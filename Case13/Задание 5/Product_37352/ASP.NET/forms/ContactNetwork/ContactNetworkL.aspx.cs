﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_37352
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ContactNetworkL : BaseListForm<ContactNetwork>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ContactNetworkL() : base(ContactNetwork.Views.ContactNetworkL)
        {
            EditPage = ContactNetworkE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/ContactNetwork/ContactNetworkL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
