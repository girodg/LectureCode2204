using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    enum SuperPower
    {
        Fly, Strength, Invisibility, Speed, Money, Telepathy, Swim
    }
    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public SuperPower Powers { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region CSV
            //string speech = GetSpeech();

            string filePath = @"C:\temp\2203\sample.txt";

            char delimiter = '+';
            //1. open the file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                //2. write to the file
                sw.Write("Batman rules! Spider-who??");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(10.3);
                sw.Write(delimiter);
                sw.Write(true);
                sw.Write(delimiter);
                sw.WriteLine("The end.");
            }//3. Closes the file

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(delimiter);
                    foreach (var item in data)
                        Console.WriteLine(item);
                }
            }

            WriteData(filePath);
            ReadData(filePath);
            #endregion

            #region JSON
            #region Serializing
            List<Superhero> heroes = new List<Superhero>()
            {
                new Superhero(){Name="Batman", Secret="Bruce Wayne", Powers = SuperPower.Money},
                new Superhero(){Name="Wonder Woman", Secret="Diana Prince", Powers = SuperPower.Strength},
                new Superhero(){Name="Flash", Secret="Barry Allen", Powers = SuperPower.Speed},
                new Superhero(){Name="Superman", Secret="Clark Kent", Powers = SuperPower.Fly}
            };

            filePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, heroes);
                }
            }
            #endregion

            #region Deserializing
            if (File.Exists(filePath))
            {
                string superText = File.ReadAllText(filePath);
                try
                {
                    List<Superhero> justice = JsonConvert.DeserializeObject<List<Superhero>>(superText);
                    foreach (var hero in justice)
                    {
                        Console.WriteLine($"I am {hero.Name} ({hero.Secret}) and I can {hero.Powers}!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR! ERROR! Read all about it!");
                }
            }
            else
                Console.WriteLine($"{filePath} is not there!!");
            #endregion
            #endregion
        }

        static void WriteData(string fPath)
        {
            List<int> nums = new List<int>() { 5, 4, 3, 2, 1 };
            char delimiter = '>';
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                bool isFirst = true;
                for (int i = 0; i < nums.Count; i++)
                {
                    if (!isFirst)
                        sw.Write(delimiter);
                    sw.Write(nums[i]);
                    isFirst = false;
                }
            }
            //OR...
            string all = string.Join(delimiter, nums);
            File.WriteAllText(fPath, all);
        }

        static void ReadData(string filePath)
        {
            char delimiter = '>';
            List<int> numbers = new List<int>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(delimiter);
                    foreach (var item in data)
                    {
                        if (int.TryParse(item, out int number))
                        {
                            numbers.Add(number);
                        }
                    }
                }
            }
            Console.WriteLine("---------READDATA---------");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        static string GetSpeech()
        {
            return "My third story is about death. When I was 17, I read a quote that went something like: If you live each day as if it was your last, someday you'll most certainly be right. " +
        "It made an impression on me, and since then, for the past 33 years, I have looked in the mirror every morning and asked myself: If today were the last day of my life, " +
        "would I want to do what I am about to do today? And whenever the answer has been No for too many days in a row, I know I need to change something. Remembering that I'll be dead " +
        "soon is the most important tool I've ever encountered to help me make the big choices in life. Because almost everything - all external expectations, all pride, all fear of " +
        "embarrassment or failure - these things just fall away in the face of death, leaving only what is truly important. Remembering that you are going to die is the best way I know" +
        " to avoid the trap of thinking you have something to lose. You are already naked. There is no reason not to follow your heart. About a year ago I was diagnosed with cancer. " +
        "I had a scan at 7:30 in the morning, and it clearly showed a tumor on my pancreas. I didn't even know what a pancreas was. The doctors told me this was almost certainly a type of" +
        " cancer that is incurable, and that I should expect to live no longer than three to six months. My doctor advised me to go home and get my affairs in order, which is doctor's" +
        " code for prepare to die. It means to try to tell your kids everything you thought you'd have the next 10 years to tell them in just a few months. It means to make sure" +
        " everything is buttoned up so that it will be as easy as possible for your family. It means to say your goodbyes. I lived with that diagnosis all day. Later that evening I had" +
        " a biopsy, where they stuck an endoscope down my throat, through my stomach and into my intestines, put a needle into my pancreas and got a few cells from the tumor. I was" +
        " sedated, but my wife, who was there, told me that when they viewed the cells under a microscope the doctors started crying because it turned out to be a very rare form of " +
        "pancreatic cancer that is curable with surgery. I had the surgery and I'm fine now. This was the closest I've been to facing death, and I hope it's the closest I get for a few" +
        " more decades. Having lived through it, I can now say this to you with a bit more certainty than when death was a useful but purely intellectual concept: No one wants to die." +
        " Even people who want to go to heaven don't want to die to get there. And yet death is the destination we all share. No one has ever escaped it. And that is as it should be, " +
        "because Death is very likely the single best invention of Life. It is Life's change agent. It clears out the old to make way for the new. Right now the new is you, but someday" +
        " not too long from now, you will gradually become the old and be cleared away. Sorry to be so dramatic, but it is quite true. Your time is limited, so don't waste it living" +
        " someone else's life. Don't be trapped by dogma - which is living with the results of other people's thinking. Don't let the noise of others' opinions drown out your own inner" +
        " voice. And most important, have the courage to follow your heart and intuition. They somehow already know what you truly want to become. Everything else is secondary. When I" +
        " was young, there was an amazing publication called The Whole Earth Catalog, which was one of the bibles of my generation. It was created by a fellow named Stewart Brand not" +
        " far from here in Menlo Park, and he brought it to life with his poetic touch. This was in the late 1960s, before personal computers and desktop publishing, so it was all made" +
        " with typewriters, scissors and Polaroid cameras. It was sort of like Google in paperback form, 35 years before Google came along: It was idealistic, and overflowing with neat" +
        " tools and great notions. Stewart and his team put out several issues of The Whole Earth Catalog, and then when it had run its course, they put out a final issue. It was the " +
        "mid-1970s, and I was your age. On the back cover of their final issue was a photograph of an early morning country road, the kind you might find yourself hitchhiking on if" +
        " you were so adventurous. Beneath it were the words: Stay Hungry. Stay Foolish. It was their farewell message as they signed off. Stay Hungry. Stay Foolish. And I have always" +
        " wished that for myself. And now, as you graduate to begin anew, I wish that for you. Stay Hungry. Stay Foolish.";
        }
    }
}
