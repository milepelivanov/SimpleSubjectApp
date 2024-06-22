using SimpleSubjectApp.Models;

namespace SimpleSubjectApp.Repositories.Interface
{
    public interface SubjectRepositoryInterface
    {
        List<Subject> getAllSubjects();
        Subject getSubjectDetails(int Id);
        Subject findById(int  id);
        void addSubject(Subject subject);
        void removeSubject(Subject subject );
        Subject findByName(String name);
    }
}
