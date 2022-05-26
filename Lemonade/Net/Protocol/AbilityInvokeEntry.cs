// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityInvokeEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from AbilityInvokeEntry.proto</summary>
  public static partial class AbilityInvokeEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityInvokeEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityInvokeEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBYmlsaXR5SW52b2tlRW50cnkucHJvdG8aHEFiaWxpdHlJbnZva2VFbnRy",
            "eUhlYWQucHJvdG8aG0FiaWxpdHlJbnZva2VBcmd1bWVudC5wcm90bxoRRm9y",
            "d2FyZFR5cGUucHJvdG8i+AEKEkFiaWxpdHlJbnZva2VFbnRyeRIlCgRoZWFk",
            "GAEgASgLMhcuQWJpbGl0eUludm9rZUVudHJ5SGVhZBItCg1hcmd1bWVudF90",
            "eXBlGAIgASgOMhYuQWJpbGl0eUludm9rZUFyZ3VtZW50EhQKDGFiaWxpdHlf",
            "ZGF0YRgDIAEoDBIRCgllbnRpdHlfaWQYBCABKA0SIgoMZm9yd2FyZF90eXBl",
            "GAUgASgOMgwuRm9yd2FyZFR5cGUSFAoMZm9yd2FyZF9wZWVyGAYgASgNEhAK",
            "CGV2ZW50X2lkGAcgASgNEhcKD3RvdGFsX3RpY2tfdGltZRgIIAEoAUIYqgIV",
            "TGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.AbilityInvokeEntryHeadReflection.Descriptor, global::Lemonade.Net.Protocol.AbilityInvokeArgumentReflection.Descriptor, global::Lemonade.Net.Protocol.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.AbilityInvokeEntry), global::Lemonade.Net.Protocol.AbilityInvokeEntry.Parser, new[]{ "Head", "ArgumentType", "AbilityData", "EntityId", "ForwardType", "ForwardPeer", "EventId", "TotalTickTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityInvokeEntry : pb::IMessage<AbilityInvokeEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityInvokeEntry> _parser = new pb::MessageParser<AbilityInvokeEntry>(() => new AbilityInvokeEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityInvokeEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.AbilityInvokeEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry(AbilityInvokeEntry other) : this() {
      head_ = other.head_ != null ? other.head_.Clone() : null;
      argumentType_ = other.argumentType_;
      abilityData_ = other.abilityData_;
      entityId_ = other.entityId_;
      forwardType_ = other.forwardType_;
      forwardPeer_ = other.forwardPeer_;
      eventId_ = other.eventId_;
      totalTickTime_ = other.totalTickTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry Clone() {
      return new AbilityInvokeEntry(this);
    }

    /// <summary>Field number for the "head" field.</summary>
    public const int HeadFieldNumber = 1;
    private global::Lemonade.Net.Protocol.AbilityInvokeEntryHead head_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilityInvokeEntryHead Head {
      get { return head_; }
      set {
        head_ = value;
      }
    }

    /// <summary>Field number for the "argument_type" field.</summary>
    public const int ArgumentTypeFieldNumber = 2;
    private global::Lemonade.Net.Protocol.AbilityInvokeArgument argumentType_ = global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.AbilityInvokeArgument ArgumentType {
      get { return argumentType_; }
      set {
        argumentType_ = value;
      }
    }

    /// <summary>Field number for the "ability_data" field.</summary>
    public const int AbilityDataFieldNumber = 3;
    private pb::ByteString abilityData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString AbilityData {
      get { return abilityData_; }
      set {
        abilityData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 5;
    private global::Lemonade.Net.Protocol.ForwardType forwardType_ = global::Lemonade.Net.Protocol.ForwardType.ForwardLocal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "forward_peer" field.</summary>
    public const int ForwardPeerFieldNumber = 6;
    private uint forwardPeer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ForwardPeer {
      get { return forwardPeer_; }
      set {
        forwardPeer_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 7;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "total_tick_time" field.</summary>
    public const int TotalTickTimeFieldNumber = 8;
    private double totalTickTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double TotalTickTime {
      get { return totalTickTime_; }
      set {
        totalTickTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityInvokeEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityInvokeEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Head, other.Head)) return false;
      if (ArgumentType != other.ArgumentType) return false;
      if (AbilityData != other.AbilityData) return false;
      if (EntityId != other.EntityId) return false;
      if (ForwardType != other.ForwardType) return false;
      if (ForwardPeer != other.ForwardPeer) return false;
      if (EventId != other.EventId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalTickTime, other.TotalTickTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (head_ != null) hash ^= Head.GetHashCode();
      if (ArgumentType != global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone) hash ^= ArgumentType.GetHashCode();
      if (AbilityData.Length != 0) hash ^= AbilityData.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) hash ^= ForwardType.GetHashCode();
      if (ForwardPeer != 0) hash ^= ForwardPeer.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (TotalTickTime != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalTickTime);
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
      if (head_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Head);
      }
      if (ArgumentType != global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ArgumentType);
      }
      if (AbilityData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(AbilityData);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ForwardType);
      }
      if (ForwardPeer != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ForwardPeer);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      if (TotalTickTime != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(TotalTickTime);
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
      if (head_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Head);
      }
      if (ArgumentType != global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ArgumentType);
      }
      if (AbilityData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(AbilityData);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ForwardType);
      }
      if (ForwardPeer != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ForwardPeer);
      }
      if (EventId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EventId);
      }
      if (TotalTickTime != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(TotalTickTime);
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
      if (head_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Head);
      }
      if (ArgumentType != global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArgumentType);
      }
      if (AbilityData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(AbilityData);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (ForwardPeer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ForwardPeer);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (TotalTickTime != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityInvokeEntry other) {
      if (other == null) {
        return;
      }
      if (other.head_ != null) {
        if (head_ == null) {
          Head = new global::Lemonade.Net.Protocol.AbilityInvokeEntryHead();
        }
        Head.MergeFrom(other.Head);
      }
      if (other.ArgumentType != global::Lemonade.Net.Protocol.AbilityInvokeArgument.AbilityNone) {
        ArgumentType = other.ArgumentType;
      }
      if (other.AbilityData.Length != 0) {
        AbilityData = other.AbilityData;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        ForwardType = other.ForwardType;
      }
      if (other.ForwardPeer != 0) {
        ForwardPeer = other.ForwardPeer;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.TotalTickTime != 0D) {
        TotalTickTime = other.TotalTickTime;
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
            if (head_ == null) {
              Head = new global::Lemonade.Net.Protocol.AbilityInvokeEntryHead();
            }
            input.ReadMessage(Head);
            break;
          }
          case 16: {
            ArgumentType = (global::Lemonade.Net.Protocol.AbilityInvokeArgument) input.ReadEnum();
            break;
          }
          case 26: {
            AbilityData = input.ReadBytes();
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 48: {
            ForwardPeer = input.ReadUInt32();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 65: {
            TotalTickTime = input.ReadDouble();
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
            if (head_ == null) {
              Head = new global::Lemonade.Net.Protocol.AbilityInvokeEntryHead();
            }
            input.ReadMessage(Head);
            break;
          }
          case 16: {
            ArgumentType = (global::Lemonade.Net.Protocol.AbilityInvokeArgument) input.ReadEnum();
            break;
          }
          case 26: {
            AbilityData = input.ReadBytes();
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 48: {
            ForwardPeer = input.ReadUInt32();
            break;
          }
          case 56: {
            EventId = input.ReadUInt32();
            break;
          }
          case 65: {
            TotalTickTime = input.ReadDouble();
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