namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string Disctrict { get; set; }
        public int ProductCategory { get; set; }
        public int EmployeeID { get; set; }
    }
}
