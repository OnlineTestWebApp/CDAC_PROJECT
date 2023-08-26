using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object_Layer
{
    public class Exam
    {
        public int sessionId { get; set; }

        public int id { get; set; }

        public string studentName { get; set; }

        public string subject { get; set; }

        public decimal marks { get; set; }

        public decimal percentage { get; set; }
    }
}
