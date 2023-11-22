using Google.Cloud.Firestore;
using System.Security.Cryptography;

namespace Borrador3Proyecto
{
   
    public class Emotion
    {
        private string _id { get; set; }
        private string _Emocion { get; set; }

        public List<MusicInfo> MusicList { get; set; }
        public string Id { get { return _id; } set { _id = value; } }
        public string Emocion { get { return _Emocion; } set { _Emocion = value; } }
        

        public Emotion(string id, string Emocion, int v)
        {
            _Emocion = Emocion;
            _id = id;
        }

        public Emotion(string id, string emocion)
        {
            Id = id;
            Emocion = emocion;
        }
    }
}
