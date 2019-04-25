
using Xamarin.Forms;

namespace ArtAuction.CustomControl
{
    public partial class LabelLenght : ContentView
    {
        public LabelLenght() => InitializeComponent();

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text),
                        typeof(string),
                        typeof(LabelLenght),
                        default(string),
                        BindingMode.OneWay,
                        propertyChanged: OnTextChanged);

        static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (LabelLenght)bindable;

            var myText = view.Text;

            if (myText.Length >= view.MaxLenght)
            {
                var text = $"{myText.Substring(0, view.MaxLenght)}...";
                view.lbl.FormattedText = new FormattedString();
                view.lbl.FormattedText.Spans.Add(new Span
                {
                    Text = text,
                    TextColor = Color.White
                });
                view.lbl.FormattedText.Spans.Add(new Span
                {
                    Text = " Read More",
                    TextColor = view.ReadMore
                });

            }
        }

        public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }


        public static readonly BindableProperty MaxLenghtProperty =
            BindableProperty.Create(nameof(MaxLenght),
                        typeof(int),
                        typeof(LabelLenght),
                        default(int),
                        BindingMode.OneWay);

        public int MaxLenght { get => (int)GetValue(MaxLenghtProperty); set => SetValue(MaxLenghtProperty, value); }


        public static readonly BindableProperty ReadMoreProperty = 
            BindableProperty.Create(nameof(ReadMore),
                        typeof(Color),
                        typeof(LabelLenght),
                        default(Color),
                        BindingMode.OneWay);

        public Color ReadMore { get => (Color)GetValue(ReadMoreProperty); set => SetValue(ReadMoreProperty, value); }
    }
}