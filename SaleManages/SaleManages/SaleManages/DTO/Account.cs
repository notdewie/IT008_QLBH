using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManages.DTO
{
    class Account
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegDate { get; set; }
        public bool status { get; set; }
        public Account() { }
    }


}

