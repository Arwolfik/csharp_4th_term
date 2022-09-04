using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task3
{
    public class DigitalCamera : Camera
    {
        public int Memory { get; set; }
        public int BatteryVolume { get; set; }

        public DigitalCamera(string brand, string diaphragms, int zoom, int memory, int batteryVolume) : base(brand, diaphragms, zoom)
        {
            Memory = memory;
            BatteryVolume = batteryVolume;
        }

        public string delete_photo()
        {
           return "Фото удалено";
        }

        public string watch_photo()
        {
            return "Режим просмотра фотографий включен";
        }

    }
}
