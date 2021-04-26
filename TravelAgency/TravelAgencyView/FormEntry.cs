using System;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BusinessLogics;
using Unity;

namespace TravelAgencyView
{
    public partial class FormEntry : System.Windows.Forms.Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientLogic _logicC;
        public FormEntry(ClientLogic logicC)
        {
            InitializeComponent();
            _logicC = logicC;
        }

        private void buttonSingIn_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAuthorization>();
            form.ShowDialog();
        }

        private void buttonSingOut_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }

    }
}
