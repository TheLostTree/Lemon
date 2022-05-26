// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonChallengeBeginNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from DungeonChallengeBeginNotify.proto</summary>
  public static partial class DungeonChallengeBeginNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonChallengeBeginNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonChallengeBeginNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFEdW5nZW9uQ2hhbGxlbmdlQmVnaW5Ob3RpZnkucHJvdG8imgEKG0R1bmdl",
            "b25DaGFsbGVuZ2VCZWdpbk5vdGlmeRIUCgxjaGFsbGVuZ2VfaWQYASABKA0S",
            "FwoPY2hhbGxlbmdlX2luZGV4GAIgASgNEhIKCnBhcmFtX2xpc3QYAyADKA0S",
            "EAoIZ3JvdXBfaWQYBCABKA0SFAoMZmF0aGVyX2luZGV4GAUgASgNEhAKCHVp",
            "ZF9saXN0GAYgAygNQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.DungeonChallengeBeginNotify), global::Lemonade.Net.Protocol.DungeonChallengeBeginNotify.Parser, new[]{ "ChallengeId", "ChallengeIndex", "ParamList", "GroupId", "FatherIndex", "UidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonChallengeBeginNotify : pb::IMessage<DungeonChallengeBeginNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonChallengeBeginNotify> _parser = new pb::MessageParser<DungeonChallengeBeginNotify>(() => new DungeonChallengeBeginNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonChallengeBeginNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.DungeonChallengeBeginNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify(DungeonChallengeBeginNotify other) : this() {
      challengeId_ = other.challengeId_;
      challengeIndex_ = other.challengeIndex_;
      paramList_ = other.paramList_.Clone();
      groupId_ = other.groupId_;
      fatherIndex_ = other.fatherIndex_;
      uidList_ = other.uidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonChallengeBeginNotify Clone() {
      return new DungeonChallengeBeginNotify(this);
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 1;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_index" field.</summary>
    public const int ChallengeIndexFieldNumber = 2;
    private uint challengeIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeIndex {
      get { return challengeIndex_; }
      set {
        challengeIndex_ = value;
      }
    }

    /// <summary>Field number for the "param_list" field.</summary>
    public const int ParamListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ParamList {
      get { return paramList_; }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "father_index" field.</summary>
    public const int FatherIndexFieldNumber = 5;
    private uint fatherIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FatherIndex {
      get { return fatherIndex_; }
      set {
        fatherIndex_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonChallengeBeginNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonChallengeBeginNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeId != other.ChallengeId) return false;
      if (ChallengeIndex != other.ChallengeIndex) return false;
      if(!paramList_.Equals(other.paramList_)) return false;
      if (GroupId != other.GroupId) return false;
      if (FatherIndex != other.FatherIndex) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (ChallengeIndex != 0) hash ^= ChallengeIndex.GetHashCode();
      hash ^= paramList_.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (FatherIndex != 0) hash ^= FatherIndex.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeIndex);
      }
      paramList_.WriteTo(output, _repeated_paramList_codec);
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (FatherIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FatherIndex);
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
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (ChallengeIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ChallengeIndex);
      }
      paramList_.WriteTo(ref output, _repeated_paramList_codec);
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (FatherIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FatherIndex);
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
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (ChallengeIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeIndex);
      }
      size += paramList_.CalculateSize(_repeated_paramList_codec);
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (FatherIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FatherIndex);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonChallengeBeginNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.ChallengeIndex != 0) {
        ChallengeIndex = other.ChallengeIndex;
      }
      paramList_.Add(other.paramList_);
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.FatherIndex != 0) {
        FatherIndex = other.FatherIndex;
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 16: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 40: {
            FatherIndex = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 16: {
            ChallengeIndex = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
            break;
          }
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 40: {
            FatherIndex = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
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
