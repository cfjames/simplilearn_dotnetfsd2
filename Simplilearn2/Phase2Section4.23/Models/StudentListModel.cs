using SchoolEfDAL;

namespace Phase2Section4._23.Models
{
    public class StudentListModel
    {
        public List<StudentModel> FullList { get; set; }

        public List<dynamic> InnerJoin { get; set; }

        public List<dynamic> LeftJoin { get; set; }

        public List<dynamic> CrossJoin { get; set; }

        public List<dynamic> GroupJoin { get; set; }
    }
}
