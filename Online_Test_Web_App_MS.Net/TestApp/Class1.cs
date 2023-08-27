using Business_Object_Layer;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Class1
    {
       

        static void Main(string[] args)
        {
                SqlUserDatabase db = new SqlUserDatabase();
                SqlExamDatabase exam = new SqlExamDatabase();
            // String st= db.login("ramendrapandey","1234qwert");
             //  Console.WriteLine($"@@@+{st}");  
            //int x= db.regestration("saksham","xyz","sakshamxyz","12345","false");
          //  int x = exam.studentLogin(4, "ifguhv", "kjhfnv");
           //int y = exam.submitExam(1111, 654, "ADS", 33.48, 37.1);
        IDictionary<int,Exam> list= new Dictionary<int,Exam>();
            list = exam.displayLeaderboard();
            Exam exam1 = new Exam();

            foreach (var item in list)
            {
                //  Console.WriteLine(item.Value.id + item.Value.sessionId + item.Value.studentFirstName+item.Value.studentLastName+item.Value.subject + item.Value.marks+item.Value.percentage);
                item.Value.print();
            }
        }
    }
}
