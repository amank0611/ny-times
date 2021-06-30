namespace NewYorkTimes.Core.DTOs
{
    public class ResponseDto
    {
        public Debug debug { get; set; }
        public string status { get; set; }
        public string copyright { get; set; }
        public Results results { get; set; }
    }

    public class Debug
    {
        public float version { get; set; }
    }

    public class Results
    {
        public Comment[] comments { get; set; }
        public int page { get; set; }
        public int totalCommentsReturned { get; set; }
        public int totalCommentsFound { get; set; }
        public int totalParentCommentsFound { get; set; }
        public int totalParentCommentsReturned { get; set; }
        public int totalReplyCommentsFound { get; set; }
        public int totalReplyCommentsReturned { get; set; }
        public int totalReporterReplyCommentsFound { get; set; }
        public int totalReporterReplyCommentsReturned { get; set; }
        public int totalEditorsSelectionFound { get; set; }
        public int totalEditorsSelectionReturned { get; set; }
        public int totalRecommendationsFound { get; set; }
        public int totalRecommendationsReturned { get; set; }
        public int replyLimit { get; set; }
        public int depthLimit { get; set; }
        public string sort { get; set; }
        public string filter { get; set; }
        public object callerID { get; set; }
        public string api_timestamp { get; set; }
    }

    public class Comment
    {
        public int commentID { get; set; }
        public string status { get; set; }
        public int commentSequence { get; set; }
        public int userID { get; set; }
        public string userDisplayName { get; set; }
        public string userLocation { get; set; }
        public object userTitle { get; set; }
        public object userURL { get; set; }
        public string commentTitle { get; set; }
        public string commentBody { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string approveDate { get; set; }
        public int recommendations { get; set; }
        public int replyCount { get; set; }
        public object[] replies { get; set; }
        public bool editorsSelection { get; set; }
        public object parentID { get; set; }
        public object parentUserDisplayName { get; set; }
        public int depth { get; set; }
        public string commentType { get; set; }
        public int trusted { get; set; }
        public object recommendedFlag { get; set; }
        public object reportAbuseFlag { get; set; }
        public string permID { get; set; }
        public string picURL { get; set; }
        public int timespeople { get; set; }
        public int sharing { get; set; }
    }
}
