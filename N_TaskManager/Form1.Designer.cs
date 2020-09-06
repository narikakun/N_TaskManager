namespace N_TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workmem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.filename,
            this.totaltime,
            this.workmem,
            this.responding});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(776, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "プロセス名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "プロセスID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // filename
            // 
            this.filename.HeaderText = "ファイル名";
            this.filename.MinimumWidth = 20;
            this.filename.Name = "filename";
            this.filename.ReadOnly = true;
            // 
            // totaltime
            // 
            this.totaltime.HeaderText = "合計プロセッサ時間";
            this.totaltime.MinimumWidth = 10;
            this.totaltime.Name = "totaltime";
            this.totaltime.ReadOnly = true;
            // 
            // workmem
            // 
            this.workmem.HeaderText = "物理メモリ使用量";
            this.workmem.MinimumWidth = 10;
            this.workmem.Name = "workmem";
            this.workmem.ReadOnly = true;
            // 
            // responding
            // 
            this.responding.HeaderText = "応答状態";
            this.responding.Name = "responding";
            this.responding.ReadOnly = true;
            // 
            // get_button
            // 
            this.get_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.get_button.Location = new System.Drawing.Point(12, 414);
            this.get_button.Name = "get_button";
            this.get_button.Size = new System.Drawing.Size(75, 23);
            this.get_button.TabIndex = 3;
            this.get_button.Text = "取得";
            this.get_button.UseVisualStyleBackColor = true;
            this.get_button.Click += new System.EventHandler(this.get_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 19);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "強制終了";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.get_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn workmem;
        private System.Windows.Forms.DataGridViewTextBoxColumn responding;
        private System.Windows.Forms.Button get_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

