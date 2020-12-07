using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Threading;

namespace TestBot
{
    public partial class Form1 : Form
    {
        private int tCPU = 20;
        private int cpu_UpLimit = 50;
        private int tSYS = 20;        
        private static DeviceClient deviceClient;

        public Form1()
        {
            InitializeComponent();
            try
            {
                deviceClient = DeviceClient.CreateFromConnectionString(textBox_IoTHubString.Text, Microsoft.Azure.Devices.Client.TransportType.Http1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sample: {0}", ex.Message);
            }
        }

        async void SendMessageToCloud(DeviceClient deviceClient, string JsonString)
        {
            label_SentToIoTHub.Text = JsonString;
            Microsoft.Azure.Devices.Client.Message eventMessage = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(JsonString));
            await deviceClient.SendEventAsync(eventMessage);
        }

        async void ReceiveCommands(DeviceClient deviceClient)
        {
            Microsoft.Azure.Devices.Client.Message receivedMessage;
            string messageData = "";
            receivedMessage = await deviceClient.ReceiveAsync();
            if (receivedMessage != null)
            {
                try
                {
                    messageData = Encoding.UTF8.GetString(receivedMessage.GetBytes());
                    await deviceClient.CompleteAsync(receivedMessage);
                    Debug.Write("got Message : "+ messageData + "\r\n");
                    dynamic data = JsonConvert.DeserializeObject(messageData);
                    string VendorString = data?.__AzureSphereVendor;
                    string commandstring = data?.__AzureSphereDMCommand;
                    string UserName = data?.__NexcomUserName;
                    string Devicename = data?.__AzureSphereDeviceName;
                    string IPC_Command = data?.__IPCCOMMAND;
                    textBox_DeviceName.Text = Devicename;

                    textBox_User.Text = UserName;
                    label_Event.Text = "Got Command : " + commandstring;
                    string JsonString = "";
                    if (commandstring.Equals("IPCCOMMAND", StringComparison.OrdinalIgnoreCase))
                    {
                        if(IPC_Command.Equals("XCARE", StringComparison.OrdinalIgnoreCase))
                        {
                            var XcareData = new
                            {
                                CPU_Temp = Convert.ToInt16(textBox_CPU.Text),
                                SYS_Temp = Convert.ToInt16(textBox_SYS.Text),
                            };
                            JsonString = JsonConvert.SerializeObject(XcareData);

                            var x = new
                            {
                                __AzureSphereVendor = VendorString,
                                __NexcomUserName = UserName,
                                __AzureSphereDeviceName = textBox_DeviceName.Text,
                                __AzureSphereDMCommand = commandstring,
                                __IPCCOMMAND = IPC_Command,
                                __CommandReturnStatus = 0,
                                __ReturnValue = JsonString,
                                __BotReturnTime = DateTime.Now.ToString("g"),
                            };
                            JsonString = JsonConvert.SerializeObject(x);
                        }
                        else if (IPC_Command.Equals("GetCPUTemp", StringComparison.OrdinalIgnoreCase))
                        {
                            var x = new
                            {
                                __AzureSphereVendor = VendorString,
                                __NexcomUserName = UserName,
                                __AzureSphereDeviceName = textBox_DeviceName.Text,
                                __AzureSphereDMCommand = commandstring,
                                __CommandReturnStatus = 0,
                                __IPCCOMMAND = IPC_Command,
                                __BotReturnTime = DateTime.Now.ToString("g"),
                                __ReturnValue = "CPU Temp: " + textBox_CPU.Text + "°C",
                            };
                            JsonString = JsonConvert.SerializeObject(x);
                        }
                        else if (IPC_Command.Equals("GetSYSTemp", StringComparison.OrdinalIgnoreCase))
                        {
                            var x = new
                            {
                                __AzureSphereVendor = VendorString,
                                __NexcomUserName = UserName,
                                __AzureSphereDeviceName = textBox_DeviceName.Text,
                                __AzureSphereDMCommand = commandstring,
                                __CommandReturnStatus = 0,
                                __IPCCOMMAND = IPC_Command,
                                __BotReturnTime = DateTime.Now.ToString("g"),
                                __ReturnValue = "SYS Temp: " + textBox_CPU.Text + "°C",
                            };
                            JsonString = JsonConvert.SerializeObject(x);
                        }
                        else if (IPC_Command.Equals("XCARESUPPORT", StringComparison.OrdinalIgnoreCase))
                        {
                            var x = new
                            {
                                __AzureSphereVendor = VendorString,
                                __NexcomUserName = UserName,
                                __AzureSphereDeviceName = textBox_DeviceName.Text,
                                __AzureSphereDMCommand = commandstring,
                                __CommandReturnStatus = 0,
                                __IPCCOMMAND = IPC_Command,
                                __BotReturnTime = DateTime.Now.ToString("g"),
                                __ReturnValue = "XCARESUPPORTED",
                            };
                            JsonString = JsonConvert.SerializeObject(x);
                        }
                        else
                            label_Event.Text = "Got Command : Not Support";
                    }
                    else
                    {
                        var x = new
                        {
                            __AzureSphereVendor = VendorString,
                            __NexcomUserName = UserName,
                            __AzureSphereDeviceName = textBox_DeviceName.Text,
                            __AzureSphereDMCommand = commandstring,
                            __CommandReturnStatus = 0,
                            __BotReturnTime = DateTime.Now.ToString("g"),
                            __ReturnValue = $"{commandstring} command is success",
                        };
                        JsonString = JsonConvert.SerializeObject(x);
                    }
                    Debug.Write("Sent to Cloud Message : " + JsonString + "\r\n");
                    SendMessageToCloud(deviceClient, JsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in sample: {0}", ex.Message);
                }
            }
        }
        //*********** start of Direct Method ********
        private void ConnectionstatuschangeHandler(ConnectionState status, ConnectionStatusChangeReason reason)
        {
            Debug.Write("Connection status : " +status+ "\r\n");
            Debug.Write("Connection reason : " +reason+ "\r\n");
        }
        private Task<MethodResponse> API_HardwareReset(MethodRequest methodRequest, object userContext)
        {
            Debug.Write($"\t"+ methodRequest.Name +" was called \r\n");
            Debug.Write($"\tPayload: " + methodRequest.DataAsJson + "\r\n");
            return Task.FromResult(new MethodResponse(new byte[0], 200));
        }
        private Task<MethodResponse> API_PING(MethodRequest methodRequest, object userContext)
        {
            Debug.Write($"\t" + methodRequest.Name + " was called \r\n");
            Debug.Write($"\tPayload: " + methodRequest.DataAsJson + "\r\n");
            return Task.FromResult(new MethodResponse(new byte[0], 200));
        }
        private Task<MethodResponse> API_SSDRecover(MethodRequest methodRequest, object userContext)
        {
            Debug.Write($"\t" + methodRequest.Name + " was called \r\n");
            Debug.Write($"\tPayload: " + methodRequest.DataAsJson + "\r\n");
            return Task.FromResult(new MethodResponse(new byte[0], 200));
        }
        private Task<MethodResponse> API_XCARE(MethodRequest methodRequest, object userContext)
        {
            Debug.Write($"\t" + methodRequest.Name + " was called \r\n");
            Debug.Write($"\tPayload: " + methodRequest.DataAsJson + "\r\n");
            return Task.FromResult(new MethodResponse(new byte[0], 200));
        }

        async void ReceiveDirectMethodCommands(DeviceClient deviceClient)
        {
            //deviceClient.SetConnectionStatusChangesHandler(ConnectionstatuschangeHandler);
            await deviceClient.SetMethodHandlerAsync("HardwareReset", API_HardwareReset, null).ConfigureAwait(false);
            await deviceClient.SetMethodHandlerAsync("PING", API_PING, null).ConfigureAwait(false);
            await deviceClient.SetMethodHandlerAsync("SSDRecover", API_SSDRecover, null).ConfigureAwait(false);
            await deviceClient.SetMethodHandlerAsync("XCARE", API_XCARE, null).ConfigureAwait(false);            
        }
        //*********** End of Direct Method ********

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tCPU++;
            tSYS = rnd.Next(20,50);
            if (tCPU > cpu_UpLimit)
            {
                var x = new
                {
                    Name = textBox_User.Text,
                    DeviceName = textBox_DeviceName.Text,
                    Time = DateTime.Now.ToString("g"),
                    CPU_Temp = Convert.ToInt16(textBox_CPU.Text),
                    SYS_Temp = Convert.ToInt16(textBox_SYS.Text),
                };
                string JsonString = JsonConvert.SerializeObject(x);
                //SendMessageToCloud(deviceClient, JsonString);
                tCPU = 20;                                
            }
            textBox_CPU.Text = Convert.ToString(tCPU);
            textBox_SYS.Text = Convert.ToString(tSYS);
            ReceiveCommands(deviceClient);
            //ReceiveDirectMethodCommands(deviceClient);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new
            {
                __AzureSphereVendor = "EMBUX",                
                __NexcomUserName = "User",
                __AzureSphereDeviceName = "ds02",
                __AzureSphereDMCommand = "PING",
                __CommandReturnStatus = 0,
                __BotReturnTime = DateTime.Now.ToString("g"),
                //CPU_Temp = tCPU++,
                //SYS_Temp = 18,
            };
            string JsonString = JsonConvert.SerializeObject(x);
            Debug.Write("Sent to Cloud Message : " + JsonString+"\r\n");
            SendMessageToCloud(deviceClient, JsonString);
        }
    }
}
