// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoreItemDelNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from StoreItemDelNotify.proto</summary>
  public static partial class StoreItemDelNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StoreItemDelNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreItemDelNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTdG9yZUl0ZW1EZWxOb3RpZnkucHJvdG8aD1N0b3JlVHlwZS5wcm90byKW",
            "AQoSU3RvcmVJdGVtRGVsTm90aWZ5Eh4KCnN0b3JlX3R5cGUYASABKA4yCi5T",
            "dG9yZVR5cGUSEQoJZ3VpZF9saXN0GAIgAygEIk0KBUNtZElkEggKBE5PTkUQ",
            "ABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAES",
            "CwoGQ01EX0lEEKwFGgIQAUIYqgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.StoreTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.StoreItemDelNotify), global::Lemonade.Net.Protocol.StoreItemDelNotify.Parser, new[]{ "StoreType", "GuidList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.StoreItemDelNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoreItemDelNotify : pb::IMessage<StoreItemDelNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StoreItemDelNotify> _parser = new pb::MessageParser<StoreItemDelNotify>(() => new StoreItemDelNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StoreItemDelNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.StoreItemDelNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreItemDelNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreItemDelNotify(StoreItemDelNotify other) : this() {
      storeType_ = other.storeType_;
      guidList_ = other.guidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreItemDelNotify Clone() {
      return new StoreItemDelNotify(this);
    }

    /// <summary>Field number for the "store_type" field.</summary>
    public const int StoreTypeFieldNumber = 1;
    private global::Lemonade.Net.Protocol.StoreType storeType_ = global::Lemonade.Net.Protocol.StoreType.StoreNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.StoreType StoreType {
      get { return storeType_; }
      set {
        storeType_ = value;
      }
    }

    /// <summary>Field number for the "guid_list" field.</summary>
    public const int GuidListFieldNumber = 2;
    private static readonly pb::FieldCodec<ulong> _repeated_guidList_codec
        = pb::FieldCodec.ForUInt64(18);
    private readonly pbc::RepeatedField<ulong> guidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> GuidList {
      get { return guidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StoreItemDelNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StoreItemDelNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StoreType != other.StoreType) return false;
      if(!guidList_.Equals(other.guidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) hash ^= StoreType.GetHashCode();
      hash ^= guidList_.GetHashCode();
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
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StoreType);
      }
      guidList_.WriteTo(output, _repeated_guidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StoreType);
      }
      guidList_.WriteTo(ref output, _repeated_guidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StoreType);
      }
      size += guidList_.CalculateSize(_repeated_guidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StoreItemDelNotify other) {
      if (other == null) {
        return;
      }
      if (other.StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        StoreType = other.StoreType;
      }
      guidList_.Add(other.guidList_);
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
            StoreType = (global::Lemonade.Net.Protocol.StoreType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            guidList_.AddEntriesFrom(input, _repeated_guidList_codec);
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
            StoreType = (global::Lemonade.Net.Protocol.StoreType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            guidList_.AddEntriesFrom(ref input, _repeated_guidList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the StoreItemDelNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 684,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
