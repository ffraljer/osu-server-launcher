
namespace OsuServerLauncher.Controls
{
  partial class ServerItem
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerItem));
      lblName = new System.Windows.Forms.Label();
      pictureIcon = new System.Windows.Forms.PictureBox();
      pictureLock = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)pictureIcon).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureLock).BeginInit();
      SuspendLayout();
      // 
      // lblName
      // 
      lblName.ForeColor = System.Drawing.Color.White;
      lblName.Location = new System.Drawing.Point(3, 70);
      lblName.Name = "lblName";
      lblName.Size = new System.Drawing.Size(93, 21);
      lblName.TabIndex = 0;
      lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureIcon
      // 
      pictureIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      pictureIcon.Location = new System.Drawing.Point(16, 7);
      pictureIcon.Name = "pictureIcon";
      pictureIcon.Size = new System.Drawing.Size(64, 60);
      pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      pictureIcon.TabIndex = 1;
      pictureIcon.TabStop = false;
      // 
      // pictureLock
      // 
      pictureLock.BackColor = System.Drawing.Color.Transparent;
      pictureLock.Image = ((System.Drawing.Image)resources.GetObject("pictureLock.Image"));
      pictureLock.Location = new System.Drawing.Point(40, 32);
      pictureLock.Name = "pictureLock";
      pictureLock.Size = new System.Drawing.Size(24, 30);
      pictureLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      pictureLock.TabIndex = 2;
      pictureLock.TabStop = false;
      // 
      // ServerItem
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      BackColor = System.Drawing.Color.FromArgb(((int)((byte)24)), ((int)((byte)24)), ((int)((byte)37)));
      Controls.Add(pictureLock);
      Controls.Add(pictureIcon);
      Controls.Add(lblName);
      Size = new System.Drawing.Size(96, 90);
      ((System.ComponentModel.ISupportInitialize)pictureIcon).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureLock).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.PictureBox pictureIcon;
    private System.Windows.Forms.PictureBox pictureLock;
  }
}
