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
    public partial class ScriptCreator : Form
    {
        public ScriptCreator()
        {
            InitializeComponent();
            Type.SelectedIndex = 0; ///< Default to ScriptedAI
            Output.ScrollBars = ScrollBars.Both;
            Output.WordWrap = false;
        }

        public string GetTypeSelectedIndexText()
        {
            switch(Type.SelectedIndex)
            {
                case 0: return "ScriptedAI";
                case 1: return "InstanceScript";
                case 2: return "CreatureScript";
                case 3: return "SpellScript";
                case 4: return "AuraScript";
            }

            return "";
        }

        public string GetTypeSelectedIndexTextType()
        {
            switch (Type.SelectedIndex)
            {
                case 0: return "npc_";
                case 1: return "";
                case 2: return "";
                case 3: return "";
                case 4: return "";
            }

            return "";
        }

        public string ScriptNameParser(string p_Name)
        {
            string l_Result = p_Name.ToLower();

            l_Result = l_Result.Replace(" ", "_");

            return l_Result;
        }

        public string FunctionCreator(string p_Type)
        {
            string l_Result = "";

            /// Add new line before send function
            l_Result += "        " + Environment.NewLine;

            switch (p_Type)
            {
                case "Reset":
                    l_Result += "        /// Called when creature Resets (after evade or on spawn)" + Environment.NewLine;
                    l_Result += "        void Reset() override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "EnterCombat":
                    l_Result += "        /// Called when creature enters combat with p_Who" + Environment.NewLine;
                    l_Result += "        /// @p_Who - Unit who entered combat with this creature" + Environment.NewLine;
                    l_Result += "        void EnterCombat(Unit* p_Who) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "ExecuteEvent":
                    l_Result += "        /// Called when an event is ready to be executed in the EventMap" + Environment.NewLine;
                    l_Result += "        /// @p_EventID - EventID ready to be executed" + Environment.NewLine;
                    l_Result += "        void ExecuteEvent(uint32 const p_EventID) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "DamageTaken":
                    l_Result += "        /// Called when creature takes damage" + Environment.NewLine;
                    l_Result += "        /// @p_Attacker - Unit who did damage" + Environment.NewLine;
                    l_Result += "        /// @p_Damage - Damage Taken" + Environment.NewLine;
                    l_Result += "        void DamageTaken(Unit* p_Attacker, uint32 &p_Damage) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "KilledUnit":
                    l_Result += "        /// Called when creature kills a unit" + Environment.NewLine;
                    l_Result += "        /// @p_Victim - Unit who was killed" + Environment.NewLine;
                    l_Result += "        void KilledUnit(Unit* p_Victim) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "JustDied":
                    l_Result += "        /// Called when creature just got killed" + Environment.NewLine;
                    l_Result += "        /// @p_Who - Unit who killed the creature" + Environment.NewLine;
                    l_Result += "        void JustDied(Unit* p_Who) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "JustSummoned":
                    l_Result += "        /// Called when creature successfully summons another creature" + Environment.NewLine;
                    l_Result += "        /// @p_Summon - Summoned" + Environment.NewLine;
                    l_Result += "        void JustSummoned(Creature* p_Summon) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;

                case "SpellHit":
                    l_Result += "        /// Called when creature is hit by a spell" + Environment.NewLine;
                    l_Result += "        /// @p_Attacker - Unit who used the spell" + Environment.NewLine;
                    l_Result += "        /// @p_SpellInfo - Spell info of the spell" + Environment.NewLine;
                    l_Result += "        void SpellHit(Unit* /*p_Attacker*/, SpellInfo const* /*p_SpellInfo*/) override" + Environment.NewLine;
                    l_Result += "        {" + Environment.NewLine;
                    l_Result += "        " + Environment.NewLine;
                    l_Result += "        }" + Environment.NewLine;
                    break;
            }
            
            /// Return result
            return l_Result;
        }

        public void UpdateOutput()
        {
            /// Don't process no name
            if (Name.Text == "")
                return;

            /// Clear output
            Output.Text = "";

            string l_Class = GetTypeSelectedIndexText();
            string l_ScriptName = GetTypeSelectedIndexTextType() + ScriptNameParser(Name.Text);

            switch (Type.SelectedIndex)
            {
                case 0: ///< ScriptedAI
                    {

                        Output.Text += "/// " + Name.Text + ": " + Entry.Text + Environment.NewLine;
                        Output.Text += "struct " + l_ScriptName + " : public " + l_Class + Environment.NewLine;
                        Output.Text += "{" + Environment.NewLine;
                        Output.Text += "    public:" + Environment.NewLine;
                        Output.Text += "        " + l_ScriptName + "(Creature* p_Creature)" + " : " + l_Class + "(p_Creature) { }" + Environment.NewLine;
                        Output.Text += FunctionCreator("Reset");
                        Output.Text += FunctionCreator("EnterCombat");
                        Output.Text += FunctionCreator("ExecuteEvent");
                        Output.Text += FunctionCreator("DamageTaken");
                        Output.Text += FunctionCreator("SpellHit");
                        Output.Text += FunctionCreator("KilledUnit");
                        Output.Text += FunctionCreator("JustDied");
                        Output.Text += FunctionCreator("JustSummoned");
                        Output.Text += "        " + Environment.NewLine;
                        Output.Text += "    private:" + Environment.NewLine;
                        Output.Text += "        /// Private variables" + Environment.NewLine;
                        Output.Text += "};" + Environment.NewLine;
                    }
                    break;
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void Entry_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }
    }
}
