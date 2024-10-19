namespace RealEstateApp.Api.Entity
{
    public class SavePropertyFilter
    {
        public int Id { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int CurrencyTypeId { get; set; }
        public int PropertyTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime AppliedDateTime { get; set; } = DateTime.Now;
        public int UserId { get; set; }
    }

}
