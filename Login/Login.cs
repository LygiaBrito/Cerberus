using System;
using Login.Interface;

namespace Login
{
   public class  Login : ILogin
   {
      private string _Login = "admin";
      private string _Senha = "admin";

      public bool Logar(string login, string senha)
      {
         if (login.Equals(_Login))
         {
            if (senha.Equals(_Senha))
            {
               return true;
            } 
            return false;
         }
         return false;
      }
   }
}
