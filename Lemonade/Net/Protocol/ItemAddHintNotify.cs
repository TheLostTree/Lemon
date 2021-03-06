// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ItemAddHintNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ItemAddHintNotify.proto</summary>
  public static partial class ItemAddHintNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ItemAddHintNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemAddHintNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdJdGVtQWRkSGludE5vdGlmeS5wcm90bxoMVmVjdG9yLnByb3RvGg5JdGVt",
            "SGludC5wcm90byLUAgoRSXRlbUFkZEhpbnROb3RpZnkSHAoJaXRlbV9saXN0",
            "GAEgAygLMgkuSXRlbUhpbnQSGQoIcG9zaXRpb24YAiABKAsyBy5WZWN0b3IS",
            "GQoRaXNfcG9zaXRpb25fdmFsaWQYAyABKAgSDgoGcmVhc29uGAQgASgNEhAK",
            "CHF1ZXN0X2lkGAUgASgNEiYKHmlzX3RyYW5zZmVyZWRfZnJvbV9hdmF0YXJf",
            "Y2FyZBgGIAEoCBIxCh5vdmVyZmxvd190cmFuc2Zvcm1lZF9pdGVtX2xpc3QY",
            "ByADKAsyCS5JdGVtSGludBIfChdpc19nZW5lcmFsX3Jld2FyZF9oaWRlbhgI",
            "IAEoCCJNCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAAS",
            "FAoQRU5FVF9JU19SRUxJQUJMRRABEgsKBkNNRF9JRBC8BRoCEAFCGKoCFUxl",
            "bW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, global::Lemonade.Net.Protocol.ItemHintReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ItemAddHintNotify), global::Lemonade.Net.Protocol.ItemAddHintNotify.Parser, new[]{ "ItemList", "Position", "IsPositionValid", "Reason", "QuestId", "IsTransferedFromAvatarCard", "OverflowTransformedItemList", "IsGeneralRewardHiden" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.ItemAddHintNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ItemAddHintNotify : pb::IMessage<ItemAddHintNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ItemAddHintNotify> _parser = new pb::MessageParser<ItemAddHintNotify>(() => new ItemAddHintNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ItemAddHintNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ItemAddHintNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify(ItemAddHintNotify other) : this() {
      itemList_ = other.itemList_.Clone();
      position_ = other.position_ != null ? other.position_.Clone() : null;
      isPositionValid_ = other.isPositionValid_;
      reason_ = other.reason_;
      questId_ = other.questId_;
      isTransferedFromAvatarCard_ = other.isTransferedFromAvatarCard_;
      overflowTransformedItemList_ = other.overflowTransformedItemList_.Clone();
      isGeneralRewardHiden_ = other.isGeneralRewardHiden_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify Clone() {
      return new ItemAddHintNotify(this);
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ItemHint> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(10, global::Lemonade.Net.Protocol.ItemHint.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint> itemList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 2;
    private global::Lemonade.Net.Protocol.Vector position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "is_position_valid" field.</summary>
    public const int IsPositionValidFieldNumber = 3;
    private bool isPositionValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPositionValid {
      get { return isPositionValid_; }
      set {
        isPositionValid_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private uint reason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 5;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "is_transfered_from_avatar_card" field.</summary>
    public const int IsTransferedFromAvatarCardFieldNumber = 6;
    private bool isTransferedFromAvatarCard_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTransferedFromAvatarCard {
      get { return isTransferedFromAvatarCard_; }
      set {
        isTransferedFromAvatarCard_ = value;
      }
    }

    /// <summary>Field number for the "overflow_transformed_item_list" field.</summary>
    public const int OverflowTransformedItemListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ItemHint> _repeated_overflowTransformedItemList_codec
        = pb::FieldCodec.ForMessage(58, global::Lemonade.Net.Protocol.ItemHint.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint> overflowTransformedItemList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemHint> OverflowTransformedItemList {
      get { return overflowTransformedItemList_; }
    }

    /// <summary>Field number for the "is_general_reward_hiden" field.</summary>
    public const int IsGeneralRewardHidenFieldNumber = 8;
    private bool isGeneralRewardHiden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGeneralRewardHiden {
      get { return isGeneralRewardHiden_; }
      set {
        isGeneralRewardHiden_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ItemAddHintNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ItemAddHintNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemList_.Equals(other.itemList_)) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (IsPositionValid != other.IsPositionValid) return false;
      if (Reason != other.Reason) return false;
      if (QuestId != other.QuestId) return false;
      if (IsTransferedFromAvatarCard != other.IsTransferedFromAvatarCard) return false;
      if(!overflowTransformedItemList_.Equals(other.overflowTransformedItemList_)) return false;
      if (IsGeneralRewardHiden != other.IsGeneralRewardHiden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemList_.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (IsPositionValid != false) hash ^= IsPositionValid.GetHashCode();
      if (Reason != 0) hash ^= Reason.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      if (IsTransferedFromAvatarCard != false) hash ^= IsTransferedFromAvatarCard.GetHashCode();
      hash ^= overflowTransformedItemList_.GetHashCode();
      if (IsGeneralRewardHiden != false) hash ^= IsGeneralRewardHiden.GetHashCode();
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
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (IsPositionValid != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsPositionValid);
      }
      if (Reason != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Reason);
      }
      if (QuestId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QuestId);
      }
      if (IsTransferedFromAvatarCard != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTransferedFromAvatarCard);
      }
      overflowTransformedItemList_.WriteTo(output, _repeated_overflowTransformedItemList_codec);
      if (IsGeneralRewardHiden != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsGeneralRewardHiden);
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
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (position_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Position);
      }
      if (IsPositionValid != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsPositionValid);
      }
      if (Reason != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Reason);
      }
      if (QuestId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QuestId);
      }
      if (IsTransferedFromAvatarCard != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTransferedFromAvatarCard);
      }
      overflowTransformedItemList_.WriteTo(ref output, _repeated_overflowTransformedItemList_codec);
      if (IsGeneralRewardHiden != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsGeneralRewardHiden);
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
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (IsPositionValid != false) {
        size += 1 + 1;
      }
      if (Reason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Reason);
      }
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (IsTransferedFromAvatarCard != false) {
        size += 1 + 1;
      }
      size += overflowTransformedItemList_.CalculateSize(_repeated_overflowTransformedItemList_codec);
      if (IsGeneralRewardHiden != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ItemAddHintNotify other) {
      if (other == null) {
        return;
      }
      itemList_.Add(other.itemList_);
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Lemonade.Net.Protocol.Vector();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.IsPositionValid != false) {
        IsPositionValid = other.IsPositionValid;
      }
      if (other.Reason != 0) {
        Reason = other.Reason;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      if (other.IsTransferedFromAvatarCard != false) {
        IsTransferedFromAvatarCard = other.IsTransferedFromAvatarCard;
      }
      overflowTransformedItemList_.Add(other.overflowTransformedItemList_);
      if (other.IsGeneralRewardHiden != false) {
        IsGeneralRewardHiden = other.IsGeneralRewardHiden;
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
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 24: {
            IsPositionValid = input.ReadBool();
            break;
          }
          case 32: {
            Reason = input.ReadUInt32();
            break;
          }
          case 40: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsTransferedFromAvatarCard = input.ReadBool();
            break;
          }
          case 58: {
            overflowTransformedItemList_.AddEntriesFrom(input, _repeated_overflowTransformedItemList_codec);
            break;
          }
          case 64: {
            IsGeneralRewardHiden = input.ReadBool();
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
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 18: {
            if (position_ == null) {
              Position = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 24: {
            IsPositionValid = input.ReadBool();
            break;
          }
          case 32: {
            Reason = input.ReadUInt32();
            break;
          }
          case 40: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsTransferedFromAvatarCard = input.ReadBool();
            break;
          }
          case 58: {
            overflowTransformedItemList_.AddEntriesFrom(ref input, _repeated_overflowTransformedItemList_codec);
            break;
          }
          case 64: {
            IsGeneralRewardHiden = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ItemAddHintNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 700,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
