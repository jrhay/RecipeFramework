namespace WinFormsRecipeTester
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstRecipeNotes = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstRecipeSteps = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstRecipeIngredients = new System.Windows.Forms.ListBox();
            this.cmbRecipeYields = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecipeBakeTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRecipeOvenFan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRecipeOvenTemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecipeSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecipeSourceURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipeAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecipeUUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstIngredientNotes = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lstIngredientSubstitutionNotes = new System.Windows.Forms.ListBox();
            this.cmbIngredientSubstitutions = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Recipe...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "orf";
            this.openFileDialog1.FileName = "openRecipeDialog1";
            this.openFileDialog1.Filter = "Open Recipe Files|*.orf|YAML Files|*.yaml|Text Files|*.txt|All Files|*.*";
            this.openFileDialog1.Title = "Open Recipe...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbIngredientSubstitutions);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lstIngredientSubstitutionNotes);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lstIngredientNotes);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lstRecipeNotes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lstRecipeSteps);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lstRecipeIngredients);
            this.groupBox1.Controls.Add(this.cmbRecipeYields);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRecipeBakeTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRecipeOvenFan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRecipeOvenTemp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRecipeSource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRecipeSourceURL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRecipeAuthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRecipeUUID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRecipeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 535);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipe";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(768, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Notes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRecipeNotes
            // 
            this.lstRecipeNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRecipeNotes.FormattingEnabled = true;
            this.lstRecipeNotes.Location = new System.Drawing.Point(769, 282);
            this.lstRecipeNotes.Name = "lstRecipeNotes";
            this.lstRecipeNotes.Size = new System.Drawing.Size(282, 238);
            this.lstRecipeNotes.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(10, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Steps";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRecipeSteps
            // 
            this.lstRecipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRecipeSteps.FormattingEnabled = true;
            this.lstRecipeSteps.Location = new System.Drawing.Point(11, 282);
            this.lstRecipeSteps.Name = "lstRecipeSteps";
            this.lstRecipeSteps.Size = new System.Drawing.Size(738, 238);
            this.lstRecipeSteps.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(390, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Ingredients";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstRecipeIngredients
            // 
            this.lstRecipeIngredients.FormattingEnabled = true;
            this.lstRecipeIngredients.Location = new System.Drawing.Point(391, 62);
            this.lstRecipeIngredients.Name = "lstRecipeIngredients";
            this.lstRecipeIngredients.Size = new System.Drawing.Size(354, 173);
            this.lstRecipeIngredients.TabIndex = 48;
            this.lstRecipeIngredients.SelectedIndexChanged += new System.EventHandler(this.lstRecipeIngredients_SelectedIndexChanged);
            // 
            // cmbRecipeYields
            // 
            this.cmbRecipeYields.FormattingEnabled = true;
            this.cmbRecipeYields.Location = new System.Drawing.Point(572, 20);
            this.cmbRecipeYields.Name = "cmbRecipeYields";
            this.cmbRecipeYields.Size = new System.Drawing.Size(175, 21);
            this.cmbRecipeYields.TabIndex = 47;
            this.cmbRecipeYields.SelectedIndexChanged += new System.EventHandler(this.cmbRecipeYields_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(390, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Yield";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(10, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total Bake Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeBakeTime
            // 
            this.txtRecipeBakeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeBakeTime.Location = new System.Drawing.Point(192, 214);
            this.txtRecipeBakeTime.Name = "txtRecipeBakeTime";
            this.txtRecipeBakeTime.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeBakeTime.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(10, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Convection Oven Fan?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeOvenFan
            // 
            this.txtRecipeOvenFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeOvenFan.Location = new System.Drawing.Point(192, 181);
            this.txtRecipeOvenFan.Name = "txtRecipeOvenFan";
            this.txtRecipeOvenFan.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeOvenFan.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(10, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Oven Temperature";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeOvenTemp
            // 
            this.txtRecipeOvenTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeOvenTemp.Location = new System.Drawing.Point(192, 160);
            this.txtRecipeOvenTemp.Name = "txtRecipeOvenTemp";
            this.txtRecipeOvenTemp.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeOvenTemp.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Source";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeSource
            // 
            this.txtRecipeSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeSource.Location = new System.Drawing.Point(192, 101);
            this.txtRecipeSource.Name = "txtRecipeSource";
            this.txtRecipeSource.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeSource.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Source URL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeSourceURL
            // 
            this.txtRecipeSourceURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeSourceURL.Location = new System.Drawing.Point(192, 122);
            this.txtRecipeSourceURL.Name = "txtRecipeSourceURL";
            this.txtRecipeSourceURL.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeSourceURL.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Author";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeAuthor
            // 
            this.txtRecipeAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeAuthor.Location = new System.Drawing.Point(192, 80);
            this.txtRecipeAuthor.Name = "txtRecipeAuthor";
            this.txtRecipeAuthor.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeAuthor.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "UUID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeUUID
            // 
            this.txtRecipeUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeUUID.Location = new System.Drawing.Point(192, 40);
            this.txtRecipeUUID.Name = "txtRecipeUUID";
            this.txtRecipeUUID.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeUUID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(192, 19);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(176, 20);
            this.txtRecipeName.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(768, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Ingredient Notes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstIngredientNotes
            // 
            this.lstIngredientNotes.FormattingEnabled = true;
            this.lstIngredientNotes.Location = new System.Drawing.Point(769, 60);
            this.lstIngredientNotes.Name = "lstIngredientNotes";
            this.lstIngredientNotes.Size = new System.Drawing.Size(282, 69);
            this.lstIngredientNotes.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(768, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Ingredient Substitutions";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstIngredientSubstitutionNotes
            // 
            this.lstIngredientSubstitutionNotes.FormattingEnabled = true;
            this.lstIngredientSubstitutionNotes.Location = new System.Drawing.Point(768, 180);
            this.lstIngredientSubstitutionNotes.Name = "lstIngredientSubstitutionNotes";
            this.lstIngredientSubstitutionNotes.Size = new System.Drawing.Size(282, 56);
            this.lstIngredientSubstitutionNotes.TabIndex = 56;
            // 
            // cmbIngredientSubstitutions
            // 
            this.cmbIngredientSubstitutions.FormattingEnabled = true;
            this.cmbIngredientSubstitutions.Location = new System.Drawing.Point(768, 159);
            this.cmbIngredientSubstitutions.Name = "cmbIngredientSubstitutions";
            this.cmbIngredientSubstitutions.Size = new System.Drawing.Size(280, 21);
            this.cmbIngredientSubstitutions.TabIndex = 58;
            this.cmbIngredientSubstitutions.SelectedIndexChanged += new System.EventHandler(this.cmbIngredientSubstitutions_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "RecipeFramework Tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecipeUUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecipeSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecipeSourceURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipeAuthor;
        private System.Windows.Forms.ListBox lstRecipeIngredients;
        private System.Windows.Forms.ComboBox cmbRecipeYields;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecipeBakeTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRecipeOvenFan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecipeOvenTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstRecipeNotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstRecipeSteps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbIngredientSubstitutions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstIngredientSubstitutionNotes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstIngredientNotes;
    }
}

