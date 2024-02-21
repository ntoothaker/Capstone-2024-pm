﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace LogicLayer
{
    /// <summary>
    /// AUTHOR: Isabella Rosenbohm, Jared Roberts, Jacob Wendt
    /// <br />
    /// CREATED: 2024-02-05
    /// <br />
    /// 
    ///     Provides CRUD operations on the data source for client data.
    /// </summary>
    /// 
    /// <remarks>
    /// UPDATER: Jared Roberts
    /// <br />
    ///    UPDATED: 2024-02-11
    /// <br />
    ///     Changed the argument type for the EditClient method from int to Client_VM &
    ///     Changed the return type for the GetClientById method from Client to Client_VM
    /// </remarks>

    public interface IClientManager
    {
        int AddClient(Client client);
        Client_VM GetClientById(int id);
        /// <summary>
        ///     A method that returns an IEnumerable containing all Client_VM records.
        ///     Method does not take in any parameters.
        /// </summary>
        /// <remarks>
        ///    Exceptions:
        /// <br />
        ///   Throws an application exception when it catches an exception from ClientAccessor.
        /// <br /><br />
        ///    CONTRIBUTOR: Isabella Rosenbohm
        /// <br />
        ///    CREATED: 2024-02-05
        /// </remarks>
        IEnumerable<Client> GetAllClients();
        IEnumerable<Client> GetClients();
        IEnumerable<Client> GetInactiveClients();
        int EditClient(Client_VM newClient);
        void DeactivateClient(int id);
        void ActivateClient(int id);
    }
}