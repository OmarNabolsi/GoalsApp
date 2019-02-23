using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoalsApp.API.Models
{
    public class Plan
    {
        [Key]
        public int DevPlanID { get; set; }
        public int GoalID { get; set; }
        public string DevelopmentPlan { get; set; }
        public string DevelopmentPlanDesc { get; set; }
        
        [Column(TypeName="Money")]
        public decimal Cost { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<DateTime> UpdatedDate { get; set; }
    }
}