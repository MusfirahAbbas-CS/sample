using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.BL;
using App.DL;
using App.UI;
namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            int logo;
            
            int option;

            
            
            do
            {
                Console.Clear();
                logo = UserUI.logoPrint();
                option = UserUI.menu();
                UserBL user = new UserBL();
                if (option==2)
                {
                    
                    user = UserUI.AddUser();
                    if(UserDL.add(user))
                    {
                        UserUI.SignupSuccess();
                    }
                }
                if(option==1)
                {
                    user=UserUI.SignIn();
                    if(UserBL.SignupRole(user)=="Admin")
                    {
                        Console.Clear();
                        int adminchoice=UserUI.AdminMenu();
                        if(adminchoice==1)
                        {
                            int regOption=UserUI.Regmenu();
                            if(regOption==1)
                            {
                                string output = UserUI.AddStudent();
                                Console.Clear();
                            }

                            
                        }
                    }
                }
            }
            while (option < 3);
        }
    }
}
