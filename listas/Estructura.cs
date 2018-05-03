using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Estructura
    {
        ClassBases inicio = null;
        public void agregar(ClassBases nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                //ClassBases t = inicio; 
                //while(t.Siguiente != null)
                //    t = t.Siguiente;
                //t.Siguiente = nuevo;
                agregar(nuevo, inicio);
            }
        }
        private void agregar (ClassBases nuevo,ClassBases quien)
        {
            if (quien.Siguiente != null)
                agregar(nuevo, quien.Siguiente);
            else
                quien.Siguiente = nuevo;
        }
        public ClassBases buscar(int dato)
        {
            return null;
        }
        public string lista()
        {
            string res = "";
            ClassBases t = inicio;
            while (t != null)
            {
                res += t.ToString() + "\r\n";
                t = t.Siguiente;
            }
            return res;
        }
    }
}
