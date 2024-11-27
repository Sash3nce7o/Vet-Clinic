namespace VetClinic
{
    public partial class PetDetailsForm : Form
    {
        private readonly IAnimal pet;

        public PetDetailsForm(IAnimal pet)
        {
            InitializeComponent();
            this.pet = pet;
        }

        private void petImageLabel_Click(object sender, EventArgs e)
        {

        }

        private void FillPetInfo(object sender, EventArgs e)
        {
            this.petNameDetailsTitleLabel.Text = pet.Name;
            this.petTypeTextBox.Text = pet.GetType().Name;
            this.petBirthdayTimePicker.Text = pet.Birthday.ToString();
            this.petBreedTextBox.Text = pet.Breed;
            this.petColorTextBox.Text = pet.Color;
            this.petWeightTextBox.Text = pet.Weight.ToString();
            this.petMedicalHistoryTextBox.Text = pet.MedicalHistory;
            this.petStatusTextBox.Text = pet.Status.ToString();

            if (!string.IsNullOrEmpty(pet.Image) && File.Exists(pet.Image))
            {
                this.petPictureBox.BackgroundImage = Image.FromFile(pet.Image);
            }

            if (pet is Cat cat)
            {
                this.petFavoriteToyTextBox.Text = cat.FavoriteToy;
            }
            else
            {
                this.petFavoriteToyTextBox.Visible = false;
                this.petFavoriteToyLabel.Visible = false;
            }

            this.adoptPetButton.Enabled = this.pet.Status != Status.Adopted;
        }

        private void ButtonAddNewPetClick (object sender, EventArgs e)
        {
            this.pet.Status = Status.Adopted;
            this.petStatusTextBox.Text = pet.Status.ToString();

            this.adoptPetButton.Enabled = false;
        }
    }
}
