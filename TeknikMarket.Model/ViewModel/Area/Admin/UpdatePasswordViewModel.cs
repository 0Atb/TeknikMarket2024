using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikMarket.Model.ViewModel.Area.Admin
{
    public class UpdatePasswordViewModel
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UniqueId { get; set; }
    }
}
