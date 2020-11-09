using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace TriviaApp
{
    /*
     * // 20201108200319
// https://opentdb.com/api.php?amount=1&category=10&difficulty=medium

{
  "response_code": 0,
  "results": [
    {
      "category": "Entertainment: Books",
      "type": "multiple",
      "difficulty": "medium",
      "question": "Who wrote the children&#039;s story &quot;The Little Match Girl&quot;?",
      "correct_answer": "Hans Christian Andersen",
      "incorrect_answers": [
        "Charles Dickens",
        "Lewis Carroll",
        "Oscar Wilde"
      ]
    }
  ]
}
     */
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&category=10&difficulty=medium";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());

            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; i++)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            Console.WriteLine("~Trivia Time~");
            Console.WriteLine("\n" + trivia.results[0].question + "\n");

            Random rand = new Random();
            int x = rand.Next(0, 4);
            int questionsDisplayed = 0;

            for(int i = 0; i < x; i++)
            {
                questionsDisplayed++;
                Console.WriteLine(questionsDisplayed + ". " + trivia.results[0].incorrect_answers[i]);
            }

            questionsDisplayed++;
            Console.WriteLine(questionsDisplayed + ". " + trivia.results[0].correct_answer);
            
            for(int j = questionsDisplayed - 1; j < 3; j++)
            {
                questionsDisplayed++;
                Console.WriteLine(questionsDisplayed + ". " + trivia.results[0].incorrect_answers[j]);
            }

            string userInput = Console.ReadLine();
            Console.WriteLine("\nYour answer was: " + userInput);
        }
    }
}
