using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Uebungsbeispiel2
{
    interface Iidentifiable
    {
        string identifier { get; }
    }

    delegate void AlarmHandler(Iidentifiable sender, string info);

    class IDS : Iidentifiable
    {
        public event AlarmHandler onAlarm;

        private string _identifier;

        public string identifier { get { return _identifier; } }

        public IDS(string identifier)
        {
            if (String.IsNullOrEmpty(identifier))
                throw new ArgumentNullException();

            _identifier = identifier;
            onAlarm = null;
        }

        public void RaiseAlarm(string message)
        {
            if (String.IsNullOrEmpty(message))
                throw new System.ArgumentNullException();

            Console.WriteLine("Alarm: " + message);
            if (onAlarm != null)
                onAlarm(this, message);
        }
    }

    class Human : Iidentifiable
    {
        private string _name;

        public string identifier { get { return _name; } }

        public Human(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException();

            _name = name;
        }

        public void GetMessageByPhone(Iidentifiable sender, string info)
        {
            Console.WriteLine(_name + " gets a message by phone from " + sender.identifier + " saying: " + info);
        }

        public void GetMessageByEMail(Iidentifiable sender, string info)
        {
            Console.WriteLine(_name + " gets a message by email from " + sender.identifier + " saying: " + info);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human admin = new Human("admin Frank");
            Human boss = new Human("boss Carla");

            admin.GetMessageByEMail(boss, "get the IDS running");

            Console.WriteLine();

            IDS ids = new IDS("central IDS");
            ids.onAlarm += admin.GetMessageByEMail;
            ids.onAlarm += boss.GetMessageByPhone;

            ids.RaiseAlarm("DDos attack on web server");

            Console.WriteLine();

            ids.RaiseAlarm("malware detected");

            Console.ReadKey();
        }
    }
}
