using Prova_TestMartin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_TestMartin
{
    public partial class Form1 : Form
    {
        List<Pessoas> lista_pessoa = new List<Pessoas>();

        public Form1()
        {
            InitializeComponent();
            lblAltera.Enabled = false;
            txtbEdita.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            lblAltera.Enabled = true;
            txtbEdita.Enabled = true;

            foreach (var Dadospessoas in lista_pessoa)
            {
                if (Dadospessoas.Nome == txtbEdita.Text)
                {
                    Dadospessoas.Nome = txtbNome.Text;
                    Dadospessoas.Idade = Convert.ToInt32(txtbIdade.Text);
                    Dadospessoas.Email = txtbEmail.Text;
                    Dadospessoas.Peso = float.Parse(txtbPeso.Text);
                    Dadospessoas.Altura = float.Parse(txtbAltura.Text);

                    dataDados.DataSource = null;
                    dataDados.DataSource = lista_pessoa;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Pessoas pessoas1 = new Pessoas();


            pessoas1.Nome = txtbNome.Text;
            pessoas1.Idade = Convert.ToInt32(txtbIdade.Text);
            pessoas1.Email = textBoxEmail.Text;
            pessoas1.Peso = float.Parse(txtbPeso.Text);
            pessoas1.Altura = float.Parse(txtbAltura.Text);

            lista_pessoa.Add(pessoas1);

            dataDados.DataSource = null;
            dataDados.DataSource = lista_pessoa;
        }
        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            lblAltera.Enabled = true;
            txtbEdita.Enabled = true;

            foreach (var Dadospiloto in lista_pessoa)
            {
                if (Dadospiloto.Nome == txtbEdita.Text)
                {
                    lista_pessoa.Remove(Dadospiloto);
                    break;
                }

                dataDados.DataSource = null;
                dataDados.DataSource = lista_pessoa;
            }
        }
    }
}
