using System;
using Chave;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {//xpto
            Login Usuario = new Login(); //Usuario e o objeto instanciado, uma variavel local.
            Console.WriteLine("Bem vindo ao Cerberus!");
            Console.WriteLine("Login: ");
            string username = Console.ReadLine(); //Username e uma variavel local usada para armazenar o login.
            Console.WriteLine("Senha: ");
            string password = Console.ReadLine(); //Username e uma variavel local usada para armazenar a senha.
            
            if(Usuario.Logar(username, password))
            { //Variavel local.Metodo logar(login e senha locais).
                Console.WriteLine("logado");
            }else{
                Console.WriteLine("Usuario ou senha incorretos. Tente npvamente.");
            }

            Cadastro Chave1 = new Cadastro();
            Console.WriteLine("Para iniciar o cadastro informe os dados solictados.");
            Console.WriteLine("Descricao: ");
            string Descricao = Console.ReadLine(); //Username e uma variavel local usada para armazenar o descricao.
            Console.WriteLine("Login: ");
            string Login = Console.ReadLine(); //Username e uma variavel local usada para armazenar a login.
            Console.WriteLine("Senha: ");
            string Senha = Console.ReadLine(); //Username e uma variavel local usada para armazenar a senha.

            if(Chave1.Logar(Descricao, Login, Senha))
            { //Variavel local.Metodo logar(login e senha locais).
                Console.WriteLine("Cadastrado");
            }else{
                Console.WriteLine("Cadastro nao realizado, verifique as informacoes e tente novamente.");
            }
        }
    }
}
