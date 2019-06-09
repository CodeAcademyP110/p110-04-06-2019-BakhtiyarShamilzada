namespace _04_June_2019
{
    partial class HomePage
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProducts.Location = new System.Drawing.Point(0, 24);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(981, 691);
            this.dgwProducts.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem,
            this.productDeleteToolStripMenuItem,
            this.productUpdateToolStripMenuItem});
            this.productsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.productAddToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productAddToolStripMenuItem.Text = "Product Add";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.ProductAddToolStripMenuItem_Click);
            // 
            // productDeleteToolStripMenuItem
            // 
            this.productDeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.productDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productDeleteToolStripMenuItem.Name = "productDeleteToolStripMenuItem";
            this.productDeleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productDeleteToolStripMenuItem.Text = "Product Delete";
            this.productDeleteToolStripMenuItem.Click += new System.EventHandler(this.ProductDeleteToolStripMenuItem_Click);
            // 
            // productUpdateToolStripMenuItem
            // 
            this.productUpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.productUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productUpdateToolStripMenuItem.Name = "productUpdateToolStripMenuItem";
            this.productUpdateToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.productUpdateToolStripMenuItem.Text = "Product Update";
            this.productUpdateToolStripMenuItem.Click += new System.EventHandler(this.ProductUpdateToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryAddToolStripMenuItem,
            this.categoryDeleteToolStripMenuItem,
            this.categoryUpdateToolStripMenuItem});
            this.categoriesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.CategoriesToolStripMenuItem_Click);
            // 
            // categoryAddToolStripMenuItem
            // 
            this.categoryAddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.categoryAddToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoryAddToolStripMenuItem.Name = "categoryAddToolStripMenuItem";
            this.categoryAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryAddToolStripMenuItem.Text = "Category Add";
            this.categoryAddToolStripMenuItem.Click += new System.EventHandler(this.CategoryAddToolStripMenuItem_Click);
            // 
            // categoryDeleteToolStripMenuItem
            // 
            this.categoryDeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.categoryDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoryDeleteToolStripMenuItem.Name = "categoryDeleteToolStripMenuItem";
            this.categoryDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryDeleteToolStripMenuItem.Text = "Category Delete";
            this.categoryDeleteToolStripMenuItem.Click += new System.EventHandler(this.CategoryDeleteToolStripMenuItem_Click);
            // 
            // categoryUpdateToolStripMenuItem
            // 
            this.categoryUpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.categoryUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.categoryUpdateToolStripMenuItem.Name = "categoryUpdateToolStripMenuItem";
            this.categoryUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoryUpdateToolStripMenuItem.Text = "Category Update";
            this.categoryUpdateToolStripMenuItem.Click += new System.EventHandler(this.CategoryUpdateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 2;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryUpdateToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

