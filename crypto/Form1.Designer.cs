namespace crypto
{
  partial class Encryptor
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
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      
      this.cryptoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.txtPlainText = new System.Windows.Forms.TextBox();
      this.txtCypherText = new System.Windows.Forms.TextBox();
      this.btnEncrypt = new System.Windows.Forms.Button();
      this.btnDecrypt = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.encryptedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.plainTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

      ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSetBindingSource)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(79, 27);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(114, 20);
      this.txtPassword.TabIndex = 3;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Private Key:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Cypher Text:";
      // 
      // cryptoDataSet
      // 

      // 
      // cryptoDataSetBindingSource
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(462, 24);
      this.menuStrip1.TabIndex = 8;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // txtPlainText
      // 
      this.txtPlainText.Location = new System.Drawing.Point(12, 251);
      this.txtPlainText.Multiline = true;
      this.txtPlainText.Name = "txtPlainText";
      this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtPlainText.Size = new System.Drawing.Size(435, 195);
      this.txtPlainText.TabIndex = 9;
      this.txtPlainText.UseSystemPasswordChar = true;
      // 
      // txtCypherText
      // 
      this.txtCypherText.Location = new System.Drawing.Point(12, 70);
      this.txtCypherText.Multiline = true;
      this.txtCypherText.Name = "txtCypherText";
      this.txtCypherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtCypherText.Size = new System.Drawing.Size(431, 164);
      this.txtCypherText.TabIndex = 10;
      this.txtCypherText.UseSystemPasswordChar = true;
      // 
      // btnEncrypt
      // 
      this.btnEncrypt.Location = new System.Drawing.Point(12, 471);
      this.btnEncrypt.Name = "btnEncrypt";
      this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
      this.btnEncrypt.TabIndex = 11;
      this.btnEncrypt.Text = "Encrypt";
      this.btnEncrypt.UseVisualStyleBackColor = true;
      this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
      // 
      // btnDecrypt
      // 
      this.btnDecrypt.Location = new System.Drawing.Point(105, 471);
      this.btnDecrypt.Name = "btnDecrypt";
      this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
      this.btnDecrypt.TabIndex = 12;
      this.btnDecrypt.Text = "Decrypt";
      this.btnDecrypt.UseVisualStyleBackColor = true;
      this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 237);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(57, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Plain Text:";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptedFileToolStripMenuItem,
            this.plainTextFileToolStripMenuItem});
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.openToolStripMenuItem.Text = "Open";
      // 
      // encryptedFileToolStripMenuItem
      // 
      this.encryptedFileToolStripMenuItem.Name = "encryptedFileToolStripMenuItem";
      this.encryptedFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.encryptedFileToolStripMenuItem.Text = "Encrypted File";
      this.encryptedFileToolStripMenuItem.Click += new System.EventHandler(this.encryptedFileToolStripMenuItem_Click);
      // 
      // plainTextFileToolStripMenuItem
      // 
      this.plainTextFileToolStripMenuItem.Name = "plainTextFileToolStripMenuItem";
      this.plainTextFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.plainTextFileToolStripMenuItem.Text = "Plain Text File";
      this.plainTextFileToolStripMenuItem.Click += new System.EventHandler(this.plainTextFileToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // Encryptor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(462, 508);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnDecrypt);
      this.Controls.Add(this.btnEncrypt);
      this.Controls.Add(this.txtCypherText);
      this.Controls.Add(this.txtPlainText);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Encryptor";
      this.Text = "Encryptor";
      
      ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSetBindingSource)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.BindingSource cryptoDataSetBindingSource;
    
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.TextBox txtPlainText;
    private System.Windows.Forms.TextBox txtCypherText;
    private System.Windows.Forms.Button btnEncrypt;
    private System.Windows.Forms.Button btnDecrypt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem encryptedFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem plainTextFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
  }
}

