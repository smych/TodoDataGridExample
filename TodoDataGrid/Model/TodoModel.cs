using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoDataGrid.Model
{
    class TodoModel
    {
        #region Fields

        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _text;

        #endregion Fields

        #region Properties
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        #endregion Properties
    }
}
