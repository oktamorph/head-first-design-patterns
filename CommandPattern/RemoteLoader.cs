namespace CommandPattern
{
    public class RemoteLoader
    {
        public static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            Tv tv = new Tv("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TvOnCommand tvOn = new TvOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TvOffCommand tvOff = new TvOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On ---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine();
            Console.WriteLine("--- Pushing Macro Off ---");
            remoteControl.OffButtonWasPushed(0);


            //Light livingRoomLight = new Light("Living Room");
            //Light kitchenLight = new Light("Kitchen");
            //CeilingFan ceilingFan = new CeilingFan("Living Room");
            //GarageDoor garageDoor = new GarageDoor("Garage");
            //Stereo stereo = new Stereo("Living Room");
            //CeilingFan ceilingFan = new CeilingFan("Living room");

            //LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            //LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            //LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            //LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            //CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            //GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            //StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            //StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            //CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);    
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            // remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remoteControl.SetCommand(2, ceilingFanHigh, ceilingFanOff);
            //remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            //remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            //remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);
            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);
            //remoteControl.OnButtonWasPushed(3);
            ////remoteControl.OffButtonWasPushed(3);
            //remoteControl.UndoButtonWasPushed();
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.OnButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();

            //remoteControl.OnButtonWasPushed(0);
            //remoteControl.OffButtonWasPushed(0);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();

            //remoteControl.OnButtonWasPushed(1);
            //Console.WriteLine(remoteControl);
            //remoteControl.UndoButtonWasPushed();
        }
    }
}
