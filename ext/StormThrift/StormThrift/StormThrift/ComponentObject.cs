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
  public partial class ComponentObject : TBase
  {
    private byte[] _serialized_java;
    private ShellComponent _shell;
    private JavaObject _java_object;

    public byte[] Serialized_java
    {
      get
      {
        return _serialized_java;
      }
      set
      {
        __isset.serialized_java = true;
        this._serialized_java = value;
      }
    }

    public ShellComponent Shell
    {
      get
      {
        return _shell;
      }
      set
      {
        __isset.shell = true;
        this._shell = value;
      }
    }

    public JavaObject Java_object
    {
      get
      {
        return _java_object;
      }
      set
      {
        __isset.java_object = true;
        this._java_object = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool serialized_java;
      public bool shell;
      public bool java_object;
    }

    public ComponentObject() {
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
            if (field.Type == TType.String) {
              Serialized_java = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Shell = new ShellComponent();
              Shell.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              Java_object = new JavaObject();
              Java_object.Read(iprot);
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
      TStruct struc = new TStruct("ComponentObject");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Serialized_java != null && __isset.serialized_java) {
        field.Name = "serialized_java";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Serialized_java);
        oprot.WriteFieldEnd();
      }
      if (Shell != null && __isset.shell) {
        field.Name = "shell";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Shell.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Java_object != null && __isset.java_object) {
        field.Name = "java_object";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        Java_object.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ComponentObject(");
      sb.Append("Serialized_java: ");
      sb.Append(Serialized_java);
      sb.Append(",Shell: ");
      sb.Append(Shell== null ? "<null>" : Shell.ToString());
      sb.Append(",Java_object: ");
      sb.Append(Java_object== null ? "<null>" : Java_object.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
