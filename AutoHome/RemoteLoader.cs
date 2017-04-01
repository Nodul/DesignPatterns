using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class RemoteLoader
    {
        public void RunPartyModeTest()
        {
            RemoteControl remote = new RemoteControl();

            Light light = new Light("Living room");
            Stereo stereo = new Stereo("Living room");

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            Command[] partyOn = {lightOn,stereoOn };
            Command[] partyOff = { lightOff, stereoOff };
            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);
            Console.WriteLine(remote.ToString());
            Console.WriteLine("\n==Pushing macro ON==");
            remote.PushOnButton(0);
            Console.WriteLine("\n==Pushing macro OFF=="); 
            remote.PushOffButton(0);

            
        }

        public void RunCeilingFanTest()
        {
            RemoteControl remote = new RemoteControl();

            CeilingFan ceilingFan = new CeilingFan("Kitchen");

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanHigh, ceilingFanOff);
            remote.SetCommand(1, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(2, ceilingFanLow, ceilingFanOff);

            Console.WriteLine(remote.ToString());

            remote.PushOnButton(0);
            remote.PushUndobutton();
            remote.PushOnButton(1);
            remote.PushOffButton(1);
            remote.PushUndobutton();
            remote.PushOnButton(2);
            remote.PushOffButton(2);
        }

        /// <summary>
        /// Full loader with 7 slots
        /// </summary>
        public void RunTest()
        {
            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");
            //Here I create commands, which can be assigned to the remote's buttons
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanOn = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown = new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote.ToString());

            remote.PushOnButton(0);
            remote.PushOffButton(0);

            remote.PushOnButton(1);
            remote.PushOffButton(1);

            remote.PushOnButton(2);
            remote.PushOffButton(2);

            remote.PushOffButton(1);
            remote.PushUndobutton();

            remote.PushOnButton(3);
            remote.PushOffButton(3);

            remote.PushOnButton(0);
            remote.PushOffButton(0);

            remote.PushOnButton(5);
            remote.PushUndobutton();
            //remote.PushUndobutton();
        }
        /// <summary>
        /// [Deprecated] This loader version has only 1 slot
        /// </summary>
        public void RunSimpleTest()
        {
            SimpleRemoteControl remote = new SimpleRemoteControl(); //Invoker

            Light light = new Light("Kitchen"); //Receiver
            LightOnCommand lightOn = new LightOnCommand(light); //Concrete Command + setting the receiver, which is passed as a parameter
            LightOffCommand lightOff = new LightOffCommand(light);

            GarageDoor garageDoor = new GarageDoor("");
            GarageDoorOpenCommand garageUp = new GarageDoorOpenCommand(garageDoor);

            remote.Command = lightOn; //SetCommand [as it is the invoker]
            remote.ButtonPress(); //Finally Execute [as it is the invoker]

            remote.Command = garageUp;
            remote.ButtonPress();

            remote.Command = lightOff;
            remote.ButtonPress();
        }
    }
}
