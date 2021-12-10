using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LocalAutos.Models
{



        public class Automobiles
        {

            public int AutomobilesID                        {get; set;}


            [StringLength(60, MinimumLength = 3)]       
            [Required]                                  
            public string Make                              {get; set;}

            [StringLength(30)]                          
            [Required]                                  
            public string AutoLocation                          {get; set;}

            [Display(Name = "Year")]   
                                       
            public String YearMade                        {get; set;}
            
            [StringLength(30)]                          
            [Required]                                 
            public string Model                             {get; set;}
            
            [Range(1,1000000)]                              
            [DataType(DataType.Currency)]               
            public decimal Price                            {get; set;}
            
            [StringLength(5)]                           
            [Required]                                  
            public string  SaleTrade                        {get; set;}

            public int UserID                                {get; set;}

            



        }






}