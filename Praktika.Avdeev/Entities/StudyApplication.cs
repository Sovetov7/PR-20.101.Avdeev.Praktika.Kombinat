//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika.Avdeev.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudyApplication
    {
        public int StudyApplicationID { get; set; }
        public int CourseID { get; set; }
        public int SolutionID { get; set; }
        public int WorkerID { get; set; }
    
        public virtual SolutionForStudy SolutionForStudy { get; set; }
        public virtual StudyCourse StudyCourse { get; set; }
        public virtual User User { get; set; }
    }
}
