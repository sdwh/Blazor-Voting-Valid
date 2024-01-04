namespace Blazor_Voting_Valid.Models
{
    public class Question
    {
        public int Id { get; set; }
        public bool Valid { get; set; }
        public string Src { get; set; } = "";

        public string Description { get; set; } = "Lorem Ipsum";
    }
    public static class QuestionManage
    {
        public static List<Question> LoadQuestions()
        {
            return new List<Question>
            {
                new Question { Id = 1, Src ="valid_1.png", Valid = true},
                new Question { Id = 2, Src ="valid_2.png", Valid = true},
                new Question { Id = 3, Src ="valid_3.png", Valid = true},
                new Question { Id = 4, Src ="valid_4.png", Valid = true},
                new Question { Id = 5, Src ="valid_5.png", Valid = true},
                new Question { Id = 6, Src ="valid_6.png", Valid = true},
                new Question { Id = 7, Src ="valid_7.png", Valid = true},
                new Question { Id = 8, Src ="valid_8.png", Valid = true},
                new Question { Id = 9, Src ="valid_9.png", Valid = true},
                new Question { Id = 10, Src ="valid_10.png", Valid = true},
                new Question { Id = 11, Src ="valid_11.png", Valid = true},
                new Question { Id = 12, Src ="valid_12.png", Valid = true},
                new Question { Id = 13, Src ="valid_13.png", Valid = true},
                new Question { Id = 14, Src ="valid_14.png", Valid = true},
                new Question { Id = 15, Src ="valid_15.png", Valid = true},
                new Question { Id = 16, Src ="valid_16.png", Valid = true},
                new Question { Id = 17, Src ="valid_17.png", Valid = true},
                new Question { Id = 18, Src ="valid_18.png", Valid = true},
                new Question { Id = 19, Src ="valid_19.png", Valid = true},
                new Question { Id = 20, Src ="valid_20.png", Valid = true},
                new Question { Id = 21, Src ="valid_21.png", Valid = true},
                new Question { Id = 22, Src ="valid_22.png", Valid = true},
                new Question { Id = 23, Src ="valid_23.png", Valid = true},
                new Question { Id = 24, Src ="valid_24.png", Valid = true},
                new Question { Id = 25, Src ="valid_25.png", Valid = true},
                new Question { Id = 26, Src ="valid_26.png", Valid = true},
                new Question { Id = 27, Src ="valid_27.png", Valid = true},
                new Question { Id = 28, Src ="valid_28.png", Valid = true},
                new Question { Id = 29, Src ="invalid_2.png", Valid = false},
                new Question { Id = 30, Src ="invalid_3.png", Valid = false},
                new Question { Id = 31, Src ="invalid_4.png", Valid = false},
                new Question { Id = 32, Src ="invalid_5.png", Valid = false},
                new Question { Id = 33, Src ="invalid_6.png", Valid = false},
                new Question { Id = 34, Src ="invalid_7.png", Valid = false},
                new Question { Id = 35, Src ="invalid_8.png", Valid = false},
                new Question { Id = 36, Src ="invalid_9.png", Valid = false},
                new Question { Id = 37, Src ="invalid_10.png", Valid = false},
                new Question { Id = 38, Src ="invalid_11.png", Valid = false},
                new Question { Id = 39, Src ="invalid_12.png", Valid = false},
                new Question { Id = 40, Src ="invalid_13.png", Valid = false},
                new Question { Id = 41, Src ="invalid_14.png", Valid = false},
                new Question { Id = 42, Src ="invalid_15.png", Valid = false},
                new Question { Id = 43, Src ="invalid_16.png", Valid = false},
                new Question { Id = 44, Src ="invalid_17.png", Valid = false},
                new Question { Id = 45, Src ="invalid_18.png", Valid = false},
                new Question { Id = 46, Src ="invalid_19.png", Valid = false},
                new Question { Id = 47, Src ="invalid_20.png", Valid = false},
                new Question { Id = 48, Src ="invalid_21.png", Valid = false},
                new Question { Id = 49, Src ="invalid_22.png", Valid = false},
                new Question { Id = 50, Src ="invalid_23.png", Valid = false},
                new Question { Id = 51, Src ="invalid_24.png", Valid = false},
            };
        }
    }
}
