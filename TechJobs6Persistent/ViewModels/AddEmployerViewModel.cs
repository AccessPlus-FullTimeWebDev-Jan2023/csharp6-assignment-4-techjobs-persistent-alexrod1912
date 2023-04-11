using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
	public class AddEmployerViewModel
	{
		[Required (ErrorMessage ="Name is required")]
		public string? name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string? location { get; set;  }

		public AddEmployerViewModel()
		{
		}
	}
}

