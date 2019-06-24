using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace recipeBox.Models
{
    public class Ingrediants
    {
        [Key]
        public int IngrediantId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Temp { get; set; }
        
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}