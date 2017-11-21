using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //initialize arrays and add to viewstate
            if (!Page.IsPostBack)
            {
                String[] asset = new string[0];
                int[] election = new int[0];
                int[] subTF = new int[0];
                ViewState.Add("Asset", asset);
                ViewState.Add("Election", election);
                ViewState.Add("SubTF", subTF);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {

            
            //pull arrays out of viewstate
            string[] asset = (string[])ViewState["Asset"];
            int[] election = (int[])ViewState["Election"];
            int[] subTF = (int[])ViewState["SubTF"];

            //check for dupe asset
            for (int i = 0; i < asset.Length; i++)
            {
                if (assetTextBox.Text == asset[i])
                {
                    msgLabel.Text = "An asset with that name has already been added.";
                    return;
                }
            }

            //iterate array size
            Array.Resize(ref asset, asset.Length + 1);
            Array.Resize(ref election, election.Length + 1);
            Array.Resize(ref subTF, subTF.Length + 1);

            //add new values to arrays
            int newIndex = asset.GetUpperBound(0);
            asset[newIndex] = assetTextBox.Text;
            election[newIndex] = int.Parse(electionTextBox.Text);
            subTF[newIndex] = int.Parse(subTFTextBox.Text);

            //display stats
            msgLabel.Text = string.Format(
                "Total elections rigged: {0}<br />"+
                "Average Acts of Subterfuge per Asset: {1:N2}<br />"+
                "(Last Asset you added: {2})",
                election.Sum(),
                subTF.Average(),
                asset[newIndex]);   

            //shove arrays back into the viewstate from whence they came
            ViewState["Asset"] = asset;
            ViewState["Election"] = election;
            ViewState["SubTF"] = subTF;
        }
    }
}