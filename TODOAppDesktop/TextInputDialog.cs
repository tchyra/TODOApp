using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOAppDesktop
{
    public partial class TextInputDialog : Form
    {
        public string WprowadzonyTekst { get => _tbxText.Text; }

        public TextInputDialog()
        {
            InitializeComponent();
        }

        public TextInputDialog(string prompt, string poczatkowyTekst = "") : this()
        {
            Text = prompt;
            _tbxText.Text = poczatkowyTekst;
            _tbxText.SelectAll();
        }
    }
}
