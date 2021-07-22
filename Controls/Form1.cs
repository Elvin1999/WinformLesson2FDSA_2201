using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //CreateLabel();
        }
        void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources.RoadMap__1_;
            label.Size = new Size(image.Width, image.Height);

            label.Image = image;
            this.Size = label.Size;

            this.Controls.Add(label);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
           // groupBox1.Controls.Add(radioButton3);
            //MessageBox.Show(textBox1.Text);
            //MessageBox.Show(textBox1.SelectedText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Text = textBox1.Text;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
           // textBox1.BorderStyle = BorderStyle.None;
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.SpringGreen;
            }
            else
            {
                checkBox1.ForeColor = Color.Black;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.SpringGreen;
            }
            else
            {
                radioButton1.ForeColor = Color.Black;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.SpringGreen;
            }
            else
            {
                radioButton2.ForeColor = Color.Black;

            }
        }
    }
}
