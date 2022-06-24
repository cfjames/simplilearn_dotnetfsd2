using SchoolEfDAL;

namespace Phase2Section4._15.Models
{
    public class StudentListModel
    {
        public List<StudentModel> FullList { get; set; }
        public List<StudentModel> TakeList { get; set; }
        public List<StudentModel> TakeWhileList { get; set; }
        public List<StudentModel> SkipList { get; set; }
        public List<StudentModel> SkipWhileList { get; set; }
    }
}
