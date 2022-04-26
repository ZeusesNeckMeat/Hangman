using System;
using System.Net.Http;

namespace Hangman.Services
{
    internal class RandomWordService
    {
        public string GetRandomWord()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://random-word-api.herokuapp.com/");

            var result = client.GetAsync("word?lang=en").Result;
            var resultContent = result.Content.ReadAsStringAsync().Result;

            if (!result.IsSuccessStatusCode)
                throw new HttpRequestException($"Failed to retrieve a random word: {resultContent}");

            resultContent = resultContent.Replace("\"", string.Empty)
                                         .Replace("[", string.Empty)
                                         .Replace("]", string.Empty);

            return resultContent;
        }
    }
}