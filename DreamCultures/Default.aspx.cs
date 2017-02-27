using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DreamCultures
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseLayerDataContext t = new DatabaseLayerDataContext();
            var asd = t.Users.Select(c => c.FirstName == "Fermamdp");
            t.Users.Any(c => c.FirstName.Contains("Fernando"));

            var asddsfasdf = new { name = "tarcisio"};
            int luna = 10000;
            string name = string.Format($"{asddsfasdf.name} {luna}");

            var tsdfg = "fdghdfgh";
            Dreaming dreaming = new Dreaming();
            List<Dream> dreams = dreaming.GetDreamsByUser();
            dreams.Where(p => p.QuarterID == 0);
            foreach (Dream item in dreams)
            {

            }
        }

        private void method123(object asddsfasdf)
        {
            
        }
    }
}