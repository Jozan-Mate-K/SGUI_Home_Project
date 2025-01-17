﻿using SGUI_Home_Project.Store;
using SGUI_Home_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGUI_Home_Project.Commands
{
    internal class ChangeToAddNewManufacturerCommand: BaseCommand
    {
        private readonly ManufacturerNavigationStore navigationStore;
        private readonly ManufacturerItemsStore itemsStore;

        public ChangeToAddNewManufacturerCommand( ManufacturerNavigationStore navigationStore, ManufacturerItemsStore itemsStore)
        {
            this.navigationStore = navigationStore;
            this.itemsStore = itemsStore;
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentView = new ManufacturerAddNewViewModel(navigationStore, itemsStore);
        }
    }
}
