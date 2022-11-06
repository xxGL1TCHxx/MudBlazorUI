namespace MudBlazorUI.Data
{
    public class WeeklyChoreItem: ChoreItem
    {

        public string DayOFWeek { get; set; } = "";

    }

    public class DailyChoreItem: ChoreItem
    {

    }

    public class ChoreItem
    {

        public string Person { get; set; } = "";

        public string ChoreName { get; set; } = "";
        public string ChoreDescription { get; set; } = "";

        public bool ChoreCompleted { get; set; }
    }
}
