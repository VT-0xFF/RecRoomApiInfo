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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB84A0", Offset = "0x2BB6EA0", VA = "0x182BB84A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB4540", Offset = "0x2BB2F40", VA = "0x182BB4540", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		public readonly Id32<JNHEPOTZQDV> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<QHFBBKDJWVN> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public AbsoluteInputId(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFF80", Offset = "0x2BAE980", VA = "0x182BAFF80")]
		public static bool SHHUBVCQRYC(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFE70", Offset = "0x2BAE870", VA = "0x182BAFE70", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFE80", Offset = "0x2BAE880", VA = "0x182BAFE80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BAFF10", Offset = "0x2BAE910", VA = "0x182BAFF10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0000", Offset = "0x2BAEA00", VA = "0x182BB0000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, SCCEHWEFPHH<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<JNHEPOTZQDV> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<CEDSPQRYDBL> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<SLVANOSNYVT> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<ZJIVHHLEHRT> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0310", Offset = "0x2BAED10", VA = "0x182BB0310")]
		public AbsoluteLegacyInputId([In] Id128<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0250", Offset = "0x2BAEC50", VA = "0x182BB0250")]
		public static bool SHHUBVCQRYC([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0160", Offset = "0x2BAEB60", VA = "0x182BB0160", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0180", Offset = "0x2BAEB80", VA = "0x182BB0180")]
		public bool XNDJLZYNOLK([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2BB00A0", Offset = "0x2BAEAA0", VA = "0x182BB00A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0190", Offset = "0x2BAEB90", VA = "0x182BB0190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0180", Offset = "0x2BAEB80", VA = "0x182BB0180", Slot = "5")]
		private bool FJOMSQFYEGQ([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, SCCEHWEFPHH<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<JNHEPOTZQDV> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<CEDSPQRYDBL> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<SLVANOSNYVT> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<HEUBCRFOLEU> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0310", Offset = "0x2BAED10", VA = "0x182BB0310")]
		public AbsoluteLegacyOutputId([In] Id128<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BB04D0", Offset = "0x2BAEED0", VA = "0x182BB04D0")]
		public static bool SHHUBVCQRYC([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0330", Offset = "0x2BAED30", VA = "0x182BB0330", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0590", Offset = "0x2BAEF90", VA = "0x182BB0590")]
		public bool XNDJLZYNOLK([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0350", Offset = "0x2BAED50", VA = "0x182BB0350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0410", Offset = "0x2BAEE10", VA = "0x182BB0410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0590", Offset = "0x2BAEF90", VA = "0x182BB0590", Slot = "5")]
		private bool WVWAQHJGQUX([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<JNHEPOTZQDV> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<CEDSPQRYDBL> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0730", Offset = "0x2BAF130", VA = "0x182BB0730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public AbsoluteNodeId(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BB06B0", Offset = "0x2BAF0B0", VA = "0x182BB06B0")]
		public static bool SHHUBVCQRYC(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0630", Offset = "0x2BAF030", VA = "0x182BB0630", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BB05A0", Offset = "0x2BAEFA0", VA = "0x182BB05A0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0640", Offset = "0x2BAF040", VA = "0x182BB0640", Slot = "2")]
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
		public readonly Id32<JNHEPOTZQDV> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<SYPXNPTSRKI> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public AbsoluteOutputId(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2BB08E0", Offset = "0x2BAF2E0", VA = "0x182BB08E0")]
		public static bool SHHUBVCQRYC(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2BB07D0", Offset = "0x2BAF1D0", VA = "0x182BB07D0", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2BB07E0", Offset = "0x2BAF1E0", VA = "0x182BB07E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0870", Offset = "0x2BAF270", VA = "0x182BB0870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0960", Offset = "0x2BAF360", VA = "0x182BB0960", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BB0C80", Offset = "0x2BAF680", VA = "0x182BB0C80")]
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
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
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
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
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
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CircuitTypeIdWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<JCARNWHFFIV> TypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly IReadOnlyList<CircuitTypeIdWrapper>? TypeParameterAssignments;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x19C1B20", Offset = "0x19C0520", VA = "0x1819C1B20")]
		private CircuitTypeIdWrapper(Id32<JCARNWHFFIV> typeId, IReadOnlyList<CircuitTypeIdWrapper>? typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0B50", Offset = "0x2BAF550", VA = "0x182BB0B50")]
		public static CircuitTypeIdWrapper LRKCREICNBU(Id32<JCARNWHFFIV> typeId)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0B80", Offset = "0x2BAF580", VA = "0x182BB0B80")]
		public static CircuitTypeIdWrapper NUAHKGVZCHM(Id32<JCARNWHFFIV> typeId, IReadOnlyList<CircuitTypeIdWrapper> a)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0BB0", Offset = "0x2BAF5B0", VA = "0x182BB0BB0", Slot = "3")]
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
		private sealed class CAKVKJDIRQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod TKNGAEUCNGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string LTCUZYHUHUF;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CAKVKJDIRQL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2BB0A00", Offset = "0x2BAF400", VA = "0x182BB0A00")]
			internal Task<bool> CMTNCYRJJNO(string? value)
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
			[Cpp2IlInjected.Address(RVA = "0x2BBBB80", Offset = "0x2BBA580", VA = "0x182BBBB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BBDC80", Offset = "0x2BBC680", VA = "0x182BBDC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE100", Offset = "0x2BBCB00", VA = "0x182BBE100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> TKNGAEUCNGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? KADZDGSJIRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? IDITGZJCNSP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? QNODXPVWTWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? ZBGEJOLOWGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? BHVUPAVSZMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? PQOIRCWVTIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD15950", Offset = "0xD14350", VA = "0x180D15950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? FYJJYCZLKVM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GLNDTVGFIEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E50", Offset = "0xDB4850", VA = "0x180DB5E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xDE1D00", Offset = "0xDE0700", VA = "0x180DE1D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1100", Offset = "0x2BAFB00", VA = "0x182BB1100")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0CC0", Offset = "0x2BAF6C0", VA = "0x182BB0CC0")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void IBUXPKSXHOQ(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0DA0", Offset = "0x2BAF7A0", VA = "0x182BB0DA0")]
		public Task MWYGDRVICLQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0F70", Offset = "0x2BAF970", VA = "0x182BB0F70")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> TJPATVVHNHL(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
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
	public interface OAFGGXPPURN : IEQIKXVEANC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface EYQDUBDWXTG : GSOEDYAARUW
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OVCRPKULUOB();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IEQIKXVEANC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface YTJEOBZMNSE
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface ASJSFOXYQJA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface SCJHQENLOSH : GSOEDYAARUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RTMZFCVHNUH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface FNRFQENIPMQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string NFWJQSGZTQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int YXWAGWTVTTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool QIWFBWENYNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface NOEMDSCOVZL : GSOEDYAARUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(GSOEDYAARUW ui);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(GSOEDYAARUW ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface SQLANVOTPXH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TPEHJJVQTCL(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RMHLEHYPTAS(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MXYXRUBVUUD(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GHGDGOOVBAL(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AFCQWVQNHLL(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZGNSQPPZENL(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RLWVEILUKHQ(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BBYVCMSUUDJ
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
		public interface QJKWEUUZVRH
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool EBOSNGZQLZB
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
			void FGJSANYMWZU();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface QAJNFKPBSIJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string SZANGXZKTMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			QPNCTETKRGD AKBKXAEYDDF
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? ACXYRLSYBUR
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			MFITZWJKJNB? PNAKJUBTJEI
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool EBOSNGZQLZB
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void FSFEDQUTOIU();

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void ZSMGCPEFZVP();

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void BCJFQUZYJWH(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface DDQHPFHUJJA
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<BBYVCMSUUDJ>? UCNUHNVUEJE
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			GSOEDYAARUW YHWIIZLYXOG(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		DDQHPFHUJJA Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GSOEDYAARUW GIRBDWRDBCS(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GSOEDYAARUW FTHBCXIEBUN(IReadOnlyList<GSOEDYAARUW> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GSOEDYAARUW YTZUJMQVBVF(IReadOnlyList<GSOEDYAARUW> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GSOEDYAARUW ZFZGSNWLNTN(Func<int> a, Func<int, Task<bool>> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GSOEDYAARUW SWVOJDWROID(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GSOEDYAARUW GVLRUCYOVWD(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		GSOEDYAARUW DDWZPMVUIWJ(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		GSOEDYAARUW HBWXMTMPZQD(Func<Id128<JNHEPOTZQDV>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		GSOEDYAARUW GFGHVOGNJWH(GSOEDYAARUW a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		NOEMDSCOVZL BEYSNPGBKNR(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<GSOEDYAARUW>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		GSOEDYAARUW DGEDMZVDWHU(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		GSOEDYAARUW NPMPUSJVJVW(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		GSOEDYAARUW NVRNHNDARHQ(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		GSOEDYAARUW YOJUITJFSVP(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		GSOEDYAARUW NBXPKROCKLP(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		GSOEDYAARUW KPYHEULOFEE(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		GSOEDYAARUW GCLIQAJHXBS(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		GSOEDYAARUW YLIIMBRIIRD(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<GSOEDYAARUW>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		GSOEDYAARUW RVQEHUGQSLA(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		GSOEDYAARUW IKREZWPQFZD(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		GSOEDYAARUW SJUFTCLJYAV(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		EYQDUBDWXTG BWFBDFZBSHE(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		EYQDUBDWXTG VPSLURZFGCZ(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		GSOEDYAARUW SDFBOYMOYVD(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		GSOEDYAARUW GGBNNXQFPPL(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SCJHQENLOSH DGLMDFMTEGY(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<GSOEDYAARUW>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void KBBCADSLRNF(GSOEDYAARUW a);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void ZIEFQXIWWPB(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void REPZXNNJWXR(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<GSOEDYAARUW>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		QJKWEUUZVRH XDUOQOCRWFW(string a, IReadOnlyList<GSOEDYAARUW> b, [Optional] IReadOnlyList<GSOEDYAARUW>? headerElements, [Optional] IReadOnlyList<GSOEDYAARUW>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		QAJNFKPBSIJ EPOVFGWKJIG(string a, string b, QPNCTETKRGD c, Action<QAJNFKPBSIJ> d, int e = 160, [Optional] (Func<QPNCTETKRGD, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, MFITZWJKJNB InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void KGLKFXNDNPI(string a);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "33")]
		GSOEDYAARUW JSULUEBJAKF(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "34")]
		GSOEDYAARUW ZGGYDVJRMFC<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "35")]
		GSOEDYAARUW AMZAGOKFQDQ(Func<string> a, Action<string> b, string c = "", string d = "");

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "36")]
		GSOEDYAARUW NCYPSRUMXGK(Func<string?> imageGetter, Func<bool>? isModifiedGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface GSOEDYAARUW
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GYFXXNNSJSW();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface FEDPZVIHXCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface YOBVMUZZIOQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XIQHVSNLMJE();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MNDZGKFHHDR(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KTCJZXKNRNM(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XNOXUCKMZXB(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface ZBHZKEAZREZ : LSNRXVKTUTI, CBUCXYTAOGI
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind QZFCEIPKDTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface JHUYQVJKPMK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface WKJPEKOLCLW
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool GXMCPXEGNEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool AEALGVIRRVD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool VIUOYYFNIOX(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType LBXDSGCRSMQ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool JPWVTGNQCUP(Id128<SZWXGBXMTIF> nodeDefId, Id128<JNHEPOTZQDV>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EWUORTTSEEE(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JIPIAYAIQLE(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface ZLCREPABUWP
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		BSRXIMSMGHS? UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool QIGYLHUAXEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool DPTEPOEQTWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<BSRXIMSMGHS> MKPIHAMKQPZ();

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, CBUCXYTAOGI> PPZZJCTMNVB([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<JNHEPOTZQDV>, Guid> VOVYYNFXULF(IEnumerable<FKWMEATAMCU> a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData DYAHVEBVFFJ(IEnumerable<FKWMEATAMCU> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface XXPTNFBFHHT
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DUPYCJDBMAF(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZKEGXWRGYBH(Id32<VESIVXUOWMV> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SKYKHHCDPQD(Id32<VESIVXUOWMV> functionId);

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
	public interface BSRXIMSMGHS
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
			public readonly IEnumerable<FKWMEATAMCU> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<JNHEPOTZQDV> SpawnIntoGraphId;

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
			[Cpp2IlInjected.Address(RVA = "0x2BB85D0", Offset = "0x2BB6FD0", VA = "0x182BB85D0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<FKWMEATAMCU> persistenceViews, bool assignNewIds, [In] Id128<JNHEPOTZQDV> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
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
			[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB8680", Offset = "0x2BB7080", VA = "0x182BB8680")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<JNHEPOTZQDV> FGJFEUWFBZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers GUSHPHEGUTB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> BJJUUGYGUUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action TVYSBGJGSWB;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> AGPTOVIGABF;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) EOIWADKYOJY(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool XEYEEWQEAGL(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ORDLNGPDVFV(ZYTONKDQJVT a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool SKOBZIBWDVM(RVVOEOTHFNY a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? RADGBDIQYNT(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? THCZEBUBXNG(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<SYPXNPTSRKI>? UBWEQYCYJMK(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<QHFBBKDJWVN>? PYUNQXBUSUT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<JNHEPOTZQDV>> WFFWSOFTHGH();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<VESIVXUOWMV>> XJLNGTOBDNK();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Id32<VESIVXUOWMV>? NXVXVAWVUJS(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int YOLYHPHLHXP(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int BZTDQYYJEFU(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(CircuitTypeIdWrapper, string)[] MXOKAPKDQQL(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(CircuitTypeIdWrapper, string)[] UCIDBFSBICQ(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string UHIBMYVBSDK(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string NWTHZHCHJWI(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		string FKXXNMXBYHP(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		PHLWUXYOEFH? PCJQMTGWFHY([In] Id128<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		PHLWUXYOEFH? PCJQMTGWFHY(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Id32<JNHEPOTZQDV> OQXGFYRKSQX([In] Id128<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Id32<JNHEPOTZQDV>? LMPPSDPKUKD([In] Id128<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Id32<JNHEPOTZQDV>? DPBWHQWOWPY(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		JBOFPJQGWHN? VHZVCWWQUSS([In] Id128<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Id32<MXFPFCGZOVW> DDTCMPATSCU(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Id32<CEDSPQRYDBL> CVNZDXPADUH(Id32<JNHEPOTZQDV> graphId, [In] Id128<CEDSPQRYDBL> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		AbsoluteNodeId? ATNAERDHRCR(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		long SHKIEOICXFI();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IEnumerable<NewStaticEdge> UAQHHTRKRJE(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool KRFBNOXHWKG(Id32<VESIVXUOWMV> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "32")]
		IEnumerable<StableStaticEdge> UIUQRBVVVDM(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "33")]
		IEnumerable<StableStaticEdge> UCKGPWZDSEN(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<(Id32<JNHEPOTZQDV>, Id32<CEDSPQRYDBL>)> VKWZTPDKDJW(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Id32<QHFBBKDJWVN> PYUNQXBUSUT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<ZWLKOZHLTZH> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Id32<CEDSPQRYDBL> VTTSOEBHBUM(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id32<CEDSPQRYDBL> HSSCNDMJRFZ(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id32<SYPXNPTSRKI> UBWEQYCYJMK(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<YCFCZDWBOEE> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "39")]
		IEnumerable<EECTNTBWABE> YYNDBGXHWCG(RoomVersion a, bool b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "40")]
		EECTNTBWABE JITRHGQHJXB(RoomVersion a, OYFUCBVVEZS b, bool c, bool d, bool e, bool f, bool g);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "41")]
		NewStaticEdge JVCDIAWAGYV(Id32<JNHEPOTZQDV> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Id128<JNHEPOTZQDV> EUVHWTCBUQG(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Id128<CEDSPQRYDBL> XFTTKQKPFJG(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "44")]
		StableStaticEdge LBWQWCQHLGE(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, LSNRXVKTUTI>> JZZUOECNHVP(Id32<JNHEPOTZQDV> parentGraphId, Id32<CEDSPQRYDBL> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<Result<None, LSNRXVKTUTI>> HUCFLBXFOBK(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, List<Id32<CEDSPQRYDBL>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "47")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)>) XZISCSYGELC(Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task HEUHRQDIWBA(Id128<JNHEPOTZQDV> legacyGraphId, Id128<CEDSPQRYDBL> boardNodeId, IReadOnlyList<Id128<CEDSPQRYDBL>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<SLVANOSNYVT>, Id32<ZJIVHHLEHRT>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<SLVANOSNYVT>, Id32<HEUBCRFOLEU>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<Result<None, LSNRXVKTUTI>> SGFGMBFBXZP(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, List<Id32<CEDSPQRYDBL>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, LSNRXVKTUTI>> AWDPWUKRQIH(Id32<JNHEPOTZQDV> parentGraphId, Id128<CEDSPQRYDBL> boardNodeId, Id32<JNHEPOTZQDV> graphId, List<Id32<CEDSPQRYDBL>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool FCBBGKZZHLE(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool CMHBRWBFPPY(Id32<JNHEPOTZQDV> graphId, Id32<QHFBBKDJWVN> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool SIATNERJUTR(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Result<PrepareTemplateForCloneResult, ZBHZKEAZREZ> UKVYQCIETTJ([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, LSNRXVKTUTI>> KSZGZREYLPN(Id32<JNHEPOTZQDV> graphId, Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<Id32<CEDSPQRYDBL>, LSNRXVKTUTI>> NPJKUIMGDCC(Id32<JNHEPOTZQDV> graphId, Id32<MXFPFCGZOVW> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> TBRJAYIKSZR(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Result<ControlPanelRootData, CBUCXYTAOGI> WXZDCPAKFQD(Id128<JNHEPOTZQDV> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Result<None, LSNRXVKTUTI>> NFCQJJUAJYH(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> inputNodeId, Id32<SLVANOSNYVT> inputPortGroupId, Id32<ZJIVHHLEHRT> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "60")]
		Task<Result<None, LSNRXVKTUTI>> DRSYLYYTJRA(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> outputNodeId, Id32<SLVANOSNYVT> outputPortGroupId, Id32<HEUBCRFOLEU> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "61")]
		Task<Result<None, LSNRXVKTUTI>> EGGATNLWEPZ(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		Task<Result<IEnumerable<Id128<CEDSPQRYDBL>>, LSNRXVKTUTI>> FPQSDMGPVAM(Id128<JNHEPOTZQDV> intoGraphId, CircuitTemplateRootData a, IEnumerable<FKWMEATAMCU> b);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		CircuitsData VPHJRZKZXNI();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "64")]
		CircuitsData SCVFMERYXVV();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "65")]
		CircuitsTemplateData OANBRCLBWMD(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id128<CEDSPQRYDBL>> nodeIds, IEnumerable<FKWMEATAMCU> b, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "66")]
		CircuitsTemplateData OANBRCLBWMD(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id32<CEDSPQRYDBL>> nodeIds, IEnumerable<FKWMEATAMCU> b, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "67")]
		CircuitsTemplateData THUWIZSHEKY(TemplateSerializationReason a, Id32<JNHEPOTZQDV> sourceGraphId, IEnumerable<Id128<JNHEPOTZQDV>> graphIds, IEnumerable<Id128<CEDSPQRYDBL>> nodeIds, ISet<Id128<MVCTDZBQWKN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "68")]
		List<YTJEOBZMNSE> GITXGASFSFO();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "69")]
		(List<YTJEOBZMNSE>, bool) MFXUMGOBXFR([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, HFOGEYCEIIA b, HCKWIMUSVHK c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool ZBCSDUDNMVU(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool OIMAFFUSAMA(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Result<Id32<SYPXNPTSRKI>?, LSNRXVKTUTI> SPQURDYNOZV(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<QHFBBKDJWVN> inputId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Result<Id32<QHFBBKDJWVN>?, LSNRXVKTUTI> VRYLEJRTJSP(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SYPXNPTSRKI> outputId);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task<Result<None, LSNRXVKTUTI>> HUEIJIJMNKI();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task<Result<None, LSNRXVKTUTI>> PTAXJNCONIO(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Id32<CEDSPQRYDBL>? YTGMUCEQFHS(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Id32<CEDSPQRYDBL>? VINGIUYAZEB(Id32<JNHEPOTZQDV> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		int LJXLYPBBTLT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int KEDUQOUHWRA(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "80")]
		int GLCZOOWQSTB(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "81")]
		int IJRPSTKWHVL(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "82")]
		Task<Result<None, LSNRXVKTUTI>> MAVELFKJLDT(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "83")]
		Task<Result<None, LSNRXVKTUTI>> APGVEIHHDNI(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "84")]
		int YMJMAZOWXDH(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<None, LSNRXVKTUTI>> UCFBKLGUVUH(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "86")]
		Task<Result<None, LSNRXVKTUTI>> MOLSKGUVEVO(Id32<JNHEPOTZQDV> graphId, Id32<CEDSPQRYDBL> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "87")]
		bool SYVHNEQNMND();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IEnumerable<Id32<XKJFYYKFODF>> JGWYDHFSZVJ();

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		string? NWNLRAEFZED(Id32<XKJFYYKFODF> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface FPJQQVBJGJY : OVPOWTRSBTJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		ZLCREPABUWP IPSDSBEJJJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface LSNRXVKTUTI : CBUCXYTAOGI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface PHLWUXYOEFH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<JNHEPOTZQDV>? DJGYFWAVSVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<JNHEPOTZQDV> RYMNSBEUIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<CEDSPQRYDBL>? EYMUNTXOKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? TBOHOFZKMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface ZYTONKDQJVT : OYFUCBVVEZS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<ZJIVHHLEHRT> DFUZABHQYGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<QHFBBKDJWVN> DDSFVFRDOSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IOOVRRREEJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DJXDWKSTVEY(FEDPZVIHXCH a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CYXCDQYXTAT(SQLANVOTPXH a);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string KVLOPWSQCZG(int a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RUFHMRAQFYT(JZDPAJDHTHD a);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BVLPRDBLEHY(JZDPAJDHTHD a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface JZDPAJDHTHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface JBOFPJQGWHN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<SZWXGBXMTIF> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<MXFPFCGZOVW> NewNodeTypeId
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
		Id32<JNMNERPAZHW> IconId
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
		FNRFQENIPMQ? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<JNHEPOTZQDV> GraphId
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
		Id32<JNHEPOTZQDV>? InnerGraphId
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
		Id32<JNHEPOTZQDV>? ProxyGraphId
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
		IEnumerable<Id128<CEDSPQRYDBL>>? InnerGraphNodeIds
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
		Id128<JNHEPOTZQDV> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<CEDSPQRYDBL> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<CEDSPQRYDBL> LegacyNodeId
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
		ReadOnlyIdArray<SLVANOSNYVT, IODGEOJDMSL> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<SLVANOSNYVT>? SelfPortGroupId
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
		event Action UZZEWHPQXVX;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate MXJISJJQTYU;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate JBAVHJHKNFB;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action VTCZULEBXWD;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action HHYMXBUXBTM;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> XQVDZQDSFEH;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<SLVANOSNYVT>> RSLWLHLOGFO;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> YNBEFKFSXMO;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<SLVANOSNYVT>, Id32<SLVANOSNYVT>> MWOQQOWVNEX;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<SLVANOSNYVT>, IODGEOJDMSL> VKLSWYPKDAH;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<SLVANOSNYVT>, Id32<SLVANOSNYVT>> NGKSQIOHQFE;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> OWKPYPTOVIP;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Result<None, LSNRXVKTUTI>> KACFKBCGQWK(int a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool YDIAQKXFKPM([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool AMCAOVPRDGX([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void XQEHULFUTFB(bool a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task KIDXBOZSFUP();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, LSNRXVKTUTI>> EPSKWZTNYVU(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void ASHZBQGIXNP();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool XEKHCMPBWDY([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool JIEDFZDBEMX([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void PVTPBUYKQFH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "50")]
		IEQIKXVEANC BOFYTAVDGZP([In] OAFGGXPPURN audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<SLVANOSNYVT>, LSNRXVKTUTI>> UUMJVVRWSQJ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void CYXCDQYXTAT(BBYVCMSUUDJ a);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform VICEHOZIEAC();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool IJOBGNQMGKI(Id32<SLVANOSNYVT> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, LSNRXVKTUTI>> SRTSVRNFSGQ(Id32<SLVANOSNYVT> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool VLRXKNGFTPK(Id32<SLVANOSNYVT> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void MIVVQPIBDNO();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void ADRSSITDETW(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void VRKUEIFNVTT(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void OVHLIJFBCEN(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void NFAQDKSHQDE(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void OWDVGYVNJXZ(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void ZJWSCNTGPHW(Id32<SLVANOSNYVT> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void TBCFOBOQOBO(Id32<SLVANOSNYVT> sourceId, Id32<SLVANOSNYVT> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void TSDPHUKTHGV(Id32<SLVANOSNYVT> sourceId, Id32<SLVANOSNYVT> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void IUQAMXHHSYN(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface RVVOEOTHFNY : OYFUCBVVEZS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<SYPXNPTSRKI> LXZBZPPPUDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<HEUBCRFOLEU> UPIIKKDMCET
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface OYFUCBVVEZS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> ZPZLEYQFONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind FUDMJCXWCHA
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<JNHEPOTZQDV> RYMNSBEUIGP
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<JNHEPOTZQDV> ZHHVBXZBZCS
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<CEDSPQRYDBL> ISUHRYTLBHO
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<SLVANOSNYVT> DLUZLNPMNKV
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<KSZBOHEYNRE> NRJLNJAXMBP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		QPNCTETKRGD WOADRHKBNRP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage DHRLNYUTZTE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool YIMMFBKFJVY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DIMDQBIRTDP(ZHRYWQMAYDW a);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void MWTLGMTUGVR(SBKNEEHEBNY a);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void JZEEQPZFBYV(YOBVMUZZIOQ a);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void NTWCXTDQZOC(ZHRYWQMAYDW a);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void QTUWQRBUWNG(SBKNEEHEBNY a);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void YRLSEECDYAQ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface ZHRYWQMAYDW
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface IODGEOJDMSL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<SLVANOSNYVT> newValue, Id32<SLVANOSNYVT> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool KAHKINNAZBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool MEWRAYZWBYL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool RYJDCWNHCZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<JNHEPOTZQDV> ZHHVBXZBZCS
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool AJWQTLDGEPF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<ZJIVHHLEHRT, ZYTONKDQJVT> AHNQPCHOHYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string EDJPGUEQTOV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<CEDSPQRYDBL> ISUHRYTLBHO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<HEUBCRFOLEU, RVVOEOTHFNY> WJRAALCBJEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<SLVANOSNYVT> DLUZLNPMNKV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action CAKFBYCKMLD;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action JOCKUYIVTHQ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<ZJIVHHLEHRT>, Id32<ZJIVHHLEHRT>> MAODWLRMCMV;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<ZJIVHHLEHRT>, Id32<ZJIVHHLEHRT>> KIMWFWMMHIW;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<HEUBCRFOLEU>, Id32<HEUBCRFOLEU>> IMMWMOQRRNS;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<HEUBCRFOLEU>, Id32<HEUBCRFOLEU>> NOEMGLBRSGZ;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<ZJIVHHLEHRT>, ZYTONKDQJVT> NPTPAZQHKLQ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<ZJIVHHLEHRT>> GXLEIXDFABV;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<ZJIVHHLEHRT>, ZYTONKDQJVT> HQKIPTQAHUG;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<HEUBCRFOLEU>, RVVOEOTHFNY> QOXUQTHDEDX;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<HEUBCRFOLEU>> PAERFSBCRDI;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<HEUBCRFOLEU>, RVVOEOTHFNY> TQKJENFKTCF;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, LSNRXVKTUTI>> PDJQSTUFRRG();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, LSNRXVKTUTI>> MTMEHCITSJL(Id32<TQQQOXOZIAW> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, LSNRXVKTUTI>> IKHUBNTUHGS(Id32<MMHQXLWOJFR> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, LSNRXVKTUTI>> GPAOPLNIWPJ(Id32<TQQQOXOZIAW> inputDefId, Id32<TQQQOXOZIAW> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, LSNRXVKTUTI>> BTSGGLZSQJY(Id32<MMHQXLWOJFR> outputDefId, Id32<MMHQXLWOJFR> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, LSNRXVKTUTI>> JODBHENPKBP();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, LSNRXVKTUTI>> QBMBYCMZIXK(string a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, LSNRXVKTUTI>> JMTPYBWXQBR(Id32<TQQQOXOZIAW> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, LSNRXVKTUTI>> GOLXUWQYKQE(Id32<MMHQXLWOJFR> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, LSNRXVKTUTI>> SLVBTTAXUNW(Id32<TQQQOXOZIAW> inputDefId, EECTNTBWABE a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, LSNRXVKTUTI>> FCKWJLSMJEB(Id32<MMHQXLWOJFR> outputDefId, EECTNTBWABE a);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void UIXNXOWIABN(int a, Id32<ZJIVHHLEHRT> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void VOHOMKQOXTO(int a, Id32<ZJIVHHLEHRT> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void RWNWPWZDHVU(int a, Id32<HEUBCRFOLEU> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void PQSUYQPJMBR(int a, Id32<HEUBCRFOLEU> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void KFLHHTNGPLS(int a, Id32<ZJIVHHLEHRT> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void VMBYFGSJORH(int a, Id32<ZJIVHHLEHRT> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void HGNELLZSROT(int a, Id32<HEUBCRFOLEU> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void JYXBOWKSNNC(int a, Id32<HEUBCRFOLEU> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void ZAEGIINRETW(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void MCBKXQFULVX(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void BTTYMDSHUOD(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void MAJPGENLTNO(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void QIBRTRPDPNY(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void FSKLENNTZGB(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void GDTJTWQJLUF(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void AILZENAZTZW(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void NEXPAQBCLRR(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void AIZMDSSNBPU(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void PTMSPTKTUGQ(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void SZGSHPUCMOD(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface EECTNTBWABE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey CGMZLBFJJSF
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string ZMMWBEPTIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<TQQQOXOZIAW>, LSNRXVKTUTI>> DGPHOLUEWMS(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<MMHQXLWOJFR>, LSNRXVKTUTI>> SYFXHEONCAT(Id128<JNHEPOTZQDV> graphId, Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface SBKNEEHEBNY
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RFKKWBVKYGC([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface QPNCTETKRGD
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
	public sealed class LegacyEdgeMissingError : YTJEOBZMNSE, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<CEDSPQRYDBL> ZJOMKQRPBQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<CEDSPQRYDBL> CUHLFRVKFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<CEDSPQRYDBL> DZGLYWWVSFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<CEDSPQRYDBL> STKQHEANRGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<QHFBBKDJWVN> RYNZYDWHOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<SYPXNPTSRKI> IEKLVVISKNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string JPRXQLQJPZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string OBZXUVGRTQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2BB1410", Offset = "0x2BAFE10", VA = "0x182BB1410", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2BB15C0", Offset = "0x2BAFFC0", VA = "0x182BB15C0")]
		public LegacyEdgeMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> srcNodeId, [In] Id128<CEDSPQRYDBL> srcLegacyNodeId, Id32<CEDSPQRYDBL> dstNodeId, [In] Id128<CEDSPQRYDBL> dstLegacyNodeId, Id32<QHFBBKDJWVN> inputPort, Id32<SYPXNPTSRKI> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xD14200", Offset = "0xD12C00", VA = "0x180D14200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1290", Offset = "0x2BAFC90", VA = "0x182BB1290", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1220", Offset = "0x2BAFC20", VA = "0x182BB1220", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1440", Offset = "0x2BAFE40", VA = "0x182BB1440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : YTJEOBZMNSE, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2BB1C10", Offset = "0x2BB0610", VA = "0x182BB1C10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1CB0", Offset = "0x2BB06B0", VA = "0x182BB1CB0")]
		public LegacyGraphMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1AC0", Offset = "0x2BB04C0", VA = "0x182BB1AC0", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1B50", Offset = "0x2BB0550", VA = "0x182BB1B50", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1C40", Offset = "0x2BB0640", VA = "0x182BB1C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, SCCEHWEFPHH<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<CEDSPQRYDBL> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<SLVANOSNYVT> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<ZJIVHHLEHRT> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2B26BE0", Offset = "0x2B255E0", VA = "0x182B26BE0")]
		public LegacyInputId([In] Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<ZJIVHHLEHRT> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1FC0", Offset = "0x2BB09C0", VA = "0x182BB1FC0")]
		public static bool SHHUBVCQRYC([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1DE0", Offset = "0x2BB07E0", VA = "0x182BB1DE0", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1DD0", Offset = "0x2BB07D0", VA = "0x182BB1DD0")]
		public bool XNDJLZYNOLK([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1E00", Offset = "0x2BB0800", VA = "0x182BB1E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1F30", Offset = "0x2BB0930", VA = "0x182BB1F30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB1DD0", Offset = "0x2BB07D0", VA = "0x182BB1DD0", Slot = "5")]
		private bool DIBQHUEMEBZ([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : YTJEOBZMNSE, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<QHFBBKDJWVN> YFVWVHSRYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<QHFBBKDJWVN> FVBJZOISYCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int GJZOWLRZUCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2320", Offset = "0x2BB0D20", VA = "0x182BB2320", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2440", Offset = "0x2BB0E40", VA = "0x182BB2440")]
		public LegacyInputIncorrectIdError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, Id32<QHFBBKDJWVN> expectedInputId, Id32<QHFBBKDJWVN> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2060", Offset = "0x2BB0A60", VA = "0x182BB2060", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2190", Offset = "0x2BB0B90", VA = "0x182BB2190", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2350", Offset = "0x2BB0D50", VA = "0x182BB2350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : YTJEOBZMNSE, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int IYKLOYCHBAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int ADJCGUDNDVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2A20", Offset = "0x2BB1420", VA = "0x182BB2A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2B30", Offset = "0x2BB1530", VA = "0x182BB2B30")]
		public LegacyInputMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2800", Offset = "0x2BB1200", VA = "0x182BB2800", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2BB28F0", Offset = "0x2BB12F0", VA = "0x182BB28F0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A50", Offset = "0x2BB1450", VA = "0x182BB2A50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : YTJEOBZMNSE, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly Id32<MXFPFCGZOVW> DFXKEOIAPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2BB3090", Offset = "0x2BB1A90", VA = "0x182BB3090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2BB31B0", Offset = "0x2BB1BB0", VA = "0x182BB31B0")]
		public LegacyNodeMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, Id32<MXFPFCGZOVW> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2FA0", Offset = "0x2BB19A0", VA = "0x182BB2FA0", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2E70", Offset = "0x2BB1870", VA = "0x182BB2E70", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB30C0", Offset = "0x2BB1AC0", VA = "0x182BB30C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, SCCEHWEFPHH<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id128<CEDSPQRYDBL> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<SLVANOSNYVT> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<HEUBCRFOLEU> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2B26BE0", Offset = "0x2B255E0", VA = "0x182B26BE0")]
		public LegacyOutputId([In] Id128<CEDSPQRYDBL> nodeId, Id32<SLVANOSNYVT> portGroupId, Id32<HEUBCRFOLEU> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3680", Offset = "0x2BB2080", VA = "0x182BB3680")]
		public static bool SHHUBVCQRYC([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB35D0", Offset = "0x2BB1FD0", VA = "0x182BB35D0", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3720", Offset = "0x2BB2120", VA = "0x182BB3720")]
		public bool XNDJLZYNOLK([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2BB34A0", Offset = "0x2BB1EA0", VA = "0x182BB34A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2BB35F0", Offset = "0x2BB1FF0", VA = "0x182BB35F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3720", Offset = "0x2BB2120", VA = "0x182BB3720", Slot = "5")]
		private bool ZPNNLPZYSLM([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : YTJEOBZMNSE, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<SYPXNPTSRKI> JIFGIEPYCZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Id32<SYPXNPTSRKI> OZEASJYBXYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int ONJUFPMFNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2BB39F0", Offset = "0x2BB23F0", VA = "0x182BB39F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3B10", Offset = "0x2BB2510", VA = "0x182BB3B10")]
		public LegacyOutputIncorrectIdError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, Id32<SYPXNPTSRKI> expectedOutputId, Id32<SYPXNPTSRKI> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2BB38C0", Offset = "0x2BB22C0", VA = "0x182BB38C0", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3730", Offset = "0x2BB2130", VA = "0x182BB3730", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3A20", Offset = "0x2BB2420", VA = "0x182BB3A20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : YTJEOBZMNSE, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int OLIFWYGXVYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly int BPKBHIXMEVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x2BB40F0", Offset = "0x2BB2AF0", VA = "0x182BB40F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4200", Offset = "0x2BB2C00", VA = "0x182BB4200")]
		public LegacyOutputMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3ED0", Offset = "0x2BB28D0", VA = "0x182BB3ED0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB3FC0", Offset = "0x2BB29C0", VA = "0x182BB3FC0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4120", Offset = "0x2BB2B20", VA = "0x182BB4120", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class XKJFYYKFODF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class BJIPVLHBSKG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class MVCTDZBQWKN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class LBAQMGWHYRE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class SZWXGBXMTIF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class REYKDUXIDCS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class VESIVXUOWMV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class JNHEPOTZQDV : JHUYQVJKPMK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class AVLHYHUNNYO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class QHFBBKDJWVN : RTGNEOABHKC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class TQQQOXOZIAW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class ZWLKOZHLTZH : RXGIMYISGCC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class CEDSPQRYDBL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class MXFPFCGZOVW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class KTAQVOGERXD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class SYPXNPTSRKI : RTGNEOABHKC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class MMHQXLWOJFR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class YCFCZDWBOEE : RXGIMYISGCC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class FTKUDETTREQ : JHUYQVJKPMK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class RTGNEOABHKC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class SLVANOSNYVT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class ZJIVHHLEHRT : KSZBOHEYNRE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class HEUBCRFOLEU : KSZBOHEYNRE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class KSZBOHEYNRE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class RXGIMYISGCC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class ORPCVONRMBT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class JNMNERPAZHW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class WJIFWEHLLTF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class JCARNWHFFIV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : YTJEOBZMNSE, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public StaticEdge MNVAARYEJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4740", Offset = "0x2BB3140", VA = "0x182BB4740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2BB47F0", Offset = "0x2BB31F0", VA = "0x182BB47F0")]
		public NewEdgeMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2BB46A0", Offset = "0x2BB30A0", VA = "0x182BB46A0", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2BB45C0", Offset = "0x2BB2FC0", VA = "0x182BB45C0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4770", Offset = "0x2BB3170", VA = "0x182BB4770", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : YTJEOBZMNSE, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4B30", Offset = "0x2BB3530", VA = "0x182BB4B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4BA0", Offset = "0x2BB35A0", VA = "0x182BB4BA0")]
		public NewGraphMissingError([In] Id128<JNHEPOTZQDV> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4A30", Offset = "0x2BB3430", VA = "0x182BB4A30", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4A90", Offset = "0x2BB3490", VA = "0x182BB4A90", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4B60", Offset = "0x2BB3560", VA = "0x182BB4B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : YTJEOBZMNSE, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<QHFBBKDJWVN> YFVWVHSRYOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Id32<QHFBBKDJWVN> YVQXEGFLCDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly int GJZOWLRZUCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB4F20", Offset = "0x2BB3920", VA = "0x182BB4F20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5040", Offset = "0x2BB3A40", VA = "0x182BB5040")]
		public NewInputIncorrectIdError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, Id32<QHFBBKDJWVN> expectedInputId, Id32<QHFBBKDJWVN> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4C60", Offset = "0x2BB3660", VA = "0x182BB4C60", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4D90", Offset = "0x2BB3790", VA = "0x182BB4D90", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2BB4F50", Offset = "0x2BB3950", VA = "0x182BB4F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : YTJEOBZMNSE, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int IYKLOYCHBAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int ADJCGUDNDVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5620", Offset = "0x2BB4020", VA = "0x182BB5620", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5730", Offset = "0x2BB4130", VA = "0x182BB5730")]
		public NewInputMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5530", Offset = "0x2BB3F30", VA = "0x182BB5530", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5400", Offset = "0x2BB3E00", VA = "0x182BB5400", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5650", Offset = "0x2BB4050", VA = "0x182BB5650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : YTJEOBZMNSE, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<MXFPFCGZOVW> DFXKEOIAPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2BB5C50", Offset = "0x2BB4650", VA = "0x182BB5C50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5D40", Offset = "0x2BB4740", VA = "0x182BB5D40")]
		public NewNodeMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, [In] Id128<CEDSPQRYDBL> legacyNodeId, [In] Id32<MXFPFCGZOVW> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5B80", Offset = "0x2BB4580", VA = "0x182BB5B80", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5A70", Offset = "0x2BB4470", VA = "0x182BB5A70", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5C80", Offset = "0x2BB4680", VA = "0x182BB5C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : YTJEOBZMNSE, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly Id32<SYPXNPTSRKI> JIFGIEPYCZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Id32<SYPXNPTSRKI> CDTKSDAHKRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int ONJUFPMFNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6280", Offset = "0x2BB4C80", VA = "0x182BB6280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2BB63A0", Offset = "0x2BB4DA0", VA = "0x182BB63A0")]
		public NewOutputIncorrectIdError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, Id32<SYPXNPTSRKI> expectedOutputId, Id32<SYPXNPTSRKI> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6150", Offset = "0x2BB4B50", VA = "0x182BB6150", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5FC0", Offset = "0x2BB49C0", VA = "0x182BB5FC0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2BB62B0", Offset = "0x2BB4CB0", VA = "0x182BB62B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : YTJEOBZMNSE, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly int OLIFWYGXVYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly int BPKBHIXMEVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x2BB6980", Offset = "0x2BB5380", VA = "0x182BB6980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6A90", Offset = "0x2BB5490", VA = "0x182BB6A90")]
		public NewOutputMissingError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6760", Offset = "0x2BB5160", VA = "0x182BB6760", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6850", Offset = "0x2BB5250", VA = "0x182BB6850", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB69B0", Offset = "0x2BB53B0", VA = "0x182BB69B0", Slot = "2")]
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
		public readonly Id32<SYPXNPTSRKI> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id32<QHFBBKDJWVN> DstId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public NewStaticEdge(Id32<SYPXNPTSRKI> srcId, Id32<QHFBBKDJWVN> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6DD0", Offset = "0x2BB57D0", VA = "0x182BB6DD0")]
		public void EBEXHOFOLIC([Out] Id32<SYPXNPTSRKI> srcId, [Out] Id32<QHFBBKDJWVN> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6EF0", Offset = "0x2BB58F0", VA = "0x182BB6EF0")]
		public static bool SHHUBVCQRYC(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6DE0", Offset = "0x2BB57E0", VA = "0x182BB6DE0", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6DF0", Offset = "0x2BB57F0", VA = "0x182BB6DF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6E80", Offset = "0x2BB5880", VA = "0x182BB6E80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : YTJEOBZMNSE, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly Id128<SZWXGBXMTIF> LNYSWMDMOWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<MXFPFCGZOVW> DFXKEOIAPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7210", Offset = "0x2BB5C10", VA = "0x182BB7210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7350", Offset = "0x2BB5D50", VA = "0x182BB7350")]
		public NodeDefMismatchError(Id32<JNHEPOTZQDV> graphId, [In] Id128<JNHEPOTZQDV> legacyGraphId, [In] Id32<CEDSPQRYDBL> nodeId, [In] Id128<CEDSPQRYDBL> legacyNodeId, [In] Id128<SZWXGBXMTIF> legacyNodeDefId, [In] Id32<MXFPFCGZOVW> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2BB70F0", Offset = "0x2BB5AF0", VA = "0x182BB70F0", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6F70", Offset = "0x2BB5970", VA = "0x182BB6F70", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7240", Offset = "0x2BB5C40", VA = "0x182BB7240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : YTJEOBZMNSE, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int MRRHXANUSCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly int NOWKDKFEQJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly int ALDIHWRHGLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2BB78E0", Offset = "0x2BB62E0", VA = "0x182BB78E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7A10", Offset = "0x2BB6410", VA = "0x182BB7A10")]
		public NodeDescInputsMismatchError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB76C0", Offset = "0x2BB60C0", VA = "0x182BB76C0", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB77B0", Offset = "0x2BB61B0", VA = "0x182BB77B0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7910", Offset = "0x2BB6310", VA = "0x182BB7910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : YTJEOBZMNSE, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<JNHEPOTZQDV> RYMNSBEUIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<JNHEPOTZQDV> ZHHVBXZBZCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly Id32<CEDSPQRYDBL> SCHRROBVJVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly Id128<CEDSPQRYDBL> ISUHRYTLBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int MRRHXANUSCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int VYEDCVTUBRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int CJLOENGMPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string QXZAPEXPSNL;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string NPWHNNNWHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB7FD0", Offset = "0x2BB69D0", VA = "0x182BB7FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8100", Offset = "0x2BB6B00", VA = "0x182BB8100")]
		public NodeDescOutputsMismatchError(Id32<JNHEPOTZQDV> graphId, Id128<JNHEPOTZQDV> legacyGraphId, Id32<CEDSPQRYDBL> nodeId, Id128<CEDSPQRYDBL> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7DB0", Offset = "0x2BB67B0", VA = "0x182BB7DB0", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7EA0", Offset = "0x2BB68A0", VA = "0x182BB7EA0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8000", Offset = "0x2BB6A00", VA = "0x182BB8000", Slot = "2")]
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
		public readonly Id128<CEDSPQRYDBL> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public ObjectBoardProps([In] Id128<CEDSPQRYDBL> objectBoardId)
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
		public readonly EECTNTBWABE Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly EECTNTBWABE Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly EECTNTBWABE Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly EECTNTBWABE Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly EECTNTBWABE String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly EECTNTBWABE Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly EECTNTBWABE Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly EECTNTBWABE Color;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB86C0", Offset = "0x2BB70C0", VA = "0x182BB86C0")]
		public PrimitivePortGroupModifiers(EECTNTBWABE @bool, EECTNTBWABE exec, EECTNTBWABE @float, EECTNTBWABE @int, EECTNTBWABE @string, EECTNTBWABE vector3, EECTNTBWABE quaternion, EECTNTBWABE color)
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
		public readonly Id128<CEDSPQRYDBL> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<YCFCZDWBOEE> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly Id128<CEDSPQRYDBL> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Id32<ZWLKOZHLTZH> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8C70", Offset = "0x2BB7670", VA = "0x182BB8C70")]
		public StableStaticEdge([In] Id128<CEDSPQRYDBL> srcNodeId, Id32<YCFCZDWBOEE> srcPortIndex, [In] Id128<CEDSPQRYDBL> dstNodeId, Id32<ZWLKOZHLTZH> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8990", Offset = "0x2BB7390", VA = "0x182BB8990")]
		public static bool SHHUBVCQRYC([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8820", Offset = "0x2BB7220", VA = "0x182BB8820", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8770", Offset = "0x2BB7170", VA = "0x182BB8770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2BB88E0", Offset = "0x2BB72E0", VA = "0x182BB88E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8A50", Offset = "0x2BB7450", VA = "0x182BB8A50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE9630", Offset = "0xEE8030", VA = "0x180EE9630")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8C90", Offset = "0x2BB7690", VA = "0x182BB8C90")]
		public StaticCircuitsConfigData NZJDRENIZKU()
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
		public readonly Id128<CEDSPQRYDBL> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id32<SLVANOSNYVT> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<HEUBCRFOLEU> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id128<CEDSPQRYDBL> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly Id32<SLVANOSNYVT> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly Id32<ZJIVHHLEHRT> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9280", Offset = "0x2BB7C80", VA = "0x182BB9280")]
		public StaticEdge([In] Id128<CEDSPQRYDBL> srcNodeId, Id32<SLVANOSNYVT> srcPortGroupId, Id32<HEUBCRFOLEU> srcPortId, [In] Id128<CEDSPQRYDBL> dstNodeId, Id32<SLVANOSNYVT> dstPortGroupId, Id32<ZJIVHHLEHRT> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8EC0", Offset = "0x2BB78C0", VA = "0x182BB8EC0")]
		public static bool SHHUBVCQRYC([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8DB0", Offset = "0x2BB77B0", VA = "0x182BB8DB0", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8D00", Offset = "0x2BB7700", VA = "0x182BB8D00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8DD0", Offset = "0x2BB77D0", VA = "0x182BB8DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8FB0", Offset = "0x2BB79B0", VA = "0x182BB8FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class CYMIIVCELLO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0A30", Offset = "0x2BAF430", VA = "0x182BB0A30")]
		public static StaticEdge IVDFFFMFEGJ(this ELNMLDJFDRT a)
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
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB92B0", Offset = "0x2BB7CB0", VA = "0x182BB92B0", Slot = "4")]
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
		public readonly QVQGEMLFVJT.HDTPLDNTADR.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public StudioFunctionPortDeclaration(string name, QVQGEMLFVJT.HDTPLDNTADR.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9420", Offset = "0x2BB7E20", VA = "0x182BB9420")]
		internal static StudioFunctionPortDeclaration IVDFFFMFEGJ(QVQGEMLFVJT a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9470", Offset = "0x2BB7E70", VA = "0x182BB9470")]
		internal QVQGEMLFVJT NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2BB93B0", Offset = "0x2BB7DB0", VA = "0x182BB93B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9300", Offset = "0x2BB7D00", VA = "0x182BB9300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2BB92B0", Offset = "0x2BB7CB0", VA = "0x182BB92B0")]
		public bool OUQQYCDGHYH(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2BB94E0", Offset = "0x2BB7EE0", VA = "0x182BB94E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly IReadOnlyDictionary<Id128<MVCTDZBQWKN>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly IReadOnlyDictionary<Id128<MVCTDZBQWKN>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x2BBAB00", Offset = "0x2BB9500", VA = "0x182BBAB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAE90", Offset = "0x2BB9890", VA = "0x182BBAE90")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAC10", Offset = "0x2BB9610", VA = "0x182BBAC10")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<MVCTDZBQWKN>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA020", Offset = "0x2BB8A20", VA = "0x182BBA020")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9BE0", Offset = "0x2BB85E0", VA = "0x182BB9BE0")]
		public static StudioFunctionRegistration IVDFFFMFEGJ(KJCWASNUYEN a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA960", Offset = "0x2BB9360", VA = "0x182BBA960")]
		public KJCWASNUYEN NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9780", Offset = "0x2BB8180", VA = "0x182BB9780", Slot = "4")]
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
		public bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x2BBB7A0", Offset = "0x2BBA1A0", VA = "0x182BBB7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F64830", Offset = "0x1F63230", VA = "0x181F64830")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB250", Offset = "0x2BB9C50", VA = "0x182BBB250")]
		public static StudioFunctionSignature IVDFFFMFEGJ(RHJWJTKWAKK a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB520", Offset = "0x2BB9F20", VA = "0x182BBB520")]
		public RHJWJTKWAKK NZJDRENIZKU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB1D0", Offset = "0x2BB9BD0", VA = "0x182BBB1D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAF40", Offset = "0x2BB9940", VA = "0x182BBAF40")]
		private static int BNJIFWZKWIL(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB120", Offset = "0x2BB9B20", VA = "0x182BBB120", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB7C0", Offset = "0x2BBA1C0", VA = "0x182BBB7C0", Slot = "3")]
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
	public static class NQGBMMWVVYO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1569DA0", Offset = "0x15687A0", VA = "0x181569DA0")]
		public static bool AVRJAAMCDQC(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1569DA0", Offset = "0x15687A0", VA = "0x181569DA0")]
		public static bool XHLPTMKKKPH(this TemplateSerializationReason a)
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
		[Cpp2IlInjected.Address(RVA = "0x1AB19C0", Offset = "0x1AB03C0", VA = "0x181AB19C0")]
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
