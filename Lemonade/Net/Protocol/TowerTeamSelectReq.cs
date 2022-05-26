// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerTeamSelectReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerTeamSelectReq.proto</summary>
  public static partial class TowerTeamSelectReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerTeamSelectReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerTeamSelectReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhUb3dlclRlYW1TZWxlY3RSZXEucHJvdG8aD1Rvd2VyVGVhbS5wcm90byKv",
            "AQoSVG93ZXJUZWFtU2VsZWN0UmVxEhAKCGZsb29yX2lkGAEgASgNEiMKD3Rv",
            "d2VyX3RlYW1fbGlzdBgCIAMoCzIKLlRvd2VyVGVhbSJiCgVDbWRJZBITCg9F",
            "TkVUX0NIQU5ORUxfSUQQABIICgROT05FEAASFAoQRU5FVF9JU19SRUxJQUJM",
            "RRABEhMKD0lTX0FMTE9XX0NMSUVOVBABEgsKBkNNRF9JRBDhEhoCEAFCGKoC",
            "FUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.TowerTeamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerTeamSelectReq), global::Lemonade.Net.Protocol.TowerTeamSelectReq.Parser, new[]{ "FloorId", "TowerTeamList" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.TowerTeamSelectReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerTeamSelectReq : pb::IMessage<TowerTeamSelectReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerTeamSelectReq> _parser = new pb::MessageParser<TowerTeamSelectReq>(() => new TowerTeamSelectReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerTeamSelectReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerTeamSelectReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerTeamSelectReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerTeamSelectReq(TowerTeamSelectReq other) : this() {
      floorId_ = other.floorId_;
      towerTeamList_ = other.towerTeamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerTeamSelectReq Clone() {
      return new TowerTeamSelectReq(this);
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 1;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "tower_team_list" field.</summary>
    public const int TowerTeamListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.TowerTeam> _repeated_towerTeamList_codec
        = pb::FieldCodec.ForMessage(18, global::Lemonade.Net.Protocol.TowerTeam.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerTeam> towerTeamList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerTeam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerTeam> TowerTeamList {
      get { return towerTeamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerTeamSelectReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerTeamSelectReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FloorId != other.FloorId) return false;
      if(!towerTeamList_.Equals(other.towerTeamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      hash ^= towerTeamList_.GetHashCode();
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
      if (FloorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FloorId);
      }
      towerTeamList_.WriteTo(output, _repeated_towerTeamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FloorId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FloorId);
      }
      towerTeamList_.WriteTo(ref output, _repeated_towerTeamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      size += towerTeamList_.CalculateSize(_repeated_towerTeamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerTeamSelectReq other) {
      if (other == null) {
        return;
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      towerTeamList_.Add(other.towerTeamList_);
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
            FloorId = input.ReadUInt32();
            break;
          }
          case 18: {
            towerTeamList_.AddEntriesFrom(input, _repeated_towerTeamList_codec);
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
            FloorId = input.ReadUInt32();
            break;
          }
          case 18: {
            towerTeamList_.AddEntriesFrom(ref input, _repeated_towerTeamList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerTeamSelectReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2401,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code