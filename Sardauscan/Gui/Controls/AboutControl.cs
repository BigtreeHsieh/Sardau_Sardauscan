﻿#region COPYRIGHT
/****************************************************************************
 *  Copyright (c) 2015 Fabio Ferretti <https://plus.google.com/+FabioFerretti3D>                 *
 *  This file is part of Sardauscan.                                        *
 *                                                                          *
 *  Sardauscan is free software: you can redistribute it and/or modify      *
 *  it under the terms of the GNU General Public License as published by    *
 *  the Free Software Foundation, either version 3 of the License, or       *
 *  (at your option) any later version.                                     *
 *                                                                          *
 *  Sardauscan is distributed in the hope that it will be useful,           *
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of          *
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the           *
 *  GNU General Public License for more details.                            *
 *                                                                          *
 *  You are not allowed to Sell in any form this code                       * 
 *  or any compiled version. This code is free and for free purpose only    *
 *                                                                          *
 *  You should have received a copy of the GNU General Public License       *
 *  along with Sardaukar.  If not, see <http://www.gnu.org/licenses/>       *
 ****************************************************************************
*/
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sardauscan.Gui.Controls
{
	public partial class AboutControl : UserControl
	{
		public AboutControl()
		{
			InitializeComponent();
		}

		private void AboutControl_Load(object sender, EventArgs e)
		{
			TitleLabel.Text = "Sarcaukar V" + Application.ProductVersion;
			CopyrightBox.Text = System.Text.Encoding.Default.GetString(global::Sardauscan.Properties.Resources.LICENSE).Replace("\n","\r\n");
			CopyrightBox.Select(0, 0);
			CreditBox.Text = global::Sardauscan.Properties.Resources.CREDIT;
			CreditBox.Select(0, 0);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://plus.google.com/+FabioFerretti3D");
		}
	}
}
