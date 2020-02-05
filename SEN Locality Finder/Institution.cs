using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEN_Locality_Finder
{
    public class Institution
    {
        
        public List<Academy> academies = new List<Academy>(); //implemented
        public List<College> colleges = new List<College>(); //implemented 
        public List<Nursery> Nurseries = new List<Nursery>(); //implemented through http://convertcsv.com/csv-to-html.htm
        public List<Primary_School> primary_schools = new List<Primary_School>(); //implemented
        public List<PRU> PRU = new List<PRU>(); //implemented through http://convertcsv.com/csv-to-html.htm
        public List<Secondary_School> secondary_schools = new List<Secondary_School>(); //implemented
        public List<Special_School> special_schools = new List<Special_School>(); //implemented
        public List<SEN_Condition> SEN_Conditions = new List<SEN_Condition>(); //implemented
    }


    public class Academy
    {
        [Key]
        public int Academy_ID { get; set; }
        public int Provider_URN { get; set; }
        public string Provider_Name { get; set; }
        public string Provider_Type { get; set; }
        public string Provider_Group { get; set; }
        public string Web_link { get; set; }
    }

    public class College
    {
        [Key]
        public int College_ID { get; set; }
        public int Provider_URN { get; set; }
        public string Provider_Name { get; set; }
        public string Provider_Type { get; set; }
        public string Provider_Group { get; set; }
        public string Web_link { get; set; }
    }

    public class Nursery
    {
        [Key]
        public int Nursery_ID { get; set; }
        public string Nursery_name { get; set; }
        public string Ofsted_region { get; set; }
        public string Local_authority { get; set; }
        public string Postcode { get; set; }
        public int? Total_number_of_pupils { get; set; }
        public string Web_link { get; set; }
    }

    public class Primary_School
    {
        [Key]
        public int Primary_School_ID { get; set; }
        public string Primary_School_name { get; set; }
        public string Ofsted_region { get; set; }
        public string Local_authority { get; set; }
        public string Postcode { get; set; }
        public int? Total_number_of_pupils { get; set; }
        public string Web_Link { get; set; }
    }

    public class PRU
    {
        [Key]
        public int PRU_ID { get; set; }
        public string PRU_name { get; set; }
        public string Ofsted_region { get; set; }
        public string Local_authority { get; set; }
        public string Postcode { get; set; }
        public int? Total_number_of_pupils { get; set; }
        public string Web_Link { get; set; }
    }

    public class Secondary_School
    {
        [Key]
        public int Secondary_School_ID { get; set; }
        public string Secondary_School_Name { get; set; }
        public string Ofsted_region { get; set; }
        public string Local_authority { get; set; }
        public string Postcode { get; set; }
        public int? Total_number_of_pupils { get; set; }
        public string Web_Link { get; set; }
    }

    public class Special_School
    {
        [Key]
        public int Special_School_ID { get; set; }
        public string Special_School_name { get; set; }
        public string Ofsted_region { get; set; }
        public string Local_authority { get; set; }
        public string Postcode { get; set; }
        public int? Total_number_of_pupils { get; set; }
        public string Web_Link { get; set; }
    }

    public class SEN_Condition
    {
        [Key]
        public int Condition_ID { get; set; }
        public string Condition_Name { get; set; }
    }
}