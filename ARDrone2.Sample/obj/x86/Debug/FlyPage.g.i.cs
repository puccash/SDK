﻿

#pragma checksum "C:\Dev\TFS-Repository\AR.Drone\AR.Drone2.0\ARDrone2.Sample\FlyPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2E987722C9488DF1DFFFDA6118D3A4F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARDrone2.Sample
{
    partial class FlyPage : global::ARDrone2.Sample.Common.LayoutAwarePage
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource MessagesSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.MediaElement arDroneMediaElem; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView MessagesListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid JoystickGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button TakeOffLandButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider AltitudeSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock AltitudeValue; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider YawSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock YawValue; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider PitchSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock PitchValue; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Slider RollSlider; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock RollValue; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::ARDrone2Client.Windows.Input.JoystickControl YawGazJoystick; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::ARDrone2Client.Windows.Input.JoystickControl RollPitchJoystick; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button ResetEmergency; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button ConfigurationButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button SwitchVideoChannelButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button IndoorOutdoorButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock DroneBattery; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock DroneStatus; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///FlyPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            MessagesSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("MessagesSource");
            arDroneMediaElem = (global::Windows.UI.Xaml.Controls.MediaElement)this.FindName("arDroneMediaElem");
            MessagesListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("MessagesListView");
            JoystickGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("JoystickGrid");
            TakeOffLandButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("TakeOffLandButton");
            AltitudeSlider = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("AltitudeSlider");
            AltitudeValue = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("AltitudeValue");
            YawSlider = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("YawSlider");
            YawValue = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("YawValue");
            PitchSlider = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("PitchSlider");
            PitchValue = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("PitchValue");
            RollSlider = (global::Windows.UI.Xaml.Controls.Slider)this.FindName("RollSlider");
            RollValue = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("RollValue");
            YawGazJoystick = (global::ARDrone2Client.Windows.Input.JoystickControl)this.FindName("YawGazJoystick");
            RollPitchJoystick = (global::ARDrone2Client.Windows.Input.JoystickControl)this.FindName("RollPitchJoystick");
            ResetEmergency = (global::Windows.UI.Xaml.Controls.Button)this.FindName("ResetEmergency");
            ConfigurationButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("ConfigurationButton");
            SwitchVideoChannelButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("SwitchVideoChannelButton");
            IndoorOutdoorButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("IndoorOutdoorButton");
            DroneBattery = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("DroneBattery");
            DroneStatus = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("DroneStatus");
        }
    }
}


