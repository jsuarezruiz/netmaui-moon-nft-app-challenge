using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MoonNFTApp.Services;
using System.Collections.ObjectModel;

namespace MoonNFTApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        readonly NFTService _NFTService;

        public MainViewModel(NFTService NFTService)
        {
            _NFTService = NFTService;

            LoadData();
        }
        
        public ObservableCollection<string> ArtCollection01 { get; set; }
        public ObservableCollection<string> ArtCollection02 { get; set; }
        public ObservableCollection<string> ArtCollection03 { get; set; }
        
        [RelayCommand]
        void LoadMoreArtCollection01()
        {
            var artCollection01 = _NFTService.GetArtCollection01();

            foreach (var artItem in artCollection01)
            {
                ArtCollection01.Add(artItem);
            }
        }

        [RelayCommand]
        void LoadMoreArtCollection02()
        {
            var artCollection02 = _NFTService.GetArtCollection02();

            foreach (var artItem in artCollection02)
            {
                ArtCollection02.Add(artItem);
            }
        }

        [RelayCommand]
        void LoadMoreArtCollection03()
        {
            var artCollection03 = _NFTService.GetArtCollection03();

            foreach (var artItem in artCollection03)
            {
                ArtCollection03.Add(artItem);
            }
        }

        void LoadData()
        {
            ArtCollection01 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection01 = _NFTService.GetArtCollection01();

                foreach(var artItem in artCollection01)
                {
                    ArtCollection01.Add(artItem);
                }
            }

            ArtCollection02 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection02 = _NFTService.GetArtCollection02();

                foreach (var artItem in artCollection02)
                {
                    ArtCollection02.Add(artItem);
                }
            }

            ArtCollection03 = new ObservableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                var artCollection03 = _NFTService.GetArtCollection03();

                foreach (var artItem in artCollection03)
                {
                    ArtCollection03.Add(artItem);
                }
            }
        }
    }
}
