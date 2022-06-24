using SchoolEfDAL;
namespace Phase2Section4._9.Models
{
    public class StudentListModel
    {
        public List<StudentModel> Students { get; set; }
        public List<StudentModel> StudentsFiltered { get; set; }
        public List<string> Subjects { get; set; }
    }
}
