using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Formulario
{
    public partial class Form1 : Form
    {
        Formulario form;
        public void AtualizarLabels()
        {
            LblNome.Text = form.EstrategiaIdioma.Nome;
            LblIdade.Text = form.EstrategiaIdioma.Idade;
            LblTelefone.Text = form.EstrategiaIdioma.Telefone;
            LblEmail.Text = form.EstrategiaIdioma.Email;
            LblEndereco.Text = form.EstrategiaIdioma.Endereco;
            LblIdioma.Text = form.EstrategiaIdioma.Idioma;
        }
        public Form1()
        {
            InitializeComponent();
            form = new Formulario("PT");
            CmbIdioma.DataSource = Formulario.GetLinguagens();
            AtualizarLabels();
        }

        private void CmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbIdioma.SelectedItem != null)
            {
                form.Idioma = (string)(CmbIdioma.SelectedItem);
                AtualizarLabels();
            }
        }
    }
}
