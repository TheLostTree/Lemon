// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HitCollision.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from HitCollision.proto</summary>
  public static partial class HitCollisionReflection {

    #region Descriptor
    /// <summary>File descriptor for HitCollision.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HitCollisionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJIaXRDb2xsaXNpb24ucHJvdG8aFUhpdENvbGxpZGVyVHlwZS5wcm90bxoM",
            "VmVjdG9yLnByb3RvIs0BCgxIaXRDb2xsaXNpb24SKwoRaGl0X2NvbGxpZGVy",
            "X3R5cGUYASABKA4yEC5IaXRDb2xsaWRlclR5cGUSFQoNaGl0X2JveF9pbmRl",
            "eBgCIAEoBRIaCgloaXRfcG9pbnQYAyABKAsyBy5WZWN0b3ISGAoHaGl0X2Rp",
            "chgEIAEoCzIHLlZlY3RvchIgChhhdHRhY2tlZV9oaXRfZm9yY2VfYW5nbGUY",
            "BSABKAISIQoZYXR0YWNrZWVfaGl0X2VudGl0eV9hbmdsZRgGIAEoAkIYqgIV",
            "TGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.HitColliderTypeReflection.Descriptor, global::Lemonade.Net.Protocol.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.HitCollision), global::Lemonade.Net.Protocol.HitCollision.Parser, new[]{ "HitColliderType", "HitBoxIndex", "HitPoint", "HitDir", "AttackeeHitForceAngle", "AttackeeHitEntityAngle" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HitCollision : pb::IMessage<HitCollision>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HitCollision> _parser = new pb::MessageParser<HitCollision>(() => new HitCollision());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HitCollision> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.HitCollisionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision(HitCollision other) : this() {
      hitColliderType_ = other.hitColliderType_;
      hitBoxIndex_ = other.hitBoxIndex_;
      hitPoint_ = other.hitPoint_ != null ? other.hitPoint_.Clone() : null;
      hitDir_ = other.hitDir_ != null ? other.hitDir_.Clone() : null;
      attackeeHitForceAngle_ = other.attackeeHitForceAngle_;
      attackeeHitEntityAngle_ = other.attackeeHitEntityAngle_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision Clone() {
      return new HitCollision(this);
    }

    /// <summary>Field number for the "hit_collider_type" field.</summary>
    public const int HitColliderTypeFieldNumber = 1;
    private global::Lemonade.Net.Protocol.HitColliderType hitColliderType_ = global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.HitColliderType HitColliderType {
      get { return hitColliderType_; }
      set {
        hitColliderType_ = value;
      }
    }

    /// <summary>Field number for the "hit_box_index" field.</summary>
    public const int HitBoxIndexFieldNumber = 2;
    private int hitBoxIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HitBoxIndex {
      get { return hitBoxIndex_; }
      set {
        hitBoxIndex_ = value;
      }
    }

    /// <summary>Field number for the "hit_point" field.</summary>
    public const int HitPointFieldNumber = 3;
    private global::Lemonade.Net.Protocol.Vector hitPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector HitPoint {
      get { return hitPoint_; }
      set {
        hitPoint_ = value;
      }
    }

    /// <summary>Field number for the "hit_dir" field.</summary>
    public const int HitDirFieldNumber = 4;
    private global::Lemonade.Net.Protocol.Vector hitDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.Vector HitDir {
      get { return hitDir_; }
      set {
        hitDir_ = value;
      }
    }

    /// <summary>Field number for the "attackee_hit_force_angle" field.</summary>
    public const int AttackeeHitForceAngleFieldNumber = 5;
    private float attackeeHitForceAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AttackeeHitForceAngle {
      get { return attackeeHitForceAngle_; }
      set {
        attackeeHitForceAngle_ = value;
      }
    }

    /// <summary>Field number for the "attackee_hit_entity_angle" field.</summary>
    public const int AttackeeHitEntityAngleFieldNumber = 6;
    private float attackeeHitEntityAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AttackeeHitEntityAngle {
      get { return attackeeHitEntityAngle_; }
      set {
        attackeeHitEntityAngle_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HitCollision);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HitCollision other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HitColliderType != other.HitColliderType) return false;
      if (HitBoxIndex != other.HitBoxIndex) return false;
      if (!object.Equals(HitPoint, other.HitPoint)) return false;
      if (!object.Equals(HitDir, other.HitDir)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackeeHitForceAngle, other.AttackeeHitForceAngle)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackeeHitEntityAngle, other.AttackeeHitEntityAngle)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HitColliderType != global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid) hash ^= HitColliderType.GetHashCode();
      if (HitBoxIndex != 0) hash ^= HitBoxIndex.GetHashCode();
      if (hitPoint_ != null) hash ^= HitPoint.GetHashCode();
      if (hitDir_ != null) hash ^= HitDir.GetHashCode();
      if (AttackeeHitForceAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackeeHitForceAngle);
      if (AttackeeHitEntityAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackeeHitEntityAngle);
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
      if (HitColliderType != global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) HitColliderType);
      }
      if (HitBoxIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(HitBoxIndex);
      }
      if (hitPoint_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HitPoint);
      }
      if (hitDir_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(HitDir);
      }
      if (AttackeeHitForceAngle != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(AttackeeHitForceAngle);
      }
      if (AttackeeHitEntityAngle != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(AttackeeHitEntityAngle);
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
      if (HitColliderType != global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid) {
        output.WriteRawTag(8);
        output.WriteEnum((int) HitColliderType);
      }
      if (HitBoxIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(HitBoxIndex);
      }
      if (hitPoint_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HitPoint);
      }
      if (hitDir_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(HitDir);
      }
      if (AttackeeHitForceAngle != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(AttackeeHitForceAngle);
      }
      if (AttackeeHitEntityAngle != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(AttackeeHitEntityAngle);
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
      if (HitColliderType != global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) HitColliderType);
      }
      if (HitBoxIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HitBoxIndex);
      }
      if (hitPoint_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HitPoint);
      }
      if (hitDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HitDir);
      }
      if (AttackeeHitForceAngle != 0F) {
        size += 1 + 4;
      }
      if (AttackeeHitEntityAngle != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HitCollision other) {
      if (other == null) {
        return;
      }
      if (other.HitColliderType != global::Lemonade.Net.Protocol.HitColliderType.HitColliderInvalid) {
        HitColliderType = other.HitColliderType;
      }
      if (other.HitBoxIndex != 0) {
        HitBoxIndex = other.HitBoxIndex;
      }
      if (other.hitPoint_ != null) {
        if (hitPoint_ == null) {
          HitPoint = new global::Lemonade.Net.Protocol.Vector();
        }
        HitPoint.MergeFrom(other.HitPoint);
      }
      if (other.hitDir_ != null) {
        if (hitDir_ == null) {
          HitDir = new global::Lemonade.Net.Protocol.Vector();
        }
        HitDir.MergeFrom(other.HitDir);
      }
      if (other.AttackeeHitForceAngle != 0F) {
        AttackeeHitForceAngle = other.AttackeeHitForceAngle;
      }
      if (other.AttackeeHitEntityAngle != 0F) {
        AttackeeHitEntityAngle = other.AttackeeHitEntityAngle;
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
            HitColliderType = (global::Lemonade.Net.Protocol.HitColliderType) input.ReadEnum();
            break;
          }
          case 16: {
            HitBoxIndex = input.ReadInt32();
            break;
          }
          case 26: {
            if (hitPoint_ == null) {
              HitPoint = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(HitPoint);
            break;
          }
          case 34: {
            if (hitDir_ == null) {
              HitDir = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(HitDir);
            break;
          }
          case 45: {
            AttackeeHitForceAngle = input.ReadFloat();
            break;
          }
          case 53: {
            AttackeeHitEntityAngle = input.ReadFloat();
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
            HitColliderType = (global::Lemonade.Net.Protocol.HitColliderType) input.ReadEnum();
            break;
          }
          case 16: {
            HitBoxIndex = input.ReadInt32();
            break;
          }
          case 26: {
            if (hitPoint_ == null) {
              HitPoint = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(HitPoint);
            break;
          }
          case 34: {
            if (hitDir_ == null) {
              HitDir = new global::Lemonade.Net.Protocol.Vector();
            }
            input.ReadMessage(HitDir);
            break;
          }
          case 45: {
            AttackeeHitForceAngle = input.ReadFloat();
            break;
          }
          case 53: {
            AttackeeHitEntityAngle = input.ReadFloat();
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
