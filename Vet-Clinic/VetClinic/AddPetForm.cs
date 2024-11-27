namespace VetClinic
{
    public partial class AddPetForm : Form
    {
        private string petImage;

        public AddPetForm()
        {
            InitializeComponent();
        }

        public IAnimal Animal { get; set; }

        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            this.petFavoriteToyLabel.Visible = false;
            this.petFavoriteToyTextBox.Visible = false;
            this.errorFavoriteToyLabel.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            this.petFavoriteToyLabel.Visible = true;
            this.petFavoriteToyTextBox.Visible = true;
        }

        private static void ShowValidationError(Label errorLabel, bool valid)
        {
            errorLabel.Visible = !valid;
        }

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool valid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, valid);

            return valid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, double min, Label errorLabel)
        {
            bool valid = double.TryParse(textBox.Text.Trim(), out double parsedValue)
                && parsedValue > min;

            ShowValidationError(errorLabel, valid);

            return valid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool valid = !string.IsNullOrWhiteSpace(value?.Trim());
            ShowValidationError(errorLabel, valid);

            return valid;
        }

        private bool CheckInputsAreValid()
        {
            return CheckIfValid(this.petNameTextBox, 3, this.errorNameLabel) &&
                CheckIfValid(this.petBreedTextBox, 5, this.errorBreedLabel) &&
                CheckIfValid(this.petMedicalHistoryTextBox, 10, this.errorMedicalHistoryLabel) &&
                CheckIfValid(this.petColorTextBox, 3, this.errorColorLabel) &&
                CheckIfValidDouble(this.petWeightTextBox, 0.5, this.errorWeightLabel) &&
                CheckIfNotEmpty(this.petImage, this.errorImageLabel);
        }

        private IAnimal CreateNewAnimal()
        {
            string name = this.petNameTextBox.Text.Trim();
            string breed = this.petBreedTextBox.Text.Trim();
            string medicalHistory = this.petMedicalHistoryTextBox.Text.Trim();
            string color = this.petColorTextBox.Text.Trim();

            DateTime birthday = DateTime.Parse(this.petBirthdayTimePicker.Text.Trim());

            double weight = double.Parse(this.petWeightTextBox.Text.Trim());

            IAnimal animal;

            if (this.catRadioPicker.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name, birthday, breed, medicalHistory, weight, color);
            }

            animal.Image = petImage;

            return animal;
        }

        private IAnimal CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favoriteToy = this.petFavoriteToyTextBox.Text.Trim();

            if (!CheckIfValid(this.petFavoriteToyTextBox, 3, this.errorFavoriteToyLabel)) return null;

            return new Cat(name, birthday, breed, medicalHistory, weight, color, favoriteToy);
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            if (!CheckInputsAreValid()) return;

            IAnimal newAnimal = CreateNewAnimal();

            if (newAnimal == null) return;

            this.Animal = newAnimal;
            DialogResult = DialogResult.OK;
        }

        private void TextBoxPhotoMouseDown(object sender, MouseEventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.petImageTextBox.Text = Path.GetFileName(petImage);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void petMedicalHistoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void errorColorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
