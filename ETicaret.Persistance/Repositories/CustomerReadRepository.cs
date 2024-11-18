using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(DbContext context) : base(context)
        {
        }
    }
}
