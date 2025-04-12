using CS2AKeanaConsebido_MVCPROJECT.BusLogic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS2AKeanaConsebido_MVCPROJECT.BusLogic.Model;

namespace CS2AKeanaConsebido_MVCPROJECT.BusLogic.Service
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();

        public bool Add(tblStudent student)
        {
            return _studentRepository.Add(student);
        }

        public IEnumerable<tblStudent> GetAll() {
            return _studentRepository.GetAll();
        }

        public tblStudent GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public bool Update(tblStudent student)
        {
            return _studentRepository.Update(student);
        }

        public tblStudent Delete(int id) {
            return _studentRepository.Delete(id);
        }
    }
}
