using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCommanderKrupa
{
    class PanelPresenter
    {
        IPanel view;
        Model model;

        public PanelPresenter(IPanel view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.GetDrives += View_GetDrives;
            this.view.GetItems += View_GetItems;
            this.view.ExecuteSelectedItem += View_ExecuteSelectedItem;
            this.view.ReturnToPreviousPath += View_ReturnToPreviousPath;
            this.view.DeleteSelectedItem += View_DeleteSelectedItem;
        }

        private void View_GetItems()
        {
            this.view.Items = model.GetFiles(this.view.CurrentPath);
        }

        private void View_GetDrives()
        {
            this.view.Drives = model.Drives();
        }

        private void View_ExecuteSelectedItem(string GivenItem)
        {
            string GivenItemFullPath = this.view.CurrentPath + GivenItem;
            if (model.IsFolder(GivenItemFullPath))
            {
                this.view.CurrentPath = GivenItemFullPath;
            }
            else
            {
                model.OpenFile(GivenItemFullPath);
            }
        }

        private void View_ReturnToPreviousPath()
        {
            string ParentPath = model.ParentPath(this.view.CurrentPath);
            this.view.CurrentPath = ParentPath;
        }

        private void View_DeleteSelectedItem(string GivenItem)
        {
            string GivenItemFullPath = this.view.CurrentPath + GivenItem;
            model.DeleteItem(GivenItemFullPath);
        }

    }
}
