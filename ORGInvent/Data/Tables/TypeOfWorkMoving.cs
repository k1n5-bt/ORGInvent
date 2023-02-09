using System.Runtime.Serialization;

namespace ORGInvent.Data.Tables
{
    public enum TypeOfWorkMoving
    {
        [EnumMember(Value="Закрепление за сотрудником")]
        Fix,

        [EnumMember(Value = "Списать")]
        Deregister,

        [EnumMember(Value="Вывод из эксплуатации")]
        Remove,

        [EnumMember(Value= "Перемещение на ремонт")]
        Repair
    }
}
