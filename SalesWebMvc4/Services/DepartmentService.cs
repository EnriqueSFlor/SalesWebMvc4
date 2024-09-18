using SalesWebMvc4.Data;
using SalesWebMvc4.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc4.Services
{
    public class DepartmentService
    {

            private readonly SalesWebMvc4Context _context;

            public DepartmentService(SalesWebMvc4Context context)
            {
                _context = context;
            }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        }
    }
