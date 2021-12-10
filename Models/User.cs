using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LocalAutos.Models
{



        public class User
        {

            public int UserID                     {get; set;}


            [StringLength(60, MinimumLength = 3)]       
            [Required]                                  
            public string FirstName                   {get; set;}

            
            [StringLength(30)]                          
            [Required]                                 
            public string LastName                    {get; set;}

            [StringLength(30)]                          
            [Required]                                  
            public string Location                    {get; set;}
            
            
            
            [StringLength(30)]                           
            [Required]                                  
            public string  UserName                 {get; set;}

            

            

            



        }






}