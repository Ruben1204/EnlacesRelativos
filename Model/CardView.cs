using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnlacesRelativos.Model
{
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
       
        public string CardTitle
        {
            get => (string)GetValue(CardView.CardTitleProperty);
            set => SetValue(CardView.CardTitleProperty, value);
        }
    
        public string CardDescription
        {
            get => (string)GetValue(CardView.CardDescriptionProperty);
            set => SetValue(CardView.CardDescriptionProperty, value);
        }

      

       

       



    }
}
