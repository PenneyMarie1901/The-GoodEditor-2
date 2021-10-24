
namespace TheGoodEditor2.EditorWindows.TextureEditors
{
    partial class InGameRotationEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGameRotationEditor));
            this.grpRotationContainer = new System.Windows.Forms.GroupBox();
            this.btnRotate90Left = new System.Windows.Forms.Button();
            this.btnRotate90Right = new System.Windows.Forms.Button();
            this.btnXMirror = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpRotationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRotationContainer
            // 
            this.grpRotationContainer.Controls.Add(this.button1);
            this.grpRotationContainer.Controls.Add(this.btnXMirror);
            this.grpRotationContainer.Controls.Add(this.btnRotate90Right);
            this.grpRotationContainer.Controls.Add(this.btnRotate90Left);
            this.grpRotationContainer.Location = new System.Drawing.Point(12, 12);
            this.grpRotationContainer.Name = "grpRotationContainer";
            this.grpRotationContainer.Size = new System.Drawing.Size(328, 135);
            this.grpRotationContainer.TabIndex = 0;
            this.grpRotationContainer.TabStop = false;
            this.grpRotationContainer.Text = "Controls";
            // 
            // btnRotate90Left
            // 
            this.btnRotate90Left.Location = new System.Drawing.Point(6, 21);
            this.btnRotate90Left.Name = "btnRotate90Left";
            this.btnRotate90Left.Size = new System.Drawing.Size(152, 48);
            this.btnRotate90Left.TabIndex = 0;
            this.btnRotate90Left.Text = "Rotate 90° Left";
            this.btnRotate90Left.UseVisualStyleBackColor = true;
            this.btnRotate90Left.Click += new System.EventHandler(this.btnRotate90Left_Click);
            // 
            // btnRotate90Right
            // 
            this.btnRotate90Right.Location = new System.Drawing.Point(164, 21);
            this.btnRotate90Right.Name = "btnRotate90Right";
            this.btnRotate90Right.Size = new System.Drawing.Size(158, 48);
            this.btnRotate90Right.TabIndex = 1;
            this.btnRotate90Right.Text = "Rotate 90° Right";
            this.btnRotate90Right.UseVisualStyleBackColor = true;
            this.btnRotate90Right.Click += new System.EventHandler(this.btnRotate90Right_Click);
            // 
            // btnXMirror
            // 
            this.btnXMirror.Location = new System.Drawing.Point(6, 75);
            this.btnXMirror.Name = "btnXMirror";
            this.btnXMirror.Size = new System.Drawing.Size(152, 48);
            this.btnXMirror.TabIndex = 2;
            this.btnXMirror.Text = "Mirror on X Axis";
            this.btnXMirror.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mirror on Y Axis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InGameRotationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 157);
            this.Controls.Add(this.grpRotationContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InGameRotationEditor";
            this.Text = "In-Game Rotation Editor";
            this.grpRotationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRotationContainer;
        private System.Windows.Forms.Button btnRotate90Left;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXMirror;
        private System.Windows.Forms.Button btnRotate90Right;
    }
}