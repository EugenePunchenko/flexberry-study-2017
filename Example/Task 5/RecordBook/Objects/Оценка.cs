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
    /// Оценка.
    /// </summary>
    // *** Start programmer edit section *** (Оценка CustomAttributes)

    // *** End programmer edit section *** (Оценка CustomAttributes)
    [BusinessServer("NewPlatform.RecordBook.ЭлектроннаяЗачётка, RecordBook(BusinessServers)", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОценкаE", new string[] {
            "Значение as \'Значение\'",
            "Дата as \'Дата\'",
            "Состояние as \'Состояние\'",
            "Студент as \'Студент\'",
            "Студент.Фамилия as \'Фамилия\'"}, Hidden=new string[] {
            "Студент.Фамилия"})]
    [MasterViewDefineAttribute("ОценкаE", "Студент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    public class Оценка : ICSSoft.STORMNET.DataObject
    {
        
        private NewPlatform.RecordBook.ЗначениеОценки fЗначение;
        
        private System.DateTime fДата;
        
        private NewPlatform.RecordBook.СостояниеОценки fСостояние;
        
        private NewPlatform.RecordBook.Студент fСтудент;
        
        private NewPlatform.RecordBook.Предмет fПредмет;
        
        // *** Start programmer edit section *** (Оценка CustomMembers)

        // *** End programmer edit section *** (Оценка CustomMembers)

        
        /// <summary>
        /// Значение.
        /// </summary>
        // *** Start programmer edit section *** (Оценка.Значение CustomAttributes)

        // *** End programmer edit section *** (Оценка.Значение CustomAttributes)
        public virtual NewPlatform.RecordBook.ЗначениеОценки Значение
        {
            get
            {
                // *** Start programmer edit section *** (Оценка.Значение Get start)

                // *** End programmer edit section *** (Оценка.Значение Get start)
                NewPlatform.RecordBook.ЗначениеОценки result = this.fЗначение;
                // *** Start programmer edit section *** (Оценка.Значение Get end)

                // *** End programmer edit section *** (Оценка.Значение Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оценка.Значение Set start)

                // *** End programmer edit section *** (Оценка.Значение Set start)
                this.fЗначение = value;
                // *** Start programmer edit section *** (Оценка.Значение Set end)

                // *** End programmer edit section *** (Оценка.Значение Set end)
            }
        }
        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Оценка.Дата CustomAttributes)

        // *** End programmer edit section *** (Оценка.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Оценка.Дата Get start)

                // *** End programmer edit section *** (Оценка.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Оценка.Дата Get end)

                // *** End programmer edit section *** (Оценка.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оценка.Дата Set start)

                // *** End programmer edit section *** (Оценка.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Оценка.Дата Set end)

                // *** End programmer edit section *** (Оценка.Дата Set end)
            }
        }
        
        /// <summary>
        /// Состояние.
        /// </summary>
        // *** Start programmer edit section *** (Оценка.Состояние CustomAttributes)

        // *** End programmer edit section *** (Оценка.Состояние CustomAttributes)
        public virtual NewPlatform.RecordBook.СостояниеОценки Состояние
        {
            get
            {
                // *** Start programmer edit section *** (Оценка.Состояние Get start)

                // *** End programmer edit section *** (Оценка.Состояние Get start)
                NewPlatform.RecordBook.СостояниеОценки result = this.fСостояние;
                // *** Start programmer edit section *** (Оценка.Состояние Get end)

                // *** End programmer edit section *** (Оценка.Состояние Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оценка.Состояние Set start)

                // *** End programmer edit section *** (Оценка.Состояние Set start)
                this.fСостояние = value;
                // *** Start programmer edit section *** (Оценка.Состояние Set end)

                // *** End programmer edit section *** (Оценка.Состояние Set end)
            }
        }
        
        /// <summary>
        /// Оценка.
        /// </summary>
        // *** Start programmer edit section *** (Оценка.Студент CustomAttributes)

        // *** End programmer edit section *** (Оценка.Студент CustomAttributes)
        [PropertyStorage(new string[] {
                "Студент"})]
        [NotNull()]
        public virtual NewPlatform.RecordBook.Студент Студент
        {
            get
            {
                // *** Start programmer edit section *** (Оценка.Студент Get start)

                // *** End programmer edit section *** (Оценка.Студент Get start)
                NewPlatform.RecordBook.Студент result = this.fСтудент;
                // *** Start programmer edit section *** (Оценка.Студент Get end)

                // *** End programmer edit section *** (Оценка.Студент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оценка.Студент Set start)

                // *** End programmer edit section *** (Оценка.Студент Set start)
                this.fСтудент = value;
                // *** Start programmer edit section *** (Оценка.Студент Set end)

                // *** End programmer edit section *** (Оценка.Студент Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.RecordBook.Предмет.
        /// </summary>
        // *** Start programmer edit section *** (Оценка.Предмет CustomAttributes)

        // *** End programmer edit section *** (Оценка.Предмет CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.RecordBook.Предмет Предмет
        {
            get
            {
                // *** Start programmer edit section *** (Оценка.Предмет Get start)

                // *** End programmer edit section *** (Оценка.Предмет Get start)
                NewPlatform.RecordBook.Предмет result = this.fПредмет;
                // *** Start programmer edit section *** (Оценка.Предмет Get end)

                // *** End programmer edit section *** (Оценка.Предмет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Оценка.Предмет Set start)

                // *** End programmer edit section *** (Оценка.Предмет Set start)
                this.fПредмет = value;
                // *** Start programmer edit section *** (Оценка.Предмет Set end)

                // *** End programmer edit section *** (Оценка.Предмет Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОценкаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОценкаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОценкаE", typeof(NewPlatform.RecordBook.Оценка));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Оценка.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfОценка CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfОценка CustomAttributes)
    public class DetailArrayOfОценка : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.RecordBook.DetailArrayOfОценка members)

        // *** End programmer edit section *** (NewPlatform.RecordBook.DetailArrayOfОценка members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Оценка by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Оценка.
        /// </summary>
        public DetailArrayOfОценка(NewPlatform.RecordBook.Предмет fПредмет) : 
                base(typeof(Оценка), ((ICSSoft.STORMNET.DataObject)(fПредмет)))
        {
        }
        
        public NewPlatform.RecordBook.Оценка this[int index]
        {
            get
            {
                return ((NewPlatform.RecordBook.Оценка)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.RecordBook.Оценка dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
