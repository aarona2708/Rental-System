
namespace CMPT_291_Project
{
    partial class AdvancedStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.displayListView = new System.Windows.Forms.ListView();
            this.selectGenreComboBox = new System.Windows.Forms.ComboBox();
            this.selectGenreLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "📊 Advanced Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select query to run:";
            // 
            // queryBox
            // 
            this.queryBox.FormattingEnabled = true;
            this.queryBox.Items.AddRange(new object[] {
            "Users who rent more than average",
            "Users who have not rented <genre>",
            "Users who have rented all genres",
            "Movies that are rented more than average",
            "Users who rent <genre> more than average"});
            this.queryBox.Location = new System.Drawing.Point(34, 117);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(259, 21);
            this.queryBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // displayListView
            // 
            this.displayListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(32, 171);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(733, 267);
            this.displayListView.TabIndex = 6;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.View = System.Windows.Forms.View.Details;
            this.displayListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // selectGenreComboBox
            // 
            this.selectGenreComboBox.FormattingEnabled = true;
            this.selectGenreComboBox.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Foreign"});
            this.selectGenreComboBox.Location = new System.Drawing.Point(94, 144);
            this.selectGenreComboBox.Name = "selectGenreComboBox";
            this.selectGenreComboBox.Size = new System.Drawing.Size(199, 21);
            this.selectGenreComboBox.TabIndex = 7;
            this.selectGenreComboBox.Visible = false;
            // 
            // selectGenreLabel
            // 
            this.selectGenreLabel.AutoSize = true;
            this.selectGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGenreLabel.Location = new System.Drawing.Point(30, 145);
            this.selectGenreLabel.Name = "selectGenreLabel";
            this.selectGenreLabel.Size = new System.Drawing.Size(58, 20);
            this.selectGenreLabel.TabIndex = 8;
            this.selectGenreLabel.Text = "Genre:";
            this.selectGenreLabel.Visible = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(306, 145);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 20);
            this.resultsLabel.TabIndex = 9;
            // 
            // AdvancedStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.selectGenreLabel);
            this.Controls.Add(this.selectGenreComboBox);
            this.Controls.Add(this.displayListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdvancedStatistics";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdvancedStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox queryBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.ComboBox selectGenreComboBox;
        private System.Windows.Forms.Label selectGenreLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}