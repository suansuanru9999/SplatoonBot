﻿namespace SplatoonBot.Splatoon2
{
    public interface ISplatoon2Manager
    {
        Task<Schedules?> GetSchedulesAsync();
        Task<List<Schedule>> GetScheduleListAsync(DateTime startTime, DateTime endTime);
    }
}
