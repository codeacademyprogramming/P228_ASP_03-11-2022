using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int AviableSeat { get; set; }
        public string Schedule { get; set; }
        public string Image { get; set; }

        public int CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }
        public Nullable<int> TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
