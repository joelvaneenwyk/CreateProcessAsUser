using System.ServiceProcess;

namespace DemoService
{
    public partial class DemoService : ServiceBase
    {
        public DemoService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ProcessExtensions.ProcessExtensions.StartProcessAsCurrentUser("calc.exe");
        }

        protected override void OnStop()
        {
            // No need to do anything special here so leaving blank intentionally.
        }
    }
}
