//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_App.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answering_the_Question
    {
        public int id { get; set; }
        public int question_id { get; set; }
        public int question_answer_id { get; set; }
        public int characteristic_id { get; set; }
        public int characteristic_answer_id { get; set; }
    
        public virtual Answers_to_the_Characteristics Answers_to_the_Characteristics { get; set; }
        public virtual Answers_to_the_Questions Answers_to_the_Questions { get; set; }
        public virtual Characteristics Characteristics { get; set; }
        public virtual Questions Questions { get; set; }
    }
}
