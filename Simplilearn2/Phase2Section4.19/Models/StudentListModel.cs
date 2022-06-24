using SchoolEfDAL;

namespace Phase2Section4._19.Models
{
    public class StudentListModel
    {
        public List<StudentModel> FullList { get; set; }
        public StudentModel FirstStudent { get; set; }
        public StudentModel LastStudent { get; set; }
        public StudentModel ThirdStudent { get; set; }
        public StudentModel FirstWith90Percent { get; set; }
        public IEnumerable<StudentModel> EmptyList { get; set; }
    }
}
