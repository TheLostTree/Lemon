// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopRewardState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from CoopRewardState.proto</summary>
  public static partial class CoopRewardStateReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopRewardState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopRewardStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDb29wUmV3YXJkU3RhdGUucHJvdG8qMgoPQ29vcFJld2FyZFN0YXRlEgoK",
            "BlVubG9jaxAAEggKBExvY2sQARIJCgVUYWtlbhACQhiqAhVMZW1vbmFkZS5O",
            "ZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Lemonade.Net.Protocol.CoopRewardState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CoopRewardState {
    [pbr::OriginalName("Unlock")] Unlock = 0,
    [pbr::OriginalName("Lock")] Lock = 1,
    [pbr::OriginalName("Taken")] Taken = 2,
  }

  #endregion

}

#endregion Designer generated code