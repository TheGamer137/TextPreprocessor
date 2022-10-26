using System.ComponentModel;

namespace TextPreprocessor
{
    partial class TextView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDictionaryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDictionaryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDictionaryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxDictionary = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.словарьToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.createDictionaryButton, this.updateDictionaryButton, this.deleteDictionaryButton });
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.словарьToolStripMenuItem.Text = "Словарь";
            // 
            // createDictionaryButton
            // 
            this.createDictionaryButton.Name = "createDictionaryButton";
            this.createDictionaryButton.Size = new System.Drawing.Size(227, 24);
            this.createDictionaryButton.Text = "Создание словаря";
            // 
            // updateDictionaryButton
            // 
            this.updateDictionaryButton.Name = "updateDictionaryButton";
            this.updateDictionaryButton.Size = new System.Drawing.Size(227, 24);
            this.updateDictionaryButton.Text = "Обновление словаря";
            // 
            // deleteDictionaryButton
            // 
            this.deleteDictionaryButton.Name = "deleteDictionaryButton";
            this.deleteDictionaryButton.Size = new System.Drawing.Size(227, 24);
            this.deleteDictionaryButton.Text = "Очистить словарь";
            // 
            // richTextBoxDictionary
            // 
            this.richTextBoxDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDictionary.Location = new System.Drawing.Point(0, 31);
            this.richTextBoxDictionary.Name = "richTextBoxDictionary";
            this.richTextBoxDictionary.Size = new System.Drawing.Size(425, 313);
            this.richTextBoxDictionary.TabIndex = 1;
            this.richTextBoxDictionary.Text = "";
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 344);
            this.Controls.Add(this.richTextBoxDictionary);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовой процессор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox richTextBoxDictionary;

        private System.Windows.Forms.ToolStripMenuItem словарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDictionaryButton;
        private System.Windows.Forms.ToolStripMenuItem updateDictionaryButton;
        private System.Windows.Forms.ToolStripMenuItem deleteDictionaryButton;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}