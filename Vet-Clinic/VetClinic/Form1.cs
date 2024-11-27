namespace VetClinic
{
    public partial class VetClinic : Form
    {
        private readonly List<IAnimal> pets = new()
        {
            new Cat ("Miau", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog ("BauBau", new DateTime(2016, 8, 20), "Golden Retriever", "Vaccinated", 4.5, "Golden")
        };

        public VetClinic()
        {
            InitializeComponent();
        }

        private void LoadAllPets()
        {
            this.listViewPets.Items.Clear();

            foreach (var pet in pets)
            {
                this.listViewPets.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.listViewPets.SelectedItems[0].Index];

            if (selectedPet == null) return;

            using PetDetailsForm detailsForm = new(selectedPet);
            detailsForm.ShowDialog();
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            using (AddPetForm newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }

            LoadAllPets();
        }
    }
}
