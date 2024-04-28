﻿using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterfaces
{
    /// <summary>
    /// AUTHOR: Jared Roberts
    /// <br />
    /// CREATED: 2024-04-28
    /// UPDATER: Jared Roberts
    /// <br />
    /// UPDATED: 2024-04-28
    /// <br />
    ///     Initial Creation
    /// </remarks>
    public interface IMaintenanceScheduleAccessor
    {
        ///     A method that returns scheduled sevice orders that are incomplete
        /// </summary>
        /// <returns>
        ///    <see cref="List{MaintenanceScheduleVM}">MaintenanceScheduleVM</see>: The list of all incomplete scheduled service orders.
        /// </returns>
        ///    CONTRIBUTOR: Jared Roberts
        /// <br />
        ///    CREATED: 2024-04-28
        /// <br />
        ///    Initial Creation
        /// </remarks>
        List<MaintenanceScheduleVM> SelectAllIncompleteMaintenanceSchedule();
        ///     A method that returns scheduled sevice orders that are complete
        /// </summary>
        /// <returns>
        ///    <see cref="List{MaintenanceScheduleVM}">MaintenanceScheduleVM</see>: The list of all complete scheduled service orders.
        /// </returns>
        ///    CONTRIBUTOR: Jared Roberts
        /// <br />
        ///    CREATED: 2024-04-28
        /// <br />
        ///    Initial Creation
        /// </remarks>
        List<MaintenanceScheduleVM> SelectAllCompleteMaintenanceSchedule();
        ///     A method that returns all scheduled sevice orders
        /// </summary>
        /// <returns>
        ///    <see cref="List{MaintenanceScheduleVM}">MaintenanceScheduleVM</see>: The list of all complete scheduled service orders.
        /// </returns>
        ///    CONTRIBUTOR: Jared Roberts
        /// <br />
        ///    CREATED: 2024-04-28
        /// <br />
        ///    Initial Creation
        /// </remarks>
        List<MaintenanceScheduleVM> SelectAllMaintenanceSchedule();
    }
}
