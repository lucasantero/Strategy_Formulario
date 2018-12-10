using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Formulario
{
    public class FormLangGER : IFormLang
    {
        public FormLangGER()
        {
            Idade = "Alter";
            Nome = "Name";
            Email = "Email";
            Telefone = "Telefon";
            Endereco = "Anschrift";
            Idioma = "Sprache";
        }
        public string Idade { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Endereco { get; }
        public string Idioma { get; }
    }
}
