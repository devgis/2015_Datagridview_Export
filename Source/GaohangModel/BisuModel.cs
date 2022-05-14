using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaohangModel
{
    public class BisuModel
    {
        public BisuModel() { }
        private string s_CaseName;//专利名
        private string s_AppNo;//申请号
        private string caseType;//专利类型
        private DateTime dt_AppDate;//申请日
        private string s_CustomField1;//法律状态
        private string s_CustomField2;//来源
        private string s_CustomField3;//出售状态
        private string s_CustomField5;//联系人1
        private string s_CustomField6;//底价1
        private string s_CustomField7;//买入价1
        private string s_CustomField8;//联系人2
        private string s_CustomField9;//底价2
        private string s_CustomField10;//买入价2

        public string S_CaseName
        {
            get { return s_CaseName; }
            set { s_CaseName = value; }
        }

        public string S_AppNo
        {
            get { return s_AppNo; }
            set { s_AppNo = value; }
        }

        public string CaseType
        {
            get { return caseType; }
            set { caseType = value; }
        }

        public DateTime Dt_AppDate
        {
            get { return dt_AppDate; }
            set { dt_AppDate = value; }
        }

        public string S_CustomField1
        {
            get { return s_CustomField1; }
            set { s_CustomField1 = value; }
        }

        public string S_CustomField2
        {
            get { return s_CustomField2; }
            set { s_CustomField2 = value; }
        }

        public string S_CustomField3
        {
            get { return s_CustomField3; }
            set { s_CustomField3 = value; }
        }

        public string S_CustomField5
        {
            get { return s_CustomField5; }
            set { s_CustomField5 = value; }
        }

        public string S_CustomField6
        {
            get { return s_CustomField6; }
            set { s_CustomField6 = value; }
        }

        public string S_CustomField7
        {
            get { return s_CustomField7; }
            set { s_CustomField7 = value; }
        }

        public string S_CustomField8
        {
            get { return s_CustomField8; }
            set { s_CustomField8 = value; }
        }

        public string S_CustomField9
        {
            get { return s_CustomField9; }
            set { s_CustomField9 = value; }
        }

        public string S_CustomField10
        {
            get { return s_CustomField10; }
            set { s_CustomField10 = value; }
        }
    }
}
