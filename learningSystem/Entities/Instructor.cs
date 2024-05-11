using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities;

public class Instructor
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public int? HeadedBy { get; set; }
    public string Phone { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Instructor Headed { get; set; }
    public List<Instructor> Instructors { get; set; }
    
    public Department Department { get; set; }

    public List<Course> Courses { get; set; }


}
