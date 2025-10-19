namespace yongjySignUpProfile;

[QueryProperty(nameof(UsernameEntry), "username")]
[QueryProperty(nameof(EmailEntry), "email")]
public partial class UserProfile : ContentPage
{
    public string UsernameEntry { get; set; }
    public string EmailEntry { get; set; }
    public string PasswordEntry { get; set; }
    public UserProfile()
    {
        InitializeComponent();
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior
        {
            IsVisible = false
        });
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LblUsername.Text = $"Username: {UsernameEntry}";
        LblEmail.Text = $"Email: {EmailEntry}";
    }
    private void OnBackToSignUpClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}