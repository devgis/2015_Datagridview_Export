using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GaohangBLL;
using GaohangDAL;
using GaohangModel;
using System.IO;
using System.Text.RegularExpressions;

namespace GaohangSearch
{
    public partial class FormMain : Form
    {
        PatBLL pBLL = new PatBLL();
        PatDAL pDAL = new PatDAL();
        bool patMore = false;
        bool ckbSelect = false;
        string checkBox01, checkBox02, checkBox03;
        string comboBox01, comboBox02;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// txtcasefor.Text.ToString().Trim()
        /// txtSelled.Text.ToString().Trim()
        private void btnPatSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = pBLL.SelectAll(txtPatSearch.Text.ToString().Trim(), patMore,
                txts_CaseName.Text.ToString().Trim(), txts_AppNo.Text.ToString().Trim(),
                txtcaseType.Text.ToString().Trim(), txtdt_AppDate1.Text.ToString().Trim(), txtdt_AppDate2.Text.ToString().Trim(), txtcaseState.Text.ToString().Trim(), comboBox01, comboBox02, txtPatCus.Text.ToString().Trim(),
                txtPcPrice1.Text.ToString().Trim(), txtPcPrice2.Text.ToString().Trim(), txtPcBuy1.Text.ToString().Trim(), txtPcBuy2.Text.ToString().Trim(), checkBox01, checkBox02, checkBox03);

            dgvPat.DataSource = dt;
            labelsum.Text = "共  " + dt.Rows.Count.ToString() + "  条";
            //Console.WriteLine("++++++++" + dt.Rows.Count.ToString());
            int c=0;
            for (int i = 0; i < dgvPat.RowCount; i++)
            {
                if (Convert.ToBoolean(dgvPat[0, i].EditedFormattedValue))
                    c++;
            }
            lblchosen.Text = "选中 " + c + " 条";
        }

        /// <summary>
        /// 高级选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPatMore_Click(object sender, EventArgs e)
        {
            if (!patMore)
            {
                btnPatMore.Text = "高级选项 <<";
                pnlPat.Visible = true;
                patMore = !patMore;
            }
            else
            {
                btnPatMore.Text = "高级选项 >>";
                pnlPat.Visible = false;
                patMore = !patMore;
            }
        }




        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void txtcaseType_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 三个checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox02 = "2";
                //checkBox1.CheckState = CheckState.Unchecked;
                //checkBox3.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox02 = "0";
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox01 = "1";
                //checkBox2.CheckState = CheckState.Unchecked;
                //checkBox3.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox01 = "0";
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                checkBox03 = "3";
                //checkBox2.CheckState = CheckState.Unchecked;
                //checkBox1.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox03 = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "咨询案")
            {
                comboBox01 = "NULL";
            }
            else
            {
                comboBox01 = (String)comboBox1.SelectedItem;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox02 = (String)comboBox2.SelectedItem;
        }

        public void SetLabelTest(string value)
        {
            labelsum.Text = value;
        }

