using System;

namespace Model
{
    public interface IModel
    {
        void Init();
        event Action ModelUpdated;
    }
}