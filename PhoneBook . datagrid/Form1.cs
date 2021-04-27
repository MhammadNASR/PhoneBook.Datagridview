using PhoneBook.datagrid.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook.datagrid
{
    public partial class PhoneBook : Form
    {
        public List<Person> People;
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            People = Person.GetPeople();
            dataGrid.DataSource = People;

            dataGrid.Columns["Name"].HeaderText = "نام";
            dataGrid.Columns["LastName"].HeaderText = "نام خانوادگی";
            dataGrid.Columns["PhoneNumber"].HeaderText = "شماره تلفن";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            var filter = People.Where(x => x.Name == name).ToList();
            dataGrid.DataSource = filter;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lastname = textBox2.Text;
            var filter = People.Where(x => x.LastName == lastname).ToList();
            dataGrid.DataSource = filter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string phonenum = textBox3.Text;
            var filter = People.Where(x => x.PhoneNumber == phonenum).ToList();
            dataGrid.DataSource = filter;
        }
    }
}
