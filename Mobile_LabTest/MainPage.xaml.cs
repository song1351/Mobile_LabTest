namespace Mobile_LabTest;

public partial class MainPage : ContentPage
{
    public MainPage()
{
InitializeComponent();

// Don't know how to add row definition to grid from C# so I added it in XAML.

// Set the slider1's range to 0~100:
slider1.Minimum = 0;
slider1.Maximum = 100;

// Set the slider1's colors:
slider1.MinimumTrackColor = Color.FromArgb("#FF0000FF");
slider1.MaximumTrackColor = Color.FromArgb("#FFFF0000");

        // Set the slider1's function:
        slider1.ValueChanged += (sender, e) => Slider1ValueOnChange(sender, e);
}

private async void Slider1ValueOnChange(object sender, EventArgs e)
{
// Get the slider1's value:
int value = (int)slider1.Value;

// Set the label1's text to the value:
label1.Text = value.ToString();

// Follow the rules:
string lbl2Txt = "Drag the slider";
Color lbl2TxtClr = Color.FromArgb("#FF000000");

if ((value >= 0) && (value <= 39)) // 0 <= value <= 39:
{
// Failed:
lbl2Txt = "Failed";
lbl2TxtClr = Color.FromArgb("#FFFF0000");
}
else if ((value >= 40) && (value <= 79)) // 40 <= value <= 79:
{
            // Passed:
            lbl2Txt = "Passed";
            lbl2TxtClr = Color.FromArgb("#FF000000");
}
else if ((value >= 80) && (value <= 100))
{
            // Excellent:
            lbl2Txt = "Excellent";
            lbl2TxtClr = Color.FromArgb("#FF00FF00");
}
else
{
// Unexpected:
lbl2Txt = $"Unexpected value for slider1: {value}";
            lbl2TxtClr = Color.FromArgb("#FFFF0000");
            await DisplayAlert("Error!", $"Unexpected value for slider1: {value}", "OK");
}

// Set the label2's text and textcolor:
label2.Text = lbl2Txt;
label2.TextColor = lbl2TxtClr;
}
    async void GoToSecondPageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Question2());
    }
    async void GoToSecondPageButtonClicked2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Question3());
    }
}

