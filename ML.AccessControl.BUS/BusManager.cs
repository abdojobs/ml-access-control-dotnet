using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ML.AccessControl.DAL;
using System.Globalization;

namespace ML.AccessControl.BUS
{
    public sealed class BusManager
    {
        private static AbsFactory _dbFactory;
        private AbsDBManager _dbManager;
        private BusSessions _sessions;
        private BusRegistration _registration;
        private BusUsers _users;

        /// <summary>
        /// Business layer constructor
        /// </summary>
        /// <param name="pDALayerType"></param>
        /// <param name="pConnectionString"></param>
        /// <param name="pCacheDALAssembly">If pCacheDALAssembly is true then subsequent instantiation of the BusManager class will reuse the same DAL assembly. Always set it true if you are always binding to the same data provider.</param>
        public BusManager(Type pDALayerType, string pConnectionString)
        {
           
            if (_dbFactory == null)
            {
                //Assembly  assembly = Assembly.LoadFrom("ML.AccessControl.DAL.SQLite.dll");
                //_dbStaticManager = (AbsDBManager)assembly.CreateInstance("ML.AccessControl.DAL.SQLite.DBManager",false,BindingFlags.Instance | BindingFlags.Public, default(Binder), new[] { "my connection string" }, default(CultureInfo), null);
                _dbFactory = (AbsFactory)Activator.CreateInstance(pDALayerType);
            }
            _dbManager = _dbFactory.CreateDBManager(pConnectionString);
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

        public string GetErrorMessage(int pMessageId)
        {
            string sResult = null;
            sResult = Resources.Messages.ResourceManager.GetString("ERR_" + pMessageId.ToString());

            return sResult;
        }

    }
}
