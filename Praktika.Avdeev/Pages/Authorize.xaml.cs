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

using Praktika.Avdeev.Pages;
using Praktika.Avdeev.Entities;

namespace Praktika.Avdeev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorize.xaml
    /// </summary>
    public partial class Authorize : Page
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            PrEntities database = PrEntities.GetContext();

            if (database.User.Any(u => u.Login == login && u.Password == password))
            {
                var user = database.User.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
                MessageBox.Show($"Добро пожаловать, {user.Profession.Name}, {user.FirstName}!");
                
                switch (user.Profession.ProfessionID)
                {
                    case 1:
                        NavigationService.Navigate(new Director());
                        break;
                    case 2:
                        NavigationService.Navigate(new OtdelKadrov());
                        break;
                    case 3:
                        NavigationService.Navigate(new AgentSupl());
                        break;
                    case 4:
                        NavigationService.Navigate(new RabotnikCeha());
                        break;
                    case 5:
                        NavigationService.Navigate(new Engineer());
                        break;
                    case 6:
                        NavigationService.Navigate(new Buhgalter());
                        break;
                }
            }
            else
                MessageBox.Show("Неверно введены логин или пароль!");
        }
    }
}
