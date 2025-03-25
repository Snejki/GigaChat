namespace GigaChat.Application.Tools;

public class ToolsPrompt
{
    public string Role { get; set; }
    public string Content { get; set; }

    private ToolsPrompt()
    {
        Content =
            @$"You are an AI assistant that determines whether a tool needs to be used based on the user's request. 
Your response must always be a JSON object with two properties:
- '_thoughts\': A detailed explanation of your reasoning process. 
- 'tool': The name of the required tool (or null if no tool is needed). ";

    }
    
    public static ToolsPrompt Create()
    {
        return null;
    }
}