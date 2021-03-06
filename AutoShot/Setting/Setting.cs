﻿using AutoShot.Converter;
using AutoShot.Effectors;
using AutoShot.Worker;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using AutoShot.Collections;

namespace AutoShot.Setting
{
    [Serializable]
    public class Setting : ICloneable
    {
        
        public delegate void SettingChangeHandler();

        List<SettingChangeHandler> delegates = new List<SettingChangeHandler>();

        private event SettingChangeHandler _SettingChangeEvent;
        public event SettingChangeHandler SettingChangeEvent
        {
            add
            {
                _SettingChangeEvent += value;
                delegates.Add(value);
            }
            remove
            {
                _SettingChangeEvent -= value;
                delegates.Remove(value);
            }
        }

        public void RemoveAllEvents()
        {
            foreach(SettingChangeHandler sch in delegates)
            {
                _SettingChangeEvent -= sch;
            }
            _AllCaptureKey.RemoveAllEvents();
            _AutoCaptureKey.RemoveAllEvents();
            _OpenSettingKey.RemoveAllEvents();
            _SelectCaptureKey.RemoveAllEvents();
            _ChangeEditorModeKey.RemoveAllEvents();
            delegates.Clear();
        }

        public void OnSettingChange()
        {
            _SettingChangeEvent?.Invoke();
        }

        public object Clone()
        {
            Setting setting = new Setting(DefaultPattern);
            
            setting._AllCaptureCountDown = _AllCaptureCountDown;
            setting._ChangeEditorModeKey = _ChangeEditorModeKey;
            setting._AllCaptureKey = _AllCaptureKey.Clone() as Shortcut;
            setting._AutoCaptureEnableSelection = _AutoCaptureEnableSelection;
            setting._AutoCaptureKey = _AutoCaptureKey.Clone() as Shortcut;
            setting._DefaultPattern = _DefaultPattern;
            setting._ImageFromImageTag = _ImageFromImageTag;
            setting._ImageFromURLSave = _ImageFromURLSave;
            setting._OpenSettingKey = _OpenSettingKey.Clone() as Shortcut;
            setting._Patterns = (NotifyList<SavePattern>)_Patterns.Clone();
            setting._DefaultPattern = _DefaultPattern;
            setting._PopupCountSec = _PopupCountSec;
            setting._RecoHeight = _RecoHeight;
            setting._RecoWidth = _RecoWidth;
            setting._SelectCaptureKey = _SelectCaptureKey.Clone() as Shortcut;
            setting._TutorialProgress = _TutorialProgress;
            setting._IsStartupProgram = _IsStartupProgram;

            return setting;
        }

        public Setting(SavePattern ptn)
        {
            _Patterns.ListChanged += ListChanged;
            _Patterns.Add(ptn);
            _DefaultPattern = ptn;
        }

        private void ListChanged(object sender, ChangeEventArgs<SavePattern> e)
        {
            if (e.Action == ChangeAction.Remove) DefaultPatternIndex = 0;
            OnSettingChange();
        }

        public void AddHandler()
        {
            _AllCaptureKey.ValueChangedEvent += KeyChange;
            _AutoCaptureKey.ValueChangedEvent += KeyChange;
            _OpenSettingKey.ValueChangedEvent += KeyChange;
            _SelectCaptureKey.ValueChangedEvent += KeyChange;
        }

        private void KeyChange()
        {
            OnSettingChange();
        }

        #region [  캡처 설정  ]

        #region [ 캡처 설정 - 자동 캡처 활성화 시 ]

        private CaptureNotifionMode _AutoCaptureEnableSelection = CaptureNotifionMode.SoundAndPopUp;
        /// <summary>
        /// 자동 캡처 활성화 시 알림 선택 방식을 말합니다.
        /// </summary>
        public CaptureNotifionMode AutoCaptureEnableSelection
        {
            get { return _AutoCaptureEnableSelection; }
            set { _AutoCaptureEnableSelection = value; OnSettingChange(); }
        }

        private LimitInt _PopupCountSec = new LimitInt(1, 3, 1);
        /// <summary>
        /// 팝업으로 띄우기시 나타낼 초를 나타냅니다 최소 1, 최대 3입니다.
        /// </summary>
        public int PopupCountSecond
        {
            get { return _PopupCountSec.Value; }
            set { _PopupCountSec.Value = value; OnSettingChange(); }
        }

