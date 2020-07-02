using System;

namespace BusinessRulesEngine
{
    public class RoyaltyDepartment
    {
        private bool _duplicateSlip = false;
        public bool Royalty(bool duplicateSlip)
        {
            _duplicateSlip = duplicateSlip;

            if (_duplicateSlip == true)
            {
                Console.WriteLine("Duplicate Slip Recieved by Royalty Department");
                return true;
            }
            return false;
        }
    }
}
