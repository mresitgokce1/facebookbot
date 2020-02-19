namespace WindowsFormsApp3
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.groupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pageBtn = new DevExpress.XtraEditors.SimpleButton();
            this.messengerBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // groupBtn
            // 
            this.groupBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupBtn.ImageOptions.Image")));
            this.groupBtn.Location = new System.Drawing.Point(9, 82);
            this.groupBtn.Name = "groupBtn";
            this.groupBtn.Size = new System.Drawing.Size(209, 64);
            this.groupBtn.TabIndex = 0;
            this.groupBtn.Text = "Grup İşlemleri";
            this.groupBtn.Click += new System.EventHandler(this.groupBtn_Click);
            // 
            // pageBtn
            // 
            this.pageBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pageBtn.ImageOptions.Image")));
            this.pageBtn.Location = new System.Drawing.Point(224, 82);
            this.pageBtn.Name = "pageBtn";
            this.pageBtn.Size = new System.Drawing.Size(209, 64);
            this.pageBtn.TabIndex = 1;
            this.pageBtn.Text = "Sayfa İşlemleri";
            this.pageBtn.Click += new System.EventHandler(this.pageBtn_Click);
            // 
            // messengerBtn
            // 
            this.messengerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("messengerBtn.ImageOptions.Image")));
            this.messengerBtn.Location = new System.Drawing.Point(439, 82);
            this.messengerBtn.Name = "messengerBtn";
            this.messengerBtn.Size = new System.Drawing.Size(209, 64);
            this.messengerBtn.TabIndex = 2;
            this.messengerBtn.Text = "Messemger İşlemleri";
            this.messengerBtn.Click += new System.EventHandler(this.messengerBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(568, 39);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "MRG Yazılım - Facebook Mesaj BOT";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 161);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.messengerBtn);
            this.Controls.Add(this.pageBtn);
            this.Controls.Add(this.groupBtn);
            this.Name = "HomePageForm";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton groupBtn;
        private DevExpress.XtraEditors.SimpleButton pageBtn;
        private DevExpress.XtraEditors.SimpleButton messengerBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}