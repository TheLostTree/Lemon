// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityScalarType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from AbilityScalarType.proto</summary>
  public static partial class AbilityScalarTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityScalarType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityScalarTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdBYmlsaXR5U2NhbGFyVHlwZS5wcm90bypgChFBYmlsaXR5U2NhbGFyVHlw",
            "ZRIKCgZVTktOT1cQABIJCgVGTE9BVBABEgcKA0lOVBACEggKBEJPT0wQAxIL",
            "CgdUUklHR0VSEAQSCgoGU1RSSU5HEAUSCAoEVUlOVBAGQhiqAhVMZW1vbmFk",
            "ZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Lemonade.Net.Protocol.AbilityScalarType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AbilityScalarType {
    [pbr::OriginalName("UNKNOW")] Unknow = 0,
    [pbr::OriginalName("FLOAT")] Float = 1,
    [pbr::OriginalName("INT")] Int = 2,
    [pbr::OriginalName("BOOL")] Bool = 3,
    [pbr::OriginalName("TRIGGER")] Trigger = 4,
    [pbr::OriginalName("STRING")] String = 5,
    [pbr::OriginalName("UINT")] Uint = 6,
  }

  #endregion

}

#endregion Designer generated code