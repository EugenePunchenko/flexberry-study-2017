﻿/*flexberryautogenerated="true"*/
namespace IIS.Product_58826
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class СтудентL : BaseListForm<Студент>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public СтудентL() : base(Студент.Views.СтудентL)
        {
            EditPage = СтудентE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Student/StudentL.aspx"; }
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
