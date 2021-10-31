using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistenciaApi.Domain.Interface
{
    public interface ICalcular
    {
        void Bandauno(string Banda1);

        void Bandados(string Banda2);

        void Bandatres(string Banda3);

        void Bandacuatro(string Banda4);

        string Retornardatos();
    }
}
