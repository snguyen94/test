using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Serialization;
using Proficy.Historian.ClientAccess.API;
using Microsoft.VisualBasic;
using System.Threading;

namespace HistorianCSharp
{
    public partial class Main : Form
    {
        //variable to hold the Historian server connection
        ServerConnection sc;

        public Main()
        {
            InitializeComponent();
            txtServerName.Text = "IHE-B7HST2";  //System.Net.Dns.GetHostName();
            dtTimestamp.Value = DateTime.Now;
            InitializeCombobox();
        }

        private void cmdReadData_Click(object sender, EventArgs e)
        {
            //declare general purpose variables
            string tag = null;
            int total = 0;
            DateTime st = DateTime.Now;
            DateTime en = st;

            //change the cursor to busy
            Cursor = Cursors.WaitCursor;

            //if currently connected
            if (sc.IsConnected())
            {   
                //create .net datatable to hold the rows selected on the tags grid
                System.Data.DataTable dt = new System.Data.DataTable();
                System.Data.DataRow dr;
                dt.Columns.Add("Timestamp", typeof(string));
                dt.Columns.Add("Value", typeof(string));
                dt.Columns.Add("Quality", typeof(string));
            
                tag = cboTags.Text;

                //build the query string
                // This does interpolated query now-10minutes to now 
                // and requesting 10 samples which is one per minute
                DataQueryParams query = new InterpolatedQuery(DateTime.Now.AddMinutes(-10), DateTime.Now, 10, tag) { Fields = DataFields.Time | DataFields.Value | DataFields.Quality };
                ItemErrors errors;
                Proficy.Historian.ClientAccess.API.DataSet set = new Proficy.Historian.ClientAccess.API.DataSet();
                
                //execute the query and populate the "set" Historian Dataset
                sc.IData.Query(ref query, out set, out errors);

                //sum up the total of samples
                total += set.TotalSamples;

                //loop thru all the samples and populate the .net datatable for data grid
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
                DateTime cstTime;
                for (int i = 0; i < set.TotalSamples; i++)
                {
                    dr = dt.NewRow();
                    if (set[tag].GetValue(i) != null)
                        dr["Value"] = set[tag].GetValue(i).ToString();
                    else 
                        dr["Value"] = "null";
                    cstTime = TimeZoneInfo.ConvertTimeFromUtc(set[tag].GetTime(i), cstZone);
                    dr["Timestamp"] = cstTime.ToLongTimeString();
                    dr["Quality"] = set[tag].GetQuality(i).PercentGood().ToString();
                    dt.Rows.Add(dr);
                }

                //populate the data grid
                dataGridData.DataSource = dt;
            }

            //calculate the elapsed time on the query operation and reset the cursor
            en = DateTime.Now;
            Cursor = Cursors.Default;
            grpRead.Text = "Read Data - " + total.ToString() + " Samples - Elapsed Time: " + en.Subtract(st).Seconds.ToString() + " Secs";
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            //connect on the server
            sc = new ServerConnection(new ConnectionProperties { ServerHostName = txtServerName.Text});
            sc.Connect();

            if (sc.IsConnected())
            {
                tsStatus.Text = "Connected to " + txtServerName.Text;
                txtServerName.ForeColor = Color.Blue;
            }
            else
            {
                tsStatus.Text = "Error Connecting to " + txtServerName.Text;
                tsStatus.ForeColor = Color.Red;
            }
            Cursor = Cursors.Default;

        }

        private void cmdBrowseTags_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            //check if the server is already connected, if not skip the execution
            if (! (sc == null))
            {
                if (sc.IsConnected())
                {
                    //build the tags query
                    TagQueryParams query = new TagQueryParams { PageSize = 100 };
                    List<Tag> allTags = new List<Tag>();
                    List<Tag> tmp;
                    // return only string tags
                    query.Criteria.TagnameMask = txtTagnameFilter.Text;
                    if (!(string.IsNullOrEmpty(cboTagType1.Text))){
                        if (cboTagType1.Text == "Single Integer")
                        {
                            query.Criteria.DataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Integer;
                        }
                        else if (cboTagType1.Text == "Single Float")
                        {
                            query.Criteria.DataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Float;
                        }
                        else if (cboTagType1.Text == "Text")
                        {
                            query.Criteria.DataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.VariableString;
                        }
                        //else if (cboTagType1.Text == "All")
                        //{
                            
                        //}
                    }
                 
                    

                    //execute the query and populate the list datatype
                    while (sc.ITags.Query(ref query, out tmp))
                        allTags.AddRange(tmp);
                    allTags.AddRange(tmp);

                    //populate the combo box
                    cboTags.DataSource = allTags;
                    cboTags.DisplayMember = "Name";
                    cboTags.ValueMember = "Name";
                }
            }

            Cursor = Cursors.Default;

        }

