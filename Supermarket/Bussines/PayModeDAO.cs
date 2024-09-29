using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;
namespace Supermarket.Bussines
{
    internal class PayModeDAO
    {
        private readonly Dictionary<int, PayMode> PayModeList;
        private static int payModeSecuencial;

        public PayModeDAO() {
            PayModeList = new Dictionary<int, PayMode>();
            payModeSecuencial = 0;
        }
        public bool AddPayMode(PayMode payMode) {
            try
            {
                payMode.Id = ++payModeSecuencial;
                PayModeList.Add((int)payMode.Id, payMode);
            }
            catch (ArgumentException) {
                return false;
            }
            return true;
        }
        public bool RemovePayMode(int id) {
            bool idExists = PayModeList.ContainsKey(id);
            if (idExists) {
                PayModeList.Remove(id);
                return true;
            }
            return false;
        }
        public PayMode GetPayMode(int id) {
            bool idExists = PayModeList.ContainsKey(id);
            if (idExists) {
                PayMode payMode = PayModeList[id];
                return payMode;
            }
            return null;
        }
        public bool UpdatePayMode(int id, PayMode payMode) {
            bool idExists = PayModeList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    PayModeList[id] = payMode;
                    return true;
                }
                catch (KeyNotFoundException) {
                    return false;
                }
            }
            return false;
        }
        public Dictionary<int, PayMode> GetPayModeList() {
            return PayModeList;
        }
    }
}
