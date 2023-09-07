using System;

namespace detectVideoApp
{
    public class NewConfiguration : EventArgs
    {
        #region Members
        public bool IsCreated { get; set; }
        #endregion
        #region Constructors
        public NewConfiguration()
        {
            IsCreated = false;
        }
        public NewConfiguration(bool isCreated)
        {
            this.IsCreated = isCreated;
        }
        #endregion
    }
}
