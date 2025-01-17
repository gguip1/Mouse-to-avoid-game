﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class game_success : UserControl
    {
        public game_success()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // back 을 눌렀을 경우
            if (label == label2) {
                Form1.form1.level = 0;


                // select_level1.cs (레벨 선택 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
            }


            // retry 를 눌렀을 경우 stage_level1.cs (게임 화면) 로 이동
            if (label == label3) { Form1.form1.UserControlVisible(Form1.form1.stage_level1, this); }


            // next stage 를 눌렀을 경우
            if (label == label4)
            {
                if (Form1.form1.stage <= 3)
                {
                    if (Form1.form1.level > 5)
                    {
                        Form1.form1.stage++;
                        Form1.form1.level = 1;
                    }
                    else
                    {
                        Form1.form1.level++;
                    }


                    // stage_level1.cs (게임 화면) 로 이동
                    Form1.form1.UserControlVisible(Form1.form1.stage_level1, this);
                }
            }
            /*
             * 스테이지4 레벨1로 들어가지는 버그 있음
             * 
             * 조건문 고쳐야 함
             */
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}
