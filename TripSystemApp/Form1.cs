using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripSystemApp.DataAccess;

namespace TripSystemApp
{
    public partial class Form1 : Form
    {
        private readonly TravelDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new TravelDbContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.Users.Load();
            dataGridView1.DataSource = _context.Users.Local.ToBindingList();
        }
    }
}
