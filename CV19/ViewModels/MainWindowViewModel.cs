using CV19.ViewModels.Base;
namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        /// <summary>Заголовок окна приложения.</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status : string - Статус программы 

        /// <summary>Статус программы.</summary>
        private string _Status =  "Готов!";

        /// <summary>Статус программы.</summary>
        public string Status 
        { 
            get => _Status;
            set => Set(ref _Status, value); 
        }
        #endregion


    }
}
