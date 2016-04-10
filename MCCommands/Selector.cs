using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCommands
{
    public class Selector : Entity
    {
        public static Selector AllPlayers(int x = int.MinValue, int y = int.MinValue, int z = int.MinValue, int radius = -1, int radiusmin = -1, string gamemode = null, int count = int.MinValue, int experiencelevel = -1, int expmin = -1, Dictionary<string, int> scoremax = null, Dictionary<string, int> scoremin = null, string team = null, string name = null, int dx = -1, int dy = -1, int dz = -1)
        {
            throw new Error();
        }
        public static Selector RandomPlayer(int x = int.MinValue, int y = int.MinValue, int z = int.MinValue, int radius = -1, int radiusmin = -1, string gamemode = null, int count = int.MinValue, int experiencelevel = -1, int expmin = -1, Dictionary<string, int> scoremax = null, Dictionary<string, int> scoremin = null, string team = null, string name = null, int dx = -1, int dy = -1, int dz = -1)
        {
            throw new Error();
        }
        public static Selector NearestPlayer(int x = int.MinValue, int y = int.MinValue, int z = int.MinValue, int radius = -1, int radiusmin = -1, string gamemode = null, int count = int.MinValue, int experiencelevel = -1, int expmin = -1, Dictionary<string, int> scoremax = null, Dictionary<string, int> scoremin = null, string team = null, string name = null, int dx = -1, int dy = -1, int dz = -1)
        {
            throw new Error();
        }
        public static Selector Entities(int x = int.MinValue, int y = int.MinValue, int z = int.MinValue, int radius = -1, int radiusmin = -1, string gamemode = null, int count = int.MinValue, int experiencelevel = -1, int expmin = -1, Dictionary<string, int> scoremax = null, Dictionary<string, int> scoremin = null, string team = null, string name = null, int dx = -1, int dy = -1, int dz = -1, string type = null)
        {
            throw new Error();
        }

        private Selector(string sel) : base(sel)
        {
        }
    }

    public enum SelectorType
    {
        AllPlayers,
        RandomPlayer,
        NearestPlayer,
        Entities
    }
}
