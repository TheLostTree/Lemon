// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerChatReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerChatReq.proto</summary>
  public static partial class PlayerChatReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerChatReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerChatReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQbGF5ZXJDaGF0UmVxLnByb3RvGg5DaGF0SW5mby5wcm90byKlAQoNUGxh",
            "eWVyQ2hhdFJlcRISCgpjaGFubmVsX2lkGAEgASgNEhwKCWNoYXRfaW5mbxgC",
            "IAEoCzIJLkNoYXRJbmZvImIKBUNtZElkEhMKD0VORVRfQ0hBTk5FTF9JRBAA",
            "EggKBE5PTkUQABIUChBFTkVUX0lTX1JFTElBQkxFEAESEwoPSVNfQUxMT1df",
            "Q0xJRU5UEAESCwoGQ01EX0lEEP4ZGgIQAUIYqgIVTGVtb25hZGUuTmV0LlBy",
            "b3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ChatInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerChatReq), global::Lemonade.Net.Protocol.PlayerChatReq.Parser, new[]{ "ChannelId", "ChatInfo" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.PlayerChatReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerChatReq : pb::IMessage<PlayerChatReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerChatReq> _parser = new pb::MessageParser<PlayerChatReq>(() => new PlayerChatReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerChatReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerChatReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerChatReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerChatReq(PlayerChatReq other) : this() {
      channelId_ = other.channelId_;
      chatInfo_ = other.chatInfo_ != null ? other.chatInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerChatReq Clone() {
      return new PlayerChatReq(this);
    }

    /// <summary>Field number for the "channel_id" field.</summary>
    public const int ChannelIdFieldNumber = 1;
    private uint channelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChannelId {
      get { return channelId_; }
      set {
        channelId_ = value;
      }
    }

    /// <summary>Field number for the "chat_info" field.</summary>
    public const int ChatInfoFieldNumber = 2;
    private global::Lemonade.Net.Protocol.ChatInfo chatInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ChatInfo ChatInfo {
      get { return chatInfo_; }
      set {
        chatInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerChatReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerChatReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChannelId != other.ChannelId) return false;
      if (!object.Equals(ChatInfo, other.ChatInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChannelId != 0) hash ^= ChannelId.GetHashCode();
      if (chatInfo_ != null) hash ^= ChatInfo.GetHashCode();
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
      if (ChannelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChannelId);
      }
      if (chatInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChatInfo);
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
      if (ChannelId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChannelId);
      }
      if (chatInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ChatInfo);
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
      if (ChannelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChannelId);
      }
      if (chatInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChatInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerChatReq other) {
      if (other == null) {
        return;
      }
      if (other.ChannelId != 0) {
        ChannelId = other.ChannelId;
      }
      if (other.chatInfo_ != null) {
        if (chatInfo_ == null) {
          ChatInfo = new global::Lemonade.Net.Protocol.ChatInfo();
        }
        ChatInfo.MergeFrom(other.ChatInfo);
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
            ChannelId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (chatInfo_ == null) {
              ChatInfo = new global::Lemonade.Net.Protocol.ChatInfo();
            }
            input.ReadMessage(ChatInfo);
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
            ChannelId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (chatInfo_ == null) {
              ChatInfo = new global::Lemonade.Net.Protocol.ChatInfo();
            }
            input.ReadMessage(ChatInfo);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerChatReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 3326,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
