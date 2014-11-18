﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Dragablz;

namespace DragablzDemo
{
    public class BasicExampleInterTabClient : IInterTabClient
    {
        public INewTabHost GetNewHost(IInterTabClient interTabClient, object partition)
        {
            var view = new BasicExampleTemplateWindow();
            var model = new BasicExampleTemplateModel(interTabClient, partition);
            view.DataContext = model;
            return new NewTabHost(view, view.TabablzControl);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindow;
        }
    }
}