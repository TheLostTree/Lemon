// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerMonthlyBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerMonthlyBrief.proto</summary>
  public static partial class TowerMonthlyBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerMonthlyBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerMonthlyBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdUb3dlck1vbnRobHlCcmllZi5wcm90byJ8ChFUb3dlck1vbnRobHlCcmll",
            "ZhIZChF0b3dlcl9zY2hlZHVsZV9pZBgBIAEoDRIYChBiZXN0X2Zsb29yX2lu",
            "ZGV4GAIgASgNEhgKEGJlc3RfbGV2ZWxfaW5kZXgYAyABKA0SGAoQdG90YWxf",
            "c3Rhcl9jb3VudBgEIAEoDUIYqgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerMonthlyBrief), global::Lemonade.Net.Protocol.TowerMonthlyBrief.Parser, new[]{ "TowerScheduleId", "BestFloorIndex", "BestLevelIndex", "TotalStarCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerMonthlyBrief : pb::IMessage<TowerMonthlyBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerMonthlyBrief> _parser = new pb::MessageParser<TowerMonthlyBrief>(() => new TowerMonthlyBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerMonthlyBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerMonthlyBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyBrief(TowerMonthlyBrief other) : this() {
      towerScheduleId_ = other.towerScheduleId_;
      bestFloorIndex_ = other.bestFloorIndex_;
      bestLevelIndex_ = other.bestLevelIndex_;
      totalStarCount_ = other.totalStarCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerMonthlyBrief Clone() {
      return new TowerMonthlyBrief(this);
    }

    /// <summary>Field number for the "tower_schedule_id" field.</summary>
    public const int TowerScheduleIdFieldNumber = 1;
    private uint towerScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TowerScheduleId {
      get { return towerScheduleId_; }
      set {
        towerScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "best_floor_index" field.</summary>
    public const int BestFloorIndexFieldNumber = 2;
    private uint bestFloorIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestFloorIndex {
      get { return bestFloorIndex_; }
      set {
        bestFloorIndex_ = value;
      }
    }

    /// <summary>Field number for the "best_level_index" field.</summary>
    public const int BestLevelIndexFieldNumber = 3;
    private uint bestLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestLevelIndex {
      get { return bestLevelIndex_; }
      set {
        bestLevelIndex_ = value;
      }
    }

    /// <summary>Field number for the "total_star_count" field.</summary>
    public const int TotalStarCountFieldNumber = 4;
    private uint totalStarCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalStarCount {
      get { return totalStarCount_; }
      set {
        totalStarCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerMonthlyBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerMonthlyBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TowerScheduleId != other.TowerScheduleId) return false;
      if (BestFloorIndex != other.BestFloorIndex) return false;
      if (BestLevelIndex != other.BestLevelIndex) return false;
      if (TotalStarCount != other.TotalStarCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TowerScheduleId != 0) hash ^= TowerScheduleId.GetHashCode();
      if (BestFloorIndex != 0) hash ^= BestFloorIndex.GetHashCode();
      if (BestLevelIndex != 0) hash ^= BestLevelIndex.GetHashCode();
      if (TotalStarCount != 0) hash ^= TotalStarCount.GetHashCode();
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      if (BestFloorIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BestFloorIndex);
      }
      if (BestLevelIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BestLevelIndex);
      }
      if (TotalStarCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalStarCount);
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      if (BestFloorIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BestFloorIndex);
      }
      if (BestLevelIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BestLevelIndex);
      }
      if (TotalStarCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalStarCount);
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
      if (TowerScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TowerScheduleId);
      }
      if (BestFloorIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestFloorIndex);
      }
      if (BestLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestLevelIndex);
      }
      if (TotalStarCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalStarCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerMonthlyBrief other) {
      if (other == null) {
        return;
      }
      if (other.TowerScheduleId != 0) {
        TowerScheduleId = other.TowerScheduleId;
      }
      if (other.BestFloorIndex != 0) {
        BestFloorIndex = other.BestFloorIndex;
      }
      if (other.BestLevelIndex != 0) {
        BestLevelIndex = other.BestLevelIndex;
      }
      if (other.TotalStarCount != 0) {
        TotalStarCount = other.TotalStarCount;
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
          case 8: {
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 16: {
            BestFloorIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            BestLevelIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            TotalStarCount = input.ReadUInt32();
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
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 16: {
            BestFloorIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            BestLevelIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            TotalStarCount = input.ReadUInt32();
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
