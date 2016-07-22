using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGo.RocketAPI.GeneratedCode;

namespace PokemonGo.RocketAPI.Logic.Utils
{
    public static class HumanUtils
    {
        private static Random _randomDevice = new Random();

        public static Task Delay(int millisecondsDelay)
        {
            int jitter = millisecondsDelay / 10;

            millisecondsDelay = _randomDevice.Next(millisecondsDelay - jitter, millisecondsDelay + jitter);

            return Task.Delay(millisecondsDelay);
        }
    }
}
