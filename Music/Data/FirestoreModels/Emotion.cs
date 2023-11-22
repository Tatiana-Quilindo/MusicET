using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrador3Proyecto.Data.FirestoreModels
{
    [FirestoreData]
    public class Emotion
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Emocion { get; set; }

    }
}
