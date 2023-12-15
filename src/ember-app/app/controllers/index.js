import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.справочник.caption'),
          title: i18n.t('forms.application.sitemap.справочник.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-дир-отд-по-раб-с-кл-l',
            caption: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-дир-отд-по-раб-с-кл-l.caption'),
            title: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-дир-отд-по-раб-с-кл-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-клиент-l',
            caption: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-клиент-l.caption'),
            title: i18n.t('forms.application.sitemap.справочник.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-клиент-l.title'),
            icon: 'list',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.документ.caption'),
          title: i18n.t('forms.application.sitemap.документ.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-договор-l',
            caption: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-договор-l.caption'),
            title: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-договор-l.title'),
            children: null
          }, {
            link: 'i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-расчет-ост-врем-l',
            caption: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-расчет-ост-врем-l.caption'),
            title: i18n.t('forms.application.sitemap.документ.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-расчет-ост-врем-l.title'),
            icon: 'suitcase',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.прочее.caption'),
          title: i18n.t('forms.application.sitemap.прочее.title'),
          children: [{
            link: 'i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-услуги-l',
            caption: i18n.t('forms.application.sitemap.прочее.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-услуги-l.caption'),
            title: i18n.t('forms.application.sitemap.прочее.i-i-s-modul-ucheta-sroka-dejjstviya-zaklyuchennykh-dogovorov-услуги-l.title'),
            icon: 'chart bar',
            children: null
          }]
        }
      ]
    };
  }),
})