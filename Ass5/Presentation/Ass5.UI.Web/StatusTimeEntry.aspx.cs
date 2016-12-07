using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MK.Framework.ACE;
using MK.Framework.ACE.Entities;
using Ass5.Entities;
using MK.Framework.DXE;
using MK.Framework.DXE.Enumeration;
using System.IO;
using Ass5.UI.Process;

namespace Ass5.UI.Web
{
    public partial class StatusTimeEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Process.TaskController listTask = new Process.TaskController();
            lblUserName.Text = Session["Username"].ToString();

            User user = (User)Session["Login"];
            lblUserID.Text = user.UserID.ToString();

            string policyId = "6050957E-E4B0-4D13-AEA1-73B8D878D33F";

           // var ace = new AccessControl();
            var ap = listTask.GetUserPermission(user.UserID, policyId);
            if (!ap.HasFullAccess())
            {
                Response.Redirect("Login.aspx");
            }
            GridViewSubmitStatusForm.DataSource = listTask.ListTask();
            GridViewSubmitStatusForm.DataBind();

            DateTime time = DateTime.Now;
            lblSubmitDate.Text = Convert.ToString(time);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Task cancelTask = new Task();
            cancelTask.TaskNo = lblTaskNo.Text;
            //cancelTask.TaskID = lblTaskID.Text;
            cancelTask.TaskName = txtTaskname.Text;
            cancelTask.StartDate = Convert.ToDateTime(txtStartDate.Text);
            cancelTask.EndDate = Convert.ToDateTime(txtEndDate.Text);
            cancelTask.CorrelationID = Guid.Parse(lblguid.Text);
            cancelTask.DateSubmitted = Convert.ToDateTime(lblSubmitDate.Text);
            cancelTask.TaskStatus = "Canceled";

            Process.TaskController CancelledTask = new Process.TaskController();
            CancelledTask.Cancel(cancelTask);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            Task approveTask = new Task();
            //approveTask.TaskNo = lblTaskNo.Text;
            approveTask.TaskID = Convert.ToInt32(lblTaskID.Text);
            //approveTask.TaskName = txtTaskname.Text;
            //approveTask.StartDate = Convert.ToDateTime(txtStartDate.Text);
            //approveTask.EndDate = Convert.ToDateTime(txtEndDate.Text);
            approveTask.CorrelationID = Guid.Parse(lblguid.Text);
            //approveTask.DateSubmitted = Convert.ToDateTime(lblSubmitDate.Text);

            Process.TaskController approvalTask = new Process.TaskController();
            approvalTask.Approve(approveTask);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            Task rejectTask = new Task();
            //rejectTask.TaskNo = lblTaskNo.Text;
            rejectTask.TaskID = Convert.ToInt16(lblTaskID.Text);
            //rejectTask.TaskName = txtTaskname.Text;
            //rejectTask.StartDate = Convert.ToDateTime(txtStartDate.Text);
            //rejectTask.EndDate = Convert.ToDateTime(txtEndDate.Text);
            rejectTask.CorrelationID = Guid.Parse(lblguid.Text);
            //rejectTask.DateSubmitted = Convert.ToDateTime(lblSubmitDate.Text);

            Process.TaskController rejectedTask = new Process.TaskController();
            rejectedTask.Reject(rejectTask);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void GridViewSubmitStatusForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTaskID.Text = GridViewSubmitStatusForm.SelectedRow.Cells[1].Text;
            txtTaskname.Text = GridViewSubmitStatusForm.SelectedRow.Cells[2].Text;
            txtStartDate.Text = GridViewSubmitStatusForm.SelectedRow.Cells[3].Text;
            txtEndDate.Text = GridViewSubmitStatusForm.SelectedRow.Cells[4].Text;
            lblguid.Text = GridViewSubmitStatusForm.SelectedRow.Cells[5].Text;
            lblSubmitDate.Text = GridViewSubmitStatusForm.SelectedRow.Cells[6].Text;
            lblTaskStatus.Text = GridViewSubmitStatusForm.SelectedRow.Cells[7].Text;
            lblTaskNo.Text = GridViewSubmitStatusForm.SelectedRow.Cells[8].Text;
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            Task exportTask = new Task();
            Process.TaskController exportedTask = new Process.TaskController();
            exportedTask.Export(exportTask);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);

           // TaskController tc = new TaskController();
            //tc.Export();
        }

    }
}
