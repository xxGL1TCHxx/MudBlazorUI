namespace MudBlazorUI.Data
{
    public class DailyChoreService
    {

        public Task<DailyChoreItem[]> GetDailyChoresAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new DailyChoreItem
            {
                ChoreDescription = "This is a long Description",
                ChoreName = "Chore " + index,
                ChoreCompleted = (index == 3),
                Person = (index % 2 == 1) ? "Scarlett" : "Sarah"
            }).ToArray());
            
        }
    }
}
