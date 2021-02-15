using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rebalancer.Classes;

namespace Rebalancer
{
    public partial class FormStart : Form
    {
        public Household SelectedHousehold = new Household();
        private List<Household> households = new List<Household>();
        public const string HouseholdPath = "household.csv";
        public const string SettingsPath = "settings.csv";
        public const string PositionPath = "position.csv";
        public const string SecurityPath = "security.csv";
        public FormHousehold HouseholdForm;
        private string formCheckedType;
        private string formCheckedFrequency;
        private string formCheckedRotation;
        private FrequencyRadio QFreqRdo;
        private FrequencyRadio SAFreqRdo;
        private FrequencyRadio AFreqRdo;
        private FrequencyRadio OFreqRdo;
        private FrequencyRadio AllFreqRdo;
        private Dictionary<string, Security> securityDict = new Dictionary<string, Security>();

        public FormStart()
        {
            InitializeComponent();

            // Run check to make sure all of the necessary csv files are available and able to be used
            List<string> missingFile = Are_All_Files_Present();
            if (missingFile.Count > 0)
            {
                // At least one file is missing. Ask if user wants to import file(s)
                Import_Files(missingFile);
            }

            // Load all of the households
            Load_Household_List();

            // TODO Load the households' types, frequencies, and rotations
            Load_Test_Data();

            // Set the radios checked by default
            Initialize_Radios();
        }

        private List<string> Are_All_Files_Present()
        {
            // Get the list of files to look for
            List<string> neededFiles = new List<string> { HouseholdPath, SettingsPath, PositionPath, SecurityPath };

            // Return the list of files missing from the directory
            List<string> missingFiles = neededFiles.Where(file => !File.Exists(file)).ToList();
            return missingFiles;
        }

        private void Import_Files(List<string> missingFiles)
        {
            // TODO Ask if user wants to import missing file(s)
        }

        private void Load_Household_List()
        {
            // Get the data from the household csv
            households = Household.Load_List_From_CSV(HouseholdPath);
        }

        private void Load_Test_Data()
        {
            // TODO Delete this once client rotations are brought in
            foreach (Household household in households)
            {
                household.ClientType = "AUM";
                household.UpdateFrequency = "Quarterly";
                household.Rotation = "Mar/Jun/Sep/Dec";
            }
        }

        private void Initialize_Radios()
        {
            // Set the checked changed for each radio button
            foreach (GroupBox gbx in this.Controls.OfType<GroupBox>())
            {
                foreach (RadioButton rdo in gbx.Controls.OfType<RadioButton>())
                {
                    rdo.CheckedChanged += rdo_CheckChanged;
                }
            }

            // Instantiate each frequency radio
            QFreqRdo = new FrequencyRadio(this, rdoQuarterly, "Quarterly", gbxQuarterly);
            SAFreqRdo = new FrequencyRadio(this, rdoSemiAnnual, "SA", gbxSA);
            AFreqRdo = new FrequencyRadio(this, rdoAnnual, "Annual", gbxAnnual);
            OFreqRdo = new FrequencyRadio(this, rdoOther);
            AllFreqRdo = new FrequencyRadio(this, rdoAllFrequency, "Annual", gbxAnnual);

            // Set default client type of AUM
            rdoAUM.Checked = true;

            // Set default client frequency of quarterly
            QFreqRdo.FormRdo.Checked = true;

            // Set default client rotation based on the current month
            QFreqRdo.Show_Months();
        }

        private void rdo_CheckChanged(object sender, EventArgs e)
        {
            // Cast the radio button that fired the event
            RadioButton rdo = (RadioButton)sender;

            if (!rdo.Checked)
            {
                // Don't do anything if this event is fired from the radio being unchecked
                return;
            }

            // Call the method that corresponds to the checked radio button's containing group box
            if (rdo.Parent == gbxType)
            {
                Type_Changed(rdo);
            }
            else if (rdo.Parent == gbxFrequency)
            {
                Frequency_Changed(rdo);
            }
            else if (rdo.Parent == gbxQuarterly || rdo.Parent == gbxSA || rdo.Parent == gbxAnnual)
            {
                Rotation_Changed(rdo);
            }

            // Fill the combo box with households whose settings match the checked off radio buttons
            Filter_Client_List();
        }

        private void Type_Changed(RadioButton rdo)
        {
            // Change the checked type variable
            formCheckedType = rdo.Text;
        }

