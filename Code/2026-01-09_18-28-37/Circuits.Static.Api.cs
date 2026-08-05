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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C3570", Offset = "0x28C2970", VA = "0x1828C3570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BF610", Offset = "0x28BEA10", VA = "0x1828BF610", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		public readonly Id32<LVEMYDMRMXB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<MSJVWGLYDQX> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public AbsoluteInputId(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB1C0", Offset = "0x28BA5C0", VA = "0x1828BB1C0")]
		public static bool NAQFJJXEQSO(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28BB0B0", Offset = "0x28BA4B0", VA = "0x1828BB0B0", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28BB0C0", Offset = "0x28BA4C0", VA = "0x1828BB0C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB150", Offset = "0x28BA550", VA = "0x1828BB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28BB240", Offset = "0x28BA640", VA = "0x1828BB240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, VHVQTMURGOZ<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<LVEMYDMRMXB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<YAEGQIMTQZT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<PBWXKRRVJJL> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<BFZTWCPUJVX> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28BB550", Offset = "0x28BA950", VA = "0x1828BB550")]
		public AbsoluteLegacyInputId([In] Id128<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28BB480", Offset = "0x28BA880", VA = "0x1828BB480")]
		public static bool NAQFJJXEQSO([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3A0", Offset = "0x28BA7A0", VA = "0x1828BB3A0", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28BB540", Offset = "0x28BA940", VA = "0x1828BB540")]
		public bool UEETEZFSGGI([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28BB2E0", Offset = "0x28BA6E0", VA = "0x1828BB2E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28BB3C0", Offset = "0x28BA7C0", VA = "0x1828BB3C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28BB540", Offset = "0x28BA940", VA = "0x1828BB540", Slot = "5")]
		private bool QQLECDOQLQM([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, VHVQTMURGOZ<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<LVEMYDMRMXB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<YAEGQIMTQZT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<PBWXKRRVJJL> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<AESTKKZGRLS> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28BB550", Offset = "0x28BA950", VA = "0x1828BB550")]
		public AbsoluteLegacyOutputId([In] Id128<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28BB720", Offset = "0x28BAB20", VA = "0x1828BB720")]
		public static bool NAQFJJXEQSO([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28BB580", Offset = "0x28BA980", VA = "0x1828BB580", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28BB570", Offset = "0x28BA970", VA = "0x1828BB570")]
		public bool UEETEZFSGGI([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28BB5A0", Offset = "0x28BA9A0", VA = "0x1828BB5A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28BB660", Offset = "0x28BAA60", VA = "0x1828BB660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28BB570", Offset = "0x28BA970", VA = "0x1828BB570", Slot = "5")]
		private bool EQTKUQYYMNB([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<LVEMYDMRMXB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<YAEGQIMTQZT> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28BB970", Offset = "0x28BAD70", VA = "0x1828BB970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public AbsoluteNodeId(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28BB8F0", Offset = "0x28BACF0", VA = "0x1828BB8F0")]
		public static bool NAQFJJXEQSO(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28BB870", Offset = "0x28BAC70", VA = "0x1828BB870", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28BB7E0", Offset = "0x28BABE0", VA = "0x1828BB7E0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28BB880", Offset = "0x28BAC80", VA = "0x1828BB880", Slot = "2")]
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
		public readonly Id32<LVEMYDMRMXB> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<ICQMRPVUNHC> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public AbsoluteOutputId(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28BBB20", Offset = "0x28BAF20", VA = "0x1828BBB20")]
		public static bool NAQFJJXEQSO(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA10", Offset = "0x28BAE10", VA = "0x1828BBA10", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28BBA20", Offset = "0x28BAE20", VA = "0x1828BBA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28BBAB0", Offset = "0x28BAEB0", VA = "0x1828BBAB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28BBBA0", Offset = "0x28BAFA0", VA = "0x1828BBBA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x28BBD70", Offset = "0x28BB170", VA = "0x1828BBD70")]
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
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
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
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
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
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
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
		[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CircuitTypeIdWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<UWVMSGKSREJ> TypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly IReadOnlyList<CircuitTypeIdWrapper>? TypeParameterAssignments;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x16B50C0", Offset = "0x16B44C0", VA = "0x1816B50C0")]
		private CircuitTypeIdWrapper(Id32<UWVMSGKSREJ> typeId, IReadOnlyList<CircuitTypeIdWrapper>? typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC70", Offset = "0x28BB070", VA = "0x1828BBC70")]
		public static CircuitTypeIdWrapper JLRVXHVIHZY(Id32<UWVMSGKSREJ> typeId)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28BBC40", Offset = "0x28BB040", VA = "0x1828BBC40")]
		public static CircuitTypeIdWrapper IDCRNLBLONM(Id32<UWVMSGKSREJ> typeId, IReadOnlyList<CircuitTypeIdWrapper> a)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28BBCA0", Offset = "0x28BB0A0", VA = "0x1828BBCA0", Slot = "3")]
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
		private sealed class PHNCDSIYYGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod EQVFCJTGTIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string OELTKTIMQDP;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public PHNCDSIYYGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x28C35F0", Offset = "0x28C29F0", VA = "0x1828C35F0")]
			internal Task<bool> PUIMATHDQAY(string? value)
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
			[Cpp2IlInjected.Address(RVA = "0x28C6BF0", Offset = "0x28C5FF0", VA = "0x1828C6BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB02960", VA = "0x180B03560", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C8C20", Offset = "0x28C8020", VA = "0x1828C8C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28C9090", Offset = "0x28C8490", VA = "0x1828C9090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> EQVFCJTGTIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? IKMZSYWCCLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? EEFMOLYRRUX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? DOCAIUDZKSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? RVTIBJKUXDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? JNZXKFQQTDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAAF000", Offset = "0xAAE400", VA = "0x180AAF000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? VJIQJJLIRHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AB0", Offset = "0xAA8EB0", VA = "0x180AA9AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? XZSVXHXNQGG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool RFYQFRCABNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB3E250", Offset = "0xB3D650", VA = "0x180B3E250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB3E2A0", Offset = "0xB3D6A0", VA = "0x180B3E2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28BC1D0", Offset = "0x28BB5D0", VA = "0x1828BC1D0")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28BBDB0", Offset = "0x28BB1B0", VA = "0x1828BBDB0")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void DCIZYYWKTJO(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28BBF90", Offset = "0x28BB390", VA = "0x1828BBF90")]
		public Task XORNAAWZMIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28BBE90", Offset = "0x28BB290", VA = "0x1828BBE90")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> SGAPGDVVFUV(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
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
	public interface GNWVAUEMOHN : RFGLQFFUGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface BAECENSVAPW : UQZARTWUWXI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SDJQRYKPMOF();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface RFGLQFFUGOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface TOGLIDTFJOI
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface LJQEZEDYKPY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface AWMKXQKLHED : UQZARTWUWXI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DPRPPYPNREL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface OZIBEMWHDXO
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string OZMHSBXKBSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int XNPYOVKQKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool TKUEGETCTXI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface XCUMKTIUMHX : UQZARTWUWXI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(UQZARTWUWXI ui);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(UQZARTWUWXI ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface BRFXEWUEBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DKHKMSZVIUP(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FUYMNPJZKTE(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VDFYTDJDUXJ(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JSUPQWKPDAX(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZVLEGUEAOEZ(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BMVHFQFHWUB(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EVOHJLLRXTA(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface TOJVLYFLUBJ
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
		public interface ARQBUDBPAYR
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool DSLAMUBYTAX
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
			void EVRWHLETFSK();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface HSUUSLIGQOJ
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string VALOROKKBMM
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			DKTEVXCIGNV VJRDSXZCIZB
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? YJGLKZYRSDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			QDYLFEOXBWD? BVCDNRXRGZW
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool DSLAMUBYTAX
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void JAHCNXYSDWA();

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void BIUZECLJPWB();

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void WOMQDPGLLJF(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface NACFOSCXECW
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<TOJVLYFLUBJ>? LBOLYABODXI
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			UQZARTWUWXI XZHKTBCXCWO(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		NACFOSCXECW Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UQZARTWUWXI IKVFNTZZQUG(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		UQZARTWUWXI GIRUCHGQLCN(IReadOnlyList<UQZARTWUWXI> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UQZARTWUWXI HJGMVZEEAEX(IReadOnlyList<UQZARTWUWXI> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		UQZARTWUWXI DWIPKIVMIAL(Func<int> a, Func<int, Task<bool>> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		UQZARTWUWXI ERBECISTFSX(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UQZARTWUWXI EGPQDWZSUWL(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		UQZARTWUWXI GAYVFDGYGJP(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		UQZARTWUWXI XIVZVCTWMJR(Func<Id128<LVEMYDMRMXB>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		UQZARTWUWXI RKXPVYJCZQX(UQZARTWUWXI a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		XCUMKTIUMHX TCPEBAUBXDN(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<UQZARTWUWXI>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		UQZARTWUWXI RZPPTSXKARM(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		UQZARTWUWXI JINBFKKWSTC(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		UQZARTWUWXI XRASBQHXUJE(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		UQZARTWUWXI CUMQJNACFEB(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		UQZARTWUWXI DKJHKNNQPQV(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		UQZARTWUWXI PFLQEYSIAMU(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		UQZARTWUWXI NZQDEORRSLG(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		UQZARTWUWXI VNNCLBZEFWZ(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<UQZARTWUWXI>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		UQZARTWUWXI MZKXRLSBGJI(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		UQZARTWUWXI HJNEUATNKSJ(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		UQZARTWUWXI IEQFFQOVUPD(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		BAECENSVAPW CBFSGQTOFMK(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		BAECENSVAPW OCVGRJFAODT(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		UQZARTWUWXI ZLWZTGYVWKN(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		UQZARTWUWXI DRCTSHSRAQZ(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		AWMKXQKLHED ZXVPLDLFPRC(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<UQZARTWUWXI>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void BUXHGOIYPJB(UQZARTWUWXI a);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void OCPAITYRFTB(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void RJKCWCXOTLZ(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<UQZARTWUWXI>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		ARQBUDBPAYR CYHCTNMBDJO(string a, IReadOnlyList<UQZARTWUWXI> b, [Optional] IReadOnlyList<UQZARTWUWXI>? headerElements, [Optional] IReadOnlyList<UQZARTWUWXI>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		HSUUSLIGQOJ TTBALUEYWKC(string a, string b, DKTEVXCIGNV c, Action<HSUUSLIGQOJ> d, int e = 160, [Optional] (Func<DKTEVXCIGNV, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, QDYLFEOXBWD InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void SJLVFCIBOLQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "33")]
		UQZARTWUWXI FBRRWXGDZIJ(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "34")]
		UQZARTWUWXI JEVNGIEJVMU<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "35")]
		UQZARTWUWXI EZPJNEJMABQ(Func<string> a, Action<string> b, string c = "", string d = "");

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "36")]
		UQZARTWUWXI PBNMFGXQUSC(Func<string?> imageGetter, Func<bool>? isModifiedGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface UQZARTWUWXI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YWHAZHSOARI();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface VQEQEVYYOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface XXILZHJLUVO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AWCRBYOUSLE();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FBIFWVEROKL(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ISQWDTZFHKG(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZKQTFPXOJDN(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface NIBBSNHBBHP : ZEEUKBHYSTE, AFOSPUXIYKE
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface GOLZHGUKZKS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface YHXGCLRLMUY
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool UDIPVEEQCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool SJBZNONGCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CSFVBIFXQDJ(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType UYLXAQQGAHW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WSNIJTSLWTN(Id128<XNNOENVVCYV> nodeDefId, Id128<LVEMYDMRMXB>? legacyInnerGraphId, IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AZGWEIALTQM(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KYPZBNYJZFQ(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface VNEDWOBTPPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		ZIFYNAHDVNO? ZOZTORXSSBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool PYLICWNDVLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool QWCBUKZHGNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<ZIFYNAHDVNO> ZAUWWIDESKX();

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, AFOSPUXIYKE> ZVQNNKIQJLR([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<LVEMYDMRMXB>, Guid> VFSPNBOGKBF(IEnumerable<PJGKUFHRWDW> a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData CBSKGVWWOKH(IEnumerable<PJGKUFHRWDW> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface STTQVDDNEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EWMARJQSAAR(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZUDUAZLVSNT(Id32<WHHYRTPYAMJ> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FRZBEAIOHLZ(Id32<WHHYRTPYAMJ> functionId);

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
	public interface ZIFYNAHDVNO
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
			public readonly IEnumerable<PJGKUFHRWDW> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<LVEMYDMRMXB> SpawnIntoGraphId;

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
			[Cpp2IlInjected.Address(RVA = "0x28C36D0", Offset = "0x28C2AD0", VA = "0x1828C36D0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<PJGKUFHRWDW> persistenceViews, bool assignNewIds, [In] Id128<LVEMYDMRMXB> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
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
			[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x28C3780", Offset = "0x28C2B80", VA = "0x1828C3780")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<LVEMYDMRMXB> VGWPVSVCOXO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers AIBZNEVDWLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> PMWZAEVOXBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action ZTPCSCTPOBP;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> QIJEKQYFMPF;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) BKSCDPMCDJI(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TQAUQBFLHCD(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool DGQAPRZMVZJ(KRJCTQRUQIF a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OLEJCOHXRZQ(CIYWIECEORY a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? HMNUCAKYULT(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? AYGZOZIIECM(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<ICQMRPVUNHC>? IGKVBIUYDBU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<MSJVWGLYDQX>? AOLQXGJAKFV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<LVEMYDMRMXB>> WVNTNGRMWHF();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<WHHYRTPYAMJ>> VFSZHOOAWGY();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Id32<WHHYRTPYAMJ>? QHPKLHRALWQ(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int ERMXYEHNPCV(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int UCRWQZHFCVI(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(CircuitTypeIdWrapper, string)[] RHEJLPEXXPN(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(CircuitTypeIdWrapper, string)[] LPGNYHCMPHW(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string EYOUJIVIDHC(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string HWFOIMZQNSE(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		string JFDEREXPEFH(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CFVHDLAXNSV? JETVTPTJPOG([In] Id128<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CFVHDLAXNSV? JETVTPTJPOG(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Id32<LVEMYDMRMXB> EYQJWOQUYHF([In] Id128<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Id32<LVEMYDMRMXB>? XNTYUJCHDXB([In] Id128<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Id32<LVEMYDMRMXB>? EMFKKKTZAKO(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		HDGORUDUZAT? RDQFVVTAZLY([In] Id128<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Id32<KKPQBRSEYJS> DPQVBBIFSFC(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Id32<YAEGQIMTQZT> RIJQFRAHULB(Id32<LVEMYDMRMXB> graphId, [In] Id128<YAEGQIMTQZT> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		AbsoluteNodeId? TYTRBPSAYFL(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		long QMKBPAGBWVI();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IEnumerable<NewStaticEdge> CVBNGJKVTWG(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool HQPVRJYAOIG(Id32<WHHYRTPYAMJ> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "32")]
		IEnumerable<StableStaticEdge> MIFKWCOEHTA(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "33")]
		IEnumerable<StableStaticEdge> EOVAHKYORJD(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<(Id32<LVEMYDMRMXB>, Id32<YAEGQIMTQZT>)> JVYBKNSWOEQ(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Id32<MSJVWGLYDQX> AOLQXGJAKFV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<CZOCRCUORFT> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Id32<YAEGQIMTQZT> URNLBUHIMVK(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id32<YAEGQIMTQZT> GSKFIIPIUIL(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id32<ICQMRPVUNHC> IGKVBIUYDBU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<TLQUCYRORFS> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "39")]
		IEnumerable<BMPZHICKVBE> SLEKRTJLIEO(RoomVersion a, bool b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "40")]
		BMPZHICKVBE MHTJKNTHNWP(RoomVersion a, NDOQTORKZIM b, bool c, bool d, bool e, bool f, bool g);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "41")]
		NewStaticEdge ZAQOSCDQFKJ(Id32<LVEMYDMRMXB> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Id128<LVEMYDMRMXB> HGYTJXHUHPA(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Id128<YAEGQIMTQZT> HVYRZIOMNEE(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "44")]
		StableStaticEdge YYLHMQVCEKM(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, ZEEUKBHYSTE>> HEVRSTKCVIV(Id32<LVEMYDMRMXB> parentGraphId, Id32<YAEGQIMTQZT> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<Result<None, ZEEUKBHYSTE>> PKTYHIZVERO(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, List<Id32<YAEGQIMTQZT>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "47")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)>) NKPUQCMIWCY(Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task RUKKRUGDCJU(Id128<LVEMYDMRMXB> legacyGraphId, Id128<YAEGQIMTQZT> boardNodeId, IReadOnlyList<Id128<YAEGQIMTQZT>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<PBWXKRRVJJL>, Id32<BFZTWCPUJVX>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<PBWXKRRVJJL>, Id32<AESTKKZGRLS>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<Result<None, ZEEUKBHYSTE>> NBPDEZSQSHD(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, List<Id32<YAEGQIMTQZT>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, ZEEUKBHYSTE>> CPKPILUXNKD(Id32<LVEMYDMRMXB> parentGraphId, Id128<YAEGQIMTQZT> boardNodeId, Id32<LVEMYDMRMXB> graphId, List<Id32<YAEGQIMTQZT>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool ZYYIKFBXRFU(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool RJVHNKPFYIW(Id32<LVEMYDMRMXB> graphId, Id32<MSJVWGLYDQX> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool XQRVMPSBJTB(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Result<PrepareTemplateForCloneResult, NIBBSNHBBHP> SMUFRVAUTYT([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, ZEEUKBHYSTE>> ZUYCOGPGGJR(Id32<LVEMYDMRMXB> graphId, Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<Id32<YAEGQIMTQZT>, ZEEUKBHYSTE>> QUNMXKKLLNA(Id32<LVEMYDMRMXB> graphId, Id32<KKPQBRSEYJS> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> HTSFDEXMPCX(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Result<ControlPanelRootData, AFOSPUXIYKE> UDXQSBQJZFF(Id128<LVEMYDMRMXB> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Result<None, ZEEUKBHYSTE>> FMLEOZYJSSL(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> inputNodeId, Id32<PBWXKRRVJJL> inputPortGroupId, Id32<BFZTWCPUJVX> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "60")]
		Task<Result<None, ZEEUKBHYSTE>> OFRPHRBBLRU(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> outputNodeId, Id32<PBWXKRRVJJL> outputPortGroupId, Id32<AESTKKZGRLS> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "61")]
		Task<Result<None, ZEEUKBHYSTE>> OOIKXFIYCGP(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		Task<Result<IEnumerable<Id128<YAEGQIMTQZT>>, ZEEUKBHYSTE>> FTWYWSUYLLS(Id128<LVEMYDMRMXB> intoGraphId, CircuitTemplateRootData a, IEnumerable<PJGKUFHRWDW> b);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		CircuitsData VGUWGLZJYBI();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "64")]
		CircuitsData QEBKMUWEINF();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "65")]
		CircuitsTemplateData CNSCSJGGIOT(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id128<YAEGQIMTQZT>> nodeIds, IEnumerable<PJGKUFHRWDW> b, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "66")]
		CircuitsTemplateData CNSCSJGGIOT(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id32<YAEGQIMTQZT>> nodeIds, IEnumerable<PJGKUFHRWDW> b, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "67")]
		CircuitsTemplateData ZTPJZPRLROA(TemplateSerializationReason a, Id32<LVEMYDMRMXB> sourceGraphId, IEnumerable<Id128<LVEMYDMRMXB>> graphIds, IEnumerable<Id128<YAEGQIMTQZT>> nodeIds, ISet<Id128<SMGNNBTWEUN>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "68")]
		List<TOGLIDTFJOI> UUJQWGJGRGM();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "69")]
		(List<TOGLIDTFJOI>, bool) OUGSGARKSDN([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, OSFRBXMQTKU b, RILPKECODQM c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool MPEFIBRGJBE(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool NLKTUTYNTOU(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Result<Id32<ICQMRPVUNHC>?, ZEEUKBHYSTE> SXFMQFDDSOP(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<MSJVWGLYDQX> inputId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Result<Id32<MSJVWGLYDQX>?, ZEEUKBHYSTE> ASVSFOGUKQT(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<ICQMRPVUNHC> outputId);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task<Result<None, ZEEUKBHYSTE>> XCSRQGVPECQ();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task<Result<None, ZEEUKBHYSTE>> CCIKSCFKLTU(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Id32<YAEGQIMTQZT>? IEWABAGRDZS(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Id32<YAEGQIMTQZT>? USXPIOCBOPT(Id32<LVEMYDMRMXB> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		int UJLZGDYHWXL(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int UCNPLGFGGHI(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "80")]
		int YVSQVDLIYNB(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "81")]
		int APKXNBPZVDD(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "82")]
		Task<Result<None, ZEEUKBHYSTE>> JALIZLBUMUB(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "83")]
		Task<Result<None, ZEEUKBHYSTE>> FMSJMPRUPKS(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "84")]
		int FVKKHSGYXGV(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<None, ZEEUKBHYSTE>> LCMXRXJQXYT(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "86")]
		Task<Result<None, ZEEUKBHYSTE>> ZFLHFOFJNLS(Id32<LVEMYDMRMXB> graphId, Id32<YAEGQIMTQZT> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "87")]
		bool CWENAMRFIFH();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IEnumerable<Id32<UMLOGIGCAWT>> FGZQNLUKAJZ();

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		string? GTVBHHMOYET(Id32<UMLOGIGCAWT> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface MTMJQAOABEK : CSAMAQNOZMD
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		VNEDWOBTPPV VNAMYEJVJKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface ZEEUKBHYSTE : AFOSPUXIYKE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface CFVHDLAXNSV
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<LVEMYDMRMXB>? HEAIILJUNBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<LVEMYDMRMXB> MTEMAKEQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<YAEGQIMTQZT>? GFPIFZEERHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? QBBBMRLSIZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface KRJCTQRUQIF : NDOQTORKZIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<BFZTWCPUJVX> WKRFWUAKTRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<MSJVWGLYDQX> ZCSWPETDZEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool CCMGSAPJFKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JPPBEMXMAGE(VQEQEVYYOAL a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OWGURTPVRBF(BRFXEWUEBHL a);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string TDGZXSBMAOA(int a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NUAHEKCILST(EHZDVSQUQJP a);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HCWKZFVMJWS(EHZDVSQUQJP a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface EHZDVSQUQJP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface HDGORUDUZAT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<XNNOENVVCYV> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<KKPQBRSEYJS> NewNodeTypeId
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
		Id32<QEMJZGJSIYE> IconId
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
		OZIBEMWHDXO? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<LVEMYDMRMXB> GraphId
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
		Id32<LVEMYDMRMXB>? InnerGraphId
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
		Id32<LVEMYDMRMXB>? ProxyGraphId
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
		IEnumerable<Id128<YAEGQIMTQZT>>? InnerGraphNodeIds
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
		Id128<LVEMYDMRMXB> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<YAEGQIMTQZT> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<YAEGQIMTQZT> LegacyNodeId
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
		ReadOnlyIdArray<PBWXKRRVJJL, ERLKPDQGBMX> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<PBWXKRRVJJL>? SelfPortGroupId
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
		event Action VLRVGGJQLTH;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate WHKAKRFCXDC;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate AWGQOZZKOML;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action TBHBDRMNQTB;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action OCTYZOSOQIC;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> PZKTIXYLHAT;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<PBWXKRRVJJL>> OQDWMFLPIRK;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> FJRWLQWGRKG;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<PBWXKRRVJJL>, Id32<PBWXKRRVJJL>> KBEMPTQRDHF;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<PBWXKRRVJJL>, ERLKPDQGBMX> ASWVLFKCQTJ;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<PBWXKRRVJJL>, Id32<PBWXKRRVJJL>> DVVUMBEHAKG;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> PCWDILSOCAH;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Result<None, ZEEUKBHYSTE>> DENCMYXURLI(int a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool IXCULJRQAMG([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool HKCLXLRKAZR([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void VGWWGEIKZMH(bool a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task GKRVVACTEXR();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, ZEEUKBHYSTE>> BSEYTRFVJIW(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void RALLTLDCIGN();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool RSWJJJQDMNA([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool KXEEQGYZILV([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void XOPRSMUVYVD(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "50")]
		RFGLQFFUGOM QFANFOMYJAB([In] GNWVAUEMOHN audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<PBWXKRRVJJL>, ZEEUKBHYSTE>> TDRQEUYCKJL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void OWGURTPVRBF(TOJVLYFLUBJ a);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform GOXXRRMHZRY();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool QORRDELGGAQ(Id32<PBWXKRRVJJL> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, ZEEUKBHYSTE>> NGFOEGUZUOU(Id32<PBWXKRRVJJL> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool RLLWXELZWUY(Id32<PBWXKRRVJJL> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void CWCNVEHFUJO();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void ARDAMEPPPMU(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void QYUESLJVDKZ(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void DUNWXRNJSTL(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void ZBXHRRWWUPY(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void UKAAKNAFTEL(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void VHHUHTEAXEA(Id32<PBWXKRRVJJL> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void ZCRFGFIKWDO(Id32<PBWXKRRVJJL> sourceId, Id32<PBWXKRRVJJL> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void WOGICZNVWRP(Id32<PBWXKRRVJJL> sourceId, Id32<PBWXKRRVJJL> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void JJYSVPFEUMB(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface CIYWIECEORY : NDOQTORKZIM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<ICQMRPVUNHC> GLNCFOJFKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<AESTKKZGRLS> NRRHAOLHWYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface NDOQTORKZIM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> XMTVQYOPIKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind VKDZZANKJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<LVEMYDMRMXB> MTEMAKEQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<LVEMYDMRMXB> PTYKFJGEUJM
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<YAEGQIMTQZT> ZHVOECCJAWA
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<PBWXKRRVJJL> UBMZXKOBBMF
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<AROUVFEABTU> VMCZMTXNQZT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		DKTEVXCIGNV SYDDCMSQJJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage ZZKIJDNKMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool IHWKEJRATJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WMCXCGVAAIN(UXFTBJKROLC a);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void QNIJQGMPRWH(DQWKOJSPSJI a);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void IZQRHYRTJCF(XXILZHJLUVO a);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void QLGEBOCIPQS(UXFTBJKROLC a);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OMVTPRUZHIA(DQWKOJSPSJI a);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void DKKDGPKPAQM(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface UXFTBJKROLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface ERLKPDQGBMX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<PBWXKRRVJJL> newValue, Id32<PBWXKRRVJJL> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool EXGRSMQGMXI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool DXNZPUOKLVN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool SRVMHMHMPGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<LVEMYDMRMXB> PTYKFJGEUJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool WSYGSIPNAYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<BFZTWCPUJVX, KRJCTQRUQIF> RRYSHSHPAOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<YAEGQIMTQZT> ZHVOECCJAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<AESTKKZGRLS, CIYWIECEORY> QUTTGNLZPPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<PBWXKRRVJJL> UBMZXKOBBMF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action DYIHTFCMMRT;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action ALGYREQZZWW;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<BFZTWCPUJVX>, Id32<BFZTWCPUJVX>> JHPYDBNJOFH;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<BFZTWCPUJVX>, Id32<BFZTWCPUJVX>> BYBYQCDMKRE;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<AESTKKZGRLS>, Id32<AESTKKZGRLS>> AEXIPJIREGY;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<AESTKKZGRLS>, Id32<AESTKKZGRLS>> MYCGMGHQYDT;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<BFZTWCPUJVX>, KRJCTQRUQIF> SOICQWZHMSG;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<BFZTWCPUJVX>> WMFWZRUDAOH;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<BFZTWCPUJVX>, KRJCTQRUQIF> KWDJSQUDRYS;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<AESTKKZGRLS>, CIYWIECEORY> HSTJIWEKKKN;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<AESTKKZGRLS>> SYDVRHZARVA;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<AESTKKZGRLS>, CIYWIECEORY> NLDAGKOTBAF;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, ZEEUKBHYSTE>> QIHXZDZEPHW();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, ZEEUKBHYSTE>> CHMUYXILOKN(Id32<GAODAGDLSAS> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, ZEEUKBHYSTE>> BTMQFSTLAXA(Id32<KBHHKAZFCJZ> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, ZEEUKBHYSTE>> GLHVZLTRIDN(Id32<GAODAGDLSAS> inputDefId, Id32<GAODAGDLSAS> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, ZEEUKBHYSTE>> DSPYJSVAWHI(Id32<KBHHKAZFCJZ> outputDefId, Id32<KBHHKAZFCJZ> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, ZEEUKBHYSTE>> XJNRCWEESDP();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, ZEEUKBHYSTE>> ZJPREZEKPDC(string a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, ZEEUKBHYSTE>> YWHDCTXWBSP(Id32<GAODAGDLSAS> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, ZEEUKBHYSTE>> WSALIYBQORG(Id32<KBHHKAZFCJZ> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, ZEEUKBHYSTE>> MIKWQEQIAVK(Id32<GAODAGDLSAS> inputDefId, BMPZHICKVBE a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, ZEEUKBHYSTE>> XJQZVZYBXNL(Id32<KBHHKAZFCJZ> outputDefId, BMPZHICKVBE a);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void KBLDEJWOJVF(int a, Id32<BFZTWCPUJVX> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void DAVPDFCAJWM(int a, Id32<BFZTWCPUJVX> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void SXAENWJENRI(int a, Id32<AESTKKZGRLS> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void IFMCRPEGJDN(int a, Id32<AESTKKZGRLS> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void AQHJDKDDYQI(int a, Id32<BFZTWCPUJVX> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void FIVWBAKKJKN(int a, Id32<BFZTWCPUJVX> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void EZPDMNJMFAL(int a, Id32<AESTKKZGRLS> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void JGBOGYZESUE(int a, Id32<AESTKKZGRLS> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void MQVHVMOWCTC(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void YAOFWNKQZFL(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void ZPDFNFAIAKH(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void SVNZZSCDWPS(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void RGNMRTZLCFQ(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void YAAWQBDVOPP(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void LEOFPEXVUNL(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void ZXVHPZSKFJS(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void FIIMHHRIPJF(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void YCJBCAQSMGO(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void SAJESDXTXBC(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void LNBELNEQJFV(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface BMPZHICKVBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey AMXBUJILFZT
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string WEXRBMNYLBT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<GAODAGDLSAS>, ZEEUKBHYSTE>> SDSUYHESKOK(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<KBHHKAZFCJZ>, ZEEUKBHYSTE>> UOHIMKNTNTN(Id128<LVEMYDMRMXB> graphId, Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface DQWKOJSPSJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NGMRSRSIMTU([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface DKTEVXCIGNV
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
	public sealed class LegacyEdgeMissingError : TOGLIDTFJOI, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<YAEGQIMTQZT> GERGIFCSNWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<YAEGQIMTQZT> BGEZNCMDITM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<YAEGQIMTQZT> BJDDHSRDEUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<YAEGQIMTQZT> JYNGNLPJAYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<MSJVWGLYDQX> QZOTSQKJWCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<ICQMRPVUNHC> XWNPNEUHMIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string AYDZCUPQZEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string EIZMBCJRQAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x28BC660", Offset = "0x28BBA60", VA = "0x1828BC660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28BC690", Offset = "0x28BBA90", VA = "0x1828BC690")]
		public LegacyEdgeMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> srcNodeId, [In] Id128<YAEGQIMTQZT> srcLegacyNodeId, Id32<YAEGQIMTQZT> dstNodeId, [In] Id128<YAEGQIMTQZT> dstLegacyNodeId, Id32<MSJVWGLYDQX> inputPort, Id32<ICQMRPVUNHC> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6630", Offset = "0xAA5A30", VA = "0x180AA6630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x28BC360", Offset = "0x28BB760", VA = "0x1828BC360", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x28BC2F0", Offset = "0x28BB6F0", VA = "0x1828BC2F0", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x28BC4E0", Offset = "0x28BB8E0", VA = "0x1828BC4E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : TOGLIDTFJOI, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x28BCD50", Offset = "0x28BC150", VA = "0x1828BCD50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x28BCD80", Offset = "0x28BC180", VA = "0x1828BCD80")]
		public LegacyGraphMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x28BCB90", Offset = "0x28BBF90", VA = "0x1828BCB90", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x28BCC20", Offset = "0x28BC020", VA = "0x1828BCC20", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x28BCCE0", Offset = "0x28BC0E0", VA = "0x1828BCCE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, VHVQTMURGOZ<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<YAEGQIMTQZT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<PBWXKRRVJJL> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<BFZTWCPUJVX> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2832D20", Offset = "0x2832120", VA = "0x182832D20")]
		public LegacyInputId([In] Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<BFZTWCPUJVX> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28BD080", Offset = "0x28BC480", VA = "0x1828BD080")]
		public static bool NAQFJJXEQSO([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28BCEA0", Offset = "0x28BC2A0", VA = "0x1828BCEA0", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28BD120", Offset = "0x28BC520", VA = "0x1828BD120")]
		public bool UEETEZFSGGI([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x28BCEC0", Offset = "0x28BC2C0", VA = "0x1828BCEC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x28BCFF0", Offset = "0x28BC3F0", VA = "0x1828BCFF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x28BD120", Offset = "0x28BC520", VA = "0x1828BD120", Slot = "5")]
		private bool RTCZXDCQGNN([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : TOGLIDTFJOI, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<MSJVWGLYDQX> UKMXGMQISSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<MSJVWGLYDQX> NMCNFLRZSQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int WUTFXUWERVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x28BD4E0", Offset = "0x28BC8E0", VA = "0x1828BD4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x28BD510", Offset = "0x28BC910", VA = "0x1828BD510")]
		public LegacyInputIncorrectIdError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, Id32<MSJVWGLYDQX> expectedInputId, Id32<MSJVWGLYDQX> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x28BD130", Offset = "0x28BC530", VA = "0x1828BD130", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x28BD260", Offset = "0x28BC660", VA = "0x1828BD260", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x28BD3F0", Offset = "0x28BC7F0", VA = "0x1828BD3F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : TOGLIDTFJOI, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int PNFNNCYBJLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int KURCRBVGASC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x28BDBD0", Offset = "0x28BCFD0", VA = "0x1828BDBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x28BDC00", Offset = "0x28BD000", VA = "0x1828BDC00")]
		public LegacyInputMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x28BD8D0", Offset = "0x28BCCD0", VA = "0x1828BD8D0", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x28BD9C0", Offset = "0x28BCDC0", VA = "0x1828BD9C0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x28BDAF0", Offset = "0x28BCEF0", VA = "0x1828BDAF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : TOGLIDTFJOI, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly Id32<KKPQBRSEYJS> AVZIYLASUIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28BE250", Offset = "0x28BD650", VA = "0x1828BE250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x28BE280", Offset = "0x28BD680", VA = "0x1828BE280")]
		public LegacyNodeMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, Id32<KKPQBRSEYJS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x28BE070", Offset = "0x28BD470", VA = "0x1828BE070", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x28BDF40", Offset = "0x28BD340", VA = "0x1828BDF40", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x28BE160", Offset = "0x28BD560", VA = "0x1828BE160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, VHVQTMURGOZ<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id128<YAEGQIMTQZT> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<PBWXKRRVJJL> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<AESTKKZGRLS> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2832D20", Offset = "0x2832120", VA = "0x182832D20")]
		public LegacyOutputId([In] Id128<YAEGQIMTQZT> nodeId, Id32<PBWXKRRVJJL> portGroupId, Id32<AESTKKZGRLS> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x28BE750", Offset = "0x28BDB50", VA = "0x1828BE750")]
		public static bool NAQFJJXEQSO([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x28BE6A0", Offset = "0x28BDAA0", VA = "0x1828BE6A0", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x28BE7F0", Offset = "0x28BDBF0", VA = "0x1828BE7F0")]
		public bool UEETEZFSGGI([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x28BE570", Offset = "0x28BD970", VA = "0x1828BE570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x28BE6C0", Offset = "0x28BDAC0", VA = "0x1828BE6C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x28BE7F0", Offset = "0x28BDBF0", VA = "0x1828BE7F0", Slot = "5")]
		private bool PWVAKOHHZPM([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : TOGLIDTFJOI, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<ICQMRPVUNHC> DZAVPZZDDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Id32<ICQMRPVUNHC> NRUVJSXTODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int KAJATIEMEER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x28BEBB0", Offset = "0x28BDFB0", VA = "0x1828BEBB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x28BEBE0", Offset = "0x28BDFE0", VA = "0x1828BEBE0")]
		public LegacyOutputIncorrectIdError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, Id32<ICQMRPVUNHC> expectedOutputId, Id32<ICQMRPVUNHC> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x28BE990", Offset = "0x28BDD90", VA = "0x1828BE990", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x28BE800", Offset = "0x28BDC00", VA = "0x1828BE800", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x28BEAC0", Offset = "0x28BDEC0", VA = "0x1828BEAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : TOGLIDTFJOI, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int SMVRLVXDKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly int OMHOMAMBWWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x28BF2A0", Offset = "0x28BE6A0", VA = "0x1828BF2A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x28BF2D0", Offset = "0x28BE6D0", VA = "0x1828BF2D0")]
		public LegacyOutputMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x28BEFA0", Offset = "0x28BE3A0", VA = "0x1828BEFA0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x28BF090", Offset = "0x28BE490", VA = "0x1828BF090", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x28BF1C0", Offset = "0x28BE5C0", VA = "0x1828BF1C0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class UMLOGIGCAWT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class WYAKEVJAGLQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class SMGNNBTWEUN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class QOQVNFITOIS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class XNNOENVVCYV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RLQPLEQLBMC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class WHHYRTPYAMJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class LVEMYDMRMXB : GOLZHGUKZKS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class UDQEPVCJWXY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class MSJVWGLYDQX : JZHFADIUEZE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class GAODAGDLSAS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class CZOCRCUORFT : YNOHMTDMEAC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class YAEGQIMTQZT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class KKPQBRSEYJS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class EWERHEIKSRX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class ICQMRPVUNHC : JZHFADIUEZE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class KBHHKAZFCJZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class TLQUCYRORFS : YNOHMTDMEAC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class CZNMXCKCHZS : GOLZHGUKZKS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class JZHFADIUEZE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class PBWXKRRVJJL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class BFZTWCPUJVX : AROUVFEABTU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class AESTKKZGRLS : AROUVFEABTU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class AROUVFEABTU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class YNOHMTDMEAC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class FSWRQTHOUUB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class QEMJZGJSIYE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class CSIQIUQUGDF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class UWVMSGKSREJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : TOGLIDTFJOI, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public StaticEdge DVKQJRMTLKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x28BF890", Offset = "0x28BEC90", VA = "0x1828BF890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x28BF8C0", Offset = "0x28BECC0", VA = "0x1828BF8C0")]
		public NewEdgeMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAA6680", Offset = "0xAA5A80", VA = "0x180AA6680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x28BF770", Offset = "0x28BEB70", VA = "0x1828BF770", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x28BF690", Offset = "0x28BEA90", VA = "0x1828BF690", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x28BF810", Offset = "0x28BEC10", VA = "0x1828BF810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : TOGLIDTFJOI, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x28BFC40", Offset = "0x28BF040", VA = "0x1828BFC40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x28BFC70", Offset = "0x28BF070", VA = "0x1828BFC70")]
		public NewGraphMissingError([In] Id128<LVEMYDMRMXB> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x28BFB00", Offset = "0x28BEF00", VA = "0x1828BFB00", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x28BFB60", Offset = "0x28BEF60", VA = "0x1828BFB60", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x28BFC00", Offset = "0x28BF000", VA = "0x1828BFC00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : TOGLIDTFJOI, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<MSJVWGLYDQX> UKMXGMQISSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Id32<MSJVWGLYDQX> OWVGBEYSQGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly int WUTFXUWERVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x28C00E0", Offset = "0x28BF4E0", VA = "0x1828C00E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x28C0110", Offset = "0x28BF510", VA = "0x1828C0110")]
		public NewInputIncorrectIdError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, Id32<MSJVWGLYDQX> expectedInputId, Id32<MSJVWGLYDQX> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x28BFD30", Offset = "0x28BF130", VA = "0x1828BFD30", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x28BFE60", Offset = "0x28BF260", VA = "0x1828BFE60", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x28BFFF0", Offset = "0x28BF3F0", VA = "0x1828BFFF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : TOGLIDTFJOI, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int PNFNNCYBJLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int KURCRBVGASC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x28C07D0", Offset = "0x28BFBD0", VA = "0x1828C07D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x28C0800", Offset = "0x28BFC00", VA = "0x1828C0800")]
		public NewInputMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x28C0600", Offset = "0x28BFA00", VA = "0x1828C0600", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x28C04D0", Offset = "0x28BF8D0", VA = "0x1828C04D0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x28C06F0", Offset = "0x28BFAF0", VA = "0x1828C06F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : TOGLIDTFJOI, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<KKPQBRSEYJS> AVZIYLASUIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x28C0DE0", Offset = "0x28C01E0", VA = "0x1828C0DE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x28C0E10", Offset = "0x28C0210", VA = "0x1828C0E10")]
		public NewNodeMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, [In] Id128<YAEGQIMTQZT> legacyNodeId, [In] Id32<KKPQBRSEYJS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x28C0C50", Offset = "0x28C0050", VA = "0x1828C0C50", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x28C0B40", Offset = "0x28BFF40", VA = "0x1828C0B40", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x28C0D20", Offset = "0x28C0120", VA = "0x1828C0D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : TOGLIDTFJOI, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly Id32<ICQMRPVUNHC> DZAVPZZDDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Id32<ICQMRPVUNHC> BPQZLZDERES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int KAJATIEMEER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x28C1440", Offset = "0x28C0840", VA = "0x1828C1440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x28C1470", Offset = "0x28C0870", VA = "0x1828C1470")]
		public NewOutputIncorrectIdError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, Id32<ICQMRPVUNHC> expectedOutputId, Id32<ICQMRPVUNHC> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x28C1220", Offset = "0x28C0620", VA = "0x1828C1220", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x28C1090", Offset = "0x28C0490", VA = "0x1828C1090", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x28C1350", Offset = "0x28C0750", VA = "0x1828C1350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : TOGLIDTFJOI, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly int SMVRLVXDKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly int OMHOMAMBWWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x28C1B30", Offset = "0x28C0F30", VA = "0x1828C1B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x28C1B60", Offset = "0x28C0F60", VA = "0x1828C1B60")]
		public NewOutputMissingError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x28C1830", Offset = "0x28C0C30", VA = "0x1828C1830", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x28C1920", Offset = "0x28C0D20", VA = "0x1828C1920", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x28C1A50", Offset = "0x28C0E50", VA = "0x1828C1A50", Slot = "2")]
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
		public readonly Id32<ICQMRPVUNHC> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id32<MSJVWGLYDQX> DstId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public NewStaticEdge(Id32<ICQMRPVUNHC> srcId, Id32<MSJVWGLYDQX> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x28C1EA0", Offset = "0x28C12A0", VA = "0x1828C1EA0")]
		public void CVMUYZWMJUG([Out] Id32<ICQMRPVUNHC> srcId, [Out] Id32<MSJVWGLYDQX> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x28C1FC0", Offset = "0x28C13C0", VA = "0x1828C1FC0")]
		public static bool NAQFJJXEQSO(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x28C1EB0", Offset = "0x28C12B0", VA = "0x1828C1EB0", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x28C1EC0", Offset = "0x28C12C0", VA = "0x1828C1EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x28C1F50", Offset = "0x28C1350", VA = "0x1828C1F50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : TOGLIDTFJOI, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly Id128<XNNOENVVCYV> RDQUVSDPXPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<KKPQBRSEYJS> AVZIYLASUIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x28C23F0", Offset = "0x28C17F0", VA = "0x1828C23F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x28C2420", Offset = "0x28C1820", VA = "0x1828C2420")]
		public NodeDefMismatchError(Id32<LVEMYDMRMXB> graphId, [In] Id128<LVEMYDMRMXB> legacyGraphId, [In] Id32<YAEGQIMTQZT> nodeId, [In] Id128<YAEGQIMTQZT> legacyNodeId, [In] Id128<XNNOENVVCYV> legacyNodeDefId, [In] Id32<KKPQBRSEYJS> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x28C21C0", Offset = "0x28C15C0", VA = "0x1828C21C0", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x28C2040", Offset = "0x28C1440", VA = "0x1828C2040", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x28C22E0", Offset = "0x28C16E0", VA = "0x1828C22E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : TOGLIDTFJOI, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int JVVPWZNGBGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly int EMJSLHVCXWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly int RQCVDYEUHZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x28C2AB0", Offset = "0x28C1EB0", VA = "0x1828C2AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x28C2AE0", Offset = "0x28C1EE0", VA = "0x1828C2AE0")]
		public NodeDescInputsMismatchError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x28C2790", Offset = "0x28C1B90", VA = "0x1828C2790", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x28C2880", Offset = "0x28C1C80", VA = "0x1828C2880", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x28C29B0", Offset = "0x28C1DB0", VA = "0x1828C29B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : TOGLIDTFJOI, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<LVEMYDMRMXB> MTEMAKEQUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<LVEMYDMRMXB> PTYKFJGEUJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly Id32<YAEGQIMTQZT> EUFSUYWPBXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly Id128<YAEGQIMTQZT> ZHVOECCJAWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int JVVPWZNGBGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int NTAIGDMLNZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int FAVHPNTBKIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string LSMWQBWFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string BNPDIBNJWTZ
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x28C31A0", Offset = "0x28C25A0", VA = "0x1828C31A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x28C31D0", Offset = "0x28C25D0", VA = "0x1828C31D0")]
		public NodeDescOutputsMismatchError(Id32<LVEMYDMRMXB> graphId, Id128<LVEMYDMRMXB> legacyGraphId, Id32<YAEGQIMTQZT> nodeId, Id128<YAEGQIMTQZT> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x28C2E80", Offset = "0x28C2280", VA = "0x1828C2E80", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x28C2F70", Offset = "0x28C2370", VA = "0x1828C2F70", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x28C30A0", Offset = "0x28C24A0", VA = "0x1828C30A0", Slot = "2")]
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
		public readonly Id128<YAEGQIMTQZT> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x125C4E0", Offset = "0x125B8E0", VA = "0x18125C4E0")]
		public ObjectBoardProps([In] Id128<YAEGQIMTQZT> objectBoardId)
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
		public readonly BMPZHICKVBE Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly BMPZHICKVBE Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly BMPZHICKVBE Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly BMPZHICKVBE Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly BMPZHICKVBE String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly BMPZHICKVBE Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly BMPZHICKVBE Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly BMPZHICKVBE Color;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28C37C0", Offset = "0x28C2BC0", VA = "0x1828C37C0")]
		public PrimitivePortGroupModifiers(BMPZHICKVBE @bool, BMPZHICKVBE exec, BMPZHICKVBE @float, BMPZHICKVBE @int, BMPZHICKVBE @string, BMPZHICKVBE vector3, BMPZHICKVBE quaternion, BMPZHICKVBE color)
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
		public readonly Id128<YAEGQIMTQZT> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<TLQUCYRORFS> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly Id128<YAEGQIMTQZT> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Id32<CZOCRCUORFT> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x28C3D70", Offset = "0x28C3170", VA = "0x1828C3D70")]
		public StableStaticEdge([In] Id128<YAEGQIMTQZT> srcNodeId, Id32<TLQUCYRORFS> srcPortIndex, [In] Id128<YAEGQIMTQZT> dstNodeId, Id32<CZOCRCUORFT> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x28C3A90", Offset = "0x28C2E90", VA = "0x1828C3A90")]
		public static bool NAQFJJXEQSO([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x28C3920", Offset = "0x28C2D20", VA = "0x1828C3920", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x28C3870", Offset = "0x28C2C70", VA = "0x1828C3870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x28C39E0", Offset = "0x28C2DE0", VA = "0x1828C39E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x28C3B50", Offset = "0x28C2F50", VA = "0x1828C3B50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xBDD0C0", Offset = "0xBDC4C0", VA = "0x180BDD0C0")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x28C3D90", Offset = "0x28C3190", VA = "0x1828C3D90")]
		public StaticCircuitsConfigData MFMKHXDBDDO()
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
		public readonly Id128<YAEGQIMTQZT> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id32<PBWXKRRVJJL> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<AESTKKZGRLS> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id128<YAEGQIMTQZT> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly Id32<PBWXKRRVJJL> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly Id32<BFZTWCPUJVX> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x28C4380", Offset = "0x28C3780", VA = "0x1828C4380")]
		public StaticEdge([In] Id128<YAEGQIMTQZT> srcNodeId, Id32<PBWXKRRVJJL> srcPortGroupId, Id32<AESTKKZGRLS> srcPortId, [In] Id128<YAEGQIMTQZT> dstNodeId, Id32<PBWXKRRVJJL> dstPortGroupId, Id32<BFZTWCPUJVX> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x28C3FC0", Offset = "0x28C33C0", VA = "0x1828C3FC0")]
		public static bool NAQFJJXEQSO([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x28C3EB0", Offset = "0x28C32B0", VA = "0x1828C3EB0", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x28C3E00", Offset = "0x28C3200", VA = "0x1828C3E00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28C3ED0", Offset = "0x28C32D0", VA = "0x1828C3ED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x28C40B0", Offset = "0x28C34B0", VA = "0x1828C40B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class ZLGFULZXJMQ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x28C9100", Offset = "0x28C8500", VA = "0x1828C9100")]
		public static StaticEdge EXEWSDYIDQV(this FOOTVRXPCWZ a)
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
		[Cpp2IlInjected.Address(RVA = "0xC2A570", Offset = "0xC29970", VA = "0x180C2A570")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x28C43B0", Offset = "0x28C37B0", VA = "0x1828C43B0", Slot = "4")]
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
		public readonly AJYVRVGRKCB.SEJJYADUEHN.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xC2A570", Offset = "0xC29970", VA = "0x180C2A570")]
		public StudioFunctionPortDeclaration(string name, AJYVRVGRKCB.SEJJYADUEHN.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x28C4400", Offset = "0x28C3800", VA = "0x1828C4400")]
		internal static StudioFunctionPortDeclaration EXEWSDYIDQV(AJYVRVGRKCB a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x28C4570", Offset = "0x28C3970", VA = "0x1828C4570")]
		internal AJYVRVGRKCB MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x28C4500", Offset = "0x28C3900", VA = "0x1828C4500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x28C4450", Offset = "0x28C3850", VA = "0x1828C4450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x28C43B0", Offset = "0x28C37B0", VA = "0x1828C43B0")]
		public bool URNWXOOWAUX(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x28C45E0", Offset = "0x28C39E0", VA = "0x1828C45E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly IReadOnlyDictionary<Id128<SMGNNBTWEUN>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly IReadOnlyDictionary<Id128<SMGNNBTWEUN>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x28C5BF0", Offset = "0x28C4FF0", VA = "0x1828C5BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x28C5F50", Offset = "0x28C5350", VA = "0x1828C5F50")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x28C5CF0", Offset = "0x28C50F0", VA = "0x1828C5CF0")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<SMGNNBTWEUN>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x28C52B0", Offset = "0x28C46B0", VA = "0x1828C52B0")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x28C4880", Offset = "0x28C3C80", VA = "0x1828C4880")]
		public static StudioFunctionRegistration EXEWSDYIDQV(NRJVFGULDHP a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x28C5120", Offset = "0x28C4520", VA = "0x1828C5120")]
		public NRJVFGULDHP MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x28C4CC0", Offset = "0x28C40C0", VA = "0x1828C4CC0", Slot = "4")]
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
		public bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x28C6640", Offset = "0x28C5A40", VA = "0x1828C6640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1BB53E0", Offset = "0x1BB47E0", VA = "0x181BB53E0")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x28C6000", Offset = "0x28C5400", VA = "0x1828C6000")]
		public static StudioFunctionSignature EXEWSDYIDQV(BQTHOPPUIWG a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x28C63E0", Offset = "0x28C57E0", VA = "0x1828C63E0")]
		public BQTHOPPUIWG MFMKHXDBDDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x28C6360", Offset = "0x28C5760", VA = "0x1828C6360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x28C6660", Offset = "0x28C5A60", VA = "0x1828C6660")]
		private static int SQISZGEMZRR(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x28C62B0", Offset = "0x28C56B0", VA = "0x1828C62B0", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x28C6850", Offset = "0x28C5C50", VA = "0x1828C6850", Slot = "3")]
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
	public static class BPSHVEVZUIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1277650", Offset = "0x1276A50", VA = "0x181277650")]
		public static bool YAEGIKQDQAS(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1277650", Offset = "0x1276A50", VA = "0x181277650")]
		public static bool EJBJLUKKUSN(this TemplateSerializationReason a)
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
		[Cpp2IlInjected.Address(RVA = "0x17A4B00", Offset = "0x17A3F00", VA = "0x1817A4B00")]
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
