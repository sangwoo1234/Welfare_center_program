using System;//DateTime사용을 위한 C#기능이 담긴 선언문
using System.Collections.Generic;//dictionary,list같은 자료구조 사용을 위해 필요한 선언문
using System.ComponentModel;
using System.Data;
using System.Drawing;//화면의 위치 크기 색상등 기능사용을 위한 선언문
using System.Globalization;//DateTimeFormatInfo같은 날짜,시간,지역등 기능을 위한 선언문
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//윈폼 사용을 위한 선언문
using System.Data.SqlClient;//sql문을 사용하기위한 선언문

namespace portfolio
{
    public partial class calander : Form
    {
        private Point mousePoint;//마우스 포인트 위치저장 변수
        int nmonth, nyear;//정수형 변수 월과 연도
        private Dictionary<DateTime, string> holidays;//공휴일 딕셔너리 선언 키인DateTime으로 string값을 찾을예정
        private Dictionary<DateTime, List<string>> 출퇴근기록;//출퇴근기록 딕셔너리 선언

        string strConn = "Server=yourdatabase; database=db; user id=test; password=test;";
        int user_id;

        public calander(int userId)
        {
            InitializeComponent();

            user_id = userId;

            DateTime now = DateTime.Now;//now에 현재 날짜와 시간 정보를 저장
            nmonth = now.Month;//현재 월 가져오기
            nyear = now.Year;

            출퇴근기록 = new Dictionary<DateTime, List<string>>();//new 연산자로 딕셔너리 생성
        }

        private void InitializeHolidays()//공휴일 초기화 함수 + 메인에 넣기에는 너무 복잡해짐
        {
            holidays = new Dictionary<DateTime, string>
            {
                { new DateTime(nyear, 1, 1), "신정" },//올해 1월1일을 key로 신정이라는value를 저장
                { new DateTime(nyear, 3, 1), "삼일절" },
                { new DateTime(nyear, 5, 5), "어린이날" },
                { new DateTime(nyear, 5, 15), "부처님 오신날" },
                { new DateTime(nyear, 6, 6), "현충일" },
                { new DateTime(nyear, 8, 15), "광복절" },
                { new DateTime(nyear, 10, 3), "개천절" },
                { new DateTime(nyear, 10, 9), "한글날" },
                { new DateTime(nyear, 12, 25), "크리스마스" }
            };
        }

        private void drag_lb_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void drag_lb_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calander_Load(object sender, EventArgs e)
        {
            InitializeHolidays();
            LoadCommuteData();
            date_a_live();
        }

