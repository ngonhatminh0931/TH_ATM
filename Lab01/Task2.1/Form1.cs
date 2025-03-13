using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task2._1
{
    public partial class Task2_1 : Form
    {
        public Task2_1()
        {
            InitializeComponent();
        }

        private void textBox_Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
                MessageBox.Show("Chỉ được nhập một chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Nếu đã có 1 ký tự, chặn nhập thêm
            if (textBox_Key.Text.Length >= 1 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập 1 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
