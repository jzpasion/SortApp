namespace SortApp
{
    partial class formSort
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.radioMergeSort = new System.Windows.Forms.RadioButton();
            this.radioBubbleSort = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(84, 39);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(142, 20);
            this.txtInput.TabIndex = 0;
            // 
            // radioMergeSort
            // 
            this.radioMergeSort.AutoSize = true;
            this.radioMergeSort.Location = new System.Drawing.Point(64, 88);
            this.radioMergeSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMergeSort.Name = "radioMergeSort";
            this.radioMergeSort.Size = new System.Drawing.Size(77, 17);
            this.radioMergeSort.TabIndex = 1;
            this.radioMergeSort.TabStop = true;
            this.radioMergeSort.Text = "Merge Sort";
            this.radioMergeSort.UseVisualStyleBackColor = true;
            // 
            // radioBubbleSort
            // 
            this.radioBubbleSort.AutoSize = true;
            this.radioBubbleSort.Location = new System.Drawing.Point(175, 88);
            this.radioBubbleSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBubbleSort.Name = "radioBubbleSort";
            this.radioBubbleSort.Size = new System.Drawing.Size(80, 17);
            this.radioBubbleSort.TabIndex = 2;
            this.radioBubbleSort.TabStop = true;
            this.radioBubbleSort.Text = "Bubble Sort";
            this.radioBubbleSort.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(106, 130);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(90, 27);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Start Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(0, 195);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(302, 20);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Sorted";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(130, 172);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // formSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 234);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.radioBubbleSort);
            this.Controls.Add(this.radioMergeSort);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton radioMergeSort;
        private System.Windows.Forms.RadioButton radioBubbleSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblOutput;
    }
}

