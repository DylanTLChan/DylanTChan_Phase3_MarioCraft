namespace DylanChan_MarioCraft_Phase3
{
    partial class frmGameUserMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameUserMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLogOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEREMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMEUSERDETAILSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DylanChan_MarioCraft_Phase3.DataSet1();
            this.qUICKINVENTORYVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERDETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERTableAdapter = new DylanChan_MarioCraft_Phase3.DataSet1TableAdapters.GAMEUSERTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMEUSERDETAILSTableAdapter = new DylanChan_MarioCraft_Phase3.DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter();
            this.qUICKINVENTORYVIEWTableAdapter = new DylanChan_MarioCraft_Phase3.DataSet1TableAdapters.QUICKINVENTORYVIEWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUICKINVENTORYVIEWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(758, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLogOut
            // 
            this.txtLogOut.Location = new System.Drawing.Point(0, 360);
            this.txtLogOut.Name = "txtLogOut";
            this.txtLogOut.Size = new System.Drawing.Size(75, 23);
            this.txtLogOut.TabIndex = 6;
            this.txtLogOut.Text = "Log Out";
            this.txtLogOut.UseVisualStyleBackColor = true;
            this.txtLogOut.Click += new System.EventHandler(this.txtLogOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSEREMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMEUSERDETAILSBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(98, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 68);
            this.dataGridView1.TabIndex = 9;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "USERID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // uSEREMAILDataGridViewTextBoxColumn
            // 
            this.uSEREMAILDataGridViewTextBoxColumn.DataPropertyName = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.HeaderText = "USEREMAIL";
            this.uSEREMAILDataGridViewTextBoxColumn.Name = "uSEREMAILDataGridViewTextBoxColumn";
            // 
            // gAMEUSERDETAILSBindingSource1
            // 
            this.gAMEUSERDETAILSBindingSource1.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUICKINVENTORYVIEWBindingSource
            // 
            this.qUICKINVENTORYVIEWBindingSource.DataMember = "QUICKINVENTORYVIEW";
            this.qUICKINVENTORYVIEWBindingSource.DataSource = this.dataSet1;
            // 
            // gAMEUSERDETAILSBindingSource
            // 
            this.gAMEUSERDETAILSBindingSource.DataMember = "GAMEUSERDETAILS";
            this.gAMEUSERDETAILSBindingSource.DataSource = this.dataSet1;
            // 
            // gAMEUSERBindingSource
            // 
            this.gAMEUSERBindingSource.DataMember = "GAMEUSER";
            this.gAMEUSERBindingSource.DataSource = this.dataSet1;
            // 
            // gAMEUSERTableAdapter
            // 
            this.gAMEUSERTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // gAMEUSERDETAILSTableAdapter
            // 
            this.gAMEUSERDETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // qUICKINVENTORYVIEWTableAdapter
            // 
            this.qUICKINVENTORYVIEWTableAdapter.ClearBeforeFill = true;
            // 
            // frmGameUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DylanChan_MarioCraft_Phase3.Properties.Resources.Mario_Wallpaper;
            this.ClientSize = new System.Drawing.Size(834, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLogOut);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameUserMenu";
            this.Text = "GameUserMenu";
            this.Load += new System.EventHandler(this.GameUserMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUICKINVENTORYVIEWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERDETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMEUSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button txtLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource gAMEUSERBindingSource;
        private DataSet1TableAdapters.GAMEUSERTableAdapter gAMEUSERTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource;
        private DataSet1TableAdapters.GAMEUSERDETAILSTableAdapter gAMEUSERDETAILSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEREMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gAMEUSERDETAILSBindingSource1;
        private System.Windows.Forms.BindingSource qUICKINVENTORYVIEWBindingSource;
        private DataSet1TableAdapters.QUICKINVENTORYVIEWTableAdapter qUICKINVENTORYVIEWTableAdapter;
    }
}