using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Core.Models
{
    public class ProductCategory
    {
        public string Id { get; set; }
        public string Category { get; set; }

        public ProductCategory()
        {
            this.Id = Guid.NewGuid().ToString();
        }



    }


}
