// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerLevelEndNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerLevelEndNotify.proto</summary>
  public static partial class TowerLevelEndNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerLevelEndNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerLevelEndNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlUb3dlckxldmVsRW5kTm90aWZ5LnByb3RvGg9JdGVtUGFyYW0ucHJvdG8i",
            "+wIKE1Rvd2VyTGV2ZWxFbmROb3RpZnkSEgoKaXNfc3VjY2VzcxgBIAEoCBIf",
            "ChdmaW5pc2hlZF9zdGFyX2NvbmRfbGlzdBgCIAMoDRIkChByZXdhcmRfaXRl",
            "bV9saXN0GAMgAygLMgouSXRlbVBhcmFtEhYKDmNvbnRpbnVlX3N0YXRlGAQg",
            "ASgNEhUKDW5leHRfZmxvb3JfaWQYBSABKA0iTQoFQ21kSWQSCAoETk9ORRAA",
            "EhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARIL",
            "CgZDTURfSUQQmBMaAhABIooBChFDb250aW51ZVN0YXRlVHlwZRIjCh9DT05U",
            "SU5VRV9TVEFURV9DQU5fTk9UX0NPTlRJTlVFEAASJwojQ09OVElOVUVfU1RB",
            "VEVfQ0FOX0VOVEVSX05FWFRfTEVWRUwQARInCiNDT05USU5VRV9TVEFURV9D",
            "QU5fRU5URVJfTkVYVF9GTE9PUhACQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9j",
            "b2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerLevelEndNotify), global::Lemonade.Net.Protocol.TowerLevelEndNotify.Parser, new[]{ "IsSuccess", "FinishedStarCondList", "RewardItemList", "ContinueState", "NextFloorId" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.TowerLevelEndNotify.Types.CmdId), typeof(global::Lemonade.Net.Protocol.TowerLevelEndNotify.Types.ContinueStateType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerLevelEndNotify : pb::IMessage<TowerLevelEndNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerLevelEndNotify> _parser = new pb::MessageParser<TowerLevelEndNotify>(() => new TowerLevelEndNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerLevelEndNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerLevelEndNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify(TowerLevelEndNotify other) : this() {
      isSuccess_ = other.isSuccess_;
      finishedStarCondList_ = other.finishedStarCondList_.Clone();
      rewardItemList_ = other.rewardItemList_.Clone();
      continueState_ = other.continueState_;
      nextFloorId_ = other.nextFloorId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelEndNotify Clone() {
      return new TowerLevelEndNotify(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 1;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "finished_star_cond_list" field.</summary>
    public const int FinishedStarCondListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_finishedStarCondList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> finishedStarCondList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedStarCondList {
      get { return finishedStarCondList_; }
    }

    /// <summary>Field number for the "reward_item_list" field.</summary>
    public const int RewardItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.ItemParam> _repeated_rewardItemList_codec
        = pb::FieldCodec.ForMessage(26, global::Lemonade.Net.Protocol.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam> rewardItemList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.ItemParam> RewardItemList {
      get { return rewardItemList_; }
    }

    /// <summary>Field number for the "continue_state" field.</summary>
    public const int ContinueStateFieldNumber = 4;
    private uint continueState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContinueState {
      get { return continueState_; }
      set {
        continueState_ = value;
      }
    }

    /// <summary>Field number for the "next_floor_id" field.</summary>
    public const int NextFloorIdFieldNumber = 5;
    private uint nextFloorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextFloorId {
      get { return nextFloorId_; }
      set {
        nextFloorId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerLevelEndNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerLevelEndNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if(!finishedStarCondList_.Equals(other.finishedStarCondList_)) return false;
      if(!rewardItemList_.Equals(other.rewardItemList_)) return false;
      if (ContinueState != other.ContinueState) return false;
      if (NextFloorId != other.NextFloorId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      hash ^= finishedStarCondList_.GetHashCode();
      hash ^= rewardItemList_.GetHashCode();
      if (ContinueState != 0) hash ^= ContinueState.GetHashCode();
      if (NextFloorId != 0) hash ^= NextFloorId.GetHashCode();
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
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      finishedStarCondList_.WriteTo(output, _repeated_finishedStarCondList_codec);
      rewardItemList_.WriteTo(output, _repeated_rewardItemList_codec);
      if (ContinueState != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ContinueState);
      }
      if (NextFloorId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextFloorId);
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
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      finishedStarCondList_.WriteTo(ref output, _repeated_finishedStarCondList_codec);
      rewardItemList_.WriteTo(ref output, _repeated_rewardItemList_codec);
      if (ContinueState != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ContinueState);
      }
      if (NextFloorId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextFloorId);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      size += finishedStarCondList_.CalculateSize(_repeated_finishedStarCondList_codec);
      size += rewardItemList_.CalculateSize(_repeated_rewardItemList_codec);
      if (ContinueState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContinueState);
      }
      if (NextFloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextFloorId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerLevelEndNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      finishedStarCondList_.Add(other.finishedStarCondList_);
      rewardItemList_.Add(other.rewardItemList_);
      if (other.ContinueState != 0) {
        ContinueState = other.ContinueState;
      }
      if (other.NextFloorId != 0) {
        NextFloorId = other.NextFloorId;
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            finishedStarCondList_.AddEntriesFrom(input, _repeated_finishedStarCondList_codec);
            break;
          }
          case 26: {
            rewardItemList_.AddEntriesFrom(input, _repeated_rewardItemList_codec);
            break;
          }
          case 32: {
            ContinueState = input.ReadUInt32();
            break;
          }
          case 40: {
            NextFloorId = input.ReadUInt32();
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 18:
          case 16: {
            finishedStarCondList_.AddEntriesFrom(ref input, _repeated_finishedStarCondList_codec);
            break;
          }
          case 26: {
            rewardItemList_.AddEntriesFrom(ref input, _repeated_rewardItemList_codec);
            break;
          }
          case 32: {
            ContinueState = input.ReadUInt32();
            break;
          }
          case 40: {
            NextFloorId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerLevelEndNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2456,
      }

      public enum ContinueStateType {
        [pbr::OriginalName("CONTINUE_STATE_CAN_NOT_CONTINUE")] ContinueStateCanNotContinue = 0,
        [pbr::OriginalName("CONTINUE_STATE_CAN_ENTER_NEXT_LEVEL")] ContinueStateCanEnterNextLevel = 1,
        [pbr::OriginalName("CONTINUE_STATE_CAN_ENTER_NEXT_FLOOR")] ContinueStateCanEnterNextFloor = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code