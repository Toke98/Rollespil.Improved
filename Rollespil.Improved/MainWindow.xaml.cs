using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rollespil.Improved
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ///THE MOST IMPORTENT PIECE OF CODE///
        public static int counter = 0;
        public static bool outOfTheApp = false;
        public static bool DeadOrNot = false;

        //Technecal stuff
        public static ConsoleKeyInfo Exit;
        public static Random rng = new Random();
        public static string makeShiftString;

        //Totallaly usless mockery
        public static int idiotCounter;

        //Character

        public static double ProficiencyBonus = 0;
        public static double Health = 100;
        public static double MaxHealth = 100;
        public static double YourHitDice = 0;
        public static double SpellcastingAbility = 0;
        public static double SpellSacveDC = 0;
        public static double spellAttackBonus = 0;

        public static int Level = 1;
        public static int numberOfSpells = 0;
        public static int NumberOfCantrips = 0;
        public static int newSpells;
        public static int Initiative;
        public static int spellSlots;
        public static int trueSpellSlot;
        public static int WalkingSpeed;
        public static int AC;
        public static int SpellsKnown;
        public static int SpellCounter;
        public static int SpellUsed;
        public static int change = 0;

        public static string yourClass = "";
        public static string yesOrNo;
        public static string yourName;
        public static string MagicalClass;
        public static string yourRace;

        //Die and chi stuff
        public static int numberOfSides;
        public static int dieResult;
        public static int numberOfRolls;
        public static int totalDieResult;

        public static bool advantageOrNot = false;
        public static bool disadvantageOrNot = false;

        ///Uniques
        //Barbarian
        public static bool barbarianOrNot = false;
        public static int rages;

        //Sorcerer
        public static bool SorcererOrNot = false;
        public static int SorcererPoints;

        //Warlock
        public static bool warlockOrNot = false;
        public static bool[] Arcadium = { false, false, false, false };


        //Combat
        public static bool combatOrNot = false;
        public static bool consentrationOrNot = false;

        public static int DamageDone = 0;
        public static int DeathDie;
        public static int LifeDie;
        public static int DeathCounter;
        public static int roundCounter;

        public static double DeathThreasHold = 0;



        //Spells
        public static int[] levelSpellSlots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] trueSpellslots = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int consentrationChech;

        public static string YourSpells;
        public static string[] allSpellLevels = { "1'st Level Spells: ", "2'nd Level Spells: ", "3rd Level Spells: ", "4'th Level Spells: ", "5'th Level Spells: ", "6'th Level Spells: ", "7'th Level Spells: ", "8'th Level Spells: ", "9'th Level Spells: " };

        public static bool levelUpSpells = false;

        public static List<string> Spells = new List<string>();


        ///Weapons
        public static string searchTool;

        //Your weapon
        public static int yourWeapon = -1;
        public static int weaponDamageDealt;
        public static int toHit;
        public static int attackRoll;

        public static bool weaponPro = false;
        public static bool rangedWeapon = false;


        //Classes and Races
        public static string[] Classess = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
        public static double[] HitDice = { 12, 8, 8, 8, 10, 8, 10, 10, 8, 6, 8, 6 };
        public static string[] Races = { "Dwarf", "Elf", "Halfling", "Human", "Dragonborn", "Gnome", "Half-Elf", "Half-Orc", "Tiefling" };

        public static bool SpeelsOrNot = false;
        public static bool SpellTotal = false;

        public static double[] SavingThrows = { 0, 0, 0, 0, 0, 0 };
        public static bool[] deathSavingProfieciency = { false, false, false, false, false, false };


        //Stats and Skills
        public static string[] AllThings = { "Strength: ", "Dexterity: ", "Constitition: ", "Intelligence: ", "Wisdom: ", "Charisma: " };
        public static int[] StatValue = { 0, 0, 0, 0, 0, 0 };

        public static string Str = "Athletics: ";
        public static double[] StrMods = { 0 };
        public static bool[] strProOrNot = { false };

        public static string[] Dex = { "Acrobatics: ", "Sleight of hand: ", "Stealth: " };
        public static double[] DexMods = { 0, 0, 0 };
        public static bool[] dexProOrNot = { false, false, false };

        public static string[] Int = { "Arcana: ", "History: ", "Investigation: ", "Nature: ", "Religion: " };
        public static double[] IntMods = { 0, 0, 0, 0, 0 };
        public static bool[] IntProOrNot = { false, false, false, false, false };

        public static string[] Wis = { "Animal Handling: ", "Insight: ", "Medicine: ", "Perception: ", "Survival: " };
        public static double[] WisMods = { 0, 0, 0, 0, 0 };
        public static bool[] wisProOrNot = { false, false, false, false, false };

        public static string[] Cha = { "Deception: ", "Intimidation: ", "Perfermance: ", "Persuasion: " };
        public static double[] ChaMods = { 0, 0, 0, 0 };
        public static bool[] chaProOrNot = { false, false, false, false };


        //Modifiers
        public static double[] Modifier = { 0, 0, 0, 0, 0, 0 };

        public static int atributes = 0;


        ///Rando
        // A-Z
        public static string[] AZ = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Z" };

        //a-z
        public static string[] az = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "z" };

        //Stats
        public static string RandoName;
        public static string firstLetter;
        public static string letter;
        public static string restName;
        public static string firstName;
        public static string lastName;

        public static int nameLetters;

        public MainWindow()
        {
            InitializeComponent();
            spell();
            dndclasses();
        }

        //Spells in Combobox
        public void spell()
        {
            //Cantrips * Combobox
            {
                Spell_0.ItemsSource = SpellList.Cantrips;
                Spell_0.SelectedIndex = 0;
            }

            //Spell 1 * Combobox
            {
                Spell_1.ItemsSource = SpellList.Level1Spells;
                Spell_1.SelectedIndex = 0; 
            }

            //Spell 2 * Combobox
            {
                Spell_2.ItemsSource = SpellList.Level2Spells;
                Spell_2.SelectedIndex = 0;
            }
            
            //Spell 3 * Combobox
            {
                Spell_3.ItemsSource = SpellList.Level3Spells;
                Spell_3.SelectedIndex = 0;
            }
            
            //Spell 4  Combobox
            {
                Spell_4.ItemsSource = SpellList.Level4Spells;
                Spell_4.SelectedIndex = 0;
            }
            
            //Spell 5  Combobox
            {
                Spell_5.ItemsSource = SpellList.Level5Spells;
                Spell_5.SelectedIndex = 0;
            }

            //Spell 6  Combobox
            {
                Spell_6.ItemsSource = SpellList.Level6Spells;
                Spell_6.SelectedIndex = 0;
            }

            //Spell 7  Combobox
            {
                Spell_7.ItemsSource = SpellList.Level7Spells;
                Spell_7.SelectedIndex = 0;
            }

            //Spell 8  Combobox
            {
                Spell_8.ItemsSource = SpellList.Level8Spells;
                Spell_8.SelectedIndex = 0;
            }

            //Spell 9  Combobox
            {
                Spell_9.ItemsSource = SpellList.Level9Spells;
                Spell_9.SelectedIndex = 0;
            }
        }

        //Classes in Combobox
        public void dndclasses()
        {
            DropClass.ItemsSource = Classess;
            DropClass.SelectedIndex = 0;
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            DropClass.Visibility = Visibility.Hidden;
            LabelClass.Content = DropClass.SelectedItem;
            TextBoxName.Visibility = Visibility.Hidden;
            LabelName.Content = TextBoxName.Text;

            
        }
    }
}
