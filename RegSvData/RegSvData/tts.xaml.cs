using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegSvData
{
	public partial class tts : ContentPage
	{
        string[] Text_mas = new string[11];
        public tts ()
        {
            InitializeComponent();

            for (int i=0;i<11;i++)
            {
                switch (i)
                {
                    case 0: Text_mas[i] = "Шифруем данные"; break;
                    case 1: Text_mas[i] = "Шифруем данные"; break;
                    case 2: Text_mas[i] = "Шифруем данные"; break;
                    case 3: Text_mas[i] = "Шифруем данные"; break;
                    case 4: Text_mas[i] = "Передаем данные"; break;
                    case 5: Text_mas[i] = "Передаем данные"; break;
                    case 6: Text_mas[i] = "Сохраняем данные"; break;
                    case 7: Text_mas[i] = "Сохраняем данные"; break;
                    case 8: Text_mas[i] = "Уже почти всё"; break;
                    case 9: Text_mas[i] = "ещё немного и..."; break;
                    case 10: Text_mas[i] = "ГОТОВО!"; break;
                }
            }
            
            
        }

        private void NewMethodAsync()
        {
            int i = 0;
            float alert = 0.10F;
            float ts = 0.0F;
            while (prgs.Progress != 1.0)
            {
                prgs.Progress += 0.01F;
               
                if (ts <= prgs.Progress)
                {
                    if (i < 10)
                    {
                        i++;
                    }
                    Device.BeginInvokeOnMainThread(()=>{ Text_m.Text = Text_mas[i]; });
                    ts += alert;
                }
            }
        }
    }
}
