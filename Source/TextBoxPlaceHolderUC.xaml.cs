using System;
using System.Windows;
using System.Windows.Controls;

namespace Source;

public partial class TextBoxPlaceHolderUC : UserControl
{
    public TextBoxPlaceHolderUC()
    {
        InitializeComponent();
    }



    public string PlaceHolder
    {
        get { return (string)GetValue(PlaceHolderProperty); }
        set { SetValue(PlaceHolderProperty, value); }
    }

    public static readonly DependencyProperty PlaceHolderProperty =
        DependencyProperty.Register("PlaceHolder", typeof(string), typeof(TextBoxPlaceHolderUC));




    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }


    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(TextBoxPlaceHolderUC));




    public bool AcceptsReturn
    {
        get { return (bool)GetValue(AcceptsReturnProperty); }
        set { SetValue(AcceptsReturnProperty, value); }
    }

    public static readonly DependencyProperty AcceptsReturnProperty =
        DependencyProperty.Register("AcceptsReturn", typeof(bool), typeof(TextBoxPlaceHolderUC));



    
    public event TextChangedEventHandler? TextChanged;
    private void textBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextChanged?.Invoke(this, e);
    }
}
