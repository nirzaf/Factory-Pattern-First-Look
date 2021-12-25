namespace Factory_Pattern_First_Look.Business.Models.Commerce
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
    }
}