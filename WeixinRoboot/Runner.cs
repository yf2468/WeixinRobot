﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
namespace WeixinRoboot
{
    public partial class RunnerForm : Form
    {
        public JObject _Members = null;
        public DataTable MemberSource = null;
        public DataTable ReplySource = null;


        public Boolean MembersSet_firstrun { get; set; }

        public void MembersSet(JObject value)
        {


            _Members = value;
            // SetMembers();
            System.Threading.Thread asyncData = new System.Threading.Thread(new System.Threading.ThreadStart(SetMembers));

            asyncData.Start();



            //Set结束
        }


        private void SetMembers()
        {
            NetFramework.Console.WriteLine("开始更新更新联系人" + DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss:fff"));



            //this.Invoke(new Action(() =>
            //{
            Linq.dbDataContext db = new Linq.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");
            this.Invoke(new Action(() => { BS_Contact.DataSource = null; }));
            foreach (var item in (_Members["MemberList"]) as JArray)
            {
                string UserNametempID = "";
                string NickName = "";
                string RemarkName = "";
                string HeadImgUrl = "";
                try
                {

                    UserNametempID = (item["UserName"] as JValue).Value.ToString();
                    NickName = (item["NickName"] as JValue).Value.ToString();
                    RemarkName = (item["RemarkName"] as JValue).Value.ToString();
                    HeadImgUrl = (item["HeadImgUrl"] as JValue).Value.ToString();

                    //NetFramework.Console.WriteLine("更新联系人" + NickName);
                    //Application.DoEvents();

                    System.Text.RegularExpressions.Regex FindSeq = new System.Text.RegularExpressions.Regex("seq=([0-9])+");

                    string Seq = FindSeq.Match(HeadImgUrl).Value;
                    //Seq = Seq.Substring(Seq.IndexOf("=") + 1);

                    Seq = RemarkName == "" ? NetFramework.Util_WEB.CleanHtml(NickName) : RemarkName;

                    Linq.WX_UserReply usrc = db.WX_UserReply.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey && t.WX_UserName == Seq && t.WX_SourceType == "微");
                    if (usrc == null)
                    {
                        Linq.WX_UserReply newusrc = new Linq.WX_UserReply();
                        newusrc.aspnet_UserID = GlobalParam.UserKey;
                        newusrc.WX_UserName = Seq;
                        newusrc.WX_SourceType = "微";
                        newusrc.RemarkName = RemarkName;
                        newusrc.NickName = NetFramework.Util_WEB.CleanHtml(NickName);

                        newusrc.IsCaculateFuli = true;
                        if (UserNametempID.StartsWith("@@") == false)
                        {
                            newusrc.IsReply = true;
                        }
                        else
                        {
                            newusrc.IsReply = false;
                        }
                        db.WX_UserReply.InsertOnSubmit(newusrc);


                    } //初始化，添加到数据库或同步数据库
                    else
                    {
                        if ((usrc.RemarkName != RemarkName) || (usrc.NickName != NetFramework.Util_WEB.CleanHtml(NickName))
                            )
                        {

                            usrc.RemarkName = RemarkName;
                            usrc.NickName = NetFramework.Util_WEB.CleanHtml(NickName);

                        }
                        if (UserNametempID.StartsWith("@@") == false && Seq != "0")
                        {
                            usrc.IsReply = true;
                        }



                    } //初始化，添加到数据库或同步数据库
                    db.SubmitChanges();
                    usrc = db.WX_UserReply.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey && t.WX_UserName == Seq && t.WX_SourceType == "微");



                    DataRow[] Lists = MemberSource.Select("User_ContactTEMPID='" + UserNametempID + "' and User_SourceType='微'");
                    DataRow newr = null;
                    if (Lists.Length == 0)
                    {
                        newr = MemberSource.NewRow();
                        MemberSource.Rows.Add(newr);
                    }
                    else
                    {
                        newr = Lists[0];
                    }
                    newr.SetField("User_ContactID", Seq);
                    newr.SetField("User_ContactTEMPID", UserNametempID);
                    newr.SetField("User_ContactType", UserNametempID.StartsWith("@@") ? "群" : "个人");
                    newr.SetField("User_SourceType", "微");
                    newr.SetField("User_Contact", RemarkName == "" ? NickName : RemarkName);


                    newr.SetField("User_IsReply", usrc.IsReply);
                    newr.SetField("User_IsAdmin", usrc.IsAdmin);
                    newr.SetField("User_IsBallPIC", usrc.IsBallPIC);

                    if (UserNametempID.StartsWith("@@") == false && Seq != "0")
                    {
                        newr.SetField("User_IsReply", usrc == null ? false : usrc.IsReply);
                    }


                    newr.SetField("User_IsReceiveTransfer", usrc == null ? false : usrc.IsReceiveTransfer);
                    newr.SetField("User_IsCaculateFuli", usrc == null ? false : usrc.IsCaculateFuli);

                    newr.SetField("User_IsBoss", usrc == null ? false : (usrc.IsBoss == null ? false : usrc.IsBoss));

                    newr.SetField("User_FiveMinuteMode", usrc == null ? false : (usrc.FiveMinuteMode == null ? false : usrc.FiveMinuteMode));

                    newr.SetField("User_HkMode", usrc == null ? false : (usrc.HkMode == null ? false : usrc.HkMode));

                    newr.SetField("User_AozcMode", usrc == null ? false : (usrc.AozcMode == null ? false : usrc.AozcMode));

                    newr.SetField("User_ChongqingMode", usrc == null ? false : (usrc.ChongqingMode == null ? false : usrc.ChongqingMode));
                  
                    
                    //var UpdateLogs = ReplySource.AsEnumerable().Where(t => t.Field<string>("Reply_ContactID") == Seq);
                    //foreach (var logitem in UpdateLogs)
                    //{
                    //    logitem.SetField("Reply_ContactTEMPID", UserNametempID);
                    //    logitem.SetField("Reply_Contact", RemarkName == "" ? NickName : RemarkName);
                    //}
                }
                catch (Exception AnyError)
                {
                    MessageBox.Show(RemarkName == "" ? NickName : RemarkName + "联系人保存失败");
                    NetFramework.Console.WriteLine(AnyError.Message);
                    NetFramework.Console.WriteLine(AnyError.StackTrace);
                }


            }//成员列表循环


