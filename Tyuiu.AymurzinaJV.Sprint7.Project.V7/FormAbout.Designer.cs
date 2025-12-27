namespace Tyuiu.AymurzinaJV.Sprint6.Task7.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_AJV = new Button();
            labelInfo_AJV = new Label();
            pictureBoxAvatar_AJV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AJV).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_AJV
            // 
            buttonOK_AJV.Location = new Point(486, 235);
            buttonOK_AJV.Name = "buttonOK_AJV";
            buttonOK_AJV.Size = new Size(94, 29);
            buttonOK_AJV.TabIndex = 5;
            buttonOK_AJV.Text = "OK";
            buttonOK_AJV.UseVisualStyleBackColor = true;
            buttonOK_AJV.Click += buttonOK_AJV_Click;
            // 
            // labelInfo_AJV
            // 
            labelInfo_AJV.AutoSize = true;
            labelInfo_AJV.Location = new Point(204, 12);
            labelInfo_AJV.Name = "labelInfo_AJV";
            labelInfo_AJV.Size = new Size(387, 200);
            labelInfo_AJV.TabIndex = 4;
            labelInfo_AJV.Text = resources.GetString("labelInfo_AJV.Text");
            // 
            // pictureBoxAvatar_AJV
            // 
            pictureBoxAvatar_AJV.BackgroundImage = (Image)resources.GetObject("pictureBoxAvatar_AJV.BackgroundImage");
            pictureBoxAvatar_AJV.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAvatar_AJV.Location = new Point(12, 12);
            pictureBoxAvatar_AJV.Name = "pictureBoxAvatar_AJV";
            pictureBoxAvatar_AJV.Size = new Size(187, 252);
            pictureBoxAvatar_AJV.TabIndex = 3;
            pictureBoxAvatar_AJV.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 273);
            Controls.Add(buttonOK_AJV);
            Controls.Add(labelInfo_AJV);
            Controls.Add(pictureBoxAvatar_AJV);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сведения";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AJV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_AJV;
        private Label labelInfo_AJV;
        private PictureBox pictureBoxAvatar_AJV;
    }
}