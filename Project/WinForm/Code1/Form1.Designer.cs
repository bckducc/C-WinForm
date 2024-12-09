namespace Code1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SexForm = new System.Windows.Forms.CheckBox();
            this.DateForm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PickPicForm = new System.Windows.Forms.Button();
            this.UpdateForm = new System.Windows.Forms.Button();
            this.ShowForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh:";
            // 
            // SexForm
            // 
            this.SexForm.AutoSize = true;
            this.SexForm.Location = new System.Drawing.Point(434, 60);
            this.SexForm.Name = "SexForm";
            this.SexForm.Size = new System.Drawing.Size(94, 17);
            this.SexForm.TabIndex = 3;
            this.SexForm.Text = "Giới tính: Nam";
            this.SexForm.UseVisualStyleBackColor = true;
            // 
            // DateForm
            // 
            this.DateForm.CustomFormat = "dd/mm/yyyy";
            this.DateForm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateForm.Location = new System.Drawing.Point(39, 115);
            this.DateForm.Name = "DateForm";
            this.DateForm.Size = new System.Drawing.Size(248, 20);
            this.DateForm.TabIndex = 5;
            this.DateForm.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Môn học yêu thích";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(79, 196);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Ngôn ngữ lập trình";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(79, 265);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Môn học khác";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(79, 242);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(169, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Phân tích && Thiết kế hệ thống";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(79, 219);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(115, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Lập trình nâng cao";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(565, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tường tác người máy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 13;
            // 
            // PickPicForm
            // 
            this.PickPicForm.Location = new System.Drawing.Point(580, 326);
            this.PickPicForm.Name = "PickPicForm";
            this.PickPicForm.Size = new System.Drawing.Size(75, 23);
            this.PickPicForm.TabIndex = 14;
            this.PickPicForm.Text = "Chọn ảnh";
            this.PickPicForm.UseVisualStyleBackColor = true;
            // 
            // UpdateForm
            // 
            this.UpdateForm.Location = new System.Drawing.Point(661, 326);
            this.UpdateForm.Name = "UpdateForm";
            this.UpdateForm.Size = new System.Drawing.Size(75, 23);
            this.UpdateForm.TabIndex = 15;
            this.UpdateForm.Text = "Cập nhật";
            this.UpdateForm.UseVisualStyleBackColor = true;
            // 
            // ShowForm
            // 
            this.ShowForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowForm.Location = new System.Drawing.Point(12, 409);
            this.ShowForm.Name = "ShowForm";
            this.ShowForm.Size = new System.Drawing.Size(809, 94);
            this.ShowForm.TabIndex = 16;
            this.ShowForm.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 512);
            this.Controls.Add(this.ShowForm);
            this.Controls.Add(this.UpdateForm);
            this.Controls.Add(this.PickPicForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateForm);
            this.Controls.Add(this.SexForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SexForm;
        private System.Windows.Forms.DateTimePicker DateForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PickPicForm;
        private System.Windows.Forms.Button UpdateForm;
        private System.Windows.Forms.Label ShowForm;
    }
}

