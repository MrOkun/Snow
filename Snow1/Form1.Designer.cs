
namespace Snow1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Canvas_Box = new System.Windows.Forms.PictureBox();
            this.TimerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas_Box
            // 
            this.Canvas_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas_Box.Location = new System.Drawing.Point(0, 0);
            this.Canvas_Box.Name = "Canvas_Box";
            this.Canvas_Box.Size = new System.Drawing.Size(573, 561);
            this.Canvas_Box.TabIndex = 0;
            this.Canvas_Box.TabStop = false;
            this.Canvas_Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Box_Paint);
            // 
            // TimerUpdate
            // 
            this.TimerUpdate.Enabled = true;
            this.TimerUpdate.Interval = 33;
            this.TimerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573, 561);
            this.Controls.Add(this.Canvas_Box);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Okun\'s Snow FPS : xxx";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas_Box;
        private System.Windows.Forms.Timer TimerUpdate;
    }
}

