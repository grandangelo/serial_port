using System.Reflection;

try
{
    var serialPortPath = "..\\..\\..\\..\\SerialPort\\bin\\Debug\\net8.0-windows\\SerialPort.dll";
    var serialAssembly = Assembly.LoadFrom(serialPortPath);
    var serialPort = Activator.CreateInstance(serialAssembly.GetType("SerialPort.SerialPort"));
}
catch
{
    // Do nothing
}


