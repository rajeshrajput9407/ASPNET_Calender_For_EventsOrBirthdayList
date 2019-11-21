using System;
using System.Collections;
using System.Web.UI.WebControls;

namespace Calender_Code
{
    public partial class Calender_code : System.Web.UI.Page
    {
        Hashtable HolidayList;

        protected void Page_Load(object sender, EventArgs e)
        {
            HolidayList = Getholiday();
            Calendar1.Caption = "Demo ";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;
            Calendar1.ShowGridLines = true;
            Calendar1.DayStyle.Height = new Unit(50);
            Calendar1.DayStyle.Width = new Unit(150);
            Calendar1.DayStyle.HorizontalAlign = HorizontalAlign.Center;
            Calendar1.DayStyle.VerticalAlign = VerticalAlign.Middle;
            Calendar1.OtherMonthDayStyle.BackColor = System.Drawing.Color.AliceBlue;
        }

        private Hashtable Getholiday()
        {
            string date = @"<div style='background-color: #266088;
                        color: #ffffff;
                        padding: 5px;
                        font-size: 14px;
                        margin-top: 10px;
                        margin-bottom: 0px;
                        text-align: center;
                        border-top-left-radius: 10px;
                        border-top-right-radius: 10px;'>
	                    <p>Birth Day </p>
	                    <p style='background-color: #eee;
                        padding: 3px;
                        color: #000;
                        border-radius: 2px;
                        font-size: 13px;
                        margin-bottom: 5px;'>John Mathews</p>
	                    <p style='background-color: #eee;
                        padding: 3px;
                        color: #000;
                        border-radius: 2px;
                        font-size: 13px;
                        margin-bottom: 5px;'>Mari bk</p>
                    </div>";
            Hashtable holiday = new Hashtable();
            holiday["1/1/2019"] = "New Year";
            holiday["1/5/2019"] = "Guru Govind Singh Jayanti";
            holiday["1/8/2019"] = "Muharam (Al Hijra)sd";
            holiday["1/14/2019"] = "Pongal";
            holiday["1/26/2019"] = "Republic Day";

            holiday["2/23/2019"] = "Maha Shivaratri";
            holiday["3/10/2019"] = "Milad un Nabi (Birthday of the Prophet";
            holiday["3/21/2019"] = "Holi";
            holiday["3/21/2019"] = "Telugu New Year";
            holiday["4/3/2019"] = "Ram Navmi";
            holiday["4/7/2019"] = "Mahavir Jayanti";
            holiday["4/10/2019"] = "Good Friday";
            holiday["4/12/2019"] = "Easter";
            holiday["4/14/2019"] = "Tamil New Year and Dr Ambedkar Birth Day";
            holiday["5/1/2019"] = "May Day";
            holiday["5/9/2019"] = "Buddha Jayanti and Buddha Purnima";
            holiday["6/24/2019"] = "Rath yatra";
            holiday["8/13/2019"] = "Krishna Jayanthi";
            holiday["8/14/2019"] = "Janmashtami";
            holiday["8/15/2019"] = "Independence Day";
            holiday["8/19/2019"] = "Parsi New Year";
            holiday["8/23/2019"] = "Vinayaka Chaturthi";
            holiday["9/2/2019"] = "Onam";
            holiday["9/5/2019"] = "Teachers Day";
            holiday["9/21/2019"] = "Ramzan";
            holiday["9/27/2019"] = "Ayutha Pooja";
            holiday["9/28/2019"] = "Vijaya Dasami (Dusherra)";
            holiday["10/2/2019"] = "Gandhi Jayanti";
            holiday["10/17/2019"] = "Diwali & Govardhan Puja";
            holiday["10/19/2019"] = "Bhaidooj";
            holiday["11/2/2019"] = "Guru Nanak Jayanti";
            holiday["11/14/2019"] = "Children's Day";
            holiday["11/28/2019"] = "Bakrid";
            holiday["12/25/2019"] = date;
            holiday["12/28/2019"] = "Muharram";
            return holiday;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            LabelAction.Text = "Date changed to :" + Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {
            LabelAction.Text = "Month changed to :" + e.NewDate.ToShortDateString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.ToShortDateString() != null)
            {
                Literal literal1 = new Literal();
                literal1.Text = "<br/>";
                e.Cell.Controls.Add(literal1);
                Label label1 = new Label();
                label1.Text = (string)HolidayList[e.Day.Date.ToShortDateString()];
                label1.Font.Size = new FontUnit(FontSize.Small);
                e.Cell.Controls.Add(label1);
            }
        }
    }
}