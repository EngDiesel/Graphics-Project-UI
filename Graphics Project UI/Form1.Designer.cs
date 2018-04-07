﻿namespace Graphics_Project_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabGraphs = new MaterialSkin.Controls.MaterialTabControl();
            this.tabLine = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabDDASteps = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDDAGraph = new System.Windows.Forms.TabPage();
            this.tabDDAGrid = new System.Windows.Forms.TabPage();
            this.tabLine2 = new System.Windows.Forms.TabPage();
            this.tabCircle = new System.Windows.Forms.TabPage();
            this.tabEllipse = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector4 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialTabSelector5 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pnlDDA = new System.Windows.Forms.Panel();
            this.pnlBresenham = new System.Windows.Forms.Panel();
            this.pnlCircle = new System.Windows.Forms.Panel();
            this.pnlEllipse = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblTest = new MaterialSkin.Controls.MaterialLabel();
            this.tabGraphs.SuspendLayout();
            this.tabLine.SuspendLayout();
            this.tabDDASteps.SuspendLayout();
            this.tabDDAGraph.SuspendLayout();
            this.tabLine2.SuspendLayout();
            this.tabCircle.SuspendLayout();
            this.tabEllipse.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGraphs
            // 
            resources.ApplyResources(this.tabGraphs, "tabGraphs");
            this.tabGraphs.Controls.Add(this.tabLine);
            this.tabGraphs.Controls.Add(this.tabLine2);
            this.tabGraphs.Controls.Add(this.tabCircle);
            this.tabGraphs.Controls.Add(this.tabEllipse);
            this.tabGraphs.Depth = 0;
            this.tabGraphs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabGraphs.Name = "tabGraphs";
            this.tabGraphs.SelectedIndex = 0;
            // 
            // tabLine
            // 
            this.tabLine.Controls.Add(this.materialTabSelector2);
            this.tabLine.Controls.Add(this.tabDDASteps);
            resources.ApplyResources(this.tabLine, "tabLine");
            this.tabLine.Name = "tabLine";
            this.tabLine.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.tabDDASteps;
            this.materialTabSelector2.Depth = 0;
            resources.ApplyResources(this.materialTabSelector2, "materialTabSelector2");
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            // 
            // tabDDASteps
            // 
            this.tabDDASteps.Controls.Add(this.tabDDAGraph);
            this.tabDDASteps.Controls.Add(this.tabDDAGrid);
            this.tabDDASteps.Depth = 0;
            resources.ApplyResources(this.tabDDASteps, "tabDDASteps");
            this.tabDDASteps.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabDDASteps.Name = "tabDDASteps";
            this.tabDDASteps.SelectedIndex = 0;
            // 
            // tabDDAGraph
            // 
            this.tabDDAGraph.Controls.Add(this.materialFlatButton1);
            this.tabDDAGraph.Controls.Add(this.groupBox2);
            this.tabDDAGraph.Controls.Add(this.groupBox1);
            this.tabDDAGraph.Controls.Add(this.lblTest);
            this.tabDDAGraph.Controls.Add(this.pnlDDA);
            resources.ApplyResources(this.tabDDAGraph, "tabDDAGraph");
            this.tabDDAGraph.Name = "tabDDAGraph";
            this.tabDDAGraph.UseVisualStyleBackColor = true;
            // 
            // tabDDAGrid
            // 
            resources.ApplyResources(this.tabDDAGrid, "tabDDAGrid");
            this.tabDDAGrid.Name = "tabDDAGrid";
            this.tabDDAGrid.UseVisualStyleBackColor = true;
            // 
            // tabLine2
            // 
            this.tabLine2.Controls.Add(this.materialTabSelector3);
            this.tabLine2.Controls.Add(this.materialTabControl1);
            resources.ApplyResources(this.tabLine2, "tabLine2");
            this.tabLine2.Name = "tabLine2";
            this.tabLine2.UseVisualStyleBackColor = true;
            // 
            // tabCircle
            // 
            this.tabCircle.Controls.Add(this.materialTabSelector4);
            this.tabCircle.Controls.Add(this.materialTabControl2);
            resources.ApplyResources(this.tabCircle, "tabCircle");
            this.tabCircle.Name = "tabCircle";
            this.tabCircle.UseVisualStyleBackColor = true;
            // 
            // tabEllipse
            // 
            this.tabEllipse.Controls.Add(this.materialTabSelector5);
            this.tabEllipse.Controls.Add(this.materialTabControl3);
            resources.ApplyResources(this.tabEllipse, "tabEllipse");
            this.tabEllipse.Name = "tabEllipse";
            this.tabEllipse.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            resources.ApplyResources(this.materialTabSelector1, "materialTabSelector1");
            this.materialTabSelector1.BaseTabControl = this.tabGraphs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector3.Depth = 0;
            resources.ApplyResources(this.materialTabSelector3, "materialTabSelector3");
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlBresenham);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector4
            // 
            this.materialTabSelector4.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector4.Depth = 0;
            resources.ApplyResources(this.materialTabSelector4, "materialTabSelector4");
            this.materialTabSelector4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector4.Name = "materialTabSelector4";
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage3);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Depth = 0;
            resources.ApplyResources(this.materialTabControl2, "materialTabControl2");
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlCircle);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector5
            // 
            this.materialTabSelector5.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector5.Depth = 0;
            resources.ApplyResources(this.materialTabSelector5, "materialTabSelector5");
            this.materialTabSelector5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector5.Name = "materialTabSelector5";
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Controls.Add(this.tabPage5);
            this.materialTabControl3.Controls.Add(this.tabPage6);
            this.materialTabControl3.Depth = 0;
            resources.ApplyResources(this.materialTabControl3, "materialTabControl3");
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.pnlEllipse);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pnlDDA
            // 
            this.pnlDDA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlDDA, "pnlDDA");
            this.pnlDDA.Name = "pnlDDA";
            // 
            // pnlBresenham
            // 
            this.pnlBresenham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBresenham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlBresenham, "pnlBresenham");
            this.pnlBresenham.Name = "pnlBresenham";
            // 
            // pnlCircle
            // 
            this.pnlCircle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlCircle, "pnlCircle");
            this.pnlCircle.Name = "pnlCircle";
            // 
            // pnlEllipse
            // 
            this.pnlEllipse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEllipse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pnlEllipse, "pnlEllipse");
            this.pnlEllipse.Name = "pnlEllipse";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.materialLabel4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Name = "numericUpDown2";
            // 
            // numericUpDown3
            // 
            resources.ApplyResources(this.numericUpDown3, "numericUpDown3");
            this.numericUpDown3.Name = "numericUpDown3";
            // 
            // numericUpDown4
            // 
            resources.ApplyResources(this.numericUpDown4, "numericUpDown4");
            this.numericUpDown4.Name = "numericUpDown4";
            // 
            // materialFlatButton1
            // 
            resources.ApplyResources(this.materialFlatButton1, "materialFlatButton1");
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.Depth = 0;
            this.lblTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTest.Name = "lblTest";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabGraphs);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabGraphs.ResumeLayout(false);
            this.tabLine.ResumeLayout(false);
            this.tabDDASteps.ResumeLayout(false);
            this.tabDDAGraph.ResumeLayout(false);
            this.tabDDAGraph.PerformLayout();
            this.tabLine2.ResumeLayout(false);
            this.tabCircle.ResumeLayout(false);
            this.tabEllipse.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabGraphs;
        private System.Windows.Forms.TabPage tabLine;
        private System.Windows.Forms.TabPage tabLine2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabCircle;
        private System.Windows.Forms.TabPage tabEllipse;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tabDDASteps;
        private System.Windows.Forms.TabPage tabDDAGraph;
        private System.Windows.Forms.TabPage tabDDAGrid;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector4;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector5;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel pnlDDA;
        private System.Windows.Forms.Panel pnlBresenham;
        private System.Windows.Forms.Panel pnlCircle;
        private System.Windows.Forms.Panel pnlEllipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel lblTest;
    }
}

