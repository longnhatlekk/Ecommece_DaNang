﻿using Microsoft.AspNetCore.Mvc;

namespace Ecommece_DaNang.Payments
{
    public class VnpayPaymentCallback
    {
        [FromQuery(Name = "vnp_TransactionStatus")]
        public string? TransactionStatus { get; set; }

        [FromQuery(Name = "vnp_TransactionNo")]
        public string? TransactionNo { get; set; }

        [FromQuery(Name = "vnp_TxnRef")]
        public string? TransactionCode { get; set; }

        [FromQuery(Name = "vnp_ResponseCode")]
        public string? ResponseCode { get; set; }

        [FromQuery(Name = "vnp_OrderInfo")]
        public string? OrderInfo { get; set; }

        public bool Success => "00".Equals(ResponseCode);
    }
}
