// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DealAddFriendRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from DealAddFriendRsp.proto</summary>
  public static partial class DealAddFriendRspReflection {

    #region Descriptor
    /// <summary>File descriptor for DealAddFriendRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealAddFriendRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEZWFsQWRkRnJpZW5kUnNwLnByb3RvGh1EZWFsQWRkRnJpZW5kUmVzdWx0",
            "VHlwZS5wcm90byLVAQoQRGVhbEFkZEZyaWVuZFJzcBIPCgdyZXRjb2RlGAEg",
            "ASgFEhIKCnRhcmdldF91aWQYAiABKA0SOAoWZGVhbF9hZGRfZnJpZW5kX3Jl",
            "c3VsdBgDIAEoDjIYLkRlYWxBZGRGcmllbmRSZXN1bHRUeXBlImIKBUNtZElk",
            "EhMKD0VORVRfQ0hBTk5FTF9JRBAAEggKBE5PTkUQABIUChBFTkVUX0lTX1JF",
            "TElBQkxFEAESEwoPSVNfQUxMT1dfQ0xJRU5UEAESCwoGQ01EX0lEEMofGgIQ",
            "AUIYqgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.DealAddFriendResultTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.DealAddFriendRsp), global::Lemonade.Net.Protocol.DealAddFriendRsp.Parser, new[]{ "Retcode", "TargetUid", "DealAddFriendResult" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.DealAddFriendRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DealAddFriendRsp : pb::IMessage<DealAddFriendRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DealAddFriendRsp> _parser = new pb::MessageParser<DealAddFriendRsp>(() => new DealAddFriendRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DealAddFriendRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.DealAddFriendRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendRsp(DealAddFriendRsp other) : this() {
      retcode_ = other.retcode_;
      targetUid_ = other.targetUid_;
      dealAddFriendResult_ = other.dealAddFriendResult_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealAddFriendRsp Clone() {
      return new DealAddFriendRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 2;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "deal_add_friend_result" field.</summary>
    public const int DealAddFriendResultFieldNumber = 3;
    private global::Lemonade.Net.Protocol.DealAddFriendResultType dealAddFriendResult_ = global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.DealAddFriendResultType DealAddFriendResult {
      get { return dealAddFriendResult_; }
      set {
        dealAddFriendResult_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DealAddFriendRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DealAddFriendRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (TargetUid != other.TargetUid) return false;
      if (DealAddFriendResult != other.DealAddFriendResult) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (DealAddFriendResult != global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject) hash ^= DealAddFriendResult.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TargetUid);
      }
      if (DealAddFriendResult != global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject) {
        output.WriteRawTag(24);
        output.WriteEnum((int) DealAddFriendResult);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TargetUid);
      }
      if (DealAddFriendResult != global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject) {
        output.WriteRawTag(24);
        output.WriteEnum((int) DealAddFriendResult);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (DealAddFriendResult != global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DealAddFriendResult);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DealAddFriendRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.DealAddFriendResult != global::Lemonade.Net.Protocol.DealAddFriendResultType.DealAddFriendReject) {
        DealAddFriendResult = other.DealAddFriendResult;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 24: {
            DealAddFriendResult = (global::Lemonade.Net.Protocol.DealAddFriendResultType) input.ReadEnum();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 16: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 24: {
            DealAddFriendResult = (global::Lemonade.Net.Protocol.DealAddFriendResultType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DealAddFriendRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4042,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
