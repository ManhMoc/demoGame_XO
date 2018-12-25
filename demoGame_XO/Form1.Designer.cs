namespace demoGame_XO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.txtCot = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.grb = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số hàng";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số cột";
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(139, 13);
            this.txtHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(116, 21);
            this.txtHang.TabIndex = 2;
            // 
            // txtCot
            // 
            this.txtCot.Location = new System.Drawing.Point(399, 15);
            this.txtCot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCot.Name = "txtCot";
            this.txtCot.Size = new System.Drawing.Size(122, 21);
            this.txtCot.TabIndex = 3;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTao.Font = new System.Drawing.Font("Mistral", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(187, 46);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(162, 23);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo ";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // grb
            // 
            this.grb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grb.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.Location = new System.Drawing.Point(3, 75);
            this.grb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grb.Size = new System.Drawing.Size(559, 404);
            this.grb.TabIndex = 6;
            this.grb.TabStop = false;
            this.grb.Text = "Cờ Cá Rô";
            this.grb.Enter += new System.EventHandler(this.grb_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 491);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtCot);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mistral", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O_X_O_X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.TextBox txtCot;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox grb;
    }
}

