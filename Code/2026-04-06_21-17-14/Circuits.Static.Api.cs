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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B82CC0", Offset = "0x2B81CC0", VA = "0x182B82CC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7EC40", Offset = "0x2B7DC40", VA = "0x182B7EC40", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		public readonly Id32<YUFXTHDQAZB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<EXUEQGJGLLV> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public AbsoluteInputId(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A7A0", Offset = "0x2B797A0", VA = "0x182B7A7A0")]
		public static bool HCRCQFCURBY(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A690", Offset = "0x2B79690", VA = "0x182B7A690", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A6A0", Offset = "0x2B796A0", VA = "0x182B7A6A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A730", Offset = "0x2B79730", VA = "0x182B7A730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A820", Offset = "0x2B79820", VA = "0x182B7A820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, VZURHGBSTCB<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<YUFXTHDQAZB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<ISSDUATOTVT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<HPGFUJBLNSN> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<FBIPJIAHSMB> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB30", Offset = "0x2B79B30", VA = "0x182B7AB30")]
		public AbsoluteLegacyInputId([In] Id128<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AA70", Offset = "0x2B79A70", VA = "0x182B7AA70")]
		public static bool HCRCQFCURBY([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A980", Offset = "0x2B79980", VA = "0x182B7A980", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A9A0", Offset = "0x2B799A0", VA = "0x182B7A9A0")]
		public bool FNYFOTOAQQI([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A8C0", Offset = "0x2B798C0", VA = "0x182B7A8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A9B0", Offset = "0x2B799B0", VA = "0x182B7A9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A9A0", Offset = "0x2B799A0", VA = "0x182B7A9A0", Slot = "5")]
		private bool JOPORCTMCSA([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, VZURHGBSTCB<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<YUFXTHDQAZB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<ISSDUATOTVT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<HPGFUJBLNSN> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<HDSUEKONMVO> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB30", Offset = "0x2B79B30", VA = "0x182B7AB30")]
		public AbsoluteLegacyOutputId([In] Id128<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AD00", Offset = "0x2B79D00", VA = "0x182B7AD00")]
		public static bool HCRCQFCURBY([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB60", Offset = "0x2B79B60", VA = "0x182B7AB60", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB50", Offset = "0x2B79B50", VA = "0x182B7AB50")]
		public bool FNYFOTOAQQI([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB80", Offset = "0x2B79B80", VA = "0x182B7AB80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AC40", Offset = "0x2B79C40", VA = "0x182B7AC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AB50", Offset = "0x2B79B50", VA = "0x182B7AB50", Slot = "5")]
		private bool EOWNCQMTIRN([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<YUFXTHDQAZB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<ISSDUATOTVT> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AF50", Offset = "0x2B79F50", VA = "0x182B7AF50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public AbsoluteNodeId(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AED0", Offset = "0x2B79ED0", VA = "0x182B7AED0")]
		public static bool HCRCQFCURBY(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AE50", Offset = "0x2B79E50", VA = "0x182B7AE50", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B7ADC0", Offset = "0x2B79DC0", VA = "0x182B7ADC0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AE60", Offset = "0x2B79E60", VA = "0x182B7AE60", Slot = "2")]
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
		public readonly Id32<YUFXTHDQAZB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<METWAAXGTBK> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public AbsoluteOutputId(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B100", Offset = "0x2B7A100", VA = "0x182B7B100")]
		public static bool HCRCQFCURBY(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B7AFF0", Offset = "0x2B79FF0", VA = "0x182B7AFF0", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B000", Offset = "0x2B7A000", VA = "0x182B7B000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B090", Offset = "0x2B7A090", VA = "0x182B7B090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B180", Offset = "0x2B7A180", VA = "0x182B7B180", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7B350", Offset = "0x2B7A350", VA = "0x182B7B350")]
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
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
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
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
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
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CircuitTypeIdWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<SNPPUNKBJMN> TypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly IReadOnlyList<CircuitTypeIdWrapper>? TypeParameterAssignments;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x19957B0", Offset = "0x19947B0", VA = "0x1819957B0")]
		private CircuitTypeIdWrapper(Id32<SNPPUNKBJMN> typeId, IReadOnlyList<CircuitTypeIdWrapper>? typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B220", Offset = "0x2B7A220", VA = "0x182B7B220")]
		public static CircuitTypeIdWrapper QNAQUEPOYVQ(Id32<SNPPUNKBJMN> typeId)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B250", Offset = "0x2B7A250", VA = "0x182B7B250")]
		public static CircuitTypeIdWrapper TPRRVJMSZJE(Id32<SNPPUNKBJMN> typeId, IReadOnlyList<CircuitTypeIdWrapper> a)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B280", Offset = "0x2B7A280", VA = "0x182B7B280", Slot = "3")]
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
		private sealed class LXFDTAXQBQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod GENSPHWQVMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string YNXGERMLHNT;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LXFDTAXQBQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2B7B8F0", Offset = "0x2B7A8F0", VA = "0x182B7B8F0")]
			internal Task<bool> HJGUBTNFJMI(string? value)
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
			[Cpp2IlInjected.Address(RVA = "0x2B86360", Offset = "0x2B85360", VA = "0x182B86360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B88460", Offset = "0x2B87460", VA = "0x182B88460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2B888E0", Offset = "0x2B878E0", VA = "0x182B888E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> GENSPHWQVMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? HTINBUMHRSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? KDMOCRITRNJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? MBQGQZROXZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? VQUKEHKSTUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? TMKWEFINWUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? YJFSGGWEOIH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? RRGEEOLMCLI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool SUCQVFXUAMX
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD9B510", Offset = "0xD9A510", VA = "0x180D9B510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xDCC050", Offset = "0xDCB050", VA = "0x180DCC050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B7D0", Offset = "0x2B7A7D0", VA = "0x182B7B7D0")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B490", Offset = "0x2B7A490", VA = "0x182B7B490")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void XASVIZHZBOI(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B570", Offset = "0x2B7A570", VA = "0x182B7B570")]
		public Task YGVLSHVCDKW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B390", Offset = "0x2B7A390", VA = "0x182B7B390")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> DDERDMURWMF(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
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
	public interface ZHHYWPNIHVR : ZBBZHLLRECI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface YBGJUYJZTVK : DBTVNXLTCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HTXYRWYGQBL();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface ZBBZHLLRECI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface FFRJNAJYTGE
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface NBJCCMNYJBM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface ABVKJWGLWKH : DBTVNXLTCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UAWYOTEJVEH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface RHXDZNHNUEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string VTAGMKNBCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int CPRDPUWQWCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool ZCAHLKAVBRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface GRKTELHQWIB : DBTVNXLTCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(DBTVNXLTCIC ui);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(DBTVNXLTCIC ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface CHYFRJTXHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SJHJUITIJFF(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FJEBLYZAGJE(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WQYQDDJASIL(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YKOGGWTNPZZ(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QPFVIGULWPX(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GKQJACCWVOV(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HIPIMPKFVIS(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface YAVKDLMCPYL
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
		public interface OJOLWQHPXVX
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool GKZLOYAZHSP
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
			void JSTCHGYNEMG();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface YNQTUTNLEIR
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string TCMFZMJELYY
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			KJYDPEYJTPJ ANNDPOORVQD
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? YPWMQNIYZMB
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			RAIQVFTYDPV? ALXVDUNJNWU
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool GKZLOYAZHSP
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void YJJNTIRMXRO();

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void BMRYIDXDWGB();

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void AUGHWTSZGEP(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface TBCOCTNNYGK
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<YAVKDLMCPYL>? EVQJGLUCNNY
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			DBTVNXLTCIC IPTYPCUNFVA(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		TBCOCTNNYGK Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DBTVNXLTCIC YNGIAGAUMOW(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DBTVNXLTCIC RMRCYUHGFOZ(IReadOnlyList<DBTVNXLTCIC> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DBTVNXLTCIC DQFCDOYTYSH(IReadOnlyList<DBTVNXLTCIC> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DBTVNXLTCIC JYXEYOKXVYL(Func<int> a, Func<int, Task<bool>> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DBTVNXLTCIC FISZDRICZZV(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		DBTVNXLTCIC EKHYKUFSGRR(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		DBTVNXLTCIC QHNACZQEKMV(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		DBTVNXLTCIC YGAUUQQMPFB(Func<Id128<YUFXTHDQAZB>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		DBTVNXLTCIC OJEUCYYWASL(DBTVNXLTCIC a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		GRKTELHQWIB BSVMFESTARB(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<DBTVNXLTCIC>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		DBTVNXLTCIC CRWZEWLOXUG(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		DBTVNXLTCIC UXBGGCAVTOU(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		DBTVNXLTCIC HYQWGZDRDOK(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		DBTVNXLTCIC OCFRNNXNMPD(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		DBTVNXLTCIC IGRSKBMXWOJ(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		DBTVNXLTCIC XAIQUNJJFFS(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		DBTVNXLTCIC BENBLXFFKKM(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		DBTVNXLTCIC RJWUTFBACEN(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<DBTVNXLTCIC>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		DBTVNXLTCIC KFTOGBFQAJM(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		DBTVNXLTCIC WEOYYZILMRP(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		DBTVNXLTCIC DEXSNPCKKQV(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		YBGJUYJZTVK LCUAVPVIZWK(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		YBGJUYJZTVK BDAFVCLTNTT(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		DBTVNXLTCIC IXXSICZQUGZ(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		DBTVNXLTCIC ZGRODDIHNNX(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		ABVKJWGLWKH WBQSRNPOIIM(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<DBTVNXLTCIC>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void HLJHQQSQQJJ(DBTVNXLTCIC a);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void BPXZFDHWRVJ(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void SNZESYUZRBR(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<DBTVNXLTCIC>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		OJOLWQHPXVX KJWJUGATZDO(string a, IReadOnlyList<DBTVNXLTCIC> b, [Optional] IReadOnlyList<DBTVNXLTCIC>? headerElements, [Optional] IReadOnlyList<DBTVNXLTCIC>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		YNQTUTNLEIR TCHNZCXAGBI(string a, string b, KJYDPEYJTPJ c, Action<YNQTUTNLEIR> d, int e = 160, [Optional] (Func<KJYDPEYJTPJ, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, RAIQVFTYDPV InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void ZAZUPSJHHHQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "33")]
		DBTVNXLTCIC GAQHJQMGBAN(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "34")]
		DBTVNXLTCIC EQBECANCUJS<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "35")]
		DBTVNXLTCIC BYFDUZOONZY(Func<string> a, Action<string> b, string c = "", string d = "");

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "36")]
		DBTVNXLTCIC GTTLVPLAKHU(Func<string?> imageGetter, Func<bool>? isModifiedGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface DBTVNXLTCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IIRMWCTEWDY();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface FXFFITNOXVR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface IHFZGDSWCHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OFIDJKUQDDM();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OKARUYGTKDV(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MPZCOLLZUNQ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VTZZDBSQMAL(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface OVKUTAZGTAB : MCRZZCNKUJE, YCREHOYWOHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind BWQZNOWSFXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface CHFMCCPRZNQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface ZOGEUBJOXII
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool XRRDYZXXKSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool GXAKWJQNMUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EWEFMIXTDWL(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType WSCKSNNIJFC(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool URYKDTGIQUH(Id128<ATOQASVPSNP> nodeDefId, Id128<YUFXTHDQAZB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GBDEDOHZMTG(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PWHAGXHHICG(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface FMQLZJSTKGH
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		FZLXAJZQSFG? CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool PDQWUBRGSRJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool QPSPPAIKILD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<FZLXAJZQSFG> IRXCRXKOKEP();

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, YCREHOYWOHO> RMDGYUQUKXJ([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<YUFXTHDQAZB>, Guid> PKOZWPKDSPV(IEnumerable<RWNYJETRKPC> a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData HDMQJHAOOOD(IEnumerable<RWNYJETRKPC> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface CTIPDVQYPIR
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DLWCNCTVHPT(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OCXVWCYFEFH(Id32<DKRIAFHGUAF> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TWQXHMINBJB(Id32<DKRIAFHGUAF> functionId);

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
	public interface FZLXAJZQSFG
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
			public readonly IEnumerable<RWNYJETRKPC> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<YUFXTHDQAZB> SpawnIntoGraphId;

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
			[Cpp2IlInjected.Address(RVA = "0x2B82DF0", Offset = "0x2B81DF0", VA = "0x182B82DF0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<RWNYJETRKPC> persistenceViews, bool assignNewIds, [In] Id128<YUFXTHDQAZB> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
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
			[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2B82EA0", Offset = "0x2B81EA0", VA = "0x182B82EA0")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<YUFXTHDQAZB> UIKPWUUYJYU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers REKPNWRXFRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> IKBQOYECPRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action CRUONGFVVFX;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> YZUTPGAKAOT;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) IJVMHZZASIS(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DAKUPMWWKBV(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KONQXNVVJSD(RHMKGKFUMBP a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DHZMHVVHLGK(QSXKFHFJPKO a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? DWLIFXWVIXH(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? JGYJTQICEIM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<METWAAXGTBK>? ZXDOMXHKRYS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<EXUEQGJGLLV>? HNOTLXPJVBN(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<YUFXTHDQAZB>> WKIJHSOOWUX();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<DKRIAFHGUAF>> XTNCMBIHOQA();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Id32<DKRIAFHGUAF>? TLPLTPEKXNW(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int UBLPLKRSKEZ(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int LTXFRJARVLU(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(CircuitTypeIdWrapper, string)[] MXLCGCAPZDZ(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(CircuitTypeIdWrapper, string)[] ROCYGZKBYIU(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string CYIKKLGUBJK(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string KSOQULQGPKQ(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		string NLYUAUSBKJD(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		OOFXQBZYQXD? PASCSJQKHBM([In] Id128<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		OOFXQBZYQXD? PASCSJQKHBM(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Id32<YUFXTHDQAZB> CUSOWEDYOUP([In] Id128<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Id32<YUFXTHDQAZB>? QJETBELOLSX([In] Id128<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Id32<YUFXTHDQAZB>? ZMFKUREUZNQ(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		SNXISRUYHOD? PUVEWDQLWHQ([In] Id128<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Id32<DQODHRVSODS> AJVXSWMPBMU(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Id32<ISSDUATOTVT> DBLQJKSIHKL(Id32<YUFXTHDQAZB> graphId, [In] Id128<ISSDUATOTVT> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		AbsoluteNodeId? DOYSURJVFWJ(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		long JAKVBGFAIRM();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IEnumerable<NewStaticEdge> DHKWENWCLFU(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool ABTIVNVQASG(Id32<DKRIAFHGUAF> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "32")]
		IEnumerable<StableStaticEdge> SKEWACSXTHM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "33")]
		IEnumerable<StableStaticEdge> ZMVITQMDSQF(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<(Id32<YUFXTHDQAZB>, Id32<ISSDUATOTVT>)> SXXHZCCTEYU(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Id32<EXUEQGJGLLV> HNOTLXPJVBN(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<JWMQWCSZLZH> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Id32<ISSDUATOTVT> MQUCEMRITKA(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id32<ISSDUATOTVT> NPAIAMDCHJB(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id32<METWAAXGTBK> ZXDOMXHKRYS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<ZZQKNMLXIHO> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "39")]
		IEnumerable<PJVLKDMUVJA> CIPCGDNGADM(RoomVersion a, bool b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "40")]
		PJVLKDMUVJA VRMKAYHTDRF(RoomVersion a, YKOXFKAMQGI b, bool c, bool d, bool e, bool f, bool g);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "41")]
		NewStaticEdge HMKFDOPHSZD(Id32<YUFXTHDQAZB> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Id128<YUFXTHDQAZB> SQOXXJSAUOC(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Id128<ISSDUATOTVT> WHTTQUYJVDS(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "44")]
		StableStaticEdge EWMNYCSEIMM(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, MCRZZCNKUJE>> EUBAJMERQWR(Id32<YUFXTHDQAZB> parentGraphId, Id32<ISSDUATOTVT> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<Result<None, MCRZZCNKUJE>> DUWQHPPJKYE(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, List<Id32<ISSDUATOTVT>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "47")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)>) EEMONFGMYCM(Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task KDYTOYHCPBM(Id128<YUFXTHDQAZB> legacyGraphId, Id128<ISSDUATOTVT> boardNodeId, IReadOnlyList<Id128<ISSDUATOTVT>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<HPGFUJBLNSN>, Id32<FBIPJIAHSMB>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<HPGFUJBLNSN>, Id32<HDSUEKONMVO>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<Result<None, MCRZZCNKUJE>> XGZXMMJDXWN(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, List<Id32<ISSDUATOTVT>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, MCRZZCNKUJE>> SYOJOEMWMLB(Id32<YUFXTHDQAZB> parentGraphId, Id128<ISSDUATOTVT> boardNodeId, Id32<YUFXTHDQAZB> graphId, List<Id32<ISSDUATOTVT>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool WQCFQBYWXBQ(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool YVSMTIFITQW(Id32<YUFXTHDQAZB> graphId, Id32<EXUEQGJGLLV> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool JANCWCOZLPN(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Result<PrepareTemplateForCloneResult, OVKUTAZGTAB> ZLAGGYJYQZJ([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, MCRZZCNKUJE>> TFLLWOLJBXN(Id32<YUFXTHDQAZB> graphId, Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<Id32<ISSDUATOTVT>, MCRZZCNKUJE>> BJRIDXQCJYO(Id32<YUFXTHDQAZB> graphId, Id32<DQODHRVSODS> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ZSJCWROFUCH(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Result<ControlPanelRootData, YCREHOYWOHO> VUJUIGFNSKD(Id128<YUFXTHDQAZB> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Result<None, MCRZZCNKUJE>> ZRHQWKZJHKD(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> inputNodeId, Id32<HPGFUJBLNSN> inputPortGroupId, Id32<FBIPJIAHSMB> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "60")]
		Task<Result<None, MCRZZCNKUJE>> PFIQADLAVAS(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> outputNodeId, Id32<HPGFUJBLNSN> outputPortGroupId, Id32<HDSUEKONMVO> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "61")]
		Task<Result<None, MCRZZCNKUJE>> MXLZBYZVNVB(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		Task<Result<IEnumerable<Id128<ISSDUATOTVT>>, MCRZZCNKUJE>> ZIOPUHCRYMY(Id128<YUFXTHDQAZB> intoGraphId, CircuitTemplateRootData a, IEnumerable<RWNYJETRKPC> b);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		CircuitsData RJSOHIRAETQ();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "64")]
		CircuitsData HEJBSSYCDGL();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "65")]
		CircuitsTemplateData IWVGFYSZRSL(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id128<ISSDUATOTVT>> nodeIds, IEnumerable<RWNYJETRKPC> b, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "66")]
		CircuitsTemplateData IWVGFYSZRSL(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id32<ISSDUATOTVT>> nodeIds, IEnumerable<RWNYJETRKPC> b, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "67")]
		CircuitsTemplateData PJDKXWRAJDC(TemplateSerializationReason a, Id32<YUFXTHDQAZB> sourceGraphId, IEnumerable<Id128<YUFXTHDQAZB>> graphIds, IEnumerable<Id128<ISSDUATOTVT>> nodeIds, ISet<Id128<WIDRWTBBIAB>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "68")]
		List<FFRJNAJYTGE> BBRCRBMIAYQ();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "69")]
		(List<FFRJNAJYTGE>, bool) KSFQQEILRIL([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, GUQFFNFRVWI b, HESTTNCLENK c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool FSSUZEUGGYG(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool NPCVVKDYDLO(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Result<Id32<METWAAXGTBK>?, MCRZZCNKUJE> OSJKNZAMKVV(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<EXUEQGJGLLV> inputId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Result<Id32<EXUEQGJGLLV>?, MCRZZCNKUJE> PAJLMIGRNFR(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<METWAAXGTBK> outputId);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task<Result<None, MCRZZCNKUJE>> MAUULLXLYPC();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task<Result<None, MCRZZCNKUJE>> SAGDFMQBMSW(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Id32<ISSDUATOTVT>? AOMRJPFRXRO(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Id32<ISSDUATOTVT>? VHZTVIJHSKZ(Id32<YUFXTHDQAZB> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		int LHZQZVKUXVX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int ZCBPOVVSZWK(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "80")]
		int ZKSKATRKDCX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "81")]
		int BJHAEYFPSFH(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "82")]
		Task<Result<None, MCRZZCNKUJE>> BUDQXFXHLJX(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "83")]
		Task<Result<None, MCRZZCNKUJE>> NWORIVBMZBA(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "84")]
		int GXIOZUNQNTP(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<None, MCRZZCNKUJE>> ZPWAMORUWRB(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "86")]
		Task<Result<None, MCRZZCNKUJE>> QXUZAHWZTAU(Id32<YUFXTHDQAZB> graphId, Id32<ISSDUATOTVT> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "87")]
		bool HIMGUJDNTNX();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IEnumerable<Id32<QSUPKMQDXBF>> XOIRTZNZHET();

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		string? CXLNBBFUQFF(Id32<QSUPKMQDXBF> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface WDIPXWWJJAG : NIHRXRZWCDF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		FMQLZJSTKGH EHTXORRPEAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface MCRZZCNKUJE : YCREHOYWOHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface OOFXQBZYQXD
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<YUFXTHDQAZB>? XMSHELJNAXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<YUFXTHDQAZB> TPKSAYVBGKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<ISSDUATOTVT>? SLTCHIIEJVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? TRBWWAHQKJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface RHMKGKFUMBP : YKOXFKAMQGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<FBIPJIAHSMB> WXNDRMFCONW
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<EXUEQGJGLLV> NKAVFHLQNTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool RUXYJSOALPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QZMLABTSDIQ(FXFFITNOXVR a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YPZZVWFEZJZ(CHYFRJTXHOB a);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string EKTQCHJBUVO(int a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RSYRZOMTRNJ(LVPTAXVPRRH a);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LAERSIBIQSC(LVPTAXVPRRH a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface LVPTAXVPRRH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface SNXISRUYHOD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<ATOQASVPSNP> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<DQODHRVSODS> NewNodeTypeId
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
		Id32<SKCKNIYGNEU> IconId
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
		RHXDZNHNUEE? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<YUFXTHDQAZB> GraphId
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
		Id32<YUFXTHDQAZB>? InnerGraphId
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
		Id32<YUFXTHDQAZB>? ProxyGraphId
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
		IEnumerable<Id128<ISSDUATOTVT>>? InnerGraphNodeIds
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
		Id128<YUFXTHDQAZB> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<ISSDUATOTVT> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<ISSDUATOTVT> LegacyNodeId
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
		ReadOnlyIdArray<HPGFUJBLNSN, XAZCQBDUMDJ> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<HPGFUJBLNSN>? SelfPortGroupId
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
		event Action XKCSYYXMRQR;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate XGTKAXGZPTO;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate FDNBJOKEGJV;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action GIVVCQPSJIP;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action VNAEOHMBTMK;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> JASIGWRKHNV;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<HPGFUJBLNSN>> AHWBQCOYDTO;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> QZNYTCLFGQS;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<HPGFUJBLNSN>, Id32<HPGFUJBLNSN>> YPIZEUVAGTF;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<HPGFUJBLNSN>, XAZCQBDUMDJ> YXBCECZDUHF;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<HPGFUJBLNSN>, Id32<HPGFUJBLNSN>> GYUCPSAADVQ;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> BGZGCDYEIFR;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Result<None, MCRZZCNKUJE>> MGXUHDSEMYW(int a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool RPNQPQQUCQK([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool OECEHXQYERN([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void WCKAQYLNYAH(bool a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task USXYJAUDHUP();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, MCRZZCNKUJE>> EHEPJNCOMGS(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void YWKGNMOGZCV();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool YLVEPQPDCRM([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool SEDYZQYZJMT([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void PVXKIQUNBZD(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "50")]
		ZBBZHLLRECI JYBGAZEIZEN([In] ZHHYWPNIHVR audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<HPGFUJBLNSN>, MCRZZCNKUJE>> ONIENZMFOPL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void YPZZVWFEZJZ(YAVKDLMCPYL a);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform IELIOEDFUOO();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool OORBJXIZJQY(Id32<HPGFUJBLNSN> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, MCRZZCNKUJE>> AZHEBKRWDQA(Id32<HPGFUJBLNSN> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool LTGNNCRIKJC(Id32<HPGFUJBLNSN> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void KIMXYCJLAOA();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void PJSYVYTWKZK(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void BKTPOQQPIOJ(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void YHIAQJGCTER(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void SWOGNUCWEAK(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void THYFIYTTAJZ(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void DBOLMHFUFMM(Id32<HPGFUJBLNSN> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void NIQQBRFPKMY(Id32<HPGFUJBLNSN> sourceId, Id32<HPGFUJBLNSN> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void RSVWLUXGOPH(Id32<HPGFUJBLNSN> sourceId, Id32<HPGFUJBLNSN> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void XOLDHLDWIJD(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface QSXKFHFJPKO : YKOXFKAMQGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<METWAAXGTBK> PERCMXUPNVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<HDSUEKONMVO> BFCUJZBUSZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface YKOXFKAMQGI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> RFOHNFILEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind GXPAUJHFBTU
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<YUFXTHDQAZB> TPKSAYVBGKX
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<YUFXTHDQAZB> XFOTGMLRBKC
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<ISSDUATOTVT> YFWMMDCBYNW
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<HPGFUJBLNSN> PFMHQRZLLYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<GWVCCMPWDTY> AFFBDDUUGFX
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		KJYDPEYJTPJ HGDIUIHURVP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage DODJUOCZRIS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool UIYPJAJMTUC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LAWVMLXQYOV(JFIZWZSGTKE a);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LDGPNWEKOTF(CGBVOBTKVVI a);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void WNTVCECSJUF(IHFZGDSWCHG a);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PFNPSWZKFUG(JFIZWZSGTKE a);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void NXLWWLKFWMI(CGBVOBTKVVI a);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void XBMLLLSLMHK(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface JFIZWZSGTKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface XAZCQBDUMDJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<HPGFUJBLNSN> newValue, Id32<HPGFUJBLNSN> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool NZCUTZHQWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool NSCVMWPQEWD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool GIVVAOAIJVL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<YUFXTHDQAZB> XFOTGMLRBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool ADFILDAPNXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<FBIPJIAHSMB, RHMKGKFUMBP> OVARURGOYXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string PAVMQALYVSV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<ISSDUATOTVT> YFWMMDCBYNW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<HDSUEKONMVO, QSXKFHFJPKO> LYBOYIUPWUE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<HPGFUJBLNSN> PFMHQRZLLYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action VNEDBTOBFAF;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action VCVDSPVGBKS;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<FBIPJIAHSMB>, Id32<FBIPJIAHSMB>> VAAKVDRRNZP;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<FBIPJIAHSMB>, Id32<FBIPJIAHSMB>> KXYGZFAFYIK;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<HDSUEKONMVO>, Id32<HDSUEKONMVO>> EQRCKHPIDFS;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<HDSUEKONMVO>, Id32<HDSUEKONMVO>> CSHREPSROAV;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<FBIPJIAHSMB>, RHMKGKFUMBP> GJECDGMGXWG;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<FBIPJIAHSMB>> MIDAFILKCZV;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<FBIPJIAHSMB>, RHMKGKFUMBP> YTWYNBJZSVI;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<HDSUEKONMVO>, QSXKFHFJPKO> LDOFABZWUQN;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<HDSUEKONMVO>> GGRMZXSJPLY;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<HDSUEKONMVO>, QSXKFHFJPKO> BVXRUASPRXT;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, MCRZZCNKUJE>> YUBCGROKPWE();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, MCRZZCNKUJE>> RPTCBCNHAOB(Id32<IWUJLJYSQDA> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, MCRZZCNKUJE>> XMRFVQTLVLA(Id32<RGHHVUNUSGT> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, MCRZZCNKUJE>> JDQXZJJEJVB(Id32<IWUJLJYSQDA> inputDefId, Id32<IWUJLJYSQDA> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, MCRZZCNKUJE>> PJZTFARBBYW(Id32<RGHHVUNUSGT> outputDefId, Id32<RGHHVUNUSGT> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, MCRZZCNKUJE>> WQCZERHLEAB();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, MCRZZCNKUJE>> FAQCERJBFME(string a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, MCRZZCNKUJE>> NYYHTQCHANZ(Id32<IWUJLJYSQDA> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, MCRZZCNKUJE>> GXYPBSTXIAE(Id32<RGHHVUNUSGT> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, MCRZZCNKUJE>> YYDPEQXDFQU(Id32<IWUJLJYSQDA> inputDefId, PJVLKDMUVJA a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, MCRZZCNKUJE>> QOEYIQSFPVH(Id32<RGHHVUNUSGT> outputDefId, PJVLKDMUVJA a);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void PSIWDRTESBV(int a, Id32<FBIPJIAHSMB> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void AQZVGSPORTW(int a, Id32<FBIPJIAHSMB> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void XHZTJMDLSBQ(int a, Id32<HDSUEKONMVO> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void UYIZJBGHVAH(int a, Id32<HDSUEKONMVO> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void PFYBWJWZKEU(int a, Id32<FBIPJIAHSMB> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void PLFOXLSUDPP(int a, Id32<FBIPJIAHSMB> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void AAYBPUIMUPN(int a, Id32<HDSUEKONMVO> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void VNLXBRQTFXW(int a, Id32<HDSUEKONMVO> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void WZURSCAVYMM(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void GBFBPVGFAUF(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void SZFBYDPBPIT(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void GLDSTPQQDQI(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void ZZJHXEMOMFM(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void TGEEITOBEBX(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void CYJFGKIFHUV(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void RIPNOVNFDIA(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void LEOAKJOHFKH(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void WHYZWNQYOGS(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void ZRGGOLMBAUE(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void LKEYUKZFYYH(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface PJVLKDMUVJA
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey KAYJFSSVOYF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string MFHOZBZVYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<IWUJLJYSQDA>, MCRZZCNKUJE>> MRKZPOVXOLE(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<RGHHVUNUSGT>, MCRZZCNKUJE>> NYCFZUVOMJJ(Id128<YUFXTHDQAZB> graphId, Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface CGBVOBTKVVI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CSMYPKLUVZQ([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface KJYDPEYJTPJ
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
	public sealed class LegacyEdgeMissingError : FFRJNAJYTGE, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<ISSDUATOTVT> EICTOJKLXXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<ISSDUATOTVT> UEBTFFQARGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<ISSDUATOTVT> PQTRPCPSHFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<ISSDUATOTVT> MLAMKHTRNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<EXUEQGJGLLV> TCRFCJQUXOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<METWAAXGTBK> VOWYGYOBVLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string FGMRZUWIGUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string DHHTODKGAXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2B7BC90", Offset = "0x2B7AC90", VA = "0x182B7BC90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B7BCC0", Offset = "0x2B7ACC0", VA = "0x182B7BCC0")]
		public LegacyEdgeMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> srcNodeId, [In] Id128<ISSDUATOTVT> srcLegacyNodeId, Id32<ISSDUATOTVT> dstNodeId, [In] Id128<ISSDUATOTVT> dstLegacyNodeId, Id32<EXUEQGJGLLV> inputPort, Id32<METWAAXGTBK> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B990", Offset = "0x2B7A990", VA = "0x182B7B990", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B920", Offset = "0x2B7A920", VA = "0x182B7B920", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B7BB10", Offset = "0x2B7AB10", VA = "0x182B7BB10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : FFRJNAJYTGE, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2B7C380", Offset = "0x2B7B380", VA = "0x182B7C380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C3B0", Offset = "0x2B7B3B0", VA = "0x182B7C3B0")]
		public LegacyGraphMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C1C0", Offset = "0x2B7B1C0", VA = "0x182B7C1C0", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C250", Offset = "0x2B7B250", VA = "0x182B7C250", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C310", Offset = "0x2B7B310", VA = "0x182B7C310", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, VZURHGBSTCB<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<ISSDUATOTVT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<HPGFUJBLNSN> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<FBIPJIAHSMB> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2AF14F0", Offset = "0x2AF04F0", VA = "0x182AF14F0")]
		public LegacyInputId([In] Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<FBIPJIAHSMB> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C6C0", Offset = "0x2B7B6C0", VA = "0x182B7C6C0")]
		public static bool HCRCQFCURBY([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C4D0", Offset = "0x2B7B4D0", VA = "0x182B7C4D0", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C620", Offset = "0x2B7B620", VA = "0x182B7C620")]
		public bool FNYFOTOAQQI([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C4F0", Offset = "0x2B7B4F0", VA = "0x182B7C4F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C630", Offset = "0x2B7B630", VA = "0x182B7C630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C620", Offset = "0x2B7B620", VA = "0x182B7C620", Slot = "5")]
		private bool HLASMHSTXZF([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : FFRJNAJYTGE, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<EXUEQGJGLLV> CRFXBOIZUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<EXUEQGJGLLV> BDIORBODOVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int OGOQBYKXDQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2B7CB10", Offset = "0x2B7BB10", VA = "0x182B7CB10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CB40", Offset = "0x2B7BB40", VA = "0x182B7CB40")]
		public LegacyInputIncorrectIdError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, Id32<EXUEQGJGLLV> expectedInputId, Id32<EXUEQGJGLLV> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C760", Offset = "0x2B7B760", VA = "0x182B7C760", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C890", Offset = "0x2B7B890", VA = "0x182B7C890", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CA20", Offset = "0x2B7BA20", VA = "0x182B7CA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : FFRJNAJYTGE, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int IJXXTHXXVCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int FIFZGFFPFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D200", Offset = "0x2B7C200", VA = "0x182B7D200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D230", Offset = "0x2B7C230", VA = "0x182B7D230")]
		public LegacyInputMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CF00", Offset = "0x2B7BF00", VA = "0x182B7CF00", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CFF0", Offset = "0x2B7BFF0", VA = "0x182B7CFF0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D120", Offset = "0x2B7C120", VA = "0x182B7D120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : FFRJNAJYTGE, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly Id32<DQODHRVSODS> IXPSZRCQQXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2B7D880", Offset = "0x2B7C880", VA = "0x182B7D880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D8B0", Offset = "0x2B7C8B0", VA = "0x182B7D8B0")]
		public LegacyNodeMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, Id32<DQODHRVSODS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D6A0", Offset = "0x2B7C6A0", VA = "0x182B7D6A0", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D570", Offset = "0x2B7C570", VA = "0x182B7D570", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D790", Offset = "0x2B7C790", VA = "0x182B7D790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, VZURHGBSTCB<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id128<ISSDUATOTVT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<HPGFUJBLNSN> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<HDSUEKONMVO> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF14F0", Offset = "0x2AF04F0", VA = "0x182AF14F0")]
		public LegacyOutputId([In] Id128<ISSDUATOTVT> nodeId, Id32<HPGFUJBLNSN> portGroupId, Id32<HDSUEKONMVO> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD90", Offset = "0x2B7CD90", VA = "0x182B7DD90")]
		public static bool HCRCQFCURBY([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DCE0", Offset = "0x2B7CCE0", VA = "0x182B7DCE0", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DBA0", Offset = "0x2B7CBA0", VA = "0x182B7DBA0")]
		public bool FNYFOTOAQQI([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DBB0", Offset = "0x2B7CBB0", VA = "0x182B7DBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DD00", Offset = "0x2B7CD00", VA = "0x182B7DD00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DBA0", Offset = "0x2B7CBA0", VA = "0x182B7DBA0", Slot = "5")]
		private bool BDAVQMFHHSK([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : FFRJNAJYTGE, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<METWAAXGTBK> OFNXVQCZDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Id32<METWAAXGTBK> QSNZQELISXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int XVFWQIYUGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2B7E1E0", Offset = "0x2B7D1E0", VA = "0x182B7E1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E210", Offset = "0x2B7D210", VA = "0x182B7E210")]
		public LegacyOutputIncorrectIdError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, Id32<METWAAXGTBK> expectedOutputId, Id32<METWAAXGTBK> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DFC0", Offset = "0x2B7CFC0", VA = "0x182B7DFC0", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DE30", Offset = "0x2B7CE30", VA = "0x182B7DE30", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E0F0", Offset = "0x2B7D0F0", VA = "0x182B7E0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : FFRJNAJYTGE, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int SKLESBNXKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly int SYDJGBXGAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2B7E8D0", Offset = "0x2B7D8D0", VA = "0x182B7E8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E900", Offset = "0x2B7D900", VA = "0x182B7E900")]
		public LegacyOutputMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E5D0", Offset = "0x2B7D5D0", VA = "0x182B7E5D0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E6C0", Offset = "0x2B7D6C0", VA = "0x182B7E6C0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E7F0", Offset = "0x2B7D7F0", VA = "0x182B7E7F0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class QSUPKMQDXBF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class NWRPEOJMBSC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class WIDRWTBBIAB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class FJRVMIVKDLM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class ATOQASVPSNP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class WXKZIVPIDWK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class DKRIAFHGUAF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class YUFXTHDQAZB : CHFMCCPRZNQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class BWYAJAARYFQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class EXUEQGJGLLV : QJTTGUCLNSK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class IWUJLJYSQDA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class JWMQWCSZLZH : AQGYAILKYBE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class ISSDUATOTVT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class DQODHRVSODS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class CQXXZYNUWDH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class METWAAXGTBK : QJTTGUCLNSK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class RGHHVUNUSGT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class ZZQKNMLXIHO : AQGYAILKYBE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class OQARLWCZFBO : CHFMCCPRZNQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class QJTTGUCLNSK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class HPGFUJBLNSN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class FBIPJIAHSMB : GWVCCMPWDTY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class HDSUEKONMVO : GWVCCMPWDTY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class GWVCCMPWDTY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class AQGYAILKYBE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class WDSYWYFRDRX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class SKCKNIYGNEU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class ZIQYSGCWCJF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class SNPPUNKBJMN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : FFRJNAJYTGE, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public StaticEdge XFGVGVMTKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2B7EFE0", Offset = "0x2B7DFE0", VA = "0x182B7EFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F010", Offset = "0x2B7E010", VA = "0x182B7F010")]
		public NewEdgeMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EEC0", Offset = "0x2B7DEC0", VA = "0x182B7EEC0", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EDE0", Offset = "0x2B7DDE0", VA = "0x182B7EDE0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EF60", Offset = "0x2B7DF60", VA = "0x182B7EF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : FFRJNAJYTGE, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F390", Offset = "0x2B7E390", VA = "0x182B7F390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F3C0", Offset = "0x2B7E3C0", VA = "0x182B7F3C0")]
		public NewGraphMissingError([In] Id128<YUFXTHDQAZB> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F250", Offset = "0x2B7E250", VA = "0x182B7F250", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F2B0", Offset = "0x2B7E2B0", VA = "0x182B7F2B0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F350", Offset = "0x2B7E350", VA = "0x182B7F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : FFRJNAJYTGE, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<EXUEQGJGLLV> CRFXBOIZUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Id32<EXUEQGJGLLV> QAYDONOCIVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly int OGOQBYKXDQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2B7F830", Offset = "0x2B7E830", VA = "0x182B7F830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F860", Offset = "0x2B7E860", VA = "0x182B7F860")]
		public NewInputIncorrectIdError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, Id32<EXUEQGJGLLV> expectedInputId, Id32<EXUEQGJGLLV> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F480", Offset = "0x2B7E480", VA = "0x182B7F480", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F5B0", Offset = "0x2B7E5B0", VA = "0x182B7F5B0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F740", Offset = "0x2B7E740", VA = "0x182B7F740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : FFRJNAJYTGE, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int IJXXTHXXVCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int FIFZGFFPFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2B7FF20", Offset = "0x2B7EF20", VA = "0x182B7FF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FF50", Offset = "0x2B7EF50", VA = "0x182B7FF50")]
		public NewInputMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FD50", Offset = "0x2B7ED50", VA = "0x182B7FD50", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FC20", Offset = "0x2B7EC20", VA = "0x182B7FC20", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7FE40", Offset = "0x2B7EE40", VA = "0x182B7FE40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : FFRJNAJYTGE, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<DQODHRVSODS> IXPSZRCQQXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2B80530", Offset = "0x2B7F530", VA = "0x182B80530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2B80560", Offset = "0x2B7F560", VA = "0x182B80560")]
		public NewNodeMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, [In] Id128<ISSDUATOTVT> legacyNodeId, [In] Id32<DQODHRVSODS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2B803A0", Offset = "0x2B7F3A0", VA = "0x182B803A0", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2B80290", Offset = "0x2B7F290", VA = "0x182B80290", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2B80470", Offset = "0x2B7F470", VA = "0x182B80470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : FFRJNAJYTGE, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly Id32<METWAAXGTBK> OFNXVQCZDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Id32<METWAAXGTBK> GQTEPZBMFLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int XVFWQIYUGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2B80B90", Offset = "0x2B7FB90", VA = "0x182B80B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2B80BC0", Offset = "0x2B7FBC0", VA = "0x182B80BC0")]
		public NewOutputIncorrectIdError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, Id32<METWAAXGTBK> expectedOutputId, Id32<METWAAXGTBK> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2B80970", Offset = "0x2B7F970", VA = "0x182B80970", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2B807E0", Offset = "0x2B7F7E0", VA = "0x182B807E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2B80AA0", Offset = "0x2B7FAA0", VA = "0x182B80AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : FFRJNAJYTGE, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly int SKLESBNXKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly int SYDJGBXGAZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2B81280", Offset = "0x2B80280", VA = "0x182B81280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2B812B0", Offset = "0x2B802B0", VA = "0x182B812B0")]
		public NewOutputMissingError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2B80F80", Offset = "0x2B7FF80", VA = "0x182B80F80", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2B81070", Offset = "0x2B80070", VA = "0x182B81070", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2B811A0", Offset = "0x2B801A0", VA = "0x182B811A0", Slot = "2")]
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
		public readonly Id32<METWAAXGTBK> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id32<EXUEQGJGLLV> DstId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public NewStaticEdge(Id32<METWAAXGTBK> srcId, Id32<EXUEQGJGLLV> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2B81780", Offset = "0x2B80780", VA = "0x182B81780")]
		public void URCAFVCDNTE([Out] Id32<METWAAXGTBK> srcId, [Out] Id32<EXUEQGJGLLV> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2B81700", Offset = "0x2B80700", VA = "0x182B81700")]
		public static bool HCRCQFCURBY(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2B815F0", Offset = "0x2B805F0", VA = "0x182B815F0", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2B81600", Offset = "0x2B80600", VA = "0x182B81600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2B81690", Offset = "0x2B80690", VA = "0x182B81690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : FFRJNAJYTGE, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly Id128<ATOQASVPSNP> RZWTNQMCVGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<DQODHRVSODS> IXPSZRCQQXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2B81B40", Offset = "0x2B80B40", VA = "0x182B81B40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2B81B70", Offset = "0x2B80B70", VA = "0x182B81B70")]
		public NodeDefMismatchError(Id32<YUFXTHDQAZB> graphId, [In] Id128<YUFXTHDQAZB> legacyGraphId, [In] Id32<ISSDUATOTVT> nodeId, [In] Id128<ISSDUATOTVT> legacyNodeId, [In] Id128<ATOQASVPSNP> legacyNodeDefId, [In] Id32<DQODHRVSODS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2B81910", Offset = "0x2B80910", VA = "0x182B81910", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2B81790", Offset = "0x2B80790", VA = "0x182B81790", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2B81A30", Offset = "0x2B80A30", VA = "0x182B81A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : FFRJNAJYTGE, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int TPFWJJAPHPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly int VDDWYCLHCJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly int BPCSPNQREVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2B82200", Offset = "0x2B81200", VA = "0x182B82200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2B82230", Offset = "0x2B81230", VA = "0x182B82230")]
		public NodeDescInputsMismatchError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2B81EE0", Offset = "0x2B80EE0", VA = "0x182B81EE0", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2B81FD0", Offset = "0x2B80FD0", VA = "0x182B81FD0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2B82100", Offset = "0x2B81100", VA = "0x182B82100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : FFRJNAJYTGE, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<YUFXTHDQAZB> TPKSAYVBGKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<YUFXTHDQAZB> XFOTGMLRBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly Id32<ISSDUATOTVT> RAEDKCMOFAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly Id128<ISSDUATOTVT> YFWMMDCBYNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int TPFWJJAPHPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int TFHBFINBKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int JGTCLDOJYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string ISLYGPHMQDP;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string ZOGEUCFSQNB
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2B828F0", Offset = "0x2B818F0", VA = "0x182B828F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2B82920", Offset = "0x2B81920", VA = "0x182B82920")]
		public NodeDescOutputsMismatchError(Id32<YUFXTHDQAZB> graphId, Id128<YUFXTHDQAZB> legacyGraphId, Id32<ISSDUATOTVT> nodeId, Id128<ISSDUATOTVT> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2B825D0", Offset = "0x2B815D0", VA = "0x182B825D0", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2B826C0", Offset = "0x2B816C0", VA = "0x182B826C0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2B827F0", Offset = "0x2B817F0", VA = "0x182B827F0", Slot = "2")]
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
		public readonly Id128<ISSDUATOTVT> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x15315F0", Offset = "0x15305F0", VA = "0x1815315F0")]
		public ObjectBoardProps([In] Id128<ISSDUATOTVT> objectBoardId)
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
		public readonly PJVLKDMUVJA Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly PJVLKDMUVJA Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly PJVLKDMUVJA Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly PJVLKDMUVJA Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly PJVLKDMUVJA String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly PJVLKDMUVJA Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly PJVLKDMUVJA Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly PJVLKDMUVJA Color;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2B82EE0", Offset = "0x2B81EE0", VA = "0x182B82EE0")]
		public PrimitivePortGroupModifiers(PJVLKDMUVJA @bool, PJVLKDMUVJA exec, PJVLKDMUVJA @float, PJVLKDMUVJA @int, PJVLKDMUVJA @string, PJVLKDMUVJA vector3, PJVLKDMUVJA quaternion, PJVLKDMUVJA color)
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
		public readonly Id128<ISSDUATOTVT> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<ZZQKNMLXIHO> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly Id128<ISSDUATOTVT> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Id32<JWMQWCSZLZH> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2B83490", Offset = "0x2B82490", VA = "0x182B83490")]
		public StableStaticEdge([In] Id128<ISSDUATOTVT> srcNodeId, Id32<ZZQKNMLXIHO> srcPortIndex, [In] Id128<ISSDUATOTVT> dstNodeId, Id32<JWMQWCSZLZH> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2B831B0", Offset = "0x2B821B0", VA = "0x182B831B0")]
		public static bool HCRCQFCURBY([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2B83040", Offset = "0x2B82040", VA = "0x182B83040", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2B82F90", Offset = "0x2B81F90", VA = "0x182B82F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2B83100", Offset = "0x2B82100", VA = "0x182B83100", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2B83270", Offset = "0x2B82270", VA = "0x182B83270", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xEBE2B0", Offset = "0xEBD2B0", VA = "0x180EBE2B0")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2B834B0", Offset = "0x2B824B0", VA = "0x182B834B0")]
		public StaticCircuitsConfigData BIDIANLANQI()
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
		public readonly Id128<ISSDUATOTVT> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id32<HPGFUJBLNSN> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<HDSUEKONMVO> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id128<ISSDUATOTVT> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly Id32<HPGFUJBLNSN> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly Id32<FBIPJIAHSMB> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2B83AA0", Offset = "0x2B82AA0", VA = "0x182B83AA0")]
		public StaticEdge([In] Id128<ISSDUATOTVT> srcNodeId, Id32<HPGFUJBLNSN> srcPortGroupId, Id32<HDSUEKONMVO> srcPortId, [In] Id128<ISSDUATOTVT> dstNodeId, Id32<HPGFUJBLNSN> dstPortGroupId, Id32<FBIPJIAHSMB> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2B836E0", Offset = "0x2B826E0", VA = "0x182B836E0")]
		public static bool HCRCQFCURBY([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2B835D0", Offset = "0x2B825D0", VA = "0x182B835D0", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2B83520", Offset = "0x2B82520", VA = "0x182B83520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2B835F0", Offset = "0x2B825F0", VA = "0x182B835F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2B837D0", Offset = "0x2B827D0", VA = "0x182B837D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class NXCKZLWIMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7ECC0", Offset = "0x2B7DCC0", VA = "0x182B7ECC0")]
		public static StaticEdge MQCSYLKHLDL(this CMLSXFVWIWV a)
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
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2B83AD0", Offset = "0x2B82AD0", VA = "0x182B83AD0", Slot = "4")]
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
		public readonly OYSTBDFHNJD.SVFNYUIHGCD.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		public StudioFunctionPortDeclaration(string name, OYSTBDFHNJD.SVFNYUIHGCD.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2B83CB0", Offset = "0x2B82CB0", VA = "0x182B83CB0")]
		internal static StudioFunctionPortDeclaration MQCSYLKHLDL(OYSTBDFHNJD a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2B83B20", Offset = "0x2B82B20", VA = "0x182B83B20")]
		internal OYSTBDFHNJD BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2B83C40", Offset = "0x2B82C40", VA = "0x182B83C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2B83B90", Offset = "0x2B82B90", VA = "0x182B83B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2B83AD0", Offset = "0x2B82AD0", VA = "0x182B83AD0")]
		public bool PRNKAZACVHZ(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2B83D00", Offset = "0x2B82D00", VA = "0x182B83D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly IReadOnlyDictionary<Id128<WIDRWTBBIAB>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly IReadOnlyDictionary<Id128<WIDRWTBBIAB>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x2B84140", Offset = "0x2B83140", VA = "0x182B84140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2B85690", Offset = "0x2B84690", VA = "0x182B85690")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2B85410", Offset = "0x2B84410", VA = "0x182B85410")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<WIDRWTBBIAB>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2B84A60", Offset = "0x2B83A60", VA = "0x182B84A60")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2B84620", Offset = "0x2B83620", VA = "0x182B84620")]
		public static StudioFunctionRegistration MQCSYLKHLDL(NTKJQXRWXYZ a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2B83FA0", Offset = "0x2B82FA0", VA = "0x182B83FA0")]
		public NTKJQXRWXYZ BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2B841C0", Offset = "0x2B831C0", VA = "0x182B841C0", Slot = "4")]
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
		public bool GJGEGYFMMBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x2B85BA0", Offset = "0x2B84BA0", VA = "0x182B85BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B85CF0", Offset = "0x2B84CF0", VA = "0x182B85CF0")]
		public static StudioFunctionSignature MQCSYLKHLDL(NPKAFWFRXQK a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B85740", Offset = "0x2B84740", VA = "0x182B85740")]
		public NPKAFWFRXQK BIDIANLANQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B85C70", Offset = "0x2B84C70", VA = "0x182B85C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B859C0", Offset = "0x2B849C0", VA = "0x182B859C0")]
		private static int CTHZFHIPEED(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B85BC0", Offset = "0x2B84BC0", VA = "0x182B85BC0", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B85FC0", Offset = "0x2B84FC0", VA = "0x182B85FC0", Slot = "3")]
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
	public static class XXRBVTSMDQO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1540560", Offset = "0x153F560", VA = "0x181540560")]
		public static bool SOKZYQTRDTM(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1540560", Offset = "0x153F560", VA = "0x181540560")]
		public static bool CENWBTVLQKZ(this TemplateSerializationReason a)
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
		[Cpp2IlInjected.Address(RVA = "0x1A86AE0", Offset = "0x1A85AE0", VA = "0x181A86AE0")]
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
