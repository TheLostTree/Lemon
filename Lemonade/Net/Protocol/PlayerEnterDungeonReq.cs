// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from PlayerEnterDungeonReq.proto</summary>
  public static partial class PlayerEnterDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEnterDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEnterDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJFbnRlckR1bmdlb25SZXEucHJvdG8iPQoVUGxheWVyRW50ZXJE",
            "dW5nZW9uUmVxEhAKCHBvaW50X2lkGAEgASgNEhIKCmR1bmdlb25faWQYAiAB",
            "KA1CGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.PlayerEnterDungeonReq), global::Lemonade.Net.Protocol.PlayerEnterDungeonReq.Parser, new[]{ "PointId", "DungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerEnterDungeonReq : pb::IMessage<PlayerEnterDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEnterDungeonReq> _parser = new pb::MessageParser<PlayerEnterDungeonReq>(() => new PlayerEnterDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEnterDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.PlayerEnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterDungeonReq(PlayerEnterDungeonReq other) : this() {
      pointId_ = other.pointId_;
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterDungeonReq Clone() {
      return new PlayerEnterDungeonReq(this);
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 1;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 2;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEnterDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEnterDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PointId != other.PointId) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PointId != 0) hash ^= PointId.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
      if (PointId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PointId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
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
      if (PointId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PointId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
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
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEnterDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
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
            PointId = input.ReadUInt32();
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
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
            PointId = input.ReadUInt32();
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
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
