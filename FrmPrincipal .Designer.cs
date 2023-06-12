namespace DPDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCli = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuForn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMov = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntSai = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDesp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRel = new System.Windows.Forms.ToolStripMenuItem();
            this.RelProd = new System.Windows.Forms.ToolStripMenuItem();
            this.RelVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.RelMov = new System.Windows.Forms.ToolStripMenuItem();
            this.RelEntSai = new System.Windows.Forms.ToolStripMenuItem();
            this.RelDesp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCad,
            this.MenuProd,
            this.MenuMov,
            this.MenuRel,
            this.MenuSair});
            resources.ApplyResources(this.MenuPrincipal, "MenuPrincipal");
            this.MenuPrincipal.Name = "MenuPrincipal";
            // 
            // MenuCad
            // 
            this.MenuCad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFunc,
            this.MenuCli,
            this.MenuUsu,
            this.MenuCargos,
            this.MenuForn});
            this.MenuCad.Name = "MenuCad";
            resources.ApplyResources(this.MenuCad, "MenuCad");
            // 
            // MenuFunc
            // 
            this.MenuFunc.Name = "MenuFunc";
            resources.ApplyResources(this.MenuFunc, "MenuFunc");
            this.MenuFunc.Click += new System.EventHandler(this.MenuFunc_Click);
            // 
            // MenuCli
            // 
            this.MenuCli.Name = "MenuCli";
            resources.ApplyResources(this.MenuCli, "MenuCli");
            // 
            // MenuUsu
            // 
            this.MenuUsu.Name = "MenuUsu";
            resources.ApplyResources(this.MenuUsu, "MenuUsu");
            // 
            // MenuCargos
            // 
            this.MenuCargos.Name = "MenuCargos";
            resources.ApplyResources(this.MenuCargos, "MenuCargos");
            // 
            // MenuForn
            // 
            this.MenuForn.Name = "MenuForn";
            resources.ApplyResources(this.MenuForn, "MenuForn");
            // 
            // MenuProd
            // 
            this.MenuProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutos,
            this.MenuEstoque});
            this.MenuProd.Name = "MenuProd";
            resources.ApplyResources(this.MenuProd, "MenuProd");
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.Name = "MenuProdutos";
            resources.ApplyResources(this.MenuProdutos, "MenuProdutos");
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.Name = "MenuEstoque";
            resources.ApplyResources(this.MenuEstoque, "MenuEstoque");
            // 
            // MenuMov
            // 
            this.MenuMov.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFluxo,
            this.menuLanc,
            this.MenuEntSai,
            this.MenuDesp});
            this.MenuMov.Name = "MenuMov";
            resources.ApplyResources(this.MenuMov, "MenuMov");
            // 
            // MenuFluxo
            // 
            this.MenuFluxo.Name = "MenuFluxo";
            resources.ApplyResources(this.MenuFluxo, "MenuFluxo");
            // 
            // menuLanc
            // 
            this.menuLanc.Name = "menuLanc";
            resources.ApplyResources(this.menuLanc, "menuLanc");
            // 
            // MenuEntSai
            // 
            this.MenuEntSai.Name = "MenuEntSai";
            resources.ApplyResources(this.MenuEntSai, "MenuEntSai");
            // 
            // MenuDesp
            // 
            this.MenuDesp.Name = "MenuDesp";
            resources.ApplyResources(this.MenuDesp, "MenuDesp");
            // 
            // MenuRel
            // 
            this.MenuRel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RelProd,
            this.RelVendas,
            this.RelMov,
            this.RelEntSai,
            this.RelDesp});
            this.MenuRel.Name = "MenuRel";
            resources.ApplyResources(this.MenuRel, "MenuRel");
            // 
            // RelProd
            // 
            this.RelProd.Name = "RelProd";
            resources.ApplyResources(this.RelProd, "RelProd");
            // 
            // RelVendas
            // 
            this.RelVendas.Name = "RelVendas";
            resources.ApplyResources(this.RelVendas, "RelVendas");
            // 
            // RelMov
            // 
            this.RelMov.Name = "RelMov";
            resources.ApplyResources(this.RelMov, "RelMov");
            // 
            // RelEntSai
            // 
            this.RelEntSai.Name = "RelEntSai";
            resources.ApplyResources(this.RelEntSai, "RelEntSai");
            // 
            // RelDesp
            // 
            this.RelDesp.Name = "RelDesp";
            resources.ApplyResources(this.RelDesp, "RelDesp");
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            resources.ApplyResources(this.MenuSair, "MenuSair");
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // img02
            // 
            resources.ApplyResources(this.img02, "img02");
            this.img02.Image = global::DPDV.Properties.Resources.cadastro;
            this.img02.Name = "img02";
            this.img02.TabStop = false;
            // 
            // img03
            // 
            resources.ApplyResources(this.img03, "img03");
            this.img03.Image = global::DPDV.Properties.Resources.kisspng_psychopedagogy_report_learning_research_course_um_5b2099c73db332_3150403215288631752527;
            this.img03.Name = "img03";
            this.img03.TabStop = false;
            // 
            // img04
            // 
            resources.ApplyResources(this.img04, "img04");
            this.img04.Image = global::DPDV.Properties.Resources.dinheiro;
            this.img04.Name = "img04";
            this.img04.TabStop = false;
            // 
            // img01
            // 
            resources.ApplyResources(this.img01, "img01");
            this.img01.Image = global::DPDV.Properties.Resources.pngwing_com;
            this.img01.Name = "img01";
            this.img01.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCad;
        private System.Windows.Forms.ToolStripMenuItem MenuProd;
        private System.Windows.Forms.ToolStripMenuItem MenuMov;
        private System.Windows.Forms.ToolStripMenuItem MenuRel;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFunc;
        private System.Windows.Forms.ToolStripMenuItem MenuCli;
        private System.Windows.Forms.ToolStripMenuItem MenuUsu;
        private System.Windows.Forms.ToolStripMenuItem MenuCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuForn;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuFluxo;
        private System.Windows.Forms.ToolStripMenuItem menuLanc;
        private System.Windows.Forms.ToolStripMenuItem MenuEntSai;
        private System.Windows.Forms.ToolStripMenuItem MenuDesp;
        private System.Windows.Forms.ToolStripMenuItem RelProd;
        private System.Windows.Forms.ToolStripMenuItem RelVendas;
        private System.Windows.Forms.ToolStripMenuItem RelMov;
        private System.Windows.Forms.ToolStripMenuItem RelEntSai;
        private System.Windows.Forms.ToolStripMenuItem RelDesp;
    }
}

