using SimpleSubjectApp.Models;
using SimpleSubjectApp.Repositories.Interface;
using System.Xml.Linq;

namespace SimpleSubjectApp.Repositories.Implementation
{
    public class SubjectRepository : SubjectRepositoryInterface
    {
        private List<Subject> _subjects;

        public SubjectRepository()
        {
            _subjects = new List<Subject>
        {
            new Subject
            {   
                Id = 0,
                Name = "Maths",
                Description = "Description for Maths",
                WeeklyClasses = 6,
                LiteratureUsed = new List<string> { "Maths Literature 1", "Maths Literature 2" }
            },
            new Subject
            {
                Id = 1,
                Name = "English",
                Description = "Description for English",
                WeeklyClasses = 3,
                LiteratureUsed = new List<string> { "English Literature 1", "English Literature 2" }
            },
            new Subject
            {
                Id = 2,
                Name = "Art",
                Description = "Description for Art",
                WeeklyClasses = 1,
                LiteratureUsed = new List<string> { "Art Literature 1", "Art Literature 2" }
            },
            new Subject
            {
                Id = 3,
                Name = "Sport",
                Description = "Description for Sport",
                WeeklyClasses = 5,
                LiteratureUsed = new List<string> { "Sport Literature 1", "Sport Literature 2" }
            },
        };
        }


        public void addSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public Subject findById(int id)
        {
            return _subjects.Find(s => s.Id.Equals(id));
        }

        public Subject findByName(string name)
        {
            
            return _subjects.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Subject> getAllSubjects()
        {
            return _subjects;
        }

        public Subject getSubjectDetails(int Id)
        {
            return _subjects.Find(s => s.Id.Equals(Id));
        }

        public void removeSubject(Subject subject)
        {
            _subjects.Remove(subject);
        }

        
    }




}
