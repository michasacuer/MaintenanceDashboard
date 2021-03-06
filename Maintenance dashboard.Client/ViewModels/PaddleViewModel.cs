﻿using MaintenanceDashboard.Data.Api;
using MaintenanceDashboard.Data.Domain;
using MaintenanceDashboard.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace MaintenanceDashboard.Client.ViewModels
{
    public class PaddleViewModel : ViewModel
    {
        private const string _paddleBarcodePattern = "Pal[0-9]{1,3}$";
        private readonly IPaddleContext context;

        public ICollection<Paddle> Paddles { get; private set; }

        public string Number { get; set; }
        public string Comments { get; set; }

        private string _Model = "VW380 T1/T2 Base/High";
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        private bool _connectedSuccessfully;
        public bool ConnectedSuccessfully
        {
            get { return _connectedSuccessfully; }
            set
            {
                _connectedSuccessfully = value;
                NotifyPropertyChanged();
            }
        }

        private Paddle _selectedPaddle;
        public Paddle SelectedPaddle
        {
            get { return _selectedPaddle; }
            set
            {
                _selectedPaddle = value;
                NotifyPropertyChanged();
            }
        }

        private string _addedData = DateTime.Now.ToString("dd/MM/yyyy");
        public string AddedDate
        {
            get { return _addedData; }
            set { _addedData = value; }
        }

        public PaddleViewModel(IPaddleContext context)
        {
            this.context = context;
            Paddles = new ObservableCollection<Paddle>();
        }

        public ActionCommand CreatePaddleCommand
        {
            get
            {
                return new ActionCommand(p => CreatePaddle(),
                    p => IsValidPaddle());
            }
        }

        public ActionCommand SavePaddleCommand
        {
            get
            {
                return new ActionCommand(p => SavePaddle());

            }
        }


        public bool IsValidPaddle()
        {
            if (OnValidate(Number) != null)
                return false;
            return true;
        }

        protected override string OnValidate(string propertyName)
        {
            if (String.IsNullOrEmpty(Number))
                return "Pole musi być wypełnione";
            else if (!Regex.IsMatch(Number, _paddleBarcodePattern))
                return "Niepoprawna składnia ciągu {Pal...}";
            else if (context.CheckPaddleExist(Number))
                return "Paletka istnieje już w bazie danych";
            return base.OnValidate(propertyName);
        }


        private void CreatePaddle()
        {
            var paddle = new Paddle
            {
                Number = Number,
                Model = Model,
                AddedDate = AddedDate,
                LastPrevention = DateTime.Now.ToString("dd/MM/yyyy"),
                Comments = Comments
            };

            context.CreatePaddle(paddle);
            ConnectedSuccessfully = true;
        }

        public void GetPaddleList()
        {
            Paddles.Clear();
            SelectedPaddle = null;

            foreach (var item in context.GetPaddleList())
                Paddles.Add(item);
        }

        private void SavePaddle()
        {
            if (SelectedPaddle != null)
                context.UpdatePaddle(SelectedPaddle);
        }

    }
}
