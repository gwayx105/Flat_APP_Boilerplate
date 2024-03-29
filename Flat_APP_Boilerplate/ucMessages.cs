﻿using System;
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
    public partial class ucMessages : UserControl
    {
        //Singleton pattern
        private static ucMessages _instance;
        public static ucMessages Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMessages();
                }
                return _instance;
            }
        }
        public ucMessages()
        {
            InitializeComponent();
        }
    }
}
