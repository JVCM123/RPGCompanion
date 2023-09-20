using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using RPGCompanion.Classes;

namespace RPGCompanion
{
    public partial class frmFichaPlayer : Form
    {
        Utilitarios util = new Utilitarios();
        public frmFichaPlayer()
        {
            InitializeComponent();

            Habilidade hab = new Habilidade()
            {
                Nome = "Bola de Fogo",
                Descricao = "Dispara uma enorme Bola de Fogo em direção ao adversário, causando queimadura e 1d10 + 5 de dano",
                Dificuldade = "5+"
            };



            dgvHabilidades.DataSource = new List<Habilidade>() { hab };


        }


    }
}
