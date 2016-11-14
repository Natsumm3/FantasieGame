using System;
using System.Collections;
using System.Collections.Generic;
    //using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace FantasyGame
{
    class SceneList : IList<Scene>
    {
        private Scene[] scenes;
        private int count;
        private int size;

        public SceneList()
        {
            size = 8;
            count = 0;
            scenes = new Scene[size];
        }

        public Scene this[int index]
        {
            get
            {
                return scenes[index];
            }

            set
            {
                scenes[index] = value;
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
            size = size * 2;
            Scene[] temp = new Scene[size];
            for (int i = 0; i < count; i++)
            {
                temp[i] = scenes[i];
                scenes = temp;
            }
        }

        public void Add(Scene item)
        {
            if(count == size)
            {
                Resize();
            }
            scenes[count] = item;
            count++;
        }

        public void Clear()
        {
            size = 8;
            count = 0;
            scenes = new Scene[size];
        }

        public bool Contains(Scene item)
        {
            if (IndexOf(item) == -1)
                return false;
            return true;
        }

        public void CopyTo(Scene[] array)
        {
            if (array.Length < count)
                throw new InsufficientMemoryException("the List is longer than the Array");
            for(int i = 0; i < count; i++)
            {
                array[i] = scenes[i];
            }
        }

        public void CopyTo(Scene[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<Scene> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(Scene item)
        {
            for (int i = 0; i < count; count++)
            {
                if (scenes[i] == item)
                    return i;
            }
            return -1;
        }

        public void Insert(int index, Scene item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Scene item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
