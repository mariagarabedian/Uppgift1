using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_Uppg1.Models
{
    public class FileContentList : ObservableCollection<FileContent>
    {
        public FileContentList()
        {

        }
        public FileContentList(string text)
        {
            Add(new FileContent(text));
        }

    }
}
