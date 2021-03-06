// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarLifeStateChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from AvatarLifeStateChangeNotify.proto</summary>
  public static partial class AvatarLifeStateChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarLifeStateChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarLifeStateChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFBdmF0YXJMaWZlU3RhdGVDaGFuZ2VOb3RpZnkucHJvdG8aE1BsYXllckRp",
            "ZVR5cGUucHJvdG8aEFNlcnZlckJ1ZmYucHJvdG8ipwIKG0F2YXRhckxpZmVT",
            "dGF0ZUNoYW5nZU5vdGlmeRITCgthdmF0YXJfZ3VpZBgBIAEoBBISCgpsaWZl",
            "X3N0YXRlGAIgASgNEhgKEHNvdXJjZV9lbnRpdHlfaWQYAyABKA0SEgoKYXR0",
            "YWNrX3RhZxgEIAEoCRIgCghkaWVfdHlwZRgFIAEoDjIOLlBsYXllckRpZVR5",
            "cGUSGQoRbW92ZV9yZWxpYWJsZV9zZXEYBiABKA0SJQoQc2VydmVyX2J1ZmZf",
            "bGlzdBgHIAMoCzILLlNlcnZlckJ1ZmYiTQoFQ21kSWQSCAoETk9ORRAAEhMK",
            "D0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZD",
            "TURfSUQQ2gkaAhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.PlayerDieTypeReflection.Descriptor, global::Lemonade.Net.Protocol.ServerBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.AvatarLifeStateChangeNotify), global::Lemonade.Net.Protocol.AvatarLifeStateChangeNotify.Parser, new[]{ "AvatarGuid", "LifeState", "SourceEntityId", "AttackTag", "DieType", "MoveReliableSeq", "ServerBuffList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.AvatarLifeStateChangeNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarLifeStateChangeNotify : pb::IMessage<AvatarLifeStateChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarLifeStateChangeNotify> _parser = new pb::MessageParser<AvatarLifeStateChangeNotify>(() => new AvatarLifeStateChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarLifeStateChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.AvatarLifeStateChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarLifeStateChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarLifeStateChangeNotify(AvatarLifeStateChangeNotify other) : this() {
      avatarGuid_ = other.avatarGuid_;
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
    public AvatarLifeStateChangeNotify Clone() {
      return new AvatarLifeStateChangeNotify(this);
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 1;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
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
      return Equals(other as AvatarLifeStateChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarLifeStateChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
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
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
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
    public void MergeFrom(AvatarLifeStateChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
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
            AvatarGuid = input.ReadUInt64();
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
            AvatarGuid = input.ReadUInt64();
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
    /// <summary>Container for nested types declared in the AvatarLifeStateChangeNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1242,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
