﻿using RecipeFramework;
using RecipeFramework.ORF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRecipeTester
{
    public partial class Form1 : Form
    {
        Recipe recipe;

        public Form1()
        {
            InitializeComponent();
        }

        void PopulateUI(Recipe currentRecipe)
        {
            recipe = currentRecipe;

            txtRecipeName.Text = currentRecipe.Name;
            txtRecipeUUID.Text = currentRecipe.UUID;

            txtRecipeAuthor.Text = currentRecipe.Author;
            txtRecipeSource.Text = currentRecipe.Source;
            txtRecipeSourceURL.Text = currentRecipe.SourceUrl;

            txtRecipeOvenTemp.Text = currentRecipe.OvenTemp;
            txtRecipeOvenFan.Text = currentRecipe.OvenFan;
            txtRecipeBakeTime.Text = currentRecipe.BakeTime;

            cmbRecipeYields.Items.Clear();
            cmbRecipeYields.Items.AddRange(currentRecipe.Yields.ToArray());
            cmbRecipeYields.SelectedIndex = 0;
            cmbRecipeYields_SelectedIndexChanged(null, null);

            lstRecipeSteps.Items.Clear();
            lstRecipeSteps.Items.AddRange(currentRecipe.Steps.ToArray());

            lstRecipeNotes.Items.Clear();
            lstRecipeNotes.Items.AddRange(currentRecipe.Notes.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PopulateUI(Recipe.LoadFromFile(openFileDialog1.FileName));
        }

        private void cmbRecipeYields_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstRecipeIngredients.Items.Clear();
            Yield selectedYield = cmbRecipeYields.SelectedItem as Yield;
            if (selectedYield != null)
            {
                foreach (Ingredient ingredient in recipe.Ingredients)
                    lstRecipeIngredients.Items.Add(ingredient.ToString(cmbRecipeYields.SelectedIndex));
            }
        }
    }
}
