﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.RecordBook
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Состояние оценки.
    /// </summary>
    // *** Start programmer edit section *** (СостояниеОценки CustomAttributes)

    // *** End programmer edit section *** (СостояниеОценки CustomAttributes)
    public enum СостояниеОценки
    {
        
        /// <summary>
        /// 
        /// </summary>
        // *** Start programmer edit section *** (СостояниеОценки.ОценкаНеВыставлена CustomAttributes)

        // *** End programmer edit section *** (СостояниеОценки.ОценкаНеВыставлена CustomAttributes)
        [Caption("Оценка не выставлена")]
        ОценкаНеВыставлена,
        
        /// <summary>
        /// 
        /// </summary>
        // *** Start programmer edit section *** (СостояниеОценки.ОценкаВыставлена CustomAttributes)

        // *** End programmer edit section *** (СостояниеОценки.ОценкаВыставлена CustomAttributes)
        [Caption("Оценка выставлена")]
        ОценкаВыставлена,
        
        /// <summary>
        /// 
        /// </summary>
        // *** Start programmer edit section *** (СостояниеОценки.ОценкаИсправлена CustomAttributes)

        // *** End programmer edit section *** (СостояниеОценки.ОценкаИсправлена CustomAttributes)
        [Caption("Оценка исправлена")]
        ОценкаИсправлена,
    }
}
