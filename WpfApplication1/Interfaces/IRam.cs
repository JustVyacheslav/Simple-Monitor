
using System;
using System.Diagnostics;
using System.Management;
public interface IRam
{
    float GetAvailableMbytes();
    float GetInUsePercent();
    float GetTotalCapacityGbytes();
}


public class RAM : IRam
{
    private PerformanceCounter ramAvaliable;
    private float totalCapacity;
    public RAM()
    {
        //ramInUse = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        ramAvaliable = new PerformanceCounter("Memory", "Available MBytes");
        totalCapacity = (float)Math.Round((double)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024/1024,1);
    }
    public float GetAvailableMbytes()
    {
        return ramAvaliable.NextValue();
    }

    public float GetInUsePercent()
    {
        //return (float)Math.Round(ramInUse.NextValue(), 1);
        return (float)Math.Round(100 - ((ramAvaliable.NextValue() / (totalCapacity*1024))*100));
    }
    public float GetTotalCapacityGbytes()
    {
        return totalCapacity;
    }
}

