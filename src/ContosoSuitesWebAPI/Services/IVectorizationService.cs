﻿using ContosoSuitesWebAPI.Entities;

namespace ContosoSuitesWebAPI.Services
{
    public interface IVectorizationService
    {
        Task<ReadOnlyMemory<float>> GetEmbeddings(string text); 

        // Exercise 3 Task 3 TODO #1: Uncomment the following line of code to provide an execute a vector search method against Cosmos DB.
        //Task<List<VectorSearchResult>> ExecuteVectorSearch(float[] queryVector, int count = 0);
    }
}
