using Domain_bib.Business;

public partial class Form1 : Form
{
    private Controller controller = new Controller();

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        if (controller.ValidateLogin(username, password))
        {
            MessageBox.Show("Login successful!");
            // Proceed to next form or main application
        }
        else
        {
            MessageBox.Show("Invalid username or password.");
        }
    }
}
