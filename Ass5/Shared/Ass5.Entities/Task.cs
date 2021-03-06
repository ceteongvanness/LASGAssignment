//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 11/30/2016 10:55:43 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace Ass5.Entities
{
    /// <summary>
    /// Represents a row of Task data.
    /// </summary>
    [DataContract]
    public partial class Task
    {
        /// <summary>
        /// Gets or sets a string value for the TaskID column.
        /// </summary>
        [DataMember]
        [Browsable(false)]
        public int TaskID { get; set; }

        /// <summary>
        /// Gets or sets a string value for the TaskName column.
        /// </summary>
        [DataMember]
        public string TaskName { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the StartDate column.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the EndDate column.
        /// </summary>
        [DataMember]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets a Guid value for the CorrelationID column.
        /// </summary>
        [DataMember]
        public Guid CorrelationID { get; set; }

        /// <summary>
        /// Gets or sets a DateTime value for the DateSubmitted column.
        /// </summary>
        [DataMember]
        public DateTime DateSubmitted { get; set; }

        /// <summary>
        /// Gets or sets a string value for the TaskStatus column.
        /// </summary>
        [DataMember]
        public string TaskStatus { get; set; }

        /// <summary>
        /// Gets or sets a string value for the TaskNo column.
        /// </summary>
        [DataMember]
        public string TaskNo { get; set; }
    }
}
