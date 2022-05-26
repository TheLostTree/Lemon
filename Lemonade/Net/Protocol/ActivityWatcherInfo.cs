// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityWatcherInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ActivityWatcherInfo.proto</summary>
  public static partial class ActivityWatcherInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityWatcherInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityWatcherInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlBY3Rpdml0eVdhdGNoZXJJbmZvLnByb3RvInAKE0FjdGl2aXR5V2F0Y2hl",
            "ckluZm8SEgoKd2F0Y2hlcl9pZBgBIAEoDRIUCgxjdXJfcHJvZ3Jlc3MYAiAB",
            "KA0SFgoOdG90YWxfcHJvZ3Jlc3MYAyABKA0SFwoPaXNfdGFrZW5fcmV3YXJk",
            "GAQgASgIQhiqAhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ActivityWatcherInfo), global::Lemonade.Net.Protocol.ActivityWatcherInfo.Parser, new[]{ "WatcherId", "CurProgress", "TotalProgress", "IsTakenReward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActivityWatcherInfo : pb::IMessage<ActivityWatcherInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityWatcherInfo> _parser = new pb::MessageParser<ActivityWatcherInfo>(() => new ActivityWatcherInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityWatcherInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ActivityWatcherInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityWatcherInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityWatcherInfo(ActivityWatcherInfo other) : this() {
      watcherId_ = other.watcherId_;
      curProgress_ = other.curProgress_;
      totalProgress_ = other.totalProgress_;
      isTakenReward_ = other.isTakenReward_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityWatcherInfo Clone() {
      return new ActivityWatcherInfo(this);
    }

    /// <summary>Field number for the "watcher_id" field.</summary>
    public const int WatcherIdFieldNumber = 1;
    private uint watcherId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WatcherId {
      get { return watcherId_; }
      set {
        watcherId_ = value;
      }
    }

    /// <summary>Field number for the "cur_progress" field.</summary>
    public const int CurProgressFieldNumber = 2;
    private uint curProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurProgress {
      get { return curProgress_; }
      set {
        curProgress_ = value;
      }
    }

    /// <summary>Field number for the "total_progress" field.</summary>
    public const int TotalProgressFieldNumber = 3;
    private uint totalProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalProgress {
      get { return totalProgress_; }
      set {
        totalProgress_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_reward" field.</summary>
    public const int IsTakenRewardFieldNumber = 4;
    private bool isTakenReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTakenReward {
      get { return isTakenReward_; }
      set {
        isTakenReward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityWatcherInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityWatcherInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WatcherId != other.WatcherId) return false;
      if (CurProgress != other.CurProgress) return false;
      if (TotalProgress != other.TotalProgress) return false;
      if (IsTakenReward != other.IsTakenReward) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WatcherId != 0) hash ^= WatcherId.GetHashCode();
      if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
      if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
      if (IsTakenReward != false) hash ^= IsTakenReward.GetHashCode();
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
      if (WatcherId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WatcherId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurProgress);
      }
      if (TotalProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TotalProgress);
      }
      if (IsTakenReward != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsTakenReward);
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
      if (WatcherId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WatcherId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurProgress);
      }
      if (TotalProgress != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TotalProgress);
      }
      if (IsTakenReward != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsTakenReward);
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
      if (WatcherId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WatcherId);
      }
      if (CurProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
      }
      if (TotalProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
      }
      if (IsTakenReward != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityWatcherInfo other) {
      if (other == null) {
        return;
      }
      if (other.WatcherId != 0) {
        WatcherId = other.WatcherId;
      }
      if (other.CurProgress != 0) {
        CurProgress = other.CurProgress;
      }
      if (other.TotalProgress != 0) {
        TotalProgress = other.TotalProgress;
      }
      if (other.IsTakenReward != false) {
        IsTakenReward = other.IsTakenReward;
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
            WatcherId = input.ReadUInt32();
            break;
          }
          case 16: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 24: {
            TotalProgress = input.ReadUInt32();
            break;
          }
          case 32: {
            IsTakenReward = input.ReadBool();
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
            WatcherId = input.ReadUInt32();
            break;
          }
          case 16: {
            CurProgress = input.ReadUInt32();
            break;
          }
          case 24: {
            TotalProgress = input.ReadUInt32();
            break;
          }
          case 32: {
            IsTakenReward = input.ReadBool();
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
