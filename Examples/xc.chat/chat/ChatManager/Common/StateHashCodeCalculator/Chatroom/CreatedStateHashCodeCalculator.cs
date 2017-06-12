﻿using System;
using System.Collections.Generic;
using XComponent.Common.Helper;
using XComponent.Engine.Execution.HashCode;

namespace XComponent.ChatManager.Common.StateHashCodeCalculator.Chatroom
{
    public class CreatedStateHashCodeCalculator : IStateHashCodeCalculator<XComponent.ChatManager.UserObject.Chatroom, Object>
    {
        public ISet<int> Calculate(XComponent.ChatManager.UserObject.Chatroom publicMember, Object internalMember)
        {
            var hashcodes = new HashSet<int>();

            hashcodes.Add(0);
            return hashcodes;
        }
    }
}