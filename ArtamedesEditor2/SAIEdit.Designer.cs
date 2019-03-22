namespace ArtamedesEditor2
{
    partial class SAIEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QueryText = new System.Windows.Forms.Label();
            this.SourceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.QueryOutput = new System.Windows.Forms.TextBox();
            this.SmartEventComboBox = new System.Windows.Forms.ComboBox();
            this.EventParam1 = new System.Windows.Forms.TextBox();
            this.EventParam2 = new System.Windows.Forms.TextBox();
            this.EventParam3 = new System.Windows.Forms.TextBox();
            this.EventParam4 = new System.Windows.Forms.TextBox();
            this.EventParam1_Label = new System.Windows.Forms.Label();
            this.EventParam2_Label = new System.Windows.Forms.Label();
            this.EventParam3_Label = new System.Windows.Forms.Label();
            this.EventParam4_Label = new System.Windows.Forms.Label();
            this.NewListButton = new System.Windows.Forms.Button();
            this.MasterList = new System.Windows.Forms.ComboBox();
            this.SmartActionComboBox = new System.Windows.Forms.ComboBox();
            this.Event_TypeLabel = new System.Windows.Forms.Label();
            this.eventIDManual = new System.Windows.Forms.TextBox();
            this.ActionTypeLabel = new System.Windows.Forms.Label();
            this.ActionParam2_Label = new System.Windows.Forms.Label();
            this.ActionParam1_Label = new System.Windows.Forms.Label();
            this.ActionParam2 = new System.Windows.Forms.TextBox();
            this.ActionParam1 = new System.Windows.Forms.TextBox();
            this.ActionParam4_Label = new System.Windows.Forms.Label();
            this.ActionParam3_Label = new System.Windows.Forms.Label();
            this.ActionParam4 = new System.Windows.Forms.TextBox();
            this.ActionParam3 = new System.Windows.Forms.TextBox();
            this.ActionParam6_Label = new System.Windows.Forms.Label();
            this.ActionParam5_Label = new System.Windows.Forms.Label();
            this.ActionParam6 = new System.Windows.Forms.TextBox();
            this.ActionParam5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(36, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QueryText
            // 
            this.QueryText.AutoSize = true;
            this.QueryText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryText.Location = new System.Drawing.Point(174, 47);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(0, 16);
            this.QueryText.TabIndex = 1;
            this.QueryText.Click += new System.EventHandler(this.label1_Click);
            // 
            // SourceTypeComboBox
            // 
            this.SourceTypeComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.SourceTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SourceTypeComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceTypeComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SourceTypeComboBox.FormattingEnabled = true;
            this.SourceTypeComboBox.Items.AddRange(new object[] {
            "SMART_SCRIPT_TYPE_CREATURE",
            "SMART_SCRIPT_TYPE_GAMEOBJECT",
            "SMART_SCRIPT_TYPE_AREATRIGGER",
            "SMART_SCRIPT_TYPE_EVENT",
            "SMART_SCRIPT_TYPE_QUEST",
            "SMART_SCRIPT_TYPE_SPELL",
            "SMART_SCRIPT_TYPE_TIMED_ACTIONLIST",
            "SMART_SCRIPT_TYPE_WAYPOINT"});
            this.SourceTypeComboBox.Location = new System.Drawing.Point(36, 78);
            this.SourceTypeComboBox.Name = "SourceTypeComboBox";
            this.SourceTypeComboBox.Size = new System.Drawing.Size(265, 21);
            this.SourceTypeComboBox.TabIndex = 2;
            this.SourceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // QueryOutput
            // 
            this.QueryOutput.BackColor = System.Drawing.SystemColors.Desktop;
            this.QueryOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryOutput.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryOutput.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.QueryOutput.Location = new System.Drawing.Point(12, 685);
            this.QueryOutput.Multiline = true;
            this.QueryOutput.Name = "QueryOutput";
            this.QueryOutput.Size = new System.Drawing.Size(1200, 214);
            this.QueryOutput.TabIndex = 3;
            // 
            // SmartEventComboBox
            // 
            this.SmartEventComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.SmartEventComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmartEventComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartEventComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SmartEventComboBox.FormattingEnabled = true;
            this.SmartEventComboBox.Items.AddRange(new object[] {
            "SMART_EVENT_UPDATE_IC",
            "SMART_EVENT_UPDATE_OOC",
            "SMART_EVENT_HEALT_PCT",
            "SMART_EVENT_MANA_PCT",
            "SMART_EVENT_AGGRO",
            "SMART_EVENT_KILL",
            "SMART_EVENT_DEATH",
            "SMART_EVENT_EVADE",
            "SMART_EVENT_SPELLHIT",
            "SMART_EVENT_RANGE",
            "SMART_EVENT_OOC_LOS",
            "SMART_EVENT_RESPAWN",
            "SMART_EVENT_TARGET_HEALTH_PCT",
            "SMART_EVENT_VICTIM_CASTING",
            "SMART_EVENT_FRIENDLY_HEALTH",
            "SMART_EVENT_FRIENDLY_IS_CC",
            "SMART_EVENT_FRIENDLY_MISSING_BUFF",
            "SMART_EVENT_SUMMONED_UNIT",
            "SMART_EVENT_TARGET_MANA_PCT",
            "SMART_EVENT_ACCEPTED_QUEST",
            "SMART_EVENT_REWARD_QUEST",
            "SMART_EVENT_REACHED_HOME",
            "SMART_EVENT_RECEIVE_EMOTE",
            "SMART_EVENT_HAS_AURA",
            "SMART_EVENT_TARGET_BUFFED",
            "SMART_EVENT_RESET",
            "SMART_EVENT_IC_LOS",
            "SMART_EVENT_PASSENGER_BOARDED",
            "SMART_EVENT_PASSENGER_REMOVED",
            "SMART_EVENT_CHARMED",
            "SMART_EVENT_CHARMED_TARGET",
            "SMART_EVENT_SPELLHIT_TARGET",
            "SMART_EVENT_DAMAGED",
            "SMART_EVENT_DAMAGED_TARGET",
            "SMART_EVENT_MOVEMENTINFORM",
            "SMART_EVENT_SUMMON_DESPAWNED",
            "SMART_EVENT_CORPSE_REMOVED",
            "SMART_EVENT_AI_INIT",
            "SMART_EVENT_DATA_SET",
            "SMART_EVENT_WAYPOINT_START",
            "SMART_EVENT_WAYPOINT_REACHED",
            "SMART_EVENT_AURA_APPLIED",
            "SMART_EVENT_AURA_REMOVED",
            "SMART_EVENT_AFTER_PASSENGER_REMOVED",
            "SMART_EVENT_VEHICLE_EXIT_REQUSTED",
            "SMART_EVENT_BEFORE_DEATH",
            "SMART_EVENT_AREATRIGGER_ONTRIGGER",
            "SMART_EVENT_VEHICLE_EXIT",
            "SMART_EVENT_UNUSED_48",
            "SMART_EVENT_UNUSED_49",
            "SMART_EVENT_UNUSED_50",
            "SMART_EVENT_UNUSED_51",
            "SMART_EVENT_TEXT_OVER",
            "SMART_EVENT_RECEIVE_HEAL",
            "SMART_EVENT_JUST_SUMMONED",
            "SMART_EVENT_WAYPOINT_PAUSED",
            "SMART_EVENT_WAYPOINT_RESUMED",
            "SMART_EVENT_WAYPOINT_STOPPED",
            "SMART_EVENT_WAYPOINT_ENDED",
            "SMART_EVENT_TIMED_EVENT_TRIGGERED",
            "SMART_EVENT_UPDATE",
            "SMART_EVENT_LINK",
            "SMART_EVENT_GOSSIP_SELECT",
            "SMART_EVENT_JUST_CREATED",
            "SMART_EVENT_GOSSIP_HELLO",
            "SMART_EVENT_FOLLOW_COMPLETED",
            "SMART_EVENT_DUMMY_EFFECT",
            "SMART_EVENT_IS_BEHIND_TARGET",
            "SMART_EVENT_GAME_EVENT_START",
            "SMART_EVENT_GAME_EVENT_END",
            "SMART_EVENT_GO_STATE_CHANGED",
            "SMART_EVENT_GO_EVENT_INFORM",
            "SMART_EVENT_ACTION_DONE",
            "SMART_EVENT_ON_SPELLCLICK",
            "SMART_EVENT_FRIENDLY_HEALTH_PCT",
            "SMART_EVENT_DISTANCE_CREATURE",
            "SMART_EVENT_DISTANCE_GAMEOBJECT",
            "SMART_EVENT_COUNTER_SET",
            "SMART_EVENT_DISTANCE_PLAYER",
            "SMART_EVENT_QUEST_ACCEPT",
            "SMART_EVENT_QUEST_COMPLETE",
            "SMART_EVENT_QUEST_REWARD",
            "SMART_EVENT_QUEST_FAIL",
            "SMART_EVENT_QUEST_ABANDON"});
            this.SmartEventComboBox.Location = new System.Drawing.Point(349, 78);
            this.SmartEventComboBox.Name = "SmartEventComboBox";
            this.SmartEventComboBox.Size = new System.Drawing.Size(265, 21);
            this.SmartEventComboBox.TabIndex = 4;
            this.SmartEventComboBox.SelectedIndexChanged += new System.EventHandler(this.OnSmartEventComboBoxElementSelected);
            // 
            // EventParam1
            // 
            this.EventParam1.BackColor = System.Drawing.SystemColors.Desktop;
            this.EventParam1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventParam1.Location = new System.Drawing.Point(349, 142);
            this.EventParam1.Name = "EventParam1";
            this.EventParam1.Size = new System.Drawing.Size(90, 21);
            this.EventParam1.TabIndex = 5;
            this.EventParam1.TextChanged += new System.EventHandler(this.EventParam1_TextChanged);
            // 
            // EventParam2
            // 
            this.EventParam2.BackColor = System.Drawing.SystemColors.Desktop;
            this.EventParam2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventParam2.Location = new System.Drawing.Point(524, 142);
            this.EventParam2.Name = "EventParam2";
            this.EventParam2.Size = new System.Drawing.Size(90, 21);
            this.EventParam2.TabIndex = 6;
            this.EventParam2.TextChanged += new System.EventHandler(this.EventParam2_TextChanged);
            // 
            // EventParam3
            // 
            this.EventParam3.BackColor = System.Drawing.SystemColors.Desktop;
            this.EventParam3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventParam3.Location = new System.Drawing.Point(349, 213);
            this.EventParam3.Name = "EventParam3";
            this.EventParam3.Size = new System.Drawing.Size(90, 21);
            this.EventParam3.TabIndex = 7;
            this.EventParam3.TextChanged += new System.EventHandler(this.EventParam3_TextChanged);
            // 
            // EventParam4
            // 
            this.EventParam4.BackColor = System.Drawing.SystemColors.Desktop;
            this.EventParam4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EventParam4.Location = new System.Drawing.Point(524, 213);
            this.EventParam4.Name = "EventParam4";
            this.EventParam4.Size = new System.Drawing.Size(90, 21);
            this.EventParam4.TabIndex = 8;
            this.EventParam4.TextChanged += new System.EventHandler(this.EventParam4_TextChanged);
            // 
            // EventParam1_Label
            // 
            this.EventParam1_Label.AutoSize = true;
            this.EventParam1_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.EventParam1_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam1_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EventParam1_Label.Location = new System.Drawing.Point(349, 126);
            this.EventParam1_Label.Name = "EventParam1_Label";
            this.EventParam1_Label.Size = new System.Drawing.Size(90, 13);
            this.EventParam1_Label.TabIndex = 9;
            this.EventParam1_Label.Text = "event_param1";
            // 
            // EventParam2_Label
            // 
            this.EventParam2_Label.AutoSize = true;
            this.EventParam2_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.EventParam2_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam2_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EventParam2_Label.Location = new System.Drawing.Point(524, 126);
            this.EventParam2_Label.Name = "EventParam2_Label";
            this.EventParam2_Label.Size = new System.Drawing.Size(90, 13);
            this.EventParam2_Label.TabIndex = 10;
            this.EventParam2_Label.Text = "event_param2";
            // 
            // EventParam3_Label
            // 
            this.EventParam3_Label.AutoSize = true;
            this.EventParam3_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.EventParam3_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam3_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EventParam3_Label.Location = new System.Drawing.Point(349, 197);
            this.EventParam3_Label.Name = "EventParam3_Label";
            this.EventParam3_Label.Size = new System.Drawing.Size(90, 13);
            this.EventParam3_Label.TabIndex = 11;
            this.EventParam3_Label.Text = "event_param3";
            // 
            // EventParam4_Label
            // 
            this.EventParam4_Label.AutoSize = true;
            this.EventParam4_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.EventParam4_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParam4_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.EventParam4_Label.Location = new System.Drawing.Point(524, 197);
            this.EventParam4_Label.Name = "EventParam4_Label";
            this.EventParam4_Label.Size = new System.Drawing.Size(90, 13);
            this.EventParam4_Label.TabIndex = 12;
            this.EventParam4_Label.Text = "event_param4";
            // 
            // NewListButton
            // 
            this.NewListButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewListButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewListButton.Location = new System.Drawing.Point(1555, 832);
            this.NewListButton.Name = "NewListButton";
            this.NewListButton.Size = new System.Drawing.Size(184, 67);
            this.NewListButton.TabIndex = 14;
            this.NewListButton.Text = "New Record";
            this.NewListButton.UseVisualStyleBackColor = false;
            this.NewListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MasterList
            // 
            this.MasterList.BackColor = System.Drawing.SystemColors.Desktop;
            this.MasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MasterList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterList.ForeColor = System.Drawing.SystemColors.Info;
            this.MasterList.FormattingEnabled = true;
            this.MasterList.Location = new System.Drawing.Point(1474, 78);
            this.MasterList.Name = "MasterList";
            this.MasterList.Size = new System.Drawing.Size(265, 21);
            this.MasterList.TabIndex = 15;
            this.MasterList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // SmartActionComboBox
            // 
            this.SmartActionComboBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.SmartActionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmartActionComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartActionComboBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SmartActionComboBox.FormattingEnabled = true;
            this.SmartActionComboBox.Items.AddRange(new object[] {
            "SMART_ACTION_NONE",
            "SMART_ACTION_TALK",
            "SMART_ACTION_SET_FACTION",
            "SMART_ACTION_MORPH_TO_ENTRY_OR_MODEL",
            "SMART_ACTION_SOUND",
            "SMART_ACTION_PLAY_EMOTE",
            "SMART_ACTION_FAIL_QUEST",
            "SMART_ACTION_ADD_QUEST",
            "SMART_ACTION_SET_REACT_STATE",
            "SMART_ACTION_ACTIVATE_GOBJECT",
            "SMART_ACTION_RANDOM_EMOTE",
            "SMART_ACTION_CAST",
            "SMART_ACTION_SUMMON_CREATURE",
            "SMART_ACTION_THREAT_SINGLE_PCT",
            "SMART_ACTION_THREAT_ALL_PCT",
            "SMART_ACTION_CALL_AREAEXPLOREDOREVENTHAPPENS",
            "SMART_ACTION_SET_INGAME_PHASE_GROUP",
            "SMART_ACTION_SET_EMOTE_STATE",
            "SMART_ACTION_SET_UNIT_FLAG",
            "SMART_ACTION_REMOVE_UNIT_FLAG",
            "SMART_ACTION_AUTO_ATTACK",
            "SMART_ACTION_ALLOW_COMBAT_MOVEMENT",
            "SMART_ACTION_SET_EVENT_PHASE",
            "SMART_ACTION_INC_EVENT_PHASE",
            "SMART_ACTION_EVADE",
            "SMART_ACTION_FLEE_FOR_ASSIST",
            "SMART_ACTION_CALL_GROUPEVENTHAPPENS",
            "SMART_ACTION_COMBAT_STOP",
            "SMART_ACTION_REMOVEAURASFROMSPELL",
            "SMART_ACTION_FOLLOW",
            "SMART_ACTION_RANDOM_PHASE",
            "SMART_ACTION_RANDOM_PHASE_RANGE",
            "SMART_ACTION_RESET_GOBJECT",
            "SMART_ACTION_CALL_KILLEDMONSTER",
            "SMART_ACTION_SET_INST_DATA",
            "SMART_ACTION_SET_INST_DATA64",
            "SMART_ACTION_UPDATE_TEMPLATE",
            "SMART_ACTION_DIE",
            "SMART_ACTION_SET_IN_COMBAT_WITH_ZONE",
            "SMART_ACTION_CALL_FOR_HELP",
            "SMART_ACTION_SET_SHEATH",
            "SMART_ACTION_FORCE_DESPAWN",
            "SMART_ACTION_SET_INVINCIBILITY_HP_LEVEL",
            "SMART_ACTION_MOUNT_TO_ENTRY_OR_MODEL",
            "SMART_ACTION_SET_INGAME_PHASE_ID",
            "SMART_ACTION_SET_DATA",
            "SMART_ACTION_MOVE_FORWARD",
            "SMART_ACTION_SET_VISIBILITY",
            "SMART_ACTION_SET_ACTIVE",
            "SMART_ACTION_ATTACK_START",
            "SMART_ACTION_SUMMON_GO",
            "SMART_ACTION_KILL_UNIT",
            "SMART_ACTION_ACTIVATE_TAXI",
            "SMART_ACTION_WP_START",
            "SMART_ACTION_WP_PAUSE",
            "SMART_ACTION_WP_STOP",
            "SMART_ACTION_ADD_ITEM",
            "SMART_ACTION_REMOVE_ITEM",
            "SMART_ACTION_INSTALL_AI_TEMPLATE",
            "SMART_ACTION_SET_RUN",
            "SMART_ACTION_SET_FLY",
            "SMART_ACTION_SET_SWIM",
            "SMART_ACTION_TELEPORT",
            "SMART_ACTION_SET_COUNTER",
            "SMART_ACTION_STORE_TARGET_LIST",
            "SMART_ACTION_WP_RESUME",
            "SMART_ACTION_SET_ORIENTATION",
            "SMART_ACTION_CREATE_TIMED_EVENT",
            "SMART_ACTION_PLAYMOVIE",
            "SMART_ACTION_MOVE_TO_POS",
            "SMART_ACTION_RESPAWN_TARGET",
            "SMART_ACTION_EQUIP",
            "SMART_ACTION_CLOSE_GOSSIP",
            "SMART_ACTION_TRIGGER_TIMED_EVENT",
            "SMART_ACTION_REMOVE_TIMED_EVENT",
            "SMART_ACTION_ADD_AURA",
            "SMART_ACTION_OVERRIDE_SCRIPT_BASE_OBJECT",
            "SMART_ACTION_RESET_SCRIPT_BASE_OBJECT",
            "SMART_ACTION_CALL_SCRIPT_RESET",
            "SMART_ACTION_SET_RANGED_MOVEMENT",
            "SMART_ACTION_CALL_TIMED_ACTIONLIST",
            "SMART_ACTION_SET_NPC_FLAG",
            "SMART_ACTION_ADD_NPC_FLAG",
            "SMART_ACTION_REMOVE_NPC_FLAG",
            "SMART_ACTION_SIMPLE_TALK",
            "SMART_ACTION_INVOKER_CAST",
            "SMART_ACTION_CROSS_CAST",
            "SMART_ACTION_CALL_RANDOM_TIMED_ACTIONLIST",
            "SMART_ACTION_CALL_RANDOM_RANGE_TIMED_ACTIONLIST",
            "SMART_ACTION_RANDOM_MOVE",
            "SMART_ACTION_SET_UNIT_FIELD_ANIM_TIER",
            "SMART_ACTION_REMOVE_UNIT_FIELD_ANIM_TIER",
            "SMART_ACTION_INTERRUPT_SPELL",
            "SMART_ACTION_SEND_GO_CUSTOM_ANIM",
            "SMART_ACTION_SET_STAND_STATE",
            "SMART_ACTION_APPLY_STAND_FLAGS",
            "SMART_ACTION_APPLY_STAND_MISC_FLAGS",
            "SMART_ACTION_JUMP_TO_POS",
            "SMART_ACTION_SEND_GOSSIP_MENU",
            "SMART_ACTION_GO_SET_LOOT_STATE",
            "SMART_ACTION_SEND_TARGET_TO_TARGET",
            "SMART_ACTION_SET_HOME_POS",
            "SMART_ACTION_SET_HEALTH_REGEN",
            "SMART_ACTION_SET_ROOT",
            "SMART_ACTION_SET_GO_FLAG",
            "SMART_ACTION_ADD_GO_FLAG",
            "SMART_ACTION_REMOVE_GO_FLAG",
            "SMART_ACTION_SUMMON_CREATURE_GROUP",
            "SMART_ACTION_SET_POWER",
            "SMART_ACTION_ADD_POWER",
            "SMART_ACTION_REMOVE_POWER",
            "SMART_ACTION_START_CLOSEST_WAYPOINT",
            "SMART_ACTION_PLAY_RANDOM_SOUND",
            "SMART_ACTION_DISABLE_EVADE",
            "SMART_ACTION_CALL_CASTEDCREATUREORGO",
            "SMART_ACTION_MOVE_TO_POS_FIXED_ORIENTATION",
            "SMART_ACTION_STORE_VARIABLE_DECIMAL",
            "SMART_ACTION_ATTACK_STOP",
            "SMART_ACTION_IGNORE_PATHFINDING",
            "SMART_ACTION_MOVE_VERTICALLY",
            "SMART_ACTION_MOVE_BY_PATH",
            "SMART_ACTION_SET_SPEED",
            "SMART_ACTION_SET_CORPSE_DELAY",
            "SMART_ACTION_SET_ANIM_KIT",
            "SMART_ACTION_MOVE_FALL",
            "SMART_ACTION_DISABLE_TURN",
            "SMART_ACTION_HANDLE_DOOR",
            "SMART_ACTION_PLAY_MUSIC",
            "SMART_ACTION_MOVE_CIRCLE",
            "SMART_ACTION_THREAT_SINGLE",
            "SMART_ACTION_IGNORE_EVADE",
            "SMART_ACTION_CAST_RANDOM",
            "SMART_ACTION_PLAY_ONE_SHOT_ANIM_KIT",
            "SMART_ACTION_PLAY_SPELL_VISUAL_KIT",
            "SMART_ACTION_PLAY_SPELL_VISUAL",
            "SMART_ACTION_PREVENT_EVENT_PHASE_RESET",
            "SMART_ACTION_SET_VEHICLE_ID",
            "SMART_ACTION_PLAYER_TALK",
            "SMART_ACTION_STOP_MOVEMENT",
            "SMART_ACTION_REMOVE_AURAS_BY_TYPE",
            "SMART_ACTION_OVERWRITE_INVOKER",
            "SMART_ACTION_SEND_QUEST_EVENT",
            "SMART_ACTION_CUSTOM_MOVE_BY_PATH",
            "SMART_ACTION_SET_DYNAMIC_FLAG",
            "SMART_ACTION_ADD_DYNAMIC_FLAG",
            "SMART_ACTION_REMOVE_DYNAMIC_FLAG",
            "SMART_ACTION_PAUSE_WAYPOINT_FOR_MS"});
            this.SmartActionComboBox.Location = new System.Drawing.Point(669, 78);
            this.SmartActionComboBox.Name = "SmartActionComboBox";
            this.SmartActionComboBox.Size = new System.Drawing.Size(265, 21);
            this.SmartActionComboBox.TabIndex = 16;
            this.SmartActionComboBox.SelectedIndexChanged += new System.EventHandler(this.SmartActionComboBox_SelectedIndexChanged);
            // 
            // Event_TypeLabel
            // 
            this.Event_TypeLabel.AutoSize = true;
            this.Event_TypeLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.Event_TypeLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_TypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Event_TypeLabel.Location = new System.Drawing.Point(349, 50);
            this.Event_TypeLabel.Name = "Event_TypeLabel";
            this.Event_TypeLabel.Size = new System.Drawing.Size(71, 13);
            this.Event_TypeLabel.TabIndex = 17;
            this.Event_TypeLabel.Text = "event_type";
            this.Event_TypeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // eventIDManual
            // 
            this.eventIDManual.BackColor = System.Drawing.SystemColors.Desktop;
            this.eventIDManual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventIDManual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIDManual.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.eventIDManual.Location = new System.Drawing.Point(620, 81);
            this.eventIDManual.Name = "eventIDManual";
            this.eventIDManual.Size = new System.Drawing.Size(31, 14);
            this.eventIDManual.TabIndex = 18;
            this.eventIDManual.TextChanged += new System.EventHandler(this.eventIDManual_TextChanged);
            // 
            // ActionTypeLabel
            // 
            this.ActionTypeLabel.AutoSize = true;
            this.ActionTypeLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionTypeLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionTypeLabel.Location = new System.Drawing.Point(666, 50);
            this.ActionTypeLabel.Name = "ActionTypeLabel";
            this.ActionTypeLabel.Size = new System.Drawing.Size(73, 13);
            this.ActionTypeLabel.TabIndex = 19;
            this.ActionTypeLabel.Text = "action_type";
            // 
            // ActionParam2_Label
            // 
            this.ActionParam2_Label.AutoSize = true;
            this.ActionParam2_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam2_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam2_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam2_Label.Location = new System.Drawing.Point(765, 172);
            this.ActionParam2_Label.Name = "ActionParam2_Label";
            this.ActionParam2_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam2_Label.TabIndex = 25;
            this.ActionParam2_Label.Text = "action_param2";
            // 
            // ActionParam1_Label
            // 
            this.ActionParam1_Label.AutoSize = true;
            this.ActionParam1_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam1_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam1_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam1_Label.Location = new System.Drawing.Point(765, 145);
            this.ActionParam1_Label.Name = "ActionParam1_Label";
            this.ActionParam1_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam1_Label.TabIndex = 24;
            this.ActionParam1_Label.Text = "action_param1";
            // 
            // ActionParam2
            // 
            this.ActionParam2.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam2.Location = new System.Drawing.Point(669, 169);
            this.ActionParam2.Name = "ActionParam2";
            this.ActionParam2.Size = new System.Drawing.Size(90, 21);
            this.ActionParam2.TabIndex = 21;
            // 
            // ActionParam1
            // 
            this.ActionParam1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam1.Location = new System.Drawing.Point(669, 142);
            this.ActionParam1.Name = "ActionParam1";
            this.ActionParam1.Size = new System.Drawing.Size(90, 21);
            this.ActionParam1.TabIndex = 20;
            // 
            // ActionParam4_Label
            // 
            this.ActionParam4_Label.AutoSize = true;
            this.ActionParam4_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam4_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam4_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam4_Label.Location = new System.Drawing.Point(765, 224);
            this.ActionParam4_Label.Name = "ActionParam4_Label";
            this.ActionParam4_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam4_Label.TabIndex = 29;
            this.ActionParam4_Label.Text = "action_param4";
            // 
            // ActionParam3_Label
            // 
            this.ActionParam3_Label.AutoSize = true;
            this.ActionParam3_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam3_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam3_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam3_Label.Location = new System.Drawing.Point(765, 197);
            this.ActionParam3_Label.Name = "ActionParam3_Label";
            this.ActionParam3_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam3_Label.TabIndex = 28;
            this.ActionParam3_Label.Text = "action_param3";
            // 
            // ActionParam4
            // 
            this.ActionParam4.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam4.Location = new System.Drawing.Point(669, 221);
            this.ActionParam4.Name = "ActionParam4";
            this.ActionParam4.Size = new System.Drawing.Size(90, 21);
            this.ActionParam4.TabIndex = 27;
            // 
            // ActionParam3
            // 
            this.ActionParam3.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam3.Location = new System.Drawing.Point(669, 194);
            this.ActionParam3.Name = "ActionParam3";
            this.ActionParam3.Size = new System.Drawing.Size(90, 21);
            this.ActionParam3.TabIndex = 26;
            // 
            // ActionParam6_Label
            // 
            this.ActionParam6_Label.AutoSize = true;
            this.ActionParam6_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam6_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam6_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam6_Label.Location = new System.Drawing.Point(765, 277);
            this.ActionParam6_Label.Name = "ActionParam6_Label";
            this.ActionParam6_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam6_Label.TabIndex = 33;
            this.ActionParam6_Label.Text = "action_param6";
            // 
            // ActionParam5_Label
            // 
            this.ActionParam5_Label.AutoSize = true;
            this.ActionParam5_Label.BackColor = System.Drawing.SystemColors.WindowText;
            this.ActionParam5_Label.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam5_Label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ActionParam5_Label.Location = new System.Drawing.Point(765, 250);
            this.ActionParam5_Label.Name = "ActionParam5_Label";
            this.ActionParam5_Label.Size = new System.Drawing.Size(92, 13);
            this.ActionParam5_Label.TabIndex = 32;
            this.ActionParam5_Label.Text = "action_param5";
            // 
            // ActionParam6
            // 
            this.ActionParam6.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam6.Location = new System.Drawing.Point(669, 274);
            this.ActionParam6.Name = "ActionParam6";
            this.ActionParam6.Size = new System.Drawing.Size(90, 21);
            this.ActionParam6.TabIndex = 31;
            // 
            // ActionParam5
            // 
            this.ActionParam5.BackColor = System.Drawing.SystemColors.Desktop;
            this.ActionParam5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionParam5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ActionParam5.Location = new System.Drawing.Point(669, 247);
            this.ActionParam5.Name = "ActionParam5";
            this.ActionParam5.Size = new System.Drawing.Size(90, 21);
            this.ActionParam5.TabIndex = 30;
            // 
            // SAIEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArtamedesEditor2.Properties.Resources.videoblocks_realistic_looping_dark_underwater_background_animation_r0mrnic6oz_thumbnail_full01;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ActionParam6_Label);
            this.Controls.Add(this.ActionParam5_Label);
            this.Controls.Add(this.ActionParam6);
            this.Controls.Add(this.ActionParam5);
            this.Controls.Add(this.ActionParam4_Label);
            this.Controls.Add(this.ActionParam3_Label);
            this.Controls.Add(this.ActionParam4);
            this.Controls.Add(this.ActionParam3);
            this.Controls.Add(this.ActionParam2_Label);
            this.Controls.Add(this.ActionParam1_Label);
            this.Controls.Add(this.ActionParam2);
            this.Controls.Add(this.ActionParam1);
            this.Controls.Add(this.ActionTypeLabel);
            this.Controls.Add(this.eventIDManual);
            this.Controls.Add(this.Event_TypeLabel);
            this.Controls.Add(this.SmartActionComboBox);
            this.Controls.Add(this.MasterList);
            this.Controls.Add(this.NewListButton);
            this.Controls.Add(this.EventParam4_Label);
            this.Controls.Add(this.EventParam3_Label);
            this.Controls.Add(this.EventParam2_Label);
            this.Controls.Add(this.EventParam1_Label);
            this.Controls.Add(this.EventParam4);
            this.Controls.Add(this.EventParam3);
            this.Controls.Add(this.EventParam2);
            this.Controls.Add(this.EventParam1);
            this.Controls.Add(this.SmartEventComboBox);
            this.Controls.Add(this.QueryOutput);
            this.Controls.Add(this.SourceTypeComboBox);
            this.Controls.Add(this.QueryText);
            this.Controls.Add(this.textBox1);
            this.Name = "SAIEdit";
            this.Text = "SAIEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label QueryText;
        private System.Windows.Forms.ComboBox SourceTypeComboBox;
        private System.Windows.Forms.TextBox QueryOutput;
        private System.Windows.Forms.ComboBox SmartEventComboBox;
        private System.Windows.Forms.TextBox EventParam1;
        private System.Windows.Forms.TextBox EventParam2;
        private System.Windows.Forms.TextBox EventParam3;
        private System.Windows.Forms.TextBox EventParam4;
        private System.Windows.Forms.Label EventParam1_Label;
        private System.Windows.Forms.Label EventParam2_Label;
        private System.Windows.Forms.Label EventParam3_Label;
        private System.Windows.Forms.Label EventParam4_Label;
        private System.Windows.Forms.Button NewListButton;
        private System.Windows.Forms.ComboBox MasterList;
        private System.Windows.Forms.ComboBox SmartActionComboBox;
        private System.Windows.Forms.Label Event_TypeLabel;
        private System.Windows.Forms.TextBox eventIDManual;
        private System.Windows.Forms.Label ActionTypeLabel;
        private System.Windows.Forms.Label ActionParam2_Label;
        private System.Windows.Forms.Label ActionParam1_Label;
        private System.Windows.Forms.TextBox ActionParam2;
        private System.Windows.Forms.TextBox ActionParam1;
        private System.Windows.Forms.Label ActionParam4_Label;
        private System.Windows.Forms.Label ActionParam3_Label;
        private System.Windows.Forms.TextBox ActionParam4;
        private System.Windows.Forms.TextBox ActionParam3;
        private System.Windows.Forms.Label ActionParam6_Label;
        private System.Windows.Forms.Label ActionParam5_Label;
        private System.Windows.Forms.TextBox ActionParam6;
        private System.Windows.Forms.TextBox ActionParam5;
    }
}