using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class BrandFormViewModel
    {
        public BrandViewModel Brand { get; set; }   
        public List<string> CountryList { get; set; }   
    }
}
