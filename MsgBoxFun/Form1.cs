using EnumUtilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MsgBoxFun
{
    public partial class Form1 : Form
    {
        readonly MessageBoxIcon[] comboBoxIconDataSource = EnumUtil.GetValues<MessageBoxIcon>().OrderBy(x => x).Distinct().ToArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIcon.DataSource = comboBoxIconDataSource;
            comboBoxIcon.SelectedIndex = 0;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Test", "test", MessageBoxButtons.OK, comboBoxIconDataSource[comboBoxIcon.SelectedIndex]);
        }
    }
}
