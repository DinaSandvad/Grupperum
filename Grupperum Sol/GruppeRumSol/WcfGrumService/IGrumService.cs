using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GrupperumServer;
using GrupperumServer.ModelLayer;

namespace WcfGrumService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGrumService
    {
        [OperationContract]
        Class getClassById(int id);

        [OperationContract]
        bool CreateGroupRoom(string name, bool whiteboard, bool monitor);

        [OperationContract]
        bool Authenticate(int user, string password);

        [OperationContract]
        bool CreateGroup(string name, List<int> studentId);

        [OperationContract]
        bool UpdateGroupRoom(string name, bool whiteboard, bool monitor);

        [OperationContract]
        bool RequestClassRoom(int groupId, int groupSize, bool whiteboard, bool monitor, bool projector);

        [OperationContract]
        List<ClassRoom> GetClassRoomByAttributes(bool whiteboard, bool monitor, bool projector);

        [OperationContract]
        List<GroupRoom> GetGroupRooms();

        [OperationContract]
        bool HasGroupRooms();

        [OperationContract]
        List<GroupRoom> GetGroupRoomList(DateTime dateStart, DateTime dateEnd, int grStrl, bool whiteboard, bool monitor);

        [OperationContract]
        bool RentGroupRoom(int grouproomId, int groupId, DateTime dateStart, DateTime dateEnd);

        [OperationContract]
        void DoTheFunkyAlgorithm();
    }
}
