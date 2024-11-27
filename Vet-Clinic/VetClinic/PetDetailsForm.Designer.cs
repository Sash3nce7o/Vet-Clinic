namespace VetClinic
{
    partial class PetDetailsForm
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
            petNameDetailsTitleLabel = new Label();
            adoptPetButton = new Button();
            petBirthdayTimePicker = new DateTimePicker();
            petMedicalHistoryTextBox = new TextBox();
            petFavoriteToyLabel = new Label();
            petStatusTextBox = new TextBox();
            petStatusLabel = new Label();
            petFavoriteToyTextBox = new TextBox();
            petColorLabel = new Label();
            petColorTextBox = new TextBox();
            petWeightLabel = new Label();
            petWeightTextBox = new TextBox();
            petMedicalHistoryLabel = new Label();
            petBirthdayLabel = new Label();
            petBreedLabel = new Label();
            petBreedTextBox = new TextBox();
            petTypeLabel = new Label();
            petTypeTextBox = new TextBox();
            petPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)petPictureBox).BeginInit();
            SuspendLayout();
            // 
            // petNameDetailsTitleLabel
            // 
            petNameDetailsTitleLabel.Anchor = AnchorStyles.Top;
            petNameDetailsTitleLabel.AutoSize = true;
            petNameDetailsTitleLabel.Font = new Font("Trebuchet MS", 48F, FontStyle.Regular, GraphicsUnit.Point);
            petNameDetailsTitleLabel.Location = new Point(563, 62);
            petNameDetailsTitleLabel.Margin = new Padding(4, 0, 4, 0);
            petNameDetailsTitleLabel.Name = "petNameDetailsTitleLabel";
            petNameDetailsTitleLabel.Size = new Size(507, 119);
            petNameDetailsTitleLabel.TabIndex = 1;
            petNameDetailsTitleLabel.Text = "Pet's name";
            // 
            // adoptPetButton
            // 
            adoptPetButton.Anchor = AnchorStyles.Top;
            adoptPetButton.BackColor = Color.FromArgb(0, 0, 192);
            adoptPetButton.Font = new Font("Arial Narrow", 21F, FontStyle.Bold, GraphicsUnit.Point);
            adoptPetButton.ForeColor = Color.White;
            adoptPetButton.Location = new Point(685, 651);
            adoptPetButton.Margin = new Padding(4, 5, 4, 5);
            adoptPetButton.Name = "adoptPetButton";
            adoptPetButton.Size = new Size(169, 78);
            adoptPetButton.TabIndex = 36;
            adoptPetButton.Text = "Adopt";
            adoptPetButton.UseMnemonic = false;
            adoptPetButton.UseVisualStyleBackColor = false;
            adoptPetButton.Click += ButtonAddNewPetClick;
            // 
            // petBirthdayTimePicker
            // 
            petBirthdayTimePicker.Anchor = AnchorStyles.Top;
            petBirthdayTimePicker.Location = new Point(379, 435);
            petBirthdayTimePicker.Margin = new Padding(4, 5, 4, 5);
            petBirthdayTimePicker.Name = "petBirthdayTimePicker";
            petBirthdayTimePicker.Size = new Size(348, 31);
            petBirthdayTimePicker.TabIndex = 35;
            // 
            // petMedicalHistoryTextBox
            // 
            petMedicalHistoryTextBox.Anchor = AnchorStyles.Top;
            petMedicalHistoryTextBox.Location = new Point(908, 502);
            petMedicalHistoryTextBox.Margin = new Padding(4, 5, 4, 5);
            petMedicalHistoryTextBox.Multiline = true;
            petMedicalHistoryTextBox.Name = "petMedicalHistoryTextBox";
            petMedicalHistoryTextBox.Size = new Size(351, 136);
            petMedicalHistoryTextBox.TabIndex = 34;
            // 
            // petFavoriteToyLabel
            // 
            petFavoriteToyLabel.Anchor = AnchorStyles.Top;
            petFavoriteToyLabel.AutoSize = true;
            petFavoriteToyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petFavoriteToyLabel.Location = new Point(195, 562);
            petFavoriteToyLabel.Margin = new Padding(4, 0, 4, 0);
            petFavoriteToyLabel.Name = "petFavoriteToyLabel";
            petFavoriteToyLabel.Size = new Size(169, 40);
            petFavoriteToyLabel.TabIndex = 33;
            petFavoriteToyLabel.Text = "Favorite Toy";
            petFavoriteToyLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // petStatusTextBox
            // 
            petStatusTextBox.Anchor = AnchorStyles.Top;
            petStatusTextBox.Location = new Point(379, 367);
            petStatusTextBox.Margin = new Padding(4, 5, 4, 5);
            petStatusTextBox.Name = "petStatusTextBox";
            petStatusTextBox.Size = new Size(347, 31);
            petStatusTextBox.TabIndex = 32;
            // 
            // petStatusLabel
            // 
            petStatusLabel.Anchor = AnchorStyles.Top;
            petStatusLabel.AutoSize = true;
            petStatusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petStatusLabel.Location = new Point(268, 366);
            petStatusLabel.Margin = new Padding(4, 0, 4, 0);
            petStatusLabel.Name = "petStatusLabel";
            petStatusLabel.Size = new Size(94, 40);
            petStatusLabel.TabIndex = 31;
            petStatusLabel.Text = "Status";
            petStatusLabel.TextAlign = ContentAlignment.TopRight;
            petStatusLabel.Click += petImageLabel_Click;
            // 
            // petFavoriteToyTextBox
            // 
            petFavoriteToyTextBox.Anchor = AnchorStyles.Top;
            petFavoriteToyTextBox.Location = new Point(382, 566);
            petFavoriteToyTextBox.Margin = new Padding(4, 5, 4, 5);
            petFavoriteToyTextBox.Name = "petFavoriteToyTextBox";
            petFavoriteToyTextBox.Size = new Size(345, 31);
            petFavoriteToyTextBox.TabIndex = 30;
            // 
            // petColorLabel
            // 
            petColorLabel.Anchor = AnchorStyles.Top;
            petColorLabel.AutoSize = true;
            petColorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petColorLabel.Location = new Point(804, 284);
            petColorLabel.Margin = new Padding(4, 0, 4, 0);
            petColorLabel.Name = "petColorLabel";
            petColorLabel.Size = new Size(86, 40);
            petColorLabel.TabIndex = 29;
            petColorLabel.Text = "Color";
            petColorLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // petColorTextBox
            // 
            petColorTextBox.Anchor = AnchorStyles.Top;
            petColorTextBox.Location = new Point(912, 291);
            petColorTextBox.Margin = new Padding(4, 5, 4, 5);
            petColorTextBox.Name = "petColorTextBox";
            petColorTextBox.Size = new Size(347, 31);
            petColorTextBox.TabIndex = 28;
            // 
            // petWeightLabel
            // 
            petWeightLabel.Anchor = AnchorStyles.Top;
            petWeightLabel.AutoSize = true;
            petWeightLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petWeightLabel.Location = new Point(249, 288);
            petWeightLabel.Margin = new Padding(4, 0, 4, 0);
            petWeightLabel.Name = "petWeightLabel";
            petWeightLabel.Size = new Size(108, 40);
            petWeightLabel.TabIndex = 27;
            petWeightLabel.Text = "Weight";
            // 
            // petWeightTextBox
            // 
            petWeightTextBox.Anchor = AnchorStyles.Top;
            petWeightTextBox.Location = new Point(379, 291);
            petWeightTextBox.Margin = new Padding(4, 5, 4, 5);
            petWeightTextBox.Name = "petWeightTextBox";
            petWeightTextBox.Size = new Size(347, 31);
            petWeightTextBox.TabIndex = 26;
            // 
            // petMedicalHistoryLabel
            // 
            petMedicalHistoryLabel.Anchor = AnchorStyles.Top;
            petMedicalHistoryLabel.AutoSize = true;
            petMedicalHistoryLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petMedicalHistoryLabel.Location = new Point(685, 502);
            petMedicalHistoryLabel.Margin = new Padding(4, 0, 4, 0);
            petMedicalHistoryLabel.Name = "petMedicalHistoryLabel";
            petMedicalHistoryLabel.Size = new Size(216, 40);
            petMedicalHistoryLabel.TabIndex = 25;
            petMedicalHistoryLabel.Text = "Medical History";
            // 
            // petBirthdayLabel
            // 
            petBirthdayLabel.Anchor = AnchorStyles.Top;
            petBirthdayLabel.AutoSize = true;
            petBirthdayLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petBirthdayLabel.Location = new Point(242, 432);
            petBirthdayLabel.Margin = new Padding(4, 0, 4, 0);
            petBirthdayLabel.Name = "petBirthdayLabel";
            petBirthdayLabel.Size = new Size(123, 40);
            petBirthdayLabel.TabIndex = 24;
            petBirthdayLabel.Text = "Birthday";
            // 
            // petBreedLabel
            // 
            petBreedLabel.Anchor = AnchorStyles.Top;
            petBreedLabel.AutoSize = true;
            petBreedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petBreedLabel.Location = new Point(802, 439);
            petBreedLabel.Margin = new Padding(4, 0, 4, 0);
            petBreedLabel.Name = "petBreedLabel";
            petBreedLabel.Size = new Size(91, 40);
            petBreedLabel.TabIndex = 23;
            petBreedLabel.Text = "Breed";
            // 
            // petBreedTextBox
            // 
            petBreedTextBox.Anchor = AnchorStyles.Top;
            petBreedTextBox.Location = new Point(909, 441);
            petBreedTextBox.Margin = new Padding(4, 5, 4, 5);
            petBreedTextBox.Name = "petBreedTextBox";
            petBreedTextBox.Size = new Size(350, 31);
            petBreedTextBox.TabIndex = 22;
            // 
            // petTypeLabel
            // 
            petTypeLabel.Anchor = AnchorStyles.Top;
            petTypeLabel.AutoSize = true;
            petTypeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petTypeLabel.Location = new Point(820, 364);
            petTypeLabel.Margin = new Padding(4, 0, 4, 0);
            petTypeLabel.Name = "petTypeLabel";
            petTypeLabel.Size = new Size(76, 40);
            petTypeLabel.TabIndex = 21;
            petTypeLabel.Text = "Type";
            // 
            // petTypeTextBox
            // 
            petTypeTextBox.Anchor = AnchorStyles.Top;
            petTypeTextBox.Location = new Point(912, 366);
            petTypeTextBox.Margin = new Padding(4, 5, 4, 5);
            petTypeTextBox.Name = "petTypeTextBox";
            petTypeTextBox.Size = new Size(347, 31);
            petTypeTextBox.TabIndex = 20;
            // 
            // petPictureBox
            // 
            petPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            petPictureBox.Location = new Point(168, 37);
            petPictureBox.Margin = new Padding(4, 5, 4, 5);
            petPictureBox.Name = "petPictureBox";
            petPictureBox.Size = new Size(193, 181);
            petPictureBox.TabIndex = 37;
            petPictureBox.TabStop = false;
            // 
            // PetDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1519, 772);
            Controls.Add(petPictureBox);
            Controls.Add(adoptPetButton);
            Controls.Add(petBirthdayTimePicker);
            Controls.Add(petMedicalHistoryTextBox);
            Controls.Add(petFavoriteToyLabel);
            Controls.Add(petStatusTextBox);
            Controls.Add(petStatusLabel);
            Controls.Add(petFavoriteToyTextBox);
            Controls.Add(petColorLabel);
            Controls.Add(petColorTextBox);
            Controls.Add(petWeightLabel);
            Controls.Add(petWeightTextBox);
            Controls.Add(petMedicalHistoryLabel);
            Controls.Add(petBirthdayLabel);
            Controls.Add(petBreedLabel);
            Controls.Add(petBreedTextBox);
            Controls.Add(petTypeLabel);
            Controls.Add(petTypeTextBox);
            Controls.Add(petNameDetailsTitleLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PetDetailsForm";
            Text = "PetDetailsForm";
            Load += FillPetInfo;
            ((System.ComponentModel.ISupportInitialize)petPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label petNameDetailsTitleLabel;
        private Button adoptPetButton;
        private DateTimePicker petBirthdayTimePicker;
        private TextBox petMedicalHistoryTextBox;
        private Label petFavoriteToyLabel;
        private TextBox petStatusTextBox;
        private Label petStatusLabel;
        private TextBox petFavoriteToyTextBox;
        private Label petColorLabel;
        private TextBox petColorTextBox;
        private Label petWeightLabel;
        private TextBox petWeightTextBox;
        private Label petMedicalHistoryLabel;
        private Label petBirthdayLabel;
        private Label petBreedLabel;
        private TextBox petBreedTextBox;
        private Label petTypeLabel;
        private TextBox petTypeTextBox;
        private PictureBox petPictureBox;
    }
}