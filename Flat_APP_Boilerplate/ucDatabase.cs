using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_APP_Boilerplate
{
    public partial class ucDatabase : UserControl
    {
        //Singleton pattern
        private static ucDatabase _instance;
        public static ucDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucDatabase();
                }
                return _instance;
            }
        }
        public ucDatabase()
        {
            InitializeComponent();
        }
    }
}
