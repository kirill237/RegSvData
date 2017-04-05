using System;
using Xamarin.Forms;


namespace RegSvData
{
	public partial class MainPage : ContentPage
	{
        private float proc;
		public MainPage()
        {
            
            InitializeComponent();
            Ancet.Text = "Регистрация нового пользователя\nВведите свои данные";
            
            //Lb.Text = Droid.MainActivity.width.ToString();
        }
        
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            App.Current.Properties.Add("Name", User_name.Text);
            App.Current.Properties.Add("phone", User_mail.Text);
            App.Current.Properties.Add("mobile", User_phon.Text);
            await Navigation.PushModalAsync(new tts(), true);
        }
    }
}
