using System;

namespace L02
{
    public class Student
    {
        public int id { get; set; }

        public string nume { get; set; }

        public string prenume { get; set; }

        public string facultate { get; set; }

        public int an_studiu { get; set; }

        public Student() { }
        public Student(int i, string num, string pre, string fac, int an)
        {
            id = i;
            nume = num;
            prenume = pre;
            facultate = fac;
            an_studiu = an;
        }
    }
}