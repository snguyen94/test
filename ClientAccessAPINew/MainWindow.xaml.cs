using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Proficy.Historian.ClientAccess.API;

namespace ClientAccessDemo
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      InitTagColumns();
      serverName.Text = System.Net.Dns.GetHostName();
    }

    void InitTagColumns()
    {
      tagGrid.Columns.Clear();
      tagGrid.AutoGenerateColumns = false;
      string[] columns = new string[] { "Name", "DataType", "Description", "CollectorName", "CollectorType", "SourceAddress", "Comment", "Id" };
      foreach (string column in columns)
        tagGrid.Columns.Add(new DataGridTextColumn { Header = column, Binding = new Binding(column) });
    }

    private void browseTags_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        Cursor = Cursors.Wait;
        browseTagsButton.IsEnabled = false;

        // Setup DataGrid columns
        InitTagColumns();

        // Construct a ServerConnection to the local Historian server with current user credentials
        ServerConnection sc = new ServerConnection(new ConnectionProperties { ServerHostName = serverName.Text, ServerCertificateValidationMode = CertificateValidationMode.None });

        // Establish a connection to the server
        sc.Connect();

        // Construct a 
        TagQueryParams query = new TagQueryParams { PageSize = 100 };
        List<Tag> allTags = new List<Tag>();

        // Retrieve all query results from the server
        List<Tag> tmp;
        while (sc.ITags.Query(ref query, out tmp))
          allTags.AddRange(tmp);
        allTags.AddRange(tmp);

        // Populate the DataGrid with all retrieved results
        tagGrid.ItemsSource = allTags;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error");
      }
      finally
      {
        browseTagsButton.IsEnabled = true;
        Cursor = Cursors.Arrow;
      }
    }
  }
}
