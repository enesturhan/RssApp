using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RssApp.Helper;
using RssApp.Models;
using RssApp.Repository;
using RssApp.Services;

namespace RssApp.Pages.News
{
    public class AddRssModel : PageModel
    {
        private readonly RssRepository _rRepo;
        private readonly NewsCreateService _newsCreateService;

  


        public AddRssModel(RssRepository rRepo,NewsCreateService newsCreateService)
        {
            _rRepo = rRepo;
            _newsCreateService = newsCreateService;

        }

        [BindProperty]
        public New NewsInput { get; set; }
 

        public string SelectedPriority{ get; set; }
      




        public IEnumerable<SelectListItem> options
        {
            get
            {
                return SelectHelper.GetItems("1", "2", "3", "4","5");
            }
        }

        public void OnGet()
        {

           

        }

        public void OnPostSave()
        {


            if (ModelState.IsValid)
            {
                _newsCreateService.CreateNews(NewsInput);
            }
        }
    }
}
