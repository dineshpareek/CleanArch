﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseImg { get; set; }
        public string CourseCode { get; set; }
        public float Credit { get; set; }
        public string Description { get; set; }
        //public int DeptId { get; set; }
        //public int SemesterId { get; set; }
    }
}
