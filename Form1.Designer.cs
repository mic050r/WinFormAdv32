﻿namespace WinFormAdv32
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.페이지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bing으로검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾ㄱ기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기기본값복원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.피드백보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.새창ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.toolStripSeparator1,
            this.페이지설정ToolStripMenuItem,
            this.인쇄ToolStripMenuItem,
            this.toolStripSeparator2,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            resources.ApplyResources(this.파일ToolStripMenuItem, "파일ToolStripMenuItem");
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            resources.ApplyResources(this.새로만들기ToolStripMenuItem, "새로만들기ToolStripMenuItem");
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 새창ToolStripMenuItem
            // 
            this.새창ToolStripMenuItem.Name = "새창ToolStripMenuItem";
            resources.ApplyResources(this.새창ToolStripMenuItem, "새창ToolStripMenuItem");
            this.새창ToolStripMenuItem.Click += new System.EventHandler(this.새창ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            resources.ApplyResources(this.열기ToolStripMenuItem, "열기ToolStripMenuItem");
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            resources.ApplyResources(this.저장ToolStripMenuItem, "저장ToolStripMenuItem");
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            resources.ApplyResources(this.다른이름으로저장ToolStripMenuItem, "다른이름으로저장ToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // 페이지설정ToolStripMenuItem
            // 
            this.페이지설정ToolStripMenuItem.Name = "페이지설정ToolStripMenuItem";
            resources.ApplyResources(this.페이지설정ToolStripMenuItem, "페이지설정ToolStripMenuItem");
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            resources.ApplyResources(this.인쇄ToolStripMenuItem, "인쇄ToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            resources.ApplyResources(this.끝내기ToolStripMenuItem, "끝내기ToolStripMenuItem");
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.toolStripSeparator3,
            this.잘라내기ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.toolStripSeparator4,
            this.bing으로검색ToolStripMenuItem,
            this.toolStripSeparator6,
            this.찾기ToolStripMenuItem,
            this.다음찾ㄱ기ToolStripMenuItem,
            this.이전찾기ToolStripMenuItem,
            this.바꾸기ToolStripMenuItem,
            this.이동ToolStripMenuItem,
            this.toolStripSeparator5,
            this.모두선택ToolStripMenuItem,
            this.시간날짜ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            resources.ApplyResources(this.편집ToolStripMenuItem, "편집ToolStripMenuItem");
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            resources.ApplyResources(this.실행취소ToolStripMenuItem, "실행취소ToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // 잘라내기ToolStripMenuItem
            // 
            this.잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
            resources.ApplyResources(this.잘라내기ToolStripMenuItem, "잘라내기ToolStripMenuItem");
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            resources.ApplyResources(this.복사ToolStripMenuItem, "복사ToolStripMenuItem");
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            resources.ApplyResources(this.붙여넣기ToolStripMenuItem, "붙여넣기ToolStripMenuItem");
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            resources.ApplyResources(this.삭제ToolStripMenuItem, "삭제ToolStripMenuItem");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // bing으로검색ToolStripMenuItem
            // 
            this.bing으로검색ToolStripMenuItem.Name = "bing으로검색ToolStripMenuItem";
            resources.ApplyResources(this.bing으로검색ToolStripMenuItem, "bing으로검색ToolStripMenuItem");
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // 찾기ToolStripMenuItem
            // 
            this.찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            resources.ApplyResources(this.찾기ToolStripMenuItem, "찾기ToolStripMenuItem");
            // 
            // 다음찾ㄱ기ToolStripMenuItem
            // 
            this.다음찾ㄱ기ToolStripMenuItem.Name = "다음찾ㄱ기ToolStripMenuItem";
            resources.ApplyResources(this.다음찾ㄱ기ToolStripMenuItem, "다음찾ㄱ기ToolStripMenuItem");
            this.다음찾ㄱ기ToolStripMenuItem.Click += new System.EventHandler(this.다음찾ㄱ기ToolStripMenuItem_Click);
            // 
            // 이전찾기ToolStripMenuItem
            // 
            this.이전찾기ToolStripMenuItem.Name = "이전찾기ToolStripMenuItem";
            resources.ApplyResources(this.이전찾기ToolStripMenuItem, "이전찾기ToolStripMenuItem");
            // 
            // 바꾸기ToolStripMenuItem
            // 
            this.바꾸기ToolStripMenuItem.Name = "바꾸기ToolStripMenuItem";
            resources.ApplyResources(this.바꾸기ToolStripMenuItem, "바꾸기ToolStripMenuItem");
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            resources.ApplyResources(this.이동ToolStripMenuItem, "이동ToolStripMenuItem");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            resources.ApplyResources(this.모두선택ToolStripMenuItem, "모두선택ToolStripMenuItem");
            // 
            // 시간날짜ToolStripMenuItem
            // 
            this.시간날짜ToolStripMenuItem.Name = "시간날짜ToolStripMenuItem";
            resources.ApplyResources(this.시간날짜ToolStripMenuItem, "시간날짜ToolStripMenuItem");
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼬ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            resources.ApplyResources(this.서식ToolStripMenuItem, "서식ToolStripMenuItem");
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            resources.ApplyResources(this.자동줄바꿈ToolStripMenuItem, "자동줄바꿈ToolStripMenuItem");
            // 
            // 글꼬ToolStripMenuItem
            // 
            this.글꼬ToolStripMenuItem.Name = "글꼬ToolStripMenuItem";
            resources.ApplyResources(this.글꼬ToolStripMenuItem, "글꼬ToolStripMenuItem");
            this.글꼬ToolStripMenuItem.Click += new System.EventHandler(this.글꼬ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.상태표시줄ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            resources.ApplyResources(this.보기ToolStripMenuItem, "보기ToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.확대하기축소하기기본값복원ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            resources.ApplyResources(this.확대ToolStripMenuItem, "확대ToolStripMenuItem");
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            resources.ApplyResources(this.축소ToolStripMenuItem, "축소ToolStripMenuItem");
            // 
            // 확대하기축소하기기본값복원ToolStripMenuItem
            // 
            this.확대하기축소하기기본값복원ToolStripMenuItem.Name = "확대하기축소하기기본값복원ToolStripMenuItem";
            resources.ApplyResources(this.확대하기축소하기기본값복원ToolStripMenuItem, "확대하기축소하기기본값복원ToolStripMenuItem");
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            resources.ApplyResources(this.상태표시줄ToolStripMenuItem, "상태표시줄ToolStripMenuItem");
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기ToolStripMenuItem,
            this.피드백보내기ToolStripMenuItem,
            this.메모장정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            resources.ApplyResources(this.도움말ToolStripMenuItem, "도움말ToolStripMenuItem");
            // 
            // 도움말보기ToolStripMenuItem
            // 
            this.도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem";
            resources.ApplyResources(this.도움말보기ToolStripMenuItem, "도움말보기ToolStripMenuItem");
            this.도움말보기ToolStripMenuItem.Click += new System.EventHandler(this.도움말보기ToolStripMenuItem_Click);
            // 
            // 피드백보내기ToolStripMenuItem
            // 
            this.피드백보내기ToolStripMenuItem.Name = "피드백보내기ToolStripMenuItem";
            resources.ApplyResources(this.피드백보내기ToolStripMenuItem, "피드백보내기ToolStripMenuItem");
            // 
            // 메모장정보ToolStripMenuItem
            // 
            this.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            resources.ApplyResources(this.메모장정보ToolStripMenuItem, "메모장정보ToolStripMenuItem");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Value = 100;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(518, 260);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "ㅇㄴㄹㄴㄹㄴ";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 페이지설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem bing으로검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾ㄱ기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기기본값복원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 피드백보내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

