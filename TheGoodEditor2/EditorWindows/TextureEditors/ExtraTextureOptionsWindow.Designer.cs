
namespace TheGoodEditor2.EditorWindows.TextureEditors
{
    partial class ExtraTextureOptionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraTextureOptionsWindow));
            this.grpExtrasContainer = new System.Windows.Forms.GroupBox();
            this.grpColorChangeContainer = new System.Windows.Forms.GroupBox();
            this.replaceWithColorBTN = new System.Windows.Forms.Button();
            this.grpExtrasContainer.SuspendLayout();
            this.grpColorChangeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExtrasContainer
            // 
            this.grpExtrasContainer.Controls.Add(this.grpColorChangeContainer);
            this.grpExtrasContainer.Location = new System.Drawing.Point(12, 12);
            this.grpExtrasContainer.Name = "grpExtrasContainer";
            this.grpExtrasContainer.Size = new System.Drawing.Size(431, 285);
            this.grpExtrasContainer.TabIndex = 0;
            this.grpExtrasContainer.TabStop = false;
            this.grpExtrasContainer.Text = "Extra Texture Options and Features";
            // 
            // grpColorChangeContainer
            // 
            this.grpColorChangeContainer.Controls.Add(this.replaceWithColorBTN);
            this.grpColorChangeContainer.Location = new System.Drawing.Point(6, 21);
            this.grpColorChangeContainer.Name = "grpColorChangeContainer";
            this.grpColorChangeContainer.Size = new System.Drawing.Size(419, 258);
            this.grpColorChangeContainer.TabIndex = 0;
            this.grpColorChangeContainer.TabStop = false;
            this.grpColorChangeContainer.Text = "Mass Color Replacement";
            // 
            // replaceWithColorBTN
            // 
            this.replaceWithColorBTN.Location = new System.Drawing.Point(6, 21);
            this.replaceWithColorBTN.Name = "replaceWithColorBTN";
            this.replaceWithColorBTN.Size = new System.Drawing.Size(407, 57);
            this.replaceWithColorBTN.TabIndex = 0;
            this.replaceWithColorBTN.Text = "Replace All Textures with Solid Color";
            this.replaceWithColorBTN.UseVisualStyleBackColor = true;
            this.replaceWithColorBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExtraTextureOptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 309);
            this.Controls.Add(this.grpExtrasContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtraTextureOptionsWindow";
            this.Text = "Extra Texture Editing Options and Features";
            this.Load += new System.EventHandler(this.ExtraTextureOptionsWindow_Load);
            this.grpExtrasContainer.ResumeLayout(false);
            this.grpColorChangeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExtrasContainer;
        private System.Windows.Forms.GroupBox grpColorChangeContainer;
        private System.Windows.Forms.Button replaceWithColorBTN;
    }
}