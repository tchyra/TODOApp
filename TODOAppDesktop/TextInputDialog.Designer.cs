namespace TODOAppDesktop
{
    partial class TextInputDialog
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
            this._tbxText = new System.Windows.Forms.TextBox();
            this._btnOk = new System.Windows.Forms.Button();
            this._btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tbxText
            // 
            this._tbxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbxText.Location = new System.Drawing.Point(12, 12);
            this._tbxText.Name = "_tbxText";
            this._tbxText.Size = new System.Drawing.Size(268, 20);
            this._tbxText.TabIndex = 0;
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOk.Location = new System.Drawing.Point(205, 38);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 23);
            this._btnOk.TabIndex = 1;
            this._btnOk.Text = "OK";
            this._btnOk.UseVisualStyleBackColor = true;
            // 
            // _btnAnuluj
            // 
            this._btnAnuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnAnuluj.Location = new System.Drawing.Point(124, 38);
            this._btnAnuluj.Name = "_btnAnuluj";
            this._btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this._btnAnuluj.TabIndex = 1;
            this._btnAnuluj.Text = "Anuluj";
            this._btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // TextInputDialog
            // 
            this.AcceptButton = this._btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnAnuluj;
            this.ClientSize = new System.Drawing.Size(292, 69);
            this.Controls.Add(this._btnAnuluj);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._tbxText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TextInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TextInputDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbxText;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.Button _btnAnuluj;
    }
}