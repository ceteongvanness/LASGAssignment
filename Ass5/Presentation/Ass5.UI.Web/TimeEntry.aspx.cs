using Ass5.Entities;
using MK.Framework.ACE;
using MK.Framework.ACE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ass5.UI.Web
{
    public partial class TimeEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Process.TaskController listTask = new Process.TaskController();

            lblUserName.Text = Session["Username"].ToString();

            User user = (User)Session["Login"];
            lblUserID.Text = user.UserID.ToString();

            string policyId = "63B6E6FB-419D-46CF-B4CB-063658E05259";
      
            //var ace = new AccessControl();
            var ap = listTask.GetUserPermission(user.UserID, policyId);
            if (!ap.HasFullAccess())
            {
                Response.Redirect("Login.aspx");
            }
            GridViewSubmitForm.DataSource = listTask.ListTask();
            GridViewSubmitForm.DataBind();

            DateTime time = DateTime.Now;
            lblSubmitDate.Text = Convert.ToString(time);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Task newTask = new Task();
            //newTask.TaskNo = txtTaskNo.Text;
            newTask.TaskName = txtTaskname.Text;
            newTask.StartDate = Convert.ToDateTime(txtStartDate.Text);
            newTask.EndDate = Convert.ToDateTime(txtEndDate.Text);
            newTask.CorrelationID = Guid.NewGuid();
            //newTask.DateSubmitted = Convert.ToDateTime(lblSubmitDate.Text);
            //newTask.TaskStatus = lblTaskStatus.Text;

            Process.TaskController submitTask = new Process.TaskController();
            submitTask.Apply(newTask);
        }

        protected void GridViewSubmitForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaskID.Text = GridViewSubmitForm.SelectedRow.Cells[1].Text;
            txtTaskname.Text = GridViewSubmitForm.SelectedRow.Cells[2].Text;
            txtStartDate.Text = GridViewSubmitForm.SelectedRow.Cells[3].Text;
            txtEndDate.Text = GridViewSubmitForm.SelectedRow.Cells[4].Text;
            lblguid.Text = GridViewSubmitForm.SelectedRow.Cells[5].Text;
            lblSubmitDate.Text = GridViewSubmitForm.SelectedRow.Cells[6].Text;
            lblTaskStatus.Text = GridViewSubmitForm.SelectedRow.Cells[7].Text;
            txtTaskNo.Text = GridViewSubmitForm.SelectedRow.Cells[8].Text;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Task cancelTask = new Task();
            //cancelTask.TaskNo = lblTaskNo.Text;
            cancelTask.TaskID = Convert.ToInt16(lblTaskID.Text);
            //cancelTask.TaskName = txtTaskname.Text;
            //cancelTask.StartDate = Convert.ToDateTime(txtStartDate.Text);
            //cancelTask.EndDate = Convert.ToDateTime(txtEndDate.Text);
            cancelTask.CorrelationID = Guid.Parse(lblguid.Text);
            //cancelTask.DateSubmitted = Convert.ToDateTime(lblSubmitDate.Text);
            //cancelTask.TaskStatus = "Canceled";

            Process.TaskController CancelledTask = new Process.TaskController();
            CancelledTask.Cancel(cancelTask);
        }
    }
}