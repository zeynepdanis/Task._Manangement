namespace Task._Manangement
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.btn_Add = new XanderUI.XUIButton();
            this.btnUpdate = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.xuiWifiPercentageAPI1 = new XanderUI.XUIWifiPercentageAPI();
            this.pnlToday = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Delete = new XanderUI.XUIButton();
            this.btn_Back = new XanderUI.XUISuperButton();
            this.chcbxStar = new XanderUI.XUICheckBox();
            this.starredPage = new System.Windows.Forms.TabPage();
            this.xuiFlatTab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiGradientPanel1.AutoScroll = true;
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.Black;
            this.xuiGradientPanel1.Location = new System.Drawing.Point(347, 107);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.Black;
            this.xuiGradientPanel1.Size = new System.Drawing.Size(901, 234);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 1;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // xuiClock1
            // 
            this.xuiClock1.BackColor = System.Drawing.Color.Black;
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(6, 149);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = true;
            this.xuiClock1.ShowHexagon = false;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(259, 251);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Add.ButtonImage = null;
            this.btn_Add.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.ClickBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Add.ClickTextColor = System.Drawing.Color.RoyalBlue;
            this.btn_Add.CornerRadius = 5;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Add.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Add.HoverTextColor = System.Drawing.Color.Black;
            this.btn_Add.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Add.Location = new System.Drawing.Point(6, 312);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(200, 50);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.TextColor = System.Drawing.Color.RoyalBlue;
            this.btn_Add.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.Black;
            this.btnUpdate.ButtonImage = null;
            this.btnUpdate.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.CornerRadius = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.HoverTextColor = System.Drawing.Color.Black;
            this.btnUpdate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(6, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "WriteTask Here";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(6, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 121);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // xuiWifiPercentageAPI1
            // 
            this.xuiWifiPercentageAPI1.Enabled = true;
            this.xuiWifiPercentageAPI1.Interval = 3000;
            // 
            // pnlToday
            // 
            this.pnlToday.AutoScroll = true;
            this.pnlToday.AutoSize = true;
            this.pnlToday.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlToday.Location = new System.Drawing.Point(347, 434);
            this.pnlToday.Name = "pnlToday";
            this.pnlToday.Size = new System.Drawing.Size(632, 233);
            this.pnlToday.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(342, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "TODAY\'S TASKS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(342, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TASKS";
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.tabPage1);
            this.xuiFlatTab1.Controls.Add(this.tabPage2);
            this.xuiFlatTab1.Controls.Add(this.starredPage);
            this.xuiFlatTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.Black;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(12, 53);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.Black;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(291, 614);
            this.xuiFlatTab1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.xuiClock1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOME";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btn_Delete);
            this.tabPage2.Controls.Add(this.btn_Back);
            this.tabPage2.Controls.Add(this.chcbxStar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btn_Add);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(283, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ADD TASK";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Delete.ButtonImage = null;
            this.btn_Delete.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.ClickBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Delete.ClickTextColor = System.Drawing.Color.RoyalBlue;
            this.btn_Delete.CornerRadius = 5;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Delete.HoverTextColor = System.Drawing.Color.Black;
            this.btn_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Delete.Location = new System.Drawing.Point(11, 446);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(200, 50);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.TextColor = System.Drawing.Color.RoyalBlue;
            this.btn_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundColor = System.Drawing.Color.Black;
            this.btn_Back.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.ButtonImage")));
            this.btn_Back.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_Back.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_Back.ButtonText = "Back To Add";
            this.btn_Back.CornerRadius = 5;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Back.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Back.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_Back.HoverTextColor = System.Drawing.Color.White;
            this.btn_Back.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_Back.Location = new System.Drawing.Point(11, 544);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Back.SelectedTextColor = System.Drawing.Color.White;
            this.btn_Back.Size = new System.Drawing.Size(262, 40);
            this.btn_Back.SuperSelected = false;
            this.btn_Back.TabIndex = 4;
            this.btn_Back.TextColor = System.Drawing.Color.White;
            this.btn_Back.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // chcbxStar
            // 
            this.chcbxStar.CheckboxCheckColor = System.Drawing.Color.White;
            this.chcbxStar.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.chcbxStar.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chcbxStar.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.chcbxStar.Checked = false;
            this.chcbxStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcbxStar.ForeColor = System.Drawing.Color.White;
            this.chcbxStar.Location = new System.Drawing.Point(6, 260);
            this.chcbxStar.Name = "chcbxStar";
            this.chcbxStar.Size = new System.Drawing.Size(237, 23);
            this.chcbxStar.TabIndex = 3;
            this.chcbxStar.Text = "Starred";
            this.chcbxStar.TickThickness = 2;
            // 
            // starredPage
            // 
            this.starredPage.AutoScroll = true;
            this.starredPage.BackColor = System.Drawing.Color.Black;
            this.starredPage.Location = new System.Drawing.Point(4, 20);
            this.starredPage.Name = "starredPage";
            this.starredPage.Padding = new System.Windows.Forms.Padding(3);
            this.starredPage.Size = new System.Drawing.Size(283, 590);
            this.starredPage.TabIndex = 2;
            this.starredPage.Text = "STARRED";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1329, 679);
            this.Controls.Add(this.xuiFlatTab1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlToday);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Task";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.xuiFlatTab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIClock xuiClock1;
        public XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private XanderUI.XUIButton btn_Add;
        private XanderUI.XUIWifiPercentageAPI xuiWifiPercentageAPI1;
        private XanderUI.XUIButton btnUpdate;
        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private XanderUI.XUICheckBox chcbxStar;
        private System.Windows.Forms.TabPage starredPage;
        private XanderUI.XUISuperButton btn_Back;
        private XanderUI.XUIButton btn_Delete;
    }
}