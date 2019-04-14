namespace TCommanderKrupa
{
    partial class TCPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Path = new System.Windows.Forms.Label();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.label_PathInfo = new System.Windows.Forms.Label();
            this.listView_Items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Path
            // 
            this.label_Path.Location = new System.Drawing.Point(0, 0);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(338, 29);
            this.label_Path.TabIndex = 0;
            this.label_Path.Text = " ";
            this.label_Path.TextChanged += new System.EventHandler(this.label_Path_TextChanged);
            // 
            // button_Backwards
            // 
            this.button_Backwards.Location = new System.Drawing.Point(148, 32);
            this.button_Backwards.Name = "button_Backwards";
            this.button_Backwards.Size = new System.Drawing.Size(187, 21);
            this.button_Backwards.TabIndex = 1;
            this.button_Backwards.Text = "<<";
            this.button_Backwards.UseVisualStyleBackColor = true;
            this.button_Backwards.Click += new System.EventHandler(this.button_Backwards_Click);
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(59, 32);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(83, 21);
            this.comboBoxDrives.TabIndex = 2;
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_SelectedIndexChanged);
            this.comboBoxDrives.Click += new System.EventHandler(this.comboBoxDrives_Click);
            // 
            // label_PathInfo
            // 
            this.label_PathInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PathInfo.Location = new System.Drawing.Point(5, 34);
            this.label_PathInfo.Name = "label_PathInfo";
            this.label_PathInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PathInfo.Size = new System.Drawing.Size(48, 19);
            this.label_PathInfo.TabIndex = 3;
            this.label_PathInfo.Text = ":Drive";
            // 
            // listView_Items
            // 
            this.listView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Items.FullRowSelect = true;
            this.listView_Items.GridLines = true;
            this.listView_Items.LabelWrap = false;
            this.listView_Items.Location = new System.Drawing.Point(3, 56);
            this.listView_Items.MultiSelect = false;
            this.listView_Items.Name = "listView_Items";
            this.listView_Items.Size = new System.Drawing.Size(332, 395);
            this.listView_Items.TabIndex = 4;
            this.listView_Items.UseCompatibleStateImageBehavior = false;
            this.listView_Items.View = System.Windows.Forms.View.List;
            this.listView_Items.DoubleClick += new System.EventHandler(this.listView_Items_DoubleClick);
            this.listView_Items.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Items_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 310;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // TCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_Items);
            this.Controls.Add(this.label_PathInfo);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.button_Backwards);
            this.Controls.Add(this.label_Path);
            this.Name = "TCPanel";
            this.Size = new System.Drawing.Size(338, 454);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.Label label_PathInfo;
        private System.Windows.Forms.ListView listView_Items;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
    }
}
