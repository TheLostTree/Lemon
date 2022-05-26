// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneAreaWeatherNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from SceneAreaWeatherNotify.proto</summary>
  public static partial class SceneAreaWeatherNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneAreaWeatherNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneAreaWeatherNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTY2VuZUFyZWFXZWF0aGVyTm90aWZ5LnByb3RvIsoCChZTY2VuZUFyZWFX",
            "ZWF0aGVyTm90aWZ5EhkKEXdlYXRoZXJfZ2FkZ2V0X2lkGAEgASgNEkcKEXdl",
            "YXRoZXJfdmFsdWVfbWFwGAIgAygLMiwuU2NlbmVBcmVhV2VhdGhlck5vdGlm",
            "eS5XZWF0aGVyVmFsdWVNYXBFbnRyeRIXCg93ZWF0aGVyX2FyZWFfaWQYAyAB",
            "KA0SFAoMY2xpbWF0ZV90eXBlGAQgASgNEhYKDnRyYW5zX2R1cmF0aW9uGAUg",
            "ASgCGjYKFFdlYXRoZXJWYWx1ZU1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2",
            "YWx1ZRgCIAEoCToCOAEiTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hB",
            "Tk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQ+wEa",
            "AhABQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.SceneAreaWeatherNotify), global::Lemonade.Net.Protocol.SceneAreaWeatherNotify.Parser, new[]{ "WeatherGadgetId", "WeatherValueMap", "WeatherAreaId", "ClimateType", "TransDuration" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.SceneAreaWeatherNotify.Types.CmdId) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneAreaWeatherNotify : pb::IMessage<SceneAreaWeatherNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneAreaWeatherNotify> _parser = new pb::MessageParser<SceneAreaWeatherNotify>(() => new SceneAreaWeatherNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneAreaWeatherNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.SceneAreaWeatherNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAreaWeatherNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAreaWeatherNotify(SceneAreaWeatherNotify other) : this() {
      weatherGadgetId_ = other.weatherGadgetId_;
      weatherValueMap_ = other.weatherValueMap_.Clone();
      weatherAreaId_ = other.weatherAreaId_;
      climateType_ = other.climateType_;
      transDuration_ = other.transDuration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAreaWeatherNotify Clone() {
      return new SceneAreaWeatherNotify(this);
    }

    /// <summary>Field number for the "weather_gadget_id" field.</summary>
    public const int WeatherGadgetIdFieldNumber = 1;
    private uint weatherGadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeatherGadgetId {
      get { return weatherGadgetId_; }
      set {
        weatherGadgetId_ = value;
      }
    }

    /// <summary>Field number for the "weather_value_map" field.</summary>
    public const int WeatherValueMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, string>.Codec _map_weatherValueMap_codec
        = new pbc::MapField<uint, string>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<uint, string> weatherValueMap_ = new pbc::MapField<uint, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, string> WeatherValueMap {
      get { return weatherValueMap_; }
    }

    /// <summary>Field number for the "weather_area_id" field.</summary>
    public const int WeatherAreaIdFieldNumber = 3;
    private uint weatherAreaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeatherAreaId {
      get { return weatherAreaId_; }
      set {
        weatherAreaId_ = value;
      }
    }

    /// <summary>Field number for the "climate_type" field.</summary>
    public const int ClimateTypeFieldNumber = 4;
    private uint climateType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClimateType {
      get { return climateType_; }
      set {
        climateType_ = value;
      }
    }

    /// <summary>Field number for the "trans_duration" field.</summary>
    public const int TransDurationFieldNumber = 5;
    private float transDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TransDuration {
      get { return transDuration_; }
      set {
        transDuration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneAreaWeatherNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneAreaWeatherNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WeatherGadgetId != other.WeatherGadgetId) return false;
      if (!WeatherValueMap.Equals(other.WeatherValueMap)) return false;
      if (WeatherAreaId != other.WeatherAreaId) return false;
      if (ClimateType != other.ClimateType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TransDuration, other.TransDuration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WeatherGadgetId != 0) hash ^= WeatherGadgetId.GetHashCode();
      hash ^= WeatherValueMap.GetHashCode();
      if (WeatherAreaId != 0) hash ^= WeatherAreaId.GetHashCode();
      if (ClimateType != 0) hash ^= ClimateType.GetHashCode();
      if (TransDuration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TransDuration);
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
      if (WeatherGadgetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WeatherGadgetId);
      }
      weatherValueMap_.WriteTo(output, _map_weatherValueMap_codec);
      if (WeatherAreaId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(WeatherAreaId);
      }
      if (ClimateType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ClimateType);
      }
      if (TransDuration != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(TransDuration);
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
      if (WeatherGadgetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WeatherGadgetId);
      }
      weatherValueMap_.WriteTo(ref output, _map_weatherValueMap_codec);
      if (WeatherAreaId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(WeatherAreaId);
      }
      if (ClimateType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ClimateType);
      }
      if (TransDuration != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(TransDuration);
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
      if (WeatherGadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeatherGadgetId);
      }
      size += weatherValueMap_.CalculateSize(_map_weatherValueMap_codec);
      if (WeatherAreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeatherAreaId);
      }
      if (ClimateType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClimateType);
      }
      if (TransDuration != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneAreaWeatherNotify other) {
      if (other == null) {
        return;
      }
      if (other.WeatherGadgetId != 0) {
        WeatherGadgetId = other.WeatherGadgetId;
      }
      weatherValueMap_.Add(other.weatherValueMap_);
      if (other.WeatherAreaId != 0) {
        WeatherAreaId = other.WeatherAreaId;
      }
      if (other.ClimateType != 0) {
        ClimateType = other.ClimateType;
      }
      if (other.TransDuration != 0F) {
        TransDuration = other.TransDuration;
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
            WeatherGadgetId = input.ReadUInt32();
            break;
          }
          case 18: {
            weatherValueMap_.AddEntriesFrom(input, _map_weatherValueMap_codec);
            break;
          }
          case 24: {
            WeatherAreaId = input.ReadUInt32();
            break;
          }
          case 32: {
            ClimateType = input.ReadUInt32();
            break;
          }
          case 45: {
            TransDuration = input.ReadFloat();
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
            WeatherGadgetId = input.ReadUInt32();
            break;
          }
          case 18: {
            weatherValueMap_.AddEntriesFrom(ref input, _map_weatherValueMap_codec);
            break;
          }
          case 24: {
            WeatherAreaId = input.ReadUInt32();
            break;
          }
          case 32: {
            ClimateType = input.ReadUInt32();
            break;
          }
          case 45: {
            TransDuration = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SceneAreaWeatherNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 251,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
