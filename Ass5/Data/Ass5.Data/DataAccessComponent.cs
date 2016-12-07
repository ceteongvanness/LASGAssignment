//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 3.0.5898.28997)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by et.cheah at ENGTEONG on 11/30/2016 11:00:42 
//====================================================================================================

using System;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Ass5.Data
{
    /// <summary>
    /// Base data access component class.
    /// </summary>
    public abstract class DataAccessComponent
    {
        protected const string CONNECTION_NAME = "default";

        protected string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString;
            }
        }

        protected int PageSize
        {
            get
            {
                // TODO: Define PageSize in config file.
                return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
            }
        }

        protected static T GetDataValue<T>(IDataReader dr, string columnName)
        {
            // NOTE: GetOrdinal() is used to automatically determine where the column
            //       is physically located in the database table. This allows the
            //       schema to be changed without affecting this piece of code.
            //       This of course sacrifices a little performance for maintainability.
            int i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T)dr.GetValue(i);
            else
                return default(T);
        }

        protected string FormatFilterStatement(string filter)
        {
            return Regex.Replace(filter, "^(AND|OR)", string.Empty);
        }

        //protected const string CONNECTION_NAME = "Assignment";

        //protected string ConnectionString
        //{
        //    get
        //    {
        //        return ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString;
        //    }
        //}

        //protected int PageSize
        //{
        //    get
        //    {
        //        // TODO: Define PageSize in config file.
        //        return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
        //    }
        //}

        //protected static T GetDataValue<T>(IDataReader dr, string columnName)
        //{
        //    // NOTE: GetOrdinal() is used to automatically determine where the column
        //    //       is physically located in the database table. This allows the
        //    //       schema to be changed without affecting this piece of code.
        //    //       This of course sacrifices a little performance for maintainability.
        //    int i = dr.GetOrdinal(columnName);

        //    if (!dr.IsDBNull(i))
        //        return (T)dr.GetValue(i);
        //    else
        //        return default(T);
        //}

        //protected string FormatFilterStatement(string filter)
        //{
        //    return Regex.Replace(filter, "^(AND|OR)", string.Empty);
        //}
    }
}
