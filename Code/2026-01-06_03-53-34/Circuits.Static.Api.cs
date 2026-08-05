using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api.Protobuf;
using Circuits.Static.EV.Protobuf;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28D07B0", Offset = "0x28CF1B0", VA = "0x1828D07B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.Circuits_Static_Api
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28CC850", Offset = "0x28CB250", VA = "0x1828CC850", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.Static.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AbsoluteInputId : IEquatable<AbsoluteInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Id32<HGNGXYZABBE> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<DDLBQTTJVCO> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public AbsoluteInputId(Id32<HGNGXYZABBE> graphId, Id32<DDLBQTTJVCO> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28C8260", Offset = "0x28C6C60", VA = "0x1828C8260")]
		public static bool FYOQTCVQVIR(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28C81C0", Offset = "0x28C6BC0", VA = "0x1828C81C0", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28C81D0", Offset = "0x28C6BD0", VA = "0x1828C81D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28C82E0", Offset = "0x28C6CE0", VA = "0x1828C82E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28C8350", Offset = "0x28C6D50", VA = "0x1828C8350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, BYEJVEWXCEM<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<HGNGXYZABBE> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<ROIJDLVWFAY> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28C8660", Offset = "0x28C7060", VA = "0x1828C8660")]
		public AbsoluteLegacyInputId([In] Id128<HGNGXYZABBE> graphId, [In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28C84D0", Offset = "0x28C6ED0", VA = "0x1828C84D0")]
		public static bool FYOQTCVQVIR([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28C84B0", Offset = "0x28C6EB0", VA = "0x1828C84B0", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28C8650", Offset = "0x28C7050", VA = "0x1828C8650")]
		public bool QGNBNUHOAWV([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28C83F0", Offset = "0x28C6DF0", VA = "0x1828C83F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28C8590", Offset = "0x28C6F90", VA = "0x1828C8590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28C8650", Offset = "0x28C7050", VA = "0x1828C8650", Slot = "5")]
		private bool UOPVHBBJHKJ([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, BYEJVEWXCEM<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<HGNGXYZABBE> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<ACVPQTFYCHZ> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28C8660", Offset = "0x28C7060", VA = "0x1828C8660")]
		public AbsoluteLegacyOutputId([In] Id128<HGNGXYZABBE> graphId, [In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28C8760", Offset = "0x28C7160", VA = "0x1828C8760")]
		public static bool FYOQTCVQVIR([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8680", Offset = "0x28C7080", VA = "0x1828C8680", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28C88E0", Offset = "0x28C72E0", VA = "0x1828C88E0")]
		public bool QGNBNUHOAWV([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28C86A0", Offset = "0x28C70A0", VA = "0x1828C86A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28C8820", Offset = "0x28C7220", VA = "0x1828C8820", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28C88E0", Offset = "0x28C72E0", VA = "0x1828C88E0", Slot = "5")]
		private bool IGBOZGUBUTO([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<HGNGXYZABBE> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28C8A80", Offset = "0x28C7480", VA = "0x1828C8A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public AbsoluteNodeId(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28C8990", Offset = "0x28C7390", VA = "0x1828C8990")]
		public static bool FYOQTCVQVIR(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28C8980", Offset = "0x28C7380", VA = "0x1828C8980", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28C88F0", Offset = "0x28C72F0", VA = "0x1828C88F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28C8A10", Offset = "0x28C7410", VA = "0x1828C8A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct AbsoluteOutputId : IEquatable<AbsoluteOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly Id32<HGNGXYZABBE> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<XDQQSNHTXDZ> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public AbsoluteOutputId(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28C8BC0", Offset = "0x28C75C0", VA = "0x1828C8BC0")]
		public static bool FYOQTCVQVIR(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B20", Offset = "0x28C7520", VA = "0x1828C8B20", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28C8B30", Offset = "0x28C7530", VA = "0x1828C8B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28C8C40", Offset = "0x28C7640", VA = "0x1828C8C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28C8CB0", Offset = "0x28C76B0", VA = "0x1828C8CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum BoardAttachmentMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Follow,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Orbit,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Attached,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Detached
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum CanSaveObjectIntoInventionResultType
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Failure_Generic,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Failure_StudioObjectInInternalRoom,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Failure_StudioObjectInTestSubroom,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Failure_StudioObjectInSingleBundleRoom,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Failure_StudioObjectContainsVideoPlayer,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Failure_StudioObjectRequiresModeration_NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Failure_StudioObjectRequiresModeration_Pending,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Failure_StudioObjectRequiresModeration_Denied,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Failure_StudioObjectRequiresModeration_ModeratorPending,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Failure_StudioObjectRequiresModeration_ModeratorDenied
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct CircuitsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CircuitsRoomData RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CircuitsSuperRoomData SuperRoomData;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E80", Offset = "0x28C7880", VA = "0x1828C8E80")]
		public CircuitsData([In] CircuitsRoomData roomData, CircuitsSuperRoomData superRoomData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct CircuitsRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CircuitRootData CV2RootData;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		public CircuitsRoomData(CircuitRootData cv2RootData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CircuitsSuperRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly SuperRoomData CV2SuperRoomData;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		public CircuitsSuperRoomData(SuperRoomData cv2SuperRoomData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct CircuitsTemplateData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly CircuitTemplateRootData CV2TemplateData;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
		public CircuitsTemplateData(CircuitTemplateRootData cv2TemplateData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum CircuitsUICharacterValidationKind
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Digit,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Integer,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Decimal,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Alphanumeric,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Name,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Regex,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		EmailAddress,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CustomValidator
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CircuitsUIContentKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Autocorrected,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		IntegerNumber,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		DecimalNumber,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Alphanumeric,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Name,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		EmailAddress,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Password,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Pin,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Custom
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct CircuitsValidationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly string LogGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public readonly string ReportAnalyticGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly string PreventOperationGameConfigKey;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1BBF210", Offset = "0x1BBDC10", VA = "0x181BBF210")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CircuitTypeIdWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<GBNADADGGBI> TypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly IReadOnlyList<CircuitTypeIdWrapper>? TypeParameterAssignments;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x16C88D0", Offset = "0x16C72D0", VA = "0x1816C88D0")]
		private CircuitTypeIdWrapper(Id32<GBNADADGGBI> typeId, IReadOnlyList<CircuitTypeIdWrapper>? typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28C8E50", Offset = "0x28C7850", VA = "0x1828C8E50")]
		public static CircuitTypeIdWrapper ZNVACXJAEPL(Id32<GBNADADGGBI> typeId)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D50", Offset = "0x28C7750", VA = "0x1828C8D50")]
		public static CircuitTypeIdWrapper KNWOLUSLYFH(Id32<GBNADADGGBI> typeId, IReadOnlyList<CircuitTypeIdWrapper> a)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28C8D80", Offset = "0x28C7780", VA = "0x1828C8D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ConfigMenuStringPurificationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate Task<bool> IsPureMethod(string? value, string context);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EQQHSUUAGWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod LHGFIJJPHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string ZJYUDPTNQRI;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public EQQHSUUAGWY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x28C9520", Offset = "0x28C7F20", VA = "0x1828C9520")]
			internal Task<bool> IEPWQYBNDHN(string? value)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <RequestNewValue>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string newRequestedValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public ConfigMenuStringPurificationHelper <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private CancellationTokenSource <thisRequestDelay>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private bool? <isPureResponse>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Exception <isPureEx>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private YieldAwaitable.YieldAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private TaskAwaiter<bool> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x28D3E10", Offset = "0x28D2810", VA = "0x1828D3E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB16840", Offset = "0xB15240", VA = "0x180B16840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private struct <WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public ConfigMenuStringPurificationHelper[] purifiers;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private TaskAwaiter<Task> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x28D5E40", Offset = "0x28D4840", VA = "0x1828D5E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28D62B0", Offset = "0x28D4CB0", VA = "0x1828D62B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> LHGFIJJPHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? ONSYSCJZYJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? DMBNONCNGDK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? ERZQAPMLTIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAB8600", Offset = "0xAB7000", VA = "0x180AB8600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? MYFFOFBQXMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? BMRCCQWACEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? FVYMLZLFFIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xABECD0", Offset = "0xABD6D0", VA = "0x180ABECD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? QEIYSCKHYKF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KPFKEUKRNFK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB52320", Offset = "0xB50D20", VA = "0x180B52320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB52370", Offset = "0xB50D70", VA = "0x180B52370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28C92E0", Offset = "0x28C7CE0", VA = "0x1828C92E0")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28C9080", Offset = "0x28C7A80", VA = "0x1828C9080")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void LJPUYLGPZHB(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28C8EC0", Offset = "0x28C78C0", VA = "0x1828C8EC0")]
		public Task CVNIBOELWGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28C9160", Offset = "0x28C7B60", VA = "0x1828C9160")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> WIHCNYYRMHS(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		CanNotInteract
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface QMUGMMRJQCS : BJVTKGNMWXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface GBGLXJBMWFR : ZVHRCDIYKZX
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QIGWDZOASAM();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface BJVTKGNMWXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface JHXDHZUYQRX
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface SIOXGANVAXN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface SRAGZQOPWOI : ZVHRCDIYKZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OYJSQOJICUM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface OMXFUPNKYAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string RCXCIUJITOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int GDOAJPFFSYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool NDDBQOUAYNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface YGGWALGXGZC : ZVHRCDIYKZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(ZVHRCDIYKZX ui);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(ZVHRCDIYKZX ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface LFQGMYIQDQG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TPGMYQYEEUQ(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PTQKZCYRTPT(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GXOGPIVHJHE(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CSZKFFUGBIG(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RWTDHMJPDTO(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JGMYYYIVIWW(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WSUVGLFNJMF(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface DMEQLXBHOSG
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum StandardButtonType
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Delete,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Edit
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface ZBZBYSLRZFG
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool IVGNKBYSBHC
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void Dismiss();

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void BYPSVRIYVZP();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface LIRROCRVXCO
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string QUPWATBAHBR
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			OOPCSIVBRMA EUIQEITMGUE
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? FLQXYCWLVUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			RWMGIRAZNGU? DIBXATAVYBT
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool IVGNKBYSBHC
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void DFVOHARDOLD();

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void TZKJBBOVUFC();

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void EZRKODSLNHM(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface OJBXHTLAMLP
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<DMEQLXBHOSG>? DUKDZRGJVBR
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			ZVHRCDIYKZX VJKVNIDIRSB(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		OJBXHTLAMLP Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ZVHRCDIYKZX ORJFZYZCLRF(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZVHRCDIYKZX XNZDLBWZEPE(IReadOnlyList<ZVHRCDIYKZX> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZVHRCDIYKZX SSYLFPBIWGI(IReadOnlyList<ZVHRCDIYKZX> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZVHRCDIYKZX IZLCHQYSVBS(Func<int> a, Func<int, Task<bool>> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		ZVHRCDIYKZX RDHBTKYLTQW(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		ZVHRCDIYKZX EFLPJWPMKUE(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		ZVHRCDIYKZX FAHNVLKWQSM(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		ZVHRCDIYKZX BTRNRXKDAEC(Func<Id128<HGNGXYZABBE>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		ZVHRCDIYKZX HFIONLZVKGK(ZVHRCDIYKZX a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		YGGWALGXGZC WVCDSBKXFUA(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<ZVHRCDIYKZX>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ZVHRCDIYKZX HINVOEOSJNZ(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ZVHRCDIYKZX QQBQDPANSDP(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ZVHRCDIYKZX WRKQFEJUWDH(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ZVHRCDIYKZX OYWNRDAPCSC(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ZVHRCDIYKZX PQNFWFZGSGQ(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		ZVHRCDIYKZX KDEWKCWBRBV(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		ZVHRCDIYKZX HLQLETRRINP(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		ZVHRCDIYKZX XDUOUQGVVCE(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<ZVHRCDIYKZX>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		ZVHRCDIYKZX VMHXVQTPLSX(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		ZVHRCDIYKZX MBWTDVXJDVY(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		ZVHRCDIYKZX LSSTMYUTAMA(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		GBGLXJBMWFR JONHYLTEVIP(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		GBGLXJBMWFR OOQYBEQWAOA(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		ZVHRCDIYKZX IHYGVNSZXSK(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		ZVHRCDIYKZX ZEAWCUFQIJS(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SRAGZQOPWOI FXCMIWIICGH(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<ZVHRCDIYKZX>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void FWNHPUEHMEA(ZVHRCDIYKZX a);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void IADETDBKTYE(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void BXNJJNDRKWC(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<ZVHRCDIYKZX>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		ZBZBYSLRZFG OWOMSEATBGH(string a, IReadOnlyList<ZVHRCDIYKZX> b, [Optional] IReadOnlyList<ZVHRCDIYKZX>? headerElements, [Optional] IReadOnlyList<ZVHRCDIYKZX>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		LIRROCRVXCO BSWFRFRABZJ(string a, string b, OOPCSIVBRMA c, Action<LIRROCRVXCO> d, int e = 160, [Optional] (Func<OOPCSIVBRMA, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, RWMGIRAZNGU InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void GMDNEUIBDQV(string a);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "33")]
		ZVHRCDIYKZX KKPBVEYUTWC(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ZVHRCDIYKZX PXDAMTFCDEZ<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "35")]
		ZVHRCDIYKZX TORMLUMLBVL(Func<string> a, Action<string> b, string c = "", string d = "");

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "36")]
		ZVHRCDIYKZX WKYKFPWAUKH(Func<string?> imageGetter, Func<bool>? isModifiedGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface ZVHRCDIYKZX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WZMFMVXTLKD();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface QIPHLRTQMME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface OUYXYYIBUAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JRGSLEAMDYZ();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WTMEGQUZFCS(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MVEUDVSRFKL(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WQZDIZZKEQU(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface QJQTDEDCOEW : AGEZPYTJJRF, PWKRFVXRRZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind FAURZZYQYPT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface CIDJNEKANPP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface FWQHNCKMARH
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool HJGTSRVFTYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool ZWDGIBXOXJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool FOZMZQFJJXA(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType WCNGMWKOWDF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool BFVUHSTQQRU(Id128<PYVBRMOVXVY> nodeDefId, Id128<HGNGXYZABBE>? legacyInnerGraphId, IReadOnlyDictionary<Id128<HGNGXYZABBE>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ZJRHLTUWUTP(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MNSIVOSNBKZ(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface RELELJKAIXW
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		UPTKEAZFDLV? GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool TJKEYWRTYVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool HXDXPWWMQGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<UPTKEAZFDLV> FMGLEFFYGKS();

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, PWKRFVXRRZL> CWWXRPSBKRU([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<HGNGXYZABBE>, Guid> SWSGRYWHVUY(IEnumerable<WSAKIWWEIUX> a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData ZJKJKRJEIIS(IEnumerable<WSAKIWWEIUX> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface EOZAANGJUTW
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VVGKWJTAHMC(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XVBHMRMGGLI(Id32<TRQHAQEUOWK> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KQQENWFRACI(Id32<TRQHAQEUOWK> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnObjectPropertiesRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnPlayerPropertiesRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OnEditGraphDidPush();

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OnEditGraphDidPop();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface UPTKEAZFDLV
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public readonly struct PrepareTemplateForCloneArgs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public readonly TemplateSerializationReason SerializationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public readonly CircuitsTemplateData CircuitsTemplateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public readonly IEnumerable<WSAKIWWEIUX> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<HGNGXYZABBE> SpawnIntoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public readonly int? MakerPenInteractionFilterKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public readonly CircuitsRigidTransform? SpawnTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public readonly CircuitsRigidTransform? OriginTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly PrepareTemplateForCloneNewInventionArgs? InventionArgs;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x28D08E0", Offset = "0x28CF2E0", VA = "0x1828D08E0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<WSAKIWWEIUX> persistenceViews, bool assignNewIds, [In] Id128<HGNGXYZABBE> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public readonly struct PrepareTemplateForCloneNewInventionArgs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public readonly IReadOnlyCollection<ByteString> ValidRoomConsumables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly IReadOnlyCollection<ByteString> ValidRoomCurrencies;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public readonly IReadOnlyCollection<ByteString> ValidRoomKeys;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x1BBF210", Offset = "0x1BBDC10", VA = "0x181BBF210")]
			public PrepareTemplateForCloneNewInventionArgs(IReadOnlyCollection<ByteString> validRoomConsumables, IReadOnlyCollection<ByteString> validRoomCurrencies, IReadOnlyCollection<ByteString> validRoomKeys)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public readonly struct PrepareTemplateForCloneResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public readonly CircuitsTemplateData CircuitsTemplateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public readonly IReadOnlyDictionary<Guid, Guid> RemappedGuids;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x28D0990", Offset = "0x28CF390", VA = "0x1828D0990")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<HGNGXYZABBE> VYGKHSYILHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers IYONQLGGJMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> SFRGVUJZXAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DLHDOXVYAJY;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> OYAYUXGLDES;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) VOVIEGIBBUH(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QWXIPILYIJY(Id32<HGNGXYZABBE> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IPTLJUJLYPS(QOQQUQJTODC a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ECVMFWUFOEX(BRHIPGXJTAN a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? EUAGAYYYRBO(Id32<HGNGXYZABBE> graphId, Id32<DDLBQTTJVCO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? UZMKFNLMAJB(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<XDQQSNHTXDZ>? AEDTBBJKWPD(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<DDLBQTTJVCO>? UZIXXGYXOOS(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<HGNGXYZABBE>> MHCGHONVQUK();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<TRQHAQEUOWK>> BDOLGQHMXON();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Id32<TRQHAQEUOWK>? KLVFWAMDTTR(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int OOJJIVDMFMC(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int QZEHPGSFOEP(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(CircuitTypeIdWrapper, string)[] WGUTXAQZXHS(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(CircuitTypeIdWrapper, string)[] LKALNUFXQTL(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string EVRZTNXQGWP(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string NIKDUKADJYZ(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		string FOMFNSXJWAK(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		VIGUMLGGXIU? UTZDJIQGUYP([In] Id128<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		VIGUMLGGXIU? UTZDJIQGUYP(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Id32<HGNGXYZABBE> XUTGLCKIKWO([In] Id128<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Id32<HGNGXYZABBE>? IMKVYFWJBDI([In] Id128<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Id32<HGNGXYZABBE>? AXASXQHPZMR(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CWRBORGFPZK? WQQUKUHPEMV([In] Id128<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Id32<HKRBMAIBFCN> QCWHXOPDRGZ(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Id32<XEUKGISKBDU> FCZESSKWRJC(Id32<HGNGXYZABBE> graphId, [In] Id128<XEUKGISKBDU> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		AbsoluteNodeId? ASPQMBKJBCW(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		long KJOMQKJEOPB();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IEnumerable<NewStaticEdge> DPFPKAGVKHH(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool PIKFIEFRASZ(Id32<TRQHAQEUOWK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "32")]
		IEnumerable<StableStaticEdge> DXBTEECNBZD(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "33")]
		IEnumerable<StableStaticEdge> WCSHTGHUQXO(Id32<HGNGXYZABBE> graphId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<(Id32<HGNGXYZABBE>, Id32<XEUKGISKBDU>)> HJQPEKZLZYB(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Id32<DDLBQTTJVCO> UZIXXGYXOOS(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<WUKYKCWFUPU> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Id32<XEUKGISKBDU> AJSNPMCTTLX(Id32<HGNGXYZABBE> graphId, Id32<DDLBQTTJVCO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id32<XEUKGISKBDU> NYTDWWFUTZC(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id32<XDQQSNHTXDZ> AEDTBBJKWPD(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<WKRIGIGZTCZ> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "39")]
		IEnumerable<CQFPEXFLRFV> WOGGIKDVVRP(RoomVersion a, bool b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CQFPEXFLRFV NUZKWQEFBOQ(RoomVersion a, KPRJDCDAPVJ b, bool c, bool d, bool e, bool f, bool g);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "41")]
		NewStaticEdge GEROYERWZVM(Id32<HGNGXYZABBE> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Id128<HGNGXYZABBE> CROJMBIKCKH(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Id128<XEUKGISKBDU> FWHJFOZDDSH(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "44")]
		StableStaticEdge ZKPKIAWZRWP(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, AGEZPYTJJRF>> EJJFSQPZSJE(Id32<HGNGXYZABBE> parentGraphId, Id32<XEUKGISKBDU> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<Result<None, AGEZPYTJJRF>> ZXSCIJRIEIX(Id32<HGNGXYZABBE> parentGraphId, Id128<XEUKGISKBDU> boardNodeId, List<Id32<XEUKGISKBDU>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "47")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<MZMEHEUCWDG>, Id32<ROIJDLVWFAY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<MZMEHEUCWDG>, Id32<ACVPQTFYCHZ>)>) GQURLVLDMYR(Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task ZCCXECZJNWT(Id128<HGNGXYZABBE> legacyGraphId, Id128<XEUKGISKBDU> boardNodeId, IReadOnlyList<Id128<XEUKGISKBDU>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<MZMEHEUCWDG>, Id32<ROIJDLVWFAY>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<MZMEHEUCWDG>, Id32<ACVPQTFYCHZ>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<Result<None, AGEZPYTJJRF>> AACZIQRNDKA(Id32<HGNGXYZABBE> parentGraphId, Id128<XEUKGISKBDU> boardNodeId, List<Id32<XEUKGISKBDU>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, AGEZPYTJJRF>> ZACDZMKESDO(Id32<HGNGXYZABBE> parentGraphId, Id128<XEUKGISKBDU> boardNodeId, Id32<HGNGXYZABBE> graphId, List<Id32<XEUKGISKBDU>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool PTXKDIXABHB(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool IHNRSBIYJED(Id32<HGNGXYZABBE> graphId, Id32<DDLBQTTJVCO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool HFQGSAKINGQ(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Result<PrepareTemplateForCloneResult, QJQTDEDCOEW> WFOBHCRLYLO([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, AGEZPYTJJRF>> PVZHISSEKPE(Id32<HGNGXYZABBE> graphId, Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<Id32<XEUKGISKBDU>, AGEZPYTJJRF>> PDBITONQUIH(Id32<HGNGXYZABBE> graphId, Id32<HKRBMAIBFCN> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> SQTTISLYKLM(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Result<ControlPanelRootData, PWKRFVXRRZL> EKTRBVJKYLC(Id128<HGNGXYZABBE> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Result<None, AGEZPYTJJRF>> YCDOYEDEZQE(Id128<HGNGXYZABBE> graphId, Id128<XEUKGISKBDU> inputNodeId, Id32<MZMEHEUCWDG> inputPortGroupId, Id32<ROIJDLVWFAY> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "60")]
		Task<Result<None, AGEZPYTJJRF>> HGRYUHBXLPF(Id128<HGNGXYZABBE> graphId, Id128<XEUKGISKBDU> outputNodeId, Id32<MZMEHEUCWDG> outputPortGroupId, Id32<ACVPQTFYCHZ> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "61")]
		Task<Result<None, AGEZPYTJJRF>> QIPYXXLWGNO(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		Task<Result<IEnumerable<Id128<XEUKGISKBDU>>, AGEZPYTJJRF>> ZKOIKISNGWV(Id128<HGNGXYZABBE> intoGraphId, CircuitTemplateRootData a, IEnumerable<WSAKIWWEIUX> b);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		CircuitsData NEUWDYZYFNB();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "64")]
		CircuitsData AEHSLMKNTPM();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "65")]
		CircuitsTemplateData XETJNDSVIDG(TemplateSerializationReason a, Id32<HGNGXYZABBE> sourceGraphId, IEnumerable<Id128<XEUKGISKBDU>> nodeIds, IEnumerable<WSAKIWWEIUX> b, ISet<Id128<EYUKRRPOQNQ>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "66")]
		CircuitsTemplateData XETJNDSVIDG(TemplateSerializationReason a, Id32<HGNGXYZABBE> sourceGraphId, IEnumerable<Id32<XEUKGISKBDU>> nodeIds, IEnumerable<WSAKIWWEIUX> b, ISet<Id128<EYUKRRPOQNQ>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "67")]
		CircuitsTemplateData JGIPMQVCIWJ(TemplateSerializationReason a, Id32<HGNGXYZABBE> sourceGraphId, IEnumerable<Id128<HGNGXYZABBE>> graphIds, IEnumerable<Id128<XEUKGISKBDU>> nodeIds, ISet<Id128<EYUKRRPOQNQ>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "68")]
		List<JHXDHZUYQRX> OMAQINYGZHD();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "69")]
		(List<JHXDHZUYQRX>, bool) ZZTBHDJDJAQ([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, MTYFAQDZYHV b, WCHWBGPTGBX c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool MQBWEVIDRER(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool PZQTBSNGNCL(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Result<Id32<XDQQSNHTXDZ>?, AGEZPYTJJRF> TXZLIVCUDIO(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<DDLBQTTJVCO> inputId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Result<Id32<DDLBQTTJVCO>?, AGEZPYTJJRF> RVVBVLTCKIC(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<XDQQSNHTXDZ> outputId);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task<Result<None, AGEZPYTJJRF>> NWNOGHAHJFZ();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task<Result<None, AGEZPYTJJRF>> KQERASBVEJR(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Id32<XEUKGISKBDU>? HTIWSHZFAUV(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Id32<XEUKGISKBDU>? FQYSHPSISMK(Id32<HGNGXYZABBE> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		int MNOHUDKTMXO(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int USIYYVVQBFD(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "80")]
		int IBSYHXRMAAW(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<MVFYUYOJMFL> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "81")]
		int KBCQBDHHAWQ(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<MVFYUYOJMFL> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "82")]
		Task<Result<None, AGEZPYTJJRF>> BCXWPNCDMTA(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<MVFYUYOJMFL> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "83")]
		Task<Result<None, AGEZPYTJJRF>> AHCJDOOOWID(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<MVFYUYOJMFL> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "84")]
		int ZNELAFBMUUK(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<None, AGEZPYTJJRF>> PIOOXXCOFWI(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "86")]
		Task<Result<None, AGEZPYTJJRF>> TUAZPWVGFER(Id32<HGNGXYZABBE> graphId, Id32<XEUKGISKBDU> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "87")]
		bool IGHHCFZXCAU();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IEnumerable<Id32<KJYTNNYIDBW>> RPPGGYUHCAQ();

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		string? MQZWGYTFWUU(Id32<KJYTNNYIDBW> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface HBLQBAPLGFR : WMXFPDHFSSW
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		RELELJKAIXW JGWYLVIJGXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface AGEZPYTJJRF : PWKRFVXRRZL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface VIGUMLGGXIU
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<HGNGXYZABBE>? SGVGZQWIXQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<HGNGXYZABBE> MLNCKPSSGRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<XEUKGISKBDU>? XCPBDPFTJKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? SAYHDSAJLMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface QOQQUQJTODC : KPRJDCDAPVJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<ROIJDLVWFAY> DEZMUZENOAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<DDLBQTTJVCO> ROBTNWODJUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool RXBAYTNNZKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PPUFQHOZJAN(QIPHLRTQMME a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IVZHYMXWARC(LFQGMYIQDQG a);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ZRYGGPBQAHP(int a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CPYDJXALMOO(FZKDYBILLCY a);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void QKRAZFRIFPH(FZKDYBILLCY a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface FZKDYBILLCY
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface CWRBORGFPZK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<PYVBRMOVXVY> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<HKRBMAIBFCN> NewNodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool ShowName
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CircuitsColor CircuitsEmissionColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		string StaticName
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NodeVisualizationKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Id32<VISMDLBISYT> IconId
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool IsRoomAssetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool IsRegisteredToEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool IsObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		MemoryType VariableMemoryType
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool CanClone
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool CanModifyWithMakerPen
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		int MakerPenInteractionFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool IsRoomContributorLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		CanSaveObjectIntoInventionResultType CanSaveIntoInventions
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool CanPublishInInventions
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool IsDeprecating
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool SupportsCustomEditControls
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool CanPlaceInCircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool IsBeingEdited
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		CircuitsVec3 LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		CircuitsQuat LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool IsFrozen
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[MemberNotNullWhen(true, "FloatingText")]
		bool HasFloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "51")]
			[MemberNotNullWhen(true, "FloatingText")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		OMXFUPNKYAL? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<HGNGXYZABBE> GraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		bool IsBusNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "56")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		Id32<HGNGXYZABBE>? InnerGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool IsProxyNode
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Id32<HGNGXYZABBE>? ProxyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool IsProxyTargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		IEnumerable<Id128<XEUKGISKBDU>>? InnerGraphNodeIds
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool IsPositionAttachedToObject
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool IsParentPreviewGraph
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "63")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		Id128<HGNGXYZABBE> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<XEUKGISKBDU> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<XEUKGISKBDU> LegacyNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		string PaletteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		ReadOnlyIdArray<MZMEHEUCWDG, PVHQAXUIWYW> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<MZMEHEUCWDG>? SelfPortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool CanAddRemovePortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(Slot = "89")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool IncludeExecInPortConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action WKTCODEYBUO;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate FTDHXRXDJWP;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate GPPAKNSYYJW;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action USERMQDQZUI;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action VKDQAVBREOB;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<MZMEHEUCWDG>, PVHQAXUIWYW> ZIHQBQTWTXW;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<MZMEHEUCWDG>> QQQQKDTXMAZ;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<MZMEHEUCWDG>, PVHQAXUIWYW> DLHVWXZRJHN;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<MZMEHEUCWDG>, Id32<MZMEHEUCWDG>> OPVPBUQVCBS;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<MZMEHEUCWDG>, PVHQAXUIWYW> LFBSOCGGONC;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<MZMEHEUCWDG>, Id32<MZMEHEUCWDG>> JYTLNJUQCKT;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> FEUSXEWBPQA;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Result<None, AGEZPYTJJRF>> NOKDXAQNCQH(int a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool GGROTDXLYPJ([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool FLABEYWUPKC([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void XZHCNKZRWDY(bool a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task KVMDMSYPUTE();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, AGEZPYTJJRF>> ICLBUBOUKPL(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void VVKKCNWGUGO();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool BUJFGYGCSXH([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool BRKBJSCNMUG([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void IOLMWBFPSJC(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "50")]
		BJVTKGNMWXJ FXVPRXDDXKY([In] QMUGMMRJQCS audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<MZMEHEUCWDG>, AGEZPYTJJRF>> DRXPOKMBCXS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void IVZHYMXWARC(DMEQLXBHOSG a);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform EQKJZEDPSOV();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool SJMZRWXCOFH(Id32<MZMEHEUCWDG> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, AGEZPYTJJRF>> EKPLFKCPEIT(Id32<MZMEHEUCWDG> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool JYEKKTUXLVT(Id32<MZMEHEUCWDG> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void UYCUZWYDFST();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void SPPIOIXYPTP(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void ETZSZGYEFIG(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void HKYTPGFECCK(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void AWQUFXDXSAD(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void QOXMRUCWEJS(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void SAJPHSEWLMR(Id32<MZMEHEUCWDG> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void GFWGIPMERPH(Id32<MZMEHEUCWDG> sourceId, Id32<MZMEHEUCWDG> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void NMKQSYYEFSW(Id32<MZMEHEUCWDG> sourceId, Id32<MZMEHEUCWDG> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void SDUECSKWUHA(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface BRHIPGXJTAN : KPRJDCDAPVJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<XDQQSNHTXDZ> OXIXWGSDUXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<ACVPQTFYCHZ> HPUAGGNRHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface KPRJDCDAPVJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> XGONUEKARFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind CEGLZSODFKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<HGNGXYZABBE> MLNCKPSSGRS
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<HGNGXYZABBE> SYJBTZXHXAR
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<XEUKGISKBDU> FYPBBOBPXVH
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<MZMEHEUCWDG> ZFPSBUYMVGC
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<ZCTNCNEQXLD> HHTYOYJFTWE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		OOPCSIVBRMA HWBORMRVATO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage DONXQFACVBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool KEYARYIOZQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void QMASKABEBTM(GPAVTZEIDXJ a);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void KBIDNUKCYNS(WKVLDSNUOXT a);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PAQBCPRKCYU(OUYXYYIBUAJ a);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AYQLZJOWLHR(GPAVTZEIDXJ a);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ZGGJFZBKILL(WKVLDSNUOXT a);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void MSAZTZWTFZX(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface GPAVTZEIDXJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface PVHQAXUIWYW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<MZMEHEUCWDG> newValue, Id32<MZMEHEUCWDG> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool FSNISRGTHZR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool FZEQGQGTLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool RNJLATFAEMW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<HGNGXYZABBE> SYJBTZXHXAR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool ZDUXOHSUPTO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<ROIJDLVWFAY, QOQQUQJTODC> GBJFEFJTTQS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<XEUKGISKBDU> FYPBBOBPXVH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<ACVPQTFYCHZ, BRHIPGXJTAN> EUWVXCNNXAT
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<MZMEHEUCWDG> ZFPSBUYMVGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action CCXDCPNUNDG;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action PRFCYYDZZBV;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<ROIJDLVWFAY>, Id32<ROIJDLVWFAY>> ANMQFVYKFDG;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<ROIJDLVWFAY>, Id32<ROIJDLVWFAY>> QSRETFJPQCR;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<ACVPQTFYCHZ>, Id32<ACVPQTFYCHZ>> BUSTAMGNITJ;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<ACVPQTFYCHZ>, Id32<ACVPQTFYCHZ>> CKDKBLLZFPK;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<ROIJDLVWFAY>, QOQQUQJTODC> ZOFLLIBEFGF;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<ROIJDLVWFAY>> EYKTJMEUPZM;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<ROIJDLVWFAY>, QOQQUQJTODC> AVTTEWBRSUF;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<ACVPQTFYCHZ>, BRHIPGXJTAN> UFWWWQLVYGE;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<ACVPQTFYCHZ>> KNBTRGVLMMB;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<ACVPQTFYCHZ>, BRHIPGXJTAN> YZJNNTBKSAU;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, AGEZPYTJJRF>> NBTQLOZSXYZ();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, AGEZPYTJJRF>> KPFOVLKWAAU(Id32<MVFYUYOJMFL> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, AGEZPYTJJRF>> VJPVFOSJSYZ(Id32<DHFDVCDFXUO> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, AGEZPYTJJRF>> LVUXJQGKUOO(Id32<MVFYUYOJMFL> inputDefId, Id32<MVFYUYOJMFL> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, AGEZPYTJJRF>> XFTGULJFSNT(Id32<DHFDVCDFXUO> outputDefId, Id32<DHFDVCDFXUO> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, AGEZPYTJJRF>> SJINOYTGJRA();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, AGEZPYTJJRF>> ZJIYFDNZETT(string a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, AGEZPYTJJRF>> HYVLKIKSTWW(Id32<MVFYUYOJMFL> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, AGEZPYTJJRF>> YXQLWSATJJR(Id32<DHFDVCDFXUO> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, AGEZPYTJJRF>> CLIGSHPOHTT(Id32<MVFYUYOJMFL> inputDefId, CQFPEXFLRFV a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, AGEZPYTJJRF>> XWAGMHTZPAO(Id32<DHFDVCDFXUO> outputDefId, CQFPEXFLRFV a);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void FOUIKIUUZBY(int a, Id32<ROIJDLVWFAY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void HQOIBSRBKPZ(int a, Id32<ROIJDLVWFAY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void THJHHJVFNQZ(int a, Id32<ACVPQTFYCHZ> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void NCWCXPMOBVA(int a, Id32<ACVPQTFYCHZ> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void REFYHSUQBNJ(int a, Id32<ROIJDLVWFAY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void KNECZEMSTVW(int a, Id32<ROIJDLVWFAY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void ZYADPJCOUZI(int a, Id32<ACVPQTFYCHZ> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void FFRYCIEBYQX(int a, Id32<ACVPQTFYCHZ> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void KRKTYFCWQZB(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void YISWSCVHLDW(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void PRZPRDWKOPY(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void TMDOHGGMQDZ(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void LSNHXAICWSZ(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void IDPKCQCXMZS(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void IYXLMYOSAMI(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void PWVDDZDZMJF(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void IUNGSCONKTS(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void YRYLTMJZSQL(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void OCUZUXBELBX(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void SUWPJAPZHPK(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface CQFPEXFLRFV
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey TMGDDGGRYVI
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string YLMLMIVSESM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<MVFYUYOJMFL>, AGEZPYTJJRF>> DXLTOZQRQVX(Id128<HGNGXYZABBE> graphId, Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<DHFDVCDFXUO>, AGEZPYTJJRF>> AXKRFMDMYVM(Id128<HGNGXYZABBE> graphId, Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface WKVLDSNUOXT
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RRHDPUUGVKJ([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface OOPCSIVBRMA
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class LegacyEdgeMissingError : JHXDHZUYQRX, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<XEUKGISKBDU> BWNDIWFDBXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<XEUKGISKBDU> YLYQLBUJTVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<XEUKGISKBDU> QHFBYHHUYNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<XEUKGISKBDU> QUPFGMVYMCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<DDLBQTTJVCO> AOZUMMSGRPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<XDQQSNHTXDZ> EYYVHPHJKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string LPDWCHCZFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string XDXZOMOPRQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x28C98C0", Offset = "0x28C82C0", VA = "0x1828C98C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28C98F0", Offset = "0x28C82F0", VA = "0x1828C98F0")]
		public LegacyEdgeMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> srcNodeId, [In] Id128<XEUKGISKBDU> srcLegacyNodeId, Id32<XEUKGISKBDU> dstNodeId, [In] Id128<XEUKGISKBDU> dstLegacyNodeId, Id32<DDLBQTTJVCO> inputPort, Id32<XDQQSNHTXDZ> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x28C95C0", Offset = "0x28C7FC0", VA = "0x1828C95C0", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x28C9550", Offset = "0x28C7F50", VA = "0x1828C9550", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x28C9740", Offset = "0x28C8140", VA = "0x1828C9740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : JHXDHZUYQRX, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x28C9FB0", Offset = "0x28C89B0", VA = "0x1828C9FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x28C9FE0", Offset = "0x28C89E0", VA = "0x1828C9FE0")]
		public LegacyGraphMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x28C9DF0", Offset = "0x28C87F0", VA = "0x1828C9DF0", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x28C9E80", Offset = "0x28C8880", VA = "0x1828C9E80", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x28C9F40", Offset = "0x28C8940", VA = "0x1828C9F40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, BYEJVEWXCEM<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<ROIJDLVWFAY> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x283FF20", Offset = "0x283E920", VA = "0x18283FF20")]
		public LegacyInputId([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ROIJDLVWFAY> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28CA240", Offset = "0x28C8C40", VA = "0x1828CA240")]
		public static bool FYOQTCVQVIR([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28CA100", Offset = "0x28C8B00", VA = "0x1828CA100", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28CA370", Offset = "0x28C8D70", VA = "0x1828CA370")]
		public bool QGNBNUHOAWV([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x28CA120", Offset = "0x28C8B20", VA = "0x1828CA120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x28CA2E0", Offset = "0x28C8CE0", VA = "0x1828CA2E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x28CA370", Offset = "0x28C8D70", VA = "0x1828CA370", Slot = "5")]
		private bool USZVRGHPPOK([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : JHXDHZUYQRX, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<DDLBQTTJVCO> RYNBEBFEMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<DDLBQTTJVCO> EJKXXWTPNFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int YXVQNZRZXPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x28CA730", Offset = "0x28C9130", VA = "0x1828CA730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x28CA760", Offset = "0x28C9160", VA = "0x1828CA760")]
		public LegacyInputIncorrectIdError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, Id32<DDLBQTTJVCO> expectedInputId, Id32<DDLBQTTJVCO> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x28CA380", Offset = "0x28C8D80", VA = "0x1828CA380", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x28CA4B0", Offset = "0x28C8EB0", VA = "0x1828CA4B0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x28CA640", Offset = "0x28C9040", VA = "0x1828CA640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : JHXDHZUYQRX, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int XMYSLBCVCNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int IQURTKWZEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x28CAE20", Offset = "0x28C9820", VA = "0x1828CAE20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x28CAE50", Offset = "0x28C9850", VA = "0x1828CAE50")]
		public LegacyInputMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x28CAB20", Offset = "0x28C9520", VA = "0x1828CAB20", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x28CAC10", Offset = "0x28C9610", VA = "0x1828CAC10", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x28CAD40", Offset = "0x28C9740", VA = "0x1828CAD40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : JHXDHZUYQRX, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly Id32<HKRBMAIBFCN> LELRLDEWYRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28CB4A0", Offset = "0x28C9EA0", VA = "0x1828CB4A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4D0", Offset = "0x28C9ED0", VA = "0x1828CB4D0")]
		public LegacyNodeMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, Id32<HKRBMAIBFCN> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x28CB2C0", Offset = "0x28C9CC0", VA = "0x1828CB2C0", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x28CB190", Offset = "0x28C9B90", VA = "0x1828CB190", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x28CB3B0", Offset = "0x28C9DB0", VA = "0x1828CB3B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, BYEJVEWXCEM<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id128<XEUKGISKBDU> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<MZMEHEUCWDG> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<ACVPQTFYCHZ> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x283FF20", Offset = "0x283E920", VA = "0x18283FF20")]
		public LegacyOutputId([In] Id128<XEUKGISKBDU> nodeId, Id32<MZMEHEUCWDG> portGroupId, Id32<ACVPQTFYCHZ> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x28CB910", Offset = "0x28CA310", VA = "0x1828CB910")]
		public static bool FYOQTCVQVIR([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x28CB8F0", Offset = "0x28CA2F0", VA = "0x1828CB8F0", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7C0", Offset = "0x28CA1C0", VA = "0x1828CB7C0")]
		public bool QGNBNUHOAWV([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7D0", Offset = "0x28CA1D0", VA = "0x1828CB7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x28CB9B0", Offset = "0x28CA3B0", VA = "0x1828CB9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x28CB7C0", Offset = "0x28CA1C0", VA = "0x1828CB7C0", Slot = "5")]
		private bool CMAFRZJNPPH([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : JHXDHZUYQRX, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<XDQQSNHTXDZ> MWVVIKDPWHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Id32<XDQQSNHTXDZ> WMICHGKTNQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int IAEJARVLVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x28CBDF0", Offset = "0x28CA7F0", VA = "0x1828CBDF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x28CBE20", Offset = "0x28CA820", VA = "0x1828CBE20")]
		public LegacyOutputIncorrectIdError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, Id32<XDQQSNHTXDZ> expectedOutputId, Id32<XDQQSNHTXDZ> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x28CBBD0", Offset = "0x28CA5D0", VA = "0x1828CBBD0", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x28CBA40", Offset = "0x28CA440", VA = "0x1828CBA40", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x28CBD00", Offset = "0x28CA700", VA = "0x1828CBD00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : JHXDHZUYQRX, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int RLUHQRINTCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly int NWRLUKYZWBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x28CC4E0", Offset = "0x28CAEE0", VA = "0x1828CC4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x28CC510", Offset = "0x28CAF10", VA = "0x1828CC510")]
		public LegacyOutputMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x28CC1E0", Offset = "0x28CABE0", VA = "0x1828CC1E0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x28CC2D0", Offset = "0x28CACD0", VA = "0x1828CC2D0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x28CC400", Offset = "0x28CAE00", VA = "0x1828CC400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIDescriptionAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class KJYTNNYIDBW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class EEACAAPXEDV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class EYUKRRPOQNQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class GJAWJHZJZCT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class PYVBRMOVXVY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class NBICJQIZBLT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class TRQHAQEUOWK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class HGNGXYZABBE : CIDJNEKANPP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class GWRUSRELMKN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class DDLBQTTJVCO : YHABBYUKUWZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class MVFYUYOJMFL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class WUKYKCWFUPU : VJUVSMISWAT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class XEUKGISKBDU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class HKRBMAIBFCN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class OBQCFAINAAA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class XDQQSNHTXDZ : YHABBYUKUWZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class DHFDVCDFXUO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class WKRIGIGZTCZ : VJUVSMISWAT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class TSUYWWKFBAH : CIDJNEKANPP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class YHABBYUKUWZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class MZMEHEUCWDG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class ROIJDLVWFAY : ZCTNCNEQXLD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class ACVPQTFYCHZ : ZCTNCNEQXLD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ZCTNCNEQXLD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class VJUVSMISWAT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class JITSGAFGGKQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class VISMDLBISYT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class UWJLYMRSXFS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class GBNADADGGBI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : JHXDHZUYQRX, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public StaticEdge ZKFIGFPZHOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x28CCAD0", Offset = "0x28CB4D0", VA = "0x1828CCAD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x28CCB00", Offset = "0x28CB500", VA = "0x1828CCB00")]
		public NewEdgeMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAB53E0", Offset = "0xAB3DE0", VA = "0x180AB53E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x28CC9B0", Offset = "0x28CB3B0", VA = "0x1828CC9B0", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x28CC8D0", Offset = "0x28CB2D0", VA = "0x1828CC8D0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x28CCA50", Offset = "0x28CB450", VA = "0x1828CCA50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : JHXDHZUYQRX, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x28CCE80", Offset = "0x28CB880", VA = "0x1828CCE80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x28CCEB0", Offset = "0x28CB8B0", VA = "0x1828CCEB0")]
		public NewGraphMissingError([In] Id128<HGNGXYZABBE> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x28CCD40", Offset = "0x28CB740", VA = "0x1828CCD40", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x28CCDA0", Offset = "0x28CB7A0", VA = "0x1828CCDA0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x28CCE40", Offset = "0x28CB840", VA = "0x1828CCE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : JHXDHZUYQRX, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<DDLBQTTJVCO> RYNBEBFEMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Id32<DDLBQTTJVCO> UCVEBIVRVIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly int YXVQNZRZXPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x28CD320", Offset = "0x28CBD20", VA = "0x1828CD320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x28CD350", Offset = "0x28CBD50", VA = "0x1828CD350")]
		public NewInputIncorrectIdError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, Id32<DDLBQTTJVCO> expectedInputId, Id32<DDLBQTTJVCO> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x28CCF70", Offset = "0x28CB970", VA = "0x1828CCF70", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x28CD0A0", Offset = "0x28CBAA0", VA = "0x1828CD0A0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x28CD230", Offset = "0x28CBC30", VA = "0x1828CD230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : JHXDHZUYQRX, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int XMYSLBCVCNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int IQURTKWZEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x28CDA10", Offset = "0x28CC410", VA = "0x1828CDA10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x28CDA40", Offset = "0x28CC440", VA = "0x1828CDA40")]
		public NewInputMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x28CD840", Offset = "0x28CC240", VA = "0x1828CD840", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x28CD710", Offset = "0x28CC110", VA = "0x1828CD710", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x28CD930", Offset = "0x28CC330", VA = "0x1828CD930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : JHXDHZUYQRX, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<HKRBMAIBFCN> LELRLDEWYRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x28CE020", Offset = "0x28CCA20", VA = "0x1828CE020", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x28CE050", Offset = "0x28CCA50", VA = "0x1828CE050")]
		public NewNodeMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, [In] Id128<XEUKGISKBDU> legacyNodeId, [In] Id32<HKRBMAIBFCN> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x28CDE90", Offset = "0x28CC890", VA = "0x1828CDE90", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x28CDD80", Offset = "0x28CC780", VA = "0x1828CDD80", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x28CDF60", Offset = "0x28CC960", VA = "0x1828CDF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : JHXDHZUYQRX, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly Id32<XDQQSNHTXDZ> MWVVIKDPWHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Id32<XDQQSNHTXDZ> BMOWDUBGJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int IAEJARVLVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x28CE680", Offset = "0x28CD080", VA = "0x1828CE680", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x28CE6B0", Offset = "0x28CD0B0", VA = "0x1828CE6B0")]
		public NewOutputIncorrectIdError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, Id32<XDQQSNHTXDZ> expectedOutputId, Id32<XDQQSNHTXDZ> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x28CE460", Offset = "0x28CCE60", VA = "0x1828CE460", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x28CE2D0", Offset = "0x28CCCD0", VA = "0x1828CE2D0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x28CE590", Offset = "0x28CCF90", VA = "0x1828CE590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : JHXDHZUYQRX, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly int RLUHQRINTCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly int NWRLUKYZWBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x28CED70", Offset = "0x28CD770", VA = "0x1828CED70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x28CEDA0", Offset = "0x28CD7A0", VA = "0x1828CEDA0")]
		public NewOutputMissingError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x28CEA70", Offset = "0x28CD470", VA = "0x1828CEA70", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x28CEB60", Offset = "0x28CD560", VA = "0x1828CEB60", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x28CEC90", Offset = "0x28CD690", VA = "0x1828CEC90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[WillBeRenamedTo("StaticEdge")]
	public readonly struct NewStaticEdge : IEquatable<NewStaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly Id32<XDQQSNHTXDZ> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id32<DDLBQTTJVCO> DstId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public NewStaticEdge(Id32<XDQQSNHTXDZ> srcId, Id32<DDLBQTTJVCO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x28CF270", Offset = "0x28CDC70", VA = "0x1828CF270")]
		public void HMUPOGLQWOR([Out] Id32<XDQQSNHTXDZ> srcId, [Out] Id32<DDLBQTTJVCO> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x28CF180", Offset = "0x28CDB80", VA = "0x1828CF180")]
		public static bool FYOQTCVQVIR(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x28CF0E0", Offset = "0x28CDAE0", VA = "0x1828CF0E0", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x28CF0F0", Offset = "0x28CDAF0", VA = "0x1828CF0F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x28CF200", Offset = "0x28CDC00", VA = "0x1828CF200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : JHXDHZUYQRX, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly Id128<PYVBRMOVXVY> QSDYUXRKBNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<HKRBMAIBFCN> LELRLDEWYRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x28CF630", Offset = "0x28CE030", VA = "0x1828CF630", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x28CF660", Offset = "0x28CE060", VA = "0x1828CF660")]
		public NodeDefMismatchError(Id32<HGNGXYZABBE> graphId, [In] Id128<HGNGXYZABBE> legacyGraphId, [In] Id32<XEUKGISKBDU> nodeId, [In] Id128<XEUKGISKBDU> legacyNodeId, [In] Id128<PYVBRMOVXVY> legacyNodeDefId, [In] Id32<HKRBMAIBFCN> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x28CF400", Offset = "0x28CDE00", VA = "0x1828CF400", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x28CF280", Offset = "0x28CDC80", VA = "0x1828CF280", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x28CF520", Offset = "0x28CDF20", VA = "0x1828CF520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : JHXDHZUYQRX, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int KIZUUBERRSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly int YEZDPSQBKAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly int CDQHWVVAGDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x28CFCF0", Offset = "0x28CE6F0", VA = "0x1828CFCF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x28CFD20", Offset = "0x28CE720", VA = "0x1828CFD20")]
		public NodeDescInputsMismatchError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x28CF9D0", Offset = "0x28CE3D0", VA = "0x1828CF9D0", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x28CFAC0", Offset = "0x28CE4C0", VA = "0x1828CFAC0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x28CFBF0", Offset = "0x28CE5F0", VA = "0x1828CFBF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : JHXDHZUYQRX, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<HGNGXYZABBE> MLNCKPSSGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<HGNGXYZABBE> SYJBTZXHXAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly Id32<XEUKGISKBDU> YQPLXVVAQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly Id128<XEUKGISKBDU> FYPBBOBPXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int KIZUUBERRSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int XQCQRBATCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int KOUPMZCSKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string OADZGOYOOOG;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string QYYTASUBHVC
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x28D03E0", Offset = "0x28CEDE0", VA = "0x1828D03E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x28D0410", Offset = "0x28CEE10", VA = "0x1828D0410")]
		public NodeDescOutputsMismatchError(Id32<HGNGXYZABBE> graphId, Id128<HGNGXYZABBE> legacyGraphId, Id32<XEUKGISKBDU> nodeId, Id128<XEUKGISKBDU> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x28D00C0", Offset = "0x28CEAC0", VA = "0x1828D00C0", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x28D01B0", Offset = "0x28CEBB0", VA = "0x1828D01B0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x28D02E0", Offset = "0x28CECE0", VA = "0x1828D02E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		DataTable,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		None
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public readonly struct ObjectBoardProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public readonly Id128<XEUKGISKBDU> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x12707F0", Offset = "0x126F1F0", VA = "0x1812707F0")]
		public ObjectBoardProps([In] Id128<XEUKGISKBDU> objectBoardId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public delegate void OnTraverseDelegate([In] TraversalProperties traversalProperties);
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		List,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		StateTransition
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public delegate void PositionChangeDelegate([In] CircuitsVec3 newLocalPosition);
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum PrepareTemplateForCloneErrKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Versioning,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		NodesNotAllowedInTargetGraph,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		SyncedVariablesNotAllowedInTargetGraphOrDescendents
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public readonly struct PrimitivePortGroupModifiers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly CQFPEXFLRFV Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly CQFPEXFLRFV Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly CQFPEXFLRFV Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly CQFPEXFLRFV Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly CQFPEXFLRFV String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly CQFPEXFLRFV Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly CQFPEXFLRFV Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly CQFPEXFLRFV Color;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28D09D0", Offset = "0x28CF3D0", VA = "0x1828D09D0")]
		public PrimitivePortGroupModifiers(CQFPEXFLRFV @bool, CQFPEXFLRFV exec, CQFPEXFLRFV @float, CQFPEXFLRFV @int, CQFPEXFLRFV @string, CQFPEXFLRFV vector3, CQFPEXFLRFV quaternion, CQFPEXFLRFV color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public delegate void RotationChangeDelegate([In] CircuitsQuat newLocalRotation);
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public readonly struct StableStaticEdge : IEquatable<StableStaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly Id128<XEUKGISKBDU> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<WKRIGIGZTCZ> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly Id128<XEUKGISKBDU> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Id32<WUKYKCWFUPU> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x28D0F80", Offset = "0x28CF980", VA = "0x1828D0F80")]
		public StableStaticEdge([In] Id128<XEUKGISKBDU> srcNodeId, Id32<WKRIGIGZTCZ> srcPortIndex, [In] Id128<XEUKGISKBDU> dstNodeId, Id32<WUKYKCWFUPU> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x28D0BF0", Offset = "0x28CF5F0", VA = "0x1828D0BF0")]
		public static bool FYOQTCVQVIR([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x28D0B30", Offset = "0x28CF530", VA = "0x1828D0B30", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x28D0A80", Offset = "0x28CF480", VA = "0x1828D0A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x28D0CB0", Offset = "0x28CF6B0", VA = "0x1828D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x28D0D60", Offset = "0x28CF760", VA = "0x1828D0D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public readonly struct StaticCircuitsConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly int InvisibleChipLimitBytes;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xBF0C20", Offset = "0xBEF620", VA = "0x180BF0C20")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x28D0FA0", Offset = "0x28CF9A0", VA = "0x1828D0FA0")]
		public StaticCircuitsConfigData JVPEYACKYLR()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly Id128<XEUKGISKBDU> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id32<MZMEHEUCWDG> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<ACVPQTFYCHZ> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id128<XEUKGISKBDU> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly Id32<MZMEHEUCWDG> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly Id32<ROIJDLVWFAY> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x28D1590", Offset = "0x28CFF90", VA = "0x1828D1590")]
		public StaticEdge([In] Id128<XEUKGISKBDU> srcNodeId, Id32<MZMEHEUCWDG> srcPortGroupId, Id32<ACVPQTFYCHZ> srcPortId, [In] Id128<XEUKGISKBDU> dstNodeId, Id32<MZMEHEUCWDG> dstPortGroupId, Id32<ROIJDLVWFAY> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x28D10E0", Offset = "0x28CFAE0", VA = "0x1828D10E0")]
		public static bool FYOQTCVQVIR([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x28D10C0", Offset = "0x28CFAC0", VA = "0x1828D10C0", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x28D1010", Offset = "0x28CFA10", VA = "0x1828D1010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28D11D0", Offset = "0x28CFBD0", VA = "0x1828D11D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x28D12C0", Offset = "0x28CFCC0", VA = "0x1828D12C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class EGLSNAAQQVR
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9400", Offset = "0x28C7E00", VA = "0x1828C9400")]
		public static StaticEdge WDKEUGVWMDY(this DELPAIBKMLK a)
		{
			return default(StaticEdge);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct StudioFunctionDefinition : IEquatable<StudioFunctionDefinition>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly string PrefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public readonly int StudioFunctionIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xC40E00", Offset = "0xC3F800", VA = "0x180C40E00")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x28D15C0", Offset = "0x28CFFC0", VA = "0x1828D15C0", Slot = "4")]
		public bool Equals(StudioFunctionDefinition other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct StudioFunctionPortDeclaration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public readonly AOZBVRJPQRE.SWOPFJGPAIA.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xC40E00", Offset = "0xC3F800", VA = "0x180C40E00")]
		public StudioFunctionPortDeclaration(string name, AOZBVRJPQRE.SWOPFJGPAIA.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A40", Offset = "0x28D0440", VA = "0x1828D1A40")]
		internal static StudioFunctionPortDeclaration WDKEUGVWMDY(AOZBVRJPQRE a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x28D1730", Offset = "0x28D0130", VA = "0x1828D1730")]
		internal AOZBVRJPQRE JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x28D16C0", Offset = "0x28D00C0", VA = "0x1828D16C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x28D1610", Offset = "0x28D0010", VA = "0x1828D1610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x28D15C0", Offset = "0x28CFFC0", VA = "0x1828D15C0")]
		public bool RTJPLCKWUCK(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x28D17A0", Offset = "0x28D01A0", VA = "0x1828D17A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly IReadOnlyDictionary<Id128<EYUKRRPOQNQ>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly IReadOnlyDictionary<Id128<EYUKRRPOQNQ>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x28D1EF0", Offset = "0x28D08F0", VA = "0x1828D1EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x28D3160", Offset = "0x28D1B60", VA = "0x1828D3160")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x28D2F00", Offset = "0x28D1900", VA = "0x1828D2F00")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<EYUKRRPOQNQ>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x28D2100", Offset = "0x28D0B00", VA = "0x1828D2100")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x28D2A40", Offset = "0x28D1440", VA = "0x1828D2A40")]
		public static StudioFunctionRegistration WDKEUGVWMDY(THZPCCBVFPW a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x28D1F70", Offset = "0x28D0970", VA = "0x1828D1F70")]
		public THZPCCBVFPW JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x28D1A90", Offset = "0x28D0490", VA = "0x1828D1A90", Slot = "4")]
		public bool Equals(StudioFunctionRegistration other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public readonly struct StudioFunctionSignature : IEquatable<StudioFunctionSignature>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public readonly IReadOnlyList<StudioFunctionPortDeclaration> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public readonly IReadOnlyList<StudioFunctionPortDeclaration> Outputs;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x28D3520", Offset = "0x28D1F20", VA = "0x1828D3520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1BBF210", Offset = "0x1BBDC10", VA = "0x181BBF210")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x28D3B60", Offset = "0x28D2560", VA = "0x1828D3B60")]
		public static StudioFunctionSignature WDKEUGVWMDY(ATFKZKPYROF a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x28D3540", Offset = "0x28D1F40", VA = "0x1828D3540")]
		public ATFKZKPYROF JVPEYACKYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x28D34A0", Offset = "0x28D1EA0", VA = "0x1828D34A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x28D3210", Offset = "0x28D1C10", VA = "0x1828D3210")]
		private static int CWPJYTUMFPG(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x28D33F0", Offset = "0x28D1DF0", VA = "0x1828D33F0", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x28D37A0", Offset = "0x28D21A0", VA = "0x1828D37A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public enum TemplateSerializationReason
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		CopyPaste,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Replicator
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public static class TTBDONAIGNX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x12849D0", Offset = "0x12833D0", VA = "0x1812849D0")]
		public static bool UMRHJNBTVPF(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x12849D0", Offset = "0x12833D0", VA = "0x1812849D0")]
		public static bool DWPFSVJRXHU(this TemplateSerializationReason a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum TraversalCause
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		GetDisplayValue,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		GetBackingValue
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct TraversalProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public readonly bool IsInitiating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public readonly TraversalCause TraversalCause;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x17B84D0", Offset = "0x17B6ED0", VA = "0x1817B84D0")]
		public TraversalProperties(bool isInitiating, TraversalCause traversalCause)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		String,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Color
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
