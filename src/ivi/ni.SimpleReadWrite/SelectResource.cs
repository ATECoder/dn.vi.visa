using System.Globalization;
using System.Windows.Forms;
using Ivi.Visa;
using System.ComponentModel;
using System.Collections.Generic;

namespace Ivi.NI.SimpleReadWrite
{
    /// <summary>
    /// Summary description for SelectResource.
    /// </summary>
    public class SelectResource : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ListBox _availableResourcesListBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.TextBox _visaResourceNameTextBox;
        private System.Windows.Forms.Label _availableResourcesLabel;
        private System.Windows.Forms.Label _resourceStringLabel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container _components = null;

        public SelectResource()
        {
            //
            // Required for Windows Form Designer support
            //
            this.InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                if ( this._components != null )
                {
                    this._components.Dispose();
                }
                if ( this._availableResourcesListBox != null )
                {
                    this._availableResourcesListBox.Dispose();
                }
                if ( this._okButton != null )
                {
                    this._okButton.Dispose();
                }
                if ( this._closeButton != null )
                {
                    this._closeButton.Dispose();
                }
                if ( this._visaResourceNameTextBox != null )
                {
                    this._visaResourceNameTextBox.Dispose();
                }
                if ( this._availableResourcesLabel != null )
                {
                    this._availableResourcesLabel.Dispose();
                }
                if ( this._resourceStringLabel != null )
                {
                    this._resourceStringLabel.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager( typeof( SelectResource ) );
            this._availableResourcesListBox = new System.Windows.Forms.ListBox();
            this._okButton = new System.Windows.Forms.Button();
            this._closeButton = new System.Windows.Forms.Button();
            this._visaResourceNameTextBox = new System.Windows.Forms.TextBox();
            this._availableResourcesLabel = new System.Windows.Forms.Label();
            this._resourceStringLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // _availableResourcesListBox
            //
            this._availableResourcesListBox.Anchor = (( System.Windows.Forms.AnchorStyles ) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this._availableResourcesListBox.Location = new System.Drawing.Point( 5, 18 );
            this._availableResourcesListBox.Name = "_availableResourcesListBox";
            this._availableResourcesListBox.Size = new System.Drawing.Size( 282, 108 );
            this._availableResourcesListBox.TabIndex = 0;
            this._availableResourcesListBox.DoubleClick += new System.EventHandler( this.AvailableResourcesListBox_DoubleClick );
            this._availableResourcesListBox.SelectedIndexChanged += new System.EventHandler( this.AvailableResourcesListBox_SelectedIndexChanged );
            //
            // _okButton
            //
            this._okButton.Anchor = (( System.Windows.Forms.AnchorStyles ) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point( 5, 187 );
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size( 77, 25 );
            this._okButton.TabIndex = 2;
            this._okButton.Text = "OK";
            //
            // _closeButton
            //
            this._closeButton.Anchor = (( System.Windows.Forms.AnchorStyles ) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Location = new System.Drawing.Point( 82, 187 );
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size( 77, 25 );
            this._closeButton.TabIndex = 3;
            this._closeButton.Text = "Cancel";
            //
            // _visaResourceNameTextBox
            //
            this._visaResourceNameTextBox.Anchor = (( System.Windows.Forms.AnchorStyles ) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this._visaResourceNameTextBox.Location = new System.Drawing.Point( 5, 157 );
            this._visaResourceNameTextBox.Name = "_visaResourceNameTextBox";
            this._visaResourceNameTextBox.Size = new System.Drawing.Size( 282, 20 );
            this._visaResourceNameTextBox.TabIndex = 4;
            this._visaResourceNameTextBox.Text = "GPIB0::2::INSTR";
            //
            // _availableResourcesLabel
            //
            this._availableResourcesLabel.Anchor = (( System.Windows.Forms.AnchorStyles ) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this._availableResourcesLabel.Location = new System.Drawing.Point( 5, 5 );
            this._availableResourcesLabel.Name = "_availableResourcesLabel";
            this._availableResourcesLabel.Size = new System.Drawing.Size( 279, 12 );
            this._availableResourcesLabel.TabIndex = 5;
            this._availableResourcesLabel.Text = "Available Resources:";
            //
            // _resourceStringLabel
            //
            this._resourceStringLabel.Anchor = (( System.Windows.Forms.AnchorStyles ) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this._resourceStringLabel.Location = new System.Drawing.Point( 5, 141 );
            this._resourceStringLabel.Name = "_resourceStringLabel";
            this._resourceStringLabel.Size = new System.Drawing.Size( 279, 13 );
            this._resourceStringLabel.TabIndex = 6;
            this._resourceStringLabel.Text = "Resource String:";
            //
            // SelectResource
            //
            this.AcceptButton = this._okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.CancelButton = this._closeButton;
            this.ClientSize = new System.Drawing.Size( 292, 220 );
            this.Controls.Add( this._resourceStringLabel );
            this.Controls.Add( this._availableResourcesLabel );
            this.Controls.Add( this._visaResourceNameTextBox );
            this.Controls.Add( this._closeButton );
            this.Controls.Add( this._okButton );
            this.Controls.Add( this._availableResourcesListBox );
            this.Icon = (( System.Drawing.Icon ) (resources.GetObject( "$this.Icon", CultureInfo.CurrentCulture )));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 177, 247 );
            this.Name = "SelectResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Resource";
            this.Load += new System.EventHandler( this.OnLoad );
            this.ResumeLayout( false );
        }
        #endregion

        private void OnLoad( object sender, System.EventArgs e )
        {
            // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
            // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
            // requires additional VISA .NET implementations.
            IEnumerable<string> resources = Ivi.Visa.GlobalResourceManager.Find( "(ASRL|GPIB|TCPIP|USB)?*" );
            foreach ( string s in resources )
            {
                _ = this._availableResourcesListBox.Items.Add( s );
            }
        }

        private void AvailableResourcesListBox_DoubleClick( object sender, System.EventArgs e )
        {
            string selectedString = ( string ) this._availableResourcesListBox.SelectedItem;
            this.ResourceName = selectedString;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AvailableResourcesListBox_SelectedIndexChanged( object sender, System.EventArgs e )
        {
            string selectedString = ( string ) this._availableResourcesListBox.SelectedItem;
            this.ResourceName = selectedString;
        }

        [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden )]
        public string ResourceName
        {
            get => this._visaResourceNameTextBox.Text; set => this._visaResourceNameTextBox.Text = value;
        }
    }
}
