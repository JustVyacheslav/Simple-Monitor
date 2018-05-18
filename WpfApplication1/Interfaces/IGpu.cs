
using OpenHardwareMonitor.Hardware;

public interface IGpu
{
    float GetGpuMemoryTotal();
    float GetGpuMemoryAvailable();
    float GetGpuClock();
}




public class Gpu : IGpu
{
    private Computer c;
    private float clock;
    private float avmem;
    private float totalmem;
    private float temperature;
    private string name;
    public string Name { get { return name; } }
    public Gpu()
    {
        c = new Computer();
        c.GPUEnabled = true;
        c.Open();
        Update();
    }
    public float GetGpuClock()
    {
        Update();
        return clock;
    }

    public float GetGpuMemoryAvailable()
    {
        Update();
        return avmem;
    }

    public float GetGpuMemoryTotal()
    {
        return totalmem;
    }

    public float GetTemerature()
    {
        Update();
        return temperature;
    }
    private void Update()
    {
        foreach (var hardware in c.Hardware)
        {

            if (hardware.HardwareType == HardwareType.GpuAti || hardware.HardwareType == HardwareType.GpuNvidia)
            {
                hardware.Update();
                name = hardware.Name;
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Clock && sensor.Name == "GPU Core")
                        clock = sensor.Value.GetValueOrDefault();
                    if (sensor.SensorType == SensorType.SmallData && sensor.Name == "GPU Memory Total")
                        totalmem = sensor.Value.GetValueOrDefault();
                    if (sensor.SensorType == SensorType.SmallData && sensor.Name == "GPU Memory Free")
                        avmem = sensor.Value.GetValueOrDefault();
                    if (sensor.SensorType == SensorType.Temperature)
                        temperature = sensor.Value.GetValueOrDefault();
                        
                }
            }
        }
    }
}
