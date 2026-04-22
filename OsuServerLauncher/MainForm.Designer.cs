
namespace OsuServerLauncher
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      btnExit = new System.Windows.Forms.Button();
      pnlLauncher = new System.Windows.Forms.Panel();
      flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      panel1 = new System.Windows.Forms.Panel();
      btnAddRemoveCredentials = new System.Windows.Forms.Button();
      btnAddServer = new System.Windows.Forms.Button();
      btnRemoveServer = new System.Windows.Forms.Button();
      pnlAbout = new System.Windows.Forms.Panel();
      label2 = new System.Windows.Forms.Label();
      lblVersion = new System.Windows.Forms.Label();
      label7 = new System.Windows.Forms.Label();
      label4 = new System.Windows.Forms.Label();
      pctrDiscord = new System.Windows.Forms.PictureBox();
      label3 = new System.Windows.Forms.Label();
      pctrGithub = new System.Windows.Forms.PictureBox();
      label1 = new System.Windows.Forms.Label();
      pnlLauncher.SuspendLayout();
      panel1.SuspendLayout();
      pnlAbout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pctrDiscord).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pctrGithub).BeginInit();
      SuspendLayout();
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
      btnExit.Location = new System.Drawing.Point(494, 11);
      btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      btnExit.Name = "btnExit";
      btnExit.Size = new System.Drawing.Size(35, 33);
      btnExit.TabIndex = 0;
      btnExit.Text = "X";
      btnExit.UseVisualStyleBackColor = false;
      btnExit.Click += btnExit_Click;
      // 
      // pnlLauncher
      // 
      pnlLauncher.Controls.Add(flowLayoutPanel);
      pnlLauncher.Controls.Add(panel1);
      pnlLauncher.Location = new System.Drawing.Point(12, 49);
      pnlLauncher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      pnlLauncher.Name = "pnlLauncher";
      pnlLauncher.Size = new System.Drawing.Size(517, 236);
      pnlLauncher.TabIndex = 1;
      pnlLauncher.MouseDown += FormDraggable;
      // 
      // flowLayoutPanel
      // 
      flowLayoutPanel.AutoScroll = true;
      flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      flowLayoutPanel.Location = new System.Drawing.Point(40, 0);
      flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      flowLayoutPanel.Name = "flowLayoutPanel";
      flowLayoutPanel.Size = new System.Drawing.Size(477, 236);
      flowLayoutPanel.TabIndex = 9;
      flowLayoutPanel.MouseDown += FormDraggable;
      // 
      // panel1
      // 
      panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)17)), ((int)((byte)17)), ((int)((byte)27)));
      panel1.Controls.Add(btnAddRemoveCredentials);
      panel1.Controls.Add(btnAddServer);
      panel1.Controls.Add(btnRemoveServer);
      panel1.Dock = System.Windows.Forms.DockStyle.Left;
      panel1.Location = new System.Drawing.Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new System.Drawing.Size(40, 236);
      panel1.TabIndex = 10;
      // 
      // btnAddRemoveCredentials
      // 
      btnAddRemoveCredentials.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      btnAddRemoveCredentials.Enabled = false;
      btnAddRemoveCredentials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddRemoveCredentials.FlatAppearance.BorderSize = 2;
      btnAddRemoveCredentials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddRemoveCredentials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
      btnAddRemoveCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      btnAddRemoveCredentials.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      btnAddRemoveCredentials.ForeColor = System.Drawing.Color.White;
      btnAddRemoveCredentials.Location = new System.Drawing.Point(4, 76);
      btnAddRemoveCredentials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      btnAddRemoveCredentials.Name = "btnAddRemoveCredentials";
      btnAddRemoveCredentials.Size = new System.Drawing.Size(32, 30);
      btnAddRemoveCredentials.TabIndex = 8;
      btnAddRemoveCredentials.Text = "🔒";
      btnAddRemoveCredentials.UseVisualStyleBackColor = false;
      btnAddRemoveCredentials.Click += btnAddRemoveCredentials_Click;
      // 
      // btnAddServer
      // 
      btnAddServer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      btnAddServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddServer.FlatAppearance.BorderSize = 2;
      btnAddServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnAddServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
      btnAddServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      btnAddServer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      btnAddServer.ForeColor = System.Drawing.Color.White;
      btnAddServer.Location = new System.Drawing.Point(4, 5);
      btnAddServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      btnAddServer.Name = "btnAddServer";
      btnAddServer.Size = new System.Drawing.Size(32, 30);
      btnAddServer.TabIndex = 6;
      btnAddServer.Text = "+";
      btnAddServer.UseVisualStyleBackColor = false;
      btnAddServer.Click += btnAddServer_Click;
      // 
      // btnRemoveServer
      // 
      btnRemoveServer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)30)), ((int)((byte)46)));
      btnRemoveServer.Enabled = false;
      btnRemoveServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnRemoveServer.FlatAppearance.BorderSize = 2;
      btnRemoveServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)43)), ((int)((byte)43)));
      btnRemoveServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)38)), ((int)((byte)38)));
      btnRemoveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      btnRemoveServer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      btnRemoveServer.ForeColor = System.Drawing.Color.White;
      btnRemoveServer.Location = new System.Drawing.Point(4, 40);
      btnRemoveServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      btnRemoveServer.Name = "btnRemoveServer";
      btnRemoveServer.Size = new System.Drawing.Size(32, 30);
      btnRemoveServer.TabIndex = 7;
      btnRemoveServer.Text = "-";
      btnRemoveServer.UseVisualStyleBackColor = false;
      btnRemoveServer.Click += btnRemoveServer_Click;
      // 
      // pnlAbout
      // 
      pnlAbout.Controls.Add(label2);
      pnlAbout.Controls.Add(lblVersion);
      pnlAbout.Controls.Add(label7);
      pnlAbout.Controls.Add(label4);
      pnlAbout.Controls.Add(pctrDiscord);
      pnlAbout.Controls.Add(label3);
      pnlAbout.Controls.Add(pctrGithub);
      pnlAbout.Location = new System.Drawing.Point(12, 49);
      pnlAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      pnlAbout.Name = "pnlAbout";
      pnlAbout.Size = new System.Drawing.Size(517, 236);
      pnlAbout.TabIndex = 2;
      pnlAbout.MouseDown += FormDraggable;
      // 
      // label2
      // 
      label2.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
      label2.ForeColor = System.Drawing.Color.White;
      label2.Location = new System.Drawing.Point(4, 5);
      label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(509, 43);
      label2.TabIndex = 5;
      label2.Text = "osu! Server Launcher   ";
      label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      label2.MouseDown += FormDraggable;
      // 
      // lblVersion
      // 
      lblVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
      lblVersion.ForeColor = System.Drawing.Color.White;
      lblVersion.Location = new System.Drawing.Point(0, 44);
      lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      lblVersion.Name = "lblVersion";
      lblVersion.Size = new System.Drawing.Size(515, 29);
      lblVersion.TabIndex = 8;
      lblVersion.Text = "Version 1.0";
      lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      lblVersion.MouseDown += FormDraggable;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.ForeColor = System.Drawing.Color.DimGray;
      label7.Location = new System.Drawing.Point(3, 138);
      label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      label7.Name = "label7";
      label7.Size = new System.Drawing.Size(112, 14);
      label7.TabIndex = 7;
      label7.Text = "feat. big tesco";
      label7.MouseDown += FormDraggable;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.ForeColor = System.Drawing.Color.Gray;
      label4.Location = new System.Drawing.Point(3, 155);
      label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(231, 14);
      label4.TabIndex = 3;
      label4.Text = "Copyright (c) Niklas Fehde, 2021";
      label4.MouseDown += FormDraggable;
      // 
      // pctrDiscord
      // 
      pctrDiscord.Cursor = System.Windows.Forms.Cursors.Arrow;
      pctrDiscord.Image = ((System.Drawing.Image)resources.GetObject("pctrDiscord.Image"));
      pctrDiscord.Location = new System.Drawing.Point(356, 128);
      pctrDiscord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      pctrDiscord.Name = "pctrDiscord";
      pctrDiscord.Size = new System.Drawing.Size(64, 60);
      pctrDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      pctrDiscord.TabIndex = 2;
      pctrDiscord.TabStop = false;
      pctrDiscord.Click += pctrDiscord_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.ForeColor = System.Drawing.Color.White;
      label3.Location = new System.Drawing.Point(3, 172);
      label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(476, 14);
      label3.TabIndex = 1;
      label3.Text = "osu! Server Launcher is not affiliated in any way with ppy. Pty Ltd";
      label3.MouseDown += FormDraggable;
      // 
      // pctrGithub
      // 
      pctrGithub.Cursor = System.Windows.Forms.Cursors.Arrow;
      pctrGithub.Image = ((System.Drawing.Image)resources.GetObject("pctrGithub.Image"));
      pctrGithub.Location = new System.Drawing.Point(425, 128);
      pctrGithub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      pctrGithub.Name = "pctrGithub";
      pctrGithub.Size = new System.Drawing.Size(64, 60);
      pctrGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      pctrGithub.TabIndex = 0;
      pctrGithub.TabStop = false;
      pctrGithub.Click += pctrGithub_Click;
      // 
      // label1
      // 
      label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
      label1.ForeColor = System.Drawing.Color.White;
      label1.Location = new System.Drawing.Point(13, 9);
      label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(492, 33);
      label1.TabIndex = 4;
      label1.Text = "osu! Server Launcher   ";
      label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      label1.MouseDown += FormDraggable;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackColor = System.Drawing.Color.FromArgb(((int)((byte)17)), ((int)((byte)17)), ((int)((byte)27)));
      ClientSize = new System.Drawing.Size(542, 296);
      Controls.Add(btnExit);
      Controls.Add(label1);
      Controls.Add(pnlLauncher);
      Controls.Add(pnlAbout);
      FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      MaximizeBox = false;
      MinimizeBox = false;
      ShowIcon = false;
      StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      Text = "osu! Server Launcher";
      FormClosing += MainForm_FormClosing;
      Load += MainForm_Load;
      MouseDown += FormDraggable;
      pnlLauncher.ResumeLayout(false);
      panel1.ResumeLayout(false);
      pnlAbout.ResumeLayout(false);
      pnlAbout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pctrDiscord).EndInit();
      ((System.ComponentModel.ISupportInitialize)pctrGithub).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Panel pnlLauncher;
    private System.Windows.Forms.Panel pnlAbout;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pctrGithub;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pctrDiscord;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnAddServer;
    private System.Windows.Forms.Button btnRemoveServer;
    private System.Windows.Forms.Button btnAddRemoveCredentials;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.Panel panel1;
  }
}