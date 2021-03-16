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
        }
    }
}
