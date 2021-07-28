
namespace Image_Processing
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
            this.BtnTile = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnFlipVertically = new System.Windows.Forms.Button();
            this.btnExtractBlue = new System.Windows.Forms.Button();
            this.btnExtractRed = new System.Windows.Forms.Button();
            this.btnExtractGreen = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnScroll = new System.Windows.Forms.Button();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnFlipHorizontal = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnGreyScale = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTile
            // 
            this.BtnTile.Location = new System.Drawing.Point(565, 203);
            this.BtnTile.Name = "BtnTile";
            this.BtnTile.Size = new System.Drawing.Size(75, 23);
            this.BtnTile.TabIndex = 34;
            this.BtnTile.Text = "Tile";
            this.BtnTile.UseVisualStyleBackColor = true;
            this.BtnTile.Click += new System.EventHandler(this.BtnTile_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(484, 203);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 33;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnFlipVertically
            // 
            this.btnFlipVertically.Location = new System.Drawing.Point(527, 270);
            this.btnFlipVertically.Name = "btnFlipVertically";
            this.btnFlipVertically.Size = new System.Drawing.Size(75, 35);
            this.btnFlipVertically.TabIndex = 39;
            this.btnFlipVertically.Text = "Flip Vertically";
            this.btnFlipVertically.UseVisualStyleBackColor = true;
            this.btnFlipVertically.Click += new System.EventHandler(this.btnFlipVertically_Click);
            // 
            // btnExtractBlue
            // 
            this.btnExtractBlue.Location = new System.Drawing.Point(564, 241);
            this.btnExtractBlue.Name = "btnExtractBlue";
            this.btnExtractBlue.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBlue.TabIndex = 37;
            this.btnExtractBlue.Text = "Ex Blue";
            this.btnExtractBlue.UseVisualStyleBackColor = true;
            this.btnExtractBlue.Click += new System.EventHandler(this.btnExtractBlue_Click);
            // 
            // btnExtractRed
            // 
            this.btnExtractRed.Location = new System.Drawing.Point(402, 241);
            this.btnExtractRed.Name = "btnExtractRed";
            this.btnExtractRed.Size = new System.Drawing.Size(75, 23);
            this.btnExtractRed.TabIndex = 35;
            this.btnExtractRed.Text = "Ex Red";
            this.btnExtractRed.UseVisualStyleBackColor = true;
            this.btnExtractRed.Click += new System.EventHandler(this.btnExtractRed_Click);
            // 
            // btnExtractGreen
            // 
            this.btnExtractGreen.Location = new System.Drawing.Point(484, 241);
            this.btnExtractGreen.Name = "btnExtractGreen";
            this.btnExtractGreen.Size = new System.Drawing.Size(75, 23);
            this.btnExtractGreen.TabIndex = 36;
            this.btnExtractGreen.Text = "Ex Green";
            this.btnExtractGreen.UseVisualStyleBackColor = true;
            this.btnExtractGreen.Click += new System.EventHandler(this.btnExtractGreen_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(402, 203);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(75, 23);
            this.btnBlur.TabIndex = 32;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(565, 125);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 28;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnScroll
            // 
            this.btnScroll.Location = new System.Drawing.Point(565, 167);
            this.btnScroll.Name = "btnScroll";
            this.btnScroll.Size = new System.Drawing.Size(75, 23);
            this.btnScroll.TabIndex = 31;
            this.btnScroll.Text = "Scroll";
            this.btnScroll.UseVisualStyleBackColor = true;
            this.btnScroll.Click += new System.EventHandler(this.btnScroll_Click);
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(484, 167);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(75, 23);
            this.btnPixellate.TabIndex = 30;
            this.btnPixellate.Text = "Pixellate";
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Location = new System.Drawing.Point(444, 270);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(75, 35);
            this.btnFlipHorizontal.TabIndex = 38;
            this.btnFlipHorizontal.Text = "Flip Horizontal";
            this.btnFlipHorizontal.UseVisualStyleBackColor = true;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(402, 167);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(75, 23);
            this.btnRotate180.TabIndex = 29;
            this.btnRotate180.Text = "Rotate 180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(402, 125);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(75, 23);
            this.btnPolarize.TabIndex = 26;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnGreyScale
            // 
            this.btnGreyScale.Location = new System.Drawing.Point(484, 125);
            this.btnGreyScale.Name = "btnGreyScale";
            this.btnGreyScale.Size = new System.Drawing.Size(75, 23);
            this.btnGreyScale.TabIndex = 27;
            this.btnGreyScale.Text = "GreyScale";
            this.btnGreyScale.UseVisualStyleBackColor = true;
            this.btnGreyScale.Click += new System.EventHandler(this.btnGreyScale_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(564, 87);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(75, 23);
            this.btnSunset.TabIndex = 25;
            this.btnSunset.Text = "Sunset";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(402, 87);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(75, 23);
            this.btnLighten.TabIndex = 23;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(484, 87);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(75, 23);
            this.btnDarken.TabIndex = 24;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(564, 46);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(75, 23);
            this.btnNegative.TabIndex = 22;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(484, 46);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(75, 23);
            this.btnTransform.TabIndex = 21;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(402, 46);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(27, 46);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(320, 240);
            this.picImage.TabIndex = 40;
            this.picImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.BtnTile);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnFlipVertically);
            this.Controls.Add(this.btnExtractBlue);
            this.Controls.Add(this.btnExtractRed);
            this.Controls.Add(this.btnExtractGreen);
            this.Controls.Add(this.btnBlur);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnScroll);
            this.Controls.Add(this.btnPixellate);
            this.Controls.Add(this.btnFlipHorizontal);
            this.Controls.Add(this.btnRotate180);
            this.Controls.Add(this.btnPolarize);
            this.Controls.Add(this.btnGreyScale);
            this.Controls.Add(this.btnSunset);
            this.Controls.Add(this.btnLighten);
            this.Controls.Add(this.btnDarken);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTile;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFlipVertically;
        private System.Windows.Forms.Button btnExtractBlue;
        private System.Windows.Forms.Button btnExtractRed;
        private System.Windows.Forms.Button btnExtractGreen;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnScroll;
        private System.Windows.Forms.Button btnPixellate;
        private System.Windows.Forms.Button btnFlipHorizontal;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnGreyScale;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
    }
}

