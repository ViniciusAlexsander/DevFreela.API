﻿namespace DevFreela.API.Models
{
    public class CreateCommentModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
