using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;

namespace doan_vxl
{
    public partial class Form1 : Form
    {
        int MAX = 0;
        int MIN = 100;
        int CountLinePoint = 0;
        double TB = 0;
        public Form1()
        {
            InitializeComponent();
            MAX = 0; MIN = 100;
            CountLinePoint = 0; TB = 0;
        }
        string[] Baud = { "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
        string[] databit = { "5", "6", "7", "8" };
        public string dataLED = "00000000";
        public Color LEDColorButton(int LEDnum)
        {
            if (dataLED[LEDnum] == '1')
                return Color.Yellow;
            else
                return DefaultBackColor;
        }
        public void SetLEDColor()
        {
            btnLED0.BackColor = LEDColorButton(0);
            btnLED1.BackColor = LEDColorButton(1);
            btnLED2.BackColor = LEDColorButton(2);
            btnLED3.BackColor = LEDColorButton(3);
            btnLED4.BackColor = LEDColorButton(4);
            btnLED5.BackColor = LEDColorButton(5);
            btnLED6.BackColor = LEDColorButton(6);
            btnLED7.BackColor = LEDColorButton(7);
        }
        public void TurnOnOffLED(int LEDnum)
        {
            char[] dataLEDarray = dataLED.ToCharArray();
            if (LEDnum >= 0 && LEDnum < dataLEDarray.Length)
            {
                // Đảo kí tự tại vị trí LEDnum
                if (dataLEDarray[LEDnum] == '1')
                {
                    dataLEDarray[LEDnum] = '0';
                }
                else if (dataLEDarray[LEDnum] == '0')
                {
                    dataLEDarray[LEDnum] = '1';
                }    
                // Chuyển đổi mảng kí tự thành chuỗi
                dataLED = new string(dataLEDarray);
            }
            SetLEDColor();
            SerialPort1.Write(dataLED);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane bieudo = BieuDo.GraphPane;
            bieudo.Title.Text = "Biểu đồ nhiệt độ";
            bieudo.XAxis.Title.Text = "thời gian";
            bieudo.YAxis.Title.Text = "giá trị";
            RollingPointPairList list1 = new RollingPointPairList(60000);// tạo danh sách dữ liệu chứa 60000 phần từ
            
            LineItem lineTEMPERATURE = bieudo.AddCurve("Nhiệt Độ", list1, Color.Black, SymbolType.Circle);
            
            bieudo.XAxis.Scale.Min = 0;
            bieudo.XAxis.Scale.Max = 100;
            bieudo.XAxis.Scale.MinorStep = 1;// thiết lập khoẳng cách nhỏ nhất giữa 2 đường thẳng đứng ( bước nhỏ)
            bieudo.XAxis.Scale.MajorStep = 5;// thiết lập khoảng cách lớn nhất giữa 2 đường thẳng đứng ( bước lớn)
            bieudo.YAxis.Scale.Min = 0;
            bieudo.YAxis.Scale.Max = 100;
            bieudo.YAxis.Scale.MinorStep = 1;
            bieudo.YAxis.Scale.MajorStep = 5;
            BieuDo.AxisChange();// thay đổi giá trị của trục
            // khai báo uart
            string[] myPort = SerialPort.GetPortNames();// lấy tên các Port có  trong máy để add vào cmb_Port
            cmb_Port.Items.AddRange(myPort);
            cmb_BaudRate.Items.AddRange(Baud);
            cmb_DataBit.Items.AddRange(databit);
            cmb_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
        }
        int tong = 0;
        // vẽ biểu đồ 
        public void vebieudo(double lineTEMPERATURE_value)
        {
            LineItem lineTEMPARATURE = BieuDo.GraphPane.CurveList[0] as LineItem;// là một danh sách các đường trên đồ thị sau đó đc ép kiểu trả về
            //LineItem duongline2 = BieuDo.GraphPane.CurveList[1] as LineItem;
            if (lineTEMPARATURE == null) // kiểm tra có đường nào vẽ trên đồ thị hay không nếu không thì dừng lại (nếu không có điều kiện này sẽ gây ra lỗi do các lệnh phía sau không được thực thi)
                return;
            
            IPointListEdit lstTEMP = lineTEMPARATURE.Points as IPointListEdit;// khai báo danh sách dữ liệu đường cong đồ thị
            
            if (lstTEMP == null)
                return;
            
            lstTEMP.Add(tong, lineTEMPERATURE_value);// tong là đại diện cho trục x line1 line2 là điểm mình cần vẽ
            
            BieuDo.AxisChange();
            BieuDo.Invalidate();
            tong++;

        }
        // tạo nút kết nối
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                
                SerialPort1.PortName = cmb_Port.Text;
                SerialPort1.BaudRate = int.Parse(cmb_BaudRate.Text);
                SerialPort1.DataBits = int.Parse(cmb_DataBit.Text);
                SerialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cmb_Parity.Text);
                SerialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmb_StopBit.Text);
                SerialPort1.DataReceived += SerialPort1_DataReceived;
                SerialPort1.Open();
                progressBar1.Value = 100;
                btn_Connect.Enabled = false;
                btn_Disconnect.Enabled = true;
                btnClean.Enabled = false;
                MessageBox.Show("Đã kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                dataLED = "00000000";
                SetLEDColor();
                SerialPort1.Write(dataLED);
                SerialPort1.Close();
                progressBar1.Value = 0;
                btn_Connect.Enabled = true;
                btn_Disconnect.Enabled = false;
                btnClean .Enabled = true;
                MessageBox.Show("Đã ngắt kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        string data = "";
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data += SerialPort1.ReadExisting();
            if (data.Length > 3)
            {
                Invoke(new MethodInvoker(() => txtCurrentData.Text = data + " °C"));
                try
                {
                    // Xử lý dữ liệu để vẽ biểu đồ
                    double lineTEMPERATURE_value = double.Parse(data); // Giả sử dữ liệu nhận được là một giá trị số
                    vebieudo(lineTEMPERATURE_value); // Vẽ biểu đồ với giá trị nhận được
                    data = "";
                    Invoke(new MethodInvoker(() =>
                    {
                        if (lineTEMPERATURE_value > MAX)
                        {
                            MAX = (int)lineTEMPERATURE_value;
                            txtMaxValue.Text = MAX.ToString();
                        }

                        if (lineTEMPERATURE_value < MIN)
                        {
                            MIN = (int)lineTEMPERATURE_value;
                            txtMinValue.Text = MIN.ToString();
                        }
                        TB = (TB * CountLinePoint + lineTEMPERATURE_value) / (CountLinePoint + 1);
                        CountLinePoint++;
                        double TBround = Math.Round(TB, 3);
                        txtTBValue.Text = TBround.ToString();
                    }));
                    
                }
                catch
                {
                    try
                    {
                        dataLED = "00000000";
                        SetLEDColor();
                        SerialPort1.Write(dataLED);
                        SerialPort1.Close();
                        progressBar1.Value = 0;
                        btn_Connect.Enabled = true;
                        btn_Disconnect.Enabled = false;
                        MessageBox.Show("Ngắt kết nối do lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SerialPort1.Write(txt_Send.Text);
            MessageBox.Show("Dữ liệu đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txtCurrentData.Clear();
        }
        private void btnAllON_Click(object sender, EventArgs e)
        {
            dataLED = "11111111";
            SetLEDColor();
            SerialPort1.Write(dataLED);
        }

        private void btnAllOFF_Click(object sender, EventArgs e)
        {
            dataLED = "00000000";
            SetLEDColor();
            SerialPort1.Write(dataLED);
        }

        private void btnLED0_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(0);
        }
        private void btnLED1_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(1);
        }
        private void btnLED2_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(2);
        }

        private void btnLED3_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(3);
        }

        private void btnLED4_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(4);
        }

        private void btnLED5_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(5);
        }

        private void btnLED6_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(6);
        }

        private void btnLED7_Click(object sender, EventArgs e)
        {
            TurnOnOffLED(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmb_Port.SelectedIndex = 1;
            cmb_BaudRate.SelectedIndex = 3;
            cmb_DataBit.SelectedIndex = 3;
            cmb_Parity.SelectedIndex = 0;
            cmb_StopBit.SelectedIndex = 0;
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCurrentData.Clear();
            txtMaxValue.Clear();
            txtMinValue.Clear();
            txtTBValue.Clear();
            MAX = 0;
            MIN = 100;
            TB = 0;
            CountLinePoint = 0;
            LineItem duongLine1 = BieuDo.GraphPane.CurveList[0] as LineItem;
            if (duongLine1 != null)
            {
                IPointListEdit list1 = duongLine1.Points as IPointListEdit;
                if (list1 != null)
                {
                    list1.Clear();
                    BieuDo.AxisChange();
                    BieuDo.Invalidate();
                }
            }
        }
    }

}