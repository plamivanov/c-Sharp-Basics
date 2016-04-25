﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Einumerable;

namespace CompanyHierarchy.Interfaces
{
    public interface IEmployee:IPerson
    {
         decimal Salary { get; set; }
         Departments Department { get; set; }
    }
}
