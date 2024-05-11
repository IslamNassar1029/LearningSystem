using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities;

public class Department
{
    public string Name { get; set; }

    public string Location { get; set; }

    public List<Instructor> Instructers { get; set; }
    public List<Course> Courses { get; set; }


}
