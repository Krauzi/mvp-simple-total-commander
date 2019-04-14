using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCommanderKrupa
{
    public partial class TCPanel : UserControl, IPanel
    {
        public TCPanel()
        {
            InitializeComponent();
            listView_Items.View = View.Details;
            listView_Items.HeaderStyle = ColumnHeaderStyle.None;
        }

        #region IPanel
        public string[] Drives
        {
            set
            {
                comboBoxDrives.Items.Clear();
                comboBoxDrives.Items.AddRange(value);
            }
        }

        public string CurrentPath
        {
            get
            {
                return label_Path.Text;
            }
            set
            {
                label_Path.Text = value;
            }
        }

        public string[] Items
        {
            get
            {
                return listView_Items.Items.OfType<string>().ToArray();
            }
            set
            {
                listView_Items.Items.Clear();
                foreach (var item in value)
                    listView_Items.Items.Add(item);
            }
        }

        public string SelectedItem
        {
            get
            {
                try
                {
                    return listView_Items.SelectedItems[0].Text;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        public void ResetFolderValues ()
        {
            GetItems();
            colorFolders();
        }

        #endregion


        public event Action GetDrives;
        private void comboBoxDrives_Click(object sender, EventArgs e)
        {
            GetDrives();
        }

        public event EventHandler ChangeSelectedDrive;
        private void ComboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPath = comboBoxDrives.SelectedItem.ToString();

            this.ChangeSelectedDrive?.Invoke(this, e);

            listView_Items.Focus();
        }

        private void label_Path_TextChanged(object sender, EventArgs e)
        {
            if (GetItems != null)
            {
                GetItems();
                colorFolders();
            }
        }

        private void colorFolders()
        {
            for (int i = 0; i < listView_Items.Items.Count; i++)
            {
                if (listView_Items.Items[i].Text.ToString().StartsWith("<D>"))
                {
                    listView_Items.Items[i] = new ListViewItem(listView_Items.Items[i].Text.ToString().Remove(0, 3));
                    listView_Items.Items[i].BackColor = Color.MediumAquamarine;
                }
            }
        }

        public event Action GetItems;

        public event Action<string> ExecuteSelectedItem;
        private void listView_Items_DoubleClick(object sender, EventArgs e)
        {
            if (ExecuteSelectedItem != null)
            {
                ExecuteSelectedItem(listView_Items.SelectedItems[0].Text);
            }
        }

        public event Action ReturnToPreviousPath;
        private void button_Backwards_Click(object sender, EventArgs e)
        {
            if (CurrentPath == "") return;
            if (ExecuteSelectedItem != null)
            {
                ReturnToPreviousPath();
            }
        }

        private void listView_Items_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_Items.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        public event Action<string> DeleteSelectedItem;
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(listView_Items.SelectedItems[0].Text);
            GetItems();
            colorFolders();
        }

        
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExecuteSelectedItem != null)
            {
                ExecuteSelectedItem(listView_Items.SelectedItems[0].Text);
            }
        }
    }
}
