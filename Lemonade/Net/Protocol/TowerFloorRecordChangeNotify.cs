// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerFloorRecordChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerFloorRecordChangeNotify.proto</summary>
  public static partial class TowerFloorRecordChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerFloorRecordChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerFloorRecordChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJUb3dlckZsb29yUmVjb3JkQ2hhbmdlTm90aWZ5LnByb3RvGhZUb3dlckZs",
            "b29yUmVjb3JkLnByb3RvIsUBChxUb3dlckZsb29yUmVjb3JkQ2hhbmdlTm90",
            "aWZ5EjIKF3Rvd2VyX2Zsb29yX3JlY29yZF9saXN0GAEgAygLMhEuVG93ZXJG",
            "bG9vclJlY29yZBIiChppc19maW5pc2hlZF9lbnRyYW5jZV9mbG9vchgCIAEo",
            "CCJNCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQ",
            "RU5FVF9JU19SRUxJQUJMRRABEgsKBkNNRF9JRBDyEhoCEAFCGKoCFUxlbW9u",
            "YWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.TowerFloorRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerFloorRecordChangeNotify), global::Lemonade.Net.Protocol.TowerFloorRecordChangeNotify.Parser, new[]{ "TowerFloorRecordList", "IsFinishedEntranceFloor" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.TowerFloorRecordChangeNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerFloorRecordChangeNotify : pb::IMessage<TowerFloorRecordChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerFloorRecordChangeNotify> _parser = new pb::MessageParser<TowerFloorRecordChangeNotify>(() => new TowerFloorRecordChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerFloorRecordChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerFloorRecordChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify(TowerFloorRecordChangeNotify other) : this() {
      towerFloorRecordList_ = other.towerFloorRecordList_.Clone();
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecordChangeNotify Clone() {
      return new TowerFloorRecordChangeNotify(this);
    }

    /// <summary>Field number for the "tower_floor_record_list" field.</summary>
    public const int TowerFloorRecordListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.TowerFloorRecord> _repeated_towerFloorRecordList_codec
        = pb::FieldCodec.ForMessage(10, global::Lemonade.Net.Protocol.TowerFloorRecord.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord> towerFloorRecordList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord> TowerFloorRecordList {
      get { return towerFloorRecordList_; }
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 2;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerFloorRecordChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerFloorRecordChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!towerFloorRecordList_.Equals(other.towerFloorRecordList_)) return false;
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= towerFloorRecordList_.GetHashCode();
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      towerFloorRecordList_.WriteTo(output, _repeated_towerFloorRecordList_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      towerFloorRecordList_.WriteTo(ref output, _repeated_towerFloorRecordList_codec);
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += towerFloorRecordList_.CalculateSize(_repeated_towerFloorRecordList_codec);
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerFloorRecordChangeNotify other) {
      if (other == null) {
        return;
      }
      towerFloorRecordList_.Add(other.towerFloorRecordList_);
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            towerFloorRecordList_.AddEntriesFrom(input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 16: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            towerFloorRecordList_.AddEntriesFrom(ref input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 16: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerFloorRecordChangeNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2418,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
