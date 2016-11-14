using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace FantasyGame
{
    class StateList : IList<State>
    {
        private State[] states;
        private int count;
        private int size;

        public StateList()
        {

        }

        public State this[int index]
        {
            get
            {
                return states[index];
            }

            set
            {
                states[index] = ;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private void Resize()
        {

        }

        public void Add(State item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(State item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(State[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<State> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(State item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, State item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(State item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
