namespace OSBT_Std_Management
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.ForeColor = System.Drawing.Color.Black;
            this.pbar.InnerColor = System.Drawing.Color.OldLace;
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(305, 180);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.Gray;
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 26;
            this.pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbar.ProgressWidth = 18;
            this.pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.Size = new System.Drawing.Size(346, 340);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.SubscriptColor = System.Drawing.Color.Silver;
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "";
            this.pbar.TabIndex = 0;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(2)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(970, 621);
            this.Controls.Add(this.pbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
    }
}