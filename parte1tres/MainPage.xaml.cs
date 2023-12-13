namespace parte1tres;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            float a = float.Parse(valor1.Text);
            float b = float.Parse(valor2.Text);
            String s = "";
            if (suma.IsChecked)
            {
                float c = a + b;
                s += a + "+" + b + "=" + c + "\n";
            }
            if (resta.IsChecked)
            {
                float c = a - b;
                s += a + "-" + b + "=" + c;
            }
            resultado.Text = s;
        }
        catch
        {
            resultado.Text = "Error al capturar los datos!!";
        }
    }
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        suma.IsChecked = !suma.IsChecked;
    }
    private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
    {
        resta.IsChecked = !resta.IsChecked;
    }
}