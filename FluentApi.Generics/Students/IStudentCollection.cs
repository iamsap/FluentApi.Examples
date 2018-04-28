using System;
using System.Collections.Generic;
using FluentApi.Generics.Framework;
using FluentApi.Generics.Models;

namespace FluentApi.Generics.Students
{
    public interface IStudentCollection : IAttachable<ISelectStudents>
    {
        IApplyable EnrollInCourses(Func<IList<Course>, IEnumerable<Course>> func);
        IApplyable ScheduleAppointments(Func<DaysOfWeek> func);
        IApplyable SendReminders();
    }
}
