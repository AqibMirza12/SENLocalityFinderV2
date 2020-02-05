using System;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using SEN_Locality_Finder.Pages.Interfaces;
using SEN_Locality_Finder.Models;
using SEN_Locality_Finder.Primary;
using System.Diagnostics;


namespace SEN_Locality_Finder.Pages
{
    
    public class SearchConfirmationPageModel : PageModel
    {

        //[Required(ErrorMessage = "Please select one or more age range values from the provided list.")]
        [BindProperty]
        public string Age_sel { get; set; }
        //[Required(ErrorMessage = "Please select one or more institutions from the provided list.")]
        [BindProperty]
        public string Ins_sel { get; set; }
        //[Required(ErrorMessage = "Please enter or select a value from the list.")]
        [BindProperty]
        public string Conditions_txt { get; set; }
        //[Required(ErrorMessage = "Please enter a valid postcode for your locality.")]
        [BindProperty]
        public string Locality_search { get; set; }

        //public void Page_Load(object sender, EventArgs e)
        //{
        //    //string barny = Http.QueryString["age_sel"];
        //    //string fred = Request.QueryString["age_sel"];
        //   Console.WriteLine(RouteData.Values["Age_sel"]);

        //    //Academies academies = new Academies();
        //    //academies.GetAcademies.GetSingle(); //does not return error, unlike GetAll()

        //}

        


    public Institution Ins { get; set; }
       
        public SearchConfirmationPageModel()
        {
            //Ins = new Institution();
            //Academies a = new Academies();
            //Ins.academies = a.GetAll(); //works

            //Nurseries n = new Nurseries();
            //Ins.Nurseries = n.GetAll(); //works

            //SEN ss = new SEN();
            //Ins.SEN_Conditions = ss.GetAll(); //works

            //SpecialSchools ps = new SpecialSchools();
            //Ins.special_schools = ps.GetAll(); //works

            //alternative method to open data for html files, also escapes data
            /*Process.Start("Chrome", Uri.EscapeDataString(@"C:/Users/qibsm/Desktop/HTML/Colleges.html"));*/ //returns error

            //ISecondaryRepo<Secondary_School> secondaryRepo = new Models.Secondary();
            //secondaryRepo.GetAll();
            
            
        }



        public void OnPost()
        {
            //Console.WriteLine(Locality_search);
            Console.WriteLine(Age_sel);
            Console.WriteLine(Ins_sel);
            Console.WriteLine(Conditions_txt);
           

        }
    }
}