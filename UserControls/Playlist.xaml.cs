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

namespace MusicPlayer.UserControls
{

    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);

        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
            ("Title", typeof(string), typeof(Playlist));

        public string Desc
        {
            get => (string)GetValue(DescProperty);
            set => SetValue(DescProperty, value);

        }

        public static readonly DependencyProperty DescProperty = DependencyProperty.Register
            ("Desc", typeof(string), typeof(Playlist));

        public ImageSource Image
        {
            get => (ImageSource)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);

        }

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register
            ("Image", typeof(ImageSource), typeof(Playlist));

        public bool IsActive
        {
            get => (bool)GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);

        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register
            ("IsActive", typeof(bool), typeof(Playlist));
    }
}
