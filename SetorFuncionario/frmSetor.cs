using System;
using System.Windows.Forms;
using SetorFuncionario.Entities;
using SetorFuncionario.Repositories;

namespace SetorFuncionario
{
    public partial class frmSetor : Form
    {
        //=========================================================================
        public frmSetor()
        {
            InitializeComponent();
            SetoresLoad();
        }
        //=========================================================================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            groupBoxSetor.Visible = true;
        }
        //=========================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetorRepository setorRepository = new SetorRepository();
            Setor setor = new Setor();
            setor.Nome = txtNome.Text;
            setor.Descricao = txtDescricao.Text;
            

            if (txtId.Text.Equals(""))
            {
                setorRepository.Insert(setor);
            }
            else
            {
                setor.SetorId = Convert.ToInt32(txtId.Text);
                setorRepository.Update(setor);
            }
            SetoresLoad();
            groupBoxSetor.Visible = false;
        }
        //=========================================================================
        private void SetoresLoad()
        {
            SetorRepository setorRepository = new SetorRepository();
            dgvSetores.DataSource = setorRepository.GetAll();
            groupBoxSetor.Visible = false;
        }
        //=========================================================================
        private void dgvSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtId.Text = dgvSetores.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvSetores.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgvSetores.Rows[e.RowIndex].Cells[2].Value.ToString();
                btnExcluir.Visible = true;
                groupBoxSetor.Visible = true;
            }
        }
        //=========================================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SetorRepository setorRepository = new SetorRepository();
            setorRepository.Delete(Convert.ToInt32(txtId.Text));
            SetoresLoad();
            groupBoxSetor.Visible = false;
        }
        //=========================================================================
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
        //=========================================================================
    }
}
