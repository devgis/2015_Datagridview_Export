using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GaohangModel;
using GaohangDAL;
using System.Data;
using System.Text.RegularExpressions;

namespace GaohangBLL
{
    public class PatBLL
    {
        
        PatDAL pDAL = new PatDAL();
        public DataTable SelectAll(string str, bool more, string s_CaseName, string s_AppNo, string caseType, string dt_AppDate1, string dt_AppDate2, string caseState, string comboBox01, string comboBox02, string custom1, string priceOut1, string priceOut2, string priceIn1, string priceIn2, string checkBox1, string checkBox2, string checkBox3)
        { 
            try
            {
                if (dt_AppDate1 == "")
                    dt_AppDate1 = "1900";
                if (dt_AppDate2 == "")
                    dt_AppDate2 = "2099";
                DateTime appDate1 = new DateTime(Convert.ToInt32(dt_AppDate1), 1, 1);
                DateTime appDate2 = new DateTime(Convert.ToInt32(dt_AppDate2), 1, 1);
                DataTable dt = new DataTable();
                dt = pDAL.SelectPatBy(str, more, s_CaseName, s_AppNo, caseType, appDate1, appDate2, caseState, comboBox01, comboBox02, custom1, priceOut1, priceOut2, priceIn1, priceIn2, checkBox1, checkBox2, checkBox3);
                    return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /*
        public DataTable SelectAll( txtPatSearch.Text.ToString(), cbxFaming.Checked, cbxShiyong.Checked, patMore, s_AppNo.Text.ToString(), s_CaseName.Text.ToString(), s_CustomField1.Text.ToString(), txtPatCus.Text.ToString(),  s_CustomField3.Text.ToString(), txtPcBuy1.Text.ToString(), txtPcBuy2.Text.ToString(), txtPcPrice1.Text.ToString(), txtPcPrice2.Text.ToString(), dt_AppDate1.Text.ToString(), dt_AppDate2.Text.ToString())
        {
            try
            {
                patno = toPatID(patno);
                patname = patname.Trim();
                patstate = patstate.Trim();
                cusname = cusname.Trim();
                patprotype = patprotype.Trim();
                patsell = patsell.Trim();
                patbuy1 = toNumber(patbuy1.Trim());
                if (patbuy1 == "")
                    patbuy1 = "0";
                patbuy2 = toNumber(patbuy2.Trim());
                if (patbuy2 == "")
                    patbuy2 = "9999999";
                patprice1 = toNumber(patprice1.Trim());
                if (patprice1 == "")
                    patprice1 = "0";
                patprice2 = toNumber(patprice2.Trim());
                if (patprice2 == "")
                    patprice2 = "9999999";
                patdate1 = toNumber(patdate1.Trim());
                if (patdate1 == "")
                    patdate1 = "0";
                patdate2 = toNumber(patdate2.Trim());
                if (patdate2 == "")
                    patdate2 = "9999";
                patstatedate1 = toNumber(patstatedate1.Trim());
                if (patstatedate1 == "")
                    patstatedate1 = "0";
                patstatedate2 = toNumber(patstatedate2.Trim());
                if (patstatedate2 == "")
                    patstatedate2 = "9999";
                booker = booker.Trim();
                DataTable dt = new DataTable();
                dt = pDAL.SelectPatBy(s.Trim(), c1, c2, more, patno, patname, patfor, patstate, cusname, patprotype, patsell, patbuy1, patbuy2, patprice1, patprice2, patdate1, patdate2, patstatedate1, patstatedate2, booker, selled);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        * */
 

        /// <summary>
        /// 变成专利号格式（数字+x）
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string toPatID(string key)
        {
            return Regex.Replace(key, @"([^\d]*[^\d|^xX])", "");
        }

        /// <summary>
        /// 变成纯数字
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string toNumber(string key)
        {
            return Regex.Replace(key, @"([^\d]*)", "");
        }
        /// <summary>
        /// 变成无数字
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string toNoNumber(string key)
        {
            return Regex.Replace(key, @"([^/d]*)([^/d]|[xX])", "");
        }

        /// <summary>
        /// 规范日期格式
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int[] toDateTime(string d)
        {
            string[] s;
            int[] date = new int[3];
            if (d.Contains('/'))
                s = d.Split('/');
            else
                s = d.Split('-');
            date[0] = Convert.ToInt32(s[0]);
            date[1] = Convert.ToInt32(s[1]);
            date[2] = Convert.ToInt32(s[2]);
            return date;
        }
    }
}
