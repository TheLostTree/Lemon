// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lemonade.Net.Protocol {

  /// <summary>Holder for reflection information generated from EnterType.proto</summary>
  public static partial class EnterTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9FbnRlclR5cGUucHJvdG8q9wEKCUVudGVyVHlwZRIOCgpFTlRFUl9OT05F",
            "EAASDgoKRU5URVJfU0VMRhABEg4KCkVOVEVSX0dPVE8QAhIOCgpFTlRFUl9K",
            "VU1QEAMSDwoLRU5URVJfT1RIRVIQBBIOCgpFTlRFUl9CQUNLEAUSEQoNRU5U",
            "RVJfRFVOR0VPThAGEhgKFEVOVEVSX0RVTkdFT05fUkVQTEFZEAcSGAoURU5U",
            "RVJfR09UT19CWV9QT1JUQUwQCBITCg9FTlRFUl9TRUxGX0hPTUUQCRIUChBF",
            "TlRFUl9PVEhFUl9IT01FEAoSFwoTRU5URVJfR09UT19SRUNSRUFURRALQhiq",
            "AhVMZW1vbmFkZS5OZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Lemonade.Net.Protocol.EnterType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EnterType {
    [pbr::OriginalName("ENTER_NONE")] EnterNone = 0,
    [pbr::OriginalName("ENTER_SELF")] EnterSelf = 1,
    [pbr::OriginalName("ENTER_GOTO")] EnterGoto = 2,
    [pbr::OriginalName("ENTER_JUMP")] EnterJump = 3,
    [pbr::OriginalName("ENTER_OTHER")] EnterOther = 4,
    [pbr::OriginalName("ENTER_BACK")] EnterBack = 5,
    [pbr::OriginalName("ENTER_DUNGEON")] EnterDungeon = 6,
    [pbr::OriginalName("ENTER_DUNGEON_REPLAY")] EnterDungeonReplay = 7,
    [pbr::OriginalName("ENTER_GOTO_BY_PORTAL")] EnterGotoByPortal = 8,
    [pbr::OriginalName("ENTER_SELF_HOME")] EnterSelfHome = 9,
    [pbr::OriginalName("ENTER_OTHER_HOME")] EnterOtherHome = 10,
    [pbr::OriginalName("ENTER_GOTO_RECREATE")] EnterGotoRecreate = 11,
  }

  #endregion

}

#endregion Designer generated code
