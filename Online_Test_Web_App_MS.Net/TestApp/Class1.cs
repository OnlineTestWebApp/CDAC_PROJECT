﻿using Business_Object_Layer;
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


          

            //List<Questions> questions = QuestionBank.GetQuestions();

            //foreach (Questions question in questions)
            //{
            //    Console.WriteLine(question.question);
            //}
            SqlUserDatabase sqlUserDatabase = new SqlUserDatabase();
            String st = sqlUserDatabase.login("ramendrapandey", "1234qwert");
            Console.WriteLine(st);
        }
    }

}