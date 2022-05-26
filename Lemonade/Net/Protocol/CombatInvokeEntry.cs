// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CombatInvokeEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from CombatInvokeEntry.proto</summary>
  public static partial class CombatInvokeEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for CombatInvokeEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatInvokeEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDb21iYXRJbnZva2VFbnRyeS5wcm90bxoYQ29tYmF0VHlwZUFyZ3VtZW50",
            "LnByb3RvGhFGb3J3YXJkVHlwZS5wcm90byJ4ChFDb21iYXRJbnZva2VFbnRy",
            "eRIqCg1hcmd1bWVudF90eXBlGAEgASgOMhMuQ29tYmF0VHlwZUFyZ3VtZW50",
            "EiIKDGZvcndhcmRfdHlwZRgCIAEoDjIMLkZvcndhcmRUeXBlEhMKC2NvbWJh",
            "dF9kYXRhGAMgASgMQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.CombatTypeArgumentReflection.Descriptor, global::Lemonade.Net.Protocol.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.CombatInvokeEntry), global::Lemonade.Net.Protocol.CombatInvokeEntry.Parser, new[]{ "ArgumentType", "ForwardType", "CombatData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CombatInvokeEntry : pb::IMessage<CombatInvokeEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CombatInvokeEntry> _parser = new pb::MessageParser<CombatInvokeEntry>(() => new CombatInvokeEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CombatInvokeEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.CombatInvokeEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry(CombatInvokeEntry other) : this() {
      argumentType_ = other.argumentType_;
      forwardType_ = other.forwardType_;
      combatData_ = other.combatData_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CombatInvokeEntry Clone() {
      return new CombatInvokeEntry(this);
    }

    /// <summary>Field number for the "argument_type" field.</summary>
    public const int ArgumentTypeFieldNumber = 1;
    private global::Lemonade.Net.Protocol.CombatTypeArgument argumentType_ = global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.CombatTypeArgument ArgumentType {
      get { return argumentType_; }
      set {
        argumentType_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 2;
    private global::Lemonade.Net.Protocol.ForwardType forwardType_ = global::Lemonade.Net.Protocol.ForwardType.ForwardLocal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "combat_data" field.</summary>
    public const int CombatDataFieldNumber = 3;
    private pb::ByteString combatData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString CombatData {
      get { return combatData_; }
      set {
        combatData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CombatInvokeEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CombatInvokeEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ArgumentType != other.ArgumentType) return false;
      if (ForwardType != other.ForwardType) return false;
      if (CombatData != other.CombatData) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ArgumentType != global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone) hash ^= ArgumentType.GetHashCode();
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) hash ^= ForwardType.GetHashCode();
      if (CombatData.Length != 0) hash ^= CombatData.GetHashCode();
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
      if (ArgumentType != global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ArgumentType);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ForwardType);
      }
      if (CombatData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(CombatData);
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
      if (ArgumentType != global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ArgumentType);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ForwardType);
      }
      if (CombatData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(CombatData);
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
      if (ArgumentType != global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArgumentType);
      }
      if (ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (CombatData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(CombatData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CombatInvokeEntry other) {
      if (other == null) {
        return;
      }
      if (other.ArgumentType != global::Lemonade.Net.Protocol.CombatTypeArgument.CombatNone) {
        ArgumentType = other.ArgumentType;
      }
      if (other.ForwardType != global::Lemonade.Net.Protocol.ForwardType.ForwardLocal) {
        ForwardType = other.ForwardType;
      }
      if (other.CombatData.Length != 0) {
        CombatData = other.CombatData;
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
            ArgumentType = (global::Lemonade.Net.Protocol.CombatTypeArgument) input.ReadEnum();
            break;
          }
          case 16: {
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 26: {
            CombatData = input.ReadBytes();
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
            ArgumentType = (global::Lemonade.Net.Protocol.CombatTypeArgument) input.ReadEnum();
            break;
          }
          case 16: {
            ForwardType = (global::Lemonade.Net.Protocol.ForwardType) input.ReadEnum();
            break;
          }
          case 26: {
            CombatData = input.ReadBytes();
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
