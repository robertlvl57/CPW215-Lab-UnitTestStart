using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte numberOfCredits;
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => courseName;
            set => ValidateCourseName(value);
        }

        private void ValidateCourseName(string course)
        {
            if (course == null)
            {
                throw new ArgumentNullException();
            }
            courseName = course;
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set => ValidateNumCredits(value);
        }

        private void ValidateNumCredits(byte c)
        {
            if (c <= 0 || c >= 30)
            {
                throw new ArgumentException("Credits should be less than 30");
            }
            numberOfCredits = c;
        }

    }
}
