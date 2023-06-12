using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DPDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            // Configurar as propriedades dos botões de controle
            this.ControlBox = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

      
        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFunc_Click(object sender, EventArgs e)
        {
            cadastro.FrmFuncionarios frm = new cadastro.FrmFuncionarios();
            frm.ShowDialog();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {


        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // Verificar se o formulário está minimizado ou restaurado e, em seguida, maximizá-lo novamente
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
