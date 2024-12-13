using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUI
{
    /// <summary>
    /// Расширение для форм
    /// </summary>
    public static class Extensions
    {
        public static void SetNotChangedSize(this Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            form.MaximizeBox = false;
            form.MinimizeBox = false;
        }
    }
}
