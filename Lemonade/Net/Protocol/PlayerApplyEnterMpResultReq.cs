// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerApplyEnterMpResultReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerApplyEnterMpResultReq.proto</summary>
  public static partial class PlayerApplyEnterMpResultReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerApplyEnterMpResultReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerApplyEnterMpResultReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQbGF5ZXJBcHBseUVudGVyTXBSZXN1bHRSZXEucHJvdG8ipwEKG1BsYXll",
            "ckFwcGx5RW50ZXJNcFJlc3VsdFJlcRIRCglhcHBseV91aWQYASABKA0SEQoJ",
            "aXNfYWdyZWVkGAIgASgIImIKBUNtZElkEhMKD0VORVRfQ0hBTk5FTF9JRBAA",
            "EggKBE5PTkUQABIUChBFTkVUX0lTX1JFTElBQkxFEAESEwoPSVNfQUxMT1df",
            "Q0xJRU5UEAESCwoGQ01EX0lEEKAOGgIQAUIYqgIVTGVtb25hZGUuTmV0LlBy",
            "b3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerApplyEnterMpResultReq), global::Lemonade.Net.Protocol.PlayerApplyEnterMpResultReq.Parser, new[]{ "ApplyUid", "IsAgreed" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.PlayerApplyEnterMpResultReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerApplyEnterMpResultReq : pb::IMessage<PlayerApplyEnterMpResultReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerApplyEnterMpResultReq> _parser = new pb::MessageParser<PlayerApplyEnterMpResultReq>(() => new PlayerApplyEnterMpResultReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerApplyEnterMpResultReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerApplyEnterMpResultReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultReq(PlayerApplyEnterMpResultReq other) : this() {
      applyUid_ = other.applyUid_;
      isAgreed_ = other.isAgreed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultReq Clone() {
      return new PlayerApplyEnterMpResultReq(this);
    }

    /// <summary>Field number for the "apply_uid" field.</summary>
    public const int ApplyUidFieldNumber = 1;
    private uint applyUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ApplyUid {
      get { return applyUid_; }
      set {
        applyUid_ = value;
      }
    }

    /// <summary>Field number for the "is_agreed" field.</summary>
    public const int IsAgreedFieldNumber = 2;
    private bool isAgreed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAgreed {
      get { return isAgreed_; }
      set {
        isAgreed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerApplyEnterMpResultReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerApplyEnterMpResultReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApplyUid != other.ApplyUid) return false;
      if (IsAgreed != other.IsAgreed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ApplyUid != 0) hash ^= ApplyUid.GetHashCode();
      if (IsAgreed != false) hash ^= IsAgreed.GetHashCode();
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
      if (ApplyUid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ApplyUid);
      }
      if (IsAgreed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAgreed);
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
      if (ApplyUid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ApplyUid);
      }
      if (IsAgreed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAgreed);
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
      if (ApplyUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ApplyUid);
      }
      if (IsAgreed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerApplyEnterMpResultReq other) {
      if (other == null) {
        return;
      }
      if (other.ApplyUid != 0) {
        ApplyUid = other.ApplyUid;
      }
      if (other.IsAgreed != false) {
        IsAgreed = other.IsAgreed;
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
            ApplyUid = input.ReadUInt32();
            break;
          }
          case 16: {
            IsAgreed = input.ReadBool();
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
            ApplyUid = input.ReadUInt32();
            break;
          }
          case 16: {
            IsAgreed = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerApplyEnterMpResultReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1824,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code