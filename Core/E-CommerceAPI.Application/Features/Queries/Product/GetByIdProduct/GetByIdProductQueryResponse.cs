using E_CommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Features.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryResponse
    {
        public Domain.Entities.Product Product { get; set; }
        //public Guid CategoryId { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public string VendorName { get; set; }
        //public int Stock { get; set; }
        //public float Price { get; set; }
        //public string ProductImagePath { get; set; }

    }
}
