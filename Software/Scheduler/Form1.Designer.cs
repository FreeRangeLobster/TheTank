
namespace Scheduler
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.ResultsGridStepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridMeasured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridTestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsGridRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(19, 353);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(730, 111);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.102804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.89719F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultsDataGridView, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.747073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.25293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 468);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(18, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(756, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open Por";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "RetrieveData";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Send Data";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.AllowUserToResizeRows = false;
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.ResultsDataGridView.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultsGridStepNumber,
            this.ResultsGridID,
            this.ResultsGridDescription,
            this.ResultsGridStatus,
            this.ResultsGridNominal,
            this.ResultsGridMinimum,
            this.ResultsGridMeasured,
            this.ResultsGridMaximum,
            this.ResultsGridUnits,
            this.ResultsGridTestTime,
            this.ResultsGridTotalTime,
            this.ResultsGridRef});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ResultsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ResultsDataGridView.Location = new System.Drawing.Point(753, 195);
            this.ResultsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.ResultsDataGridView.MultiSelect = false;
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.RowHeadersWidth = 51;
            this.ResultsDataGridView.RowTemplate.Height = 30;
            this.ResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ResultsDataGridView.ShowCellErrors = false;
            this.ResultsDataGridView.ShowEditingIcon = false;
            this.ResultsDataGridView.ShowRowErrors = false;
            this.ResultsDataGridView.Size = new System.Drawing.Size(116, 154);
            this.ResultsDataGridView.TabIndex = 4;
            // 
            // ResultsGridStepNumber
            // 
            this.ResultsGridStepNumber.FillWeight = 50F;
            this.ResultsGridStepNumber.HeaderText = "Step";
            this.ResultsGridStepNumber.MinimumWidth = 60;
            this.ResultsGridStepNumber.Name = "ResultsGridStepNumber";
            this.ResultsGridStepNumber.ReadOnly = true;
            // 
            // ResultsGridID
            // 
            this.ResultsGridID.HeaderText = "ID";
            this.ResultsGridID.MinimumWidth = 60;
            this.ResultsGridID.Name = "ResultsGridID";
            this.ResultsGridID.ReadOnly = true;
            // 
            // ResultsGridDescription
            // 
            this.ResultsGridDescription.FillWeight = 500F;
            this.ResultsGridDescription.HeaderText = "Description";
            this.ResultsGridDescription.MinimumWidth = 100;
            this.ResultsGridDescription.Name = "ResultsGridDescription";
            this.ResultsGridDescription.ReadOnly = true;
            // 
            // ResultsGridStatus
            // 
            this.ResultsGridStatus.HeaderText = "Status";
            this.ResultsGridStatus.MinimumWidth = 60;
            this.ResultsGridStatus.Name = "ResultsGridStatus";
            this.ResultsGridStatus.ReadOnly = true;
            // 
            // ResultsGridNominal
            // 
            this.ResultsGridNominal.HeaderText = "Nominal";
            this.ResultsGridNominal.MinimumWidth = 60;
            this.ResultsGridNominal.Name = "ResultsGridNominal";
            this.ResultsGridNominal.ReadOnly = true;
            this.ResultsGridNominal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResultsGridMinimum
            // 
            this.ResultsGridMinimum.HeaderText = "Minimum";
            this.ResultsGridMinimum.MinimumWidth = 60;
            this.ResultsGridMinimum.Name = "ResultsGridMinimum";
            this.ResultsGridMinimum.ReadOnly = true;
            this.ResultsGridMinimum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResultsGridMeasured
            // 
            this.ResultsGridMeasured.HeaderText = "Measured";
            this.ResultsGridMeasured.MinimumWidth = 60;
            this.ResultsGridMeasured.Name = "ResultsGridMeasured";
            this.ResultsGridMeasured.ReadOnly = true;
            this.ResultsGridMeasured.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResultsGridMaximum
            // 
            this.ResultsGridMaximum.HeaderText = "Maximum";
            this.ResultsGridMaximum.MinimumWidth = 60;
            this.ResultsGridMaximum.Name = "ResultsGridMaximum";
            this.ResultsGridMaximum.ReadOnly = true;
            this.ResultsGridMaximum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResultsGridUnits
            // 
            this.ResultsGridUnits.HeaderText = "Units";
            this.ResultsGridUnits.MinimumWidth = 60;
            this.ResultsGridUnits.Name = "ResultsGridUnits";
            this.ResultsGridUnits.ReadOnly = true;
            // 
            // ResultsGridTestTime
            // 
            dataGridViewCellStyle2.Format = "0.00";
            this.ResultsGridTestTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ResultsGridTestTime.HeaderText = "Test Time";
            this.ResultsGridTestTime.MinimumWidth = 60;
            this.ResultsGridTestTime.Name = "ResultsGridTestTime";
            this.ResultsGridTestTime.ReadOnly = true;
            // 
            // ResultsGridTotalTime
            // 
            dataGridViewCellStyle3.Format = "0.0";
            this.ResultsGridTotalTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResultsGridTotalTime.HeaderText = "Total Time";
            this.ResultsGridTotalTime.MinimumWidth = 60;
            this.ResultsGridTotalTime.Name = "ResultsGridTotalTime";
            this.ResultsGridTotalTime.ReadOnly = true;
            // 
            // ResultsGridRef
            // 
            this.ResultsGridRef.FillWeight = 50F;
            this.ResultsGridRef.HeaderText = "Ref";
            this.ResultsGridRef.MinimumWidth = 60;
            this.ResultsGridRef.Name = "ResultsGridRef";
            this.ResultsGridRef.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cActive,
            this.cOutput,
            this.cState,
            this.cDay,
            this.cHour,
            this.cMinute});
            this.dataGridView1.Location = new System.Drawing.Point(18, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 148);
            this.dataGridView1.TabIndex = 5;
            // 
            // cActive
            // 
            this.cActive.HeaderText = "Active";
            this.cActive.Name = "cActive";
            // 
            // cOutput
            // 
            this.cOutput.HeaderText = "Output";
            this.cOutput.Name = "cOutput";
            // 
            // cState
            // 
            this.cState.HeaderText = "State";
            this.cState.Name = "cState";
            // 
            // cDay
            // 
            this.cDay.HeaderText = "Day";
            this.cDay.Name = "cDay";
            // 
            // cHour
            // 
            this.cHour.HeaderText = "Hour";
            this.cHour.Name = "cHour";
            // 
            // cMinute
            // 
            this.cMinute.HeaderText = "Minute";
            this.cMinute.Name = "cMinute";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(320, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(615, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(463, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(333, 108);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(112, 20);
            this.textBox6.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridStepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridMeasured;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridTestTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridTotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultsGridRef;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn cState;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinute;
    }
}

