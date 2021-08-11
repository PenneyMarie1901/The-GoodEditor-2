
namespace TheGoodEditor2.AboutAssets
{
    partial class WhatIsGenRawBlob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatIsGenRawBlob));
            this.grpAboutText = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAboutAsset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.whatIsText = new System.Windows.Forms.Label();
            this.grpAboutText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAboutText
            // 
            this.grpAboutText.Controls.Add(this.label2);
            this.grpAboutText.Controls.Add(this.txtAboutAsset);
            this.grpAboutText.Controls.Add(this.label1);
            this.grpAboutText.Controls.Add(this.whatIsText);
            this.grpAboutText.Location = new System.Drawing.Point(12, 12);
            this.grpAboutText.Name = "grpAboutText";
            this.grpAboutText.Size = new System.Drawing.Size(824, 509);
            this.grpAboutText.TabIndex = 5;
            this.grpAboutText.TabStop = false;
            this.grpAboutText.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Editable? - Somewhat.";
            // 
            // txtAboutAsset
            // 
            this.txtAboutAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAboutAsset.Location = new System.Drawing.Point(6, 198);
            this.txtAboutAsset.Multiline = true;
            this.txtAboutAsset.Name = "txtAboutAsset";
            this.txtAboutAsset.ReadOnly = true;
            this.txtAboutAsset.Size = new System.Drawing.Size(812, 305);
            this.txtAboutAsset.TabIndex = 2;
            this.txtAboutAsset.Text = resources.GetString("txtAboutAsset.Text");
            this.txtAboutAsset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asset Type: \"GEN_RawBlob\", Texture";
            // 
            // whatIsText
            // 
            this.whatIsText.AutoSize = true;
            this.whatIsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatIsText.Location = new System.Drawing.Point(253, 18);
            this.whatIsText.Name = "whatIsText";
            this.whatIsText.Size = new System.Drawing.Size(311, 38);
            this.whatIsText.TabIndex = 0;
            this.whatIsText.Text = "What is this asset?";
            // 
            // WhatIsGenRawBlob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.Add(this.grpAboutText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhatIsGenRawBlob";
            this.Text = "What is this asset?";
            this.grpAboutText.ResumeLayout(false);
            this.grpAboutText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAboutText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAboutAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label whatIsText;
    }
}