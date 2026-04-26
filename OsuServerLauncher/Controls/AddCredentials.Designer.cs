
namespace OsuServerLauncher.Controls
{
  partial class AddCredentials
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
        private void InitializeComponent() {
            label1 = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnAddCredentials = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(13, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 33);
            label1.TabIndex = 5;
            label1.Text = "Add Credentials";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.MouseDown += FormDraggable;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.Location = new System.Drawing.Point(271, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(35, 33);
            btnExit.TabIndex = 6;
            btnExit.TabStop = false;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label2.Location = new System.Drawing.Point(9, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "Username";
            label2.MouseDown += FormDraggable;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtUsername.ForeColor = System.Drawing.Color.White;
            txtUsername.Location = new System.Drawing.Point(82, 52);
            txtUsername.MaxLength = 32;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(224, 25);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txt_TextChanged;
            txtUsername.KeyDown += txt_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.Location = new System.Drawing.Point(82, 81);
            txtPassword.MaxLength = 64;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(224, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txt_TextChanged;
            txtPassword.KeyDown += txt_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label5.Location = new System.Drawing.Point(9, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            label5.MouseDown += FormDraggable;
            // 
            // btnAddCredentials
            // 
            btnAddCredentials.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            btnAddCredentials.Enabled = false;
            btnAddCredentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnAddCredentials.FlatAppearance.BorderSize = 2;
            btnAddCredentials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnAddCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            btnAddCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddCredentials.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAddCredentials.ForeColor = System.Drawing.Color.White;
            btnAddCredentials.Location = new System.Drawing.Point(13, 112);
            btnAddCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddCredentials.Name = "btnAddCredentials";
            btnAddCredentials.Size = new System.Drawing.Size(293, 31);
            btnAddCredentials.TabIndex = 2;
            btnAddCredentials.TabStop = false;
            btnAddCredentials.Text = "Add Credentials";
            btnAddCredentials.UseVisualStyleBackColor = false;
            btnAddCredentials.Click += btnAddServer_Click;
            // 
            // AddCredentials
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(17, 17, 27);
            ClientSize = new System.Drawing.Size(319, 154);
            Controls.Add(btnAddCredentials);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCredentials";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MouseDown += FormDraggable;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAddCredentials;
  }
}