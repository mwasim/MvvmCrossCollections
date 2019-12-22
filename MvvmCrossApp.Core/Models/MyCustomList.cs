using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using MvvmCrossApp.Core.Models.Kittens;

namespace MvvmCrossApp.Core.Models
{
    public class MyCustomList : IList<Kitten>, IList, INotifyCollectionChanged
    {
        private readonly MockDataRepository _dataRepository = new MockDataRepository();

        object IList.this[int index]
        {
            get => this[index];
            set => throw new NotImplementedException();
        }

        public int Count => _dataRepository.GetCount();

        public Kitten this[int index]
        {
            get => _dataRepository.GetKitten(index);
            set => throw new NotImplementedException();
        }

        public void Add(Kitten item)
        {
            _dataRepository.Append(item);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item,
                _dataRepository.GetCount() - 1));
        }

        public void RemoveAt(int index)
        {
            var toRemove = this[index];
            _dataRepository.DeleteAt(index);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            //RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, null, toRemove, index));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void RaiseCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            var handler = CollectionChanged;

            handler?.Invoke(this, args);
        }

        #region Not implemented

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsSynchronized { get; private set; }

        public object SyncRoot { get; private set; }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedSize => false;

        public IEnumerator<Kitten> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Kitten item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Kitten[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Kitten item)
        {
            throw new NotImplementedException();
        }

        public bool IsReadOnly { get; private set; }

        public int IndexOf(Kitten item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Kitten item)
        {
            throw new NotImplementedException();
        }

        #endregion Not implemented
    }
}
