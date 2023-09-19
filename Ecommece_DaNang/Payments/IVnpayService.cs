using Ecommece_DaNang.Entity;

namespace Ecommece_DaNang.Payment
{
    public interface IVnpayService
    {
      public   string CreatePaymentUrl(Paymentt payment);
        
    }
}
