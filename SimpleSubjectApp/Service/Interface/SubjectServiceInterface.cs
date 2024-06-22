using SimpleSubjectApp.Models;

namespace SimpleSubjectApp.Service.Interface
{
    public interface SubjectServiceInterface
    {
        List<Subject> getAllSubjects();
        Subject getSubjectDetails(int Id);
        void addSubject(Subject subject);
        void removeSubject(Subject subject);
    }
}
