using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SEN_Locality_Finder.Pages.Interfaces; //for accessing CRUD methods
using SEN_Locality_Finder.Models;

namespace SEN_Locality_Finder.Pages
{
    public class IndexModel : PageModel
    {
        //[Required(ErrorMessage = "Please select one or more age range values from the provided list.")]
        public string Age_sel { get; set; }
        //[Required(ErrorMessage = "Please select one or more institutions from the provided list.")]
        public string Ins_sel { get; set; }
        //[Required(ErrorMessage = "Please enter or select a value from the list.")]
        public string Conditions_txt { get; set; }
        //[Required(ErrorMessage = "Please enter a valid postcode for your locality.")]
        public string Locality_search { get; set; }

        public void OnGet()
        {
            //can access all methods and options

            //Nurseries nurseries = new Nurseries();
            //nurseries.GetNurseries.GetAll();
            
           
        }
    }
}
