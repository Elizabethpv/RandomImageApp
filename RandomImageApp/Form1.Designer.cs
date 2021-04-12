
namespace RandomImageApp
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
            this.components = new System.ComponentModel.Container();
            this.btnRotate = new System.Windows.Forms.Button();
            this.picChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImgPrevious = new System.Windows.Forms.Button();
            this.btnRemoveImgFromFolder = new System.Windows.Forms.Button();
            this.btnAddtoFolder = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.txtDeletePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteBrowse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(-1, 68);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(267, 51);
            this.btnRotate.TabIndex = 2;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // picChangeTimer
            // 
            this.picChangeTimer.Enabled = true;
            this.picChangeTimer.Interval = 5000;
            this.picChangeTimer.Tick += new System.EventHandler(this.picChangeTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnImgPrevious);
            this.panel1.Controls.Add(this.btnRemoveImgFromFolder);
            this.panel1.Controls.Add(this.btnAddtoFolder);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 463);
            this.panel1.TabIndex = 3;
            // 
            // btnImgPrevious
            // 
            this.btnImgPrevious.Location = new System.Drawing.Point(-1, 242);
            this.btnImgPrevious.Name = "btnImgPrevious";
            this.btnImgPrevious.Size = new System.Drawing.Size(267, 51);
            this.btnImgPrevious.TabIndex = 5;
            this.btnImgPrevious.Text = "Previous";
            this.btnImgPrevious.UseVisualStyleBackColor = true;
            // 
            // btnRemoveImgFromFolder
            // 
            this.btnRemoveImgFromFolder.Location = new System.Drawing.Point(-1, 184);
            this.btnRemoveImgFromFolder.Name = "btnRemoveImgFromFolder";
            this.btnRemoveImgFromFolder.Size = new System.Drawing.Size(267, 51);
            this.btnRemoveImgFromFolder.TabIndex = 4;
            this.btnRemoveImgFromFolder.Text = "Remove from Collection";
            this.btnRemoveImgFromFolder.UseVisualStyleBackColor = true;
            this.btnRemoveImgFromFolder.Click += new System.EventHandler(this.btnRemoveImgFromFolder_Click);
            // 
            // btnAddtoFolder
            // 
            this.btnAddtoFolder.Location = new System.Drawing.Point(-1, 126);
            this.btnAddtoFolder.Name = "btnAddtoFolder";
            this.btnAddtoFolder.Size = new System.Drawing.Size(267, 51);
            this.btnAddtoFolder.TabIndex = 3;
            this.btnAddtoFolder.Text = "Add to Collection";
            this.btnAddtoFolder.UseVisualStyleBackColor = true;
            this.btnAddtoFolder.Click += new System.EventHandler(this.btnAddtoFolder_Click);
            // 
            // picBox2
            // 
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Location = new System.Drawing.Point(496, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(493, 452);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 1;
            this.picBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 429);
            this.panel2.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(24, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(181, 38);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(24, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(181, 38);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAdd.Controls.Add(this.btnCloseAdd);
            this.panelAdd.Controls.Add(this.txtPath);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.btnBrowse);
            this.panelAdd.Controls.Add(this.btnUpload);
            this.panelAdd.Location = new System.Drawing.Point(259, 241);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(232, 223);
            this.panelAdd.TabIndex = 8;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(4, 115);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(225, 20);
            this.txtPath.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add to Collection";
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelDelete.Controls.Add(this.btnClose);
            this.panelDelete.Controls.Add(this.txtDeletePath);
            this.panelDelete.Controls.Add(this.label2);
            this.panelDelete.Controls.Add(this.btnDeleteBrowse);
            this.panelDelete.Controls.Add(this.btnDelete);
            this.panelDelete.Location = new System.Drawing.Point(258, 12);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(232, 223);
            this.panelDelete.TabIndex = 9;
            // 
            // txtDeletePath
            // 
            this.txtDeletePath.Location = new System.Drawing.Point(4, 115);
            this.txtDeletePath.Name = "txtDeletePath";
            this.txtDeletePath.Size = new System.Drawing.Size(225, 20);
            this.txtDeletePath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Remove to Collection";
            // 
            // btnDeleteBrowse
            // 
            this.btnDeleteBrowse.Location = new System.Drawing.Point(24, 58);
            this.btnDeleteBrowse.Name = "btnDeleteBrowse";
            this.btnDeleteBrowse.Size = new System.Drawing.Size(181, 38);
            this.btnDeleteBrowse.TabIndex = 5;
            this.btnDeleteBrowse.Text = "Browse";
            this.btnDeleteBrowse.UseVisualStyleBackColor = true;
            this.btnDeleteBrowse.Click += new System.EventHandler(this.btnDeleteBrowse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(24, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 38);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(207, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseAdd
            // 
            this.btnCloseAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAdd.Location = new System.Drawing.Point(206, 0);
            this.btnCloseAdd.Name = "btnCloseAdd";
            this.btnCloseAdd.Size = new System.Drawing.Size(26, 28);
            this.btnCloseAdd.TabIndex = 11;
            this.btnCloseAdd.Text = "X";
            this.btnCloseAdd.UseVisualStyleBackColor = true;
            this.btnCloseAdd.Click += new System.EventHandler(this.btnCloseAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 478);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "RandomImage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Timer picChangeTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImgPrevious;
        private System.Windows.Forms.Button btnRemoveImgFromFolder;
        private System.Windows.Forms.Button btnAddtoFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.TextBox txtDeletePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteBrowse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCloseAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

