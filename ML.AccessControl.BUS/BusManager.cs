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
        private bool _bCacheDALAssembly;
        private static AbsDBManager _dbStaticManager;
        private AbsDBManager _dbManager;
        private BusSessions _sessions;

        /// <summary>
        /// Business layer constructor
        /// </summary>
        /// <param name="pDALayerType"></param>
        /// <param name="pConnectionString"></param>
        /// <param name="pCacheDALAssembly">If pCacheDALAssembly is true then subsequent instantiation of the BusManager class will reuse the same DAL assembly. Always set it true if you are always binding to the same data provider.</param>
        public BusManager(Type pDALayerType, string pConnectionString, bool pCacheDALAssembly)
        {
            if (pCacheDALAssembly)
            {
                if (_dbStaticManager == null)
                {
                    //Assembly  assembly = Assembly.LoadFrom("ML.AccessControl.DAL.SQLite.dll");
                    //_dbStaticManager = (AbsDBManager)assembly.CreateInstance("ML.AccessControl.DAL.SQLite.DBManager",false,BindingFlags.Instance | BindingFlags.Public, default(Binder), new[] { "my connection string" }, default(CultureInfo), null);
                    _dbStaticManager = (AbsDBManager)Activator.CreateInstance(pDALayerType, new Object[] { pConnectionString });
                }
            }
            else
            {
                //Assembly  assembly = Assembly.LoadFrom("ML.AccessControl.DAL.SQLite.dll");
                //_dbManager = (AbsDBManager)assembly.CreateInstance("ML.AccessControl.DAL.SQLite.DBManager",false,BindingFlags.Instance | BindingFlags.Public, default(Binder), new[] { "my connection string" }, default(CultureInfo), null);
                _dbManager = (AbsDBManager)Activator.CreateInstance(pDALayerType, new Object[] { pConnectionString });
            }
            _bCacheDALAssembly = pCacheDALAssembly;
        }

        public BusSessions Sessions
        {
            get
            {
                if (_sessions == null)
                    _sessions = new BusSessions(_bCacheDALAssembly ? _dbStaticManager : _dbManager);
                return _sessions;
            }
        }

    }
}
