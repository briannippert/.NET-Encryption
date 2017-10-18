using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto
{
  public partial class Encryptor : Form
  {
    OpenFileDialog _fileDialog;
    string _version = "1.1";
    /// <summary>
    /// Encryptor Constructor
    /// </summary>
    public Encryptor()
    {
      InitializeComponent();
      _fileDialog = new OpenFileDialog();

    }

    /// <summary>
    /// Encrypts data in the txtPlainText field using the password.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnEncrypt_Click(object sender, EventArgs e)
    {
      if (txtPlainText.Text == "" || txtPassword.Text == "")
      {
        MessageBox.Show("Please Enter Password and PlainText");
        return;
      }
      string cypher = Encryption.EncryptStringAES(txtPlainText.Text, txtPassword.Text);
      txtCypherText.Text = cypher;
    }

    /// <summary>
    /// Decrypts Data in the cypher text field. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnDecrypt_Click(object sender, EventArgs e)
    {
      if (txtCypherText.Text == "" || txtPassword.Text == "")
      {
        MessageBox.Show("Please Enter Password and PlainText");
        return;
      }
      try
      {
        string cypher = Encryption.DecryptStringAES(txtCypherText.Text, txtPassword.Text);
        txtPlainText.Text = cypher;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Invalid Password", "Invalid Password!");
      }

    }
    /// <summary>
    /// Closes the program from the menu strip.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    /// <summary>
    /// Shows file dialog then reads the file into the cypher text filed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void encryptedFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (_fileDialog.ShowDialog() == DialogResult.OK)
        {
          System.IO.StreamReader sr = new
             System.IO.StreamReader(_fileDialog.FileName);
          txtCypherText.Text = sr.ReadToEnd();
          sr.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error!", ex.Message);
      }
      
    }

    /// <summary>
    /// Shows file dialog then reads the file into the plain text filed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void plainTextFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (_fileDialog.ShowDialog() == DialogResult.OK)
        {
          System.IO.StreamReader sr = new
             System.IO.StreamReader(_fileDialog.FileName);
          txtPlainText.Text = sr.ReadToEnd();
          sr.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error!", ex.Message);
      }

    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog s1 = new SaveFileDialog();
      string lines = txtCypherText.Text;
      if ( s1.ShowDialog() == DialogResult.OK)
      {
        System.IO.StreamWriter file = new System.IO.StreamWriter(s1.FileName);
        file.WriteLine(lines);
        file.Close();
      }
      

    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(txtCypherText.Text);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Simple String Encryption Version " + _version, "About");
    }
  }
}
