using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvcapp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }= string.Empty;
        public string Password{ get; set; }=string.Empty;

        public string Email{get;set;}=string.Empty;
        
    }
}