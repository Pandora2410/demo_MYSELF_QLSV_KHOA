namespace demo
{
    partial class frm_khoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.dgv_khoa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tk);
            this.groupBox1.Controls.Add(this.txt_sl);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "So Luong";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(137, 89);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(194, 27);
            this.txt_mk.TabIndex = 3;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(137, 231);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(194, 27);
            this.txt_sl.TabIndex = 5;
            // 
            // dgv_khoa
            // 
            this.dgv_khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoa.Location = new System.Drawing.Point(402, 93);
            this.dgv_khoa.Name = "dgv_khoa";
            this.dgv_khoa.RowHeadersWidth = 51;
            this.dgv_khoa.RowTemplate.Height = 24;
            this.dgv_khoa.Size = new System.Drawing.Size(524, 379);
            this.dgv_khoa.TabIndex = 1;
            this.dgv_khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khoa_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(183, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "QUẢN LÝ THÔNG TIN CÁC KHOA";
            // 
            // btn_add_update
            // 
            this.btn_add_update.Location = new System.Drawing.Point(63, 437);
            this.btn_add_update.Name = "btn_add_update";
            this.btn_add_update.Size = new System.Drawing.Size(119, 35);
            this.btn_add_update.TabIndex = 3;
            this.btn_add_update.Text = "Them/Sua";
            this.btn_add_update.UseVisualStyleBackColor = true;
            this.btn_add_update.Click += new System.EventHandler(this.btn_add_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(226, 437);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(105, 35);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Xoa";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(760, 513);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(84, 35);
            this.btn_end.TabIndex = 5;
            this.btn_end.Text = "Thoat";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(137, 160);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(194, 27);
            this.txt_tk.TabIndex = 6;
            // 
            // frm_khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_khoa);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_khoa";
            this.Text = "Form_Khoa";
            this.Load += new System.EventHandler(this.frm_khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.DataGridView dgv_khoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_update;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_tk;
    }
}