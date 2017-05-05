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
using System.Numerics;

namespace unificare
{
    public partial class frmCreateJson : Form
    {
        frmMain mainForm = new frmMain();
        public frmCreateJson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.formMain.Show();
        }

        private void frmCreateJson_Load(object sender, EventArgs e)
        {

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateJsonFile();
        }



        // user created functions
        private void CreateJsonFile()
        {
            string[] allergiesString =  txtAllergies.Text.Split(",".ToCharArray()).ToArray<string>();
            string[] chronical_diseases_String = txtChronDiseases.Text.Split(",".ToCharArray()).ToArray<string>();
            string[] vaccinesString = txtVaccines.Text.Split(",".ToCharArray()).ToArray<string>();
            string[] visitedLocationsString = txtVisCountries.Text.Split(",".ToCharArray()).ToArray<string>();
            string[] restrictedLocationString = txtResCountries.Text.Split(",".ToCharArray()).ToArray<string>();
            CreateJson createJson = new CreateJson()
            {
                id = txtID.Text.Length != 0 ? BigInteger.Parse(txtID.Text) : 0,
                cnp = txtCNP.Text.Length != 0 ? BigInteger.Parse(txtCNP.Text) : 0,
                last_name = txtLN.Text,
                first_name = txtFN.Text,
                birth_date = txtBirthD.Text,
                birth_location_country = txtBirthCountry.Text,
                birth_location_city = txtBirthCity.Text,
                living_country = txtLCountry.Text,
                living_city = txtLCity.Text,
                living_street = txtLStreet.Text,
                living_street_number = txtLStreetNumber.Text,
                living_building = txtLBuilding.Text,
                living_stair = txtLStair.Text,
                living_floor = txtLFloor.Text,
                living_apartment = txtLApartment.Text,
                living_zip_code = txtLZipCode.Text.Length != 0 ? BigInteger.Parse(txtLZipCode.Text) : 0,
                driving_license_holder = chkDriveLicense.Checked ? true : false,
                driving_license_category = txtLLicCat.Text,
                health_insurance = chkHealthInsurance.Checked ? true : false,
                medic_last_name = txtMedicLN.Text,
                medic_first_name = txtMedicFN.Text,
                medic_phone_number = txtMedicPhone.Text,
                emergency_1st_person_name = txt1EmPers.Text,
                emergency_1st_person_phone = txt1EmPersPh.Text,
                emergency_2nd_person_name = txt2EmPers.Text,
                emergency_2nd_person_phone = txt2EmPersP.Text,
                blood_type = txtBloodType.Text,
                blood_rh = txtBloodRh.Text,
                allergies = allergiesString,
                chronical_diseases = chronical_diseases_String,
                vaccines = vaccinesString,
                height = txtHeight.Text.Length !=0 ? int.Parse(txtHeight.Text) : 0,
                eyes = txtEyes.Text,
                visited_locations = visitedLocationsString,
                restricted_countries = restrictedLocationString
            };

            using (StreamWriter file = File.CreateText(txtFileName.Text + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, createJson);
            }
            this.Close();
        }
    }
}
