namespace WindowsFormsApp1
{
    partial class PluginSelectionForm
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
            this.listBoxPlugins = new System.Windows.Forms.ListBox();
            this.bttnAddPlugin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlugins
            // 
            this.listBoxPlugins.FormattingEnabled = true;
            this.listBoxPlugins.ItemHeight = 20;
            this.listBoxPlugins.Location = new System.Drawing.Point(105, 102);
            this.listBoxPlugins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxPlugins.Name = "listBoxPlugins";
            this.listBoxPlugins.Size = new System.Drawing.Size(318, 204);
            this.listBoxPlugins.TabIndex = 0;
            // 
            // bttnAddPlugin
            // 
            this.bttnAddPlugin.Location = new System.Drawing.Point(474, 169);
            this.bttnAddPlugin.Name = "bttnAddPlugin";
            this.bttnAddPlugin.Size = new System.Drawing.Size(160, 52);
            this.bttnAddPlugin.TabIndex = 1;
            this.bttnAddPlugin.Text = "Добавить";
            this.bttnAddPlugin.UseVisualStyleBackColor = true;
            this.bttnAddPlugin.Click += new System.EventHandler(this.bttnAddPlugin_Click);
            // 
            // PluginSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.bttnAddPlugin);
            this.Controls.Add(this.listBoxPlugins);
            this.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PluginSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PluginSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlugins;
        private System.Windows.Forms.Button bttnAddPlugin;
    }
}