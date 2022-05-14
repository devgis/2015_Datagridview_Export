using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tool
{
    /// <summary>
    /// 数据库访问类
    /// </summary>
    public static class SqlDbHelper
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString; //"Data Source=MAOGUODONG\\SQLEXPRESS;Database=Search;Uid=sa;";
        public static readonly string urlStr = ConfigurationManager.ConnectionStrings["urlstr"].ConnectionString; //"Data Source=MAOGUODONG\\SQLEXPRESS;Database=Search;Uid=sa;";
        /// <summary>
        /// 无参增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Exec(string sql)
        {
            Console.WriteLine(sql);//测试
            int i = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                i = cmd.ExecuteNonQuery();
            }
            return i;
        }
        /// <summary>
        /// 无参单值查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingle(string sql)
        {
            object obj = null;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                obj = cmd.ExecuteScalar();
            }
            return obj;
        }
        /// <summary>
        /// 无参多值查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetMany(string sql)
        {
            Console.WriteLine(sql);//测试
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// 有参增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Exec(string sql, params SqlParameter[] para)
        {
            Console.WriteLine(sql);//测试
            int i = 0;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(para);
                i = cmd.ExecuteNonQuery();
            }
            return i;
        }
        /// <summary>
        /// 有参单值查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingle(string sql, params SqlParameter[] para)
        {
            Console.WriteLine(sql);//测试
            object obj = null;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(para);
                obj = cmd.ExecuteScalar();
            }
            return obj;
        }
        /// <summary>
        /// 有参多值查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetMany(string sql, params SqlParameter[] para)
        {
            Console.WriteLine(sql);//测试
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddRange(para);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }
    }
}