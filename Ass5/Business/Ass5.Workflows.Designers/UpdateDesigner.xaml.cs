//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 12/02/2016 11:19:07 
//====================================================================================================

using System;
using System.Activities;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.Windows;
using System.Collections.Generic;
using Ass5.Entities;
using Ass5.Workflows.Activities;

namespace Ass5.Workflows.Designers
{
    /// <summary>
    /// Designer class for Update.
    /// </summary>
    public partial class UpdateDesigner : IRegisterMetadata
    {
        public UpdateDesigner()
        {
            InitializeComponent();
        }

        public void Register()
        {
            AttributeTableBuilder builder = new AttributeTableBuilder();

            builder.AddCustomAttributes(typeof(Update), new Attribute[] {
            new DesignerAttribute(typeof(UpdateDesigner))});

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        public void taskEntry_Loaded(object sender, RoutedEventArgs e)
        {
            taskEntry.ExpressionType = typeof(Task);
        }

        public void taskLogEntry_Loaded(object sender, RoutedEventArgs e)
        {
            taskLogEntry.ExpressionType = typeof(TaskLog);
        }

    }
}
