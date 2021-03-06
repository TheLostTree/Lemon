// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerStoreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerStoreNotify.proto</summary>
  public static partial class PlayerStoreNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerStoreNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerStoreNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQbGF5ZXJTdG9yZU5vdGlmeS5wcm90bxoPU3RvcmVUeXBlLnByb3RvGgpJ",
            "dGVtLnByb3RvIrIBChFQbGF5ZXJTdG9yZU5vdGlmeRIeCgpzdG9yZV90eXBl",
            "GAEgASgOMgouU3RvcmVUeXBlEhgKCWl0ZW1fbGlzdBgCIAMoCzIFLkl0ZW0S",
            "FAoMd2VpZ2h0X2xpbWl0GAMgASgNIk0KBUNtZElkEggKBE5PTkUQABITCg9F",
            "TkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAESCwoGQ01E",
            "X0lEEIkFGgIQAUIYqgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.StoreTypeReflection.Descriptor, global::Lemonade.Net.Protocol.ItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerStoreNotify), global::Lemonade.Net.Protocol.PlayerStoreNotify.Parser, new[]{ "StoreType", "ItemList", "WeightLimit" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.PlayerStoreNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerStoreNotify : pb::IMessage<PlayerStoreNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerStoreNotify> _parser = new pb::MessageParser<PlayerStoreNotify>(() => new PlayerStoreNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerStoreNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerStoreNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify(PlayerStoreNotify other) : this() {
      storeType_ = other.storeType_;
      itemList_ = other.itemList_.Clone();
      weightLimit_ = other.weightLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStoreNotify Clone() {
      return new PlayerStoreNotify(this);
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

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.Item> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(18, global::Lemonade.Net.Protocol.Item.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.Item> itemList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.Item>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.Item> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "weight_limit" field.</summary>
    public const int WeightLimitFieldNumber = 3;
    private uint weightLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeightLimit {
      get { return weightLimit_; }
      set {
        weightLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerStoreNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerStoreNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StoreType != other.StoreType) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (WeightLimit != other.WeightLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) hash ^= StoreType.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (WeightLimit != 0) hash ^= WeightLimit.GetHashCode();
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
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (WeightLimit != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(WeightLimit);
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
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StoreType);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (WeightLimit != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(WeightLimit);
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
      if (StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StoreType);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (WeightLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeightLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerStoreNotify other) {
      if (other == null) {
        return;
      }
      if (other.StoreType != global::Lemonade.Net.Protocol.StoreType.StoreNone) {
        StoreType = other.StoreType;
      }
      itemList_.Add(other.itemList_);
      if (other.WeightLimit != 0) {
        WeightLimit = other.WeightLimit;
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
            StoreType = (global::Lemonade.Net.Protocol.StoreType) input.ReadEnum();
            break;
          }
          case 18: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 24: {
            WeightLimit = input.ReadUInt32();
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
          case 18: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 24: {
            WeightLimit = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerStoreNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 649,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
