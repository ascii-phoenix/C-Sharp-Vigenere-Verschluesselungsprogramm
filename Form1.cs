using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vigenère_verschlüsselungO;

namespace vigenère_verschlüsselung_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Verschluessung vigenère_verschlüsselung = new VerschluessungFullAscii();
       
        private void decryptButton_Click(object sender, EventArgs e)
        {
            vigenère_verschlüsselung.key = KeyRichTextBox.Text;
            vigenère_verschlüsselung.codedText = inputRichTextBox.Text;
            OutputRichTextBox.Text = vigenère_verschlüsselung.clearText;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            vigenère_verschlüsselung.key = KeyRichTextBox.Text;
            vigenère_verschlüsselung.clearText = inputRichTextBox.Text;
            OutputRichTextBox.Text = vigenère_verschlüsselung.codedText;
        }

    }
}
