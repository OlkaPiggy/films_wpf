using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SopotnytskaOlhaPZ35
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        filmsEntities1 _db = new filmsEntities1();
        public static DataGrid dataGrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = _db.members.ToList();
            dataGrid = myDataGrid;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            Insert iPage = new Insert();
            iPage.ShowDialog();
        }


        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as member).id;
            var deleteHotel = _db.members.Where(h => h.id == Id).Single();
            _db.members.Remove(deleteHotel);

            _db.SaveChanges();
            dataGrid.ItemsSource = _db.members.ToList();
            //this.Hide();
        }

    }
}
    

