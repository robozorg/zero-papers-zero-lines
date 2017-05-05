using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace unificare
{
    public class CreateJson
    {
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
        public string[] allergies;
        public string[] chronical_diseases;
        public string[] vaccines;
        public int height;
        public string eyes;
        public string[] visited_locations;
        public string[] restricted_countries;
    }
}

