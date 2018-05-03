using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class ClassBases
    {
        private int _dato;
        //para editar la variable
        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        //la sig direccion
        private ClassBases _siguiente;
        public ClassBases Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClassBases(int dato)
        {
            _dato = dato;
        }
        public override string ToString()
        {
            return "dato = "+ _dato;
        }
    }
}
