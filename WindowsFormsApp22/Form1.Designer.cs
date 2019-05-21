namespace WindowsFormsApp22
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииСТоваромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованиеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изготовительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаИзготовленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.срокГодностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.операцииСТоваромToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1270, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateToolStripMenuItem.Text = "Create";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // операцииСТоваромToolStripMenuItem
            // 
            this.операцииСТоваромToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.операцииСТоваромToolStripMenuItem.Name = "операцииСТоваромToolStripMenuItem";
            this.операцииСТоваромToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.операцииСТоваромToolStripMenuItem.Text = "Operation";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группаТоваровToolStripMenuItem,
            this.наименованиеТовараToolStripMenuItem,
            this.изготовительToolStripMenuItem,
            this.датаИзготовленияToolStripMenuItem,
            this.срокГодностиToolStripMenuItem});
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.найтиToolStripMenuItem.Text = "Find";
            // 
            // группаТоваровToolStripMenuItem
            // 
            this.группаТоваровToolStripMenuItem.Name = "группаТоваровToolStripMenuItem";
            this.группаТоваровToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.группаТоваровToolStripMenuItem.Text = "Product group";
            // 
            // наименованиеТовараToolStripMenuItem
            // 
            this.наименованиеТовараToolStripMenuItem.Name = "наименованиеТовараToolStripMenuItem";
            this.наименованиеТовараToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.наименованиеТовараToolStripMenuItem.Text = "Product name";
            // 
            // изготовительToolStripMenuItem
            // 
            this.изготовительToolStripMenuItem.Name = "изготовительToolStripMenuItem";
            this.изготовительToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.изготовительToolStripMenuItem.Text = "Manufacturer";
            // 
            // датаИзготовленияToolStripMenuItem
            // 
            this.датаИзготовленияToolStripMenuItem.Name = "датаИзготовленияToolStripMenuItem";
            this.датаИзготовленияToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.датаИзготовленияToolStripMenuItem.Text = "Date of manufacture";
            // 
            // срокГодностиToolStripMenuItem
            // 
            this.срокГодностиToolStripMenuItem.Name = "срокГодностиToolStripMenuItem";
            this.срокГодностиToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.срокГодностиToolStripMenuItem.Text = "Expiration date";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 696);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Управление товаром ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииСТоваромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наименованиеТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изготовительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаИзготовленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem срокГодностиToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
    }
}

