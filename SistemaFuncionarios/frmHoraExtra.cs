using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFuncionarios
{
    public partial class frmHoraExtra : Form
    {
        private AppDbContext _db = new AppDbContext();
        private int _profissionalId;

        public frmHoraExtra()
        {
            InitializeComponent();
            
            CarregarProfissionais();
            
        }
        public frmHoraExtra(int profissionalId) : this()
        {
            _profissionalId = profissionalId;
            SelecionarProfissional();
        }
        private void SelecionarProfissional()
        {
            
            foreach (Profissional item in cbProfissionais.Items)
            {
                if (item.Id == _profissionalId)
                {
                    cbProfissionais.SelectedItem = item;
                    break;
                }
            }
        }

        private void CarregarProfissionais()
        {
            cbProfissionais.DataSource = _db.Profissionais.ToList();
            cbProfissionais.DisplayMember = "NomeCompleto";
            cbProfissionais.ValueMember = "Id";
        }

        private void cbProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProfissionais.SelectedItem is Profissional profissional)
            {
                txtSalarioAtual.Text = profissional.Salario.ToString("C2");
                numHorasExtras.Value = 0;
                CalcularTotal();
            }
        }

        private void numHorasExtras_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (cbProfissionais.SelectedItem is Profissional profissional && numHorasExtras.Value > 0)
            {
                decimal valorHoraExtra = profissional.Salario * 0.05m;
                decimal totalHorasExtras = valorHoraExtra * numHorasExtras.Value;
                decimal salarioTotal = profissional.Salario + totalHorasExtras;

                txtValorHoraExtra.Text = valorHoraExtra.ToString("C2");
                txtTotalHorasExtras.Text = totalHorasExtras.ToString("C2");
                txtSalarioTotal.Text = salarioTotal.ToString("C2");
            }
            else
            {
                LimparCamposCalculo();
            }
        }
        private void LimparCamposCalculo()
        {
            txtValorHoraExtra.Text = string.Empty;
            txtTotalHorasExtras.Text = string.Empty;
            txtSalarioTotal.Text = string.Empty;
        }
    }

    
}
