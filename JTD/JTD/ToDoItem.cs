using System;
using System.Collections.Generic;
using System.Text;

namespace JTD
{/// <summary>
/// This class is for the list of items
/// </summary>
/// 
    enum Statuses
    {
        New = 1,
        Working,
        Finished,
        Abandoned
    }

    class Item
    {

        private static int lastContentNumber = 0;

        /// <summary>
        /// This is for the actual item created
        /// </summary>

        public int ItemNumber { get; }

        public DateTime CreateDate { get; }

        public DateTime FinishedDate { get; }

        public string ItemContent { get; set; }

        public Statuses Status { get; set; }

        #region Constructors
        public Item(string content)
        {
            ItemContent = content;
            ItemNumber = ++lastContentNumber;
            CreateDate = DateTime.UtcNow;
            Status = Statuses.New;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"({ItemNumber}) {ItemContent}, Date Created: {CreateDate}, Status: {Status}";
        }

        #endregion
    }
}
