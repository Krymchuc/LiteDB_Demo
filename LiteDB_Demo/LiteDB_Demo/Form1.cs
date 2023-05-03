
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

namespace LiteDB_Demo
{
    public partial class Form1 : Form
    {
        private LiteDatabase db;
        private LiteCollection<Contact> contacts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new LiteDatabase($"{Application.StartupPath}\\mydb.db");
            contacts = (LiteCollection<Contact>)db.GetCollection<Contact>("Contacts");

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DataGridView.DataSource = contacts.FindAll().ToList();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFullName.Text) || string.IsNullOrEmpty(textBoxPhone.Text) ||
                string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please enter all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Contact newContact = new Contact
            {
                FullName = textBoxFullName.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text
            };

            contacts.Insert(newContact);
            RefreshDataGridView();

            ClearFields();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = DataGridView.SelectedRows[0].Index;
            Contact selectedContact = DataGridView.SelectedRows[0].DataBoundItem as Contact;

            if (selectedContact != null)
            {
                selectedContact.FullName = textBoxFullName.Text;
                selectedContact.Phone = textBoxPhone.Text;
                selectedContact.Email = textBoxEmail.Text;
                selectedContact.Address = textBoxAddress.Text;

                contacts.Update(selectedContact);
                RefreshDataGridView();

                DataGridView.Rows[selectedRowIndex].Selected = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = DataGridView.SelectedRows[0].Index;
            Contact selectedContact = DataGridView.SelectedRows[0].DataBoundItem as Contact;

            if (selectedContact != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this contact?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contacts.Delete(selectedContact.Id);
                    RefreshDataGridView();

                    if (DataGridView.Rows.Count > 0)
                    {
                        if (selectedRowIndex >= DataGridView.Rows.Count)
                            selectedRowIndex = DataGridView.Rows.Count - 1;

                        DataGridView.Rows[selectedRowIndex].Selected = true;
                    }
                    else
                    {
                        ClearFields();
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxFullName.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";

            DataGridView.ClearSelection();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                Contact selectedContact = DataGridView.SelectedRows[0].DataBoundItem as Contact;

                if (selectedContact != null)
                {
                    textBoxFullName.Text = selectedContact.FullName;
                    textBoxPhone.Text = selectedContact.Phone;
                    textBoxEmail.Text = selectedContact.Email;
                    textBoxAddress.Text = selectedContact.Address;
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
                string searchQuery = textBoxSearch.Text.Trim();

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    var results = contacts.Find(x =>
                        x.FullName.Contains(searchQuery) ||
                        x.Phone.Contains(searchQuery) ||
                        x.Email.Contains(searchQuery) ||
                        x.Address.Contains(searchQuery)
                    ).ToList();

                    DataGridView.DataSource = results;
                }
                else
                {
                    RefreshDataGridView();
                }            
        }
    }
}

