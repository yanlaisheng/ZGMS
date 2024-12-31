using System.Windows.Forms;
using System;

namespace WNMS2
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnToggle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richtxbox_tmp = new System.Windows.Forms.RichTextBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.comboBox_receive_Mode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_Append_Time = new System.Windows.Forms.CheckBox();
            this.btn_Analy_Data = new System.Windows.Forms.Button();
            this.btn_Clear_ReceiveZone = new System.Windows.Forms.Button();
            this.checkBox_SaveData2File = new System.Windows.Forms.CheckBox();
            this.checkBox_Show_Only_Select = new System.Windows.Forms.CheckBox();
            this.checkBox_NoScrollScreen = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_Send_Only_Select = new System.Windows.Forms.CheckBox();
            this.chkBox_Append_CRC = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_reply = new System.Windows.Forms.CheckBox();
            this.chkBox_TimeSend = new System.Windows.Forms.CheckBox();
            this.chkBox_Send_16 = new System.Windows.Forms.CheckBox();
            this.textBox_Send_interval_Time = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_clr_sendZone = new System.Windows.Forms.Button();
            this.tbSend_zone = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_autoStartService = new System.Windows.Forms.CheckBox();
            this.comboBox_WorkMode = new System.Windows.Forms.ComboBox();
            this.btn_StartStopService = new System.Windows.Forms.Button();
            this.tb_ServicePort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listView_terminal = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_receive = new System.Windows.Forms.TabPage();
            this.tb_receive_zone = new System.Windows.Forms.RichTextBox();
            this.tabPage_Status = new System.Windows.Forms.TabPage();
            this.splitContainer_status = new System.Windows.Forms.SplitContainer();
            this.panel_device_status = new System.Windows.Forms.Panel();
            this.btnToggle_Right_status = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label277 = new System.Windows.Forms.Label();
            this.label271 = new System.Windows.Forms.Label();
            this.label272 = new System.Windows.Forms.Label();
            this.label265 = new System.Windows.Forms.Label();
            this.label268 = new System.Windows.Forms.Label();
            this.label283 = new System.Windows.Forms.Label();
            this.label284 = new System.Windows.Forms.Label();
            this.label285 = new System.Windows.Forms.Label();
            this.label286 = new System.Windows.Forms.Label();
            this.label287 = new System.Windows.Forms.Label();
            this.label288 = new System.Windows.Forms.Label();
            this.label289 = new System.Windows.Forms.Label();
            this.label290 = new System.Windows.Forms.Label();
            this.label291 = new System.Windows.Forms.Label();
            this.label292 = new System.Windows.Forms.Label();
            this.textBox156 = new System.Windows.Forms.TextBox();
            this.textBox157 = new System.Windows.Forms.TextBox();
            this.textBox158 = new System.Windows.Forms.TextBox();
            this.textBox159 = new System.Windows.Forms.TextBox();
            this.textBox160 = new System.Windows.Forms.TextBox();
            this.textBox161 = new System.Windows.Forms.TextBox();
            this.textBox162 = new System.Windows.Forms.TextBox();
            this.textBox163 = new System.Windows.Forms.TextBox();
            this.textBox164 = new System.Windows.Forms.TextBox();
            this.textBox165 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label280 = new System.Windows.Forms.Label();
            this.textBox151 = new System.Windows.Forms.TextBox();
            this.label281 = new System.Windows.Forms.Label();
            this.textBox152 = new System.Windows.Forms.TextBox();
            this.label282 = new System.Windows.Forms.Label();
            this.textBox153 = new System.Windows.Forms.TextBox();
            this.textBox154 = new System.Windows.Forms.TextBox();
            this.textBox155 = new System.Windows.Forms.TextBox();
            this.lbl_No4 = new System.Windows.Forms.Label();
            this.lbl_No5 = new System.Windows.Forms.Label();
            this.label224 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label223 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.label222 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label221 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label249 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label244 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.label208 = new System.Windows.Forms.Label();
            this.label253 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label250 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label205 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.label262 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label276 = new System.Windows.Forms.Label();
            this.label270 = new System.Windows.Forms.Label();
            this.label279 = new System.Windows.Forms.Label();
            this.label275 = new System.Windows.Forms.Label();
            this.label267 = new System.Windows.Forms.Label();
            this.label274 = new System.Windows.Forms.Label();
            this.label269 = new System.Windows.Forms.Label();
            this.label278 = new System.Windows.Forms.Label();
            this.label273 = new System.Windows.Forms.Label();
            this.label266 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox147 = new System.Windows.Forms.TextBox();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.textBox150 = new System.Windows.Forms.TextBox();
            this.textBox141 = new System.Windows.Forms.TextBox();
            this.textBox146 = new System.Windows.Forms.TextBox();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox145 = new System.Windows.Forms.TextBox();
            this.textBox138 = new System.Windows.Forms.TextBox();
            this.textBox149 = new System.Windows.Forms.TextBox();
            this.textBox140 = new System.Windows.Forms.TextBox();
            this.textBox144 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox143 = new System.Windows.Forms.TextBox();
            this.textBox137 = new System.Windows.Forms.TextBox();
            this.textBox148 = new System.Windows.Forms.TextBox();
            this.textBox139 = new System.Windows.Forms.TextBox();
            this.textBox142 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox136 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label193 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label192 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label191 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox105 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label190 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label248 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.label243 = new System.Windows.Forms.Label();
            this.label241 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label189 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox130 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox129 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox127 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox126 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label187 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label186 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label245 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label185 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.textBox125 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox119 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox117 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label236 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label233 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label225 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label182 = new System.Windows.Forms.Label();
            this.label255 = new System.Windows.Forms.Label();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label257 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label259 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label263 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.label293 = new System.Windows.Forms.Label();
            this.textBox135 = new System.Windows.Forms.TextBox();
            this.label294 = new System.Windows.Forms.Label();
            this.textBox134 = new System.Windows.Forms.TextBox();
            this.label295 = new System.Windows.Forms.Label();
            this.textBox132 = new System.Windows.Forms.TextBox();
            this.textBox133 = new System.Windows.Forms.TextBox();
            this.label296 = new System.Windows.Forms.Label();
            this.textBox131 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_No3 = new System.Windows.Forms.Label();
            this.lbl_No2 = new System.Windows.Forms.Label();
            this.lbl_No1 = new System.Windows.Forms.Label();
            this.btn_QueryStatus_4_5 = new System.Windows.Forms.Button();
            this.btn_QueryStatus_1_3 = new System.Windows.Forms.Button();
            this.tabPage_Par = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnToggle_Right = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_No1_Par = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_No2_Par = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage_No3_Par = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage_No4_Par = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage_No5_Par = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel_indicate_select = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_QueryPar = new System.Windows.Forms.Button();
            this.btn_clear_par_value = new System.Windows.Forms.Button();
            this.btn_Save_par = new System.Windows.Forms.Button();
            this.numericUpDown_ParValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_parName = new System.Windows.Forms.Label();
            this.lbl_par_address = new System.Windows.Forms.Label();
            this.label_parValue = new System.Windows.Forms.Label();
            this.btn_ModifyPar = new System.Windows.Forms.Button();
            this.groupBox_Select_Device = new System.Windows.Forms.GroupBox();
            this.label_PUMP_NO = new System.Windows.Forms.Label();
            this.label299 = new System.Windows.Forms.Label();
            this.label_USER_NO = new System.Windows.Forms.Label();
            this.label298 = new System.Windows.Forms.Label();
            this.label_DTU_NO = new System.Windows.Forms.Label();
            this.label297 = new System.Windows.Forms.Label();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.state_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendcount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.recivecount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.cleancount_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_select_DTU_NO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_select_USERNAME = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_select_pump_no = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_AutoSend = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_clearMemory = new System.Windows.Forms.Timer(this.components);
            this.timer_timeout = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_receive.SuspendLayout();
            this.tabPage_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_status)).BeginInit();
            this.splitContainer_status.Panel1.SuspendLayout();
            this.splitContainer_status.Panel2.SuspendLayout();
            this.splitContainer_status.SuspendLayout();
            this.panel_device_status.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_No1_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage_No2_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage_No3_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage_No4_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage_No5_Par.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panel_indicate_select.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ParValue)).BeginInit();
            this.groupBox_Select_Device.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出_toolStripMenuItem1,
            this.删除ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 退出_toolStripMenuItem1
            // 
            this.退出_toolStripMenuItem1.Name = "退出_toolStripMenuItem1";
            this.退出_toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.退出_toolStripMenuItem1.Text = "退出";
            this.退出_toolStripMenuItem1.Click += new System.EventHandler(this.退出_toolStripMenuItem1_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.panel3.ContextMenuStrip = this.contextMenuStrip1;
            this.panel3.Controls.Add(this.lbl_time);
            this.panel3.Controls.Add(this.lbl_Title);
            this.panel3.Controls.Add(this.splitter4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1566, 107);
            this.panel3.TabIndex = 22;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(1354, 37);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(214, 28);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "2023-09-24 16:50:00";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(625, 22);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(392, 46);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "ZGMS 远 程 监 控 系 统";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter4
            // 
            this.splitter4.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(0, 98);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1566, 3);
            this.splitter4.TabIndex = 2;
            this.splitter4.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(0, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1566, 6);
            this.label4.TabIndex = 1;
            this.label4.Text = "                        ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 65);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 687);
            this.panel1.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.splitter6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1563, 662);
            this.panel6.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1560, 662);
            this.panel4.TabIndex = 33;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Main);
            this.splitContainer1.Size = new System.Drawing.Size(1560, 662);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 40;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnToggle);
            this.panelLeft.Controls.Add(this.groupBox4);
            this.panelLeft.Controls.Add(this.groupBox5);
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(239, 662);
            this.panelLeft.TabIndex = 43;
            // 
            // btnToggle
            // 
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggle.Location = new System.Drawing.Point(227, 0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(12, 662);
            this.btnToggle.TabIndex = 64;
            this.btnToggle.Text = "<";
            this.btnToggle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richtxbox_tmp);
            this.groupBox4.Controls.Add(this.btn_openFile);
            this.groupBox4.Controls.Add(this.comboBox_receive_Mode);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.checkBox_Append_Time);
            this.groupBox4.Controls.Add(this.btn_Analy_Data);
            this.groupBox4.Controls.Add(this.btn_Clear_ReceiveZone);
            this.groupBox4.Controls.Add(this.checkBox_SaveData2File);
            this.groupBox4.Controls.Add(this.checkBox_Show_Only_Select);
            this.groupBox4.Controls.Add(this.checkBox_NoScrollScreen);
            this.groupBox4.Location = new System.Drawing.Point(2, 410);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(233, 216);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区设置";
            // 
            // richtxbox_tmp
            // 
            this.richtxbox_tmp.ForeColor = System.Drawing.Color.Black;
            this.richtxbox_tmp.Location = new System.Drawing.Point(139, 123);
            this.richtxbox_tmp.Name = "richtxbox_tmp";
            this.richtxbox_tmp.Size = new System.Drawing.Size(85, 16);
            this.richtxbox_tmp.TabIndex = 74;
            this.richtxbox_tmp.Text = "";
            this.richtxbox_tmp.Visible = false;
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(136, 84);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(88, 32);
            this.btn_openFile.TabIndex = 72;
            this.btn_openFile.Text = "打开文件";
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // comboBox_receive_Mode
            // 
            this.comboBox_receive_Mode.FormattingEnabled = true;
            this.comboBox_receive_Mode.Items.AddRange(new object[] {
            "十六进制",
            "文本模式",
            "十六进制和文本模式"});
            this.comboBox_receive_Mode.Location = new System.Drawing.Point(83, 24);
            this.comboBox_receive_Mode.Name = "comboBox_receive_Mode";
            this.comboBox_receive_Mode.Size = new System.Drawing.Size(131, 20);
            this.comboBox_receive_Mode.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "接收区显示：";
            // 
            // checkBox_Append_Time
            // 
            this.checkBox_Append_Time.AutoSize = true;
            this.checkBox_Append_Time.Checked = true;
            this.checkBox_Append_Time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Append_Time.Location = new System.Drawing.Point(9, 63);
            this.checkBox_Append_Time.Name = "checkBox_Append_Time";
            this.checkBox_Append_Time.Size = new System.Drawing.Size(132, 16);
            this.checkBox_Append_Time.TabIndex = 68;
            this.checkBox_Append_Time.Text = "加时间戳和分包显示";
            this.checkBox_Append_Time.UseVisualStyleBackColor = true;
            // 
            // btn_Analy_Data
            // 
            this.btn_Analy_Data.Location = new System.Drawing.Point(9, 177);
            this.btn_Analy_Data.Name = "btn_Analy_Data";
            this.btn_Analy_Data.Size = new System.Drawing.Size(88, 32);
            this.btn_Analy_Data.TabIndex = 67;
            this.btn_Analy_Data.Text = "解析数据";
            // 
            // btn_Clear_ReceiveZone
            // 
            this.btn_Clear_ReceiveZone.Location = new System.Drawing.Point(141, 177);
            this.btn_Clear_ReceiveZone.Name = "btn_Clear_ReceiveZone";
            this.btn_Clear_ReceiveZone.Size = new System.Drawing.Size(88, 32);
            this.btn_Clear_ReceiveZone.TabIndex = 57;
            this.btn_Clear_ReceiveZone.Text = "清除接收区";
            this.btn_Clear_ReceiveZone.Click += new System.EventHandler(this.btn_Clear_ReceiveZone_Click);
            // 
            // checkBox_SaveData2File
            // 
            this.checkBox_SaveData2File.AutoSize = true;
            this.checkBox_SaveData2File.Location = new System.Drawing.Point(9, 93);
            this.checkBox_SaveData2File.Name = "checkBox_SaveData2File";
            this.checkBox_SaveData2File.Size = new System.Drawing.Size(132, 16);
            this.checkBox_SaveData2File.TabIndex = 27;
            this.checkBox_SaveData2File.Text = "保存接收数据到文件";
            this.checkBox_SaveData2File.UseVisualStyleBackColor = true;
            // 
            // checkBox_Show_Only_Select
            // 
            this.checkBox_Show_Only_Select.AutoSize = true;
            this.checkBox_Show_Only_Select.Location = new System.Drawing.Point(9, 154);
            this.checkBox_Show_Only_Select.Name = "checkBox_Show_Only_Select";
            this.checkBox_Show_Only_Select.Size = new System.Drawing.Size(108, 16);
            this.checkBox_Show_Only_Select.TabIndex = 27;
            this.checkBox_Show_Only_Select.Text = "只显示选择通道";
            this.checkBox_Show_Only_Select.UseVisualStyleBackColor = true;
            // 
            // checkBox_NoScrollScreen
            // 
            this.checkBox_NoScrollScreen.AutoSize = true;
            this.checkBox_NoScrollScreen.Location = new System.Drawing.Point(9, 123);
            this.checkBox_NoScrollScreen.Name = "checkBox_NoScrollScreen";
            this.checkBox_NoScrollScreen.Size = new System.Drawing.Size(72, 16);
            this.checkBox_NoScrollScreen.TabIndex = 27;
            this.checkBox_NoScrollScreen.Text = "禁止滚屏";
            this.checkBox_NoScrollScreen.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_Send_Only_Select);
            this.groupBox5.Controls.Add(this.chkBox_Append_CRC);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.checkBox_reply);
            this.groupBox5.Controls.Add(this.chkBox_TimeSend);
            this.groupBox5.Controls.Add(this.chkBox_Send_16);
            this.groupBox5.Controls.Add(this.textBox_Send_interval_Time);
            this.groupBox5.Controls.Add(this.btn_Send);
            this.groupBox5.Controls.Add(this.btn_clr_sendZone);
            this.groupBox5.Controls.Add(this.tbSend_zone);
            this.groupBox5.Location = new System.Drawing.Point(2, 135);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(233, 267);
            this.groupBox5.TabIndex = 62;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区设置";
            // 
            // checkBox_Send_Only_Select
            // 
            this.checkBox_Send_Only_Select.AutoSize = true;
            this.checkBox_Send_Only_Select.Location = new System.Drawing.Point(9, 196);
            this.checkBox_Send_Only_Select.Name = "checkBox_Send_Only_Select";
            this.checkBox_Send_Only_Select.Size = new System.Drawing.Size(108, 16);
            this.checkBox_Send_Only_Select.TabIndex = 66;
            this.checkBox_Send_Only_Select.Text = "只发送选择通道";
            this.checkBox_Send_Only_Select.UseVisualStyleBackColor = true;
            // 
            // chkBox_Append_CRC
            // 
            this.chkBox_Append_CRC.AutoSize = true;
            this.chkBox_Append_CRC.Location = new System.Drawing.Point(9, 140);
            this.chkBox_Append_CRC.Name = "chkBox_Append_CRC";
            this.chkBox_Append_CRC.Size = new System.Drawing.Size(150, 16);
            this.chkBox_Append_CRC.TabIndex = 65;
            this.chkBox_Append_CRC.Text = "末尾加ModbusCRC16校验";
            this.chkBox_Append_CRC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "毫秒发送";
            // 
            // checkBox_reply
            // 
            this.checkBox_reply.AutoSize = true;
            this.checkBox_reply.Location = new System.Drawing.Point(166, 112);
            this.checkBox_reply.Name = "checkBox_reply";
            this.checkBox_reply.Size = new System.Drawing.Size(48, 16);
            this.checkBox_reply.TabIndex = 63;
            this.checkBox_reply.Text = "回应";
            this.checkBox_reply.UseVisualStyleBackColor = true;
            // 
            // chkBox_TimeSend
            // 
            this.chkBox_TimeSend.AutoSize = true;
            this.chkBox_TimeSend.Location = new System.Drawing.Point(9, 168);
            this.chkBox_TimeSend.Name = "chkBox_TimeSend";
            this.chkBox_TimeSend.Size = new System.Drawing.Size(48, 16);
            this.chkBox_TimeSend.TabIndex = 59;
            this.chkBox_TimeSend.Text = "每隔";
            this.chkBox_TimeSend.UseVisualStyleBackColor = true;
            // 
            // chkBox_Send_16
            // 
            this.chkBox_Send_16.AutoSize = true;
            this.chkBox_Send_16.Location = new System.Drawing.Point(9, 112);
            this.chkBox_Send_16.Name = "chkBox_Send_16";
            this.chkBox_Send_16.Size = new System.Drawing.Size(96, 16);
            this.chkBox_Send_16.TabIndex = 58;
            this.chkBox_Send_16.Text = "十六进制发送";
            this.chkBox_Send_16.UseVisualStyleBackColor = true;
            // 
            // textBox_Send_interval_Time
            // 
            this.textBox_Send_interval_Time.Location = new System.Drawing.Point(57, 166);
            this.textBox_Send_interval_Time.Name = "textBox_Send_interval_Time";
            this.textBox_Send_interval_Time.Size = new System.Drawing.Size(55, 21);
            this.textBox_Send_interval_Time.TabIndex = 62;
            this.textBox_Send_interval_Time.Text = "1000";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(9, 222);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(88, 32);
            this.btn_Send.TabIndex = 57;
            this.btn_Send.Text = "发送";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_clr_sendZone
            // 
            this.btn_clr_sendZone.Location = new System.Drawing.Point(141, 222);
            this.btn_clr_sendZone.Name = "btn_clr_sendZone";
            this.btn_clr_sendZone.Size = new System.Drawing.Size(88, 32);
            this.btn_clr_sendZone.TabIndex = 56;
            this.btn_clr_sendZone.Text = "清除发送区";
            this.btn_clr_sendZone.Click += new System.EventHandler(this.btn_clr_sendZone_Click);
            // 
            // tbSend_zone
            // 
            this.tbSend_zone.Location = new System.Drawing.Point(5, 19);
            this.tbSend_zone.Multiline = true;
            this.tbSend_zone.Name = "tbSend_zone";
            this.tbSend_zone.Size = new System.Drawing.Size(224, 80);
            this.tbSend_zone.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_autoStartService);
            this.groupBox2.Controls.Add(this.comboBox_WorkMode);
            this.groupBox2.Controls.Add(this.btn_StartStopService);
            this.groupBox2.Controls.Add(this.tb_ServicePort);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(233, 125);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通信设置";
            // 
            // checkBox_autoStartService
            // 
            this.checkBox_autoStartService.AutoSize = true;
            this.checkBox_autoStartService.Location = new System.Drawing.Point(122, 92);
            this.checkBox_autoStartService.Name = "checkBox_autoStartService";
            this.checkBox_autoStartService.Size = new System.Drawing.Size(96, 16);
            this.checkBox_autoStartService.TabIndex = 64;
            this.checkBox_autoStartService.Text = "自动开始服务";
            this.checkBox_autoStartService.UseVisualStyleBackColor = true;
            // 
            // comboBox_WorkMode
            // 
            this.comboBox_WorkMode.FormattingEnabled = true;
            this.comboBox_WorkMode.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.comboBox_WorkMode.Location = new System.Drawing.Point(77, 20);
            this.comboBox_WorkMode.Name = "comboBox_WorkMode";
            this.comboBox_WorkMode.Size = new System.Drawing.Size(84, 20);
            this.comboBox_WorkMode.TabIndex = 63;
            // 
            // btn_StartStopService
            // 
            this.btn_StartStopService.Location = new System.Drawing.Point(10, 83);
            this.btn_StartStopService.Name = "btn_StartStopService";
            this.btn_StartStopService.Size = new System.Drawing.Size(88, 32);
            this.btn_StartStopService.TabIndex = 61;
            this.btn_StartStopService.Text = "开始服务";
            this.btn_StartStopService.Click += new System.EventHandler(this.btn_StartStopService_Click);
            // 
            // tb_ServicePort
            // 
            this.tb_ServicePort.Location = new System.Drawing.Point(77, 53);
            this.tb_ServicePort.Name = "tb_ServicePort";
            this.tb_ServicePort.Size = new System.Drawing.Size(84, 21);
            this.tb_ServicePort.TabIndex = 62;
            this.tb_ServicePort.Text = "5009";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "工作模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "服务端口：";
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.splitContainer3);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1317, 662);
            this.panel_Main.TabIndex = 70;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listView_terminal);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer3.Panel2.Controls.Add(this.panel_Bottom);
            this.splitContainer3.Size = new System.Drawing.Size(1317, 662);
            this.splitContainer3.SplitterDistance = 93;
            this.splitContainer3.TabIndex = 69;
            // 
            // listView_terminal
            // 
            this.listView_terminal.CheckBoxes = true;
            this.listView_terminal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_terminal.FullRowSelect = true;
            this.listView_terminal.HideSelection = false;
            this.listView_terminal.Location = new System.Drawing.Point(0, 0);
            this.listView_terminal.MultiSelect = false;
            this.listView_terminal.Name = "listView_terminal";
            this.listView_terminal.Size = new System.Drawing.Size(1317, 93);
            this.listView_terminal.TabIndex = 35;
            this.listView_terminal.UseCompatibleStateImageBehavior = false;
            this.listView_terminal.View = System.Windows.Forms.View.Details;
            this.listView_terminal.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_terminal_ItemChecked);
            this.listView_terminal.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_terminal_ItemSelectionChanged);
            this.listView_terminal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_terminal_MouseClick);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "终端登录号码";
            this.columnHeader0.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名称";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "移动网内IP地址";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "移动网内IP端口";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "登录时间";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "终端出口IP地址";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "终端出口IP端口";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "发送计数";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "接收计数";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "空闲时间";
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_Bottom.Controls.Add(this.tabControl1);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 0);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1317, 565);
            this.panel_Bottom.TabIndex = 42;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_receive);
            this.tabControl1.Controls.Add(this.tabPage_Status);
            this.tabControl1.Controls.Add(this.tabPage_Par);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1317, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_receive
            // 
            this.tabPage_receive.Controls.Add(this.tb_receive_zone);
            this.tabPage_receive.Location = new System.Drawing.Point(4, 22);
            this.tabPage_receive.Name = "tabPage_receive";
            this.tabPage_receive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_receive.Size = new System.Drawing.Size(1309, 539);
            this.tabPage_receive.TabIndex = 0;
            this.tabPage_receive.Text = "接收数据";
            this.tabPage_receive.UseVisualStyleBackColor = true;
            // 
            // tb_receive_zone
            // 
            this.tb_receive_zone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_receive_zone.Location = new System.Drawing.Point(3, 3);
            this.tb_receive_zone.Name = "tb_receive_zone";
            this.tb_receive_zone.Size = new System.Drawing.Size(1303, 533);
            this.tb_receive_zone.TabIndex = 42;
            this.tb_receive_zone.Text = "";
            // 
            // tabPage_Status
            // 
            this.tabPage_Status.Controls.Add(this.splitContainer_status);
            this.tabPage_Status.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Status.Name = "tabPage_Status";
            this.tabPage_Status.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Status.Size = new System.Drawing.Size(1309, 539);
            this.tabPage_Status.TabIndex = 1;
            this.tabPage_Status.Text = "设备状态";
            this.tabPage_Status.UseVisualStyleBackColor = true;
            // 
            // splitContainer_status
            // 
            this.splitContainer_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_status.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_status.Name = "splitContainer_status";
            // 
            // splitContainer_status.Panel1
            // 
            this.splitContainer_status.Panel1.Controls.Add(this.panel_device_status);
            // 
            // splitContainer_status.Panel2
            // 
            this.splitContainer_status.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer_status.Panel2.Controls.Add(this.btn_QueryStatus_4_5);
            this.splitContainer_status.Panel2.Controls.Add(this.btn_QueryStatus_1_3);
            this.splitContainer_status.Size = new System.Drawing.Size(1303, 533);
            this.splitContainer_status.SplitterDistance = 1133;
            this.splitContainer_status.TabIndex = 46;
            // 
            // panel_device_status
            // 
            this.panel_device_status.AutoScroll = true;
            this.panel_device_status.Controls.Add(this.btnToggle_Right_status);
            this.panel_device_status.Controls.Add(this.groupBox1);
            this.panel_device_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_device_status.Location = new System.Drawing.Point(0, 0);
            this.panel_device_status.Name = "panel_device_status";
            this.panel_device_status.Size = new System.Drawing.Size(1133, 533);
            this.panel_device_status.TabIndex = 46;
            // 
            // btnToggle_Right_status
            // 
            this.btnToggle_Right_status.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggle_Right_status.Location = new System.Drawing.Point(1106, 0);
            this.btnToggle_Right_status.Name = "btnToggle_Right_status";
            this.btnToggle_Right_status.Size = new System.Drawing.Size(10, 866);
            this.btnToggle_Right_status.TabIndex = 70;
            this.btnToggle_Right_status.Text = "<";
            this.btnToggle_Right_status.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.label277);
            this.groupBox1.Controls.Add(this.label271);
            this.groupBox1.Controls.Add(this.label272);
            this.groupBox1.Controls.Add(this.label265);
            this.groupBox1.Controls.Add(this.label268);
            this.groupBox1.Controls.Add(this.label283);
            this.groupBox1.Controls.Add(this.label284);
            this.groupBox1.Controls.Add(this.label285);
            this.groupBox1.Controls.Add(this.label286);
            this.groupBox1.Controls.Add(this.label287);
            this.groupBox1.Controls.Add(this.label288);
            this.groupBox1.Controls.Add(this.label289);
            this.groupBox1.Controls.Add(this.label290);
            this.groupBox1.Controls.Add(this.label291);
            this.groupBox1.Controls.Add(this.label292);
            this.groupBox1.Controls.Add(this.textBox156);
            this.groupBox1.Controls.Add(this.textBox157);
            this.groupBox1.Controls.Add(this.textBox158);
            this.groupBox1.Controls.Add(this.textBox159);
            this.groupBox1.Controls.Add(this.textBox160);
            this.groupBox1.Controls.Add(this.textBox161);
            this.groupBox1.Controls.Add(this.textBox162);
            this.groupBox1.Controls.Add(this.textBox163);
            this.groupBox1.Controls.Add(this.textBox164);
            this.groupBox1.Controls.Add(this.textBox165);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.label76);
            this.groupBox1.Controls.Add(this.label154);
            this.groupBox1.Controls.Add(this.label169);
            this.groupBox1.Controls.Add(this.label280);
            this.groupBox1.Controls.Add(this.textBox151);
            this.groupBox1.Controls.Add(this.label281);
            this.groupBox1.Controls.Add(this.textBox152);
            this.groupBox1.Controls.Add(this.label282);
            this.groupBox1.Controls.Add(this.textBox153);
            this.groupBox1.Controls.Add(this.textBox154);
            this.groupBox1.Controls.Add(this.textBox155);
            this.groupBox1.Controls.Add(this.lbl_No4);
            this.groupBox1.Controls.Add(this.lbl_No5);
            this.groupBox1.Controls.Add(this.label224);
            this.groupBox1.Controls.Add(this.label181);
            this.groupBox1.Controls.Add(this.label131);
            this.groupBox1.Controls.Add(this.label173);
            this.groupBox1.Controls.Add(this.label223);
            this.groupBox1.Controls.Add(this.label180);
            this.groupBox1.Controls.Add(this.label130);
            this.groupBox1.Controls.Add(this.label174);
            this.groupBox1.Controls.Add(this.textBox110);
            this.groupBox1.Controls.Add(this.textBox88);
            this.groupBox1.Controls.Add(this.textBox64);
            this.groupBox1.Controls.Add(this.textBox82);
            this.groupBox1.Controls.Add(this.label171);
            this.groupBox1.Controls.Add(this.label172);
            this.groupBox1.Controls.Add(this.textBox81);
            this.groupBox1.Controls.Add(this.label222);
            this.groupBox1.Controls.Add(this.label179);
            this.groupBox1.Controls.Add(this.label129);
            this.groupBox1.Controls.Add(this.label165);
            this.groupBox1.Controls.Add(this.comboBox11);
            this.groupBox1.Controls.Add(this.comboBox9);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox10);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label221);
            this.groupBox1.Controls.Add(this.label178);
            this.groupBox1.Controls.Add(this.label128);
            this.groupBox1.Controls.Add(this.label75);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.label220);
            this.groupBox1.Controls.Add(this.label177);
            this.groupBox1.Controls.Add(this.label127);
            this.groupBox1.Controls.Add(this.label74);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.label219);
            this.groupBox1.Controls.Add(this.label176);
            this.groupBox1.Controls.Add(this.label126);
            this.groupBox1.Controls.Add(this.label106);
            this.groupBox1.Controls.Add(this.label218);
            this.groupBox1.Controls.Add(this.label175);
            this.groupBox1.Controls.Add(this.label125);
            this.groupBox1.Controls.Add(this.label73);
            this.groupBox1.Controls.Add(this.label105);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label217);
            this.groupBox1.Controls.Add(this.label170);
            this.groupBox1.Controls.Add(this.label124);
            this.groupBox1.Controls.Add(this.label72);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label216);
            this.groupBox1.Controls.Add(this.label168);
            this.groupBox1.Controls.Add(this.label123);
            this.groupBox1.Controls.Add(this.label71);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label215);
            this.groupBox1.Controls.Add(this.label167);
            this.groupBox1.Controls.Add(this.label122);
            this.groupBox1.Controls.Add(this.label70);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label214);
            this.groupBox1.Controls.Add(this.label166);
            this.groupBox1.Controls.Add(this.label121);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label213);
            this.groupBox1.Controls.Add(this.label164);
            this.groupBox1.Controls.Add(this.label120);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label212);
            this.groupBox1.Controls.Add(this.label163);
            this.groupBox1.Controls.Add(this.label119);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label249);
            this.groupBox1.Controls.Add(this.label247);
            this.groupBox1.Controls.Add(this.label244);
            this.groupBox1.Controls.Add(this.label242);
            this.groupBox1.Controls.Add(this.label240);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label211);
            this.groupBox1.Controls.Add(this.label162);
            this.groupBox1.Controls.Add(this.label118);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label210);
            this.groupBox1.Controls.Add(this.label161);
            this.groupBox1.Controls.Add(this.label117);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label209);
            this.groupBox1.Controls.Add(this.label160);
            this.groupBox1.Controls.Add(this.label116);
            this.groupBox1.Controls.Add(this.label64);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label254);
            this.groupBox1.Controls.Add(this.label208);
            this.groupBox1.Controls.Add(this.label253);
            this.groupBox1.Controls.Add(this.label159);
            this.groupBox1.Controls.Add(this.label252);
            this.groupBox1.Controls.Add(this.label115);
            this.groupBox1.Controls.Add(this.label251);
            this.groupBox1.Controls.Add(this.label63);
            this.groupBox1.Controls.Add(this.label250);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label207);
            this.groupBox1.Controls.Add(this.label158);
            this.groupBox1.Controls.Add(this.label104);
            this.groupBox1.Controls.Add(this.label62);
            this.groupBox1.Controls.Add(this.label206);
            this.groupBox1.Controls.Add(this.label157);
            this.groupBox1.Controls.Add(this.label101);
            this.groupBox1.Controls.Add(this.label114);
            this.groupBox1.Controls.Add(this.label108);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label205);
            this.groupBox1.Controls.Add(this.label156);
            this.groupBox1.Controls.Add(this.label100);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label204);
            this.groupBox1.Controls.Add(this.label155);
            this.groupBox1.Controls.Add(this.label99);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label264);
            this.groupBox1.Controls.Add(this.label262);
            this.groupBox1.Controls.Add(this.label258);
            this.groupBox1.Controls.Add(this.label261);
            this.groupBox1.Controls.Add(this.label256);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label203);
            this.groupBox1.Controls.Add(this.label153);
            this.groupBox1.Controls.Add(this.label98);
            this.groupBox1.Controls.Add(this.label112);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label202);
            this.groupBox1.Controls.Add(this.label152);
            this.groupBox1.Controls.Add(this.label97);
            this.groupBox1.Controls.Add(this.label59);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label201);
            this.groupBox1.Controls.Add(this.label151);
            this.groupBox1.Controls.Add(this.label96);
            this.groupBox1.Controls.Add(this.label58);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label200);
            this.groupBox1.Controls.Add(this.label150);
            this.groupBox1.Controls.Add(this.label95);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.label276);
            this.groupBox1.Controls.Add(this.label270);
            this.groupBox1.Controls.Add(this.label279);
            this.groupBox1.Controls.Add(this.label275);
            this.groupBox1.Controls.Add(this.label267);
            this.groupBox1.Controls.Add(this.label274);
            this.groupBox1.Controls.Add(this.label269);
            this.groupBox1.Controls.Add(this.label278);
            this.groupBox1.Controls.Add(this.label273);
            this.groupBox1.Controls.Add(this.label266);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label199);
            this.groupBox1.Controls.Add(this.label149);
            this.groupBox1.Controls.Add(this.label94);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label198);
            this.groupBox1.Controls.Add(this.label148);
            this.groupBox1.Controls.Add(this.label93);
            this.groupBox1.Controls.Add(this.label55);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label197);
            this.groupBox1.Controls.Add(this.label147);
            this.groupBox1.Controls.Add(this.label92);
            this.groupBox1.Controls.Add(this.label54);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label196);
            this.groupBox1.Controls.Add(this.label146);
            this.groupBox1.Controls.Add(this.label91);
            this.groupBox1.Controls.Add(this.label103);
            this.groupBox1.Controls.Add(this.label195);
            this.groupBox1.Controls.Add(this.label145);
            this.groupBox1.Controls.Add(this.label90);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.label102);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label194);
            this.groupBox1.Controls.Add(this.label144);
            this.groupBox1.Controls.Add(this.label89);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.textBox147);
            this.groupBox1.Controls.Add(this.textBox109);
            this.groupBox1.Controls.Add(this.textBox150);
            this.groupBox1.Controls.Add(this.textBox141);
            this.groupBox1.Controls.Add(this.textBox146);
            this.groupBox1.Controls.Add(this.textBox87);
            this.groupBox1.Controls.Add(this.textBox145);
            this.groupBox1.Controls.Add(this.textBox138);
            this.groupBox1.Controls.Add(this.textBox149);
            this.groupBox1.Controls.Add(this.textBox140);
            this.groupBox1.Controls.Add(this.textBox144);
            this.groupBox1.Controls.Add(this.textBox63);
            this.groupBox1.Controls.Add(this.textBox143);
            this.groupBox1.Controls.Add(this.textBox137);
            this.groupBox1.Controls.Add(this.textBox148);
            this.groupBox1.Controls.Add(this.textBox139);
            this.groupBox1.Controls.Add(this.textBox142);
            this.groupBox1.Controls.Add(this.textBox38);
            this.groupBox1.Controls.Add(this.textBox136);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.label193);
            this.groupBox1.Controls.Add(this.label143);
            this.groupBox1.Controls.Add(this.label88);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.textBox108);
            this.groupBox1.Controls.Add(this.textBox86);
            this.groupBox1.Controls.Add(this.textBox62);
            this.groupBox1.Controls.Add(this.textBox37);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.label192);
            this.groupBox1.Controls.Add(this.label142);
            this.groupBox1.Controls.Add(this.label87);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.textBox107);
            this.groupBox1.Controls.Add(this.textBox85);
            this.groupBox1.Controls.Add(this.textBox61);
            this.groupBox1.Controls.Add(this.textBox52);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.textBox51);
            this.groupBox1.Controls.Add(this.textBox106);
            this.groupBox1.Controls.Add(this.textBox84);
            this.groupBox1.Controls.Add(this.textBox60);
            this.groupBox1.Controls.Add(this.textBox36);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.label191);
            this.groupBox1.Controls.Add(this.label141);
            this.groupBox1.Controls.Add(this.label86);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.textBox105);
            this.groupBox1.Controls.Add(this.textBox83);
            this.groupBox1.Controls.Add(this.textBox59);
            this.groupBox1.Controls.Add(this.textBox35);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.label190);
            this.groupBox1.Controls.Add(this.label140);
            this.groupBox1.Controls.Add(this.label85);
            this.groupBox1.Controls.Add(this.label111);
            this.groupBox1.Controls.Add(this.label248);
            this.groupBox1.Controls.Add(this.label246);
            this.groupBox1.Controls.Add(this.label243);
            this.groupBox1.Controls.Add(this.label241);
            this.groupBox1.Controls.Add(this.label239);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox104);
            this.groupBox1.Controls.Add(this.textBox80);
            this.groupBox1.Controls.Add(this.textBox58);
            this.groupBox1.Controls.Add(this.textBox34);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.textBox103);
            this.groupBox1.Controls.Add(this.textBox79);
            this.groupBox1.Controls.Add(this.textBox57);
            this.groupBox1.Controls.Add(this.textBox33);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox102);
            this.groupBox1.Controls.Add(this.textBox78);
            this.groupBox1.Controls.Add(this.textBox56);
            this.groupBox1.Controls.Add(this.textBox32);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label189);
            this.groupBox1.Controls.Add(this.label139);
            this.groupBox1.Controls.Add(this.label84);
            this.groupBox1.Controls.Add(this.label110);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox101);
            this.groupBox1.Controls.Add(this.textBox77);
            this.groupBox1.Controls.Add(this.textBox55);
            this.groupBox1.Controls.Add(this.textBox31);
            this.groupBox1.Controls.Add(this.textBox13);
            this.groupBox1.Controls.Add(this.textBox100);
            this.groupBox1.Controls.Add(this.textBox76);
            this.groupBox1.Controls.Add(this.textBox50);
            this.groupBox1.Controls.Add(this.textBox30);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox99);
            this.groupBox1.Controls.Add(this.textBox75);
            this.groupBox1.Controls.Add(this.textBox49);
            this.groupBox1.Controls.Add(this.textBox29);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox98);
            this.groupBox1.Controls.Add(this.textBox74);
            this.groupBox1.Controls.Add(this.textBox48);
            this.groupBox1.Controls.Add(this.textBox28);
            this.groupBox1.Controls.Add(this.textBox130);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox129);
            this.groupBox1.Controls.Add(this.textBox97);
            this.groupBox1.Controls.Add(this.textBox128);
            this.groupBox1.Controls.Add(this.textBox73);
            this.groupBox1.Controls.Add(this.textBox127);
            this.groupBox1.Controls.Add(this.textBox47);
            this.groupBox1.Controls.Add(this.textBox126);
            this.groupBox1.Controls.Add(this.textBox27);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label188);
            this.groupBox1.Controls.Add(this.label138);
            this.groupBox1.Controls.Add(this.label83);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox96);
            this.groupBox1.Controls.Add(this.textBox72);
            this.groupBox1.Controls.Add(this.textBox46);
            this.groupBox1.Controls.Add(this.textBox26);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label187);
            this.groupBox1.Controls.Add(this.label137);
            this.groupBox1.Controls.Add(this.label82);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox95);
            this.groupBox1.Controls.Add(this.textBox71);
            this.groupBox1.Controls.Add(this.textBox45);
            this.groupBox1.Controls.Add(this.textBox25);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label186);
            this.groupBox1.Controls.Add(this.label136);
            this.groupBox1.Controls.Add(this.label81);
            this.groupBox1.Controls.Add(this.label109);
            this.groupBox1.Controls.Add(this.label238);
            this.groupBox1.Controls.Add(this.label235);
            this.groupBox1.Controls.Add(this.label232);
            this.groupBox1.Controls.Add(this.label228);
            this.groupBox1.Controls.Add(this.label245);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.textBox94);
            this.groupBox1.Controls.Add(this.textBox70);
            this.groupBox1.Controls.Add(this.textBox44);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label185);
            this.groupBox1.Controls.Add(this.label135);
            this.groupBox1.Controls.Add(this.label80);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label184);
            this.groupBox1.Controls.Add(this.label134);
            this.groupBox1.Controls.Add(this.label79);
            this.groupBox1.Controls.Add(this.label113);
            this.groupBox1.Controls.Add(this.label237);
            this.groupBox1.Controls.Add(this.label234);
            this.groupBox1.Controls.Add(this.label231);
            this.groupBox1.Controls.Add(this.label227);
            this.groupBox1.Controls.Add(this.label230);
            this.groupBox1.Controls.Add(this.label107);
            this.groupBox1.Controls.Add(this.textBox125);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.textBox124);
            this.groupBox1.Controls.Add(this.textBox93);
            this.groupBox1.Controls.Add(this.textBox123);
            this.groupBox1.Controls.Add(this.textBox69);
            this.groupBox1.Controls.Add(this.textBox43);
            this.groupBox1.Controls.Add(this.textBox122);
            this.groupBox1.Controls.Add(this.textBox120);
            this.groupBox1.Controls.Add(this.textBox23);
            this.groupBox1.Controls.Add(this.textBox119);
            this.groupBox1.Controls.Add(this.textBox92);
            this.groupBox1.Controls.Add(this.textBox118);
            this.groupBox1.Controls.Add(this.textBox68);
            this.groupBox1.Controls.Add(this.textBox117);
            this.groupBox1.Controls.Add(this.textBox42);
            this.groupBox1.Controls.Add(this.textBox54);
            this.groupBox1.Controls.Add(this.textBox121);
            this.groupBox1.Controls.Add(this.textBox116);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox53);
            this.groupBox1.Controls.Add(this.textBox91);
            this.groupBox1.Controls.Add(this.textBox67);
            this.groupBox1.Controls.Add(this.textBox41);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.label236);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label233);
            this.groupBox1.Controls.Add(this.label183);
            this.groupBox1.Controls.Add(this.label229);
            this.groupBox1.Controls.Add(this.label133);
            this.groupBox1.Controls.Add(this.label226);
            this.groupBox1.Controls.Add(this.label78);
            this.groupBox1.Controls.Add(this.label225);
            this.groupBox1.Controls.Add(this.label77);
            this.groupBox1.Controls.Add(this.textBox115);
            this.groupBox1.Controls.Add(this.label132);
            this.groupBox1.Controls.Add(this.textBox114);
            this.groupBox1.Controls.Add(this.textBox90);
            this.groupBox1.Controls.Add(this.textBox113);
            this.groupBox1.Controls.Add(this.textBox66);
            this.groupBox1.Controls.Add(this.textBox112);
            this.groupBox1.Controls.Add(this.textBox40);
            this.groupBox1.Controls.Add(this.textBox111);
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label182);
            this.groupBox1.Controls.Add(this.label255);
            this.groupBox1.Controls.Add(this.textBox89);
            this.groupBox1.Controls.Add(this.label257);
            this.groupBox1.Controls.Add(this.textBox65);
            this.groupBox1.Controls.Add(this.label259);
            this.groupBox1.Controls.Add(this.textBox39);
            this.groupBox1.Controls.Add(this.label263);
            this.groupBox1.Controls.Add(this.label260);
            this.groupBox1.Controls.Add(this.label293);
            this.groupBox1.Controls.Add(this.textBox135);
            this.groupBox1.Controls.Add(this.label294);
            this.groupBox1.Controls.Add(this.textBox134);
            this.groupBox1.Controls.Add(this.label295);
            this.groupBox1.Controls.Add(this.textBox132);
            this.groupBox1.Controls.Add(this.textBox133);
            this.groupBox1.Controls.Add(this.label296);
            this.groupBox1.Controls.Add(this.textBox131);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_No3);
            this.groupBox1.Controls.Add(this.lbl_No2);
            this.groupBox1.Controls.Add(this.lbl_No1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1092, 864);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "解析数据";
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Location = new System.Drawing.Point(859, 736);
            this.label277.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(65, 12);
            this.label277.TabIndex = 159;
            this.label277.Text = "5#手动定频";
            // 
            // label271
            // 
            this.label271.AutoSize = true;
            this.label271.Location = new System.Drawing.Point(664, 736);
            this.label271.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(65, 12);
            this.label271.TabIndex = 158;
            this.label271.Text = "4#手动定频";
            // 
            // label272
            // 
            this.label272.AutoSize = true;
            this.label272.Location = new System.Drawing.Point(459, 736);
            this.label272.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(65, 12);
            this.label272.TabIndex = 157;
            this.label272.Text = "3#手动定频";
            // 
            // label265
            // 
            this.label265.AutoSize = true;
            this.label265.Location = new System.Drawing.Point(261, 736);
            this.label265.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(65, 12);
            this.label265.TabIndex = 156;
            this.label265.Text = "2#手动定频";
            // 
            // label268
            // 
            this.label268.AutoSize = true;
            this.label268.Location = new System.Drawing.Point(63, 736);
            this.label268.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(65, 12);
            this.label268.TabIndex = 155;
            this.label268.Text = "1#手动定频";
            // 
            // label283
            // 
            this.label283.AutoSize = true;
            this.label283.Location = new System.Drawing.Point(459, 828);
            this.label283.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label283.Name = "label283";
            this.label283.Size = new System.Drawing.Size(53, 12);
            this.label283.TabIndex = 135;
            this.label283.Text = "更新时间";
            // 
            // label284
            // 
            this.label284.AutoSize = true;
            this.label284.Location = new System.Drawing.Point(63, 828);
            this.label284.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label284.Name = "label284";
            this.label284.Size = new System.Drawing.Size(53, 12);
            this.label284.TabIndex = 143;
            this.label284.Text = "更新时间";
            // 
            // label285
            // 
            this.label285.AutoSize = true;
            this.label285.Location = new System.Drawing.Point(859, 828);
            this.label285.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label285.Name = "label285";
            this.label285.Size = new System.Drawing.Size(53, 12);
            this.label285.TabIndex = 142;
            this.label285.Text = "更新时间";
            // 
            // label286
            // 
            this.label286.AutoSize = true;
            this.label286.Location = new System.Drawing.Point(664, 828);
            this.label286.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label286.Name = "label286";
            this.label286.Size = new System.Drawing.Size(53, 12);
            this.label286.TabIndex = 141;
            this.label286.Text = "更新时间";
            // 
            // label287
            // 
            this.label287.AutoSize = true;
            this.label287.Location = new System.Drawing.Point(261, 828);
            this.label287.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label287.Name = "label287";
            this.label287.Size = new System.Drawing.Size(53, 12);
            this.label287.TabIndex = 144;
            this.label287.Text = "更新时间";
            // 
            // label288
            // 
            this.label288.AutoSize = true;
            this.label288.Location = new System.Drawing.Point(459, 805);
            this.label288.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label288.Name = "label288";
            this.label288.Size = new System.Drawing.Size(53, 12);
            this.label288.TabIndex = 139;
            this.label288.Text = "更新计数";
            // 
            // label289
            // 
            this.label289.AutoSize = true;
            this.label289.Location = new System.Drawing.Point(63, 805);
            this.label289.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label289.Name = "label289";
            this.label289.Size = new System.Drawing.Size(53, 12);
            this.label289.TabIndex = 138;
            this.label289.Text = "更新计数";
            // 
            // label290
            // 
            this.label290.AutoSize = true;
            this.label290.Location = new System.Drawing.Point(859, 805);
            this.label290.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label290.Name = "label290";
            this.label290.Size = new System.Drawing.Size(53, 12);
            this.label290.TabIndex = 137;
            this.label290.Text = "更新计数";
            // 
            // label291
            // 
            this.label291.AutoSize = true;
            this.label291.Location = new System.Drawing.Point(664, 805);
            this.label291.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label291.Name = "label291";
            this.label291.Size = new System.Drawing.Size(53, 12);
            this.label291.TabIndex = 136;
            this.label291.Text = "更新计数";
            // 
            // label292
            // 
            this.label292.AutoSize = true;
            this.label292.Location = new System.Drawing.Point(261, 805);
            this.label292.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label292.Name = "label292";
            this.label292.Size = new System.Drawing.Size(53, 12);
            this.label292.TabIndex = 140;
            this.label292.Text = "更新计数";
            // 
            // textBox156
            // 
            this.textBox156.Location = new System.Drawing.Point(549, 822);
            this.textBox156.Margin = new System.Windows.Forms.Padding(2);
            this.textBox156.Name = "textBox156";
            this.textBox156.Size = new System.Drawing.Size(113, 21);
            this.textBox156.TabIndex = 146;
            // 
            // textBox157
            // 
            this.textBox157.Location = new System.Drawing.Point(940, 822);
            this.textBox157.Margin = new System.Windows.Forms.Padding(2);
            this.textBox157.Name = "textBox157";
            this.textBox157.Size = new System.Drawing.Size(113, 21);
            this.textBox157.TabIndex = 147;
            // 
            // textBox158
            // 
            this.textBox158.Location = new System.Drawing.Point(144, 822);
            this.textBox158.Margin = new System.Windows.Forms.Padding(2);
            this.textBox158.Name = "textBox158";
            this.textBox158.Size = new System.Drawing.Size(113, 21);
            this.textBox158.TabIndex = 148;
            // 
            // textBox159
            // 
            this.textBox159.Location = new System.Drawing.Point(745, 822);
            this.textBox159.Margin = new System.Windows.Forms.Padding(2);
            this.textBox159.Name = "textBox159";
            this.textBox159.Size = new System.Drawing.Size(113, 21);
            this.textBox159.TabIndex = 149;
            // 
            // textBox160
            // 
            this.textBox160.Location = new System.Drawing.Point(549, 799);
            this.textBox160.Margin = new System.Windows.Forms.Padding(2);
            this.textBox160.Name = "textBox160";
            this.textBox160.Size = new System.Drawing.Size(54, 21);
            this.textBox160.TabIndex = 150;
            // 
            // textBox161
            // 
            this.textBox161.Location = new System.Drawing.Point(342, 822);
            this.textBox161.Margin = new System.Windows.Forms.Padding(2);
            this.textBox161.Name = "textBox161";
            this.textBox161.Size = new System.Drawing.Size(113, 21);
            this.textBox161.TabIndex = 151;
            // 
            // textBox162
            // 
            this.textBox162.Location = new System.Drawing.Point(940, 799);
            this.textBox162.Margin = new System.Windows.Forms.Padding(2);
            this.textBox162.Name = "textBox162";
            this.textBox162.Size = new System.Drawing.Size(54, 21);
            this.textBox162.TabIndex = 152;
            // 
            // textBox163
            // 
            this.textBox163.Location = new System.Drawing.Point(144, 799);
            this.textBox163.Margin = new System.Windows.Forms.Padding(2);
            this.textBox163.Name = "textBox163";
            this.textBox163.Size = new System.Drawing.Size(54, 21);
            this.textBox163.TabIndex = 153;
            // 
            // textBox164
            // 
            this.textBox164.Location = new System.Drawing.Point(745, 799);
            this.textBox164.Margin = new System.Windows.Forms.Padding(2);
            this.textBox164.Name = "textBox164";
            this.textBox164.Size = new System.Drawing.Size(54, 21);
            this.textBox164.TabIndex = 145;
            // 
            // textBox165
            // 
            this.textBox165.Location = new System.Drawing.Point(342, 799);
            this.textBox165.Margin = new System.Windows.Forms.Padding(2);
            this.textBox165.Name = "textBox165";
            this.textBox165.Size = new System.Drawing.Size(54, 21);
            this.textBox165.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1004, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 100;
            this.label6.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(809, 456);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 101;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 456);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 102;
            this.label8.Text = "m";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(613, 456);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(11, 12);
            this.label43.TabIndex = 103;
            this.label43.Text = "m";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(208, 456);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(11, 12);
            this.label76.TabIndex = 104;
            this.label76.Text = "m";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(859, 457);
            this.label154.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(59, 12);
            this.label154.TabIndex = 105;
            this.label154.Text = "进水液位2";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(664, 457);
            this.label169.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(59, 12);
            this.label169.TabIndex = 106;
            this.label169.Text = "进水液位2";
            // 
            // label280
            // 
            this.label280.AutoSize = true;
            this.label280.Location = new System.Drawing.Point(261, 457);
            this.label280.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(59, 12);
            this.label280.TabIndex = 107;
            this.label280.Text = "进水液位2";
            // 
            // textBox151
            // 
            this.textBox151.Location = new System.Drawing.Point(940, 453);
            this.textBox151.Margin = new System.Windows.Forms.Padding(2);
            this.textBox151.Name = "textBox151";
            this.textBox151.Size = new System.Drawing.Size(54, 21);
            this.textBox151.TabIndex = 110;
            // 
            // label281
            // 
            this.label281.AutoSize = true;
            this.label281.Location = new System.Drawing.Point(459, 457);
            this.label281.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(59, 12);
            this.label281.TabIndex = 108;
            this.label281.Text = "进水液位2";
            // 
            // textBox152
            // 
            this.textBox152.Location = new System.Drawing.Point(745, 453);
            this.textBox152.Margin = new System.Windows.Forms.Padding(2);
            this.textBox152.Name = "textBox152";
            this.textBox152.Size = new System.Drawing.Size(54, 21);
            this.textBox152.TabIndex = 111;
            // 
            // label282
            // 
            this.label282.AutoSize = true;
            this.label282.Location = new System.Drawing.Point(63, 457);
            this.label282.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label282.Name = "label282";
            this.label282.Size = new System.Drawing.Size(59, 12);
            this.label282.TabIndex = 109;
            this.label282.Text = "进水液位2";
            // 
            // textBox153
            // 
            this.textBox153.Location = new System.Drawing.Point(342, 453);
            this.textBox153.Margin = new System.Windows.Forms.Padding(2);
            this.textBox153.Name = "textBox153";
            this.textBox153.Size = new System.Drawing.Size(54, 21);
            this.textBox153.TabIndex = 112;
            // 
            // textBox154
            // 
            this.textBox154.Location = new System.Drawing.Point(549, 453);
            this.textBox154.Margin = new System.Windows.Forms.Padding(2);
            this.textBox154.Name = "textBox154";
            this.textBox154.Size = new System.Drawing.Size(54, 21);
            this.textBox154.TabIndex = 113;
            // 
            // textBox155
            // 
            this.textBox155.Location = new System.Drawing.Point(144, 453);
            this.textBox155.Margin = new System.Windows.Forms.Padding(2);
            this.textBox155.Name = "textBox155";
            this.textBox155.Size = new System.Drawing.Size(54, 21);
            this.textBox155.TabIndex = 114;
            // 
            // lbl_No4
            // 
            this.lbl_No4.AutoSize = true;
            this.lbl_No4.Location = new System.Drawing.Point(690, 14);
            this.lbl_No4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_No4.Name = "lbl_No4";
            this.lbl_No4.Size = new System.Drawing.Size(53, 12);
            this.lbl_No4.TabIndex = 99;
            this.lbl_No4.Text = "4#双驱泵";
            // 
            // lbl_No5
            // 
            this.lbl_No5.AutoSize = true;
            this.lbl_No5.Location = new System.Drawing.Point(888, 14);
            this.lbl_No5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_No5.Name = "lbl_No5";
            this.lbl_No5.Size = new System.Drawing.Size(53, 12);
            this.lbl_No5.TabIndex = 94;
            this.lbl_No5.Text = "5#双驱泵";
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Location = new System.Drawing.Point(1004, 409);
            this.label224.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(11, 12);
            this.label224.TabIndex = 33;
            this.label224.Text = "A";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(809, 409);
            this.label181.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(11, 12);
            this.label181.TabIndex = 33;
            this.label181.Text = "A";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(613, 409);
            this.label131.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(11, 12);
            this.label131.TabIndex = 33;
            this.label131.Text = "A";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(406, 409);
            this.label173.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(11, 12);
            this.label173.TabIndex = 33;
            this.label173.Text = "A";
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Location = new System.Drawing.Point(859, 410);
            this.label223.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(29, 12);
            this.label223.TabIndex = 34;
            this.label223.Text = "电流";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(664, 410);
            this.label180.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(29, 12);
            this.label180.TabIndex = 34;
            this.label180.Text = "电流";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(459, 410);
            this.label130.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(29, 12);
            this.label130.TabIndex = 34;
            this.label130.Text = "电流";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(261, 410);
            this.label174.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(29, 12);
            this.label174.TabIndex = 34;
            this.label174.Text = "电流";
            // 
            // textBox110
            // 
            this.textBox110.Location = new System.Drawing.Point(940, 406);
            this.textBox110.Margin = new System.Windows.Forms.Padding(2);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(54, 21);
            this.textBox110.TabIndex = 35;
            // 
            // textBox88
            // 
            this.textBox88.Location = new System.Drawing.Point(745, 406);
            this.textBox88.Margin = new System.Windows.Forms.Padding(2);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(54, 21);
            this.textBox88.TabIndex = 35;
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(549, 406);
            this.textBox64.Margin = new System.Windows.Forms.Padding(2);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(54, 21);
            this.textBox64.TabIndex = 35;
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(342, 406);
            this.textBox82.Margin = new System.Windows.Forms.Padding(2);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(54, 21);
            this.textBox82.TabIndex = 35;
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(208, 409);
            this.label171.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(11, 12);
            this.label171.TabIndex = 30;
            this.label171.Text = "A";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(63, 410);
            this.label172.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(29, 12);
            this.label172.TabIndex = 31;
            this.label172.Text = "电流";
            // 
            // textBox81
            // 
            this.textBox81.Location = new System.Drawing.Point(144, 406);
            this.textBox81.Margin = new System.Windows.Forms.Padding(2);
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(54, 21);
            this.textBox81.TabIndex = 32;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(859, 551);
            this.label222.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(29, 12);
            this.label222.TabIndex = 27;
            this.label222.Text = "频率";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(664, 551);
            this.label179.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(29, 12);
            this.label179.TabIndex = 27;
            this.label179.Text = "频率";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(459, 551);
            this.label129.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(29, 12);
            this.label129.TabIndex = 27;
            this.label129.Text = "频率";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(261, 551);
            this.label165.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(29, 12);
            this.label165.TabIndex = 27;
            this.label165.Text = "频率";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(940, 708);
            this.comboBox11.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(91, 20);
            this.comboBox11.TabIndex = 25;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(745, 708);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(91, 20);
            this.comboBox9.TabIndex = 25;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(549, 708);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(91, 20);
            this.comboBox6.TabIndex = 25;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(342, 708);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(91, 20);
            this.comboBox4.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 708);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 20);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(940, 686);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(91, 20);
            this.comboBox10.TabIndex = 25;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(745, 686);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(91, 20);
            this.comboBox7.TabIndex = 25;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(549, 686);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(91, 20);
            this.comboBox5.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(342, 686);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(91, 20);
            this.comboBox3.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 686);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 20);
            this.comboBox1.TabIndex = 25;
            // 
            // label221
            // 
            this.label221.AutoSize = true;
            this.label221.Location = new System.Drawing.Point(1004, 666);
            this.label221.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(17, 12);
            this.label221.TabIndex = 6;
            this.label221.Text = "℃";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(809, 666);
            this.label178.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(17, 12);
            this.label178.TabIndex = 6;
            this.label178.Text = "℃";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(613, 666);
            this.label128.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(17, 12);
            this.label128.TabIndex = 6;
            this.label128.Text = "℃";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(406, 666);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(17, 12);
            this.label75.TabIndex = 6;
            this.label75.Text = "℃";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(208, 666);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(17, 12);
            this.label40.TabIndex = 6;
            this.label40.Text = "℃";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Location = new System.Drawing.Point(1004, 643);
            this.label220.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(17, 12);
            this.label220.TabIndex = 6;
            this.label220.Text = "℃";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(809, 643);
            this.label177.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(17, 12);
            this.label177.TabIndex = 6;
            this.label177.Text = "℃";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(613, 643);
            this.label127.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(17, 12);
            this.label127.TabIndex = 6;
            this.label127.Text = "℃";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(406, 643);
            this.label74.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(17, 12);
            this.label74.TabIndex = 6;
            this.label74.Text = "℃";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(208, 643);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(17, 12);
            this.label38.TabIndex = 6;
            this.label38.Text = "℃";
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Location = new System.Drawing.Point(1004, 597);
            this.label219.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(23, 12);
            this.label219.TabIndex = 6;
            this.label219.Text = "MPa";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(809, 597);
            this.label176.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(23, 12);
            this.label176.TabIndex = 6;
            this.label176.Text = "MPa";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(613, 597);
            this.label126.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(23, 12);
            this.label126.TabIndex = 6;
            this.label126.Text = "MPa";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(406, 597);
            this.label106.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(23, 12);
            this.label106.TabIndex = 6;
            this.label106.Text = "MPa";
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Location = new System.Drawing.Point(1004, 620);
            this.label218.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(23, 12);
            this.label218.TabIndex = 6;
            this.label218.Text = "MPa";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(809, 620);
            this.label175.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(23, 12);
            this.label175.TabIndex = 6;
            this.label175.Text = "MPa";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(613, 620);
            this.label125.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(23, 12);
            this.label125.TabIndex = 6;
            this.label125.Text = "MPa";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(406, 620);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(23, 12);
            this.label73.TabIndex = 6;
            this.label73.Text = "MPa";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(208, 597);
            this.label105.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(23, 12);
            this.label105.TabIndex = 6;
            this.label105.Text = "MPa";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(208, 620);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 12);
            this.label36.TabIndex = 6;
            this.label36.Text = "MPa";
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Location = new System.Drawing.Point(1004, 573);
            this.label217.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(23, 12);
            this.label217.TabIndex = 6;
            this.label217.Text = "MPa";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(809, 573);
            this.label170.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(23, 12);
            this.label170.TabIndex = 6;
            this.label170.Text = "MPa";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(613, 573);
            this.label124.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(23, 12);
            this.label124.TabIndex = 6;
            this.label124.Text = "MPa";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(406, 573);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(23, 12);
            this.label72.TabIndex = 6;
            this.label72.Text = "MPa";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(208, 573);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 12);
            this.label34.TabIndex = 6;
            this.label34.Text = "MPa";
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Location = new System.Drawing.Point(1004, 550);
            this.label216.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(17, 12);
            this.label216.TabIndex = 6;
            this.label216.Text = "Hz";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(809, 550);
            this.label168.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(17, 12);
            this.label168.TabIndex = 6;
            this.label168.Text = "Hz";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(613, 550);
            this.label123.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(17, 12);
            this.label123.TabIndex = 6;
            this.label123.Text = "Hz";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(406, 550);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(17, 12);
            this.label71.TabIndex = 6;
            this.label71.Text = "Hz";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(208, 550);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 12);
            this.label32.TabIndex = 6;
            this.label32.Text = "Hz";
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Location = new System.Drawing.Point(1004, 527);
            this.label215.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(17, 12);
            this.label215.TabIndex = 6;
            this.label215.Text = "秒";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(809, 527);
            this.label167.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(17, 12);
            this.label167.TabIndex = 6;
            this.label167.Text = "秒";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(613, 527);
            this.label122.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(17, 12);
            this.label122.TabIndex = 6;
            this.label122.Text = "秒";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(406, 527);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(17, 12);
            this.label70.TabIndex = 6;
            this.label70.Text = "秒";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(208, 527);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 12);
            this.label30.TabIndex = 6;
            this.label30.Text = "秒";
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Location = new System.Drawing.Point(1004, 504);
            this.label214.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(29, 12);
            this.label214.TabIndex = 6;
            this.label214.Text = "分钟";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(809, 504);
            this.label166.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(29, 12);
            this.label166.TabIndex = 6;
            this.label166.Text = "分钟";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(613, 504);
            this.label121.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(29, 12);
            this.label121.TabIndex = 6;
            this.label121.Text = "分钟";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(406, 504);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(29, 12);
            this.label69.TabIndex = 6;
            this.label69.Text = "分钟";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(208, 504);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 6;
            this.label28.Text = "分钟";
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Location = new System.Drawing.Point(1004, 481);
            this.label213.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(29, 12);
            this.label213.TabIndex = 6;
            this.label213.Text = "小时";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(809, 481);
            this.label164.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(29, 12);
            this.label164.TabIndex = 6;
            this.label164.Text = "小时";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(613, 481);
            this.label120.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(29, 12);
            this.label120.TabIndex = 6;
            this.label120.Text = "小时";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(406, 481);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(29, 12);
            this.label68.TabIndex = 6;
            this.label68.Text = "小时";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(208, 481);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 6;
            this.label26.Text = "小时";
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(1004, 315);
            this.label212.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(23, 12);
            this.label212.TabIndex = 6;
            this.label212.Text = "rpm";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(809, 315);
            this.label163.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(23, 12);
            this.label163.TabIndex = 6;
            this.label163.Text = "rpm";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(613, 315);
            this.label119.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(23, 12);
            this.label119.TabIndex = 6;
            this.label119.Text = "rpm";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(407, 315);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(23, 12);
            this.label67.TabIndex = 6;
            this.label67.Text = "rpm";
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Location = new System.Drawing.Point(1004, 342);
            this.label249.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(11, 12);
            this.label249.TabIndex = 6;
            this.label249.Text = "%";
            // 
            // label247
            // 
            this.label247.AutoSize = true;
            this.label247.Location = new System.Drawing.Point(809, 342);
            this.label247.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(11, 12);
            this.label247.TabIndex = 6;
            this.label247.Text = "%";
            // 
            // label244
            // 
            this.label244.AutoSize = true;
            this.label244.Location = new System.Drawing.Point(613, 342);
            this.label244.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(11, 12);
            this.label244.TabIndex = 6;
            this.label244.Text = "%";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Location = new System.Drawing.Point(408, 342);
            this.label242.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(11, 12);
            this.label242.TabIndex = 6;
            this.label242.Text = "%";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(208, 342);
            this.label240.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(11, 12);
            this.label240.TabIndex = 6;
            this.label240.Text = "%";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(208, 315);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 6;
            this.label22.Text = "rpm";
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(1004, 273);
            this.label211.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(11, 12);
            this.label211.TabIndex = 6;
            this.label211.Text = "V";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(809, 273);
            this.label162.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(11, 12);
            this.label162.TabIndex = 6;
            this.label162.Text = "V";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(613, 273);
            this.label118.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(11, 12);
            this.label118.TabIndex = 6;
            this.label118.Text = "V";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(407, 273);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(11, 12);
            this.label66.TabIndex = 6;
            this.label66.Text = "V";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(208, 273);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 12);
            this.label19.TabIndex = 6;
            this.label19.Text = "V";
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(1004, 250);
            this.label210.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(17, 12);
            this.label210.TabIndex = 6;
            this.label210.Text = "M3";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(809, 250);
            this.label161.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(17, 12);
            this.label161.TabIndex = 6;
            this.label161.Text = "M3";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(613, 250);
            this.label117.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(17, 12);
            this.label117.TabIndex = 6;
            this.label117.Text = "M3";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(407, 250);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(17, 12);
            this.label65.TabIndex = 6;
            this.label65.Text = "M3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 250);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "M3";
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(1004, 227);
            this.label209.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(29, 12);
            this.label209.TabIndex = 6;
            this.label209.Text = "M3/h";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(809, 227);
            this.label160.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(29, 12);
            this.label160.TabIndex = 6;
            this.label160.Text = "M3/h";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(613, 227);
            this.label116.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(29, 12);
            this.label116.TabIndex = 6;
            this.label116.Text = "M3/h";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(407, 227);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(29, 12);
            this.label64.TabIndex = 6;
            this.label64.Text = "M3/h";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 227);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 6;
            this.label15.Text = "M3/h";
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(1004, 204);
            this.label254.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(17, 12);
            this.label254.TabIndex = 6;
            this.label254.Text = "台";
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.Location = new System.Drawing.Point(1004, 181);
            this.label208.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(11, 12);
            this.label208.TabIndex = 6;
            this.label208.Text = "%";
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Location = new System.Drawing.Point(809, 204);
            this.label253.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(17, 12);
            this.label253.TabIndex = 6;
            this.label253.Text = "台";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(809, 181);
            this.label159.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(11, 12);
            this.label159.TabIndex = 6;
            this.label159.Text = "%";
            // 
            // label252
            // 
            this.label252.AutoSize = true;
            this.label252.Location = new System.Drawing.Point(613, 204);
            this.label252.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(17, 12);
            this.label252.TabIndex = 6;
            this.label252.Text = "台";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(613, 181);
            this.label115.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(11, 12);
            this.label115.TabIndex = 6;
            this.label115.Text = "%";
            // 
            // label251
            // 
            this.label251.AutoSize = true;
            this.label251.Location = new System.Drawing.Point(407, 204);
            this.label251.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(17, 12);
            this.label251.TabIndex = 6;
            this.label251.Text = "台";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(407, 181);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(11, 12);
            this.label63.TabIndex = 6;
            this.label63.Text = "%";
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.Location = new System.Drawing.Point(208, 204);
            this.label250.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(17, 12);
            this.label250.TabIndex = 6;
            this.label250.Text = "台";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(208, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "%";
            // 
            // label207
            // 
            this.label207.AutoSize = true;
            this.label207.Location = new System.Drawing.Point(1004, 65);
            this.label207.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(17, 12);
            this.label207.TabIndex = 6;
            this.label207.Text = "Hz";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(809, 65);
            this.label158.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(17, 12);
            this.label158.TabIndex = 6;
            this.label158.Text = "Hz";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(613, 65);
            this.label104.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(17, 12);
            this.label104.TabIndex = 6;
            this.label104.Text = "Hz";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(407, 65);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(17, 12);
            this.label62.TabIndex = 6;
            this.label62.Text = "Hz";
            // 
            // label206
            // 
            this.label206.AutoSize = true;
            this.label206.Location = new System.Drawing.Point(1004, 88);
            this.label206.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(11, 12);
            this.label206.TabIndex = 6;
            this.label206.Text = "V";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(809, 88);
            this.label157.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(11, 12);
            this.label157.TabIndex = 6;
            this.label157.Text = "V";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(613, 88);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(11, 12);
            this.label101.TabIndex = 6;
            this.label101.Text = "V";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(408, 88);
            this.label114.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(11, 12);
            this.label114.TabIndex = 6;
            this.label114.Text = "V";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(208, 88);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(11, 12);
            this.label108.TabIndex = 6;
            this.label108.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hz";
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.Location = new System.Drawing.Point(1004, 114);
            this.label205.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(23, 12);
            this.label205.TabIndex = 6;
            this.label205.Text = "kWh";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(809, 114);
            this.label156.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(23, 12);
            this.label156.TabIndex = 6;
            this.label156.Text = "kWh";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(613, 114);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(23, 12);
            this.label100.TabIndex = 6;
            this.label100.Text = "kWh";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(407, 114);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(23, 12);
            this.label61.TabIndex = 6;
            this.label61.Text = "kWh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "kWh";
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(1004, 42);
            this.label204.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(17, 12);
            this.label204.TabIndex = 6;
            this.label204.Text = "kW";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(809, 42);
            this.label155.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(17, 12);
            this.label155.TabIndex = 6;
            this.label155.Text = "kW";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(613, 42);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(17, 12);
            this.label99.TabIndex = 6;
            this.label99.Text = "kW";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(407, 42);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(17, 12);
            this.label60.TabIndex = 6;
            this.label60.Text = "kW";
            // 
            // label264
            // 
            this.label264.AutoSize = true;
            this.label264.Location = new System.Drawing.Point(1004, 432);
            this.label264.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(11, 12);
            this.label264.TabIndex = 6;
            this.label264.Text = "m";
            // 
            // label262
            // 
            this.label262.AutoSize = true;
            this.label262.Location = new System.Drawing.Point(809, 432);
            this.label262.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(11, 12);
            this.label262.TabIndex = 6;
            this.label262.Text = "m";
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Location = new System.Drawing.Point(406, 432);
            this.label258.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(11, 12);
            this.label258.TabIndex = 6;
            this.label258.Text = "m";
            // 
            // label261
            // 
            this.label261.AutoSize = true;
            this.label261.Location = new System.Drawing.Point(613, 432);
            this.label261.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(11, 12);
            this.label261.TabIndex = 6;
            this.label261.Text = "m";
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Location = new System.Drawing.Point(208, 432);
            this.label256.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(11, 12);
            this.label256.TabIndex = 6;
            this.label256.Text = "m";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "kW";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(859, 295);
            this.label203.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(29, 12);
            this.label203.TabIndex = 6;
            this.label203.Text = "启停";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(664, 295);
            this.label153.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(29, 12);
            this.label153.TabIndex = 6;
            this.label153.Text = "启停";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(459, 295);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(29, 12);
            this.label98.TabIndex = 6;
            this.label98.Text = "启停";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(261, 295);
            this.label112.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(29, 12);
            this.label112.TabIndex = 6;
            this.label112.Text = "启停";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(63, 295);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 6;
            this.label20.Text = "启停";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(859, 387);
            this.label202.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(47, 12);
            this.label202.TabIndex = 6;
            this.label202.Text = "220计数";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(664, 387);
            this.label152.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(47, 12);
            this.label152.TabIndex = 6;
            this.label152.Text = "220计数";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(459, 387);
            this.label97.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(47, 12);
            this.label97.TabIndex = 6;
            this.label97.Text = "220计数";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(261, 387);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 12);
            this.label59.TabIndex = 6;
            this.label59.Text = "220计数";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(63, 387);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 6;
            this.label25.Text = "220计数";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(859, 364);
            this.label201.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(65, 12);
            this.label201.TabIndex = 6;
            this.label201.Text = "变频器计数";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(664, 364);
            this.label151.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(65, 12);
            this.label151.TabIndex = 6;
            this.label151.Text = "变频器计数";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(459, 364);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(65, 12);
            this.label96.TabIndex = 6;
            this.label96.Text = "变频器计数";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(261, 364);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(65, 12);
            this.label58.TabIndex = 6;
            this.label58.Text = "变频器计数";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(63, 364);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 6;
            this.label23.Text = "变频器计数";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(859, 713);
            this.label200.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(53, 12);
            this.label200.TabIndex = 6;
            this.label200.Text = "设备状态";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(664, 713);
            this.label150.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(53, 12);
            this.label150.TabIndex = 6;
            this.label150.Text = "设备状态";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(459, 713);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(53, 12);
            this.label95.TabIndex = 6;
            this.label95.Text = "设备状态";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(261, 713);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(53, 12);
            this.label57.TabIndex = 6;
            this.label57.Text = "设备状态";
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Location = new System.Drawing.Point(459, 782);
            this.label276.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(89, 12);
            this.label276.TabIndex = 6;
            this.label276.Text = "电动阀开度反馈";
            // 
            // label270
            // 
            this.label270.AutoSize = true;
            this.label270.Location = new System.Drawing.Point(63, 782);
            this.label270.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(65, 12);
            this.label270.TabIndex = 6;
            this.label270.Text = "电动阀标志";
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.Location = new System.Drawing.Point(859, 782);
            this.label279.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(35, 12);
            this.label279.TabIndex = 6;
            this.label279.Text = "预留3";
            // 
            // label275
            // 
            this.label275.AutoSize = true;
            this.label275.Location = new System.Drawing.Point(664, 782);
            this.label275.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(77, 12);
            this.label275.TabIndex = 6;
            this.label275.Text = "2#电动阀状态";
            // 
            // label267
            // 
            this.label267.AutoSize = true;
            this.label267.Location = new System.Drawing.Point(261, 782);
            this.label267.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(77, 12);
            this.label267.TabIndex = 6;
            this.label267.Text = "阀前进水压力";
            // 
            // label274
            // 
            this.label274.AutoSize = true;
            this.label274.Location = new System.Drawing.Point(459, 759);
            this.label274.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(89, 12);
            this.label274.TabIndex = 6;
            this.label274.Text = "电动阀开度设定";
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Location = new System.Drawing.Point(63, 759);
            this.label269.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(65, 12);
            this.label269.TabIndex = 6;
            this.label269.Text = "液位等标志";
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Location = new System.Drawing.Point(859, 759);
            this.label278.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(41, 12);
            this.label278.TabIndex = 6;
            this.label278.Text = "2#液位";
            // 
            // label273
            // 
            this.label273.AutoSize = true;
            this.label273.Location = new System.Drawing.Point(664, 759);
            this.label273.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(77, 12);
            this.label273.TabIndex = 6;
            this.label273.Text = "1#电动阀状态";
            // 
            // label266
            // 
            this.label266.AutoSize = true;
            this.label266.Location = new System.Drawing.Point(261, 759);
            this.label266.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(53, 12);
            this.label266.TabIndex = 6;
            this.label266.Text = "输出开度";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(63, 713);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 12);
            this.label42.TabIndex = 6;
            this.label42.Text = "设备状态";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(859, 690);
            this.label199.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(53, 12);
            this.label199.TabIndex = 6;
            this.label199.Text = "停机状态";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(664, 690);
            this.label149.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(53, 12);
            this.label149.TabIndex = 6;
            this.label149.Text = "停机状态";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(459, 690);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(53, 12);
            this.label94.TabIndex = 6;
            this.label94.Text = "停机状态";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(261, 690);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(53, 12);
            this.label56.TabIndex = 6;
            this.label56.Text = "停机状态";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(63, 690);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(53, 12);
            this.label41.TabIndex = 6;
            this.label41.Text = "停机状态";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(859, 667);
            this.label198.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(65, 12);
            this.label198.TabIndex = 6;
            this.label198.Text = "2#电机温度";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(664, 667);
            this.label148.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(65, 12);
            this.label148.TabIndex = 6;
            this.label148.Text = "2#电机温度";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(459, 667);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(65, 12);
            this.label93.TabIndex = 6;
            this.label93.Text = "2#电机温度";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(261, 667);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 12);
            this.label55.TabIndex = 6;
            this.label55.Text = "2#电机温度";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(63, 667);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(65, 12);
            this.label39.TabIndex = 6;
            this.label39.Text = "2#电机温度";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(859, 644);
            this.label197.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(65, 12);
            this.label197.TabIndex = 6;
            this.label197.Text = "1#电机温度";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(664, 644);
            this.label147.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(65, 12);
            this.label147.TabIndex = 6;
            this.label147.Text = "1#电机温度";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(459, 644);
            this.label92.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(65, 12);
            this.label92.TabIndex = 6;
            this.label92.Text = "1#电机温度";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(261, 644);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 12);
            this.label54.TabIndex = 6;
            this.label54.Text = "1#电机温度";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(63, 644);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 6;
            this.label37.Text = "1#电机温度";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(859, 598);
            this.label196.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(53, 12);
            this.label196.TabIndex = 6;
            this.label196.Text = "出水压力";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(664, 598);
            this.label146.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(53, 12);
            this.label146.TabIndex = 6;
            this.label146.Text = "出水压力";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(459, 598);
            this.label91.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(53, 12);
            this.label91.TabIndex = 6;
            this.label91.Text = "出水压力";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(261, 598);
            this.label103.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(53, 12);
            this.label103.TabIndex = 6;
            this.label103.Text = "出水压力";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(859, 621);
            this.label195.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(53, 12);
            this.label195.TabIndex = 6;
            this.label195.Text = "设定压力";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(664, 621);
            this.label145.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(53, 12);
            this.label145.TabIndex = 6;
            this.label145.Text = "设定压力";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(459, 621);
            this.label90.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 12);
            this.label90.TabIndex = 6;
            this.label90.Text = "设定压力";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(261, 621);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(53, 12);
            this.label53.TabIndex = 6;
            this.label53.Text = "设定压力";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(63, 598);
            this.label102.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(53, 12);
            this.label102.TabIndex = 6;
            this.label102.Text = "出水压力";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(63, 621);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 6;
            this.label35.Text = "设定压力";
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(859, 574);
            this.label194.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(53, 12);
            this.label194.TabIndex = 6;
            this.label194.Text = "进水压力";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(664, 574);
            this.label144.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(53, 12);
            this.label144.TabIndex = 6;
            this.label144.Text = "进水压力";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(459, 574);
            this.label89.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 12);
            this.label89.TabIndex = 6;
            this.label89.Text = "进水压力";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(261, 574);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(53, 12);
            this.label52.TabIndex = 6;
            this.label52.Text = "进水压力";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(63, 574);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 12);
            this.label33.TabIndex = 6;
            this.label33.Text = "进水压力";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(63, 551);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 6;
            this.label31.Text = "频率";
            // 
            // textBox147
            // 
            this.textBox147.Location = new System.Drawing.Point(549, 776);
            this.textBox147.Margin = new System.Windows.Forms.Padding(2);
            this.textBox147.Name = "textBox147";
            this.textBox147.Size = new System.Drawing.Size(54, 21);
            this.textBox147.TabIndex = 20;
            // 
            // textBox109
            // 
            this.textBox109.Location = new System.Drawing.Point(940, 663);
            this.textBox109.Margin = new System.Windows.Forms.Padding(2);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(54, 21);
            this.textBox109.TabIndex = 20;
            // 
            // textBox150
            // 
            this.textBox150.Location = new System.Drawing.Point(940, 776);
            this.textBox150.Margin = new System.Windows.Forms.Padding(2);
            this.textBox150.Name = "textBox150";
            this.textBox150.Size = new System.Drawing.Size(54, 21);
            this.textBox150.TabIndex = 20;
            // 
            // textBox141
            // 
            this.textBox141.Location = new System.Drawing.Point(144, 776);
            this.textBox141.Margin = new System.Windows.Forms.Padding(2);
            this.textBox141.Name = "textBox141";
            this.textBox141.Size = new System.Drawing.Size(54, 21);
            this.textBox141.TabIndex = 20;
            // 
            // textBox146
            // 
            this.textBox146.Location = new System.Drawing.Point(745, 776);
            this.textBox146.Margin = new System.Windows.Forms.Padding(2);
            this.textBox146.Name = "textBox146";
            this.textBox146.Size = new System.Drawing.Size(54, 21);
            this.textBox146.TabIndex = 20;
            // 
            // textBox87
            // 
            this.textBox87.Location = new System.Drawing.Point(745, 663);
            this.textBox87.Margin = new System.Windows.Forms.Padding(2);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(54, 21);
            this.textBox87.TabIndex = 20;
            // 
            // textBox145
            // 
            this.textBox145.Location = new System.Drawing.Point(549, 753);
            this.textBox145.Margin = new System.Windows.Forms.Padding(2);
            this.textBox145.Name = "textBox145";
            this.textBox145.Size = new System.Drawing.Size(54, 21);
            this.textBox145.TabIndex = 20;
            // 
            // textBox138
            // 
            this.textBox138.Location = new System.Drawing.Point(342, 776);
            this.textBox138.Margin = new System.Windows.Forms.Padding(2);
            this.textBox138.Name = "textBox138";
            this.textBox138.Size = new System.Drawing.Size(54, 21);
            this.textBox138.TabIndex = 20;
            // 
            // textBox149
            // 
            this.textBox149.Location = new System.Drawing.Point(940, 753);
            this.textBox149.Margin = new System.Windows.Forms.Padding(2);
            this.textBox149.Name = "textBox149";
            this.textBox149.Size = new System.Drawing.Size(54, 21);
            this.textBox149.TabIndex = 20;
            // 
            // textBox140
            // 
            this.textBox140.Location = new System.Drawing.Point(144, 753);
            this.textBox140.Margin = new System.Windows.Forms.Padding(2);
            this.textBox140.Name = "textBox140";
            this.textBox140.Size = new System.Drawing.Size(54, 21);
            this.textBox140.TabIndex = 20;
            // 
            // textBox144
            // 
            this.textBox144.Location = new System.Drawing.Point(745, 753);
            this.textBox144.Margin = new System.Windows.Forms.Padding(2);
            this.textBox144.Name = "textBox144";
            this.textBox144.Size = new System.Drawing.Size(54, 21);
            this.textBox144.TabIndex = 20;
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(549, 663);
            this.textBox63.Margin = new System.Windows.Forms.Padding(2);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(54, 21);
            this.textBox63.TabIndex = 20;
            // 
            // textBox143
            // 
            this.textBox143.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox143.Location = new System.Drawing.Point(549, 730);
            this.textBox143.Margin = new System.Windows.Forms.Padding(2);
            this.textBox143.Name = "textBox143";
            this.textBox143.Size = new System.Drawing.Size(54, 21);
            this.textBox143.TabIndex = 20;
            // 
            // textBox137
            // 
            this.textBox137.Location = new System.Drawing.Point(342, 753);
            this.textBox137.Margin = new System.Windows.Forms.Padding(2);
            this.textBox137.Name = "textBox137";
            this.textBox137.Size = new System.Drawing.Size(54, 21);
            this.textBox137.TabIndex = 20;
            // 
            // textBox148
            // 
            this.textBox148.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox148.Location = new System.Drawing.Point(940, 730);
            this.textBox148.Margin = new System.Windows.Forms.Padding(2);
            this.textBox148.Name = "textBox148";
            this.textBox148.Size = new System.Drawing.Size(54, 21);
            this.textBox148.TabIndex = 20;
            // 
            // textBox139
            // 
            this.textBox139.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox139.Location = new System.Drawing.Point(144, 730);
            this.textBox139.Margin = new System.Windows.Forms.Padding(2);
            this.textBox139.Name = "textBox139";
            this.textBox139.Size = new System.Drawing.Size(54, 21);
            this.textBox139.TabIndex = 20;
            // 
            // textBox142
            // 
            this.textBox142.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox142.Location = new System.Drawing.Point(745, 730);
            this.textBox142.Margin = new System.Windows.Forms.Padding(2);
            this.textBox142.Name = "textBox142";
            this.textBox142.Size = new System.Drawing.Size(54, 21);
            this.textBox142.TabIndex = 20;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(342, 663);
            this.textBox38.Margin = new System.Windows.Forms.Padding(2);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(54, 21);
            this.textBox38.TabIndex = 20;
            // 
            // textBox136
            // 
            this.textBox136.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox136.Location = new System.Drawing.Point(342, 730);
            this.textBox136.Margin = new System.Windows.Forms.Padding(2);
            this.textBox136.Name = "textBox136";
            this.textBox136.Size = new System.Drawing.Size(54, 21);
            this.textBox136.TabIndex = 20;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(144, 663);
            this.textBox19.Margin = new System.Windows.Forms.Padding(2);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(54, 21);
            this.textBox19.TabIndex = 20;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(859, 528);
            this.label193.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(77, 12);
            this.label193.TabIndex = 6;
            this.label193.Text = "累计运行时间";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(664, 528);
            this.label143.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(77, 12);
            this.label143.TabIndex = 6;
            this.label143.Text = "累计运行时间";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(459, 528);
            this.label88.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(77, 12);
            this.label88.TabIndex = 6;
            this.label88.Text = "累计运行时间";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(261, 528);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(77, 12);
            this.label51.TabIndex = 6;
            this.label51.Text = "累计运行时间";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(63, 528);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 12);
            this.label29.TabIndex = 6;
            this.label29.Text = "累计运行时间";
            // 
            // textBox108
            // 
            this.textBox108.Location = new System.Drawing.Point(940, 640);
            this.textBox108.Margin = new System.Windows.Forms.Padding(2);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(54, 21);
            this.textBox108.TabIndex = 20;
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(745, 640);
            this.textBox86.Margin = new System.Windows.Forms.Padding(2);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(54, 21);
            this.textBox86.TabIndex = 20;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(549, 640);
            this.textBox62.Margin = new System.Windows.Forms.Padding(2);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(54, 21);
            this.textBox62.TabIndex = 20;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(342, 640);
            this.textBox37.Margin = new System.Windows.Forms.Padding(2);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(54, 21);
            this.textBox37.TabIndex = 20;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(144, 640);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(54, 21);
            this.textBox18.TabIndex = 20;
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(859, 505);
            this.label192.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(77, 12);
            this.label192.TabIndex = 6;
            this.label192.Text = "累计运行时间";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(664, 505);
            this.label142.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(77, 12);
            this.label142.TabIndex = 6;
            this.label142.Text = "累计运行时间";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(459, 505);
            this.label87.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(77, 12);
            this.label87.TabIndex = 6;
            this.label87.Text = "累计运行时间";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(261, 505);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 12);
            this.label50.TabIndex = 6;
            this.label50.Text = "累计运行时间";
            // 
            // textBox107
            // 
            this.textBox107.Location = new System.Drawing.Point(940, 594);
            this.textBox107.Margin = new System.Windows.Forms.Padding(2);
            this.textBox107.Name = "textBox107";
            this.textBox107.Size = new System.Drawing.Size(54, 21);
            this.textBox107.TabIndex = 20;
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(745, 594);
            this.textBox85.Margin = new System.Windows.Forms.Padding(2);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(54, 21);
            this.textBox85.TabIndex = 20;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(549, 594);
            this.textBox61.Margin = new System.Windows.Forms.Padding(2);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(54, 21);
            this.textBox61.TabIndex = 20;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(342, 594);
            this.textBox52.Margin = new System.Windows.Forms.Padding(2);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(54, 21);
            this.textBox52.TabIndex = 20;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(63, 505);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 12);
            this.label27.TabIndex = 6;
            this.label27.Text = "累计运行时间";
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(144, 594);
            this.textBox51.Margin = new System.Windows.Forms.Padding(2);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(54, 21);
            this.textBox51.TabIndex = 20;
            // 
            // textBox106
            // 
            this.textBox106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox106.Location = new System.Drawing.Point(940, 617);
            this.textBox106.Margin = new System.Windows.Forms.Padding(2);
            this.textBox106.Name = "textBox106";
            this.textBox106.Size = new System.Drawing.Size(54, 21);
            this.textBox106.TabIndex = 20;
            // 
            // textBox84
            // 
            this.textBox84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox84.Location = new System.Drawing.Point(745, 617);
            this.textBox84.Margin = new System.Windows.Forms.Padding(2);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(54, 21);
            this.textBox84.TabIndex = 20;
            // 
            // textBox60
            // 
            this.textBox60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox60.Location = new System.Drawing.Point(549, 617);
            this.textBox60.Margin = new System.Windows.Forms.Padding(2);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(54, 21);
            this.textBox60.TabIndex = 20;
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox36.Location = new System.Drawing.Point(342, 617);
            this.textBox36.Margin = new System.Windows.Forms.Padding(2);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(54, 21);
            this.textBox36.TabIndex = 20;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox17.Location = new System.Drawing.Point(144, 617);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(54, 21);
            this.textBox17.TabIndex = 20;
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(859, 482);
            this.label191.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(77, 12);
            this.label191.TabIndex = 6;
            this.label191.Text = "累计运行时间";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(664, 482);
            this.label141.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(77, 12);
            this.label141.TabIndex = 6;
            this.label141.Text = "累计运行时间";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(459, 482);
            this.label86.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(77, 12);
            this.label86.TabIndex = 6;
            this.label86.Text = "累计运行时间";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(261, 482);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 12);
            this.label49.TabIndex = 6;
            this.label49.Text = "累计运行时间";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(63, 482);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 6;
            this.label24.Text = "累计运行时间";
            // 
            // textBox105
            // 
            this.textBox105.Location = new System.Drawing.Point(940, 570);
            this.textBox105.Margin = new System.Windows.Forms.Padding(2);
            this.textBox105.Name = "textBox105";
            this.textBox105.Size = new System.Drawing.Size(54, 21);
            this.textBox105.TabIndex = 20;
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(745, 570);
            this.textBox83.Margin = new System.Windows.Forms.Padding(2);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(54, 21);
            this.textBox83.TabIndex = 20;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(549, 570);
            this.textBox59.Margin = new System.Windows.Forms.Padding(2);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(54, 21);
            this.textBox59.TabIndex = 20;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(342, 570);
            this.textBox35.Margin = new System.Windows.Forms.Padding(2);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(54, 21);
            this.textBox35.TabIndex = 20;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(144, 570);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(54, 21);
            this.textBox16.TabIndex = 20;
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(859, 318);
            this.label190.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(29, 12);
            this.label190.TabIndex = 6;
            this.label190.Text = "转速";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(664, 318);
            this.label140.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(29, 12);
            this.label140.TabIndex = 6;
            this.label140.Text = "转速";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(459, 318);
            this.label85.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(29, 12);
            this.label85.TabIndex = 6;
            this.label85.Text = "转速";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(261, 318);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(29, 12);
            this.label111.TabIndex = 6;
            this.label111.Text = "转速";
            // 
            // label248
            // 
            this.label248.AutoSize = true;
            this.label248.Location = new System.Drawing.Point(859, 341);
            this.label248.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(53, 12);
            this.label248.TabIndex = 6;
            this.label248.Text = "功率因数";
            // 
            // label246
            // 
            this.label246.AutoSize = true;
            this.label246.Location = new System.Drawing.Point(664, 341);
            this.label246.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(53, 12);
            this.label246.TabIndex = 6;
            this.label246.Text = "功率因数";
            // 
            // label243
            // 
            this.label243.AutoSize = true;
            this.label243.Location = new System.Drawing.Point(459, 341);
            this.label243.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(53, 12);
            this.label243.TabIndex = 6;
            this.label243.Text = "功率因数";
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(261, 341);
            this.label241.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(53, 12);
            this.label241.TabIndex = 6;
            this.label241.Text = "功率因数";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(63, 341);
            this.label239.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(53, 12);
            this.label239.TabIndex = 6;
            this.label239.Text = "功率因数";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 318);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 6;
            this.label21.Text = "转速";
            // 
            // textBox104
            // 
            this.textBox104.Location = new System.Drawing.Point(940, 547);
            this.textBox104.Margin = new System.Windows.Forms.Padding(2);
            this.textBox104.Name = "textBox104";
            this.textBox104.Size = new System.Drawing.Size(54, 21);
            this.textBox104.TabIndex = 20;
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(745, 547);
            this.textBox80.Margin = new System.Windows.Forms.Padding(2);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(54, 21);
            this.textBox80.TabIndex = 20;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(549, 547);
            this.textBox58.Margin = new System.Windows.Forms.Padding(2);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(54, 21);
            this.textBox58.TabIndex = 20;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(342, 547);
            this.textBox34.Margin = new System.Windows.Forms.Padding(2);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(54, 21);
            this.textBox34.TabIndex = 20;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(144, 547);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(54, 21);
            this.textBox15.TabIndex = 20;
            // 
            // textBox103
            // 
            this.textBox103.Location = new System.Drawing.Point(940, 383);
            this.textBox103.Margin = new System.Windows.Forms.Padding(2);
            this.textBox103.Name = "textBox103";
            this.textBox103.Size = new System.Drawing.Size(54, 21);
            this.textBox103.TabIndex = 20;
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(745, 383);
            this.textBox79.Margin = new System.Windows.Forms.Padding(2);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(54, 21);
            this.textBox79.TabIndex = 20;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(549, 383);
            this.textBox57.Margin = new System.Windows.Forms.Padding(2);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(54, 21);
            this.textBox57.TabIndex = 20;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(342, 383);
            this.textBox33.Margin = new System.Windows.Forms.Padding(2);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(54, 21);
            this.textBox33.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(144, 383);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(54, 21);
            this.textBox11.TabIndex = 20;
            // 
            // textBox102
            // 
            this.textBox102.Location = new System.Drawing.Point(940, 524);
            this.textBox102.Margin = new System.Windows.Forms.Padding(2);
            this.textBox102.Name = "textBox102";
            this.textBox102.Size = new System.Drawing.Size(54, 21);
            this.textBox102.TabIndex = 20;
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(745, 524);
            this.textBox78.Margin = new System.Windows.Forms.Padding(2);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(54, 21);
            this.textBox78.TabIndex = 20;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(549, 524);
            this.textBox56.Margin = new System.Windows.Forms.Padding(2);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(54, 21);
            this.textBox56.TabIndex = 20;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(342, 524);
            this.textBox32.Margin = new System.Windows.Forms.Padding(2);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(54, 21);
            this.textBox32.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(144, 524);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(54, 21);
            this.textBox14.TabIndex = 20;
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(859, 272);
            this.label189.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(29, 12);
            this.label189.TabIndex = 6;
            this.label189.Text = "电压";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(664, 272);
            this.label139.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(29, 12);
            this.label139.TabIndex = 6;
            this.label139.Text = "电压";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(459, 272);
            this.label84.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(29, 12);
            this.label84.TabIndex = 6;
            this.label84.Text = "电压";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(261, 272);
            this.label110.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(29, 12);
            this.label110.TabIndex = 6;
            this.label110.Text = "电压";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 272);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "电压";
            // 
            // textBox101
            // 
            this.textBox101.Location = new System.Drawing.Point(940, 501);
            this.textBox101.Margin = new System.Windows.Forms.Padding(2);
            this.textBox101.Name = "textBox101";
            this.textBox101.Size = new System.Drawing.Size(54, 21);
            this.textBox101.TabIndex = 20;
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(745, 501);
            this.textBox77.Margin = new System.Windows.Forms.Padding(2);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(54, 21);
            this.textBox77.TabIndex = 20;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(549, 501);
            this.textBox55.Margin = new System.Windows.Forms.Padding(2);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(54, 21);
            this.textBox55.TabIndex = 20;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(342, 501);
            this.textBox31.Margin = new System.Windows.Forms.Padding(2);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(54, 21);
            this.textBox31.TabIndex = 20;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(144, 501);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(54, 21);
            this.textBox13.TabIndex = 20;
            // 
            // textBox100
            // 
            this.textBox100.Location = new System.Drawing.Point(940, 360);
            this.textBox100.Margin = new System.Windows.Forms.Padding(2);
            this.textBox100.Name = "textBox100";
            this.textBox100.Size = new System.Drawing.Size(54, 21);
            this.textBox100.TabIndex = 20;
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(745, 360);
            this.textBox76.Margin = new System.Windows.Forms.Padding(2);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(54, 21);
            this.textBox76.TabIndex = 20;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(549, 360);
            this.textBox50.Margin = new System.Windows.Forms.Padding(2);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(54, 21);
            this.textBox50.TabIndex = 20;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(342, 360);
            this.textBox30.Margin = new System.Windows.Forms.Padding(2);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(54, 21);
            this.textBox30.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(144, 360);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(54, 21);
            this.textBox10.TabIndex = 20;
            // 
            // textBox99
            // 
            this.textBox99.Location = new System.Drawing.Point(940, 478);
            this.textBox99.Margin = new System.Windows.Forms.Padding(2);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(54, 21);
            this.textBox99.TabIndex = 20;
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(745, 478);
            this.textBox75.Margin = new System.Windows.Forms.Padding(2);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(54, 21);
            this.textBox75.TabIndex = 20;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(549, 478);
            this.textBox49.Margin = new System.Windows.Forms.Padding(2);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(54, 21);
            this.textBox49.TabIndex = 20;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(342, 478);
            this.textBox29.Margin = new System.Windows.Forms.Padding(2);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(54, 21);
            this.textBox29.TabIndex = 20;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(144, 478);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(54, 21);
            this.textBox12.TabIndex = 20;
            // 
            // textBox98
            // 
            this.textBox98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox98.Location = new System.Drawing.Point(940, 291);
            this.textBox98.Margin = new System.Windows.Forms.Padding(2);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(54, 21);
            this.textBox98.TabIndex = 20;
            // 
            // textBox74
            // 
            this.textBox74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox74.Location = new System.Drawing.Point(745, 291);
            this.textBox74.Margin = new System.Windows.Forms.Padding(2);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(54, 21);
            this.textBox74.TabIndex = 20;
            // 
            // textBox48
            // 
            this.textBox48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox48.Location = new System.Drawing.Point(549, 291);
            this.textBox48.Margin = new System.Windows.Forms.Padding(2);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(54, 21);
            this.textBox48.TabIndex = 20;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox28.Location = new System.Drawing.Point(342, 291);
            this.textBox28.Margin = new System.Windows.Forms.Padding(2);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(54, 21);
            this.textBox28.TabIndex = 20;
            // 
            // textBox130
            // 
            this.textBox130.Location = new System.Drawing.Point(940, 337);
            this.textBox130.Margin = new System.Windows.Forms.Padding(2);
            this.textBox130.Name = "textBox130";
            this.textBox130.Size = new System.Drawing.Size(54, 21);
            this.textBox130.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox8.Location = new System.Drawing.Point(144, 291);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 21);
            this.textBox8.TabIndex = 20;
            // 
            // textBox129
            // 
            this.textBox129.Location = new System.Drawing.Point(745, 337);
            this.textBox129.Margin = new System.Windows.Forms.Padding(2);
            this.textBox129.Name = "textBox129";
            this.textBox129.Size = new System.Drawing.Size(54, 21);
            this.textBox129.TabIndex = 20;
            // 
            // textBox97
            // 
            this.textBox97.Location = new System.Drawing.Point(940, 314);
            this.textBox97.Margin = new System.Windows.Forms.Padding(2);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(54, 21);
            this.textBox97.TabIndex = 20;
            // 
            // textBox128
            // 
            this.textBox128.Location = new System.Drawing.Point(549, 337);
            this.textBox128.Margin = new System.Windows.Forms.Padding(2);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(54, 21);
            this.textBox128.TabIndex = 20;
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(745, 314);
            this.textBox73.Margin = new System.Windows.Forms.Padding(2);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(54, 21);
            this.textBox73.TabIndex = 20;
            // 
            // textBox127
            // 
            this.textBox127.Location = new System.Drawing.Point(342, 337);
            this.textBox127.Margin = new System.Windows.Forms.Padding(2);
            this.textBox127.Name = "textBox127";
            this.textBox127.Size = new System.Drawing.Size(54, 21);
            this.textBox127.TabIndex = 20;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(549, 314);
            this.textBox47.Margin = new System.Windows.Forms.Padding(2);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(54, 21);
            this.textBox47.TabIndex = 20;
            // 
            // textBox126
            // 
            this.textBox126.Location = new System.Drawing.Point(144, 337);
            this.textBox126.Margin = new System.Windows.Forms.Padding(2);
            this.textBox126.Name = "textBox126";
            this.textBox126.Size = new System.Drawing.Size(54, 21);
            this.textBox126.TabIndex = 20;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(342, 314);
            this.textBox27.Margin = new System.Windows.Forms.Padding(2);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(54, 21);
            this.textBox27.TabIndex = 20;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(144, 314);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(54, 21);
            this.textBox9.TabIndex = 20;
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(859, 249);
            this.label188.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(53, 12);
            this.label188.TabIndex = 6;
            this.label188.Text = "累计流量";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(664, 249);
            this.label138.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(53, 12);
            this.label138.TabIndex = 6;
            this.label138.Text = "累计流量";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(459, 249);
            this.label83.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(53, 12);
            this.label83.TabIndex = 6;
            this.label83.Text = "累计流量";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(261, 249);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(53, 12);
            this.label48.TabIndex = 6;
            this.label48.Text = "累计流量";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 249);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "累计流量";
            // 
            // textBox96
            // 
            this.textBox96.Location = new System.Drawing.Point(940, 268);
            this.textBox96.Margin = new System.Windows.Forms.Padding(2);
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(54, 21);
            this.textBox96.TabIndex = 20;
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(745, 268);
            this.textBox72.Margin = new System.Windows.Forms.Padding(2);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(54, 21);
            this.textBox72.TabIndex = 20;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(549, 268);
            this.textBox46.Margin = new System.Windows.Forms.Padding(2);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(54, 21);
            this.textBox46.TabIndex = 20;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(342, 268);
            this.textBox26.Margin = new System.Windows.Forms.Padding(2);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(54, 21);
            this.textBox26.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(144, 268);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 21);
            this.textBox7.TabIndex = 20;
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(859, 226);
            this.label187.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(53, 12);
            this.label187.TabIndex = 6;
            this.label187.Text = "瞬时流量";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(664, 226);
            this.label137.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(53, 12);
            this.label137.TabIndex = 6;
            this.label137.Text = "瞬时流量";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(459, 226);
            this.label82.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(53, 12);
            this.label82.TabIndex = 6;
            this.label82.Text = "瞬时流量";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(261, 226);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(53, 12);
            this.label47.TabIndex = 6;
            this.label47.Text = "瞬时流量";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 226);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "瞬时流量";
            // 
            // textBox95
            // 
            this.textBox95.Location = new System.Drawing.Point(940, 245);
            this.textBox95.Margin = new System.Windows.Forms.Padding(2);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(54, 21);
            this.textBox95.TabIndex = 20;
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(745, 245);
            this.textBox71.Margin = new System.Windows.Forms.Padding(2);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(54, 21);
            this.textBox71.TabIndex = 20;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(549, 245);
            this.textBox45.Margin = new System.Windows.Forms.Padding(2);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(54, 21);
            this.textBox45.TabIndex = 20;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(342, 245);
            this.textBox25.Margin = new System.Windows.Forms.Padding(2);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(54, 21);
            this.textBox25.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 245);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 21);
            this.textBox6.TabIndex = 20;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(859, 180);
            this.label186.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(29, 12);
            this.label186.TabIndex = 6;
            this.label186.Text = "效率";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(664, 180);
            this.label136.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(29, 12);
            this.label136.TabIndex = 6;
            this.label136.Text = "效率";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(459, 180);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(29, 12);
            this.label81.TabIndex = 6;
            this.label81.Text = "效率";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(261, 180);
            this.label109.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(29, 12);
            this.label109.TabIndex = 6;
            this.label109.Text = "效率";
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(859, 203);
            this.label238.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(53, 12);
            this.label238.TabIndex = 6;
            this.label238.Text = "停机数量";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(664, 203);
            this.label235.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(53, 12);
            this.label235.TabIndex = 6;
            this.label235.Text = "停机数量";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(459, 203);
            this.label232.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(53, 12);
            this.label232.TabIndex = 6;
            this.label232.Text = "停机数量";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(261, 203);
            this.label228.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(53, 12);
            this.label228.TabIndex = 6;
            this.label228.Text = "停机数量";
            // 
            // label245
            // 
            this.label245.AutoSize = true;
            this.label245.Location = new System.Drawing.Point(63, 203);
            this.label245.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(53, 12);
            this.label245.TabIndex = 6;
            this.label245.Text = "停机数量";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(63, 180);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(29, 12);
            this.label44.TabIndex = 6;
            this.label44.Text = "效率";
            // 
            // textBox94
            // 
            this.textBox94.Location = new System.Drawing.Point(940, 222);
            this.textBox94.Margin = new System.Windows.Forms.Padding(2);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(54, 21);
            this.textBox94.TabIndex = 20;
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(745, 222);
            this.textBox70.Margin = new System.Windows.Forms.Padding(2);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(54, 21);
            this.textBox70.TabIndex = 20;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(549, 222);
            this.textBox44.Margin = new System.Windows.Forms.Padding(2);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(54, 21);
            this.textBox44.TabIndex = 20;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(342, 222);
            this.textBox24.Margin = new System.Windows.Forms.Padding(2);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(54, 21);
            this.textBox24.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 222);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(54, 21);
            this.textBox5.TabIndex = 20;
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.Location = new System.Drawing.Point(859, 65);
            this.label185.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(53, 12);
            this.label185.TabIndex = 6;
            this.label185.Text = "目标频率";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(664, 65);
            this.label135.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(53, 12);
            this.label135.TabIndex = 6;
            this.label135.Text = "目标频率";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(468, 65);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(53, 12);
            this.label80.TabIndex = 6;
            this.label80.Text = "目标频率";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(261, 65);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(53, 12);
            this.label46.TabIndex = 6;
            this.label46.Text = "目标频率";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Location = new System.Drawing.Point(859, 88);
            this.label184.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(53, 12);
            this.label184.TabIndex = 6;
            this.label184.Text = "输出电压";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(664, 88);
            this.label134.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(53, 12);
            this.label134.TabIndex = 6;
            this.label134.Text = "输出电压";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(468, 88);
            this.label79.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(53, 12);
            this.label79.TabIndex = 6;
            this.label79.Text = "输出电压";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(261, 88);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(53, 12);
            this.label113.TabIndex = 6;
            this.label113.Text = "输出电压";
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(859, 134);
            this.label237.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(77, 12);
            this.label237.TabIndex = 6;
            this.label237.Text = "变频故障代码";
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(664, 134);
            this.label234.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(77, 12);
            this.label234.TabIndex = 6;
            this.label234.Text = "变频故障代码";
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(459, 134);
            this.label231.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(77, 12);
            this.label231.TabIndex = 6;
            this.label231.Text = "变频故障代码";
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Location = new System.Drawing.Point(261, 134);
            this.label227.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(77, 12);
            this.label227.TabIndex = 6;
            this.label227.Text = "变频故障代码";
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(63, 134);
            this.label230.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(77, 12);
            this.label230.TabIndex = 6;
            this.label230.Text = "变频故障代码";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(63, 88);
            this.label107.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(53, 12);
            this.label107.TabIndex = 6;
            this.label107.Text = "输出电压";
            // 
            // textBox125
            // 
            this.textBox125.Location = new System.Drawing.Point(940, 199);
            this.textBox125.Margin = new System.Windows.Forms.Padding(2);
            this.textBox125.Name = "textBox125";
            this.textBox125.Size = new System.Drawing.Size(54, 21);
            this.textBox125.TabIndex = 20;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(63, 65);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 12);
            this.label45.TabIndex = 6;
            this.label45.Text = "目标频率";
            // 
            // textBox124
            // 
            this.textBox124.Location = new System.Drawing.Point(745, 199);
            this.textBox124.Margin = new System.Windows.Forms.Padding(2);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(54, 21);
            this.textBox124.TabIndex = 20;
            // 
            // textBox93
            // 
            this.textBox93.Location = new System.Drawing.Point(940, 176);
            this.textBox93.Margin = new System.Windows.Forms.Padding(2);
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(54, 21);
            this.textBox93.TabIndex = 20;
            // 
            // textBox123
            // 
            this.textBox123.Location = new System.Drawing.Point(549, 199);
            this.textBox123.Margin = new System.Windows.Forms.Padding(2);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(54, 21);
            this.textBox123.TabIndex = 20;
            // 
            // textBox69
            // 
            this.textBox69.Location = new System.Drawing.Point(745, 176);
            this.textBox69.Margin = new System.Windows.Forms.Padding(2);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(54, 21);
            this.textBox69.TabIndex = 20;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(549, 176);
            this.textBox43.Margin = new System.Windows.Forms.Padding(2);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(54, 21);
            this.textBox43.TabIndex = 20;
            // 
            // textBox122
            // 
            this.textBox122.Location = new System.Drawing.Point(342, 199);
            this.textBox122.Margin = new System.Windows.Forms.Padding(2);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(54, 21);
            this.textBox122.TabIndex = 20;
            // 
            // textBox120
            // 
            this.textBox120.Location = new System.Drawing.Point(940, 130);
            this.textBox120.Margin = new System.Windows.Forms.Padding(2);
            this.textBox120.Name = "textBox120";
            this.textBox120.Size = new System.Drawing.Size(54, 21);
            this.textBox120.TabIndex = 20;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(342, 176);
            this.textBox23.Margin = new System.Windows.Forms.Padding(2);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(54, 21);
            this.textBox23.TabIndex = 20;
            // 
            // textBox119
            // 
            this.textBox119.Location = new System.Drawing.Point(745, 130);
            this.textBox119.Margin = new System.Windows.Forms.Padding(2);
            this.textBox119.Name = "textBox119";
            this.textBox119.Size = new System.Drawing.Size(54, 21);
            this.textBox119.TabIndex = 20;
            // 
            // textBox92
            // 
            this.textBox92.Location = new System.Drawing.Point(940, 84);
            this.textBox92.Margin = new System.Windows.Forms.Padding(2);
            this.textBox92.Name = "textBox92";
            this.textBox92.Size = new System.Drawing.Size(54, 21);
            this.textBox92.TabIndex = 20;
            // 
            // textBox118
            // 
            this.textBox118.Location = new System.Drawing.Point(549, 130);
            this.textBox118.Margin = new System.Windows.Forms.Padding(2);
            this.textBox118.Name = "textBox118";
            this.textBox118.Size = new System.Drawing.Size(54, 21);
            this.textBox118.TabIndex = 20;
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(745, 84);
            this.textBox68.Margin = new System.Windows.Forms.Padding(2);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(54, 21);
            this.textBox68.TabIndex = 20;
            // 
            // textBox117
            // 
            this.textBox117.Location = new System.Drawing.Point(342, 130);
            this.textBox117.Margin = new System.Windows.Forms.Padding(2);
            this.textBox117.Name = "textBox117";
            this.textBox117.Size = new System.Drawing.Size(54, 21);
            this.textBox117.TabIndex = 20;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(549, 84);
            this.textBox42.Margin = new System.Windows.Forms.Padding(2);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(54, 21);
            this.textBox42.TabIndex = 20;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(342, 84);
            this.textBox54.Margin = new System.Windows.Forms.Padding(2);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(54, 21);
            this.textBox54.TabIndex = 20;
            // 
            // textBox121
            // 
            this.textBox121.Location = new System.Drawing.Point(144, 199);
            this.textBox121.Margin = new System.Windows.Forms.Padding(2);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(54, 21);
            this.textBox121.TabIndex = 20;
            // 
            // textBox116
            // 
            this.textBox116.Location = new System.Drawing.Point(144, 130);
            this.textBox116.Margin = new System.Windows.Forms.Padding(2);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(54, 21);
            this.textBox116.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 176);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 21);
            this.textBox4.TabIndex = 20;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(144, 84);
            this.textBox53.Margin = new System.Windows.Forms.Padding(2);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(54, 21);
            this.textBox53.TabIndex = 20;
            // 
            // textBox91
            // 
            this.textBox91.Location = new System.Drawing.Point(940, 61);
            this.textBox91.Margin = new System.Windows.Forms.Padding(2);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(54, 21);
            this.textBox91.TabIndex = 20;
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(745, 61);
            this.textBox67.Margin = new System.Windows.Forms.Padding(2);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(54, 21);
            this.textBox67.TabIndex = 20;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(549, 61);
            this.textBox41.Margin = new System.Windows.Forms.Padding(2);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(54, 21);
            this.textBox41.TabIndex = 20;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(342, 61);
            this.textBox22.Margin = new System.Windows.Forms.Padding(2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(54, 21);
            this.textBox22.TabIndex = 20;
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(859, 157);
            this.label236.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(53, 12);
            this.label236.TabIndex = 6;
            this.label236.Text = "软件版本";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 21);
            this.textBox1.TabIndex = 20;
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(664, 157);
            this.label233.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(53, 12);
            this.label233.TabIndex = 6;
            this.label233.Text = "软件版本";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Location = new System.Drawing.Point(859, 111);
            this.label183.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(77, 12);
            this.label183.TabIndex = 6;
            this.label183.Text = "合相有功电能";
            // 
            // label229
            // 
            this.label229.AutoSize = true;
            this.label229.Location = new System.Drawing.Point(459, 157);
            this.label229.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(53, 12);
            this.label229.TabIndex = 6;
            this.label229.Text = "软件版本";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(664, 111);
            this.label133.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(77, 12);
            this.label133.TabIndex = 6;
            this.label133.Text = "合相有功电能";
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Location = new System.Drawing.Point(261, 157);
            this.label226.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(53, 12);
            this.label226.TabIndex = 6;
            this.label226.Text = "软件版本";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(459, 111);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(77, 12);
            this.label78.TabIndex = 6;
            this.label78.Text = "合相有功电能";
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Location = new System.Drawing.Point(63, 157);
            this.label225.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(53, 12);
            this.label225.TabIndex = 6;
            this.label225.Text = "软件版本";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(261, 111);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(77, 12);
            this.label77.TabIndex = 6;
            this.label77.Text = "合相有功电能";
            // 
            // textBox115
            // 
            this.textBox115.Location = new System.Drawing.Point(940, 153);
            this.textBox115.Margin = new System.Windows.Forms.Padding(2);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(54, 21);
            this.textBox115.TabIndex = 20;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(63, 111);
            this.label132.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(77, 12);
            this.label132.TabIndex = 6;
            this.label132.Text = "合相有功电能";
            // 
            // textBox114
            // 
            this.textBox114.Location = new System.Drawing.Point(745, 153);
            this.textBox114.Margin = new System.Windows.Forms.Padding(2);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(54, 21);
            this.textBox114.TabIndex = 20;
            // 
            // textBox90
            // 
            this.textBox90.Location = new System.Drawing.Point(940, 107);
            this.textBox90.Margin = new System.Windows.Forms.Padding(2);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(54, 21);
            this.textBox90.TabIndex = 20;
            // 
            // textBox113
            // 
            this.textBox113.Location = new System.Drawing.Point(549, 153);
            this.textBox113.Margin = new System.Windows.Forms.Padding(2);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(54, 21);
            this.textBox113.TabIndex = 20;
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(745, 107);
            this.textBox66.Margin = new System.Windows.Forms.Padding(2);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(54, 21);
            this.textBox66.TabIndex = 20;
            // 
            // textBox112
            // 
            this.textBox112.Location = new System.Drawing.Point(342, 153);
            this.textBox112.Margin = new System.Windows.Forms.Padding(2);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(54, 21);
            this.textBox112.TabIndex = 20;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(549, 107);
            this.textBox40.Margin = new System.Windows.Forms.Padding(2);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(54, 21);
            this.textBox40.TabIndex = 20;
            // 
            // textBox111
            // 
            this.textBox111.Location = new System.Drawing.Point(144, 153);
            this.textBox111.Margin = new System.Windows.Forms.Padding(2);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(54, 21);
            this.textBox111.TabIndex = 20;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(342, 107);
            this.textBox21.Margin = new System.Windows.Forms.Padding(2);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(54, 21);
            this.textBox21.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 107);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 21);
            this.textBox3.TabIndex = 20;
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(859, 42);
            this.label182.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(77, 12);
            this.label182.TabIndex = 6;
            this.label182.Text = "合相有功功率";
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Location = new System.Drawing.Point(664, 42);
            this.label255.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(77, 12);
            this.label255.TabIndex = 6;
            this.label255.Text = "合相有功功率";
            // 
            // textBox89
            // 
            this.textBox89.Location = new System.Drawing.Point(940, 38);
            this.textBox89.Margin = new System.Windows.Forms.Padding(2);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(54, 21);
            this.textBox89.TabIndex = 20;
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Location = new System.Drawing.Point(468, 42);
            this.label257.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(77, 12);
            this.label257.TabIndex = 6;
            this.label257.Text = "合相有功功率";
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(745, 38);
            this.textBox65.Margin = new System.Windows.Forms.Padding(2);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(54, 21);
            this.textBox65.TabIndex = 20;
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Location = new System.Drawing.Point(261, 42);
            this.label259.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(77, 12);
            this.label259.TabIndex = 6;
            this.label259.Text = "合相有功功率";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(549, 38);
            this.textBox39.Margin = new System.Windows.Forms.Padding(2);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(54, 21);
            this.textBox39.TabIndex = 20;
            // 
            // label263
            // 
            this.label263.AutoSize = true;
            this.label263.Location = new System.Drawing.Point(859, 433);
            this.label263.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(59, 12);
            this.label263.TabIndex = 6;
            this.label263.Text = "进水液位1";
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Location = new System.Drawing.Point(664, 433);
            this.label260.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(59, 12);
            this.label260.TabIndex = 6;
            this.label260.Text = "进水液位1";
            // 
            // label293
            // 
            this.label293.AutoSize = true;
            this.label293.Location = new System.Drawing.Point(261, 433);
            this.label293.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label293.Name = "label293";
            this.label293.Size = new System.Drawing.Size(59, 12);
            this.label293.TabIndex = 6;
            this.label293.Text = "进水液位1";
            // 
            // textBox135
            // 
            this.textBox135.Location = new System.Drawing.Point(940, 429);
            this.textBox135.Margin = new System.Windows.Forms.Padding(2);
            this.textBox135.Name = "textBox135";
            this.textBox135.Size = new System.Drawing.Size(54, 21);
            this.textBox135.TabIndex = 20;
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Location = new System.Drawing.Point(459, 433);
            this.label294.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(59, 12);
            this.label294.TabIndex = 6;
            this.label294.Text = "进水液位1";
            // 
            // textBox134
            // 
            this.textBox134.Location = new System.Drawing.Point(745, 429);
            this.textBox134.Margin = new System.Windows.Forms.Padding(2);
            this.textBox134.Name = "textBox134";
            this.textBox134.Size = new System.Drawing.Size(54, 21);
            this.textBox134.TabIndex = 20;
            // 
            // label295
            // 
            this.label295.AutoSize = true;
            this.label295.Location = new System.Drawing.Point(63, 433);
            this.label295.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label295.Name = "label295";
            this.label295.Size = new System.Drawing.Size(59, 12);
            this.label295.TabIndex = 6;
            this.label295.Text = "进水液位1";
            // 
            // textBox132
            // 
            this.textBox132.Location = new System.Drawing.Point(342, 429);
            this.textBox132.Margin = new System.Windows.Forms.Padding(2);
            this.textBox132.Name = "textBox132";
            this.textBox132.Size = new System.Drawing.Size(54, 21);
            this.textBox132.TabIndex = 20;
            // 
            // textBox133
            // 
            this.textBox133.Location = new System.Drawing.Point(549, 429);
            this.textBox133.Margin = new System.Windows.Forms.Padding(2);
            this.textBox133.Name = "textBox133";
            this.textBox133.Size = new System.Drawing.Size(54, 21);
            this.textBox133.TabIndex = 20;
            // 
            // label296
            // 
            this.label296.AutoSize = true;
            this.label296.Location = new System.Drawing.Point(63, 42);
            this.label296.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label296.Name = "label296";
            this.label296.Size = new System.Drawing.Size(77, 12);
            this.label296.TabIndex = 6;
            this.label296.Text = "合相有功功率";
            // 
            // textBox131
            // 
            this.textBox131.Location = new System.Drawing.Point(144, 429);
            this.textBox131.Margin = new System.Windows.Forms.Padding(2);
            this.textBox131.Name = "textBox131";
            this.textBox131.Size = new System.Drawing.Size(54, 21);
            this.textBox131.TabIndex = 20;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(342, 38);
            this.textBox20.Margin = new System.Windows.Forms.Padding(2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(54, 21);
            this.textBox20.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 38);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 21);
            this.textBox2.TabIndex = 20;
            // 
            // lbl_No3
            // 
            this.lbl_No3.AutoSize = true;
            this.lbl_No3.Location = new System.Drawing.Point(503, 14);
            this.lbl_No3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_No3.Name = "lbl_No3";
            this.lbl_No3.Size = new System.Drawing.Size(53, 12);
            this.lbl_No3.TabIndex = 6;
            this.lbl_No3.Text = "3#双驱泵";
            // 
            // lbl_No2
            // 
            this.lbl_No2.AutoSize = true;
            this.lbl_No2.Location = new System.Drawing.Point(296, 14);
            this.lbl_No2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_No2.Name = "lbl_No2";
            this.lbl_No2.Size = new System.Drawing.Size(53, 12);
            this.lbl_No2.TabIndex = 6;
            this.lbl_No2.Text = "2#双驱泵";
            // 
            // lbl_No1
            // 
            this.lbl_No1.AutoSize = true;
            this.lbl_No1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_No1.Location = new System.Drawing.Point(99, 14);
            this.lbl_No1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_No1.Name = "lbl_No1";
            this.lbl_No1.Size = new System.Drawing.Size(53, 12);
            this.lbl_No1.TabIndex = 6;
            this.lbl_No1.Text = "1#双驱泵";
            // 
            // btn_QueryStatus_4_5
            // 
            this.btn_QueryStatus_4_5.Location = new System.Drawing.Point(19, 299);
            this.btn_QueryStatus_4_5.Name = "btn_QueryStatus_4_5";
            this.btn_QueryStatus_4_5.Size = new System.Drawing.Size(98, 32);
            this.btn_QueryStatus_4_5.TabIndex = 60;
            this.btn_QueryStatus_4_5.Text = "查询4-5#泵状态";
            this.btn_QueryStatus_4_5.Click += new System.EventHandler(this.btn_QueryStatus_4_5_Click);
            // 
            // btn_QueryStatus_1_3
            // 
            this.btn_QueryStatus_1_3.Location = new System.Drawing.Point(19, 118);
            this.btn_QueryStatus_1_3.Name = "btn_QueryStatus_1_3";
            this.btn_QueryStatus_1_3.Size = new System.Drawing.Size(98, 32);
            this.btn_QueryStatus_1_3.TabIndex = 59;
            this.btn_QueryStatus_1_3.Text = "查询1-3#泵状态";
            this.btn_QueryStatus_1_3.Click += new System.EventHandler(this.btn_QueryStatus_1_3_Click);
            // 
            // tabPage_Par
            // 
            this.tabPage_Par.Controls.Add(this.splitContainer4);
            this.tabPage_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Par.Name = "tabPage_Par";
            this.tabPage_Par.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Par.Size = new System.Drawing.Size(1309, 539);
            this.tabPage_Par.TabIndex = 2;
            this.tabPage_Par.Text = "设定参数";
            this.tabPage_Par.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer4.Panel1.Controls.Add(this.radioButton6);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton7);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton8);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton9);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton10);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton5);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton4);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer4.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer4.Panel1.Resize += new System.EventHandler(this.splitContainer4_Panel1_Resize);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(1303, 533);
            this.splitContainer4.SplitterDistance = 143;
            this.splitContainer4.TabIndex = 0;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(21, 216);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(101, 16);
            this.radioButton6.TabIndex = 9;
            this.radioButton6.Text = "参数[500-599]";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(21, 251);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(101, 16);
            this.radioButton7.TabIndex = 8;
            this.radioButton7.Text = "参数[600-699]";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(21, 286);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(101, 16);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "参数[700-799]";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(21, 321);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(101, 16);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.Text = "参数[800-899]";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(21, 356);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(101, 16);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.Text = "参数[900-999]";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(21, 181);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(101, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "参数[400-499]";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 146);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "参数[300-399]";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "参数[200-299]";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "参数[100-199]";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "参数[000-099]";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnToggle_Right);
            this.splitContainer5.Panel1.Controls.Add(this.tabControl2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.panelRight);
            this.splitContainer5.Size = new System.Drawing.Size(1156, 533);
            this.splitContainer5.SplitterDistance = 942;
            this.splitContainer5.TabIndex = 2;
            // 
            // btnToggle_Right
            // 
            this.btnToggle_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggle_Right.Location = new System.Drawing.Point(932, 0);
            this.btnToggle_Right.Name = "btnToggle_Right";
            this.btnToggle_Right.Size = new System.Drawing.Size(10, 533);
            this.btnToggle_Right.TabIndex = 69;
            this.btnToggle_Right.Text = "<";
            this.btnToggle_Right.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_No1_Par);
            this.tabControl2.Controls.Add(this.tabPage_No2_Par);
            this.tabControl2.Controls.Add(this.tabPage_No3_Par);
            this.tabControl2.Controls.Add(this.tabPage_No4_Par);
            this.tabControl2.Controls.Add(this.tabPage_No5_Par);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(942, 533);
            this.tabControl2.TabIndex = 2;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage_No1_Par
            // 
            this.tabPage_No1_Par.AutoScroll = true;
            this.tabPage_No1_Par.Controls.Add(this.dataGridView1);
            this.tabPage_No1_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_No1_Par.Name = "tabPage_No1_Par";
            this.tabPage_No1_Par.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_No1_Par.Size = new System.Drawing.Size(934, 507);
            this.tabPage_No1_Par.TabIndex = 0;
            this.tabPage_No1_Par.Text = "1#泵";
            this.tabPage_No1_Par.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 501);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabPage_No2_Par
            // 
            this.tabPage_No2_Par.Controls.Add(this.dataGridView2);
            this.tabPage_No2_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_No2_Par.Name = "tabPage_No2_Par";
            this.tabPage_No2_Par.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_No2_Par.Size = new System.Drawing.Size(934, 507);
            this.tabPage_No2_Par.TabIndex = 1;
            this.tabPage_No2_Par.Text = "2#泵";
            this.tabPage_No2_Par.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(928, 501);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView2_ColumnWidthChanged);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // tabPage_No3_Par
            // 
            this.tabPage_No3_Par.Controls.Add(this.dataGridView3);
            this.tabPage_No3_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_No3_Par.Name = "tabPage_No3_Par";
            this.tabPage_No3_Par.Size = new System.Drawing.Size(934, 507);
            this.tabPage_No3_Par.TabIndex = 2;
            this.tabPage_No3_Par.Text = "3#泵";
            this.tabPage_No3_Par.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(934, 507);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView3_CellFormatting);
            this.dataGridView3.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView3_ColumnWidthChanged);
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // tabPage_No4_Par
            // 
            this.tabPage_No4_Par.Controls.Add(this.dataGridView4);
            this.tabPage_No4_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_No4_Par.Name = "tabPage_No4_Par";
            this.tabPage_No4_Par.Size = new System.Drawing.Size(934, 507);
            this.tabPage_No4_Par.TabIndex = 3;
            this.tabPage_No4_Par.Text = "4#泵";
            this.tabPage_No4_Par.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(934, 507);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            this.dataGridView4.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView4_CellFormatting);
            this.dataGridView4.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView4_ColumnWidthChanged);
            this.dataGridView4.SelectionChanged += new System.EventHandler(this.dataGridView4_SelectionChanged);
            // 
            // tabPage_No5_Par
            // 
            this.tabPage_No5_Par.Controls.Add(this.dataGridView5);
            this.tabPage_No5_Par.Location = new System.Drawing.Point(4, 22);
            this.tabPage_No5_Par.Name = "tabPage_No5_Par";
            this.tabPage_No5_Par.Size = new System.Drawing.Size(934, 507);
            this.tabPage_No5_Par.TabIndex = 4;
            this.tabPage_No5_Par.Text = "5#泵";
            this.tabPage_No5_Par.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(934, 507);
            this.dataGridView5.TabIndex = 3;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            this.dataGridView5.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView5_CellFormatting);
            this.dataGridView5.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView5_ColumnWidthChanged);
            this.dataGridView5.SelectionChanged += new System.EventHandler(this.dataGridView5_SelectionChanged);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelRight.Controls.Add(this.panel_indicate_select);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(210, 533);
            this.panelRight.TabIndex = 2;
            this.panelRight.Resize += new System.EventHandler(this.panelRight_Resize);
            // 
            // panel_indicate_select
            // 
            this.panel_indicate_select.Controls.Add(this.groupBox3);
            this.panel_indicate_select.Controls.Add(this.groupBox_Select_Device);
            this.panel_indicate_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_indicate_select.Location = new System.Drawing.Point(0, 0);
            this.panel_indicate_select.Name = "panel_indicate_select";
            this.panel_indicate_select.Size = new System.Drawing.Size(210, 533);
            this.panel_indicate_select.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_QueryPar);
            this.groupBox3.Controls.Add(this.btn_clear_par_value);
            this.groupBox3.Controls.Add(this.btn_Save_par);
            this.groupBox3.Controls.Add(this.numericUpDown_ParValue);
            this.groupBox3.Controls.Add(this.lbl_parName);
            this.groupBox3.Controls.Add(this.lbl_par_address);
            this.groupBox3.Controls.Add(this.label_parValue);
            this.groupBox3.Controls.Add(this.btn_ModifyPar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 499);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作设备";
            // 
            // btn_QueryPar
            // 
            this.btn_QueryPar.Location = new System.Drawing.Point(45, 41);
            this.btn_QueryPar.Name = "btn_QueryPar";
            this.btn_QueryPar.Size = new System.Drawing.Size(88, 32);
            this.btn_QueryPar.TabIndex = 82;
            this.btn_QueryPar.Text = "查询参数";
            this.btn_QueryPar.Click += new System.EventHandler(this.btn_QueryPar_Click);
            // 
            // btn_clear_par_value
            // 
            this.btn_clear_par_value.Location = new System.Drawing.Point(45, 320);
            this.btn_clear_par_value.Name = "btn_clear_par_value";
            this.btn_clear_par_value.Size = new System.Drawing.Size(88, 32);
            this.btn_clear_par_value.TabIndex = 81;
            this.btn_clear_par_value.Text = "清除参数";
            // 
            // btn_Save_par
            // 
            this.btn_Save_par.Location = new System.Drawing.Point(45, 266);
            this.btn_Save_par.Name = "btn_Save_par";
            this.btn_Save_par.Size = new System.Drawing.Size(88, 32);
            this.btn_Save_par.TabIndex = 80;
            this.btn_Save_par.Text = "保存参数";
            this.btn_Save_par.Click += new System.EventHandler(this.btn_Save_par_Click);
            // 
            // numericUpDown_ParValue
            // 
            this.numericUpDown_ParValue.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_ParValue.Location = new System.Drawing.Point(45, 114);
            this.numericUpDown_ParValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_ParValue.Name = "numericUpDown_ParValue";
            this.numericUpDown_ParValue.Size = new System.Drawing.Size(88, 24);
            this.numericUpDown_ParValue.TabIndex = 79;
            // 
            // lbl_parName
            // 
            this.lbl_parName.AutoSize = true;
            this.lbl_parName.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_parName.ForeColor = System.Drawing.Color.Red;
            this.lbl_parName.Location = new System.Drawing.Point(43, 165);
            this.lbl_parName.Name = "lbl_parName";
            this.lbl_parName.Size = new System.Drawing.Size(38, 11);
            this.lbl_parName.TabIndex = 78;
            this.lbl_parName.Text = "参数名";
            // 
            // lbl_par_address
            // 
            this.lbl_par_address.AutoSize = true;
            this.lbl_par_address.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_par_address.ForeColor = System.Drawing.Color.Red;
            this.lbl_par_address.Location = new System.Drawing.Point(43, 148);
            this.lbl_par_address.Name = "lbl_par_address";
            this.lbl_par_address.Size = new System.Drawing.Size(49, 11);
            this.lbl_par_address.TabIndex = 77;
            this.lbl_par_address.Text = "参数地址";
            // 
            // label_parValue
            // 
            this.label_parValue.AutoSize = true;
            this.label_parValue.Location = new System.Drawing.Point(43, 96);
            this.label_parValue.Name = "label_parValue";
            this.label_parValue.Size = new System.Drawing.Size(53, 12);
            this.label_parValue.TabIndex = 76;
            this.label_parValue.Text = "参数值：";
            // 
            // btn_ModifyPar
            // 
            this.btn_ModifyPar.Location = new System.Drawing.Point(45, 205);
            this.btn_ModifyPar.Name = "btn_ModifyPar";
            this.btn_ModifyPar.Size = new System.Drawing.Size(88, 32);
            this.btn_ModifyPar.TabIndex = 75;
            this.btn_ModifyPar.Text = "修改参数";
            // 
            // groupBox_Select_Device
            // 
            this.groupBox_Select_Device.Controls.Add(this.label_PUMP_NO);
            this.groupBox_Select_Device.Controls.Add(this.label299);
            this.groupBox_Select_Device.Controls.Add(this.label_USER_NO);
            this.groupBox_Select_Device.Controls.Add(this.label298);
            this.groupBox_Select_Device.Controls.Add(this.label_DTU_NO);
            this.groupBox_Select_Device.Controls.Add(this.label297);
            this.groupBox_Select_Device.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Select_Device.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Select_Device.Name = "groupBox_Select_Device";
            this.groupBox_Select_Device.Size = new System.Drawing.Size(210, 112);
            this.groupBox_Select_Device.TabIndex = 79;
            this.groupBox_Select_Device.TabStop = false;
            this.groupBox_Select_Device.Text = "选择设备";
            // 
            // label_PUMP_NO
            // 
            this.label_PUMP_NO.AutoSize = true;
            this.label_PUMP_NO.Location = new System.Drawing.Point(70, 78);
            this.label_PUMP_NO.Name = "label_PUMP_NO";
            this.label_PUMP_NO.Size = new System.Drawing.Size(47, 12);
            this.label_PUMP_NO.TabIndex = 84;
            this.label_PUMP_NO.Text = "PUMP_NO";
            // 
            // label299
            // 
            this.label299.AutoSize = true;
            this.label299.Location = new System.Drawing.Point(11, 78);
            this.label299.Name = "label299";
            this.label299.Size = new System.Drawing.Size(53, 12);
            this.label299.TabIndex = 83;
            this.label299.Text = "泵  号：";
            // 
            // label_USER_NO
            // 
            this.label_USER_NO.AutoSize = true;
            this.label_USER_NO.Location = new System.Drawing.Point(70, 53);
            this.label_USER_NO.Name = "label_USER_NO";
            this.label_USER_NO.Size = new System.Drawing.Size(47, 12);
            this.label_USER_NO.TabIndex = 82;
            this.label_USER_NO.Text = "USER_NO";
            // 
            // label298
            // 
            this.label298.AutoSize = true;
            this.label298.Location = new System.Drawing.Point(11, 53);
            this.label298.Name = "label298";
            this.label298.Size = new System.Drawing.Size(53, 12);
            this.label298.TabIndex = 81;
            this.label298.Text = "用户名：";
            // 
            // label_DTU_NO
            // 
            this.label_DTU_NO.AutoSize = true;
            this.label_DTU_NO.Location = new System.Drawing.Point(70, 31);
            this.label_DTU_NO.Name = "label_DTU_NO";
            this.label_DTU_NO.Size = new System.Drawing.Size(41, 12);
            this.label_DTU_NO.TabIndex = 80;
            this.label_DTU_NO.Text = "DTU_NO";
            // 
            // label297
            // 
            this.label297.AutoSize = true;
            this.label297.Location = new System.Drawing.Point(11, 31);
            this.label297.Name = "label297";
            this.label297.Size = new System.Drawing.Size(53, 12);
            this.label297.TabIndex = 79;
            this.label297.Text = "DTU_NO：";
            // 
            // splitter6
            // 
            this.splitter6.Location = new System.Drawing.Point(0, 0);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(3, 662);
            this.splitter6.TabIndex = 32;
            this.splitter6.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(3, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1563, 3);
            this.splitter3.TabIndex = 31;
            this.splitter3.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 665);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(451, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 28;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.state_tssl,
            this.toolStripStatusLabel3,
            this.sendcount_tssl,
            this.toolStripStatusLabel5,
            this.recivecount_tssl,
            this.cleancount_tssl,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tssl_select_DTU_NO,
            this.toolStripStatusLabel4,
            this.tssl_select_USERNAME,
            this.toolStripStatusLabel6,
            this.tssl_select_pump_no});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1566, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // state_tssl
            // 
            this.state_tssl.Name = "state_tssl";
            this.state_tssl.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel3.Text = "  发送数据：";
            // 
            // sendcount_tssl
            // 
            this.sendcount_tssl.Name = "sendcount_tssl";
            this.sendcount_tssl.Size = new System.Drawing.Size(60, 17);
            this.sendcount_tssl.Text = "             ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel5.Text = "      接收数据：";
            // 
            // recivecount_tssl
            // 
            this.recivecount_tssl.Name = "recivecount_tssl";
            this.recivecount_tssl.Size = new System.Drawing.Size(64, 17);
            this.recivecount_tssl.Text = "              ";
            // 
            // cleancount_tssl
            // 
            this.cleancount_tssl.AutoSize = false;
            this.cleancount_tssl.Name = "cleancount_tssl";
            this.cleancount_tssl.Size = new System.Drawing.Size(100, 17);
            this.cleancount_tssl.Text = "清空计数";
            this.cleancount_tssl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cleancount_tssl.Click += new System.EventHandler(this.cleancount_tssl_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel2.Text = "选择DTU号：";
            // 
            // tssl_select_DTU_NO
            // 
            this.tssl_select_DTU_NO.Name = "tssl_select_DTU_NO";
            this.tssl_select_DTU_NO.Size = new System.Drawing.Size(120, 17);
            this.tssl_select_DTU_NO.Text = "tssl_select_DTU_NO";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel4.Text = "选择用户名：";
            // 
            // tssl_select_USERNAME
            // 
            this.tssl_select_USERNAME.Name = "tssl_select_USERNAME";
            this.tssl_select_USERNAME.Size = new System.Drawing.Size(0, 17);
            this.tssl_select_USERNAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel6.Text = "选择泵号：";
            // 
            // tssl_select_pump_no
            // 
            this.tssl_select_pump_no.Name = "tssl_select_pump_no";
            this.tssl_select_pump_no.Size = new System.Drawing.Size(0, 17);
            // 
            // timer_AutoSend
            // 
            this.timer_AutoSend.Interval = 1000;
            this.timer_AutoSend.Tick += new System.EventHandler(this.timer_AutoSend_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_clearMemory
            // 
            this.timer_clearMemory.Enabled = true;
            this.timer_clearMemory.Interval = 3000;
            this.timer_clearMemory.Tick += new System.EventHandler(this.timer_clearMemory_Tick_1);
            // 
            // timer_timeout
            // 
            this.timer_timeout.Enabled = true;
            this.timer_timeout.Interval = 1000;
            this.timer_timeout.Tick += new System.EventHandler(this.timer_timeout_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 794);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "MainFrm";
            this.Text = "ZGMS远程监控系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_Main.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_receive.ResumeLayout(false);
            this.tabPage_Status.ResumeLayout(false);
            this.splitContainer_status.Panel1.ResumeLayout(false);
            this.splitContainer_status.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_status)).EndInit();
            this.splitContainer_status.ResumeLayout(false);
            this.panel_device_status.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Par.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_No1_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage_No2_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage_No3_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage_No4_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage_No5_Par.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panel_indicate_select.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ParValue)).EndInit();
            this.groupBox_Select_Device.ResumeLayout(false);
            this.groupBox_Select_Device.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出_toolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel state_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel sendcount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel recivecount_tssl;
        private System.Windows.Forms.ToolStripStatusLabel cleancount_tssl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Timer timer_AutoSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_clearMemory;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timer_timeout;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richtxbox_tmp;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.ComboBox comboBox_receive_Mode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_Append_Time;
        private System.Windows.Forms.Button btn_Analy_Data;
        private System.Windows.Forms.Button btn_Clear_ReceiveZone;
        private System.Windows.Forms.CheckBox checkBox_SaveData2File;
        private System.Windows.Forms.CheckBox checkBox_Show_Only_Select;
        private System.Windows.Forms.CheckBox checkBox_NoScrollScreen;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_Send_Only_Select;
        private System.Windows.Forms.CheckBox chkBox_Append_CRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_reply;
        private System.Windows.Forms.CheckBox chkBox_TimeSend;
        private System.Windows.Forms.CheckBox chkBox_Send_16;
        private System.Windows.Forms.TextBox textBox_Send_interval_Time;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_clr_sendZone;
        private System.Windows.Forms.TextBox tbSend_zone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_autoStartService;
        private System.Windows.Forms.ComboBox comboBox_WorkMode;
        private System.Windows.Forms.Button btn_StartStopService;
        private System.Windows.Forms.TextBox tb_ServicePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListView listView_terminal;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_receive;
        private System.Windows.Forms.RichTextBox tb_receive_zone;
        private System.Windows.Forms.TabPage tabPage_Status;
        private System.Windows.Forms.TabPage tabPage_Par;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button btnToggle_Right;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_No1_Par;
        private System.Windows.Forms.TabPage tabPage_No2_Par;
        private System.Windows.Forms.TabPage tabPage_No3_Par;
        private System.Windows.Forms.TabPage tabPage_No4_Par;
        private System.Windows.Forms.TabPage tabPage_No5_Par;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.SplitContainer splitContainer_status;
        private System.Windows.Forms.Panel panel_device_status;
        private System.Windows.Forms.Button btnToggle_Right_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label277;
        private System.Windows.Forms.Label label271;
        private System.Windows.Forms.Label label272;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.Label label268;
        private System.Windows.Forms.Label label283;
        private System.Windows.Forms.Label label284;
        private System.Windows.Forms.Label label285;
        private System.Windows.Forms.Label label286;
        private System.Windows.Forms.Label label287;
        private System.Windows.Forms.Label label288;
        private System.Windows.Forms.Label label289;
        private System.Windows.Forms.Label label290;
        private System.Windows.Forms.Label label291;
        private System.Windows.Forms.Label label292;
        private System.Windows.Forms.TextBox textBox156;
        private System.Windows.Forms.TextBox textBox157;
        private System.Windows.Forms.TextBox textBox158;
        private System.Windows.Forms.TextBox textBox159;
        private System.Windows.Forms.TextBox textBox160;
        private System.Windows.Forms.TextBox textBox161;
        private System.Windows.Forms.TextBox textBox162;
        private System.Windows.Forms.TextBox textBox163;
        private System.Windows.Forms.TextBox textBox164;
        private System.Windows.Forms.TextBox textBox165;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label280;
        private System.Windows.Forms.TextBox textBox151;
        private System.Windows.Forms.Label label281;
        private System.Windows.Forms.TextBox textBox152;
        private System.Windows.Forms.Label label282;
        private System.Windows.Forms.TextBox textBox153;
        private System.Windows.Forms.TextBox textBox154;
        private System.Windows.Forms.TextBox textBox155;
        private System.Windows.Forms.Label lbl_No4;
        private System.Windows.Forms.Label lbl_No5;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.TextBox textBox110;
        private System.Windows.Forms.TextBox textBox88;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Label label247;
        private System.Windows.Forms.Label label244;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label276;
        private System.Windows.Forms.Label label270;
        private System.Windows.Forms.Label label279;
        private System.Windows.Forms.Label label275;
        private System.Windows.Forms.Label label267;
        private System.Windows.Forms.Label label274;
        private System.Windows.Forms.Label label269;
        private System.Windows.Forms.Label label278;
        private System.Windows.Forms.Label label273;
        private System.Windows.Forms.Label label266;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox147;
        private System.Windows.Forms.TextBox textBox109;
        private System.Windows.Forms.TextBox textBox150;
        private System.Windows.Forms.TextBox textBox141;
        private System.Windows.Forms.TextBox textBox146;
        private System.Windows.Forms.TextBox textBox87;
        private System.Windows.Forms.TextBox textBox145;
        private System.Windows.Forms.TextBox textBox138;
        private System.Windows.Forms.TextBox textBox149;
        private System.Windows.Forms.TextBox textBox140;
        private System.Windows.Forms.TextBox textBox144;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox143;
        private System.Windows.Forms.TextBox textBox137;
        private System.Windows.Forms.TextBox textBox148;
        private System.Windows.Forms.TextBox textBox139;
        private System.Windows.Forms.TextBox textBox142;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox136;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox108;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox107;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox106;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox105;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label248;
        private System.Windows.Forms.Label label246;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox104;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox130;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox129;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox128;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox127;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox126;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label245;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox textBox125;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox124;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.TextBox textBox123;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox122;
        private System.Windows.Forms.TextBox textBox120;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox119;
        private System.Windows.Forms.TextBox textBox92;
        private System.Windows.Forms.TextBox textBox118;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox117;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox121;
        private System.Windows.Forms.TextBox textBox116;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox textBox115;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox textBox114;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox113;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox112;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox111;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Label label293;
        private System.Windows.Forms.TextBox textBox135;
        private System.Windows.Forms.Label label294;
        private System.Windows.Forms.TextBox textBox134;
        private System.Windows.Forms.Label label295;
        private System.Windows.Forms.TextBox textBox132;
        private System.Windows.Forms.TextBox textBox133;
        private System.Windows.Forms.Label label296;
        private System.Windows.Forms.TextBox textBox131;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_No3;
        private System.Windows.Forms.Label lbl_No2;
        private System.Windows.Forms.Label lbl_No1;
        private System.Windows.Forms.Button btn_QueryStatus_1_3;
        private System.Windows.Forms.Button btn_QueryStatus_4_5;
        private Panel panel_indicate_select;
        private GroupBox groupBox_Select_Device;
        private Label label_USER_NO;
        private Label label298;
        private Label label_DTU_NO;
        private Label label297;
        private Label label_PUMP_NO;
        private Label label299;
        private GroupBox groupBox3;
        private Button btn_QueryPar;
        private Button btn_clear_par_value;
        private Button btn_Save_par;
        private NumericUpDown numericUpDown_ParValue;
        private Label lbl_parName;
        private Label lbl_par_address;
        private Label label_parValue;
        private Button btn_ModifyPar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel tssl_select_DTU_NO;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel tssl_select_USERNAME;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel tssl_select_pump_no;
    }
}