            // BS_Contact.Sort = "User_Contact";
            // }));


            this.Invoke(new Action(() => { BS_Contact.DataSource = MemberSource; }));
            NetFramework.Console.WriteLine("更新联系人完成" + DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss:fff"));



        }

        public JObject RoomMembers = null;
        public DataTable RoomMerbersSource = null;


        public void SetYixinMembers(List<StartForm.YixinContact> contact, List<StartForm.YixinContactInfo> contactinf)
        {
            NetFramework.Console.WriteLine("开始更新更新易信联系人" + DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss:fff"));
            try
            {

                if (contactinf.Count == 0)
                {
                    return;
                }
                this.Invoke(new Action(() =>
                {
                    Linq.dbDataContext db = new Linq.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
                    db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");
                    BS_Contact.DataSource = null;
                    foreach (var item in contact)
                    {
                        StartForm.YixinContactInfo yf = contactinf.SingleOrDefault(t => t.ContactID == item.ContactID);

                        string UserNametempID = item.ContactID;
                        string NickName = "";
                        if (yf != null)
                        {
                            NickName = yf.ContactName;
                        }


                        string RemarkName = item.ContactRemarkName;


                        //NetFramework.Console.WriteLine("更新联系人" + NickName);
                        //Application.DoEvents();




                        Linq.WX_UserReply usrc = db.WX_UserReply.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey && t.WX_UserName == item.ContactID && t.WX_SourceType == "易");
                        if (usrc == null)
                        {
                            Linq.WX_UserReply newusrc = new Linq.WX_UserReply();
                            newusrc.aspnet_UserID = GlobalParam.UserKey;
                            newusrc.WX_UserName = item.ContactID;
                            newusrc.RemarkName = RemarkName;
                            newusrc.NickName = NetFramework.Util_WEB.CleanHtml(NickName);
                            newusrc.WX_SourceType = "易";
                            newusrc.IsCaculateFuli = true;
                            if (item.ContactType == "个人")
                            {
                                newusrc.IsReply = true;
                            }
                            else
                            {
                                newusrc.IsReply = false;
                            }
                            newusrc.FiveMinuteMode = false;
                            newusrc.HkMode = false;
                            newusrc.AozcMode = false;
                            db.WX_UserReply.InsertOnSubmit(newusrc);


                        } //初始化，添加到数据库或同步数据库
                        else
                        {
                            if ((usrc.RemarkName != RemarkName) || (usrc.NickName != NetFramework.Util_WEB.CleanHtml(NickName))
                                )
                            {

                                usrc.RemarkName = RemarkName;
                                usrc.NickName = NetFramework.Util_WEB.CleanHtml(NickName);

                            }
                            if (item.ContactType == "个人")
                            {
                                usrc.IsReply = true;
                            }



                        } //初始化，添加到数据库或同步数据库
                        db.SubmitChanges();
                        usrc = db.WX_UserReply.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey && t.WX_UserName == item.ContactID && t.WX_SourceType == "易");



                        DataRow[] Lists = MemberSource.Select("User_ContactID='" + item.ContactID.Replace("'", "''") + "' and User_SourceType='易'");
                        DataRow newr = null;
                        if (Lists.Length == 0)
                        {
                            newr = MemberSource.NewRow();
                            MemberSource.Rows.Add(newr);
                        }
                        else
                        {
                            newr = Lists[0];
                        }
                        newr.SetField("User_ContactID", item.ContactID);
                        newr.SetField("User_ContactTEMPID", UserNametempID);
                        newr.SetField("User_ContactType", item.ContactType);
                        newr.SetField("User_SourceType", "易");
                        newr.SetField("User_Contact", RemarkName == "" ? NickName : RemarkName);

                        newr.SetField("User_IsReply", usrc.IsReply);

                        if (item.ContactType == "个人")
                        {
                            newr.SetField("User_IsReply", usrc == null ? false : usrc.IsReply);
                        }


                        newr.SetField("User_IsReceiveTransfer", usrc == null ? false : usrc.IsReceiveTransfer);
                        newr.SetField("User_IsCaculateFuli", usrc == null ? false : usrc.IsCaculateFuli);

                        newr.SetField("User_IsBoss", usrc == null ? false : (usrc.IsBoss == null ? false : usrc.IsBoss));


                        newr.SetField("User_FiveMinuteMode", usrc == null ? false : (usrc.FiveMinuteMode == null ? false : usrc.FiveMinuteMode));
                        newr.SetField("User_HkMode", usrc == null ? false : (usrc.HkMode == null ? false : usrc.HkMode));

                        newr.SetField("User_AozcMode", usrc == null ? false : (usrc.AozcMode == null ? false : usrc.AozcMode));

                        newr.SetField("User_ChongqingMode", usrc == null ? false : (usrc.ChongqingMode == null ? false : usrc.ChongqingMode));
                        //var UpdateLogs = ReplySource.AsEnumerable().Where(t => t.Field<string>("Reply_ContactID") == Seq);
                        //foreach (var logitem in UpdateLogs)
                        //{
                        //    logitem.SetField("Reply_ContactTEMPID", UserNametempID);
                        //    logitem.SetField("Reply_Contact", RemarkName == "" ? NickName : RemarkName);
                        //}


                    }//成员列表循环

                    BS_Contact.DataSource = MemberSource;
                    // BS_Contact.Sort = "User_Contact";
                }));
            }
            catch (Exception AnyError)
            {

                NetFramework.Console.WriteLine(AnyError.Message);
                NetFramework.Console.WriteLine(AnyError.StackTrace);
            }
            NetFramework.Console.WriteLine("更新易信联系人完成" + DateTime.Now.ToString("yyyy-MM-dd HH::mm:ss:fff"));

        }


