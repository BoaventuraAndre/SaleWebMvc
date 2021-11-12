using SalesWebMvc1.Data;
using System.Linq;
using System.Collections.Generic;
using SalesWebMvc1.Models;


namespace SalesWebMvc1.Services
{
    public class DepartmentServices
    {
        private readonly SalesWebMvc1Context _context;

        public DepartmentServices (SalesWebMvc1Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x=> x.Name).ToList();
        }


    }
}
