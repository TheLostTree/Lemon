// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityAppliedAbility.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from AbilityAppliedAbility.proto</summary>
  public static partial class AbilityAppliedAbilityReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityAppliedAbility.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityAppliedAbilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBYmlsaXR5QXBwbGllZEFiaWxpdHkucHJvdG8aE0FiaWxpdHlTdHJpbmcu",
            "cHJvdG8aHUFiaWxpdHlTY2FsYXJWYWx1ZUVudHJ5LnByb3RvIrUBChVBYmls",
            "aXR5QXBwbGllZEFiaWxpdHkSJAoMYWJpbGl0eV9uYW1lGAEgASgLMg4uQWJp",
            "bGl0eVN0cmluZxIoChBhYmlsaXR5X292ZXJyaWRlGAIgASgLMg4uQWJpbGl0",
            "eVN0cmluZxIuCgxvdmVycmlkZV9tYXAYAyADKAsyGC5BYmlsaXR5U2NhbGFy",
            "VmFsdWVFbnRyeRIcChRpbnN0YW5jZWRfYWJpbGl0eV9pZBgEIAEoDUIYqgIV",
            "TGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.AbilityStringReflection.Descriptor, global::Lemonade.Net.Protocol.AbilityScalarValueEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.AbilityAppliedAbility), global::Lemonade.Net.Protocol.AbilityAppliedAbility.Parser, new[]{ "AbilityName", "AbilityOverride", "OverrideMap", "InstancedAbilityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityAppliedAbility : pb::IMessage<AbilityAppliedAbility>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityAppliedAbility> _parser = new pb::MessageParser<AbilityAppliedAbility>(() => new AbilityAppliedAbility());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityAppliedAbility> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.AbilityAppliedAbilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAppliedAbility() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAppliedAbility(AbilityAppliedAbility other) : this() {
      abilityName_ = other.abilityName_ != null ? other.abilityName_.Clone() : null;
      abilityOverride_ = other.abilityOverride_ != null ? other.abilityOverride_.Clone() : null;
      overrideMap_ = other.overrideMap_.Clone();
      instancedAbilityId_ = other.instancedAbilityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAppliedAbility Clone() {
      return new AbilityAppliedAbility(this);
    }

    /// <summary>Field number for the "ability_name" field.</summary>
    public const int AbilityNameFieldNumber = 1;
    private global::Lemonade.Net.Protocol.AbilityString abilityName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilityString AbilityName {
      get { return abilityName_; }
      set {
        abilityName_ = value;
      }
    }

    /// <summary>Field number for the "ability_override" field.</summary>
    public const int AbilityOverrideFieldNumber = 2;
    private global::Lemonade.Net.Protocol.AbilityString abilityOverride_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilityString AbilityOverride {
      get { return abilityOverride_; }
      set {
        abilityOverride_ = value;
      }
    }

    /// <summary>Field number for the "override_map" field.</summary>
    public const int OverrideMapFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.AbilityScalarValueEntry> _repeated_overrideMap_codec
        = pb::FieldCodec.ForMessage(26, global::Lemonade.Net.Protocol.AbilityScalarValueEntry.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.AbilityScalarValueEntry> overrideMap_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.AbilityScalarValueEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.AbilityScalarValueEntry> OverrideMap {
      get { return overrideMap_; }
    }

    /// <summary>Field number for the "instanced_ability_id" field.</summary>
    public const int InstancedAbilityIdFieldNumber = 4;
    private uint instancedAbilityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedAbilityId {
      get { return instancedAbilityId_; }
      set {
        instancedAbilityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityAppliedAbility);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityAppliedAbility other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AbilityName, other.AbilityName)) return false;
      if (!object.Equals(AbilityOverride, other.AbilityOverride)) return false;
      if(!overrideMap_.Equals(other.overrideMap_)) return false;
      if (InstancedAbilityId != other.InstancedAbilityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (abilityName_ != null) hash ^= AbilityName.GetHashCode();
      if (abilityOverride_ != null) hash ^= AbilityOverride.GetHashCode();
      hash ^= overrideMap_.GetHashCode();
      if (InstancedAbilityId != 0) hash ^= InstancedAbilityId.GetHashCode();
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
      if (abilityName_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AbilityName);
      }
      if (abilityOverride_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AbilityOverride);
      }
      overrideMap_.WriteTo(output, _repeated_overrideMap_codec);
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InstancedAbilityId);
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
      if (abilityName_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AbilityName);
      }
      if (abilityOverride_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AbilityOverride);
      }
      overrideMap_.WriteTo(ref output, _repeated_overrideMap_codec);
      if (InstancedAbilityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InstancedAbilityId);
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
      if (abilityName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityName);
      }
      if (abilityOverride_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityOverride);
      }
      size += overrideMap_.CalculateSize(_repeated_overrideMap_codec);
      if (InstancedAbilityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedAbilityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityAppliedAbility other) {
      if (other == null) {
        return;
      }
      if (other.abilityName_ != null) {
        if (abilityName_ == null) {
          AbilityName = new global::Lemonade.Net.Protocol.AbilityString();
        }
        AbilityName.MergeFrom(other.AbilityName);
      }
      if (other.abilityOverride_ != null) {
        if (abilityOverride_ == null) {
          AbilityOverride = new global::Lemonade.Net.Protocol.AbilityString();
        }
        AbilityOverride.MergeFrom(other.AbilityOverride);
      }
      overrideMap_.Add(other.overrideMap_);
      if (other.InstancedAbilityId != 0) {
        InstancedAbilityId = other.InstancedAbilityId;
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
          case 10: {
            if (abilityName_ == null) {
              AbilityName = new global::Lemonade.Net.Protocol.AbilityString();
            }
            input.ReadMessage(AbilityName);
            break;
          }
          case 18: {
            if (abilityOverride_ == null) {
              AbilityOverride = new global::Lemonade.Net.Protocol.AbilityString();
            }
            input.ReadMessage(AbilityOverride);
            break;
          }
          case 26: {
            overrideMap_.AddEntriesFrom(input, _repeated_overrideMap_codec);
            break;
          }
          case 32: {
            InstancedAbilityId = input.ReadUInt32();
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
          case 10: {
            if (abilityName_ == null) {
              AbilityName = new global::Lemonade.Net.Protocol.AbilityString();
            }
            input.ReadMessage(AbilityName);
            break;
          }
          case 18: {
            if (abilityOverride_ == null) {
              AbilityOverride = new global::Lemonade.Net.Protocol.AbilityString();
            }
            input.ReadMessage(AbilityOverride);
            break;
          }
          case 26: {
            overrideMap_.AddEntriesFrom(ref input, _repeated_overrideMap_codec);
            break;
          }
          case 32: {
            InstancedAbilityId = input.ReadUInt32();
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