        public RunnerForm()
        {
            InitializeComponent();
            Linq.dbDataContext db = new Linq.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");


            dtp_StartDate.Value = DateTime.Today.AddDays(-3);
            dtp_EndDate.Value = DateTime.Today.AddMonths(1);

            ReplySource = new DataTable();

            ReplySource.Columns.Add("Reply_Contact");
            ReplySource.Columns.Add("Reply_ContactID");
            ReplySource.Columns.Add("Reply_SourceType");
            ReplySource.Columns.Add("Reply_ContactTEMPID");
            ReplySource.Columns.Add("Reply_ReceiveContent");
            ReplySource.Columns.Add("Reply_ReplyContent");
            ReplySource.Columns.Add("Reply_ReceiveTime", typeof(DateTime));
            ReplySource.Columns.Add("Reply_ReplyTime", typeof(DateTime));



            MemberSource = new DataTable();
            MemberSource.Columns.Add("User_Contact");
            MemberSource.Columns.Add("User_ContactType");
            MemberSource.Columns.Add("User_ContactID");
            MemberSource.Columns.Add("User_ContactTEMPID");
            MemberSource.Columns.Add("User_IsReply", typeof(Boolean));
            MemberSource.Columns.Add("User_IsReceiveTransfer", typeof(Boolean));
            MemberSource.Columns.Add("User_IsCaculateFuli", typeof(Boolean));
            MemberSource.Columns.Add("User_SourceType");
            MemberSource.Columns.Add("User_IsBoss", typeof(Boolean));

            MemberSource.Columns.Add("User_IsBallPIC", typeof(Boolean));
            MemberSource.Columns.Add("User_ISSendCard", typeof(Boolean));
            MemberSource.Columns.Add("User_IsAdmin", typeof(Boolean));

            MemberSource.Columns.Add("User_FiveMinuteMode", typeof(Boolean));
            MemberSource.Columns.Add("User_HkMode", typeof(Boolean));
              MemberSource.Columns.Add("User_AozcMode", typeof(Boolean));

              MemberSource.Columns.Add("User_ChongqingMode", typeof(Boolean));

            BS_ReceiveReply.DataSource = ReplySource;


            dtp_StartDate.Value = DateTime.Today.AddDays(-3);
            dtp_EndDate.Value = DateTime.Today.AddMonths(1);

            BS_Contact.DataSource = MemberSource;

            LoadReplyLog("", "");

            TM_Refresh.Start();
        }

