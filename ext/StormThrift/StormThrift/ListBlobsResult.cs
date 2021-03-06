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
  public partial class ListBlobsResult : TBase
  {

    public List<string> Keys { get; set; }

    public string Session { get; set; }

    public ListBlobsResult() {
    }

    public ListBlobsResult(List<string> keys, string session) : this() {
      this.Keys = keys;
      this.Session = session;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_keys = false;
      bool isset_session = false;
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
                Keys = new List<string>();
                TList _list248 = iprot.ReadListBegin();
                for( int _i249 = 0; _i249 < _list248.Count; ++_i249)
                {
                  string _elem250 = null;
                  _elem250 = iprot.ReadString();
                  Keys.Add(_elem250);
                }
                iprot.ReadListEnd();
              }
              isset_keys = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Session = iprot.ReadString();
              isset_session = true;
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
      if (!isset_keys)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_session)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ListBlobsResult");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "keys";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.String, Keys.Count));
        foreach (string _iter251 in Keys)
        {
          oprot.WriteString(_iter251);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      field.Name = "session";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Session);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ListBlobsResult(");
      sb.Append("Keys: ");
      sb.Append(Keys);
      sb.Append(",Session: ");
      sb.Append(Session);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
