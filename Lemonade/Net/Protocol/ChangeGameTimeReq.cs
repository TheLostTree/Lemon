// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeGameTimeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from ChangeGameTimeReq.proto</summary>
  public static partial class ChangeGameTimeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeGameTimeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeGameTimeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDaGFuZ2VHYW1lVGltZVJlcS5wcm90byK0AQoRQ2hhbmdlR2FtZVRpbWVS",
            "ZXESEQoJZ2FtZV90aW1lGAEgASgNEhQKDGlzX2ZvcmNlX3NldBgCIAEoCBIS",
            "CgpleHRyYV9kYXlzGAMgASgNImIKBUNtZElkEhMKD0VORVRfQ0hBTk5FTF9J",
            "RBAAEggKBE5PTkUQABIUChBFTkVUX0lTX1JFTElBQkxFEAESEwoPSVNfQUxM",
            "T1dfQ0xJRU5UEAESCwoGQ01EX0lEEKEBGgIQAUIYqgIVTGVtb25hZGUuTmV0",
            "LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.ChangeGameTimeReq), global::Lemonade.Net.Protocol.ChangeGameTimeReq.Parser, new[]{ "GameTime", "IsForceSet", "ExtraDays" }, null, new[]{ typeof(global::Lemonade.Net.Protocol.ChangeGameTimeReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChangeGameTimeReq : pb::IMessage<ChangeGameTimeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeGameTimeReq> _parser = new pb::MessageParser<ChangeGameTimeReq>(() => new ChangeGameTimeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeGameTimeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.ChangeGameTimeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeGameTimeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeGameTimeReq(ChangeGameTimeReq other) : this() {
      gameTime_ = other.gameTime_;
      isForceSet_ = other.isForceSet_;
      extraDays_ = other.extraDays_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeGameTimeReq Clone() {
      return new ChangeGameTimeReq(this);
    }

    /// <summary>Field number for the "game_time" field.</summary>
    public const int GameTimeFieldNumber = 1;
    private uint gameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameTime {
      get { return gameTime_; }
      set {
        gameTime_ = value;
      }
    }

    /// <summary>Field number for the "is_force_set" field.</summary>
    public const int IsForceSetFieldNumber = 2;
    private bool isForceSet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForceSet {
      get { return isForceSet_; }
      set {
        isForceSet_ = value;
      }
    }

    /// <summary>Field number for the "extra_days" field.</summary>
    public const int ExtraDaysFieldNumber = 3;
    private uint extraDays_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraDays {
      get { return extraDays_; }
      set {
        extraDays_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeGameTimeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeGameTimeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameTime != other.GameTime) return false;
      if (IsForceSet != other.IsForceSet) return false;
      if (ExtraDays != other.ExtraDays) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GameTime != 0) hash ^= GameTime.GetHashCode();
      if (IsForceSet != false) hash ^= IsForceSet.GetHashCode();
      if (ExtraDays != 0) hash ^= ExtraDays.GetHashCode();
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
      if (GameTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameTime);
      }
      if (IsForceSet != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsForceSet);
      }
      if (ExtraDays != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ExtraDays);
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
      if (GameTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameTime);
      }
      if (IsForceSet != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsForceSet);
      }
      if (ExtraDays != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ExtraDays);
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
      if (GameTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameTime);
      }
      if (IsForceSet != false) {
        size += 1 + 1;
      }
      if (ExtraDays != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraDays);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeGameTimeReq other) {
      if (other == null) {
        return;
      }
      if (other.GameTime != 0) {
        GameTime = other.GameTime;
      }
      if (other.IsForceSet != false) {
        IsForceSet = other.IsForceSet;
      }
      if (other.ExtraDays != 0) {
        ExtraDays = other.ExtraDays;
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
            GameTime = input.ReadUInt32();
            break;
          }
          case 16: {
            IsForceSet = input.ReadBool();
            break;
          }
          case 24: {
            ExtraDays = input.ReadUInt32();
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
            GameTime = input.ReadUInt32();
            break;
          }
          case 16: {
            IsForceSet = input.ReadBool();
            break;
          }
          case 24: {
            ExtraDays = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ChangeGameTimeReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("ENET_CHANNEL_ID")] EnetChannelId = 0,
        [pbr::OriginalName("NONE", PreferredAlias = false)] None = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 161,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
