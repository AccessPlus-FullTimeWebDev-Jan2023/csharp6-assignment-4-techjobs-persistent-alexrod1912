using System;
using TechJobs6Persistent.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace TechJobs6Persistent.ViewModels

	
{
	public class AddJobViewModel
	{
		[Required (ErrorMessage ="Name is required") ]
		public string? jobName { get; set; }
		public int? Id { get; set; }
		public List<SelectListItem>? Employers { get; set; }
        

		public AddJobViewModel(List<Employer> possibleEmployer)
		{
            Employers = new List<SelectListItem>();
            foreach (var employer in possibleEmployer)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

           
        }

        public AddJobViewModel()
        {
        }
    }
}

