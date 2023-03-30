namespace Monitor2
{
    partial class Monitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.bPAD = new System.Windows.Forms.Button();
            this.bHospII = new System.Windows.Forms.Button();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bHospLI = new System.Windows.Forms.Button();
            this.bHospLP = new System.Windows.Forms.Button();
            this.cbChangeAnalysis = new System.Windows.Forms.CheckBox();
            this.bLPCheck = new System.Windows.Forms.Button();
            this.tbIBnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPAD
            // 
            this.bPAD.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPAD.Location = new System.Drawing.Point(12, 12);
            this.bPAD.Name = "bPAD";
            this.bPAD.Size = new System.Drawing.Size(260, 101);
            this.bPAD.TabIndex = 0;
            this.bPAD.TabStop = false;
            this.bPAD.Text = "Экстренные направления в ПАО:\r\n???";
            this.bPAD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bPAD.UseVisualStyleBackColor = true;
            this.bPAD.Click += new System.EventHandler(this.bPAD_Click);
            // 
            // bHospII
            // 
            this.bHospII.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bHospII.Location = new System.Drawing.Point(296, 136);
            this.bHospII.Name = "bHospII";
            this.bHospII.Size = new System.Drawing.Size(260, 101);
            this.bHospII.TabIndex = 1;
            this.bHospII.TabStop = false;
            this.bHospII.Text = "Госпитализированные без ИИ:\r\n???";
            this.bHospII.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bHospII.UseVisualStyleBackColor = true;
            this.bHospII.Click += new System.EventHandler(this.bHospII_Click);
            // 
            // dpStartDate
            // 
            this.dpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpStartDate.CustomFormat = "";
            this.dpStartDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartDate.Location = new System.Drawing.Point(1074, 12);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(178, 39);
            this.dpStartDate.TabIndex = 2;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpEndDate.CustomFormat = "";
            this.dpEndDate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(1074, 74);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(178, 39);
            this.dpEndDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1039, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1019, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ПО";
            // 
            // bRefresh
            // 
            this.bRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bRefresh.Image = global::Monitor2.Properties.Resources.arrow_reload_refresh_sync_icon_176208__1_;
            this.bRefresh.Location = new System.Drawing.Point(1074, 253);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(178, 65);
            this.bRefresh.TabIndex = 6;
            this.bRefresh.TabStop = false;
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bHospLI
            // 
            this.bHospLI.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bHospLI.Location = new System.Drawing.Point(12, 136);
            this.bHospLI.Name = "bHospLI";
            this.bHospLI.Size = new System.Drawing.Size(260, 101);
            this.bHospLI.TabIndex = 7;
            this.bHospLI.TabStop = false;
            this.bHospLI.Text = "Госпитализированные без ЛИ: \r\n???";
            this.bHospLI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bHospLI.UseVisualStyleBackColor = true;
            this.bHospLI.Click += new System.EventHandler(this.bHospLI_Click);
            // 
            // bHospLP
            // 
            this.bHospLP.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bHospLP.Location = new System.Drawing.Point(580, 136);
            this.bHospLP.Name = "bHospLP";
            this.bHospLP.Size = new System.Drawing.Size(260, 101);
            this.bHospLP.TabIndex = 8;
            this.bHospLP.TabStop = false;
            this.bHospLP.Text = "Госпитализированные без ЛП:\r\n???";
            this.bHospLP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bHospLP.UseVisualStyleBackColor = true;
            this.bHospLP.Click += new System.EventHandler(this.bHospIP_Click);
            // 
            // cbChangeAnalysis
            // 
            this.cbChangeAnalysis.AutoSize = true;
            this.cbChangeAnalysis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbChangeAnalysis.Location = new System.Drawing.Point(990, 183);
            this.cbChangeAnalysis.Name = "cbChangeAnalysis";
            this.cbChangeAnalysis.Size = new System.Drawing.Size(274, 64);
            this.cbChangeAnalysis.TabIndex = 9;
            this.cbChangeAnalysis.Text = "Проверить исправления \r\nна следующий день";
            this.cbChangeAnalysis.UseVisualStyleBackColor = true;
            this.cbChangeAnalysis.CheckedChanged += new System.EventHandler(this.cbChangeAnalysis_CheckedChanged);
            // 
            // bLPCheck
            // 
            this.bLPCheck.Enabled = false;
            this.bLPCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bLPCheck.Location = new System.Drawing.Point(580, 12);
            this.bLPCheck.Name = "bLPCheck";
            this.bLPCheck.Size = new System.Drawing.Size(260, 101);
            this.bLPCheck.TabIndex = 10;
            this.bLPCheck.TabStop = false;
            this.bLPCheck.Text = "ФИО авторов назначений ЛП по конкретной ИБ";
            this.bLPCheck.UseVisualStyleBackColor = true;
            this.bLPCheck.Click += new System.EventHandler(this.bLPCheck_Click);
            // 
            // tbIBnum
            // 
            this.tbIBnum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIBnum.Location = new System.Drawing.Point(1074, 135);
            this.tbIBnum.Multiline = true;
            this.tbIBnum.Name = "tbIBnum";
            this.tbIBnum.Size = new System.Drawing.Size(178, 39);
            this.tbIBnum.TabIndex = 11;
            this.tbIBnum.TextChanged += new System.EventHandler(this.tbIBnum_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1019, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "ИБ";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIBnum);
            this.Controls.Add(this.bLPCheck);
            this.Controls.Add(this.cbChangeAnalysis);
            this.Controls.Add(this.bHospLP);
            this.Controls.Add(this.bHospLI);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpEndDate);
            this.Controls.Add(this.dpStartDate);
            this.Controls.Add(this.bHospII);
            this.Controls.Add(this.bPAD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Монитор";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bPAD;
        private Button bHospII;
        private DateTimePicker dpStartDate;
        private DateTimePicker dpEndDate;
        private Label label1;
        private Label label2;
        private Button bRefresh;
        private Button bHospLI;
        private Button bHospLP;
        private CheckBox cbChangeAnalysis;
        private Button bLPCheck;
        private TextBox tbIBnum;
        private Label label3;
    }
}