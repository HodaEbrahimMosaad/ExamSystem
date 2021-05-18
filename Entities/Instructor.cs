﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class Instructor
    {
        public Instructor()
        {
            Department = new HashSet<Department>();
            InstructorCourse = new HashSet<InstructorCourse>();
        }

        [Key]
        [Column("InsID")]
        public int InsId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("degree")]
        [StringLength(50)]
        public string Degree { get; set; }
        [Column("salary")]
        public double Salary { get; set; }
        [Column("userID")]
        public int? UserId { get; set; }
        [Column("deptID")]
        public int? DeptId { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty("Instructor")]
        public virtual Department Dept { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Instructor))]
        public virtual Users User { get; set; }
        [InverseProperty("Manager")]
        public virtual ICollection<Department> Department { get; set; }
        [InverseProperty("Ins")]
        public virtual ICollection<InstructorCourse> InstructorCourse { get; set; }
    }
}