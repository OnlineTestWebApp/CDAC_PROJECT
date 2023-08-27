using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    internal class Login
    {
        SqlUserDatabase _db;
        SqlExamDatabase _examDb;
        public Boolean loginConfirmation(String username, String password) 
        {
            String privilege = _db.login(username, password);
            
            if (privilege.Equals("true") || privilege.Equals("false")) 
            {
               return true;
            }
         
            else { return false; }  
        }

        public void regestration (int id,String firstName,String lastName,String username, String password,String privilege) 
        {
            _db.regestration(firstName,lastName,username,password,privilege);
            _examDb.studentLogin(id, firstName, lastName);
        }

    }
}
