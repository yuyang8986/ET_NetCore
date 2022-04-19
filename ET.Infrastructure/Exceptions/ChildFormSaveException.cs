using System;

namespace ET.Infrastructure.Exceptions
{
    public class ChildFormSaveException:Exception
    {
        public ChildFormSaveException(string name, object key)
            : base($"Entity \"{name}\"  attached on MainForm, ID = ({key}) error on saving.")
        {
        }
    }
}
