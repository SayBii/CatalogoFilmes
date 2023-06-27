using CatalogoFilmes.Controller;
using CatalogoFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmes.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txbox_filme.Text;
            Filme.EstreiaFilme = txbox_estreia.Text;
            Filme.DuracaoFilme = txbox_duracao.Text;
            Filme.CategoriaFilme = cbox_categoria.Text;

            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();
        }
        public void novocadastroFilme()
        {

           
        }
     
    }
}
