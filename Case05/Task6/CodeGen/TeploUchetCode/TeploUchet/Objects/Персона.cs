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
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Персона.
    /// </summary>
    // *** Start programmer edit section *** (Персона CustomAttributes)

    // *** End programmer edit section *** (Персона CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПерсонаE", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Логин as \'Логин\'"})]
    [View("ПерсонаL", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "Логин as \'Логин\'"})]
    public class Персона : ICSSoft.STORMNET.DataObject
    {
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private string fЛогин;
        
        // *** Start programmer edit section *** (Персона CustomMembers)

        // *** End programmer edit section *** (Персона CustomMembers)

        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Персона.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Персона.Фамилия CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Персона.Фамилия Get start)

                // *** End programmer edit section *** (Персона.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Персона.Фамилия Get end)

                // *** End programmer edit section *** (Персона.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Персона.Фамилия Set start)

                // *** End programmer edit section *** (Персона.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Персона.Фамилия Set end)

                // *** End programmer edit section *** (Персона.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Персона.Имя CustomAttributes)

        // *** End programmer edit section *** (Персона.Имя CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Персона.Имя Get start)

                // *** End programmer edit section *** (Персона.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Персона.Имя Get end)

                // *** End programmer edit section *** (Персона.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Персона.Имя Set start)

                // *** End programmer edit section *** (Персона.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Персона.Имя Set end)

                // *** End programmer edit section *** (Персона.Имя Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Персона.Отчество CustomAttributes)

        // *** End programmer edit section *** (Персона.Отчество CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Персона.Отчество Get start)

                // *** End programmer edit section *** (Персона.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Персона.Отчество Get end)

                // *** End programmer edit section *** (Персона.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Персона.Отчество Set start)

                // *** End programmer edit section *** (Персона.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Персона.Отчество Set end)

                // *** End programmer edit section *** (Персона.Отчество Set end)
            }
        }
        
        /// <summary>
        /// Логин.
        /// </summary>
        // *** Start programmer edit section *** (Персона.Логин CustomAttributes)

        // *** End programmer edit section *** (Персона.Логин CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Логин
        {
            get
            {
                // *** Start programmer edit section *** (Персона.Логин Get start)

                // *** End programmer edit section *** (Персона.Логин Get start)
                string result = this.fЛогин;
                // *** Start programmer edit section *** (Персона.Логин Get end)

                // *** End programmer edit section *** (Персона.Логин Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Персона.Логин Set start)

                // *** End programmer edit section *** (Персона.Логин Set start)
                this.fЛогин = value;
                // *** Start programmer edit section *** (Персона.Логин Set end)

                // *** End programmer edit section *** (Персона.Логин Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПерсонаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПерсонаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПерсонаE", typeof(TeploCorp.TeploUchet.Персона));
                }
            }
            
            /// <summary>
            /// "ПерсонаL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПерсонаL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПерсонаL", typeof(TeploCorp.TeploUchet.Персона));
                }
            }
        }
    }
}
