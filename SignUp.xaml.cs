namespace yongjySignUpProfile;

public partial class SignUp : ContentPage
{
    public SignUp()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;
        string passwordConfirm = ConfirmPasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password))
        {
            DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }

        if (password != passwordConfirm)
        {
            DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }

        var myData = new Dictionary<string, object>
        {
            { "username", $"{UsernameEntry.Text}" },
            { "email", $"{EmailEntry.Text}" },
            { "password", $"{PasswordEntry.Text}" }
        };
        Shell.Current.GoToAsync(nameof(UserProfile), myData);
    }
}