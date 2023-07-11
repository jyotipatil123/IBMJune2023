using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_IBMJune2023.Models
{
    public class Employee1
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public city city { get; set; }
        public skills skills { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool AgreeTerm { get; set; }
    }
    public enum city
    {
        Delhi,
        Mumbai,
        Kolkata,
        Channai,
        Bangalore
    }
    public enum skills
    {
        HTML5,
        CSS3,
        Bootstrap,
        JavaScript,
        JQuery,
        Angular,
        MVC,
        WebAPI
    }

}