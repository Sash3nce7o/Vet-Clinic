namespace VetClinic
{
    partial class VetClinic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetClinic));
            titleLabel = new Label();
            listViewPets = new ListView();
            imageListPets = new ImageList(components);
            addPetButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Trebuchet MS", 48F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(499, 50);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(458, 119);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Vet Clinic";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Click += label1_Click;
            // 
            // listViewPets
            // 
            listViewPets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewPets.BackColor = Color.MediumPurple;
            listViewPets.GroupImageList = imageListPets;
            listViewPets.LargeImageList = imageListPets;
            listViewPets.Location = new Point(150, 200);
            listViewPets.Margin = new Padding(4, 5, 4, 5);
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(1184, 167);
            listViewPets.SmallImageList = imageListPets;
            listViewPets.TabIndex = 1;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.MouseClick += ListViewPetsMouseClick;
            // 
            // imageListPets
            // 
            imageListPets.ColorDepth = ColorDepth.Depth8Bit;
            imageListPets.ImageStream = (ImageListStreamer)resources.GetObject("imageListPets.ImageStream");
            imageListPets.TransparentColor = Color.Transparent;
            imageListPets.Images.SetKeyName(0, "—Pngtree—pink cute cat icon animal_8188672.png");
            imageListPets.Images.SetKeyName(1, "—Pngtree—cute little brown and white_15442724.png");
            // 
            // addPetButton
            // 
            addPetButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addPetButton.BackColor = Color.FromArgb(0, 0, 192);
            addPetButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addPetButton.ForeColor = Color.White;
            addPetButton.Location = new Point(150, 441);
            addPetButton.Margin = new Padding(4, 5, 4, 5);
            addPetButton.Name = "addPetButton";
            addPetButton.Size = new Size(1186, 78);
            addPetButton.TabIndex = 2;
            addPetButton.Text = "Add Pet +";
            addPetButton.UseMnemonic = false;
            addPetButton.UseVisualStyleBackColor = false;
            addPetButton.Click += ButtonAddNewPetClick;
            // 
            // VetClinic
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1440, 669);
            Controls.Add(addPetButton);
            Controls.Add(listViewPets);
            Controls.Add(titleLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "VetClinic";
            Text = "Vet Clinic";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private ListView listViewPets;
        private Button addPetButton;
        private ImageList imageListPets;
    }
}
