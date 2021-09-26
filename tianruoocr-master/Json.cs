public class Rootobject
{
    public string from { get; set; }
    public string to { get; set; }
    public Trans_Result[] trans_result { get; set; }
}

public class Trans_Result
{
    public string src { get; set; }
    public string dst { get; set; }
}