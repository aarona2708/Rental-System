
namespace CMPT_291_Project
{
    partial class Movies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.moviesSearch = new System.Windows.Forms.Button();
            this.userMoviesDropdown = new System.Windows.Forms.ComboBox();
            this.MovieLists = new System.Windows.Forms.DataGridView();
            this.gridMovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMovieCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieLabel = new System.Windows.Forms.Label();
            this.genreSearch = new System.Windows.Forms.Button();
            this.genreDropDown = new System.Windows.Forms.ComboBox();
            this.rentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.acctNoHolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieLists)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesSearch
            // 
            this.moviesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesSearch.Location = new System.Drawing.Point(256, 484);
            this.moviesSearch.Name = "moviesSearch";
            this.moviesSearch.Size = new System.Drawing.Size(71, 28);
            this.moviesSearch.TabIndex = 400;
            this.moviesSearch.Text = "Search";
            this.moviesSearch.UseVisualStyleBackColor = true;
            this.moviesSearch.Click += new System.EventHandler(this.moviesSearch_Click);
            // 
            // userMoviesDropdown
            // 
            this.userMoviesDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMoviesDropdown.FormattingEnabled = true;
            this.userMoviesDropdown.Location = new System.Drawing.Point(12, 485);
            this.userMoviesDropdown.Name = "userMoviesDropdown";
            this.userMoviesDropdown.Size = new System.Drawing.Size(238, 28);
            this.userMoviesDropdown.TabIndex = 399;
            // 
            // MovieLists
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MovieLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MovieLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridMovieID,
            this.gridMovieTitle,
            this.gridMovieGenre,
            this.gridMovieCopies});
            this.MovieLists.Location = new System.Drawing.Point(12, 60);
            this.MovieLists.Name = "MovieLists";
            this.MovieLists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.MovieLists.Size = new System.Drawing.Size(770, 420);
            this.MovieLists.TabIndex = 398;
            // 
            // gridMovieID
            // 
            this.gridMovieID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieID.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridMovieID.HeaderText = "ID";
            this.gridMovieID.Name = "gridMovieID";
            this.gridMovieID.Width = 69;
            // 
            // gridMovieTitle
            // 
            this.gridMovieTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieTitle.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMovieTitle.HeaderText = "Title";
            this.gridMovieTitle.Name = "gridMovieTitle";
            this.gridMovieTitle.Width = 96;
            // 
            // gridMovieGenre
            // 
            this.gridMovieGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieGenre.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridMovieGenre.HeaderText = "Genre";
            this.gridMovieGenre.Name = "gridMovieGenre";
            this.gridMovieGenre.Width = 119;
            // 
            // gridMovieCopies
            // 
            this.gridMovieCopies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMovieCopies.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridMovieCopies.HeaderText = "Copies";
            this.gridMovieCopies.Name = "gridMovieCopies";
            this.gridMovieCopies.Width = 130;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.movieLabel.Location = new System.Drawing.Point(12, 26);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(161, 31);
            this.movieLabel.TabIndex = 401;
            this.movieLabel.Text = "Movie Lists";
            // 
            // genreSearch
            // 
            this.genreSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreSearch.Location = new System.Drawing.Point(662, 483);
            this.genreSearch.Name = "genreSearch";
            this.genreSearch.Size = new System.Drawing.Size(120, 28);
            this.genreSearch.TabIndex = 403;
            this.genreSearch.Text = "Search Genre";
            this.genreSearch.UseVisualStyleBackColor = true;
            this.genreSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // genreDropDown
            // 
            this.genreDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreDropDown.FormattingEnabled = true;
            this.genreDropDown.Location = new System.Drawing.Point(460, 484);
            this.genreDropDown.Name = "genreDropDown";
            this.genreDropDown.Size = new System.Drawing.Size(196, 28);
            this.genreDropDown.TabIndex = 402;
            // 
            // rentButton
            // 
            this.rentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentButton.Location = new System.Drawing.Point(788, 452);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(71, 28);
            this.rentButton.TabIndex = 404;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(894, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(71, 28);
            this.backButton.TabIndex = 405;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // acctNoHolder
            // 
            this.acctNoHolder.AutoSize = true;
            this.acctNoHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNoHolder.Location = new System.Drawing.Point(801, 166);
            this.acctNoHolder.Name = "acctNoHolder";
            this.acctNoHolder.Size = new System.Drawing.Size(76, 13);
            this.acctNoHolder.TabIndex = 406;
            this.acctNoHolder.Text = "acctNo Holder";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 561);
            this.Controls.Add(this.acctNoHolder);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.genreSearch);
            this.Controls.Add(this.genreDropDown);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.moviesSearch);
            this.Controls.Add(this.userMoviesDropdown);
            this.Controls.Add(this.MovieLists);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieLists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moviesSearch;
        private System.Windows.Forms.ComboBox userMoviesDropdown;
        private System.Windows.Forms.DataGridView MovieLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMovieCopies;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Button genreSearch;
        private System.Windows.Forms.ComboBox genreDropDown;
        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label acctNoHolder;
    }
}