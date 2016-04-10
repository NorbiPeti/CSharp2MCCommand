using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCCommands
{
    public static class MCCommand //TODO: Change string parameters to new types
    { //TODO: Add selectors in messages
        public static bool AchievementGive(string achievement, Entity player)
        {
            throw new Error();
        }

        public static bool AchievementTake()
        {
            throw new Error();
        }

        public static bool Blockdata(Location location, string datatag)
        {
            throw new Error();
        }

        public static bool Clear(Entity player, string item, int data)
        {
            throw new Error();
        }

        public static bool Clone(Location source1, Location source2, Location destination, string maskmode, string clonemode, string tilename)
        {
            throw new Error();
        }

        public static bool Defaultgamemode(Entity player, string mode)
        {
            throw new Error();
        }

        public static bool Difficulty(string difficulty)
        {
            throw new Error();
        }

        public static bool EffectClear(Entity player)
        {
            throw new Error();
        }

        public static bool Effect(Entity player, string effect, int seconds, int amplifier, bool hideparticles)
        {
            throw new Error();
        }

        public static bool Enchant(Entity player, string enchantment, int level)
        {
            throw new Error();
        }

        public static bool Entitydata(Entity player, string datatag)
        {
            throw new Error();
        }
        
        public static bool Execute(Entity entity, Location location, Action command)
        {
            throw new Error();
        }

        public static bool ExecuteDetect(Entity entity, Location location, Location detectlocation, string block, int data, Action command)
        {
            throw new Error();
        }

        public static bool Fill(Location loc1, Location loc2, string tilename, int data, string oldblockhandling, string datatag)
        {
            throw new Error();
        }

        public static bool FillReplace(Location loc1, Location loc2, string tilename, int data, string replacetilename, string replacedata)
        {
            throw new Error();
        }

        public static bool Gamemode(Entity player, string mode)
        {
            throw new Error();
        }

        public static bool Gamerule(string rule, string value)
        {
            throw new Error();
        }

        public static bool Gamerule(string rule, bool value)
        {
            throw new Error();
        }

        public static bool Gamerule(string rule, int value)
        {
            throw new Error();
        }

        public static bool Give(Entity player, string item, int amount, int data, string datatag)
        {
            throw new Error();
        }

        public static bool Help(int page)
        {
            throw new Error();
        }

        public static bool Help(string command)
        {
            throw new Error();
        }

        public static bool List(bool uuids)
        {
            throw new Error();
        }

        public static bool Me(string action)
        {
            throw new Error();
        }

        public static bool Particle(string name, Location location, int xd, int yd, int zd, int speed, int count, Entity player, params string[] parameters)
        {
            throw new Error();
        }

        public static bool Playsound(string sound, string source, Entity player, Location location, int volume, int pitch, int minvolume)
        {
            throw new Error();
        }

        public static bool ReplaceitemBlock(Location location, int slot, string item, int amount, int data, string datatag)
        {
            throw new Error();
        }

        public static bool ReplaceitemEntity(Entity entity, string slot, string item, int amount, int data, string datatag)
        {
            throw new Error();
        }

        public static bool Say(string message)
        {
            throw new Error();
        }

        public static bool Scoreboard(string message) //TODO: Scoreboard
        {
            throw new Error();
        }

        public static bool Seed()
        {
            throw new Error();
        }

        public static bool Setblock(Location location, string tilename, int data, string oldblockhandling, string datatag)
        {
            throw new Error();
        }

        public static bool Spawnpoint(Entity player, Location location)
        {
            throw new Error();
        }

        public static bool Spreadplayers(Entity player, int x, int z, int spreaddistance, int maxrange, bool respectteams, params Entity[] entities)
        {
            throw new Error();
        }

        //TODO: Get all players who satisfy a condition, etc.
        public static bool StatsBlockClear(Location location, string stat)
        {
            throw new Error();
        }

        public static bool StatsBlockSet(Location location, string stat, Entity selector, string objective)
        {
            throw new Error();
        }

        public static bool StatsEntityClear(Entity entities, string stat)
        {
            throw new Error();
        }

        public static bool StatsEntitySet(Entity entities, string stat, Entity selector, string objective)
        {
            throw new Error();
        }

        public static bool Summon(string entityname, Location location, string datatag)
        {
            throw new Error();
        }

        public static bool Tell(Entity player, string message)
        {
            throw new Error();
        }

        //TODO: Add object structure and use Newtonsoft.Json
        public static bool Tellraw(Entity player, string json)
        {
            throw new Error();
        }

        public static int Testfor(Entity entities, string datatag)
        {
            throw new Error();
        }

        public static bool Testforblock(Location location, string tilename, int data, string datatag)
        {
            throw new Error();
        }

        public static bool Testforblock(Location source1, Location source2, Location target, string tilename, bool masked)
        {
            throw new Error();
        }

        public static bool TimeAdd(int value)
        {
            throw new Error();
        }

        public static int TimeQuery(string value)
        {
            throw new Error();
        }

        public static bool TimeSet(int value)
        {
            throw new Error();
        }

        public static bool TitleClear()
        {
            throw new Error();
        }

        public static bool TitleReset()
        {
            throw new Error();
        }

        public static bool TitleSubtitle(string title)
        {
            throw new Error();
        }

        public static bool TitleTimes(int fadein, int stay, int fadeout)
        {
            throw new Error();
        }

        public static bool TitleTitle(string title)
        {
            throw new Error();
        }

        public static bool Toggledownfall()
        {
            throw new Error();
        }

        public static bool Tp(Entity entities, Entity entity)
        {
            throw new Error();
        }

        public static bool Tp(Entity entities, Location location, int yrot, int xrot)
        {
            throw new Error();
        }

        public static bool TriggerAdd(string objective, int value)
        {
            throw new Error();
        }

        public static bool TriggerSet(string objective, int value)
        {
            throw new Error();
        }

        public static bool Weather(string value, int duration)
        {
            throw new Error();
        }

        public static bool WhitelistAdd(Entity player)
        {
            throw new Error();
        }

        public static bool WhitelistList()
        {
            throw new Error();
        }

        public static bool WhitelistOff()
        {
            throw new Error();
        }

        public static bool WhitelistOn()
        {
            throw new Error();
        }

        public static bool WhitelistReload()
        {
            throw new Error();
        }

        public static bool WhitelistRemove(Entity player)
        {
            throw new Error();
        }

        //TODO: Worldborder
        public static bool Worldborder(Entity player)
        {
            throw new Error();
        }

        public static bool Xp(int amount, bool level, Entity player)
        {
            throw new Error();
        }
    }
}
