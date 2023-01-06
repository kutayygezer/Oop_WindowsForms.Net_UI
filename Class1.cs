using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;
using System.Windows.Forms;
using HaloUniverseUI.Properties;
using System.Security.Cryptography;

namespace HaloUniverseUI
{


    public abstract class BaseHumanoid : IHumanoid
    {
        public System.Drawing.Image ImagePath1 { get; set; }
        public System.Drawing.Image ImagePath2 { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Species { get; set; }
        public string PowerLvl { get; set; }
        public SoundPlayer SoundPlayer1 { get; set; }
        public string DanceVidPath { get; set; }
        public string FightVidPath { get; set; }
        public string PunchVidPath { get; set; }
        
        public string Dance()
        {
            return DanceVidPath = "DanceHalo.mp4";
        }
    }


    public class Human : BaseHumanoid
    {
        public Human()
        {
            Name1 = "CIVILIANS";
            Name2 = "SPARTANS";
            ImagePath1 = (Properties.Resources.PeopleHalo);
            ImagePath2 = (Properties.Resources.Spartans1);
            Dance();
        }


    }
    public class Spartan : Human
    {
        public Spartan()
        {
            Name1 = "SPARTANS";
            Species = "Human";
            PowerLvl = "High";
            ImagePath1 = (Properties.Resources.SpartanPic);
            SoundPlayer1 = new SoundPlayer(Properties.Resources.m52_20c_070_car_m52_20c_070_car_);
            FightVidPath = "SpartanFight.mp4";
            PunchVidPath = "SpartanPunch.mp4";
        }
        
    }
    public class Civilian : Human
    {
        public Civilian()
        {
            Name1 = "CIVILIAN";
            Species = "Human";
            PowerLvl = "Low";
            ImagePath1 = (Properties.Resources.DrHalsey);
            SoundPlayer1 = new SoundPlayer(Properties.Resources.m80_10c_030_hal_m80_10c_030_hal_);
        }
    }
    public class Covenant : BaseHumanoid
    {
        public Covenant()
        {
            Name1 = "GRUNTS";
            Name2 = "ELITES";
            ImagePath1 = (Properties.Resources.Grunts);
            ImagePath2 = (Properties.Resources.Elites);
            Dance();
        }
    }
    public class Elites : Covenant
    {
        public Elites()
        {
            Name1 = "Elites";
            Species = "Covenant/Alien";
            PowerLvl = "High";
            ImagePath1 = (Properties.Resources.ElitePic);
            SoundPlayer1 = new SoundPlayer(Properties.Resources.elite_grenade_where_are_your_glasses);
            FightVidPath = "EliteFight.mp4";
            PunchVidPath = "ElitePunchHalo.mp4";
        }
    }
    public class Grunts : Covenant
    {
        public Grunts()
        {
            Name1 = "GRUNTS";
            Species = "Covenant/Alien";
            PowerLvl = "Medium";
            ImagePath1 = (Properties.Resources.GruntsPic);
            SoundPlayer1 = new SoundPlayer(Properties.Resources.hahawewinwewin);
            FightVidPath = "GruntFight.mp4";
        }
    }


}
