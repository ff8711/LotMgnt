using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LotteryMgnt
{
    class LotTrans
    {
        private string _CustId, _CustName,_ItemId,_ItemName,_Description,_Code;
        private float _Price, _inpQuantity,_outQuantity,_Amount;
        private DateTime _Date;
    //string
        public string CustId
        {
            get { return _CustId;}
            set {_CustId = value;}
        }
        public string CustName
        {
            get { return _CustName;}
            set {_CustName = value;}
        }
        public string ItemId
        {
            get { return _ItemId;}
            set {_ItemId = value;}
        }
        public string ItemName
        {
            get { return _ItemName;}
            set {_ItemName = value;}
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
    //float
        public float Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        public float inpQuantity
        {
            get { return _inpQuantity; }
            set { _inpQuantity = value; }
        }
        public float outpQuantity
        {
            get { return _outQuantity; }
            set { _outQuantity = value; }
        }
    //Date  
        public DateTime Date 
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public int Insert(LotTrans lt)
        {

        }
        //public int InsertNumberByTxt(string cmdTxt, string connectStr, string PackingId)
        //{
        //    SqlConnection cnn = new SqlConnection(connectStr);
        //    SqlCommand cmd = new SqlCommand(cmdTxt, cnn);
        //    cmd.CommandType = CommandType.Text;
        //    return cmd.ExecuteNonQuery();
        //}
    }
}
