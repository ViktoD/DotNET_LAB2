using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class StudentEnumerator: Student, IEnumerator
    {
        private ArrayList? _nameExams;
        private ArrayList? _nameTests;
        private ArrayList? _result;
        private int position = -1;
    

        public StudentEnumerator(ArrayList nameExams, ArrayList nameTests)
        {

            _nameExams = nameExams;
            _nameTests = nameTests;
            _result = new ArrayList();
        }
        public object? Current
        {
            get
            {
                if(position == -1 || position >= _nameExams?.Count)
                {
                    throw new ArgumentException();
                }
              
                foreach (string nameExam in _nameExams)
                    {
                        foreach (string nameTest in _nameTests)
                        {
                            if (nameExam == nameTest)
                            {
                                _result?.Add(nameExam);
                            }
                        }
                    }
                _nameExams.Clear();
                _nameExams = _result;
                return _nameExams[position];
            }
        }

        public bool MoveNext()
        {
            if (position < _nameExams?.Count - 1)
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
