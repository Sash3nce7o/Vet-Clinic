namespace VetClinic
{
    partial class AddPetForm
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
            petNameTextBox = new TextBox();
            petNameLabel = new Label();
            petBreedLabel = new Label();
            petBreedTextBox = new TextBox();
            petBirthdayLabel = new Label();
            petMedicalHistoryLabel = new Label();
            petWeightLabel = new Label();
            petWeightTextBox = new TextBox();
            petColorLabel = new Label();
            petColorTextBox = new TextBox();
            petImageLabel = new Label();
            petFavoriteToyLabel = new Label();
            petFavoriteToyTextBox = new TextBox();
            petMedicalHistoryTextBox = new TextBox();
            petBirthdayTimePicker = new DateTimePicker();
            addPetFormButton = new Button();
            petImageTextBox = new TextBox();
            errorNameLabel = new Label();
            errorBreedLabel = new Label();
            errorMedicalHistoryLabel = new Label();
            errorWeightLabel = new Label();
            errorColorLabel = new Label();
            errorImageLabel = new Label();
            errorFavoriteToyLabel = new Label();
            newPetTitleLabel = new Label();
            catRadioPicker = new RadioButton();
            dogRadioPicker = new RadioButton();
            SuspendLayout();
            // 
            // petNameTextBox
            // 
            petNameTextBox.Anchor = AnchorStyles.Top;
            petNameTextBox.Location = new Point(244, 286);
            petNameTextBox.Margin = new Padding(4, 5, 4, 5);
            petNameTextBox.Name = "petNameTextBox";
            petNameTextBox.Size = new Size(357, 31);
            petNameTextBox.TabIndex = 1;
            petNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // petNameLabel
            // 
            petNameLabel.Anchor = AnchorStyles.Top;
            petNameLabel.AutoSize = true;
            petNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petNameLabel.Location = new Point(129, 286);
            petNameLabel.Margin = new Padding(4, 0, 4, 0);
            petNameLabel.Name = "petNameLabel";
            petNameLabel.Size = new Size(94, 40);
            petNameLabel.TabIndex = 2;
            petNameLabel.Text = "Name";
            // 
            // petBreedLabel
            // 
            petBreedLabel.Anchor = AnchorStyles.Top;
            petBreedLabel.AutoSize = true;
            petBreedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petBreedLabel.Location = new Point(129, 398);
            petBreedLabel.Margin = new Padding(4, 0, 4, 0);
            petBreedLabel.Name = "petBreedLabel";
            petBreedLabel.Size = new Size(91, 40);
            petBreedLabel.TabIndex = 4;
            petBreedLabel.Text = "Breed";
            // 
            // petBreedTextBox
            // 
            petBreedTextBox.Anchor = AnchorStyles.Top;
            petBreedTextBox.Location = new Point(244, 398);
            petBreedTextBox.Margin = new Padding(4, 5, 4, 5);
            petBreedTextBox.Name = "petBreedTextBox";
            petBreedTextBox.Size = new Size(357, 31);
            petBreedTextBox.TabIndex = 3;
            // 
            // petBirthdayLabel
            // 
            petBirthdayLabel.Anchor = AnchorStyles.Top;
            petBirthdayLabel.AutoSize = true;
            petBirthdayLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petBirthdayLabel.Location = new Point(643, 294);
            petBirthdayLabel.Margin = new Padding(4, 0, 4, 0);
            petBirthdayLabel.Name = "petBirthdayLabel";
            petBirthdayLabel.Size = new Size(123, 40);
            petBirthdayLabel.TabIndex = 5;
            petBirthdayLabel.Text = "Birthday";
            // 
            // petMedicalHistoryLabel
            // 
            petMedicalHistoryLabel.Anchor = AnchorStyles.Top;
            petMedicalHistoryLabel.AutoSize = true;
            petMedicalHistoryLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petMedicalHistoryLabel.Location = new Point(734, 478);
            petMedicalHistoryLabel.Margin = new Padding(4, 0, 4, 0);
            petMedicalHistoryLabel.Name = "petMedicalHistoryLabel";
            petMedicalHistoryLabel.Size = new Size(216, 40);
            petMedicalHistoryLabel.TabIndex = 6;
            petMedicalHistoryLabel.Text = "Medical History";
            petMedicalHistoryLabel.Click += petMedicalHistoryLabel_Click;
            // 
            // petWeightLabel
            // 
            petWeightLabel.Anchor = AnchorStyles.Top;
            petWeightLabel.AutoSize = true;
            petWeightLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petWeightLabel.Location = new Point(633, 402);
            petWeightLabel.Margin = new Padding(4, 0, 4, 0);
            petWeightLabel.Name = "petWeightLabel";
            petWeightLabel.Size = new Size(108, 40);
            petWeightLabel.TabIndex = 10;
            petWeightLabel.Text = "Weight";
            // 
            // petWeightTextBox
            // 
            petWeightTextBox.Anchor = AnchorStyles.Top;
            petWeightTextBox.Location = new Point(749, 402);
            petWeightTextBox.Margin = new Padding(4, 5, 4, 5);
            petWeightTextBox.Name = "petWeightTextBox";
            petWeightTextBox.Size = new Size(131, 31);
            petWeightTextBox.TabIndex = 9;
            // 
            // petColorLabel
            // 
            petColorLabel.Anchor = AnchorStyles.Top;
            petColorLabel.AutoSize = true;
            petColorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petColorLabel.Location = new Point(912, 398);
            petColorLabel.Margin = new Padding(4, 0, 4, 0);
            petColorLabel.Name = "petColorLabel";
            petColorLabel.Size = new Size(86, 40);
            petColorLabel.TabIndex = 12;
            petColorLabel.Text = "Color";
            petColorLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // petColorTextBox
            // 
            petColorTextBox.Anchor = AnchorStyles.Top;
            petColorTextBox.Location = new Point(1003, 402);
            petColorTextBox.Margin = new Padding(4, 5, 4, 5);
            petColorTextBox.Name = "petColorTextBox";
            petColorTextBox.Size = new Size(131, 31);
            petColorTextBox.TabIndex = 11;
            // 
            // petImageLabel
            // 
            petImageLabel.Anchor = AnchorStyles.Top;
            petImageLabel.AutoSize = true;
            petImageLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petImageLabel.Location = new Point(451, 35);
            petImageLabel.Margin = new Padding(4, 0, 4, 0);
            petImageLabel.Name = "petImageLabel";
            petImageLabel.Size = new Size(97, 40);
            petImageLabel.TabIndex = 14;
            petImageLabel.Text = "Image";
            petImageLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // petFavoriteToyLabel
            // 
            petFavoriteToyLabel.Anchor = AnchorStyles.Top;
            petFavoriteToyLabel.AutoSize = true;
            petFavoriteToyLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            petFavoriteToyLabel.Location = new Point(129, 496);
            petFavoriteToyLabel.Margin = new Padding(4, 0, 4, 0);
            petFavoriteToyLabel.Name = "petFavoriteToyLabel";
            petFavoriteToyLabel.Size = new Size(169, 40);
            petFavoriteToyLabel.TabIndex = 16;
            petFavoriteToyLabel.Text = "Favorite Toy";
            petFavoriteToyLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // petFavoriteToyTextBox
            // 
            petFavoriteToyTextBox.Anchor = AnchorStyles.Top;
            petFavoriteToyTextBox.Location = new Point(298, 499);
            petFavoriteToyTextBox.Margin = new Padding(4, 5, 4, 5);
            petFavoriteToyTextBox.Name = "petFavoriteToyTextBox";
            petFavoriteToyTextBox.Size = new Size(363, 31);
            petFavoriteToyTextBox.TabIndex = 15;
            // 
            // petMedicalHistoryTextBox
            // 
            petMedicalHistoryTextBox.Anchor = AnchorStyles.Top;
            petMedicalHistoryTextBox.Location = new Point(734, 543);
            petMedicalHistoryTextBox.Margin = new Padding(4, 5, 4, 5);
            petMedicalHistoryTextBox.Multiline = true;
            petMedicalHistoryTextBox.Name = "petMedicalHistoryTextBox";
            petMedicalHistoryTextBox.Size = new Size(404, 134);
            petMedicalHistoryTextBox.TabIndex = 17;
            // 
            // petBirthdayTimePicker
            // 
            petBirthdayTimePicker.Anchor = AnchorStyles.Top;
            petBirthdayTimePicker.Location = new Point(789, 299);
            petBirthdayTimePicker.Margin = new Padding(4, 5, 4, 5);
            petBirthdayTimePicker.Name = "petBirthdayTimePicker";
            petBirthdayTimePicker.Size = new Size(355, 31);
            petBirthdayTimePicker.TabIndex = 18;
            // 
            // addPetFormButton
            // 
            addPetFormButton.Anchor = AnchorStyles.Top;
            addPetFormButton.BackColor = Color.FromArgb(0, 0, 192);
            addPetFormButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addPetFormButton.ForeColor = Color.White;
            addPetFormButton.Location = new Point(185, 571);
            addPetFormButton.Margin = new Padding(4, 5, 4, 5);
            addPetFormButton.Name = "addPetFormButton";
            addPetFormButton.Size = new Size(167, 78);
            addPetFormButton.TabIndex = 19;
            addPetFormButton.Text = "Add";
            addPetFormButton.UseMnemonic = false;
            addPetFormButton.UseVisualStyleBackColor = false;
            addPetFormButton.Click += ButtonAddNewPetClick;
            // 
            // petImageTextBox
            // 
            petImageTextBox.Anchor = AnchorStyles.Top;
            petImageTextBox.Location = new Point(418, 94);
            petImageTextBox.Margin = new Padding(4, 5, 4, 5);
            petImageTextBox.Multiline = true;
            petImageTextBox.Name = "petImageTextBox";
            petImageTextBox.Size = new Size(140, 132);
            petImageTextBox.TabIndex = 13;
            petImageTextBox.MouseDown += TextBoxPhotoMouseDown;
            // 
            // errorNameLabel
            // 
            errorNameLabel.Anchor = AnchorStyles.Top;
            errorNameLabel.AutoSize = true;
            errorNameLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorNameLabel.ForeColor = Color.Red;
            errorNameLabel.Location = new Point(244, 329);
            errorNameLabel.Margin = new Padding(4, 0, 4, 0);
            errorNameLabel.Name = "errorNameLabel";
            errorNameLabel.Size = new Size(337, 23);
            errorNameLabel.TabIndex = 20;
            errorNameLabel.Text = "Name should be at least 3 characters long!";
            // 
            // errorBreedLabel
            // 
            errorBreedLabel.Anchor = AnchorStyles.Top;
            errorBreedLabel.AutoSize = true;
            errorBreedLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorBreedLabel.ForeColor = Color.Red;
            errorBreedLabel.Location = new Point(247, 441);
            errorBreedLabel.Margin = new Padding(4, 0, 4, 0);
            errorBreedLabel.Name = "errorBreedLabel";
            errorBreedLabel.Size = new Size(335, 23);
            errorBreedLabel.TabIndex = 21;
            errorBreedLabel.Text = "Breed should be at least 5 characters long!";
            // 
            // errorMedicalHistoryLabel
            // 
            errorMedicalHistoryLabel.Anchor = AnchorStyles.Top;
            errorMedicalHistoryLabel.AutoSize = true;
            errorMedicalHistoryLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorMedicalHistoryLabel.ForeColor = Color.Red;
            errorMedicalHistoryLabel.Location = new Point(734, 699);
            errorMedicalHistoryLabel.Margin = new Padding(4, 0, 4, 0);
            errorMedicalHistoryLabel.Name = "errorMedicalHistoryLabel";
            errorMedicalHistoryLabel.Size = new Size(417, 23);
            errorMedicalHistoryLabel.TabIndex = 22;
            errorMedicalHistoryLabel.Text = "Medical History should be at least 10 characters long!";
            // 
            // errorWeightLabel
            // 
            errorWeightLabel.Anchor = AnchorStyles.Top;
            errorWeightLabel.AutoSize = true;
            errorWeightLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorWeightLabel.ForeColor = Color.Red;
            errorWeightLabel.Location = new Point(749, 445);
            errorWeightLabel.Margin = new Padding(4, 0, 4, 0);
            errorWeightLabel.Name = "errorWeightLabel";
            errorWeightLabel.Size = new Size(139, 23);
            errorWeightLabel.TabIndex = 23;
            errorWeightLabel.Text = "Weight is invalid!";
            // 
            // errorColorLabel
            // 
            errorColorLabel.Anchor = AnchorStyles.Top;
            errorColorLabel.AutoSize = true;
            errorColorLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorColorLabel.ForeColor = Color.Red;
            errorColorLabel.Location = new Point(1003, 445);
            errorColorLabel.Margin = new Padding(4, 0, 4, 0);
            errorColorLabel.Name = "errorColorLabel";
            errorColorLabel.Size = new Size(136, 23);
            errorColorLabel.TabIndex = 24;
            errorColorLabel.Text = "Color is required";
            errorColorLabel.Click += errorColorLabel_Click;
            // 
            // errorImageLabel
            // 
            errorImageLabel.Anchor = AnchorStyles.Top;
            errorImageLabel.AutoSize = true;
            errorImageLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorImageLabel.ForeColor = Color.Red;
            errorImageLabel.Location = new Point(418, 231);
            errorImageLabel.Margin = new Padding(4, 0, 4, 0);
            errorImageLabel.Name = "errorImageLabel";
            errorImageLabel.Size = new Size(148, 23);
            errorImageLabel.TabIndex = 25;
            errorImageLabel.Text = "Image is required!";
            // 
            // errorFavoriteToyLabel
            // 
            errorFavoriteToyLabel.Anchor = AnchorStyles.Top;
            errorFavoriteToyLabel.AutoSize = true;
            errorFavoriteToyLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            errorFavoriteToyLabel.ForeColor = Color.Red;
            errorFavoriteToyLabel.Location = new Point(301, 543);
            errorFavoriteToyLabel.Margin = new Padding(4, 0, 4, 0);
            errorFavoriteToyLabel.Name = "errorFavoriteToyLabel";
            errorFavoriteToyLabel.Size = new Size(188, 23);
            errorFavoriteToyLabel.TabIndex = 26;
            errorFavoriteToyLabel.Text = "Favorite toy is required!";
            // 
            // newPetTitleLabel
            // 
            newPetTitleLabel.Anchor = AnchorStyles.Top;
            newPetTitleLabel.AutoSize = true;
            newPetTitleLabel.Font = new Font("Trebuchet MS", 48F, FontStyle.Regular, GraphicsUnit.Point);
            newPetTitleLabel.Location = new Point(584, 35);
            newPetTitleLabel.Margin = new Padding(4, 0, 4, 0);
            newPetTitleLabel.Name = "newPetTitleLabel";
            newPetTitleLabel.Size = new Size(403, 119);
            newPetTitleLabel.TabIndex = 0;
            newPetTitleLabel.Text = "New Pet";
            // 
            // catRadioPicker
            // 
            catRadioPicker.Anchor = AnchorStyles.Top;
            catRadioPicker.AutoSize = true;
            catRadioPicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            catRadioPicker.Location = new Point(620, 195);
            catRadioPicker.Margin = new Padding(4, 5, 4, 5);
            catRadioPicker.Name = "catRadioPicker";
            catRadioPicker.Size = new Size(92, 49);
            catRadioPicker.TabIndex = 7;
            catRadioPicker.TabStop = true;
            catRadioPicker.Text = "Cat";
            catRadioPicker.UseVisualStyleBackColor = true;
            catRadioPicker.Click += RadioButtonCatCheckedChanged;
            // 
            // dogRadioPicker
            // 
            dogRadioPicker.Anchor = AnchorStyles.Top;
            dogRadioPicker.AutoSize = true;
            dogRadioPicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dogRadioPicker.Location = new Point(759, 195);
            dogRadioPicker.Margin = new Padding(4, 5, 4, 5);
            dogRadioPicker.Name = "dogRadioPicker";
            dogRadioPicker.Size = new Size(105, 49);
            dogRadioPicker.TabIndex = 8;
            dogRadioPicker.TabStop = true;
            dogRadioPicker.Text = "Dog";
            dogRadioPicker.UseVisualStyleBackColor = true;
            dogRadioPicker.Click += RadioButtonDogCheckedChanged;
            // 
            // AddPetForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1726, 757);
            Controls.Add(dogRadioPicker);
            Controls.Add(catRadioPicker);
            Controls.Add(errorFavoriteToyLabel);
            Controls.Add(newPetTitleLabel);
            Controls.Add(errorImageLabel);
            Controls.Add(errorColorLabel);
            Controls.Add(errorWeightLabel);
            Controls.Add(errorMedicalHistoryLabel);
            Controls.Add(errorBreedLabel);
            Controls.Add(errorNameLabel);
            Controls.Add(addPetFormButton);
            Controls.Add(petBirthdayTimePicker);
            Controls.Add(petMedicalHistoryTextBox);
            Controls.Add(petFavoriteToyLabel);
            Controls.Add(petFavoriteToyTextBox);
            Controls.Add(petImageLabel);
            Controls.Add(petImageTextBox);
            Controls.Add(petColorLabel);
            Controls.Add(petColorTextBox);
            Controls.Add(petWeightLabel);
            Controls.Add(petWeightTextBox);
            Controls.Add(petMedicalHistoryLabel);
            Controls.Add(petBirthdayLabel);
            Controls.Add(petBreedLabel);
            Controls.Add(petBreedTextBox);
            Controls.Add(petNameLabel);
            Controls.Add(petNameTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddPetForm";
            Text = "AddPetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox petNameTextBox;
        private Label petNameLabel;
        private Label petBreedLabel;
        private TextBox petBreedTextBox;
        private Label petBirthdayLabel;
        private Label petMedicalHistoryLabel;
        private Label petWeightLabel;
        private TextBox petWeightTextBox;
        private Label petColorLabel;
        private TextBox petColorTextBox;
        private Label petImageLabel;
        private Label petFavoriteToyLabel;
        private TextBox petFavoriteToyTextBox;
        private TextBox petMedicalHistoryTextBox;
        private DateTimePicker petBirthdayTimePicker;
        private Button addPetFormButton;
        private TextBox petImageTextBox;
        private Label errorNameLabel;
        private Label errorBreedLabel;
        private Label errorMedicalHistoryLabel;
        private Label errorWeightLabel;
        private Label errorColorLabel;
        private Label errorImageLabel;
        private Label errorFavoriteToyLabel;
        private Label newPetTitleLabel;
        private RadioButton catRadioPicker;
        private RadioButton dogRadioPicker;
    }
}