using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using GaohangModel;
using Tool;
//
//
namespace GaohangDAL
{
    
    public class PatDAL
    {
        public String sum ;
        //string strsql = "select s_CaseName,s_AppNo,caseType,dt_AppDate,s_CustomField1,s_CustomField3,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10 from TCase_Base ";
        string strsql = "select s_CaseName,s_AppNo,dt_AppDate,s_CustomField1,s_Inventors,s_CustomField2,s_CustomField5,s_CustomField6,s_CustomField7,s_CustomField8,s_CustomField9,s_CustomField10,s_CaseSerial from TCase_Base inner join TPCase_Patent on TCase_Base.n_CaseID=TPCase_Patent.n_CaseID  where s_CaseName != '' and ( s_CaseSerial like 'Z%' or s_CustomField2 = '收购' or s_CustomField2 = '自申请' ) ";
        /// <summary>
        /// 模糊搜索
        /// </summary>
        /// <param name="s">查找内容</param>
        /// <returns></returns>
        public DataTable SelectPatBy(string str, bool more, string s_CaseName, string s_AppNo, string caseType, DateTime dt_AppDate1, DateTime dt_AppDate2, string caseState, string comboBox01, string comboBox02, string custom1, string priceOut1, string priceOut2, string priceIn1, string priceIn2, string checkBox1, string checkBox2, string checkBox3)
        {
            try
            {   
                string selsql = strsql + " ";
                if (str != "")
                {
                    selsql += " and (  s_CaseName  like '%" + str + "%'";
                    selsql += " or  s_AppNo     like '%" + str + "%'";
                    //selsql += " or  caseType   like '%" + str + "%'";
                    selsql += " or  dt_AppDate   like '%" + str + "%'";
                    selsql += " or  s_CustomField1   like '%" + str + "%'";
                    selsql += " or  s_Inventors   like '%" + str + "%'";
                    selsql += " or  s_CustomField2   like '%" + str + "%'";
                    selsql += " or  s_CustomField5   like '%" + str + "%'";
                    selsql += " or  s_CustomField6   like '%" + str + "%'";
                    selsql += " or  s_CustomField7   like '%" + str + "%'";
                    selsql += " or  s_CustomField8   like '%" + str + "%'";
                    selsql += " or  s_CustomField9   like '%" + str + "%'";
                    selsql += " or  s_CustomField10   like '%" + str + "%')";
                }
                /*
                if (!selled)
                {
                    selsql += " and pcsell != '已售' ";
                }
                if (c1 || c2)
                {
                    if (c1)
                    {
                        selsql += " and (  PatType  like '%发明%'  ";
                    }
                    if (c2)
                    {
                        if (!c1)
                            selsql += " and ( ";
                        else
                            selsql += " or ";
                        selsql += "  PatType  like '%实用%' ";
                    }
                    selsql += " ) "; 
                }
                 * */
                if (checkBox1 == "1")
                {
                    if (checkBox2 == "2")
                    {
                        selsql += " and  s_AppNo like '____1%'";
                        selsql += " or  s_AppNo like '____2%'";
                    }
                    else
                    {
                        selsql += " and  s_AppNo like '____1%'";
                    }
                }
                else if (checkBox2 == "2")
                {
                    if (checkBox3 == "3")
                    {
                        selsql += " and  s_AppNo like '____2%'";
                        selsql += " or  s_AppNo like '____3%'";
                    }
                    else
                    {
                        selsql += " and  s_AppNo like '____2%'";
                    }
                }

                else if (checkBox3 == "3")
                {
                    selsql += " and  s_AppNo like '____3%'";
                }

                if (more)
                {
                    selsql += " and s_CaseName like '%" + s_CaseName + "%' ";
                    selsql += " and  s_AppNo like '%" + s_AppNo + "%' ";
                    //selsql += " and  caseType like '%" + caseType + "%' ";
                    selsql += " and  dt_AppDate between '" + dt_AppDate1 + "' and '" + dt_AppDate2 + "' ";
                    selsql += " and  s_CustomField1 like '%" + caseState + "%' ";
                    if(comboBox01 != "NULL")
                    {

                        selsql += " and  s_CustomField2 like '%" + comboBox01 + "%' ";
                    }
                    else 
                    {
                        selsql += " and  s_CustomField2 like '' ";
                    }
                    selsql += " and  s_Inventors like '%" + comboBox02 + "%' ";
                    selsql += " and ( s_CustomField5 like '%" + custom1 + "%' or s_CustomField8 like '%" + custom1 + "%')  ";
                    //selsql += " and  s_CustomField6 between '" + priceOut1 + "' and '" + priceOut2+"'";
                    //selsql += " and  s_CustomField7 between " + priceIn1 + " and " + priceIn2;
                    //selsql += " and  s_CustomField8 like '%" + custom1 + "%' ";
                    /*selsql += " and  s_CustomField9 between " + priceOut1 + " and " + priceOut2;
                    selsql += " and  s_CustomField10 between " + priceIn1 + " and " + priceIn2;*/
                    
                }
                DataTable dt = new DataTable();
                dt = SqlDbHelper.GetMany(selsql);
                sum = dt.Rows.Count.ToString();
                Console.WriteLine(sum);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
    }
    
}
