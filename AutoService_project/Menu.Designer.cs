namespace AutoService_project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonEmployes = new System.Windows.Forms.Button();
            this.buttonServise = new System.Windows.Forms.Button();
            this.buttonProfessions = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelHello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(39, 277);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(242, 47);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonEmployes
            // 
            this.buttonEmployes.Location = new System.Drawing.Point(39, 340);
            this.buttonEmployes.Name = "buttonEmployes";
            this.buttonEmployes.Size = new System.Drawing.Size(242, 47);
            this.buttonEmployes.TabIndex = 1;
            this.buttonEmployes.Text = "Сотрудники";
            this.buttonEmployes.UseVisualStyleBackColor = true;
            this.buttonEmployes.Click += new System.EventHandler(this.buttonEmployes_Click);
            // 
            // buttonServise
            // 
            this.buttonServise.Location = new System.Drawing.Point(39, 404);
            this.buttonServise.Name = "buttonServise";
            this.buttonServise.Size = new System.Drawing.Size(242, 47);
            this.buttonServise.TabIndex = 2;
            this.buttonServise.Text = "Услуги";
            this.buttonServise.UseVisualStyleBackColor = true;
            this.buttonServise.Click += new System.EventHandler(this.buttonServise_Click);
            // 
            // buttonProfessions
            // 
            this.buttonProfessions.Location = new System.Drawing.Point(39, 466);
            this.buttonProfessions.Name = "buttonProfessions";
            this.buttonProfessions.Size = new System.Drawing.Size(242, 47);
            this.buttonProfessions.TabIndex = 3;
            this.buttonProfessions.Text = "Профессии";
            this.buttonProfessions.UseVisualStyleBackColor = true;
            this.buttonProfessions.Click += new System.EventHandler(this.buttonProfessions_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(39, 529);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(242, 47);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(21, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(281, 24);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Автомастерская \"Petushok\"";
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(139, 80);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 17);
            this.labelHello.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoService_project.Properties.Resources._0f7e8d3799cce8681;
            this.pictureBox1.Location = new System.Drawing.Point(39, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 170);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonProfessions);
            this.Controls.Add(this.buttonServise);
            this.Controls.Add(this.buttonEmployes);
            this.Controls.Add(this.buttonClients);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonEmployes;
        private System.Windows.Forms.Button buttonServise;
        private System.Windows.Forms.Button buttonProfessions;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

