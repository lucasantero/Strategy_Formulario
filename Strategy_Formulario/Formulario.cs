using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Formulario
{
    public class Formulario
    {
        public string Nome { get; }
        public string Idade { get; }
        public string Email { get; }
        public string Telefone { get; }
        public string Endereco { get; }
        private string _Idioma;
        public string Idioma
        {
            get
            {
                return _Idioma;
            }
            set
            {
                _Idioma = value;
                switch (_Idioma)
                {
                    case ("PT"):
                        EstrategiaIdioma = new FormLangPT();
                        break;
                    case ("EN"):
                        EstrategiaIdioma = new FormLangEN();
                        break;
                    case ("JP"):
                        EstrategiaIdioma = new FormLangJP();
                        break;
                    case ("GER"):
                        EstrategiaIdioma = new FormLangGER();
                        break;
                    default:
                        throw new Exception("Idioma indisponível");
                }
            }
        }
        public IFormLang EstrategiaIdioma { get; protected set; }

        public Formulario(string idioma)
        {
            _Idioma = idioma;
        }

        public static List<string> GetLinguagens()
        {
            List<string> listaLinguagens = new List<string>();
            listaLinguagens.Add("PT");
            listaLinguagens.Add("EN");
            listaLinguagens.Add("JP");
            listaLinguagens.Add("GER");
            return listaLinguagens;
        }

        

    }
}
