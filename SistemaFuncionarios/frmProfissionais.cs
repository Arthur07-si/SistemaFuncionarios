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
    public partial class frmProfissionais : Form
    {
        private AppDbContext _context;
        private Profissional _profissionalAtual;
        private bool _editando;

        public frmProfissionais()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }
        private void frmProfissionais_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CarregarProfissionais();
            HabilitarControles(false);
            btnCalcularHoraExtra.Enabled = false;

        }
        
            private void ConfigurarDataGridView()
        {
            
            dgvProfissionais.Columns.Clear();

            
            dgvProfissionais.AutoGenerateColumns = false;

            
            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "colId",         
                Visible = false

            });

            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCompleto",
                HeaderText = "Nome Completo",
                Name = "colNome",
                Width = 200
            });

            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefone",
                HeaderText = "Telefone",
                Name = "colTelefone",
                Width = 120
            });

            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RG",
                HeaderText = "RG",
                Name = "colRG",
                Width = 120
            });

            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Endereco",
                HeaderText = "Endereço",
                Name = "colEndereco",
                Width = 200
            });

            dgvProfissionais.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Salario",
                HeaderText = "Salário",
                Name = "colSalario",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2" 
                }
            });
        }

        

        private void CarregarProfissionais()
        {
            using (var db = new AppDbContext())
            {
                dgvProfissionais.DataSource = db.Profissionais.ToList();
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtRG.Text = "";
            txtEndereco.Text = "";
            txtSalario.Text = "";
            _profissionalAtual = null;
        }
        private void HabilitarControles(bool habilitar)
        {
            txtNome.Enabled = habilitar;
            txtTelefone.Enabled = habilitar;
            txtRG.Enabled = habilitar;
            txtEndereco.Enabled = habilitar;
            txtSalario.Enabled = habilitar;

            btnSalvar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;

            btnAdicionar.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar && dgvProfissionais.SelectedRows.Count > 0;
            btnExcluir.Enabled = !habilitar && dgvProfissionais.SelectedRows.Count > 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            {
                _editando = false;
                LimparCampos();
                HabilitarControles(true);
                txtNome.Focus();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                if (dgvProfissionais.SelectedRows.Count > 0)
                {
                    try
                    {
                        _editando = true;


                        var id = Convert.ToInt32(dgvProfissionais.SelectedRows[0].Cells["colId"].Value);

                        _profissionalAtual = _context.Profissionais.Find(id);


                        txtNome.Text = _profissionalAtual.NomeCompleto;
                        txtTelefone.Text = _profissionalAtual.Telefone;
                        txtRG.Text = _profissionalAtual.RG;
                        txtEndereco.Text = _profissionalAtual.Endereco;
                        txtSalario.Text = _profissionalAtual.Salario.ToString();

                        HabilitarControles(true);
                        txtNome.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao editar profissional: {ex.Message}", "Erro",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProfissionais.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir este profissional?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    var id = (int)dgvProfissionais.SelectedRows[0].Cells["colId"].Value;
                    var profissional = _context.Profissionais.Find(id);

                    _context.Profissionais.Remove(profissional);
                    _context.SaveChanges();

                    CarregarProfissionais();
                    LimparCampos();
                    HabilitarControles(false);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (!_editando)
                {
                    _profissionalAtual = new Profissional();
                }

                _profissionalAtual.NomeCompleto = txtNome.Text;
                _profissionalAtual.Telefone = txtTelefone.Text;
                _profissionalAtual.RG = txtRG.Text;
                _profissionalAtual.Endereco = txtEndereco.Text;
                _profissionalAtual.Salario = decimal.Parse(txtSalario.Text);

                if (!_editando)
                {
                    _context.Profissionais.Add(_profissionalAtual);
                }

                _context.SaveChanges();

                CarregarProfissionais();
                LimparCampos();
                HabilitarControles(false);
            }
        }
        private bool ValidarCampos()
        {
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O nome completo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(txtSalario.Text, out _))
                {
                    MessageBox.Show("O salário deve ser um valor numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                LimparCampos();
                HabilitarControles(false);
        }

        private void dgvProfissionais_SelectionChanged(object sender, EventArgs e)
       {
            bool linhaSelecionada = dgvProfissionais.SelectedRows.Count > 0;
            btnEditar.Enabled = linhaSelecionada;
            btnExcluir.Enabled = linhaSelecionada;
            btnCalcularHoraExtra.Enabled = linhaSelecionada;
        }

        private void btnCalcularHoraExtra_Click(object sender, EventArgs e)
        {
            
            if (dgvProfissionais.SelectedRows.Count > 0)
            {
                
                var id = (int)dgvProfissionais.SelectedRows[0].Cells["colId"].Value;

                
                using (var formHoraExtra = new frmHoraExtra(id))
                {
                    formHoraExtra.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecione um profissional primeiro.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
