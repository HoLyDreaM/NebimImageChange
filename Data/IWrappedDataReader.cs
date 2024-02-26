using System;
using System.Data;

namespace NebimResimSiralama.Data
{
    public interface IWrappedDataReader : IDataReader, IDisposable, IDataRecord
    {
        IDataReader Reader { get; }
        IDbCommand Command { get; }
    }
}