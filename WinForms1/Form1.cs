using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        private Label label1;
        private TextBox textBox1;
        private Button button1;

        public Form1()
        {
            InitializeComponent();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.label1 = new Label();

            button1.Text = "Go";
            label1.Text = "Please enter your name: ";
            label1.SetBounds(10,10,100,30);     // left, top, width, height
            textBox1.SetBounds(110,10,100,30);
            button1.SetBounds(10,50,100,30);

            button1.Click += Button1_Click;

            Controls.AddRange(new Control[] {label1,textBox1,button1});

        }

        private void Button1_Click(object sender, EventArgs ea)
        {
            MessageBox.Show($"Hello {textBox1.Text}");
        }

    }
}
