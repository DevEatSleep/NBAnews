namespace NBAnews.Model
{
    public class Score
    {
        public string? Points { get; set; }
    }

    public class VTeam
    {
        public string? TeamId { get; set; }
        public string? ShortName { get; set; }
        public string? FullName { get; set; }
        public string? NickName { get; set; }
        public string? Logo { get; set; }
        public Score? Score { get; set; }
    }

    public class HTeam
    {
        public string? TeamId { get; set; }
        public string? ShortName { get; set; }
        public string? FullName { get; set; }
        public string? NickName { get; set; }
        public string? Logo { get; set; }
        public Score? Score { get; set; }
    }

    public class Game
    {
        public string? SeasonYear { get; set; }
        public string? League { get; set; }
        public string? GameId { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public DateTime EndTimeUtc { get; set; }
        public string? Arena { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Clock { get; set; }
        public string? GameDuration { get; set; }
        public string? CurrentPeriod { get; set; }
        public string? Halftime { get; set; }
        public string? EndOfPeriod { get; set; }
        public string? SeasonStage { get; set; }
        public string? StatusShortGame { get; set; }
        public string? StatusGame { get; set; }
        public VTeam? VTeam { get; set; }
        public HTeam? HTeam { get; set; }
    }

    public class Api
    {
        public int Status { get; set; }
        public string? Message { get; set; }
        public int Results { get; set; }
        public List<string>? Filters { get; set; }
        public List<Game>? Games { get; set; }
    }

    public class Result
    {
        public Api? Api { get; set; }
    }
}
