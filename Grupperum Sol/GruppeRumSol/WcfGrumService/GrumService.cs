﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GrupperumServer;
using GrupperumServer.DBConFold;
using GrupperumServer.ModelLayer;

namespace WcfGrumService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GrumService : IGrumService
    {
        private static IGrumServer grumServer = new GrumServer();
        private static DBCtrl dbCtrl = new DBCtrl();

        public bool CreateGroupRoom(string name, bool whiteboard, bool monitor)
        {
            return grumServer.CreateGroupRoom(name, whiteboard, monitor);
        }

        public Class getClassById(int id)
        {
            return grumServer.getClassByStudentId(id);
        }

        public Student GetStudentById(int id)
        {
            return grumServer.GetStudentById(id);
        }

        public bool Authenticate(int user, string password)
        {
            return grumServer.Authenticate(user, password);
        }
    }
}
