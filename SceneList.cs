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
                if (index > size)
                    throw new IndexOutOfRangeException();
                return scenes[index];
            }

            set
            {
                if (index > size)
                    throw new IndexOutOfRangeException();
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
            CopyTo(array, 0);
        }

        public void CopyTo(Scene[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex < count)
                throw new InsufficientMemoryException("the List is longer than the Array");
            for (int i = 0; i < count; i++)
            {
                array[i + arrayIndex] = scenes[i];
            }
        }

        public IEnumerator<Scene> GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(Scene item)
        {
            for (int i = 0; i < count; i++)
            {
                if (scenes[i] == item)
                    return i;
            }
            return -1;
        }

        public void Insert(int index, Scene item)
        {
            if (index > size)
                throw new IndexOutOfRangeException();
            for(int i = count;i > index; i--)
            {
                scenes[i] = scenes[i - 1];
            }
            scenes[index] = item;
            count++;
        }

        public bool Remove(Scene item)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (scenes[i] == item)
                {
                    RemoveAt(i);
                    i--;
                    found = true;
                }
            }
            return found;
        }

        public void RemoveAt(int index)
        {
            if (index > count)
                throw new IndexOutOfRangeException();
            for (int i = index; i + 1 < count; i++)
            {
                scenes[i] = scenes[i + 1];
            }
            count--;
            scenes[count] = null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
