namespace EducationalSystem.Entities;

public class Request
{
    public Request(string name, string reqId, string requestMassage, string answer, Score? score)
    {
        Name = name;
        ReqId = reqId;
        RequestMassage = requestMassage;
        Answer = answer;
        Score = score;
    }

    public string Name { get; private set; }
    public string ReqId { get; private set; }
    public string RequestMassage { get; private set;  }
    public string Answer { get; private set;  }
    private static Score? Score { get; set; }

    public double? StudentAvg { get; } = Score?.Average;
    
    public enum Status
    {
        Sent,
        Current,
        Referred, // ارجاع شده                              
        Rejected, 
        Confirmed,
        Terminated
    }
    
    public enum ReqType
    {
        TopStudent,  // دانشجوی برتر                  
        EducationalExemption, // معافیت تحصیلی       
        RemoveSemester,        // حذف ترم        
        StudyLeave,             // مرحصی تحصیلی 
        Graduation  // فارغ التحصیلی             
    }
    
}