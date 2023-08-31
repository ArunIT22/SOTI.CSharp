using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOTI.CSharp.Day8SOLID
{
    internal interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void NextSong();
        void PreviousSong();
    }

    public interface IFeaturePhoneMusicPlayer
    {
        void Rewind();
        void Forward();
    }

    public class Nokia6610 : IMusicPlayer, IFeaturePhoneMusicPlayer
    {
        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void NextSong()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void PreviousSong()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class iPhone14Pro : IMusicPlayer
    {
        public void NextSong()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void PreviousSong()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
