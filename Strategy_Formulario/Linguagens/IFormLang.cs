using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Formulario
{
    public interface IFormLang
    {
        string Nome { get;}
        string Idade{ get; }
        string Email { get; }
        string Telefone { get; }
        string Endereco { get; }
        string Idioma { get; }
    }
}
