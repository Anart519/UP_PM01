namespace Lab1WF {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.aNUD = new System.Windows.Forms.NumericUpDown();
			this.bNUD = new System.Windows.Forms.NumericUpDown();
			this.cNUD = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.aNUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bNUD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cNUD)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.resultLabel, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.aNUD, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.bNUD, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.cNUD, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 168);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "a:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "b:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "alpha(градусы):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Площадь:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultLabel.Location = new System.Drawing.Point(133, 96);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(145, 20);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// aNUD
			// 
			this.aNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.aNUD.DecimalPlaces = 6;
			this.aNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.aNUD.Location = new System.Drawing.Point(133, 3);
			this.aNUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.aNUD.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
			this.aNUD.Name = "aNUD";
			this.aNUD.Size = new System.Drawing.Size(145, 26);
			this.aNUD.TabIndex = 6;
			this.aNUD.ValueChanged += new System.EventHandler(this.aNUD_ValueChanged);
			// 
			// bNUD
			// 
			this.bNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.bNUD.DecimalPlaces = 6;
			this.bNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bNUD.Location = new System.Drawing.Point(133, 35);
			this.bNUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.bNUD.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
			this.bNUD.Name = "bNUD";
			this.bNUD.Size = new System.Drawing.Size(145, 26);
			this.bNUD.TabIndex = 7;
			this.bNUD.ValueChanged += new System.EventHandler(this.bNUD_ValueChanged);
			// 
			// cNUD
			// 
			this.cNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cNUD.DecimalPlaces = 6;
			this.cNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cNUD.Location = new System.Drawing.Point(133, 67);
			this.cNUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.cNUD.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
			this.cNUD.Name = "cNUD";
			this.cNUD.Size = new System.Drawing.Size(145, 26);
			this.cNUD.TabIndex = 8;
			this.cNUD.ValueChanged += new System.EventHandler(this.cNUD_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 168);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Lab1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.aNUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bNUD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cNUD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.NumericUpDown aNUD;
		private System.Windows.Forms.NumericUpDown bNUD;
		private System.Windows.Forms.NumericUpDown cNUD;
	}
}

