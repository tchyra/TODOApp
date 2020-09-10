namespace TODOAppDesktop
{
    partial class FrmListy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListy));
            this._lbxListy = new System.Windows.Forms.ListBox();
            this._btnUtworzListe = new System.Windows.Forms.Button();
            this._btnZmienNazwe = new System.Windows.Forms.Button();
            this._btnUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lbxListy
            // 
            this._lbxListy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbxListy.FormattingEnabled = true;
            this._lbxListy.IntegralHeight = false;
            this._lbxListy.Location = new System.Drawing.Point(12, 41);
            this._lbxListy.Name = "_lbxListy";
            this._lbxListy.Size = new System.Drawing.Size(338, 397);
            this._lbxListy.TabIndex = 0;
            this._lbxListy.DoubleClick += new System.EventHandler(this._lbxListy_DoubleClick);
            // 
            // _btnUtworzListe
            // 
            this._btnUtworzListe.Location = new System.Drawing.Point(12, 12);
            this._btnUtworzListe.Name = "_btnUtworzListe";
            this._btnUtworzListe.Size = new System.Drawing.Size(75, 23);
            this._btnUtworzListe.TabIndex = 1;
            this._btnUtworzListe.Text = "Utwórz";
            this._btnUtworzListe.UseVisualStyleBackColor = true;
            this._btnUtworzListe.Click += new System.EventHandler(this._btnUtworzListe_Click);
            // 
            // _btnZmienNazwe
            // 
            this._btnZmienNazwe.Location = new System.Drawing.Point(93, 12);
            this._btnZmienNazwe.Name = "_btnZmienNazwe";
            this._btnZmienNazwe.Size = new System.Drawing.Size(127, 23);
            this._btnZmienNazwe.TabIndex = 1;
            this._btnZmienNazwe.Text = "Zmień nazwę";
            this._btnZmienNazwe.UseVisualStyleBackColor = true;
            this._btnZmienNazwe.Click += new System.EventHandler(this._btnZmienNazwe_Click);
            // 
            // _btnUsun
            // 
            this._btnUsun.Location = new System.Drawing.Point(226, 12);
            this._btnUsun.Name = "_btnUsun";
            this._btnUsun.Size = new System.Drawing.Size(69, 23);
            this._btnUsun.TabIndex = 1;
            this._btnUsun.Text = "Usuń";
            this._btnUsun.UseVisualStyleBackColor = true;
            this._btnUsun.Click += new System.EventHandler(this._btnUsun_Click);
            // 
            // FrmListy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this._btnUsun);
            this.Controls.Add(this._btnZmienNazwe);
            this.Controls.Add(this._btnUtworzListe);
            this.Controls.Add(this._lbxListy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListy";
            this.Text = "TODOApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _lbxListy;
        private System.Windows.Forms.Button _btnUtworzListe;
        private System.Windows.Forms.Button _btnZmienNazwe;
        private System.Windows.Forms.Button _btnUsun;
    }
}