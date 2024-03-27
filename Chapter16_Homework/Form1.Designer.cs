namespace Chapter16_Homework
{
    partial class frmDelivery
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
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblTracking = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecipient
            // 
            this.lblRecipient.AutoSize = true;
            this.lblRecipient.Location = new System.Drawing.Point(37, 46);
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Size = new System.Drawing.Size(80, 20);
            this.lblRecipient.TabIndex = 0;
            this.lblRecipient.Text = "Recipient";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Location = new System.Drawing.Point(37, 95);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(83, 20);
            this.lblSent.TabIndex = 1;
            this.lblSent.Text = "Sent Date";
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(37, 142);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(139, 20);
            this.lblTracking.TabIndex = 2;
            this.lblTracking.Text = "Tracking Number";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(32, 175);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(197, 16);
            this.lblFee.TabIndex = 3;
            this.lblFee.Text = "(Additional fee for certified letter)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(104, 220);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.txtTracking);
            this.grpInputs.Controls.Add(this.txtDate);
            this.grpInputs.Controls.Add(this.txtRecipient);
            this.grpInputs.Controls.Add(this.btnExit);
            this.grpInputs.Controls.Add(this.lblRecipient);
            this.grpInputs.Controls.Add(this.lblSent);
            this.grpInputs.Controls.Add(this.lblTracking);
            this.grpInputs.Controls.Add(this.lblFee);
            this.grpInputs.Controls.Add(this.btnClear);
            this.grpInputs.Controls.Add(this.btnSend);
            this.grpInputs.Location = new System.Drawing.Point(12, 12);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(295, 263);
            this.grpInputs.TabIndex = 7;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Inputs";
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(160, 46);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(100, 22);
            this.txtRecipient.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(160, 95);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 22);
            this.txtDate.TabIndex = 8;
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(160, 139);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(100, 22);
            this.txtTracking.TabIndex = 9;
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.lblOutput);
            this.grpOutputs.Location = new System.Drawing.Point(356, 12);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(612, 263);
            this.grpOutputs.TabIndex = 10;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Outputs";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(19, 33);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(18, 20);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "_";
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 282);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.grpInputs);
            this.Name = "frmDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter Delivery";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.Label lblOutput;
    }
}

