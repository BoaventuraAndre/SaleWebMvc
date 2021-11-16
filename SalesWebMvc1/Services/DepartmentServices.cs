using SalesWebMvc1.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWebMvc1.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc1.Services
{
    public class DepartmentServices
    {
        private readonly SalesWebMvc1Context _context;

        public DepartmentServices (SalesWebMvc1Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x=> x.Name).ToListAsync();
        }


    }
}
