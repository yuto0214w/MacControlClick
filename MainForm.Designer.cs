
namespace MacControlClick
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoUpdate = new System.Windows.Forms.Timer(this.components);
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.runOnLogin = new System.Windows.Forms.CheckBox();
            this.minimizeOnStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // infoUpdate
            // 
            this.infoUpdate.Tick += new System.EventHandler(this.CheckInfo);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("メイリオ", 12F);
            this.descriptionLabel.Location = new System.Drawing.Point(14, 9);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(625, 120);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Mac って Control キー押しながらクリックすると右クリックできるじゃないですか。\r\nあれが Windows でもやりたかったので作りました。\r\nCtrl" +
    " キー押しながら左クリックです。\r\n自分で作っていうのもあれなんですがわりかしべんりですねこれ(自画自賛)\r\nみなさんもぜひ。";
            // 
            // runOnLogin
            // 
            this.runOnLogin.AutoSize = true;
            this.runOnLogin.Font = new System.Drawing.Font("メイリオ", 9F);
            this.runOnLogin.Location = new System.Drawing.Point(12, 132);
            this.runOnLogin.Name = "runOnLogin";
            this.runOnLogin.Size = new System.Drawing.Size(147, 22);
            this.runOnLogin.TabIndex = 1;
            this.runOnLogin.Text = "ログイン時に起動する";
            this.runOnLogin.UseVisualStyleBackColor = true;
            this.runOnLogin.CheckedChanged += new System.EventHandler(this.RunOnLoginCheckedChanged);
            // 
            // minimizeOnStart
            // 
            this.minimizeOnStart.AutoSize = true;
            this.minimizeOnStart.Font = new System.Drawing.Font("メイリオ", 9F);
            this.minimizeOnStart.Location = new System.Drawing.Point(165, 132);
            this.minimizeOnStart.Name = "minimizeOnStart";
            this.minimizeOnStart.Size = new System.Drawing.Size(111, 22);
            this.minimizeOnStart.TabIndex = 1;
            this.minimizeOnStart.Text = "起動時に最小化";
            this.minimizeOnStart.UseVisualStyleBackColor = true;
            this.minimizeOnStart.CheckedChanged += new System.EventHandler(this.MinimizeOnStartCheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 166);
            this.Controls.Add(this.minimizeOnStart);
            this.Controls.Add(this.runOnLogin);
            this.Controls.Add(this.descriptionLabel);
            this.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 205);
            this.MinimumSize = new System.Drawing.Size(669, 205);
            this.Name = "MainForm";
            this.Text = "Mac のあれを再現！";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer infoUpdate;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.CheckBox runOnLogin;
        private System.Windows.Forms.CheckBox minimizeOnStart;
    }
}

