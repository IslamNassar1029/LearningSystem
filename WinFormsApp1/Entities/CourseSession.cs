﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities;

public class CourseSession
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public DateOnly  Date { get; set; }
    public string Title { get; set; }

    public Instructor Instructor { get; set; }

    public Course Course { get; set; }
}
