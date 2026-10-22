namespace Aluka.Application.DTOs;

/// <summary>
/// DTO para estatísticas do histórico.
/// </summary>
public class HistoryStatisticsDTO
{
    public int Total { get; set; }
    public int Success { get; set; }
    public int Errors { get; set; }
    public int Ignored { get; set; }

    public double SuccessRate => Total > 0 ? (double)Success / Total * 100 : 0;
    public double ErrorRate => Total > 0 ? (double)Errors / Total * 100 : 0;
    public double IgnoredRate => Total > 0 ? (double)Ignored / Total * 100 : 0;
}