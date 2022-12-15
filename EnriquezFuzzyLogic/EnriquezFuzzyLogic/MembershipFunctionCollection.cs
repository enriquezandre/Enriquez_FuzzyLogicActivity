using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DotFuzzy
{
    /// <summary>
    /// Represents a collection of membership functions.
    /// </summary>
    public class MembershipFunctionCollection : Collection<MembershipFunction>
    {
        #region Public Methods

        /// <summary>
        /// Finds a membership function in a collection.
        /// </summary>
        /// <param name="membershipFunctionName">Membership function name.</param>
        /// <returns>The membership function, if founded.</returns>
        public MembershipFunction Find(string membershipFunctionName)
        {
            MembershipFunction membershipFunction = null;

            foreach (MembershipFunction function in this)
            {
                if (function.Name == membershipFunctionName)
                {
                    membershipFunction = function;
                    break;
                }
            }

            if (membershipFunction == null)
                throw new Exception("MembershipFunction not found: " + membershipFunctionName);
            else
                return membershipFunction;
        }

        #endregion
    }
}
