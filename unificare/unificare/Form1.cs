using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Numerics;

namespace unificare
{
    public partial class frmMain : Form
    {
        public frmMain formMain;
        public int allergiesLenght = 0;
        public int chronical_diseases_Length = 0;
        public int vaccinesLength;
        public int visited_locations_Length = 0;
        public int restricted_countries_Length = 0;
        public static bool once = true;

        public BigInteger id;
        public BigInteger cnp;
        public string last_name;
        public string first_name;
        public string birth_date;
        public string birth_location_country;
        public string birth_location_city;
        public string living_country;
        public string living_city;
        public string living_street;
        public string living_street_number;
        public string living_building;
        public string living_stair;
        public string living_floor;
        public string living_apartment;
        public BigInteger living_zip_code;
        public bool driving_license_holder;
        public string driving_license_category;
        public bool driving_license_suspended;
        public bool health_insurance;
        public string medic_last_name;
        public string medic_first_name;
        public string medic_phone_number;
        public string emergency_1st_person_name;
        public string emergency_1st_person_phone;
        public string emergency_2nd_person_name;
        public string emergency_2nd_person_phone;
        public string blood_type;
        public string blood_rh;
        public bool organ_donor;
        public string[] allergies = new string[100];
        public string[] chronical_diseases = new string[100];
        public string[] vaccines = new string[150];
        public int height;
        public string eyes;
        public string[] visited_locations = new string[1000];
        public string[] restricted_countries = new string[200];
        public string raducanu;
        public string mihai;
        public frmMain()
        {
            InitializeComponent();
            formMain = this;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadJson();
            txtShow.ReadOnly = true;

        }


