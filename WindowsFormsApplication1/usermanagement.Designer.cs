namespace WindowsFormsApplication1
{
    partial class usermanagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db3DataSet = new WindowsFormsApplication1.db3DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usersTableAdapter = new WindowsFormsApplication1.db3DataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db3DataSet1 = new WindowsFormsApplication1.db3DataSet1();
            this.t2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t2TableAdapter = new WindowsFormsApplication1.db3DataSet1TableAdapters.t2TableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saletavalod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismodir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.username,
            this.pas,
            this.saletavalod,
            this.email,
            this.ismodir});
            this.dataGridView1.DataSource = this.usersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(663, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.db3DataSet;
            // 
            // db3DataSet
            // 
            this.db3DataSet.DataSetName = "db3DataSet";
            this.db3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.db3DataSet;
            // 
            // db3DataSet1
            // 
            this.db3DataSet1.DataSetName = "db3DataSet1";
            this.db3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t2BindingSource
            // 
            this.t2BindingSource.DataMember = "t2";
            this.t2BindingSource.DataSource = this.db3DataSet1;
            // 
            // t2TableAdapter
            // 
            this.t2TableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 48;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.Width = 72;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            // 
            // pas
            // 
            this.pas.DataPropertyName = "pas";
            this.pas.HeaderText = "pas";
            this.pas.Name = "pas";
            // 
            // saletavalod
            // 
            this.saletavalod.DataPropertyName = "saletavalod";
            this.saletavalod.HeaderText = "saletavalod";
            this.saletavalod.Name = "saletavalod";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // ismodir
            // 
            this.ismodir.DataPropertyName = "ismodir";
            this.ismodir.HeaderText = "ismodir";
            this.ismodir.Name = "ismodir";
            // 
            // usermanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "usermanagement";
            this.Text = "usermanagement";
            this.Load += new System.EventHandler(this.usermanagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private db3DataSet db3DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private db3DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private db3DataSet1 db3DataSet1;
        private System.Windows.Forms.BindingSource t2BindingSource;
        private db3DataSet1TableAdapters.t2TableAdapter t2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn pas;
        private System.Windows.Forms.DataGridViewTextBoxColumn saletavalod;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismodir;
    }
}