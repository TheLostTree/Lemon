// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VehicleLocationInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from VehicleLocationInfo.proto</summary>
  public static partial class VehicleLocationInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VehicleLocationInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleLocationInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlWZWhpY2xlTG9jYXRpb25JbmZvLnByb3RvGgxWZWN0b3IucHJvdG8irAEK",
            "E1ZlaGljbGVMb2NhdGlvbkluZm8SEQoJZW50aXR5X2lkGAEgASgNEhEKCWdh",
            "ZGdldF9pZBgCIAEoDRIRCglvd25lcl91aWQYAyABKA0SFAoDcG9zGAQgASgL",
            "MgcuVmVjdG9yEhQKA3JvdBgFIAEoCzIHLlZlY3RvchIOCgZjdXJfaHAYBiAB",
            "KAISDgoGbWF4X2hwGAcgASgCEhAKCHVpZF9saXN0GAggAygNQhiqAhVMZW1v",
            "bmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.VehicleLocationInfo), global::Lemonade.Net.Protocol.VehicleLocationInfo.Parser, new[]{ "EntityId", "GadgetId", "OwnerUid", "Pos", "Rot", "CurHp", "MaxHp", "UidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VehicleLocationInfo : pb::IMessage<VehicleLocationInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VehicleLocationInfo> _parser = new pb::MessageParser<VehicleLocationInfo>(() => new VehicleLocationInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VehicleLocationInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.VehicleLocationInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleLocationInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleLocationInfo(VehicleLocationInfo other) : this() {
      entityId_ = other.entityId_;
      gadgetId_ = other.gadgetId_;
      ownerUid_ = other.ownerUid_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      curHp_ = other.curHp_;
      maxHp_ = other.maxHp_;
      uidList_ = other.uidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleLocationInfo Clone() {
      return new VehicleLocationInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 2;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "owner_uid" field.</summary>
    public const int OwnerUidFieldNumber = 3;
    private uint ownerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerUid {
      get { return ownerUid_; }
      set {
        ownerUid_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 4;
    private global::Lemonade.Net.Protocol.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 5;
    private global::Lemonade.Net.Protocol.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    /// <summary>Field number for the "cur_hp" field.</summary>
    public const int CurHpFieldNumber = 6;
    private float curHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CurHp {
      get { return curHp_; }
      set {
        curHp_ = value;
      }
    }

    /// <summary>Field number for the "max_hp" field.</summary>
    public const int MaxHpFieldNumber = 7;
    private float maxHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MaxHp {
      get { return maxHp_; }
      set {
        maxHp_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VehicleLocationInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VehicleLocationInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (GadgetId != other.GadgetId) return false;
      if (OwnerUid != other.OwnerUid) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CurHp, other.CurHp)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxHp, other.MaxHp)) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
      if (CurHp != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CurHp);
      if (MaxHp != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxHp);
      hash ^= uidList_.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetId);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerUid);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (rot_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Rot);
      }
      if (CurHp != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(CurHp);
      }
      if (MaxHp != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(MaxHp);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GadgetId);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerUid);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (rot_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Rot);
      }
      if (CurHp != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(CurHp);
      }
      if (MaxHp != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(MaxHp);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (OwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      if (CurHp != 0F) {
        size += 1 + 4;
      }
      if (MaxHp != 0F) {
        size += 1 + 4;
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VehicleLocationInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.OwnerUid != 0) {
        OwnerUid = other.OwnerUid;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Lemonade.Net.Protocol.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::Lemonade.Net.Protocol.Vector();
        }
        Rot.MergeFrom(other.Rot);
      }
      if (other.CurHp != 0F) {
        CurHp = other.CurHp;
      }
      if (other.MaxHp != 0F) {
        MaxHp = other.MaxHp;
      }
      uidList_.Add(other.uidList_);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 42: {
            if (rot_ == null) {
              Rot = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 53: {
            CurHp = input.ReadFloat();
            break;
          }
          case 61: {
            MaxHp = input.ReadFloat();
            break;
          }
          case 66:
          case 64: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 42: {
            if (rot_ == null) {
              Rot = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 53: {
            CurHp = input.ReadFloat();
            break;
          }
          case 61: {
            MaxHp = input.ReadFloat();
            break;
          }
          case 66:
          case 64: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
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
