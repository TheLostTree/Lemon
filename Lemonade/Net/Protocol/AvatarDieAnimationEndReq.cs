// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarDieAnimationEndReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from AvatarDieAnimationEndReq.proto</summary>
  public static partial class AvatarDieAnimationEndReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarDieAnimationEndReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarDieAnimationEndReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5BdmF0YXJEaWVBbmltYXRpb25FbmRSZXEucHJvdG8aDFZlY3Rvci5wcm90",
            "byK/AQoYQXZhdGFyRGllQW5pbWF0aW9uRW5kUmVxEhAKCGRpZV9ndWlkGAEg",
            "ASgEEhAKCHNraWxsX2lkGAIgASgNEhsKCnJlYm9ybl9wb3MYAyABKAsyBy5W",
            "ZWN0b3IiYgoFQ21kSWQSEwoPRU5FVF9DSEFOTkVMX0lEEAASCAoETk9ORRAA",
            "EhQKEEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARIL",
            "CgZDTURfSUQQyQ0aAhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.AvatarDieAnimationEndReq), global::Lemonade.Net.Protocol.AvatarDieAnimationEndReq.Parser, new[]{ "DieGuid", "SkillId", "RebornPos" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.AvatarDieAnimationEndReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarDieAnimationEndReq : pb::IMessage<AvatarDieAnimationEndReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarDieAnimationEndReq> _parser = new pb::MessageParser<AvatarDieAnimationEndReq>(() => new AvatarDieAnimationEndReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarDieAnimationEndReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.AvatarDieAnimationEndReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarDieAnimationEndReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarDieAnimationEndReq(AvatarDieAnimationEndReq other) : this() {
      dieGuid_ = other.dieGuid_;
      skillId_ = other.skillId_;
      rebornPos_ = other.rebornPos_ != null ? other.rebornPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarDieAnimationEndReq Clone() {
      return new AvatarDieAnimationEndReq(this);
    }

    /// <summary>Field number for the "die_guid" field.</summary>
    public const int DieGuidFieldNumber = 1;
    private ulong dieGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DieGuid {
      get { return dieGuid_; }
      set {
        dieGuid_ = value;
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

    /// <summary>Field number for the "reborn_pos" field.</summary>
    public const int RebornPosFieldNumber = 3;
    private global::Lemonade.Net.Protocol.Vector rebornPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector RebornPos {
      get { return rebornPos_; }
      set {
        rebornPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarDieAnimationEndReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarDieAnimationEndReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DieGuid != other.DieGuid) return false;
      if (SkillId != other.SkillId) return false;
      if (!object.Equals(RebornPos, other.RebornPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DieGuid != 0UL) hash ^= DieGuid.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (rebornPos_ != null) hash ^= RebornPos.GetHashCode();
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
      if (DieGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DieGuid);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (rebornPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RebornPos);
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
      if (DieGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DieGuid);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (rebornPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RebornPos);
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
      if (DieGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DieGuid);
      }
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (rebornPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RebornPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarDieAnimationEndReq other) {
      if (other == null) {
        return;
      }
      if (other.DieGuid != 0UL) {
        DieGuid = other.DieGuid;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.rebornPos_ != null) {
        if (rebornPos_ == null) {
          RebornPos = new global::Lemonade.Net.Protocol.Vector();
        }
        RebornPos.MergeFrom(other.RebornPos);
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
            DieGuid = input.ReadUInt64();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (rebornPos_ == null) {
              RebornPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(RebornPos);
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
            DieGuid = input.ReadUInt64();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (rebornPos_ == null) {
              RebornPos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(RebornPos);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AvatarDieAnimationEndReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1737,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
