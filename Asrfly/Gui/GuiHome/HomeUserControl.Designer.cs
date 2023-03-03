
namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddInput = new System.Windows.Forms.Button();
            this.buttonAddOutput = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddProject = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelWellcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 173);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Asrfly.Properties.Resources.icons8_smart_96px_3;
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.buttonAddInput);
            this.groupBox1.Controls.Add(this.buttonAddOutput);
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.buttonAddProject);
            this.groupBox1.Controls.Add(this.buttonAddSupplier);
            this.groupBox1.Controls.Add(this.buttonAddCustomer);
            this.groupBox1.Controls.Add(this.buttonAddCategory);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أضافة";
            // 
            // buttonAddInput
            // 
            this.buttonAddInput.Image = global::Asrfly.Properties.Resources.icons8_Request_Money_32px;
            this.buttonAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddInput.Location = new System.Drawing.Point(30, 34);
            this.buttonAddInput.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.Size = new System.Drawing.Size(161, 45);
            this.buttonAddInput.TabIndex = 8;
            this.buttonAddInput.Text = "   قبض";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            this.buttonAddOutput.Image = global::Asrfly.Properties.Resources.icons8_Initiate_Money_Transfer_32px;
            this.buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddOutput.Location = new System.Drawing.Point(201, 34);
            this.buttonAddOutput.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddOutput.Name = "buttonAddOutput";
            this.buttonAddOutput.Size = new System.Drawing.Size(161, 45);
            this.buttonAddOutput.TabIndex = 7;
            this.buttonAddOutput.Text = "   صرف";
            this.buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Image = global::Asrfly.Properties.Resources.icons8_users_32px_4;
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(372, 34);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(161, 45);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "   مستخدم";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Image = global::Asrfly.Properties.Resources.icons8_view_module_32px_1;
            this.buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProject.Location = new System.Drawing.Point(543, 34);
            this.buttonAddProject.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(161, 45);
            this.buttonAddProject.TabIndex = 5;
            this.buttonAddProject.Text = "   مشروع";
            this.buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Image = global::Asrfly.Properties.Resources.icons8_customer_32px_2;
            this.buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddSupplier.Location = new System.Drawing.Point(717, 34);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(161, 45);
            this.buttonAddSupplier.TabIndex = 4;
            this.buttonAddSupplier.Text = "   مورد";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Image = global::Asrfly.Properties.Resources.icons8_customer_32px_1;
            this.buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCustomer.Location = new System.Drawing.Point(888, 34);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(161, 45);
            this.buttonAddCustomer.TabIndex = 3;
            this.buttonAddCustomer.Text = "   عميل";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Image = global::Asrfly.Properties.Resources.icons8_categorize_32px_4;
            this.buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCategory.Location = new System.Drawing.Point(1059, 34);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(161, 45);
            this.buttonAddCategory.TabIndex = 2;
            this.buttonAddCategory.Text = "   صنف";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Location = new System.Drawing.Point(795, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 124);
            this.panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyName.Location = new System.Drawing.Point(0, 44);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(299, 32);
            this.labelCompanyName.TabIndex = 5;
            this.labelCompanyName.Text = "أفق المستقبل للحول البرمجية";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = global::Asrfly.Properties.Resources.icons8_smart_96px_3;
            this.pictureBoxLogo.Location = new System.Drawing.Point(299, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(92, 124);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelWellcome
            // 
            this.labelWellcome.AutoSize = true;
            this.labelWellcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWellcome.Location = new System.Drawing.Point(80, 140);
            this.labelWellcome.Name = "labelWellcome";
            this.labelWellcome.Size = new System.Drawing.Size(166, 32);
            this.labelWellcome.TabIndex = 6;
            this.labelWellcome.Text = "مرحبا بك مجددا";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWellcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomeUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1264, 618);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddCustomers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWellcome;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddInput;
    }
}
