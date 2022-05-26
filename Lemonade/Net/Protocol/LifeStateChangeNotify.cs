// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LifeStateChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from LifeStateChangeNotify.proto</summary>
  public static partial class LifeStateChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LifeStateChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LifeStateChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMaWZlU3RhdGVDaGFuZ2VOb3RpZnkucHJvdG8aE1BsYXllckRpZVR5cGUu",
            "cHJvdG8aEFNlcnZlckJ1ZmYucHJvdG8inwIKFUxpZmVTdGF0ZUNoYW5nZU5v",
            "dGlmeRIRCgllbnRpdHlfaWQYASABKA0SEgoKbGlmZV9zdGF0ZRgCIAEoDRIY",
            "ChBzb3VyY2VfZW50aXR5X2lkGAMgASgNEhIKCmF0dGFja190YWcYBCABKAkS",
            "IAoIZGllX3R5cGUYBSABKA4yDi5QbGF5ZXJEaWVUeXBlEhkKEW1vdmVfcmVs",
            "aWFibGVfc2VxGAYgASgNEiUKEHNlcnZlcl9idWZmX2xpc3QYByADKAsyCy5T",
            "ZXJ2ZXJCdWZmIk0KBUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxf",
            "SUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAESCwoGQ01EX0lEEMIJGgIQAUIY",
            "qgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.PlayerDieTypeReflection.Descriptor, global::Lemonade.Net.Protocol.ServerBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.LifeStateChangeNotify), global::Lemonade.Net.Protocol.LifeStateChangeNotify.Parser, new[]{ "EntityId", "LifeState", "SourceEntityId", "AttackTag", "DieType", "MoveReliableSeq", "ServerBuffList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.LifeStateChangeNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LifeStateChangeNotify : pb::IMessage<LifeStateChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LifeStateChangeNotify> _parser = new pb::MessageParser<LifeStateChangeNotify>(() => new LifeStateChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LifeStateChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.LifeStateChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify(LifeStateChangeNotify other) : this() {
      entityId_ = other.entityId_;
      lifeState_ = other.lifeState_;
      sourceEntityId_ = other.sourceEntityId_;
      attackTag_ = other.attackTag_;
      dieType_ = other.dieType_;
      moveReliableSeq_ = other.moveReliableSeq_;
      serverBuffList_ = other.serverBuffList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify Clone() {
      return new LifeStateChangeNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "life_state" field.</summary>
    public const int LifeStateFieldNumber = 2;
    private uint lifeState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LifeState {
      get { return lifeState_; }
      set {
        lifeState_ = value;
      }
    }

    /// <summary>Field number for the "source_entity_id" field.</summary>
    public const int SourceEntityIdFieldNumber = 3;
    private uint sourceEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceEntityId {
      get { return sourceEntityId_; }
      set {
        sourceEntityId_ = value;
      }
    }

    /// <summary>Field number for the "attack_tag" field.</summary>
    public const int AttackTagFieldNumber = 4;
    private string attackTag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AttackTag {
      get { return attackTag_; }
      set {
        attackTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "die_type" field.</summary>
    public const int DieTypeFieldNumber = 5;
    private global::Lemonade.Net.Protocol.PlayerDieType dieType_ = global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.PlayerDieType DieType {
      get { return dieType_; }
      set {
        dieType_ = value;
      }
    }

    /// <summary>Field number for the "move_reliable_seq" field.</summary>
    public const int MoveReliableSeqFieldNumber = 6;
    private uint moveReliableSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MoveReliableSeq {
      get { return moveReliableSeq_; }
      set {
        moveReliableSeq_ = value;
      }
    }

    /// <summary>Field number for the "server_buff_list" field.</summary>
    public const int ServerBuffListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ServerBuff> _repeated_serverBuffList_codec
        = pb::FieldCodec.ForMessage(58, global::Lemonade.Net.Protocol.ServerBuff.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ServerBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ServerBuff> ServerBuffList {
      get { return serverBuffList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LifeStateChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LifeStateChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (LifeState != other.LifeState) return false;
      if (SourceEntityId != other.SourceEntityId) return false;
      if (AttackTag != other.AttackTag) return false;
      if (DieType != other.DieType) return false;
      if (MoveReliableSeq != other.MoveReliableSeq) return false;
      if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (LifeState != 0) hash ^= LifeState.GetHashCode();
      if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
      if (AttackTag.Length != 0) hash ^= AttackTag.GetHashCode();
      if (DieType != global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone) hash ^= DieType.GetHashCode();
      if (MoveReliableSeq != 0) hash ^= MoveReliableSeq.GetHashCode();
      hash ^= serverBuffList_.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (LifeState != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LifeState);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SourceEntityId);
      }
      if (AttackTag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AttackTag);
      }
      if (DieType != global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DieType);
      }
      if (MoveReliableSeq != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MoveReliableSeq);
      }
      serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (LifeState != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LifeState);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SourceEntityId);
      }
      if (AttackTag.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AttackTag);
      }
      if (DieType != global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DieType);
      }
      if (MoveReliableSeq != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MoveReliableSeq);
      }
      serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (LifeState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeState);
      }
      if (SourceEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
      }
      if (AttackTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AttackTag);
      }
      if (DieType != global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieType);
      }
      if (MoveReliableSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MoveReliableSeq);
      }
      size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LifeStateChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.LifeState != 0) {
        LifeState = other.LifeState;
      }
      if (other.SourceEntityId != 0) {
        SourceEntityId = other.SourceEntityId;
      }
      if (other.AttackTag.Length != 0) {
        AttackTag = other.AttackTag;
      }
      if (other.DieType != global::Lemonade.Net.Protocol.PlayerDieType.PlayerDieNone) {
        DieType = other.DieType;
      }
      if (other.MoveReliableSeq != 0) {
        MoveReliableSeq = other.MoveReliableSeq;
      }
      serverBuffList_.Add(other.serverBuffList_);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            LifeState = input.ReadUInt32();
            break;
          }
          case 24: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            AttackTag = input.ReadString();
            break;
          }
          case 40: {
            DieType = (global::Lemonade.Net.Protocol.PlayerDieType) input.ReadEnum();
            break;
          }
          case 48: {
            MoveReliableSeq = input.ReadUInt32();
            break;
          }
          case 58: {
            serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            LifeState = input.ReadUInt32();
            break;
          }
          case 24: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 34: {
            AttackTag = input.ReadString();
            break;
          }
          case 40: {
            DieType = (global::Lemonade.Net.Protocol.PlayerDieType) input.ReadEnum();
            break;
          }
          case 48: {
            MoveReliableSeq = input.ReadUInt32();
            break;
          }
          case 58: {
            serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LifeStateChangeNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1218,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
