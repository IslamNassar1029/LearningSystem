using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities;

public class Course
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public int InstructorId { get; set; }
    public int Duration { get; set; }
    public string Name { get; set; }
    public Instructor Instructor { get; set; }

    public Department Department { get; set; }



}
