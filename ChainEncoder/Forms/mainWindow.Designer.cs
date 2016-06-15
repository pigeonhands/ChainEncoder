namespace ChainEncoder.Forms
{
    partial class mainWindow
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvChain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmChain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseChainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbDecode = new System.Windows.Forms.CheckBox();
            this.copySelectedStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmChain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 33);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(380, 70);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 138);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(380, 70);
            this.rtbOutput.TabIndex = 2;
            this.rtbOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // lvChain
            // 
            this.lvChain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvChain.ContextMenuStrip = this.cmChain;
            this.lvChain.FullRowSelect = true;
            this.lvChain.GridLines = true;
            this.lvChain.Location = new System.Drawing.Point(12, 227);
            this.lvChain.Name = "lvChain";
            this.lvChain.Size = new System.Drawing.Size(380, 136);
            this.lvChain.TabIndex = 4;
            this.lvChain.UseCompatibleStateImageBehavior = false;
            this.lvChain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Success";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Current State";
            this.columnHeader4.Width = 157;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(136, 399);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run Chain";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Chain";
            // 
            // cmChain
            // 
            this.cmChain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.removeSelectedToolStripMenuItem,
            this.copySelectedStateToolStripMenuItem,
            this.reverseChainToolStripMenuItem});
            this.cmChain.Name = "cmChain";
            this.cmChain.Size = new System.Drawing.Size(179, 114);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(164, 22);
            this.tsmAdd.Text = "Add";
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // reverseChainToolStripMenuItem
            // 
            this.reverseChainToolStripMenuItem.Name = "reverseChainToolStripMenuItem";
            this.reverseChainToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reverseChainToolStripMenuItem.Text = "Reverse Chain";
            this.reverseChainToolStripMenuItem.Click += new System.EventHandler(this.reverseChainToolStripMenuItem_Click);
            // 
            // cbDecode
            // 
            this.cbDecode.AutoSize = true;
            this.cbDecode.Location = new System.Drawing.Point(15, 369);
            this.cbDecode.Name = "cbDecode";
            this.cbDecode.Size = new System.Drawing.Size(64, 17);
            this.cbDecode.TabIndex = 8;
            this.cbDecode.Text = "Decode";
            this.cbDecode.UseVisualStyleBackColor = true;
            // 
            // copySelectedStateToolStripMenuItem
            // 
            this.copySelectedStateToolStripMenuItem.Name = "copySelectedStateToolStripMenuItem";
            this.copySelectedStateToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copySelectedStateToolStripMenuItem.Text = "Copy Selected State";
            this.copySelectedStateToolStripMenuItem.Click += new System.EventHandler(this.copySelectedStateToolStripMenuItem_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 434);
            this.Controls.Add(this.cbDecode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lvChain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainWindow";
            this.Text = "Chain Encoder";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.cmChain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvChain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmChain;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseChainToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbDecode;
        private System.Windows.Forms.ToolStripMenuItem copySelectedStateToolStripMenuItem;
    }
}