namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataNavigatorButtonCaptionHelper1 = new WindowsApplication1.DataNavigatorButtonCaptionHelper();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.ImageIndex = 6;
            this.dataNavigator1.Buttons.Append.Tag = "Append";
            this.dataNavigator1.Buttons.CancelEdit.ImageIndex = 9;
            this.dataNavigator1.Buttons.CancelEdit.Tag = "Cancel";
            this.dataNavigator1.Buttons.EndEdit.ImageIndex = 8;
            this.dataNavigator1.Buttons.EndEdit.Tag = "EndEdit";
            this.dataNavigator1.Buttons.First.ImageIndex = 0;
            this.dataNavigator1.Buttons.First.Tag = "First";
            this.dataNavigator1.Buttons.Last.ImageIndex = 5;
            this.dataNavigator1.Buttons.Last.Tag = "Last";
            this.dataNavigator1.Buttons.Next.ImageIndex = 3;
            this.dataNavigator1.Buttons.Next.Tag = "Next";
            this.dataNavigator1.Buttons.NextPage.ImageIndex = 4;
            this.dataNavigator1.Buttons.NextPage.Tag = "NP";
            this.dataNavigator1.Buttons.Prev.ImageIndex = 2;
            this.dataNavigator1.Buttons.Prev.Tag = "Prev";
            this.dataNavigator1.Buttons.PrevPage.ImageIndex = 1;
            this.dataNavigator1.Buttons.PrevPage.Tag = "PrevPage";
            this.dataNavigator1.Buttons.Remove.ImageIndex = 7;
            this.dataNavigator1.Buttons.Remove.Tag = "Remove";
            this.dataNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(-1, 10, true, true, "", "<Custom>")});
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(0, 499);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(987, 28);
            this.dataNavigator1.TabIndex = 0;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(987, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataNavigatorButtonCaptionHelper1
            // 
            this.dataNavigatorButtonCaptionHelper1.SelectedNavigator = this.dataNavigator1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 527);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataNavigator1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataNavigatorButtonCaptionHelper dataNavigatorButtonCaptionHelper1;
    }
}

