using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RssApp.Models;
using RssApp.Repository;
using RssApp.Services;

namespace RssApp.Pages.News
{
    public class ListNewsModel : PageModel
    {

        private readonly RssRepository _rRepo;
        private readonly NewsCreateService _newsCreateService;
        public List<SelectListItem> options { get; set; }


        public ListNewsModel(RssRepository rRepo, NewsCreateService newsCreateService)
        {
            _rRepo = rRepo;
            _newsCreateService = newsCreateService;

        }
    
        public New NewsInput { get; set; }
        public IEnumerable<New> newsList { get; set; }
        public void OnGet(string id)
        {

            newsList = _rRepo.List().OrderByDescending(x => x.Priority);

      

            options = newsList.Select(a =>
            new SelectListItem
            {
                Value = a.RssLink,
                Text = a.NewsName
            }).ToList();
        }
    }
    }
