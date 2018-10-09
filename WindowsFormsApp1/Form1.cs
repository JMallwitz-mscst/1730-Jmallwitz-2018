using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;
       

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setMinButton_Click(object sender, EventArgs e)
        {
           
            byte1 = Byte.MinValue;  textBox1.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; textBox6.Text = sbyte1.ToString();
            short1 = Int16.MinValue; textBox9.Text = short1.ToString();
            ushort1 = UInt16.MinValue; textBox12.Text = ushort1.ToString();
            int1 = Int32.MinValue; textBox15.Text = int1.ToString();
            uint1 = UInt32.MinValue; textBox18.Text = uint1.ToString();
            long1 = Int64.MinValue; textBox21.Text = long1.ToString();
            ulong1 = UInt64.MinValue; textBox24.Text = ulong1.ToString();
            float1 = Single.MinValue; textBox27.Text = float1.ToString();
            double1 = Double.MinValue; textBox30.Text = double1.ToString();
            decimal1 = Decimal.MinValue; textBox33.Text = decimal1.ToString();
        }

        private void setMaxButton_Click(object sender, EventArgs e)
        {
           
            byte2 = Byte.MaxValue; textBox2.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; textBox4.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; textBox8.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; textBox11.Text = ushort2.ToString();
            int2 = Int32.MaxValue; textBox14.Text = int2.ToString();
            uint2 = UInt32.MaxValue; textBox17.Text = uint2.ToString();
            long2 = Int64.MaxValue; textBox20.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; textBox23.Text = ulong2.ToString();
            float2 = Single.MaxValue; textBox26.Text = float2.ToString();
            double2 = Double.MaxValue; textBox29.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; textBox32.Text = decimal2.ToString();
        }

        private void input1TextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                byte1 = Convert.ToByte(input1TextBox.Text);
                textBox1.Text = byte1.ToString();
            }
            catch (Exception) { textBox1.Text = "error"; byte1 = 0; }
                
                try
                {
                    sbyte1 = Convert.ToSByte(input1TextBox.Text);
                    textBox6.Text = sbyte1.ToString();
                }
            catch (Exception) { textBox6.Text = "error"; sbyte1 = 0; }
            try
            {
                short1 = Convert.ToInt16(input1TextBox.Text);
                textBox9.Text = short1.ToString();
            }
            catch (Exception) { textBox9.Text = "error"; short1 = 0; }
            try
            {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                textBox12.Text = ushort1.ToString();
            }
            catch (Exception) { textBox12.Text = "error"; ushort1 = 0; }

            try
            {
                int1 = Convert.ToInt32(input1TextBox.Text);
                textBox15.Text = int1.ToString();
            }
            catch (Exception) { textBox15.Text = "error"; int1 = 0; }

            try
            {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
                textBox18.Text = uint1.ToString();
            }
            catch (Exception) { textBox18.Text = "error"; uint1 = 0; }

            try
            {
                long1 = Convert.ToInt64(input1TextBox.Text);
                textBox21.Text = long1.ToString();
            }
            catch (Exception) { textBox21.Text = "error"; long1 = 0; }

            try
            {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                textBox24.Text = ulong1.ToString();
            }
            catch (Exception) { textBox24.Text = "error"; ulong1 = 0; }

            try
            {
                float1 = Convert.ToSingle(input1TextBox.Text);
                textBox27.Text = float1.ToString();
            }
            catch (Exception) { textBox27.Text = "error"; float1 = 0.0f; }

            try
            {
                double1 = Convert.ToDouble(input1TextBox.Text);
                textBox30.Text = double1.ToString();
            }
            catch (Exception) { textBox30.Text = "error"; double1 = 0.0; }

            try
            {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                textBox33.Text = decimal1.ToString();
            }
            catch (Exception) { textBox33.Text = "error"; decimal1 = 0m; }
        }
        private void input2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2TextBox.Text);
                textBox2.Text = byte2.ToString();
            }

            catch (Exception) { textBox2.Text = "error"; byte2 = 0; }

            try
            {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                textBox4.Text = sbyte2.ToString();
            }
            catch (Exception) { textBox4.Text = "error"; sbyte2 = 0; }

            try
            {
                short2 = Convert.ToInt16(input2TextBox.Text);
                textBox8.Text = short2.ToString();
            }
            catch (Exception) { textBox8.Text = "error"; short2 = 0; }

            try
            {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                textBox11.Text = ushort2.ToString();
            }
            catch (Exception) { textBox11.Text = "error"; ushort2 = 0; }

            try
            {
                int2 = Convert.ToInt32(input2TextBox.Text);
                textBox14.Text = int2.ToString();
            }
            catch (Exception) { textBox14.Text = "error"; int2 = 0; }

            try
            {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                textBox17.Text = uint2.ToString();
            }
            catch (Exception) { textBox17.Text = "error"; uint2 = 0; }

            try
            {
                long2 = Convert.ToInt64(input2TextBox.Text);
                textBox20.Text = long2.ToString();
            }
            catch (Exception) { textBox20.Text = "error"; long2 = 0; }

            try
            {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                textBox23.Text = ulong2.ToString();
            }
            catch (Exception) { textBox23.Text = "error"; ulong2 = 0; }

            try
            {
                float2 = Convert.ToSingle(input1TextBox.Text);
                textBox26.Text = float2.ToString();
            }
            catch (Exception) { textBox26.Text = "error"; float2 = 0.0f; }

            try
            {
                double2 = Convert.ToDouble(input2TextBox.Text);
                textBox29.Text = double2.ToString();
            }
            catch (Exception) { textBox29.Text = "error"; double2 = 0.0; }

            try
            {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                textBox32.Text = decimal2.ToString();
            }
            catch (Exception) { textBox32.Text = "error"; decimal2 = 0m; }
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                textBox5.Text = byte3.ToString();
            }
            catch (Exception) { textBox5.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                textBox3.Text = sbyte3.ToString();
            }
            catch (Exception) { textBox3.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                textBox7.Text = short3.ToString();
            }
            catch (Exception) { textBox7.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                textBox10.Text = ushort3.ToString();
            }
            catch (Exception) { textBox10.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 + this.int2);
                textBox13.Text = int3.ToString();
            }
            catch (Exception) { textBox13.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                textBox16.Text = uint3.ToString();
            }
            catch (Exception) { textBox16.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 + this.long2);
                textBox19.Text = long3.ToString();
            }
            catch (Exception) { textBox19.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                textBox22.Text = ulong3.ToString();
            }
            catch (Exception) { textBox22.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 + this.float2);
                textBox25.Text = float3.ToString();
            }
            catch (Exception) { textBox25.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 + this.double2);
                textBox28.Text = double3.ToString();
            }
            catch (Exception) { textBox28.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                textBox31.Text = decimal3.ToString();
            }
            catch (Exception) { textBox31.Text = "error"; }
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                textBox5.Text = byte3.ToString();
            }
            catch (Exception) { textBox5.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                textBox3.Text = sbyte3.ToString();
            }
            catch (Exception) { textBox3.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                textBox7.Text = short3.ToString();
            }
            catch (Exception) { textBox7.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                textBox10.Text = ushort3.ToString();
            }
            catch (Exception) { textBox10.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 - this.int2);
                textBox13.Text = int3.ToString();
            }
            catch (Exception) { textBox13.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                textBox16.Text = uint3.ToString();
            }
            catch (Exception) { textBox16.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 - this.long2);
                textBox19.Text = long3.ToString();
            }
            catch (Exception) { textBox19.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                textBox22.Text = ulong3.ToString();
            }
            catch (Exception) { textBox22.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 - this.float2);
                textBox25.Text = float3.ToString();
            }
            catch (Exception) { textBox25.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 - this.double2);
                textBox28.Text = double3.ToString();
            }
            catch (Exception) { textBox28.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                textBox31.Text = decimal3.ToString();
            }
            catch (Exception) { textBox31.Text = "error"; }
        }
        private void multiplybutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                textBox5.Text = byte3.ToString();
            }
            catch (Exception) { textBox5.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                textBox3.Text = sbyte3.ToString();
            }
            catch (Exception) { textBox3.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                textBox7.Text = short3.ToString();
            }
            catch (Exception) { textBox7.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                textBox10.Text = ushort3.ToString();
            }
            catch (Exception) { textBox10.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 * this.int2);
                textBox13.Text = int3.ToString();
            }
            catch (Exception) { textBox13.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                textBox16.Text = uint3.ToString();
            }
            catch (Exception) { textBox16.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 * this.long2);
                textBox19.Text = long3.ToString();
            }
            catch (Exception) { textBox19.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                textBox22.Text = ulong3.ToString();
            }
            catch (Exception) { textBox22.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 * this.float2);
                textBox25.Text = float3.ToString();
            }
            catch (Exception) { textBox25.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 * this.double2);
                textBox28.Text = double3.ToString();
            }
            catch (Exception) { textBox28.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                textBox31.Text = decimal3.ToString();
            }
            catch (Exception) { textBox31.Text = "error"; }
        }
        private void dividebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                textBox5.Text = byte3.ToString();
            }
            catch (Exception) { textBox5.Text = "error"; }

            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                textBox3.Text = sbyte3.ToString();
            }
            catch (Exception) { textBox3.Text = "error"; }

            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                textBox7.Text = short3.ToString();
            }
            catch (Exception) { textBox7.Text = "error"; }

            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                textBox10.Text = ushort3.ToString();
            }
            catch (Exception) { textBox10.Text = "error"; }

            try
            {
                this.int3 = checked(this.int1 / this.int2);
                textBox13.Text = int3.ToString();
            }
            catch (Exception) { textBox13.Text = "error"; }

            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                textBox16.Text = uint3.ToString();
            }
            catch (Exception) { textBox16.Text = "error"; }

            try
            {
                this.long3 = checked(this.long1 / this.long2);
                textBox19.Text = long3.ToString();
            }
            catch (Exception) { textBox19.Text = "error"; }

            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                textBox22.Text = ulong3.ToString();
            }
            catch (Exception) { textBox22.Text = "error"; }

            try
            {
                this.float3 = checked(this.float1 / this.float2);
                textBox25.Text = float3.ToString();
            }
            catch (Exception) { textBox25.Text = "error"; }

            try
            {
                this.double3 = checked(this.double1 / this.double2);
                textBox28.Text = double3.ToString();
            }
            catch (Exception) { textBox28.Text = "error"; }

            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                textBox31.Text = decimal3.ToString();
            }
            catch (Exception) { textBox31.Text = "error"; }
        }
    }
}
