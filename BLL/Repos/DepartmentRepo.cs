using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Data.CompanyDbContext;
using DAL.Models;

namespace BLL.Repos
{
    public class DepartmentRepo : IDepratmentRepo
    {
        private readonly CompanyDbContext _companyDbContext;
        public DepartmentRepo()
        {
            _companyDbContext = new CompanyDbContext();
        }
        public IEnumerable<Department> GetAll()
        {
            return _companyDbContext.Departments.ToList();
        }

        public Department? Get(int id)
        {
            return _companyDbContext.Departments.Find(id);
        }

        public int Add(Department model)
        {
            _companyDbContext.Departments.Add(model);
            return _companyDbContext.SaveChanges();

        }

        public int Update(Department model)
        {
            _companyDbContext.Departments.Update(model);
            return _companyDbContext.SaveChanges();
        }

        public int Delete(Department model)
        {
            _companyDbContext.Departments.Remove(model);
            return _companyDbContext.SaveChanges();
        }
       
    }
}
