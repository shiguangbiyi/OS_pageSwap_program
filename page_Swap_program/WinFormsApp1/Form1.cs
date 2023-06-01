using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static int[] visited = new int[320]; // 标记数组，用于记录是否已遍历过
        int page_fault_num = 0;//缺页数 
        double page_fault_rate = 0;//缺页率
        int currentPosition = -1; // 当前所在位置，初始为-1
        int Execution_Status = 0;//指令执行方式：顺序执行，随机执行，混合执行
        int[] memory_block = Enumerable.Repeat(-1, 4).ToArray();//用来记录内存块中每个块装载的页号
        int block_pointer = 0;//FIFO算法指针
        int[] time_block = Enumerable.Repeat(-1, 4).ToArray();//用来记录内存块中的页在内存中存留时间，用于LRU算法
        int Excution_times = 0;//用来记录执行指令数
        bool page_fault = true; //用来记录是否缺页
        public Form1()
        {
            this.Text = "请求调页存储管理方式模拟";
            InitializeComponent();
        }
        public void LabelInit()
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button19.BackColor = Color.White;
            button20.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button23.BackColor = Color.White;
            button24.BackColor = Color.White;
            button25.BackColor = Color.White;
            button26.BackColor = Color.White;
            button27.BackColor = Color.White;
            button28.BackColor = Color.White;
            button29.BackColor = Color.White;
            button30.BackColor = Color.White;
            button31.BackColor = Color.White;
            button32.BackColor = Color.White;
            button33.BackColor = Color.White;
            button34.BackColor = Color.White;
            button35.BackColor = Color.White;
            button36.BackColor = Color.White;
            button37.BackColor = Color.White;
            button38.BackColor = Color.White;
            button39.BackColor = Color.White;
            button40.BackColor = Color.White;
            button41.BackColor = Color.White;
            button42.BackColor = Color.White;
            button43.BackColor = Color.White;
        }
        public void Initial()
        {
            visited = Enumerable.Repeat(0, 320).ToArray();
            page_fault_num = 0;
            page_fault_rate = 0;
            Excution_times = 0;
            currentPosition = -1;
            block_pointer = 0;
            timer1.Stop();
            memory_block = Enumerable.Repeat(-1, 4).ToArray();
            time_block = Enumerable.Repeat(-1, 4).ToArray();
            textBox1.Text = "第X页";
            textBox2.Text = "第X页";
            textBox3.Text = "第X页";
            textBox4.Text = "第X页";
            textBox7.Text = "驻留X周期";
            textBox8.Text = "驻留X周期";
            textBox9.Text = "驻留X周期";
            textBox10.Text = "驻留X周期";
            textBox11.Text = "";
            textBox5.Text = "0";
            textBox6.Text = "0";
            button2.Text = "连续执行";
            dataGridView1.Rows.Clear(); // 清除所有行
            LabelInit();
        }
        public void Excution()
        {
            int nextPosition = GetNextPosition(currentPosition, Execution_Status);
            if (nextPosition == -1)
            {
                return;
            }
            else
                textBox11.Text = "执行" + nextPosition.ToString() + "号指令";
            int page = nextPosition / 10;
            int offset = nextPosition % 10;
            currentPosition = nextPosition;
            Excution_times++;
            string f = "无";//换出页记录
            string g = "无";//换入页记录
            int i;
            //扫描内存块中是否有对应的页
            for (i = 0; i < memory_block.Length; i++)
            {
                if (memory_block[i] != page)
                    continue;
                else
                {
                    time_block[i] = -1;
                    UpdatePageIns(i, offset);
                    break;
                }

            }
            page_fault = false;
            if (i == 4)
            {
                page_fault = true;
                page_fault_num++;
                string b = Convert.ToString(page_fault_num);
                textBox5.Text = b;

                //寻找是否有空闲页面
                int j;
                for (j = 0; j < memory_block.Length; j++)
                {
                    if (memory_block[j] == -1)//找到空闲页面
                    {
                        memory_block[j] = page;
                        UpdateTextBox(j, page);
                        UpdatePageIns(j, offset);
                        break;
                    }
                    else
                        continue;
                }

                //没找到空闲页面，调用页面置换算法
                if (j == 4)
                {
                    //FIFO算法
                    if (comboBox1.Text == "FIFO算法")
                    {
                        f = Convert.ToString(memory_block[block_pointer]);//记录换出页
                        g = Convert.ToString(page);//记录换出页
                        time_block[block_pointer] = -1;
                        memory_block[block_pointer] = page;
                        UpdateTextBox(block_pointer, page);
                        UpdatePageIns(block_pointer, offset);
                        if (block_pointer == 3)
                            block_pointer = 0;
                        else
                            block_pointer++;
                    }
                    else if (comboBox1.Text == "LRU算法")
                    {
                        int max = time_block[0];
                        int time_long_page = 0;
                        for (int n = 0; n < time_block.Length; n++)
                        {
                            if (time_block[n] > max)
                            {
                                max = time_block[n];
                                time_long_page = n;
                            }
                        }
                        time_block[time_long_page] = -1;
                        f = Convert.ToString(memory_block[time_long_page]);//记录换出页
                        g = Convert.ToString(page);//记录换出页
                        memory_block[time_long_page] = page;
                        UpdateTextBox(time_long_page, page);
                        UpdatePageIns(time_long_page, offset);

                    }
                }
            }

            //右下角显示缺页数和缺页率
            page_fault_rate = page_fault_num * 100.0 / Excution_times;
            page_fault_rate = Math.Round(page_fault_rate, 2);
            string c = Convert.ToString(page_fault_rate);
            textBox6.Text = c + "%";

            //在右侧“已执行指令”中显示指令地址、是否缺页、换出页、换入页
            string d = Convert.ToString(currentPosition);
            string e;
            if (page_fault == true)
                e = "是";
            else
                e = "否";
            dataGridView1.Rows.Add(d, e, f, g);//在右侧表中添加所取地址和是否缺页等信息
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;//使滑动条跟随新数据向下行
            for (int m = 0; m < memory_block.Length; m++)
            {
                if (memory_block[m] != -1)
                    time_block[m]++;
            }
            UpdateTime();
        }
        static int GetNextPosition(int currentPosition, int option)
        {
            int nextPosition;
            int z;
            for (z = 0; z < 320; z++)
            {
                if (visited[z] == 1)
                    continue;
                else
                    break;
            }
            if (z == 320)
                return -1;
            if (currentPosition == -1)
            {
                visited[0] = 1;
                return 0;
            }


            if (option == 0)
            {
                nextPosition = (currentPosition + 1) % 320;
                visited[nextPosition] = 1; // 标记该位置已被遍历过
                return nextPosition; // 第一个参数+1，并确保范围在0~319
            }


            else if (option == 1)
            {
                // 随机选择一个未被遍历过的位置
                Random random = new Random();
                nextPosition = random.Next(320);

                // 确保选择的位置未被遍历过
                while (visited[nextPosition] != 0)
                {
                    nextPosition = random.Next(320);
                }

                visited[nextPosition] = 1; // 标记该位置已被遍历过
                return nextPosition;
            }


            else if (option == 2)
            {
                Random random = new Random();
                int randomNumber = random.Next(100);

                if (randomNumber < 50)
                {
                    nextPosition = (currentPosition + 1) % 320;
                    visited[nextPosition] = 1;
                    return nextPosition;
                }
                else if (randomNumber < 75)
                {
                    // 均匀分布在0~currentPosition-1中选择未被遍历过的位置
                    List<int> availablePositions = new List<int>();

                    for (int i = 0; i < currentPosition; i++)
                    {
                        if (visited[i] == 0)
                        {
                            availablePositions.Add(i);
                        }
                    }

                    if (availablePositions.Count > 0)
                    {
                        int index = random.Next(availablePositions.Count);
                        nextPosition = availablePositions[index];
                        visited[nextPosition] = 1;
                        return nextPosition;
                    }
                }
                else
                {
                    // 均匀分布在currentPosition+1~319中选择未被遍历过的位置
                    List<int> availablePositions = new List<int>();

                    for (int i = currentPosition + 1; i < 320; i++)
                    {
                        if (visited[i] == 0)
                        {
                            availablePositions.Add(i);
                        }
                    }

                    if (availablePositions.Count > 0)
                    {
                        int index = random.Next(availablePositions.Count);
                        nextPosition = availablePositions[index];
                        visited[nextPosition] = 1;
                        return nextPosition;
                    }
                }
            }

            if (currentPosition != 319)
                return currentPosition + 1;
            else
                return currentPosition;
        }
        public void UpdateTime()
        {
            if (time_block[0] != -1)
                textBox7.Text = "驻留" + time_block[0] + "周期";
            if (time_block[1] != -1)
                textBox8.Text = "驻留" + time_block[1] + "周期";
            if (time_block[2] != -1)
                textBox9.Text = "驻留" + time_block[2] + "周期";
            if (time_block[3] != -1)
                textBox10.Text = "驻留" + time_block[3] + "周期";
            if (time_block[0] == 0)
                textBox7.Text = "正在调用";
            if (time_block[1] == 0)
                textBox8.Text = "正在调用";
            if (time_block[2] == 0)
                textBox9.Text = "正在调用";
            if (time_block[3] == 0)
                textBox10.Text = "正在调用";
        }
        public void UpdatePageIns(int j, int page)
        {
            switch (j)
            {
                case 0:
                    LabelInit();
                    switch (page)
                    {
                        case 0: button4.BackColor = Color.Red; break;
                        case 1: button5.BackColor = Color.Red; break;
                        case 2: button6.BackColor = Color.Red; break;
                        case 3: button7.BackColor = Color.Red; break;
                        case 4: button8.BackColor = Color.Red; break;
                        case 5: button9.BackColor = Color.Red; break;
                        case 6: button10.BackColor = Color.Red; break;
                        case 7: button11.BackColor = Color.Red; break;
                        case 8: button12.BackColor = Color.Red; break;
                        case 9: button13.BackColor = Color.Red; break;
                    }
                    break;
                case 1:
                    LabelInit();
                    switch (page)
                    {
                        case 0: button14.BackColor = Color.Red; break;
                        case 1: button15.BackColor = Color.Red; break;
                        case 2: button16.BackColor = Color.Red; break;
                        case 3: button17.BackColor = Color.Red; break;
                        case 4: button18.BackColor = Color.Red; break;
                        case 5: button19.BackColor = Color.Red; break;
                        case 6: button20.BackColor = Color.Red; break;
                        case 7: button21.BackColor = Color.Red; break;
                        case 8: button22.BackColor = Color.Red; break;
                        case 9: button23.BackColor = Color.Red; break;
                    }
                    break;
                case 2:
                    LabelInit();
                    switch (page)
                    {
                        case 0: button24.BackColor = Color.Red; break;
                        case 1: button25.BackColor = Color.Red; break;
                        case 2: button26.BackColor = Color.Red; break;
                        case 3: button27.BackColor = Color.Red; break;
                        case 4: button28.BackColor = Color.Red; break;
                        case 5: button29.BackColor = Color.Red; break;
                        case 6: button30.BackColor = Color.Red; break;
                        case 7: button31.BackColor = Color.Red; break;
                        case 8: button32.BackColor = Color.Red; break;
                        case 9: button33.BackColor = Color.Red; break;
                    }
                    break;
                case 3:
                    LabelInit();
                    switch (page)
                    {
                        case 0: button34.BackColor = Color.Red; break;
                        case 1: button35.BackColor = Color.Red; break;
                        case 2: button36.BackColor = Color.Red; break;
                        case 3: button37.BackColor = Color.Red; break;
                        case 4: button38.BackColor = Color.Red; break;
                        case 5: button39.BackColor = Color.Red; break;
                        case 6: button40.BackColor = Color.Red; break;
                        case 7: button41.BackColor = Color.Red; break;
                        case 8: button42.BackColor = Color.Red; break;
                        case 9: button43.BackColor = Color.Red; break;
                    }
                    break;
            }
        }
        public void UpdateTextBox(int j, int page)
        {
            string newText = "第" + page + "页";
            if (j == 0)
                textBox1.Text = newText;
            else if (j == 1)
                textBox2.Text = newText;
            else if (j == 2)
                textBox3.Text = newText;
            else if (j == 3)
                textBox4.Text = newText;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excution();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Initial();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "顺序执行")
            {
                Execution_Status = 0;
            }
            else if (comboBox2.Text == "随机执行")
            {
                Execution_Status = 1;
            }
            else if (comboBox2.Text == "混合执行")
            {
                Execution_Status = 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
                timer1.Enabled = true;
            button2.Text = "连续执行";
            if (Excution_times == 320)
            {
                textBox11.Text = "指令执行完毕";
                timer1.Stop();
                return;
            }
            Excution();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Text = "继续";
        }
    }
}