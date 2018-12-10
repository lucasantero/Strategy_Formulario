using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Formulario
{
    public class FormLangPT : IFormLang
    {
        public FormLangPT()
        {
            Idade = "Idade";
            Nome = "Nome";
            Email = "Email";
            Telefone = "Telefone";
            Endereco = "Endereço";
            Idioma = "Idioma";
        }
        public string Idade { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Endereco { get; }
        public string Idioma { get; }
    }
}