        private void Frequency_Changed(RadioButton rdo)
        {
            // Get the FrequencyRadio that was checked
            FrequencyRadio freqRdo = Get_Checked_Frequency_Radio(rdo);

            if (freqRdo == null)
            {
                // No frequency radio was found; do nothing
                return;
            }

            // Show the corresponding rotation group box for the checked frequency
            // and get the checked rotation radio from the visible group box
            RadioButton checkedRotation = freqRdo.Show_Months();
            formCheckedRotation = checkedRotation == null ? "" : checkedRotation.Text;

            // Change the checked frequency variable
            formCheckedFrequency = rdo.Text;
        }

        private FrequencyRadio Get_Checked_Frequency_Radio(RadioButton rdo)
        {
            // Convert the radio button to its corresponding FrequencyRadio
            if (rdo == rdoQuarterly)
            {
                return QFreqRdo;
            }
            if (rdo == rdoSemiAnnual)
            {
                return SAFreqRdo;
            }
            if (rdo == rdoAnnual)
            {
                return AFreqRdo;
            }
            if (rdo == rdoOther)
            {
                return OFreqRdo;
            }
            if (rdo == rdoAllFrequency)
            {
                return AllFreqRdo;
            }

            // Should never be null
            return null;
        }

        private void Rotation_Changed(RadioButton rdo)
        {
            // Set the checked rotation radio
            if (rdo.Parent == gbxQuarterly)
            {
                QFreqRdo.CheckedRotationRdo = rdo;
            }
            else if (rdo.Parent == gbxSA)
            {
                SAFreqRdo.CheckedRotationRdo = rdo;
            }
            else if (rdo.Parent == gbxAnnual)
            {
                AFreqRdo.CheckedRotationRdo = rdo;
                AllFreqRdo.CheckedRotationRdo = rdo;
            }

            // Change the checked rotation variable
            formCheckedRotation = rdo.Text;
        }

        private void Filter_Client_List()
        {
            // Clear the household list
            CBHouseholdList.Items.Clear();

            // Go through list of households and only show the ones that match the checked radio buttons
            foreach (Household household in households)
            {
                // Does the type match
                bool typeMatches = household.ClientType == formCheckedType || formCheckedType == "All";

                // Does the frequency match
                bool frequencyMatches = household.UpdateFrequency == formCheckedFrequency || formCheckedFrequency == "All";

                // Does the rotation match, or does the household's rotation contain the checked off month
                bool rotationMatches = household.Rotation == formCheckedRotation
                    || formCheckedFrequency == "All" && DoesRotationContainMonth(household.Rotation, formCheckedRotation);

                // Check if the radio buttons checked off on the form match the household's settings
                if (typeMatches && frequencyMatches && rotationMatches)
                {
                    // The client type, update frequency, and rotation match. Add the household to the list
                    CBHouseholdList.Items.Add(household.Description);
                }
            }
        }

        private bool DoesRotationContainMonth(string householdRotation, string formRotationMonth)
        {
            // Get the abbreviated month name from the checked off radio button
            string abbreviatedMonth = formRotationMonth.Substring(0, 3);

            // Return if the household's rotation contains the abbreviated month
            string[] splitRotation = householdRotation.Split('/');
            return splitRotation.Contains(abbreviatedMonth);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Don't do anything if there's no household selected
            if (CBHouseholdList.SelectedIndex == -1)
            {
                return;
            }

            // Get the selected household
            SelectedHousehold = households[CBHouseholdList.SelectedIndex];

            // Open the form showing the household's data
            Open_Household_Form();
        }

        private void Open_Household_Form()
        {
            // Instantiate the household form with events
            HouseholdForm = new FormHousehold(SelectedHousehold, securityDict);
            HouseholdForm.FormClosed += Household_Form_Closed;
            HouseholdForm.btnSelectNew.Click += Household_Form_Select_New;

            // Hide this form
            this.Hide();

            // Show the household form
            HouseholdForm.Show();
        }

        private void Household_Form_Closed(object sender, EventArgs e)
        {
            // When the household form is closed, close this one as well
            this.Close();
        }

        private void Household_Form_Select_New(object sender, EventArgs e)
        {
            // Reopen this form in order to select a new household
            this.Show();
            CBHouseholdList.Text = "";
            HouseholdForm.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}