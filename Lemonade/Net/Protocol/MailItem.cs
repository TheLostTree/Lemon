// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MailItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from MailItem.proto</summary>
  public static partial class MailItemReflection {

    #region Descriptor
    /// <summary>File descriptor for MailItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MailItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5NYWlsSXRlbS5wcm90bxoPSXRlbVBhcmFtLnByb3RvGhhNYXRlcmlhbERl",
            "bGV0ZUluZm8ucHJvdG8iVAoITWFpbEl0ZW0SHgoKaXRlbV9wYXJhbRgBIAEo",
            "CzIKLkl0ZW1QYXJhbRIoCgtkZWxldGVfaW5mbxgCIAEoCzITLk1hdGVyaWFs",
            "RGVsZXRlSW5mb0IYqgIVTGVtb25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Lemonade.Net.Protocol.ItemParamReflection.Descriptor, global::Lemonade.Net.Protocol.MaterialDeleteInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lemonade.Net.Protocol.MailItem), global::Lemonade.Net.Protocol.MailItem.Parser, new[]{ "ItemParam", "DeleteInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MailItem : pb::IMessage<MailItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MailItem> _parser = new pb::MessageParser<MailItem>(() => new MailItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MailItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lemonade.Net.Protocol.MailItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MailItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MailItem(MailItem other) : this() {
      itemParam_ = other.itemParam_ != null ? other.itemParam_.Clone() : null;
      deleteInfo_ = other.deleteInfo_ != null ? other.deleteInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MailItem Clone() {
      return new MailItem(this);
    }

    /// <summary>Field number for the "item_param" field.</summary>
    public const int ItemParamFieldNumber = 1;
    private global::Lemonade.Net.Protocol.ItemParam itemParam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.ItemParam ItemParam {
      get { return itemParam_; }
      set {
        itemParam_ = value;
      }
    }

    /// <summary>Field number for the "delete_info" field.</summary>
    public const int DeleteInfoFieldNumber = 2;
    private global::Lemonade.Net.Protocol.MaterialDeleteInfo deleteInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Lemonade.Net.Protocol.MaterialDeleteInfo DeleteInfo {
      get { return deleteInfo_; }
      set {
        deleteInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MailItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MailItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ItemParam, other.ItemParam)) return false;
      if (!object.Equals(DeleteInfo, other.DeleteInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (itemParam_ != null) hash ^= ItemParam.GetHashCode();
      if (deleteInfo_ != null) hash ^= DeleteInfo.GetHashCode();
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
      if (itemParam_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ItemParam);
      }
      if (deleteInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DeleteInfo);
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
      if (itemParam_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ItemParam);
      }
      if (deleteInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DeleteInfo);
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
      if (itemParam_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemParam);
      }
      if (deleteInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeleteInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MailItem other) {
      if (other == null) {
        return;
      }
      if (other.itemParam_ != null) {
        if (itemParam_ == null) {
          ItemParam = new global::Lemonade.Net.Protocol.ItemParam();
        }
        ItemParam.MergeFrom(other.ItemParam);
      }
      if (other.deleteInfo_ != null) {
        if (deleteInfo_ == null) {
          DeleteInfo = new global::Lemonade.Net.Protocol.MaterialDeleteInfo();
        }
        DeleteInfo.MergeFrom(other.DeleteInfo);
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
          case 10: {
            if (itemParam_ == null) {
              ItemParam = new global::Lemonade.Net.Protocol.ItemParam();
            }
            input.ReadMessage(ItemParam);
            break;
          }
          case 18: {
            if (deleteInfo_ == null) {
              DeleteInfo = new global::Lemonade.Net.Protocol.MaterialDeleteInfo();
            }
            input.ReadMessage(DeleteInfo);
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
          case 10: {
            if (itemParam_ == null) {
              ItemParam = new global::Lemonade.Net.Protocol.ItemParam();
            }
            input.ReadMessage(ItemParam);
            break;
          }
          case 18: {
            if (deleteInfo_ == null) {
              DeleteInfo = new global::Lemonade.Net.Protocol.MaterialDeleteInfo();
            }
            input.ReadMessage(DeleteInfo);
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