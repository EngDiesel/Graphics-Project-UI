namespace Graphics_Project_UI
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
            this.tabGraphs.SuspendLayout();
            this.tabLine.SuspendLayout();
            this.tabDDASteps.SuspendLayout();
            this.tabLine2.SuspendLayout();
            this.tabCircle.SuspendLayout();
            this.tabEllipse.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
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
            this.tabLine2.ResumeLayout(false);
            this.tabCircle.ResumeLayout(false);
            this.tabEllipse.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
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
    }
}

