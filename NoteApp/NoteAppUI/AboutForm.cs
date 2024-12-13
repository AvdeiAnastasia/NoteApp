using System.Reflection;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            
            AuthorValueLabel.Text = "Anastasia Avdeychuk";
            EmailValueLabel.Text = "avdei.anastasia@gmail.com";
            VersionLabel.Text = Assembly.GetAssembly(typeof(AboutForm))?.GetName().Version?.ToString(); 
            GitHubLinkLabel.Text = "https://github.com/AvdeiAnastasia";
            InfoLabel.Text = "Anastasia Avdeychuk 2024 ©";

            this.SetNotChangedSize();
        }
    }
}
