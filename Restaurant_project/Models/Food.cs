using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_project.Models
{
    public class Food
    {
        //work with DB
        public virtual int FoodId { get; set; }

        public virtual string Foodname { get; set; }
    }
}