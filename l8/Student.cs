using System;
using System.Collections.Generic;
using System.Text;

namespace l8
{
    class Student
    {
        private string nume;
        public Student(string nume)
        {
            this.nume = nume;
        }

        public string Nume { get { return this.nume; } }
        public void Tipareste() { 
        }
    }
}
