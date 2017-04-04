﻿/*flexberryautogenerated="false"*/

namespace TeploCorp.TeploUchet
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;
    using System.Web;
    using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using System.Linq;
    using ICSSoft.STORMNET.FunctionalLanguage;
    using ICSSoft.STORMNET;
    using System.Web.UI.WebControls;
    using ICSSoft.STORMNET.Web.AjaxControls;
    using System.Collections.Generic;
    using System.Collections;
    using System.Data;

    public partial class УчастокСетиM : BaseEditForm<УчастокСети>
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public УчастокСетиM()
            : base(УчастокСети.Views.УчастокСетиE)
        {
        }

        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/UchastokSeti/UchastokSetiM.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {

        }

        /// <summary>
        /// Здесь лучше всего писать бизнес-логику, оперируя только объектом данных.
        /// </summary>
        protected override void PreApplyToControls()
        {
            
        }

        /// <summary>
        /// Здесь лучше всего изменять свойства контролов на странице,
        /// которые не обрабатываются WebBinder.
        /// </summary>
        protected override void PostApplyToControls()
        { 
            ctrlОбъект.PropertyToShow = Information.ExtractPropertyPath<Объект>(x => x.Наименование);
            
            //объект выбран
            if (ctrlОбъект.SelectedMasterPK != "")
            {
                MainPanel.Visible = true;
                var objectKey = ctrlОбъект.SelectedMasterPK;
                IDataService _dataService = DataServiceProvider.DataService;
                var countSeti = _dataService.Query<УчастокСети>(УчастокСети.Views.УчастокСетиE)
                                            .Where(x => x.Актуален == true)
                                            .Count(x => x.Объект.__PrimaryKey.ToString() == objectKey);
                var samObject = _dataService.Query<Объект>(Объект.Views.ОбъектE)
                                            .FirstOrDefault(x => x.__PrimaryKey.ToString() == objectKey);
                //наименование объекта
                Label objectTitleLabel = new Label();
                objectTitleLabel.CssClass = " object-info";
                objectTitleLabel.Text = "Наименование: " + samObject.Наименование;
                //здание
                Label objectBuildLabel = new Label();
                objectBuildLabel.CssClass = " object-info";
                objectBuildLabel.Text = "Адрес: " + samObject.Здание.Адрес;
                //контрагент
                Label objectAgentLabel = new Label();
                objectAgentLabel.CssClass = " object-info";
                objectAgentLabel.Text = "Контрагент: " + samObject.Контрагент;
                //панель объекта = наименование, адрес здания, сконтрагент
                Panel objectInfoPanel = new Panel();
                objectInfoPanel.Controls.Add(objectTitleLabel);
                objectInfoPanel.Controls.Add(objectBuildLabel);
                objectInfoPanel.Controls.Add(objectAgentLabel);
                ObjectPanel.Controls.Add(objectInfoPanel);

                //участки в объекте есть
                if (countSeti != 0)
                {
                    var objectSeti = _dataService.Query<УчастокСети>(УчастокСети.Views.УчастокСетиE)
                                                .Where(x => x.Актуален == true)
                                                .Where(x => x.Объект.__PrimaryKey.ToString() == objectKey);
                    //участки в виде панели = информация, панель ввода
                    foreach (var each in objectSeti)
                    {
                        var eachNumber = each.Номер.ToString();
                        var eachKey = each.__PrimaryKey.ToString();
                        //панель участка(информация) = номер, тип изоляции, номер для сортировки(hide)
                        Panel panel = new Panel();
                        panel.ID = each.__PrimaryKey.ToString();
                        panel.CssClass = "sector sector-" + each.Номер.ToString() + " draggable";
                        if (each.ТипМонтажа == ЗначенияМонтажа.Надземный) { panel.CssClass = panel.CssClass + " overground"; }
                        if (each.ТипМонтажа == ЗначенияМонтажа.Подземный) { panel.CssClass = panel.CssClass + " underground"; }
                        if (each.ТипМонтажа == ЗначенияМонтажа.ПоПодвалу) { panel.CssClass = panel.CssClass + " basement"; }

                        // номера участка
                        Label infoLabel = new Label();
                        infoLabel.ID = "infoLabel-" + eachNumber;
                        infoLabel.Text = "Участок теплосети №" + eachNumber;

                        // изоляции участка
                        Label insulationLabel = new Label();
                        insulationLabel.ID = "infoInsulation-" + eachNumber;
                        insulationLabel.Text = "Теплоизоляция: " + eachNumber;

                        // номер участка для сортировки
                        Label numberLabel = new Label();
                        numberLabel.ID = "numberLabel-" + eachNumber;
                        numberLabel.CssClass = " hidden";
                        string aElem = "<a class='hidden index' name=" + eachNumber + "></a>";
                        numberLabel.Text = aElem;

                        //панель для информации об участке
                        Panel infoPanel = new Panel();
                        infoPanel.ID = "infoPanel-" + eachNumber;
                        infoPanel.CssClass = "clickable";
                        infoPanel.Controls.Add(infoLabel);
                        infoPanel.Controls.Add(insulationLabel);
                        infoPanel.Controls.Add(numberLabel);
                        panel.Controls.Add(infoPanel);

                        //панель ввода инфы = вид прокладки, теплоизоляция, дата прокладки
                        //вид прокладки
                        Label mountLabel = new Label();
                        mountLabel.Text = "Вид прокладки: ";
                        DropDownList mount = new DropDownList();
                        mount.ID = "mountList-" + eachKey;
                        mount.CssClass = mount.CssClass + " MountType";
                        mount.DataSource = CreateDataSource();
                        mount.DataTextField = "TextValue";
                        mount.DataValueField = "CurrentValue";
                        mount.DataBind();
                        mount.SelectedValue = each.ТипМонтажа.ToString();

                        //теплоизоляция
                        Label insulationLabel2 = new Label();
                        insulationLabel2.Text = "Тип теплоизоляции: ";
                        TextBox infoNumber = new TextBox();
                        infoNumber.ID = "infoNumber-" + eachKey;
                        infoNumber.Text = each.Номер.ToString();
                        //датапрокладки
                        Label dateLabel = new Label();
                        dateLabel.Text = "Дата прокладки";
                        DatePicker date = new DatePicker();
                        date.ID = "date-" + eachKey; 
                        date.Value = each.ГодПрокладки;
                        //кнопка ок
                        Button btn = new Button();
                        btn.Text = "Ok";
                        btn.OnClientClick = "OkClick";
                                                
                        //панель ввода
                        Panel inputPanel = new Panel();
                        inputPanel.ID = "inputPanel" + eachNumber;
                        inputPanel.CssClass = "hidden fieldset";
                        inputPanel.Controls.Add(mountLabel);
                        inputPanel.Controls.Add(mount);
                        inputPanel.Controls.Add(insulationLabel2);
                        inputPanel.Controls.Add(infoNumber);
                        inputPanel.Controls.Add(dateLabel);
                        inputPanel.Controls.Add(date);
                        inputPanel.Controls.Add(btn);
                        panel.Controls.Add(inputPanel);

                        //участок создан
                        //присвоение участка окну
                        if (each.ТипСети == ТипыСети.Наружная)
                        {
                            MainPanel.Controls.Add(panel);
                        }
                        else
                        {
                            ObjectPanel.Controls.Add(panel);
                        };
                    }
                }
                else
                {
                    //TODO
                    //сообщение 
                    MainPanel.Visible = false;
                }
            }
            Page.Validate();
        }
        
        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
            string strUser = HttpContext.Current.User.Identity.Name;
            var _dataService = (SQLDataService)DataServiceProvider.DataService;
            var _Inspector = _dataService.Query<Инспектор>(Инспектор.Views.ИнспекторL).FirstOrDefault(x => x.Логин == strUser); // получаем объект инспектор по логину

            if (_Inspector != null)
            {
                SQLWhereLanguageDef langdef = SQLWhereLanguageDef.LanguageDef;
                string strDistrictName = _Inspector.Район.Название; //название района инспектора

                Function lf = langdef.GetFunction(langdef.funcAND,
                                    langdef.GetFunction(langdef.funcEQ,
                                        new VariableDef(langdef.StringType, Information.ExtractPropertyPath<Объект>(x => x.Здание.Район.Название)),
                                        strDistrictName),
                                    langdef.GetFunction(langdef.funcEQ,
                                        new VariableDef(langdef.StringType, Information.ExtractPropertyPath<Объект>(x => x.Актуален)),
                                        true));
                ctrlОбъект.LimitFunction = lf;
            };
        }

        /// <summary>
        /// Валидация объекта для сохранения.
        /// </summary>
        /// <returns>true - продолжать сохранение, иначе - прекратить.</returns>
        protected override bool PreSaveObject()
        {
            var p = MainPanel.Controls.Count; //удалить 
            if (ctrlОбъект.SelectedMasterPK != "" && MainPanel.Controls.Count > 1 )
            {
                int col = MainPanel.Controls.Count;
                int sectorsNumb = 0;
                int[] sectorIndex = null;
                for (int i = 0; i < col; i++)
                {
                    if (MainPanel.Controls[i].ID.Contains("mountList-") )
                    {
                        var keyFromMountList = MainPanel.Controls[i].GetType();
                        keyFromMountList xuz = new keyFromMountList();
                    }
                    if ( MainPanel.Controls[i].ID.Contains("sector"))
                    {

                    }
                };
                for (int i = 0; )

            }
            ///TODO сообщение
            return false;
        }

        /// <summary>
        /// Нетривиальная логика сохранения объекта.
        /// </summary>
        /// <returns>Объект данных, который сохранился.</returns>
        protected override DataObject SaveObject()
        {             
            return base.SaveObject();
        }        
        //клик по создать схему
        protected void applyBtn_Click(object sender, EventArgs e)
        {
            
        }
        //строки для спискового элемента
        private object CreateDataSource()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add(new DataColumn("TextValue", typeof(string)));
            dt.Columns.Add(new DataColumn("CurrentValue", typeof(string)));

            dr = dt.NewRow();
            dr[0] = "Надземная";
            dr[1] = "Надземная";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "Подземная";
            dr[1] = "Подземная";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "По подвалу";
            dr[1] = "ПоПодвалу";
            dt.Rows.Add(dr);
            
            DataView dv = new DataView(dt);
            return dv;
        }
    }
}