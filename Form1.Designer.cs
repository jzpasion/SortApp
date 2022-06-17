namespace SortApp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.radioQuickSort = new System.Windows.Forms.RadioButton();
            this.radioBubbleSort = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(113, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 22);
            this.txtInput.TabIndex = 0;
            // 
            // radioQuickSort
            // 
            this.radioQuickSort.AutoSize = true;
            this.radioQuickSort.Location = new System.Drawing.Point(86, 108);
            this.radioQuickSort.Name = "radioQuickSort";
            this.radioQuickSort.Size = new System.Drawing.Size(89, 20);
            this.radioQuickSort.TabIndex = 1;
            this.radioQuickSort.TabStop = true;
            this.radioQuickSort.Text = "Quick Sort";
            this.radioQuickSort.UseVisualStyleBackColor = true;
            // 
            // radioBubbleSort
            // 
            this.radioBubbleSort.AutoSize = true;
            this.radioBubbleSort.Location = new System.Drawing.Point(233, 108);
            this.radioBubbleSort.Name = "radioBubbleSort";
            this.radioBubbleSort.Size = new System.Drawing.Size(98, 20);
            this.radioBubbleSort.TabIndex = 2;
            this.radioBubbleSort.TabStop = true;
            this.radioBubbleSort.Text = "Bubble Sort";
            this.radioBubbleSort.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(139, 160);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(120, 33);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Start Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(171, 224);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(51, 16);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 330);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.radioBubbleSort);
            this.Controls.Add(this.radioQuickSort);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton radioQuickSort;
        private System.Windows.Forms.RadioButton radioBubbleSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblAnswer;
    }
}

