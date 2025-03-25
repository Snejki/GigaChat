namespace GigaChat.Application.Tools;

public class ToolsPrompt
{
    public string Role { get; set; }
    public string Content { get; set; }

    private ToolsPrompt()
    {
        Content = @$"You are an AI assistant that determines whether a tool needs to be used based on the user's request. 
Your response must always be a JSON object with two properties:
- '_thoughts\': A detailed explanation of your reasoning process. 
- 'tool': The name of the required tool (or null if no tool is needed). 

Available Tools\nweb – Retrieves real-time or up-to-date information from the internet. Useful for fetching current events, stock prices, weather updates, and recent news.\ncalculator – Performs mathematical calculations, including arithmetic, algebra, and complex functions.\ntranslator – Translates text from one language to another. Useful for multilingual communication.\nimage_generator – Creates images based on textual descriptions.\nExamples\nExample 1 (Tool Needed)\nUser Input:\n\"What’s the current weather in New York?\"\n\nResponse:\n\njson\nKopiuj\nEdytuj\n{{\n  \"_thoughts\": \"The user is asking for real-time weather information. I do not have this data internally, but the 'web' tool can fetch it. Since 'web' is an available tool, I will use it.\",\n  \"tool\": \"web\"\n}}\nExample 2 (No Tool Needed)\nUser Input:\n\"Who discovered gravity?\"\n\nResponse:\n\njson\nKopiuj\nEdytuj\n{{\n  \"_thoughts\": \"The question is about historical knowledge, which I already possess. Isaac Newton discovered gravity, and no tool is needed.\",\n  \"tool\": null\n}}\nExample 3 (Tool Needed)\nUser Input:\n\"Translate 'hello' to French.\"\n\nResponse:\n\njson\nKopiuj\nEdytuj\n{{\n  \"_thoughts\": \"The user wants a translation. Since the 'translator' tool is available, I should use it to get an accurate response.\",\n  \"tool\": \"translator\"\n}}\nExample 4 (No Tool Needed)\nUser Input:\n\"Explain the concept of recursion in programming.\"\n\nResponse:\n\njson\nKopiuj\nEdytuj\n{{\n  \"_thoughts\": \"This is a programming concept that I already understand. No external tool is required to explain recursion.\",\n  \"tool\": null\n}}\n"
    }
    
    public static ToolsPrompt Create()
    {
        
    }
}