        #endregion

        private LimitInt _AllCaptureCountDown = new LimitInt(0, 5, 0);
        /// <summary>
        /// 전체 캡처 시 카운트 다운
        /// </summary>
        public int AllCaptureCountDown
        {
            get { return _AllCaptureCountDown.Value; }
            set { _AllCaptureCountDown.Value = value; OnSettingChange(); }
        }

        private ImageSaveMode _ImageFromURLSave = ImageSaveMode.Ask;
        /// <summary>
        /// 이미지를 URL로 부터 가져올때 저장 방법입니다.
        /// </summary>
        public ImageSaveMode ImageFromURLSave
        {
            get { return _ImageFromURLSave; }
            set { _ImageFromURLSave = value; OnSettingChange(); }
        }

        private ImageSaveMode _ImageFromImageTag = ImageSaveMode.Ask;
        /// <summary>
        /// 이미지를 Image Tag로 부터 가져올때 저장 방법입니다.
        /// </summary>
        public ImageSaveMode ImageFromImageTag
        {
            get { return _ImageFromImageTag; }
            set { _ImageFromImageTag = value; OnSettingChange(); }
        }
        #endregion
        
        #region [  환경 설정  ]

        private int _RecoWidth = 1;
        private int _RecoHeight = 1;

        public Size RecoSize
        {
            get { return new Size(_RecoWidth, _RecoHeight); }
        }

        public int RecoWidth
        {
            get { return _RecoWidth; }
            set { _RecoWidth = value; OnSettingChange(); }
        }
        public int RecoHeight
        {
            get { return _RecoHeight; }
            set { _RecoHeight = value; OnSettingChange(); }
        }

        #region [  환경 설정 - 단축키 설정  ]
        private Shortcut _AutoCaptureKey = new Shortcut("AutoCapture", Key.D2, true, false, false);
        public Shortcut AutoCaptureKey
        {
            get { return _AutoCaptureKey; }
            set { _AutoCaptureKey = value; OnSettingChange(); }
        }
        private Shortcut _SelectCaptureKey = new Shortcut("SelCapture", Key.D4, true, false, false);
        public Shortcut SelectCaptureKey
        {
            get { return _SelectCaptureKey; }
            set { _SelectCaptureKey = value; OnSettingChange(); }
        }
        private Shortcut _AllCaptureKey = new Shortcut("AllCapture", Key.D3, true, false, false);
        public Shortcut AllCaptureKey
        {
            get { return _AllCaptureKey; }
            set { _AllCaptureKey = value; OnSettingChange(); }
        }
        private Shortcut _OpenSettingKey = new Shortcut("OpenSetting", Key.D1, true, false, false);
        public Shortcut OpenSettingKey
        {
            get { return _OpenSettingKey; }
            set { _OpenSettingKey = value; OnSettingChange(); }
        }
        private Shortcut _ChangeEditorModeKey = new Shortcut("ChangeEditorMode", Key.D5, true, false, false);
        public Shortcut ChangeEditorModeKey
        {
            get { return _ChangeEditorModeKey; }
            set { _ChangeEditorModeKey = value;  OnSettingChange(); }
        }
        #endregion
        #endregion
        
        #region [  패턴 관리  ]

        private SavePattern _DefaultPattern;
        public SavePattern DefaultPattern
        {
            get
            {
                return _DefaultPattern;
            }
            set
            {
                if (!_Patterns.Contains(value)) { throw new Exception("DefaultPattern는 Patterns에 포함된 아이템이여야만 합니다."); }
                _DefaultPattern = value;
                OnSettingChange();
            }
        }
        public int DefaultPatternIndex
        {
            get { return _Patterns.IndexOf(DefaultPattern); }
            set { DefaultPattern = _Patterns[value]; OnSettingChange(); }
        }

        NotifyList<SavePattern> _Patterns = new NotifyList<SavePattern>();
        public NotifyList<SavePattern> Patterns
        {
            get { return _Patterns; }
            set { _Patterns = value; OnSettingChange(); }
        }
        #endregion



