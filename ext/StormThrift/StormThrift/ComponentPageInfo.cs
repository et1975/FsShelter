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
  public partial class ComponentPageInfo : TBase
  {
    private string _topology_id;
    private string _topology_name;
    private int _num_executors;
    private int _num_tasks;
    private Dictionary<string, ComponentAggregateStats> _window_to_stats;
    private Dictionary<GlobalStreamId, ComponentAggregateStats> _gsid_to_input_stats;
    private Dictionary<string, ComponentAggregateStats> _sid_to_output_stats;
    private List<ExecutorAggregateStats> _exec_stats;
    private List<ErrorInfo> _errors;
    private string _eventlog_host;
    private int _eventlog_port;
    private DebugOptions _debug_options;
    private string _topology_status;

    public string Component_id { get; set; }

    /// <summary>
    /// 
    /// <seealso cref="ComponentType"/>
    /// </summary>
    public ComponentType Component_type { get; set; }

    public string Topology_id
    {
      get
      {
        return _topology_id;
      }
      set
      {
        __isset.topology_id = true;
        this._topology_id = value;
      }
    }

    public string Topology_name
    {
      get
      {
        return _topology_name;
      }
      set
      {
        __isset.topology_name = true;
        this._topology_name = value;
      }
    }

    public int Num_executors
    {
      get
      {
        return _num_executors;
      }
      set
      {
        __isset.num_executors = true;
        this._num_executors = value;
      }
    }

    public int Num_tasks
    {
      get
      {
        return _num_tasks;
      }
      set
      {
        __isset.num_tasks = true;
        this._num_tasks = value;
      }
    }

    public Dictionary<string, ComponentAggregateStats> Window_to_stats
    {
      get
      {
        return _window_to_stats;
      }
      set
      {
        __isset.window_to_stats = true;
        this._window_to_stats = value;
      }
    }

    public Dictionary<GlobalStreamId, ComponentAggregateStats> Gsid_to_input_stats
    {
      get
      {
        return _gsid_to_input_stats;
      }
      set
      {
        __isset.gsid_to_input_stats = true;
        this._gsid_to_input_stats = value;
      }
    }

    public Dictionary<string, ComponentAggregateStats> Sid_to_output_stats
    {
      get
      {
        return _sid_to_output_stats;
      }
      set
      {
        __isset.sid_to_output_stats = true;
        this._sid_to_output_stats = value;
      }
    }

    public List<ExecutorAggregateStats> Exec_stats
    {
      get
      {
        return _exec_stats;
      }
      set
      {
        __isset.exec_stats = true;
        this._exec_stats = value;
      }
    }

    public List<ErrorInfo> Errors
    {
      get
      {
        return _errors;
      }
      set
      {
        __isset.errors = true;
        this._errors = value;
      }
    }

    public string Eventlog_host
    {
      get
      {
        return _eventlog_host;
      }
      set
      {
        __isset.eventlog_host = true;
        this._eventlog_host = value;
      }
    }

    public int Eventlog_port
    {
      get
      {
        return _eventlog_port;
      }
      set
      {
        __isset.eventlog_port = true;
        this._eventlog_port = value;
      }
    }

    public DebugOptions Debug_options
    {
      get
      {
        return _debug_options;
      }
      set
      {
        __isset.debug_options = true;
        this._debug_options = value;
      }
    }

    public string Topology_status
    {
      get
      {
        return _topology_status;
      }
      set
      {
        __isset.topology_status = true;
        this._topology_status = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool topology_id;
      public bool topology_name;
      public bool num_executors;
      public bool num_tasks;
      public bool window_to_stats;
      public bool gsid_to_input_stats;
      public bool sid_to_output_stats;
      public bool exec_stats;
      public bool errors;
      public bool eventlog_host;
      public bool eventlog_port;
      public bool debug_options;
      public bool topology_status;
    }

    public ComponentPageInfo() {
    }

    public ComponentPageInfo(string component_id, ComponentType component_type) : this() {
      this.Component_id = component_id;
      this.Component_type = component_type;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_component_id = false;
      bool isset_component_type = false;
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
              Component_id = iprot.ReadString();
              isset_component_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Component_type = (ComponentType)iprot.ReadI32();
              isset_component_type = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Topology_id = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Topology_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Num_executors = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Num_tasks = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Map) {
              {
                Window_to_stats = new Dictionary<string, ComponentAggregateStats>();
                TMap _map211 = iprot.ReadMapBegin();
                for( int _i212 = 0; _i212 < _map211.Count; ++_i212)
                {
                  string _key213;
                  ComponentAggregateStats _val214;
                  _key213 = iprot.ReadString();
                  _val214 = new ComponentAggregateStats();
                  _val214.Read(iprot);
                  Window_to_stats[_key213] = _val214;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Map) {
              {
                Gsid_to_input_stats = new Dictionary<GlobalStreamId, ComponentAggregateStats>();
                TMap _map215 = iprot.ReadMapBegin();
                for( int _i216 = 0; _i216 < _map215.Count; ++_i216)
                {
                  GlobalStreamId _key217;
                  ComponentAggregateStats _val218;
                  _key217 = new GlobalStreamId();
                  _key217.Read(iprot);
                  _val218 = new ComponentAggregateStats();
                  _val218.Read(iprot);
                  Gsid_to_input_stats[_key217] = _val218;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Map) {
              {
                Sid_to_output_stats = new Dictionary<string, ComponentAggregateStats>();
                TMap _map219 = iprot.ReadMapBegin();
                for( int _i220 = 0; _i220 < _map219.Count; ++_i220)
                {
                  string _key221;
                  ComponentAggregateStats _val222;
                  _key221 = iprot.ReadString();
                  _val222 = new ComponentAggregateStats();
                  _val222.Read(iprot);
                  Sid_to_output_stats[_key221] = _val222;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.List) {
              {
                Exec_stats = new List<ExecutorAggregateStats>();
                TList _list223 = iprot.ReadListBegin();
                for( int _i224 = 0; _i224 < _list223.Count; ++_i224)
                {
                  ExecutorAggregateStats _elem225 = new ExecutorAggregateStats();
                  _elem225 = new ExecutorAggregateStats();
                  _elem225.Read(iprot);
                  Exec_stats.Add(_elem225);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.List) {
              {
                Errors = new List<ErrorInfo>();
                TList _list226 = iprot.ReadListBegin();
                for( int _i227 = 0; _i227 < _list226.Count; ++_i227)
                {
                  ErrorInfo _elem228 = new ErrorInfo();
                  _elem228 = new ErrorInfo();
                  _elem228.Read(iprot);
                  Errors.Add(_elem228);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              Eventlog_host = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.I32) {
              Eventlog_port = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Struct) {
              Debug_options = new DebugOptions();
              Debug_options.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.String) {
              Topology_status = iprot.ReadString();
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
      if (!isset_component_id)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_component_type)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ComponentPageInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "component_id";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Component_id);
      oprot.WriteFieldEnd();
      field.Name = "component_type";
      field.Type = TType.I32;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)Component_type);
      oprot.WriteFieldEnd();
      if (Topology_id != null && __isset.topology_id) {
        field.Name = "topology_id";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Topology_id);
        oprot.WriteFieldEnd();
      }
      if (Topology_name != null && __isset.topology_name) {
        field.Name = "topology_name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Topology_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.num_executors) {
        field.Name = "num_executors";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Num_executors);
        oprot.WriteFieldEnd();
      }
      if (__isset.num_tasks) {
        field.Name = "num_tasks";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Num_tasks);
        oprot.WriteFieldEnd();
      }
      if (Window_to_stats != null && __isset.window_to_stats) {
        field.Name = "window_to_stats";
        field.Type = TType.Map;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Window_to_stats.Count));
          foreach (string _iter229 in Window_to_stats.Keys)
          {
            oprot.WriteString(_iter229);
            Window_to_stats[_iter229].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Gsid_to_input_stats != null && __isset.gsid_to_input_stats) {
        field.Name = "gsid_to_input_stats";
        field.Type = TType.Map;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Struct, TType.Struct, Gsid_to_input_stats.Count));
          foreach (GlobalStreamId _iter230 in Gsid_to_input_stats.Keys)
          {
            _iter230.Write(oprot);
            Gsid_to_input_stats[_iter230].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Sid_to_output_stats != null && __isset.sid_to_output_stats) {
        field.Name = "sid_to_output_stats";
        field.Type = TType.Map;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Struct, Sid_to_output_stats.Count));
          foreach (string _iter231 in Sid_to_output_stats.Keys)
          {
            oprot.WriteString(_iter231);
            Sid_to_output_stats[_iter231].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Exec_stats != null && __isset.exec_stats) {
        field.Name = "exec_stats";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Exec_stats.Count));
          foreach (ExecutorAggregateStats _iter232 in Exec_stats)
          {
            _iter232.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Errors != null && __isset.errors) {
        field.Name = "errors";
        field.Type = TType.List;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Errors.Count));
          foreach (ErrorInfo _iter233 in Errors)
          {
            _iter233.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Eventlog_host != null && __isset.eventlog_host) {
        field.Name = "eventlog_host";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Eventlog_host);
        oprot.WriteFieldEnd();
      }
      if (__isset.eventlog_port) {
        field.Name = "eventlog_port";
        field.Type = TType.I32;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Eventlog_port);
        oprot.WriteFieldEnd();
      }
      if (Debug_options != null && __isset.debug_options) {
        field.Name = "debug_options";
        field.Type = TType.Struct;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        Debug_options.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Topology_status != null && __isset.topology_status) {
        field.Name = "topology_status";
        field.Type = TType.String;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Topology_status);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ComponentPageInfo(");
      sb.Append("Component_id: ");
      sb.Append(Component_id);
      sb.Append(",Component_type: ");
      sb.Append(Component_type);
      sb.Append(",Topology_id: ");
      sb.Append(Topology_id);
      sb.Append(",Topology_name: ");
      sb.Append(Topology_name);
      sb.Append(",Num_executors: ");
      sb.Append(Num_executors);
      sb.Append(",Num_tasks: ");
      sb.Append(Num_tasks);
      sb.Append(",Window_to_stats: ");
      sb.Append(Window_to_stats);
      sb.Append(",Gsid_to_input_stats: ");
      sb.Append(Gsid_to_input_stats);
      sb.Append(",Sid_to_output_stats: ");
      sb.Append(Sid_to_output_stats);
      sb.Append(",Exec_stats: ");
      sb.Append(Exec_stats);
      sb.Append(",Errors: ");
      sb.Append(Errors);
      sb.Append(",Eventlog_host: ");
      sb.Append(Eventlog_host);
      sb.Append(",Eventlog_port: ");
      sb.Append(Eventlog_port);
      sb.Append(",Debug_options: ");
      sb.Append(Debug_options== null ? "<null>" : Debug_options.ToString());
      sb.Append(",Topology_status: ");
      sb.Append(Topology_status);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
