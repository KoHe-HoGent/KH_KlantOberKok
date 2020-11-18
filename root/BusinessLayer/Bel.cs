using System;
using BusinessLayer.Events;

namespace KlantOberKok
{
    public class Bel
    {
        public event EventHandler<BestelEventArgs> RingEvent;

        public void Ring(BestelEventArgs args)
        {
            RingEvent?.Invoke(this, args);
        }
    }
}