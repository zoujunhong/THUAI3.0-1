// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageToServer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Communication.Proto {

  /// <summary>Holder for reflection information generated from MessageToServer.proto</summary>
  public static partial class MessageToServerReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageToServer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageToServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNZXNzYWdlVG9TZXJ2ZXIucHJvdG8SCFByb3RvYnVmGhVNZXNzYWdlVG9D",
            "bGllbnQucHJvdG8ilwIKD01lc3NhZ2VUb1NlcnZlchIKCgJJRBgBIAEoAxIq",
            "CgtDb21tYW5kVHlwZRgCIAEoDjIVLlByb3RvYnVmLkNvbW1hbmRUeXBlEioK",
            "DU1vdmVEaXJlY3Rpb24YAyABKA4yEy5Qcm90b2J1Zi5EaXJlY3Rpb24SFAoM",
            "TW92ZUR1cmF0aW9uGAQgASgFEhUKDVRocm93RGlzdGFuY2UYBSABKAESEgoK",
            "VGhyb3dBbmdsZRgGIAEoARITCgtJc1Rocm93RGlzaBgHIAEoCBIPCgdVc2VU",
            "eXBlGAggASgFEhEKCVNwZWFrVGV4dBgJIAEoCRISCgpQYXJhbWV0ZXIxGAog",
            "ASgFEhIKClBhcmFtZXRlcjIYCyABKAUqXQoLQ29tbWFuZFR5cGUSCAoETW92",
            "ZRAAEggKBFBpY2sQARIHCgNQdXQQAhIHCgNVc2UQAxIICgRTdG9wEAQSCQoF",
            "U3BlYWsQBRITCg9Db21tYW5kVHlwZVNpemUQBkIWqgITQ29tbXVuaWNhdGlv",
            "bi5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Communication.Proto.MessageToClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Communication.Proto.CommandType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.MessageToServer), global::Communication.Proto.MessageToServer.Parser, new[]{ "ID", "CommandType", "MoveDirection", "MoveDuration", "ThrowDistance", "ThrowAngle", "IsThrowDish", "UseType", "SpeakText", "Parameter1", "Parameter2" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CommandType {
    [pbr::OriginalName("Move")] Move = 0,
    [pbr::OriginalName("Pick")] Pick = 1,
    [pbr::OriginalName("Put")] Put = 2,
    [pbr::OriginalName("Use")] Use = 3,
    [pbr::OriginalName("Stop")] Stop = 4,
    [pbr::OriginalName("Speak")] Speak = 5,
    [pbr::OriginalName("CommandTypeSize")] Size = 6,
  }

  #endregion

  #region Messages
  public sealed partial class MessageToServer : pb::IMessage<MessageToServer> {
    private static readonly pb::MessageParser<MessageToServer> _parser = new pb::MessageParser<MessageToServer>(() => new MessageToServer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageToServer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToServer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToServer(MessageToServer other) : this() {
      iD_ = other.iD_;
      commandType_ = other.commandType_;
      moveDirection_ = other.moveDirection_;
      moveDuration_ = other.moveDuration_;
      throwDistance_ = other.throwDistance_;
      throwAngle_ = other.throwAngle_;
      isThrowDish_ = other.isThrowDish_;
      useType_ = other.useType_;
      speakText_ = other.speakText_;
      parameter1_ = other.parameter1_;
      parameter2_ = other.parameter2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToServer Clone() {
      return new MessageToServer(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private long iD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ID {
      get { return iD_; }
      set {
        iD_ = value;
      }
    }

    /// <summary>Field number for the "CommandType" field.</summary>
    public const int CommandTypeFieldNumber = 2;
    private global::Communication.Proto.CommandType commandType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.CommandType CommandType {
      get { return commandType_; }
      set {
        commandType_ = value;
      }
    }

    /// <summary>Field number for the "MoveDirection" field.</summary>
    public const int MoveDirectionFieldNumber = 3;
    private global::Communication.Proto.Direction moveDirection_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.Direction MoveDirection {
      get { return moveDirection_; }
      set {
        moveDirection_ = value;
      }
    }

    /// <summary>Field number for the "MoveDuration" field.</summary>
    public const int MoveDurationFieldNumber = 4;
    private int moveDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MoveDuration {
      get { return moveDuration_; }
      set {
        moveDuration_ = value;
      }
    }

    /// <summary>Field number for the "ThrowDistance" field.</summary>
    public const int ThrowDistanceFieldNumber = 5;
    private double throwDistance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ThrowDistance {
      get { return throwDistance_; }
      set {
        throwDistance_ = value;
      }
    }

    /// <summary>Field number for the "ThrowAngle" field.</summary>
    public const int ThrowAngleFieldNumber = 6;
    private double throwAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ThrowAngle {
      get { return throwAngle_; }
      set {
        throwAngle_ = value;
      }
    }

    /// <summary>Field number for the "IsThrowDish" field.</summary>
    public const int IsThrowDishFieldNumber = 7;
    private bool isThrowDish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsThrowDish {
      get { return isThrowDish_; }
      set {
        isThrowDish_ = value;
      }
    }

    /// <summary>Field number for the "UseType" field.</summary>
    public const int UseTypeFieldNumber = 8;
    private int useType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UseType {
      get { return useType_; }
      set {
        useType_ = value;
      }
    }

    /// <summary>Field number for the "SpeakText" field.</summary>
    public const int SpeakTextFieldNumber = 9;
    private string speakText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpeakText {
      get { return speakText_; }
      set {
        speakText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Parameter1" field.</summary>
    public const int Parameter1FieldNumber = 10;
    private int parameter1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Parameter1 {
      get { return parameter1_; }
      set {
        parameter1_ = value;
      }
    }

    /// <summary>Field number for the "Parameter2" field.</summary>
    public const int Parameter2FieldNumber = 11;
    private int parameter2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Parameter2 {
      get { return parameter2_; }
      set {
        parameter2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageToServer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageToServer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (CommandType != other.CommandType) return false;
      if (MoveDirection != other.MoveDirection) return false;
      if (MoveDuration != other.MoveDuration) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ThrowDistance, other.ThrowDistance)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ThrowAngle, other.ThrowAngle)) return false;
      if (IsThrowDish != other.IsThrowDish) return false;
      if (UseType != other.UseType) return false;
      if (SpeakText != other.SpeakText) return false;
      if (Parameter1 != other.Parameter1) return false;
      if (Parameter2 != other.Parameter2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ID != 0L) hash ^= ID.GetHashCode();
      if (CommandType != 0) hash ^= CommandType.GetHashCode();
      if (MoveDirection != 0) hash ^= MoveDirection.GetHashCode();
      if (MoveDuration != 0) hash ^= MoveDuration.GetHashCode();
      if (ThrowDistance != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ThrowDistance);
      if (ThrowAngle != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ThrowAngle);
      if (IsThrowDish != false) hash ^= IsThrowDish.GetHashCode();
      if (UseType != 0) hash ^= UseType.GetHashCode();
      if (SpeakText.Length != 0) hash ^= SpeakText.GetHashCode();
      if (Parameter1 != 0) hash ^= Parameter1.GetHashCode();
      if (Parameter2 != 0) hash ^= Parameter2.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ID != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ID);
      }
      if (CommandType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) CommandType);
      }
      if (MoveDirection != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MoveDirection);
      }
      if (MoveDuration != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MoveDuration);
      }
      if (ThrowDistance != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(ThrowDistance);
      }
      if (ThrowAngle != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(ThrowAngle);
      }
      if (IsThrowDish != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsThrowDish);
      }
      if (UseType != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(UseType);
      }
      if (SpeakText.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(SpeakText);
      }
      if (Parameter1 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Parameter1);
      }
      if (Parameter2 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Parameter2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ID);
      }
      if (CommandType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CommandType);
      }
      if (MoveDirection != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MoveDirection);
      }
      if (MoveDuration != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MoveDuration);
      }
      if (ThrowDistance != 0D) {
        size += 1 + 8;
      }
      if (ThrowAngle != 0D) {
        size += 1 + 8;
      }
      if (IsThrowDish != false) {
        size += 1 + 1;
      }
      if (UseType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UseType);
      }
      if (SpeakText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpeakText);
      }
      if (Parameter1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Parameter1);
      }
      if (Parameter2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Parameter2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageToServer other) {
      if (other == null) {
        return;
      }
      if (other.ID != 0L) {
        ID = other.ID;
      }
      if (other.CommandType != 0) {
        CommandType = other.CommandType;
      }
      if (other.MoveDirection != 0) {
        MoveDirection = other.MoveDirection;
      }
      if (other.MoveDuration != 0) {
        MoveDuration = other.MoveDuration;
      }
      if (other.ThrowDistance != 0D) {
        ThrowDistance = other.ThrowDistance;
      }
      if (other.ThrowAngle != 0D) {
        ThrowAngle = other.ThrowAngle;
      }
      if (other.IsThrowDish != false) {
        IsThrowDish = other.IsThrowDish;
      }
      if (other.UseType != 0) {
        UseType = other.UseType;
      }
      if (other.SpeakText.Length != 0) {
        SpeakText = other.SpeakText;
      }
      if (other.Parameter1 != 0) {
        Parameter1 = other.Parameter1;
      }
      if (other.Parameter2 != 0) {
        Parameter2 = other.Parameter2;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ID = input.ReadInt64();
            break;
          }
          case 16: {
            CommandType = (global::Communication.Proto.CommandType) input.ReadEnum();
            break;
          }
          case 24: {
            MoveDirection = (global::Communication.Proto.Direction) input.ReadEnum();
            break;
          }
          case 32: {
            MoveDuration = input.ReadInt32();
            break;
          }
          case 41: {
            ThrowDistance = input.ReadDouble();
            break;
          }
          case 49: {
            ThrowAngle = input.ReadDouble();
            break;
          }
          case 56: {
            IsThrowDish = input.ReadBool();
            break;
          }
          case 64: {
            UseType = input.ReadInt32();
            break;
          }
          case 74: {
            SpeakText = input.ReadString();
            break;
          }
          case 80: {
            Parameter1 = input.ReadInt32();
            break;
          }
          case 88: {
            Parameter2 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
