using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte numberOfCredits;

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
        public string CourseName { get; set; }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits 
        { 
            get { return numberOfCredits; } 
            set { ValidateNumCredits(value, numberOfCredits); }
        }

        private void ValidateNumCredits(byte c, byte credits)
        {
            if(c < 0 || c > 30)
            {
                throw new ArgumentException("Credits should be between 0 and 30");
            }
            credits = c;
        }

    }
}