        private bool _TutorialProgress = false;
        public bool TutorialProgress
        {
            get { return _TutorialProgress; }
            set { _TutorialProgress = value; OnSettingChange(); }
        }

        private bool _IsStartupProgram = false;

        public bool IsStartupProgram
        {
            get { return _IsStartupProgram; }
            set { _IsStartupProgram = value;  OnSettingChange(); }
        }

    }


    /// <summary>
    /// 자동 캡처 활성화 시 안내 방법입니다.
    /// </summary>
    public enum CaptureNotifionMode
    {
        None = 0,
        SoundPlay = 1,
        OpenPopup = 2,
        SoundAndPopUp= 3,
        NoRing = 4
    }

    /// <summary>
    /// 사진을 저장할때에 어떻게 저장할지에 대한 방법입니다.
    /// </summary>
    public enum ImageSaveMode
    {
        None = 0,
        Ask = 1,
        PatternSave = 2,
        NoUse = 3
    }
    

    [Serializable]
    /// <summary>
    /// 최대, 최솟값이 있는 int 형식입니다.
    /// </summary>
    public struct LimitInt :IComparable, IComparable<Int32>, IEquatable<Int32>
    {
        public LimitInt(int min = 0, int max = 10, int value = 5)
        {
            _Minimum = int.MinValue;
            _Maximum = int.MaxValue;
            _Value = 0;

            
            Minimum = min;
            Maximum = max;
            Value = value;
        }
        public static bool operator ==(LimitInt LeftExp, LimitInt RightExp)
        {
            if (LeftExp.Value == RightExp.Value && LeftExp.Minimum == RightExp.Minimum && LeftExp.Maximum == RightExp.Maximum) return true;

            return false;
        }
        public static bool operator !=(LimitInt LeftExp, LimitInt RightExp)
        {
            if (LeftExp.Value != RightExp.Value || LeftExp.Minimum != RightExp.Minimum || LeftExp.Maximum != RightExp.Maximum) return true;

            return false;
        }
        public static bool operator ==(LimitInt lint, int intdata)
        {
            if (lint.Value == intdata) return true;

            return false;
        }
        public static bool operator !=(LimitInt lint, int intdata)
        {
            if (lint.Value != intdata) return true;

            return false;
        }
        

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() == typeof(int))
            {
                if (Value == (int)obj) return Value.CompareTo(obj);
            }
            if (obj.GetType() == typeof(LimitInt))
            {
                if (this == (LimitInt)obj) return Value.CompareTo(((LimitInt)obj).Value);
            }

            throw new ArgumentException("Object는 int나 LimitInt가 아닙니다.");
        }

        public bool Equals(int other)
        {
            this.Value = other;
            return true;
        }

        public int CompareTo(int other)
        {
            if (Value == other) return Value.CompareTo(other);
            throw new ArgumentException("Object는 int가 아닙니다.");
        }

        private int _Value;
        public int Value
        {
            get { return _Value; }
            set
            {
                if (value > Maximum) value = Maximum;
                if (value < Minimum) value = Minimum;

                _Value = value;
            }
        }


        private int _Minimum;
        public int Minimum
        {
            get { return _Minimum; }
            set
            {
                if (value > _Maximum) value = _Maximum;
                _Minimum = value;
            }
        }

        private int _Maximum;
        public int Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < _Minimum) value = _Minimum;
                _Maximum = value;
            }
        }
    }
    
    [Serializable]
    public class SavePattern
    {
        
        public SavePattern(string Name, string Location, bool openeffector = false, bool overwrite = false, bool saveimmediately = true)
        {
            PatternName = Name;
            SaveLocation = Location;
            OpenEffector = openeffector;
            OverWrite = overwrite;
        }
        
        public string RealSaveName
        {
            get
            {
                string str;
                PatternConverter.ConvertAll(PatternName, out str);
                return str;
            }
        }
        public string RealSaveLocation
        {
            get
            {
                string str;
                LocationConverter.ConvertAll(SaveLocation, out str);
                return str;
            }
        }

        public string PatternName;
        public string SaveLocation;
        
        public bool OpenEffector;
        public bool OverWrite;
        public bool SaveImmediately;
    }

}
