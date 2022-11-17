using Avalonia.Controls;
using Avalonia.Interactivity;
using HarfBuzzSharp;

namespace tcctest
{
    public partial class MainWindow : Window
    {
        private readonly UserControl1 m_View1 = new UserControl1();
        private readonly UserControl2 m_View2 = new UserControl2();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetView1( object args, RoutedEventArgs e )
        {
            tcc.Content = m_View1;
        }

        public void SetView2( object args, RoutedEventArgs e )
        {
            tcc.Content = m_View2;
        }
    }
}
