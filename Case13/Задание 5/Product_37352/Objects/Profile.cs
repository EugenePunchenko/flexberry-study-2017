﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Product_37352
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Profile.
    /// </summary>
    // *** Start programmer edit section *** (Profile CustomAttributes)

    // *** End programmer edit section *** (Profile CustomAttributes)
    [AutoAltered()]
    [Caption("Профиль")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ProfileE", new string[] {
            "login as \'Логин\'",
            "mail as \'Почта\'",
            "name as \'Имя\'",
            "surname as \'Фамилия\'",
            "patronymic as \'Отчество\'",
            "gender as \'Пол\'",
            "birthday as \'День рождения\'",
            "sity as \'Город\'",
            "country as \'Страна\'",
            "Network.name as \'Соц сеть\'",
            "Network"})]
    public class Profile : ICSSoft.STORMNET.DataObject
    {
        
        private string flogin;
        
        private string fmail;
        
        private string fname;
        
        private string fsurname;
        
        private string fpatronymic;
        
        private string fgender;
        
        private System.DateTime fbirthday;
        
        private string fsity;
        
        private string fcountry;
        
        private IIS.Product_37352.Network fNetwork;
        
        private IIS.Product_37352.UserData fUserData;
        
        // *** Start programmer edit section *** (Profile CustomMembers)

        // *** End programmer edit section *** (Profile CustomMembers)

        
        /// <summary>
        /// login.
        /// </summary>
        // *** Start programmer edit section *** (Profile.login CustomAttributes)

        // *** End programmer edit section *** (Profile.login CustomAttributes)
        [StrLen(255)]
        public virtual string login
        {
            get
            {
                // *** Start programmer edit section *** (Profile.login Get start)

                // *** End programmer edit section *** (Profile.login Get start)
                string result = this.flogin;
                // *** Start programmer edit section *** (Profile.login Get end)

                // *** End programmer edit section *** (Profile.login Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.login Set start)

                // *** End programmer edit section *** (Profile.login Set start)
                this.flogin = value;
                // *** Start programmer edit section *** (Profile.login Set end)

                // *** End programmer edit section *** (Profile.login Set end)
            }
        }
        
        /// <summary>
        /// mail.
        /// </summary>
        // *** Start programmer edit section *** (Profile.mail CustomAttributes)

        // *** End programmer edit section *** (Profile.mail CustomAttributes)
        [StrLen(255)]
        public virtual string mail
        {
            get
            {
                // *** Start programmer edit section *** (Profile.mail Get start)

                // *** End programmer edit section *** (Profile.mail Get start)
                string result = this.fmail;
                // *** Start programmer edit section *** (Profile.mail Get end)

                // *** End programmer edit section *** (Profile.mail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.mail Set start)

                // *** End programmer edit section *** (Profile.mail Set start)
                this.fmail = value;
                // *** Start programmer edit section *** (Profile.mail Set end)

                // *** End programmer edit section *** (Profile.mail Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        // *** Start programmer edit section *** (Profile.name CustomAttributes)

        // *** End programmer edit section *** (Profile.name CustomAttributes)
        [StrLen(255)]
        public virtual string name
        {
            get
            {
                // *** Start programmer edit section *** (Profile.name Get start)

                // *** End programmer edit section *** (Profile.name Get start)
                string result = this.fname;
                // *** Start programmer edit section *** (Profile.name Get end)

                // *** End programmer edit section *** (Profile.name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.name Set start)

                // *** End programmer edit section *** (Profile.name Set start)
                this.fname = value;
                // *** Start programmer edit section *** (Profile.name Set end)

                // *** End programmer edit section *** (Profile.name Set end)
            }
        }
        
        /// <summary>
        /// surname.
        /// </summary>
        // *** Start programmer edit section *** (Profile.surname CustomAttributes)

        // *** End programmer edit section *** (Profile.surname CustomAttributes)
        [StrLen(255)]
        public virtual string surname
        {
            get
            {
                // *** Start programmer edit section *** (Profile.surname Get start)

                // *** End programmer edit section *** (Profile.surname Get start)
                string result = this.fsurname;
                // *** Start programmer edit section *** (Profile.surname Get end)

                // *** End programmer edit section *** (Profile.surname Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.surname Set start)

                // *** End programmer edit section *** (Profile.surname Set start)
                this.fsurname = value;
                // *** Start programmer edit section *** (Profile.surname Set end)

                // *** End programmer edit section *** (Profile.surname Set end)
            }
        }
        
        /// <summary>
        /// patronymic.
        /// </summary>
        // *** Start programmer edit section *** (Profile.patronymic CustomAttributes)

        // *** End programmer edit section *** (Profile.patronymic CustomAttributes)
        [StrLen(255)]
        public virtual string patronymic
        {
            get
            {
                // *** Start programmer edit section *** (Profile.patronymic Get start)

                // *** End programmer edit section *** (Profile.patronymic Get start)
                string result = this.fpatronymic;
                // *** Start programmer edit section *** (Profile.patronymic Get end)

                // *** End programmer edit section *** (Profile.patronymic Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.patronymic Set start)

                // *** End programmer edit section *** (Profile.patronymic Set start)
                this.fpatronymic = value;
                // *** Start programmer edit section *** (Profile.patronymic Set end)

                // *** End programmer edit section *** (Profile.patronymic Set end)
            }
        }
        
        /// <summary>
        /// gender.
        /// </summary>
        // *** Start programmer edit section *** (Profile.gender CustomAttributes)

        // *** End programmer edit section *** (Profile.gender CustomAttributes)
        [StrLen(255)]
        public virtual string gender
        {
            get
            {
                // *** Start programmer edit section *** (Profile.gender Get start)

                // *** End programmer edit section *** (Profile.gender Get start)
                string result = this.fgender;
                // *** Start programmer edit section *** (Profile.gender Get end)

                // *** End programmer edit section *** (Profile.gender Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.gender Set start)

                // *** End programmer edit section *** (Profile.gender Set start)
                this.fgender = value;
                // *** Start programmer edit section *** (Profile.gender Set end)

                // *** End programmer edit section *** (Profile.gender Set end)
            }
        }
        
        /// <summary>
        /// birthday.
        /// </summary>
        // *** Start programmer edit section *** (Profile.birthday CustomAttributes)

        // *** End programmer edit section *** (Profile.birthday CustomAttributes)
        public virtual System.DateTime birthday
        {
            get
            {
                // *** Start programmer edit section *** (Profile.birthday Get start)

                // *** End programmer edit section *** (Profile.birthday Get start)
                System.DateTime result = this.fbirthday;
                // *** Start programmer edit section *** (Profile.birthday Get end)

                // *** End programmer edit section *** (Profile.birthday Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.birthday Set start)

                // *** End programmer edit section *** (Profile.birthday Set start)
                this.fbirthday = value;
                // *** Start programmer edit section *** (Profile.birthday Set end)

                // *** End programmer edit section *** (Profile.birthday Set end)
            }
        }
        
        /// <summary>
        /// sity.
        /// </summary>
        // *** Start programmer edit section *** (Profile.sity CustomAttributes)

        // *** End programmer edit section *** (Profile.sity CustomAttributes)
        [StrLen(255)]
        public virtual string sity
        {
            get
            {
                // *** Start programmer edit section *** (Profile.sity Get start)

                // *** End programmer edit section *** (Profile.sity Get start)
                string result = this.fsity;
                // *** Start programmer edit section *** (Profile.sity Get end)

                // *** End programmer edit section *** (Profile.sity Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.sity Set start)

                // *** End programmer edit section *** (Profile.sity Set start)
                this.fsity = value;
                // *** Start programmer edit section *** (Profile.sity Set end)

                // *** End programmer edit section *** (Profile.sity Set end)
            }
        }
        
        /// <summary>
        /// country.
        /// </summary>
        // *** Start programmer edit section *** (Profile.country CustomAttributes)

        // *** End programmer edit section *** (Profile.country CustomAttributes)
        [StrLen(255)]
        public virtual string country
        {
            get
            {
                // *** Start programmer edit section *** (Profile.country Get start)

                // *** End programmer edit section *** (Profile.country Get start)
                string result = this.fcountry;
                // *** Start programmer edit section *** (Profile.country Get end)

                // *** End programmer edit section *** (Profile.country Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.country Set start)

                // *** End programmer edit section *** (Profile.country Set start)
                this.fcountry = value;
                // *** Start programmer edit section *** (Profile.country Set end)

                // *** End programmer edit section *** (Profile.country Set end)
            }
        }
        
        /// <summary>
        /// Profile.
        /// </summary>
        // *** Start programmer edit section *** (Profile.Network CustomAttributes)

        // *** End programmer edit section *** (Profile.Network CustomAttributes)
        [PropertyStorage(new string[] {
                "Network"})]
        [NotNull()]
        public virtual IIS.Product_37352.Network Network
        {
            get
            {
                // *** Start programmer edit section *** (Profile.Network Get start)

                // *** End programmer edit section *** (Profile.Network Get start)
                IIS.Product_37352.Network result = this.fNetwork;
                // *** Start programmer edit section *** (Profile.Network Get end)

                // *** End programmer edit section *** (Profile.Network Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.Network Set start)

                // *** End programmer edit section *** (Profile.Network Set start)
                this.fNetwork = value;
                // *** Start programmer edit section *** (Profile.Network Set end)

                // *** End programmer edit section *** (Profile.Network Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Product_37352.UserData.
        /// </summary>
        // *** Start programmer edit section *** (Profile.UserData CustomAttributes)

        // *** End programmer edit section *** (Profile.UserData CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "User"})]
        public virtual IIS.Product_37352.UserData UserData
        {
            get
            {
                // *** Start programmer edit section *** (Profile.UserData Get start)

                // *** End programmer edit section *** (Profile.UserData Get start)
                IIS.Product_37352.UserData result = this.fUserData;
                // *** Start programmer edit section *** (Profile.UserData Get end)

                // *** End programmer edit section *** (Profile.UserData Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Profile.UserData Set start)

                // *** End programmer edit section *** (Profile.UserData Set start)
                this.fUserData = value;
                // *** Start programmer edit section *** (Profile.UserData Set end)

                // *** End programmer edit section *** (Profile.UserData Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ProfileE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ProfileE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ProfileE", typeof(IIS.Product_37352.Profile));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Profile.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfProfile CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfProfile CustomAttributes)
    public class DetailArrayOfProfile : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Product_37352.DetailArrayOfProfile members)

        // *** End programmer edit section *** (IIS.Product_37352.DetailArrayOfProfile members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Profile by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Profile.
        /// </summary>
        public DetailArrayOfProfile(IIS.Product_37352.UserData fUserData) : 
                base(typeof(Profile), ((ICSSoft.STORMNET.DataObject)(fUserData)))
        {
        }
        
        public IIS.Product_37352.Profile this[int index]
        {
            get
            {
                return ((IIS.Product_37352.Profile)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Product_37352.Profile dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
