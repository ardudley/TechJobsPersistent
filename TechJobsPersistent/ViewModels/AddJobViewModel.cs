﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerID { get; set; }

        public int SkillId { get; set; }
        public List<SelectListItem> Employers { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            Skills = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
                }

            foreach (var skill in skills)
            {
                Skills.Add(new SelectListItem
                    {
                        Value = skill.Id.ToString(),
                        Text = skill.Name
                    });
            }
        }


        public AddJobViewModel() { }
    }
}
