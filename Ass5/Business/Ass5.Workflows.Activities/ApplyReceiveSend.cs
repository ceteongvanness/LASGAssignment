//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 11/30/2016 11:22:04 
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
    /// Messaging wrapper activity for Apply.
    /// </summary>
    /// <remarks>
    /// This class serves only as a convenience to simplify workflow services creation at
    /// design time. It does not contribute any functionality to running code.
    /// </remarks>
    public class ApplyReceiveSend : MessagingWrapperActivity, IActivityTemplateFactory
    {
        public Activity Create(DependencyObject target)
        {
            // Sequence container.
            var sequence = new Sequence();
            sequence.DisplayName = "Apply";

            // Correlation Handle.
            var handle = new Variable<CorrelationHandle>("_handle");
            var applyResult = new Variable<Task>("_applyResult");
            var task = new Variable<Task>("_task");

            // Get variable collection.
            var variables = GetVariableCollection(target);

            if (variables == null)
            {
                sequence.Variables.Add(handle);
                sequence.Variables.Add(applyResult);
                sequence.Variables.Add(task);
            }
            else
            {
                handle = AddVariable<CorrelationHandle>(variables, handle);
                applyResult = AddVariable<Task>(variables, applyResult);
                task = AddVariable<Task>(variables, task);
            }

            // Create Receive Activity.
            var receive = new Receive();
            receive.DisplayName = "Apply Receive";
            receive.Action = "http://tempuri.org/ITaskWorkflowService/Apply";
            receive.OperationName = "Apply";
            receive.ProtectionLevel = ProtectionLevel.None;
            receive.ServiceContractName = "ITaskWorkflowService";
            receive.CanCreateInstance = true;

            // Add parameters to Receive
            var parameters = new ReceiveParametersContent();
            parameters.Parameters.Add("task", new OutArgument<Task>(task));
            receive.Content = parameters;

            // Add CorrelationInitializer to Receive
            var initializer = new RequestReplyCorrelationInitializer();
            initializer.CorrelationHandle = new InArgument<CorrelationHandle>(handle);
            receive.CorrelationInitializers.Add(initializer);

            // Create SendReply Activity
            var send = new SendReply();
            send.DisplayName = "Apply Reply";
            send.Action = "http://tempuri.org/ITaskWorkflowService/ApplyResponse";
            send.Request = receive;
            send.PersistBeforeSend = true;

            // Add parameters to SendReply
            var sendParameters = new SendParametersContent();
            sendParameters.Parameters.Add("ApplyResponseResult", new InArgument<Task>(applyResult));
            send.Content = sendParameters;

            // Create Apply activity.
            Apply apply = new Apply();
            apply.DisplayName = "Apply";
            apply.ApplyResult = applyResult;
            apply.Task = task;

            // Add activities to sequence.
            sequence.Activities.Add(receive);
            sequence.Activities.Add(apply);
            sequence.Activities.Add(send);

            return sequence;
        }
    }
}
