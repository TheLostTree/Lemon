// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DealAddFriendResultType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from DealAddFriendResultType.proto</summary>
  public static partial class DealAddFriendResultTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for DealAddFriendResultType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealAddFriendResultTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EZWFsQWRkRnJpZW5kUmVzdWx0VHlwZS5wcm90bypRChdEZWFsQWRkRnJp",
            "ZW5kUmVzdWx0VHlwZRIaChZERUFMX0FERF9GUklFTkRfUkVKRUNUEAASGgoW",
            "REVBTF9BRERfRlJJRU5EX0FDQ0VQVBABQhiqAhVMZW1vbmFkZS5OZXQuUHJv",
            "dG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Lemonade.Net.Protocol.DealAddFriendResultType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DealAddFriendResultType {
    [pbr::OriginalName("DEAL_ADD_FRIEND_REJECT")] DealAddFriendReject = 0,
    [pbr::OriginalName("DEAL_ADD_FRIEND_ACCEPT")] DealAddFriendAccept = 1,
  }

  #endregion

}

#endregion Designer generated code
