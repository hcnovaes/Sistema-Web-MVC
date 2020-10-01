using System.Collections.Generic;


namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewMoel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
