﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.Common.ApiContext;

namespace XComponent.Authentication.Common
{
    public interface IInternalCommunication
    {
        void Init(string configFile);

        void Send(Context context, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.InitializationSuccess evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.InitializationError evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.CheckLogin evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.CreateHeartBeat evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.LoginSuccess evt, string privateTopic = null);

        void Send(Context context, XComponent.Authentication.UserObject.LoginError evt, string privateTopic = null);

        void SendEvent(XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.InitializationSuccess evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.InitializationError evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.CheckLogin evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.CreateHeartBeat evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.LoginSuccess evt, string privateTopic = null);

        void SendEvent(XComponent.Authentication.UserObject.LoginError evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Common.Event.DefaultEvent evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.InitializationSuccess evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.InitializationError evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.CheckLogin evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.CreateHeartBeat evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.LoginSuccess evt, string privateTopic = null);

        void SendEvent(StdEnum stdEnum, XComponent.Authentication.UserObject.LoginError evt, string privateTopic = null);

    }
}
