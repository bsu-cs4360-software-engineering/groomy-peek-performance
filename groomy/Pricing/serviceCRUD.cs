using Google.Api;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Pricing
{
    public class ServicesCRUD : serviceInterface

    {

        private FirestoreDb __db;

        private string __collectionName;


        public ServicesCRUD(FirestoreDb db, string collectionName)

        {

            __collectionName = collectionName;

            __db = db;

        }


        public async Task CreateService(Service addableService)

        {

            DocumentReference docRef = __db.Collection(__collectionName).Document();

            addableService.Id = docRef.Id;

            addableService.Deleted = false;

            await docRef.SetAsync(addableService);

        }


        public async Task<Service> GetService(string documentID)

        {

            DocumentReference docRef = __db.Collection(__collectionName).Document(documentID);

            var serviceSnapshot = await docRef.GetSnapshotAsync();

            return serviceSnapshot.ConvertTo<Service>();

        }


        public async Task SoftDeleteService(string documentID)

        {

            DocumentReference docRef = __db.Collection(__collectionName).Document(documentID);

            var serviceSnapshot = await docRef.GetSnapshotAsync();

            if (serviceSnapshot.Exists)

            {

                var service = serviceSnapshot.ConvertTo<Service>();

                service.Deleted = true;

                await docRef.SetAsync(service, SetOptions.MergeAll);

            }

        }


        public async Task UpdateService(Service updatedService)

        {

            DocumentReference docRef = __db.Collection(__collectionName).Document(updatedService.Id);

            await docRef.SetAsync(updatedService, SetOptions.MergeAll);

        }


        public async Task<List<Service>> GetAllServices()

        {

            CollectionReference collectionRef = __db.Collection(__collectionName);

            List<Service> services = new List<Service>();

            var snapshots = await collectionRef.GetSnapshotAsync();

            foreach (var snapshot in snapshots)

            {

                var service = snapshot.ConvertTo<Service>();

                if (!service.Deleted) // Only return non-deleted services

                {

                    services.Add(service);

                }

            }

            return services;

        }

    }
}