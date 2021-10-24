
namespace TheGoodEditor2.EditorWindows.Randomizer
{
    partial class Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.grpRandomizerControlsContainer = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSimpleObjects = new System.Windows.Forms.RadioButton();
            this.rdoPlatforms = new System.Windows.Forms.RadioButton();
            this.grpWhatToContainer = new System.Windows.Forms.GroupBox();
            this.chkPosX = new System.Windows.Forms.CheckBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.chkPosZ = new System.Windows.Forms.CheckBox();
            this.chkPosY = new System.Windows.Forms.CheckBox();
            this.chkRotY = new System.Windows.Forms.CheckBox();
            this.chkRotZ = new System.Windows.Forms.CheckBox();
            this.lblRotation = new System.Windows.Forms.Label();
            this.chkRotX = new System.Windows.Forms.CheckBox();
            this.chkScaleY = new System.Windows.Forms.CheckBox();
            this.chkScaleZ = new System.Windows.Forms.CheckBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.chkScaleX = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpRandomizerControlsContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpWhatToContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRandomizerControlsContainer
            // 
            this.grpRandomizerControlsContainer.Controls.Add(this.button1);
            this.grpRandomizerControlsContainer.Controls.Add(this.grpWhatToContainer);
            this.grpRandomizerControlsContainer.Controls.Add(this.groupBox1);
            this.grpRandomizerControlsContainer.Location = new System.Drawing.Point(12, 12);
            this.grpRandomizerControlsContainer.Name = "grpRandomizerControlsContainer";
            this.grpRandomizerControlsContainer.Size = new System.Drawing.Size(607, 338);
            this.grpRandomizerControlsContainer.TabIndex = 0;
            this.grpRandomizerControlsContainer.TabStop = false;
            this.grpRandomizerControlsContainer.Text = "Asset Randomizer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPlatforms);
            this.groupBox1.Controls.Add(this.rdoSimpleObjects);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What To Randomize?";
            // 
            // rdoSimpleObjects
            // 
            this.rdoSimpleObjects.AutoSize = true;
            this.rdoSimpleObjects.Location = new System.Drawing.Point(6, 44);
            this.rdoSimpleObjects.Name = "rdoSimpleObjects";
            this.rdoSimpleObjects.Size = new System.Drawing.Size(119, 21);
            this.rdoSimpleObjects.TabIndex = 0;
            this.rdoSimpleObjects.TabStop = true;
            this.rdoSimpleObjects.Text = "SimpleObjects";
            this.rdoSimpleObjects.UseVisualStyleBackColor = true;
            // 
            // rdoPlatforms
            // 
            this.rdoPlatforms.AutoSize = true;
            this.rdoPlatforms.Location = new System.Drawing.Point(6, 72);
            this.rdoPlatforms.Name = "rdoPlatforms";
            this.rdoPlatforms.Size = new System.Drawing.Size(88, 21);
            this.rdoPlatforms.TabIndex = 1;
            this.rdoPlatforms.TabStop = true;
            this.rdoPlatforms.Text = "Platforms";
            this.rdoPlatforms.UseVisualStyleBackColor = true;
            // 
            // grpWhatToContainer
            // 
            this.grpWhatToContainer.Controls.Add(this.chkScaleY);
            this.grpWhatToContainer.Controls.Add(this.chkScaleZ);
            this.grpWhatToContainer.Controls.Add(this.lblScale);
            this.grpWhatToContainer.Controls.Add(this.chkScaleX);
            this.grpWhatToContainer.Controls.Add(this.chkRotY);
            this.grpWhatToContainer.Controls.Add(this.chkRotZ);
            this.grpWhatToContainer.Controls.Add(this.lblRotation);
            this.grpWhatToContainer.Controls.Add(this.chkRotX);
            this.grpWhatToContainer.Controls.Add(this.chkPosY);
            this.grpWhatToContainer.Controls.Add(this.chkPosZ);
            this.grpWhatToContainer.Controls.Add(this.lblPosition);
            this.grpWhatToContainer.Controls.Add(this.chkPosX);
            this.grpWhatToContainer.Location = new System.Drawing.Point(259, 21);
            this.grpWhatToContainer.Name = "grpWhatToContainer";
            this.grpWhatToContainer.Size = new System.Drawing.Size(342, 182);
            this.grpWhatToContainer.TabIndex = 1;
            this.grpWhatToContainer.TabStop = false;
            this.grpWhatToContainer.Text = "Choose Data To Randomize";
            // 
            // chkPosX
            // 
            this.chkPosX.AutoSize = true;
            this.chkPosX.Location = new System.Drawing.Point(27, 81);
            this.chkPosX.Name = "chkPosX";
            this.chkPosX.Size = new System.Drawing.Size(39, 21);
            this.chkPosX.TabIndex = 0;
            this.chkPosX.Text = "X";
            this.chkPosX.UseVisualStyleBackColor = true;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(24, 44);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position";
            // 
            // chkPosZ
            // 
            this.chkPosZ.AutoSize = true;
            this.chkPosZ.Location = new System.Drawing.Point(27, 135);
            this.chkPosZ.Name = "chkPosZ";
            this.chkPosZ.Size = new System.Drawing.Size(39, 21);
            this.chkPosZ.TabIndex = 2;
            this.chkPosZ.Text = "Z";
            this.chkPosZ.UseVisualStyleBackColor = true;
            // 
            // chkPosY
            // 
            this.chkPosY.AutoSize = true;
            this.chkPosY.Location = new System.Drawing.Point(27, 108);
            this.chkPosY.Name = "chkPosY";
            this.chkPosY.Size = new System.Drawing.Size(39, 21);
            this.chkPosY.TabIndex = 3;
            this.chkPosY.Text = "Y";
            this.chkPosY.UseVisualStyleBackColor = true;
            this.chkPosY.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkRotY
            // 
            this.chkRotY.AutoSize = true;
            this.chkRotY.Location = new System.Drawing.Point(151, 108);
            this.chkRotY.Name = "chkRotY";
            this.chkRotY.Size = new System.Drawing.Size(39, 21);
            this.chkRotY.TabIndex = 7;
            this.chkRotY.Text = "Y";
            this.chkRotY.UseVisualStyleBackColor = true;
            // 
            // chkRotZ
            // 
            this.chkRotZ.AutoSize = true;
            this.chkRotZ.Location = new System.Drawing.Point(151, 135);
            this.chkRotZ.Name = "chkRotZ";
            this.chkRotZ.Size = new System.Drawing.Size(39, 21);
            this.chkRotZ.TabIndex = 6;
            this.chkRotZ.Text = "Z";
            this.chkRotZ.UseVisualStyleBackColor = true;
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(148, 44);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(61, 17);
            this.lblRotation.TabIndex = 5;
            this.lblRotation.Text = "Rotation";
            // 
            // chkRotX
            // 
            this.chkRotX.AutoSize = true;
            this.chkRotX.Location = new System.Drawing.Point(151, 81);
            this.chkRotX.Name = "chkRotX";
            this.chkRotX.Size = new System.Drawing.Size(39, 21);
            this.chkRotX.TabIndex = 4;
            this.chkRotX.Text = "X";
            this.chkRotX.UseVisualStyleBackColor = true;
            // 
            // chkScaleY
            // 
            this.chkScaleY.AutoSize = true;
            this.chkScaleY.Location = new System.Drawing.Point(272, 108);
            this.chkScaleY.Name = "chkScaleY";
            this.chkScaleY.Size = new System.Drawing.Size(39, 21);
            this.chkScaleY.TabIndex = 11;
            this.chkScaleY.Text = "Y";
            this.chkScaleY.UseVisualStyleBackColor = true;
            // 
            // chkScaleZ
            // 
            this.chkScaleZ.AutoSize = true;
            this.chkScaleZ.Location = new System.Drawing.Point(272, 135);
            this.chkScaleZ.Name = "chkScaleZ";
            this.chkScaleZ.Size = new System.Drawing.Size(39, 21);
            this.chkScaleZ.TabIndex = 10;
            this.chkScaleZ.Text = "Z";
            this.chkScaleZ.UseVisualStyleBackColor = true;
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(269, 44);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(43, 17);
            this.lblScale.TabIndex = 9;
            this.lblScale.Text = "Scale";
            // 
            // chkScaleX
            // 
            this.chkScaleX.AutoSize = true;
            this.chkScaleX.Location = new System.Drawing.Point(272, 81);
            this.chkScaleX.Name = "chkScaleX";
            this.chkScaleX.Size = new System.Drawing.Size(39, 21);
            this.chkScaleX.TabIndex = 8;
            this.chkScaleX.Text = "X";
            this.chkScaleX.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(595, 123);
            this.button1.TabIndex = 2;
            this.button1.Text = "Randomize!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 361);
            this.Controls.Add(this.grpRandomizerControlsContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Randomizer";
            this.Text = "Randomizer";
            this.Load += new System.EventHandler(this.Randomizer_Load);
            this.grpRandomizerControlsContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpWhatToContainer.ResumeLayout(false);
            this.grpWhatToContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRandomizerControlsContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSimpleObjects;
        private System.Windows.Forms.RadioButton rdoPlatforms;
        private System.Windows.Forms.GroupBox grpWhatToContainer;
        private System.Windows.Forms.CheckBox chkPosY;
        private System.Windows.Forms.CheckBox chkPosZ;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.CheckBox chkPosX;
        private System.Windows.Forms.CheckBox chkScaleY;
        private System.Windows.Forms.CheckBox chkScaleZ;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.CheckBox chkScaleX;
        private System.Windows.Forms.CheckBox chkRotY;
        private System.Windows.Forms.CheckBox chkRotZ;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.CheckBox chkRotX;
        private System.Windows.Forms.Button button1;
    }
}