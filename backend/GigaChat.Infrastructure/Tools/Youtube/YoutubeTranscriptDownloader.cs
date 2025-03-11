using GigaChat.Application.Tools.Youtube;
using YoutubeTranscriptApi;

namespace GigaChat.Infrastructure.Tools.Youtube;

public class YoutubeTranscriptDownloader : IYoutubeTranscriptDownloader
{
    public List<TranscriptionItem> Handle(string id)
    {
        var youTubeTranscriptApi = new YouTubeTranscriptApi();
        var transcriptItems = youTubeTranscriptApi.GetTranscript(id);

        return transcriptItems.Select(x => new TranscriptionItem()
        {
            Duration = x.Duration,
            Start = x.Start,
            Text = x.Text
        }).ToList();
    }
}