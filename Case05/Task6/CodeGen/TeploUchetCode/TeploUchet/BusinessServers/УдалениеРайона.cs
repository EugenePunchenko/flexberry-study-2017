﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeploCorp.TeploUchet
{
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using System.Linq;
    using System;
    using System.Xml;


    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// УдалениеРайона.
    /// </summary>
    // *** Start programmer edit section *** (УдалениеРайона CustomAttributes)

    // *** End programmer edit section *** (УдалениеРайона CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class УдалениеРайона : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (УдалениеРайона CustomMembers)

        // *** End programmer edit section *** (УдалениеРайона CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateРайон CustomAttributes)

        // *** End programmer edit section *** (OnUpdateРайон CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateРайон(TeploCorp.TeploUchet.Район UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateРайон)
            if (UpdatedObject.GetStatus() == ObjectStatus.Deleted)
            {
                DataService.LoadObject(UpdatedObject);
                UpdatedObject.SetStatus(ObjectStatus.Altered);
                UpdatedObject.Актуален = false;
            }
            return new ICSSoft.STORMNET.DataObject[0];
            // *** End programmer edit section *** (OnUpdateРайон)
        }
    }
}
