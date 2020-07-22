using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace orders.Models
{
    //[DataContract]
    //public class BaseModel
    //{
    //    [DataMember]
    //    public int ID { get; protected set; }
    //}

    public class Orders //: BaseModel
    {
        public Orders()
        {
        }

        public Orders(int iD, string iTEM, int qTD, decimal vALORUNITARIO, decimal tOTAL, string cLIENTE, string cANAL)
        {
            ID = iD;
            ITEM = iTEM;
            QTD = qTD;
            VALORUNITARIO = vALORUNITARIO;
            TOTAL = tOTAL;
            CLIENTE = cLIENTE;
            CANAL = cANAL;
        }

        [Required]
        public Int32 ID { get; private set; }

        [Required]
        public string ITEM { get; private set; }

        [Required]
        public Int32 QTD { get; private set; }

        [Required]
        public Decimal VALORUNITARIO { get; private set; }

        [Required]
        public Decimal TOTAL { get; private set; }


        [Required]
        public string CLIENTE { get; private set; }
        [Required]
        public string CANAL { get; private set; }

   }

    public class cOrders //: BaseModel
    {
        public List<Orders> ListaOrders { get; private set; }
        public List<string> ListaCanal { get; private set; }
    }
    }
