//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 12/02/2016 11:19:07 
//====================================================================================================

using System;
using System.Activities;
using System.Activities.Presentation;
using System.Activities.Statements;
using System.Net.Security;
using System.ServiceModel.Activities;
using System.Windows;
using System.Collections.Generic;
using Ass5.Entities;
using Ass5.Business;

namespace Ass5.Workflows.Activities
{
    /// <summary>
    /// Messaging wrapper activity for Update.
    /// </summary>
    /// <remarks>
    /// This class serves only as a convenience to simplify workflow services creation at
    /// design time. It does not contribute any functionality to running code.
    /// </remarks>
    public class UpdateReceiveSend : MessagingWrapperActivity, IActivityTemplateFactory
    {
        public Activity Create(DependencyObject target)
        {
            // Sequence container.
            var sequence = new Sequence();
            sequence.DisplayName = "Update";

            // Correlation Handle.
            var handle = new Variable<CorrelationHandle>("_handle");
            var task = new Variable<Task>("_task");
            var taskLog = new Variable<TaskLog>("_taskLog");

            // Get variable collection.
            var variables = GetVariableCollection(target);

            if (variables == null)
            {
                sequence.Variables.Add(handle);
                sequence.Variables.Add(task);
                sequence.Variables.Add(taskLog);
            }
            else
            {
                handle = AddVariable<CorrelationHandle>(variables, handle);
                task = AddVariable<Task>(variables, task);
                taskLog = AddVariable<TaskLog>(variables, taskLog);
            }

            // Create Receive Activity.
            var receive = new Receive();
            receive.DisplayName = "Update Receive";
            receive.Action = "http://tempuri.org/ITaskWorkflowService/Update";
            receive.OperationName = "Update";
            receive.ProtectionLevel = ProtectionLevel.None;
            receive.ServiceContractName = "ITaskWorkflowService";

            // Add parameters to Receive
            var parameters = new ReceiveParametersContent();
            parameters.Parameters.Add("task", new OutArgument<Task>(task));
            parameters.Parameters.Add("taskLog", new OutArgument<TaskLog>(taskLog));
            receive.Content = parameters;

            // Add CorrelationInitializer to Receive
            var initializer = new RequestReplyCorrelationInitializer();
            initializer.CorrelationHandle = new InArgument<CorrelationHandle>(handle);
            receive.CorrelationInitializers.Add(initializer);

            // Create SendReply Activity
            var send = new SendReply();
            send.DisplayName = "Update Reply";
            send.Action = "http://tempuri.org/ITaskWorkflowService/UpdateResponse";
            send.Request = receive;
            send.PersistBeforeSend = true;

            // Create Update activity.
            Update update = new Update();
            update.DisplayName = "Update";
            update.Task = task;
            update.TaskLog = taskLog;

            // Add activities to sequence.
            sequence.Activities.Add(receive);
            sequence.Activities.Add(update);
            sequence.Activities.Add(send);

            return sequence;
        }
    }
}
