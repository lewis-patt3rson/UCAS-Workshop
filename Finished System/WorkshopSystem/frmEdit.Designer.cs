namespace WorkshopSystem
{
    partial class frmEdit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWorkshops = new System.Windows.Forms.Button();
            this.btnCoach = new System.Windows.Forms.Button();
            this.btnCampus = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelWorkshops = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvWorkshop = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveWorkshopEdits = new System.Windows.Forms.Button();
            this.btnNewWorkshop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewWorkshop = new System.Windows.Forms.TextBox();
            this.btnDeleteWorkshop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCoor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteCoor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewCoorFor = new System.Windows.Forms.TextBox();
            this.btnSaveCoor = new System.Windows.Forms.Button();
            this.btnNewCoor = new System.Windows.Forms.Button();
            this.dgvCoor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewCoorSur = new System.Windows.Forms.TextBox();
            this.panelCampus = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewCampus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteCampus = new System.Windows.Forms.Button();
            this.btnEditCampus = new System.Windows.Forms.Button();
            this.btnAddCampus = new System.Windows.Forms.Button();
            this.dgvCampus = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSession = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.cmbCoach = new System.Windows.Forms.ComboBox();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.cmbWshops = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbHours = new System.Windows.Forms.ComboBox();
            this.cmbMins = new System.Windows.Forms.ComboBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelWorkshops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).BeginInit();
            this.panelCoor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoor)).BeginInit();
            this.panelCampus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).BeginInit();
            this.panelSession.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Choose a list to edit:";
            // 
            // btnWorkshops
            // 
            this.btnWorkshops.Location = new System.Drawing.Point(247, 6);
            this.btnWorkshops.Name = "btnWorkshops";
            this.btnWorkshops.Size = new System.Drawing.Size(76, 27);
            this.btnWorkshops.TabIndex = 41;
            this.btnWorkshops.Text = "Workshops";
            this.btnWorkshops.UseVisualStyleBackColor = true;
            this.btnWorkshops.Click += new System.EventHandler(this.btnWorkshops_Click);
            // 
            // btnCoach
            // 
            this.btnCoach.Location = new System.Drawing.Point(329, 6);
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.Size = new System.Drawing.Size(85, 27);
            this.btnCoach.TabIndex = 42;
            this.btnCoach.Text = "Co-Ordinators";
            this.btnCoach.UseVisualStyleBackColor = true;
            this.btnCoach.Click += new System.EventHandler(this.btnCoach_Click);
            // 
            // btnCampus
            // 
            this.btnCampus.Location = new System.Drawing.Point(420, 6);
            this.btnCampus.Name = "btnCampus";
            this.btnCampus.Size = new System.Drawing.Size(76, 27);
            this.btnCampus.TabIndex = 43;
            this.btnCampus.Text = "Campus\'";
            this.btnCampus.UseVisualStyleBackColor = true;
            this.btnCampus.Click += new System.EventHandler(this.btnCampus_Click);
            // 
            // btnSession
            // 
            this.btnSession.Location = new System.Drawing.Point(502, 6);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(76, 27);
            this.btnSession.TabIndex = 44;
            this.btnSession.Text = "Sessions";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelWorkshops);
            this.panelMain.Location = new System.Drawing.Point(16, 39);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(729, 386);
            this.panelMain.TabIndex = 46;
            // 
            // panelWorkshops
            // 
            this.panelWorkshops.Controls.Add(this.panelCoor);
            this.panelWorkshops.Controls.Add(this.label2);
            this.panelWorkshops.Controls.Add(this.btnDeleteWorkshop);
            this.panelWorkshops.Controls.Add(this.label7);
            this.panelWorkshops.Controls.Add(this.txtNewWorkshop);
            this.panelWorkshops.Controls.Add(this.btnSaveWorkshopEdits);
            this.panelWorkshops.Controls.Add(this.btnNewWorkshop);
            this.panelWorkshops.Controls.Add(this.dgvWorkshop);
            this.panelWorkshops.Controls.Add(this.label6);
            this.panelWorkshops.Controls.Add(this.label10);
            this.panelWorkshops.Location = new System.Drawing.Point(0, 0);
            this.panelWorkshops.Name = "panelWorkshops";
            this.panelWorkshops.Size = new System.Drawing.Size(729, 386);
            this.panelWorkshops.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(134, -26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Workshops:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 27);
            this.label6.TabIndex = 56;
            this.label6.Text = "Existing Workshops:";
            // 
            // dgvWorkshop
            // 
            this.dgvWorkshop.AllowUserToAddRows = false;
            this.dgvWorkshop.AllowUserToDeleteRows = false;
            this.dgvWorkshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkshop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colHeld});
            this.dgvWorkshop.Location = new System.Drawing.Point(17, 46);
            this.dgvWorkshop.Name = "dgvWorkshop";
            this.dgvWorkshop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkshop.Size = new System.Drawing.Size(448, 320);
            this.dgvWorkshop.TabIndex = 58;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 40;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Workshop Name";
            this.colName.Name = "colName";
            // 
            // colHeld
            // 
            this.colHeld.HeaderText = "Sessions";
            this.colHeld.Name = "colHeld";
            this.colHeld.Width = 80;
            // 
            // btnSaveWorkshopEdits
            // 
            this.btnSaveWorkshopEdits.BackColor = System.Drawing.Color.Khaki;
            this.btnSaveWorkshopEdits.Location = new System.Drawing.Point(486, 188);
            this.btnSaveWorkshopEdits.Name = "btnSaveWorkshopEdits";
            this.btnSaveWorkshopEdits.Size = new System.Drawing.Size(226, 43);
            this.btnSaveWorkshopEdits.TabIndex = 60;
            this.btnSaveWorkshopEdits.Text = "Save edits.";
            this.btnSaveWorkshopEdits.UseVisualStyleBackColor = false;
            this.btnSaveWorkshopEdits.Click += new System.EventHandler(this.btnSaveWorkshopEdits_Click);
            // 
            // btnNewWorkshop
            // 
            this.btnNewWorkshop.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewWorkshop.Location = new System.Drawing.Point(486, 326);
            this.btnNewWorkshop.Name = "btnNewWorkshop";
            this.btnNewWorkshop.Size = new System.Drawing.Size(226, 41);
            this.btnNewWorkshop.TabIndex = 59;
            this.btnNewWorkshop.Text = "Add new workshop.";
            this.btnNewWorkshop.UseVisualStyleBackColor = false;
            this.btnNewWorkshop.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(482, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "New Workshop Name:";
            // 
            // txtNewWorkshop
            // 
            this.txtNewWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWorkshop.Location = new System.Drawing.Point(486, 299);
            this.txtNewWorkshop.Name = "txtNewWorkshop";
            this.txtNewWorkshop.Size = new System.Drawing.Size(226, 22);
            this.txtNewWorkshop.TabIndex = 62;
            // 
            // btnDeleteWorkshop
            // 
            this.btnDeleteWorkshop.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteWorkshop.Location = new System.Drawing.Point(486, 47);
            this.btnDeleteWorkshop.Name = "btnDeleteWorkshop";
            this.btnDeleteWorkshop.Size = new System.Drawing.Size(226, 43);
            this.btnDeleteWorkshop.TabIndex = 64;
            this.btnDeleteWorkshop.Text = "Delete selected workshop.";
            this.btnDeleteWorkshop.UseVisualStyleBackColor = false;
            this.btnDeleteWorkshop.Click += new System.EventHandler(this.btnDeleteWorkshop_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(482, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 65;
            this.label2.Text = "(Workshops with sessions recorded can\'t be deleted.)";
            // 
            // panelCoor
            // 
            this.panelCoor.Controls.Add(this.panelCampus);
            this.panelCoor.Controls.Add(this.label9);
            this.panelCoor.Controls.Add(this.txtNewCoorSur);
            this.panelCoor.Controls.Add(this.label3);
            this.panelCoor.Controls.Add(this.btnDeleteCoor);
            this.panelCoor.Controls.Add(this.label4);
            this.panelCoor.Controls.Add(this.txtNewCoorFor);
            this.panelCoor.Controls.Add(this.btnSaveCoor);
            this.panelCoor.Controls.Add(this.btnNewCoor);
            this.panelCoor.Controls.Add(this.dgvCoor);
            this.panelCoor.Controls.Add(this.label5);
            this.panelCoor.Controls.Add(this.label8);
            this.panelCoor.Location = new System.Drawing.Point(0, 0);
            this.panelCoor.Name = "panelCoor";
            this.panelCoor.Size = new System.Drawing.Size(729, 386);
            this.panelCoor.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(482, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 46);
            this.label3.TabIndex = 65;
            this.label3.Text = "(Co-ordinators who have held workshops can not be deleted.)";
            // 
            // btnDeleteCoor
            // 
            this.btnDeleteCoor.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteCoor.Location = new System.Drawing.Point(486, 47);
            this.btnDeleteCoor.Name = "btnDeleteCoor";
            this.btnDeleteCoor.Size = new System.Drawing.Size(226, 43);
            this.btnDeleteCoor.TabIndex = 64;
            this.btnDeleteCoor.Text = "Delete selected co-ordinator.";
            this.btnDeleteCoor.UseVisualStyleBackColor = false;
            this.btnDeleteCoor.Click += new System.EventHandler(this.btnDeleteCoor_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(482, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 63;
            this.label4.Text = "New Co-Ordinator Forname:";
            // 
            // txtNewCoorFor
            // 
            this.txtNewCoorFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoorFor.Location = new System.Drawing.Point(486, 251);
            this.txtNewCoorFor.Name = "txtNewCoorFor";
            this.txtNewCoorFor.Size = new System.Drawing.Size(226, 22);
            this.txtNewCoorFor.TabIndex = 62;
            this.txtNewCoorFor.TextChanged += new System.EventHandler(this.txtNewCoorFor_TextChanged);
            // 
            // btnSaveCoor
            // 
            this.btnSaveCoor.BackColor = System.Drawing.Color.Khaki;
            this.btnSaveCoor.Location = new System.Drawing.Point(486, 158);
            this.btnSaveCoor.Name = "btnSaveCoor";
            this.btnSaveCoor.Size = new System.Drawing.Size(226, 43);
            this.btnSaveCoor.TabIndex = 60;
            this.btnSaveCoor.Text = "Save edits.";
            this.btnSaveCoor.UseVisualStyleBackColor = false;
            this.btnSaveCoor.Click += new System.EventHandler(this.btnSaveCoor_Click);
            // 
            // btnNewCoor
            // 
            this.btnNewCoor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewCoor.Location = new System.Drawing.Point(486, 326);
            this.btnNewCoor.Name = "btnNewCoor";
            this.btnNewCoor.Size = new System.Drawing.Size(226, 41);
            this.btnNewCoor.TabIndex = 59;
            this.btnNewCoor.Text = "Add new Co-ordinator.";
            this.btnNewCoor.UseVisualStyleBackColor = false;
            this.btnNewCoor.Click += new System.EventHandler(this.btnNewCoor_Click);
            // 
            // dgvCoor
            // 
            this.dgvCoor.AllowUserToAddRows = false;
            this.dgvCoor.AllowUserToDeleteRows = false;
            this.dgvCoor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colSurname,
            this.dataGridViewTextBoxColumn3});
            this.dgvCoor.Location = new System.Drawing.Point(17, 46);
            this.dgvCoor.Name = "dgvCoor";
            this.dgvCoor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoor.Size = new System.Drawing.Size(448, 320);
            this.dgvCoor.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 27);
            this.label5.TabIndex = 56;
            this.label5.Text = "Existing Co-ordinators:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(134, -26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Workshops:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Forename";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // colSurname
            // 
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sessions Held";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(482, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "New Co-Ordinator Surname:";
            // 
            // txtNewCoorSur
            // 
            this.txtNewCoorSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCoorSur.Location = new System.Drawing.Point(486, 299);
            this.txtNewCoorSur.Name = "txtNewCoorSur";
            this.txtNewCoorSur.Size = new System.Drawing.Size(226, 22);
            this.txtNewCoorSur.TabIndex = 66;
            // 
            // panelCampus
            // 
            this.panelCampus.Controls.Add(this.panelSession);
            this.panelCampus.Controls.Add(this.label11);
            this.panelCampus.Controls.Add(this.txtNewCampus);
            this.panelCampus.Controls.Add(this.label12);
            this.panelCampus.Controls.Add(this.btnDeleteCampus);
            this.panelCampus.Controls.Add(this.btnEditCampus);
            this.panelCampus.Controls.Add(this.btnAddCampus);
            this.panelCampus.Controls.Add(this.dgvCampus);
            this.panelCampus.Controls.Add(this.label14);
            this.panelCampus.Controls.Add(this.label15);
            this.panelCampus.Location = new System.Drawing.Point(0, 0);
            this.panelCampus.Name = "panelCampus";
            this.panelCampus.Size = new System.Drawing.Size(729, 386);
            this.panelCampus.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(482, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 23);
            this.label11.TabIndex = 67;
            this.label11.Text = "New Campus Name";
            // 
            // txtNewCampus
            // 
            this.txtNewCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCampus.Location = new System.Drawing.Point(486, 299);
            this.txtNewCampus.Name = "txtNewCampus";
            this.txtNewCampus.Size = new System.Drawing.Size(226, 22);
            this.txtNewCampus.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(482, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 46);
            this.label12.TabIndex = 65;
            this.label12.Text = "(Campus\' with sessions that were held in them, can not be deleted.)";
            // 
            // btnDeleteCampus
            // 
            this.btnDeleteCampus.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteCampus.Location = new System.Drawing.Point(486, 47);
            this.btnDeleteCampus.Name = "btnDeleteCampus";
            this.btnDeleteCampus.Size = new System.Drawing.Size(226, 43);
            this.btnDeleteCampus.TabIndex = 64;
            this.btnDeleteCampus.Text = "Delete selected campus.";
            this.btnDeleteCampus.UseVisualStyleBackColor = false;
            this.btnDeleteCampus.Click += new System.EventHandler(this.btnDeleteCampus_Click);
            // 
            // btnEditCampus
            // 
            this.btnEditCampus.BackColor = System.Drawing.Color.Khaki;
            this.btnEditCampus.Location = new System.Drawing.Point(486, 179);
            this.btnEditCampus.Name = "btnEditCampus";
            this.btnEditCampus.Size = new System.Drawing.Size(226, 43);
            this.btnEditCampus.TabIndex = 60;
            this.btnEditCampus.Text = "Save edits.";
            this.btnEditCampus.UseVisualStyleBackColor = false;
            this.btnEditCampus.Click += new System.EventHandler(this.btnEditCampus_Click);
            // 
            // btnAddCampus
            // 
            this.btnAddCampus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddCampus.Location = new System.Drawing.Point(486, 326);
            this.btnAddCampus.Name = "btnAddCampus";
            this.btnAddCampus.Size = new System.Drawing.Size(226, 41);
            this.btnAddCampus.TabIndex = 59;
            this.btnAddCampus.Text = "Add new campus.";
            this.btnAddCampus.UseVisualStyleBackColor = false;
            this.btnAddCampus.Click += new System.EventHandler(this.btnAddCampus_Click);
            // 
            // dgvCampus
            // 
            this.dgvCampus.AllowUserToAddRows = false;
            this.dgvCampus.AllowUserToDeleteRows = false;
            this.dgvCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.dgvCampus.Location = new System.Drawing.Point(17, 46);
            this.dgvCampus.Name = "dgvCampus";
            this.dgvCampus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampus.Size = new System.Drawing.Size(448, 320);
            this.dgvCampus.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(246, 27);
            this.label14.TabIndex = 56;
            this.label14.Text = "Existing Campus\':";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(134, -26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Workshops:";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Campus Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Sessions Held";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // panelSession
            // 
            this.panelSession.Controls.Add(this.panelDisplay);
            this.panelSession.Controls.Add(this.label13);
            this.panelSession.Controls.Add(this.txtSearch);
            this.panelSession.Controls.Add(this.btnSearch);
            this.panelSession.Controls.Add(this.label18);
            this.panelSession.Location = new System.Drawing.Point(0, 0);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(729, 386);
            this.panelSession.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(134, -26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 24);
            this.label18.TabIndex = 39;
            this.label18.Text = "Workshops:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(13, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(452, 23);
            this.label13.TabIndex = 67;
            this.label13.Text = "Please enter the id for the session you want to edit/delete:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(471, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(107, 22);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(584, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 22);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.button1);
            this.panelDisplay.Controls.Add(this.cmbMins);
            this.panelDisplay.Controls.Add(this.cmbHours);
            this.panelDisplay.Controls.Add(this.label25);
            this.panelDisplay.Controls.Add(this.lblID);
            this.panelDisplay.Controls.Add(this.btnEditStudents);
            this.panelDisplay.Controls.Add(this.btnDeleteSession);
            this.panelDisplay.Controls.Add(this.btnSaveSession);
            this.panelDisplay.Controls.Add(this.dtpSessionDate);
            this.panelDisplay.Controls.Add(this.label24);
            this.panelDisplay.Controls.Add(this.label23);
            this.panelDisplay.Controls.Add(this.label21);
            this.panelDisplay.Controls.Add(this.label22);
            this.panelDisplay.Controls.Add(this.label19);
            this.panelDisplay.Controls.Add(this.label17);
            this.panelDisplay.Controls.Add(this.label16);
            this.panelDisplay.Controls.Add(this.label20);
            this.panelDisplay.Controls.Add(this.cmbCoach);
            this.panelDisplay.Controls.Add(this.cmbCampus);
            this.panelDisplay.Controls.Add(this.cmbWshops);
            this.panelDisplay.Location = new System.Drawing.Point(17, 40);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(695, 327);
            this.panelDisplay.TabIndex = 68;
            this.panelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // cmbCoach
            // 
            this.cmbCoach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoach.Enabled = false;
            this.cmbCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoach.FormattingEnabled = true;
            this.cmbCoach.Location = new System.Drawing.Point(144, 195);
            this.cmbCoach.Name = "cmbCoach";
            this.cmbCoach.Size = new System.Drawing.Size(182, 23);
            this.cmbCoach.TabIndex = 27;
            // 
            // cmbCampus
            // 
            this.cmbCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampus.Enabled = false;
            this.cmbCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(144, 233);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(182, 23);
            this.cmbCampus.TabIndex = 25;
            // 
            // cmbWshops
            // 
            this.cmbWshops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWshops.Enabled = false;
            this.cmbWshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWshops.FormattingEnabled = true;
            this.cmbWshops.Location = new System.Drawing.Point(144, 159);
            this.cmbWshops.Name = "cmbWshops";
            this.cmbWshops.Size = new System.Drawing.Size(182, 23);
            this.cmbWshops.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(46, 159);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 23);
            this.label20.TabIndex = 69;
            this.label20.Text = "Workshop:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei Light", 14F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(139, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 23);
            this.label16.TabIndex = 70;
            this.label16.Text = "Session Details:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(50, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 23);
            this.label17.TabIndex = 71;
            this.label17.Text = "Session ID:";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(30, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 23);
            this.label19.TabIndex = 72;
            this.label19.Text = "Session Date: ";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(27, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 23);
            this.label22.TabIndex = 73;
            this.label22.Text = "Session Time:";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(18, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 23);
            this.label21.TabIndex = 74;
            this.label21.Text = "Co-Ordinator:";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(54, 232);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 23);
            this.label23.TabIndex = 75;
            this.label23.Text = "Campus:";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(197, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 23);
            this.label24.TabIndex = 77;
            this.label24.Text = ":";
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.Location = new System.Drawing.Point(144, 79);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(182, 20);
            this.dtpSessionDate.TabIndex = 78;
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveSession.Location = new System.Drawing.Point(469, 218);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(182, 38);
            this.btnSaveSession.TabIndex = 69;
            this.btnSaveSession.Text = "Save edits.";
            this.btnSaveSession.UseVisualStyleBackColor = false;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteSession.Location = new System.Drawing.Point(469, 170);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(182, 38);
            this.btnDeleteSession.TabIndex = 79;
            this.btnDeleteSession.Text = "Delete Session.";
            this.btnDeleteSession.UseVisualStyleBackColor = false;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.BackColor = System.Drawing.Color.Khaki;
            this.btnEditStudents.Location = new System.Drawing.Point(469, 123);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(182, 38);
            this.btnEditStudents.TabIndex = 80;
            this.btnEditStudents.Text = "View Attendees.";
            this.btnEditStudents.UseVisualStyleBackColor = false;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(140, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 23);
            this.lblID.TabIndex = 81;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(256, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 23);
            this.label25.TabIndex = 82;
            this.label25.Text = "(hh:mm)";
            // 
            // cmbHours
            // 
            this.cmbHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHours.Enabled = false;
            this.cmbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHours.FormattingEnabled = true;
            this.cmbHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHours.Location = new System.Drawing.Point(144, 119);
            this.cmbHours.Name = "cmbHours";
            this.cmbHours.Size = new System.Drawing.Size(59, 23);
            this.cmbHours.TabIndex = 83;
            // 
            // cmbMins
            // 
            this.cmbMins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMins.Enabled = false;
            this.cmbMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMins.FormattingEnabled = true;
            this.cmbMins.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMins.Location = new System.Drawing.Point(209, 119);
            this.cmbMins.Name = "cmbMins";
            this.cmbMins.Size = new System.Drawing.Size(48, 23);
            this.cmbMins.TabIndex = 84;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(469, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 85;
            this.button1.Text = "Change Course.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 437);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnSession);
            this.Controls.Add(this.btnCampus);
            this.Controls.Add(this.btnCoach);
            this.Controls.Add(this.btnWorkshops);
            this.Controls.Add(this.label1);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.panelMain.ResumeLayout(false);
            this.panelWorkshops.ResumeLayout(false);
            this.panelWorkshops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).EndInit();
            this.panelCoor.ResumeLayout(false);
            this.panelCoor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoor)).EndInit();
            this.panelCampus.ResumeLayout(false);
            this.panelCampus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampus)).EndInit();
            this.panelSession.ResumeLayout(false);
            this.panelSession.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWorkshops;
        private System.Windows.Forms.Button btnCoach;
        private System.Windows.Forms.Button btnCampus;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelWorkshops;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvWorkshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeld;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveWorkshopEdits;
        private System.Windows.Forms.Button btnNewWorkshop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewWorkshop;
        private System.Windows.Forms.Button btnDeleteWorkshop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteCoor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewCoorFor;
        private System.Windows.Forms.Button btnSaveCoor;
        private System.Windows.Forms.Button btnNewCoor;
        private System.Windows.Forms.DataGridView dgvCoor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewCoorSur;
        private System.Windows.Forms.Panel panelCampus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNewCampus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteCampus;
        private System.Windows.Forms.Button btnEditCampus;
        private System.Windows.Forms.Button btnAddCampus;
        private System.Windows.Forms.DataGridView dgvCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbCoach;
        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.ComboBox cmbWshops;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbMins;
        private System.Windows.Forms.ComboBox cmbHours;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Button button1;
    }
}