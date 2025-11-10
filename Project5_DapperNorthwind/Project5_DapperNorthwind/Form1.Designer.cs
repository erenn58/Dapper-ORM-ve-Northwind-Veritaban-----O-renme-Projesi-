namespace Project5_DapperNorthwind
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
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncratecategory = new System.Windows.Forms.Button();
            this.txtcategoryname = new System.Windows.Forms.TextBox();
            this.txtcatedes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcategoryıd = new System.Windows.Forms.TextBox();
            this.btncategoryDelete = new System.Windows.Forms.Button();
            this.lblcategorycount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblproductcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(410, 7);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(163, 23);
            this.btnCategoryList.TabIndex = 0;
            this.btnCategoryList.Text = "Kategori Listesi";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // btncratecategory
            // 
            this.btncratecategory.Location = new System.Drawing.Point(410, 41);
            this.btncratecategory.Name = "btncratecategory";
            this.btncratecategory.Size = new System.Drawing.Size(163, 23);
            this.btncratecategory.TabIndex = 2;
            this.btncratecategory.Text = "Kategori Ekle";
            this.btncratecategory.UseVisualStyleBackColor = true;
            this.btncratecategory.Click += new System.EventHandler(this.btncratecategory_Click);
            // 
            // txtcategoryname
            // 
            this.txtcategoryname.Location = new System.Drawing.Point(120, 38);
            this.txtcategoryname.Name = "txtcategoryname";
            this.txtcategoryname.Size = new System.Drawing.Size(205, 20);
            this.txtcategoryname.TabIndex = 3;
            // 
            // txtcatedes
            // 
            this.txtcatedes.Location = new System.Drawing.Point(120, 68);
            this.txtcatedes.Multiline = true;
            this.txtcatedes.Name = "txtcatedes";
            this.txtcatedes.Size = new System.Drawing.Size(205, 79);
            this.txtcatedes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Açıklaması:";
            // 
            // txtcategoryıd
            // 
            this.txtcategoryıd.Location = new System.Drawing.Point(120, 7);
            this.txtcategoryıd.Name = "txtcategoryıd";
            this.txtcategoryıd.Size = new System.Drawing.Size(205, 20);
            this.txtcategoryıd.TabIndex = 8;
            // 
            // btncategoryDelete
            // 
            this.btncategoryDelete.Location = new System.Drawing.Point(410, 71);
            this.btncategoryDelete.Name = "btncategoryDelete";
            this.btncategoryDelete.Size = new System.Drawing.Size(163, 23);
            this.btncategoryDelete.TabIndex = 9;
            this.btncategoryDelete.Text = "Sil";
            this.btncategoryDelete.UseVisualStyleBackColor = true;
            this.btncategoryDelete.Click += new System.EventHandler(this.btncategoryDelete_Click);
            // 
            // lblcategorycount
            // 
            this.lblcategorycount.AutoSize = true;
            this.lblcategorycount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcategorycount.Location = new System.Drawing.Point(6, 68);
            this.lblcategorycount.Name = "lblcategorycount";
            this.lblcategorycount.Size = new System.Drawing.Size(0, 24);
            this.lblcategorycount.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblproductcount);
            this.groupBox1.Controls.Add(this.lblcategorycount);
            this.groupBox1.Location = new System.Drawing.Point(638, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 431);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dapper İstatistikler";
            // 
            // lblproductcount
            // 
            this.lblproductcount.AutoSize = true;
            this.lblproductcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblproductcount.Location = new System.Drawing.Point(6, 168);
            this.lblproductcount.Name = "lblproductcount";
            this.lblproductcount.Size = new System.Drawing.Size(0, 24);
            this.lblproductcount.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncategoryDelete);
            this.Controls.Add(this.txtcategoryıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcatedes);
            this.Controls.Add(this.txtcategoryname);
            this.Controls.Add(this.btncratecategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCategoryList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncratecategory;
        private System.Windows.Forms.TextBox txtcategoryname;
        private System.Windows.Forms.TextBox txtcatedes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcategoryıd;
        private System.Windows.Forms.Button btncategoryDelete;
        private System.Windows.Forms.Label lblcategorycount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblproductcount;
    }
}

