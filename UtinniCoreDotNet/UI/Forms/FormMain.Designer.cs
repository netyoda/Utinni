﻿/**
 * MIT License
 *
 * Copyright (c) 2020 Philip Klatt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
**/


namespace UtinniCoreDotNet.UI.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlGame = new System.Windows.Forms.Panel();
            this.cmbPanels = new UtinniCoreDotNet.UI.Controls.UtinniComboBox();
            this.pnlPlugins = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGame.BackColor = System.Drawing.Color.Black;
            this.pnlGame.Location = new System.Drawing.Point(452, 34);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(735, 460);
            this.pnlGame.TabIndex = 3;
            // 
            // cmbPanels
            // 
            this.cmbPanels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbPanels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPanels.DrawOutline = true;
            this.cmbPanels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPanels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPanels.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPanels.FormattingEnabled = true;
            this.cmbPanels.Location = new System.Drawing.Point(3, 3);
            this.cmbPanels.Name = "cmbPanels";
            this.cmbPanels.Size = new System.Drawing.Size(420, 21);
            this.cmbPanels.TabIndex = 6;
            this.cmbPanels.TabStop = false;
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPlugins.AutoScroll = true;
            this.pnlPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlPlugins.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPlugins.Controls.Add(this.cmbPanels);
            this.pnlPlugins.Location = new System.Drawing.Point(0, 34);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(446, 460);
            this.pnlPlugins.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Renagade Build";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPlugins);
            this.Controls.Add(this.pnlGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconImage = ((System.Drawing.Image)(resources.GetObject("$this.IconImage")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(750, 250);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Utinni - Renagade";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.pnlPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGame;
        private UtinniCoreDotNet.UI.Controls.UtinniComboBox cmbPanels;
        private System.Windows.Forms.Panel pnlPlugins;
        private System.Windows.Forms.Label label1;
    }
}