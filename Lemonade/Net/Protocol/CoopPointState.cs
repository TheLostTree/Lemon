// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopPointState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from CoopPointState.proto</summary>
  public static partial class CoopPointStateReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopPointState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopPointStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRDb29wUG9pbnRTdGF0ZS5wcm90byo6Cg5Db29wUG9pbnRTdGF0ZRINCglV",
            "bnN0YXJ0ZWQQABILCgdTdGFydGVkEAESDAoIRmluaXNoZWQQAkIYqgIVTGVt",
            "b25hZGUuTmV0LlByb3RvY29sYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Lemonade.Net.Protocol.CoopPointState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CoopPointState {
    [pbr::OriginalName("Unstarted")] Unstarted = 0,
    [pbr::OriginalName("Started")] Started = 1,
    [pbr::OriginalName("Finished")] Finished = 2,
  }

  #endregion

}

#endregion Designer generated code
