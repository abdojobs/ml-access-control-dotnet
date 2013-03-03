using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ML.AccessControl.DAL;
using System.Globalization;
using ML.AccessControl.Common.Resources;

namespace ML.AccessControl.BUS
{
    public sealed class BusManager
    {
        private bool _bCacheDALAssembly;
        private static AbsFactory _dbStaticFactory;
        private AbsFactory _dbFactory;
        private AbsManager _dbManager;

        private BusSessions _sessions;
        private BusRegistration _registration;
        private BusUsers _users;
        private BusRoles _roles;

        /// <summary>
        /// Business layer constructor
        /// </summary>
        /// <param name="pDALayerType">Data type of the DAL DBFactory. e.g Type.GetType("ML.AccessControl.DAL.SQLite.DBFactory, ML.AccessControl.DAL.SQLite", true)</param>
        /// <param name="pConnectionString">Connection string to the database</param>
        public BusManager(Type pDALayerType, string pConnectionString) : this(pDALayerType, pConnectionString, true) { }

        /// <summary>
        /// Business layer constructor
        /// </summary>
        /// <param name="pDALayerType">Data type of the DAL DBFactory. e.g Type.GetType("ML.AccessControl.DAL.SQLite.DBFactory, ML.AccessControl.DAL.SQLite", true)</param>
        /// <param name="pConnectionString">Connection string to the database</param>
        /// <param name="pCacheDALAssembly">If pCacheDALAssembly is true then subsequent instantiation of the BusManager class will reuse the same DAL assembly. Always set it true if you are not intending to switch the data provider at runtime.</param>
        public BusManager(Type pDALayerType, string pConnectionString, bool pCacheDALAssembly)
        {
            _bCacheDALAssembly = pCacheDALAssembly;
            if (_bCacheDALAssembly)
            {
                if (_dbStaticFactory == null)
                    _dbStaticFactory = (AbsFactory)Activator.CreateInstance(pDALayerType);
                _dbManager = _dbStaticFactory.CreateDBManager(pConnectionString);
            }
            else
            {
                _dbFactory = (AbsFactory)Activator.CreateInstance(pDALayerType);
                _dbManager = _dbFactory.CreateDBManager(pConnectionString);
            }
        }

        public BusSessions Sessions
        {
            get
            {
                if (_sessions == null)
                    _sessions = new BusSessions(this, _dbManager);
                return _sessions;
            }
        }

        public BusRegistration Registration
        {
            get
            {
                if (_registration == null)
                    _registration = new BusRegistration(this, _dbManager);
                return _registration;
            }
        }

        public BusUsers Users
        {
            get
            {
                if (_users == null)
                    _users = new BusUsers(this, _dbManager);
                return _users;
            }
        }

        public BusRoles Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new BusRoles(this, _dbManager);
                return _roles;
            }
        }

        public string GetErrorMessage(int pMessageId)
        {
            string sResult = null;
            sResult = Messages.ResourceManager.GetString("ERR_" + pMessageId.ToString());

            return sResult;
        }

    }
}
