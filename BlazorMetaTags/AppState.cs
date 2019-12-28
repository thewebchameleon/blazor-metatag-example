using System;

namespace BlazorMetaTags
{
    public class AppState
    {
        public MetaTags MetaTags { get; private set; } = new MetaTags();

        public event Action OnChange;

        public void SetMetaTags(MetaTags metatags)
        {
            MetaTags = metatags;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
