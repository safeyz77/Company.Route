﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IDepratmentRepo
    {
        IEnumerable<Department> GetAll();

        Department? Get(int id);

        int Add(Department model);
        int Update(Department model);
        int Delete(Department model);

        
    }
}
