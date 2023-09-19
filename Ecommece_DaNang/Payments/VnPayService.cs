using Ecommece_DaNang.Entity;
using Ecommece_DaNang.Payments;

namespace Ecommece_DaNang.Payment
{
    public class VnPayService : IVnpayService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;

        public VnPayService(IConfiguration configuration, IHttpContextAccessor contextAccessor)
        {
            _configuration = configuration;
            _contextAccessor = contextAccessor;
        }
        public string CreatePaymentUrl(Paymentt payment)
        {
            HttpContext context = _contextAccessor.HttpContext;


            var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["TimeZoneId"]);
            var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
            var tick = DateTime.Now.Ticks.ToString();
            var pay = new VnPayLibrary();
            var urlCallBack = $"{_configuration["VnPay:CallbackUrl"]}/{payment.PaymentId}";

            pay.Addrequestdata("vnp_Version", _configuration["Vnpay:Version"]);
            pay.Addrequestdata("vnp_Command", _configuration["Vnpay:Command"]);
            pay.Addrequestdata("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
            pay.Addrequestdata("vnp_Amount", ((int)payment.Amount * 100).ToString());
            pay.Addrequestdata("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
            pay.Addrequestdata("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
            pay.Addrequestdata("vnp_IpAddr", pay.GetIPAddress(context));
            pay.Addrequestdata("vnp_Locale", _configuration["Vnpay:Locale"]);
            pay.Addrequestdata("vnp_OrderInfo", $"Thanh toan hoa don {payment.Amount}");
            pay.Addrequestdata("vnp_OrderType", payment.Method);
            pay.Addrequestdata("vnp_ReturnUrl", urlCallBack);
            pay.Addrequestdata("vnp_TxnRef", tick);

            var paymentUrl =
                pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);

            return paymentUrl;
        }
    }
}
