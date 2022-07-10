namespace Day16WindowsFormsApp
{
    partial class DataviewOperations
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
            this.lblTestScore = new System.Windows.Forms.Label();
            this.dataGridCandidate = new System.Windows.Forms.DataGridView();
            this.comboTestScore = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestScore.Location = new System.Drawing.Point(154, 84);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(185, 16);
            this.lblTestScore.TabIndex = 1;
            this.lblTestScore.Text = "Select Test Score Range ";
            // 
            // dataGridCandidate
            // 
            this.dataGridCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCandidate.Location = new System.Drawing.Point(40, 186);
            this.dataGridCandidate.Name = "dataGridCandidate";
            this.dataGridCandidate.Size = new System.Drawing.Size(688, 241);
            this.dataGridCandidate.TabIndex = 2;
            // 
            // comboTestScore
            // 
            this.comboTestScore.FormattingEnabled = true;
            this.comboTestScore.Location = new System.Drawing.Point(361, 83);
            this.comboTestScore.Name = "comboTestScore";
            this.comboTestScore.Size = new System.Drawing.Size(213, 21);
            this.comboTestScore.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(609, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DataviewOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboTestScore);
            this.Controls.Add(this.dataGridCandidate);
            this.Controls.Add(this.lblTestScore);
            this.Name = "DataviewOperations";
            this.Text = "DataviewOperations";
            this.Load += new System.EventHandler(this.DataviewOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.DataGridView dataGridCandidate;
        private System.Windows.Forms.ComboBox comboTestScore;
        private System.Windows.Forms.Button btnSearch;
    }
}