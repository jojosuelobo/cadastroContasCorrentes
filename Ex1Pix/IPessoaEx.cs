using System;
namespace Ex1Pix
{
    public interface IPessoaEx
    {
        public string nome{get; set;}
        public string sobrenome{get; set;}
        public bool validarDados(string x);
    }
}