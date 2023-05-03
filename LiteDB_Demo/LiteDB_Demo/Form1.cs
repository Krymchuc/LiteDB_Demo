using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace LiteDB_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiteDatabase db;
            LiteCollection<Contact> list;
            db = new LiteDatabase($"{Application.StartupPath}\\mydb.db");
            list = (LiteCollection<Contact>)db.GetCollection<Contact>();
            //list.EnsureIndex("Id", true);
            if (list.Count() == 0)
                contactBindingSource.DataSource = new List<Contact>();
            else
                contactBindingSource.DataSource = list.FindAll();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
