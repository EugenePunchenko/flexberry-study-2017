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
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Личность.
    /// </summary>
    // *** Start programmer edit section *** (Личность CustomAttributes)

    // *** End programmer edit section *** (Личность CustomAttributes)
    [BusinessServer("NewPlatform.RecordBook.ЭлектроннаяЗачётка, RecordBook(BusinessServers)", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЛичностьE", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "ДатаРождения as \'Дата рождения\'",
            "Логин as \'Логин\'",
            "ФИО as \'ФИО\'"})]
    [View("ЛичностьL", new string[] {
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "ДатаРождения as \'Дата рождения\'",
            "Логин as \'Логин\'",
            "ФИО as \'ФИО\'"})]
    public class Личность : ICSSoft.STORMNET.DataObject
    {
        
        private string fФамилия;
        
        private string fИмя;
        
        private string fОтчество;
        
        private System.DateTime fДатаРождения;
        
        private string fЛогин;
        
        // *** Start programmer edit section *** (Личность CustomMembers)

        // *** End programmer edit section *** (Личность CustomMembers)

        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Личность.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Личность.Фамилия CustomAttributes)
        [StrLen(256)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Личность.Фамилия Get start)

                // *** End programmer edit section *** (Личность.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Личность.Фамилия Get end)

                // *** End programmer edit section *** (Личность.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Личность.Фамилия Set start)

                // *** End programmer edit section *** (Личность.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Личность.Фамилия Set end)

                // *** End programmer edit section *** (Личность.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Личность.Имя CustomAttributes)

        // *** End programmer edit section *** (Личность.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Личность.Имя Get start)

                // *** End programmer edit section *** (Личность.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Личность.Имя Get end)

                // *** End programmer edit section *** (Личность.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Личность.Имя Set start)

                // *** End programmer edit section *** (Личность.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Личность.Имя Set end)

                // *** End programmer edit section *** (Личность.Имя Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Личность.Отчество CustomAttributes)

        // *** End programmer edit section *** (Личность.Отчество CustomAttributes)
        [StrLen(255)]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Личность.Отчество Get start)

                // *** End programmer edit section *** (Личность.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Личность.Отчество Get end)

                // *** End programmer edit section *** (Личность.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Личность.Отчество Set start)

                // *** End programmer edit section *** (Личность.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Личность.Отчество Set end)

                // *** End programmer edit section *** (Личность.Отчество Set end)
            }
        }
        
        /// <summary>
        /// ДатаРождения.
        /// </summary>
        // *** Start programmer edit section *** (Личность.ДатаРождения CustomAttributes)

        // *** End programmer edit section *** (Личность.ДатаРождения CustomAttributes)
        public virtual System.DateTime ДатаРождения
        {
            get
            {
                // *** Start programmer edit section *** (Личность.ДатаРождения Get start)

                // *** End programmer edit section *** (Личность.ДатаРождения Get start)
                System.DateTime result = this.fДатаРождения;
                // *** Start programmer edit section *** (Личность.ДатаРождения Get end)

                // *** End programmer edit section *** (Личность.ДатаРождения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Личность.ДатаРождения Set start)

                // *** End programmer edit section *** (Личность.ДатаРождения Set start)
                this.fДатаРождения = value;
                // *** Start programmer edit section *** (Личность.ДатаРождения Set end)

                // *** End programmer edit section *** (Личность.ДатаРождения Set end)
            }
        }
        
        /// <summary>
        /// Логин.
        /// </summary>
        // *** Start programmer edit section *** (Личность.Логин CustomAttributes)

        // *** End programmer edit section *** (Личность.Логин CustomAttributes)
        [StrLen(255)]
        public virtual string Логин
        {
            get
            {
                // *** Start programmer edit section *** (Личность.Логин Get start)

                // *** End programmer edit section *** (Личность.Логин Get start)
                string result = this.fЛогин;
                // *** Start programmer edit section *** (Личность.Логин Get end)

                // *** End programmer edit section *** (Личность.Логин Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Личность.Логин Set start)

                // *** End programmer edit section *** (Личность.Логин Set start)
                this.fЛогин = value;
                // *** Start programmer edit section *** (Личность.Логин Set end)

                // *** End programmer edit section *** (Личность.Логин Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Личность.ФИО CustomAttributes)

        // *** End programmer edit section *** (Личность.ФИО CustomAttributes)
        [PropertyStorage("FIO")]
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "@Фамилия@ + \' \' + @Имя@ + \' \' + @Отчество@")]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Личность.ФИО Get)
                return null;
                // *** End programmer edit section *** (Личность.ФИО Get)
            }
            set
            {
                // *** Start programmer edit section *** (Личность.ФИО Set)

                // *** End programmer edit section *** (Личность.ФИО Set)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЛичностьE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛичностьE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛичностьE", typeof(NewPlatform.RecordBook.Личность));
                }
            }
            
            /// <summary>
            /// "ЛичностьL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЛичностьL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЛичностьL", typeof(NewPlatform.RecordBook.Личность));
                }
            }
        }
    }
}
