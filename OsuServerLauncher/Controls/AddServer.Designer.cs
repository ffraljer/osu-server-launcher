
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
      btnExit.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnExit.FlatAppearance.BorderSize = 2;
      btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)53)), ((int)((byte)69)));
      btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      btnExit.ForeColor = System.Drawing.Color.White;
      btnExit.Location = new System.Drawing.Point(297, 11);
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
      txtName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      txtName.ForeColor = System.Drawing.Color.White;
      txtName.Location = new System.Drawing.Point(129, 52);
      txtName.MaxLength = 32;
      txtName.Name = "txtName";
      txtName.PlaceholderText = "e.g. \"EZPPFarm\"";
      txtName.Size = new System.Drawing.Size(159, 25);
      txtName.TabIndex = 0;
      txtName.TextChanged += txtName_TextChanged;
      // 
      // txtDomain
      // 
      txtDomain.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      txtDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      txtDomain.ForeColor = System.Drawing.Color.White;
      txtDomain.Location = new System.Drawing.Point(129, 81);
      txtDomain.MaxLength = 64;
      txtDomain.Name = "txtDomain";
      txtDomain.PlaceholderText = "e.g. \"ez-pp.farm\"";
      txtDomain.Size = new System.Drawing.Size(159, 25);
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
      btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      btnAddServer.Enabled = false;
      btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddServer.FlatAppearance.BorderSize = 2;
      btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
      btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      btnAddServer.Font = new System.Drawing.Font("Segoe UI", 12F);
      btnAddServer.ForeColor = System.Drawing.Color.White;
      btnAddServer.Location = new System.Drawing.Point(13, 110);
      btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      btnAddServer.Name = "btnAddServer";
      btnAddServer.Size = new System.Drawing.Size(319, 33);
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
      // AddServer
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackColor = System.Drawing.Color.FromArgb(((int)((byte)17)), ((int)((byte)17)), ((int)((byte)27)));
      ClientSize = new System.Drawing.Size(341, 153);
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
  }
}