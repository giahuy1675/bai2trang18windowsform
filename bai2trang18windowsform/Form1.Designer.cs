using System;

namespace bai2trang18windowsform
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
            this.txb_MSSV = new System.Windows.Forms.RichTextBox();
            this.txb_HoTen = new System.Windows.Forms.RichTextBox();
            this.txb_Diem = new System.Windows.Forms.RichTextBox();
            this.cb_ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_TongNam = new System.Windows.Forms.RichTextBox();
            this.txb_TongNu = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Nam = new System.Windows.Forms.RadioButton();
            this.cb_Nu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_MSSV.Location = new System.Drawing.Point(79, 65);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.Size = new System.Drawing.Size(188, 43);
            this.txb_MSSV.TabIndex = 0;
            this.txb_MSSV.Text = "";
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_HoTen.Location = new System.Drawing.Point(79, 148);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(296, 43);
            this.txb_HoTen.TabIndex = 1;
            this.txb_HoTen.Text = "";
            // 
            // txb_Diem
            // 
            this.txb_Diem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Diem.Location = new System.Drawing.Point(380, 65);
            this.txb_Diem.Name = "txb_Diem";
            this.txb_Diem.Size = new System.Drawing.Size(155, 43);
            this.txb_Diem.TabIndex = 2;
            this.txb_Diem.Text = "";
            // 
            // cb_ChuyenNganh
            // 
            this.cb_ChuyenNganh.FormattingEnabled = true;
            this.cb_ChuyenNganh.Location = new System.Drawing.Point(79, 232);
            this.cb_ChuyenNganh.Name = "cb_ChuyenNganh";
            this.cb_ChuyenNganh.Size = new System.Drawing.Size(170, 24);
            this.cb_ChuyenNganh.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::bai2trang18windowsform.Properties.Resources.sum_32px;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(79, 300);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 55);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(79, 361);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 55);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(202, 300);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(117, 55);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(554, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 354);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới tính";
            // 
            // txb_TongNam
            // 
            this.txb_TongNam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TongNam.Location = new System.Drawing.Point(50, 467);
            this.txb_TongNam.Name = "txb_TongNam";
            this.txb_TongNam.Size = new System.Drawing.Size(188, 43);
            this.txb_TongNam.TabIndex = 14;
            this.txb_TongNam.Text = "";
            // 
            // txb_TongNu
            // 
            this.txb_TongNu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_TongNu.Location = new System.Drawing.Point(309, 467);
            this.txb_TongNu.Name = "txb_TongNu";
            this.txb_TongNu.Size = new System.Drawing.Size(188, 43);
            this.txb_TongNu.TabIndex = 15;
            this.txb_TongNu.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tổng nam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng nữ";
            // 
            // cb_Nam
            // 
            this.cb_Nam.AutoSize = true;
            this.cb_Nam.Location = new System.Drawing.Point(79, 199);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(57, 20);
            this.cb_Nam.TabIndex = 18;
            this.cb_Nam.TabStop = true;
            this.cb_Nam.Text = "Nam";
            this.cb_Nam.UseVisualStyleBackColor = true;
            // 
            // cb_Nu
            // 
            this.cb_Nu.AutoSize = true;
            this.cb_Nu.Location = new System.Drawing.Point(152, 199);
            this.cb_Nu.Name = "cb_Nu";
            this.cb_Nu.Size = new System.Drawing.Size(45, 20);
            this.cb_Nu.TabIndex = 19;
            this.cb_Nu.TabStop = true;
            this.cb_Nu.Text = "Nữ";
            this.cb_Nu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 565);
            this.Controls.Add(this.cb_Nu);
            this.Controls.Add(this.cb_Nam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_TongNu);
            this.Controls.Add(this.txb_TongNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_ChuyenNganh);
            this.Controls.Add(this.txb_Diem);
            this.Controls.Add(this.txb_HoTen);
            this.Controls.Add(this.txb_MSSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.RichTextBox txb_MSSV;
        private System.Windows.Forms.RichTextBox txb_HoTen;
        private System.Windows.Forms.RichTextBox txb_Diem;
        private System.Windows.Forms.ComboBox cb_ChuyenNganh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txb_TongNam;
        private System.Windows.Forms.RichTextBox txb_TongNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton cb_Nam;
        private System.Windows.Forms.RadioButton cb_Nu;
    }
}

