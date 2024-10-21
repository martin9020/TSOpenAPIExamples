using System.Windows.Forms;

namespace PadFootingCreator
{
    partial class Form1 : Form
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
            this.SpacingXInput = new System.Windows.Forms.TextBox();
            this.LabelSpacingX = new System.Windows.Forms.Label();
            this.LabelSpacingY = new System.Windows.Forms.Label();
            this.SpacingYInput = new System.Windows.Forms.TextBox();
            this.NumPadsXInput = new System.Windows.Forms.TextBox();
            this.NumPadsYInput = new System.Windows.Forms.TextBox();
            this.InsertJobDescriptionButton = new System.Windows.Forms.Button();
            this.LabelNumberPadsX = new System.Windows.Forms.Label();
            this.LabelNumberPadsY = new System.Windows.Forms.Label();
            this.PostcodeLabel = new System.Windows.Forms.Label();
            this.LabelJobBuilder = new System.Windows.Forms.Label();
            this.JobPostCodeText = new System.Windows.Forms.TextBox();
            this.JobBuilderText = new System.Windows.Forms.TextBox();
            this.LabelJobName = new System.Windows.Forms.Label();
            this.JobNameText = new System.Windows.Forms.TextBox();
            this.LabelJobNumber = new System.Windows.Forms.Label();
            this.JobNumberText = new System.Windows.Forms.TextBox();
            this.LabelJobDesigner = new System.Windows.Forms.Label();
            this.JobDesignerText = new System.Windows.Forms.TextBox();
            this.LabelInfo1 = new System.Windows.Forms.Label();
            this.JobInfo1 = new System.Windows.Forms.TextBox();
            this.LabelJobDescription = new System.Windows.Forms.Label();
            this.JobDescription = new System.Windows.Forms.TextBox();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreatePadFootingButton = new System.Windows.Forms.Button();
            this.LoadColumnSettings = new System.Windows.Forms.ComboBox();
            this.LoadBeamSettings = new System.Windows.Forms.ComboBox();
            this.ColumnSettingsLabel = new System.Windows.Forms.Label();
            this.BeamSettingsLabel = new System.Windows.Forms.Label();
            this.LabelOption = new System.Windows.Forms.Label();
            this.GridInsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpacingXInput
            // 
            this.SpacingXInput.BackColor = System.Drawing.Color.White;
            this.SpacingXInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpacingXInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.SpacingXInput.ForeColor = System.Drawing.Color.Black;
            this.SpacingXInput.Location = new System.Drawing.Point(110, 17);
            this.SpacingXInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpacingXInput.Name = "SpacingXInput";
            this.SpacingXInput.Size = new System.Drawing.Size(124, 25);
            this.SpacingXInput.TabIndex = 1;
            this.SpacingXInput.Text = "1500";
            // 
            // LabelSpacingX
            // 
            this.LabelSpacingX.AutoSize = true;
            this.LabelSpacingX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelSpacingX.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelSpacingX.ForeColor = System.Drawing.Color.White;
            this.LabelSpacingX.Location = new System.Drawing.Point(13, 20);
            this.LabelSpacingX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSpacingX.Name = "LabelSpacingX";
            this.LabelSpacingX.Size = new System.Drawing.Size(75, 19);
            this.LabelSpacingX.TabIndex = 2;
            this.LabelSpacingX.Text = "Spacing X";
            // 
            // LabelSpacingY
            // 
            this.LabelSpacingY.AutoSize = true;
            this.LabelSpacingY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelSpacingY.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelSpacingY.ForeColor = System.Drawing.Color.White;
            this.LabelSpacingY.Location = new System.Drawing.Point(13, 60);
            this.LabelSpacingY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSpacingY.Name = "LabelSpacingY";
            this.LabelSpacingY.Size = new System.Drawing.Size(75, 19);
            this.LabelSpacingY.TabIndex = 4;
            this.LabelSpacingY.Text = "Spacing Y";
            // 
            // SpacingYInput
            // 
            this.SpacingYInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.SpacingYInput.Location = new System.Drawing.Point(110, 57);
            this.SpacingYInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpacingYInput.Name = "SpacingYInput";
            this.SpacingYInput.Size = new System.Drawing.Size(124, 25);
            this.SpacingYInput.TabIndex = 3;
            this.SpacingYInput.Text = "3000";
            // 
            // NumPadsXInput
            // 
            this.NumPadsXInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.NumPadsXInput.Location = new System.Drawing.Point(176, 137);
            this.NumPadsXInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumPadsXInput.Name = "NumPadsXInput";
            this.NumPadsXInput.Size = new System.Drawing.Size(58, 25);
            this.NumPadsXInput.TabIndex = 5;
            this.NumPadsXInput.Text = "5";
            this.NumPadsXInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumPadsYInput
            // 
            this.NumPadsYInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.NumPadsYInput.Location = new System.Drawing.Point(176, 177);
            this.NumPadsYInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumPadsYInput.Name = "NumPadsYInput";
            this.NumPadsYInput.Size = new System.Drawing.Size(58, 25);
            this.NumPadsYInput.TabIndex = 6;
            this.NumPadsYInput.Text = "5";
            this.NumPadsYInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertJobDescriptionButton
            // 
            this.InsertJobDescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.InsertJobDescriptionButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.InsertJobDescriptionButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.InsertJobDescriptionButton.Location = new System.Drawing.Point(544, 325);
            this.InsertJobDescriptionButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.InsertJobDescriptionButton.Name = "InsertJobDescriptionButton";
            this.InsertJobDescriptionButton.Size = new System.Drawing.Size(207, 46);
            this.InsertJobDescriptionButton.TabIndex = 7;
            this.InsertJobDescriptionButton.Text = "Insert Job Description";
            this.InsertJobDescriptionButton.UseVisualStyleBackColor = false;
            this.InsertJobDescriptionButton.Click += new System.EventHandler(this.InsertJobDescription);
            // 
            // LabelNumberPadsX
            // 
            this.LabelNumberPadsX.AutoSize = true;
            this.LabelNumberPadsX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelNumberPadsX.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelNumberPadsX.ForeColor = System.Drawing.Color.White;
            this.LabelNumberPadsX.Location = new System.Drawing.Point(13, 140);
            this.LabelNumberPadsX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberPadsX.Name = "LabelNumberPadsX";
            this.LabelNumberPadsX.Size = new System.Drawing.Size(113, 19);
            this.LabelNumberPadsX.TabIndex = 8;
            this.LabelNumberPadsX.Text = "Number Pads X";
            // 
            // LabelNumberPadsY
            // 
            this.LabelNumberPadsY.AutoSize = true;
            this.LabelNumberPadsY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelNumberPadsY.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelNumberPadsY.ForeColor = System.Drawing.Color.White;
            this.LabelNumberPadsY.Location = new System.Drawing.Point(13, 180);
            this.LabelNumberPadsY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberPadsY.Name = "LabelNumberPadsY";
            this.LabelNumberPadsY.Size = new System.Drawing.Size(113, 19);
            this.LabelNumberPadsY.TabIndex = 9;
            this.LabelNumberPadsY.Text = "Number Pads Y";
            // 
            // PostcodeLabel
            // 
            this.PostcodeLabel.AutoSize = true;
            this.PostcodeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.PostcodeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.PostcodeLabel.ForeColor = System.Drawing.Color.White;
            this.PostcodeLabel.Location = new System.Drawing.Point(540, 225);
            this.PostcodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostcodeLabel.Name = "PostcodeLabel";
            this.PostcodeLabel.Size = new System.Drawing.Size(71, 19);
            this.PostcodeLabel.TabIndex = 17;
            this.PostcodeLabel.Text = "Postcode";
            // 
            // LabelJobBuilder
            // 
            this.LabelJobBuilder.AutoSize = true;
            this.LabelJobBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobBuilder.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelJobBuilder.ForeColor = System.Drawing.Color.White;
            this.LabelJobBuilder.Location = new System.Drawing.Point(540, 100);
            this.LabelJobBuilder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobBuilder.Name = "LabelJobBuilder";
            this.LabelJobBuilder.Size = new System.Drawing.Size(57, 19);
            this.LabelJobBuilder.TabIndex = 16;
            this.LabelJobBuilder.Text = "Builder";
            // 
            // JobPostCodeText
            // 
            this.JobPostCodeText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobPostCodeText.Location = new System.Drawing.Point(695, 219);
            this.JobPostCodeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobPostCodeText.Name = "JobPostCodeText";
            this.JobPostCodeText.Size = new System.Drawing.Size(117, 25);
            this.JobPostCodeText.TabIndex = 15;
            this.JobPostCodeText.Text = "PostCode";
            this.JobPostCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // JobBuilderText
            // 
            this.JobBuilderText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobBuilderText.Location = new System.Drawing.Point(695, 94);
            this.JobBuilderText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobBuilderText.Name = "JobBuilderText";
            this.JobBuilderText.Size = new System.Drawing.Size(143, 25);
            this.JobBuilderText.TabIndex = 14;
            this.JobBuilderText.Text = "ProjectName";
            // 
            // LabelJobName
            // 
            this.LabelJobName.AutoSize = true;
            this.LabelJobName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelJobName.ForeColor = System.Drawing.Color.White;
            this.LabelJobName.Location = new System.Drawing.Point(540, 60);
            this.LabelJobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobName.Name = "LabelJobName";
            this.LabelJobName.Size = new System.Drawing.Size(49, 19);
            this.LabelJobName.TabIndex = 13;
            this.LabelJobName.Text = "Name";
            // 
            // JobNameText
            // 
            this.JobNameText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobNameText.Location = new System.Drawing.Point(695, 54);
            this.JobNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobNameText.Name = "JobNameText";
            this.JobNameText.Size = new System.Drawing.Size(143, 25);
            this.JobNameText.TabIndex = 12;
            this.JobNameText.Text = "ProjectName";
            // 
            // LabelJobNumber
            // 
            this.LabelJobNumber.AutoSize = true;
            this.LabelJobNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobNumber.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelJobNumber.ForeColor = System.Drawing.Color.White;
            this.LabelJobNumber.Location = new System.Drawing.Point(540, 20);
            this.LabelJobNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobNumber.Name = "LabelJobNumber";
            this.LabelJobNumber.Size = new System.Drawing.Size(92, 19);
            this.LabelJobNumber.TabIndex = 11;
            this.LabelJobNumber.Text = "Job Number";
            // 
            // JobNumberText
            // 
            this.JobNumberText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobNumberText.Location = new System.Drawing.Point(695, 14);
            this.JobNumberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobNumberText.Name = "JobNumberText";
            this.JobNumberText.Size = new System.Drawing.Size(143, 25);
            this.JobNumberText.TabIndex = 10;
            this.JobNumberText.Text = "70xxxxx";
            // 
            // LabelJobDesigner
            // 
            this.LabelJobDesigner.AutoSize = true;
            this.LabelJobDesigner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobDesigner.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelJobDesigner.ForeColor = System.Drawing.Color.White;
            this.LabelJobDesigner.Location = new System.Drawing.Point(540, 180);
            this.LabelJobDesigner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobDesigner.Name = "LabelJobDesigner";
            this.LabelJobDesigner.Size = new System.Drawing.Size(116, 19);
            this.LabelJobDesigner.TabIndex = 19;
            this.LabelJobDesigner.Text = "Designer-Initials";
            // 
            // JobDesignerText
            // 
            this.JobDesignerText.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobDesignerText.Location = new System.Drawing.Point(695, 174);
            this.JobDesignerText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobDesignerText.Name = "JobDesignerText";
            this.JobDesignerText.Size = new System.Drawing.Size(72, 25);
            this.JobDesignerText.TabIndex = 18;
            this.JobDesignerText.Text = "DesignerName";
            // 
            // LabelInfo1
            // 
            this.LabelInfo1.AutoSize = true;
            this.LabelInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelInfo1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelInfo1.ForeColor = System.Drawing.Color.White;
            this.LabelInfo1.Location = new System.Drawing.Point(540, 269);
            this.LabelInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo1.Name = "LabelInfo1";
            this.LabelInfo1.Size = new System.Drawing.Size(43, 19);
            this.LabelInfo1.TabIndex = 21;
            this.LabelInfo1.Text = "Info1";
            // 
            // JobInfo1
            // 
            this.JobInfo1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobInfo1.Location = new System.Drawing.Point(695, 263);
            this.JobInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobInfo1.Name = "JobInfo1";
            this.JobInfo1.Size = new System.Drawing.Size(143, 25);
            this.JobInfo1.TabIndex = 20;
            this.JobInfo1.Text = "Some Standard 2";
            // 
            // LabelJobDescription
            // 
            this.LabelJobDescription.AutoSize = true;
            this.LabelJobDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelJobDescription.ForeColor = System.Drawing.Color.White;
            this.LabelJobDescription.Location = new System.Drawing.Point(540, 140);
            this.LabelJobDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobDescription.Name = "LabelJobDescription";
            this.LabelJobDescription.Size = new System.Drawing.Size(109, 19);
            this.LabelJobDescription.TabIndex = 23;
            this.LabelJobDescription.Text = "JobDescription";
            // 
            // JobDescription
            // 
            this.JobDescription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.JobDescription.Location = new System.Drawing.Point(695, 134);
            this.JobDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Size = new System.Drawing.Size(143, 25);
            this.JobDescription.TabIndex = 24;
            this.JobDescription.Text = "JobDescription";
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelHeight.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.LabelHeight.ForeColor = System.Drawing.Color.White;
            this.LabelHeight.Location = new System.Drawing.Point(13, 100);
            this.LabelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(54, 19);
            this.LabelHeight.TabIndex = 26;
            this.LabelHeight.Text = "Height";
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.HeightInput.Location = new System.Drawing.Point(110, 97);
            this.HeightInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(124, 25);
            this.HeightInput.TabIndex = 25;
            this.HeightInput.Text = "1500";
            this.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 308);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 33);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CreatePadFootingButton
            // 
            this.CreatePadFootingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.CreatePadFootingButton.FlatAppearance.BorderSize = 0;
            this.CreatePadFootingButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CreatePadFootingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.CreatePadFootingButton.Location = new System.Drawing.Point(14, 284);
            this.CreatePadFootingButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(175, 57);
            this.CreatePadFootingButton.TabIndex = 0;
            this.CreatePadFootingButton.Text = "Insert \n Pads Cols Beams";
            this.CreatePadFootingButton.UseVisualStyleBackColor = false;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.Execute_OnButtonclick);
            // 
            // LoadColumnSettings
            // 
            this.LoadColumnSettings.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.LoadColumnSettings.FormattingEnabled = true;
            this.LoadColumnSettings.Location = new System.Drawing.Point(374, 17);
            this.LoadColumnSettings.Name = "LoadColumnSettings";
            this.LoadColumnSettings.Size = new System.Drawing.Size(116, 25);
            this.LoadColumnSettings.TabIndex = 29;
            this.LoadColumnSettings.SelectedIndexChanged += new System.EventHandler(this.LoadColumnSettings_SelectedIndexChanged);
            // 
            // LoadBeamSettings
            // 
            this.LoadBeamSettings.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.LoadBeamSettings.FormattingEnabled = true;
            this.LoadBeamSettings.Location = new System.Drawing.Point(374, 57);
            this.LoadBeamSettings.Name = "LoadBeamSettings";
            this.LoadBeamSettings.Size = new System.Drawing.Size(116, 25);
            this.LoadBeamSettings.TabIndex = 30;
            // 
            // ColumnSettingsLabel
            // 
            this.ColumnSettingsLabel.AutoSize = true;
            this.ColumnSettingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.ColumnSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.ColumnSettingsLabel.ForeColor = System.Drawing.Color.White;
            this.ColumnSettingsLabel.Location = new System.Drawing.Point(254, 20);
            this.ColumnSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColumnSettingsLabel.Name = "ColumnSettingsLabel";
            this.ColumnSettingsLabel.Size = new System.Drawing.Size(113, 19);
            this.ColumnSettingsLabel.TabIndex = 31;
            this.ColumnSettingsLabel.Text = "ColumnSettings";
            // 
            // BeamSettingsLabel
            // 
            this.BeamSettingsLabel.AutoSize = true;
            this.BeamSettingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.BeamSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.BeamSettingsLabel.ForeColor = System.Drawing.Color.White;
            this.BeamSettingsLabel.Location = new System.Drawing.Point(254, 60);
            this.BeamSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BeamSettingsLabel.Name = "BeamSettingsLabel";
            this.BeamSettingsLabel.Size = new System.Drawing.Size(100, 19);
            this.BeamSettingsLabel.TabIndex = 32;
            this.BeamSettingsLabel.Text = "BeamSettings";
            // 
            // LabelOption
            // 
            this.LabelOption.AutoSize = true;
            this.LabelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelOption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LabelOption.ForeColor = System.Drawing.Color.White;
            this.LabelOption.Location = new System.Drawing.Point(231, 277);
            this.LabelOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOption.Name = "LabelOption";
            this.LabelOption.Size = new System.Drawing.Size(266, 23);
            this.LabelOption.TabIndex = 33;
            this.LabelOption.Text = "Some Settings and options here";
            // 
            // GridInsertButton
            // 
            this.GridInsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.GridInsertButton.FlatAppearance.BorderSize = 0;
            this.GridInsertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GridInsertButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.GridInsertButton.Location = new System.Drawing.Point(14, 359);
            this.GridInsertButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.GridInsertButton.Name = "GridInsertButton";
            this.GridInsertButton.Size = new System.Drawing.Size(157, 57);
            this.GridInsertButton.TabIndex = 35;
            this.GridInsertButton.Text = "InsertGrid";
            this.GridInsertButton.UseVisualStyleBackColor = false;
            this.GridInsertButton.Click += new System.EventHandler(this.GridInsertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(854, 426);
            this.Controls.Add(this.GridInsertButton);
            this.Controls.Add(this.LabelOption);
            this.Controls.Add(this.BeamSettingsLabel);
            this.Controls.Add(this.ColumnSettingsLabel);
            this.Controls.Add(this.LoadBeamSettings);
            this.Controls.Add(this.LoadColumnSettings);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.JobDescription);
            this.Controls.Add(this.LabelJobDescription);
            this.Controls.Add(this.LabelInfo1);
            this.Controls.Add(this.JobInfo1);
            this.Controls.Add(this.LabelJobDesigner);
            this.Controls.Add(this.JobDesignerText);
            this.Controls.Add(this.PostcodeLabel);
            this.Controls.Add(this.LabelJobBuilder);
            this.Controls.Add(this.JobPostCodeText);
            this.Controls.Add(this.JobBuilderText);
            this.Controls.Add(this.LabelJobName);
            this.Controls.Add(this.JobNameText);
            this.Controls.Add(this.LabelJobNumber);
            this.Controls.Add(this.JobNumberText);
            this.Controls.Add(this.LabelNumberPadsY);
            this.Controls.Add(this.LabelNumberPadsX);
            this.Controls.Add(this.InsertJobDescriptionButton);
            this.Controls.Add(this.NumPadsYInput);
            this.Controls.Add(this.NumPadsXInput);
            this.Controls.Add(this.LabelSpacingY);
            this.Controls.Add(this.SpacingYInput);
            this.Controls.Add(this.LabelSpacingX);
            this.Controls.Add(this.SpacingXInput);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.Text = "API Exercise 1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SpacingXInput;
        private System.Windows.Forms.Label LabelSpacingX;
        private System.Windows.Forms.Label LabelSpacingY;
        private System.Windows.Forms.TextBox SpacingYInput;
        private System.Windows.Forms.TextBox NumPadsXInput;
        private System.Windows.Forms.TextBox NumPadsYInput;
        private System.Windows.Forms.Button InsertJobDescriptionButton;
        private System.Windows.Forms.Label LabelNumberPadsX;
        private System.Windows.Forms.Label LabelNumberPadsY;
        private System.Windows.Forms.Label PostcodeLabel;
        private System.Windows.Forms.Label LabelJobBuilder;
        private System.Windows.Forms.TextBox JobPostCodeText;
        private System.Windows.Forms.TextBox JobBuilderText;
        private System.Windows.Forms.Label LabelJobName;
        private System.Windows.Forms.TextBox JobNameText;
        private System.Windows.Forms.Label LabelJobNumber;
        private System.Windows.Forms.TextBox JobNumberText;
        private System.Windows.Forms.Label LabelJobDesigner;
        private System.Windows.Forms.TextBox JobDesignerText;
        private System.Windows.Forms.Label LabelInfo1;
        private System.Windows.Forms.TextBox JobInfo1;
        private System.Windows.Forms.Label LabelJobDescription;
        private System.Windows.Forms.TextBox JobDescription;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreatePadFootingButton;
        private ComboBox LoadColumnSettings;
        private ComboBox LoadBeamSettings;
        private Label ColumnSettingsLabel;
        private Label BeamSettingsLabel;
        private Label LabelOption;
        private Button GridInsertButton;
    }
}

