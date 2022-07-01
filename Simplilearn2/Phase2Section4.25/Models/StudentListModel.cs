using SchoolEfDAL;

namespace Phase2Section4._25.Models
{
    public class StudentListModel
    {
        public List<StudentModel> FullList { get; set; }

        public List<StudentModel> UnionList { get; set; }

        public List<StudentModel> IntersectList { get; set; }

        public List<dynamic> DistinctList { get; set; }

        public List<StudentModel> ExceptList { get; set; }
    }
}
