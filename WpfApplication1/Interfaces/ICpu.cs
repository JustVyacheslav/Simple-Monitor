using OpenHardwareMonitor.Hardware;
using System.Diagnostics;

public interface IProcessor
{
    float GetCurrentTemperature();
    float GetCurrentTotalLoad();
}

public class Processor : IProcessor
{
    Computer c;
    string processorName;
    float curTemp;
    float totalLoad;
    PerformanceCounter cpuload;
    public Processor()
    {
        cpuload = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        curTemp = 0;
        totalLoad = cpuload.NextValue();
        c = new Computer();
        c.Open();
        c.CPUEnabled = true;
        foreach (var hardware in c.Hardware)
        {

            if (hardware.HardwareType == HardwareType.CPU)
            {
                processorName = hardware.Name;
            }
        }
    }
    //Обновление параметров процессора
    private float GetTemperature()
    {
        foreach(var hardware in c.Hardware)
        {

            if(hardware.HardwareType == HardwareType.CPU)
            {
                hardware.Update();
                foreach(var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package")
                        return sensor.Value.GetValueOrDefault();
                }
            }
        }
        return -1;

    }
    private void UpdateLoad()
    {
        totalLoad = cpuload.NextValue();
    }
    private void UpdateTemperature()
    {
        curTemp = GetTemperature();
    }
    //Возврвщает текущую температуру
    public float GetCurrentTemperature()
    {
        UpdateTemperature();
        return curTemp;
    }
    //Возвращает текущую загрузку
    public float GetCurrentTotalLoad()
    {
        UpdateLoad();
        return totalLoad;
    }
    public string GetProcessorName()
    {
        return processorName;
    }
} 
