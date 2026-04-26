
namespace OsuServerLauncher.Controls
{
  partial class AddServer
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
            txtName = new System.Windows.Forms.TextBox();
            txtDomain = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnAddServer = new System.Windows.Forms.Button();
            pictureBox = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 33);
            label1.TabIndex = 5;
            label1.Text = "Add Server";
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
            btnExit.Location = new System.Drawing.Point(348, 11);
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
            label2.Location = new System.Drawing.Point(23, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 7;
            label2.Text = "Server Name";
            label2.MouseDown += FormDraggable;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtName.ForeColor = System.Drawing.Color.White;
            txtName.Location = new System.Drawing.Point(129, 52);
            txtName.MaxLength = 32;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "e.g. \"EZPPFarm\"";
            txtName.Size = new System.Drawing.Size(254, 25);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtDomain
            // 
            txtDomain.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtDomain.ForeColor = System.Drawing.Color.White;
            txtDomain.Location = new System.Drawing.Point(129, 81);
            txtDomain.MaxLength = 64;
            txtDomain.Name = "txtDomain";
            txtDomain.PlaceholderText = "e.g. \"ez-pp.farm\"";
            txtDomain.Size = new System.Drawing.Size(254, 25);
            txtDomain.TabIndex = 1;
            txtDomain.TextChanged += txtDomain_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label5.Location = new System.Drawing.Point(12, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 15);
            label5.TabIndex = 10;
            label5.Text = "Server Domain";
            label5.MouseDown += FormDraggable;
            // 
            // btnAddServer
            // 
            btnAddServer.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            btnAddServer.Enabled = false;
            btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnAddServer.FlatAppearance.BorderSize = 2;
            btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(43, 43, 43);
            btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 38, 38);
            btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddServer.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnAddServer.ForeColor = System.Drawing.Color.White;
            btnAddServer.Location = new System.Drawing.Point(13, 149);
            btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddServer.Name = "btnAddServer";
            btnAddServer.Size = new System.Drawing.Size(370, 33);
            btnAddServer.TabIndex = 2;
            btnAddServer.TabStop = false;
            btnAddServer.Text = "Add Server";
            btnAddServer.UseVisualStyleBackColor = false;
            btnAddServer.Click += btnAddServer_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(135, 7);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(40, 37);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 15;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += FormDraggable;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            label3.Location = new System.Drawing.Point(12, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 15);
            label3.TabIndex = 16;
            label3.Text = "Custom Client Path";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            textBox1.ForeColor = System.Drawing.Color.White;
            textBox1.Location = new System.Drawing.Point(169, 109);
            textBox1.MaxLength = 64;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "e.g. \"D:\\DigitalClient\\\"";
            textBox1.Size = new System.Drawing.Size(214, 25);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddServer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(17, 17, 27);
            ClientSize = new System.Drawing.Size(396, 194);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox);
            Controls.Add(btnAddServer);
            Controls.Add(txtDomain);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddServer";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            MouseDown += FormDraggable;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtDomain;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnAddServer;
    private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}