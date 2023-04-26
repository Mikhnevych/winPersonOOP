namespace winPersonOOP.Presentation_Layer
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayAllPersons = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(267, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(266, 78);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllPersons
            // 
            this.btnDisplayAllPersons.Location = new System.Drawing.Point(267, 222);
            this.btnDisplayAllPersons.Name = "btnDisplayAllPersons";
            this.btnDisplayAllPersons.Size = new System.Drawing.Size(266, 78);
            this.btnDisplayAllPersons.TabIndex = 4;
            this.btnDisplayAllPersons.Text = "Display All Persons";
            this.btnDisplayAllPersons.UseVisualStyleBackColor = true;
            this.btnDisplayAllPersons.Click += new System.EventHandler(this.btnDisplayAllPersons_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(267, 119);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(266, 78);
            this.btnAddNewPerson.TabIndex = 3;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Menu";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayAllPersons);
            this.Controls.Add(this.btnAddNewPerson);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayAllPersons;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label label1;
    }
}