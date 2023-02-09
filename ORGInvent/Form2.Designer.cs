using System.Windows.Forms;

namespace ORGInvent
{
    partial class Form2
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
            this.pcData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editEquipment = new System.Windows.Forms.Button();
            this.addEquipment = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Moving = new System.Windows.Forms.DataGridView();
            this.TypeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveModernization = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Modernization = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pcData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Moving)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Modernization)).BeginInit();
            this.SuspendLayout();
            // 
            // pcData
            // 
            this.pcData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pcData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.type_q,
            this.title,
            this.model,
            this.number,
            this.manufacturer,
            this.ip,
            this.owner,
            this.department,
            this.cabinet});
            this.pcData.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcData.Location = new System.Drawing.Point(9, 56);
            this.pcData.Name = "pcData";
            this.pcData.ReadOnly = true;
            this.pcData.Size = new System.Drawing.Size(1043, 153);
            this.pcData.TabIndex = 2;
            this.pcData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pcData_CellContentClick);
            this.pcData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pcData_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "№п/п";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // type_q
            // 
            this.type_q.HeaderText = "Тип устройства";
            this.type_q.Name = "type_q";
            this.type_q.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Имя устройства";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Инвентарный номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Производитель";
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP-Адрес";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // owner
            // 
            this.owner.HeaderText = "Владелец";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // department
            // 
            this.department.HeaderText = "Департамент";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // cabinet
            // 
            this.cabinet.HeaderText = "Кабинет";
            this.cabinet.Name = "cabinet";
            this.cabinet.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1410, 629);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editEquipment);
            this.tabPage1.Controls.Add(this.addEquipment);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pcData);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1402, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с БД";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editEquipment
            // 
            this.editEquipment.Location = new System.Drawing.Point(1092, 133);
            this.editEquipment.Name = "editEquipment";
            this.editEquipment.Size = new System.Drawing.Size(112, 30);
            this.editEquipment.TabIndex = 8;
            this.editEquipment.Text = "Редактировать";
            this.editEquipment.UseVisualStyleBackColor = true;
            // 
            // addEquipment
            // 
            this.addEquipment.Location = new System.Drawing.Point(1092, 97);
            this.addEquipment.Name = "addEquipment";
            this.addEquipment.Size = new System.Drawing.Size(112, 30);
            this.addEquipment.TabIndex = 8;
            this.addEquipment.Text = "Добавить";
            this.addEquipment.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(9, 257);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(835, 317);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 291);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Комплектующие";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 270);
            this.dataGridView2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Общая информация",
            "Процессор",
            "Материнская плата",
            "ОЗУ",
            "Видеокарта",
            "Операционная система",
            "Хранилище данных"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Moving);
            this.tabPage4.Controls.Add(this.saveModernization);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(827, 291);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Перемещения техники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Moving
            // 
            this.Moving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Moving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfWork,
            this.UserName,
            this.Description,
            this.Date});
            this.Moving.Location = new System.Drawing.Point(0, 0);
            this.Moving.Name = "Moving";
            this.Moving.Size = new System.Drawing.Size(444, 291);
            this.Moving.TabIndex = 4;
            // 
            // TypeOfWork
            // 
            this.TypeOfWork.HeaderText = "Тип работы";
            this.TypeOfWork.Name = "TypeOfWork";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Исполнитель";
            this.UserName.Name = "UserName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // saveModernization
            // 
            this.saveModernization.Location = new System.Drawing.Point(574, 129);
            this.saveModernization.Name = "saveModernization";
            this.saveModernization.Size = new System.Drawing.Size(112, 30);
            this.saveModernization.TabIndex = 8;
            this.saveModernization.Text = "Сохранить";
            this.saveModernization.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Modernization);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(827, 291);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Модернизация и ремонт";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Modernization
            // 
            this.Modernization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Modernization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.Modernization.Location = new System.Drawing.Point(0, 0);
            this.Modernization.Name = "Modernization";
            this.Modernization.Size = new System.Drawing.Size(444, 291);
            this.Modernization.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Тип работы";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица оргтехники";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1402, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Формирование отчета";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1402, 603);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Пользователи программы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1402, 603);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Работники предприятия";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1402, 603);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Инструкция";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1219, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closed_event);
            ((System.ComponentModel.ISupportInitialize)(this.pcData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Moving)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Modernization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView pcData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeEquipment;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Modernization;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView Moving;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Button editEquipment;
        private Button addEquipment;
        private DataGridViewTextBoxColumn TypeOfWork;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private Button saveModernization;
        private Button button1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn type_q;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn manufacturer;
        private DataGridViewTextBoxColumn ip;
        private DataGridViewTextBoxColumn owner;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn cabinet;
    }
}