namespace GrafikCizme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zedPanel = new ZedGraph.ZedGraphControl();
            this.btnCiz = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.txtXkatsayi = new System.Windows.Forms.TextBox();
            this.txtYkatsayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSabitSayi = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grupIki = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.listFormuller = new DevExpress.XtraEditors.ListBoxControl();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupIki)).BeginInit();
            this.grupIki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFormuller)).BeginInit();
            this.SuspendLayout();
            // 
            // zedPanel
            // 
            this.zedPanel.Location = new System.Drawing.Point(0, 39);
            this.zedPanel.Name = "zedPanel";
            this.zedPanel.ScrollGrace = 0D;
            this.zedPanel.ScrollMaxX = 0D;
            this.zedPanel.ScrollMaxY = 0D;
            this.zedPanel.ScrollMaxY2 = 0D;
            this.zedPanel.ScrollMinX = 0D;
            this.zedPanel.ScrollMinY = 0D;
            this.zedPanel.ScrollMinY2 = 0D;
            this.zedPanel.Size = new System.Drawing.Size(510, 354);
            this.zedPanel.TabIndex = 0;
            // 
            // btnCiz
            // 
            this.btnCiz.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCiz.Appearance.Options.UseFont = true;
            this.btnCiz.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCiz.Image = ((System.Drawing.Image)(resources.GetObject("btnCiz.Image")));
            this.btnCiz.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCiz.ImageUri.Uri = "Chart;Office2013";
            this.btnCiz.Location = new System.Drawing.Point(317, 124);
            this.btnCiz.Name = "btnCiz";
            this.btnCiz.Size = new System.Drawing.Size(75, 49);
            this.btnCiz.TabIndex = 1;
            this.btnCiz.Text = "Çiz";
            this.btnCiz.Click += new System.EventHandler(this.btnCiz_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(418, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(73, 49);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(147, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // cmbIslem
            // 
            this.cmbIslem.BackColor = System.Drawing.Color.White;
            this.cmbIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbIslem.Location = new System.Drawing.Point(58, 42);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(32, 24);
            this.cmbIslem.TabIndex = 6;
            this.cmbIslem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIslem_KeyPress);
            // 
            // txtXkatsayi
            // 
            this.txtXkatsayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXkatsayi.Location = new System.Drawing.Point(5, 42);
            this.txtXkatsayi.Multiline = true;
            this.txtXkatsayi.Name = "txtXkatsayi";
            this.txtXkatsayi.Size = new System.Drawing.Size(28, 24);
            this.txtXkatsayi.TabIndex = 7;
            this.txtXkatsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXkatsayi_KeyPress_1);
            // 
            // txtYkatsayi
            // 
            this.txtYkatsayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYkatsayi.Location = new System.Drawing.Point(96, 42);
            this.txtYkatsayi.Multiline = true;
            this.txtYkatsayi.Name = "txtYkatsayi";
            this.txtYkatsayi.Size = new System.Drawing.Size(28, 25);
            this.txtYkatsayi.TabIndex = 7;
            this.txtYkatsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYkatsayi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(128, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // txtSabitSayi
            // 
            this.txtSabitSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSabitSayi.Location = new System.Drawing.Point(172, 41);
            this.txtSabitSayi.Multiline = true;
            this.txtSabitSayi.Name = "txtSabitSayi";
            this.txtSabitSayi.Size = new System.Drawing.Size(30, 26);
            this.txtSabitSayi.TabIndex = 7;
            this.txtSabitSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSabitSayi_KeyPress);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.grupIki);
            this.groupControl1.Controls.Add(this.zedPanel);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(510, 584);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Koordinat Sistemi";
            // 
            // grupIki
            // 
            this.grupIki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupIki.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grupIki.CaptionImage")));
            this.grupIki.Controls.Add(this.label4);
            this.grupIki.Controls.Add(this.listFormuller);
            this.grupIki.Controls.Add(this.txtXkatsayi);
            this.grupIki.Controls.Add(this.cmbIslem);
            this.grupIki.Controls.Add(this.btnSil);
            this.grupIki.Controls.Add(this.label3);
            this.grupIki.Controls.Add(this.btnCiz);
            this.grupIki.Controls.Add(this.lbSonuc);
            this.grupIki.Controls.Add(this.label2);
            this.grupIki.Controls.Add(this.txtYkatsayi);
            this.grupIki.Controls.Add(this.label1);
            this.grupIki.Controls.Add(this.txtSabitSayi);
            this.grupIki.Location = new System.Drawing.Point(4, 402);
            this.grupIki.Name = "grupIki";
            this.grupIki.Size = new System.Drawing.Size(506, 178);
            this.grupIki.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(209, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ör(2x+4y=8)";
            // 
            // listFormuller
            // 
            this.listFormuller.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.listFormuller.Appearance.Options.UseFont = true;
            this.listFormuller.Cursor = System.Windows.Forms.Cursors.Default;
            this.listFormuller.Location = new System.Drawing.Point(5, 73);
            this.listFormuller.Name = "listFormuller";
            this.listFormuller.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listFormuller.Size = new System.Drawing.Size(306, 100);
            this.listFormuller.TabIndex = 10;
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbSonuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbSonuc.Location = new System.Drawing.Point(334, 49);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 17);
            this.lbSonuc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 585);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupIki)).EndInit();
            this.grupIki.ResumeLayout(false);
            this.grupIki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFormuller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPanel;
        private DevExpress.XtraEditors.SimpleButton btnCiz;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.TextBox txtXkatsayi;
        private System.Windows.Forms.TextBox txtYkatsayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSabitSayi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lbSonuc;
        private DevExpress.XtraEditors.GroupControl grupIki;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.ListBoxControl listFormuller;
        private System.Windows.Forms.Label label4;
    }
}

