// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerAllDataRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerAllDataRsp.proto</summary>
  public static partial class TowerAllDataRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerAllDataRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerAllDataRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVUb3dlckFsbERhdGFSc3AucHJvdG8aGVRvd2VyQ3VyTGV2ZWxSZWNvcmQu",
            "cHJvdG8aF1Rvd2VyTW9udGhseUJyaWVmLnByb3RvGhZUb3dlckZsb29yUmVj",
            "b3JkLnByb3RvIokHCg9Ub3dlckFsbERhdGFSc3ASGQoRdG93ZXJfc2NoZWR1",
            "bGVfaWQYASABKA0SMgoXdG93ZXJfZmxvb3JfcmVjb3JkX2xpc3QYAiADKAsy",
            "ES5Ub3dlckZsb29yUmVjb3JkEhYKDmRhaWx5X2Zsb29yX2lkGAMgASgNEhkK",
            "EWRhaWx5X2xldmVsX2luZGV4GAQgASgNEi4KEGN1cl9sZXZlbF9yZWNvcmQY",
            "BSABKAsyFC5Ub3dlckN1ckxldmVsUmVjb3JkEiEKGW5leHRfc2NoZWR1bGVf",
            "Y2hhbmdlX3RpbWUYBiABKA0SQwoTZmxvb3Jfb3Blbl90aW1lX21hcBgHIAMo",
            "CzImLlRvd2VyQWxsRGF0YVJzcC5GbG9vck9wZW5UaW1lTWFwRW50cnkSGQoR",
            "aXNfZmlyc3RfaW50ZXJhY3QYCCABKAgSKQoNbW9udGhseV9icmllZhgJIAEo",
            "CzISLlRvd2VyTW9udGhseUJyaWVmEhsKE3NraXBfdG9fZmxvb3JfaW5kZXgY",
            "CiABKA0SHwoXY29tbWVtb3JhdGl2ZV9yZXdhcmRfaWQYCyABKA0SXwoic2tp",
            "cF9mbG9vcl9ncmFudGVkX3Jld2FyZF9pdGVtX21hcBgMIAMoCzIzLlRvd2Vy",
            "QWxsRGF0YVJzcC5Ta2lwRmxvb3JHcmFudGVkUmV3YXJkSXRlbU1hcEVudHJ5",
            "Eh4KFnZhbGlkX3Rvd2VyX3JlY29yZF9udW0YDSABKA0SDwoHcmV0Y29kZRgO",
            "IAEoBRIiChppc19maW5pc2hlZF9lbnRyYW5jZV9mbG9vchgPIAEoCBIbChNz",
            "Y2hlZHVsZV9zdGFydF90aW1lGBAgASgNEjcKG2xhc3Rfc2NoZWR1bGVfbW9u",
            "dGhseV9icmllZhgRIAEoCzISLlRvd2VyTW9udGhseUJyaWVmGjcKFUZsb29y",
            "T3BlblRpbWVNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06",
            "AjgBGkQKIlNraXBGbG9vckdyYW50ZWRSZXdhcmRJdGVtTWFwRW50cnkSCwoD",
            "a2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4ASJNCgVDbWRJZBIICgROT05F",
            "EAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRAB",
            "EgsKBkNNRF9JRBCdExoCEAFCGKoCFUxlbW9uYWRlLk5ldC5Qcm90b2NvbGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.TowerCurLevelRecordReflection.Descriptor, global::Lemonade.Net.Protocol.TowerMonthlyBriefReflection.Descriptor, global::Lemonade.Net.Protocol.TowerFloorRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerAllDataRsp), global::Lemonade.Net.Protocol.TowerAllDataRsp.Parser, new[]{ "TowerScheduleId", "TowerFloorRecordList", "DailyFloorId", "DailyLevelIndex", "CurLevelRecord", "NextScheduleChangeTime", "FloorOpenTimeMap", "IsFirstInteract", "MonthlyBrief", "SkipToFloorIndex", "CommemorativeRewardId", "SkipFloorGrantedRewardItemMap", "ValidTowerRecordNum", "Retcode", "IsFinishedEntranceFloor", "ScheduleStartTime", "LastScheduleMonthlyBrief" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.TowerAllDataRsp.Types.CmdId) }, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerAllDataRsp : pb::IMessage<TowerAllDataRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerAllDataRsp> _parser = new pb::MessageParser<TowerAllDataRsp>(() => new TowerAllDataRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerAllDataRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerAllDataRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp(TowerAllDataRsp other) : this() {
      towerScheduleId_ = other.towerScheduleId_;
      towerFloorRecordList_ = other.towerFloorRecordList_.Clone();
      dailyFloorId_ = other.dailyFloorId_;
      dailyLevelIndex_ = other.dailyLevelIndex_;
      curLevelRecord_ = other.curLevelRecord_ != null ? other.curLevelRecord_.Clone() : null;
      nextScheduleChangeTime_ = other.nextScheduleChangeTime_;
      floorOpenTimeMap_ = other.floorOpenTimeMap_.Clone();
      isFirstInteract_ = other.isFirstInteract_;
      monthlyBrief_ = other.monthlyBrief_ != null ? other.monthlyBrief_.Clone() : null;
      skipToFloorIndex_ = other.skipToFloorIndex_;
      commemorativeRewardId_ = other.commemorativeRewardId_;
      skipFloorGrantedRewardItemMap_ = other.skipFloorGrantedRewardItemMap_.Clone();
      validTowerRecordNum_ = other.validTowerRecordNum_;
      retcode_ = other.retcode_;
      isFinishedEntranceFloor_ = other.isFinishedEntranceFloor_;
      scheduleStartTime_ = other.scheduleStartTime_;
      lastScheduleMonthlyBrief_ = other.lastScheduleMonthlyBrief_ != null ? other.lastScheduleMonthlyBrief_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerAllDataRsp Clone() {
      return new TowerAllDataRsp(this);
    }

    /// <summary>Field number for the "tower_schedule_id" field.</summary>
    public const int TowerScheduleIdFieldNumber = 1;
    private uint towerScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TowerScheduleId {
      get { return towerScheduleId_; }
      set {
        towerScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "tower_floor_record_list" field.</summary>
    public const int TowerFloorRecordListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Lemonade.Net.Protocol.TowerFloorRecord> _repeated_towerFloorRecordList_codec
        = pb::FieldCodec.ForMessage(18, global::Lemonade.Net.Protocol.TowerFloorRecord.Parser);
    private readonly pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord> towerFloorRecordList_ = new pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Lemonade.Net.Protocol.TowerFloorRecord> TowerFloorRecordList {
      get { return towerFloorRecordList_; }
    }

    /// <summary>Field number for the "daily_floor_id" field.</summary>
    public const int DailyFloorIdFieldNumber = 3;
    private uint dailyFloorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyFloorId {
      get { return dailyFloorId_; }
      set {
        dailyFloorId_ = value;
      }
    }

    /// <summary>Field number for the "daily_level_index" field.</summary>
    public const int DailyLevelIndexFieldNumber = 4;
    private uint dailyLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyLevelIndex {
      get { return dailyLevelIndex_; }
      set {
        dailyLevelIndex_ = value;
      }
    }

    /// <summary>Field number for the "cur_level_record" field.</summary>
    public const int CurLevelRecordFieldNumber = 5;
    private global::Lemonade.Net.Protocol.TowerCurLevelRecord curLevelRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.TowerCurLevelRecord CurLevelRecord {
      get { return curLevelRecord_; }
      set {
        curLevelRecord_ = value;
      }
    }

    /// <summary>Field number for the "next_schedule_change_time" field.</summary>
    public const int NextScheduleChangeTimeFieldNumber = 6;
    private uint nextScheduleChangeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextScheduleChangeTime {
      get { return nextScheduleChangeTime_; }
      set {
        nextScheduleChangeTime_ = value;
      }
    }

    /// <summary>Field number for the "floor_open_time_map" field.</summary>
    public const int FloorOpenTimeMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, uint>.Codec _map_floorOpenTimeMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 58);
    private readonly pbc::MapField<uint, uint> floorOpenTimeMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FloorOpenTimeMap {
      get { return floorOpenTimeMap_; }
    }

    /// <summary>Field number for the "is_first_interact" field.</summary>
    public const int IsFirstInteractFieldNumber = 8;
    private bool isFirstInteract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstInteract {
      get { return isFirstInteract_; }
      set {
        isFirstInteract_ = value;
      }
    }

    /// <summary>Field number for the "monthly_brief" field.</summary>
    public const int MonthlyBriefFieldNumber = 9;
    private global::Lemonade.Net.Protocol.TowerMonthlyBrief monthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.TowerMonthlyBrief MonthlyBrief {
      get { return monthlyBrief_; }
      set {
        monthlyBrief_ = value;
      }
    }

    /// <summary>Field number for the "skip_to_floor_index" field.</summary>
    public const int SkipToFloorIndexFieldNumber = 10;
    private uint skipToFloorIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkipToFloorIndex {
      get { return skipToFloorIndex_; }
      set {
        skipToFloorIndex_ = value;
      }
    }

    /// <summary>Field number for the "commemorative_reward_id" field.</summary>
    public const int CommemorativeRewardIdFieldNumber = 11;
    private uint commemorativeRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CommemorativeRewardId {
      get { return commemorativeRewardId_; }
      set {
        commemorativeRewardId_ = value;
      }
    }

    /// <summary>Field number for the "skip_floor_granted_reward_item_map" field.</summary>
    public const int SkipFloorGrantedRewardItemMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_skipFloorGrantedRewardItemMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> skipFloorGrantedRewardItemMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SkipFloorGrantedRewardItemMap {
      get { return skipFloorGrantedRewardItemMap_; }
    }

    /// <summary>Field number for the "valid_tower_record_num" field.</summary>
    public const int ValidTowerRecordNumFieldNumber = 13;
    private uint validTowerRecordNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ValidTowerRecordNum {
      get { return validTowerRecordNum_; }
      set {
        validTowerRecordNum_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "is_finished_entrance_floor" field.</summary>
    public const int IsFinishedEntranceFloorFieldNumber = 15;
    private bool isFinishedEntranceFloor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinishedEntranceFloor {
      get { return isFinishedEntranceFloor_; }
      set {
        isFinishedEntranceFloor_ = value;
      }
    }

    /// <summary>Field number for the "schedule_start_time" field.</summary>
    public const int ScheduleStartTimeFieldNumber = 16;
    private uint scheduleStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleStartTime {
      get { return scheduleStartTime_; }
      set {
        scheduleStartTime_ = value;
      }
    }

    /// <summary>Field number for the "last_schedule_monthly_brief" field.</summary>
    public const int LastScheduleMonthlyBriefFieldNumber = 17;
    private global::Lemonade.Net.Protocol.TowerMonthlyBrief lastScheduleMonthlyBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.TowerMonthlyBrief LastScheduleMonthlyBrief {
      get { return lastScheduleMonthlyBrief_; }
      set {
        lastScheduleMonthlyBrief_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerAllDataRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerAllDataRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TowerScheduleId != other.TowerScheduleId) return false;
      if(!towerFloorRecordList_.Equals(other.towerFloorRecordList_)) return false;
      if (DailyFloorId != other.DailyFloorId) return false;
      if (DailyLevelIndex != other.DailyLevelIndex) return false;
      if (!object.Equals(CurLevelRecord, other.CurLevelRecord)) return false;
      if (NextScheduleChangeTime != other.NextScheduleChangeTime) return false;
      if (!FloorOpenTimeMap.Equals(other.FloorOpenTimeMap)) return false;
      if (IsFirstInteract != other.IsFirstInteract) return false;
      if (!object.Equals(MonthlyBrief, other.MonthlyBrief)) return false;
      if (SkipToFloorIndex != other.SkipToFloorIndex) return false;
      if (CommemorativeRewardId != other.CommemorativeRewardId) return false;
      if (!SkipFloorGrantedRewardItemMap.Equals(other.SkipFloorGrantedRewardItemMap)) return false;
      if (ValidTowerRecordNum != other.ValidTowerRecordNum) return false;
      if (Retcode != other.Retcode) return false;
      if (IsFinishedEntranceFloor != other.IsFinishedEntranceFloor) return false;
      if (ScheduleStartTime != other.ScheduleStartTime) return false;
      if (!object.Equals(LastScheduleMonthlyBrief, other.LastScheduleMonthlyBrief)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TowerScheduleId != 0) hash ^= TowerScheduleId.GetHashCode();
      hash ^= towerFloorRecordList_.GetHashCode();
      if (DailyFloorId != 0) hash ^= DailyFloorId.GetHashCode();
      if (DailyLevelIndex != 0) hash ^= DailyLevelIndex.GetHashCode();
      if (curLevelRecord_ != null) hash ^= CurLevelRecord.GetHashCode();
      if (NextScheduleChangeTime != 0) hash ^= NextScheduleChangeTime.GetHashCode();
      hash ^= FloorOpenTimeMap.GetHashCode();
      if (IsFirstInteract != false) hash ^= IsFirstInteract.GetHashCode();
      if (monthlyBrief_ != null) hash ^= MonthlyBrief.GetHashCode();
      if (SkipToFloorIndex != 0) hash ^= SkipToFloorIndex.GetHashCode();
      if (CommemorativeRewardId != 0) hash ^= CommemorativeRewardId.GetHashCode();
      hash ^= SkipFloorGrantedRewardItemMap.GetHashCode();
      if (ValidTowerRecordNum != 0) hash ^= ValidTowerRecordNum.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IsFinishedEntranceFloor != false) hash ^= IsFinishedEntranceFloor.GetHashCode();
      if (ScheduleStartTime != 0) hash ^= ScheduleStartTime.GetHashCode();
      if (lastScheduleMonthlyBrief_ != null) hash ^= LastScheduleMonthlyBrief.GetHashCode();
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      towerFloorRecordList_.WriteTo(output, _repeated_towerFloorRecordList_codec);
      if (DailyFloorId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DailyFloorId);
      }
      if (DailyLevelIndex != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DailyLevelIndex);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CurLevelRecord);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      floorOpenTimeMap_.WriteTo(output, _map_floorOpenTimeMap_codec);
      if (IsFirstInteract != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFirstInteract);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MonthlyBrief);
      }
      if (SkipToFloorIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkipToFloorIndex);
      }
      if (CommemorativeRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CommemorativeRewardId);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(output, _map_skipFloorGrantedRewardItemMap_codec);
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
      }
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (TowerScheduleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TowerScheduleId);
      }
      towerFloorRecordList_.WriteTo(ref output, _repeated_towerFloorRecordList_codec);
      if (DailyFloorId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DailyFloorId);
      }
      if (DailyLevelIndex != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DailyLevelIndex);
      }
      if (curLevelRecord_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CurLevelRecord);
      }
      if (NextScheduleChangeTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextScheduleChangeTime);
      }
      floorOpenTimeMap_.WriteTo(ref output, _map_floorOpenTimeMap_codec);
      if (IsFirstInteract != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFirstInteract);
      }
      if (monthlyBrief_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MonthlyBrief);
      }
      if (SkipToFloorIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkipToFloorIndex);
      }
      if (CommemorativeRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CommemorativeRewardId);
      }
      skipFloorGrantedRewardItemMap_.WriteTo(ref output, _map_skipFloorGrantedRewardItemMap_codec);
      if (ValidTowerRecordNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ValidTowerRecordNum);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
      }
      if (IsFinishedEntranceFloor != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsFinishedEntranceFloor);
      }
      if (ScheduleStartTime != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(LastScheduleMonthlyBrief);
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
      if (TowerScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TowerScheduleId);
      }
      size += towerFloorRecordList_.CalculateSize(_repeated_towerFloorRecordList_codec);
      if (DailyFloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyFloorId);
      }
      if (DailyLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyLevelIndex);
      }
      if (curLevelRecord_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurLevelRecord);
      }
      if (NextScheduleChangeTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextScheduleChangeTime);
      }
      size += floorOpenTimeMap_.CalculateSize(_map_floorOpenTimeMap_codec);
      if (IsFirstInteract != false) {
        size += 1 + 1;
      }
      if (monthlyBrief_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MonthlyBrief);
      }
      if (SkipToFloorIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkipToFloorIndex);
      }
      if (CommemorativeRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CommemorativeRewardId);
      }
      size += skipFloorGrantedRewardItemMap_.CalculateSize(_map_skipFloorGrantedRewardItemMap_codec);
      if (ValidTowerRecordNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ValidTowerRecordNum);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (IsFinishedEntranceFloor != false) {
        size += 1 + 1;
      }
      if (ScheduleStartTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleStartTime);
      }
      if (lastScheduleMonthlyBrief_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LastScheduleMonthlyBrief);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerAllDataRsp other) {
      if (other == null) {
        return;
      }
      if (other.TowerScheduleId != 0) {
        TowerScheduleId = other.TowerScheduleId;
      }
      towerFloorRecordList_.Add(other.towerFloorRecordList_);
      if (other.DailyFloorId != 0) {
        DailyFloorId = other.DailyFloorId;
      }
      if (other.DailyLevelIndex != 0) {
        DailyLevelIndex = other.DailyLevelIndex;
      }
      if (other.curLevelRecord_ != null) {
        if (curLevelRecord_ == null) {
          CurLevelRecord = new global::Lemonade.Net.Protocol.TowerCurLevelRecord();
        }
        CurLevelRecord.MergeFrom(other.CurLevelRecord);
      }
      if (other.NextScheduleChangeTime != 0) {
        NextScheduleChangeTime = other.NextScheduleChangeTime;
      }
      floorOpenTimeMap_.Add(other.floorOpenTimeMap_);
      if (other.IsFirstInteract != false) {
        IsFirstInteract = other.IsFirstInteract;
      }
      if (other.monthlyBrief_ != null) {
        if (monthlyBrief_ == null) {
          MonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
        }
        MonthlyBrief.MergeFrom(other.MonthlyBrief);
      }
      if (other.SkipToFloorIndex != 0) {
        SkipToFloorIndex = other.SkipToFloorIndex;
      }
      if (other.CommemorativeRewardId != 0) {
        CommemorativeRewardId = other.CommemorativeRewardId;
      }
      skipFloorGrantedRewardItemMap_.Add(other.skipFloorGrantedRewardItemMap_);
      if (other.ValidTowerRecordNum != 0) {
        ValidTowerRecordNum = other.ValidTowerRecordNum;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IsFinishedEntranceFloor != false) {
        IsFinishedEntranceFloor = other.IsFinishedEntranceFloor;
      }
      if (other.ScheduleStartTime != 0) {
        ScheduleStartTime = other.ScheduleStartTime;
      }
      if (other.lastScheduleMonthlyBrief_ != null) {
        if (lastScheduleMonthlyBrief_ == null) {
          LastScheduleMonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
        }
        LastScheduleMonthlyBrief.MergeFrom(other.LastScheduleMonthlyBrief);
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
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 18: {
            towerFloorRecordList_.AddEntriesFrom(input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 24: {
            DailyFloorId = input.ReadUInt32();
            break;
          }
          case 32: {
            DailyLevelIndex = input.ReadUInt32();
            break;
          }
          case 42: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::Lemonade.Net.Protocol.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 48: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 58: {
            floorOpenTimeMap_.AddEntriesFrom(input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 64: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 74: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 80: {
            SkipToFloorIndex = input.ReadUInt32();
            break;
          }
          case 88: {
            CommemorativeRewardId = input.ReadUInt32();
            break;
          }
          case 98: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 104: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 128: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 138: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
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
            TowerScheduleId = input.ReadUInt32();
            break;
          }
          case 18: {
            towerFloorRecordList_.AddEntriesFrom(ref input, _repeated_towerFloorRecordList_codec);
            break;
          }
          case 24: {
            DailyFloorId = input.ReadUInt32();
            break;
          }
          case 32: {
            DailyLevelIndex = input.ReadUInt32();
            break;
          }
          case 42: {
            if (curLevelRecord_ == null) {
              CurLevelRecord = new global::Lemonade.Net.Protocol.TowerCurLevelRecord();
            }
            input.ReadMessage(CurLevelRecord);
            break;
          }
          case 48: {
            NextScheduleChangeTime = input.ReadUInt32();
            break;
          }
          case 58: {
            floorOpenTimeMap_.AddEntriesFrom(ref input, _map_floorOpenTimeMap_codec);
            break;
          }
          case 64: {
            IsFirstInteract = input.ReadBool();
            break;
          }
          case 74: {
            if (monthlyBrief_ == null) {
              MonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
            }
            input.ReadMessage(MonthlyBrief);
            break;
          }
          case 80: {
            SkipToFloorIndex = input.ReadUInt32();
            break;
          }
          case 88: {
            CommemorativeRewardId = input.ReadUInt32();
            break;
          }
          case 98: {
            skipFloorGrantedRewardItemMap_.AddEntriesFrom(ref input, _map_skipFloorGrantedRewardItemMap_codec);
            break;
          }
          case 104: {
            ValidTowerRecordNum = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            IsFinishedEntranceFloor = input.ReadBool();
            break;
          }
          case 128: {
            ScheduleStartTime = input.ReadUInt32();
            break;
          }
          case 138: {
            if (lastScheduleMonthlyBrief_ == null) {
              LastScheduleMonthlyBrief = new global::Lemonade.Net.Protocol.TowerMonthlyBrief();
            }
            input.ReadMessage(LastScheduleMonthlyBrief);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerAllDataRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2461,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
