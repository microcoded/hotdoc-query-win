using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;

namespace hotdoc_query_win
{
    public partial class Form1 : Form
    {
        int radio = 0;
        bool stop = true;
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void postcodeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't a non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Suburb: " + suburbInput.Text);
            Debug.WriteLine("State: " + stateBox.Text);
            if (postcodeInput.Text != "") { System.Diagnostics.Debug.WriteLine("Postcode: " + Int32.Parse(postcodeInput.Text)); }
            Debug.WriteLine("Vaccine: " + vaccineBox.Text);
            Debug.WriteLine("Dose: " + radio);
            Debug.WriteLine("Availability: " + availabilityBox.Text);

            stop = false;
            counter = 0;

            // Begin conversion from main.py

            int sleeptime = 60 * 1000;

            // Get info from user
            string suburb = suburbInput.Text.ToLower().Replace(" ", "-");
            string state = stateBox.Text.ToUpper();
            int postcode = 0;
            if (postcodeInput.Text != "") { postcode = Int32.Parse(postcodeInput.Text); }
            string type = vaccineBox.Text;

            if (type == "AstraZeneca (above 60)") {
                type = "covid_vaccine-astrazeneca_60_plus,";
            } else if (type == "AstraZeneca (below 60)")
            {
                type = "covid_vaccine-astrazeneca_under_60,";
            } else if (type == "Pfizer")
            {
                type = "covid_vaccine-pfizer,";
            } else
            {
                type = "";
            }

            int dose = radio;
            string availability = availabilityBox.Text;

            if (availability == "Today")
            {
                availability = "today";
            }
            else if (availability == "Next 7 days")
            {
                availability = "next_7_days";
            }
            else if (availability == "Next 14 days")
            {
                availability = "next_14_days";
            }
            else if (availability == "Next 30 days")
            {
                availability = "next_30_days";
            }

            // Loop through API unless stop button pressed

            //while (true && stop == false) {
            // Requesting from API in a super weird way because this is C# and Windows. At least this library sorta helps.

            var client = new RestClient("https://www.hotdoc.com.au/api/");
                var request = new RestRequest("patient/search")
                    .AddHeader("accept", "application/au.com.hotdoc.v5")
                    .AddParameter("entities", "clinics")
                    .AddParameter("filters", $"{type}covid_vaccine_dose-{dose},covid_vaccine_availability-{availability}")
                    .AddParameter("suburb", $"{suburb}-{state}-{postcode}");

                // Get response from server
                var response = client.Get(request);
                Debug.WriteLine(response.Content);
                var apiResponse = new JsonSerializer().Deserialize<Rootobject>(response);


            

            // Every clinic
            foreach (var clinic in apiResponse.clinics)
            {
                Debug.WriteLine($"{clinic.name} is available!");
                counter++;

                
            }

            if (counter == 0)
            {
                Debug.WriteLine("None found");
            }


            // URL for user
            string user_url = $"https://www.hotdoc.com.au/search?filters={type}covid_vaccine_dose-{dose}%2Ccovid_vaccine_availability-{availability}&in={suburb}-{state}-{postcode}&purpose=covid-vaccine";
            Debug.WriteLine(user_url);
                

            //}

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
  
}
