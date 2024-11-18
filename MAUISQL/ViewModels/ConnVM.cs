using MAUISQL.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISQL.ViewModels
{
    public class ConnVM
    {
        private ConnectionState _connState;
        private DelegateCommand _btnConnectCmd;

        public ConnectionState ConnState {
            get { 
                return _connState;
            }
        }

        private void _btnConnectCmd_Execute() {
            _connState = DALEJ1.ConexionSQL.GetConnection();
        }

        private Boolean _btnConnectCmd_CanExecute() {
            return _connState == null;
        }

        public DelegateCommand ConnectCmd {
            get { return _btnConnectCmd; }
        }

        public ConnVM() {
            _btnConnectCmd = new DelegateCommand(_btnConnectCmd_Execute, _btnConnectCmd_CanExecute);
        }
    }
}
