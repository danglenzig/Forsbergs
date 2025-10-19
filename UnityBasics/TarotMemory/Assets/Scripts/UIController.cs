using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System;

namespace TarotMemory
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private TMP_Text flavorTextUpper;
        [SerializeField] private TMP_Text flavorTextLower;
        [SerializeField] private TMP_Text comboText;
        private Dictionary<string, string> cardTitleDict = new Dictionary<string, string>();
        private Dictionary<string, string> flavorTextDict = new Dictionary<string, string>();
        private Dictionary<string, string> comboTextDict = new Dictionary<string, string>();

        private void Start()
        {
            ClearTexts();
            SetupDicts();



            //string testString = "IB";
            //Debug.Log(comboTextDict[SortAlphabetically(testString)]);



        }

        public void ShowFlavorText(string _key, bool isUpper)
        {
            string theText = $"{cardTitleDict[_key]}\n{flavorTextDict[_key]}";
            if (isUpper)
            {
                flavorTextUpper.text = theText;
            }
            else
            {
                flavorTextLower.text = theText;
            }
        }

        public void ShowComboText(string comboString)
        {
            comboString = SortAlphabetically(comboString);
            comboText.text = comboTextDict[comboString];

        }

        public void ClearTexts()
        {
            flavorTextUpper.text = "";
            flavorTextLower.text = "";
            comboText.text = "";
        }

        private void SetupDicts()
        {
            cardTitleDict["A"] = "The Fool";
            cardTitleDict["B"] = "The Magician";
            cardTitleDict["C"] = "The High Priestess";
            cardTitleDict["D"] = "The Empress";
            cardTitleDict["E"] = "The Emperor";
            cardTitleDict["F"] = "The Hierophant";
            cardTitleDict["G"] = "The Lovers";
            cardTitleDict["H"] = "The Chariot";
            cardTitleDict["I"] = "Strength";

            flavorTextDict["A"] = "A leap into the unknown, wide-eyed and weightless. Every risk hums with the promise of becoming.";
            flavorTextDict["B"] = "All tools are at hand — willpower crackles like lightning between them. Creation begins with intention.";
            flavorTextDict["C"] = "Veiled in silence, she guards the threshold of mystery. What’s hidden asks to be felt, not seen.";
            flavorTextDict["D"] = "Life blooms wherever her gaze falls. She reminds you that care itself is a form of magic.";
            flavorTextDict["E"] = "Stone and structure, command and clarity. Order gives the wild a place to grow strong.";
            flavorTextDict["F"] = "Old wisdom whispers through ritual and rule. To learn is to listen for the sacred echo beneath the surface.";
            flavorTextDict["G"] = "Choice entwined with connection — the heart speaks, but it also decides.";
            flavorTextDict["H"] = "Momentum forged from discipline. To steer your path is to harness opposing forces into one drive.";
            flavorTextDict["I"] = "Power gentled by compassion. True courage is not the roar, but the calm hand that tames it.";

            comboTextDict["AB"] = "Innocence meets mastery. Raw potential sparked into purpose.";
            comboTextDict["AC"] = "Naïve wonder stumbles upon ancient mystery. Discovery begins where questions dare to wander.";
            comboTextDict["AD"] = "Creation greets curiosity. Every step plants a seed in the unknown.";
            comboTextDict["AE"] = "Freedom meets form. Chaos pauses long enough to glimpse the beauty of order.";
            comboTextDict["AF"] = "Rebellion against tradition, or tradition teaching through experience. Perhaps a lesson in trust.";
            comboTextDict["AG"] = "The open heart leaps before it looks. Connection is the greatest adventure.";
            comboTextDict["AH"] = "Impulse at full gallop. Will recklessness carry you, or crash gloriously?";
            comboTextDict["AI"] = "Fearless curiosity finds quiet courage. Bravery wears a smile, not armor.";

            comboTextDict["BC"] = "The seen and the unseen join hands. Knowledge is balanced by mystery.";
            comboTextDict["BD"] = "Intent meets abundance. What’s imagined can take root in the world.";
            comboTextDict["BE"] = "Willpower finds discipline, creation shaped by command.";
            comboTextDict["BF"] = "Arcane insight meets sacred order. Mastery gains meaning through tradition.";
            comboTextDict["BG"] = "Desire fuels manifestation. The spell begins with the heart’s true want.";
            comboTextDict["BH"] = "Skill in motion. The will steers destiny. Every victory is a crafted one.";
            comboTextDict["BI"] = "Power focused through compassion. The strongest magic listens before it acts.";

            comboTextDict["CD"] = "Mystery nourishes life. The hidden and the fertile whisper to one another.";
            comboTextDict["CE"] = "Intuition meets authority. The quiet voice of wisdom whispers behind the throne.";
            comboTextDict["CF"] = "Two keepers of knowledge, one inner, one outer. Between them, truth hums like music.";
            comboTextDict["CG"] = "A heart illuminated from within. Connection deepens when silence is understood.";
            comboTextDict["CH"] = "Inner guidance drives the journey. The unseen becomes your compass.";
            comboTextDict["CI"] = "Patience and empathy merge. The quiet soul’s endurance outlasts force.";

            comboTextDict["DE"] = "Creation and control, the dance between nature and structure. Together, they build worlds.";
            comboTextDict["DF"] = "Fertility guided by faith. Growth shaped by timeless principles.";
            comboTextDict["DG"] = "Affection in full bloom. Love becomes the art of creation itself.";
            comboTextDict["DH"] = "Abundance with direction. Energy steered toward fruition.";
            comboTextDict["DI"] = "Kindness fortified. Gentle power nourishes lasting growth.";

            comboTextDict["EF"] = "Authority blessed by wisdom. Law tempered by spirit.";
            comboTextDict["DG"] = "Structure meets surrender. Love tests the limits of control.";
            comboTextDict["DH"] = "Command and momentum unite. Victory through unwavering focus.";
            comboTextDict["DI"] = "True leadership rules through calm resilience, not fear.";

            comboTextDict["FG"] = "Faith entwined with choice. Commitment transforms belief into devotion.";
            comboTextDict["FH"] = "Conviction drives the wheels forward. Discipline becomes pilgrimage.";
            comboTextDict["FI"] = "Tradition softened by compassion. The gentle reformer’s courage.";

            comboTextDict["GH"] = "Desire given direction — two hearts moving as one will.";
            comboTextDict["GI"] = "Tenderness is might. Love endures where force would fail.";

            comboTextDict["HI"] = "Speed meets stillness. Mastery requires both drive and restraint.";

            comboTextDict["AA"] = "Two beginnings collide. Infinite potential is folded in on itself. The journey renews with every brave mistake.";
            comboTextDict["BB"] = "Power recognizes itself. Intention sharpens to pure creation — the will and the world become one act.";
            comboTextDict["CC"] = "A mirror of silence. Mystery doubled becomes clarity beyond words.";
            comboTextDict["DD"] = "Abundance overflowing. Creation is nurturing creation. Life delights in its own beauty.";
            comboTextDict["EE"] = "Order squared. Structure so firm it becomes foundation. A strength that others can stand upon.";
            comboTextDict["FF"] = "Tradition reaffirmed. Knowledge echoes through generations, keeping faith alive through time.";
            comboTextDict["GG"] = "Union within union. When reflection meets devotion, love knows itself completely.";
            comboTextDict["HH"] = "Twin forces perfectly aligned. Momentum turns to mastery. Victory without struggle.";
            comboTextDict["II"] = "Gentle power doubled. Compassion becomes unbreakable resolve.";

            


            //Debug.Log(flavorTextDict["FOO"]);
            //Debug.Log(flavorTextDict["BAR"]);

            //string testString = "HA";
            //string sortedTest = SortAlphabetically(testString);
            //Debug.Log(comboTextDict[sortedTest]);
        }

        private static string SortAlphabetically(string inString)
        {
            char[] chars = inString.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}