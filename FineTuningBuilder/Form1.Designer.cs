namespace FineTuningBuilder
{
    partial class frm_Principal
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
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.txt_Prompt = new System.Windows.Forms.TextBox();
            this.txt_Completion = new System.Windows.Forms.TextBox();
            this.txt_FineTuning = new System.Windows.Forms.TextBox();
            this.lbl_Prompt = new System.Windows.Forms.Label();
            this.lbl_Completion = new System.Windows.Forms.Label();
            this.lbl_FineTuning = new System.Windows.Forms.Label();
            this.btn_Montar = new System.Windows.Forms.Button();
            this.pnl_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.Controls.Add(this.btn_Montar);
            this.pnl_Principal.Controls.Add(this.lbl_FineTuning);
            this.pnl_Principal.Controls.Add(this.lbl_Completion);
            this.pnl_Principal.Controls.Add(this.lbl_Prompt);
            this.pnl_Principal.Controls.Add(this.txt_FineTuning);
            this.pnl_Principal.Controls.Add(this.txt_Completion);
            this.pnl_Principal.Controls.Add(this.txt_Prompt);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_Principal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(1049, 675);
            this.pnl_Principal.TabIndex = 0;
            // 
            // txt_Prompt
            // 
            this.txt_Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Prompt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prompt.Location = new System.Drawing.Point(14, 42);
            this.txt_Prompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Prompt.Multiline = true;
            this.txt_Prompt.Name = "txt_Prompt";
            this.txt_Prompt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Prompt.Size = new System.Drawing.Size(1020, 83);
            this.txt_Prompt.TabIndex = 0;
            this.txt_Prompt.WordWrap = false;
            // 
            // txt_Completion
            // 
            this.txt_Completion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Completion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Completion.Location = new System.Drawing.Point(13, 176);
            this.txt_Completion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Completion.Multiline = true;
            this.txt_Completion.Name = "txt_Completion";
            this.txt_Completion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Completion.Size = new System.Drawing.Size(1020, 179);
            this.txt_Completion.TabIndex = 1;
            this.txt_Completion.WordWrap = false;
            // 
            // txt_FineTuning
            // 
            this.txt_FineTuning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FineTuning.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FineTuning.Location = new System.Drawing.Point(16, 409);
            this.txt_FineTuning.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FineTuning.Multiline = true;
            this.txt_FineTuning.Name = "txt_FineTuning";
            this.txt_FineTuning.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_FineTuning.Size = new System.Drawing.Size(1020, 249);
            this.txt_FineTuning.TabIndex = 3;
            this.txt_FineTuning.WordWrap = false;
            // 
            // lbl_Prompt
            // 
            this.lbl_Prompt.AutoSize = true;
            this.lbl_Prompt.Location = new System.Drawing.Point(12, 22);
            this.lbl_Prompt.Name = "lbl_Prompt";
            this.lbl_Prompt.Size = new System.Drawing.Size(49, 16);
            this.lbl_Prompt.TabIndex = 3;
            this.lbl_Prompt.Text = "Prompt";
            // 
            // lbl_Completion
            // 
            this.lbl_Completion.AutoSize = true;
            this.lbl_Completion.Location = new System.Drawing.Point(12, 156);
            this.lbl_Completion.Name = "lbl_Completion";
            this.lbl_Completion.Size = new System.Drawing.Size(72, 16);
            this.lbl_Completion.TabIndex = 4;
            this.lbl_Completion.Text = "Completion";
            // 
            // lbl_FineTuning
            // 
            this.lbl_FineTuning.AutoSize = true;
            this.lbl_FineTuning.Location = new System.Drawing.Point(11, 389);
            this.lbl_FineTuning.Name = "lbl_FineTuning";
            this.lbl_FineTuning.Size = new System.Drawing.Size(74, 16);
            this.lbl_FineTuning.TabIndex = 5;
            this.lbl_FineTuning.Text = "Fine Tuning";
            // 
            // btn_Montar
            // 
            this.btn_Montar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Montar.Location = new System.Drawing.Point(927, 362);
            this.btn_Montar.Name = "btn_Montar";
            this.btn_Montar.Size = new System.Drawing.Size(110, 43);
            this.btn_Montar.TabIndex = 2;
            this.btn_Montar.Text = "Montar";
            this.btn_Montar.UseVisualStyleBackColor = true;
            this.btn_Montar.Click += new System.EventHandler(this.btn_Montar_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 675);
            this.Controls.Add(this.pnl_Principal);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1065, 714);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fine Tuning Builder";
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Principal;
        private System.Windows.Forms.TextBox txt_FineTuning;
        private System.Windows.Forms.TextBox txt_Completion;
        private System.Windows.Forms.TextBox txt_Prompt;
        private System.Windows.Forms.Label lbl_FineTuning;
        private System.Windows.Forms.Label lbl_Completion;
        private System.Windows.Forms.Label lbl_Prompt;
        private System.Windows.Forms.Button btn_Montar;
    }
}

