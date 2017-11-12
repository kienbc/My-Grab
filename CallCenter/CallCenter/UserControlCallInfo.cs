﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenter
{
    public partial class UserControlCallInfo : UserControl
    {
        public UserControlCallInfo()
        {
            InitializeComponent();
        }

        public UserControlCallInfo(CallInfo call)
        {
            InitializeComponent();
            this.labelTime.Text = call.CallDate.ToString(ConstantValue.DATETIME_FORMAT);
            this.labelStatus.Text = GetStatusMeaning(call.Status);
            this.labelStatus.ForeColor = GetStatusColor(call.Status);
            this.labelAddress.Text = call.Address;
        }

        private Color GetStatusColor(int status)
        {
            if (status == ConstantValue.UNLOCATED)
                return Color.Orange;
            else if (status == ConstantValue.FINDING_CAR)
                return Color.Blue;
            else if (status == ConstantValue.NO_CAR)
                return Color.Violet;
            else if (status == ConstantValue.DONE)
                return Color.Green;

            return Color.Black;
        }

        private string GetStatusMeaning(int status)
        {
            if (status == ConstantValue.UNLOCATED)
                return "Chưa xác định tọa độ";
            else if (status == ConstantValue.FINDING_CAR)
                return "Đang tìm xe";
            else if (status == ConstantValue.NO_CAR)
                return "Không có xe nhận";
            else if (status == ConstantValue.DONE)
                return "Đặt thành công";

            return "";
        }
        private void UserControlCallInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
