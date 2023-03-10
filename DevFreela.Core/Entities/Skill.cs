﻿namespace DevFreela.Core.Entities
{
    public class Skill : BaseEntity
    {
        public Skill(string description)
        {
            Description = description;
        }

        public string Description { get; set; }

    }
}
