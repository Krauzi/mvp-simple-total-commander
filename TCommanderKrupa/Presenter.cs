using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCommanderKrupa
{
    class Presenter
    {
        IView view;
        Model model;
        PanelPresenter left;
        PanelPresenter right;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.left = new PanelPresenter(view.LeftPanel, model);
            this.right = new PanelPresenter(view.RightPanel, model);

            this.view.Copy += View_Copy;
            this.view.Move += View_Move;
        }

        private void View_Copy(IPanel activePannel, IPanel passivePanel)
        {
            model.CopyItem(activePannel.CurrentPath + activePannel.SelectedItem, activePannel.CurrentPath, passivePanel.CurrentPath);
            passivePanel.ResetFolderValues();
        }

        private void View_Move(IPanel activePannel, IPanel passivePanel)
        {
            model.MoveItem(activePannel.CurrentPath + activePannel.SelectedItem, activePannel.CurrentPath, passivePanel.CurrentPath);
            activePannel.ResetFolderValues();
            passivePanel.ResetFolderValues();
        }
    }
}