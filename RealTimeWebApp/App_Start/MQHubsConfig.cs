﻿
using Messag.Utility.Config;
using Microsoft.AspNet.SignalR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Messag.Logger;
using BusniessEntities.Models;



namespace RealTimeApp
{
    /// <summary>
    /// MQHubsConfig
    /// </summary>
    public class MQHubsConfig
    {
        /// <summary>
        /// ILogger
        /// </summary>
        private static ILogger log = new Logger("MQHubsConfig");

        /// <summary>
        /// Registers the mq listen and hubs.
        /// </summary>
        public static void RegisterMQListenAndHubs()
        {
            var activemq = Megadotnet.MessageMQ.Adapter.ActiveMQListenAdapter<PushMessageModel>.Instance(MQConfig.MQIpAddress, MQConfig.QueueDestination);
            activemq.MQListener += m =>
            {
                log.InfoFormat("从MQ收到消息{0}", m.MSG_CONTENT);
                GlobalHost.ConnectionManager.GetHubContext<FeedHub>().Clients.All.receive(m);
            };

            activemq.ReceviceListener<PushMessageModel>();
        }
    }
}