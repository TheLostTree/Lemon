// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BossChestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from BossChestInfo.proto</summary>
  public static partial class BossChestInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BossChestInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BossChestInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNCb3NzQ2hlc3RJbmZvLnByb3RvGiFXZWVrbHlCb3NzUmVzaW5EaXNjb3Vu",
            "dEluZm8ucHJvdG8i/wEKDUJvc3NDaGVzdEluZm8SGQoRbW9uc3Rlcl9jb25m",
            "aWdfaWQYASABKA0SDQoFcmVzaW4YAiABKA0SFwoPcmVtYWluX3VpZF9saXN0",
            "GAMgAygNEhgKEHF1YWxpZnlfdWlkX2xpc3QYBCADKA0SPAoQdWlkX2Rpc2Nv",
            "dW50X21hcBgFIAMoCzIiLkJvc3NDaGVzdEluZm8uVWlkRGlzY291bnRNYXBF",
            "bnRyeRpTChNVaWREaXNjb3VudE1hcEVudHJ5EgsKA2tleRgBIAEoDRIrCgV2",
            "YWx1ZRgCIAEoCzIcLldlZWtseUJvc3NSZXNpbkRpc2NvdW50SW5mbzoCOAFC",
            "GKoCFUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.BossChestInfo), global::Lemonade.Net.Protocol.BossChestInfo.Parser, new[]{ "MonsterConfigId", "Resin", "RemainUidList", "QualifyUidList", "UidDiscountMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BossChestInfo : pb::IMessage<BossChestInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BossChestInfo> _parser = new pb::MessageParser<BossChestInfo>(() => new BossChestInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BossChestInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.BossChestInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BossChestInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BossChestInfo(BossChestInfo other) : this() {
      monsterConfigId_ = other.monsterConfigId_;
      resin_ = other.resin_;
      remainUidList_ = other.remainUidList_.Clone();
      qualifyUidList_ = other.qualifyUidList_.Clone();
      uidDiscountMap_ = other.uidDiscountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BossChestInfo Clone() {
      return new BossChestInfo(this);
    }

    /// <summary>Field number for the "monster_config_id" field.</summary>
    public const int MonsterConfigIdFieldNumber = 1;
    private uint monsterConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterConfigId {
      get { return monsterConfigId_; }
      set {
        monsterConfigId_ = value;
      }
    }

    /// <summary>Field number for the "resin" field.</summary>
    public const int ResinFieldNumber = 2;
    private uint resin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Resin {
      get { return resin_; }
      set {
        resin_ = value;
      }
    }

    /// <summary>Field number for the "remain_uid_list" field.</summary>
    public const int RemainUidListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_remainUidList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> remainUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RemainUidList {
      get { return remainUidList_; }
    }

    /// <summary>Field number for the "qualify_uid_list" field.</summary>
    public const int QualifyUidListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_qualifyUidList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> qualifyUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> QualifyUidList {
      get { return qualifyUidList_; }
    }

    /// <summary>Field number for the "uid_discount_map" field.</summary>
    public const int UidDiscountMapFieldNumber = 5;
    private static readonly pbc::MapField<uint, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo>.Codec _map_uidDiscountMap_codec
        = new pbc::MapField<uint, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo.Parser), 42);
    private readonly pbc::MapField<uint, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo> uidDiscountMap_ = new pbc::MapField<uint, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Lemonade.Net.Protocol.WeeklyBossResinDiscountInfo> UidDiscountMap {
      get { return uidDiscountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BossChestInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BossChestInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterConfigId != other.MonsterConfigId) return false;
      if (Resin != other.Resin) return false;
      if(!remainUidList_.Equals(other.remainUidList_)) return false;
      if(!qualifyUidList_.Equals(other.qualifyUidList_)) return false;
      if (!UidDiscountMap.Equals(other.UidDiscountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterConfigId != 0) hash ^= MonsterConfigId.GetHashCode();
      if (Resin != 0) hash ^= Resin.GetHashCode();
      hash ^= remainUidList_.GetHashCode();
      hash ^= qualifyUidList_.GetHashCode();
      hash ^= UidDiscountMap.GetHashCode();
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
      if (MonsterConfigId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterConfigId);
      }
      if (Resin != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Resin);
      }
      remainUidList_.WriteTo(output, _repeated_remainUidList_codec);
      qualifyUidList_.WriteTo(output, _repeated_qualifyUidList_codec);
      uidDiscountMap_.WriteTo(output, _map_uidDiscountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MonsterConfigId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterConfigId);
      }
      if (Resin != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Resin);
      }
      remainUidList_.WriteTo(ref output, _repeated_remainUidList_codec);
      qualifyUidList_.WriteTo(ref output, _repeated_qualifyUidList_codec);
      uidDiscountMap_.WriteTo(ref output, _map_uidDiscountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MonsterConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterConfigId);
      }
      if (Resin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Resin);
      }
      size += remainUidList_.CalculateSize(_repeated_remainUidList_codec);
      size += qualifyUidList_.CalculateSize(_repeated_qualifyUidList_codec);
      size += uidDiscountMap_.CalculateSize(_map_uidDiscountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BossChestInfo other) {
      if (other == null) {
        return;
      }
      if (other.MonsterConfigId != 0) {
        MonsterConfigId = other.MonsterConfigId;
      }
      if (other.Resin != 0) {
        Resin = other.Resin;
      }
      remainUidList_.Add(other.remainUidList_);
      qualifyUidList_.Add(other.qualifyUidList_);
      uidDiscountMap_.Add(other.uidDiscountMap_);
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
            MonsterConfigId = input.ReadUInt32();
            break;
          }
          case 16: {
            Resin = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            remainUidList_.AddEntriesFrom(input, _repeated_remainUidList_codec);
            break;
          }
          case 34:
          case 32: {
            qualifyUidList_.AddEntriesFrom(input, _repeated_qualifyUidList_codec);
            break;
          }
          case 42: {
            uidDiscountMap_.AddEntriesFrom(input, _map_uidDiscountMap_codec);
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
            MonsterConfigId = input.ReadUInt32();
            break;
          }
          case 16: {
            Resin = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            remainUidList_.AddEntriesFrom(ref input, _repeated_remainUidList_codec);
            break;
          }
          case 34:
          case 32: {
            qualifyUidList_.AddEntriesFrom(ref input, _repeated_qualifyUidList_codec);
            break;
          }
          case 42: {
            uidDiscountMap_.AddEntriesFrom(ref input, _map_uidDiscountMap_codec);
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
