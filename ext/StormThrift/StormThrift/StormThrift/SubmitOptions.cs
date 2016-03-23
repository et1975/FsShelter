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
  public partial class SubmitOptions : TBase
  {
    private Credentials _creds;

    /// <summary>
    /// 
    /// <seealso cref="TopologyInitialStatus"/>
    /// </summary>
    public TopologyInitialStatus Initial_status { get; set; }

    public Credentials Creds
    {
      get
      {
        return _creds;
      }
      set
      {
        __isset.creds = true;
        this._creds = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool creds;
    }

    public SubmitOptions() {
    }

    public SubmitOptions(TopologyInitialStatus initial_status) : this() {
      this.Initial_status = initial_status;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_initial_status = false;
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
            if (field.Type == TType.I32) {
              Initial_status = (TopologyInitialStatus)iprot.ReadI32();
              isset_initial_status = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Creds = new Credentials();
              Creds.Read(iprot);
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
      if (!isset_initial_status)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SubmitOptions");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "initial_status";
      field.Type = TType.I32;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)Initial_status);
      oprot.WriteFieldEnd();
      if (Creds != null && __isset.creds) {
        field.Name = "creds";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Creds.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SubmitOptions(");
      sb.Append("Initial_status: ");
      sb.Append(Initial_status);
      sb.Append(",Creds: ");
      sb.Append(Creds== null ? "<null>" : Creds.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
