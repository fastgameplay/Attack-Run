namespace AttackRun.Events
{
    using System;
    using UnityEngine;
    [Serializable]
    public struct EventReference
    {
        public Action Event {
            get{ return _type == EventType.Internal ? _internalEvent : _externalEvent.Event ;}
            set{
                if(_type == EventType.Internal){
                    _internalEvent = value;
                } else{
                    _externalEvent.Event = value;
                }
            }    
        }
        [SerializeField] private EventType _type;

        [SerializeField] private SO_Event _externalEvent;
        private Action _internalEvent;
        
        public static EventReference operator +(EventReference eventRef, Action listener)
        {
            eventRef.Event += listener;
            return eventRef;
        }

        public static EventReference operator -(EventReference eventRef, Action listener)
        {
            eventRef.Event -= listener;

            return eventRef;
        }

        public void Invoke()
        {
            Event?.Invoke();
        }
    }
    [Serializable]
    public struct EventReference<T>
    {
        public Action<T> Event{
            get{ return _type == EventType.Internal ? _internalEvent : _externalEvent.Event ;}
            set{
                if(_type == EventType.Internal){
                    _internalEvent = value;
                } else{
                    _externalEvent.Event = value;
                }
            }
        }    
        [SerializeField] private EventType _type;

        [SerializeField] private SO_BaseEvent<T> _externalEvent;
        private Action<T> _internalEvent;
        
        public static EventReference<T> operator +(EventReference<T> eventRef, Action<T> listener){
            eventRef.Event += listener;
            return eventRef;
        }

        public static EventReference<T> operator -(EventReference<T> eventRef, Action<T> listener){
            eventRef.Event -= listener;

            return eventRef;
        }

        public void AddListener(Action<T> listener){
            Event += listener;
        }
        public void RemoveListener(Action<T> listener){
            Event -= listener;
        }

        public void Invoke(T arg1){
            Event?.Invoke(arg1);
        }

    }

    [Serializable]
    public struct EventReference<T, J>
    {
        public Action<T,J> Event{
            get{ return _type == EventType.Internal ? _internalEvent : _externalEvent.Event ;}
            set{
                if(_type == EventType.Internal){
                    _internalEvent = value;
                } else{
                    _externalEvent.Event = value;
                }
            }
        }    
        [SerializeField] private EventType _type;

        [SerializeField] private SO_BaseEvent<T,J> _externalEvent;
        private Action<T,J> _internalEvent;
            public static EventReference<T,J> operator +(EventReference<T,J> eventRef, Action<T,J> listener){
            eventRef.Event += listener;
            return eventRef;
        }

        public static EventReference<T,J> operator -(EventReference<T,J> eventRef, Action<T,J> listener){
            eventRef.Event -= listener;

            return eventRef;
        }

        public void Invoke(T arg1, J arg2){
            Event?.Invoke(arg1, arg2);
        }
        
    }
}