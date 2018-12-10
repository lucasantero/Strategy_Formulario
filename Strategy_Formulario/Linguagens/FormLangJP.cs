using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Formulario
{
    public class FormLangJP : IFormLang
    {
        public FormLangJP()
        {
            Idade = "年齢";
            Nome = "名";
            Email = "Eメール";
            Telefone = "電話";
            Endereco = "住所";
            Idioma = "言語";
        }
        public string Idade { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Endereco { get; }
        public string Idioma { get; }
    }
}
