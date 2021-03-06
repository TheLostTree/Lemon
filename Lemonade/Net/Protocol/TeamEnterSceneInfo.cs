// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TeamEnterSceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TeamEnterSceneInfo.proto</summary>
  public static partial class TeamEnterSceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TeamEnterSceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TeamEnterSceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhUZWFtRW50ZXJTY2VuZUluZm8ucHJvdG8aGkFiaWxpdHlTeW5jU3RhdGVJ",
            "bmZvLnByb3RvGhlBYmlsaXR5Q29udHJvbEJsb2NrLnByb3RvIpMBChJUZWFt",
            "RW50ZXJTY2VuZUluZm8SFgoOdGVhbV9lbnRpdHlfaWQYASABKA0SMAoRdGVh",
            "bV9hYmlsaXR5X2luZm8YAiABKAsyFS5BYmlsaXR5U3luY1N0YXRlSW5mbxIz",
            "ChVhYmlsaXR5X2NvbnRyb2xfYmxvY2sYAyABKAsyFC5BYmlsaXR5Q29udHJv",
            "bEJsb2NrQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.AbilitySyncStateInfoReflection.Descriptor, global::Lemonade.Net.Protocol.AbilityControlBlockReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TeamEnterSceneInfo), global::Lemonade.Net.Protocol.TeamEnterSceneInfo.Parser, new[]{ "TeamEntityId", "TeamAbilityInfo", "AbilityControlBlock" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TeamEnterSceneInfo : pb::IMessage<TeamEnterSceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TeamEnterSceneInfo> _parser = new pb::MessageParser<TeamEnterSceneInfo>(() => new TeamEnterSceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TeamEnterSceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TeamEnterSceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEnterSceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEnterSceneInfo(TeamEnterSceneInfo other) : this() {
      teamEntityId_ = other.teamEntityId_;
      teamAbilityInfo_ = other.teamAbilityInfo_ != null ? other.teamAbilityInfo_.Clone() : null;
      abilityControlBlock_ = other.abilityControlBlock_ != null ? other.abilityControlBlock_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamEnterSceneInfo Clone() {
      return new TeamEnterSceneInfo(this);
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

    /// <summary>Field number for the "team_ability_info" field.</summary>
    public const int TeamAbilityInfoFieldNumber = 2;
    private global::Lemonade.Net.Protocol.AbilitySyncStateInfo teamAbilityInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilitySyncStateInfo TeamAbilityInfo {
      get { return teamAbilityInfo_; }
      set {
        teamAbilityInfo_ = value;
      }
    }

    /// <summary>Field number for the "ability_control_block" field.</summary>
    public const int AbilityControlBlockFieldNumber = 3;
    private global::Lemonade.Net.Protocol.AbilityControlBlock abilityControlBlock_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilityControlBlock AbilityControlBlock {
      get { return abilityControlBlock_; }
      set {
        abilityControlBlock_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TeamEnterSceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TeamEnterSceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TeamEntityId != other.TeamEntityId) return false;
      if (!object.Equals(TeamAbilityInfo, other.TeamAbilityInfo)) return false;
      if (!object.Equals(AbilityControlBlock, other.AbilityControlBlock)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TeamEntityId != 0) hash ^= TeamEntityId.GetHashCode();
      if (teamAbilityInfo_ != null) hash ^= TeamAbilityInfo.GetHashCode();
      if (abilityControlBlock_ != null) hash ^= AbilityControlBlock.GetHashCode();
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
      if (teamAbilityInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TeamAbilityInfo);
      }
      if (abilityControlBlock_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AbilityControlBlock);
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
      if (teamAbilityInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TeamAbilityInfo);
      }
      if (abilityControlBlock_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AbilityControlBlock);
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
      if (teamAbilityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeamAbilityInfo);
      }
      if (abilityControlBlock_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityControlBlock);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TeamEnterSceneInfo other) {
      if (other == null) {
        return;
      }
      if (other.TeamEntityId != 0) {
        TeamEntityId = other.TeamEntityId;
      }
      if (other.teamAbilityInfo_ != null) {
        if (teamAbilityInfo_ == null) {
          TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
        }
        TeamAbilityInfo.MergeFrom(other.TeamAbilityInfo);
      }
      if (other.abilityControlBlock_ != null) {
        if (abilityControlBlock_ == null) {
          AbilityControlBlock = new global::Lemonade.Net.Protocol.AbilityControlBlock();
        }
        AbilityControlBlock.MergeFrom(other.AbilityControlBlock);
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
          case 18: {
            if (teamAbilityInfo_ == null) {
              TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
            }
            input.ReadMessage(TeamAbilityInfo);
            break;
          }
          case 26: {
            if (abilityControlBlock_ == null) {
              AbilityControlBlock = new global::Lemonade.Net.Protocol.AbilityControlBlock();
            }
            input.ReadMessage(AbilityControlBlock);
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
          case 18: {
            if (teamAbilityInfo_ == null) {
              TeamAbilityInfo = new global::Lemonade.Net.Protocol.AbilitySyncStateInfo();
            }
            input.ReadMessage(TeamAbilityInfo);
            break;
          }
          case 26: {
            if (abilityControlBlock_ == null) {
              AbilityControlBlock = new global::Lemonade.Net.Protocol.AbilityControlBlock();
            }
            input.ReadMessage(AbilityControlBlock);
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
