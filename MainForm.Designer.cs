
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
            this.SuspendLayout();
            // 
            // infoUpdate
            // 
            this.infoUpdate.Tick += new System.EventHandler(this.CheckInfo);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 138);
            this.Controls.Add(this.descriptionLabel);
            this.Font = new System.Drawing.Font("メイリオ", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(669, 177);
            this.MinimumSize = new System.Drawing.Size(669, 177);
            this.Name = "MainForm";
            this.Text = "Mac のあれを再現！";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer infoUpdate;
        private System.Windows.Forms.Label descriptionLabel;
    }
}

