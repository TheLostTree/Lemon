// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ScenePlayerInfo.proto</summary>
  public static partial class ScenePlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZVBsYXllckluZm8ucHJvdG8aFk9ubGluZVBsYXllckluZm8ucHJv",
            "dG8ilAEKD1NjZW5lUGxheWVySW5mbxILCgN1aWQYASABKA0SDwoHcGVlcl9p",
            "ZBgCIAEoDRIMCgRuYW1lGAMgASgJEhQKDGlzX2Nvbm5lY3RlZBgEIAEoCBIQ",
            "CghzY2VuZV9pZBgFIAEoDRItChJvbmxpbmVfcGxheWVyX2luZm8YBiABKAsy",
            "ES5PbmxpbmVQbGF5ZXJJbmZvQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ScenePlayerInfo), global::Lemonade.Net.Protocol.ScenePlayerInfo.Parser, new[]{ "Uid", "PeerId", "Name", "IsConnected", "SceneId", "OnlinePlayerInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScenePlayerInfo : pb::IMessage<ScenePlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScenePlayerInfo> _parser = new pb::MessageParser<ScenePlayerInfo>(() => new ScenePlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScenePlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ScenePlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayerInfo(ScenePlayerInfo other) : this() {
      uid_ = other.uid_;
      peerId_ = other.peerId_;
      name_ = other.name_;
      isConnected_ = other.isConnected_;
      sceneId_ = other.sceneId_;
      onlinePlayerInfo_ = other.onlinePlayerInfo_ != null ? other.onlinePlayerInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayerInfo Clone() {
      return new ScenePlayerInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "peer_id" field.</summary>
    public const int PeerIdFieldNumber = 2;
    private uint peerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PeerId {
      get { return peerId_; }
      set {
        peerId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_connected" field.</summary>
    public const int IsConnectedFieldNumber = 4;
    private bool isConnected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsConnected {
      get { return isConnected_; }
      set {
        isConnected_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 5;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "online_player_info" field.</summary>
    public const int OnlinePlayerInfoFieldNumber = 6;
    private global::Lemonade.Net.Protocol.OnlinePlayerInfo onlinePlayerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.OnlinePlayerInfo OnlinePlayerInfo {
      get { return onlinePlayerInfo_; }
      set {
        onlinePlayerInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScenePlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScenePlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (PeerId != other.PeerId) return false;
      if (Name != other.Name) return false;
      if (IsConnected != other.IsConnected) return false;
      if (SceneId != other.SceneId) return false;
      if (!object.Equals(OnlinePlayerInfo, other.OnlinePlayerInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (PeerId != 0) hash ^= PeerId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (IsConnected != false) hash ^= IsConnected.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (onlinePlayerInfo_ != null) hash ^= OnlinePlayerInfo.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (PeerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PeerId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (IsConnected != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsConnected);
      }
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (onlinePlayerInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OnlinePlayerInfo);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (PeerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PeerId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (IsConnected != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsConnected);
      }
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (onlinePlayerInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(OnlinePlayerInfo);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (PeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PeerId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (IsConnected != false) {
        size += 1 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (onlinePlayerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OnlinePlayerInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScenePlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.PeerId != 0) {
        PeerId = other.PeerId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.IsConnected != false) {
        IsConnected = other.IsConnected;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.onlinePlayerInfo_ != null) {
        if (onlinePlayerInfo_ == null) {
          OnlinePlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
        }
        OnlinePlayerInfo.MergeFrom(other.OnlinePlayerInfo);
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            IsConnected = input.ReadBool();
            break;
          }
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (onlinePlayerInfo_ == null) {
              OnlinePlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
            }
            input.ReadMessage(OnlinePlayerInfo);
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            IsConnected = input.ReadBool();
            break;
          }
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (onlinePlayerInfo_ == null) {
              OnlinePlayerInfo = new global::Lemonade.Net.Protocol.OnlinePlayerInfo();
            }
            input.ReadMessage(OnlinePlayerInfo);
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