        //owner created methods
        public void LoadJson()
        {
            dynamic unification = JObject.Parse(File.ReadAllText(@"example.json"));
            id = unification.id;
            cnp = unification.cnp;
            last_name = unification.last_name;
            first_name = unification.first_name;
            birth_date = unification.birth_date;
            birth_location_country = unification.birth_location_country;
            birth_location_city = unification.birth_location_city;
            living_country = unification.living_country;
            living_city = unification.living_city;
            living_street = unification.living_street;
            living_street_number = unification.living_street_number;
            living_building = unification.living_building;
            living_stair = unification.living_stair;
            living_floor = unification.living_floor;
            living_apartment = unification.living_apartment;
            living_zip_code = unification.living_zip_code;
            driving_license_holder = unification.driving_license_holder;
            driving_license_category = unification.driving_license_category;
            driving_license_suspended = unification.driving_license_suspended;
            health_insurance = unification.health_insurance;
            medic_last_name = unification.medic_last_name;
            medic_first_name = unification.medic_first_name;
            medic_phone_number = unification.medic_phone_number;
            emergency_1st_person_name = unification.emergency_1st_person_name;
            emergency_1st_person_phone = unification.emergency_1st_person_phone;
            emergency_2nd_person_name = unification.emergency_2nd_person_name;
            emergency_2nd_person_phone = unification.emergency_2nd_person_phone;
            blood_type = unification.blood_type;
            blood_rh = unification.blood_rh;
            organ_donor = unification.organ_donor;

            foreach (var item in unification.allergies)
            {
                if (unification.allergies[allergiesLenght] != null)
                {
                    allergies[allergiesLenght] = unification.allergies[allergiesLenght];
                    allergiesLenght++;  
                }
            }

            foreach (var item in unification.chronical_diseases)
            {
                if (unification.chronical_diseases[chronical_diseases_Length] != null)
                {
                    chronical_diseases[chronical_diseases_Length] = unification.chronical_diseases[chronical_diseases_Length];
                    chronical_diseases_Length++;
                }
            }

            foreach (var item in unification.vaccines)
            {
                if (unification.vaccines[vaccinesLength] != null)
                {
                    vaccines[vaccinesLength] = unification.vaccines[vaccinesLength];
                    vaccinesLength++;
                }
            }

            height = unification.height;
            eyes = unification.eyes;

            foreach (var item in unification.visited_locations)
            {
                if (unification.visited_locations[visited_locations_Length] != null)
                {
                    visited_locations[visited_locations_Length] = unification.visited_locations[visited_locations_Length];
                    visited_locations_Length++;
                }
            }
            foreach (var item in unification.restricted_countries)
                {
                    if (unification.restricted_countries[restricted_countries_Length] != null)
                    {
                        restricted_countries[restricted_countries_Length] = unification.restricted_countries[restricted_countries_Length];
                        restricted_countries_Length++;
                    }
                }
        }
        private void LoadComboBox()
        {
            cmbSelect.Items.Add("Identity");
            cmbSelect.Items.Add("Doctor");
            cmbSelect.Items.Add("Emergency");
            cmbSelect.Items.Add("Police Officer");
            cmbSelect.Items.Add("Border");
            cmbSelect.SelectedIndex = 0;
            cmbSelect.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            switch (cmbSelect.SelectedItem.ToString())
            {
                case "Identity":
                    txtShow.Text = "ID: " + id + Environment.NewLine + "CNP: " + cnp + Environment.NewLine + "Last Name: " + last_name + Environment.NewLine + "First Name: " + first_name;
                    txtShow.Text += Environment.NewLine + "Birth Date: " + birth_date + Environment.NewLine + "Birth Country: " + birth_location_country + Environment.NewLine;
                    txtShow.Text += "Birth City: " + birth_location_city + Environment.NewLine + "Living Country: " + living_country + Environment.NewLine;
                    txtShow.Text += "Living City: " + living_city + Environment.NewLine + "Adress: Street " + living_street + ", No. " + living_street_number + ", Bulding " +
                    living_building + ", Stair " + living_stair + ", Floor " + living_floor + ", Apartment " + living_apartment + ", Zip code " + living_zip_code;
                    break;
                case "Doctor":
                    txtShow.Text = "ID: " + id + Environment.NewLine + "CNP: " + cnp + Environment.NewLine + "Last Name: " + last_name + Environment.NewLine + "First Name: " + first_name;
                    txtShow.Text += Environment.NewLine + "Birth Date: " + birth_date + Environment.NewLine;
                    txtShow.Text += "Is insured: " + health_insurance + Environment.NewLine ;
                    txtShow.Text += "Blood type: " + blood_type + Environment.NewLine + "Blood RH: " + blood_rh + Environment.NewLine;
                    txtShow.Text += "Alergies: " + Environment.NewLine;
                    for(int i = 0; i < allergiesLenght; i++)
                    {
                        txtShow.Text += "     " + allergies[i] + Environment.NewLine;
                    }
                    txtShow.Text += "Chronical diseases: " + Environment.NewLine;
                    for (int i = 0; i < chronical_diseases_Length; i++)
                    {
                        txtShow.Text += "     " + chronical_diseases[i] + Environment.NewLine;
                    }
                    txtShow.Text += "Vaccines " + Environment.NewLine;
                    for (int i = 0; i < vaccinesLength; i++)
                    {
                        txtShow.Text += "     " + vaccines[i] + Environment.NewLine;
                    }
                    txtShow.Text += "Visited Locations " + Environment.NewLine;
                    for (int i = 0; i < visited_locations_Length; i += 3)
                    {
                        txtShow.Text += "     " + visited_locations[i] + Environment.NewLine;
                    }

                    break;
                case "Emergency":
                    txtShow.Text = "ID: " + id + Environment.NewLine + "CNP: " + cnp + Environment.NewLine + "Last Name: " + last_name + Environment.NewLine + "First Name: " + first_name;
                    txtShow.Text += Environment.NewLine + "Birth Date: " + birth_date + Environment.NewLine;
                    txtShow.Text += "Is insured: " + health_insurance + Environment.NewLine;
                    txtShow.Text += "Medic Name: " + medic_last_name + " " + medic_first_name + Environment.NewLine;
                    txtShow.Text += "Medic Phone number: " + medic_phone_number + Environment.NewLine;
                    txtShow.Text += "Blood type: " + blood_type + Environment.NewLine + "Blood RH: " + blood_rh + Environment.NewLine;
                    txtShow.Text += "Emergency person: " + emergency_1st_person_name + Environment.NewLine;
                    txtShow.Text += "Emergency phone: " + emergency_1st_person_phone + Environment.NewLine;
                    txtShow.Text += "Emergency person: " + emergency_2nd_person_name + Environment.NewLine;
                    txtShow.Text += "Emergency phone: " + emergency_2nd_person_phone + Environment.NewLine;
                    txtShow.Text += "Alergies: " + Environment.NewLine;
                    for (int i = 0; i < allergiesLenght; i++)
                    {
                        txtShow.Text += "     " + allergies[i] + Environment.NewLine;
                    }
                    txtShow.Text += "Chronical diseases: " + Environment.NewLine;
                    for (int i = 0; i < chronical_diseases_Length; i++)
                    {
                        txtShow.Text += "     " + chronical_diseases[i] + Environment.NewLine;
                    }
                    break;
                case "Police Officer":
                    txtShow.Text = "ID: " + id + Environment.NewLine + "CNP: " + cnp + Environment.NewLine + "Last Name: " + last_name + Environment.NewLine + "First Name: " + first_name;
                    txtShow.Text += Environment.NewLine + "Birth Date: " + birth_date + Environment.NewLine;
                    txtShow.Text += "Driving Categories: " + driving_license_category + Environment.NewLine;
                    txtShow.Text += "License Suspended: " + driving_license_suspended; 
                    break;
                case "Border":
                    txtShow.Text = "ID: " + id + Environment.NewLine + "CNP: " + cnp + Environment.NewLine + "Last Name: " + last_name + Environment.NewLine + "First Name: " + first_name;
                    txtShow.Text += Environment.NewLine + "Birth Date: " + birth_date + Environment.NewLine + "Birth Country: " + birth_location_country + Environment.NewLine;
                    txtShow.Text += "Birth City: " + birth_location_city + Environment.NewLine + "Living Country: " + living_country + Environment.NewLine;
                    txtShow.Text += "Living City: " + living_city + Environment.NewLine + "Adress: Street " + living_street + ", No. " + living_street_number + ", Bulding " +
                    living_building + ", Stair " + living_stair + ", Floor " + living_floor + ", Apartment " + living_apartment + ", Zip code " + living_zip_code + Environment.NewLine;
                    txtShow.Text += "Visited Locations " + Environment.NewLine;
                    for (int i = 0; i < visited_locations_Length; i += 3)
                    {
                        txtShow.Text += "     " + visited_locations[i] + Environment.NewLine;
                        txtShow.Text += "       Entry date: " + visited_locations[i + 1] + Environment.NewLine;
                        txtShow.Text += "       Exit date: "  + visited_locations[i + 2] + Environment.NewLine;
                    }
                    txtShow.Text += "Restricted Locations: " + Environment.NewLine;
                    for (int i = 0; i < restricted_countries_Length; i++)
                    {
                        txtShow.Text += "     " + restricted_countries[i] + Environment.NewLine;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateJson createJson = new frmCreateJson();
            createJson.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown && once == true)
            {
                return;
            }
            if (once)
            {
                once = false;
                switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
