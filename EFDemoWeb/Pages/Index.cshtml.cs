using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext context;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public void OnGet()
        {

        }

        private void LoadSampleData()
        {
            if (context.People.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");

                var people = JsonSerializer.Deserialize<List<Person>>(file);

                context.AddRange(people);
                context.SaveChanges();
            }
        }
    }
}
