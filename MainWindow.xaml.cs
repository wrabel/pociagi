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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pociag pociag = new Pociag();
        bool czy_lokomotywa, czy_wagon;

        public MainWindow()
        {
            InitializeComponent();
            txt_masa.Visibility = Visibility.Hidden;
            txt_model.Visibility = Visibility.Hidden;
            txt_rodzaj.Visibility = Visibility.Hidden;
            txt_typ.Visibility = Visibility.Hidden;

            textbox_masa.Visibility = Visibility.Hidden;
            textbox_model.Visibility = Visibility.Hidden;
            textbox_rodzaj.Visibility = Visibility.Hidden;

            combobox_1.Visibility = Visibility.Hidden;

            BTN_ADD.Visibility = Visibility.Hidden;

        }

        private void btn_add_lok_Click(object sender, RoutedEventArgs e)
        {
            txt_masa.Visibility = Visibility.Visible;
            textbox_masa.Visibility = Visibility.Visible;
            textbox_masa.Text = null;

            txt_model.Visibility = Visibility.Visible;
            textbox_model.Visibility = Visibility.Visible;
            textbox_model.Text = null;

            BTN_ADD.Visibility = Visibility.Visible;

            txt_rodzaj.Visibility = Visibility.Hidden;
            txt_typ.Visibility = Visibility.Hidden;

            textbox_rodzaj.Visibility = Visibility.Hidden;
            textbox_rodzaj.Text = null;

            combobox_1.Visibility = Visibility.Hidden;

            czy_lokomotywa = true;
            czy_wagon = false;

        }

        private void btn_add_wag_Click(object sender, RoutedEventArgs e)
        {
            txt_masa.Visibility = Visibility.Visible;
            textbox_masa.Visibility = Visibility.Visible;
            textbox_masa.Text = null;

            txt_model.Visibility = Visibility.Visible;
            textbox_model.Visibility = Visibility.Visible;
            textbox_model.Text = null;

            BTN_ADD.Visibility = Visibility.Visible;

            txt_rodzaj.Visibility = Visibility.Visible;
            txt_typ.Visibility = Visibility.Visible;

            textbox_rodzaj.Visibility = Visibility.Visible;
            textbox_rodzaj.Text = null;

            combobox_1.Visibility = Visibility.Visible;
            combobox_1.SelectedIndex = 0;

            czy_lokomotywa = false;
            czy_wagon = true;
        }

        private void btn_spr_Click(object sender, RoutedEventArgs e)
        {
            if (pociag.MozeJechac() == false)
            {
                MessageBox.Show("Pociag nie ruszy", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);return;
            }
            MessageBox.Show("Z pociagiem wszystko jest OK", "GOOD", MessageBoxButton.OK, MessageBoxImage.Information); return;
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (czy_lokomotywa)
                {
                    pociag.DodajLokomotywe(int.Parse(textbox_masa.Text.ToString()), textbox_model.Text.ToString());
                }

                if (czy_wagon)
                {
                    switch (combobox_1.SelectedIndex)
                    {
                        case 0:
                            pociag.DodajOsobowy(int.Parse(textbox_masa.Text.ToString()), textbox_model.Text.ToString(), textbox_rodzaj.Text.ToString()); break;
                        case 1:
                            pociag.DodajTowarowy(int.Parse(textbox_masa.Text.ToString()), textbox_model.Text.ToString(), textbox_rodzaj.Text.ToString()); break;
                    }
                }
                txt_sklad.Text = pociag.Info();
            }
            catch (Exception M)
            {
                MessageBox.Show(M.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        
    }
}
