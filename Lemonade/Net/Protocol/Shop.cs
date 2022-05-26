// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Shop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from Shop.proto</summary>
  public static partial class ShopReflection {

    #region Descriptor
    /// <summary>File descriptor for Shop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpTaG9wLnByb3RvGg9TaG9wR29vZHMucHJvdG8aFlNob3BNY29pblByb2R1",
            "Y3QucHJvdG8aFVNob3BDYXJkUHJvZHVjdC5wcm90bxoYU2hvcENvbmNlcnRQ",
            "cm9kdWN0LnByb3RvIpMCCgRTaG9wEhEKCXNob3BfdHlwZRgBIAEoDRIeCgpn",
            "b29kc19saXN0GAIgAygLMgouU2hvcEdvb2RzEi0KEm1jb2luX3Byb2R1Y3Rf",
            "bGlzdBgDIAMoCzIRLlNob3BNY29pblByb2R1Y3QSKwoRY2FyZF9wcm9kdWN0",
            "X2xpc3QYBCADKAsyEC5TaG9wQ2FyZFByb2R1Y3QSGQoRbmV4dF9yZWZyZXNo",
            "X3RpbWUYBiABKA0SDwoHY2l0eV9pZBgHIAEoDRIdChVjaXR5X3JlcHV0YXRp",
            "b25fbGV2ZWwYCCABKA0SMQoUY29uY2VydF9wcm9kdWN0X2xpc3QYCSADKAsy",
            "Ey5TaG9wQ29uY2VydFByb2R1Y3RCGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2Nv",
            "bGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ShopGoodsReflection.Descriptor, global::Lemonade.Net.Protocol.ShopMcoinProductReflection.Descriptor, global::Lemonade.Net.Protocol.ShopCardProductReflection.Descriptor, global::Lemonade.Net.Protocol.ShopConcertProductReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.Shop), global::Lemonade.Net.Protocol.Shop.Parser, new[]{ "ShopType", "GoodsList", "McoinProductList", "CardProductList", "NextRefreshTime", "CityId", "CityReputationLevel", "ConcertProductList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Shop : pb::IMessage<Shop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Shop> _parser = new pb::MessageParser<Shop>(() => new Shop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Shop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ShopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop(Shop other) : this() {
      shopType_ = other.shopType_;
      goodsList_ = other.goodsList_.Clone();
      mcoinProductList_ = other.mcoinProductList_.Clone();
      cardProductList_ = other.cardProductList_.Clone();
      nextRefreshTime_ = other.nextRefreshTime_;
      cityId_ = other.cityId_;
      cityReputationLevel_ = other.cityReputationLevel_;
      concertProductList_ = other.concertProductList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop Clone() {
      return new Shop(this);
    }

    /// <summary>Field number for the "shop_type" field.</summary>
    public const int ShopTypeFieldNumber = 1;
    private uint shopType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopType {
      get { return shopType_; }
      set {
        shopType_ = value;
      }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ShopGoods> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(18, global::Lemonade.Net.Protocol.ShopGoods.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopGoods> goodsList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopGoods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopGoods> GoodsList {
      get { return goodsList_; }
    }

    /// <summary>Field number for the "mcoin_product_list" field.</summary>
    public const int McoinProductListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ShopMcoinProduct> _repeated_mcoinProductList_codec
        = pb::FieldCodec.ForMessage(26, global::Lemonade.Net.Protocol.ShopMcoinProduct.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopMcoinProduct> mcoinProductList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopMcoinProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopMcoinProduct> McoinProductList {
      get { return mcoinProductList_; }
    }

    /// <summary>Field number for the "card_product_list" field.</summary>
    public const int CardProductListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ShopCardProduct> _repeated_cardProductList_codec
        = pb::FieldCodec.ForMessage(34, global::Lemonade.Net.Protocol.ShopCardProduct.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopCardProduct> cardProductList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopCardProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopCardProduct> CardProductList {
      get { return cardProductList_; }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 6;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 7;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    /// <summary>Field number for the "city_reputation_level" field.</summary>
    public const int CityReputationLevelFieldNumber = 8;
    private uint cityReputationLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityReputationLevel {
      get { return cityReputationLevel_; }
      set {
        cityReputationLevel_ = value;
      }
    }

    /// <summary>Field number for the "concert_product_list" field.</summary>
    public const int ConcertProductListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ShopConcertProduct> _repeated_concertProductList_codec
        = pb::FieldCodec.ForMessage(74, global::Lemonade.Net.Protocol.ShopConcertProduct.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopConcertProduct> concertProductList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopConcertProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ShopConcertProduct> ConcertProductList {
      get { return concertProductList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Shop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Shop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopType != other.ShopType) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      if(!mcoinProductList_.Equals(other.mcoinProductList_)) return false;
      if(!cardProductList_.Equals(other.cardProductList_)) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (CityId != other.CityId) return false;
      if (CityReputationLevel != other.CityReputationLevel) return false;
      if(!concertProductList_.Equals(other.concertProductList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopType != 0) hash ^= ShopType.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      hash ^= mcoinProductList_.GetHashCode();
      hash ^= cardProductList_.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (CityReputationLevel != 0) hash ^= CityReputationLevel.GetHashCode();
      hash ^= concertProductList_.GetHashCode();
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
      if (ShopType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ShopType);
      }
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      mcoinProductList_.WriteTo(output, _repeated_mcoinProductList_codec);
      cardProductList_.WriteTo(output, _repeated_cardProductList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextRefreshTime);
      }
      if (CityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CityId);
      }
      if (CityReputationLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(output, _repeated_concertProductList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ShopType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ShopType);
      }
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      mcoinProductList_.WriteTo(ref output, _repeated_mcoinProductList_codec);
      cardProductList_.WriteTo(ref output, _repeated_cardProductList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextRefreshTime);
      }
      if (CityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CityId);
      }
      if (CityReputationLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(ref output, _repeated_concertProductList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ShopType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
      }
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      size += mcoinProductList_.CalculateSize(_repeated_mcoinProductList_codec);
      size += cardProductList_.CalculateSize(_repeated_cardProductList_codec);
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (CityReputationLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityReputationLevel);
      }
      size += concertProductList_.CalculateSize(_repeated_concertProductList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Shop other) {
      if (other == null) {
        return;
      }
      if (other.ShopType != 0) {
        ShopType = other.ShopType;
      }
      goodsList_.Add(other.goodsList_);
      mcoinProductList_.Add(other.mcoinProductList_);
      cardProductList_.Add(other.cardProductList_);
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.CityReputationLevel != 0) {
        CityReputationLevel = other.CityReputationLevel;
      }
      concertProductList_.Add(other.concertProductList_);
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 18: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
            break;
          }
          case 26: {
            mcoinProductList_.AddEntriesFrom(input, _repeated_mcoinProductList_codec);
            break;
          }
          case 34: {
            cardProductList_.AddEntriesFrom(input, _repeated_cardProductList_codec);
            break;
          }
          case 48: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 56: {
            CityId = input.ReadUInt32();
            break;
          }
          case 64: {
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            concertProductList_.AddEntriesFrom(input, _repeated_concertProductList_codec);
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 18: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
            break;
          }
          case 26: {
            mcoinProductList_.AddEntriesFrom(ref input, _repeated_mcoinProductList_codec);
            break;
          }
          case 34: {
            cardProductList_.AddEntriesFrom(ref input, _repeated_cardProductList_codec);
            break;
          }
          case 48: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 56: {
            CityId = input.ReadUInt32();
            break;
          }
          case 64: {
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            concertProductList_.AddEntriesFrom(ref input, _repeated_concertProductList_codec);
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
