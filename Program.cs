var id = ArmDot.Client.Api.GetCurrentMachineHardwareId(ArmDot.Client.Api.Hardware.CPU | ArmDot.Client.Api.Hardware.Motherboard | ArmDot.Client.Api.Hardware.HDD);
Console.WriteLine($"Your Activation Key Is: {id}");

