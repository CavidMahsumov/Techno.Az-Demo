using E_Commerce.Persistence.Contexts;
using E_CommerceAPI.Application.Repositories;
using E_CommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistence.Repositories
{
    public class CategoryWriteRepository :WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(ECommerceDbContext context):base(context) { }

    }
}
