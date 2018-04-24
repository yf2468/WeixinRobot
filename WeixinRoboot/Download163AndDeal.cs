﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeixinRoboot
{
    public partial class Download163AndDeal : Form
    {
        public StartForm StartF = null;
        public RunnerForm RunnerF = null;
        public Download163AndDeal()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            bool SendImage = false;
            StartF.DownLoad163CaiPiao(ref SendImage, Dtp_DownloadDate.Value,true);
            StartF.DealGameLogAndNotice(true);
            GlobalParam.db.SubmitChanges();
            SendImage = true;
            #region "有新的就通知,以及处理结果"
            if (SendImage == true)
            {


                var users = GlobalParam.db.WX_UserReply.Where(t => t.IsReply == true && t.aspnet_UserID == GlobalParam.Key);
                foreach (var item in users)
                {
                    #region  多人同号不到ID跳过
                    #endregion
                    DataRow[] dr = RunnerF.MemberSource.Select("User_ContactID='" + item.WX_UserName + "'");
                    if (dr.Length == 0)
                    {
                        continue;
                    }
                    string TEMPUserName = dr[0].Field<string>("User_ContactTEMPID");
                    if (TEMPUserName.StartsWith("@@"))
                    {
                        StartF.SendWXImage(Application.StartupPath + "\\Data.jpg", TEMPUserName);
                        System.Threading.Thread.Sleep(1000);
                        //SendWXImage(Application.StartupPath + "\\Data2.jpg", TEMPUserName);
                        if (System.IO.File.Exists(Application.StartupPath + "\\Data3.txt"))
                        {
                            System.IO.FileStream fs = new System.IO.FileStream(Application.StartupPath + "\\Data3.txt", System.IO.FileMode.Open);
                            byte[] bs = new byte[fs.Length];
                            fs.Read(bs, 0, bs.Length);
                            fs.Close();
                            fs.Dispose();
                            StartF.SendWXContent(Encoding.UTF8.GetString(bs), TEMPUserName);
                        }
                    }//向监听的群发送图片

                }//设置为自动监听的用户
                StartF.DealGameLogAndNotice();



            }//新开奖

            #endregion
            Download163AndDeal_Load(null, null);





        }

        private void Download163AndDeal_Load(object sender, EventArgs e)
        {
            Dtp_DownloadDate_ValueChanged(null, null);
        }

        private void Dtp_DownloadDate_ValueChanged(object sender, EventArgs e)
        {

            BS_GameResult.DataSource = GlobalParam.db.Game_Result.Where(t => t.aspnet_UserID == GlobalParam.Key && t.GameTime.Value.Date == Dtp_DownloadDate.Value.Date)
                .Select(t => new
                {

                    Gr_GamePeriod = t.GamePeriod,
                    Gr_GameTime = (DateTime?)t.GameTime,
                    Gr_GameResult = t.GameResult,
                    Gr_NumTotal = t.NumTotal,
                    Gr_BigSmall = t.BigSmall,
                    Gr_SingleDouble = t.SingleDouble,
                    Gr_DragonTiger = t.DragonTiger,
                    Gr_GamePrivatePeriod = t.GamePrivatePeriod
                }).ToList();

            var GameLog = (from ds in GlobalParam.db.WX_UserGameLog
                           where (
                 (ds.Result_HaveProcess == false || ds.Result_HaveProcess == null)
                 )

                           select new GameLogClass
               (
                     "",
                     ds.WX_UserName,
                    (DateTime?)ds.TransTime,
                     ds.GamePeriod,
                     ds.Buy_Value,
                     ds.Buy_Point
                     ,ds.GameLocalPeriod
               )
                ).ToList();
            #region
            foreach (var GameLogitem in GameLog)
            {
                DataRow[] usrrow = RunnerF.MemberSource.Select("User_ContactID='" + GameLogitem.Wgl_ContantID + "'");
                if (usrrow.Length == 0)
                {
                    continue;
                }
                GameLogitem.Wgl_Contact = usrrow[0].Field<string>("User_Contact");
            }
            #endregion

            BS_GameLogNotDeal.DataSource = GameLog;


        }

        private void CB_AllNotDeal_CheckedChanged(object sender, EventArgs e)
        {
            Dtp_DownloadDate_ValueChanged(null, null);
        }

        protected class GameLogClass
        {
            public GameLogClass(string P_Wgl_Contant, string P_Wgl_ContantID
                , DateTime? P_Wgl_TransTime, string P_Wgl_GamePeriod
                , string P_Wgl_Buy_Value, decimal? P_Wgl_Buy_Point, string P_Wgl_GamePrivatePeriod)
            {
                _Wgl_Contact = P_Wgl_Contant;
                _Wgl_ContactID = P_Wgl_ContantID;
                _Wgl_TransTime = P_Wgl_TransTime;
                _Wgl_GamePeriod = P_Wgl_GamePeriod;
                _Wgl_Buy_Value = P_Wgl_Buy_Value;
                _Wgl_Buy_Point = P_Wgl_Buy_Point;
                _Wgl_GamePrivatePeriod = P_Wgl_GamePrivatePeriod;
            }
            private string _Wgl_Contact = "";
            private string _Wgl_ContactID = "";
            private DateTime? _Wgl_TransTime = null;
            private string _Wgl_GamePeriod = "";
            private string _Wgl_GamePrivatePeriod = "";
            private string _Wgl_Buy_Value = "";
            private decimal? _Wgl_Buy_Point = null;


            public string Wgl_Contact { get { return _Wgl_Contact; } set { _Wgl_Contact = value; } }
            public string Wgl_ContantID { get { return _Wgl_ContactID; } set { _Wgl_ContactID = value; } }
            public DateTime? Wgl_TransTime { get { return _Wgl_TransTime; } set { _Wgl_TransTime = value; } }
            public string Wgl_GamePeriod { get { return _Wgl_GamePeriod; } set { _Wgl_GamePeriod = value; } }
            public string Wgl_Buy_Value { get { return _Wgl_Buy_Value; } set { _Wgl_Buy_Value = value; } }
            public decimal? Wgl_Buy_Point { get { return _Wgl_Buy_Point; } set { _Wgl_Buy_Point = value; } }
            public string Wgl_GamePrivatePeriod { get { return _Wgl_GamePrivatePeriod; } set { _Wgl_GamePrivatePeriod = value; } }

        }

    }

}
