using StudentDATA.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDATA.DataAccess.managment;

internal class CourseTest
{

    public void Select()
    {
        using (var Context = new SampleStoreContext2())
        {
            var cour = Context.courses.ToList();


            //Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine("| cour id |    course title      | courseCode |  course description  |");
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.ResetColor();
            foreach (var c in cour)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"| {c.course_id,(-7)} | {c.course_title,(-20)} | {c.course_code,(-10)} | {c.course_description,(-20)} |");
                Console.ResetColor();
            }
            Console.WriteLine(" --------------------------------------------------------------------");
        }
    }

    public void Add()
    {
        var context = new SampleStoreContext2();
        var course = new Course
        {

            course_title = "full stack",
            course_code = "CC0032",
            course_description ="full stack developer",

            
           
        };

        context.courses.Add(course);
        context.SaveChanges();

        context.Dispose();
    }

    public void Delete()
    {
        Console.WriteLine("enter delete course id : >>  ");
        var courseIdText = Console.ReadLine();
        var courseIdToBeDeleted = int.Parse(courseIdText);

        using var context = new SampleStoreContext2();

        var cour = context.courses.FirstOrDefault(xyz => xyz.course_id == courseIdToBeDeleted);

        if (cour == null)
        {
            Console.WriteLine($"course with id = {courseIdToBeDeleted} not found");
            return;
        }

        context.courses.Remove(cour);
        context.SaveChanges();

        context.Dispose();
    }

    public void Update()
    {
        Console.WriteLine("Enter the course Id to be updated ");
        var courseIdText = Console.ReadLine();
        var courseIdToBeUpdated = int.Parse(courseIdText);

        using var context = new SampleStoreContext2();

        var cour = context.courses.FirstOrDefault(xyz => xyz.course_id == courseIdToBeUpdated);

        if (cour == null)
        {
            Console.WriteLine($"course with id = {courseIdToBeUpdated} not found");
            return;
        }

        cour.course_title = "text";
        cour.course_title =  "text";
        cour.course_description =  "text";
       

        context.courses.Update(cour);
        context.SaveChanges();
    }
}
