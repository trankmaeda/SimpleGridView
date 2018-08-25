﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleGridView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Prefecture> Prefectures { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();

            InitializeDummyData();
        }

        private void InitializeDummyData()
        {
            Prefectures = new ObservableCollection<Prefecture>
            {
                new Prefecture
                {
                    ID = 1,
                    Name = "Aomori",
                    StartDate = new DateTime(1945, 8, 15),
                    Cities = new List<City>
                    {
                        new City
                        {
                            ID = 11,
                            Name = "Aomori",
                            Mayor = "AomoriJin",
                        },
                        new City
                        {
                            ID = 12,
                            Name = "Hiromae",
                            Mayor = "Hirosi",
                        },
                        new City
                        {
                            ID = 13,
                            Name = "Yato",
                            Mayor = "Yassan",
                        },
                        new City
                        {
                            ID = 14,
                            Name = "Kuroisi",
                            Mayor = "Kuroi",
                        },
                        new City
                        {
                            ID = 15,
                            Name = "Goshogawara",
                            Mayor = "Gomi",
                        },
                    },
                },
                new Prefecture
                {
                    ID = 2,
                    Name = "Akita",
                    StartDate = new DateTime(1977, 7, 10),
                    Cities = new List<City>
                    {
                        new City
                        {
                            ID = 21,
                            Name = "Akita",
                            Mayor = "Akiyama",
                        },
                        new City
                        {
                            ID = 22,
                            Name = "Ojika",
                            Mayor = "Oji",
                        },
                        new City
                        {
                            ID = 23,
                            Name = "Gojou",
                            Mayor = "Gojin",
                        },
                    },
                },
                new Prefecture
                {
                    ID = 3,
                    Name = "Iwate",
                    StartDate = DateTime.Now,
                    Cities = new List<City>
                    {
                        new City
                        {
                            ID = 31,
                            Name = "Morioka",
                            Mayor = "Morita",
                        },
                        new City
                        {
                            ID = 32,
                            Name = "Hatimanndaira",
                            Mayor = "Yassan",
                        },
                        new City
                        {
                            ID = 33,
                            Name = "Takizawa",
                            Mayor = "Tanigawa",
                        },
                        new City
                        {
                            ID = 34,
                            Name = "Iwate",
                            Mayor = "Iwama",
                        },
                    },
                },
            };
        }
    }
}
