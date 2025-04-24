using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    partial class Coords
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
            this.CMB_coordsystem = new MissionPlanner.Controls.MyCustomComboBox();
            this.SuspendLayout();
            // 
            // CMB_coordsystem
            // 
            this.CMB_coordsystem.ArrowColor = Color.White;
            this.CMB_coordsystem.BackColor = SystemColors.Control;
            this.CMB_coordsystem.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CMB_coordsystem.ButtonColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CMB_coordsystem.DrawMode = DrawMode.OwnerDrawFixed;
            this.CMB_coordsystem.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CMB_coordsystem.FlatStyle = FlatStyle.Flat;
            this.CMB_coordsystem.ForeColor = SystemColors.ControlText;
            this.CMB_coordsystem.FormattingEnabled = true;
            this.CMB_coordsystem.Items.AddRange(new object[] {
            "GEO",
            "UTM",
            "MGRS"});
            this.CMB_coordsystem.Location = new System.Drawing.Point(0, 2);
            this.CMB_coordsystem.Name = "CMB_coordsystem";
            this.CMB_coordsystem.Size = new System.Drawing.Size(64, 23);
            this.CMB_coordsystem.TabIndex = 0;
            this.CMB_coordsystem.SelectedIndexChanged += new System.EventHandler(this.CMB_coordsystem_SelectedIndexChanged);
            // 
            // Coords
            // 
            this.Controls.Add(this.CMB_coordsystem);
            this.Name = "Coords";
            this.Size = new System.Drawing.Size(200, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomComboBox CMB_coordsystem;
    }
}
