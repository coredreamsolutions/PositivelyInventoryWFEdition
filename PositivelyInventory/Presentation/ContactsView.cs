using PositivelyInventory.Model;
using PositivelyInventory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PositivelyInventory.Presentation
{
    public partial class ContactsView : Form
    {

        ContactsRepository contactsRepository = new ContactsRepository();
        public List<Contacts> ContactModel { get; set; }

        public ContactsView(List<Contacts> contact)
        {
            InitializeComponent();

            ContactModel = contact ?? throw new ArgumentNullException("contact");
 
            ConfigureGrid();
            PopulateContactsGrid();
        }

        private void ConfigureGrid()
        {
            ContactsGrid.AutoGenerateColumns = false;
            ContactsGrid.RowHeadersVisible = false;
            ContactsGrid.Columns[0].Visible = true;
        }

        private void PopulateContactsGrid()
        {
            List<Contacts> contacts = contactsRepository.GetContacts();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = contacts;
            ContactsGrid.DataSource = bindingSource;
            ContactsGrid.Update();
        }

        private void NewContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            using (ContactView contactView = new ContactView(contact))
            {
                contactView.Owner = this; // Set the child's parent window to the this.
                contactView.ShowDialog(); // Show the child window.

                PopulateContactsGrid();
            }
        }
    }
}
