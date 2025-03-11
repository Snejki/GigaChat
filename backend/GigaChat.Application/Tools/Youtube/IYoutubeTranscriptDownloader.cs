namespace GigaChat.Application.Tools.Youtube;

public interface IYoutubeTranscriptDownloader
{
    List<TranscriptionItem> Handle(string id);
}

public class TranscriptionItem
{
    public string Text { get; init; }

    public float Start { get; init; }

    public float Duration { get; init; }
}