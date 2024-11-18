using MAUIAzure.ViewModels.Utilidades;
using MAUIAzure.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIAzure.ViewModels
{
    public class ConnVM: clsVMBase
    {
        private ConnectionState _connState;
        private DelegateCommand _btnConnectCmd;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ConnectionState ConnState {
            get { 
                return _connState;
            }
            set {
                _connState = value;
                NotifyPropertyChanged("ConnState");
            }
        }

        private void _btnConnectCmd_Execute() {
            _connState = DALEJ1.ConexionSQL.GetConnection();
        }

        private Boolean _btnConnectCmd_CanExecute() {
            return true;
        }

        public DelegateCommand ConnectCmd {
            get { return _btnConnectCmd; }
        }

        public ConnVM() {
            _btnConnectCmd = new DelegateCommand(_btnConnectCmd_Execute, _btnConnectCmd_CanExecute);
        }
    }
}
