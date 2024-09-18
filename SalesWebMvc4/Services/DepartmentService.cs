using SalesWebMvc4.Data;
using SalesWebMvc4.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc4.Services
{
    public class DepartmentService
    {

            private readonly SalesWebMvc4Context _context;

            public DepartmentService(SalesWebMvc4Context context)
            {
                _context = context;
            }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        }
    }
