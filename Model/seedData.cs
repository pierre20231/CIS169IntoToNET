using CIS169IntroToNET.Data;
using Microsoft.EntityFrameworkCore;

namespace CIS169IntroToNET.Model;

public static class seedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CIS169IntroToNETContext(serviceProvider.GetRequiredService<
                   DbContextOptions<CIS169IntroToNETContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null CIS169IntroToNET");
            }

            if (context.Course.Any())
            {
                return;
            }

            context.Course.AddRange(new Course()
                {
                   
                    CourseName = "CIS427",
                    CourseDescription = "Intro to Mobile",
                    RoomNumber = 120,
                   StartTime = new TimeOnly(7, 30),
                   EndTime = new TimeOnly(9, 30)
                },
                new Course()
                {
                    CourseName = "CIS132",
                    CourseDescription = "Java Programming",
                    RoomNumber = 120,
                    StartTime = new TimeOnly(9, 30),
                    EndTime = new TimeOnly(11, 30)
                    },

                     new Course()
                    {
                    CourseName = "CIS132",
                    CourseDescription = "Basic HTML",
                    RoomNumber = 120,
                    StartTime = new TimeOnly(7, 30),
                    EndTime = new TimeOnly(9, 30) },
                     new Course()
                     {
                    CourseName = "CIS132",
                    CourseDescription = "Intro to Programming Logic",
                    RoomNumber = 120,
                    StartTime = new TimeOnly(7, 30),
                    EndTime = new TimeOnly(8, 30) },
                     new Course()
                     {
                    CourseName = "CIS492",
                    CourseDescription = "Intro to JavaScript Prgogramming",
                    RoomNumber = 120,
                    StartTime = new TimeOnly(7, 30),
                    EndTime = new TimeOnly(9, 30) }
            );
            context.SaveChanges(); 
        }
    }
}