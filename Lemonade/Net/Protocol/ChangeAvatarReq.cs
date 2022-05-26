// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ChangeAvatarReq.proto</summary>
  public static partial class ChangeAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDaGFuZ2VBdmF0YXJSZXEucHJvdG8aDFZlY3Rvci5wcm90byLBAQoPQ2hh",
            "bmdlQXZhdGFyUmVxEgwKBGd1aWQYASABKAQSEAoIc2tpbGxfaWQYAiABKA0S",
            "DwoHaXNfbW92ZRgDIAEoCBIZCghtb3ZlX3BvcxgEIAEoCzIHLlZlY3RvciJi",
            "CgVDbWRJZBITCg9FTkVUX0NIQU5ORUxfSUQQABIICgROT05FEAASFAoQRU5F",
            "VF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVOVBABEgsKBkNNRF9J",
            "RBCFDRoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ChangeAvatarReq), global::Lemonade.Net.Protocol.ChangeAvatarReq.Parser, new[]{ "Guid", "SkillId", "IsMove", "MovePos" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.ChangeAvatarReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChangeAvatarReq : pb::IMessage<ChangeAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeAvatarReq> _parser = new pb::MessageParser<ChangeAvatarReq>(() => new ChangeAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ChangeAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq(ChangeAvatarReq other) : this() {
      guid_ = other.guid_;
      skillId_ = other.skillId_;
      isMove_ = other.isMove_;
      movePos_ = other.movePos_ != null ? other.movePos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq Clone() {
      return new ChangeAvatarReq(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 2;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "is_move" field.</summary>
    public const int IsMoveFieldNumber = 3;
    private bool isMove_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMove {
      get { return isMove_; }
      set {
        isMove_ = value;
      }
    }

    /// <summary>Field number for the "move_pos" field.</summary>
    public const int MovePosFieldNumber = 4;
    private global::Lemonade.Net.Protocol.Vector movePos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector MovePos {
      get { return movePos_; }
      set {
        movePos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (SkillId != other.SkillId) return false;
      if (IsMove != other.IsMove) return false;
      if (!object.Equals(MovePos, other.MovePos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (IsMove != false) hash ^= IsMove.GetHashCode();
      if (movePos_ != null) hash ^= MovePos.GetHashCode();
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
      if (Guid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Guid);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (IsMove != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsMove);
      }
      if (movePos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MovePos);
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
      if (Guid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Guid);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (IsMove != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsMove);
      }
      if (movePos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MovePos);
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
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (IsMove != false) {
        size += 1 + 1;
      }
      if (movePos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MovePos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeAvatarReq other) {
      if (other == null) {
        return;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.IsMove != false) {
        IsMove = other.IsMove;
      }
      if (other.movePos_ != null) {
        if (movePos_ == null) {
          MovePos = new global::Lemonade.Net.Protocol.Vector();
        }
        MovePos.MergeFrom(other.MovePos);
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
            Guid = input.ReadUInt64();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsMove = input.ReadBool();
            break;
          }
          case 34: {
            if (movePos_ == null) {
              MovePos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(MovePos);
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
            Guid = input.ReadUInt64();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsMove = input.ReadBool();
            break;
          }
          case 34: {
            if (movePos_ == null) {
              MovePos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(MovePos);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ChangeAvatarReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1669,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
