// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeMpTeamAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ChangeMpTeamAvatarReq.proto</summary>
  public static partial class ChangeMpTeamAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeMpTeamAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeMpTeamAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDaGFuZ2VNcFRlYW1BdmF0YXJSZXEucHJvdG8irgEKFUNoYW5nZU1wVGVh",
            "bUF2YXRhclJlcRIYChBhdmF0YXJfZ3VpZF9saXN0GAEgAygEEhcKD2N1cl9h",
            "dmF0YXJfZ3VpZBgCIAEoBCJiCgVDbWRJZBITCg9FTkVUX0NIQU5ORUxfSUQQ",
            "ABIICgROT05FEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9X",
            "X0NMSUVOVBABEgsKBkNNRF9JRBDDDRoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Q",
            "cm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ChangeMpTeamAvatarReq), global::Lemonade.Net.Protocol.ChangeMpTeamAvatarReq.Parser, new[]{ "AvatarGuidList", "CurAvatarGuid" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.ChangeMpTeamAvatarReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChangeMpTeamAvatarReq : pb::IMessage<ChangeMpTeamAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeMpTeamAvatarReq> _parser = new pb::MessageParser<ChangeMpTeamAvatarReq>(() => new ChangeMpTeamAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeMpTeamAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ChangeMpTeamAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq(ChangeMpTeamAvatarReq other) : this() {
      avatarGuidList_ = other.avatarGuidList_.Clone();
      curAvatarGuid_ = other.curAvatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeMpTeamAvatarReq Clone() {
      return new ChangeMpTeamAvatarReq(this);
    }

    /// <summary>Field number for the "avatar_guid_list" field.</summary>
    public const int AvatarGuidListFieldNumber = 1;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarGuidList_codec
        = pb::FieldCodec.ForUInt64(10);
    private readonly pbc::RepeatedField<ulong> avatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarGuidList {
      get { return avatarGuidList_; }
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 2;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeMpTeamAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeMpTeamAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarGuidList_.Equals(other.avatarGuidList_)) return false;
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarGuidList_.GetHashCode();
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
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
      avatarGuidList_.WriteTo(output, _repeated_avatarGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(CurAvatarGuid);
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
      avatarGuidList_.WriteTo(ref output, _repeated_avatarGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(CurAvatarGuid);
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
      size += avatarGuidList_.CalculateSize(_repeated_avatarGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeMpTeamAvatarReq other) {
      if (other == null) {
        return;
      }
      avatarGuidList_.Add(other.avatarGuidList_);
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
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
          case 10:
          case 8: {
            avatarGuidList_.AddEntriesFrom(input, _repeated_avatarGuidList_codec);
            break;
          }
          case 16: {
            CurAvatarGuid = input.ReadUInt64();
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
          case 10:
          case 8: {
            avatarGuidList_.AddEntriesFrom(ref input, _repeated_avatarGuidList_codec);
            break;
          }
          case 16: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ChangeMpTeamAvatarReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1731,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
