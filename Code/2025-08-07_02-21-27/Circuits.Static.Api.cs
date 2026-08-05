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
using Circuits.Static.RecRoom.Protobuf;
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
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
internal sealed class ZHPALOHOCAQ<a, b>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a EZLTIDNNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b CZJLKERKLLR;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4495E80", Offset = "0x4494A80", VA = "0x184495E80")]
	[DebuggerHidden]
	public ZHPALOHOCAQ(a a, b b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4491910", Offset = "0x4490510", VA = "0x184491910", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4492190", Offset = "0x4490D90", VA = "0x184492190", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4492FD0", Offset = "0x4491BD0", VA = "0x184492FD0", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DDA1C0", Offset = "0x2DD8DC0", VA = "0x182DDA1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DD6220", Offset = "0x2DD4E20", VA = "0x182DD6220", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<AWZVWRTEXTC> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public AbsoluteInputId(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1EB0", Offset = "0x2DD0AB0", VA = "0x182DD1EB0")]
		public static bool EOXNKNKFOQL(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1F30", Offset = "0x2DD0B30", VA = "0x182DD1F30", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1F40", Offset = "0x2DD0B40", VA = "0x182DD1F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1FD0", Offset = "0x2DD0BD0", VA = "0x182DD1FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2040", Offset = "0x2DD0C40", VA = "0x182DD2040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, MNLRIGBOINM<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<CUMWXIQVBDQ> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<GIQEAILWCVY> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2350", Offset = "0x2DD0F50", VA = "0x182DD2350")]
		public AbsoluteLegacyInputId([In] Id128<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DD20F0", Offset = "0x2DD0CF0", VA = "0x182DD20F0")]
		public static bool EOXNKNKFOQL([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2270", Offset = "0x2DD0E70", VA = "0x182DD2270", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DD20E0", Offset = "0x2DD0CE0", VA = "0x182DD20E0")]
		public bool XGBYPYNVUZB([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2DD21B0", Offset = "0x2DD0DB0", VA = "0x182DD21B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2290", Offset = "0x2DD0E90", VA = "0x182DD2290", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2DD20E0", Offset = "0x2DD0CE0", VA = "0x182DD20E0", Slot = "5")]
		private bool DPZVMLBBEJR([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, MNLRIGBOINM<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<CUMWXIQVBDQ> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<DJLWKSNXJYV> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2350", Offset = "0x2DD0F50", VA = "0x182DD2350")]
		public AbsoluteLegacyOutputId([In] Id128<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2370", Offset = "0x2DD0F70", VA = "0x182DD2370")]
		public static bool EOXNKNKFOQL([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2430", Offset = "0x2DD1030", VA = "0x182DD2430", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD25D0", Offset = "0x2DD11D0", VA = "0x182DD25D0")]
		public bool XGBYPYNVUZB([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2450", Offset = "0x2DD1050", VA = "0x182DD2450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2510", Offset = "0x2DD1110", VA = "0x182DD2510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD25D0", Offset = "0x2DD11D0", VA = "0x182DD25D0", Slot = "5")]
		private bool VDJVHUZAVXI([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2770", Offset = "0x2DD1370", VA = "0x182DD2770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public AbsoluteNodeId(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2DD25E0", Offset = "0x2DD11E0", VA = "0x182DD25E0")]
		public static bool EOXNKNKFOQL(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DD26F0", Offset = "0x2DD12F0", VA = "0x182DD26F0", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2660", Offset = "0x2DD1260", VA = "0x182DD2660", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2700", Offset = "0x2DD1300", VA = "0x182DD2700", Slot = "2")]
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
		public readonly Id32<JQPVMRMCZNG> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<IEQQYWIVYHH> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public AbsoluteOutputId(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2810", Offset = "0x2DD1410", VA = "0x182DD2810")]
		public static bool EOXNKNKFOQL(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2890", Offset = "0x2DD1490", VA = "0x182DD2890", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2DD28A0", Offset = "0x2DD14A0", VA = "0x182DD28A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2930", Offset = "0x2DD1530", VA = "0x182DD2930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD29A0", Offset = "0x2DD15A0", VA = "0x182DD29A0", Slot = "3")]
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
		Failure_StudioObjectInR1Room,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Failure_StudioObjectInInternalRoom,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Failure_StudioObjectInTestSubroom,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Failure_StudioObjectInSingleBundleRoom,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Failure_StudioObjectContainsVideoPlayer,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Failure_StudioObjectRequiresModeration_NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Failure_StudioObjectRequiresModeration_Pending,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Failure_StudioObjectRequiresModeration_Denied,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Failure_StudioObjectRequiresModeration_ModeratorPending,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Failure_StudioObjectRequiresModeration_ModeratorDenied
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct CircuitsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CircuitsRoomData RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly CircuitsSuperRoomData SuperRoomData;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2A40", Offset = "0x2DD1640", VA = "0x182DD2A40")]
		public CircuitsData([In] CircuitsRoomData roomData, CircuitsSuperRoomData superRoomData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct CircuitsRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly RootData EVRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly CircuitRootData CV2RootData;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		public CircuitsRoomData(RootData evRootData, CircuitRootData cv2RootData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CircuitsSuperRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly SuperRoomData CV2SuperRoomData;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public CircuitsSuperRoomData(SuperRoomData cv2SuperRoomData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct CircuitsTemplateData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly CircuitTemplateRootData CV2TemplateData;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public CircuitsTemplateData(CircuitTemplateRootData cv2TemplateData)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum CircuitsUICharacterValidationKind
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Digit,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Integer,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Decimal,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Alphanumeric,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Name,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Regex,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		EmailAddress,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		CustomValidator
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum CircuitsUIContentKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Autocorrected,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		IntegerNumber,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		DecimalNumber,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Alphanumeric,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Name,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		EmailAddress,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Password,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Pin,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Custom
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct CircuitsValidationConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly string LogGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly string ReportAnalyticGameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly string PreventOperationGameConfigKey;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ConfigMenuStringPurificationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate Task<bool> IsPureMethod(string? value, string context);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WFWDIIKMSFQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod ZPNELUYLBPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string KEBYUPXJULG;

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WFWDIIKMSFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2DDFE80", Offset = "0x2DDEA80", VA = "0x182DDFE80")]
			internal Task<bool> IXHFKDJBLMB(string? value)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
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

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2DDD890", Offset = "0x2DDC490", VA = "0x182DDD890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
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

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2DDF990", Offset = "0x2DDE590", VA = "0x182DDF990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2DDFE10", Offset = "0x2DDEA10", VA = "0x182DDFE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> ZPNELUYLBPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? ZSRUCDKORNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? WRKIZQDLZMS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? GQFHKWQEUVA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? PLKFHBROJTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? IWRQGFKRDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? ONYFHPVKJHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? XTXRGBTCKXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IVOKFIQUHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xBB3CE0", Offset = "0xBB28E0", VA = "0x180BB3CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xBB3D50", Offset = "0xBB2950", VA = "0x180BB3D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2EC0", Offset = "0x2DD1AC0", VA = "0x182DD2EC0")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2A80", Offset = "0x2DD1680", VA = "0x182DD2A80")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void BIVFQCCFWQF(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2C60", Offset = "0x2DD1860", VA = "0x182DD2C60")]
		public Task QOYBCGDXDSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2B60", Offset = "0x2DD1760", VA = "0x182DD2B60")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> CIGTUAEXAYG(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		CanNotInteract
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface TDRIXRAFYDC : OGQAUMAECCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface ILNVSIYYJPP : HAZNRURCQZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RGCOWURXSKK();
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface OGQAUMAECCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface YQTIKHJWKGT
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface PTONQBFNJNP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface OHUCYPOHKAG : HAZNRURCQZV
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CVJISTTKVWS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface MELVNCPVTZR
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HDMVPFSPGVT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IPCVLPTKDCR
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string SELXQMSXKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int YJSPVINULDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool YQEVACVKATP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface SCQCCQCRVAW : HAZNRURCQZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(HAZNRURCQZV ui);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(HAZNRURCQZV ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface EWORBMNSPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AAKUPUZGHHU(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DGNNTORZOXV(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LICJUDDJEXW(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NQFOYOUKPFO(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TJKRUQOPMBY(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PCPMKBRFBOM(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XYUEKSCTGQH(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface TXKDNVJCJHK
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
		public interface JQMEYYQIKVE
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool DYRMMBUXXTQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void Dismiss();

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void GPXTIBLIAAT();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface VZUJAEBJZSM
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string YCMLBIMMEHL
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			OHIRIUFGIUC AEDDHLQOPBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? MSXOHZRDNNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			ZUNCMYGRYZE? JRYNLQZQJXJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool DYRMMBUXXTQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void GTRQCPHAFVN();

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void OQZNFUQLHZE();

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void QLJVQKWGHTC(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface BIIPRZVADMH
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<TXKDNVJCJHK>? LUAQVVXQHCB
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			HAZNRURCQZV DXBOZHDHLRV(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		BIIPRZVADMH Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HAZNRURCQZV IRIPPMDLFXH(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		HAZNRURCQZV GFEPGWSNSYY(IReadOnlyList<HAZNRURCQZV> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HAZNRURCQZV UIICCYOFULE(IReadOnlyList<HAZNRURCQZV> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "4")]
		HAZNRURCQZV WHALQOPZEBQ(Func<int> a, Action<int> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "5")]
		HAZNRURCQZV JIZNSDPORUI(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "6")]
		HAZNRURCQZV HEZQFSVGEEK(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "7")]
		HAZNRURCQZV VFKNNZAKLTI(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "8")]
		HAZNRURCQZV FLQKNFLRWZK(Func<Id128<JQPVMRMCZNG>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "9")]
		HAZNRURCQZV PHVBMPIGNIA(HAZNRURCQZV a);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SCQCCQCRVAW LUTDGTSVABE(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<HAZNRURCQZV>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "11")]
		HAZNRURCQZV IBCIGUGLHND(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "12")]
		HAZNRURCQZV IVMZZVFRFNV(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "13")]
		HAZNRURCQZV FEJHLAPLEPV(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		HAZNRURCQZV GZWOJILDEWE(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		HAZNRURCQZV ZMREDARZFRY(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		HAZNRURCQZV MRQVHYDVXYJ(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		HAZNRURCQZV UKIGWJFIZVZ(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		HAZNRURCQZV XUJWKDVSMXA(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<HAZNRURCQZV>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		HAZNRURCQZV TMZOAZGLEZD(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "20")]
		HAZNRURCQZV JZNTIWEHAYA(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "21")]
		HAZNRURCQZV GGZMICCUKNI(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "22")]
		ILNVSIYYJPP GFGJPIYRZGB(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "23")]
		ILNVSIYYJPP ESNIQZSOQPE(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "24")]
		HAZNRURCQZV CTJDEWTPAKM(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "25")]
		HAZNRURCQZV RYVORFIYQLI(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "26")]
		OHUCYPOHKAG ULBBFOKZSKF(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<HAZNRURCQZV>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void LYIVSCIZRFQ(HAZNRURCQZV a);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void JKEIISSHOTI(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void DLUUZWDXDVW(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<HAZNRURCQZV>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		JQMEYYQIKVE UOANRCADPHX(string a, IReadOnlyList<HAZNRURCQZV> b, [Optional] IReadOnlyList<HAZNRURCQZV>? headerElements, [Optional] IReadOnlyList<HAZNRURCQZV>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		VZUJAEBJZSM GLWPVCBIOGZ(string a, string b, OHIRIUFGIUC c, Action<VZUJAEBJZSM> d, int e = 160, [Optional] (Func<OHIRIUFGIUC, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, ZUNCMYGRYZE InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void AEMOYVKCEIL(string a);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "33")]
		HAZNRURCQZV EAWCRXQUZCQ(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "34")]
		HAZNRURCQZV AGVRMKYDVBZ<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface HAZNRURCQZV
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OPOVDFAVRWR();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface MWJVYZXYCXM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface LRRWLGFUBVR
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GODAELZLETN();

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LHTCBOYCCTS(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PPLBSXQRKUZ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FGACHKNNQCS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface VOMTLWUOHYQ : JGXPLWKAZER, GOLLTPPMOJR
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface WCWSQTZCGLB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface ADSZSQCVFAD
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool BYGUMHZZJCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool EZUJBKBPUKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool EIOBBELDMAM(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType NAXYNQIPBOF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool RMFTZCAGDPC(Id128<EPXTWKGOJAA> nodeDefId, Id128<JQPVMRMCZNG>? legacyInnerGraphId, IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool URFMRATTKCL(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MUYIKIASOMX(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface UUQTXJCUZUW
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		YHTFDKLWCND? CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool SUNRJGVOXYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool EMOSKMMUISE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<YHTFDKLWCND> LWFZECXAPOQ();

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, GOLLTPPMOJR> CSIDKNHRING([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid> CKYAUJJRENQ(IEnumerable<ABLNPBVPOUZ> a);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData YVJCAZELXCY(IEnumerable<ABLNPBVPOUZ> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface FRAUNCBXFKS
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void QFMHUDGVTUA(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OnObjectPropertiesRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OnPlayerPropertiesRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OnEditGraphDidPush();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void OnEditGraphDidPop();
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface YHTFDKLWCND
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
			public readonly IEnumerable<ABLNPBVPOUZ> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<JQPVMRMCZNG> SpawnIntoGraphId;

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

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2DDA2F0", Offset = "0x2DD8EF0", VA = "0x182DDA2F0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<ABLNPBVPOUZ> persistenceViews, bool assignNewIds, [In] Id128<JQPVMRMCZNG> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
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

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
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

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2DDA3A0", Offset = "0x2DD8FA0", VA = "0x182DDA3A0")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<JQPVMRMCZNG> KVTXXAFCZDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers OAQDBHUPCBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> KUGAWDIPGOB
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action DWWCFZWLJRK;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> GXSYDRSPBDS;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) AZIOCHSUSMJ(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool NRDQDUJALSI(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UQCZLGJIDPM(TXCKZOIHSCK a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool SJVLRXSTFKR(CQXNAEUPHGL a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? XXRPBSEHONI(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? RAXXPCGOLVH(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<IEQQYWIVYHH>? RSRJBUCZZZR(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<AWZVWRTEXTC>? SQLSPHUODYU(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<JQPVMRMCZNG>> SEEJDDSWVEA();

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<FFORBNFDOVK>> TRBRNDATVYD();

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		string WLIVAJFVEMF(Id32<FFORBNFDOVK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		string XKNONFRWSOM(Id32<FFORBNFDOVK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CMFLWIUZKZI? UHBREDZJHNP([In] Id128<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CMFLWIUZKZI? UHBREDZJHNP(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Id32<JQPVMRMCZNG> JFZCIWKFMPS([In] Id128<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		Id32<JQPVMRMCZNG>? RSOATTACXAQ([In] Id128<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Id32<JQPVMRMCZNG>? GNUYAUTJWDV(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		VXTUWJBKUSC? JVWCAVZODPV([In] Id128<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Id32<TFITIOWUSRJ> GQJQKPCMRDZ(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Id32<LWYTCPIHOQE> WTGSQRWEQQK(Id32<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		AbsoluteNodeId? CTKVZQBQAVW(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		long RGHJTBCKNVL();

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		IEnumerable<NewStaticEdge> GIGAVCVOCRR(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		bool JKSXCUFRUCD(Id32<FFORBNFDOVK> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		IEnumerable<StableStaticEdge> LZHGMCRDCQT(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		IEnumerable<StableStaticEdge> JRBEDOFUGNI(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		IEnumerable<(Id32<JQPVMRMCZNG>, Id32<LWYTCPIHOQE>)> BAFEPZNUSBR(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		IEnumerable<VXTUWJBKUSC> DNJAJWRHXKN([In] Id128<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Id32<AWZVWRTEXTC> SQLSPHUODYU(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Id32<LWYTCPIHOQE> JSJZQKYHKNN(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Id32<LWYTCPIHOQE> GFVDUBNXXAG(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		Id32<IEQQYWIVYHH> RSRJBUCZZZR(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<YTMTLPGRGSJ> CFJHYGTMMHN(RoomVersion a, bool b, bool c, bool d, bool e);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		YTMTLPGRGSJ TGSRHZYWKGO(RoomVersion a, EAPWZEKDOJL b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		NewStaticEdge GFQUMKAJFPW(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id128<JQPVMRMCZNG> MZVOOTRPOIZ(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id128<LWYTCPIHOQE> DUQDOTAHAFH(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		StableStaticEdge BBASKYDYWJT(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, JGXPLWKAZER>> HNUIDIACQXS(Id32<JQPVMRMCZNG> parentGraphId, Id32<LWYTCPIHOQE> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, JGXPLWKAZER>> XQVXVSYWEKZ(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, List<Id32<LWYTCPIHOQE>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)>) MYOHWIRWZOD(Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task UYBJIMFJTGZ(Id128<JQPVMRMCZNG> legacyGraphId, Id128<LWYTCPIHOQE> boardNodeId, IReadOnlyList<Id128<LWYTCPIHOQE>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, JGXPLWKAZER>> HQUMQASFMQC(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, List<Id32<LWYTCPIHOQE>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, JGXPLWKAZER>> BTVINWMYVXU(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, Id32<JQPVMRMCZNG> graphId, List<Id32<LWYTCPIHOQE>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool YNNUZLDLNVD(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool LYCNNQKHWOV(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		bool KCTNIVUDGUW(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Result<PrepareTemplateForCloneResult, VOMTLWUOHYQ> ZHEGZRTXIVA([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, JGXPLWKAZER>> EGQMAKOFSYQ(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		Task<Result<Id32<LWYTCPIHOQE>, JGXPLWKAZER>> QKCAXAQRHGB(Id32<JQPVMRMCZNG> graphId, Id32<TFITIOWUSRJ> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "52")]
		Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> KGUMIMGFKKY(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		Result<ControlPanelRootData, GOLLTPPMOJR> LTDCCPBBKPI(Id128<JQPVMRMCZNG> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Task<Result<None, JGXPLWKAZER>> SSVLCPEDRUK(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> inputNodeId, Id32<CUMWXIQVBDQ> inputPortGroupId, Id32<GIQEAILWCVY> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, JGXPLWKAZER>> CBOCIPNCELL(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> outputNodeId, Id32<CUMWXIQVBDQ> outputPortGroupId, Id32<DJLWKSNXJYV> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<None, JGXPLWKAZER>> UAERFJANUNI(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<IEnumerable<Id128<LWYTCPIHOQE>>, JGXPLWKAZER>> IATHKKJRYLZ(Id128<JQPVMRMCZNG> intoGraphId, CircuitTemplateRootData a, IEnumerable<ABLNPBVPOUZ> b);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		CircuitsData YPGYTTVGURH();

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		CircuitsData INYYROPZIAI();

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		CircuitsTemplateData ALOFFAUJYNA(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id128<LWYTCPIHOQE>> nodeIds, IEnumerable<ABLNPBVPOUZ> b, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		CircuitsTemplateData ALOFFAUJYNA(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id32<LWYTCPIHOQE>> nodeIds, IEnumerable<ABLNPBVPOUZ> b, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		CircuitsTemplateData YWCYAKNWOOX(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id128<JQPVMRMCZNG>> graphIds, IEnumerable<Id128<LWYTCPIHOQE>> nodeIds, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		List<YQTIKHJWKGT> XHUBSMRQBKD();

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		(List<YQTIKHJWKGT>, bool) NWSTHOJXXDM([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, EZLAWBCIVGN b, JUZDWRULVVJ c);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		bool GGRROSIUHPJ(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		bool SBGJLGETLPL(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		Result<Id32<IEQQYWIVYHH>?, JGXPLWKAZER> NPECMLSIDAA(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<AWZVWRTEXTC> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "68")]
		Result<Id32<AWZVWRTEXTC>?, JGXPLWKAZER> WKCXKHNNFCE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<IEQQYWIVYHH> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		Task<Result<None, JGXPLWKAZER>> UCXZIGIAPGJ();

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		Task<Result<None, JGXPLWKAZER>> VADXINSBSWB(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "71")]
		Id32<LWYTCPIHOQE>? VWZANAJDXDF(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Id32<LWYTCPIHOQE>? UZAGHLZJIQQ(Id32<JQPVMRMCZNG> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "73")]
		int GWEDMGYHSZE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "74")]
		int TOEXOQHMOTF(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "75")]
		int CMBIWMTDQNG(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "76")]
		int AUUGXRTHDDI(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Task<Result<None, JGXPLWKAZER>> RNOKRQVKVIE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "78")]
		Task<Result<None, JGXPLWKAZER>> XFWVHKKTPIV(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int EZSBKBAEXQY(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "80")]
		Task<Result<None, JGXPLWKAZER>> UNAYXVHWBWG(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "81")]
		Task<Result<None, JGXPLWKAZER>> BZUICACSOOX(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "87")]
		IEnumerable<Id32<XXUTQJTARJE>> IPQLLIIVYIG();

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "88")]
		string? VGTXRGWTFBE(Id32<XXUTQJTARJE> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface UVXOEOANMEZ : EVMQDAXXTXG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		UUQTXJCUZUW WXGHAZZMPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface JGXPLWKAZER : GOLLTPPMOJR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface CMFLWIUZKZI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<JQPVMRMCZNG>? KRGIYFTCCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<JQPVMRMCZNG> LGSCAVMTATU
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<LWYTCPIHOQE>? AWCRVCOTKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? EEQPZUQQEOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface TXCKZOIHSCK : EAPWZEKDOJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<GIQEAILWCVY> SLURXSQVXPL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<AWZVWRTEXTC> HOANWQLKQKW
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool AXCFGELMPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MMYWXQPXGBZ(MWJVYZXYCXM a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BEVVSLIZEEG(EWORBMNSPDC a);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string UTSXIUGSXZB(int a);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AYBOBVAZNZS(NAEGKHVBMUW a);

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PFWUFUXGCOD(NAEGKHVBMUW a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface NAEGKHVBMUW
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface VXTUWJBKUSC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<EPXTWKGOJAA> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<TFITIOWUSRJ> NewNodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool ShowName
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		CircuitsColor CircuitsEmissionColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		string StaticName
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		NodeVisualizationKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		Id32<KWZBWBHJPPH> IconId
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool IsRoomAssetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool IsRegisteredToEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool IsObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		MemoryType VariableMemoryType
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool CanClone
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		bool CanDestroy
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool CanModifyWithMakerPen
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		int MakerPenInteractionFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool IsRoomContributorLocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		CanSaveObjectIntoInventionResultType CanSaveIntoInventions
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool CanPublishInInventions
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool IsDeprecating
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		bool SupportsCustomEditControls
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool CanPlaceInCircuitBoard
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool IsBeingEdited
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		CircuitsVec3 LocalPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		CircuitsQuat LocalRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool IsFrozen
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[MemberNotNullWhen(true, "FloatingText")]
		bool HasFloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "51")]
			[MemberNotNullWhen(true, "FloatingText")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		IPCVLPTKDCR? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<JQPVMRMCZNG> GraphId
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(Slot = "55")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		bool IsBusNode
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "56")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		Id32<JQPVMRMCZNG>? InnerGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "57")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		bool IsProxyNode
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "58")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Id32<JQPVMRMCZNG>? ProxyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool IsProxyTargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		IEnumerable<Id128<LWYTCPIHOQE>>? InnerGraphNodeIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool IsPositionAttachedToObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "62")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool IsParentPreviewGraph
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "63")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		Id128<JQPVMRMCZNG> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<LWYTCPIHOQE> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<LWYTCPIHOQE> LegacyNodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(Slot = "67")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		string PaletteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(Slot = "68")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		ReadOnlyIdArray<CUMWXIQVBDQ, JDUQSSPECCA> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<CUMWXIQVBDQ>? SelfPortGroupId
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool CanAddRemovePortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(Slot = "89")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool IncludeExecInPortConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action UACDRGUFSNS;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate VMGJLDNZUOF;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate KRRSJYLZHFM;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action VPNRBGRESEK;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action JBQCQSHKFFZ;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> DFHRIGEYONA;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<CUMWXIQVBDQ>> HUCXSOZHUFZ;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> WHQGEXYLTUZ;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<CUMWXIQVBDQ>, Id32<CUMWXIQVBDQ>> AQLVKXHKRIK;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> JHFFNZIZLAC;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<CUMWXIQVBDQ>, Id32<CUMWXIQVBDQ>> VWEKMICVOGV;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> BBRCDZYYYOK;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EUDFZTPDNVP(int a);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool OPHPAEQDUWZ([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool JCCDDYKHFVC([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void ITTRBSLVCFS(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task QBLVBZMHKAI();

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, JGXPLWKAZER>> RITKJVGWMDN(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void VBRSOHLCAVK();

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool ANCCKLNFRLR([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool HBLAGMIARHC([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void GLEUQOHEDYO(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "50")]
		OGQAUMAECCF FMWSVBGCCSC([In] TDRIXRAFYDC audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> TXYUKLOTKFU(string a);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void BEVVSLIZEEG(TXKDNVJCJHK a);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform RSLCVKZOBVN();

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool IGYPXLPSLTF(Id32<CUMWXIQVBDQ> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, JGXPLWKAZER>> EMVVQHAPLMV(Id32<CUMWXIQVBDQ> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool ZMGZZXLYJDJ(Id32<CUMWXIQVBDQ> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void IHHIAIQMHOZ();

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void MHICVCOWREL(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void TTNWXRAYJGI(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void RHAPCAUCVPC(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void TPSGUKNJNDH(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void FDOBZFDOQYO(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void HANBFYXKNIL(Id32<CUMWXIQVBDQ> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void XXPPHMOTONN(Id32<CUMWXIQVBDQ> sourceId, Id32<CUMWXIQVBDQ> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void CERFGEMYLQA(Id32<CUMWXIQVBDQ> sourceId, Id32<CUMWXIQVBDQ> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void CXMWERJNDUI(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface CQXNAEUPHGL : EAPWZEKDOJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<IEQQYWIVYHH> NZUDWCQOASR
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<DJLWKSNXJYV> JPDAWZBPOTO
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface EAPWZEKDOJL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> RMXWNDFASUO
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind OUMLOWGQAJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<JQPVMRMCZNG> LGSCAVMTATU
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<JQPVMRMCZNG> WDWIWIPILVN
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<LWYTCPIHOQE> PATYYQBRWBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<CUMWXIQVBDQ> NMRRFENDSBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<QPIYMGVHWXV> OZMFWSPYFEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		OHIRIUFGIUC VFFWURSPVNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage MELVBFDMGKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool ECIXHQXMDXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void GWSYEGFHBSE(HFSKVMSXLFT a);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BREJVJOMYRE(PMZMMSKUDKT a);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QMYRLDHACAS(LRRWLGFUBVR a);

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void DFESWAZKLLH(HFSKVMSXLFT a);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CAXPHXGZNGD(PMZMMSKUDKT a);

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void WAXSSHBECTJ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface HFSKVMSXLFT
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface JDUQSSPECCA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<CUMWXIQVBDQ> newValue, Id32<CUMWXIQVBDQ> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool FCMTSOTFUKV
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool WTXNWLBELEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool BAUAQXPLUYY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<JQPVMRMCZNG> WDWIWIPILVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool JXRTGJYGHTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<GIQEAILWCVY, TXCKZOIHSCK> NFEHNMKPGQY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<LWYTCPIHOQE> PATYYQBRWBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<DJLWKSNXJYV, CQXNAEUPHGL> RATUKFOUOMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<CUMWXIQVBDQ> NMRRFENDSBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action SKJVATXIDVQ;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action GTRUIZHRNIJ;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<GIQEAILWCVY>, Id32<GIQEAILWCVY>> MJFIFRJYTTQ;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<GIQEAILWCVY>, Id32<GIQEAILWCVY>> KBHMZCECKDR;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<DJLWKSNXJYV>, Id32<DJLWKSNXJYV>> JRJASMZNPVX;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<DJLWKSNXJYV>, Id32<DJLWKSNXJYV>> OYWNPADTAGW;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<GIQEAILWCVY>, TXCKZOIHSCK> GCZTLAPAEDR;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<GIQEAILWCVY>> MQDOAPINIPG;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<GIQEAILWCVY>, TXCKZOIHSCK> AEVJUITETLF;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<DJLWKSNXJYV>, CQXNAEUPHGL> YFRSDFGJMIO;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<DJLWKSNXJYV>> NPZMESSFRNB;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<DJLWKSNXJYV>, CQXNAEUPHGL> WPQKQTXUMNA;

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, JGXPLWKAZER>> SLRXXMRZVYX();

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, JGXPLWKAZER>> MRJADUIJXCK(Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, JGXPLWKAZER>> CQPJBPXFUXF(Id32<TIEJMITYOHO> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, JGXPLWKAZER>> MEMSRKEJQBC(Id32<VPKCJSHTFFF> inputDefId, Id32<VPKCJSHTFFF> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, JGXPLWKAZER>> BFUJWVVNOET(Id32<TIEJMITYOHO> outputDefId, Id32<TIEJMITYOHO> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, JGXPLWKAZER>> YVTCNFCYKNS();

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, JGXPLWKAZER>> OKGAIVFXYBB(string a);

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, JGXPLWKAZER>> UBHGLZINNUU(Id32<VPKCJSHTFFF> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, JGXPLWKAZER>> FMPVMSNKDFH(Id32<TIEJMITYOHO> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, JGXPLWKAZER>> IZNLHMMYPXR(Id32<VPKCJSHTFFF> inputDefId, YTMTLPGRGSJ a);

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, JGXPLWKAZER>> NREWQMRLOPG(Id32<TIEJMITYOHO> outputDefId, YTMTLPGRGSJ a);

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void YJZVYMSOSHG(int a, Id32<GIQEAILWCVY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void PVZKSVUEJWV(int a, Id32<GIQEAILWCVY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void MQCZSXCWFXN(int a, Id32<DJLWKSNXJYV> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void JFOKWSFKIVG(int a, Id32<DJLWKSNXJYV> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void CKDLAWQRPHD(int a, Id32<GIQEAILWCVY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void SMEZCRPSGWO(int a, Id32<GIQEAILWCVY> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void IFTYWSJVNAA(int a, Id32<DJLWKSNXJYV> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void MEYDUKNQYUJ(int a, Id32<DJLWKSNXJYV> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void MRVGMUMQGVL(int a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void EVWLCSBUNZU(int a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void BPNCACIPQYE(int a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void DTNCMLKWZCN(int a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void HAYWJUAXMJJ(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void TAHYWGXIPAC(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void KHOLFZBPYXA(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void LAFKSIFBCJX(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void LAJXJGWTUOC(int a);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void TKYPVUSSHEN(int a);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void XSHPUNVHIHZ(int a);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void CVMVWYYBMRU(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface YTMTLPGRGSJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey JBHNPJLELII
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string MPOTAIMFXOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<VPKCJSHTFFF>, JGXPLWKAZER>> NCCVHRRQDFR(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<TIEJMITYOHO>, JGXPLWKAZER>> KHFBDWEETNS(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface PMZMMSKUDKT
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LOIVEQKTXYD([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface OHIRIUFGIUC
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class LegacyEdgeMissingError : YQTIKHJWKGT, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<LWYTCPIHOQE> TXVBWBLHCNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<LWYTCPIHOQE> YIKTUDAXKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<LWYTCPIHOQE> HUSCMRFAIDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<LWYTCPIHOQE> OBWYEWMULLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<AWZVWRTEXTC> PITLKUDDKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<IEQQYWIVYHH> ZWOMZNWDUPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string EWXAUMWUFNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string IORNIKFXZZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2DD3350", Offset = "0x2DD1F50", VA = "0x182DD3350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3380", Offset = "0x2DD1F80", VA = "0x182DD3380")]
		public LegacyEdgeMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> srcNodeId, [In] Id128<LWYTCPIHOQE> srcLegacyNodeId, Id32<LWYTCPIHOQE> dstNodeId, [In] Id128<LWYTCPIHOQE> dstLegacyNodeId, Id32<AWZVWRTEXTC> inputPort, Id32<IEQQYWIVYHH> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3050", Offset = "0x2DD1C50", VA = "0x182DD3050", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2FE0", Offset = "0x2DD1BE0", VA = "0x182DD2FE0", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2DD31D0", Offset = "0x2DD1DD0", VA = "0x182DD31D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : YQTIKHJWKGT, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2DD3A40", Offset = "0x2DD2640", VA = "0x182DD3A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3A70", Offset = "0x2DD2670", VA = "0x182DD3A70")]
		public LegacyGraphMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3880", Offset = "0x2DD2480", VA = "0x182DD3880", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3910", Offset = "0x2DD2510", VA = "0x182DD3910", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD39D0", Offset = "0x2DD25D0", VA = "0x182DD39D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, MNLRIGBOINM<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<CUMWXIQVBDQ> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<GIQEAILWCVY> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D47340", Offset = "0x2D45F40", VA = "0x182D47340")]
		public LegacyInputId([In] Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3B90", Offset = "0x2DD2790", VA = "0x182DD3B90")]
		public static bool EOXNKNKFOQL([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3C30", Offset = "0x2DD2830", VA = "0x182DD3C30", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3E10", Offset = "0x2DD2A10", VA = "0x182DD3E10")]
		public bool XGBYPYNVUZB([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3C50", Offset = "0x2DD2850", VA = "0x182DD3C50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3D80", Offset = "0x2DD2980", VA = "0x182DD3D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3E10", Offset = "0x2DD2A10", VA = "0x182DD3E10", Slot = "5")]
		private bool LTHDXCUVPLW([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : YQTIKHJWKGT, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<AWZVWRTEXTC> YPBTCOLUBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<AWZVWRTEXTC> DIYJERYXKXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int LQCXBBCCYRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2DD41D0", Offset = "0x2DD2DD0", VA = "0x182DD41D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4200", Offset = "0x2DD2E00", VA = "0x182DD4200")]
		public LegacyInputIncorrectIdError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, Id32<AWZVWRTEXTC> expectedInputId, Id32<AWZVWRTEXTC> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3E20", Offset = "0x2DD2A20", VA = "0x182DD3E20", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3F50", Offset = "0x2DD2B50", VA = "0x182DD3F50", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2DD40E0", Offset = "0x2DD2CE0", VA = "0x182DD40E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : YQTIKHJWKGT, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int CTZRLBPNNIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int BUWNWIHRORP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2DD48C0", Offset = "0x2DD34C0", VA = "0x182DD48C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2DD48F0", Offset = "0x2DD34F0", VA = "0x182DD48F0")]
		public LegacyInputMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2DD45C0", Offset = "0x2DD31C0", VA = "0x182DD45C0", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2DD46B0", Offset = "0x2DD32B0", VA = "0x182DD46B0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x2DD47E0", Offset = "0x2DD33E0", VA = "0x182DD47E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : YQTIKHJWKGT, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2DD4ED0", Offset = "0x2DD3AD0", VA = "0x182DD4ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4F00", Offset = "0x2DD3B00", VA = "0x182DD4F00")]
		public LegacyNodeMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4D40", Offset = "0x2DD3940", VA = "0x182DD4D40", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4C30", Offset = "0x2DD3830", VA = "0x182DD4C30", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD4E10", Offset = "0x2DD3A10", VA = "0x182DD4E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, MNLRIGBOINM<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly Id128<LWYTCPIHOQE> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id32<CUMWXIQVBDQ> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<DJLWKSNXJYV> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2D47340", Offset = "0x2D45F40", VA = "0x182D47340")]
		public LegacyOutputId([In] Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5190", Offset = "0x2DD3D90", VA = "0x182DD5190")]
		public static bool EOXNKNKFOQL([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5360", Offset = "0x2DD3F60", VA = "0x182DD5360", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5180", Offset = "0x2DD3D80", VA = "0x182DD5180")]
		public bool XGBYPYNVUZB([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5230", Offset = "0x2DD3E30", VA = "0x182DD5230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5380", Offset = "0x2DD3F80", VA = "0x182DD5380", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5180", Offset = "0x2DD3D80", VA = "0x182DD5180", Slot = "5")]
		private bool BUDPUCQUORR([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : YQTIKHJWKGT, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id32<IEQQYWIVYHH> QEISNOXAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<IEQQYWIVYHH> IFMJFYTRWKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int ZHOHBSYOXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2DD57C0", Offset = "0x2DD43C0", VA = "0x182DD57C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2DD57F0", Offset = "0x2DD43F0", VA = "0x182DD57F0")]
		public LegacyOutputIncorrectIdError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, Id32<IEQQYWIVYHH> expectedOutputId, Id32<IEQQYWIVYHH> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD55A0", Offset = "0x2DD41A0", VA = "0x182DD55A0", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5410", Offset = "0x2DD4010", VA = "0x182DD5410", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD56D0", Offset = "0x2DD42D0", VA = "0x182DD56D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : YQTIKHJWKGT, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly int NZRKTMPNVVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int HHXQGEFYETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2DD5EB0", Offset = "0x2DD4AB0", VA = "0x182DD5EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5EE0", Offset = "0x2DD4AE0", VA = "0x182DD5EE0")]
		public LegacyOutputMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5BB0", Offset = "0x2DD47B0", VA = "0x182DD5BB0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5CA0", Offset = "0x2DD48A0", VA = "0x182DD5CA0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2DD5DD0", Offset = "0x2DD49D0", VA = "0x182DD5DD0", Slot = "2")]
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
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class XXUTQJTARJE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class QOGRDNIYNLH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class CRFUMRQJTMA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class FSLSIRWFGSN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class EPXTWKGOJAA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class VSIOWTDHCSD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class FFORBNFDOVK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class JQPVMRMCZNG : WCWSQTZCGLB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class TZJZKVJCHTJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class AWZVWRTEXTC : NBMEYLEBXOD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class VPKCJSHTFFF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class JKFKBVVIBGI : RBQHJQGVGKF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class LWYTCPIHOQE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class TFITIOWUSRJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class RPQAGIRUEZU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class IEQQYWIVYHH : NBMEYLEBXOD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class TIEJMITYOHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class BIMMTVVZQUL : RBQHJQGVGKF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class UDJYJVFXDCV : WCWSQTZCGLB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class NBMEYLEBXOD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class CUMWXIQVBDQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class GIQEAILWCVY : QPIYMGVHWXV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class DJLWKSNXJYV : QPIYMGVHWXV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class QPIYMGVHWXV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class RBQHJQGVGKF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class LDSXIGEBBJE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class KWZBWBHJPPH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class MSOYEZOQLIG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class XBXCGKIEZZS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : YQTIKHJWKGT, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public StaticEdge CZOTZDEWZDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x2DD65C0", Offset = "0x2DD51C0", VA = "0x182DD65C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2DD65F0", Offset = "0x2DD51F0", VA = "0x182DD65F0")]
		public NewEdgeMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2DD64A0", Offset = "0x2DD50A0", VA = "0x182DD64A0", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD63C0", Offset = "0x2DD4FC0", VA = "0x182DD63C0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6540", Offset = "0x2DD5140", VA = "0x182DD6540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : YQTIKHJWKGT, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2DD6970", Offset = "0x2DD5570", VA = "0x182DD6970", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD69A0", Offset = "0x2DD55A0", VA = "0x182DD69A0")]
		public NewGraphMissingError([In] Id128<JQPVMRMCZNG> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6830", Offset = "0x2DD5430", VA = "0x182DD6830", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6890", Offset = "0x2DD5490", VA = "0x182DD6890", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6930", Offset = "0x2DD5530", VA = "0x182DD6930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : YQTIKHJWKGT, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id32<AWZVWRTEXTC> YPBTCOLUBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<AWZVWRTEXTC> FMJUTGVOPVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly int LQCXBBCCYRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2DD6E10", Offset = "0x2DD5A10", VA = "0x182DD6E10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6E40", Offset = "0x2DD5A40", VA = "0x182DD6E40")]
		public NewInputIncorrectIdError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, Id32<AWZVWRTEXTC> expectedInputId, Id32<AWZVWRTEXTC> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6A60", Offset = "0x2DD5660", VA = "0x182DD6A60", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6B90", Offset = "0x2DD5790", VA = "0x182DD6B90", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2DD6D20", Offset = "0x2DD5920", VA = "0x182DD6D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : YQTIKHJWKGT, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly int CTZRLBPNNIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int BUWNWIHRORP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7500", Offset = "0x2DD6100", VA = "0x182DD7500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7530", Offset = "0x2DD6130", VA = "0x182DD7530")]
		public NewInputMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7330", Offset = "0x2DD5F30", VA = "0x182DD7330", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7200", Offset = "0x2DD5E00", VA = "0x182DD7200", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7420", Offset = "0x2DD6020", VA = "0x182DD7420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : YQTIKHJWKGT, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2DD7AA0", Offset = "0x2DD66A0", VA = "0x182DD7AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7AD0", Offset = "0x2DD66D0", VA = "0x182DD7AD0")]
		public NewNodeMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, [In] Id128<LWYTCPIHOQE> legacyNodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7960", Offset = "0x2DD6560", VA = "0x182DD7960", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7870", Offset = "0x2DD6470", VA = "0x182DD7870", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7A10", Offset = "0x2DD6610", VA = "0x182DD7A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : YQTIKHJWKGT, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<IEQQYWIVYHH> QEISNOXAOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id32<IEQQYWIVYHH> MDKWPXVORUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly int ZHOHBSYOXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2DD8090", Offset = "0x2DD6C90", VA = "0x182DD8090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2DD80C0", Offset = "0x2DD6CC0", VA = "0x182DD80C0")]
		public NewOutputIncorrectIdError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, Id32<IEQQYWIVYHH> expectedOutputId, Id32<IEQQYWIVYHH> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7E70", Offset = "0x2DD6A70", VA = "0x182DD7E70", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7CE0", Offset = "0x2DD68E0", VA = "0x182DD7CE0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2DD7FA0", Offset = "0x2DD6BA0", VA = "0x182DD7FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : YQTIKHJWKGT, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly int NZRKTMPNVVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly int HHXQGEFYETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2DD8780", Offset = "0x2DD7380", VA = "0x182DD8780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD87B0", Offset = "0x2DD73B0", VA = "0x182DD87B0")]
		public NewOutputMissingError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8480", Offset = "0x2DD7080", VA = "0x182DD8480", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8570", Offset = "0x2DD7170", VA = "0x182DD8570", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD86A0", Offset = "0x2DD72A0", VA = "0x182DD86A0", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly Id32<IEQQYWIVYHH> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly Id32<AWZVWRTEXTC> DstId;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public NewStaticEdge(Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8C80", Offset = "0x2DD7880", VA = "0x182DD8C80")]
		public void SGLQLYIOUSX([Out] Id32<IEQQYWIVYHH> srcId, [Out] Id32<AWZVWRTEXTC> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8AF0", Offset = "0x2DD76F0", VA = "0x182DD8AF0")]
		public static bool EOXNKNKFOQL(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8B70", Offset = "0x2DD7770", VA = "0x182DD8B70", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8B80", Offset = "0x2DD7780", VA = "0x182DD8B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8C10", Offset = "0x2DD7810", VA = "0x182DD8C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : YQTIKHJWKGT, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id128<EPXTWKGOJAA> AUWBYXUNSJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id32<TFITIOWUSRJ> ROGJAUITDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2DD9040", Offset = "0x2DD7C40", VA = "0x182DD9040", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9070", Offset = "0x2DD7C70", VA = "0x182DD9070")]
		public NodeDefMismatchError(Id32<JQPVMRMCZNG> graphId, [In] Id128<JQPVMRMCZNG> legacyGraphId, [In] Id32<LWYTCPIHOQE> nodeId, [In] Id128<LWYTCPIHOQE> legacyNodeId, [In] Id128<EPXTWKGOJAA> legacyNodeDefId, [In] Id32<TFITIOWUSRJ> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8E10", Offset = "0x2DD7A10", VA = "0x182DD8E10", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8C90", Offset = "0x2DD7890", VA = "0x182DD8C90", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD8F30", Offset = "0x2DD7B30", VA = "0x182DD8F30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : YQTIKHJWKGT, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly int BMTJFKFWBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly int IPNFXLHQBJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int KKVEFQRXQXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2DD9700", Offset = "0x2DD8300", VA = "0x182DD9700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9730", Offset = "0x2DD8330", VA = "0x182DD9730")]
		public NodeDescInputsMismatchError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD93E0", Offset = "0x2DD7FE0", VA = "0x182DD93E0", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2DD94D0", Offset = "0x2DD80D0", VA = "0x182DD94D0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9600", Offset = "0x2DD8200", VA = "0x182DD9600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : YQTIKHJWKGT, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly Id32<JQPVMRMCZNG> LGSCAVMTATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly Id128<JQPVMRMCZNG> WDWIWIPILVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<LWYTCPIHOQE> RKPACBPTHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<LWYTCPIHOQE> PATYYQBRWBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly int BMTJFKFWBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly int YGPYEOHKAIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int IHPESYJTTPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string SBDQSYTFLPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2DD9DF0", Offset = "0x2DD89F0", VA = "0x182DD9DF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9E20", Offset = "0x2DD8A20", VA = "0x182DD9E20")]
		public NodeDescOutputsMismatchError(Id32<JQPVMRMCZNG> graphId, Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> nodeId, Id128<LWYTCPIHOQE> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9AD0", Offset = "0x2DD86D0", VA = "0x182DD9AD0", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9BC0", Offset = "0x2DD87C0", VA = "0x182DD9BC0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2DD9CF0", Offset = "0x2DD88F0", VA = "0x182DD9CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		DataTable,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		None
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public readonly struct ObjectBoardProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public readonly Id128<LWYTCPIHOQE> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public ObjectBoardProps([In] Id128<LWYTCPIHOQE> objectBoardId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public delegate void OnTraverseDelegate([In] TraversalProperties traversalProperties);
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		List,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		StateTransition
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public delegate void PositionChangeDelegate([In] CircuitsVec3 newLocalPosition);
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public enum PrepareTemplateForCloneErrKind
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Versioning,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		NodesNotAllowedInTargetGraph,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		SyncedVariablesNotAllowedInTargetGraphOrDescendents
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public readonly struct PrimitivePortGroupModifiers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly YTMTLPGRGSJ Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly YTMTLPGRGSJ Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public readonly YTMTLPGRGSJ Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly YTMTLPGRGSJ Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly YTMTLPGRGSJ String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly YTMTLPGRGSJ Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly YTMTLPGRGSJ Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly YTMTLPGRGSJ Color;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA3E0", Offset = "0x2DD8FE0", VA = "0x182DDA3E0")]
		public PrimitivePortGroupModifiers(YTMTLPGRGSJ @bool, YTMTLPGRGSJ exec, YTMTLPGRGSJ @float, YTMTLPGRGSJ @int, YTMTLPGRGSJ @string, YTMTLPGRGSJ vector3, YTMTLPGRGSJ quaternion, YTMTLPGRGSJ color)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public delegate void RotationChangeDelegate([In] CircuitsQuat newLocalRotation);
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public readonly struct StableStaticEdge : IEquatable<StableStaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly Id128<LWYTCPIHOQE> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly Id32<BIMMTVVZQUL> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly Id128<LWYTCPIHOQE> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<JKFKBVVIBGI> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA990", Offset = "0x2DD9590", VA = "0x182DDA990")]
		public StableStaticEdge([In] Id128<LWYTCPIHOQE> srcNodeId, Id32<BIMMTVVZQUL> srcPortIndex, [In] Id128<LWYTCPIHOQE> dstNodeId, Id32<JKFKBVVIBGI> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA490", Offset = "0x2DD9090", VA = "0x182DDA490")]
		public static bool EOXNKNKFOQL([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA600", Offset = "0x2DD9200", VA = "0x182DDA600", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA550", Offset = "0x2DD9150", VA = "0x182DDA550", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA6C0", Offset = "0x2DD92C0", VA = "0x182DDA6C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA770", Offset = "0x2DD9370", VA = "0x182DDA770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public readonly struct StaticCircuitsConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly int InvisibleChipLimitBytes;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xF15B70", Offset = "0xF14770", VA = "0x180F15B70")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2DDA9B0", Offset = "0x2DD95B0", VA = "0x182DDA9B0")]
		public StaticCircuitsConfigData HHVZPFZEWXT()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly Id128<LWYTCPIHOQE> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly Id32<CUMWXIQVBDQ> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly Id32<DJLWKSNXJYV> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id128<LWYTCPIHOQE> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<CUMWXIQVBDQ> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id32<GIQEAILWCVY> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAFA0", Offset = "0x2DD9BA0", VA = "0x182DDAFA0")]
		public StaticEdge([In] Id128<LWYTCPIHOQE> srcNodeId, Id32<CUMWXIQVBDQ> srcPortGroupId, Id32<DJLWKSNXJYV> srcPortId, [In] Id128<LWYTCPIHOQE> dstNodeId, Id32<CUMWXIQVBDQ> dstPortGroupId, Id32<GIQEAILWCVY> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAA20", Offset = "0x2DD9620", VA = "0x182DDAA20")]
		public static bool EOXNKNKFOQL([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDABC0", Offset = "0x2DD97C0", VA = "0x182DDABC0", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAB10", Offset = "0x2DD9710", VA = "0x182DDAB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDABE0", Offset = "0x2DD97E0", VA = "0x182DDABE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDACD0", Offset = "0x2DD98D0", VA = "0x182DDACD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class NNGMTLBLMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2DD62A0", Offset = "0x2DD4EA0", VA = "0x182DD62A0")]
		public static StaticEdge GBPRBWZJNOI(this BTLBHBKTZXE a)
		{
			return default(StaticEdge);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct StudioFunctionDefinition : IEquatable<StudioFunctionDefinition>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly string PrefabName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly int StudioFunctionIndex;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xE01E80", Offset = "0xE00A80", VA = "0x180E01E80")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAFD0", Offset = "0x2DD9BD0", VA = "0x182DDAFD0", Slot = "4")]
		public bool Equals(StudioFunctionDefinition other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct StudioFunctionPortDeclaration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public readonly FUKVVMNGAGU.MMDAOZKJIDU.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE01E80", Offset = "0xE00A80", VA = "0x180E01E80")]
		public StudioFunctionPortDeclaration(string name, FUKVVMNGAGU.MMDAOZKJIDU.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB0D0", Offset = "0x2DD9CD0", VA = "0x182DDB0D0")]
		internal static StudioFunctionPortDeclaration GBPRBWZJNOI(FUKVVMNGAGU a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB190", Offset = "0x2DD9D90", VA = "0x182DDB190")]
		internal FUKVVMNGAGU HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB120", Offset = "0x2DD9D20", VA = "0x182DDB120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB020", Offset = "0x2DD9C20", VA = "0x182DDB020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2DDAFD0", Offset = "0x2DD9BD0", VA = "0x182DDAFD0")]
		public bool SGJHVRLWUTG(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB200", Offset = "0x2DD9E00", VA = "0x182DDB200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly IReadOnlyDictionary<Id128<CRFUMRQJTMA>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly IReadOnlyDictionary<Id128<CRFUMRQJTMA>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x2DDB4A0", Offset = "0x2DDA0A0", VA = "0x182DDB4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2DDCBB0", Offset = "0x2DDB7B0", VA = "0x182DDCBB0")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC930", Offset = "0x2DDB530", VA = "0x182DDC930")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<CRFUMRQJTMA>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDBF60", Offset = "0x2DDAB60", VA = "0x182DDBF60")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB980", Offset = "0x2DDA580", VA = "0x182DDB980")]
		public static StudioFunctionRegistration GBPRBWZJNOI(DSMRZJHUXCO a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2DDBDC0", Offset = "0x2DDA9C0", VA = "0x182DDBDC0")]
		public DSMRZJHUXCO HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB520", Offset = "0x2DDA120", VA = "0x182DDB520", Slot = "4")]
		public bool Equals(StudioFunctionRegistration other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public readonly struct StudioFunctionSignature : IEquatable<StudioFunctionSignature>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public readonly string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly IReadOnlyList<StudioFunctionPortDeclaration> Inputs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public readonly IReadOnlyList<StudioFunctionPortDeclaration> Outputs;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x2DDCC60", Offset = "0x2DDB860", VA = "0x182DDCC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2167760", Offset = "0x2166360", VA = "0x182167760")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2DDCD30", Offset = "0x2DDB930", VA = "0x182DDCD30")]
		public static StudioFunctionSignature GBPRBWZJNOI(CBZKHVXAJAL a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD080", Offset = "0x2DDBC80", VA = "0x182DDD080")]
		public CBZKHVXAJAL HHVZPFZEWXT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD000", Offset = "0x2DDBC00", VA = "0x182DDD000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD300", Offset = "0x2DDBF00", VA = "0x182DDD300")]
		private static int MFJUVNKCVBY(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2DDCC80", Offset = "0x2DDB880", VA = "0x182DDCC80", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD4F0", Offset = "0x2DDC0F0", VA = "0x182DDD4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public enum TemplateSerializationReason
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		CopyPaste,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Replicator
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public static class BBQULVXYSCT
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15D8AB0", Offset = "0x15D76B0", VA = "0x1815D8AB0")]
		public static bool CGSEJXLCDWZ(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x15D8AB0", Offset = "0x15D76B0", VA = "0x1815D8AB0")]
		public static bool WGVBQJJINAI(this TemplateSerializationReason a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum TraversalCause
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		GetDisplayValue,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		GetBackingValue
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public readonly struct TraversalProperties
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public readonly bool IsInitiating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public readonly TraversalCause TraversalCause;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D7B0", Offset = "0x1D5C3B0", VA = "0x181D5D7B0")]
		public TraversalProperties(bool isInitiating, TraversalCause traversalCause)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		String,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
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