        private void LoadReplyLog(string SelectUser, string SourceType)
        {

            Linq.dbDataContext db = new Linq.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");

            //ReplySource.Columns.Add("Reply_Contact");
            //ReplySource.Columns.Add("Reply_ContactID");
            //ReplySource.Columns.Add("Reply_ContactTEMPID");
            //ReplySource.Columns.Add("Reply_ReceiveContent");
            //ReplySource.Columns.Add("Reply_ReplyContent");
            //ReplySource.Columns.Add("Reply_ReceiveTime", typeof(object));
            //ReplySource.Columns.Add("Reply_ReplyTime", typeof(object));

            DataTable PreRend = NetFramework.Util_Sql.RunSqlDataTable("LocalSqlServer"
                  , "Select case when ur.RemarkName<>'' then ur.RemarkName+'@#'+ur.NickName else ur.NickName end as Reply_Contact ,RL.WX_UserName as Reply_ContactID,RL.WX_SourceType as Reply_SourceType "

              + " ,'' as Reply_ContactTEMPID"
              + " ,ReceiveContent as Reply_ReceiveContent"
              + " ,ReplyContent as Reply_ReplyContent"

              + " ,ReceiveTime as ReplyReceiveTime"
              + " ,ReplyTime as Reply_ReplyTime"

                  + " from WX_UserReplyLog RL with (nolock) join WX_UserReply ur with (nolock) on RL.aspnet_UserID=ur.aspnet_UserID and RL.WX_UserName=ur.WX_UserName and   RL.WX_SourceType=ur.WX_SourceType  where RL.aspnet_UserID='" + GlobalParam.UserKey.ToString() + "' and "
                  + "ReceiveTime >='" + dtp_StartDate.Value.Date.ToString("yyyy-MM-dd") + "' and "
                  + "ReceiveTime <'" + dtp_EndDate.Value.Date.ToString("yyyy-MM-dd") + "'  "
                  + (SelectUser == "" ? "" : " and RL.WX_UserName='" + SelectUser.Replace("'","''") + "' ")
                  + (SourceType == "" ? "" : " and RL.WX_SourceType='" + SourceType + "' ")

                  );
            if (ReplySource == null)
            {
                return;
            }
            ReplySource.Rows.Clear();
            foreach (DataRow item in PreRend.Rows)
            {
                string ContactID = item.Field<string>("Reply_ContactID");
                //string SourceType = item.Field<string>("Reply_SourceType");
                DataRow[] memusr = MemberSource.Select("User_ContactID='" + ContactID.Replace("'", "''") + "' and User_SourceType='" + SourceType + "'");
                if (memusr.Length != 0)
                {
                    item.SetField("Reply_ContactTEMPID", memusr[0].Field<string>("User_ContactTEMPID"));
                    item.SetField("Reply_Contact", memusr[0].Field<string>("User_Contact"));

                }
                else
                {
                    //item.SetField("Reply_Contact", "非此微信号联系人");

                }
                ReplySource.Rows.Add(item.ItemArray);
            }


            BS_ReceiveReply.Sort = "Reply_ContactID,Reply_ReceiveTime";


            if (dtp_StartDate.Value == null || dtp_EndDate.Value == null)
            {
                return;
            }

            var datasource = from ds in db.WX_UserReplyLog
                             join dsgame in db.WX_UserGameLog
                             on new { ds.aspnet_UserID, ds.WX_UserName, ds.ReceiveTime, ds.WX_SourceType } equals new { dsgame.aspnet_UserID, dsgame.WX_UserName, ReceiveTime = dsgame.TransTime, WX_SourceType = dsgame.WX_SourceType }
                             into leftdsggame
                             from dsgame2 in leftdsggame.DefaultIfEmpty()
                             where ds.ReceiveTime >= dtp_StartDate.Value
                             && ds.ReceiveTime < dtp_EndDate.Value
                             && ds.aspnet_UserID == GlobalParam.UserKey
                             && ds.WX_UserName == SelectUser
                             && ds.WX_SourceType == SourceType
                             orderby ds.ReceiveTime descending
                             select new
                             {
                                 ds.ReceiveTime,
                                 ds.ReceiveContent,
                                 ds.aspnet_UserID,
                                 ds.WX_UserName,
                                 ds.WX_SourceType,
                                 TransTime = (DateTime?)dsgame2.TransTime,
                                 dsgame2.GamePeriod
                                 ,
                                 GameLocalPeriod = dsgame2.GameLocalPeriod
                                 ,
                                 dsgame2.GameResult
                                 ,
                                 dsgame2.Buy_Value
                                 ,
                                 dsgame2.Buy_Type

                                 ,
                                 dsgame2.Buy_Point,
                                 dsgame2.Result_Point

                             };
            GV_GameLog.DataSource = datasource;
        }


