using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Helper
{
    public static class SelectHelper
    {


        public static IEnumerable<SelectListItem> GetItems(params string[] values)
        {
            var selectListItems = new List<SelectListItem>();

            foreach (var item in values)
            {
                var selectItem = new SelectListItem
                {
                    Text = item,
                    Value = item
                };

                selectListItems.Add(selectItem);
            }

            return selectListItems;
        }
    }
    }
