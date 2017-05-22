namespace MainForm
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
            this.addNodeButton = new System.Windows.Forms.Button();
            this.firstNodeBox = new System.Windows.Forms.ComboBox();
            this.secondNodeBox = new System.Windows.Forms.ComboBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.addPathButton = new System.Windows.Forms.Button();
            this.currentRouters = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.router = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNodeButton
            // 
            this.addNodeButton.Location = new System.Drawing.Point(12, 12);
            this.addNodeButton.Name = "addNodeButton";
            this.addNodeButton.Size = new System.Drawing.Size(75, 23);
            this.addNodeButton.TabIndex = 0;
            this.addNodeButton.Text = "Add node";
            this.addNodeButton.UseVisualStyleBackColor = true;
            this.addNodeButton.Click += new System.EventHandler(this.addNodeButton_Click);
            // 
            // firstNodeBox
            // 
            this.firstNodeBox.FormattingEnabled = true;
            this.firstNodeBox.Location = new System.Drawing.Point(380, 23);
            this.firstNodeBox.Name = "firstNodeBox";
            this.firstNodeBox.Size = new System.Drawing.Size(121, 21);
            this.firstNodeBox.TabIndex = 1;
            // 
            // secondNodeBox
            // 
            this.secondNodeBox.FormattingEnabled = true;
            this.secondNodeBox.Location = new System.Drawing.Point(380, 63);
            this.secondNodeBox.Name = "secondNodeBox";
            this.secondNodeBox.Size = new System.Drawing.Size(121, 21);
            this.secondNodeBox.TabIndex = 2;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(380, 101);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 3;
            // 
            // addPathButton
            // 
            this.addPathButton.Location = new System.Drawing.Point(380, 141);
            this.addPathButton.Name = "addPathButton";
            this.addPathButton.Size = new System.Drawing.Size(75, 23);
            this.addPathButton.TabIndex = 4;
            this.addPathButton.Text = "Add path";
            this.addPathButton.UseVisualStyleBackColor = true;
            this.addPathButton.Click += new System.EventHandler(this.addPathButton_Click);
            // 
            // currentRouters
            // 
            this.currentRouters.FormattingEnabled = true;
            this.currentRouters.Location = new System.Drawing.Point(77, 101);
            this.currentRouters.Name = "currentRouters";
            this.currentRouters.Size = new System.Drawing.Size(121, 21);
            this.currentRouters.TabIndex = 5;
            this.currentRouters.SelectedIndexChanged += new System.EventHandler(this.currentRouters_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.router,
            this.weight});
            this.dataGridView1.Location = new System.Drawing.Point(45, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // router
            // 
            this.router.HeaderText = "Router";
            this.router.Name = "router";
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.currentRouters);
            this.Controls.Add(this.addPathButton);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.secondNodeBox);
            this.Controls.Add(this.firstNodeBox);
            this.Controls.Add(this.addNodeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.ComboBox firstNodeBox;
        private System.Windows.Forms.ComboBox secondNodeBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.Button addPathButton;
        private System.Windows.Forms.ComboBox currentRouters;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn router;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
    }
}