        private void LoadCommuteData()//출퇴근 기록 불러오기 함수
        {
            출퇴근기록.Clear();
            using (SqlConnection conn = new SqlConnection(strConn))//중간에 오류발생 방지 자동 .close기능을 위해 using문 사용
            {
                conn.Open();
                string sql = "SELECT * FROM commute WHERE user_id = @user_id AND arrive_time >= @StartDate AND leave_time <= @EndDate";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);//user_id값 넘겨주기
                    cmd.Parameters.AddWithValue("@StartDate", new DateTime(nyear, nmonth, 1));//해당 월의 1일을 시작 날짜로 값 넘겨주기
                    cmd.Parameters.AddWithValue("@EndDate", new DateTime(nyear, nmonth, DateTime.DaysInMonth(nyear, nmonth)));//해당 월의 마지막 날짜값 넘겨주기

                    using (SqlDataReader rdr = cmd.ExecuteReader())//rdr로 cmd값 받기
                    {
                        while (rdr.Read())
                        {
                            DateTime 출근시간 = Convert.ToDateTime(rdr["arrive_time"]);//출근시간에 DB에서 가져온 rdr의 arrive_time을 가져와서 저장

                            DateTime dateKey = 출근시간.Date;//시간은 버리고 날짜만 가져오기 출근시간에 저장된 값은"2026-09-02 08:46:29.710"이므로 뒤에를 빼버림

                            if (!출퇴근기록.ContainsKey(dateKey))//출퇴근기록 딕셔너리에 값 출근시간이 없다면 if문 실행 있다면 실행이 안됨
                            {
                                출퇴근기록[dateKey] = new List<string>();
                            }
                            출퇴근기록[dateKey].Add("출근 " + 출근시간.ToString("HH:mm"));

                            if (rdr["leave_time"] != DBNull.Value)//rdr의 leave_time즉 퇴근시간의 값과 DB값이 null값이 아니라면 퇴근찍기
                            {
                                DateTime 퇴근시간 = Convert.ToDateTime(rdr["leave_time"]);
                                출퇴근기록[dateKey].Add("퇴근 " + 퇴근시간.ToString("HH:mm"));
                            }

                        }

                    }
                }
            }
        }

        private void date_a_live()//달력을 생성하는 함수
        {
            first_pl.Controls.Clear();
            InitializeHolidays();//다음년도로 넘어갈시 2027년 공휴일의 연도부분은 고정되어있지 않으므로 초기화가 필요함

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(nmonth);
            lb_month.Text = nyear + "년 " + monthname;//월 레이블 텍스트 변경해줌

            DateTime month = new DateTime(nyear, nmonth, 1);//month에는 2026-09-01이 들어가있음
            int day = DateTime.DaysInMonth(nyear, nmonth);//DaysInMonth를 사용해 해당연도 월의 총 일수를 갖고옴 9월기준 day에는 30이 저장됨
            int weekday = (int)month.DayOfWeek + 1;//month의 정보 2026-09-01을 이용해 DayOfWeek속성을 사용해 DayOfWeek.monthday tuesday같은 1일의 요일을 알아내기
            //같은 형식으로 반환되기에 ToString("d")를 사용해 문자열2로 바꾸고 그 문자열 2를 Convert를 사용해 숫자 2로 바꿔줌
            //컴퓨터기준 일요일이 0으로 되어있어 달력 특징을 생각해 +1을 해줌
            //근데 int weekday = (int)month.DayOfWeek + 1; 이런 형식으로 바꿀 수 있다는걸 확인했기에 변경 2026-09-04
            //기존 코드 int weekday = Convert.ToInt32(month.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < weekday; i++)//weekday에는 숫자 3이 들어가있음
            {
                calander_control blank = new calander_control();//calander_control은 내가 직접 이전월 표기를 위한 blank표시를 위해 사용자 정의 컨트롤로 만든 클래스
                first_pl.Controls.Add(blank);//빈칸을 달력에 추가             
            }

            for (int i = 1; i <= day; i++)
            {
                cal_control_day uc_day = new cal_control_day();//날짜 표기및 출퇴근 표기를 위한 사용자 정의 컨트롤
                uc_day.day(i);//uc_day로 cal_control_day에 접근 가능해서.day(i)는 day함수의 numday의 매개변수로 넘겨줌 이는 아래의SetSaturday와 동일

                DateTime currentDay = new DateTime(nyear, nmonth, i); //currentDay에 i의 날짜를 저장
                bool isSaturday = currentDay.DayOfWeek == DayOfWeek.Saturday;//부울형 변수 isSaturday를 만들고 그 안에 i의 날짜가 토요일인지 확인
                bool isSunday = currentDay.DayOfWeek == DayOfWeek.Sunday;//동일
                bool isHoliday = holidays.ContainsKey(currentDay);//isHoliday에 holidays공휴일딕셔너리와 currentDay날짜값 확인 공휴일이면 true

                uc_day.SetSaturday(isSaturday);//i의 날짜가 토요일일때 true값이 전달되어 휴일로 표시 그외에는 전부 false값이 전달
                uc_day.SetSunday(isSunday);//동일
                if (isHoliday)
                {

                    uc_day.SetHoliday(holidays[currentDay], isSaturday);//공휴일일떄 true전달 시작
                    //*토요일의 색상이 공휴일과 겹칠때 빨간색으로 표기되므로 사용자 정의 컨트롤의 SetHoliday에 isSaturday매개변수를 전달한 후 if문을 생성해서 2번확인
                    if (currentDay.DayOfWeek == DayOfWeek.Sunday)//currentDay.DayOfWeek가 일요일과 같다면 대체휴일로 지정
                    {
                        DateTime nextDay = currentDay.AddDays(1);
                        holidays[nextDay] = holidays[currentDay] + " 대체휴일";
                    }
                    else if (currentDay.DayOfWeek == DayOfWeek.Saturday)//동일하게 토요일이 공휴일이라면
                    {
                        DateTime nextDay = currentDay.AddDays(2);
                        holidays[nextDay] = holidays[currentDay] + " 대체휴일";
                    }
                }

                // 퇴근 기록이 있는 날짜에 대해 commute 정보를 설정
                if (출퇴근기록.ContainsKey(currentDay))
                {
                    uc_day.SetCommute(출퇴근기록[currentDay]);
                }

                first_pl.Controls.Add(uc_day);
            }
        }

        private void pm_btn_Click(object sender, EventArgs e)
        {
            first_pl.Controls.Clear();
            nmonth--;
            if (nmonth == 0)
            {
                nmonth = 12;
                nyear--;
            }
            LoadCommuteData();
            date_a_live();
        }

        private void nm_btn_Click(object sender, EventArgs e)
        {
            first_pl.Controls.Clear();
            nmonth++;
            if (nmonth == 13)
            {
                nmonth = 1;
                nyear++;
            }
            LoadCommuteData();
            date_a_live();
        }
    }
}