        private DataTable toDataTable(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                DataTable dtOld = new DataTable();
                dtOld = (DataTable)dgv.DataSource;
                dt = dtOld.Copy();
                dt.Clear();
                bool sel = false;//是否有选中项
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if ((bool)dgv.Rows[i].Cells[0].EditedFormattedValue == true)
                    {
                        sel = true;
                        break;
                    }
                }
                if (sel)
                {
                    for ( int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if ((bool)dgv.Rows[i].Cells[0].EditedFormattedValue == true)
                        {
                            //没用的？
                            //PatentInfoModel pat = patBLL.ToPatInfo((DataTable)dgv.DataSource, dgv["patNO", i].Value.ToString());
                            //CustomerInfoModel cus = cusBLL.toCusInfo(Convert.ToInt32(dgv["cusNo", i].Value));
                            long patid = 0;
                            try
                            {
                                patid=Convert.ToInt64(dgv.Rows[i].Cells["s_AppNo"].Value);
                            }
                            catch
                            {}

                            for (int j = 0; j < dtOld.Rows.Count; j++)
                            {
                                long newid = 0;
                                try
                                {
                                    newid = Convert.ToInt64(dtOld.Rows[j]["s_AppNo"].ToString());
                                }
                                catch
                                { }
                                if (newid == patid)
                                    dt.Rows.Add(dtOld.Rows[j].ItemArray);
                            }
                        }
                    }
                }
                else
                    dt = (DataTable)dgv.DataSource;
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void OutPut(DataTable tb, int ty)
        {
            Console.WriteLine(Application.StartupPath);
            StreamWriter sr = new StreamWriter(Application.StartupPath + "//MyFile3.txt", false, Encoding.GetEncoding("gb2312"));
            bool write, fa = false;
            if (MessageBox.Show("是否导出数据？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                fa = true;
            }
            if (ty == 0)
            {
                sr.WriteLine("专利名\t申请号\t申请日期\t法律状态\t来源");
                foreach (DataRow dr in tb.Rows)
                {
                    write = true;
                    for (int i = 0; i < 6; i++)//导出前4列，跳过NO号(int i = 0; i < dr.ItemArray.Length;i++ )
                      

                    {
                        if (i == 4)
                        { continue; }
                        if (fa == false)
                        {
                            if (dr["s_Inventors"].ToString() == "不外发")
                            {
                                write = false;
                                continue;
                            }
                        }
                        if (dr[i].ToString() == "1900-01-01 00:00:00")
                        {
                            sr.Write("\t");
                        }
                        else
                            sr.Write(dr[i].ToString() + "\t");
                    }
                    if (write)
                        sr.WriteLine();

                }
            }
            else
            {
                sr.WriteLine("专利号\t专利名\t专利类型\t申请日\t分类号\t法律状态\t授权日\t底价\t买入价\t出售状态\t公司名\t联系人\tQQ\t手机\t收集者\t申请方式\t更新时间\t联系地址\t联系电话\t网站\t发明人\t地址");
                foreach (DataRow dr in tb.Rows)
                {
                    write = true;
                    for (int i = 1; i < dr.ItemArray.Length - 1; i++)//
                    {
                        if (fa == false)
                        {
                            if (dr["s_Inventors"].ToString() == "不外发")
                            {
                                write = false;
                                continue;
                            }
                        }
                        if (dr[i].ToString() == "1900-01-01 00:00:00")
                        {
                            sr.Write("\t");
                        }
                        else
                            sr.Write(dr[i].ToString() + "\t");
                    }
                    if (write)
                        sr.WriteLine();

                }
            }
            sr.Close();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Application.StartupPath + "//MyFile3.txt", saveFileDialog1.FileName, true);
                File.Delete(Application.StartupPath + "//MyFile3.txt");
            }

        }




        private void btnOut_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    DataTable myDT = new DataTable();
                    myDT = toDataTable(dgvPat);
                    OutPut(myDT, 0);
                }
                catch
                {
                    MessageBox.Show("保存失败！");
                }
            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPatSelectAll_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvPat.RowCount; i++)
            {
                if (ckbSelect)
                    dgvPat[0, i].Value = !checkBox1.Checked;
                else
                    dgvPat[0, i].Value = checkBox1.Checked;
            }
            ckbSelect = !ckbSelect;
        }

        private void dgvPat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.Button.Equals(MouseButtons.Left))
                return;
            if (e.RowIndex < 0)
                return;
            if (Convert.ToBoolean(dgvPat[0, e.RowIndex].Value))
                dgvPat[0, e.RowIndex].Value = false;
            else
                dgvPat[0, e.RowIndex].Value = true;

            int SelCount = 0;
            foreach (DataGridViewRow row in dgvPat.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["patCkb"] as DataGridViewCheckBoxCell;
                if (cell.Value!=null&&(bool)cell.Value)
                {
                    SelCount++;
                }
            }
            lblchosen.Text = "选中 "+SelCount+" 条";
        }



    }
}
