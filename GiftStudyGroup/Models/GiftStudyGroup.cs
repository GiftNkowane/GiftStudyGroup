using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiftStudyGroup.Models
{
	public class GiftStudyGroup
	{
		[Display(Name = "Student number")]
		public string StudentNum { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}