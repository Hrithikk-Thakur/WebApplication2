using Microsoft.AspNetCore.Mvc;
using QuestionAPI.Models;

namespace QuestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Question>> GetQuestions()
        {
            var options = new List<string>
            {
                "Strongly Disagree", "Disagree", "Unsure", "Agree", "Strongly Agree"
            };

            var questions = new List<Question>
            {
                new Question { Id = 1, Text = "I like to build kitchen cabinets", Options = options },
                new Question { Id = 2, Text = "I enjoy solving mathematical problems", Options = options },
                new Question { Id = 3, Text = "I find it easy to communicate with others", Options = options },
                new Question { Id = 4, Text = "I prefer working alone rather than in a team", Options = options },
                new Question { Id = 5, Text = "I enjoy learning new languages", Options = options },
                new Question { Id = 6, Text = "I feel comfortable speaking in public", Options = options },
                new Question { Id = 7, Text = "I enjoy painting and drawing", Options = options },
                new Question { Id = 8, Text = "I like to work with numbers and data", Options = options },
                new Question { Id = 9, Text = "I am interested in how machines work", Options = options },
                new Question { Id = 10, Text = "I like organizing events and planning schedules", Options = options },
                new Question { Id = 11, Text = "I enjoy working with animals", Options = options },
                new Question { Id = 12, Text = "I like to read books in my free time", Options = options },
                new Question { Id = 13, Text = "I enjoy working with computers", Options = options },
                new Question { Id = 14, Text = "I am interested in history and culture", Options = options },
                new Question { Id = 15, Text = "I like helping people solve their problems", Options = options },
                new Question { Id = 16, Text = "I prefer physical work over sitting at a desk", Options = options },
                new Question { Id = 17, Text = "I enjoy listening to music and playing instruments", Options = options },
                new Question { Id = 18, Text = "I am good at remembering details", Options = options },
                new Question { Id = 19, Text = "I like working with my hands and creating things", Options = options },
                new Question { Id = 20, Text = "I enjoy teaching others new skills", Options = options },
                new Question { Id = 21, Text = "I am interested in science and experiments", Options = options },
                new Question { Id = 22, Text = "I find it easy to adapt to new situations", Options = options },
                new Question { Id = 23, Text = "I prefer stability over taking risks", Options = options },
                new Question { Id = 24, Text = "I enjoy cooking and trying new recipes", Options = options },
                new Question { Id = 25, Text = "I am interested in space and the universe", Options = options },
                new Question { Id = 26, Text = "I like working with children", Options = options },
                new Question { Id = 27, Text = "I prefer structured environments over flexibility", Options = options },
                new Question { Id = 28, Text = "I enjoy designing things like clothes or interiors", Options = options },
                new Question { Id = 29, Text = "I am passionate about sports and fitness", Options = options },
                new Question { Id = 30, Text = "I enjoy writing essays and stories", Options = options }
            };

            return Ok(questions);
        }
    }
}
