// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetClientParam.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from GadgetClientParam.proto</summary>
  public static partial class GadgetClientParamReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetClientParam.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetClientParamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWRnZXRDbGllbnRQYXJhbS5wcm90byKFAQoRR2FkZ2V0Q2xpZW50UGFy",
            "YW0SDgoGY2FtcElkGAEgASgNEhAKCGNhbXBUeXBlGAIgASgNEgwKBGd1aWQY",
            "AyABKAQSFQoNb3duZXJFbnRpdHlJZBgEIAEoDRIWCg50YXJnZXRFbnRpdHlJ",
            "ZBgFIAEoDRIRCglhc3luY0xvYWQYBiABKAhCGKoCFUxlbW9uYWRlLk5ldC5Q",
            "cm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.GadgetClientParam), global::Lemonade.Net.Protocol.GadgetClientParam.Parser, new[]{ "CampId", "CampType", "Guid", "OwnerEntityId", "TargetEntityId", "AsyncLoad" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GadgetClientParam : pb::IMessage<GadgetClientParam>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetClientParam> _parser = new pb::MessageParser<GadgetClientParam>(() => new GadgetClientParam());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetClientParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.GadgetClientParamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetClientParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetClientParam(GadgetClientParam other) : this() {
      campId_ = other.campId_;
      campType_ = other.campType_;
      guid_ = other.guid_;
      ownerEntityId_ = other.ownerEntityId_;
      targetEntityId_ = other.targetEntityId_;
      asyncLoad_ = other.asyncLoad_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetClientParam Clone() {
      return new GadgetClientParam(this);
    }

    /// <summary>Field number for the "campId" field.</summary>
    public const int CampIdFieldNumber = 1;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "campType" field.</summary>
    public const int CampTypeFieldNumber = 2;
    private uint campType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 3;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "ownerEntityId" field.</summary>
    public const int OwnerEntityIdFieldNumber = 4;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "targetEntityId" field.</summary>
    public const int TargetEntityIdFieldNumber = 5;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "asyncLoad" field.</summary>
    public const int AsyncLoadFieldNumber = 6;
    private bool asyncLoad_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AsyncLoad {
      get { return asyncLoad_; }
      set {
        asyncLoad_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetClientParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetClientParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CampId != other.CampId) return false;
      if (CampType != other.CampType) return false;
      if (Guid != other.Guid) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      if (AsyncLoad != other.AsyncLoad) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
      if (AsyncLoad != false) hash ^= AsyncLoad.GetHashCode();
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
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetEntityId);
      }
      if (AsyncLoad != false) {
        output.WriteRawTag(48);
        output.WriteBool(AsyncLoad);
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
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetEntityId);
      }
      if (AsyncLoad != false) {
        output.WriteRawTag(48);
        output.WriteBool(AsyncLoad);
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
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampType);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (AsyncLoad != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetClientParam other) {
      if (other == null) {
        return;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
      }
      if (other.AsyncLoad != false) {
        AsyncLoad = other.AsyncLoad;
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampType = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            AsyncLoad = input.ReadBool();
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampType = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            AsyncLoad = input.ReadBool();
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
