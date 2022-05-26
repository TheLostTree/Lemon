// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerFloorRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerFloorRecord.proto</summary>
  public static partial class TowerFloorRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerFloorRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerFloorRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZUb3dlckZsb29yUmVjb3JkLnByb3RvGhZUb3dlckxldmVsUmVjb3JkLnBy",
            "b3RvIvUBChBUb3dlckZsb29yUmVjb3JkEhAKCGZsb29yX2lkGAEgASgNEj8K",
            "EHBhc3NlZF9sZXZlbF9tYXAYAiADKAsyJS5Ub3dlckZsb29yUmVjb3JkLlBh",
            "c3NlZExldmVsTWFwRW50cnkSIgoaZmxvb3Jfc3Rhcl9yZXdhcmRfcHJvZ3Jl",
            "c3MYAyABKA0SMwoYcGFzc2VkX2xldmVsX3JlY29yZF9saXN0GAQgAygLMhEu",
            "VG93ZXJMZXZlbFJlY29yZBo1ChNQYXNzZWRMZXZlbE1hcEVudHJ5EgsKA2tl",
            "eRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCGKoCFUxlbW9uYWRlLk5ldC5Q",
            "cm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.TowerLevelRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerFloorRecord), global::Lemonade.Net.Protocol.TowerFloorRecord.Parser, new[]{ "FloorId", "PassedLevelMap", "FloorStarRewardProgress", "PassedLevelRecordList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerFloorRecord : pb::IMessage<TowerFloorRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerFloorRecord> _parser = new pb::MessageParser<TowerFloorRecord>(() => new TowerFloorRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerFloorRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerFloorRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecord(TowerFloorRecord other) : this() {
      floorId_ = other.floorId_;
      passedLevelMap_ = other.passedLevelMap_.Clone();
      floorStarRewardProgress_ = other.floorStarRewardProgress_;
      passedLevelRecordList_ = other.passedLevelRecordList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerFloorRecord Clone() {
      return new TowerFloorRecord(this);
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 1;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "passed_level_map" field.</summary>
    public const int PassedLevelMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, uint>.Codec _map_passedLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 18);
    private readonly pbc::MapField<uint, uint> passedLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> PassedLevelMap {
      get { return passedLevelMap_; }
    }

    /// <summary>Field number for the "floor_star_reward_progress" field.</summary>
    public const int FloorStarRewardProgressFieldNumber = 3;
    private uint floorStarRewardProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorStarRewardProgress {
      get { return floorStarRewardProgress_; }
      set {
        floorStarRewardProgress_ = value;
      }
    }

    /// <summary>Field number for the "passed_level_record_list" field.</summary>
    public const int PassedLevelRecordListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.TowerLevelRecord> _repeated_passedLevelRecordList_codec
        = pb::FieldCodec.ForMessage(34, global::Lemonade.Net.Protocol.TowerLevelRecord.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerLevelRecord> passedLevelRecordList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerLevelRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerLevelRecord> PassedLevelRecordList {
      get { return passedLevelRecordList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerFloorRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerFloorRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FloorId != other.FloorId) return false;
      if (!PassedLevelMap.Equals(other.PassedLevelMap)) return false;
      if (FloorStarRewardProgress != other.FloorStarRewardProgress) return false;
      if(!passedLevelRecordList_.Equals(other.passedLevelRecordList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      hash ^= PassedLevelMap.GetHashCode();
      if (FloorStarRewardProgress != 0) hash ^= FloorStarRewardProgress.GetHashCode();
      hash ^= passedLevelRecordList_.GetHashCode();
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
      if (FloorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FloorId);
      }
      passedLevelMap_.WriteTo(output, _map_passedLevelMap_codec);
      if (FloorStarRewardProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FloorStarRewardProgress);
      }
      passedLevelRecordList_.WriteTo(output, _repeated_passedLevelRecordList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FloorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FloorId);
      }
      passedLevelMap_.WriteTo(ref output, _map_passedLevelMap_codec);
      if (FloorStarRewardProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FloorStarRewardProgress);
      }
      passedLevelRecordList_.WriteTo(ref output, _repeated_passedLevelRecordList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      size += passedLevelMap_.CalculateSize(_map_passedLevelMap_codec);
      if (FloorStarRewardProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorStarRewardProgress);
      }
      size += passedLevelRecordList_.CalculateSize(_repeated_passedLevelRecordList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerFloorRecord other) {
      if (other == null) {
        return;
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      passedLevelMap_.Add(other.passedLevelMap_);
      if (other.FloorStarRewardProgress != 0) {
        FloorStarRewardProgress = other.FloorStarRewardProgress;
      }
      passedLevelRecordList_.Add(other.passedLevelRecordList_);
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
          case 8: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 18: {
            passedLevelMap_.AddEntriesFrom(input, _map_passedLevelMap_codec);
            break;
          }
          case 24: {
            FloorStarRewardProgress = input.ReadUInt32();
            break;
          }
          case 34: {
            passedLevelRecordList_.AddEntriesFrom(input, _repeated_passedLevelRecordList_codec);
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
          case 8: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 18: {
            passedLevelMap_.AddEntriesFrom(ref input, _map_passedLevelMap_codec);
            break;
          }
          case 24: {
            FloorStarRewardProgress = input.ReadUInt32();
            break;
          }
          case 34: {
            passedLevelRecordList_.AddEntriesFrom(ref input, _repeated_passedLevelRecordList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
