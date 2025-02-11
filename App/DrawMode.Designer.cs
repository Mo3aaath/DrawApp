namespace App
{
    partial class DrawMode
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.drawModeBtn = new System.Windows.Forms.Button();
            this.infoModeBtn = new System.Windows.Forms.Button();
            this.choicesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lineBt = new System.Windows.Forms.Button();
            this.squareBt = new System.Windows.Forms.Button();
            this.rectBt = new System.Windows.Forms.Button();
            this.circleBt = new System.Windows.Forms.Button();
            this.triBt = new System.Windows.Forms.Button();
            this.nameList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.choicesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.controlPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.choicesPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameList, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.drawingPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1201, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.controlPanel, 3);
            this.controlPanel.Controls.Add(this.drawModeBtn);
            this.controlPanel.Controls.Add(this.infoModeBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(3, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1195, 67);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.WrapContents = false;
            // 
            // drawModeBtn
            // 
            this.drawModeBtn.Location = new System.Drawing.Point(3, 3);
            this.drawModeBtn.Name = "drawModeBtn";
            this.drawModeBtn.Size = new System.Drawing.Size(102, 54);
            this.drawModeBtn.TabIndex = 1;
            this.drawModeBtn.Text = "Draw Mode";
            this.drawModeBtn.UseVisualStyleBackColor = true;
            // 
            // infoModeBtn
            // 
            this.infoModeBtn.Location = new System.Drawing.Point(111, 3);
            this.infoModeBtn.Name = "infoModeBtn";
            this.infoModeBtn.Size = new System.Drawing.Size(102, 54);
            this.infoModeBtn.TabIndex = 2;
            this.infoModeBtn.Text = "Info Mode";
            this.infoModeBtn.UseVisualStyleBackColor = true;
            this.infoModeBtn.Click += new System.EventHandler(this.infoModeBtn_Click);
            // 
            // choicesPanel
            // 
            this.choicesPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choicesPanel.Controls.Add(this.lineBt);
            this.choicesPanel.Controls.Add(this.squareBt);
            this.choicesPanel.Controls.Add(this.rectBt);
            this.choicesPanel.Controls.Add(this.circleBt);
            this.choicesPanel.Controls.Add(this.triBt);
            this.choicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choicesPanel.Location = new System.Drawing.Point(3, 76);
            this.choicesPanel.Name = "choicesPanel";
            this.tableLayoutPanel1.SetRowSpan(this.choicesPanel, 2);
            this.choicesPanel.Size = new System.Drawing.Size(172, 480);
            this.choicesPanel.TabIndex = 1;
            // 
            // lineBt
            // 
            this.lineBt.Image = global::App.Properties.Resources.icons8_line_50;
            this.lineBt.Location = new System.Drawing.Point(3, 3);
            this.lineBt.Name = "lineBt";
            this.lineBt.Size = new System.Drawing.Size(79, 71);
            this.lineBt.TabIndex = 3;
            this.lineBt.UseVisualStyleBackColor = true;
            this.lineBt.Click += new System.EventHandler(this.lineBt_Click);
            // 
            // squareBt
            // 
            this.squareBt.Image = global::App.Properties.Resources.icons8_square_50;
            this.squareBt.Location = new System.Drawing.Point(88, 3);
            this.squareBt.Name = "squareBt";
            this.squareBt.Size = new System.Drawing.Size(79, 71);
            this.squareBt.TabIndex = 4;
            this.squareBt.UseVisualStyleBackColor = true;
            this.squareBt.Click += new System.EventHandler(this.squareBt_Click);
            // 
            // rectBt
            // 
            this.rectBt.Image = global::App.Properties.Resources.icons8_rectangle_48;
            this.rectBt.Location = new System.Drawing.Point(3, 80);
            this.rectBt.Name = "rectBt";
            this.rectBt.Size = new System.Drawing.Size(79, 71);
            this.rectBt.TabIndex = 5;
            this.rectBt.UseVisualStyleBackColor = true;
            this.rectBt.Click += new System.EventHandler(this.rectBt_Click);
            // 
            // circleBt
            // 
            this.circleBt.Image = global::App.Properties.Resources.icons8_circle_50;
            this.circleBt.Location = new System.Drawing.Point(88, 80);
            this.circleBt.Name = "circleBt";
            this.circleBt.Size = new System.Drawing.Size(79, 71);
            this.circleBt.TabIndex = 6;
            this.circleBt.UseVisualStyleBackColor = true;
            this.circleBt.Click += new System.EventHandler(this.circleBt_Click);
            // 
            // triBt
            // 
            this.triBt.Image = global::App.Properties.Resources.icons8_triangle_32;
            this.triBt.Location = new System.Drawing.Point(3, 157);
            this.triBt.Name = "triBt";
            this.triBt.Size = new System.Drawing.Size(79, 71);
            this.triBt.TabIndex = 7;
            this.triBt.UseVisualStyleBackColor = true;
            this.triBt.Click += new System.EventHandler(this.triBt_Click);
            // 
            // nameList
            // 
            this.nameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameList.Location = new System.Drawing.Point(1034, 128);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(164, 428);
            this.nameList.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1034, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 46);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shapes";
            // 
            // drawingPanel
            // 
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingPanel.Location = new System.Drawing.Point(181, 76);
            this.drawingPanel.Name = "drawingPanel";
            this.tableLayoutPanel1.SetRowSpan(this.drawingPanel, 2);
            this.drawingPanel.Size = new System.Drawing.Size(847, 480);
            this.drawingPanel.TabIndex = 6;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            // 
            // DrawMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1201, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1219, 606);
            this.Name = "DrawMode";
            this.Text = "Draw App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.choicesPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel controlPanel;
        private System.Windows.Forms.FlowLayoutPanel choicesPanel;
        private System.Windows.Forms.Button drawModeBtn;
        private System.Windows.Forms.Button infoModeBtn;
        private System.Windows.Forms.Button lineBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button squareBt;
        private System.Windows.Forms.Button rectBt;
        private System.Windows.Forms.Button circleBt;
        private System.Windows.Forms.Button triBt;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.FlowLayoutPanel nameList;
    }
}

