﻿namespace Octopus.CoreDomain.Events.Teller
{
    public class OpenAmountNegativeDifferenceEvent : TellerEvent
    {
        public override string Code
        {
            get { return "ONDE"; }
            set { }
        }
    }
}