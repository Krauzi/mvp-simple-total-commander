using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCommanderKrupa
{
    public interface IPanel
    {
        string[] Drives { set; }
        string[] Items { get;  set; }
        string CurrentPath { get; set; }
        string SelectedItem { get; }
        void ResetFolderValues();

        event Action GetDrives;
        event Action GetItems;
        event Action<string> ExecuteSelectedItem;
        event Action<string> DeleteSelectedItem;
        event Action ReturnToPreviousPath;
    }
}
