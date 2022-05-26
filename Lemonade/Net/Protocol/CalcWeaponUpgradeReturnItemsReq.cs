// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CalcWeaponUpgradeReturnItemsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from CalcWeaponUpgradeReturnItemsReq.proto</summary>
  public static partial class CalcWeaponUpgradeReturnItemsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for CalcWeaponUpgradeReturnItemsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalcWeaponUpgradeReturnItemsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVDYWxjV2VhcG9uVXBncmFkZVJldHVybkl0ZW1zUmVxLnByb3RvGg9JdGVt",
            "UGFyYW0ucHJvdG8i5QEKH0NhbGNXZWFwb25VcGdyYWRlUmV0dXJuSXRlbXNS",
            "ZXESGgoSdGFyZ2V0X3dlYXBvbl9ndWlkGAEgASgEEh0KFWZvb2Rfd2VhcG9u",
            "X2d1aWRfbGlzdBgCIAMoBBIjCg9pdGVtX3BhcmFtX2xpc3QYAyADKAsyCi5J",
            "dGVtUGFyYW0iYgoFQ21kSWQSEwoPRU5FVF9DSEFOTkVMX0lEEAASCAoETk9O",
            "RRAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQ",
            "ARILCgZDTURfSUQQnQUaAhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.CalcWeaponUpgradeReturnItemsReq), global::Lemonade.Net.Protocol.CalcWeaponUpgradeReturnItemsReq.Parser, new[]{ "TargetWeaponGuid", "FoodWeaponGuidList", "ItemParamList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.CalcWeaponUpgradeReturnItemsReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CalcWeaponUpgradeReturnItemsReq : pb::IMessage<CalcWeaponUpgradeReturnItemsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CalcWeaponUpgradeReturnItemsReq> _parser = new pb::MessageParser<CalcWeaponUpgradeReturnItemsReq>(() => new CalcWeaponUpgradeReturnItemsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CalcWeaponUpgradeReturnItemsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.CalcWeaponUpgradeReturnItemsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq(CalcWeaponUpgradeReturnItemsReq other) : this() {
      targetWeaponGuid_ = other.targetWeaponGuid_;
      foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
      itemParamList_ = other.itemParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq Clone() {
      return new CalcWeaponUpgradeReturnItemsReq(this);
    }

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 1;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
    public const int FoodWeaponGuidListFieldNumber = 2;
    private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
        = pb::FieldCodec.ForUInt64(18);
    private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> FoodWeaponGuidList {
      get { return foodWeaponGuidList_; }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(26, global::Lemonade.Net.Protocol.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam> itemParamList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CalcWeaponUpgradeReturnItemsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CalcWeaponUpgradeReturnItemsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
      hash ^= foodWeaponGuidList_.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
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
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TargetWeaponGuid);
      }
      foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TargetWeaponGuid);
      }
      foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      size += foodWeaponGuidList_.CalculateSize(_repeated_foodWeaponGuidList_codec);
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CalcWeaponUpgradeReturnItemsReq other) {
      if (other == null) {
        return;
      }
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
      }
      foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
      itemParamList_.Add(other.itemParamList_);
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
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 18:
          case 16: {
            foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 26: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
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
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 18:
          case 16: {
            foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 26: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CalcWeaponUpgradeReturnItemsReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 669,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
