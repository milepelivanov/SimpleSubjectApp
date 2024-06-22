using SimpleSubjectApp.Models;
using SimpleSubjectApp.Service.Interface;
using SimpleSubjectApp.Repositories.Interface;

namespace SimpleSubjectApp.Service.Implementation
{
    public class SubjectService : SubjectServiceInterface
    {
        private readonly SubjectRepositoryInterface _repositoryInterface;

        public SubjectService(SubjectRepositoryInterface repositoryInterface)
        {
            _repositoryInterface = repositoryInterface;
        }

        public void addSubject(Subject subject)
        {
            var test = _repositoryInterface.findByName(subject.Name);
          
            if (test == null)
            {
                _repositoryInterface.addSubject(subject);
            }
        }

        public List<Subject> getAllSubjects()
        {
            return _repositoryInterface.getAllSubjects();
        }

        public Subject getSubjectDetails(int Id)
        {
            var test = _repositoryInterface.findById(Id);
            if(test!=null)
            {
                return _repositoryInterface.getSubjectDetails(Id);
            }
            else
            {
                return null;
            }
        }

        public void removeSubject(Subject subject)
        {
            var test = _repositoryInterface.findById(subject.Id);

            if( test!=null )
            {
                _repositoryInterface.removeSubject(subject);
            }
        }
    }
}
