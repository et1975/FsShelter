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
  public partial class SupervisorInfo : TBase
  {
    private string _assignment_id;
    private List<long> _used_ports;
    private List<long> _meta;
    private Dictionary<string, string> _scheduler_meta;
    private long _uptime_secs;
    private string _version;
    private Dictionary<string, double> _resources_map;

    public long Time_secs { get; set; }

    public string Hostname { get; set; }

    public string Assignment_id
    {
      get
      {
        return _assignment_id;
      }
      set
      {
        __isset.assignment_id = true;
        this._assignment_id = value;
      }
    }

    public List<long> Used_ports
    {
      get
      {
        return _used_ports;
      }
      set
      {
        __isset.used_ports = true;
        this._used_ports = value;
      }
    }

    public List<long> Meta
    {
      get
      {
        return _meta;
      }
      set
      {
        __isset.meta = true;
        this._meta = value;
      }
    }

    public Dictionary<string, string> Scheduler_meta
    {
      get
      {
        return _scheduler_meta;
      }
      set
      {
        __isset.scheduler_meta = true;
        this._scheduler_meta = value;
      }
    }

    public long Uptime_secs
    {
      get
      {
        return _uptime_secs;
      }
      set
      {
        __isset.uptime_secs = true;
        this._uptime_secs = value;
      }
    }

    public string Version
    {
      get
      {
        return _version;
      }
      set
      {
        __isset.version = true;
        this._version = value;
      }
    }

    public Dictionary<string, double> Resources_map
    {
      get
      {
        return _resources_map;
      }
      set
      {
        __isset.resources_map = true;
        this._resources_map = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool assignment_id;
      public bool used_ports;
      public bool meta;
      public bool scheduler_meta;
      public bool uptime_secs;
      public bool version;
      public bool resources_map;
    }

    public SupervisorInfo() {
    }

    public SupervisorInfo(long time_secs, string hostname) : this() {
      this.Time_secs = time_secs;
      this.Hostname = hostname;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_time_secs = false;
      bool isset_hostname = false;
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
            if (field.Type == TType.I64) {
              Time_secs = iprot.ReadI64();
              isset_time_secs = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Hostname = iprot.ReadString();
              isset_hostname = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Assignment_id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                Used_ports = new List<long>();
                TList _list252 = iprot.ReadListBegin();
                for( int _i253 = 0; _i253 < _list252.Count; ++_i253)
                {
                  long _elem254 = 0;
                  _elem254 = iprot.ReadI64();
                  Used_ports.Add(_elem254);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                Meta = new List<long>();
                TList _list255 = iprot.ReadListBegin();
                for( int _i256 = 0; _i256 < _list255.Count; ++_i256)
                {
                  long _elem257 = 0;
                  _elem257 = iprot.ReadI64();
                  Meta.Add(_elem257);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Map) {
              {
                Scheduler_meta = new Dictionary<string, string>();
                TMap _map258 = iprot.ReadMapBegin();
                for( int _i259 = 0; _i259 < _map258.Count; ++_i259)
                {
                  string _key260;
                  string _val261;
                  _key260 = iprot.ReadString();
                  _val261 = iprot.ReadString();
                  Scheduler_meta[_key260] = _val261;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I64) {
              Uptime_secs = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              Version = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Map) {
              {
                Resources_map = new Dictionary<string, double>();
                TMap _map262 = iprot.ReadMapBegin();
                for( int _i263 = 0; _i263 < _map262.Count; ++_i263)
                {
                  string _key264;
                  double _val265;
                  _key264 = iprot.ReadString();
                  _val265 = iprot.ReadDouble();
                  Resources_map[_key264] = _val265;
                }
                iprot.ReadMapEnd();
              }
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
      if (!isset_time_secs)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_hostname)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("SupervisorInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "time_secs";
      field.Type = TType.I64;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(Time_secs);
      oprot.WriteFieldEnd();
      field.Name = "hostname";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Hostname);
      oprot.WriteFieldEnd();
      if (Assignment_id != null && __isset.assignment_id) {
        field.Name = "assignment_id";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Assignment_id);
        oprot.WriteFieldEnd();
      }
      if (Used_ports != null && __isset.used_ports) {
        field.Name = "used_ports";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, Used_ports.Count));
          foreach (long _iter266 in Used_ports)
          {
            oprot.WriteI64(_iter266);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Meta != null && __isset.meta) {
        field.Name = "meta";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, Meta.Count));
          foreach (long _iter267 in Meta)
          {
            oprot.WriteI64(_iter267);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Scheduler_meta != null && __isset.scheduler_meta) {
        field.Name = "scheduler_meta";
        field.Type = TType.Map;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, Scheduler_meta.Count));
          foreach (string _iter268 in Scheduler_meta.Keys)
          {
            oprot.WriteString(_iter268);
            oprot.WriteString(Scheduler_meta[_iter268]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.uptime_secs) {
        field.Name = "uptime_secs";
        field.Type = TType.I64;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Uptime_secs);
        oprot.WriteFieldEnd();
      }
      if (Version != null && __isset.version) {
        field.Name = "version";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Version);
        oprot.WriteFieldEnd();
      }
      if (Resources_map != null && __isset.resources_map) {
        field.Name = "resources_map";
        field.Type = TType.Map;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Double, Resources_map.Count));
          foreach (string _iter269 in Resources_map.Keys)
          {
            oprot.WriteString(_iter269);
            oprot.WriteDouble(Resources_map[_iter269]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SupervisorInfo(");
      sb.Append("Time_secs: ");
      sb.Append(Time_secs);
      sb.Append(",Hostname: ");
      sb.Append(Hostname);
      sb.Append(",Assignment_id: ");
      sb.Append(Assignment_id);
      sb.Append(",Used_ports: ");
      sb.Append(Used_ports);
      sb.Append(",Meta: ");
      sb.Append(Meta);
      sb.Append(",Scheduler_meta: ");
      sb.Append(Scheduler_meta);
      sb.Append(",Uptime_secs: ");
      sb.Append(Uptime_secs);
      sb.Append(",Version: ");
      sb.Append(Version);
      sb.Append(",Resources_map: ");
      sb.Append(Resources_map);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
