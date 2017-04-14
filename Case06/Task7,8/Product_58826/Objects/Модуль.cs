﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_58826
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Модуль.
    /// </summary>
    // *** Start programmer edit section *** (Модуль CustomAttributes)

    // *** End programmer edit section *** (Модуль CustomAttributes)
    [BusinessServer("IIS.Product_58826.МодульБС, Product_58826(BusinessServers)", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.@this)]
    [View("AuditView", new string[] {
            "Название as \'Название\'",
            "Описание as \'Описание\'",
            "Актуальность as \'Актуальность\'",
            "Организация as \'Организация\'",
            "Организация.Название as \'Название\'",
            "Семестр as \'Семестр\'",
            "Семестр.Номер as \'Номер\'"})]
    [View("МодульE", new string[] {
            "Название as \'Название\'",
            "Описание as \'Описание\'",
            "Семестр as \'Семестр № \'",
            "Семестр.Номер as \' \'",
            "Организация as \'Организация\'",
            "Организация.Название as \' \'",
            "Актуальность"})]
    [View("МодульL", new string[] {
            "Название as \'Модуль\'",
            "Описание as \'Описание\'",
            "Семестр.Начало as \'с \'",
            "Семестр.Конец as \'по \'",
            "Семестр.Номер as \'Семестр № \'",
            "Организация.Название as \'Организация\'",
            "Актуальность"})]
    public class Модуль : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fНазвание;
        
        private string fОписание;
        
        private bool fАктуальность = true;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.Product_58826.Организация fОрганизация;
        
        private IIS.Product_58826.Семестр fСеместр;
        
        // *** Start programmer edit section *** (Модуль CustomMembers)

        // *** End programmer edit section *** (Модуль CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Название CustomAttributes)

        // *** End programmer edit section *** (Модуль.Название CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Название Get start)

                // *** End programmer edit section *** (Модуль.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (Модуль.Название Get end)

                // *** End programmer edit section *** (Модуль.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Название Set start)

                // *** End programmer edit section *** (Модуль.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (Модуль.Название Set end)

                // *** End programmer edit section *** (Модуль.Название Set end)
            }
        }
        
        /// <summary>
        /// Описание.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Описание CustomAttributes)

        // *** End programmer edit section *** (Модуль.Описание CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Описание
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Описание Get start)

                // *** End programmer edit section *** (Модуль.Описание Get start)
                string result = this.fОписание;
                // *** Start programmer edit section *** (Модуль.Описание Get end)

                // *** End programmer edit section *** (Модуль.Описание Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Описание Set start)

                // *** End programmer edit section *** (Модуль.Описание Set start)
                this.fОписание = value;
                // *** Start programmer edit section *** (Модуль.Описание Set end)

                // *** End programmer edit section *** (Модуль.Описание Set end)
            }
        }
        
        /// <summary>
        /// Актуальность.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Актуальность CustomAttributes)

        // *** End programmer edit section *** (Модуль.Актуальность CustomAttributes)
        public virtual bool Актуальность
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Актуальность Get start)

                // *** End programmer edit section *** (Модуль.Актуальность Get start)
                bool result = this.fАктуальность;
                // *** Start programmer edit section *** (Модуль.Актуальность Get end)

                // *** End programmer edit section *** (Модуль.Актуальность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Актуальность Set start)

                // *** End programmer edit section *** (Модуль.Актуальность Set start)
                this.fАктуальность = value;
                // *** Start programmer edit section *** (Модуль.Актуальность Set end)

                // *** End programmer edit section *** (Модуль.Актуальность Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.CreateTime CustomAttributes)

        // *** End programmer edit section *** (Модуль.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.CreateTime Get start)

                // *** End programmer edit section *** (Модуль.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                // *** Start programmer edit section *** (Модуль.CreateTime Get end)

                // *** End programmer edit section *** (Модуль.CreateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.CreateTime Set start)

                // *** End programmer edit section *** (Модуль.CreateTime Set start)
                this.fCreateTime = value;
                // *** Start programmer edit section *** (Модуль.CreateTime Set end)

                // *** End programmer edit section *** (Модуль.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Creator CustomAttributes)

        // *** End programmer edit section *** (Модуль.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Creator Get start)

                // *** End programmer edit section *** (Модуль.Creator Get start)
                string result = this.fCreator;
                // *** Start programmer edit section *** (Модуль.Creator Get end)

                // *** End programmer edit section *** (Модуль.Creator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Creator Set start)

                // *** End programmer edit section *** (Модуль.Creator Set start)
                this.fCreator = value;
                // *** Start programmer edit section *** (Модуль.Creator Set end)

                // *** End programmer edit section *** (Модуль.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.EditTime CustomAttributes)

        // *** End programmer edit section *** (Модуль.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.EditTime Get start)

                // *** End programmer edit section *** (Модуль.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                // *** Start programmer edit section *** (Модуль.EditTime Get end)

                // *** End programmer edit section *** (Модуль.EditTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.EditTime Set start)

                // *** End programmer edit section *** (Модуль.EditTime Set start)
                this.fEditTime = value;
                // *** Start programmer edit section *** (Модуль.EditTime Set end)

                // *** End programmer edit section *** (Модуль.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Editor CustomAttributes)

        // *** End programmer edit section *** (Модуль.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Editor Get start)

                // *** End programmer edit section *** (Модуль.Editor Get start)
                string result = this.fEditor;
                // *** Start programmer edit section *** (Модуль.Editor Get end)

                // *** End programmer edit section *** (Модуль.Editor Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Editor Set start)

                // *** End programmer edit section *** (Модуль.Editor Set start)
                this.fEditor = value;
                // *** Start programmer edit section *** (Модуль.Editor Set end)

                // *** End programmer edit section *** (Модуль.Editor Set end)
            }
        }
        
        /// <summary>
        /// Модуль.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Организация CustomAttributes)

        // *** End programmer edit section *** (Модуль.Организация CustomAttributes)
        [NotNull()]
        public virtual IIS.Product_58826.Организация Организация
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Организация Get start)

                // *** End programmer edit section *** (Модуль.Организация Get start)
                IIS.Product_58826.Организация result = this.fОрганизация;
                // *** Start programmer edit section *** (Модуль.Организация Get end)

                // *** End programmer edit section *** (Модуль.Организация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Организация Set start)

                // *** End programmer edit section *** (Модуль.Организация Set start)
                this.fОрганизация = value;
                // *** Start programmer edit section *** (Модуль.Организация Set end)

                // *** End programmer edit section *** (Модуль.Организация Set end)
            }
        }
        
        /// <summary>
        /// Модуль.
        /// </summary>
        // *** Start programmer edit section *** (Модуль.Семестр CustomAttributes)

        // *** End programmer edit section *** (Модуль.Семестр CustomAttributes)
        [NotNull()]
        public virtual IIS.Product_58826.Семестр Семестр
        {
            get
            {
                // *** Start programmer edit section *** (Модуль.Семестр Get start)

                // *** End programmer edit section *** (Модуль.Семестр Get start)
                IIS.Product_58826.Семестр result = this.fСеместр;
                // *** Start programmer edit section *** (Модуль.Семестр Get end)

                // *** End programmer edit section *** (Модуль.Семестр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Модуль.Семестр Set start)

                // *** End programmer edit section *** (Модуль.Семестр Set start)
                this.fСеместр = value;
                // *** Start programmer edit section *** (Модуль.Семестр Set end)

                // *** End programmer edit section *** (Модуль.Семестр Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.Product_58826.Модуль));
                }
            }
            
            /// <summary>
            /// "МодульE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МодульE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МодульE", typeof(IIS.Product_58826.Модуль));
                }
            }
            
            /// <summary>
            /// "МодульL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МодульL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МодульL", typeof(IIS.Product_58826.Модуль));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
