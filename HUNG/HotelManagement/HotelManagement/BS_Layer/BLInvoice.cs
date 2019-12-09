﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HotelManagement.BS_Layer
{
    class BLInvoice
    {
        public System.Data.Linq.Table<Invoice> LoadInvoice()
        {
            DataSet ds = new DataSet();
            HotelManagementDataContext hm = new HotelManagementDataContext();
            return hm.Invoices;
        }
        public bool Checkin(string CustomerID, string RoomID,string EmployeeID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_CheckIn(Convert.ToInt32(CustomerID), Convert.ToInt32(RoomID),Convert.ToInt32(EmployeeID));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateInvoice(string InvoiceID, string CustomerID, string RoomID, string NumberOfDay, string EmployeeID, string InvoiceTotal, string CheckInDate, string CheckOutDate, bool CheckInvoice)
        {
            try
            {
                //HotelManagementDataContext db = new HotelManagementDataContext();
                //db.sp_UpdateInvoice(Convert.ToInt32(InvoiceID), Convert.ToInt32(CustomerID), Convert.ToInt32(RoomID), Convert.ToByte(NumberOfDay), Convert.ToInt32(EmployeeID), Convert.ToDecimal(InvoiceTotal), Convert.ToDateTime(CheckInDate), Convert.ToDateTime(CheckOutDate), CheckInvoice);
                //db.Invoices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteInvoice( string InvoiceID)
        {
            try
            {
                HotelManagementDataContext db = new HotelManagementDataContext();
                db.sp_DeleteInvoices(Convert.ToInt32(InvoiceID));
                db.Invoices.Context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}