using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class StudentEnumerator: IEnumerator
    {
        private string[] _nameSubjects;
        private int position = -1;

        public StudentEnumerator(string[] nameSubjects)
        {
            _nameSubjects = nameSubjects;
        }
    
        public object Current
        {
            get
            {
                if(position == -1 || position >= _nameSubjects.Length)
                {
                    throw new ArgumentException();
                }
                return _nameSubjects[position];
            }
        }

        public bool MoveNext()
        {
            if (position < _nameSubjects.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }
    }
       
}
