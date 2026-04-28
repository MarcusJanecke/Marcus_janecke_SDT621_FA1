using System;
using System.Windows.Forms;

namespace FavouriteLanguages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateCount(); // NEW in v2.0
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.", "Empty Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in lstLanguages.Items)
            {
                if (item.ToString().Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("'" + language + "' is already in the list.", "Duplicate Entry",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            lstLanguages.Items.Add(language);
            lblStatus.Text = "Added '" + language + "' at " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            txtLanguage.Clear();
            txtLanguage.Focus(); // NEW in v2.0
            UpdateCount();       // NEW in v2.0
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string removed = lstLanguages.SelectedItem.ToString();
            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            lblStatus.Text = "Removed '" + removed + "' at " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");
            UpdateCount(); // NEW in v2.0
        }

        // NEW in v2.0: sort the list alphabetically
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (lstLanguages.Items.Count == 0)
            {
                lblStatus.Text = "Nothing to sort.";
                return;
            }

            var items = new System.Collections.Generic.List<string>();
            foreach (var item in lstLanguages.Items)
                items.Add(item.ToString());

            items.Sort(StringComparer.OrdinalIgnoreCase);

            lstLanguages.Items.Clear();
            foreach (var item in items)
                lstLanguages.Items.Add(item);

            lblStatus.Text = "List sorted alphabetically at " + DateTime.Now.ToString("HH:mm:ss");
        }

        // NEW in v2.0: update the item count label
        private void UpdateCount()
        {
            lblCount.Text = "Languages in list: " + lstLanguages.Items.Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}