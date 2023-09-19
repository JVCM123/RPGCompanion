using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGCompanion.Classes;

namespace RPGCompanion
{
    public partial class frmFichaPlayer : Form
    {
        public frmFichaPlayer()
        {
            InitializeComponent();

            HabilidadeModel aa = new HabilidadeModel()
            {
                Nome = "Bola de Fogo",
                Descricao = "Dispara uma enorme Bola de Fogo em direção ao adversário, causando queimadura e 1d10 + 5 de dano",
                Dificuldade = 5
            };
            var bb = new List<HabilidadeModel>() { aa };
            dgvHabilidades.DataSource = bb;
        }
    }
}
