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
using Praktika.Avdeev.Entities;

namespace Praktika.Avdeev.Pages
{
    /// <summary>
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Page
    {
        PrEntities m = new PrEntities();
        PrEntities ms = Helper.getContext();
        public Director()
        {
            InitializeComponent();
        }

        private void btn_redact_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string patronymic = tb_patronymic.Text;
            string professia = tb_professia.Text;
            string login = tb_login.Text;
            string password = tb_password.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                && string.IsNullOrEmpty(patronymic))

            {
                MessageBox.Show("Не все нужные данные введены");
            }
            else if (int.TryParse(name, out int n) || int.TryParse(surname, out int s)
                || int.TryParse(patronymic, out int p))
            {
                MessageBox.Show("Данные введены не корректно");
            }
            int num = Convert.ToInt32(tb_id.Text);
            var uRow = m.User.Where(w => w.UserID == num).FirstOrDefault();
            uRow.FirstName = tb_name.Text;
            uRow.LastName = tb_surname.Text;
            uRow.Patronymic = tb_patronymic.Text;
            uRow.ProfessionID = Convert.ToInt32(tb_professia.Text);
            uRow.Login = tb_login.Text;
            uRow.Password = tb_password.Text;
            m.SaveChanges();
        }

        private void btn_dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            string patronymic = tb_patronymic.Text;
            int professia = Convert.ToInt32(tb_professia.Text);
            string login = tb_login.Text;
            string password = tb_password.Text;
            int num = Convert.ToInt32(tb_id.Text);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname)
                && string.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Не все нужные данные введены");
            }
            else if (int.TryParse(name, out int n) || int.TryParse(surname, out int s)
                || int.TryParse(patronymic, out int p))
            {
                MessageBox.Show("Данные введены не корректно");
            }else
            {
                User user = new User {UserID = num, FirstName = name, LastName = surname, Patronymic = patronymic, ProfessionID = professia, Login = login, Password = password };
                Helper.Create(user);
                MessageBox.Show("Сотрудник добавлен");
            }
        }

        private void btn_udalenie_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить сотрудника из системы?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int num = Convert.ToInt32(tb_id.Text);
                var dRow = m.User.Where(w => w.UserID == num).FirstOrDefault();
                m.User.Remove(dRow);
                m.SaveChanges();
                var query = from user in m.User select new { user.UserID, user.FirstName, user.LastName, user.Patronymic, user.ProfessionID, user.Login, user.Password };
                
            }
        }

        private void btn_prosmotr_Click(object sender, RoutedEventArgs e)
        {
            var query = from client in m.User select new { client.UserID, client.LastName, client.FirstName, client.Patronymic, client.ProfessionID };
            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
