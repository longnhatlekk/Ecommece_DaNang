using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace Ecommece_DaNang.Payments
{
    public class VnPayLibrary
    {
        private readonly SortedList<string, string> _requestdata = new SortedList<string, string>(new VnPayCompare());
        private readonly SortedList<string, string> _responsedata = new SortedList<string, string>(new VnPayCompare());


        public string GetIPAddress(HttpContext context)
        {
            var ipadress = string.Empty;
            try
            {

                var ipadressremove = context.Connection.RemoteIpAddress;
                if (ipadressremove != null)
                {
                    if (ipadressremove.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        ipadressremove = Dns.GetHostEntry(ipadressremove).AddressList
                            .FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork);

                    }
                    if (ipadressremove != null) ipadress = ipadressremove.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "127.0.0.1";

        }
        public void Addrequestdata(string key, string value)
        {
            if(!string.IsNullOrEmpty(value))
            {
                  _requestdata.Add(key, value);
            }
        }
        public void Addresponsedat(string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _responsedata.Add(key, value);
            }
        }
        public string GetResponseData(string key)
        {
            return _responsedata.TryGetValue(key, out var retvalue) ? retvalue : string.Empty;
        }
        public string CreateRequestUrl(string baseUrl, string vnpHashSecret)
        {
            var data = new StringBuilder();

            foreach (var (key, value) in _requestdata.Where(kv => !string.IsNullOrEmpty(kv.Value)))
            {
                data.Append(WebUtility.UrlEncode(key) + "=" + WebUtility.UrlEncode(value) + "&");
            }

            var querystring = data.ToString();

            baseUrl += "?" + querystring;
            var signData = querystring;
            if (signData.Length > 0)
            {
                signData = signData.Remove(data.Length - 1, 1);
            }

            var vnpSecureHash = HmacSha512(vnpHashSecret, signData);
            baseUrl += "vnp_SecureHash=" + vnpSecureHash;

            return baseUrl;
        }

        public bool ValidateSignature(string inputHash, string secretKey)
        {
            var rspRaw = GetResponseData();
            var myChecksum = HmacSha512(secretKey, rspRaw);
            return myChecksum.Equals(inputHash, StringComparison.InvariantCultureIgnoreCase);
        }

        private string HmacSha512(string key, string inputData)
        {
            var hash = new StringBuilder();
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var inputBytes = Encoding.UTF8.GetBytes(inputData);
            using (var hmac = new HMACSHA512(keyBytes))
            {
                var hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }

            return hash.ToString();
        }

        private string GetResponseData()
        {
            var data = new StringBuilder();
            if (_responsedata.ContainsKey("vnp_SecureHashType"))
            {
                _responsedata.Remove("vnp_SecureHashType");
            }

            if (_responsedata.ContainsKey("vnp_SecureHash"))
            {
                _responsedata.Remove("vnp_SecureHash");
            }

            foreach (var (key, value) in _responsedata.Where(kv => !string.IsNullOrEmpty(kv.Value)))
            {
                data.Append(WebUtility.UrlEncode(key) + "=" + WebUtility.UrlEncode(value) + "&");
            }

            //remove last '&'
            if (data.Length > 0)
            {
                data.Remove(data.Length - 1, 1);
            }

            return data.ToString();
        }
    }
   
}
public class VnPayCompare : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x == null || y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        var vnpCompare = CompareInfo.GetCompareInfo("en-US");
        return vnpCompare.Compare(x, y, CompareOptions.Ordinal);
    }
}
    
