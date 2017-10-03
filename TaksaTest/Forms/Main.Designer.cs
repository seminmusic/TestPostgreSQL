namespace TaksaTest.Forms
{
    partial class Main
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
            this.btnInsertTestData = new System.Windows.Forms.Button();
            this.txtBrojRecorda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGetData = new System.Windows.Forms.Label();
            this.lblInsertData = new System.Windows.Forms.Label();
            this.lblZavrseno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsertTestData
            // 
            this.btnInsertTestData.Location = new System.Drawing.Point(525, 12);
            this.btnInsertTestData.Name = "btnInsertTestData";
            this.btnInsertTestData.Size = new System.Drawing.Size(128, 25);
            this.btnInsertTestData.TabIndex = 0;
            this.btnInsertTestData.Text = "Insert Test Data";
            this.btnInsertTestData.UseVisualStyleBackColor = true;
            this.btnInsertTestData.Click += new System.EventHandler(this.btnInsertTestData_Click);
            // 
            // txtBrojRecorda
            // 
            this.txtBrojRecorda.Location = new System.Drawing.Point(413, 15);
            this.txtBrojRecorda.Name = "txtBrojRecorda";
            this.txtBrojRecorda.Size = new System.Drawing.Size(100, 20);
            this.txtBrojRecorda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj recorda:";
            // 
            // lblGetData
            // 
            this.lblGetData.Location = new System.Drawing.Point(343, 47);
            this.lblGetData.Name = "lblGetData";
            this.lblGetData.Size = new System.Drawing.Size(310, 20);
            this.lblGetData.TabIndex = 3;
            this.lblGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInsertData
            // 
            this.lblInsertData.Location = new System.Drawing.Point(343, 67);
            this.lblInsertData.Name = "lblInsertData";
            this.lblInsertData.Size = new System.Drawing.Size(310, 20);
            this.lblInsertData.TabIndex = 4;
            this.lblInsertData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZavrseno
            // 
            this.lblZavrseno.Location = new System.Drawing.Point(343, 87);
            this.lblZavrseno.Name = "lblZavrseno";
            this.lblZavrseno.Size = new System.Drawing.Size(310, 20);
            this.lblZavrseno.TabIndex = 5;
            this.lblZavrseno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 419);
            this.Controls.Add(this.lblZavrseno);
            this.Controls.Add(this.lblInsertData);
            this.Controls.Add(this.lblGetData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojRecorda);
            this.Controls.Add(this.btnInsertTestData);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taksa Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertTestData;
        private System.Windows.Forms.TextBox txtBrojRecorda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGetData;
        private System.Windows.Forms.Label lblInsertData;
        private System.Windows.Forms.Label lblZavrseno;
    }
}