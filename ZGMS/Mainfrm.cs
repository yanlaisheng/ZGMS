#define 公司自用
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Data.SQLite;
using ZGP331;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using ZGMS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
//using Sanli;
//using DevExpress.Data.Linq.Helpers;
//using Modbus.Data;
//using Modbus.Device;
//using Modbus.IO;
//using Modbus.Utility;


namespace WNMS2
{
    //结构定义
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GPRS_DATA_RECORD
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string m_userid;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string m_recv_date;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)] //这里做了修改，转换时由ByValTStr变为ByValArray类型，
        public byte[] m_data_buf;                   //定位由string改为byte[]
        public ushort m_data_len;
        public byte m_data_type;
        public void Initialize()                    //初始化byte[]的字段
        {
            m_data_buf = new byte[1024];
        }
        //UnmanagedType.LPStr
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GPRS_USER_INFO
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        public string m_userid;
        public uint m_sin_addr;
        public ushort m_sin_port;
        public uint m_local_addr;
        public ushort m_local_port;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string m_logon_date;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string m_update_time;
        public byte m_status;
    }



    public partial class MainFrm : Form
    {
        private string filename = null;
        private long reciveCount = 0;
        private long sendCount = 0;
        private long Set_TimeOut = 0;
        private long Buff_size = 0;
        byte[] CRC_rxd = new byte[2];
        byte[] CRC_txd = new byte[2];
        public StringBuilder strbu1 = new StringBuilder();
        private int R_splitterDistance;
        private int R_splitterDistance_status;
        private string Query_Process_No;//保存查询/修改的过程号
        private int Select_Radio_No;    //保存Radio号（当前参数在哪一组区间内）
        private int Select_Par_Row;     //保存要查询/修改的行号
        private int Select_Par_Address; //保存要查询/修改的参数地址
        private string Select_Par_Name; //保存要查询/修改的参数名
        private string Query_DTUid;     //保存要查询的DTU ID号
        private int Select_Pump_No;     //保存要查询/修改的泵号
        long[] update_count = new long[5];
        private int previousSelectedRowIndex = -1;
        private string Select_DTU_NO;

        // 连接数据库，FailIfMissing=false时若文件不存在会自动创建
        string connectionString = "Data Source=data.db;Version=3;Pooling=true;FailIfMissing=false;";
        private SQLiteConnection conn;
        public enum Command
        {
            Login,      //登陆到服务器
            Logout,     //注销
            Message,    //发送信息
            List,       //得到用户列表
            Null,       //No command
            ListAll,    //列出全部用户
            Control,    //控制命令
            Heart,      //心跳包
            ModiPWD     //修改用户密码
        }


        CRC crc = new CRC();

        #region Import_Wcomm_Dll

        [DllImport(".\\wcomm_dll.dll")]
        static extern int start_gprs_server(
            IntPtr hWnd,
            int wMsg,
            int nServerPort,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);
        [DllImport(".\\wcomm_dll.dll")]
        static extern int start_net_service(
            IntPtr hWnd,
            int wMsg,
            int nServerPort,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int stop_gprs_server(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);
        [DllImport(".\\wcomm_dll.dll")]
        static extern int stop_net_service(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int do_read_proc(
            ref GPRS_DATA_RECORD recdPtr,
            [MarshalAs(UnmanagedType.LPStr)]
        StringBuilder mess,
            bool reply);

        //		[DllImport(".\\wcomm_dll.dll")]
        //		public static extern int do_send_user_data(
        //			[MarshalAs(UnmanagedType.LPStr)]
        //			string userid,											
        //			[MarshalAs(UnmanagedType.LPStr)]
        //			string data,																		
        //			int len,
        //			[MarshalAs(UnmanagedType.LPStr)]
        //			StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int do_send_user_data(
            [MarshalAs(UnmanagedType.LPStr)]
            string userid,
            [MarshalAs(UnmanagedType.LPArray)]
            byte[] data,
            int len,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int get_user_info(
            [MarshalAs(UnmanagedType.LPStr)]
        string userid,
            ref GPRS_USER_INFO infoPtr);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int SetWorkMode(int nWorkMode);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int SelectProtocol(int nProtocol);


        //[DllImport(".\\wcomm_dll.dll")]
        //static extern int get_user_at(
        //    int i,
        //    ref GPRS_USER_INFO infoPtr);
        //
        //定义一些SOCKET API函数
        [DllImport("Ws2_32.dll")]
        static extern Int32 inet_addr(string ip);
        [DllImport("Ws2_32.dll")]
        static extern string inet_ntoa(uint ip); //将一个32位的二进制数字IP地址转换成一个点分十进制的字符串形式的IP地址
        [DllImport("Ws2_32.dll")]
        static extern uint htonl(uint ip);
        [DllImport("Ws2_32.dll")]
        static extern uint ntohl(uint ip); //将一个无符号长整形数从网络字节顺序转换为主机字节顺序， ntohl()返回一个以主机字节顺序表达的数
        [DllImport("Ws2_32.dll")]
        static extern ushort htons(ushort ip);
        [DllImport("Ws2_32.dll")]
        static extern ushort ntohs(ushort ip);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int do_close_one_user(
            [MarshalAs(UnmanagedType.LPStr)]
            string userid,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int do_close_all_user(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder mess);

        [DllImport(".\\wcomm_dll.dll")]
        static extern int get_online_user_amount();

        [DllImport(".\\wcomm_dll.dll")]
        static extern int get_max_user_amount();

        #endregion

        public const int WM_DTU = 0x400 + 100;
        private bool isSidebarVisible = true;

        private bool isLeftPanelVisible = true;
        private bool isRightPanelVisible = true;
        //string dateString = DateTime.Now.ToString("yyyyMMdd");
        //private string logFilePath = $"log/log_{dateString}.txt";
        int par_no = 0;
        int pump_no = 0;
        public MainFrm()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);

        }

        //DataGridView从SQLite数据库中载入数据
        private void LoadDataIntoDataGridView(int pump_no, int par_no)
        {
            // 创建SQLite连接
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = GetQueryForParNo(par_no);
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (tabControl2.SelectedIndex == 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else if (tabControl2.SelectedIndex == 1)
                        {
                            dataGridView2.DataSource = dataTable;
                        }
                        else if (tabControl2.SelectedIndex == 2)
                        {
                            dataGridView3.DataSource = dataTable;
                        }
                        else if (tabControl2.SelectedIndex == 3)
                        {
                            dataGridView4.DataSource = dataTable;
                        }
                        else if (tabControl2.SelectedIndex == 4)
                        {
                            dataGridView5.DataSource = dataTable;
                        }
                    }
                }
            }


        }

        private string GetQueryForParNo(int par_no)
        {
            int lowerBound = par_no * 100;
            int upperBound = lowerBound + 99;

            switch (tabControl2.SelectedIndex)
            {
                case 0:
                    {
                        return $"SELECT 参数地址,参数值1,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                        break;
                    }
                case 1:
                    {
                        return $"SELECT 参数地址,参数值2,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                        break;

                    }
                case 2:
                    {
                        return $"SELECT 参数地址,参数值3,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                        break;

                    }
                case 3:
                    {
                        return $"SELECT 参数地址,参数值4,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                        break;

                    }
                case 4:
                    {
                        return $"SELECT 参数地址,参数值5,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                        break;

                    }
                default:
                    {
                        return $"SELECT 参数地址,参数值1,小数位数,单位,参数名称,备注,可写,最小值,最大值,所属页面 FROM par WHERE 参数地址 BETWEEN {lowerBound} AND {upperBound};";

                    }
            }


        }

        //窗体加载，读取ini配置文件
        private void MainFrm_Load(object sender, EventArgs e)
        {
            Logger.WriteLog("程序开始运行");
            LoadDataIntoDataGridView(0, 0);
            LoadDataIntoDataGridView(1, 0);
            LoadDataIntoDataGridView(2, 0);
            LoadDataIntoDataGridView(3, 0);
            LoadDataIntoDataGridView(4, 0);

            #region 读取ini配置文件
            //通讯设置
            filename = Application.StartupPath + "\\参数列表.ini";
            string TcpUdp = IniFunc.getString("通信设置", "工作模式", "UDP", filename);
            comboBox_WorkMode.Text = TcpUdp;
            string ServicePort = IniFunc.getString("通信设置", "服务端口", "5009", filename);
            tb_ServicePort.Text = ServicePort;

            string timeout = IniFunc.getString("通信设置", "空闲超时", "1800", filename);
            Set_TimeOut = Convert.ToInt32(timeout);

            string buffersize = IniFunc.getString("通信设置", "缓冲区大小", "10240", filename);
            Buff_size = Convert.ToInt32(buffersize);


            string autoStart = IniFunc.getString("通信设置", "自动开始服务", "1", filename);
            if (autoStart == "1")
            {
                startStopService(e);
                checkBox_autoStartService.Checked = true;
            }
            else
                checkBox_autoStartService.Checked = false;

            //发送设置
            string sendMode = IniFunc.getString("发送设置", "十六进制发送", "1", filename);
            if (sendMode == "1")
                chkBox_Send_16.Checked = true;
            else
                chkBox_Send_16.Checked = false;

            string replyMode = IniFunc.getString("发送设置", "回应", "1", filename);
            if (replyMode == "1")
                checkBox_reply.Checked = true;
            else
                checkBox_reply.Checked = false;

            string appendCRC = IniFunc.getString("发送设置", "添加CRC校验", "1", filename);
            if (appendCRC == "1")
                chkBox_Append_CRC.Checked = true;
            else
                chkBox_Append_CRC.Checked = false;

            string timeSendMode = IniFunc.getString("发送设置", "发送区数据", "", filename);
            if (timeSendMode != "")
                tbSend_zone.Text = timeSendMode;


            string sendTime = IniFunc.getString("发送设置", "发送间隔时间", "1000", filename);
            textBox_Send_interval_Time.Text = sendTime;
            timer_AutoSend.Interval = Convert.ToInt32(sendTime);

            //接收设置
            //string rcvBuffer = IniFunc.getString("接收设置", "接收缓冲区", "1000", filename);
            //txtBox_receive_Buffer.Text = rcvBuffer;
            //receiveBuffer_KB = Convert.ToInt32(rcvBuffer);

            string rcvMode = IniFunc.getString("接收设置", "接收区显示", "十六进制", filename);
            comboBox_receive_Mode.Text = rcvMode;

            string appendTime = IniFunc.getString("接收设置", "加时间戳", "1", filename);
            if (appendTime == "1")
                checkBox_Append_Time.Checked = true;
            else
                checkBox_Append_Time.Checked = false;

            //string save2File = IniFunc.getString("接收设置", "保存接收数据到文件", "0", filename);
            //if (save2File == "1")
            //    checkBox_SaveData2File.Checked = true;
            //else
            //    checkBox_SaveData2File.Checked = false;

            string noScrollScreen = IniFunc.getString("接收设置", "禁止滚屏", "0", filename);
            if (noScrollScreen == "1")
                checkBox_NoScrollScreen.Checked = true;
            else
                checkBox_NoScrollScreen.Checked = false;

            //界面设置
            string Col0_width = IniFunc.getString("界面设置", "设备列表第0列宽度", "160", filename);
            listView_terminal.Columns[0].Width = Convert.ToInt32(Col0_width);

            string Col1_width = IniFunc.getString("界面设置", "设备列表第1列宽度", "200", filename);
            listView_terminal.Columns[1].Width = Convert.ToInt32(Col1_width);

            string Col2_width = IniFunc.getString("界面设置", "设备列表第2列宽度", "200", filename);
            listView_terminal.Columns[2].Width = Convert.ToInt32(Col2_width);

            string Col3_width = IniFunc.getString("界面设置", "设备列表第3列宽度", "200", filename);
            listView_terminal.Columns[3].Width = Convert.ToInt32(Col3_width);

            string Col4_width = IniFunc.getString("界面设置", "设备列表第4列宽度", "200", filename);
            listView_terminal.Columns[4].Width = Convert.ToInt32(Col4_width);

            string Col5_width = IniFunc.getString("界面设置", "设备列表第5列宽度", "200", filename);
            listView_terminal.Columns[5].Width = Convert.ToInt32(Col5_width);

            string Col6_width = IniFunc.getString("界面设置", "设备列表第6列宽度", "200", filename);
            listView_terminal.Columns[6].Width = Convert.ToInt32(Col6_width);

            string Col7_width = IniFunc.getString("界面设置", "设备列表第7列宽度", "120", filename);
            listView_terminal.Columns[7].Width = Convert.ToInt32(Col7_width);

            string Col8_width = IniFunc.getString("界面设置", "设备列表第8列宽度", "120", filename);
            listView_terminal.Columns[8].Width = Convert.ToInt32(Col8_width);

            string Col9_width = IniFunc.getString("界面设置", "设备列表第9列宽度", "120", filename);
            listView_terminal.Columns[9].Width = Convert.ToInt32(Col9_width);

            //DataGridView界面设置
            Read_ini_DataGridview(0);

            //上下分割设定
            string updownSp_distance = IniFunc.getString("上下Splitter设置", "分割距离", "200", filename);
            splitContainer3.SplitterDistance = Convert.ToInt32(updownSp_distance);
            #endregion

            #region 左侧Splitter收缩设置

            // 初始化Splitter的位置和大小
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 250; // 初始分割距离

            // 初始化左侧Panel的大小
            panelLeft.Width = splitContainer1.SplitterDistance;

            // 初始化按钮属性
            btnToggle.Text = "<";
            btnToggle.Dock = DockStyle.Right;
            btnToggle.Width = 12; // 按钮宽度
            btnToggle.Click += BtnToggle_Click;
            #endregion

            #region 右侧Splitter收缩设置

            // 初始化Splitter的位置和大小
            // 初始化按钮属性
            btnToggle_Right.Text = ">";
            btnToggle_Right.Dock = DockStyle.Right;
            btnToggle_Right.Width = 12; // 按钮宽度
            btnToggle_Right.Click += btnToggle_Right_Click;

            splitContainer5.Dock = DockStyle.Fill;
            string r_sp_width = IniFunc.getString("右侧Splitter设置", "分割距离", "200", filename);
            R_splitterDistance = Convert.ToInt32(r_sp_width);
            splitContainer5.SplitterDistance = splitContainer5.Width - R_splitterDistance; // 初始分割距离

            panelRight.Dock = DockStyle.Fill;
            #endregion

            #region 右侧splitContainer_status收缩设置
            // 初始化按钮属性
            btnToggle_Right_status.Text = ">";
            //btnToggle_Right_status.Dock = DockStyle.Right;
            btnToggle_Right_status.Width = 12; // 按钮宽度
            btnToggle_Right_status.Click += btnToggle_Right_status_Click;

            // 初始化Splitter的位置和大小
            //splitContainer_status.Dock = DockStyle.Fill;
            string r_sp_status_width = IniFunc.getString("splitContainer_status设置", "分割距离2", "200", filename);
            R_splitterDistance_status = Convert.ToInt32(r_sp_status_width);
            splitContainer_status.SplitterDistance = splitContainer_status.Width - R_splitterDistance_status; // 初始分割距离


            #endregion

            // 计算标签位置，居中于窗体
            lbl_Title.Location = new System.Drawing.Point((this.ClientSize.Width - lbl_Title.Width) / 2, lbl_Title.Location.Y);
            lbl_time.Location = new Point(this.ClientSize.Width - 300, lbl_time.Location.Y);

            //对状态栏信息初始化
            tssl_select_DTU_NO.Text = "";
            tssl_select_USERNAME.Text = "";
            tssl_select_pump_no.Text = "";
        }

        private void Read_ini_DataGridview(int gdview_no)
        {
            string dgview_Col0_width = IniFunc.getString("DataGridView界面设置", "第0列宽度", "160", filename);
            string dgview_Col1_width = IniFunc.getString("DataGridView界面设置", "第1列宽度", "160", filename);
            string dgview_Col2_width = IniFunc.getString("DataGridView界面设置", "第2列宽度", "160", filename);
            string dgview_Col3_width = IniFunc.getString("DataGridView界面设置", "第3列宽度", "160", filename);
            string dgview_Col4_width = IniFunc.getString("DataGridView界面设置", "第4列宽度", "160", filename);
            string dgview_Col5_width = IniFunc.getString("DataGridView界面设置", "第5列宽度", "160", filename);
            string dgview_Col6_width = IniFunc.getString("DataGridView界面设置", "第6列宽度", "80", filename);
            string dgview_Col7_width = IniFunc.getString("DataGridView界面设置", "第7列宽度", "80", filename);
            string dgview_Col8_width = IniFunc.getString("DataGridView界面设置", "第8列宽度", "80", filename);
            string dgview_Col9_width = IniFunc.getString("DataGridView界面设置", "第9列宽度", "80", filename);

            switch (gdview_no)
            {
                case 0:
                    //DataGridView界面设置
                    dataGridView1.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView1.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView1.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView1.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView1.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView1.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView1.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView1.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView1.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView1.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

                case 1:
                    dataGridView2.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView2.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView2.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView2.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView2.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView2.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView2.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView2.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView2.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView2.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

                case 2:
                    dataGridView3.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView3.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView3.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView3.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView3.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView3.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView3.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView3.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView3.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView3.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

                case 3:
                    dataGridView4.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView4.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView4.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView4.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView4.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView4.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView4.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView4.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView4.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView4.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

                case 4:
                    dataGridView5.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView5.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView5.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView5.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView5.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView5.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView5.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView5.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView5.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView5.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

                default:
                    dataGridView1.Columns[0].Width = Convert.ToInt32(dgview_Col0_width);
                    dataGridView1.Columns[1].Width = Convert.ToInt32(dgview_Col1_width);
                    dataGridView1.Columns[2].Width = Convert.ToInt32(dgview_Col2_width);
                    dataGridView1.Columns[3].Width = Convert.ToInt32(dgview_Col3_width);
                    dataGridView1.Columns[4].Width = Convert.ToInt32(dgview_Col4_width);
                    dataGridView1.Columns[5].Width = Convert.ToInt32(dgview_Col5_width);
                    dataGridView1.Columns[6].Width = Convert.ToInt32(dgview_Col6_width);
                    dataGridView1.Columns[7].Width = Convert.ToInt32(dgview_Col7_width);
                    dataGridView1.Columns[8].Width = Convert.ToInt32(dgview_Col8_width);
                    dataGridView1.Columns[9].Width = Convert.ToInt32(dgview_Col9_width);
                    break;

            }


        }
        //左侧收缩按钮
        private void BtnToggle_Click(object sender, EventArgs e)
        {
            if (isLeftPanelVisible)
            {
                // 隐藏左侧面板
                splitContainer1.Panel1MinSize = 12;
                //splitContainer1.Panel1Collapsed = true;
                btnToggle.Text = ">";

                panelLeft.Width = btnToggle.Width;
                splitContainer1.SplitterDistance = 12;
            }
            else
            {
                // 显示左侧面板
                splitContainer1.Panel1MinSize = 250; // 最小宽度
                //splitContainer1.Panel1Collapsed = false;
                btnToggle.Text = "<";

                panelLeft.Width = 250;
                splitContainer1.SplitterDistance = 250;

            }
            isLeftPanelVisible = !isLeftPanelVisible;
        }

        //右侧收缩按钮
        private void btnToggle_Right_Click(object sender, EventArgs e)
        {
            if (isRightPanelVisible)
            {
                // 隐藏右侧面板
                splitContainer5.Panel2Collapsed = true;
                btnToggle_Right.Text = "<";
            }
            else
            {
                // 显示右侧面板
                splitContainer5.Panel2Collapsed = false;
                btnToggle_Right.Text = ">";
            }
            isRightPanelVisible = !isRightPanelVisible;
        }


        //右侧收缩按钮-状态
        private void btnToggle_Right_status_Click(object sender, EventArgs e)
        {
            if (isRightPanelVisible)
            {
                // 隐藏右侧面板
                splitContainer_status.Panel2Collapsed = true;
                btnToggle_Right_status.Text = "<";
            }
            else
            {
                // 显示右侧面板
                splitContainer_status.Panel2Collapsed = false;
                btnToggle_Right_status.Text = ">";
            }
            isRightPanelVisible = !isRightPanelVisible;
        }

        #region 开始服务，停止服务
        /// <summary>
        /// 开始服务 停止服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartStopService_Click(object sender, EventArgs e)
        {
            startStopService(e);
        }

        //启动停止服务函数
        private void startStopService(EventArgs e)
        {
            try
            {
                if (btn_StartStopService.Text == "开始服务")
                {
                    if (comboBox_WorkMode.Text == "UDP")
                        SelectProtocol(0);
                    else
                        SelectProtocol(1);

                    SetWorkMode(2);

                    //启动服务
                    StringBuilder mess = new StringBuilder(100);
                    //start_gprs_server(this.Handle, WM_DTU, int.Parse(tbPort.Text), mess);			
                    start_net_service(this.Handle, WM_DTU, int.Parse(tb_ServicePort.Text), mess);
                    tb_receive_zone.AppendText(mess.ToString() + "\r\n");
                    tb_receive_zone.AppendText("\r\n");
                    btn_StartStopService.Text = "停止服务";
                    Logger.WriteLog(mess.ToString());
                }
                else
                {
                    StringBuilder mess = new StringBuilder(100);
                    //停止服务
                    //stop_gprs_server(mess);			
                    stop_net_service(mess);
                    tb_receive_zone.AppendText(mess.ToString() + "\r\n");
                    tb_receive_zone.AppendText("\r\n");
                    btn_StartStopService.Text = "开始服务";
                    Logger.WriteLog(mess.ToString());

                    if (chkBox_TimeSend.Checked)
                    {
                        chkBox_TimeSend.Checked = false;
                        timer_AutoSend.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                tb_receive_zone.AppendText(ex.ToString() + "\n");
                Logger.WriteLog(ex.ToString());

            }
        }
        #endregion

        //发送数据
        private void btn_Send_Click(object sender, EventArgs e)
        {
            func_send_Data();
        }

        //发送数据函数
        private void func_send_Data()
        {
            //// 执行耗时操作前，先释放控制权
            //Application.DoEvents();

            StringBuilder mess = new StringBuilder(100);

            int i;
            string str;
            int len;

            //清缓冲区
            if (tb_receive_zone.TextLength > Buff_size)
            {
                tb_receive_zone.Clear();
            }

            for (i = 0; i < listView_terminal.Items.Count; i++)
            {
                if (checkBox_Send_Only_Select.Checked && listView_terminal.Items[i].Checked || !checkBox_Send_Only_Select.Checked)
                {
                    if (chkBox_Send_16.Checked) //十六进制发送
                    {
                        str = tbSend_zone.Text.Replace(" ", "");
                        if (chkBox_Append_CRC.Checked)
                            len = str.Trim().Length / 2 + 2;
                        else
                            len = str.Trim().Length / 2;

                        byte[] dataTemp = new byte[len];
                        try
                        {
                            //追加CRC校验
                            if (chkBox_Append_CRC.Checked)
                            {
                                dataTemp = Transform.ToBytes(str + "0000");
                                CRC_txd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                                dataTemp[dataTemp.Length - 2] = CRC_txd[1];
                                dataTemp[dataTemp.Length - 1] = CRC_txd[0];
                            }
                            else
                            {
                                dataTemp = Transform.ToBytes(str);
                            }

                            if (do_send_user_data(listView_terminal.Items[i].Text, dataTemp, dataTemp.Length, mess) == -1)
                            {
                                tb_receive_zone.AppendText(mess.ToString()); //发送失败
                                Logger.WriteLog(mess.ToString());
                            }
                            else //发送成功，更新计数器
                            {
                                strbu1.Clear();
                                strbu1.Append("\r\n");
                                strbu1.Append("终端号码：" + listView_terminal.Items[i].Text + "\r\n");
                                strbu1.Append("用户名称：" + listView_terminal.Items[i].SubItems[1].Text + "\r\n");
                                strbu1.Append("发送时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
                                strbu1.Append("数据长度：" + dataTemp.Length + "\r\n");
                                strbu1.Append("发送数据→：" + Transform.ToHexString(dataTemp, " ") + "\r\n");

                                int startlen = tb_receive_zone.TextLength;
                                tb_receive_zone.AppendText(strbu1.ToString());   //添加数据
                                Logger.WriteLog(strbu1.ToString());
                                int endlen = tb_receive_zone.TextLength;
                                tb_receive_zone.Select(startlen, endlen - startlen);
                                tb_receive_zone.SelectionColor = Color.Red;

                                sendCount += dataTemp.Length;
                                sendcount_tssl.Text = sendCount.ToString();

                                //发送计数更新
                                long temp1;
                                temp1 = Convert.ToInt32(listView_terminal.Items[i].SubItems[7].Text) + dataTemp.Length;
                                listView_terminal.Items[i].SubItems[7].Text = temp1.ToString();
                            }
                        }
                        catch
                        {
                            if (chkBox_TimeSend.Checked)
                            {
                                chkBox_TimeSend.Checked = false;
                                timer_AutoSend.Stop();
                            }
                            MessageBox.Show("输入数据有误！");
                        }

                        //滚屏
                        tb_receive_zone.SelectionStart = tb_receive_zone.Text.Length;
                        tb_receive_zone.ScrollToCaret();

                        //保存到文件中
                        save2File();
                    }
                    else  //文本模式发送
                    {
                        string str1;
                        int len2;
                        str1 = tbSend_zone.Text.Replace(" ", "");

                        if (chkBox_Append_CRC.Checked)
                            len2 = str1.Trim().Length + 2;
                        else
                            len2 = str1.Trim().Length;

                        byte[] st1 = new byte[len2];

                        //追加CRC校验
                        if (chkBox_Append_CRC.Checked)
                        {
                            // 将字符串转换为ASCII字节数组
                            st1 = System.Text.Encoding.ASCII.GetBytes(str1 + "00");
                            CRC_txd = Class_CRC16_Modbus.Crc16(st1, st1.Length - 2);
                            st1[st1.Length - 2] = CRC_txd[1];
                            st1[st1.Length - 1] = CRC_txd[0];
                        }
                        else
                        {
                            st1 = System.Text.Encoding.ASCII.GetBytes(str1);
                        }
                        //string ss = System.Text.Encoding.Default.GetString(st1, 0, st1.Length);
                        //st1 = Transform.ToBytes(str1);

                        if (do_send_user_data(listView_terminal.Items[i].Text, st1, st1.Length, mess) == -1)
                        {
                            tb_receive_zone.AppendText(mess.ToString());    //发送失败
                            Logger.WriteLog(mess.ToString());
                        }
                        else//发送成功，更新计数器
                        {
                            strbu1.Clear();
                            strbu1.Append("\r\n");
                            strbu1.Append("终端号码：" + listView_terminal.Items[i].Text + "\r\n");
                            strbu1.Append("用户名称：" + listView_terminal.Items[i].SubItems[1].Text + "\r\n");
                            strbu1.Append("发送时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
                            strbu1.Append("数据长度：" + st1.Length + "\r\n");
                            strbu1.Append("发送数据→：" + Transform.ToHexString(st1, " ") + "\r\n");

                            int startlen = tb_receive_zone.TextLength;
                            tb_receive_zone.AppendText(strbu1.ToString());   //添加数据
                            Logger.WriteLog(strbu1.ToString());
                            int endlen = tb_receive_zone.TextLength;
                            tb_receive_zone.Select(startlen, endlen - startlen);
                            tb_receive_zone.SelectionColor = Color.Red;

                            //sendCount += tbSend_zone.Text.Length;
                            sendCount += st1.Length;
                            sendcount_tssl.Text = sendCount.ToString();

                            //发送计数更新
                            long temp1;
                            temp1 = Convert.ToInt32(listView_terminal.Items[i].SubItems[7].Text) + st1.Length;
                            listView_terminal.Items[i].SubItems[7].Text = temp1.ToString();

                            //滚屏
                            tb_receive_zone.SelectionStart = tb_receive_zone.Text.Length;
                            tb_receive_zone.ScrollToCaret();

                            //保存到文件中
                            save2File();
                        }
                    }
                }
            }
        }

        //消息处理：注册DTU、接收数据等
        protected override void WndProc(ref Message m)
        {
            // TODO:  添加 Form1.WndProc 实现
            int i;

            //响应DTU消息
            if (m.Msg == WM_DTU)
            {
                GPRS_DATA_RECORD recdPtr = new GPRS_DATA_RECORD();
                StringBuilder mess = new StringBuilder(100);

                //读取DTU数据
                //do_read_proc(dr, mess, checkBox1.Checked);				
                do_read_proc(ref recdPtr, mess, checkBox_reply.Checked);

                byte a = recdPtr.m_data_type;

                switch (recdPtr.m_data_type)
                {
                    case 0x01:  //注册包												
                        GPRS_USER_INFO user_info = new GPRS_USER_INFO();
                        ushort usPort;
                        if (get_user_info(recdPtr.m_userid, ref user_info) == 0)
                        {
                            if (listView_terminal.Items.Count > 2000)
                            {
                                listView_terminal.Items.Clear();
                            }
                            //列表中存在设备													
                            for (i = 0; i < listView_terminal.Items.Count; i++)
                                if (listView_terminal.Items[i].Text == user_info.m_userid)//找到已经存在的设备
                                {
                                    if (listView_terminal.Items[i].SubItems[1].Text == "")
                                    {
                                        #region 通过数据库获取用户名称
                                        SQLiteConnection con2 = new SQLiteConnection(connectionString);

                                        con2.Open();
                                        SQLiteCommand cmd2 = new SQLiteCommand(con2);
                                        //查询数据
                                        cmd2.CommandText = "select m_user_name from device where m_userid='" + listView_terminal.Items[i].Text + "'";
                                        var name2 = cmd2.ExecuteScalar();
                                        //关闭连接
                                        con2.Close();
                                        if (name2 != null)
                                            //listView_terminal.Items[i].SubItems.Add(name2.ToString()); //添加用户名称
                                            listView_terminal.Items[i].SubItems[1].Text = name2.ToString();//更新用户名称

                                        #endregion
                                    }

                                    //listView_terminal.Items[i].SubItems.Add(inet_ntoa(ntohl(user_info.m_local_addr)));//添加移动网内IP地址
                                    listView_terminal.Items[i].SubItems[2].Text = inet_ntoa(ntohl(user_info.m_local_addr));//更新移动网内IP地址

                                    usPort = user_info.m_local_port;
                                    //listView_terminal.Items[i].SubItems.Add(usPort.ToString());//添加移动网内IP端口
                                    listView_terminal.Items[i].SubItems[3].Text = usPort.ToString();//更新移动网内IP端口

                                    //listView_terminal.Items[i].SubItems.Add(user_info.m_logon_date);//添加登陆时间
                                    listView_terminal.Items[i].SubItems[4].Text = user_info.m_logon_date;//更新登陆时间

                                    //listView_terminal.Items[i].SubItems.Add(inet_ntoa(ntohl(user_info.m_sin_addr)));//添加终端出口IP地址
                                    listView_terminal.Items[i].SubItems[5].Text = inet_ntoa(ntohl(user_info.m_sin_addr));//更新终端出口IP地址

                                    usPort = user_info.m_sin_port;
                                    //listView_terminal.Items[i].SubItems.Add(usPort.ToString());//添加终端出口IP端口
                                    listView_terminal.Items[i].SubItems[6].Text = usPort.ToString();//更新终端出口IP端口

                                    Logger.WriteLog("设备注册：" + listView_terminal.Items[i].Text + listView_terminal.Items[i].SubItems[1].Text);

                                    return;
                                }

                            //没有注册过
                            ListViewItem lvi = listView_terminal.Items.Add(user_info.m_userid);

                            #region 通过数据库获取用户名称
                            SQLiteConnection con1 = new SQLiteConnection(connectionString);

                            con1.Open();
                            SQLiteCommand cmd = new SQLiteCommand(con1);
                            //查询数据
                            cmd.CommandText = "select m_user_name from device where m_userid='" + listView_terminal.Items[i].Text + "'";
                            var name = cmd.ExecuteScalar();
                            //关闭连接
                            con1.Close();
                            if (name != null)
                                lvi.SubItems.Add(name.ToString());
                            else
                                lvi.SubItems.Add("");
                            #endregion

                            //inet_ntoa，将一个32位的二进制数字IP地址转换成一个点分十进制的字符串形式的IP地址
                            //ntohl函数，是将一个无符号长整形数从网络字节顺序转换为主机字节顺序， ntohl()返回一个以主机字节顺序表达的数
                            lvi.SubItems.Add(inet_ntoa(ntohl(user_info.m_local_addr)));

                            usPort = user_info.m_local_port;
                            lvi.SubItems.Add(usPort.ToString());

                            lvi.SubItems.Add(user_info.m_logon_date);

                            //inet_ntoa，将一个32位的二进制数字IP地址转换成一个点分十进制的字符串形式的IP地址
                            lvi.SubItems.Add(inet_ntoa(ntohl(user_info.m_sin_addr)));

                            usPort = user_info.m_sin_port;
                            lvi.SubItems.Add(usPort.ToString());

                            lvi.SubItems.Add("0");
                            lvi.SubItems.Add("0");
                            lvi.SubItems.Add("0");
                            Logger.WriteLog("设备注册：" + listView_terminal.Items[i].Text + listView_terminal.Items[i].SubItems[1].Text);


                        }
                        break;
                    case 0x02:  //注销包											
                        for (i = 0; i < listView_terminal.Items.Count; i++)
                            if (listView_terminal.Items[i].Text == recdPtr.m_userid)
                            {
                                Logger.WriteLog("设备注销：" + listView_terminal.Items[i].Text + listView_terminal.Items[i].SubItems[1].Text);
                                listView_terminal.Items[i].Remove();

                                break;
                            }
                        break;
                    case 0x04:  //无效包
                        break;
                    case 0x09:  //数据包								 
                                //int d=3;
                                //string xx=recdPtr.m_data_buf;
                                //string bb=recdPtr.m_data_buf;
                                //byte[] ss = System.Text.Encoding.Default.GetBytes("a");
                                //int b = int.Parse(recdPtr.m_data_buf, System.Globalization.NumberStyles.HexNumber);  
                                //System.Text.Encoding.ASCII.GetString(bs);
                                //string ss = System.Text.Encoding.ASCII.GetString(bc);
                                //textBox1.AppendText(b + "\n");
                                //SqlConnection conn=new SqlConnection("Data Source=192.168.1.188;UID=sa;PWD=1113;DATABASE=weiz");
                                //conn.Open();						
                                //tb_receive.AppendText(System.Text.Encoding.Default.GetString(recdPtr.m_data_buf) + "\r\n");

                        //接收计数
                        reciveCount += recdPtr.m_data_len;
                        recivecount_tssl.Text = reciveCount.ToString();

                        //另存到数组中
                        byte[] dataTemp = new byte[recdPtr.m_data_len];
                        for (int j = 0; j < recdPtr.m_data_len; j++)
                            dataTemp[j] = recdPtr.m_data_buf[j];

                        //处理接收数据——修改参数
                        Process_receive_Data_ModiPar(dataTemp, Select_Pump_No, Select_Par_Row);

                        //清缓冲区
                        if (tb_receive_zone.TextLength > Buff_size)
                        {
                            tb_receive_zone.Clear();
                        }

                        for (i = 0; i < listView_terminal.Items.Count; i++)
                        {
                            //只接收选择通道数据
                            if (checkBox_Show_Only_Select.Checked && listView_terminal.Items[i].Checked || !checkBox_Show_Only_Select.Checked)
                            {
                                {
                                    strbu1.Clear();
                                    strbu1.Append("\r\n");
                                    strbu1.Append("终端号码：" + recdPtr.m_userid + "\r\n");
                                    strbu1.Append("用户名称：" + listView_terminal.Items[i].SubItems[1].Text + "\r\n");
                                    strbu1.Append("接收时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");

                                    //richtxbox_tmp.Text = "";
                                    //richtxbox_tmp.AppendText("终端号码：" + recdPtr.m_userid + "\r\n");
                                    //richtxbox_tmp.AppendText("用户名称：" + listView_terminal.Items[i].SubItems[1].Text + "\r\n");
                                    //richtxbox_tmp.AppendText("接收时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");

                                    switch (comboBox_receive_Mode.Text)
                                    {
                                        case "十六进制":
                                            //richtxbox_tmp.AppendText("数据长度：" + dataTemp.Length + "\r\n");
                                            //richtxbox_tmp.AppendText("接收数据：" + Transform.ToHexString(dataTemp, " ") + "\r\n\r\n");
                                            strbu1.Append("数据长度：" + dataTemp.Length + "\r\n");
                                            strbu1.Append("接收数据←：" + Transform.ToHexString(dataTemp, " ") + "\r\n");
                                            break;
                                        case "文本模式":
                                            //richtxbox_tmp.AppendText("数据长度(文本)：" + recdPtr.m_data_len + "\r\n");
                                            //richtxbox_tmp.AppendText("接收数据(文本)：" + Encoding.ASCII.GetString(dataTemp) + "\r\n\r\n");
                                            strbu1.Append("数据长度(文本)：" + recdPtr.m_data_len + "\r\n");
                                            strbu1.Append("接收数据(文本)←：" + Encoding.ASCII.GetString(dataTemp) + "\r\n");
                                            break;
                                        case "十六进制和文本模式":
                                            //richtxbox_tmp.AppendText("数据长度：" + dataTemp.Length + "\r\n");
                                            //richtxbox_tmp.AppendText("接收数据：" + Transform.ToHexString(dataTemp, " ") + "\r\n");
                                            //richtxbox_tmp.AppendText("数据长度(文本)：" + dataTemp.Length + "\r\n");
                                            //richtxbox_tmp.AppendText("接收数据(文本)：" + Encoding.ASCII.GetString(dataTemp) + "\r\n\r\n");
                                            strbu1.Append("数据长度：" + dataTemp.Length + "\r\n");
                                            strbu1.Append("接收数据←：" + Transform.ToHexString(dataTemp, " ") + "\r\n");
                                            strbu1.Append("数据长度(文本)：" + recdPtr.m_data_len + "\r\n");
                                            strbu1.Append("接收数据(文本)←：" + Encoding.ASCII.GetString(dataTemp) + "\r\n");
                                            break;
                                        default:
                                            //richtxbox_tmp.AppendText("数据长度：" + dataTemp.Length + "\r\n");
                                            //richtxbox_tmp.AppendText("接收数据：" + Transform.ToHexString(dataTemp, " ") + "\r\n\r\n");
                                            strbu1.Append("数据长度：" + dataTemp.Length + "\r\n");
                                            strbu1.Append("接收数据←：" + Transform.ToHexString(dataTemp, " ") + "\r\n");
                                            break;
                                    }

                                    Logger.WriteLog(strbu1.ToString());

                                    if (listView_terminal.Items[i].Text == recdPtr.m_userid)
                                    {
                                        //接收计数更新
                                        long temp1;
                                        temp1 = Convert.ToInt32(listView_terminal.Items[i].SubItems[8].Text) + dataTemp.Length;
                                        listView_terminal.Items[i].SubItems[8].Text = temp1.ToString();//接收计数

                                        listView_terminal.Items[i].SubItems[9].Text = "0";//空闲时间


                                        if (checkBox_Append_Time.Checked) //加时间戳
                                        {
                                            //tb_receive_zone.AppendText(richtxbox_tmp.Text);//追加到接收数据区

                                            int startlen = tb_receive_zone.TextLength;
                                            //tb_receive_zone.AppendText(richtxbox_tmp.Text);
                                            tb_receive_zone.AppendText(strbu1.ToString());
                                            int endlen = tb_receive_zone.TextLength;
                                            tb_receive_zone.Select(startlen, endlen - startlen);
                                            tb_receive_zone.SelectionColor = Color.Black;

                                            //禁止滚屏
                                            if (checkBox_NoScrollScreen.Checked)
                                            {
                                                // this selects the index zero as the location of your caret
                                                tb_receive_zone.Select(0, 0);
                                                // Scrolls to the caret :)
                                                tb_receive_zone.ScrollToCaret();
                                            }
                                            else //滚屏
                                            {
                                                tb_receive_zone.SelectionStart = tb_receive_zone.Text.Length;
                                                tb_receive_zone.ScrollToCaret();
                                            }
                                        }
                                        else
                                        {
                                            int startlen = tb_receive_zone.TextLength;
                                            tb_receive_zone.AppendText("[" + recdPtr.m_userid + "] [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]接收" + dataTemp.Length + "→");
                                            tb_receive_zone.AppendText(Transform.ToHexString(dataTemp, " ") + "\r\n\r\n");
                                            int endlen = tb_receive_zone.TextLength;
                                            tb_receive_zone.Select(startlen, endlen - startlen);
                                            tb_receive_zone.SelectionColor = Color.Black;

                                            //禁止滚屏
                                            if (checkBox_NoScrollScreen.Checked)
                                            {
                                                // this selects the index zero as the location of your caret
                                                tb_receive_zone.Select(0, 0);
                                                // Scrolls to the caret :)
                                                tb_receive_zone.ScrollToCaret();
                                            }
                                            else //滚屏
                                            {
                                                tb_receive_zone.SelectionStart = tb_receive_zone.Text.Length;
                                                tb_receive_zone.ScrollToCaret();
                                            }
                                        }
                                    }

                                    //保存到文件中
                                    save2File();
                                }
                            }
                        }

                        break;
                    default:
                        break;
                }
            }
            else
            {
                //缺省消息处理
                base.WndProc(ref m);
            }
        }

        // 计算CRC校验码
        private static ushort CalculateCRC(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (int pos = 0; pos < data.Length; pos++)
            {
                crc ^= (ushort)data[pos];          // XOR byte into least sig. byte of crc

                for (int i = 8; i != 0; i--)
                {    // Loop over each bit
                    if ((crc & 0x0001) != 0)
                    {              // If the LSB is set
                        crc >>= 1;                    // Shift right and XOR 0xA001
                        crc ^= 0xA001;
                    }
                    else                            // Else LSB is not set
                        crc >>= 1;                    // Just shift right
                }
            }
            return crc;
        }

        // 将字节数组转换为无符号短整型（大端字节序）
        private static ushort ToUInt16BigEndian(byte[] bytes, int index)
        {
            if (BitConverter.IsLittleEndian)
            {
                byte[] bigEndianBytes = new byte[2];
                Array.Copy(bytes, index, bigEndianBytes, 0, 2);
                Array.Reverse(bigEndianBytes); // 反转字节顺序以获得大端字节序
                return BitConverter.ToUInt16(bigEndianBytes, 0);
            }
            else
            {
                return BitConverter.ToUInt16(bytes, index);
            }
        }


        /// <summary>
        /// 处理接收到的数据，修改参数，显示在DataGridView中
        /// </summary>
        /// <param name="receivedData">数据</param>
        /// <param name="pump_no">泵号</param>
        /// <param name="rowIndex">行号</param>
        private void Process_receive_Data_ModiPar(byte[] receivedData, int pump_no, int rowIndex)
        {
            if (receivedData.Length < 5) // 检查数据长度是否足够
            {
                Console.WriteLine("Received data is too short.");
                return;
            }

            // 验证CRC
            ushort receivedCrc = ToUInt16BigEndian(receivedData, receivedData.Length - 2);
            //Array.Resize(ref receivedData, receivedData.Length - 2); // 移除CRC部分以重新计算
            //byte[] receivedData_tmp=new byte[receivedData.Length-2];
            Array.Resize(ref receivedData, receivedData.Length - 2); // 移除CRC部分以重新计算

            ushort calculatedCrc = CalculateCRC(receivedData);

            // 如果系统是小端字节序，需要反转CRC校验码的字节顺序
            if (BitConverter.IsLittleEndian)
            {
                calculatedCrc = (ushort)((calculatedCrc << 8) | (calculatedCrc >> 8));
            }

            if (calculatedCrc != receivedCrc)
            {
                Console.WriteLine("CRC check failed.");
                return;
            }

            // 解析功能码
            byte functionCode = receivedData[1];
            if ((functionCode & 0x0f) == 0x06) // 写单个保持寄存器
            {
                Query_Process_No = "";

                ushort registerAddress = ToUInt16BigEndian(receivedData, 2);
                ushort registerValue = ToUInt16BigEndian(receivedData, 4);
                Console.WriteLine($"Register address: {registerAddress}, Register value: {registerValue}");
                // 在这里添加代码来更新从设备的寄存器值
                if (pump_no == 0 || (functionCode & 0xf0) == 0x10)
                {
                    WriteToSecondColumn(dataGridView1, rowIndex, registerValue);
                }
                else if (pump_no == 1 || (functionCode & 0xf0) == 0x20)
                {
                    WriteToSecondColumn(dataGridView2, rowIndex, registerValue);
                }
                else if (pump_no == 2 || (functionCode & 0xf0) == 0x30)
                {
                    WriteToSecondColumn(dataGridView3, rowIndex, registerValue);
                }
                else if (pump_no == 3 || (functionCode & 0xf0) == 0x40)
                {
                    WriteToSecondColumn(dataGridView4, rowIndex, registerValue);
                }
                else if (pump_no == 4 || (functionCode & 0xf0) == 0x50)
                {
                    WriteToSecondColumn(dataGridView5, rowIndex, registerValue);
                }
            }
            else if ((functionCode & 0x0f) == 0x03 && (functionCode & 0xf0) != 0x00) // 读保持寄存器-设备参数
            {
                if (pump_no == 0 && (functionCode & 0xf0) == 0x10)
                {
                    AnalyseData_ReadPar(dataGridView1, receivedData);
                }
                else if (pump_no == 1 && (functionCode & 0xf0) == 0x20)
                {
                    AnalyseData_ReadPar(dataGridView2, receivedData);
                }
                else if (pump_no == 2 && (functionCode & 0xf0) == 0x30)
                {
                    AnalyseData_ReadPar(dataGridView3, receivedData);
                }
                else if (pump_no == 3 && (functionCode & 0xf0) == 0x40)
                {
                    AnalyseData_ReadPar(dataGridView4, receivedData);
                }
                else if (pump_no == 4 && (functionCode & 0xf0) == 0x50)
                {
                    AnalyseData_ReadPar(dataGridView5, receivedData);
                }

            }
            else if ((functionCode & 0x0f) == 0x03 && (functionCode & 0xf0) == 0x00) // 读保持寄存器-设备状态
            {
                AnalyseData(receivedData);
            }
            else
            {
                Console.WriteLine("Unsupported function code.");
                Logger.WriteLog("Unsupported function code.");
            }

        }

        private void WriteToSecondColumn(DataGridView dgv, int rowIndex, ushort value)
        {
            if (rowIndex >= 0 && rowIndex < dgv.Rows.Count)
            {
                // 获取目标单元格
                DataGridViewCell targetCell = dgv.Rows[rowIndex].Cells[1];
                targetCell.Value = value; // 第2列的索引是1（从0开始计数）

                // 设置目标单元格的文字颜色为红色
                targetCell.Style.ForeColor = Color.Red;

                // 重置其他单元格的文字颜色为默认颜色
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != targetCell)
                        {
                            cell.Style.ForeColor = Color.Black; // 或其他默认颜色
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid row index");
            }
        }

        //分析接收到的数据——读参数
        private void AnalyseData_ReadPar(DataGridView dgv, byte[] data)
        {
            ushort registerValue;
            if (data.Length == 203) // 检查数据长度是否足够
            {
                for (int i = 0; i < 100; i++)
                {
                    registerValue = ToUInt16BigEndian(data, 2 * i + 3);
                    WriteToSecondColumn(dgv, i, registerValue);
                }
            }
            else
            {
                Console.WriteLine("Received data is too short or too loog.");
            }

        }
        //清除接收区域
        private void btn_Clear_ReceiveZone_Click(object sender, EventArgs e)
        {
            tb_receive_zone.Text = "";
        }

        //清除发送区域
        private void btn_clr_sendZone_Click(object sender, EventArgs e)
        {
            tbSend_zone.Text = "";
        }

        /// <summary>
        /// 关闭窗体时保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("确认退出程序？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                #region 保存ini配置
                //通讯设置
                IniFunc.writeString("通信设置", "工作模式", comboBox_WorkMode.Text, filename);
                IniFunc.writeString("通信设置", "服务端口", tb_ServicePort.Text, filename);
                if (checkBox_autoStartService.Checked)
                    IniFunc.writeString("通信设置", "自动开始服务", "1", filename);
                else
                    IniFunc.writeString("通信设置", "自动开始服务", "0", filename);


                //发送设置
                if (chkBox_Send_16.Checked)
                    IniFunc.writeString("发送设置", "十六进制发送", "1", filename);
                else
                    IniFunc.writeString("发送设置", "十六进制发送", "0", filename);

                if (checkBox_reply.Checked)
                    IniFunc.writeString("发送设置", "回应", "1", filename);
                else
                    IniFunc.writeString("发送设置", "回应", "0", filename);

                if (chkBox_Append_CRC.Checked)
                    IniFunc.writeString("发送设置", "添加CRC校验", "1", filename);
                else
                    IniFunc.writeString("发送设置", "添加CRC校验", "0", filename);

                if (tbSend_zone.Text != "")
                    IniFunc.writeString("发送设置", "发送区数据", tbSend_zone.Text, filename);

                IniFunc.writeString("发送设置", "发送间隔时间", textBox_Send_interval_Time.Text.Trim(), filename);


                //接收设置
                //IniFunc.writeString("接收设置", "接收缓冲区", txtBox_receive_Buffer.Text.Trim(), filename);
                IniFunc.writeString("接收设置", "接收区显示", comboBox_receive_Mode.Text.Trim(), filename);

                if (checkBox_Append_Time.Checked)
                    IniFunc.writeString("接收设置", "加时间戳", "1", filename);
                else
                    IniFunc.writeString("接收设置", "加时间戳", "0", filename);

                if (checkBox_NoScrollScreen.Checked)
                    IniFunc.writeString("接收设置", "禁止滚屏", "1", filename);
                else
                    IniFunc.writeString("接收设置", "禁止滚屏", "0", filename);

                //界面配置
                IniFunc.writeString("界面设置", "设备列表第0列宽度", listView_terminal.Columns[0].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第1列宽度", listView_terminal.Columns[1].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第2列宽度", listView_terminal.Columns[2].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第3列宽度", listView_terminal.Columns[3].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第4列宽度", listView_terminal.Columns[4].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第5列宽度", listView_terminal.Columns[5].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第6列宽度", listView_terminal.Columns[6].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第7列宽度", listView_terminal.Columns[7].Width.ToString(), filename);
                IniFunc.writeString("界面设置", "设备列表第8列宽度", listView_terminal.Columns[8].Width.ToString(), filename);

                //DataGridView界面设置
                IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView1.Columns[0].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView1.Columns[1].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView1.Columns[2].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView1.Columns[3].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView1.Columns[4].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView1.Columns[5].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView1.Columns[6].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView1.Columns[7].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView1.Columns[8].Width.ToString(), filename);
                IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView1.Columns[9].Width.ToString(), filename);

                IniFunc.writeString("右侧Splitter设置", "分割距离", (splitContainer5.Width - btnToggle_Right.Width - splitContainer5.SplitterDistance).ToString(), filename);
                IniFunc.writeString("上下Splitter设置", "分割距离", splitContainer3.SplitterDistance.ToString(), filename);
                IniFunc.writeString("splitContainer_status设置", "分割距离2", (splitContainer_status.Width - btnToggle_Right_status.Width - splitContainer_status.SplitterDistance).ToString(), filename);

                #endregion
                Logger.WriteLog("程序结束运行");
                //Close();
                //System.Environment.Exit(0);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;

            }

        }

        //listView排序
        private void listView_terminal_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //this.listView_terminal.ListViewItemSorter = new ListViewItemComparer();
            //// Call the sort method to manually sort.
            //listView_terminal.Sort();


            if (listView_terminal.Columns[e.Column].Tag == null)
            {
                listView_terminal.Columns[e.Column].Tag = true;
            }
            var tabK = (bool)listView_terminal.Columns[e.Column].Tag;
            listView_terminal.Columns[e.Column].Tag = !tabK;
            listView_terminal.ListViewItemSorter = new ListViewSort(e.Column, listView_terminal.Columns[e.Column].Tag);
            //指定排序器并传送列索引与升序降序关键字  
            listView_terminal.Sort();//对列表进行自定义排序 
        }

        //类的继承，接口
        public class ListViewSort : IComparer
        {
            private readonly int _col;
            private readonly bool _descK;

            public ListViewSort()
            {
                _col = 0;
            }

            public ListViewSort(int column, object desc)
            {
                _descK = (bool)desc;
                _col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递  
            }

            public int Compare(object x, object y)
            {
                int tempInt = String.CompareOrdinal(((ListViewItem)x).SubItems[_col].Text,
                                                    ((ListViewItem)y).SubItems[_col].Text);
                if (_descK)
                {
                    return -tempInt;
                }
                return tempInt;
            }
        }

        //打开保存数据文件
        private void btn_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "log/DataLog.txt";
                p.Start();
            }
            catch
            {
                MessageBox.Show("文件暂时不能打开！请检查此文件的位置是否正确！", "无法打开",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //计数器清零
        private void cleancount_tssl_Click(object sender, EventArgs e)
        {
            reciveCount = 0;
            recivecount_tssl.Text = "0";

            sendCount = 0;
            sendcount_tssl.Text = "0";

        }

        //时钟
        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            lbl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //保存到文件中
        private void save2File()
        {
            //int a = await Exce_Save2File();
            Exce_Save2File();
        }

        ////执行->保存文件
        //public Task<int> Exce_Save2File()
        public void Exce_Save2File()
        {
            //int i = 0;
            //return Task.Factory.StartNew(() =>
            {
                string fileName = @"log/DataLog.txt";
                // 获取应用程序的当前目录
                string filePath = Directory.GetCurrentDirectory();

                // 拼接完整的文件路径
                filePath = Path.Combine(filePath, fileName);
                //string content = "Hello, world!";

                // 判断文件是否存在
                if (File.Exists(filePath))
                {
                    // 文件存在，直接写入数据
                    StreamWriter sw = new StreamWriter(filePath, true);
                    //sw.WriteLine(DateTime.Now.ToString() + "(" + tmp_sendBuff.Length + ") " + send_rtb.Text);
                    //sw.WriteLine("{0}", richtxbox_tmp.Text); strbu1
                    sw.WriteLine("{0}", strbu1);
                    sw.Close();
                }
                else
                {
                    // 文件不存在，创建文件并写入数据
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.WriteLine("{0}", strbu1);
                    sw.Close();
                }
            }
        }


        #region CRC校验
        public class CRC
        {
            private byte[] CRC_L = new byte[256]
            {
            0, 192, 193, 1, 195, 3, 2, 194, 198, 6,
            7, 199, 5, 197, 196, 4, 204, 12, 13, 205,
            15, 207, 206, 14, 10, 202, 203, 11, 201, 9,
            8, 200, 216, 24, 25, 217, 27, 219, 218, 26,
            30, 222, 223, 31, 221, 29, 28, 220, 20, 212,
            213, 21, 215, 23, 22, 214, 210, 18, 19, 211,
            17, 209, 208, 16, 240, 48, 49, 241, 51, 243,
            242, 50, 54, 246, 247, 55, 245, 53, 52, 244,
            60, 252, 253, 61, 255, 63, 62, 254, 250, 58,
            59, 251, 57, 249, 248, 56, 40, 232, 233, 41,
            235, 43, 42, 234, 238, 46, 47, 239, 45, 237,
            236, 44, 228, 36, 37, 229, 39, 231, 230, 38,
            34, 226, 227, 35, 225, 33, 32, 224, 160, 96,
            97, 161, 99, 163, 162, 98, 102, 166, 167, 103,
            165, 101, 100, 164, 108, 172, 173, 109, 175, 111,
            110, 174, 170, 106, 107, 171, 105, 169, 168, 104,
            120, 184, 185, 121, 187, 123, 122, 186, 190, 126,
            127, 191, 125, 189, 188, 124, 180, 116, 117, 181,
            119, 183, 182, 118, 114, 178, 179, 115, 177, 113,
            112, 176, 80, 144, 145, 81, 147, 83, 82, 146,
            150, 86, 87, 151, 85, 149, 148, 84, 156, 92,
            93, 157, 95, 159, 158, 94, 90, 154, 155, 91,
            153, 89, 88, 152, 136, 72, 73, 137, 75, 139,
            138, 74, 78, 142, 143, 79, 141, 77, 76, 140,
            68, 132, 133, 69, 135, 71, 70, 134, 130, 66,
            67, 131, 65, 129, 128, 64
            };

            private byte[] CRC_H = new byte[256]
            {
            0, 193, 129, 64, 1, 192, 128, 65, 1, 192,
            128, 65, 0, 193, 129, 64, 1, 192, 128, 65,
            0, 193, 129, 64, 0, 193, 129, 64, 1, 192,
            128, 65, 1, 192, 128, 65, 0, 193, 129, 64,
            0, 193, 129, 64, 1, 192, 128, 65, 0, 193,
            129, 64, 1, 192, 128, 65, 1, 192, 128, 65,
            0, 193, 129, 64, 1, 192, 128, 65, 0, 193,
            129, 64, 0, 193, 129, 64, 1, 192, 128, 65,
            0, 193, 129, 64, 1, 192, 128, 65, 1, 192,
            128, 65, 0, 193, 129, 64, 0, 193, 129, 64,
            1, 192, 128, 65, 1, 192, 128, 65, 0, 193,
            129, 64, 1, 192, 128, 65, 0, 193, 129, 64,
            0, 193, 129, 64, 1, 192, 128, 65, 1, 192,
            128, 65, 0, 193, 129, 64, 0, 193, 129, 64,
            1, 192, 128, 65, 0, 193, 129, 64, 1, 192,
            128, 65, 1, 192, 128, 65, 0, 193, 129, 64,
            0, 193, 129, 64, 1, 192, 128, 65, 1, 192,
            128, 65, 0, 193, 129, 64, 1, 192, 128, 65,
            0, 193, 129, 64, 0, 193, 129, 64, 1, 192,
            128, 65, 0, 193, 129, 64, 1, 192, 128, 65,
            1, 192, 128, 65, 0, 193, 129, 64, 1, 192,
            128, 65, 0, 193, 129, 64, 0, 193, 129, 64,
            1, 192, 128, 65, 1, 192, 128, 65, 0, 193,
            129, 64, 0, 193, 129, 64, 1, 192, 128, 65,
            0, 193, 129, 64, 1, 192, 128, 65, 1, 192,
            128, 65, 0, 193, 129, 64
            };

            public int CRC_Check(byte[] byteTemp, int byteLength)
            {
                int num = 255;
                int num2 = 255;
                byte[] array = new byte[2];
                int num4 = 0;
                int num5 = 0;
                for (int num6 = byteLength; num6 > 0; num6--)
                {
                    num4 = num ^ byteTemp[num5];
                    num5++;
                    num = num2 ^ CRC_H[num4];
                    num2 = CRC_L[num4];
                }

                return (num << 8) | num2;
            }
        }

        #endregion

        #region 控件大小随窗体大小等比例缩放
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            //一定要在属性设置中，设置窗体的MinimumSize属性，设置可变的最小尺寸
            //当窗体缩小到一定程度时，窗体中的控件会产生一定程度的错位！

            //float newx = (this.Width) / x;
            //float newy = (this.Height) / y;
            //setControls(newx, newy, this);

            // 计算标签位置，居中于窗体
            lbl_Title.Location = new System.Drawing.Point((this.ClientSize.Width - lbl_Title.Width) / 2, lbl_Title.Location.Y);
        }
        #endregion

        //自动发送
        private void chkBox_TimeSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_TimeSend.Checked == true)
            {
                timer_AutoSend.Interval = Convert.ToInt32(textBox_Send_interval_Time.Text);
                timer_AutoSend.Start();
            }
            else
            {
                timer_AutoSend.Stop();
            }

        }

        //定时发送数据
        private void timer_AutoSend_Tick(object sender, EventArgs e)
        {
            //timer_AutoSend.Interval = Convert.ToInt32(textBox_Send_interval_Time.Text);
            func_send_Data();
        }

        //在程序中用一个计时器，每隔几秒钟调用一次该函数，打开任务管理器，你会有惊奇的发现
        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearRAM()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion

        private void timer_clearMemory_Tick_1(object sender, EventArgs e)
        {
            ClearRAM();

        }

        //判断空闲超时
        private void timer_timeout_Tick(object sender, EventArgs e)
        {
            //发送计数更新
            long temp1;
            for (int i = 0; i < listView_terminal.Items.Count; i++)
            {
                temp1 = Convert.ToInt32(listView_terminal.Items[i].SubItems[9].Text);
                temp1++;
                listView_terminal.Items[i].SubItems[9].Text = temp1.ToString();
                if (temp1 > Set_TimeOut)
                {
                    listView_terminal.Items[i].Remove();
                }
            }

        }

        #region 右键菜单
        private void 退出_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的项
            if (listView_terminal.SelectedItems.Count > 0)
            {
                // 显示确认对话框
                DialogResult result = MessageBox.Show("确定要删除选中的行吗？", "确认删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    // 获取第一个选中的项并删除
                    ListViewItem selectedItem = listView_terminal.SelectedItems[0];
                    Logger.WriteLog("删除设备：" + selectedItem.SubItems[0].Text + selectedItem.SubItems[1].Text);
                    listView_terminal.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的行！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZGMS Remote Monitoring System\r\n" +
                "Version:  V1.2  \r\n" +
                "Design by:  YLS  \r\n" +
                "Support：  Qingdao Sanli Intelligent Power Co.,Ltd. \r\n" +
                "Date compiled:   2024.12.24", "About",
                MessageBoxButtons.OK);
        }
        #endregion

        #region 点击Radio按钮，从Sqlite数据库中读取数据
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 3);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 4);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 5);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 6);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 7);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 8);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(tabControl2.SelectedIndex, 9);
        }
        #endregion

        #region 切换Tab，即切换泵，从Sqlite数据库中读取数据
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //从Sqlite数据库中读取数据
            if (radioButton1.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 0); }
            else if (radioButton2.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 1); }
            else if (radioButton3.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 2); }
            else if (radioButton4.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 3); }
            else if (radioButton5.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 4); }
            else if (radioButton6.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 5); }
            else if (radioButton7.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 6); }
            else if (radioButton8.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 7); }
            else if (radioButton9.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 8); }
            else if (radioButton10.Checked)
            { LoadDataIntoDataGridView(tabControl2.SelectedIndex, 9); }

            //从ini配置文件中读取列宽，DataGridView界面设置
            Read_ini_DataGridview(tabControl2.SelectedIndex);
        }
        #endregion

        #region dataGridView点击行改变颜色，并读取这一行的数据
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowData(dataGridView1, e.RowIndex);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowData(dataGridView2, e.RowIndex);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowData(dataGridView3, e.RowIndex);
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowData(dataGridView4, e.RowIndex);
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowData(dataGridView5, e.RowIndex);
        }

        //获取Datagridview某一行的数据
        private void GetRowData(DataGridView dgv, int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dgv.Rows.Count)
            {
                return; // or throw an exception based on your requirement
            }

            // 取消之前选中的行的颜色
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // 重置背景颜色
            }

            // 选中行设置为新颜色
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue; // 设置选中行的背景颜色
            }

            // 取消之前选中的行的颜色
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White; // 重置背景颜色
            }

            // 选中行设置为新颜色
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                selectedRow.DefaultCellStyle.BackColor = Color.LightBlue; // 设置选中行的背景颜色
            }

            // 检查点击的是数据行（排除表头）
            if (rowIndex >= 0)
            {
                // 获取点击行的第 2 列（索引 1）
                string cellValue = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                // 将该值设置到 numericUpDown 中
                numericUpDown_ParValue.Text = cellValue;
                numericUpDown_ParValue.Minimum = Convert.ToInt32(dgv.Rows[rowIndex].Cells[7].Value.ToString());//最小值
                numericUpDown_ParValue.Maximum = Convert.ToInt32(dgv.Rows[rowIndex].Cells[8].Value.ToString());//最大值

                Select_Par_Row = rowIndex;    //保存行号到全局变量Select_Par_Row中

                string cellvalue2 = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                Select_Par_Address = Convert.ToInt16(cellvalue2);
                lbl_par_address.Text = $"{Select_Par_Address}";

                Select_Par_Name = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                lbl_parName.Text = Select_Par_Name;

                if (dgv.Rows[rowIndex].Cells[6].Value.ToString() == "0")    //可写
                {
                    numericUpDown_ParValue.Enabled = false;     //禁止修改
                    btn_ModifyPar.Enabled = false;
                }
                else
                {
                    numericUpDown_ParValue.Enabled = true;      //可写
                    btn_ModifyPar.Enabled = true;
                }

                Select_Pump_No = tabControl2.SelectedIndex;     //保存要查询/修改的泵号

                // 将焦点设置到NumericUpDown控件
                //numericUpDown_ParValue.Focus();
            }
        }
        #endregion

        #region 保存datagridview列宽到ini文件
        //保存datagridview列宽到ini文件
        private void Save_Datagridview_ini(int dbview_no)
        {
            switch (dbview_no)
            {
                case 0:
                    //DataGridView界面设置
                    IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView1.Columns[0].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView1.Columns[1].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView1.Columns[2].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView1.Columns[3].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView1.Columns[4].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView1.Columns[5].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView1.Columns[6].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView1.Columns[7].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView1.Columns[8].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView1.Columns[9].Width.ToString(), filename);
                    break;
                case 1:
                    IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView2.Columns[0].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView2.Columns[1].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView2.Columns[2].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView2.Columns[3].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView2.Columns[4].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView2.Columns[5].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView2.Columns[6].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView2.Columns[7].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView2.Columns[8].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView2.Columns[9].Width.ToString(), filename);
                    break;

                case 2:
                    IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView3.Columns[0].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView3.Columns[1].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView3.Columns[2].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView3.Columns[3].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView3.Columns[4].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView3.Columns[5].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView3.Columns[6].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView3.Columns[7].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView3.Columns[8].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView3.Columns[9].Width.ToString(), filename);
                    break;
                case 3:
                    IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView4.Columns[0].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView4.Columns[1].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView4.Columns[2].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView4.Columns[3].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView4.Columns[4].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView4.Columns[5].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView4.Columns[6].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView4.Columns[7].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView4.Columns[8].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView4.Columns[9].Width.ToString(), filename);
                    break;
                case 4:
                    IniFunc.writeString("DataGridView界面设置", "第0列宽度", dataGridView5.Columns[0].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第1列宽度", dataGridView5.Columns[1].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第2列宽度", dataGridView5.Columns[2].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第3列宽度", dataGridView5.Columns[3].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第4列宽度", dataGridView5.Columns[4].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第5列宽度", dataGridView5.Columns[5].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第6列宽度", dataGridView5.Columns[6].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第7列宽度", dataGridView5.Columns[7].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第8列宽度", dataGridView5.Columns[8].Width.ToString(), filename);
                    IniFunc.writeString("DataGridView界面设置", "第9列宽度", dataGridView5.Columns[9].Width.ToString(), filename);
                    break;
                default: break;
            }
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Save_Datagridview_ini(0);
        }

        private void dataGridView2_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Save_Datagridview_ini(1);
        }

        private void dataGridView3_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Save_Datagridview_ini(2);

        }

        private void dataGridView4_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Save_Datagridview_ini(3);

        }

        private void dataGridView5_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Save_Datagridview_ini(4);

        }
        #endregion



        #region 根据panel宽度变化，自动调整里面空间的位置
        private void panelRight_Resize(object sender, EventArgs e)
        {
            // 计算 Panel 的宽度和高度
            int x = (panelRight.ClientSize.Width - btn_QueryPar.Width) / 2;
            //int y = (panelRight.ClientSize.Height - btn_QueryPar.Height) / 2;

            // 设置按钮的坐标
            btn_QueryPar.Location = new System.Drawing.Point(x, btn_QueryPar.Location.Y);
            btn_ModifyPar.Location = new System.Drawing.Point(x, btn_ModifyPar.Location.Y);
            label_parValue.Location = new System.Drawing.Point(x, label_parValue.Location.Y);
            //Eidt_ParValue.Location = new System.Drawing.Point(x, Eidt_ParValue.Location.Y);
            numericUpDown_ParValue.Location = new System.Drawing.Point(x, numericUpDown_ParValue.Location.Y);

            lbl_par_address.Location = new System.Drawing.Point(x, lbl_par_address.Location.Y);
            lbl_parName.Location = new System.Drawing.Point(x, lbl_parName.Location.Y);

            btn_Save_par.Location = new System.Drawing.Point(x, btn_Save_par.Location.Y);
            btn_clear_par_value.Location = new System.Drawing.Point(x, btn_clear_par_value.Location.Y);
        }

        //重新调整Radio所在区域的宽度
        private void splitContainer4_Panel1_Resize(object sender, EventArgs e)
        {
            // 计算 Panel 的宽度和高度
            int x = (splitContainer4.Panel1.ClientSize.Width - radioButton1.Width) / 2;
            //int y = (splitContainer4.Panel1.ClientSize.Height - btn_QueryPar.Height) / 2;

            // 设置Radio的坐标
            radioButton1.Location = new System.Drawing.Point(x, radioButton1.Location.Y);
            radioButton2.Location = new System.Drawing.Point(x, radioButton2.Location.Y);
            radioButton3.Location = new System.Drawing.Point(x, radioButton3.Location.Y);
            radioButton4.Location = new System.Drawing.Point(x, radioButton4.Location.Y);
            radioButton5.Location = new System.Drawing.Point(x, radioButton5.Location.Y);
            radioButton6.Location = new System.Drawing.Point(x, radioButton6.Location.Y);
            radioButton7.Location = new System.Drawing.Point(x, radioButton7.Location.Y);
            radioButton8.Location = new System.Drawing.Point(x, radioButton8.Location.Y);
            radioButton9.Location = new System.Drawing.Point(x, radioButton9.Location.Y);
            radioButton10.Location = new System.Drawing.Point(x, radioButton10.Location.Y);
        }


        #endregion


        //查询参数
        private void btn_QueryPar_Click(object sender, EventArgs e)
        {
            StringBuilder mess = new StringBuilder(100);
            int Address;

            // 确保至少有一个选中的项
            if (listView_terminal.SelectedItems.Count > 0 && Select_DTU_NO != "")
            {

                CheckSelectedRadioButton();//判断Radio控件选择的是哪一个，存入Select_Radio_No中

                Query_Process_No = $"Query_par_{tabControl2.SelectedIndex + 1}_{Select_Radio_No}";
                byte[] dataTemp = new byte[8];
                dataTemp[0] = 0x02;
                dataTemp[1] = 0x03;
                Address = 10000 * (tabControl2.SelectedIndex + 1) + 100 * Select_Radio_No;
                // 将 int 转换为字节数组（默认使用小端字节序）
                byte[] byteArray = BitConverter.GetBytes(Address);
                dataTemp[2] = byteArray[1];
                dataTemp[3] = byteArray[0];
                dataTemp[4] = 0x00;
                dataTemp[5] = 100; //查询100个字
                                   //追加CRC校验
                CRC_txd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                dataTemp[dataTemp.Length - 2] = CRC_txd[1];
                dataTemp[dataTemp.Length - 1] = CRC_txd[0];

                Send_ByteArray(listView_terminal.SelectedItems[0].Text, dataTemp);
                MessageBox.Show("查询数据发送成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("请选择要查询的设备！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //显示发送的数据
        private void Disp_Send_Data(byte[] dataTemp)
        {
            strbu1.Clear();
            strbu1.Append("\r\n");
            strbu1.Append("终端号码：" + listView_terminal.SelectedItems[0].Text + "\r\n");
            strbu1.Append("用户名称：" + listView_terminal.SelectedItems[0].SubItems[1].Text + "\r\n");
            strbu1.Append("发送时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
            strbu1.Append("数据长度：" + dataTemp.Length + "\r\n");
            strbu1.Append("发送数据→：" + Transform.ToHexString(dataTemp, " ") + "\r\n");

            int startlen = tb_receive_zone.TextLength;
            tb_receive_zone.AppendText(strbu1.ToString());   //添加数据
            Logger.WriteLog(strbu1.ToString());
            int endlen = tb_receive_zone.TextLength;
            tb_receive_zone.Select(startlen, endlen - startlen);
            tb_receive_zone.SelectionColor = Color.Red;

            sendCount += dataTemp.Length;
            sendcount_tssl.Text = sendCount.ToString();

            //发送计数更新
            long temp1 = Convert.ToInt32(listView_terminal.SelectedItems[0].SubItems[7].Text) + dataTemp.Length;
            listView_terminal.SelectedItems[0].SubItems[7].Text = temp1.ToString();
        }



        #region listview当复选框的勾选状态变化时
        // 当复选框的勾选状态变化时
        private void listView_terminal_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // If an item is checked, uncheck all other items
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in listView_terminal.Items)
                {
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }

                // Get the first and second column data of the checked item
                string column1Data = e.Item.SubItems[0].Text;
                string column2Data = e.Item.SubItems[1].Text;

                // Display the data in a MessageBox
                //对状态栏进行赋值
                tssl_select_DTU_NO.Text = column1Data;
                tssl_select_DTU_NO.ForeColor = Color.Red;
                tssl_select_USERNAME.Text = column2Data;
                tssl_select_USERNAME.ForeColor = Color.Red;

                //对选择设备进行赋值
                label_DTU_NO.Text = column1Data;
                label_DTU_NO.ForeColor = Color.Red;
                label_USER_NO.Text = column2Data;
                label_USER_NO.ForeColor = Color.Red;
                //tssl_select_pump_no.Text = "";

                //保存当前选择的DTU号
                Select_DTU_NO = column1Data;


                //新选择了设备，所以先清除SQLite中的参数值
                Clear_Par_Value_All();

                // 泵切换到第一个页面
                tabControl2.SelectedIndex = 0;
                // 切换到第一个RadioButton
                radioButton1.Checked = true;

            }
            else
            {
                tssl_select_DTU_NO.Text = "";
                tssl_select_USERNAME.Text = "";

                label_DTU_NO.Text = "";
                label_USER_NO.Text = "";

                Select_DTU_NO = "";
            }
        }

        // 处理鼠标点击事件，点击行时也勾选复选框
        private void listView_terminal_MouseClick(object sender, MouseEventArgs e)
        {
            //System.Windows.Forms.ListView listView = sender as System.Windows.Forms.ListView;

            //// 获取鼠标点击的项
            //ListViewItem selectedItem = listView.GetItemAt(e.X, e.Y);

            //if (selectedItem != null)
            //{
            //    // 如果点击的行复选框没有选中，则选中它
            //    selectedItem.Checked = !selectedItem.Checked;

            //    // 取消其他项的勾选
            //    foreach (ListViewItem item in listView.Items)
            //    {
            //        if (item != selectedItem)
            //        {
            //            item.Checked = false;
            //        }
            //    }

            //    // 选中点击的行
            //    selectedItem.Selected = true;
            //}

            // Get the item that was clicked
            ListViewHitTestInfo info = listView_terminal.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                // Toggle the checkbox state
                info.Item.Checked = !info.Item.Checked;
            }
        }
        #endregion





        //查询1-3号泵状态
        private void btn_QueryStatus_1_3_Click(object sender, EventArgs e)
        {
            // 确保至少有一个选中的项
            if (listView_terminal.SelectedItems.Count > 0)
            {
                Query_Process_No = "Query_Status_13";
                byte[] dataTemp = new byte[8];
                dataTemp[0] = 0x02;
                dataTemp[1] = 0x03;
                dataTemp[2] = 0x00;
                dataTemp[3] = 0x00;
                dataTemp[4] = 0x00;
                dataTemp[5] = 0x78; //从地址0开始查询120个字
                                    //追加CRC校验
                CRC_txd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                dataTemp[dataTemp.Length - 2] = CRC_txd[1];
                dataTemp[dataTemp.Length - 1] = CRC_txd[0];

                Send_ByteArray(listView_terminal.SelectedItems[0].Text, dataTemp);
            }
            else
            {
                MessageBox.Show("请选择要查询的设备！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //查询4-5号泵状态
        private void btn_QueryStatus_4_5_Click(object sender, EventArgs e)
        {
            // 确保至少有一个选中的项
            if (listView_terminal.SelectedItems.Count > 0)
            {
                Query_Process_No = "Query_Status_45";
                byte[] dataTemp = new byte[8];
                dataTemp[0] = 0x02;
                dataTemp[1] = 0x03;
                dataTemp[2] = 0x00;
                dataTemp[3] = 0x78;
                dataTemp[4] = 0x00;
                dataTemp[5] = 0x50; //从地址0x78开始查询80个字
                                    //追加CRC校验
                CRC_txd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                dataTemp[dataTemp.Length - 2] = CRC_txd[1];
                dataTemp[dataTemp.Length - 1] = CRC_txd[0];

                Send_ByteArray(listView_terminal.SelectedItems[0].Text, dataTemp);
            }
            else
            {
                MessageBox.Show("请选择要查询的设备！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //发送一个字节数组
        public void Send_ByteArray(string DTU_No, byte[] data)
        {
            StringBuilder mess = new StringBuilder(100);

            if (do_send_user_data(DTU_No, data, data.Length, mess) == -1)
            {
                tb_receive_zone.AppendText(mess.ToString()); //发送失败
                Logger.WriteLog(mess.ToString());
            }
            else
            {
                Query_DTUid = DTU_No;  //保存查询的DTU ID号
                Disp_Send_Data(data);
            }
        }

        private void CheckSelectedRadioButton()
        {
            // 假设你的 RadioButton 名为 radioButton1 和 radioButton2
            if (radioButton1.Checked)
            {
                Select_Radio_No = 0;
            }
            else if (radioButton2.Checked)
            {
                Select_Radio_No = 1;
            }
            else if (radioButton3.Checked)
            {
                Select_Radio_No = 2;
            }
            else if (radioButton4.Checked)
            {
                Select_Radio_No = 3;
            }
            else if (radioButton5.Checked)
            {
                Select_Radio_No = 4;
            }
            else if (radioButton6.Checked)
            {
                Select_Radio_No = 5;
            }
            else if (radioButton7.Checked)
            {
                Select_Radio_No = 6;
            }
            else if (radioButton8.Checked)
            {
                Select_Radio_No = 7;
            }
            else if (radioButton9.Checked)
            {
                Select_Radio_No = 8;
            }
            else if (radioButton10.Checked)
            {
                Select_Radio_No = 9;
            }
        }

        //修改参数
        private void btn_ModifyPar_Click(object sender, EventArgs e)
        {
            StringBuilder mess = new StringBuilder(100);
            int Address;

            // 确保至少有一个选中的项
            if (listView_terminal.SelectedItems.Count > 0)
            {
                CheckSelectedRadioButton();//判断Radio控件选择的是哪一个，存入Select_Radio_No中

                // 弹出提示框，询问是否确定要修改参数
                DialogResult result = MessageBox.Show($"是否确定要修改参数？\n将{tabControl2.SelectedIndex + 1}#泵的参数地址:[{lbl_par_address.Text}]，参数名称:[{lbl_parName.Text}]修改为:[{numericUpDown_ParValue.Value}]？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // 如果用户选择“是”
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        byte[] dataTemp = new byte[8];
                        dataTemp[0] = 0x02;
                        dataTemp[1] = 0x06;
                        Address = 10000 * (tabControl2.SelectedIndex + 1) + Convert.ToInt32(lbl_par_address.Text);
                        // 将 int 转换为字节数组（默认使用小端字节序）
                        byte[] byteArray = BitConverter.GetBytes(Address);
                        dataTemp[2] = byteArray[1];
                        dataTemp[3] = byteArray[0];

                        dataTemp[4] = (byte)((int)numericUpDown_ParValue.Value >> 8);
                        dataTemp[5] = (byte)((int)numericUpDown_ParValue.Value & 0xFF); //要修改的参数值

                        //追加CRC校验
                        CRC_txd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                        dataTemp[dataTemp.Length - 2] = CRC_txd[1];
                        dataTemp[dataTemp.Length - 1] = CRC_txd[0];

                        Send_ByteArray(listView_terminal.SelectedItems[0].Text, dataTemp);
                        Query_Process_No = $"Modify_par_{tabControl2.SelectedIndex + 1}_{Select_Radio_No}";
                        MessageBox.Show("修改数据发送成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"数据发送失败: {ex.Message}", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要查询的设备！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //把字符串转换为数字，并存入字节数组中
        static byte[] StringToByteArray(string s)
        {
            try
            {
                // 将字符串解析为整数
                int number = int.Parse(s);

                // 将整数转换为字节数组
                byte[] byteArray = BitConverter.GetBytes(number);

                return byteArray;
            }
            catch (FormatException)
            {
                Console.WriteLine("输入的字符串不是有效的数字");
                return null;
            }
        }

        private void numericUpDown_ParValue_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                // 触发按钮的点击事件
                btn_ModifyPar_Click(this, EventArgs.Empty);
            }

        }

        /// <summary>
        /// 解析数据
        /// </summary>
        /// <param name="dataTemp"></param>
        private void AnalyseData(byte[] dataTemp)
        {
            int Temp;
            double Temp_f;

            // 解析数据
            if (dataTemp.Length >= 5)
            {
                if (dataTemp[0] == 0x02 && dataTemp[1] == 0x03) //dataTemp.Length == 85 && 
                {
                    if (dataTemp.Length == dataTemp[2] + 3)
                    {
                        //CRC_rxd = Class_CRC16_Modbus.Crc16(dataTemp, dataTemp.Length - 2);
                        //if (CRC_rxd[0] == dataTemp[dataTemp.Length - 1] && CRC_rxd[1] == dataTemp[dataTemp.Length - 2])
                        {
                            #region  解析数据
                            if (dataTemp[2] == 240) //Query_Par_No == 1 &&
                            {
                                //Query_Par_No = 2;

                                #region 1#高频双驱泵
                                //1#高频双驱泵
                                lbl_No1.BackColor = Color.FromArgb(255, 192, 128);
                                //合相有功功率
                                Temp_f = ((dataTemp[1 * 2 + 3] << 24) + (dataTemp[1 * 2 + 3 + 1] << 16) + (dataTemp[0 * 2 + 3] << 8) + dataTemp[0 * 2 + 3 + 1]) / 10.0;
                                textBox2.Text = string.Format("{0:F1}", Temp_f);
                                //目标频率
                                Temp_f = ((dataTemp[2 * 2 + 3] << 8) + dataTemp[2 * 2 + 3 + 1]) / 10.0;
                                textBox1.Text = string.Format("{0:F1}", Temp_f);
                                //输出电压
                                Temp_f = ((dataTemp[3 * 2 + 3] << 8) + dataTemp[3 * 2 + 3 + 1]);
                                textBox53.Text = string.Format("{0:F0}", Temp_f);
                                //合相有功电能
                                Temp_f = ((dataTemp[5 * 2 + 3] << 24) + (dataTemp[5 * 2 + 3 + 1] << 16) + (dataTemp[4 * 2 + 3] << 8) + dataTemp[4 * 2 + 3 + 1]) / 10.0;
                                textBox3.Text = string.Format("{0:F1}", Temp_f);
                                //变频器故障代码
                                Temp_f = ((dataTemp[6 * 2 + 3] << 8) + dataTemp[6 * 2 + 3 + 1]);
                                textBox116.Text = string.Format("{0:F0}", Temp_f);
                                //软件版本
                                Temp_f = ((dataTemp[7 * 2 + 3] << 8) + dataTemp[7 * 2 + 3 + 1]) / 100.0;
                                textBox111.Text = string.Format("{0:F2}", Temp_f);
                                //效率
                                Temp_f = ((dataTemp[8 * 2 + 3] << 8) + dataTemp[8 * 2 + 3 + 1]) / 100.0;
                                textBox4.Text = string.Format("{0:F2}", Temp_f);
                                //停机数量
                                Temp_f = ((dataTemp[9 * 2 + 3] << 8) + dataTemp[9 * 2 + 3 + 1]);
                                textBox121.Text = string.Format("{0:F0}", Temp_f);
                                //瞬时流量
                                Temp_f = ((dataTemp[11 * 2 + 3] << 24) + (dataTemp[11 * 2 + 3 + 1] << 16) + (dataTemp[10 * 2 + 3] << 8) + dataTemp[10 * 2 + 3 + 1]) / 100.0;
                                textBox5.Text = string.Format("{0:F2}", Temp_f);
                                //累计流量
                                Temp_f = ((dataTemp[13 * 2 + 3] << 24) + (dataTemp[13 * 2 + 3 + 1] << 16) + (dataTemp[12 * 2 + 3] << 8) + dataTemp[12 * 2 + 3 + 1]) / 10.0;
                                textBox6.Text = string.Format("{0:F1}", Temp_f);
                                //电压
                                Temp_f = ((dataTemp[14 * 2 + 3] << 8) + dataTemp[14 * 2 + 3 + 1]) / 10.0;
                                textBox7.Text = string.Format("{0:F1}", Temp_f);
                                //启停
                                Temp_f = ((dataTemp[15 * 2 + 3] << 8) + dataTemp[15 * 2 + 3 + 1]);
                                textBox8.Text = string.Format("{0:F0}", Temp_f);
                                //转速
                                Temp_f = ((dataTemp[16 * 2 + 3] << 8) + dataTemp[16 * 2 + 3 + 1]);
                                textBox9.Text = string.Format("{0:F0}", Temp_f);
                                //功率因数
                                Temp_f = ((dataTemp[17 * 2 + 3] << 8) + dataTemp[17 * 2 + 3 + 1]) / 100.0;
                                textBox126.Text = string.Format("{0:F2}", Temp_f);
                                //变频器计数
                                Temp_f = ((dataTemp[18 * 2 + 3] << 8) + dataTemp[18 * 2 + 3 + 1]);
                                textBox10.Text = string.Format("{0:F0}", Temp_f);
                                //220计数
                                Temp_f = ((dataTemp[19 * 2 + 3] << 8) + dataTemp[19 * 2 + 3 + 1]);
                                textBox11.Text = string.Format("{0:F0}", Temp_f);
                                //电流
                                Temp_f = ((dataTemp[20 * 2 + 3] << 8) + dataTemp[20 * 2 + 3 + 1]) / 100.0;
                                textBox81.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位1
                                Temp_f = ((dataTemp[21 * 2 + 3] << 8) + dataTemp[21 * 2 + 3 + 1]) / 100.0;
                                textBox131.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位2
                                Temp_f = ((dataTemp[22 * 2 + 3] << 8) + dataTemp[22 * 2 + 3 + 1]) / 100.0;
                                textBox155.Text = string.Format("{0:F2}", Temp_f);
                                //累计运行时间——秒
                                Temp_f = ((dataTemp[23 * 2 + 3] << 8) + dataTemp[23 * 2 + 3 + 1]);
                                textBox14.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——分钟
                                Temp_f = ((dataTemp[24 * 2 + 3] << 8) + dataTemp[24 * 2 + 3 + 1]);
                                textBox13.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——小时
                                Temp_f = ((dataTemp[26 * 2 + 3] << 24) + (dataTemp[26 * 2 + 3 + 1] << 16) + (dataTemp[25 * 2 + 3] << 8) + dataTemp[25 * 2 + 3 + 1]);
                                textBox12.Text = string.Format("{0:F0}", Temp_f);
                                //频率
                                Temp_f = ((dataTemp[27 * 2 + 3] << 8) + dataTemp[27 * 2 + 3 + 1]) / 10.0;
                                textBox15.Text = string.Format("{0:F1}", Temp_f);
                                //进水压力
                                Temp_f = ((dataTemp[28 * 2 + 3] << 8) + dataTemp[28 * 2 + 3 + 1]) / 1000.0;
                                textBox16.Text = string.Format("{0:F3}", Temp_f);
                                //出水压力
                                Temp_f = ((dataTemp[29 * 2 + 3] << 8) + dataTemp[29 * 2 + 3 + 1]) / 1000.0;
                                textBox51.Text = string.Format("{0:F3}", Temp_f);
                                //1#温度
                                Temp_f = ((dataTemp[30 * 2 + 3] << 8) + dataTemp[30 * 2 + 3 + 1]) / 10.0;
                                textBox18.Text = string.Format("{0:F1}", Temp_f);
                                //2#温度
                                Temp_f = ((dataTemp[31 * 2 + 3] << 8) + dataTemp[31 * 2 + 3 + 1]) / 10.0;
                                textBox19.Text = string.Format("{0:F1}", Temp_f);
                                //设定压力
                                Temp_f = ((dataTemp[32 * 2 + 3] << 8) + dataTemp[32 * 2 + 3 + 1]) / 1000.0;
                                textBox17.Text = string.Format("{0:F3}", Temp_f);

                                //手动定频
                                Temp_f = ((dataTemp[37 * 2 + 3] << 8) + dataTemp[37 * 2 + 3 + 1]) / 10.0;
                                textBox139.Text = string.Format("{0:F1}", Temp_f);

                                //预留2
                                Temp_f = ((dataTemp[38 * 2 + 3] << 8) + dataTemp[38 * 2 + 3 + 1]);
                                textBox140.Text = string.Format("{0:F0}", Temp_f);

                                //预留3
                                Temp_f = ((dataTemp[39 * 2 + 3] << 8) + dataTemp[39 * 2 + 3 + 1]);
                                textBox141.Text = string.Format("{0:F0}", Temp_f);

                                //停机状态
                                Temp = (dataTemp[33 * 2 + 3] << 8) + dataTemp[33 * 2 + 3 + 1];
                                label41.Text = "1#:" + string.Format("{0:X0}H", Temp);
                                comboBox1.Items.Clear();
                                comboBox1.Text = "";
                                if ((Temp & 0x0002) != 0)
                                {
                                    comboBox1.Items.Add("主令开关停止");
                                }
                                if ((Temp & 0x0004) != 0)
                                {
                                    comboBox1.Items.Add("变频器报警");
                                }
                                if ((Temp & 0x0010) != 0)
                                {
                                    comboBox1.Items.Add("无水停机");
                                }
                                if ((Temp & 0x0400) != 0)
                                {
                                    comboBox1.Items.Add("软件超压保护");
                                }
                                if ((Temp & 0x4000) != 0)
                                {
                                    comboBox1.Items.Add("进水压高节能停机");
                                }

                                Temp = (dataTemp[34 * 2 + 3] << 8) + dataTemp[34 * 2 + 3 + 1];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0001) != 0)
                                {
                                    comboBox1.Items.Add("进水压高保护停机");
                                }
                                if ((Temp & 0x0100) != 0)
                                {
                                    comboBox1.Items.Add("远程遥控停机");
                                }

                                Temp = (dataTemp[35 * 2 + 3] << 8) + dataTemp[35 * 2 + 3 + 1];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0200) != 0)
                                {
                                    comboBox1.Items.Add("遥控定频");
                                }
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedIndex = 0;
                                }

                                //设备状态
                                Temp = (dataTemp[36 * 2 + 3] << 8) + dataTemp[36 * 2 + 3 + 1];
                                label42.Text = "1#:" + string.Format("{0:X0}H", Temp);
                                comboBox2.Items.Clear();
                                comboBox2.Text = "";
                                if ((Temp & 0x0e00) != 0)
                                {
                                    if ((Temp & 0x0200) != 0)
                                    {
                                        comboBox2.Items.Add("变频");
                                    }
                                    if ((Temp & 0x0400) != 0)
                                    {
                                        comboBox2.Items.Add("工频");
                                    }
                                    if ((Temp & 0x0800) != 0)
                                    {
                                        comboBox2.Items.Add("故障");
                                    }
                                }
                                else
                                {
                                    comboBox2.Items.Add("停止");
                                }
                                if (comboBox2.Items.Count > 0)
                                {
                                    comboBox2.SelectedIndex = 0;
                                }

                                update_count[0] += 1;
                                textBox163.Text = update_count[0].ToString();
                                textBox158.Text = DateTime.Now.ToString();
                                #endregion 

                                #region 2#高频双驱泵
                                //2#高频双驱泵
                                lbl_No2.BackColor = Color.FromArgb(255, 192, 128);

                                //合相有功功率
                                Temp_f = ((dataTemp[1 * 2 + 3 + 40 * 2] << 24) + (dataTemp[1 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[0 * 2 + 3 + 40 * 2] << 8) + dataTemp[0 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox20.Text = string.Format("{0:F1}", Temp_f);
                                //目标频率
                                Temp_f = ((dataTemp[2 * 2 + 3 + 40 * 2] << 8) + dataTemp[2 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox22.Text = string.Format("{0:F1}", Temp_f);
                                //输出电压
                                Temp_f = ((dataTemp[3 * 2 + 3 + 40 * 2] << 8) + dataTemp[3 * 2 + 3 + 1 + 40 * 2]);
                                textBox54.Text = string.Format("{0:F0}", Temp_f);
                                //合相有功电能
                                Temp_f = ((dataTemp[5 * 2 + 3 + 40 * 2] << 24) + (dataTemp[5 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[4 * 2 + 3 + 40 * 2] << 8) + dataTemp[4 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox21.Text = string.Format("{0:F1}", Temp_f);
                                //变频器故障代码
                                Temp_f = ((dataTemp[6 * 2 + 3 + 40 * 2] << 8) + dataTemp[6 * 2 + 3 + 1 + 40 * 2]);
                                textBox117.Text = string.Format("{0:F0}", Temp_f);
                                //软件版本
                                Temp_f = ((dataTemp[7 * 2 + 3 + 40 * 2] << 8) + dataTemp[7 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox112.Text = string.Format("{0:F2}", Temp_f);
                                //效率
                                Temp_f = ((dataTemp[8 * 2 + 3 + 40 * 2] << 8) + dataTemp[8 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox23.Text = string.Format("{0:F2}", Temp_f);
                                //停机数量
                                Temp_f = ((dataTemp[9 * 2 + 3 + 40 * 2] << 8) + dataTemp[9 * 2 + 3 + 1 + 40 * 2]);
                                textBox122.Text = string.Format("{0:F0}", Temp_f);
                                //瞬时流量
                                Temp_f = ((dataTemp[11 * 2 + 3 + 40 * 2] << 24) + (dataTemp[11 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[10 * 2 + 3 + 40 * 2] << 8) + dataTemp[10 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox24.Text = string.Format("{0:F2}", Temp_f);
                                //累计流量
                                Temp_f = ((dataTemp[13 * 2 + 3 + 40 * 2] << 24) + (dataTemp[13 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[12 * 2 + 3 + 40 * 2] << 8) + dataTemp[12 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox25.Text = string.Format("{0:F1}", Temp_f);
                                //电压
                                Temp_f = ((dataTemp[14 * 2 + 3 + 40 * 2] << 8) + dataTemp[14 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox26.Text = string.Format("{0:F1}", Temp_f);
                                //启停
                                Temp_f = ((dataTemp[15 * 2 + 3 + 40 * 2] << 8) + dataTemp[15 * 2 + 3 + 1 + 40 * 2]);
                                textBox28.Text = string.Format("{0:F0}", Temp_f);
                                //转速
                                Temp_f = ((dataTemp[16 * 2 + 3 + 40 * 2] << 8) + dataTemp[16 * 2 + 3 + 1 + 40 * 2]);
                                textBox27.Text = string.Format("{0:F0}", Temp_f);
                                //功率因数
                                Temp_f = ((dataTemp[17 * 2 + 3 + 40 * 2] << 8) + dataTemp[17 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox127.Text = string.Format("{0:F2}", Temp_f);
                                //变频器计数
                                Temp_f = ((dataTemp[18 * 2 + 3 + 40 * 2] << 8) + dataTemp[18 * 2 + 3 + 1 + 40 * 2]);
                                textBox30.Text = string.Format("{0:F0}", Temp_f);
                                //220计数
                                Temp_f = ((dataTemp[19 * 2 + 3 + 40 * 2] << 8) + dataTemp[19 * 2 + 3 + 1 + 40 * 2]);
                                textBox33.Text = string.Format("{0:F0}", Temp_f);
                                //电流
                                Temp_f = ((dataTemp[20 * 2 + 3 + 40 * 2] << 8) + dataTemp[20 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox82.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位1
                                Temp_f = ((dataTemp[21 * 2 + 3 + 40 * 2] << 8) + dataTemp[21 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox132.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位2
                                Temp_f = ((dataTemp[22 * 2 + 3 + 40 * 2] << 8) + dataTemp[22 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox153.Text = string.Format("{0:F2}", Temp_f);


                                //累计运行时间——秒
                                Temp_f = ((dataTemp[23 * 2 + 3 + 40 * 2] << 8) + dataTemp[23 * 2 + 3 + 1 + 40 * 2]);
                                textBox32.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——分钟
                                Temp_f = ((dataTemp[24 * 2 + 3 + 40 * 2] << 8) + dataTemp[24 * 2 + 3 + 1 + 40 * 2]);
                                textBox31.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——小时
                                Temp_f = ((dataTemp[26 * 2 + 3 + 40 * 2] << 24) + (dataTemp[26 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[25 * 2 + 3 + 40 * 2] << 8) + dataTemp[25 * 2 + 3 + 1 + 40 * 2]);
                                textBox29.Text = string.Format("{0:F0}", Temp_f);
                                //频率
                                Temp_f = ((dataTemp[27 * 2 + 3 + 40 * 2] << 8) + dataTemp[27 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox34.Text = string.Format("{0:F1}", Temp_f);
                                //进水压力
                                Temp_f = ((dataTemp[28 * 2 + 3 + 40 * 2] << 8) + dataTemp[28 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox35.Text = string.Format("{0:F3}", Temp_f);
                                //出水压力
                                Temp_f = ((dataTemp[29 * 2 + 3 + 40 * 2] << 8) + dataTemp[29 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox52.Text = string.Format("{0:F3}", Temp_f);
                                //1#温度
                                Temp_f = ((dataTemp[30 * 2 + 3 + 40 * 2] << 8) + dataTemp[30 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox37.Text = string.Format("{0:F1}", Temp_f);
                                //2#温度
                                Temp_f = ((dataTemp[31 * 2 + 3 + 40 * 2] << 8) + dataTemp[31 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox38.Text = string.Format("{0:F1}", Temp_f);
                                //设定压力
                                Temp_f = ((dataTemp[32 * 2 + 3 + 40 * 2] << 8) + dataTemp[32 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox36.Text = string.Format("{0:F3}", Temp_f);

                                //手动定频
                                Temp_f = ((dataTemp[37 * 2 + 3 + 40 * 2] << 8) + dataTemp[37 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox136.Text = string.Format("{0:F1}", Temp_f);

                                //预留2
                                Temp_f = ((dataTemp[38 * 2 + 3 + 40 * 2] << 8) + dataTemp[38 * 2 + 3 + 1 + 40 * 2]);
                                textBox137.Text = string.Format("{0:F0}", Temp_f);

                                //预留3
                                Temp_f = ((dataTemp[39 * 2 + 3 + 40 * 2] << 8) + dataTemp[39 * 2 + 3 + 1 + 40 * 2]);
                                textBox138.Text = string.Format("{0:F0}", Temp_f);

                                //2#停机状态
                                Temp = (dataTemp[33 * 2 + 3 + 40 * 2] << 8) + dataTemp[33 * 2 + 3 + 1 + 40 * 2];
                                label56.Text = "2#:" + string.Format("{0:X0}H", Temp);
                                comboBox3.Items.Clear();
                                comboBox3.Text = "";
                                if ((Temp & 0x0002) != 0)
                                {
                                    comboBox3.Items.Add("主令开关停止");
                                }
                                if ((Temp & 0x0004) != 0)
                                {
                                    comboBox3.Items.Add("变频器报警");
                                }
                                if ((Temp & 0x0010) != 0)
                                {
                                    comboBox3.Items.Add("无水停机");
                                }
                                if ((Temp & 0x0400) != 0)
                                {
                                    comboBox3.Items.Add("软件超压保护");
                                }
                                if ((Temp & 0x4000) != 0)
                                {
                                    comboBox3.Items.Add("进水压高节能停机");
                                }
                                Temp = (dataTemp[34 * 2 + 3 + 40 * 2] << 8) + dataTemp[34 * 2 + 3 + 1 + 40 * 2];
                                label56.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0001) != 0)
                                {
                                    comboBox3.Items.Add("进水压高保护停机");
                                }
                                if ((Temp & 0x0100) != 0)
                                {
                                    comboBox3.Items.Add("远程遥控停机");
                                }

                                Temp = (dataTemp[35 * 2 + 3 + 40 * 2] << 8) + dataTemp[35 * 2 + 3 + 1 + 40 * 2];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0200) != 0)
                                {
                                    comboBox1.Items.Add("遥控定频");
                                }
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedIndex = 0;
                                }
                                //2#状态
                                Temp = (dataTemp[36 * 2 + 3 + 40 * 2] << 8) + dataTemp[36 * 2 + 3 + 1 + 40 * 2];
                                label57.Text = "2#:" + string.Format("{0:X0}H", Temp);
                                comboBox4.Items.Clear();
                                comboBox4.Text = "";
                                if ((Temp & 0x0e00) != 0)
                                {
                                    if ((Temp & 0x0200) != 0)
                                    {
                                        comboBox4.Items.Add("变频");
                                    }
                                    if ((Temp & 0x0400) != 0)
                                    {
                                        comboBox4.Items.Add("工频");
                                    }
                                    if ((Temp & 0x0800) != 0)
                                    {
                                        comboBox4.Items.Add("故障");
                                    }
                                }
                                else
                                {
                                    comboBox4.Items.Add("停止");
                                }
                                if (comboBox4.Items.Count > 0)
                                {
                                    comboBox4.SelectedIndex = 0;
                                }

                                update_count[1] += 1;
                                textBox165.Text = update_count[1].ToString();
                                textBox161.Text = DateTime.Now.ToString();
                                #endregion


                                #region 3#高频双驱泵
                                //3#高频双驱泵
                                lbl_No3.BackColor = Color.FromArgb(255, 192, 128);

                                //合相有功功率
                                Temp_f = ((dataTemp[1 * 2 + 3 + 80 * 2] << 24) + (dataTemp[1 * 2 + 3 + 1 + 80 * 2] << 16) + (dataTemp[0 * 2 + 3 + 80 * 2] << 8) + dataTemp[0 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox39.Text = string.Format("{0:F1}", Temp_f);
                                //目标频率
                                Temp_f = ((dataTemp[2 * 2 + 3 + 80 * 2] << 8) + dataTemp[2 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox41.Text = string.Format("{0:F1}", Temp_f);
                                //输出电压
                                Temp_f = ((dataTemp[3 * 2 + 3 + 80 * 2] << 8) + dataTemp[3 * 2 + 3 + 1 + 80 * 2]);
                                textBox42.Text = string.Format("{0:F0}", Temp_f);
                                //合相有功电能
                                Temp_f = ((dataTemp[5 * 2 + 3 + 80 * 2] << 24) + (dataTemp[5 * 2 + 3 + 1 + 80 * 2] << 16) + (dataTemp[4 * 2 + 3 + 80 * 2] << 8) + dataTemp[4 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox40.Text = string.Format("{0:F1}", Temp_f);
                                //变频器故障代码
                                Temp_f = ((dataTemp[6 * 2 + 3 + 80 * 2] << 8) + dataTemp[6 * 2 + 3 + 1 + 80 * 2]);
                                textBox118.Text = string.Format("{0:F0}", Temp_f);
                                //软件版本
                                Temp_f = ((dataTemp[7 * 2 + 3 + 80 * 2] << 8) + dataTemp[7 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox113.Text = string.Format("{0:F2}", Temp_f);
                                //效率
                                Temp_f = ((dataTemp[8 * 2 + 3 + 80 * 2] << 8) + dataTemp[8 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox43.Text = string.Format("{0:F2}", Temp_f);
                                //停机数量
                                Temp_f = ((dataTemp[9 * 2 + 3 + 80 * 2] << 8) + dataTemp[9 * 2 + 3 + 1 + 80 * 2]);
                                textBox123.Text = string.Format("{0:F0}", Temp_f);
                                //瞬时流量
                                Temp_f = ((dataTemp[11 * 2 + 3 + 80 * 2] << 24) + (dataTemp[11 * 2 + 3 + 1 + 80 * 2] << 16) + (dataTemp[10 * 2 + 3 + 80 * 2] << 8) + dataTemp[10 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox44.Text = string.Format("{0:F2}", Temp_f);
                                //累计流量
                                Temp_f = ((dataTemp[13 * 2 + 3 + 80 * 2] << 24) + (dataTemp[13 * 2 + 3 + 1 + 80 * 2] << 16) + (dataTemp[12 * 2 + 3 + 80 * 2] << 8) + dataTemp[12 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox45.Text = string.Format("{0:F1}", Temp_f);
                                //电压
                                Temp_f = ((dataTemp[14 * 2 + 3 + 80 * 2] << 8) + dataTemp[14 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox46.Text = string.Format("{0:F1}", Temp_f);
                                //启停
                                Temp_f = ((dataTemp[15 * 2 + 3 + 80 * 2] << 8) + dataTemp[15 * 2 + 3 + 1 + 80 * 2]);
                                textBox48.Text = string.Format("{0:F0}", Temp_f);
                                //转速
                                Temp_f = ((dataTemp[16 * 2 + 3 + 80 * 2] << 8) + dataTemp[16 * 2 + 3 + 1 + 80 * 2]);
                                textBox47.Text = string.Format("{0:F0}", Temp_f);
                                //功率因数
                                Temp_f = ((dataTemp[17 * 2 + 3 + 80 * 2] << 8) + dataTemp[17 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox128.Text = string.Format("{0:F2}", Temp_f);
                                //变频器计数
                                Temp_f = ((dataTemp[18 * 2 + 3 + 80 * 2] << 8) + dataTemp[18 * 2 + 3 + 1 + 80 * 2]);
                                textBox50.Text = string.Format("{0:F0}", Temp_f);
                                //220计数
                                Temp_f = ((dataTemp[19 * 2 + 3 + 80 * 2] << 8) + dataTemp[19 * 2 + 3 + 1 + 80 * 2]);
                                textBox57.Text = string.Format("{0:F0}", Temp_f);
                                //电流
                                Temp_f = ((dataTemp[20 * 2 + 3 + 80 * 2] << 8) + dataTemp[20 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox64.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位1
                                Temp_f = ((dataTemp[21 * 2 + 3 + 80 * 2] << 8) + dataTemp[21 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox133.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位2
                                Temp_f = ((dataTemp[22 * 2 + 3 + 80 * 2] << 8) + dataTemp[22 * 2 + 3 + 1 + 80 * 2]) / 100.0;
                                textBox154.Text = string.Format("{0:F2}", Temp_f);
                                //累计运行时间——秒
                                Temp_f = ((dataTemp[23 * 2 + 3 + 80 * 2] << 8) + dataTemp[23 * 2 + 3 + 1 + 80 * 2]);
                                textBox56.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——分钟
                                Temp_f = ((dataTemp[24 * 2 + 3 + 80 * 2] << 8) + dataTemp[24 * 2 + 3 + 1 + 80 * 2]);
                                textBox55.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——小时
                                Temp_f = ((dataTemp[26 * 2 + 3 + 80 * 2] << 24) + (dataTemp[26 * 2 + 3 + 1 + 80 * 2] << 16) + (dataTemp[25 * 2 + 3 + 80 * 2] << 8) + dataTemp[25 * 2 + 3 + 1 + 80 * 2]);
                                textBox49.Text = string.Format("{0:F0}", Temp_f);
                                //频率
                                Temp_f = ((dataTemp[27 * 2 + 3 + 80 * 2] << 8) + dataTemp[27 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox58.Text = string.Format("{0:F1}", Temp_f);
                                //进水压力
                                Temp_f = ((dataTemp[28 * 2 + 3 + 80 * 2] << 8) + dataTemp[28 * 2 + 3 + 1 + 80 * 2]) / 1000.0;
                                textBox59.Text = string.Format("{0:F3}", Temp_f);
                                //出水压力
                                Temp_f = ((dataTemp[29 * 2 + 3 + 80 * 2] << 8) + dataTemp[29 * 2 + 3 + 1 + 80 * 2]) / 1000.0;
                                textBox61.Text = string.Format("{0:F3}", Temp_f);
                                //1#温度
                                Temp_f = ((dataTemp[30 * 2 + 3 + 80 * 2] << 8) + dataTemp[30 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox62.Text = string.Format("{0:F1}", Temp_f);
                                //2#温度
                                Temp_f = ((dataTemp[31 * 2 + 3 + 80 * 2] << 8) + dataTemp[31 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox63.Text = string.Format("{0:F1}", Temp_f);
                                //设定压力
                                Temp_f = ((dataTemp[32 * 2 + 3 + 80 * 2] << 8) + dataTemp[32 * 2 + 3 + 1 + 80 * 2]) / 1000.0;
                                textBox60.Text = string.Format("{0:F3}", Temp_f);

                                //手动定频
                                Temp_f = ((dataTemp[37 * 2 + 3 + 80 * 2] << 8) + dataTemp[37 * 2 + 3 + 1 + 80 * 2]) / 10.0;
                                textBox143.Text = string.Format("{0:F1}", Temp_f);

                                //预留2
                                Temp_f = ((dataTemp[38 * 2 + 3 + 80 * 2] << 8) + dataTemp[38 * 2 + 3 + 1 + 80 * 2]);
                                textBox145.Text = string.Format("{0:F0}", Temp_f);

                                //预留3
                                Temp_f = ((dataTemp[39 * 2 + 3 + 80 * 2] << 8) + dataTemp[39 * 2 + 3 + 1 + 80 * 2]);
                                textBox147.Text = string.Format("{0:F0}", Temp_f);

                                //3#停机状态
                                Temp = (dataTemp[33 * 2 + 3 + 80 * 2] << 8) + dataTemp[33 * 2 + 3 + 1 + 80 * 2];
                                label94.Text = "3#:" + string.Format("{0:X0}H", Temp);
                                comboBox5.Items.Clear();
                                comboBox5.Text = "";
                                if ((Temp & 0x0002) != 0)
                                {
                                    comboBox5.Items.Add("主令开关停止");
                                }
                                if ((Temp & 0x0004) != 0)
                                {
                                    comboBox5.Items.Add("变频器报警");
                                }
                                if ((Temp & 0x0010) != 0)
                                {
                                    comboBox5.Items.Add("无水停机");
                                }
                                if ((Temp & 0x0400) != 0)
                                {
                                    comboBox5.Items.Add("软件超压保护");
                                }
                                if ((Temp & 0x4000) != 0)
                                {
                                    comboBox5.Items.Add("进水压高节能停机");
                                }
                                Temp = (dataTemp[34 * 2 + 3 + 80 * 2] << 8) + dataTemp[34 * 2 + 3 + 1 + 80 * 2];
                                label94.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0001) != 0)
                                {
                                    comboBox5.Items.Add("进水压高保护停机");
                                }
                                if ((Temp & 0x0100) != 0)
                                {
                                    comboBox5.Items.Add("远程遥控停机");
                                }

                                Temp = (dataTemp[35 * 2 + 3 + 80 * 2] << 8) + dataTemp[35 * 2 + 3 + 1 + 80 * 2];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0200) != 0)
                                {
                                    comboBox1.Items.Add("遥控定频");
                                }
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedIndex = 0;
                                }

                                //3#状态
                                Temp = (dataTemp[36 * 2 + 3 + 80 * 2] << 8) + dataTemp[36 * 2 + 3 + 1 + 80 * 2];
                                label95.Text = "3#:" + string.Format("{0:X0}H", Temp);
                                comboBox6.Items.Clear();
                                comboBox6.Text = "";
                                if ((Temp & 0x0e00) != 0)
                                {
                                    if ((Temp & 0x0200) != 0)
                                    {
                                        comboBox6.Items.Add("变频");
                                    }
                                    if ((Temp & 0x0400) != 0)
                                    {
                                        comboBox6.Items.Add("工频");
                                    }
                                    if ((Temp & 0x0800) != 0)
                                    {
                                        comboBox6.Items.Add("故障");
                                    }
                                }
                                else
                                {
                                    comboBox6.Items.Add("停止");
                                }
                                if (comboBox6.Items.Count > 0)
                                {
                                    comboBox6.SelectedIndex = 0;
                                }

                                update_count[2] += 1;
                                textBox160.Text = update_count[2].ToString();
                                textBox156.Text = DateTime.Now.ToString();

                                #endregion

                            }
                            else if (dataTemp[2] == 160) //Query_Par_No == 2 &&
                            {
                                //Query_Par_No = 1;

                                #region 4#高频双驱泵
                                //4#高频双驱泵
                                lbl_No4.BackColor = Color.FromArgb(255, 192, 128);
                                //合相有功功率
                                Temp_f = ((dataTemp[1 * 2 + 3] << 24) + (dataTemp[1 * 2 + 3 + 1] << 16) + (dataTemp[0 * 2 + 3] << 8) + dataTemp[0 * 2 + 3 + 1]) / 10.0;
                                textBox65.Text = string.Format("{0:F1}", Temp_f);
                                //目标频率
                                Temp_f = ((dataTemp[2 * 2 + 3] << 8) + dataTemp[2 * 2 + 3 + 1]) / 10.0;
                                textBox67.Text = string.Format("{0:F1}", Temp_f);
                                //输出电压
                                Temp_f = ((dataTemp[3 * 2 + 3] << 8) + dataTemp[3 * 2 + 3 + 1]);
                                textBox68.Text = string.Format("{0:F0}", Temp_f);
                                //合相有功电能
                                Temp_f = ((dataTemp[5 * 2 + 3] << 24) + (dataTemp[5 * 2 + 3 + 1] << 16) + (dataTemp[4 * 2 + 3] << 8) + dataTemp[4 * 2 + 3 + 1]) / 10.0;
                                textBox66.Text = string.Format("{0:F1}", Temp_f);
                                //变频器故障代码
                                Temp_f = ((dataTemp[6 * 2 + 3] << 8) + dataTemp[6 * 2 + 3 + 1]);
                                textBox119.Text = string.Format("{0:F0}", Temp_f);
                                //软件版本
                                Temp_f = ((dataTemp[7 * 2 + 3] << 8) + dataTemp[7 * 2 + 3 + 1]) / 100.0;
                                textBox114.Text = string.Format("{0:F2}", Temp_f);
                                //效率
                                Temp_f = ((dataTemp[8 * 2 + 3] << 8) + dataTemp[8 * 2 + 3 + 1]) / 100.0;
                                textBox69.Text = string.Format("{0:F2}", Temp_f);
                                //停机数量
                                Temp_f = ((dataTemp[9 * 2 + 3] << 8) + dataTemp[9 * 2 + 3 + 1]);
                                textBox124.Text = string.Format("{0:F0}", Temp_f);
                                //瞬时流量
                                Temp_f = ((dataTemp[11 * 2 + 3] << 24) + (dataTemp[11 * 2 + 3 + 1] << 16) + (dataTemp[10 * 2 + 3] << 8) + dataTemp[10 * 2 + 3 + 1]) / 100.0;
                                textBox70.Text = string.Format("{0:F2}", Temp_f);
                                //累计流量
                                Temp_f = ((dataTemp[13 * 2 + 3] << 24) + (dataTemp[13 * 2 + 3 + 1] << 16) + (dataTemp[12 * 2 + 3] << 8) + dataTemp[12 * 2 + 3 + 1]) / 10.0;
                                textBox71.Text = string.Format("{0:F1}", Temp_f);
                                //电压
                                Temp_f = ((dataTemp[14 * 2 + 3] << 8) + dataTemp[14 * 2 + 3 + 1]) / 10.0;
                                textBox72.Text = string.Format("{0:F1}", Temp_f);
                                //启停
                                Temp_f = ((dataTemp[15 * 2 + 3] << 8) + dataTemp[15 * 2 + 3 + 1]);
                                textBox74.Text = string.Format("{0:F0}", Temp_f);
                                //转速
                                Temp_f = ((dataTemp[16 * 2 + 3] << 8) + dataTemp[16 * 2 + 3 + 1]);
                                textBox73.Text = string.Format("{0:F0}", Temp_f);
                                //功率因数
                                Temp_f = ((dataTemp[17 * 2 + 3] << 8) + dataTemp[17 * 2 + 3 + 1]) / 100.0;
                                textBox129.Text = string.Format("{0:F2}", Temp_f);
                                //变频器计数
                                Temp_f = ((dataTemp[18 * 2 + 3] << 8) + dataTemp[18 * 2 + 3 + 1]);
                                textBox76.Text = string.Format("{0:F0}", Temp_f);
                                //220计数
                                Temp_f = ((dataTemp[19 * 2 + 3] << 8) + dataTemp[19 * 2 + 3 + 1]);
                                textBox79.Text = string.Format("{0:F0}", Temp_f);
                                //电流
                                Temp_f = ((dataTemp[20 * 2 + 3] << 8) + dataTemp[20 * 2 + 3 + 1]) / 100.0;
                                textBox88.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位1
                                Temp_f = ((dataTemp[21 * 2 + 3] << 8) + dataTemp[21 * 2 + 3 + 1]) / 100.0;
                                textBox154.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位2
                                Temp_f = ((dataTemp[22 * 2 + 3] << 8) + dataTemp[22 * 2 + 3 + 1]) / 100.0;
                                textBox152.Text = string.Format("{0:F2}", Temp_f);

                                //累计运行时间——秒
                                Temp_f = ((dataTemp[23 * 2 + 3] << 8) + dataTemp[23 * 2 + 3 + 1]);
                                textBox78.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——分钟
                                Temp_f = ((dataTemp[24 * 2 + 3] << 8) + dataTemp[24 * 2 + 3 + 1]);
                                textBox77.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——小时
                                Temp_f = ((dataTemp[26 * 2 + 3] << 24) + (dataTemp[26 * 2 + 3 + 1] << 16) + (dataTemp[25 * 2 + 3] << 8) + dataTemp[25 * 2 + 3 + 1]);
                                textBox75.Text = string.Format("{0:F0}", Temp_f);
                                //频率
                                Temp_f = ((dataTemp[27 * 2 + 3] << 8) + dataTemp[27 * 2 + 3 + 1]) / 10.0;
                                textBox80.Text = string.Format("{0:F1}", Temp_f);
                                //进水压力
                                Temp_f = ((dataTemp[28 * 2 + 3] << 8) + dataTemp[28 * 2 + 3 + 1]) / 1000.0;
                                textBox83.Text = string.Format("{0:F3}", Temp_f);
                                //出水压力
                                Temp_f = ((dataTemp[29 * 2 + 3] << 8) + dataTemp[29 * 2 + 3 + 1]) / 1000.0;
                                textBox85.Text = string.Format("{0:F3}", Temp_f);
                                //1#温度
                                Temp_f = ((dataTemp[30 * 2 + 3] << 8) + dataTemp[30 * 2 + 3 + 1]) / 10.0;
                                textBox86.Text = string.Format("{0:F1}", Temp_f);
                                //2#温度
                                Temp_f = ((dataTemp[31 * 2 + 3] << 8) + dataTemp[31 * 2 + 3 + 1]) / 10.0;
                                textBox87.Text = string.Format("{0:F1}", Temp_f);
                                //设定压力
                                Temp_f = ((dataTemp[32 * 2 + 3] << 8) + dataTemp[32 * 2 + 3 + 1]) / 1000.0;
                                textBox84.Text = string.Format("{0:F3}", Temp_f);

                                //手动定频
                                Temp_f = ((dataTemp[37 * 2 + 3] << 8) + dataTemp[37 * 2 + 3 + 1]) / 10.0;
                                textBox142.Text = string.Format("{0:F1}", Temp_f);

                                //预留2
                                Temp_f = ((dataTemp[38 * 2 + 3] << 8) + dataTemp[38 * 2 + 3 + 1]);
                                textBox144.Text = string.Format("{0:F0}", Temp_f);

                                //预留3
                                Temp_f = ((dataTemp[39 * 2 + 3] << 8) + dataTemp[39 * 2 + 3 + 1]);
                                textBox146.Text = string.Format("{0:F0}", Temp_f);

                                //停机状态
                                Temp = (dataTemp[33 * 2 + 3] << 8) + dataTemp[33 * 2 + 3 + 1];
                                label149.Text = "4#:" + string.Format("{0:X0}H", Temp);
                                comboBox7.Items.Clear();
                                comboBox7.Text = "";
                                if ((Temp & 0x0002) != 0)
                                {
                                    comboBox7.Items.Add("主令开关停止");
                                }
                                if ((Temp & 0x0004) != 0)
                                {
                                    comboBox7.Items.Add("变频器报警");
                                }
                                if ((Temp & 0x0010) != 0)
                                {
                                    comboBox7.Items.Add("无水停机");
                                }
                                if ((Temp & 0x0400) != 0)
                                {
                                    comboBox7.Items.Add("软件超压保护");
                                }
                                if ((Temp & 0x4000) != 0)
                                {
                                    comboBox7.Items.Add("进水压高节能停机");
                                }
                                Temp = (dataTemp[34 * 2 + 3] << 8) + dataTemp[34 * 2 + 3 + 1];
                                label149.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0001) != 0)
                                {
                                    comboBox7.Items.Add("进水压高保护停机");
                                }
                                if ((Temp & 0x0100) != 0)
                                {
                                    comboBox7.Items.Add("远程遥控停机");
                                }
                                if (comboBox7.Items.Count > 0)
                                {
                                    comboBox7.SelectedIndex = 0;
                                }

                                Temp = (dataTemp[35 * 2 + 3] << 8) + dataTemp[35 * 2 + 3 + 1];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0200) != 0)
                                {
                                    comboBox1.Items.Add("遥控定频");
                                }
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedIndex = 0;
                                }

                                //设备状态
                                Temp = (dataTemp[36 * 2 + 3] << 8) + dataTemp[36 * 2 + 3 + 1];
                                label150.Text = "4#:" + string.Format("{0:X0}H", Temp);
                                comboBox9.Items.Clear();
                                comboBox9.Text = "";
                                if ((Temp & 0x0e00) != 0)
                                {
                                    if ((Temp & 0x0200) != 0)
                                    {
                                        comboBox9.Items.Add("变频");
                                    }
                                    if ((Temp & 0x0400) != 0)
                                    {
                                        comboBox9.Items.Add("工频");
                                    }
                                    if ((Temp & 0x0800) != 0)
                                    {
                                        comboBox9.Items.Add("故障");
                                    }
                                }
                                else
                                {
                                    comboBox9.Items.Add("停止");
                                }
                                if (comboBox9.Items.Count > 0)
                                {
                                    comboBox9.SelectedIndex = 0;
                                }

                                update_count[3] += 1;
                                textBox164.Text = update_count[3].ToString();
                                textBox159.Text = DateTime.Now.ToString();

                                #endregion 

                                #region 5#高频双驱泵
                                //5#高频双驱泵
                                lbl_No5.BackColor = Color.FromArgb(255, 192, 128);
                                //合相有功功率
                                Temp_f = ((dataTemp[1 * 2 + 3 + 40 * 2] << 24) + (dataTemp[1 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[0 * 2 + 3 + 40 * 2] << 8) + dataTemp[0 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox89.Text = string.Format("{0:F1}", Temp_f);
                                //目标频率
                                Temp_f = ((dataTemp[2 * 2 + 3 + 40 * 2] << 8) + dataTemp[2 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox91.Text = string.Format("{0:F1}", Temp_f);
                                //输出电压
                                Temp_f = ((dataTemp[3 * 2 + 3 + 40 * 2] << 8) + dataTemp[3 * 2 + 3 + 1 + 40 * 2]);
                                textBox92.Text = string.Format("{0:F0}", Temp_f);
                                //合相有功电能
                                Temp_f = ((dataTemp[5 * 2 + 3 + 40 * 2] << 24) + (dataTemp[5 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[4 * 2 + 3 + 40 * 2] << 8) + dataTemp[4 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox90.Text = string.Format("{0:F1}", Temp_f);
                                //变频器故障代码
                                Temp_f = ((dataTemp[6 * 2 + 3 + 40 * 2] << 8) + dataTemp[6 * 2 + 3 + 1 + 40 * 2]);
                                textBox120.Text = string.Format("{0:F0}", Temp_f);
                                //软件版本
                                Temp_f = ((dataTemp[7 * 2 + 3 + 40 * 2] << 8) + dataTemp[7 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox115.Text = string.Format("{0:F2}", Temp_f);
                                //效率
                                Temp_f = ((dataTemp[8 * 2 + 3 + 40 * 2] << 8) + dataTemp[8 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox93.Text = string.Format("{0:F2}", Temp_f);
                                //停机数量
                                Temp_f = ((dataTemp[9 * 2 + 3 + 40 * 2] << 8) + dataTemp[9 * 2 + 3 + 1 + 40 * 2]);
                                textBox125.Text = string.Format("{0:F0}", Temp_f);
                                //瞬时流量
                                Temp_f = ((dataTemp[11 * 2 + 3 + 40 * 2] << 24) + (dataTemp[11 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[10 * 2 + 3 + 40 * 2] << 8) + dataTemp[10 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox94.Text = string.Format("{0:F2}", Temp_f);
                                //累计流量
                                Temp_f = ((dataTemp[13 * 2 + 3 + 40 * 2] << 24) + (dataTemp[13 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[12 * 2 + 3 + 40 * 2] << 8) + dataTemp[12 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox95.Text = string.Format("{0:F1}", Temp_f);
                                //电压
                                Temp_f = ((dataTemp[14 * 2 + 3 + 40 * 2] << 8) + dataTemp[14 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox96.Text = string.Format("{0:F1}", Temp_f);
                                //启停
                                Temp_f = ((dataTemp[15 * 2 + 3 + 40 * 2] << 8) + dataTemp[15 * 2 + 3 + 1 + 40 * 2]);
                                textBox98.Text = string.Format("{0:F0}", Temp_f);
                                //转速
                                Temp_f = ((dataTemp[16 * 2 + 3 + 40 * 2] << 8) + dataTemp[16 * 2 + 3 + 1 + 40 * 2]);
                                textBox97.Text = string.Format("{0:F0}", Temp_f);
                                //功率因数
                                Temp_f = ((dataTemp[17 * 2 + 3 + 40 * 2] << 8) + dataTemp[17 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox130.Text = string.Format("{0:F2}", Temp_f);
                                //变频器计数
                                Temp_f = ((dataTemp[18 * 2 + 3 + 40 * 2] << 8) + dataTemp[18 * 2 + 3 + 1 + 40 * 2]);
                                textBox100.Text = string.Format("{0:F0}", Temp_f);
                                //220计数
                                Temp_f = ((dataTemp[19 * 2 + 3 + 40 * 2] << 8) + dataTemp[19 * 2 + 3 + 1 + 40 * 2]);
                                textBox103.Text = string.Format("{0:F0}", Temp_f);
                                //电流
                                Temp_f = ((dataTemp[20 * 2 + 3 + 40 * 2] << 8) + dataTemp[20 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox110.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位1
                                Temp_f = ((dataTemp[21 * 2 + 3 + 40 * 2] << 8) + dataTemp[21 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox135.Text = string.Format("{0:F2}", Temp_f);
                                //进水液位2
                                Temp_f = ((dataTemp[22 * 2 + 3 + 40 * 2] << 8) + dataTemp[22 * 2 + 3 + 1 + 40 * 2]) / 100.0;
                                textBox151.Text = string.Format("{0:F2}", Temp_f);

                                //累计运行时间——秒
                                Temp_f = ((dataTemp[23 * 2 + 3 + 40 * 2] << 8) + dataTemp[23 * 2 + 3 + 1 + 40 * 2]);
                                textBox102.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——分钟
                                Temp_f = ((dataTemp[24 * 2 + 3 + 40 * 2] << 8) + dataTemp[24 * 2 + 3 + 1 + 40 * 2]);
                                textBox101.Text = string.Format("{0:F0}", Temp_f);
                                //累计运行时间——小时
                                Temp_f = ((dataTemp[26 * 2 + 3 + 40 * 2] << 24) + (dataTemp[26 * 2 + 3 + 1 + 40 * 2] << 16) + (dataTemp[25 * 2 + 3 + 40 * 2] << 8) + dataTemp[25 * 2 + 3 + 1 + 40 * 2]);
                                textBox99.Text = string.Format("{0:F0}", Temp_f);
                                //频率
                                Temp_f = ((dataTemp[27 * 2 + 3 + 40 * 2] << 8) + dataTemp[27 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox104.Text = string.Format("{0:F1}", Temp_f);
                                //进水压力
                                Temp_f = ((dataTemp[28 * 2 + 3 + 40 * 2] << 8) + dataTemp[28 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox105.Text = string.Format("{0:F3}", Temp_f);
                                //出水压力
                                Temp_f = ((dataTemp[29 * 2 + 3 + 40 * 2] << 8) + dataTemp[29 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox107.Text = string.Format("{0:F3}", Temp_f);
                                //1#温度
                                Temp_f = ((dataTemp[30 * 2 + 3 + 40 * 2] << 8) + dataTemp[30 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox108.Text = string.Format("{0:F1}", Temp_f);
                                //2#温度
                                Temp_f = ((dataTemp[31 * 2 + 3 + 40 * 2] << 8) + dataTemp[31 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox109.Text = string.Format("{0:F1}", Temp_f);
                                //设定压力
                                Temp_f = ((dataTemp[32 * 2 + 3 + 40 * 2] << 8) + dataTemp[32 * 2 + 3 + 1 + 40 * 2]) / 1000.0;
                                textBox106.Text = string.Format("{0:F3}", Temp_f);

                                //手动定频
                                Temp_f = ((dataTemp[37 * 2 + 3 + 40 * 2] << 8) + dataTemp[37 * 2 + 3 + 1 + 40 * 2]) / 10.0;
                                textBox148.Text = string.Format("{0:F1}", Temp_f);

                                //预留2
                                Temp_f = ((dataTemp[38 * 2 + 3 + 40 * 2] << 8) + dataTemp[38 * 2 + 3 + 1 + 40 * 2]);
                                textBox149.Text = string.Format("{0:F0}", Temp_f);

                                //预留3
                                Temp_f = ((dataTemp[39 * 2 + 3 + 40 * 2] << 8) + dataTemp[39 * 2 + 3 + 1 + 40 * 2]);
                                textBox150.Text = string.Format("{0:F0}", Temp_f);

                                //5#停机状态
                                Temp = (dataTemp[33 * 2 + 3 + 40 * 2] << 8) + dataTemp[33 * 2 + 3 + 1 + 40 * 2];
                                label199.Text = "5#:" + string.Format("{0:X0}H", Temp);
                                comboBox10.Items.Clear();
                                comboBox10.Text = "";
                                if ((Temp & 0x0002) != 0)
                                {
                                    comboBox10.Items.Add("主令开关停止");
                                }
                                if ((Temp & 0x0004) != 0)
                                {
                                    comboBox10.Items.Add("变频器报警");
                                }
                                if ((Temp & 0x0010) != 0)
                                {
                                    comboBox10.Items.Add("无水停机");
                                }
                                if ((Temp & 0x0400) != 0)
                                {
                                    comboBox10.Items.Add("软件超压保护");
                                }
                                if ((Temp & 0x4000) != 0)
                                {
                                    comboBox10.Items.Add("进水压高节能停机");
                                }

                                Temp = (dataTemp[34 * 2 + 3 + 40 * 2] << 8) + dataTemp[34 * 2 + 3 + 1 + 40 * 2];
                                label199.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0001) != 0)
                                {
                                    comboBox10.Items.Add("进水压高保护停机");
                                }
                                if ((Temp & 0x0100) != 0)
                                {
                                    comboBox10.Items.Add("远程遥控停机");
                                }

                                Temp = (dataTemp[35 * 2 + 3 + 40 * 2] << 8) + dataTemp[35 * 2 + 3 + 1 + 40 * 2];
                                label41.Text += string.Format(" {0:X0}H", Temp);
                                if ((Temp & 0x0200) != 0)
                                {
                                    comboBox1.Items.Add("遥控定频");
                                }
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedIndex = 0;
                                }

                                //5#状态
                                Temp = (dataTemp[36 * 2 + 3 + 40 * 2] << 8) + dataTemp[36 * 2 + 3 + 1 + 40 * 2];
                                label200.Text = "5#:" + string.Format("{0:X0}H", Temp);
                                comboBox11.Items.Clear();
                                comboBox11.Text = "";

                                if ((Temp & 0x0e00) != 0)
                                {
                                    if ((Temp & 0x0200) != 0)
                                    {
                                        comboBox11.Items.Add("变频");
                                    }
                                    if ((Temp & 0x0400) != 0)
                                    {
                                        comboBox11.Items.Add("工频");
                                    }
                                    if ((Temp & 0x0800) != 0)
                                    {
                                        comboBox11.Items.Add("故障");
                                    }
                                }
                                else
                                {
                                    comboBox11.Items.Add("停止");
                                }
                                if (comboBox11.Items.Count > 0)
                                {
                                    comboBox11.SelectedIndex = 0;
                                }

                                update_count[4] += 1;
                                textBox162.Text = update_count[4].ToString();
                                textBox157.Text = DateTime.Now.ToString();

                                #endregion
                            }
                            #endregion
                        }
                    }
                }
            }
        }

        #region DataGridView表格颜色设置
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Clear previous selection coloring
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.LightBlue : Color.LightGreen;
            }

            // Set selected row color to yellow
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.DarkSeaGreen;
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Clear previous selection coloring
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.LightBlue : Color.LightGreen;
            }

            // Set selected row color to yellow
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.ForestGreen;
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            // Clear previous selection coloring
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.LightBlue : Color.LightGreen;
            }

            // Set selected row color to yellow
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView4_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.YellowGreen;
            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            // Clear previous selection coloring
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.LightBlue : Color.LightGreen;
            }

            // Set selected row color to yellow
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set alternating row colors
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.SpringGreen;
            }
        }

        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            // Clear previous selection coloring
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = row.Index % 2 == 0 ? Color.LightBlue : Color.LightGreen;
            }

            // Set selected row color to yellow
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
        #endregion


        private SQLiteConnection GetConnection()
        {
            //string connectionString = "Data Source=data.db;Version=3;Pooling=true;FailIfMissing=false;";
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
        private void SaveDataToDatabase(DataGridView dgv, int pump_no)
        {
            string par_value;
            par_value = $"参数值{pump_no + 1}";
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string parameterAddress = row.Cells[0].Value.ToString();//参数地址
                        string parameterValue1 = row.Cells[1].Value.ToString(); //参数值
                        string updateQuery = $"UPDATE Par SET {par_value} = '{parameterValue1}' WHERE 参数地址 = '{parameterAddress}'"; // 替换为你的表名
                        SQLiteCommand command = new SQLiteCommand(updateQuery, GetConnection());
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("数据保存成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据保存错误: " + ex.Message);
            }
        }

        //只保存选择行的数据到数据库中
        private void SaveDataToDatabase_1Row(DataGridView dgv, int pump_no, int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    if (!row.IsNewRow)
                    {
                        string parameterAddress = row.Cells[0].Value.ToString();
                        string parameterValue1 = row.Cells[1].Value.ToString();
                        string updateQuery = $"UPDATE Par SET 参数值1 = '{parameterValue1}' WHERE 参数地址 = '{parameterAddress}'"; // 替换为你的表名
                        SQLiteCommand command = new SQLiteCommand(updateQuery, GetConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data saved successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void btn_Save_par_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase(dataGridView1, 0);
            SaveDataToDatabase(dataGridView2, 0);
            SaveDataToDatabase(dataGridView3, 0);
            SaveDataToDatabase(dataGridView4, 0);
            SaveDataToDatabase(dataGridView5, 0);
            //SaveDataToDatabase_1Row(dataGridView1, 0, 0);
        }

        //清除参数值这一列的数值
        private void Clear_Par_Value(int pump_no)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string columnName = $"参数值{pump_no + 1}"; // 替换为你要更新的列名

                    string query = $"UPDATE Par SET {columnName} = NULL";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} 行更新成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("一个错误发生: " + ex.Message);
            }
        }

        //清除全部的参数值
        private void Clear_Par_Value_All()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string columnName = $"参数值{pump_no + 1}"; // 替换为你要更新的列名

                    string query = $"UPDATE Par SET 参数值1= NULL,参数值2= NULL,参数值3= NULL,参数值4= NULL,参数值5= NULL";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} 行更新成功！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("一个错误发生: " + ex.Message);
            }
        }

        //清除参数
        private void btn_clear_par_value_Click(object sender, EventArgs e)
        {
            Clear_Par_Value(tabControl2.SelectedIndex);
        }

        private void listView_terminal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //// 获取当前选中的项
            //ListViewItem selectedItem = e.Item;

            //if (selectedItem != null && selectedItem.Selected)
            //{
            //    // 检查该项是否被选中（复选框是否被勾选）
            //    if (selectedItem.Checked)
            //    {
            //        MessageBox.Show("The item is checked.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("The item is not checked.");
            //    }
            //}
        }

        private void DataGridView1_ItemChecked(object sender, DataGridViewCellEventArgs e)
        {
            // 确保只允许一个复选框被选中
            if (e.ColumnIndex == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i != e.RowIndex)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }


    }
}











