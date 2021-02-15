using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebalancer.Classes
{
    class FrequencyRadio
    {
        public FormStart ContainingForm;
        public RadioButton FormRdo;
        public GroupBox FormRotationGbx;
        public string Frequency;
        public RadioButton CheckedRotationRdo;

        public FrequencyRadio(FormStart frm, RadioButton rdo, string freq, GroupBox gbx)
        {
            ContainingForm = frm;
            FormRdo = rdo;
            Frequency = freq;
            FormRotationGbx = gbx;
        }

        public FrequencyRadio(FormStart frm, RadioButton rdo)
        {
            ContainingForm = frm;
            FormRdo = rdo;
        }

        public int NumOfMonths
        {
            get
            {
                if (Frequency == "Quarterly")
                {
                    return 3;
                }

                if (Frequency == "SA")
                {
                    return 6;
                }

                if (Frequency == "Annual")
                {
                    return 12;
                }

                return 0;
            }
        }

        public RadioButton Show_Months()
        {
            // Show the corresponding rotation group box depending on which frequency was checked
            List<GroupBox> rotationGroupBoxes = new List<GroupBox>()
                {ContainingForm.gbxQuarterly, ContainingForm.gbxSA, ContainingForm.gbxAnnual};
            foreach (GroupBox gbx in rotationGroupBoxes)
            {
                if (gbx == FormRotationGbx)
                {
                    gbx.Visible = true;
                }
                else
                {
                    gbx.Visible = false;
                }
            }

            // If the rotation hasn't been checked already, check off the rotation's month based on the current month
            if (CheckedRotationRdo == null)
            {
                Set_Rotation_Month();
            }

            // Return the selected rotation radio
            return CheckedRotationRdo;
        }

        private void Set_Rotation_Month()
        {
            // Check the radio in the Rotation group box that corresponds to the current month and checked frequency
            int month = DateTime.Today.Month;
            for (int i = 1; i <= NumOfMonths; i++)
            {
                if ((month - i) % 3 == 0)
                {
                    RadioButton rdoRotation = (RadioButton)FormRotationGbx.Controls["rdo" + Frequency + i];
                    rdoRotation.Checked = true;
                }
            }
        }
    }
}
