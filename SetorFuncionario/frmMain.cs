using System;
using System.Windows.Forms;
using SetorFuncionario.Entities;
using SetorFuncionario.Repositories;

namespace SetorFuncionario
{
    public partial class frmMain : Form
    {
        //=========================================================================
        public frmMain()
        {
            InitializeComponent();
            FuncionariosLoad();
            FillSetores();
        }
        //=========================================================================
        private void FillSetores()
        {
            SetorRepository setorRepository = new SetorRepository();
            cmbSetor.DataSource = setorRepository.GetAll();
            cmbSetor.DisplayMember = "Nome";
            cmbSetor.ValueMember = "SetorId";
        }

        //=========================================================================
        private void FuncionariosLoad()
        {
            SetorFuncionarioRepository setorFuncionarioRepository = new SetorFuncionarioRepository();
            dgvFuncionarios.DataSource = setorFuncionarioRepository.GetAll();
            groupBoxFuncionario.Visible = false;
        }
        //=========================================================================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtDataAdmissao.Text = "";
            groupBoxFuncionario.Visible = true;
        }
        //=========================================================================
        private void btnSetor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetor frmSetor = new frmSetor();
            frmSetor.Show();
        }
        //=========================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.DataAdmissao = Convert.ToDateTime(txtDataAdmissao.Text);
            funcionario.SetorId = Convert.ToInt32(cmbSetor.SelectedValue);
            //funcionario.Setor = new Setor();
            //funcionario.Setor.SetorId = Convert.ToInt32(cmbSetor.SelectedValue);


            if (txtId.Text.Equals(""))
            {
                funcionarioRepository.Insert(funcionario);
            }
            else
            {
                funcionario.FuncionarioId = Convert.ToInt32(txtId.Text);
                funcionarioRepository.Update(funcionario);
            }
            FuncionariosLoad();
            groupBoxFuncionario.Visible = false;
        }
        //=========================================================================
        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtId.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDataAdmissao.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnExcluir.Visible = true;
                groupBoxFuncionario.Visible = true;
            }
        }
        //=========================================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            funcionarioRepository.Delete(Convert.ToInt32(txtId.Text));
            FuncionariosLoad();
            groupBoxFuncionario.Visible = false;
        }
    }
}