        private void cmdWriteData_Click(object sender, EventArgs e)
        {
            string tag="";
            string value="";
            DateTime dt = DateTime.Now;

            tag = cboTags.Text;

            if (! (tag==null))
            {
                try
                {
                    value = txtValue.Text;
                    dt = Convert.ToDateTime(dtTimestamp.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);                    
                }

                Proficy.Historian.ClientAccess.API.DataSet set = new Proficy.Historian.ClientAccess.API.DataSet();
                ItemErrors errors;

                // populate tag values
                set[tag] = new DataSamples<string> { Values = new string[] {value}, Times = new DateTime[] { dt }, ImplicitQuality = DataQuality.Good };
                
                // write values to server
                sc.IData.Add(set, false, out errors);
            }
        }

        //Creating a hard coded Multi Field tag called MyMFTag with a type called "My MultiField"
        private void AddMultiFieldTag_Click(object sender, EventArgs e)
        {
         try
            {
                //create two fields
                Proficy.Historian.ClientAccess.API.Field myField1 = new Proficy.Historian.ClientAccess.API.Field();
                myField1.Name = "My Field1";
                myField1.FieldValueDataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Integer;

                Proficy.Historian.ClientAccess.API.Field myField2 = new Proficy.Historian.ClientAccess.API.Field();
                myField2.Name = "My Field2";
                myField2.FieldValueDataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Float;

                //create a multifield object
                MultiField myMultiFieldDef = new Proficy.Historian.ClientAccess.API.MultiField();
                myMultiFieldDef.Name = "My MultiField";
                myMultiFieldDef.StoreFieldQualities = true;
                myMultiFieldDef.AdministratorSecurityGroup = "Administrators";  //you don't really need this

                // add the 2 fields to the multifield object
                myMultiFieldDef.Fields.Add(myField1);
                myMultiFieldDef.Fields.Add(myField2);
                myMultiFieldDef.NumberOfFields = myMultiFieldDef.Fields.Count;

                // create a User Defined Type and add the multifield object to it
                UserDefinedType myType = new Proficy.Historian.ClientAccess.API.UserDefinedType();
                myType.DataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.MultiField;
                myType.Type = myMultiFieldDef;

                // write the user defined type to the Data Archiver
                sc.IUserDefinedTypes.Add(myType);

                // create a tag that uses that user defined type
                Proficy.Historian.ClientAccess.API.Tag tag = new Proficy.Historian.ClientAccess.API.Tag { Name = "MyMFTag" };
                tag.DataType = (Proficy.Historian.ClientAccess.API.Tag.NativeDataType)Proficy.Historian.ClientAccess.API.Tag.NativeDataType.MultiField;
                tag.UserDefinedTypeName = "My MultiField";

                sc.ITags.Add(tag);
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //Using the hard coded tag created above to write a data sample to it. 
        private void WriteDataToMultiField_Click(object sender, EventArgs e)
        {
            try
            {
                ItemErrors errors;

                Proficy.Historian.ClientAccess.API.DataSet set = new Proficy.Historian.ClientAccess.API.DataSet();
                DataSamples<MultiFieldValue> dataSamples = new DataSamples<MultiFieldValue>();
                int NoOfFields = 2;

                //Values for the datasample
                MultiFieldValue[] mfValues = new MultiFieldValue[1];

                //Timestamp for the sample
                DateTime[] times = new DateTime[1];

                //data sample
                mfValues[0] = new MultiFieldValue();
                mfValues[0].NumFields = NoOfFields;

                //Fields collection
                FieldValue fvalue = new FieldValue();
                List<FieldValue> fvalues = new List<FieldValue>();

                //Field 1
                fvalue = new FieldValue();
                fvalue.Name = "My Field1";
                //detailed value for the field 
                DetailedValue dvalue = new DetailedValue();
                dvalue.Quality = DataQuality.Good;
                dvalue.ValueDataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Integer;
                dvalue.Value = 100;
                fvalue.Value = dvalue;
                fvalues.Add(fvalue);
                
                //Field 2
                fvalue = new FieldValue();
                fvalue.Name = "My Field2";
                //value for the field 
                dvalue = new DetailedValue();
                dvalue.Quality = DataQuality.Good;
                dvalue.ValueDataType = Proficy.Historian.ClientAccess.API.Tag.NativeDataType.Float;
                dvalue.Value = 101;
                fvalue.Value = dvalue;
                fvalues.Add(fvalue);
                
                mfValues[0].Values = fvalues;

                dataSamples.Values = mfValues;
                times[0] = DateTime.Now.AddTicks(1 * 1000);
                dataSamples.Times = times;
                dataSamples.ImplicitQuality = DataQuality.Good;

                set["MyMFTag"] = dataSamples;
               
                // write data to server
                sc.IData.Add(set, false, out errors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }   
        
        public void InitializeCombobox()
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "Single Integer", Value = "Integer" });
            dataSource.Add(new Language() { Name = "Single Float", Value = "Float" });
            dataSource.Add(new Language() { Name = "Text", Value = "String" });
            //dataSource.Add(new Language() { Name = "All", Value = "All" });

            this.cboTagType1.DataSource = dataSource;
            this.cboTagType1.DisplayMember = "Name";
            this.cboTagType1.ValueMember = "Value";
            this.cboTagType1.SelectedItem = null;
        }

    }
    public class Language
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
