using StartBootStrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootStrap.ViewModels
{
    public class VmHome
    {
        public Setting Setting { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
