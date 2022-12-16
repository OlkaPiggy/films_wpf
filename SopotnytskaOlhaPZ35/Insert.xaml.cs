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
using System.Windows.Shapes;

namespace SopotnytskaOlhaPZ35
{
    /// <summary>
    /// Interaction logic for Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        public Insert()
        {
            InitializeComponent();
        }
        filmsEntities1 _db = new filmsEntities1();

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            member newHotel = new member()
            {
                name = nameBox.Text,
                director = directorBox.Text,
                duration = durationBox.Text,
                genre = genreBox.Text,
                recommend=recommendBox.Text,
                comment=commentBox.Text
            };
            _db.members.Add(newHotel);
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.members.ToList();
            this.Hide();
        }
    }
}
