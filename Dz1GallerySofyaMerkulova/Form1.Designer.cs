namespace Dz1GallerySofyaMerkulova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayingImagesPictureBox = new System.Windows.Forms.PictureBox();
            this.headingTextBox = new System.Windows.Forms.TextBox();
            this.imageSelectionListBox = new System.Windows.Forms.ListBox();
            this.downloadingButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelForPicture = new System.Windows.Forms.Label();
            this.labelForListBox = new System.Windows.Forms.Label();
            this.labelForTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayingImagesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayingImagesPictureBox
            // 
            this.displayingImagesPictureBox.Location = new System.Drawing.Point(366, 111);
            this.displayingImagesPictureBox.Name = "displayingImagesPictureBox";
            this.displayingImagesPictureBox.Size = new System.Drawing.Size(927, 413);
            this.displayingImagesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.displayingImagesPictureBox.TabIndex = 0;
            this.displayingImagesPictureBox.TabStop = false;
            // 
            // headingTextBox
            // 
            this.headingTextBox.Location = new System.Drawing.Point(897, 547);
            this.headingTextBox.Multiline = true;
            this.headingTextBox.Name = "headingTextBox";
            this.headingTextBox.Size = new System.Drawing.Size(384, 50);
            this.headingTextBox.TabIndex = 1;
            this.headingTextBox.TextChanged += new System.EventHandler(this.headingTextBox_TextChanged);
            // 
            // imageSelectionListBox
            // 
            this.imageSelectionListBox.FormattingEnabled = true;
            this.imageSelectionListBox.ItemHeight = 16;
            this.imageSelectionListBox.Location = new System.Drawing.Point(12, 102);
            this.imageSelectionListBox.Name = "imageSelectionListBox";
            this.imageSelectionListBox.Size = new System.Drawing.Size(245, 484);
            this.imageSelectionListBox.TabIndex = 2;
            this.imageSelectionListBox.SelectedIndexChanged += new System.EventHandler(this.imageSelectionListBox_SelectedIndexChanged);
            // 
            // downloadingButton
            // 
            this.downloadingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.downloadingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.downloadingButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.downloadingButton.Location = new System.Drawing.Point(0, 0);
            this.downloadingButton.Name = "downloadingButton";
            this.downloadingButton.Size = new System.Drawing.Size(1293, 46);
            this.downloadingButton.TabIndex = 3;
            this.downloadingButton.Text = "Загрузить изображения из папки";
            this.downloadingButton.UseVisualStyleBackColor = false;
            this.downloadingButton.Click += new System.EventHandler(this.downloadingButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(236)))));
            this.saveButton.Location = new System.Drawing.Point(0, 603);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1293, 46);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelForPicture
            // 
            this.labelForPicture.AutoSize = true;
            this.labelForPicture.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelForPicture.Location = new System.Drawing.Point(778, 71);
            this.labelForPicture.Name = "labelForPicture";
            this.labelForPicture.Size = new System.Drawing.Size(162, 27);
            this.labelForPicture.TabIndex = 5;
            this.labelForPicture.Text = "Изображение";
            // 
            // labelForListBox
            // 
            this.labelForListBox.AutoSize = true;
            this.labelForListBox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelForListBox.Location = new System.Drawing.Point(12, 62);
            this.labelForListBox.Name = "labelForListBox";
            this.labelForListBox.Size = new System.Drawing.Size(245, 27);
            this.labelForListBox.TabIndex = 6;
            this.labelForListBox.Text = "Список изображений";
            // 
            // labelForTextBox
            // 
            this.labelForTextBox.AutoSize = true;
            this.labelForTextBox.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelForTextBox.Location = new System.Drawing.Point(738, 547);
            this.labelForTextBox.Name = "labelForTextBox";
            this.labelForTextBox.Size = new System.Drawing.Size(127, 27);
            this.labelForTextBox.TabIndex = 7;
            this.labelForTextBox.Text = "Заголовок";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1293, 649);
            this.Controls.Add(this.labelForTextBox);
            this.Controls.Add(this.labelForListBox);
            this.Controls.Add(this.labelForPicture);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.downloadingButton);
            this.Controls.Add(this.imageSelectionListBox);
            this.Controls.Add(this.headingTextBox);
            this.Controls.Add(this.displayingImagesPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.displayingImagesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayingImagesPictureBox;
        private System.Windows.Forms.TextBox headingTextBox;
        private System.Windows.Forms.ListBox imageSelectionListBox;
        private System.Windows.Forms.Button downloadingButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelForPicture;
        private System.Windows.Forms.Label labelForListBox;
        private System.Windows.Forms.Label labelForTextBox;
    }
}

