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
  public partial class ExecutorSpecificStats : TBase
  {
    private BoltStats _bolt;
    private SpoutStats _spout;

    public BoltStats Bolt
    {
      get
      {
        return _bolt;
      }
      set
      {
        __isset.bolt = true;
        this._bolt = value;
      }
    }

    public SpoutStats Spout
    {
      get
      {
        return _spout;
      }
      set
      {
        __isset.spout = true;
        this._spout = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool bolt;
      public bool spout;
    }

    public ExecutorSpecificStats() {
    }

    public void Read (TProtocol iprot)
    {
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
            if (field.Type == TType.Struct) {
              Bolt = new BoltStats();
              Bolt.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Spout = new SpoutStats();
              Spout.Read(iprot);
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
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ExecutorSpecificStats");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Bolt != null && __isset.bolt) {
        field.Name = "bolt";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Bolt.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Spout != null && __isset.spout) {
        field.Name = "spout";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Spout.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ExecutorSpecificStats(");
      sb.Append("Bolt: ");
      sb.Append(Bolt== null ? "<null>" : Bolt.ToString());
      sb.Append(",Spout: ");
      sb.Append(Spout== null ? "<null>" : Spout.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
