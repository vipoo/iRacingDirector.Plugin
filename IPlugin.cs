using System.Drawing;

namespace iRacingDirector
{
    public interface IPlugin
    {
        void DrawIntroFlashCard(long timestamp, int page);
    }
}
