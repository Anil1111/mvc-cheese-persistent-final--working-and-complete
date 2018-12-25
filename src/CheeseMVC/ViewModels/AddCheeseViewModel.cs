using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required (ErrorMessage = "You must give your cheese a name. Please reset form")]
        [Display(Name = "Category")]
        public string Name { get; set; }

        public int CategoryID { get; set; }
        public List<SelectListItem> Categories { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description.Please reset form")]
        public string Description { get; set; }

        
        public AddCheeseViewModel() { }
       

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {

            Categories = new List<SelectListItem>();

            foreach (var category in categories)
            {

                Categories.Add(new SelectListItem
                {
                    Value = category.ID.ToString(),
                    Text = category.Name
                });
            }
         }
    }
}


           
        