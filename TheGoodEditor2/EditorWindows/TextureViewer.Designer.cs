
namespace TheGoodEditor2.EditorWindows
{
    partial class TextureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureViewer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textureViewerBox = new System.Windows.Forms.PictureBox();
            this.saveAsPng = new System.Windows.Forms.Button();
            this.grpSavingControls = new System.Windows.Forms.GroupBox();
            this.saveAsJpg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detailsContainer = new System.Windows.Forms.GroupBox();
            this.lblActuHeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblActualWidth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.replacementContainer = new System.Windows.Forms.GroupBox();
            this.btnReplaceWithSolidColor = new System.Windows.Forms.Button();
            this.btnImportTexture = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenIngameRotationEditor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textureViewerBox)).BeginInit();
            this.grpSavingControls.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.detailsContainer.SuspendLayout();
            this.replacementContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textureViewerBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texture Viewer";
            // 
            // textureViewerBox
            // 
            this.textureViewerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textureViewerBox.Location = new System.Drawing.Point(3, 18);
            this.textureViewerBox.Name = "textureViewerBox";
            this.textureViewerBox.Size = new System.Drawing.Size(647, 534);
            this.textureViewerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.textureViewerBox.TabIndex = 0;
            this.textureViewerBox.TabStop = false;
            // 
            // saveAsPng
            // 
            this.saveAsPng.Location = new System.Drawing.Point(6, 36);
            this.saveAsPng.Name = "saveAsPng";
            this.saveAsPng.Size = new System.Drawing.Size(233, 38);
            this.saveAsPng.TabIndex = 1;
            this.saveAsPng.Text = "Save Texture As *.png";
            this.saveAsPng.UseVisualStyleBackColor = true;
            this.saveAsPng.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSavingControls
            // 
            this.grpSavingControls.Controls.Add(this.saveAsJpg);
            this.grpSavingControls.Controls.Add(this.saveAsPng);
            this.grpSavingControls.Controls.Add(this.groupBox2);
            this.grpSavingControls.Location = new System.Drawing.Point(671, 21);
            this.grpSavingControls.Name = "grpSavingControls";
            this.grpSavingControls.Size = new System.Drawing.Size(401, 543);
            this.grpSavingControls.TabIndex = 2;
            this.grpSavingControls.TabStop = false;
            this.grpSavingControls.Text = "Saving Controls";
            // 
            // saveAsJpg
            // 
            this.saveAsJpg.Location = new System.Drawing.Point(6, 80);
            this.saveAsJpg.Name = "saveAsJpg";
            this.saveAsJpg.Size = new System.Drawing.Size(233, 38);
            this.saveAsJpg.TabIndex = 2;
            this.saveAsJpg.Text = "Save Texture As *.jpg";
            this.saveAsJpg.UseVisualStyleBackColor = true;
            this.saveAsJpg.Click += new System.EventHandler(this.saveAsJpg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.detailsContainer);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.replacementContainer);
            this.groupBox2.Location = new System.Drawing.Point(6, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 413);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Editing Controls";
            // 
            // detailsContainer
            // 
            this.detailsContainer.Controls.Add(this.lblActuHeight);
            this.detailsContainer.Controls.Add(this.lblHeight);
            this.detailsContainer.Controls.Add(this.lblActualWidth);
            this.detailsContainer.Controls.Add(this.lblWidth);
            this.detailsContainer.Location = new System.Drawing.Point(6, 329);
            this.detailsContainer.Name = "detailsContainer";
            this.detailsContainer.Size = new System.Drawing.Size(233, 78);
            this.detailsContainer.TabIndex = 5;
            this.detailsContainer.TabStop = false;
            this.detailsContainer.Text = "Texture Details";
            this.detailsContainer.Enter += new System.EventHandler(this.detailsContainer_Enter);
            // 
            // lblActuHeight
            // 
            this.lblActuHeight.AutoSize = true;
            this.lblActuHeight.Location = new System.Drawing.Point(59, 55);
            this.lblActuHeight.Name = "lblActuHeight";
            this.lblActuHeight.Size = new System.Drawing.Size(0, 17);
            this.lblActuHeight.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(8, 55);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(53, 17);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height:";
            // 
            // lblActualWidth
            // 
            this.lblActualWidth.AutoSize = true;
            this.lblActualWidth.Location = new System.Drawing.Point(57, 32);
            this.lblActualWidth.Name = "lblActualWidth";
            this.lblActualWidth.Size = new System.Drawing.Size(0, 17);
            this.lblActualWidth.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 32);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 17);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Width:";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Mirror Texture on Y Axis";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Mirror Texture on X Axis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rotate Texture 90° Left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rotate Texture 90° Right";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // replacementContainer
            // 
            this.replacementContainer.Controls.Add(this.btnReplaceWithSolidColor);
            this.replacementContainer.Controls.Add(this.btnImportTexture);
            this.replacementContainer.Location = new System.Drawing.Point(6, 188);
            this.replacementContainer.Name = "replacementContainer";
            this.replacementContainer.Size = new System.Drawing.Size(233, 135);
            this.replacementContainer.TabIndex = 3;
            this.replacementContainer.TabStop = false;
            this.replacementContainer.Text = "Texture Replacement Controls";
            // 
            // btnReplaceWithSolidColor
            // 
            this.btnReplaceWithSolidColor.Location = new System.Drawing.Point(6, 71);
            this.btnReplaceWithSolidColor.Name = "btnReplaceWithSolidColor";
            this.btnReplaceWithSolidColor.Size = new System.Drawing.Size(221, 44);
            this.btnReplaceWithSolidColor.TabIndex = 3;
            this.btnReplaceWithSolidColor.Text = "Replace Texture with Solid Color";
            this.btnReplaceWithSolidColor.UseVisualStyleBackColor = true;
            this.btnReplaceWithSolidColor.Click += new System.EventHandler(this.btnReplaceWithSolidColor_Click);
            // 
            // btnImportTexture
            // 
            this.btnImportTexture.Location = new System.Drawing.Point(6, 21);
            this.btnImportTexture.Name = "btnImportTexture";
            this.btnImportTexture.Size = new System.Drawing.Size(221, 44);
            this.btnImportTexture.TabIndex = 2;
            this.btnImportTexture.Text = "Import Custom Texture (Experimental)";
            this.btnImportTexture.UseVisualStyleBackColor = true;
            this.btnImportTexture.Click += new System.EventHandler(this.btnImportTexture_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenIngameRotationEditor);
            this.groupBox3.Location = new System.Drawing.Point(245, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 386);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Options";
            this.groupBox3.Visible = false;
            // 
            // btnOpenIngameRotationEditor
            // 
            this.btnOpenIngameRotationEditor.Location = new System.Drawing.Point(6, 26);
            this.btnOpenIngameRotationEditor.Name = "btnOpenIngameRotationEditor";
            this.btnOpenIngameRotationEditor.Size = new System.Drawing.Size(126, 44);
            this.btnOpenIngameRotationEditor.TabIndex = 3;
            this.btnOpenIngameRotationEditor.Text = "In-game Rotation";
            this.btnOpenIngameRotationEditor.UseVisualStyleBackColor = true;
            this.btnOpenIngameRotationEditor.Visible = false;
            this.btnOpenIngameRotationEditor.Click += new System.EventHandler(this.btnOpenIngameRotationEditor_Click);
            // 
            // TextureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSavingControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextureViewer";
            this.Text = "Texture Viewer";
            this.Load += new System.EventHandler(this.TextureViewer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textureViewerBox)).EndInit();
            this.grpSavingControls.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.detailsContainer.ResumeLayout(false);
            this.detailsContainer.PerformLayout();
            this.replacementContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox textureViewerBox;
        private System.Windows.Forms.Button saveAsPng;
        private System.Windows.Forms.GroupBox grpSavingControls;
        private System.Windows.Forms.Button saveAsJpg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox replacementContainer;
        private System.Windows.Forms.Button btnImportTexture;
        private System.Windows.Forms.GroupBox detailsContainer;
        private System.Windows.Forms.Label lblActuHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblActualWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReplaceWithSolidColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpenIngameRotationEditor;
    }
}