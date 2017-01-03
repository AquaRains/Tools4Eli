using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tools4eli
{
    public partial class Form1 : Form
    {
        //그냥 파일 이름
        string justFileName;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataDataSet.file_data' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.file_dataTableAdapter.Fill(this.dataDataSet.file_data);
            // TODO: 이 코드는 데이터를 'dataDataSet.file_data' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            this.file_dataTableAdapter.Fill(this.dataDataSet.file_data);

        }

        /// <summary>
        /// 파일을 불러와서 조건에 맞게 읽어들입니다.
        /// </summary>
        private void readfile()
        {
            //읽기 전용으로 열기
            using (FileStream fs = new FileStream(txtFilePath.Text, FileMode.Open,FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Default,true))
                {
                    bool isAvailable = false;
                    string strLineValue = null;
                    //파일 읽기 시작
                    while((strLineValue = sr.ReadLine()) != null)
                    {
                        //1. ns 찾기
                        if(strLineValue.StartsWith("ns ="))
                        {
                            txtNsValue.Text = strLineValue.Split(';')[0];
                            isAvailable = true;
                            break;
                        }               
                    }
                    if (!isAvailable)
                    {
                        System.Windows.Forms.MessageBox.Show("ns 값이 없는 것 같습니다. 파일 확인 바랍니다.", "값이 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        txtMFilePath.Text = txtFilePath.Text;
                    }
                    //deck : 프로그램을 돌리기 위한 input값 모음(이 들어있는 파일)
                    //deck.m이라는 plain text file을 input으로 잡고
                    //내부에서 ns = 으로 시작하는 line을 읽어서
                    //db의 첫번째 요소로 넣고
                    //deck.m이라는 파일의 풀경로를 두번째 요소로
                    //동일디렉토리에 deck.mat라는 파일의 풀경로를 3번째 요소로
                }
            }
        }


        /// <summary>
        /// 열기 버튼 클릭시 m 파일 대화상자를 엽니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            switch (openFileDialog_filepath.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    {
                        txtFilePath.Text = openFileDialog_filepath.FileName;
                        justFileName = openFileDialog_filepath.SafeFileName;

                        readfile();
                        if (ChkisSameFileName.Checked)
                        {
                            txtMatFilePath.Text = txtMFilePath.Text;
                        }
              
                        break;
                    }
                case System.Windows.Forms.DialogResult.Cancel:
                    {
                        break;
                    }
                default: break;
            }
        }

        /// <summary>
        /// 닫기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMatFilePath_Click(object sender, EventArgs e)
        {
            switch (openFileDialog_MatFilePath.ShowDialog())
            {
                case DialogResult.OK:
                    {
                        txtMatFilePath.Text = openFileDialog_MatFilePath.FileName;
                        break;
                    }

                default:
                    {
                        txtMatFilePath.Text = string.Empty;
                        break;
                    }
            }
            
        }


        //목록 추가 버튼
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNsValue.Text)) { MessageBox.Show("ns 값이 없습니다. ns값이 있는 파일을 선택하세요.", "값 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            file_dataTableAdapter.InsertQuery(txtNsValue.Text, txtMFilePath.Text, txtMatFilePath.Text);
            file_dataTableAdapter.Fill(this.dataDataSet.file_data);
            dataGridView1.Refresh();

        }
        //목록 수정 버튼
        private void BtnListMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNsValue.Text)) { MessageBox.Show("ns 값이 없습니다. ns값이 있는 파일을 선택하세요.", "값 없음", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            file_dataTableAdapter.UpdateQuery(txtNsValue.Text, txtMFilePath.Text, txtMatFilePath.Text, int.Parse(txtSerialNo.Text));
            file_dataTableAdapter.Fill(this.dataDataSet.file_data);
            dataGridView1.Refresh();
        }
        //목록 삭제 버튼
        private void BtnListDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSerialNo.Text))
            {
                file_dataTableAdapter.Delete(int.Parse(txtSerialNo.Text));
                file_dataTableAdapter.Fill(this.dataDataSet.file_data);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("삭제 대상이 올바르지 않습니다. 항목이 선택되었는지 확인해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataTable dt = dataDataSet.file_data;
            string strPath = dt.Rows[e.RowIndex].ItemArray[e.ColumnIndex].ToString();

            if(strPath.Substring(1).StartsWith(":\\"))
            {
                System.Diagnostics.Process.Start("explorer.exe",strPath.Substring(0,strPath.Length - justFileName.Length));
            }
        }
    }
}
