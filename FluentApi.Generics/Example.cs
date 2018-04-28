using System;
using System.Linq;
using System.Threading.Tasks;
using FluentApi.Generics.Models;

namespace FluentApi.Generics
{
    public class Example
    {
        public static void main(String[] args) 
        {
            // Enroll a student in a class
            LinkedInLearning
                .Students
                    .Select<Student>(s => s.Id == "RMILLSAP")
                    .Attach()
                .EnrollInCourses(courses => courses.Where(c => c.Subject == "ENGLISH"))
                .Apply();

            // Schedule counselor appointments
            LinkedInLearning
                .Students
                    .Select()
                        .WithoutRegistration()
                    .Attach()
                    .ScheduleAppointments(() => DaysOfWeek.Monday | DaysOfWeek.Friday)
                .Apply();

            // Send out appointment reminders
            LinkedInLearning
                .Students
                    .Select()
                        .WithTuitionDue()
                    .Attach()
                .SendReminders()
                .Apply();
                       
        }
    }
}
