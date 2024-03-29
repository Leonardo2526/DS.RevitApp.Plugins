﻿using DS.ClassLib.VarUtils;
using DS.MEPCurveTraversability.Interactors;
using DS.MEPCurveTraversability.Interactors.Settings;
using MoreLinq;
using Rhino;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UnitSystem = Rhino.UnitSystem;

namespace DS.MEPCurveTraversability.Presenters
{
    public class RoomTraversionViewModel : IRoomTraversionSettings, INotifyPropertyChanged
    {
        private static readonly double _cmToFeet =
         RhinoMath.UnitScale(UnitSystem.Centimeters, UnitSystem.Feet);

        private static readonly double _feetToCM =
            RhinoMath.UnitScale(UnitSystem.Feet, UnitSystem.Centimeters);

        private readonly IRoomTraversionSettings _settings;
        private string _itemToAdd;

        public RoomTraversionViewModel(IRoomTraversionSettings settings)
        {
            var t1 = _cmToFeet;
            var t2 = _feetToCM;
            _settings = settings;
            settings.ExcludeFields.ForEach(StringCollection.Add);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public bool CheckEndPoints
        {
            get => _settings.CheckEndPoints;
            set 
            { 
                _settings.CheckEndPoints = value; 
                OnPropertyChanged(nameof(CheckEndPoints)); 
            }
        }

        public bool CheckSolid
        {
            get => _settings.CheckSolid;
            set { _settings.CheckSolid = value; 
                OnPropertyChanged(nameof(CheckSolid)); }
        }

        public bool CheckNames
        {
            get => _settings.CheckNames;
            set {
                _settings.CheckNames = value;
                OnPropertyChanged(nameof(CheckNames));
            }
        }

        public IEnumerable<string> ExcludeFields
        {
            get => _settings.ExcludeFields;
            set => _settings.ExcludeFields = value.ToList();
        }

        public double MinResidualVolume
        {
            get => _settings.MinResidualVolume * Math.Pow(_feetToCM, 3);
            set => _settings.MinResidualVolume = value * Math.Pow(_cmToFeet,3);
        }

        public bool StrictFieldCompliance
        {
            get => _settings.StrictFieldCompliance;
            set => _settings.StrictFieldCompliance = value;
        }

        public ObservableCollection<string> StringCollection { get; } = new();


        public string ItemToRemove { get; set; }
        public string ItemToAdd
        {
            get => _itemToAdd;
            set
            {
                _itemToAdd = value;
                OnPropertyChanged(nameof(ItemToAdd));
            }

        }

        #region Commands

        public ICommand AddItem => new RelayCommand(p =>
        {
            StringCollection.Add(ItemToAdd);
            ItemToAdd = string.Empty;
        }, _ => !string.IsNullOrEmpty(ItemToAdd));

        public ICommand SetDefault => new RelayCommand(p =>
        {
            StringCollection.Clear();
            _settings.SetDefault();
            _settings.ExcludeFields.ForEach(f => StringCollection.Add(f));
        }, _ => true);

        public ICommand RemoveItem => new RelayCommand(p =>
        {
            string targetItem = ItemToRemove is null ?
             StringCollection.Last() : ItemToRemove;
            StringCollection.Remove(targetItem);
        }, _ => StringCollection.Count > 0);

        public ICommand RemoveAll => new RelayCommand(p =>
        {
            StringCollection.Clear();
        }, _ => StringCollection.Count > 0);

        public ICommand CloseWindow => new RelayCommand(p =>
        {
            _settings.ExcludeFields = StringCollection.Select(c => c);
        });

        /// <summary>
        /// Notify on change propterty;
        /// </summary>
        /// <param name="prop"></param>
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        void IRoomTraversionSettings.SetDefault()
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
