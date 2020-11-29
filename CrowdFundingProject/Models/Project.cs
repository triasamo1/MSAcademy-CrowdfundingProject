﻿using System;
using System.Collections.Generic;

namespace CrowdFundingProject.Models
{
    public class Project
    {
        //Primary key
        public int Id { get; set; }
        //Attributes
        public string Title { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public decimal Goal { get; set; }
        public decimal CurrentAmount { get; set; }
        public bool IsTrending { get; set; }
        public decimal Progress => CurrentAmount / Goal;
        public string EndDate { get; set; }
        public string PicturePath { get; set; }

        //Foreign Key
        public Creator Creator { get; set; }
        public List<Bundle> Bundles { get; set; }
        public List<Backer> Backers { get; set; }
        public Tag Tag { get; set; }
    }
}