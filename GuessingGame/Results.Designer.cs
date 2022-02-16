namespace GuessingGame
{
    partial class Results
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessLabel = new System.Windows.Forms.Label();
            this.originalOrderLabel = new System.Windows.Forms.Label();
            this.sortedOrderLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessLabel
            // 
            this.guessLabel.Location = new System.Drawing.Point(33, 110);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(197, 23);
            this.guessLabel.TabIndex = 0;
            this.guessLabel.Text = "label1";
            // 
            // originalOrderLabel
            // 
            this.originalOrderLabel.Location = new System.Drawing.Point(33, 159);
            this.originalOrderLabel.Name = "originalOrderLabel";
            this.originalOrderLabel.Size = new System.Drawing.Size(197, 23);
            this.originalOrderLabel.TabIndex = 1;
            this.originalOrderLabel.Text = "label1";
            // 
            // sortedOrderLabel
            // 
            this.sortedOrderLabel.Location = new System.Drawing.Point(33, 210);
            this.sortedOrderLabel.Name = "sortedOrderLabel";
            this.sortedOrderLabel.Size = new System.Drawing.Size(197, 23);
            this.sortedOrderLabel.TabIndex = 2;
            this.sortedOrderLabel.Text = "label1";
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(122, 27);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(197, 23);
            this.winLabel.TabIndex = 3;
            this.winLabel.Text = "You Got It!!";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.sortedOrderLabel);
            this.Controls.Add(this.originalOrderLabel);
            this.Controls.Add(this.guessLabel);
            this.Name = "Results";
            this.Size = new System.Drawing.Size(438, 412);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label originalOrderLabel;
        private System.Windows.Forms.Label sortedOrderLabel;
        private System.Windows.Forms.Label winLabel;
    }
}
