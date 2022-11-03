using System.Windows;
using System.Windows.Controls;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBoxPlaceHolderUC_TextChanged(object sender, TextChangedEventArgs e)
    {
        MessageBox.Show("Test");
    }
}
