namespace TODOAppDesktop
{
    partial class FrmListaZadan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnDodajZadanie = new System.Windows.Forms.Button();
            this._btnEdytujZadanie = new System.Windows.Forms.Button();
            this._btnUsunZadanie = new System.Windows.Forms.Button();
            this._btnZadanieWGore = new System.Windows.Forms.Button();
            this._btnZadanieWDol = new System.Windows.Forms.Button();
            this._lsvZadania = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this._btnDodajZadanie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnEdytujZadanie, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnUsunZadanie, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnZadanieWGore, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnZadanieWDol, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _btnDodajZadanie
            // 
            this._btnDodajZadanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDodajZadanie.Location = new System.Drawing.Point(3, 3);
            this._btnDodajZadanie.Name = "_btnDodajZadanie";
            this._btnDodajZadanie.Size = new System.Drawing.Size(78, 38);
            this._btnDodajZadanie.TabIndex = 0;
            this._btnDodajZadanie.Text = "Dodaj";
            this._btnDodajZadanie.UseVisualStyleBackColor = true;
            this._btnDodajZadanie.Click += new System.EventHandler(this._btnDodajZadanie_Click);
            // 
            // _btnEdytujZadanie
            // 
            this._btnEdytujZadanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEdytujZadanie.Enabled = false;
            this._btnEdytujZadanie.Location = new System.Drawing.Point(87, 3);
            this._btnEdytujZadanie.Name = "_btnEdytujZadanie";
            this._btnEdytujZadanie.Size = new System.Drawing.Size(78, 38);
            this._btnEdytujZadanie.TabIndex = 0;
            this._btnEdytujZadanie.Text = "Edytuj";
            this._btnEdytujZadanie.UseVisualStyleBackColor = true;
            this._btnEdytujZadanie.Click += new System.EventHandler(this._btnEdytujZadanie_Click);
            // 
            // _btnUsunZadanie
            // 
            this._btnUsunZadanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnUsunZadanie.Enabled = false;
            this._btnUsunZadanie.Location = new System.Drawing.Point(171, 3);
            this._btnUsunZadanie.Name = "_btnUsunZadanie";
            this._btnUsunZadanie.Size = new System.Drawing.Size(78, 38);
            this._btnUsunZadanie.TabIndex = 0;
            this._btnUsunZadanie.Text = "Usuń";
            this._btnUsunZadanie.UseVisualStyleBackColor = true;
            this._btnUsunZadanie.Click += new System.EventHandler(this._btnUsunZadanie_Click);
            // 
            // _btnZadanieWGore
            // 
            this._btnZadanieWGore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnZadanieWGore.Enabled = false;
            this._btnZadanieWGore.Location = new System.Drawing.Point(255, 3);
            this._btnZadanieWGore.Name = "_btnZadanieWGore";
            this._btnZadanieWGore.Size = new System.Drawing.Size(78, 38);
            this._btnZadanieWGore.TabIndex = 0;
            this._btnZadanieWGore.Text = "W górę";
            this._btnZadanieWGore.UseVisualStyleBackColor = true;
            this._btnZadanieWGore.Click += new System.EventHandler(this._btnZadanieWGore_Click);
            // 
            // _btnZadanieWDol
            // 
            this._btnZadanieWDol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnZadanieWDol.Enabled = false;
            this._btnZadanieWDol.Location = new System.Drawing.Point(339, 3);
            this._btnZadanieWDol.Name = "_btnZadanieWDol";
            this._btnZadanieWDol.Size = new System.Drawing.Size(82, 38);
            this._btnZadanieWDol.TabIndex = 0;
            this._btnZadanieWDol.Text = "W dół";
            this._btnZadanieWDol.UseVisualStyleBackColor = true;
            this._btnZadanieWDol.Click += new System.EventHandler(this._btnZadanieWDol_Click);
            // 
            // _lsvZadania
            // 
            this._lsvZadania.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsvZadania.CheckBoxes = true;
            this._lsvZadania.FullRowSelect = true;
            this._lsvZadania.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._lsvZadania.HideSelection = false;
            this._lsvZadania.Location = new System.Drawing.Point(12, 62);
            this._lsvZadania.MultiSelect = false;
            this._lsvZadania.Name = "_lsvZadania";
            this._lsvZadania.Size = new System.Drawing.Size(424, 530);
            this._lsvZadania.TabIndex = 2;
            this._lsvZadania.UseCompatibleStateImageBehavior = false;
            this._lsvZadania.View = System.Windows.Forms.View.List;
            this._lsvZadania.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this._lsvZadania_ItemChecked);
            this._lsvZadania.SelectedIndexChanged += new System.EventHandler(this._lsvZadania_SelectedIndexChanged);
            // 
            // FrmListaZadan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 604);
            this.Controls.Add(this._lsvZadania);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmListaZadan";
            this.Text = "Lista zadań";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _btnDodajZadanie;
        private System.Windows.Forms.Button _btnEdytujZadanie;
        private System.Windows.Forms.Button _btnUsunZadanie;
        private System.Windows.Forms.Button _btnZadanieWGore;
        private System.Windows.Forms.Button _btnZadanieWDol;
        private System.Windows.Forms.ListView _lsvZadania;
    }
}

