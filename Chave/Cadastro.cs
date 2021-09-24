using System;
using Chave.Interface;

namespace Chave 
{
    public class Cadastro: ICadastro
    {
        public bool Cadastrar(string descricao, string login, string senha)
        {
            if (descricao.IsNullOrEmpty(textBox1.Text))
            {
                if (login.IsNullOrEmpty(textBox1.Text))
                {
                    if (senha.IsNullOrEmpty(textBox1.Text))
                    {
                    return false;
                    } 
                    return false;
                }
                return false;
            }
             return true;
        }
    }
}
