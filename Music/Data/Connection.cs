using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Borrador3Proyecto.Data
{
    public class Connection
    {
        public FirestoreDb FirestoreDb { get; set; }

        public Connection()
        {
            var filePath = @"Data\musicemotions-cf347-firebase-adminsdk-ld0qe-2a4f43257e.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            FirestoreDb = FirestoreDb.Create("musicemotions-cf347");
            

        }
    }
}
