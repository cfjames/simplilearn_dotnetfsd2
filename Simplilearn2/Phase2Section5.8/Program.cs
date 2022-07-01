// See https://aka.ms/new-console-template for more information

using SchoolApi;

var httpClient = new HttpClient();
var apiClient = new SchoolClient("http://localhost:5180/", httpClient);
var students = apiClient.StudentsAllAsync().Result;
var student = apiClient.Students2Async(4).Result;
StudentModel newStudent = new StudentModel() {
    Name = "test",
    Address = "test address",
    ContactEmail = "test@email.com",
    Course = "test",
    Grades = 89,
    Subjects = new List<string>(),
    StudentID = 0
};
var studentAdd = apiClient.StudentsAsync(newStudent).Result;
studentAdd.Grades = 79; 
var studentUpdate = apiClient.Students3Async(studentAdd.StudentID, studentAdd).Result;
var studentDelete = apiClient.Students4Async(studentAdd.StudentID);