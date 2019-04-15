namespace TCommanderKrupa
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ButtonMove = new System.Windows.Forms.Button();
            this.tcPanelRight = new TCommanderKrupa.TCPanel();
            this.tcPanelLeft = new TCommanderKrupa.TCPanel();
            this.SuspendLayout();
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Location = new System.Drawing.Point(265, 462);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(75, 23);
            this.ButtonCopy.TabIndex = 2;
            this.ButtonCopy.Text = "Copy";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonMove
            // 
            this.ButtonMove.Location = new System.Drawing.Point(355, 462);
            this.ButtonMove.Name = "ButtonMove";
            this.ButtonMove.Size = new System.Drawing.Size(75, 23);
            this.ButtonMove.TabIndex = 3;
            this.ButtonMove.Text = "Move";
            this.ButtonMove.UseVisualStyleBackColor = true;
            this.ButtonMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // tcPanelRight
            // 
            this.tcPanelRight.CurrentPath = " ";
            this.tcPanelRight.Items = new string[0];
            this.tcPanelRight.Location = new System.Drawing.Point(355, 2);
            this.tcPanelRight.Name = "tcPanelRight";
            this.tcPanelRight.Size = new System.Drawing.Size(338, 454);
            this.tcPanelRight.TabIndex = 1;
            this.tcPanelRight.Click += new System.EventHandler(this.tcPanelRight_Click);
            this.tcPanelRight.Enter += new System.EventHandler(this.tcPanelRight_Click);
            // 
            // tcPanelLeft
            // 
            this.tcPanelLeft.CurrentPath = " ";
            this.tcPanelLeft.Items = new string[0];
            this.tcPanelLeft.Location = new System.Drawing.Point(2, 2);
            this.tcPanelLeft.Name = "tcPanelLeft";
            this.tcPanelLeft.Size = new System.Drawing.Size(338, 454);
            this.tcPanelLeft.TabIndex = 0;
            this.tcPanelLeft.Click += new System.EventHandler(this.tcPanelLeft_Click);
            this.tcPanelLeft.Enter += new System.EventHandler(this.tcPanelLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(697, 494);
            this.Controls.Add(this.ButtonMove);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.tcPanelRight);
            this.Controls.Add(this.tcPanelLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TCPanel tcPanelLeft;
        private TCPanel tcPanelRight;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Button ButtonMove;
    }
}

