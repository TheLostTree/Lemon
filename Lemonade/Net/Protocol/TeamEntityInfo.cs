// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TeamEntityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TeamEntityInfo.proto</summary>
  public static partial class TeamEntityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TeamEntityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TeamEntityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRUZWFtRW50aXR5SW5mby5wcm90bxoaQWJpbGl0eVN5bmNTdGF0ZUluZm8u",
            "cHJvdG8idQoOVGVhbUVudGl0eUluZm8SFgoOdGVhbV9lbnRpdHlfaWQYASAB",
            "KA0SGQoRYXV0aG9yaXR5X3BlZXJfaWQYAiABKA0SMAoRdGVhbV9hYmlsaXR5",
            "X2luZm8YAyABKAsyFS5BYmlsaXR5U3luY1N0YXRlSW5mb0IYqgIVTGVtb25h",
            "ZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.AbilitySyncStateInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TeamEntityInfo), global::Lemonade.Net.Protocol.TeamEntityInfo.Parser, new[]{ "TeamEntityId", "AuthorityPeerId", "TeamAbilityInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TeamEntityInfo : pb::IMessage<TeamEntityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TeamEntityInfo> _parser = new pb::MessageParser<TeamEntityInfo>(() => new TeamEntityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TeamEntityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TeamEntityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEntityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEntityInfo(TeamEntityInfo other) : this() {
      teamEntityId_ = other.teamEntityId_;
      authorityPeerId_ = other.authorityPeerId_;
      teamAbilityInfo_ = other.teamAbilityInfo_ != null ? other.teamAbilityInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEntityInfo Clone() {
      return new TeamEntityInfo(this);
    }

    /// <summary>Field number for the "team_entity_id" field.</summary>
    public const int TeamEntityIdFieldNumber = 1;
    private uint teamEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TeamEntityId {
      get { return teamEntityId_; }
      set {
        teamEntityId_ = value;
      }
    }

    /// <summary>Field number for the "authority_peer_id" field.</summary>
    public const int AuthorityPeerIdFieldNumber = 2;
    private uint authorityPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthorityPeerId {
      get { return authorityPeerId_; }
      set {
        authorityPeerId_ = value;
      }
    }

    /// <summary>Field number for the "team_ability_info" field.</summary>
    public const int TeamAbilityInfoFieldNumber = 3;
    private global::Lemonade.Net.Protocol.AbilitySyncStateInfo teamAbilityInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilitySyncStateInfo TeamAbilityInfo {
      get { return teamAbilityInfo_; }
      set {
        teamAbilityInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TeamEntityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TeamEntityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TeamEntityId != other.TeamEntityId) return false;
      if (AuthorityPeerId != other.AuthorityPeerId) return false;
      if (!object.Equals(TeamAbilityInfo, other.TeamAbilityInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TeamEntityId != 0) hash ^= TeamEntityId.GetHashCode();
      if (AuthorityPeerId != 0) hash ^= AuthorityPeerId.GetHashCode();
      if (teamAbilityInfo_ != null) hash ^= TeamAbilityInfo.GetHashCode();
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
      if (TeamEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TeamEntityId);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (teamAbilityInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TeamAbilityInfo);
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
      if (TeamEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TeamEntityId);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (teamAbilityInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TeamAbilityInfo);
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
      if (TeamEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TeamEntityId);
      }
      if (AuthorityPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthorityPeerId);
      }
      if (teamAbilityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamAbilityInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TeamEntityInfo other) {
      if (other == null) {
        return;
      }
      if (other.TeamEntityId != 0) {
        TeamEntityId = other.TeamEntityId;
      }
      if (other.AuthorityPeerId != 0) {
        AuthorityPeerId = other.AuthorityPeerId;
      }
      if (other.teamAbilityInfo_ != null) {
        if (teamAbilityInfo_ == null) {
          TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
        }
        TeamAbilityInfo.MergeFrom(other.TeamAbilityInfo);
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
            TeamEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (teamAbilityInfo_ == null) {
              TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
            }
            input.ReadMessage(TeamAbilityInfo);
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
            TeamEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 26: {
            if (teamAbilityInfo_ == null) {
              TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
            }
            input.ReadMessage(TeamAbilityInfo);
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
