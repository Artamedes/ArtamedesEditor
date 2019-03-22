using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtamedesEditor2
{
    public partial class SAIEdit : Form
    {

        public class SAIData
        {
            public int   ID;
            public int   Link;
            public int   EventType;
            public int   EventPhaseMask;
            public int   EventChance;
            public int   EventFlags;
            public int   EventParams1 { get; set; }
            public int   EventParams2 { get; set; }
            public int   EventParams3 { get; set; }
            public int   EventParams4 { get; set; }
            public int   ActionType;
            public int   ActionParam1;
            public int   ActionParam2;
            public int   ActionParam3;
            public int   ActionParam4;
            public int   ActionParam5;
            public int   ActionParam6;
            public int   TargetType;
            public int   TargetParam1;
            public int   TargetParam2;
            public int   TargetParam3;
            public float  TargetX;
            public float  TargetY;
            public float  TargetZ;
            public float  TargetO;
            public string Comment;
        };

        List<SAIData> m_SAIList;
        int m_CurrentlySelectedID;

        public SAIEdit()
        {
            InitializeComponent();

            m_SAIList = new List<SAIData>();
            m_SAIList.Add(new SAIData());

            m_CurrentlySelectedID = 0;

            Reset();
            UpdateMasterList();
        }

        public void Reset()
        {
            textBox1.Text = "548";
            SourceTypeComboBox.SelectedIndex = 0;
            SmartEventComboBox.SelectedIndex = 0;
            SmartActionComboBox.SelectedIndex = 0;
        }

        public uint GetSmartScriptType()
        {
            switch(SourceTypeComboBox.SelectedIndex)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return 2;
                case 3: return 3;
                case 4: return 5;
                case 5: return 6;
                case 6: return 9;
                case 7: return 10;
            }

            return 0;
        }

        public string GenerateEventTypeString(int p_EventType)
        {
            switch(p_EventType)
            {
                case 0:
                    return "OnUpdate (In Combat)";
                case 1:
                    return "OnUpdate (Out of Combat Combat)";
                case 2:
                    return "OnHealthPct";
                case 3:
                    return "OnManaPct";
                case 4:
                    return "OnAggro";
                case 5:
                    return "OnKill";
                case 6:
                    return "OnDeath";
                case 7:
                    return "OnEvade";
                case 8:
                    return "OnSpellHit";
                case 9:
                    return "OnTargetInRange";
                case 10:
                    return "OnTargetInDistance (Out of Combat)";
                case 11:
                    return "On Respawn";
                case 12:
                    return "On Target Health Pct";
                case 13:
                    return "On Target Casting Spell";
                case 14:
                    return "On Friendly Health Deficit";
                case 15:
                    return "On Friendly Is CC";
                case 16:
                    return "On Friendly Lost Buff";
                case 17:
                    return "On Summoned Unit";
                case 18:
                    return "On Target Mana Percentage";
                case 19:
                    return "On Target Accepted Quest";
                case 20:
                    return "On Target Rewarded Quest";
                case 21:
                    return "On Creature Reached Home";
                case 22:
                    return "On Recieve Emote";
            }

            return "Unknown";
        }

        public string GenerateComment(SAIData p_Data)
        {
            string l_Comment = "";

            l_Comment += GenerateEventTypeString(p_Data.EventType);

            return "'" + l_Comment + "'";
        }

        public void GenerateSQL()
        {
            try
            {
                int l_EntryOrGUID = Convert.ToInt32(QueryText.Text);
                uint l_SourceType = GetSmartScriptType();

                QueryOutput.Text = "-- " + Environment.NewLine +
                    "DELETE FROM `smart_scripts` WHERE `entryorguid` = " + l_EntryOrGUID + " AND `source_type` = " + l_SourceType + ";" + Environment.NewLine;

                QueryOutput.Text +=
                    "INSERT INTO `smart_scripts` (`entryorguid`, `source_type`, `id`, `link`, `event_type`, `event_phase_mask`, `event_chance`, `event_flags`, `event_param1`, `event_param2`, `event_param3`, `event_param4`, " +
                                                 "`action_type`, `action_param1`, `action_param2`, `action_param3`, `action_param4`, `action_param5`, `action_param6`, " +
                                                 "`target_type`, `target_param1`, `target_param2`, `target_param3`, `target_x`, `target_y`, `target_z`, `target_o`, `comment`) VALUES " + Environment.NewLine + Environment.NewLine;

                int l_Count = 0;
                int l_Max = m_SAIList.Count;

                foreach (SAIData l_Data in m_SAIList)
                {
                    QueryOutput.Text +=
                        "("
                        + l_EntryOrGUID + ", "
                        + l_SourceType + ", "
                        + l_Data.ID + ", "
                        + l_Data.Link + ", "
                        + l_Data.EventType + ", "
                        + l_Data.EventPhaseMask + ", "
                        + l_Data.EventChance + ", "
                        + l_Data.EventFlags + ", "
                        + l_Data.EventParams1 + ", "
                        + l_Data.EventParams2 + ", "
                        + l_Data.EventParams3 + ", "
                        + l_Data.EventParams4 + ", "
                        + l_Data.ActionType + ", "
                        + l_Data.ActionParam1 + ", "
                        + l_Data.ActionParam2 + ", "
                        + l_Data.ActionParam3 + ", "
                        + l_Data.ActionParam4 + ", "
                        + l_Data.ActionParam5 + ", "
                        + l_Data.ActionParam6 + ", "
                        + l_Data.TargetType + ", "
                        + l_Data.TargetParam1 + ", "
                        + l_Data.TargetParam2 + ", "
                        + l_Data.TargetParam3 + ", "
                        + l_Data.TargetX + ", "
                        + l_Data.TargetY + ", "
                        + l_Data.TargetZ + ", "
                        + l_Data.TargetO + ", "
                        + GenerateComment(l_Data);

                    if(++l_Count < l_Max)
                        QueryOutput.Text += ")," + Environment.NewLine;
                    else
                        QueryOutput.Text += ");" + Environment.NewLine;
                }
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object p_Sender, EventArgs p_EventArgs)
        {
            TextBox l_TextBox = (TextBox)p_Sender;
            string l_Text = l_TextBox.Text;

            QueryText.Text = l_Text;

            GenerateSQL();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GenerateSQL();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateSQL();
        }

        private void UpdateEventParamLabels(int p_EventID)
        {
            /// Default labels
            EventParam1_Label.Text = "Event Param 1";
            EventParam2_Label.Text = "Event Param 2";
            EventParam3_Label.Text = "Event Param 3";
            EventParam4_Label.Text = "Event Param 4";

            switch (p_EventID)
            {
                case 0:
                case 1:
                    EventParam1_Label.Text = "InitialMin";
                    EventParam2_Label.Text = "InitialMax";
                    EventParam3_Label.Text = "RepeatMin";
                    EventParam4_Label.Text = "RepeatMax";
                    break;

                case 2:
                    EventParam1_Label.Text = "HPMin%";
                    EventParam2_Label.Text = "HPMax%";
                    EventParam3_Label.Text = "RepeatMin";
                    EventParam4_Label.Text = "RepeatMax";
                    break;

                case 3:
                    EventParam1_Label.Text = "ManaMin%";
                    EventParam2_Label.Text = "ManaMax%";
                    EventParam3_Label.Text = "RepeatMin";
                    EventParam4_Label.Text = "RepeatMax";
                    break;
            }
        }

        private void OnSmartEventComboBoxElementSelected(object sender, EventArgs e)
        {
            m_SAIList[m_CurrentlySelectedID].EventType = SmartEventComboBox.SelectedIndex;
            UpdateEventParamLabels(SmartEventComboBox.SelectedIndex);
            GenerateSQL();
        }

        private void EventParam1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_SAIList[m_CurrentlySelectedID].EventParams1 = Convert.ToInt32(EventParam1.Text);

                GenerateSQL();
            }
            catch
            {

            }
        }

        private void EventParam2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_SAIList[m_CurrentlySelectedID].EventParams2 = Convert.ToInt32(EventParam2.Text);

                GenerateSQL();
            }
            catch
            {

            }
        }

        private void EventParam3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_SAIList[m_CurrentlySelectedID].EventParams3 = Convert.ToInt32(EventParam3.Text);

                GenerateSQL();
            }
            catch
            {

            }
        }

        private void EventParam4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m_SAIList[m_CurrentlySelectedID].EventParams4 = Convert.ToInt32(EventParam4.Text);

                GenerateSQL();
            }
            catch
            {

            }
        }
        
        private void UpdateMasterList()
        {
            int l_NewIndex = MasterList.Items.Add("Viewing: " + (m_SAIList.Count() - 1));
            MasterList.SelectedIndex = l_NewIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_SAIList.Add(new SAIData());
            UpdateMasterList();
            GenerateSQL();
        }

        private void UpdateAllElementsAtSAIListIndex(int p_Index)
        {
            m_CurrentlySelectedID = p_Index;
            
            SmartEventComboBox.SelectedIndex = m_SAIList[m_CurrentlySelectedID].EventType;
            EventParam1.Text = m_SAIList[p_Index].EventParams1.ToString();
            EventParam2.Text = m_SAIList[p_Index].EventParams2.ToString();
            EventParam3.Text = m_SAIList[p_Index].EventParams3.ToString();
            EventParam4.Text = m_SAIList[p_Index].EventParams4.ToString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateAllElementsAtSAIListIndex(MasterList.SelectedIndex);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void eventIDManual_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int l_Index = Convert.ToInt32(eventIDManual.Text);

                if (l_Index > 0)
                {
                    SmartEventComboBox.SelectedIndex = l_Index;
                    m_SAIList[m_CurrentlySelectedID].EventType = l_Index;
                    UpdateEventParamLabels(l_Index);
                    GenerateSQL();
                }
            }
            catch
            {

            }
        }

        private void SmartActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SAIList[m_CurrentlySelectedID].ActionType = SmartActionComboBox.SelectedIndex;
            GenerateSQL();
        }
    }
}
