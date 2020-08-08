using System;
using System.ComponentModel.DataAnnotations;

namespace Receipes.Models
{
    public class Recipe
    {
        [Required(ErrorMessage ="Please Add Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Add Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Add Ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please Add Chef Name")]
        public string Chef { get; set; }
        [Required(ErrorMessage = "Please Add Cooking Time")]
        public string Time { get; set; }

        //public Recipe()
        //{
        //}
    }
}
