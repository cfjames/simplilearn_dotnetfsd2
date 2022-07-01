using SchoolEfDAL;

namespace Phase2Section4._21.Models
{
    public class StudentListModel
    {
        public List<StudentModel> FullList { get; set; }

        public IEnumerable<IGrouping<int, StudentModel>> GroupedList { get; set; }
    }
}
