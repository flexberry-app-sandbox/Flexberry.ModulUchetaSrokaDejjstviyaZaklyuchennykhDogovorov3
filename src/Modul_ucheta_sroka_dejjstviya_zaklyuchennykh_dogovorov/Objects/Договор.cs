﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Договор.
    /// </summary>
    // *** Start programmer edit section *** (Договор CustomAttributes)

    // *** End programmer edit section *** (Договор CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ДоговорE", new string[] {
            "Номер as \'Номер\'",
            "Дата as \'Дата\'",
            "Статус as \'Статус\'",
            "Тип as \'Тип\'",
            "Стоимость as \'Стоимость\'",
            "Длительность as \'Длительность\'",
            "ЕдВремени as \'Единица времени\'",
            "ДирОтдПоРабСКл as \'Фамилия директора\'",
            "ДирОтдПоРабСКл.Имя as \'Имя директора\'",
            "ДирОтдПоРабСКл.Отчество as \'Отчество директора\'",
            "Клиент as \'Фамилия клиента\'",
            "Клиент.Имя as \'Имя клиента\'",
            "Клиент.Отчество as \'Отчество клиента\'"})]
    [MasterViewDefineAttribute("ДоговорE", "ДирОтдПоРабСКл", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [MasterViewDefineAttribute("ДоговорE", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Фамилия")]
    [View("ДоговорL", new string[] {
            "Номер as \'Номер\'",
            "Дата as \'Дата\'",
            "Статус as \'Статус\'",
            "Тип as \'Тип\'",
            "Стоимость as \'Стоимость\'",
            "Длительность as \'Длительность\'",
            "ЕдВремени as \'Ед времени\'",
            "ДирОтдПоРабСКл.Фамилия as \'Фамилия директора\'",
            "Клиент.Фамилия as \'Фамилия клиента\'"})]
    public class Договор : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private System.DateTime fДата;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Статус fСтатус;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ТипДоговора fТип;
        
        private int fСтоимость;
        
        private double fДлительность;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ЕдВремени fЕдВремени;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Клиент fКлиент;
        
        private IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ДирОтдПоРабСКл fДирОтдПоРабСКл;
        
        // *** Start programmer edit section *** (Договор CustomMembers)

        // *** End programmer edit section *** (Договор CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Дата CustomAttributes)

        // *** End programmer edit section *** (Договор.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Дата Get start)

                // *** End programmer edit section *** (Договор.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Договор.Дата Get end)

                // *** End programmer edit section *** (Договор.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Дата Set start)

                // *** End programmer edit section *** (Договор.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Договор.Дата Set end)

                // *** End programmer edit section *** (Договор.Дата Set end)
            }
        }
        
        /// <summary>
        /// Длительность.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Длительность CustomAttributes)

        // *** End programmer edit section *** (Договор.Длительность CustomAttributes)
        public virtual double Длительность
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Длительность Get start)

                // *** End programmer edit section *** (Договор.Длительность Get start)
                double result = this.fДлительность;
                // *** Start programmer edit section *** (Договор.Длительность Get end)

                // *** End programmer edit section *** (Договор.Длительность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Длительность Set start)

                // *** End programmer edit section *** (Договор.Длительность Set start)
                this.fДлительность = value;
                // *** Start programmer edit section *** (Договор.Длительность Set end)

                // *** End programmer edit section *** (Договор.Длительность Set end)
            }
        }
        
        /// <summary>
        /// ЕдВремени.
        /// </summary>
        // *** Start programmer edit section *** (Договор.ЕдВремени CustomAttributes)

        // *** End programmer edit section *** (Договор.ЕдВремени CustomAttributes)
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ЕдВремени ЕдВремени
        {
            get
            {
                // *** Start programmer edit section *** (Договор.ЕдВремени Get start)

                // *** End programmer edit section *** (Договор.ЕдВремени Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ЕдВремени result = this.fЕдВремени;
                // *** Start programmer edit section *** (Договор.ЕдВремени Get end)

                // *** End programmer edit section *** (Договор.ЕдВремени Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.ЕдВремени Set start)

                // *** End programmer edit section *** (Договор.ЕдВремени Set start)
                this.fЕдВремени = value;
                // *** Start programmer edit section *** (Договор.ЕдВремени Set end)

                // *** End programmer edit section *** (Договор.ЕдВремени Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Номер CustomAttributes)

        // *** End programmer edit section *** (Договор.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Номер Get start)

                // *** End programmer edit section *** (Договор.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Договор.Номер Get end)

                // *** End programmer edit section *** (Договор.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Номер Set start)

                // *** End programmer edit section *** (Договор.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Договор.Номер Set end)

                // *** End programmer edit section *** (Договор.Номер Set end)
            }
        }
        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Статус CustomAttributes)

        // *** End programmer edit section *** (Договор.Статус CustomAttributes)
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Статус Статус
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Статус Get start)

                // *** End programmer edit section *** (Договор.Статус Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Статус result = this.fСтатус;
                // *** Start programmer edit section *** (Договор.Статус Get end)

                // *** End programmer edit section *** (Договор.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Статус Set start)

                // *** End programmer edit section *** (Договор.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (Договор.Статус Set end)

                // *** End programmer edit section *** (Договор.Статус Set end)
            }
        }
        
        /// <summary>
        /// Стоимость.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Стоимость CustomAttributes)

        // *** End programmer edit section *** (Договор.Стоимость CustomAttributes)
        public virtual int Стоимость
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Стоимость Get start)

                // *** End programmer edit section *** (Договор.Стоимость Get start)
                int result = this.fСтоимость;
                // *** Start programmer edit section *** (Договор.Стоимость Get end)

                // *** End programmer edit section *** (Договор.Стоимость Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Стоимость Set start)

                // *** End programmer edit section *** (Договор.Стоимость Set start)
                this.fСтоимость = value;
                // *** Start programmer edit section *** (Договор.Стоимость Set end)

                // *** End programmer edit section *** (Договор.Стоимость Set end)
            }
        }
        
        /// <summary>
        /// Тип.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Тип CustomAttributes)

        // *** End programmer edit section *** (Договор.Тип CustomAttributes)
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ТипДоговора Тип
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Тип Get start)

                // *** End programmer edit section *** (Договор.Тип Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ТипДоговора result = this.fТип;
                // *** Start programmer edit section *** (Договор.Тип Get end)

                // *** End programmer edit section *** (Договор.Тип Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Тип Set start)

                // *** End programmer edit section *** (Договор.Тип Set start)
                this.fТип = value;
                // *** Start programmer edit section *** (Договор.Тип Set end)

                // *** End programmer edit section *** (Договор.Тип Set end)
            }
        }
        
        /// <summary>
        /// Договор.
        /// </summary>
        // *** Start programmer edit section *** (Договор.ДирОтдПоРабСКл CustomAttributes)

        // *** End programmer edit section *** (Договор.ДирОтдПоРабСКл CustomAttributes)
        [PropertyStorage(new string[] {
                "ДирОтдПоРабСКл"})]
        [NotNull()]
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ДирОтдПоРабСКл ДирОтдПоРабСКл
        {
            get
            {
                // *** Start programmer edit section *** (Договор.ДирОтдПоРабСКл Get start)

                // *** End programmer edit section *** (Договор.ДирОтдПоРабСКл Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.ДирОтдПоРабСКл result = this.fДирОтдПоРабСКл;
                // *** Start programmer edit section *** (Договор.ДирОтдПоРабСКл Get end)

                // *** End programmer edit section *** (Договор.ДирОтдПоРабСКл Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.ДирОтдПоРабСКл Set start)

                // *** End programmer edit section *** (Договор.ДирОтдПоРабСКл Set start)
                this.fДирОтдПоРабСКл = value;
                // *** Start programmer edit section *** (Договор.ДирОтдПоРабСКл Set end)

                // *** End programmer edit section *** (Договор.ДирОтдПоРабСКл Set end)
            }
        }
        
        /// <summary>
        /// Договор.
        /// </summary>
        // *** Start programmer edit section *** (Договор.Клиент CustomAttributes)

        // *** End programmer edit section *** (Договор.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        [NotNull()]
        public virtual IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (Договор.Клиент Get start)

                // *** End programmer edit section *** (Договор.Клиент Get start)
                IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (Договор.Клиент Get end)

                // *** End programmer edit section *** (Договор.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Договор.Клиент Set start)

                // *** End programmer edit section *** (Договор.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (Договор.Клиент Set end)

                // *** End programmer edit section *** (Договор.Клиент Set end)
            }
        }
        
        // *** Start programmer edit section *** (Договор.Отправить CustomAttributes)

        // *** End programmer edit section *** (Договор.Отправить CustomAttributes)
        [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
        public virtual void Отправить()
        {
            // *** Start programmer edit section *** (Договор.Отправить method implementation)

            return;
            // *** End programmer edit section *** (Договор.Отправить method implementation)
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ДоговорE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДоговорE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДоговорE", typeof(IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Договор));
                }
            }
            
            /// <summary>
            /// "ДоговорL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ДоговорL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ДоговорL", typeof(IIS.Modul_ucheta_sroka_dejjstviya_zaklyuchennykh_dogovorov.Договор));
                }
            }
        }
    }
}
