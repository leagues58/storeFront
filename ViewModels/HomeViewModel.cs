using StoreFront.Models;
using System.Collections.Generic;

namespace StoreFront.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Product> Products { get; set; }
    }
}
