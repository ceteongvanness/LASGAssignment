//====================================================================================================
// Base code generated with Impulse: UIPC Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 11/30/2016 11:56:17 
//====================================================================================================

using Ass5.Entities;
using Ass5.Services.Contracts;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;

using Ass5.UI.Process.TaskWorkflowService;
using MK.Framework.ACE.Entities;
using Ass5.UI.Process.TaskService;
using MK.Framework.ACE;

namespace Ass5.UI.Process
{
    // NOTE: Please ensure that you name the service reference as the service name
    //		 when you Add Service Reference.
    //		 Example: MyService and not MyServiceReference
    //
    //		 Depending on the svcutil.exe, your method parameters could be in 
    //		 different order from the code generated here. If that is the case, 
    //		 please rearrange the generated code.

    /// <summary>
    /// Task controller component.
    /// </summary>
    public partial class TaskController
    {       /// <summary>
            /// Calls the ListTask operation method in the TaskService.
            /// </summary>
            /// <param name="currentPage">A currentPage value.</param>
            /// <returns>Returns a List<Task> object.</returns>
        public List<Task> ListTask()
        {
            List<Task> result = default(List<Task>);
            var proxy = new TaskServiceClient();

            try
            {
                result = proxy.ListTask();
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
            return result;
        }
        /// <summary>
        /// Calls the GetTask operation method in the TaskService.
        /// </summary>
        /// <param name="taskID">A taskID value.</param>
        /// <returns>Returns a Task object.</returns>
        public Task GetTask(int taskID)
        {
            Task result = default(Task);
            var proxy = new TaskServiceClient();

            try
            {
                result = proxy.GetTask(taskID);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
            return result;
        }

        public User LoginVerify(string Username, string Password)
        {
            User result = default(User);
            var proxy = new TaskServiceClient();

            try
            {
                result = proxy.LoginVerify(Username, Password);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
            return result;
        }


        public void Reject(Task task)
        {
            var proxy = new TaskWorkflowServiceClient();

            try
            {
                proxy.Reject(task);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public void Cancel(Task task)
        {
            var proxy = new TaskWorkflowServiceClient();

            try
            {
                proxy.Cancel(task);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public void Approve(Task task)
        {
            var proxy = new TaskWorkflowServiceClient();

            try
            {
                proxy.Approve(task);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        public void Apply(Task task)
        {
            var proxy = new TaskWorkflowServiceClient();

            try
            {
                proxy.Apply(task);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
        }

        /// <summary>
        /// Calls the GetUserPermission operation method in the TaskService.
        /// </summary>
        /// <param name="userID">A userID value.</param>
        /// <param name="policyId">A policyId value.</param>
        /// <returns>Returns a AccessPolicy object.</returns>
        public AccessPolicy GetUserPermission(long userID, string policyId)
        {
            AccessPolicy result = default(AccessPolicy);
            var proxy = new TaskServiceClient();

            try
            {
                result = proxy.GetUserPermission(userID, policyId);   
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
            return result;
        }

        //public AccessPolicy GetUserPermission(long userID, string policyId)
        //{
        //    var ace = new AccessControl();
        //    var ap = ace.GetAccessPolicy(userID, policyId);

        //    return ap;
        //}

        //public AccessControl GetAccessPolicy(long userID, string policyId)
        //{
        //    AccessPolicy result = default(AccessPolicy);
        //    var ace = new AccessControl(); 
        //    try
        //    {
        //        result = ace.GetAccessPolicy(userID, policyId);
        //    }
        //    catch(FaultException fex)
        //    {
        //        throw new ApplicationException(fex.Message);
        //    }
        //    return result;
        //}
        public void Export(Task task)
        {
            TaskServiceClient tsc = new TaskServiceClient();
            try
            {
                tsc.Export();
            }
            catch(FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                tsc.Close();
            }
            
        }


        /// <summary>
        /// Calls the Update operation method in the TaskWorkflowService.
        /// </summary>
        /// <param name="task">A task value.</param>
        /// <param name="taskLog">A taskLog value.</param>
        public void Update(Task task, TaskLog taskLog)
        {
            var proxy = new TaskWorkflowServiceClient();

            try
            {
                proxy.Update(task, taskLog);
            }
            catch (FaultException fex)
            {
                // TODO: Handle your exception here or raise it to the UI.
                //		 Do not display sensitive information to the UI.
                throw new ApplicationException(fex.Message);
            }
            finally
            {
                proxy.Close();
            }
        }


      
    }
}
