using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public delegate void MyDelegate(string Message);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hallo!";
        }

        private void AddTextToBox(String text)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void button2_Click(object sender, EventArgs e)
        {
            // Opret derefter en ny knap, der ved tryk starter en ny tråd. Den nye tråd skal have
            // angivet en startmetode. Fra denne startmetode kaldes den metode, der udskriver noget
            // i tekstboksen med det, man ønsker udskrevet, som parameter.
            MyDelegate del = new MyDelegate(button1_Click);
            del("Hello from delegate");


        }
        
    }
}
