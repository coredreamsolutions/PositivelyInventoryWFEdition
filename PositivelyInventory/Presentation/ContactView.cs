using PositivelyInventory.Data;
using PositivelyInventory.Model;
using PositivelyInventory.Validators;
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
    public partial class ContactView : Form
    {
        ContactsRepository contactsRepository = new ContactsRepository();
        public Contact ContactModel { get; set; }

        public ContactView(Contact contact)
        {
            InitializeComponent();

            ContactModel = contact ?? throw new ArgumentNullException("contact");

            BindModel(contact);
        }

        /// <summary>
        /// Bind the data from the database to the proper controls.
        /// </summary>
        /// <param name="contact">The model</param>
        public void BindModel(Contact contact)
        {
            FirstName.DataBindings.Add("Text", contact, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            LastName.DataBindings.Add("Text", contact, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            Email.DataBindings.Add("Text", contact, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            MobileNumber.DataBindings.Add("Text", contact, "MobileNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            OfficeNumber.DataBindings.Add("Text", contact, "OfficeNumber", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SaveCloseContact_Click(object sender, EventArgs e)
        {
            SaveContactView();
        }

        public void SaveContactView()
        {
            CheckResult checkResult = ContactValidator.ValidateSave(ContactModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            contactsRepository.SaveContact(ContactModel, null);
            Close();
            List<Contacts> contact = contactsRepository.GetContacts();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = contact;
        }
    }

}
