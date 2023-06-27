using CatalogoFilmes.Controller;
using CatalogoFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmes.View
{
    public partial class TelaCadastroSerie : Form
    {
        public TelaCadastroSerie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txt_boxserie.Text;
            Serie.EstreiaSerie = txbox_estreiaserie.Text;
            Serie.TemporadaSerie = txbox_temp.Text;
            Serie.CategoriaSerie = cbox_categoriaserie.Text;

            SerieController seriecontroller = new SerieController();
            seriecontroller.CadastrarSerie();
        }
    }
}
