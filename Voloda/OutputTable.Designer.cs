namespace Voloda
{
    partial class Form1
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
            this.data_dgv = new System.Windows.Forms.DataGridView();
            this.get_gata_from_sql_btn = new System.Windows.Forms.Button();
            this.table_name_cbox = new System.Windows.Forms.ComboBox();
            this.column_name_lview = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // data_dgv
            // 
            this.data_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dgv.Location = new System.Drawing.Point(12, 41);
            this.data_dgv.Name = "data_dgv";
            this.data_dgv.Size = new System.Drawing.Size(347, 254);
            this.data_dgv.TabIndex = 0;
            // 
            // get_gata_from_sql_btn
            // 
            this.get_gata_from_sql_btn.Location = new System.Drawing.Point(12, 12);
            this.get_gata_from_sql_btn.Name = "get_gata_from_sql_btn";
            this.get_gata_from_sql_btn.Size = new System.Drawing.Size(75, 23);
            this.get_gata_from_sql_btn.TabIndex = 1;
            this.get_gata_from_sql_btn.Text = "Execute";
            this.get_gata_from_sql_btn.UseVisualStyleBackColor = true;
            this.get_gata_from_sql_btn.Click += new System.EventHandler(this.get_gata_from_sql_btn_Click);
            // 
            // table_name_cbox
            // 
            this.table_name_cbox.FormattingEnabled = true;
            this.table_name_cbox.Location = new System.Drawing.Point(93, 14);
            this.table_name_cbox.Name = "table_name_cbox";
            this.table_name_cbox.Size = new System.Drawing.Size(121, 21);
            this.table_name_cbox.TabIndex = 2;
            this.table_name_cbox.SelectedIndexChanged += new System.EventHandler(this.table_name_cbox_SelectedIndexChanged);
            this.table_name_cbox.SelectedValueChanged += new System.EventHandler(this.table_name_cbox_SelectedValueChanged);
            // 
            // column_name_lview
            // 
            this.column_name_lview.CheckBoxes = true;
            this.column_name_lview.HideSelection = false;
            this.column_name_lview.Location = new System.Drawing.Point(365, 41);
            this.column_name_lview.Name = "column_name_lview";
            this.column_name_lview.Size = new System.Drawing.Size(70, 254);
            this.column_name_lview.TabIndex = 3;
            this.column_name_lview.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 307);
            this.Controls.Add(this.column_name_lview);
            this.Controls.Add(this.table_name_cbox);
            this.Controls.Add(this.get_gata_from_sql_btn);
            this.Controls.Add(this.data_dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_dgv;
        private System.Windows.Forms.Button get_gata_from_sql_btn;
        private System.Windows.Forms.ComboBox table_name_cbox;
        private System.Windows.Forms.ListView column_name_lview;
    }
}

