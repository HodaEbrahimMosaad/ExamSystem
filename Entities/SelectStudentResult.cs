﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamSystem.Entities
{
    public partial class SelectStudentResult
    {
        public int studentID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public int? deptID { get; set; }
        public int? userID { get; set; }
    }
}
