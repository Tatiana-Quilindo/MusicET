using Borrador3Proyecto.Data.Repositories;
using Borrador3Proyecto.Data;
using System;
using System.Collections.ObjectModel;

namespace Borrador3Proyecto
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-------Create");
            Connection dbConn = new Connection();
            EmotionRepository EmotionRepo = new EmotionRepository(dbConn);
            Emotion newEmotion = new Emotion(string.Empty, "Alegria", 1);
            EmotionRepo.Insert(newEmotion);

            Console.WriteLine("------finAll");

            var all = EmotionRepo.FindAll();

            foreach (var item in all) 
            { 
            
                Console.WriteLine($"{item.Id}) {item.Emocion} {item.MusicList}");
            }

            Console.WriteLine("------Find by id");

            var oneEntity = EmotionRepo.FindById(all.First().Id);
            Console.WriteLine($"{oneEntity.Id}{oneEntity.Emocion}{oneEntity.MusicList}");

            Console.WriteLine("------Delete");

            EmotionRepo.Delete(all.First().Id);

            Console.WriteLine("------Update");

            Emotion updateEmotion =all.Last();
            updateEmotion.Emocion = "Ansiedad";

            EmotionRepo.Update(updateEmotion);
            //updateEmotion.MusicList = 1;

            //EmotionApp.Run();
        }
    }
}
