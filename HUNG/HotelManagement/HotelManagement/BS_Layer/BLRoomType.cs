﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HotelManagement.BS_Layer
{
    class BLRoomType
    {
        public System.Data.Linq.Table<RoomType> LoadRoomType()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.RoomTypes;
        }
        public bool CreateRoomType( string Name, string Price)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_CreateRoomTypes(Name, Convert.ToDecimal(Price));
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
        public bool UpdateRoomType(int RoomTypeID, string Name, string Price)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_UpdateRoomTypes(Convert.ToByte(RoomTypeID) , Name, Convert.ToDecimal(Price)); 
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
        public bool DeleteRoomType(string RoomTypeID)
        {
            HotelManagementDataContext db = new HotelManagementDataContext();
            db.sp_DeleteRoomTypes(Convert.ToByte(RoomTypeID));
            db.RoomTypes.Context.SubmitChanges();
            return true;
        }
    }
}