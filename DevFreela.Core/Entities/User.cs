﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate) 
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            Skills = new List<UserSkill>();
            OwnedProjects = List<Project>();
            FreelanceProjects = List<Project>();
            CreatedAt = DateTime.Now;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }
        public List<UserSkill> Skills { get; set; }
        public List<Project> OwnedProjects { get; set; }
        public List<Project> FreelanceProjects { get; set; }
    }
}
