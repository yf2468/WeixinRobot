﻿namespace WeixinRoboot
{
    partial class UserSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.fd_username = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_Islock = new System.Windows.Forms.Label();
            this.fd_password = new System.Windows.Forms.TextBox();
            this.fd_IsLock = new System.Windows.Forms.CheckBox();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.lbl_NewGameSend = new System.Windows.Forms.Label();
            this.fd_NewGameSend = new System.Windows.Forms.CheckBox();
            this.lbl_ActiveCode = new System.Windows.Forms.Label();
            this.fd_activecode = new System.Windows.Forms.TextBox();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.fd_EndDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_Build = new System.Windows.Forms.Button();
            this.lbl_IsBlock = new System.Windows.Forms.Label();
            this.Fd_IsBlock = new System.Windows.Forms.CheckBox();
            this.fd_BossUserName = new System.Windows.Forms.TextBox();
            this.lbl_boss = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.fd_MaxPlayerCount = new System.Windows.Forms.TextBox();
            this.lbl_tracecount = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.FD_ReceiveOrder = new System.Windows.Forms.CheckBox();
            this.lbl_pic = new System.Windows.Forms.Label();
            this.FD_SendPIC = new System.Windows.Forms.CheckBox();
            this.lbl_TimeLimit1 = new System.Windows.Forms.Label();
            this.fd_SendTimeStart1 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeEnd1 = new System.Windows.Forms.TextBox();
            this.lbl_TimeLimit2 = new System.Windows.Forms.Label();
            this.lbl_TimeLimit3 = new System.Windows.Forms.Label();
            this.lbl_TimeLimit4 = new System.Windows.Forms.Label();
            this.fd_SendTimeStart2 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeEnd2 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeStart3 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeEnd3 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeStart4 = new System.Windows.Forms.TextBox();
            this.fd_SendTimeEnd4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fd_ImageTopText = new System.Windows.Forms.TextBox();
            this.fd_ImageEndText = new System.Windows.Forms.TextBox();
            this.ep_wf = new System.Windows.Forms.ErrorProvider(this.components);
            this.TC_Main = new System.Windows.Forms.TabControl();
            this.TP_Data = new System.Windows.Forms.TabPage();
            this.TP_UserList = new System.Windows.Forms.TabPage();
            this.gv_UserList = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLockedOut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BS_UserList = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_wf)).BeginInit();
            this.TC_Main.SuspendLayout();
            this.TP_Data.SuspendLayout();
            this.TP_UserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fd_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pwd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Islock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fd_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fd_IsLock, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Load, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_NewGameSend, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.fd_NewGameSend, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ActiveCode, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.fd_activecode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_endDate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.fd_EndDate, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Build, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_IsBlock, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Fd_IsBlock, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fd_BossUserName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_boss, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.fd_MaxPlayerCount, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tracecount, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_order, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.FD_ReceiveOrder, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pic, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.FD_SendPIC, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeLimit1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeStart1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeEnd1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeLimit2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeLimit3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeLimit4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeStart2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeEnd2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeStart3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeEnd3, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeStart4, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.fd_SendTimeEnd4, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.fd_ImageTopText, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.fd_ImageEndText, 4, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(3, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(47, 12);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "会员号:";
            // 
            // fd_username
            // 
            this.fd_username.Location = new System.Drawing.Point(103, 3);
            this.fd_username.Name = "fd_username";
            this.fd_username.Size = new System.Drawing.Size(174, 21);
            this.fd_username.TabIndex = 1;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(3, 30);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(35, 12);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "密码:";
            // 
            // lbl_Islock
            // 
            this.lbl_Islock.AutoSize = true;
            this.lbl_Islock.Location = new System.Drawing.Point(3, 60);
            this.lbl_Islock.Name = "lbl_Islock";
            this.lbl_Islock.Size = new System.Drawing.Size(35, 12);
            this.lbl_Islock.TabIndex = 3;
            this.lbl_Islock.Text = "锁定:";
            // 
            // fd_password
            // 
            this.fd_password.Location = new System.Drawing.Point(103, 33);
            this.fd_password.Name = "fd_password";
            this.fd_password.Size = new System.Drawing.Size(174, 21);
            this.fd_password.TabIndex = 5;
            // 
            // fd_IsLock
            // 
            this.fd_IsLock.AutoSize = true;
            this.fd_IsLock.Location = new System.Drawing.Point(103, 63);
            this.fd_IsLock.Name = "fd_IsLock";
            this.fd_IsLock.Size = new System.Drawing.Size(15, 14);
            this.fd_IsLock.TabIndex = 6;
            this.fd_IsLock.UseVisualStyleBackColor = true;
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(283, 3);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(75, 23);
            this.Btn_Load.TabIndex = 9;
            this.Btn_Load.Text = "加载";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // lbl_NewGameSend
            // 
            this.lbl_NewGameSend.AutoSize = true;
            this.lbl_NewGameSend.Location = new System.Drawing.Point(3, 90);
            this.lbl_NewGameSend.Name = "lbl_NewGameSend";
            this.lbl_NewGameSend.Size = new System.Drawing.Size(89, 24);
            this.lbl_NewGameSend.TabIndex = 10;
            this.lbl_NewGameSend.Text = "开奖立即发送结果";
            // 
            // fd_NewGameSend
            // 
            this.fd_NewGameSend.AutoSize = true;
            this.fd_NewGameSend.Location = new System.Drawing.Point(103, 93);
            this.fd_NewGameSend.Name = "fd_NewGameSend";
            this.fd_NewGameSend.Size = new System.Drawing.Size(15, 14);
            this.fd_NewGameSend.TabIndex = 11;
            this.fd_NewGameSend.UseVisualStyleBackColor = true;
            // 
            // lbl_ActiveCode
            // 
            this.lbl_ActiveCode.AutoSize = true;
            this.lbl_ActiveCode.Location = new System.Drawing.Point(383, 30);
            this.lbl_ActiveCode.Name = "lbl_ActiveCode";
            this.lbl_ActiveCode.Size = new System.Drawing.Size(53, 12);
            this.lbl_ActiveCode.TabIndex = 12;
            this.lbl_ActiveCode.Text = "激活码：";
            // 
            // fd_activecode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fd_activecode, 2);
            this.fd_activecode.Location = new System.Drawing.Point(383, 63);
            this.fd_activecode.Multiline = true;
            this.fd_activecode.Name = "fd_activecode";
            this.tableLayoutPanel1.SetRowSpan(this.fd_activecode, 2);
            this.fd_activecode.Size = new System.Drawing.Size(274, 54);
            this.fd_activecode.TabIndex = 13;
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(383, 120);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(101, 12);
            this.lbl_endDate.TabIndex = 14;
            this.lbl_endDate.Text = "激活码到期时间：";
            // 
            // fd_EndDate
            // 
            this.fd_EndDate.Enabled = false;
            this.fd_EndDate.Location = new System.Drawing.Point(383, 153);
            this.fd_EndDate.Name = "fd_EndDate";
            this.fd_EndDate.Size = new System.Drawing.Size(174, 21);
            this.fd_EndDate.TabIndex = 15;
            // 
            // Btn_Build
            // 
            this.Btn_Build.Location = new System.Drawing.Point(383, 183);
            this.Btn_Build.Name = "Btn_Build";
            this.Btn_Build.Size = new System.Drawing.Size(75, 23);
            this.Btn_Build.TabIndex = 16;
            this.Btn_Build.Text = "生成激活码";
            this.Btn_Build.UseVisualStyleBackColor = true;
            this.Btn_Build.Click += new System.EventHandler(this.Btn_Build_Click);
            // 
            // lbl_IsBlock
            // 
            this.lbl_IsBlock.AutoSize = true;
            this.lbl_IsBlock.Location = new System.Drawing.Point(3, 120);
            this.lbl_IsBlock.Name = "lbl_IsBlock";
            this.lbl_IsBlock.Size = new System.Drawing.Size(29, 12);
            this.lbl_IsBlock.TabIndex = 17;
            this.lbl_IsBlock.Text = "封盘";
            // 
            // Fd_IsBlock
            // 
            this.Fd_IsBlock.AutoSize = true;
            this.Fd_IsBlock.Location = new System.Drawing.Point(103, 123);
            this.Fd_IsBlock.Name = "Fd_IsBlock";
            this.Fd_IsBlock.Size = new System.Drawing.Size(15, 14);
            this.Fd_IsBlock.TabIndex = 18;
            this.Fd_IsBlock.UseVisualStyleBackColor = true;
            // 
            // fd_BossUserName
            // 
            this.fd_BossUserName.Location = new System.Drawing.Point(563, 3);
            this.fd_BossUserName.Name = "fd_BossUserName";
            this.fd_BossUserName.Size = new System.Drawing.Size(94, 21);
            this.fd_BossUserName.TabIndex = 26;
            // 
            // lbl_boss
            // 
            this.lbl_boss.AutoSize = true;
            this.lbl_boss.Location = new System.Drawing.Point(383, 0);
            this.lbl_boss.Name = "lbl_boss";
            this.lbl_boss.Size = new System.Drawing.Size(47, 12);
            this.lbl_boss.TabIndex = 25;
            this.lbl_boss.Text = "老板号:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(3, 393);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // fd_MaxPlayerCount
            // 
            this.fd_MaxPlayerCount.Location = new System.Drawing.Point(103, 333);
            this.fd_MaxPlayerCount.Name = "fd_MaxPlayerCount";
            this.fd_MaxPlayerCount.Size = new System.Drawing.Size(149, 21);
            this.fd_MaxPlayerCount.TabIndex = 24;
            this.fd_MaxPlayerCount.Text = "50";
            // 
            // lbl_tracecount
            // 
            this.lbl_tracecount.AutoSize = true;
            this.lbl_tracecount.Location = new System.Drawing.Point(3, 330);
            this.lbl_tracecount.Name = "lbl_tracecount";
            this.lbl_tracecount.Size = new System.Drawing.Size(89, 24);
            this.lbl_tracecount.TabIndex = 21;
            this.lbl_tracecount.Text = "跟踪玩家最大数量：";
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Location = new System.Drawing.Point(3, 300);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(77, 12);
            this.lbl_order.TabIndex = 20;
            this.lbl_order.Text = "会员可接单：";
            // 
            // FD_ReceiveOrder
            // 
            this.FD_ReceiveOrder.AutoSize = true;
            this.FD_ReceiveOrder.Location = new System.Drawing.Point(103, 303);
            this.FD_ReceiveOrder.Name = "FD_ReceiveOrder";
            this.FD_ReceiveOrder.Size = new System.Drawing.Size(15, 14);
            this.FD_ReceiveOrder.TabIndex = 23;
            this.FD_ReceiveOrder.UseVisualStyleBackColor = true;
            // 
            // lbl_pic
            // 
            this.lbl_pic.AutoSize = true;
            this.lbl_pic.Location = new System.Drawing.Point(3, 270);
            this.lbl_pic.Name = "lbl_pic";
            this.lbl_pic.Size = new System.Drawing.Size(77, 12);
            this.lbl_pic.TabIndex = 19;
            this.lbl_pic.Text = "会员可发图：";
            // 
            // FD_SendPIC
            // 
            this.FD_SendPIC.AutoSize = true;
            this.FD_SendPIC.Location = new System.Drawing.Point(103, 273);
            this.FD_SendPIC.Name = "FD_SendPIC";
            this.FD_SendPIC.Size = new System.Drawing.Size(15, 14);
            this.FD_SendPIC.TabIndex = 22;
            this.FD_SendPIC.UseVisualStyleBackColor = true;
            // 
            // lbl_TimeLimit1
            // 
            this.lbl_TimeLimit1.AutoSize = true;
            this.lbl_TimeLimit1.Location = new System.Drawing.Point(3, 150);
            this.lbl_TimeLimit1.Name = "lbl_TimeLimit1";
            this.lbl_TimeLimit1.Size = new System.Drawing.Size(77, 24);
            this.lbl_TimeLimit1.TabIndex = 29;
            this.lbl_TimeLimit1.Text = "发图时间范围1(0-24):";
            // 
            // fd_SendTimeStart1
            // 
            this.fd_SendTimeStart1.Enabled = false;
            this.fd_SendTimeStart1.Location = new System.Drawing.Point(103, 153);
            this.fd_SendTimeStart1.Name = "fd_SendTimeStart1";
            this.fd_SendTimeStart1.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeStart1.TabIndex = 27;
            this.fd_SendTimeStart1.Text = "0";
            // 
            // fd_SendTimeEnd1
            // 
            this.fd_SendTimeEnd1.Enabled = false;
            this.fd_SendTimeEnd1.Location = new System.Drawing.Point(283, 153);
            this.fd_SendTimeEnd1.Name = "fd_SendTimeEnd1";
            this.fd_SendTimeEnd1.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeEnd1.TabIndex = 28;
            this.fd_SendTimeEnd1.Text = "24";
            // 
            // lbl_TimeLimit2
            // 
            this.lbl_TimeLimit2.AutoSize = true;
            this.lbl_TimeLimit2.Location = new System.Drawing.Point(3, 180);
            this.lbl_TimeLimit2.Name = "lbl_TimeLimit2";
            this.lbl_TimeLimit2.Size = new System.Drawing.Size(77, 24);
            this.lbl_TimeLimit2.TabIndex = 31;
            this.lbl_TimeLimit2.Text = "发图时间范围1(0-24):";
            // 
            // lbl_TimeLimit3
            // 
            this.lbl_TimeLimit3.AutoSize = true;
            this.lbl_TimeLimit3.Location = new System.Drawing.Point(3, 210);
            this.lbl_TimeLimit3.Name = "lbl_TimeLimit3";
            this.lbl_TimeLimit3.Size = new System.Drawing.Size(77, 24);
            this.lbl_TimeLimit3.TabIndex = 30;
            this.lbl_TimeLimit3.Text = "发图时间范围3(0-24):";
            // 
            // lbl_TimeLimit4
            // 
            this.lbl_TimeLimit4.AutoSize = true;
            this.lbl_TimeLimit4.Location = new System.Drawing.Point(3, 240);
            this.lbl_TimeLimit4.Name = "lbl_TimeLimit4";
            this.lbl_TimeLimit4.Size = new System.Drawing.Size(77, 24);
            this.lbl_TimeLimit4.TabIndex = 32;
            this.lbl_TimeLimit4.Text = "发图时间范围4(0-24):";
            // 
            // fd_SendTimeStart2
            // 
            this.fd_SendTimeStart2.Location = new System.Drawing.Point(103, 183);
            this.fd_SendTimeStart2.Name = "fd_SendTimeStart2";
            this.fd_SendTimeStart2.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeStart2.TabIndex = 33;
            this.fd_SendTimeStart2.Text = "0";
            // 
            // fd_SendTimeEnd2
            // 
            this.fd_SendTimeEnd2.Location = new System.Drawing.Point(283, 183);
            this.fd_SendTimeEnd2.Name = "fd_SendTimeEnd2";
            this.fd_SendTimeEnd2.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeEnd2.TabIndex = 34;
            this.fd_SendTimeEnd2.Text = "24";
            // 
            // fd_SendTimeStart3
            // 
            this.fd_SendTimeStart3.Location = new System.Drawing.Point(103, 213);
            this.fd_SendTimeStart3.Name = "fd_SendTimeStart3";
            this.fd_SendTimeStart3.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeStart3.TabIndex = 35;
            this.fd_SendTimeStart3.Text = "0";
            // 
            // fd_SendTimeEnd3
            // 
            this.fd_SendTimeEnd3.Location = new System.Drawing.Point(283, 213);
            this.fd_SendTimeEnd3.Name = "fd_SendTimeEnd3";
            this.fd_SendTimeEnd3.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeEnd3.TabIndex = 36;
            this.fd_SendTimeEnd3.Text = "24";
            // 
            // fd_SendTimeStart4
            // 
            this.fd_SendTimeStart4.Location = new System.Drawing.Point(103, 243);
            this.fd_SendTimeStart4.Name = "fd_SendTimeStart4";
            this.fd_SendTimeStart4.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeStart4.TabIndex = 37;
            this.fd_SendTimeStart4.Text = "0";
            // 
            // fd_SendTimeEnd4
            // 
            this.fd_SendTimeEnd4.Location = new System.Drawing.Point(283, 243);
            this.fd_SendTimeEnd4.Name = "fd_SendTimeEnd4";
            this.fd_SendTimeEnd4.Size = new System.Drawing.Size(50, 21);
            this.fd_SendTimeEnd4.TabIndex = 38;
            this.fd_SendTimeEnd4.Text = "24";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "顶部文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 40;
            this.label2.Text = "底部文字";
            // 
            // fd_ImageTopText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fd_ImageTopText, 2);
            this.fd_ImageTopText.Enabled = false;
            this.fd_ImageTopText.Location = new System.Drawing.Point(563, 273);
            this.fd_ImageTopText.Name = "fd_ImageTopText";
            this.fd_ImageTopText.Size = new System.Drawing.Size(187, 21);
            this.fd_ImageTopText.TabIndex = 41;
            // 
            // fd_ImageEndText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.fd_ImageEndText, 2);
            this.fd_ImageEndText.Enabled = false;
            this.fd_ImageEndText.Location = new System.Drawing.Point(563, 303);
            this.fd_ImageEndText.Name = "fd_ImageEndText";
            this.fd_ImageEndText.Size = new System.Drawing.Size(187, 21);
            this.fd_ImageEndText.TabIndex = 42;
            // 
            // ep_wf
            // 
            this.ep_wf.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_wf.ContainerControl = this;
            // 
            // TC_Main
            // 
            this.TC_Main.Controls.Add(this.TP_Data);
            this.TC_Main.Controls.Add(this.TP_UserList);
            this.TC_Main.Location = new System.Drawing.Point(3, 12);
            this.TC_Main.Name = "TC_Main";
            this.TC_Main.SelectedIndex = 0;
            this.TC_Main.Size = new System.Drawing.Size(775, 538);
            this.TC_Main.TabIndex = 1;
            // 
            // TP_Data
            // 
            this.TP_Data.Controls.Add(this.tableLayoutPanel1);
            this.TP_Data.Location = new System.Drawing.Point(4, 22);
            this.TP_Data.Name = "TP_Data";
            this.TP_Data.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Data.Size = new System.Drawing.Size(767, 512);
            this.TP_Data.TabIndex = 0;
            this.TP_Data.Text = "资料";
            this.TP_Data.UseVisualStyleBackColor = true;
            // 
            // TP_UserList
            // 
            this.TP_UserList.Controls.Add(this.gv_UserList);
            this.TP_UserList.Location = new System.Drawing.Point(4, 22);
            this.TP_UserList.Name = "TP_UserList";
            this.TP_UserList.Padding = new System.Windows.Forms.Padding(3);
            this.TP_UserList.Size = new System.Drawing.Size(767, 512);
            this.TP_UserList.TabIndex = 1;
            this.TP_UserList.Text = "列表";
            this.TP_UserList.UseVisualStyleBackColor = true;
            // 
            // gv_UserList
            // 
            this.gv_UserList.AllowUserToAddRows = false;
            this.gv_UserList.AllowUserToDeleteRows = false;
            this.gv_UserList.AllowUserToOrderColumns = true;
            this.gv_UserList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_UserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.IsLockedOut});
            this.gv_UserList.DataSource = this.BS_UserList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_UserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_UserList.Location = new System.Drawing.Point(7, 7);
            this.gv_UserList.MultiSelect = false;
            this.gv_UserList.Name = "gv_UserList";
            this.gv_UserList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_UserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_UserList.RowHeadersVisible = false;
            this.gv_UserList.RowTemplate.Height = 23;
            this.gv_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_UserList.Size = new System.Drawing.Size(754, 499);
            this.gv_UserList.TabIndex = 0;
            this.gv_UserList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UserList_CellContentDoubleClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "用户ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // IsLockedOut
            // 
            this.IsLockedOut.DataPropertyName = "IsLockedOut";
            this.IsLockedOut.HeaderText = "锁定";
            this.IsLockedOut.Name = "IsLockedOut";
            this.IsLockedOut.ReadOnly = true;
            this.IsLockedOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsLockedOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.TC_Main);
            this.Name = "UserSetting";
            this.Text = "用户设置";
            this.Load += new System.EventHandler(this.UserSetting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_wf)).EndInit();
            this.TC_Main.ResumeLayout(false);
            this.TP_Data.ResumeLayout(false);
            this.TP_UserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_Islock;
        private System.Windows.Forms.TextBox fd_password;
        private System.Windows.Forms.CheckBox fd_IsLock;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider ep_wf;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.TabControl TC_Main;
        private System.Windows.Forms.TabPage TP_Data;
        private System.Windows.Forms.TabPage TP_UserList;
        private System.Windows.Forms.DataGridView gv_UserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLockedOut;
        private System.Windows.Forms.BindingSource BS_UserList;
        private System.Windows.Forms.Label lbl_NewGameSend;
        private System.Windows.Forms.CheckBox fd_NewGameSend;
        public System.Windows.Forms.TextBox fd_username;
        private System.Windows.Forms.Label lbl_ActiveCode;
        private System.Windows.Forms.TextBox fd_activecode;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.DateTimePicker fd_EndDate;
        private System.Windows.Forms.Button Btn_Build;
        private System.Windows.Forms.Label lbl_IsBlock;
        private System.Windows.Forms.CheckBox Fd_IsBlock;
        private System.Windows.Forms.Label lbl_pic;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label lbl_tracecount;
        private System.Windows.Forms.CheckBox FD_SendPIC;
        private System.Windows.Forms.CheckBox FD_ReceiveOrder;
        private System.Windows.Forms.TextBox fd_MaxPlayerCount;
        private System.Windows.Forms.Label lbl_boss;
        private System.Windows.Forms.TextBox fd_BossUserName;
        private System.Windows.Forms.TextBox fd_SendTimeEnd1;
        private System.Windows.Forms.TextBox fd_SendTimeStart1;
        private System.Windows.Forms.Label lbl_TimeLimit1;
        private System.Windows.Forms.Label lbl_TimeLimit2;
        private System.Windows.Forms.Label lbl_TimeLimit3;
        private System.Windows.Forms.Label lbl_TimeLimit4;
        private System.Windows.Forms.TextBox fd_SendTimeStart2;
        private System.Windows.Forms.TextBox fd_SendTimeEnd2;
        private System.Windows.Forms.TextBox fd_SendTimeStart3;
        private System.Windows.Forms.TextBox fd_SendTimeEnd3;
        private System.Windows.Forms.TextBox fd_SendTimeStart4;
        private System.Windows.Forms.TextBox fd_SendTimeEnd4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fd_ImageTopText;
        private System.Windows.Forms.TextBox fd_ImageEndText;

    }
}