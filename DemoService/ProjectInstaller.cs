using System.ComponentModel;
using JetBrains.Annotations;

namespace DemoService
{
    [RunInstaller(true)]
    [PublicAPI]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
