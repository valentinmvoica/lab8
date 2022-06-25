using System;
using System.Collections.Generic;
using System.Text;

namespace l8
{
    class Catalog
    {
        private List<Student> listaDeStudenti = new List<Student>();

        public void AddStudent(Student student)
        {
            this.listaDeStudenti.Add(student);
        }
        public void RemoveStudentByName(string name)
        {
            Student studentDeSters = null;
            foreach(Student student in listaDeStudenti)
            {
                if (student.Nume == name)
                {
                    studentDeSters = student;
                }
            }

            if (studentDeSters!=null)
            {
                listaDeStudenti.Remove(studentDeSters);
            }
        }
        public void RemoveStudent(Student studentToRemove)
        {
            listaDeStudenti.Remove(studentToRemove);
            int index = -1;
            for (int i = 0; i < listaDeStudenti.Count; i++)
            {
                Student student = listaDeStudenti[i];
                if (studentToRemove == student)
                {
                    index = i;
                }                    
            }

            if (index >0)
            {
                this.listaDeStudenti.RemoveAt(index);
            }
        }

        public void Tipareste()
        {
   
            foreach(Student student in listaDeStudenti)
            {

            }
        }


    }
}
