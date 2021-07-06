using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesLibNS
{
    public class CoursesLibClass
    {
        public string ShowCourseName(int code)
        {
            if (code == 1234)
                return "M" + code + " - Progamiing C#";
            return "Curso não cadastrado";
        }
    }
}
