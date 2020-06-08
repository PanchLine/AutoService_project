namespace AutoService_project
{
    partial class FormProfession
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelProfessionName = new System.Windows.Forms.Label();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.listViewProfessions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(236, 495);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(95, 35);
            this.buttonDel.TabIndex = 30;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(135, 495);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 35);
            this.buttonEdit.TabIndex = 29;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 495);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 35);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProfessionName
            // 
            this.labelProfessionName.AutoSize = true;
            this.labelProfessionName.Location = new System.Drawing.Point(91, 169);
            this.labelProfessionName.Name = "labelProfessionName";
            this.labelProfessionName.Size = new System.Drawing.Size(183, 17);
            this.labelProfessionName.TabIndex = 31;
            this.labelProfessionName.Text = "Наименование профессии";
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Location = new System.Drawing.Point(81, 189);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.Size = new System.Drawing.Size(194, 22);
            this.textBoxProfession.TabIndex = 32;
            // 
            // listViewProfessions
            // 
            this.listViewProfessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewProfessions.FullRowSelect = true;
            this.listViewProfessions.GridLines = true;
            this.listViewProfessions.HideSelection = false;
            this.listViewProfessions.Location = new System.Drawing.Point(37, 217);
            this.listViewProfessions.MultiSelect = false;
            this.listViewProfessions.Name = "listViewProfessions";
            this.listViewProfessions.Size = new System.Drawing.Size(294, 257);
            this.listViewProfessions.TabIndex = 33;
            this.listViewProfessions.UseCompatibleStateImageBehavior = false;
            this.listViewProfessions.View = System.Windows.Forms.View.Details;
            this.listViewProfessions.SelectedIndexChanged += new System.EventHandler(this.listViewProfessions_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Профессия";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoService_project.Properties.Resources._0f7e8d3799cce8681;
            this.pictureBox1.Location = new System.Drawing.Point(80, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 155);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // FormProfession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProfessions);
            this.Controls.Add(this.textBoxProfession);
            this.Controls.Add(this.labelProfessionName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormProfession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профессии";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelProfessionName;
        private System.Windows.Forms.TextBox textBoxProfession;
        private System.Windows.Forms.ListView listViewProfessions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}