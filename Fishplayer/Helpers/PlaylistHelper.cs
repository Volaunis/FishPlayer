using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fishplayer.Models;

namespace Fishplayer.Helpers
{
    public class PlaylistHelper
    {
        private List<Track> _list = new List<Track>();

        private Track _activeTrack = null;
        private int _activeTrackIndex = -1;

        public void AddTrack(string filePath)
        {
            _list.Add(new Track(filePath));
        }

        public void AddTracks(List<string> filePaths)
        {
            filePaths.ForEach(f => _list.Add(new Track(f)));
        }

        public void RemoveIndex(int index)
        {
            if (_list.Count > index)
            {
                _list.RemoveAt(index);
                // TODO handle index change for active track
            }
        }

        public void RemveIndexes(List<int> indexes)
        {
            var sortedIndexes = indexes.OrderBy(i => i).ToList();

            if(_list.Count>sortedIndexes.Max())
            {
                sortedIndexes.OrderByDescending(i => i).ToList();
                sortedIndexes.ForEach(i => _list.RemoveAt(i));
                // TODO handle index change for active track
            }
        }

    }
}
