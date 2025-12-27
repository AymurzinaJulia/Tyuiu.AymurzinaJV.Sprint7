namespace Tyuiu.AymurzinaJV.Sprint7.Project.V7
{
    partial class FormStatistics
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
            labelCount_AJV = new Label();
            labelSum_AJV = new Label();
            labelMin_AJV = new Label();
            labelAvg_AJV = new Label();
            labelDebt_AJV = new Label();
            labelMax_AJV = new Label();
            textBoxCount_AJV = new TextBox();
            textBoxSum_AJV = new TextBox();
            textBoxAvg_AJV = new TextBox();
            textBoxMin_AJV = new TextBox();
            textBoxMax_AJV = new TextBox();
            textBoxDebt_AJV = new TextBox();
            SuspendLayout();
            // 
            // labelCount_AJV
            // 
            labelCount_AJV.AutoSize = true;
            labelCount_AJV.Location = new Point(12, 9);
            labelCount_AJV.Name = "labelCount_AJV";
            labelCount_AJV.Size = new Size(153, 20);
            labelCount_AJV.TabIndex = 0;
            labelCount_AJV.Text = "Количество квартир:";
            // 
            // labelSum_AJV
            // 
            labelSum_AJV.AutoSize = true;
            labelSum_AJV.Location = new Point(12, 68);
            labelSum_AJV.Name = "labelSum_AJV";
            labelSum_AJV.Size = new Size(126, 20);
            labelSum_AJV.TabIndex = 1;
            labelSum_AJV.Text = "Общая площадь:";
            // 
            // labelMin_AJV
            // 
            labelMin_AJV.AutoSize = true;
            labelMin_AJV.Location = new Point(12, 194);
            labelMin_AJV.Name = "labelMin_AJV";
            labelMin_AJV.Size = new Size(178, 20);
            labelMin_AJV.TabIndex = 3;
            labelMin_AJV.Text = "Минимальная площадь:";
            // 
            // labelAvg_AJV
            // 
            labelAvg_AJV.AutoSize = true;
            labelAvg_AJV.Location = new Point(12, 130);
            labelAvg_AJV.Name = "labelAvg_AJV";
            labelAvg_AJV.Size = new Size(137, 20);
            labelAvg_AJV.TabIndex = 2;
            labelAvg_AJV.Text = "Средняя площадь:";
            // 
            // labelDebt_AJV
            // 
            labelDebt_AJV.AutoSize = true;
            labelDebt_AJV.Location = new Point(12, 323);
            labelDebt_AJV.Name = "labelDebt_AJV";
            labelDebt_AJV.Size = new Size(287, 20);
            labelDebt_AJV.TabIndex = 5;
            labelDebt_AJV.Text = "Количество квартир с задолженностью:\r\n";
            // 
            // labelMax_AJV
            // 
            labelMax_AJV.AutoSize = true;
            labelMax_AJV.Location = new Point(12, 258);
            labelMax_AJV.Name = "labelMax_AJV";
            labelMax_AJV.Size = new Size(182, 20);
            labelMax_AJV.TabIndex = 4;
            labelMax_AJV.Text = "Максимальная площадь:";
            // 
            // textBoxCount_AJV
            // 
            textBoxCount_AJV.Location = new Point(13, 35);
            textBoxCount_AJV.Name = "textBoxCount_AJV";
            textBoxCount_AJV.ReadOnly = true;
            textBoxCount_AJV.Size = new Size(286, 27);
            textBoxCount_AJV.TabIndex = 6;
            // 
            // textBoxSum_AJV
            // 
            textBoxSum_AJV.Location = new Point(13, 97);
            textBoxSum_AJV.Name = "textBoxSum_AJV";
            textBoxSum_AJV.ReadOnly = true;
            textBoxSum_AJV.Size = new Size(286, 27);
            textBoxSum_AJV.TabIndex = 7;
            // 
            // textBoxAvg_AJV
            // 
            textBoxAvg_AJV.Location = new Point(13, 159);
            textBoxAvg_AJV.Name = "textBoxAvg_AJV";
            textBoxAvg_AJV.ReadOnly = true;
            textBoxAvg_AJV.Size = new Size(286, 27);
            textBoxAvg_AJV.TabIndex = 8;
            // 
            // textBoxMin_AJV
            // 
            textBoxMin_AJV.Location = new Point(13, 223);
            textBoxMin_AJV.Name = "textBoxMin_AJV";
            textBoxMin_AJV.ReadOnly = true;
            textBoxMin_AJV.Size = new Size(286, 27);
            textBoxMin_AJV.TabIndex = 9;
            // 
            // textBoxMax_AJV
            // 
            textBoxMax_AJV.Location = new Point(13, 290);
            textBoxMax_AJV.Name = "textBoxMax_AJV";
            textBoxMax_AJV.ReadOnly = true;
            textBoxMax_AJV.Size = new Size(286, 27);
            textBoxMax_AJV.TabIndex = 10;
            // 
            // textBoxDebt_AJV
            // 
            textBoxDebt_AJV.Location = new Point(13, 354);
            textBoxDebt_AJV.Name = "textBoxDebt_AJV";
            textBoxDebt_AJV.ReadOnly = true;
            textBoxDebt_AJV.Size = new Size(286, 27);
            textBoxDebt_AJV.TabIndex = 11;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 398);
            Controls.Add(textBoxDebt_AJV);
            Controls.Add(textBoxMax_AJV);
            Controls.Add(textBoxMin_AJV);
            Controls.Add(textBoxAvg_AJV);
            Controls.Add(textBoxSum_AJV);
            Controls.Add(textBoxCount_AJV);
            Controls.Add(labelDebt_AJV);
            Controls.Add(labelMax_AJV);
            Controls.Add(labelMin_AJV);
            Controls.Add(labelAvg_AJV);
            Controls.Add(labelSum_AJV);
            Controls.Add(labelCount_AJV);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormStatistics";
            Text = "Статистика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCount_AJV;
        private Label labelSum_AJV;
        private Label labelMin_AJV;
        private Label labelAvg_AJV;
        private Label labelDebt_AJV;
        private Label labelMax_AJV;
        private TextBox textBoxCount_AJV;
        private TextBox textBoxSum_AJV;
        private TextBox textBoxAvg_AJV;
        private TextBox textBoxMin_AJV;
        private TextBox textBoxMax_AJV;
        private TextBox textBoxDebt_AJV;
    }
}