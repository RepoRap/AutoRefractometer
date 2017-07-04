using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            serialPort1.Write("d");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("l");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort1.Write("m");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("n");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            serialPort1.Write("p");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
