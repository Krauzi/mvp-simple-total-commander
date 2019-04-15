using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TCommanderKrupa
{
    class Model
    {
        List<string> items = new List<string>();

        public Model () { }

        public string[] Drives ()
        {
            List<string> readyDrives = new List<string>();
            foreach (var drive in DriveInfo.GetDrives().ToArray())
                if (drive.IsReady) readyDrives.Add(drive.ToString());

            return readyDrives.ToArray();
        }

        public string[] GetFiles(string CurrentPath)
        {
            items.Add(CurrentPath);
            if (Directory.Exists(CurrentPath))
            {
                List<string> allItems = new List<string>();
                try
                {
                    foreach (var dir in Directory.GetDirectories(CurrentPath).ToList())
                        allItems.Add("<D>" + dir.Remove(0, CurrentPath.Length));

                    foreach (var dir in Directory.GetFiles(CurrentPath).ToList())
                        allItems.Add(dir.Remove(0, CurrentPath.Length));

                    return allItems.ToArray();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Cannot open a folder");
                    return new List<string>().ToArray();
                }
            }
            else return items.ToArray();
        }

        public bool IsFolder(string path)
        {
            if (Directory.Exists(path))
                return true;
            else return false;
        }
        public void OpenFile(string path)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
                
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("There was a problem with file!");
            }
        }

        public string ParentPath(string path)
        {
            try
            {
                return Directory.GetParent(path).ToString();
            }
            catch (Exception)
            {
                return path;
            }
        }

        public void DeleteItem(string source)
        {
            if (Directory.Exists(source))
            {
                DialogResult dialogResult = MessageBox.Show("Confirm deleting this directory", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Directory.Delete(source, true);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirm deleting this file", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(source);
                }
            }
        }

        public void CopyItem(string FileName, string SourceLocation, string NewLocation)
        {
            if (Directory.Exists(FileName))
            {
                DirectoryInfo diSource = new DirectoryInfo(FileName);
                DirectoryInfo diTarget = new DirectoryInfo(NewLocation + @"\" + FileName.Substring(SourceLocation.Length));

                CopyDirectoryContents(diSource, diTarget);
            } else
            {
                try
                {
                    if (FileName == SourceLocation)
                    {
                        MessageBox.Show("Pick something.");
                        return;
                    }
                    if (NewLocation == "" || NewLocation == null)
                    {
                        MessageBox.Show("Select the destination.");
                        return;
                    }

                    string ItemName = FileName.Substring(SourceLocation.Length);
                    File.Copy(FileName, NewLocation + @"\" + ItemName);
                    MessageBox.Show("Copied successfully.");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("No permission.");
                }
                catch (IOException)
                {
                    string ItemName = FileName.Substring(SourceLocation.Length);
                    MessageBox.Show("Error: Item " + ItemName + " already exists.");
                }
            }
        }

        private void CopyDirectoryContents(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);


            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                CopyDirectoryContents(diSourceSubDir, nextTargetSubDir);
            }
        }

        public void MoveItem(string FileName, string SourceLocation, string NewLocation)
        {

            if (Directory.Exists(FileName))
            {
                Console.WriteLine(SourceLocation + " target: " + NewLocation);

                if (Directory.GetDirectoryRoot(SourceLocation) == Directory.GetDirectoryRoot(NewLocation))
                {
                    MessageBox.Show("Moving file to the same destination folder?");
                    return;
                }
                else
                {
                    CopyItem(FileName, SourceLocation, NewLocation);
                    Directory.Delete(FileName, true);
                }

            } else File.Move(SourceLocation + FileName.Substring(SourceLocation.Length), NewLocation);

        }
    }
}
