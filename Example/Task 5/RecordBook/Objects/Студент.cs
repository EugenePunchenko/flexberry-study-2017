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
    /// Студент.
    /// </summary>
    // *** Start programmer edit section *** (Студент CustomAttributes)

    // *** End programmer edit section *** (Студент CustomAttributes)
    [BusinessServer("NewPlatform.RecordBook.ЭлектроннаяЗачётка, RecordBook(BusinessServers)", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored(false)]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СтудентE", new string[] {
            "Рейтинг as \'Рейтинг\'",
            "СреднийБалл as \'Средний балл\'",
            "Отчислен as \'Отчислен\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "ДатаРождения as \'Дата рождения\'",
            "Логин as \'Логин\'",
            "ФИО as \'ФИО\'"})]
    public class Студент : NewPlatform.RecordBook.Личность
    {
        
        private int fРейтинг = 0;
        
        private double fСреднийБалл = 0D;
        
        private bool fОтчислен = false;
        
        private NewPlatform.RecordBook.Группа fГруппа;
        
        // *** Start programmer edit section *** (Студент CustomMembers)

        // *** End programmer edit section *** (Студент CustomMembers)

        
        /// <summary>
        /// Рейтинг.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Рейтинг CustomAttributes)

        // *** End programmer edit section *** (Студент.Рейтинг CustomAttributes)
        [NotNull()]
        public virtual int Рейтинг
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Рейтинг Get start)

                // *** End programmer edit section *** (Студент.Рейтинг Get start)
                int result = this.fРейтинг;
                // *** Start programmer edit section *** (Студент.Рейтинг Get end)

                // *** End programmer edit section *** (Студент.Рейтинг Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Рейтинг Set start)

                // *** End programmer edit section *** (Студент.Рейтинг Set start)
                this.fРейтинг = value;
                // *** Start programmer edit section *** (Студент.Рейтинг Set end)

                // *** End programmer edit section *** (Студент.Рейтинг Set end)
            }
        }
        
        /// <summary>
        /// СреднийБалл.
        /// </summary>
        // *** Start programmer edit section *** (Студент.СреднийБалл CustomAttributes)

        // *** End programmer edit section *** (Студент.СреднийБалл CustomAttributes)
        [NotNull()]
        public virtual double СреднийБалл
        {
            get
            {
                // *** Start programmer edit section *** (Студент.СреднийБалл Get start)

                // *** End programmer edit section *** (Студент.СреднийБалл Get start)
                double result = this.fСреднийБалл;
                // *** Start programmer edit section *** (Студент.СреднийБалл Get end)

                // *** End programmer edit section *** (Студент.СреднийБалл Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.СреднийБалл Set start)

                // *** End programmer edit section *** (Студент.СреднийБалл Set start)
                this.fСреднийБалл = value;
                // *** Start programmer edit section *** (Студент.СреднийБалл Set end)

                // *** End programmer edit section *** (Студент.СреднийБалл Set end)
            }
        }
        
        /// <summary>
        /// Отчислен.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Отчислен CustomAttributes)

        // *** End programmer edit section *** (Студент.Отчислен CustomAttributes)
        [NotNull()]
        public virtual bool Отчислен
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Отчислен Get start)

                // *** End programmer edit section *** (Студент.Отчислен Get start)
                bool result = this.fОтчислен;
                // *** Start programmer edit section *** (Студент.Отчислен Get end)

                // *** End programmer edit section *** (Студент.Отчислен Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Отчислен Set start)

                // *** End programmer edit section *** (Студент.Отчислен Set start)
                this.fОтчислен = value;
                // *** Start programmer edit section *** (Студент.Отчислен Set end)

                // *** End programmer edit section *** (Студент.Отчислен Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.RecordBook.Группа.
        /// </summary>
        // *** Start programmer edit section *** (Студент.Группа CustomAttributes)

        // *** End programmer edit section *** (Студент.Группа CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.RecordBook.Группа Группа
        {
            get
            {
                // *** Start programmer edit section *** (Студент.Группа Get start)

                // *** End programmer edit section *** (Студент.Группа Get start)
                NewPlatform.RecordBook.Группа result = this.fГруппа;
                // *** Start programmer edit section *** (Студент.Группа Get end)

                // *** End programmer edit section *** (Студент.Группа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Студент.Группа Set start)

                // *** End programmer edit section *** (Студент.Группа Set start)
                this.fГруппа = value;
                // *** Start programmer edit section *** (Студент.Группа Set end)

                // *** End programmer edit section *** (Студент.Группа Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СтудентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СтудентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СтудентE", typeof(NewPlatform.RecordBook.Студент));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Студент.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСтудент CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСтудент CustomAttributes)
    public class DetailArrayOfСтудент : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.RecordBook.DetailArrayOfСтудент members)

        // *** End programmer edit section *** (NewPlatform.RecordBook.DetailArrayOfСтудент members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Студент by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Студент.
        /// </summary>
        public DetailArrayOfСтудент(NewPlatform.RecordBook.Группа fГруппа) : 
                base(typeof(Студент), ((ICSSoft.STORMNET.DataObject)(fГруппа)))
        {
        }
        
        public NewPlatform.RecordBook.Студент this[int index]
        {
            get
            {
                return ((NewPlatform.RecordBook.Студент)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.RecordBook.Студент dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
