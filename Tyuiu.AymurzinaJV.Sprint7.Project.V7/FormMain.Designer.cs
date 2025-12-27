namespace Tyuiu.AymurzinaJV.Sprint7.Project.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelControls_AJV;
        private GroupBox groupBoxSearch_AJV;
        private Button buttonSearch_AJV;
        private TextBox textBoxSearchSurname_AJV;
        private GroupBox groupBoxAdd_AJV;
        private TextBox textBoxSurname_AJV;
        private TextBox textBoxApartmentNumber_AJV;
        private ComboBox comboBoxDebt_AJV;
        private TextBox textBoxArea_AJV;
        private TextBox textBoxName_AJV;
        private Button buttonAdd_AJV;
        private TextBox textBoxUsefulArea_AJV;
        private TextBox textBoxEntranceNumber_AJV;
        private TextBox textBoxFamilyCount_AJV;
        private TextBox textBoxRoomsCount_AJV;
        private TextBox textBoxChildrenCount_AJV;
        private GroupBox groupBoxDelete_AJV;
        private TextBox textBoxDeleteApartmentNumber_AJV;
        private Button buttonDelete_AJV;
        private Button buttonLoad_AJV;
        private Button buttonSave_AJV;
        private Button buttonAbout_AJV;
        private Button buttonShowAll_AJV;
        private ComboBox comboBoxFilter_AJV;
        private GroupBox groupBoxSort_AJV;
        private ComboBox comboBoxSortDirection_AJV;
        private ComboBox comboBoxSortField_AJV;
        private Button buttonSort_AJV;
        private SplitContainer splitContainer_AJV;
        private DataGridView dataGridView_AJV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelControls_AJV = new Panel();
            buttonStats_AJV = new Button();
            groupBoxFilter_AJV = new GroupBox();
            buttonFilter_AJV = new Button();
            textBoxFilter_AJV = new TextBox();
            comboBoxFilter_AJV = new ComboBox();
            groupBoxSearch_AJV = new GroupBox();
            buttonSearch_AJV = new Button();
            textBoxSearchSurname_AJV = new TextBox();
            groupBoxAdd_AJV = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxApartmentNumber_AJV = new TextBox();
            textBoxSurname_AJV = new TextBox();
            textBoxName_AJV = new TextBox();
            textBoxArea_AJV = new TextBox();
            textBoxUsefulArea_AJV = new TextBox();
            textBoxEntranceNumber_AJV = new TextBox();
            textBoxRoomsCount_AJV = new TextBox();
            textBoxFamilyCount_AJV = new TextBox();
            textBoxChildrenCount_AJV = new TextBox();
            comboBoxDebt_AJV = new ComboBox();
            buttonAdd_AJV = new Button();
            groupBoxDelete_AJV = new GroupBox();
            textBoxDeleteApartmentNumber_AJV = new TextBox();
            buttonDelete_AJV = new Button();
            buttonLoad_AJV = new Button();
            buttonSave_AJV = new Button();
            buttonAbout_AJV = new Button();
            buttonShowAll_AJV = new Button();
            groupBoxSort_AJV = new GroupBox();
            comboBoxSortField_AJV = new ComboBox();
            comboBoxSortDirection_AJV = new ComboBox();
            buttonSort_AJV = new Button();
            splitContainer_AJV = new SplitContainer();
            dataGridView_AJV = new DataGridView();
            chart_AJV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelControls_AJV.SuspendLayout();
            groupBoxFilter_AJV.SuspendLayout();
            groupBoxSearch_AJV.SuspendLayout();
            groupBoxAdd_AJV.SuspendLayout();
            groupBoxDelete_AJV.SuspendLayout();
            groupBoxSort_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_AJV).BeginInit();
            splitContainer_AJV.Panel1.SuspendLayout();
            splitContainer_AJV.Panel2.SuspendLayout();
            splitContainer_AJV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AJV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_AJV).BeginInit();
            SuspendLayout();
            // 
            // panelControls_AJV
            // 
            panelControls_AJV.Controls.Add(buttonStats_AJV);
            panelControls_AJV.Controls.Add(groupBoxFilter_AJV);
            panelControls_AJV.Controls.Add(groupBoxSearch_AJV);
            panelControls_AJV.Controls.Add(groupBoxAdd_AJV);
            panelControls_AJV.Controls.Add(groupBoxDelete_AJV);
            panelControls_AJV.Controls.Add(buttonLoad_AJV);
            panelControls_AJV.Controls.Add(buttonSave_AJV);
            panelControls_AJV.Controls.Add(buttonAbout_AJV);
            panelControls_AJV.Controls.Add(buttonShowAll_AJV);
            panelControls_AJV.Controls.Add(groupBoxSort_AJV);
            panelControls_AJV.Dock = DockStyle.Top;
            panelControls_AJV.Location = new Point(0, 0);
            panelControls_AJV.Name = "panelControls_AJV";
            panelControls_AJV.Size = new Size(1470, 260);
            panelControls_AJV.TabIndex = 1;
            // 
            // buttonStats_AJV
            // 
            buttonStats_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStats_AJV.BackgroundImage = (Image)resources.GetObject("buttonStats_AJV.BackgroundImage");
            buttonStats_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonStats_AJV.Location = new Point(1339, 98);
            buttonStats_AJV.Name = "buttonStats_AJV";
            buttonStats_AJV.Size = new Size(67, 63);
            buttonStats_AJV.TabIndex = 10;
            buttonStats_AJV.UseVisualStyleBackColor = true;
            buttonStats_AJV.Click += buttonStats_AJV_Click;
            // 
            // groupBoxFilter_AJV
            // 
            groupBoxFilter_AJV.Controls.Add(buttonFilter_AJV);
            groupBoxFilter_AJV.Controls.Add(textBoxFilter_AJV);
            groupBoxFilter_AJV.Controls.Add(comboBoxFilter_AJV);
            groupBoxFilter_AJV.Location = new Point(1081, 10);
            groupBoxFilter_AJV.Name = "groupBoxFilter_AJV";
            groupBoxFilter_AJV.Size = new Size(192, 230);
            groupBoxFilter_AJV.TabIndex = 9;
            groupBoxFilter_AJV.TabStop = false;
            groupBoxFilter_AJV.Text = "Фильтрация";
            // 
            // buttonFilter_AJV
            // 
            buttonFilter_AJV.BackgroundImage = (Image)resources.GetObject("buttonFilter_AJV.BackgroundImage");
            buttonFilter_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonFilter_AJV.Location = new Point(65, 153);
            buttonFilter_AJV.Name = "buttonFilter_AJV";
            buttonFilter_AJV.Size = new Size(66, 56);
            buttonFilter_AJV.TabIndex = 10;
            buttonFilter_AJV.Click += buttonFilter_AJV_Click;
            // 
            // textBoxFilter_AJV
            // 
            textBoxFilter_AJV.Location = new Point(21, 99);
            textBoxFilter_AJV.Name = "textBoxFilter_AJV";
            textBoxFilter_AJV.Size = new Size(151, 27);
            textBoxFilter_AJV.TabIndex = 9;
            // 
            // comboBoxFilter_AJV
            // 
            comboBoxFilter_AJV.Items.AddRange(new object[] { "Номер подъезда", "Номер квартиры", "Общая площадь", "Полезная площадь", "Задолженность", "Имя", "Фамилия", "Количество комнат", "Количество жильцов", "Количество детей" });
            comboBoxFilter_AJV.Location = new Point(21, 45);
            comboBoxFilter_AJV.Name = "comboBoxFilter_AJV";
            comboBoxFilter_AJV.Size = new Size(151, 28);
            comboBoxFilter_AJV.TabIndex = 7;
            comboBoxFilter_AJV.SelectedIndexChanged += comboBoxDebtFilter_AJV_SelectedIndexChanged;
            // 
            // groupBoxSearch_AJV
            // 
            groupBoxSearch_AJV.Controls.Add(buttonSearch_AJV);
            groupBoxSearch_AJV.Controls.Add(textBoxSearchSurname_AJV);
            groupBoxSearch_AJV.Location = new Point(10, 10);
            groupBoxSearch_AJV.Name = "groupBoxSearch_AJV";
            groupBoxSearch_AJV.Size = new Size(300, 100);
            groupBoxSearch_AJV.TabIndex = 0;
            groupBoxSearch_AJV.TabStop = false;
            groupBoxSearch_AJV.Text = "Поиск по фамилии";
            // 
            // buttonSearch_AJV
            // 
            buttonSearch_AJV.BackgroundImage = (Image)resources.GetObject("buttonSearch_AJV.BackgroundImage");
            buttonSearch_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonSearch_AJV.Location = new Point(215, 26);
            buttonSearch_AJV.Name = "buttonSearch_AJV";
            buttonSearch_AJV.Size = new Size(66, 56);
            buttonSearch_AJV.TabIndex = 0;
            buttonSearch_AJV.Click += buttonSearch_AJV_Click;
            // 
            // textBoxSearchSurname_AJV
            // 
            textBoxSearchSurname_AJV.Location = new Point(17, 41);
            textBoxSearchSurname_AJV.Name = "textBoxSearchSurname_AJV";
            textBoxSearchSurname_AJV.Size = new Size(173, 27);
            textBoxSearchSurname_AJV.TabIndex = 1;
            // 
            // groupBoxAdd_AJV
            // 
            groupBoxAdd_AJV.Controls.Add(label10);
            groupBoxAdd_AJV.Controls.Add(label9);
            groupBoxAdd_AJV.Controls.Add(label8);
            groupBoxAdd_AJV.Controls.Add(label7);
            groupBoxAdd_AJV.Controls.Add(label6);
            groupBoxAdd_AJV.Controls.Add(label5);
            groupBoxAdd_AJV.Controls.Add(label4);
            groupBoxAdd_AJV.Controls.Add(label3);
            groupBoxAdd_AJV.Controls.Add(label2);
            groupBoxAdd_AJV.Controls.Add(label1);
            groupBoxAdd_AJV.Controls.Add(textBoxApartmentNumber_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxSurname_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxName_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxArea_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxUsefulArea_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxEntranceNumber_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxRoomsCount_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxFamilyCount_AJV);
            groupBoxAdd_AJV.Controls.Add(textBoxChildrenCount_AJV);
            groupBoxAdd_AJV.Controls.Add(comboBoxDebt_AJV);
            groupBoxAdd_AJV.Controls.Add(buttonAdd_AJV);
            groupBoxAdd_AJV.Location = new Point(320, 10);
            groupBoxAdd_AJV.Name = "groupBoxAdd_AJV";
            groupBoxAdd_AJV.Size = new Size(551, 230);
            groupBoxAdd_AJV.TabIndex = 1;
            groupBoxAdd_AJV.TabStop = false;
            groupBoxAdd_AJV.Text = "Добавление квартиры";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 192);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 20;
            label10.Text = "Задолженность";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 192);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 19;
            label9.Text = "Кол-во детей";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 151);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 18;
            label8.Text = "Кол-во жильцов";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 109);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 17;
            label7.Text = "Кол-во комнат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 69);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 16;
            label6.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 29);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 15;
            label5.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 151);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 14;
            label4.Text = "Полезная площадь";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 13;
            label3.Text = "Общая площадь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 69);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 12;
            label2.Text = "№ квартиры";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 11;
            label1.Text = "№ подъезда";
            // 
            // textBoxApartmentNumber_AJV
            // 
            textBoxApartmentNumber_AJV.Location = new Point(128, 66);
            textBoxApartmentNumber_AJV.Name = "textBoxApartmentNumber_AJV";
            textBoxApartmentNumber_AJV.Size = new Size(77, 27);
            textBoxApartmentNumber_AJV.TabIndex = 0;
            // 
            // textBoxSurname_AJV
            // 
            textBoxSurname_AJV.Location = new Point(325, 66);
            textBoxSurname_AJV.Name = "textBoxSurname_AJV";
            textBoxSurname_AJV.Size = new Size(86, 27);
            textBoxSurname_AJV.TabIndex = 1;
            // 
            // textBoxName_AJV
            // 
            textBoxName_AJV.Location = new Point(287, 26);
            textBoxName_AJV.Name = "textBoxName_AJV";
            textBoxName_AJV.Size = new Size(124, 27);
            textBoxName_AJV.TabIndex = 2;
            // 
            // textBoxArea_AJV
            // 
            textBoxArea_AJV.Location = new Point(155, 106);
            textBoxArea_AJV.Name = "textBoxArea_AJV";
            textBoxArea_AJV.Size = new Size(50, 27);
            textBoxArea_AJV.TabIndex = 3;
            // 
            // textBoxUsefulArea_AJV
            // 
            textBoxUsefulArea_AJV.Location = new Point(171, 148);
            textBoxUsefulArea_AJV.Name = "textBoxUsefulArea_AJV";
            textBoxUsefulArea_AJV.Size = new Size(34, 27);
            textBoxUsefulArea_AJV.TabIndex = 4;
            // 
            // textBoxEntranceNumber_AJV
            // 
            textBoxEntranceNumber_AJV.Location = new Point(128, 26);
            textBoxEntranceNumber_AJV.Name = "textBoxEntranceNumber_AJV";
            textBoxEntranceNumber_AJV.Size = new Size(77, 27);
            textBoxEntranceNumber_AJV.TabIndex = 5;
            // 
            // textBoxRoomsCount_AJV
            // 
            textBoxRoomsCount_AJV.Location = new Point(360, 106);
            textBoxRoomsCount_AJV.Name = "textBoxRoomsCount_AJV";
            textBoxRoomsCount_AJV.Size = new Size(51, 27);
            textBoxRoomsCount_AJV.TabIndex = 6;
            // 
            // textBoxFamilyCount_AJV
            // 
            textBoxFamilyCount_AJV.Location = new Point(376, 148);
            textBoxFamilyCount_AJV.Name = "textBoxFamilyCount_AJV";
            textBoxFamilyCount_AJV.Size = new Size(35, 27);
            textBoxFamilyCount_AJV.TabIndex = 7;
            // 
            // textBoxChildrenCount_AJV
            // 
            textBoxChildrenCount_AJV.Location = new Point(351, 189);
            textBoxChildrenCount_AJV.Name = "textBoxChildrenCount_AJV";
            textBoxChildrenCount_AJV.Size = new Size(60, 27);
            textBoxChildrenCount_AJV.TabIndex = 8;
            // 
            // comboBoxDebt_AJV
            // 
            comboBoxDebt_AJV.Items.AddRange(new object[] { "Да", "Нет" });
            comboBoxDebt_AJV.Location = new Point(149, 189);
            comboBoxDebt_AJV.Name = "comboBoxDebt_AJV";
            comboBoxDebt_AJV.Size = new Size(56, 28);
            comboBoxDebt_AJV.TabIndex = 9;
            // 
            // buttonAdd_AJV
            // 
            buttonAdd_AJV.BackgroundImage = (Image)resources.GetObject("buttonAdd_AJV.BackgroundImage");
            buttonAdd_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonAdd_AJV.Location = new Point(456, 91);
            buttonAdd_AJV.Name = "buttonAdd_AJV";
            buttonAdd_AJV.Size = new Size(66, 56);
            buttonAdd_AJV.TabIndex = 10;
            buttonAdd_AJV.Click += buttonAdd_AJV_Click;
            // 
            // groupBoxDelete_AJV
            // 
            groupBoxDelete_AJV.Controls.Add(textBoxDeleteApartmentNumber_AJV);
            groupBoxDelete_AJV.Controls.Add(buttonDelete_AJV);
            groupBoxDelete_AJV.Location = new Point(10, 134);
            groupBoxDelete_AJV.Name = "groupBoxDelete_AJV";
            groupBoxDelete_AJV.Size = new Size(300, 100);
            groupBoxDelete_AJV.TabIndex = 2;
            groupBoxDelete_AJV.TabStop = false;
            groupBoxDelete_AJV.Text = "Удаление по номеру квартиры";
            // 
            // textBoxDeleteApartmentNumber_AJV
            // 
            textBoxDeleteApartmentNumber_AJV.Location = new Point(15, 41);
            textBoxDeleteApartmentNumber_AJV.Name = "textBoxDeleteApartmentNumber_AJV";
            textBoxDeleteApartmentNumber_AJV.Size = new Size(175, 27);
            textBoxDeleteApartmentNumber_AJV.TabIndex = 0;
            // 
            // buttonDelete_AJV
            // 
            buttonDelete_AJV.BackgroundImage = (Image)resources.GetObject("buttonDelete_AJV.BackgroundImage");
            buttonDelete_AJV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete_AJV.Location = new Point(215, 26);
            buttonDelete_AJV.Name = "buttonDelete_AJV";
            buttonDelete_AJV.Size = new Size(66, 56);
            buttonDelete_AJV.TabIndex = 1;
            buttonDelete_AJV.Click += buttonDelete_AJV_Click;
            // 
            // buttonLoad_AJV
            // 
            buttonLoad_AJV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLoad_AJV.BackgroundImage = (Image)resources.GetObject("buttonLoad_AJV.BackgroundImage");
            buttonLoad_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonLoad_AJV.Location = new Point(1289, 177);
            buttonLoad_AJV.Name = "buttonLoad_AJV";
            buttonLoad_AJV.Size = new Size(67, 63);
            buttonLoad_AJV.TabIndex = 3;
            buttonLoad_AJV.Click += buttonLoad_AJV_Click;
            // 
            // buttonSave_AJV
            // 
            buttonSave_AJV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave_AJV.BackgroundImage = (Image)resources.GetObject("buttonSave_AJV.BackgroundImage");
            buttonSave_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonSave_AJV.Location = new Point(1391, 177);
            buttonSave_AJV.Name = "buttonSave_AJV";
            buttonSave_AJV.Size = new Size(67, 63);
            buttonSave_AJV.TabIndex = 4;
            buttonSave_AJV.Click += buttonSave_AJV_Click;
            // 
            // buttonAbout_AJV
            // 
            buttonAbout_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_AJV.BackgroundImage = (Image)resources.GetObject("buttonAbout_AJV.BackgroundImage");
            buttonAbout_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_AJV.Location = new Point(1391, 20);
            buttonAbout_AJV.Name = "buttonAbout_AJV";
            buttonAbout_AJV.Size = new Size(67, 63);
            buttonAbout_AJV.TabIndex = 5;
            buttonAbout_AJV.Click += buttonAbout_AJV_Click;
            // 
            // buttonShowAll_AJV
            // 
            buttonShowAll_AJV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonShowAll_AJV.BackgroundImage = (Image)resources.GetObject("buttonShowAll_AJV.BackgroundImage");
            buttonShowAll_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonShowAll_AJV.Location = new Point(1289, 20);
            buttonShowAll_AJV.Name = "buttonShowAll_AJV";
            buttonShowAll_AJV.Size = new Size(67, 64);
            buttonShowAll_AJV.TabIndex = 6;
            buttonShowAll_AJV.Click += buttonShowAll_AJV_Click;
            // 
            // groupBoxSort_AJV
            // 
            groupBoxSort_AJV.Controls.Add(comboBoxSortField_AJV);
            groupBoxSort_AJV.Controls.Add(comboBoxSortDirection_AJV);
            groupBoxSort_AJV.Controls.Add(buttonSort_AJV);
            groupBoxSort_AJV.Location = new Point(880, 10);
            groupBoxSort_AJV.Name = "groupBoxSort_AJV";
            groupBoxSort_AJV.Size = new Size(192, 230);
            groupBoxSort_AJV.TabIndex = 8;
            groupBoxSort_AJV.TabStop = false;
            groupBoxSort_AJV.Text = "Сортировка";
            // 
            // comboBoxSortField_AJV
            // 
            comboBoxSortField_AJV.Items.AddRange(new object[] { "Номер квартиры", "Фамилия", "Общая площадь", "Количество комнат" });
            comboBoxSortField_AJV.Location = new Point(18, 46);
            comboBoxSortField_AJV.Name = "comboBoxSortField_AJV";
            comboBoxSortField_AJV.Size = new Size(151, 28);
            comboBoxSortField_AJV.TabIndex = 0;
            // 
            // comboBoxSortDirection_AJV
            // 
            comboBoxSortDirection_AJV.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBoxSortDirection_AJV.Location = new Point(18, 99);
            comboBoxSortDirection_AJV.Name = "comboBoxSortDirection_AJV";
            comboBoxSortDirection_AJV.Size = new Size(151, 28);
            comboBoxSortDirection_AJV.TabIndex = 1;
            // 
            // buttonSort_AJV
            // 
            buttonSort_AJV.BackgroundImage = (Image)resources.GetObject("buttonSort_AJV.BackgroundImage");
            buttonSort_AJV.BackgroundImageLayout = ImageLayout.Center;
            buttonSort_AJV.Location = new Point(62, 153);
            buttonSort_AJV.Name = "buttonSort_AJV";
            buttonSort_AJV.Size = new Size(66, 56);
            buttonSort_AJV.TabIndex = 2;
            buttonSort_AJV.Click += buttonSort_AJV_Click;
            // 
            // splitContainer_AJV
            // 
            splitContainer_AJV.Dock = DockStyle.Fill;
            splitContainer_AJV.Location = new Point(0, 260);
            splitContainer_AJV.Name = "splitContainer_AJV";
            // 
            // splitContainer_AJV.Panel1
            // 
            splitContainer_AJV.Panel1.Controls.Add(dataGridView_AJV);
            // 
            // splitContainer_AJV.Panel2
            // 
            splitContainer_AJV.Panel2.Controls.Add(chart_AJV);
            splitContainer_AJV.Size = new Size(1470, 496);
            splitContainer_AJV.SplitterDistance = 873;
            splitContainer_AJV.TabIndex = 0;
            // 
            // dataGridView_AJV
            // 
            dataGridView_AJV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AJV.Dock = DockStyle.Fill;
            dataGridView_AJV.Location = new Point(0, 0);
            dataGridView_AJV.Name = "dataGridView_AJV";
            dataGridView_AJV.RowHeadersWidth = 51;
            dataGridView_AJV.Size = new Size(873, 496);
            dataGridView_AJV.TabIndex = 0;
            // 
            // chart_AJV
            // 
            chartArea1.Name = "ChartArea1";
            chart_AJV.ChartAreas.Add(chartArea1);
            chart_AJV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart_AJV.Legends.Add(legend1);
            chart_AJV.Location = new Point(0, 0);
            chart_AJV.Name = "chart_AJV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_AJV.Series.Add(series1);
            chart_AJV.Size = new Size(593, 496);
            chart_AJV.TabIndex = 0;
            chart_AJV.Text = "chart1";
            // 
            // FormMain
            // 
            ClientSize = new Size(1470, 756);
            Controls.Add(splitContainer_AJV);
            Controls.Add(panelControls_AJV);
            MinimumSize = new Size(1488, 803);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домоуправление";
            panelControls_AJV.ResumeLayout(false);
            groupBoxFilter_AJV.ResumeLayout(false);
            groupBoxFilter_AJV.PerformLayout();
            groupBoxSearch_AJV.ResumeLayout(false);
            groupBoxSearch_AJV.PerformLayout();
            groupBoxAdd_AJV.ResumeLayout(false);
            groupBoxAdd_AJV.PerformLayout();
            groupBoxDelete_AJV.ResumeLayout(false);
            groupBoxDelete_AJV.PerformLayout();
            groupBoxSort_AJV.ResumeLayout(false);
            splitContainer_AJV.Panel1.ResumeLayout(false);
            splitContainer_AJV.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_AJV).EndInit();
            splitContainer_AJV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AJV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_AJV).EndInit();
            ResumeLayout(false);
        }
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private GroupBox groupBoxFilter_AJV;
        private Button buttonFilter_AJV;
        private TextBox textBoxFilter_AJV;
        private Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_AJV;
        private Button buttonStats_AJV;
    }
}
