/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace StormThrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class LSTopoHistoryList : TBase
  {

    public List<LSTopoHistory> Topo_history { get; set; }

    public LSTopoHistoryList() {
    }

    public LSTopoHistoryList(List<LSTopoHistory> topo_history) : this() {
      this.Topo_history = topo_history;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_topo_history = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                Topo_history = new List<LSTopoHistory>();
                TList _list348 = iprot.ReadListBegin();
                for( int _i349 = 0; _i349 < _list348.Count; ++_i349)
                {
                  LSTopoHistory _elem350 = new LSTopoHistory();
                  _elem350 = new LSTopoHistory();
                  _elem350.Read(iprot);
                  Topo_history.Add(_elem350);
                }
                iprot.ReadListEnd();
              }
              isset_topo_history = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_topo_history)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("LSTopoHistoryList");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "topo_history";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Topo_history.Count));
        foreach (LSTopoHistory _iter351 in Topo_history)
        {
          _iter351.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LSTopoHistoryList(");
      sb.Append("Topo_history: ");
      sb.Append(Topo_history);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
