
using Xamarin.Forms;

namespace ArtAuction.CustomControl
{
    public partial class LabelLength : ContentView
    {
        public LabelLength() => InitializeComponent();

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text),
                        typeof(string),
                        typeof(LabelLength),
                        default(string),
                        BindingMode.OneWay,
                        propertyChanged: OnTextChanged);

        static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = (LabelLength)bindable;

            var myText = view.Text;

            if (myText.Length >= view.MaxLength)
            {
                var text = $"{myText.Substring(0, view.MaxLength)}...";
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


        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.Create(nameof(MaxLength),
                        typeof(int),
                        typeof(LabelLength),
                        default(int),
                        BindingMode.OneWay);

        public int MaxLength { get => (int)GetValue(MaxLengthProperty); set => SetValue(MaxLengthProperty, value); }


        public static readonly BindableProperty ReadMoreProperty = 
            BindableProperty.Create(nameof(ReadMore),
                        typeof(Color),
                        typeof(LabelLength),
                        default(Color),
                        BindingMode.OneWay);

        public Color ReadMore { get => (Color)GetValue(ReadMoreProperty); set => SetValue(ReadMoreProperty, value); }
    }
}