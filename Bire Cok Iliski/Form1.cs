using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bire_Cok_Iliski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            
        }
        DBXContext context = new DBXContext();
        private void button1_Click_1(object sender, EventArgs e)
        {
            Kisiler kisiler = new() //foreign key üzerinden ekleme
            {
                KISIAD = textBox1.Text,
                KisilerID = Convert.ToInt32(textBox2.Text),
                PCMarkaID=Convert.ToInt32(textBox3.Text)
            };
            context.Add(kisiler);
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.DataSource = context.PcMarkalar.AsNoTracking().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.DataSource = context.Kisiler.AsNoTracking().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PcMarkalar pcMarkalar = new PcMarkalar() 
            {
                MarkaAD = textBox4.Text,
                Kisiler = new HashSet<Kisiler>() { new() { KISIAD = textBox5.Text, KisilerID = Convert.ToInt32(textBox7.Text) } }
            };

            context.Add(pcMarkalar);
            context.SaveChanges();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var list = context.PcMarkalar.Where(u => u.MarkaAD == textBox9.Text).ToList();
            if(list.Count!=0)
            {
                MessageBox.Show("Böyle bir marka var");
            }
            else
            {
                PcMarkalar markalar = new()
                {
                    MarkaAD = textBox9.Text,
                };
                context.Add(markalar);
                context.SaveChanges();
            }

          
        }

        private void button6_Click(object sender, EventArgs e)
        {

            var list = context.PcMarkalar.Where(u => u.MarkaAD == textBox10.Text).ToList(); // veritabanındaki değeri arama
            if(list.Count!=0)
            {
                MessageBox.Show("Böyle bir marka var");
            }
           
        }
    }
}
