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
  public partial class StreamInfo : TBase
  {

    public List<string> Output_fields { get; set; }

    public bool Direct { get; set; }

    public StreamInfo() {
    }

    public StreamInfo(List<string> output_fields, bool direct) : this() {
      this.Output_fields = output_fields;
      this.Direct = direct;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_output_fields = false;
      bool isset_direct = false;
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
                Output_fields = new List<string>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  string _elem10 = null;
                  _elem10 = iprot.ReadString();
                  Output_fields.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
              isset_output_fields = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              Direct = iprot.ReadBool();
              isset_direct = true;
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
      if (!isset_output_fields)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_direct)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("StreamInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "output_fields";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.String, Output_fields.Count));
        foreach (string _iter11 in Output_fields)
        {
          oprot.WriteString(_iter11);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      field.Name = "direct";
      field.Type = TType.Bool;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteBool(Direct);
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StreamInfo(");
      sb.Append("Output_fields: ");
      sb.Append(Output_fields);
      sb.Append(",Direct: ");
      sb.Append(Direct);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
