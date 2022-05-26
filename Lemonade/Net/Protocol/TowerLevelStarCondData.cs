// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerLevelStarCondData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from TowerLevelStarCondData.proto</summary>
  public static partial class TowerLevelStarCondDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerLevelStarCondData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerLevelStarCondDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUb3dlckxldmVsU3RhckNvbmREYXRhLnByb3RvIlcKFlRvd2VyTGV2ZWxT",
            "dGFyQ29uZERhdGESFwoPc3Rhcl9jb25kX2luZGV4GAMgASgNEhIKCmNvbmRf",
            "dmFsdWUYBCABKA0SEAoIaXNfcGF1c2UYBSABKAhCGKoCFUxlbW9uYWRlLk5l",
            "dC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.TowerLevelStarCondData), global::Lemonade.Net.Protocol.TowerLevelStarCondData.Parser, new[]{ "StarCondIndex", "CondValue", "IsPause" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerLevelStarCondData : pb::IMessage<TowerLevelStarCondData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerLevelStarCondData> _parser = new pb::MessageParser<TowerLevelStarCondData>(() => new TowerLevelStarCondData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerLevelStarCondData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.TowerLevelStarCondDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData(TowerLevelStarCondData other) : this() {
      starCondIndex_ = other.starCondIndex_;
      condValue_ = other.condValue_;
      isPause_ = other.isPause_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData Clone() {
      return new TowerLevelStarCondData(this);
    }

    /// <summary>Field number for the "star_cond_index" field.</summary>
    public const int StarCondIndexFieldNumber = 3;
    private uint starCondIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StarCondIndex {
      get { return starCondIndex_; }
      set {
        starCondIndex_ = value;
      }
    }

    /// <summary>Field number for the "cond_value" field.</summary>
    public const int CondValueFieldNumber = 4;
    private uint condValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CondValue {
      get { return condValue_; }
      set {
        condValue_ = value;
      }
    }

    /// <summary>Field number for the "is_pause" field.</summary>
    public const int IsPauseFieldNumber = 5;
    private bool isPause_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPause {
      get { return isPause_; }
      set {
        isPause_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerLevelStarCondData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerLevelStarCondData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StarCondIndex != other.StarCondIndex) return false;
      if (CondValue != other.CondValue) return false;
      if (IsPause != other.IsPause) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StarCondIndex != 0) hash ^= StarCondIndex.GetHashCode();
      if (CondValue != 0) hash ^= CondValue.GetHashCode();
      if (IsPause != false) hash ^= IsPause.GetHashCode();
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
      if (StarCondIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StarCondIndex);
      }
      if (CondValue != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CondValue);
      }
      if (IsPause != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsPause);
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
      if (StarCondIndex != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StarCondIndex);
      }
      if (CondValue != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CondValue);
      }
      if (IsPause != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsPause);
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
      if (StarCondIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StarCondIndex);
      }
      if (CondValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CondValue);
      }
      if (IsPause != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerLevelStarCondData other) {
      if (other == null) {
        return;
      }
      if (other.StarCondIndex != 0) {
        StarCondIndex = other.StarCondIndex;
      }
      if (other.CondValue != 0) {
        CondValue = other.CondValue;
      }
      if (other.IsPause != false) {
        IsPause = other.IsPause;
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
          case 24: {
            StarCondIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            CondValue = input.ReadUInt32();
            break;
          }
          case 40: {
            IsPause = input.ReadBool();
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
          case 24: {
            StarCondIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            CondValue = input.ReadUInt32();
            break;
          }
          case 40: {
            IsPause = input.ReadBool();
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
