using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndDatabases
{
    /// <summary>
    /// Represents a single piece of computer equipment
    /// </summary>
    class Equipment
    {
        /// <summary>
        /// Primary key for equipment
        /// </summary>
        public int EquipmentId { get; set; }

        /// <summary>
        /// The name of the equipment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Retail price of the equipment
        /// </summary>
        public double Price { get; set; }
    }
}