        void RelySource_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            Linq.dbDataContext db = new Linq.dbDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            db.ExecuteCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED");

            if (e.Row != null)
            {
                return;
            }
            Linq.WX_UserReply checkreply = db.WX_UserReply.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey && t.WX_UserName == e.Row.Field<string>("Reply_ContactID") && t.WX_SourceType == e.Row.Field<string>("Reply_SourceType"));
            if (checkreply.IsReply == true)
            {
                string Reply_ContactID = e.Row.Field<string>("Reply_ContactID");
                string Reply_SourceType = e.Row.Field<string>("Reply_SourceType");
                string Reply_ReceiveTime = e.Row.Field<string>("Reply_ReceiveTime");
                Linq.WX_UserReplyLog log = db.WX_UserReplyLog.SingleOrDefault(t => t.aspnet_UserID == GlobalParam.UserKey
                     && t.WX_UserName == Reply_ContactID
                     && t.WX_SourceType == Reply_SourceType
                     && t.ReceiveTime == Convert.ToDateTime(Reply_ReceiveTime)
                     );
                if (log == null)
                {
                    db.WX_UserReplyLog.InsertOnSubmit(log);
                    db.SubmitChanges();
                }
            }


        }



        private void TM_Refresh_Tick(object sender, EventArgs e)
        {
            BS_Contact.Filter = "User_Contact like '%" + tb_ContactFilter.Text + "%'";
            BS_ReceiveReply.Filter = "";
            this.Refresh();

        }




        public StartForm StartF = null;
        private void MI_FasongXinxi_Click(object sender, EventArgs e)
        {

            SendMessage SM = new SendMessage();
            SM.UserRow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;
            SM.StartF = StartF;
            SM.RunnerF = this;
            SM.Show();


        }

        private void gv_contact_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void gv_ReceiveReply_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void tb_ContactFilter_TextChanged(object sender, EventArgs e)
        {
            BS_Contact.Filter = "User_Contact like '%" + tb_ContactFilter.Text + "%'";
        }





        private void MI_ChongZhi_Click(object sender, EventArgs e)
        {

            SendCharge sc = new SendCharge();
            sc.RunnerF = this;
            sc.StartF = this.StartF;
            sc.UserRow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;
            sc.Mode = "Charge";
            sc.Show();
        }

        private void Runner_Load(object sender, EventArgs e)
        {
            TM_Refresh.Start();
        }

        private void gv_contact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

                return;
            }

            if (gv_contact.SelectedRows.Count != 0)
            {
                gv_contact.ContextMenuStrip = MouseMenuReply;
                gv_contact.ContextMenuStrip.Show(
                    this, this.PointToClient(MousePosition)
                    );

                LoadReplyLog(((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row.Field<string>("User_ContactID")
                    , ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row.Field<string>("User_SourceType")
                    );


            }
            else
            {

            }

        }

        private void dtp_Start_ValueChanged(object sender, EventArgs e)
        {
            LoadReplyLog("", "");
        }

        private void dtp_End_ValueChanged(object sender, EventArgs e)
        {
            LoadReplyLog("", "");
        }

        private void gv_contact_Leave(object sender, EventArgs e)
        {
            gv_contact.ClearSelection();
        }

        private void MI_OrderManual_Click(object sender, EventArgs e)
        {

            SendManulOrder SM = new SendManulOrder();
            SM.StartF = this.StartF;
            SM.RunnerF = this;
            SM.UserRow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;
            SM.Show();

        }

        private void MI_CleanUp_Click(object sender, EventArgs e)
        {

            SendCharge sc = new SendCharge();
            sc.RunnerF = this;
            sc.StartF = this.StartF;
            sc.UserRow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;
            sc.Mode = "CleanUp";
            sc.Show();
        }

        private void gv_contact_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void MI_IsReply_Click(object sender, EventArgs e)
        {


            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;



                string Result = Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("自动", editrow, DateTime.Now);


                if (Result != "")
                {
                    MessageBox.Show(Result);
                }

            }
        }

        private void MI_CancelIsReply_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消自动", editrow, DateTime.Now);


            }
        }

        private void MI_ReceiveTrans_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("转发", editrow, DateTime.Now);


            }
        }

        private void MI_CancelReceiveTrans_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消转发", editrow, DateTime.Now);


            }
        }

        private void BtnSaveAndDeal_Click(object sender, EventArgs e)
        {
            try
            {
                bool Newdb = false;
                Linq.ProgramLogic.ShiShiCaiMode subm = Linq.ProgramLogic.ShiShiCaiMode.重庆时时彩;
                if (cb_gamemode.SelectedItem!=null&&cb_gamemode.SelectedItem.ToString()=="重庆时时彩")
                {
                    subm = Linq.ProgramLogic.ShiShiCaiMode.重庆时时彩; 
                }
                else if (cb_gamemode.SelectedItem != null && cb_gamemode.SelectedItem.ToString() == "五分彩")
                {
                    subm = Linq.ProgramLogic.ShiShiCaiMode.五分彩;
                }
                else if (cb_gamemode.SelectedItem != null && cb_gamemode.SelectedItem.ToString() == "香港时时彩")
                {
                    subm = Linq.ProgramLogic.ShiShiCaiMode.香港时时彩;
                }
                else if (cb_gamemode.SelectedItem != null && cb_gamemode.SelectedItem.ToString() == "澳洲幸运5")
                {
                    subm = Linq.ProgramLogic.ShiShiCaiMode.澳洲幸运5;
                }
                Linq.ProgramLogic.NewGameResult(
                            fd_Num1.Text + " " + fd_Num2.Text + " " + fd_Num3.Text + " " + fd_Num4.Text + " " + fd_Num5.Text, fd_day.Value.ToString("yyMMdd") + fd_Period.Text, out Newdb,subm);
                DateTime day = DateTime.Now;
                if (day.Hour <= 8)
                {
                    day = day.AddDays(-1);
                }
                if (Newdb)
                {
                    StartF.ShiShiCaiDealGameLogAndNotice();
                }
                StartF.DrawChongqingshishicai(day,subm);
                StartF.SendChongqingResult(subm);
            }
            catch (Exception AnyError)
            {

                NetFramework.Console.WriteLine(AnyError.Message);
                NetFramework.Console.WriteLine(AnyError.StackTrace);
            }


        }

        private void MI_FuliCheck_Click(object sender, EventArgs e)
        {

            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("福利", editrow, DateTime.Now);


            }
        }

        private void MI_CancelFuliCheck_Click(object sender, EventArgs e)
        {

            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消福利", editrow, DateTime.Now);


            }
        }

        private void Btn_Resend_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.Hour <=8 )
                {
                    StartF.DrawChongqingshishicai(DateTime.Today.AddDays(-1), Linq.ProgramLogic.ShiShiCaiMode.重庆时时彩);
                    StartF.DrawChongqingshishicai(DateTime.Today.AddDays(-1), Linq.ProgramLogic.ShiShiCaiMode.五分彩);
                    StartF.DrawChongqingshishicai(DateTime.Today.AddDays(-1), Linq.ProgramLogic.ShiShiCaiMode.香港时时彩);
                    StartF.DrawChongqingshishicai(DateTime.Today.AddDays(-1), Linq.ProgramLogic.ShiShiCaiMode.澳洲幸运5);
             
                }
                else
                {
                    StartF.DrawChongqingshishicai(DateTime.Today, Linq.ProgramLogic.ShiShiCaiMode.重庆时时彩);
                    StartF.DrawChongqingshishicai(DateTime.Today, Linq.ProgramLogic.ShiShiCaiMode.五分彩);
                    StartF.DrawChongqingshishicai(DateTime.Today, Linq.ProgramLogic.ShiShiCaiMode.香港时时彩);
                    StartF.DrawChongqingshishicai(DateTime.Today, Linq.ProgramLogic.ShiShiCaiMode.澳洲幸运5);

                }

                StartF.ShiShiCaiDealGameLogAndNotice();
                StartF.SendChongqingResult(Linq.ProgramLogic.ShiShiCaiMode.重庆时时彩);
                StartF.SendChongqingResult(Linq.ProgramLogic.ShiShiCaiMode.五分彩);
                StartF.SendChongqingResult(Linq.ProgramLogic.ShiShiCaiMode.香港时时彩);
                StartF.SendChongqingResult(Linq.ProgramLogic.ShiShiCaiMode.澳洲幸运5);
            }
            catch (Exception AnyError)
            {
                NetFramework.Console.Write(AnyError.Message);

            }
        }

        private void 老板查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("老板查询", editrow, DateTime.Now);


            }
        }

        private void 取消老板查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消老板查询", editrow, DateTime.Now);


            }
        }

        private void MI_SendPCS_Click(object sender, EventArgs e)
        {

        }

        private void btn_resendballl_Click(object sender, EventArgs e)
        {

        }

        private void MI_BALLPIC_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("球赛图片", editrow, DateTime.Now);


            }
        }

        private void MI_CancelBALLPIC_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消球赛图片", editrow, DateTime.Now);


            }
        }



        private void MI_WebSendSetting_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;

                string ContactID = editrow.Field<string>("User_ContactID");
                string SourceType = editrow.Field<string>("User_SourceType");

                string ContactName = editrow.Field<string>("User_Contact");

                WebWeChatImageSetting wset = new WebWeChatImageSetting();
                wset.WX_SourceType = SourceType;
                wset.WX_UserName = ContactID;
                wset.Show();
                wset.Text = ContactName + "发图设置";
            }
        }

        private void MI_HUIYAN_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("会员", editrow, DateTime.Now);


            }
        }

        private void mi_cancelhuiyan_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("取消会员", editrow, DateTime.Now);


            }
        }

        private void MI_ChongQingMode_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("重庆时时彩模式", editrow, DateTime.Now);


            }
        }

        private void MI_FiveMinuteMode_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("五分彩模式", editrow, DateTime.Now);


            }
        }

        private void MI_HkMode_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("香港时时彩模式", editrow, DateTime.Now);


            }
        }

        private void 澳洲幸运5模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gv_contact.SelectedRows.Count != 0)
            {
                DataRow editrow = ((DataRowView)gv_contact.SelectedRows[0].DataBoundItem).Row;


                Linq.ProgramLogic.WX_UserReplyLog_MySendCreate("澳洲幸运5模式", editrow, DateTime.Now);


            }
        }







    }
}
