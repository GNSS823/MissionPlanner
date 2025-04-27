namespace MissionPlanner.Controls
{
    partial class ConnectionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionControl));
            this.cmb_Baud = new MissionPlanner.Controls.MyCustomComboBox();
            this.cmb_Connection = new MissionPlanner.Controls.MyCustomComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmb_sysid = new MissionPlanner.Controls.MyCustomComboBox();
            this.SuspendLayout();
            // 
            // cmb_Baud
            // 
            resources.ApplyResources(this.cmb_Baud, "cmb_Baud");
            this.cmb_Baud.ArrowColor = System.Drawing.Color.Empty;
            this.cmb_Baud.BackColor = System.Drawing.Color.Black;
            this.cmb_Baud.BGGradBot = System.Drawing.Color.Empty;
            this.cmb_Baud.BGGradTop = System.Drawing.Color.Empty;
            this.cmb_Baud.BorderColor = System.Drawing.Color.Empty;
            this.cmb_Baud.ButtonColor = System.Drawing.Color.Empty;
            this.cmb_Baud.ButtonGradBot = System.Drawing.Color.Empty;
            this.cmb_Baud.ButtonGradTop = System.Drawing.Color.Empty;
            this.cmb_Baud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Baud.DropDownWidth = 110;
            this.cmb_Baud.ForeColor = System.Drawing.Color.White;
            this.cmb_Baud.Items.AddRange(new object[] {
            resources.GetString("cmb_Baud.Items"),
            resources.GetString("cmb_Baud.Items1"),
            resources.GetString("cmb_Baud.Items2"),
            resources.GetString("cmb_Baud.Items3"),
            resources.GetString("cmb_Baud.Items4"),
            resources.GetString("cmb_Baud.Items5"),
            resources.GetString("cmb_Baud.Items6"),
            resources.GetString("cmb_Baud.Items7"),
            resources.GetString("cmb_Baud.Items8"),
            resources.GetString("cmb_Baud.Items9"),
            resources.GetString("cmb_Baud.Items10"),
            resources.GetString("cmb_Baud.Items11"),
            resources.GetString("cmb_Baud.Items12"),
            resources.GetString("cmb_Baud.Items13"),
            resources.GetString("cmb_Baud.Items14"),
            resources.GetString("cmb_Baud.Items15")});
            this.cmb_Baud.Name = "cmb_Baud";
            // 
            // cmb_Connection
            // 
            this.cmb_Connection.ArrowColor = System.Drawing.Color.Empty;
            this.cmb_Connection.BackColor = System.Drawing.Color.Black;
            this.cmb_Connection.BGGradBot = System.Drawing.Color.Empty;
            this.cmb_Connection.BGGradTop = System.Drawing.Color.Empty;
            this.cmb_Connection.BorderColor = System.Drawing.Color.Empty;
            this.cmb_Connection.ButtonColor = System.Drawing.Color.Empty;
            this.cmb_Connection.ButtonGradBot = System.Drawing.Color.Empty;
            this.cmb_Connection.ButtonGradTop = System.Drawing.Color.Empty;
            this.cmb_Connection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Connection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Connection.DropDownWidth = 230;
            resources.ApplyResources(this.cmb_Connection, "cmb_Connection");
            this.cmb_Connection.ForeColor = System.Drawing.Color.White;
            this.cmb_Connection.FormattingEnabled = true;
            this.cmb_Connection.Name = "cmb_Connection";
            this.cmb_Connection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_Connection_DrawItem);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // cmb_sysid
            // 
            resources.ApplyResources(this.cmb_sysid, "cmb_sysid");
            this.cmb_sysid.ArrowColor = System.Drawing.Color.Empty;
            this.cmb_sysid.BackColor = System.Drawing.Color.Black;
            this.cmb_sysid.BGGradBot = System.Drawing.Color.Empty;
            this.cmb_sysid.BGGradTop = System.Drawing.Color.Empty;
            this.cmb_sysid.BorderColor = System.Drawing.Color.Empty;
            this.cmb_sysid.ButtonColor = System.Drawing.Color.Empty;
            this.cmb_sysid.ButtonGradBot = System.Drawing.Color.Empty;
            this.cmb_sysid.ButtonGradTop = System.Drawing.Color.Empty;
            this.cmb_sysid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_sysid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sysid.DropDownWidth = 200;
            this.cmb_sysid.ForeColor = System.Drawing.Color.White;
            this.cmb_sysid.FormattingEnabled = true;
            this.cmb_sysid.Name = "cmb_sysid";
            this.cmb_sysid.SelectedIndexChanged += new System.EventHandler(this.CMB_sysid_SelectedIndexChanged);
            this.cmb_sysid.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmb_sysid_Format);
            // 
            // ConnectionControl
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.Controls.Add(this.cmb_sysid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmb_Connection);
            this.Controls.Add(this.cmb_Baud);
            resources.ApplyResources(this, "$this");
            this.Name = "ConnectionControl";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectionControl_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomComboBox cmb_Baud;
        private MyCustomComboBox cmb_Connection;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public MyCustomComboBox cmb_sysid;
    }
}
