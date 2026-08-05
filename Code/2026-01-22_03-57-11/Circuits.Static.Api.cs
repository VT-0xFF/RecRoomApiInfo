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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E5770", Offset = "0x28E3F70", VA = "0x1828E5770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x28E1810", Offset = "0x28E0010", VA = "0x1828E1810", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		public readonly Id32<VAEORNAZREW> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly Id32<WZTXETPFGMO> InputId;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public AbsoluteInputId(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28DD2A0", Offset = "0x28DBAA0", VA = "0x1828DD2A0")]
		public static bool SSVDESVOTBX(AbsoluteInputId a, AbsoluteInputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x28DD190", Offset = "0x28DB990", VA = "0x1828DD190", Slot = "4")]
		public bool Equals(AbsoluteInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28DD1A0", Offset = "0x28DB9A0", VA = "0x1828DD1A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28DD230", Offset = "0x28DBA30", VA = "0x1828DD230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28DD320", Offset = "0x28DBB20", VA = "0x1828DD320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AbsoluteLegacyInputId : IEquatable<AbsoluteLegacyInputId>, HOAFHMGXMKA<AbsoluteLegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly Id128<VAEORNAZREW> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly Id128<CATHGSEFVUK> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly Id32<JIWIEDNGUWY> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly Id32<CLOCUIODAVK> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28DD630", Offset = "0x28DBE30", VA = "0x1828DD630")]
		public AbsoluteLegacyInputId([In] Id128<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28DD570", Offset = "0x28DBD70", VA = "0x1828DD570")]
		public static bool SSVDESVOTBX([In] AbsoluteLegacyInputId lhs, [In] AbsoluteLegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28DD480", Offset = "0x28DBC80", VA = "0x1828DD480", Slot = "4")]
		public bool Equals(AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28DD560", Offset = "0x28DBD60", VA = "0x1828DD560")]
		public bool WWCFUGHNLCB([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28DD3C0", Offset = "0x28DBBC0", VA = "0x1828DD3C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28DD4A0", Offset = "0x28DBCA0", VA = "0x1828DD4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28DD560", Offset = "0x28DBD60", VA = "0x1828DD560", Slot = "5")]
		private bool LILPRLSWFQV([In] AbsoluteLegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct AbsoluteLegacyOutputId : IEquatable<AbsoluteLegacyOutputId>, HOAFHMGXMKA<AbsoluteLegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly Id128<VAEORNAZREW> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly Id128<CATHGSEFVUK> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly Id32<JIWIEDNGUWY> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly Id32<RYQAJTIFIUP> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28DD630", Offset = "0x28DBE30", VA = "0x1828DD630")]
		public AbsoluteLegacyOutputId([In] Id128<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28DD800", Offset = "0x28DC000", VA = "0x1828DD800")]
		public static bool SSVDESVOTBX([In] AbsoluteLegacyOutputId lhs, [In] AbsoluteLegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28DD650", Offset = "0x28DBE50", VA = "0x1828DD650", Slot = "4")]
		public bool Equals(AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28DD7F0", Offset = "0x28DBFF0", VA = "0x1828DD7F0")]
		public bool WWCFUGHNLCB([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28DD670", Offset = "0x28DBE70", VA = "0x1828DD670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28DD730", Offset = "0x28DBF30", VA = "0x1828DD730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28DD7F0", Offset = "0x28DBFF0", VA = "0x1828DD7F0", Slot = "5")]
		private bool IIBZYZVLTKU([In] AbsoluteLegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AbsoluteNodeId : IEquatable<AbsoluteNodeId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly Id32<VAEORNAZREW> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Id32<CATHGSEFVUK> NodeId;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28DDA50", Offset = "0x28DC250", VA = "0x1828DDA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public AbsoluteNodeId(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28DD9D0", Offset = "0x28DC1D0", VA = "0x1828DD9D0")]
		public static bool SSVDESVOTBX(AbsoluteNodeId a, AbsoluteNodeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28DD950", Offset = "0x28DC150", VA = "0x1828DD950", Slot = "4")]
		public bool Equals(AbsoluteNodeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28DD8C0", Offset = "0x28DC0C0", VA = "0x1828DD8C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28DD960", Offset = "0x28DC160", VA = "0x1828DD960", Slot = "2")]
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
		public readonly Id32<VAEORNAZREW> GraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Id32<NNBWOXGQYLV> OutputId;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public AbsoluteOutputId(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC00", Offset = "0x28DC400", VA = "0x1828DDC00")]
		public static bool SSVDESVOTBX(AbsoluteOutputId a, AbsoluteOutputId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28DDAF0", Offset = "0x28DC2F0", VA = "0x1828DDAF0", Slot = "4")]
		public bool Equals(AbsoluteOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28DDB00", Offset = "0x28DC300", VA = "0x1828DDB00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28DDB90", Offset = "0x28DC390", VA = "0x1828DDB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28DDC80", Offset = "0x28DC480", VA = "0x1828DDC80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x28DDE50", Offset = "0x28DC650", VA = "0x1828DDE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
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
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
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
		[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
		public CircuitsValidationConfig(string logGameConfigKey, string reportAnalyticGameConfigKey, string preventOperationGameConfigKey)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CircuitTypeIdWrapper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public readonly Id32<RBMJELGIMTE> TypeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly IReadOnlyList<CircuitTypeIdWrapper>? TypeParameterAssignments;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x16F0FC0", Offset = "0x16EF7C0", VA = "0x1816F0FC0")]
		private CircuitTypeIdWrapper(Id32<RBMJELGIMTE> typeId, IReadOnlyList<CircuitTypeIdWrapper>? typeParameterAssignments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28DDD20", Offset = "0x28DC520", VA = "0x1828DDD20")]
		public static CircuitTypeIdWrapper KKUOFZNAPZD(Id32<RBMJELGIMTE> typeId)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE20", Offset = "0x28DC620", VA = "0x1828DDE20")]
		public static CircuitTypeIdWrapper ZFVWKJWJOUR(Id32<RBMJELGIMTE> typeId, IReadOnlyList<CircuitTypeIdWrapper> a)
		{
			return default(CircuitTypeIdWrapper);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28DDD50", Offset = "0x28DC550", VA = "0x1828DDD50", Slot = "3")]
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
		private sealed class XQTSCXJHXWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IsPureMethod GSQNBTPATJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string CHVZLCUSNMW;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public XQTSCXJHXWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x28EB2E0", Offset = "0x28E9AE0", VA = "0x1828EB2E0")]
			internal Task<bool> MOXBJULNNJZ(string? value)
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
			[Cpp2IlInjected.Address(RVA = "0x28E8DD0", Offset = "0x28E75D0", VA = "0x1828E8DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x28EAE00", Offset = "0x28E9600", VA = "0x1828EAE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28EB270", Offset = "0x28E9A70", VA = "0x1828EB270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Func<string?, Task<bool>> GSQNBTPATJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private TaskCompletionSource<object?>? EULWTRODPPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private CancellationTokenSource? OWLKZLSVQVG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Action<ConfigMenuStringPurificationHelper>? QHZHNECBXGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Action<ConfigMenuStringPurificationHelper>? ZFURXQUKKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string? ATWPZYJNLSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB2B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string? NGWBCFZKQSG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAACAD0", Offset = "0xAAB2D0", VA = "0x180AACAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string? JNFDNNHLGQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AIZDKSZZVQE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB40C20", Offset = "0xB3F420", VA = "0x180B40C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xB40D60", Offset = "0xB3F560", VA = "0x180B40D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28DE2B0", Offset = "0x28DCAB0", VA = "0x1828DE2B0")]
		public ConfigMenuStringPurificationHelper(string context, string? initialValue, IsPureMethod isPureMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE90", Offset = "0x28DC690", VA = "0x1828DDE90")]
		[AsyncStateMachine(typeof(<RequestNewValue>d__30))]
		public void BTXYYKOMKEL(string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x28DDF70", Offset = "0x28DC770", VA = "0x1828DDF70")]
		public Task EJWLQGJBCHR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x28DE130", Offset = "0x28DC930", VA = "0x1828DE130")]
		[AsyncStateMachine(typeof(<WaitUntilAfterAllRequestsEndedAndGetFirstError>d__32))]
		public static Task<string> VODLLKOHYNO(TimeSpan a, params ConfigMenuStringPurificationHelper[] purifiers)
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
	public interface USAZVGSRDYS : RZZYLYVYVIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitializeRecorderData(string blobName, Action<string, float> OnSampleDataChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface PMZVIRTMZHZ : VTREXZDFCRH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QPTHZBHAJDK();
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface RZZYLYVYVIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnHide();

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DoneEditing();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface RNDCLZSKOMZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IYIVKDQYSHF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface SYZCVXWMDUY : VTREXZDFCRH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XTMSIWQSGRC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface XNCDZOSFRIX
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string EIXRIAHLHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int OCDSFZKFKQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		bool JIXNMRFODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface GSUPJLFMFYA : VTREXZDFCRH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(VTREXZDFCRH ui);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(VTREXZDFCRH ui);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface KGFRRRIUBTI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KWYNBJKNAVG(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HQSFDFBITZP(string a, Action b, Func<bool> c);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VGEIWWGBXGO(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZKPIIEUCUCO(string a, Func<int> b, Action<int> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XTHWECAULNK(string a, Func<object> b, Action<object> c, Func<object, string> d, Func<bool> e, Type f, IReadOnlyList<object> g);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UMITFPMDYMC(string a, Func<string> b, Action<string> c, Func<bool> d);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void TEOOCHRKZMF(string a, Func<bool> b, Action<bool> c, Func<bool> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IEYQOFDLLGC
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
		public interface WBXFUMIJEYE
		{
			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			bool JQNQCBNIHIY
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
			void DXHSOFGMEFT();
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public interface JWHQUASNMWK
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			string EMNYFIMOXJZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			FUCFUCZHAKA NTQFIEIFJFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			bool? AGGTILUJONM
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			JURBOQXQJTS? SJFMSIAJDTL
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			bool JQNQCBNIHIY
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(Slot = "7")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void MJRLCCOQGRX();

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void LLUGKNXJIUU();

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void NUKDUSLUNNQ(string a);
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface BWLTANXZTQB
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Action<IEYQOFDLLGC>? URDAILDLYDJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			VTREXZDFCRH MCXBUMLEPDX(Func<bool> a, Action<bool> b, Func<byte> c, Action<byte> d, Func<int> e, Action<int> f, Func<IReadOnlyList<string>> g, Action<IReadOnlyList<string>> h, [Optional] Func<IReadOnlyList<string>>? runtimeFilteredTagsGetter, [Optional] Action<IReadOnlyList<string>>? runtimeFilteredTagsSetter, [Optional] Func<bool>? isVisibleGetter);
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		BWLTANXZTQB Legacy
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "1")]
		VTREXZDFCRH GFNBCOUEYGH(Action a, string b = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VTREXZDFCRH ISPOVMUBFPI(IReadOnlyList<VTREXZDFCRH> a, [Optional] float? b, [Optional] int? c, [Optional] bool? d, [Optional] bool? e, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VTREXZDFCRH PYRANTAAFMY(IReadOnlyList<VTREXZDFCRH> a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VTREXZDFCRH UZZAMZXACAQ(Func<int> a, Func<int, Task<bool>> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool c = false, string d = "Color", [Optional] Func<bool>? isModifiedGetter, bool e = true, bool f = true);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "5")]
		VTREXZDFCRH OKGURCEKRBU(StandardButtonType a, Action b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "6")]
		VTREXZDFCRH ZKKPAGEACKQ(Func<long> a, Action<long> b, string c = "Choose Event", string d = "Choose Event", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<CancellationToken>? cancellationTokenGetter);

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "7")]
		VTREXZDFCRH XMCHJHSINPO(Func<Guid> a, Action<Guid> b, CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "8")]
		VTREXZDFCRH EBQSNLDDMFA(Func<Id128<VAEORNAZREW>> graphIdGetter, Func<int> a, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "9")]
		VTREXZDFCRH IITHJYUYAJU(VTREXZDFCRH a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "10")]
		GSUPJLFMFYA GQBUGYWYGJK(int a, string b, string c = "", string d = "", string e = "", [Optional] IReadOnlyList<VTREXZDFCRH>? elements, [Optional] Func<bool>? isVisibleGetter, bool f = true, [Optional] Func<bool>? isOpenGetter, [Optional] Action<bool>? isOpenSetter, [Optional] float? g);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		VTREXZDFCRH CFXENCEEKWD(string a, [Optional] Func<string?>? textGetter, [Optional] Func<bool>? isVisibleGetter);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		VTREXZDFCRH DTTJOLLZKDH(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, [Optional] Func<(string text, int charIndex, char addedChar), char>? onValidateInput, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		VTREXZDFCRH NJBPJPUXFVX(Func<float> a, Action<float> b, string c = "", string d = "", string e = "", string f = "", string g = "", bool h = false, float i = 0f, float j = 1000f, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		VTREXZDFCRH ISXXPDUDRFA(Func<int> a, Action<int> b, string c = "", [Optional] Func<string>? primaryLabelGetter, string d = "", [Optional] Func<string>? secondaryLabelGetter, string e = "", string f = "", string g = "", bool h = false, int i = 0, int j = 1000, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		VTREXZDFCRH GXIHLATPAYE(Type a, IReadOnlyList<object> b, Func<object> c, Action<object> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<object, string>? itemToString, bool i = true, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		VTREXZDFCRH OQDCNUEGVEH(Func<string> a, Action<string> b, int c = 1000, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, [Optional] string? regexValue, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string e = "", string f = "", string g = "", string h = "", bool i = false, [Optional] Func<bool>? isModifiedGetter, bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "17")]
		VTREXZDFCRH SHAUTFZFOQR(Func<float> a, Action<float> b, float c = 0f, float d = 1000f, [Optional] Func<bool>? isActiveGetter, int e = -1, string f = "", string g = "", string h = "", string i = "", string j = "", [Optional] Func<float, float>? valueFracFromSliderFrac, [Optional] Func<float, float>? sliderFracFromValueFrac, [Optional] Func<bool>? isModifiedGetter, bool k = true);

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "18")]
		VTREXZDFCRH XUYZVAIHTIY(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<VTREXZDFCRH>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true, float k = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "19")]
		VTREXZDFCRH LGDUPQBWSVN(Func<string> a, Action<string> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] int? c, bool d = false, string e = "", string f = "", string g = "", [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "20")]
		VTREXZDFCRH UWIMNROANAS(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, bool h = true);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "21")]
		VTREXZDFCRH WGEADRVRBTO(Func<bool> a, Action<bool> b, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, string c = "", string d = "", string e = "", string f = "", [Optional] int? g, [Optional] Func<bool>? isModifiedGetter, [Optional] Func<bool>? showWarningGetter, string h = "", [Optional] Func<string>? warningTitleGetter, string i = "", [Optional] Func<string>? warningTextGetter, bool j = true);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "22")]
		PMZVIRTMZHZ FCNLFOLZKNZ(Dictionary<string, EnumChoiceData> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "23")]
		PMZVIRTMZHZ JOYDNLGXXMI(Func<Dictionary<string, EnumChoiceData>> a, Func<int> b, Action<int> c, string d, string e = "", string f = "", string g = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, bool h = true, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "24")]
		VTREXZDFCRH MZTPKUYPOBQ(Func<IReadOnlyList<KeyValuePair<string, EnumChoiceData>>> sourceGetter, Func<int> a, Action<int> b, string c, string d = "", string e = "", string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? sourceDirtyGetter, [Optional] Func<int, string>? toStringOverride, [Optional] Action? onDropdownOpened, [Optional] Action? onDropdownDismissed, bool g = true, bool h = true, bool i = true, bool j = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "25")]
		VTREXZDFCRH FKUBHEJQOGQ(Func<List<object>> a, Func<object> b, Action<object> c, Func<object, string> d, string e = "", string f = "", string g = "", string h = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, bool i = true, bool j = true, bool k = false);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "26")]
		SYZCVXWMDUY CELNMBWCEGH(string a, Func<object?> selectedItemGetter, Action<object?> selectedItemSetter, Func<object?, string> itemToString, Func<IReadOnlyList<object?>> itemsGetter, bool b = true, [Optional] Func<bool>? isVisibleGetter, bool c = false, [Optional] Func<object?, string>? itemToStringDropdownLabelOverride, [Optional] IReadOnlyList<VTREXZDFCRH>? footerElements, [Optional] int? d);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void YBHDVGFJAGU(VTREXZDFCRH a);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void LMDMLXXPEGU(string a, Action? primaryButtonEvent, string b, Action? secondaryButtonEvent, string c, string d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void YDYLVTRMGMG(Func<string> a, Action<string> b, Action c, [Optional] Func<bool>? isVisibleGetter, CircuitsUIContentKind d = CircuitsUIContentKind.Alphanumeric, [Optional] Func<string, bool>? fullTextValidator, CircuitsUICharacterValidationKind e = CircuitsUICharacterValidationKind.Alphanumeric, [Optional] string? regexValue, [Optional] List<VTREXZDFCRH>? extraFields, string f = "", string g = "", string h = "", string i = "", bool j = true);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "30")]
		WBXFUMIJEYE KCVHMLYZOEP(string a, IReadOnlyList<VTREXZDFCRH> b, [Optional] IReadOnlyList<VTREXZDFCRH>? headerElements, [Optional] IReadOnlyList<VTREXZDFCRH>? footerElements);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "31")]
		JWHQUASNMWK HFMUBRGDZFB(string a, string b, FUCFUCZHAKA c, Action<JWHQUASNMWK> d, int e = 160, [Optional] (Func<FUCFUCZHAKA, bool> IsTypeSyncableGetter, bool InitialIsSynced)? isSyncedData, [Optional] (string Label, bool IsForPort, JURBOQXQJTS InitialValue)? valueData);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void ZHMOOXLDTVL(string a);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "33")]
		VTREXZDFCRH OSCJIJNKRGS(List<object> a, List<string> b, Func<int> c, Action<int> d, string e = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool f = true, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "34")]
		VTREXZDFCRH JGOSGGJKUBL<T>(List<T> a, List<string> b, Func<int> c, Action<int> d, Func<T, TypeKey> e, string f = "", [Optional] Func<bool>? isVisibleGetter, [Optional] Func<bool>? interactableGetter, [Optional] Func<bool>? isModifiedGetter, bool g = true, bool h = false) where T : notnull;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "35")]
		VTREXZDFCRH YHDMOWGFIJP(Func<string> a, Action<string> b, string c = "", string d = "");

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "36")]
		VTREXZDFCRH NXWELJULGBJ(Func<string?> imageGetter, Func<bool>? isModifiedGetter);
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface VTREXZDFCRH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CPLCVZZCURZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface VAOGVSXWKOQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Configure();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface FMAAJTLCBCR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TCVSLZKMCEN();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LRXDWHZFZSK(string a, [In] CircuitsColor color);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AHKGMUNBNCD(string a);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YSVIYBPADJG(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public interface VFHGFKHTIMO : SPRIBHSTRKT, ZVSGMZZHZEF
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		PrepareTemplateForCloneErrKind OHCPFBUROHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface TBABXGKQSFX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public interface UBBXDGOYCFP
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool BJTMRWQQTWW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		bool LUWBOZTMSXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool PRVVJWRSLOC(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		CanSaveObjectIntoInventionResultType ZKNTKDTDHFN(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YBDLQPMMFSO(Id128<YJGJBYABSIW> nodeDefId, Id128<VAEORNAZREW>? legacyInnerGraphId, IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid>? graphToToolMappings);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool YDIRYXINNXT(Guid a);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool WTMABBTMDDX(Guid a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface EWIDHKPBELO
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		LIKWTTGVGUH? QIBVUYLFYAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		bool LJXNRBSJBPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool FOIZZWNXBNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<LIKWTTGVGUH> OEPQNVATAPI();

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Result<CircuitsRoomData, ZVSGMZZHZEF> UDQCPIVCSJU([In] CircuitsRoomData circuitsTemplateData);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		IReadOnlyDictionary<Id128<VAEORNAZREW>, Guid> KNLQSNIAMNC(IEnumerable<PHWYRKJBQIP> a);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitGraphToolMappingRegistryData SFQLQZDUODE(IEnumerable<PHWYRKJBQIP> a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface PKIQFPOYTSE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnEdgeDidAdd(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnEdgeWillRemove(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CQJQMJFNFQC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnFunctionDeclsRefreshed();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OJSOOSNGBGG(Id32<IRHDXXZWZGG> functionId);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KEKWUMUEDEI(Id32<IRHDXXZWZGG> functionId);

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
	public interface LIKWTTGVGUH
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
			public readonly IEnumerable<PHWYRKJBQIP> PersistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly bool AssignNewIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly Id128<VAEORNAZREW> SpawnIntoGraphId;

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
			[Cpp2IlInjected.Address(RVA = "0x28E58A0", Offset = "0x28E40A0", VA = "0x1828E58A0")]
			public PrepareTemplateForCloneArgs(TemplateSerializationReason serializationReason, [In] CircuitsTemplateData circuitsTemplateData, IEnumerable<PHWYRKJBQIP> persistenceViews, bool assignNewIds, [In] Id128<VAEORNAZREW> spawnIntoGraphId, int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform, [In] PrepareTemplateForCloneNewInventionArgs? inventionArgs)
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
			[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x28E5950", Offset = "0x28E4150", VA = "0x1828E5950")]
			public PrepareTemplateForCloneResult(CircuitsTemplateData circuitsTemplateData, IReadOnlyDictionary<Guid, Guid> remappedGuids)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Id128<VAEORNAZREW> YILRVLPINBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		PrimitivePortGroupModifiers RWNJJRZVHRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		IReadOnlyList<string> XLNELLSVTNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action APMQMZBDQWG;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<string> HKIHPWTCSVM;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		(bool, bool) YTFHTZZCQEL(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool LXATKHGQGLU(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool UPKHGOAHATS(IGMMKFROMTK a);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool SGSWEFKOSXJ(VYRBTYZQMFH a);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		AbsoluteLegacyInputId? WOXOHVSIWIM(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AbsoluteLegacyOutputId? DSAOHOOFGYT(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Id32<NNBWOXGQYLV>? LCGIXXMKEIZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Id32<WZTXETPFGMO>? EWMMVTXPEOS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		IEnumerable<Id32<VAEORNAZREW>> EENPNQETMXE();

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		IEnumerable<Id32<IRHDXXZWZGG>> ERBRDCYHKEV();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		Id32<IRHDXXZWZGG>? GIORCPGYISX(string a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		int RKOJATGIALY(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		int XPQFFMUWCSD(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		(CircuitTypeIdWrapper, string)[] JIZVZQRVWEM(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		(CircuitTypeIdWrapper, string)[] IJYCVBGQODT(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string BMQZSKIMYCX(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		string HCPSCUHBVCN(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		string GABBCLWPTRU(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		QCLYYAWWCMI? UTPMZKXPLJJ([In] Id128<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		QCLYYAWWCMI? UTPMZKXPLJJ(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Id32<VAEORNAZREW> IKMUJHFTRSK([In] Id128<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Id32<VAEORNAZREW>? GCMIYTHZMRY([In] Id128<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Id32<VAEORNAZREW>? CYFRETOFQVT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "25")]
		VGSZPQPOABG? IAHHLQAOFWN([In] Id128<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Id32<EIHRYTCDBRP> WNCTSJTWSDT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "27")]
		Id32<CATHGSEFVUK> ZGSWDRPSMAI(Id32<VAEORNAZREW> graphId, [In] Id128<CATHGSEFVUK> legacyNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "28")]
		AbsoluteNodeId? RVJRDFFXNWG(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "29")]
		long EFTPYSZRELB();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IEnumerable<NewStaticEdge> HBNFQGNGOAN(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool DKRJSWHSQEF(Id32<IRHDXXZWZGG> functionDeclId);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "32")]
		IEnumerable<StableStaticEdge> TLNALZWTODD(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId);

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "33")]
		IEnumerable<StableStaticEdge> GLUITIQRYCA(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "34")]
		IEnumerable<(Id32<VAEORNAZREW>, Id32<CATHGSEFVUK>)> ZGZCLMNCAVT(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Id32<WZTXETPFGMO> EWMMVTXPEOS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<LGADMMDLSJA> inputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Id32<CATHGSEFVUK> SOFSYMKTMXT(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Id32<CATHGSEFVUK> GQHJPONAARW(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Id32<NNBWOXGQYLV> LCGIXXMKEIZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<ODOZBJITLFD> outputIndex);

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "39")]
		IEnumerable<YBETPIMTIQD> AAZWMEFPWWB(RoomVersion a, bool b, bool c, bool d, bool e, bool f);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "40")]
		YBETPIMTIQD AZQDCBAWZIM(RoomVersion a, XHHKBSRZIYH b, bool c, bool d, bool e, bool f, bool g);

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "41")]
		NewStaticEdge EZLOQJYAZCS(Id32<VAEORNAZREW> graphId, [In] StableStaticEdge stableEdge);

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Id128<VAEORNAZREW> UNQQHMVZGUD(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Id128<CATHGSEFVUK> VWGUHQLCMDJ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "44")]
		StableStaticEdge UAPPJLUPDHV(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "45")]
		Task<Result<None, SPRIBHSTRKT>> YMDFQDBYHDM(Id32<VAEORNAZREW> parentGraphId, Id32<CATHGSEFVUK> boardNodeId, CircuitsVec3 a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task<Result<None, SPRIBHSTRKT>> YILLUZDHDAL(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, List<Id32<CATHGSEFVUK>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "47")]
		(IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)>) IMVOGVQKUGV(Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> boardNodeId);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task SLQXANYPNAX(Id128<VAEORNAZREW> legacyGraphId, Id128<CATHGSEFVUK> boardNodeId, IReadOnlyList<Id128<CATHGSEFVUK>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<JIWIEDNGUWY>, Id32<CLOCUIODAVK>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<JIWIEDNGUWY>, Id32<RYQAJTIFIUP>)> outputMapping);

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task<Result<None, SPRIBHSTRKT>> IZIUHGIVWNO(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, List<Id32<CATHGSEFVUK>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task<Result<None, SPRIBHSTRKT>> FRQRPZXZVKM(Id32<VAEORNAZREW> parentGraphId, Id128<CATHGSEFVUK> boardNodeId, Id32<VAEORNAZREW> graphId, List<Id32<CATHGSEFVUK>> nodeIds);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "51")]
		bool DXMTWIVWTEP(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool JKDALZJVJVZ(Id32<VAEORNAZREW> graphId, Id32<WZTXETPFGMO> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "53")]
		bool SLMSYKFLDZK(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "54")]
		Result<PrepareTemplateForCloneResult, VFHGFKHTIMO> CGFNASRMVSE([In] PrepareTemplateForCloneArgs args);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "55")]
		Task<Result<None, SPRIBHSTRKT>> QNKPBBQVURY(Id32<VAEORNAZREW> graphId, Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<Result<Id32<CATHGSEFVUK>, SPRIBHSTRKT>> CODUEZKXASD(Id32<VAEORNAZREW> graphId, Id32<EIHRYTCDBRP> nodeDefId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "57")]
		Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> GAAIJMDNDJM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "58")]
		Result<ControlPanelRootData, ZVSGMZZHZEF> MQUPKGZHEHK(Id128<VAEORNAZREW> graphId, ControlPanelRootData a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "59")]
		Task<Result<None, SPRIBHSTRKT>> EAHGWVNVHJS(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> inputNodeId, Id32<JIWIEDNGUWY> inputPortGroupId, Id32<CLOCUIODAVK> inputId);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "60")]
		Task<Result<None, SPRIBHSTRKT>> RXIISSGZOFV(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> outputNodeId, Id32<JIWIEDNGUWY> outputPortGroupId, Id32<RYQAJTIFIUP> outputId);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "61")]
		Task<Result<None, SPRIBHSTRKT>> AOSPIUAXROY(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "62")]
		Task<Result<IEnumerable<Id128<CATHGSEFVUK>>, SPRIBHSTRKT>> UUTBJRWESGV(Id128<VAEORNAZREW> intoGraphId, CircuitTemplateRootData a, IEnumerable<PHWYRKJBQIP> b);

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "63")]
		CircuitsData IHFNEXNYIUH();

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "64")]
		CircuitsData OIXEHOURPCG();

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "65")]
		CircuitsTemplateData PVHIWYWDFNW(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id128<CATHGSEFVUK>> nodeIds, IEnumerable<PHWYRKJBQIP> b, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "66")]
		CircuitsTemplateData PVHIWYWDFNW(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id32<CATHGSEFVUK>> nodeIds, IEnumerable<PHWYRKJBQIP> b, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "67")]
		CircuitsTemplateData VCIUIPAHVUZ(TemplateSerializationReason a, Id32<VAEORNAZREW> sourceGraphId, IEnumerable<Id128<VAEORNAZREW>> graphIds, IEnumerable<Id128<CATHGSEFVUK>> nodeIds, ISet<Id128<MSOPKGVLNVM>>? allPrefabIds);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "68")]
		List<RNDCLZSKOMZ> RDMOUDAJBQZ();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "69")]
		(List<RNDCLZSKOMZ>, bool) FNKKIKLANNO([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, WJNNGZCVIXN b, SIDHHOOLKJP c);

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool PNOJMBDKPQB(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "71")]
		bool BYGPOEDYWXN(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "72")]
		Result<Id32<NNBWOXGQYLV>?, SPRIBHSTRKT> PJPRCZHUVJE(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<WZTXETPFGMO> inputId);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "73")]
		Result<Id32<WZTXETPFGMO>?, SPRIBHSTRKT> XQVVRJNUHZM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<NNBWOXGQYLV> outputId);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "74")]
		Task<Result<None, SPRIBHSTRKT>> UZRIXDRKFSH();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "75")]
		Task<Result<None, SPRIBHSTRKT>> FOJWRKBVVGT(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "76")]
		Id32<CATHGSEFVUK>? OZQVNJDIQHX(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "77")]
		Id32<CATHGSEFVUK>? ATYQPGQQLSS(Id32<VAEORNAZREW> graphId);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "78")]
		int SZAWIVVRYZC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "79")]
		int HYYLNOHVJOZ(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "80")]
		int BBGVYOMDFAC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "81")]
		int ZCSFUJXXPXS(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "82")]
		Task<Result<None, SPRIBHSTRKT>> UFLIYJYUKYW(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "83")]
		Task<Result<None, SPRIBHSTRKT>> MGNLYEABVHB(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "84")]
		int FVZNZXUXSDM(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<None, SPRIBHSTRKT>> TKUUTTLTXJC(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, string a);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "86")]
		Task<Result<None, SPRIBHSTRKT>> YIFHTPTQILX(Id32<VAEORNAZREW> graphId, Id32<CATHGSEFVUK> nodeId, CircuitsVec3 a, CircuitsQuat b);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "87")]
		bool VTUXWOVBNWE();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IEnumerable<Id32<FHFSLOAARZW>> RNOGUPCHAXK();

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		string? HWCHNJYYHSU(Id32<FHFSLOAARZW> behaviorId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface NJGRZRZNSSX : SQWWKBIAPXQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		EWIDHKPBELO NNJKMUFBXEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface SPRIBHSTRKT : ZVSGMZZHZEF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface QCLYYAWWCMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		Id32<VAEORNAZREW>? QFGRFZPLJPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		Id32<VAEORNAZREW> TPRAXEVDNOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		Id128<CATHGSEFVUK>? CMANLHMZSEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		ObjectBoardProps? DUQSNZRSAVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface IGMMKFROMTK : XHHKBSRZIYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		Id32<CLOCUIODAVK> BUZJJGXNWIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		Id32<WZTXETPFGMO> VBCQMIJJFAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool AKEOOTAKRGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NPSAJNYEBEV(VAOGVSXWKOQ a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YROWMZJRUFK(KGFRRRIUBTI a);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string IGCTTYQDAUN(int a);

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OJFUCYXZTSS(SHHTDAZPMGE a);

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HJNWBBBLACN(SHHTDAZPMGE a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface SHHTDAZPMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnDefaultValueChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface VGSZPQPOABG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object Object
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		Id128<YJGJBYABSIW> NodeTypeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Id32<EIHRYTCDBRP> NewNodeTypeId
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
		Id32<GEWLTDJAIBZ> IconId
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
		XNCDZOSFRIX? FloatingText
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Id32<VAEORNAZREW> GraphId
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
		Id32<VAEORNAZREW>? InnerGraphId
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
		Id32<VAEORNAZREW>? ProxyGraphId
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
		IEnumerable<Id128<CATHGSEFVUK>>? InnerGraphNodeIds
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
		Id128<VAEORNAZREW> LegacyGraphId
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "64")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		Id32<CATHGSEFVUK> NodeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "65")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		Id128<CATHGSEFVUK> LegacyNodeId
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
		ReadOnlyIdArray<JIWIEDNGUWY, EXEXARECGOC> PortGroups
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(Slot = "69")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		Id32<JIWIEDNGUWY>? SelfPortGroupId
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
		event Action VURHGBKESNI;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event PositionChangeDelegate MEFWHSQSEKL;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event RotationChangeDelegate XZXDBHCLSPC;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action HHUSJKLMABS;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action RNQODFSMOBL;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> TOVMGHOHATK;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<Id32<JIWIEDNGUWY>> RQBUAPJRGMR;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> NNJQACTYXMD;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<Id32<JIWIEDNGUWY>, Id32<JIWIEDNGUWY>> SEAPSXCLSYU;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<Id32<JIWIEDNGUWY>, EXEXARECGOC> FOKZDNIPZXC;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<Id32<JIWIEDNGUWY>, Id32<JIWIEDNGUWY>> TVKERWQGPMT;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action<bool> WVADNPCWKJK;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<Result<None, SPRIBHSTRKT>> CGXADSPFNUL(int a);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool OJIEDYOUWTJ([In] CircuitsVec3 value);

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool XZFINCLHYDU([In] CircuitsQuat value);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void CVVTICOVZGG(bool a);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task XGTDQFYBOEK();

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "32")]
		Task<Result<None, SPRIBHSTRKT>> JRFTVKFNYAJ(CircuitsVec3? a, CircuitsQuat? b);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void HILDBBOZJXQ();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void ConfigurableWillShow();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ConfigurableWillHide();

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "46")]
		bool MMYWEMDTITH([Out] Guid a);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "47")]
		bool EOYPUDEABPE([In] Guid graphId);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void Reset();

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void MCTRROWAJIA(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "50")]
		RZZYLYVYVIL BGBDUKHMIVG([In] USAZVGSRDYS audioRecorder);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void OnVisualizationAcquired(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void OnVisualizationReleased(object controlPanelChip);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "85")]
		Task<Result<Id32<JIWIEDNGUWY>, SPRIBHSTRKT>> NPFVKWIFNJK(string a);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void YROWMZJRUFK(IEYQOFDLLGC a);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "87")]
		CircuitsRigidTransform UKMPWWCEVFT();

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "88")]
		bool ZEUPXIHMVKB(Id32<JIWIEDNGUWY> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "91")]
		Task<Result<None, SPRIBHSTRKT>> OCGBGORZVLJ(Id32<JIWIEDNGUWY> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "92")]
		bool YWFDDJPXDGR(Id32<JIWIEDNGUWY> portGroupId);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "93")]
		void ZLVXOFFBUKP();

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "94")]
		void ESIIILXMMBH(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "95")]
		void EOSIUDFLOWW(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void BXKNRDDEQLQ(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "97")]
		void DXTYXUTCHPJ(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "98")]
		void UPKXQBFJJLK(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "99")]
		void RLHJKGOKDTT(Id32<JIWIEDNGUWY> nodeDescIndex);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "100")]
		void LEIQROZRTTH(Id32<JIWIEDNGUWY> sourceId, Id32<JIWIEDNGUWY> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "101")]
		void QNHYCYVBTKO(Id32<JIWIEDNGUWY> sourceId, Id32<JIWIEDNGUWY> targetId);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "102")]
		void TACYYUBULFQ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public interface VYRBTYZQMFH : XHHKBSRZIYH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Id32<NNBWOXGQYLV> KNWMBUATUGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Id32<RYQAJTIFIUP> SZKJBGPBHFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface XHHKBSRZIYH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000055")]
		IEnumerable<StaticEdge> YVPBBRQSSTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		DisplayKind GNNSZLMCXMN
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Id32<VAEORNAZREW> TPRAXEVDNOU
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		Id128<VAEORNAZREW> DDOKUOFBUAV
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		Id128<CATHGSEFVUK> OPHVPCKNUUV
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		Id32<JIWIEDNGUWY> IBZEBSUYLHI
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		Id32<YPMXJKHDXAR> XBXCHAIVHII
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		FUCFUCZHAKA BXQWLFOXMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		PortImage PMCGEUHUVNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool DSVWMQVRCNT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MDCGKSVQMSS(RRSSDQZVWAD a);

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void QNQHHXYORHC(YSBXJZBYJIV a);

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void FYMGZZUXLOE(FMAAJTLCBCR a);

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void KQOHJBUFVHZ(RRSSDQZVWAD a);

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void YBEZAVARFWZ(YSBXJZBYJIV a);

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void XAQHFXWBJPD(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public interface RRSSDQZVWAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnIsConnectedChanged();

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnInferredTypeChanged();
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface EXEXARECGOC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public delegate void PortGroupIdChangeDelegate(Id32<JIWIEDNGUWY> newValue, Id32<JIWIEDNGUWY> oldValue);

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool DIHTSCKDGPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool QMKYAVYNLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool HGHBCNAHCNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		Id128<VAEORNAZREW> DDOKUOFBUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		bool BGKSLQQLPFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		ReadOnlyIdArray<CLOCUIODAVK, IGMMKFROMTK> NRCBNCHXRGW
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string TYWDEKEDEIY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		Id128<CATHGSEFVUK> OPHVPCKNUUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		ReadOnlyIdArray<RYQAJTIFIUP, VYRBTYZQMFH> USGSXJAIKQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		Id32<JIWIEDNGUWY> IBZEBSUYLHI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action VSVFLXBJEII;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action ZJPDZEGBLEH;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<Id32<CLOCUIODAVK>, Id32<CLOCUIODAVK>> SDPKURGYUKM;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<Id32<CLOCUIODAVK>, Id32<CLOCUIODAVK>> VYYUUTHGUYF;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<Id32<RYQAJTIFIUP>, Id32<RYQAJTIFIUP>> QUICVJXEKEH;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<Id32<RYQAJTIFIUP>, Id32<RYQAJTIFIUP>> PGKVBUDKIDG;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<Id32<CLOCUIODAVK>, IGMMKFROMTK> BRRXNLNOWAV;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<Id32<CLOCUIODAVK>> TPERQAHTJPY;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<Id32<CLOCUIODAVK>, IGMMKFROMTK> RCCQVIBOPVX;

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action<Id32<RYQAJTIFIUP>, VYRBTYZQMFH> XLWSZTVALIU;

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action<Id32<RYQAJTIFIUP>> SZQWZKJDIJX;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action<Id32<RYQAJTIFIUP>, VYRBTYZQMFH> ADRKDFAZTWU;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		Task<Result<None, SPRIBHSTRKT>> XSGASHJTHKF();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task<Result<None, SPRIBHSTRKT>> KRLEGYSXHXS(Id32<ITYZVGJUOOJ> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		Task<Result<None, SPRIBHSTRKT>> HBHYJXAHWUZ(Id32<XSORAGHTHUW> outputDefId);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		Task<Result<None, SPRIBHSTRKT>> VGLEHCFHYHE(Id32<ITYZVGJUOOJ> inputDefId, Id32<ITYZVGJUOOJ> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		Task<Result<None, SPRIBHSTRKT>> UGKGCCQEWTH(Id32<XSORAGHTHUW> outputDefId, Id32<XSORAGHTHUW> targetIndex);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task<Result<None, SPRIBHSTRKT>> LIGCSFMKBQC();

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		Task<Result<None, SPRIBHSTRKT>> MCYLFPFZQRP(string a);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		Task<Result<None, SPRIBHSTRKT>> OVEEKSAEENE(Id32<ITYZVGJUOOJ> inputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		Task<Result<None, SPRIBHSTRKT>> FAVITSQPRFR(Id32<XSORAGHTHUW> outputDefId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<Result<None, SPRIBHSTRKT>> CNAUDAMCLHT(Id32<ITYZVGJUOOJ> inputDefId, YBETPIMTIQD a);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<Result<None, SPRIBHSTRKT>> QOBJYDZEJKS(Id32<XSORAGHTHUW> outputDefId, YBETPIMTIQD a);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void PFSBKRATRQC(int a, Id32<CLOCUIODAVK> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void NKVSMLCQUGL(int a, Id32<CLOCUIODAVK> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void MJYXXBMCKKR(int a, Id32<RYQAJTIFIUP> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void PKBXRAQWVEC(int a, Id32<RYQAJTIFIUP> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void VDMBYVSGUQX(int a, Id32<CLOCUIODAVK> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void MIRQCXBRTCE(int a, Id32<CLOCUIODAVK> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void GRMAJNUAFKS(int a, Id32<RYQAJTIFIUP> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "52")]
		void WVSLINPTVWP(int a, Id32<RYQAJTIFIUP> portIndex);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void JVOMCEOBWAD(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void JYQWFRZPWUI(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void LIISFEYNLBA(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void GPODHLJTOHJ(int a);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void XYWEJJDIWKB(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void FMYUKCSZVAA(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void IXCZWOUTZZS(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		void CKTREGNPKXZ(int a, int b);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void BHWRYHAORWY(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void GVVOLPZKRJF(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "63")]
		void HPRWPOIDEZT(int a);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void UZVOZTRRAUM(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface YBETPIMTIQD
	{
		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		TypeKey BDXCGXTXCPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string FLOIORYHPSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<Result<Id32<ITYZVGJUOOJ>, SPRIBHSTRKT>> NZTOPEHYLEF(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, string a);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<Result<Id32<XSORAGHTHUW>, SPRIBHSTRKT>> QVLTCCXLIRE(Id128<VAEORNAZREW> graphId, Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface YSBXJZBYJIV
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PNHHZXJVLIV([In] TraversalProperties traversalProperties);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface FUCFUCZHAKA
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
	public sealed class LegacyEdgeMissingError : RNDCLZSKOMZ, IEquatable<LegacyEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly Id32<CATHGSEFVUK> GVHXMVYFFRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly Id128<CATHGSEFVUK> IINSOPGMNTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly Id32<CATHGSEFVUK> XLQFGFHUPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly Id128<CATHGSEFVUK> JAXFXJOQYGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly Id32<WZTXETPFGMO> VIYOADZLFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly Id32<NNBWOXGQYLV> UCKPCGEHWVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly string IJMAEHEHMFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly string TDLXQUIAPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x28DE860", Offset = "0x28DD060", VA = "0x1828DE860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28DE890", Offset = "0x28DD090", VA = "0x1828DE890")]
		public LegacyEdgeMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> srcNodeId, [In] Id128<CATHGSEFVUK> srcLegacyNodeId, Id32<CATHGSEFVUK> dstNodeId, [In] Id128<CATHGSEFVUK> dstLegacyNodeId, Id32<WZTXETPFGMO> inputPort, Id32<NNBWOXGQYLV> outputPort, string legacyInputName, string legacyOutputName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB4130", Offset = "0xAB2930", VA = "0x180AB4130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x28DE560", Offset = "0x28DCD60", VA = "0x1828DE560", Slot = "5")]
		public bool Equals(LegacyEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x28DE4F0", Offset = "0x28DCCF0", VA = "0x1828DE4F0", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x28DE6E0", Offset = "0x28DCEE0", VA = "0x1828DE6E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public sealed class LegacyGraphMissingError : RNDCLZSKOMZ, IEquatable<LegacyGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x28DEF50", Offset = "0x28DD750", VA = "0x1828DEF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x28DEF80", Offset = "0x28DD780", VA = "0x1828DEF80")]
		public LegacyGraphMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x28DED90", Offset = "0x28DD590", VA = "0x1828DED90", Slot = "5")]
		public bool Equals(LegacyGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x28DEE20", Offset = "0x28DD620", VA = "0x1828DEE20", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x28DEEE0", Offset = "0x28DD6E0", VA = "0x1828DEEE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public readonly struct LegacyInputId : IEquatable<LegacyInputId>, HOAFHMGXMKA<LegacyInputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly Id128<CATHGSEFVUK> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly Id32<JIWIEDNGUWY> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly Id32<CLOCUIODAVK> PortGroupInputId;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2854C40", Offset = "0x2853440", VA = "0x182854C40")]
		public LegacyInputId([In] Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<CLOCUIODAVK> portGroupInputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28DF290", Offset = "0x28DDA90", VA = "0x1828DF290")]
		public static bool SSVDESVOTBX([In] LegacyInputId lhs, [In] LegacyInputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28DF0B0", Offset = "0x28DD8B0", VA = "0x1828DF0B0", Slot = "4")]
		public bool Equals(LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x28DF0A0", Offset = "0x28DD8A0", VA = "0x1828DF0A0")]
		public bool WWCFUGHNLCB([In] LegacyInputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x28DF0D0", Offset = "0x28DD8D0", VA = "0x1828DF0D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x28DF200", Offset = "0x28DDA00", VA = "0x1828DF200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x28DF0A0", Offset = "0x28DD8A0", VA = "0x1828DF0A0", Slot = "5")]
		private bool AODWTDROKGO([In] LegacyInputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class LegacyInputIncorrectIdError : RNDCLZSKOMZ, IEquatable<LegacyInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly Id32<WZTXETPFGMO> CDDSPIWBUZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly Id32<WZTXETPFGMO> XBFKEHWPDHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly int CWCIXVOTPPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x28DF6E0", Offset = "0x28DDEE0", VA = "0x1828DF6E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x28DF710", Offset = "0x28DDF10", VA = "0x1828DF710")]
		public LegacyInputIncorrectIdError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, Id32<WZTXETPFGMO> expectedInputId, Id32<WZTXETPFGMO> inputIdOnLegacyNode, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x28DF330", Offset = "0x28DDB30", VA = "0x1828DF330", Slot = "5")]
		public bool Equals(LegacyInputIncorrectIdError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x28DF460", Offset = "0x28DDC60", VA = "0x1828DF460", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x28DF5F0", Offset = "0x28DDDF0", VA = "0x1828DF5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public sealed class LegacyInputMissingError : RNDCLZSKOMZ, IEquatable<LegacyInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly int GRGHDKLXIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly int MCRIDAHJYDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x28DFDD0", Offset = "0x28DE5D0", VA = "0x1828DFDD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x28DFE00", Offset = "0x28DE600", VA = "0x1828DFE00")]
		public LegacyInputMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x28DFAD0", Offset = "0x28DE2D0", VA = "0x1828DFAD0", Slot = "5")]
		public bool Equals(LegacyInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x28DFBC0", Offset = "0x28DE3C0", VA = "0x1828DFBC0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x28DFCF0", Offset = "0x28DE4F0", VA = "0x1828DFCF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class LegacyNodeMissingError : RNDCLZSKOMZ, IEquatable<LegacyNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly Id32<EIHRYTCDBRP> SIFCALKUZNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x28E0450", Offset = "0x28DEC50", VA = "0x1828E0450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x28E0480", Offset = "0x28DEC80", VA = "0x1828E0480")]
		public LegacyNodeMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, Id32<EIHRYTCDBRP> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x28E0270", Offset = "0x28DEA70", VA = "0x1828E0270", Slot = "5")]
		public bool Equals(LegacyNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x28E0140", Offset = "0x28DE940", VA = "0x1828E0140", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x28E0360", Offset = "0x28DEB60", VA = "0x1828E0360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public readonly struct LegacyOutputId : IEquatable<LegacyOutputId>, HOAFHMGXMKA<LegacyOutputId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly Id128<CATHGSEFVUK> NodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly Id32<JIWIEDNGUWY> PortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly Id32<RYQAJTIFIUP> PortGroupOutputId;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2854C40", Offset = "0x2853440", VA = "0x182854C40")]
		public LegacyOutputId([In] Id128<CATHGSEFVUK> nodeId, Id32<JIWIEDNGUWY> portGroupId, Id32<RYQAJTIFIUP> portGroupOutputId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x28E0960", Offset = "0x28DF160", VA = "0x1828E0960")]
		public static bool SSVDESVOTBX([In] LegacyOutputId lhs, [In] LegacyOutputId rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x28E08B0", Offset = "0x28DF0B0", VA = "0x1828E08B0", Slot = "4")]
		public bool Equals(LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x28E0770", Offset = "0x28DEF70", VA = "0x1828E0770")]
		public bool WWCFUGHNLCB([In] LegacyOutputId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x28E0780", Offset = "0x28DEF80", VA = "0x1828E0780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x28E08D0", Offset = "0x28DF0D0", VA = "0x1828E08D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x28E0770", Offset = "0x28DEF70", VA = "0x1828E0770", Slot = "5")]
		private bool EZTZSUWOGTD([In] LegacyOutputId other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class LegacyOutputIncorrectIdError : RNDCLZSKOMZ, IEquatable<LegacyOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Id32<NNBWOXGQYLV> GEOYDWDQBTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly Id32<NNBWOXGQYLV> OMLCSODAHXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int UIGPGHJTUQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x28E0DB0", Offset = "0x28DF5B0", VA = "0x1828E0DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x28E0DE0", Offset = "0x28DF5E0", VA = "0x1828E0DE0")]
		public LegacyOutputIncorrectIdError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, Id32<NNBWOXGQYLV> expectedOutputId, Id32<NNBWOXGQYLV> outputIdOnLegacyNode, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x28E0B90", Offset = "0x28DF390", VA = "0x1828E0B90", Slot = "5")]
		public bool Equals(LegacyOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x28E0A00", Offset = "0x28DF200", VA = "0x1828E0A00", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x28E0CC0", Offset = "0x28DF4C0", VA = "0x1828E0CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class LegacyOutputMissingError : RNDCLZSKOMZ, IEquatable<LegacyOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly int VGNNXKWHKGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public readonly int HUNJIHJNWLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x28E14A0", Offset = "0x28DFCA0", VA = "0x1828E14A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x28E14D0", Offset = "0x28DFCD0", VA = "0x1828E14D0")]
		public LegacyOutputMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x28E11A0", Offset = "0x28DF9A0", VA = "0x1828E11A0", Slot = "5")]
		public bool Equals(LegacyOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x28E1290", Offset = "0x28DFA90", VA = "0x1828E1290", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x28E13C0", Offset = "0x28DFBC0", VA = "0x1828E13C0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
		public MakerAIDescriptionAttribute(string description)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class MakerAIIgnoreAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public MakerAIIgnoreAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class FHFSLOAARZW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class RIADTVFJVZN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class MSOPKGVLNVM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class HPFJPYBDYZZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class YJGJBYABSIW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class RZYXMTNPVSV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class IRHDXXZWZGG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class VAEORNAZREW : TBABXGKQSFX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class VABXWOJEKAJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class WZTXETPFGMO : QDNCJORUPZH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class ITYZVGJUOOJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class LGADMMDLSJA : MRWTAUKRVCT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class CATHGSEFVUK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class EIHRYTCDBRP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class JQPVEKPUQSM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class NNBWOXGQYLV : QDNCJORUPZH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class XSORAGHTHUW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class ODOZBJITLFD : MRWTAUKRVCT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class QTIYGTDLLQX : TBABXGKQSFX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class QDNCJORUPZH
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[Todo("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
	public sealed class JIWIEDNGUWY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class CLOCUIODAVK : YPMXJKHDXAR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class RYQAJTIFIUP : YPMXJKHDXAR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class YPMXJKHDXAR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class MRWTAUKRVCT
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class ZKTPNDFBKTW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public sealed class GEWLTDJAIBZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class LDGGQTDBFUU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class RBMJELGIMTE
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NewEdgeMissingError : RNDCLZSKOMZ, IEquatable<NewEdgeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public StaticEdge TDAHVALZFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x28E1A90", Offset = "0x28E0290", VA = "0x1828E1A90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x28E1AC0", Offset = "0x28E02C0", VA = "0x1828E1AC0")]
		public NewEdgeMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, [In] StaticEdge legacyEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x28E1970", Offset = "0x28E0170", VA = "0x1828E1970", Slot = "5")]
		public bool Equals(NewEdgeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x28E1890", Offset = "0x28E0090", VA = "0x1828E1890", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x28E1A10", Offset = "0x28E0210", VA = "0x1828E1A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class NewGraphMissingError : RNDCLZSKOMZ, IEquatable<NewGraphMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x28E1E40", Offset = "0x28E0640", VA = "0x1828E1E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x28E1E70", Offset = "0x28E0670", VA = "0x1828E1E70")]
		public NewGraphMissingError([In] Id128<VAEORNAZREW> legacyGraphId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x28E1D00", Offset = "0x28E0500", VA = "0x1828E1D00", Slot = "5")]
		public bool Equals(NewGraphMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x28E1D60", Offset = "0x28E0560", VA = "0x1828E1D60", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x28E1E00", Offset = "0x28E0600", VA = "0x1828E1E00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NewInputIncorrectIdError : RNDCLZSKOMZ, IEquatable<NewInputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly Id32<WZTXETPFGMO> CDDSPIWBUZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Id32<WZTXETPFGMO> NAZZQVLDAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly int CWCIXVOTPPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x28E22E0", Offset = "0x28E0AE0", VA = "0x1828E22E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x28E2310", Offset = "0x28E0B10", VA = "0x1828E2310")]
		public NewInputIncorrectIdError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, Id32<WZTXETPFGMO> expectedInputId, Id32<WZTXETPFGMO> inputIdInEntities, int inputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x28E1F30", Offset = "0x28E0730", VA = "0x1828E1F30", Slot = "5")]
		public bool Equals(NewInputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x28E2060", Offset = "0x28E0860", VA = "0x1828E2060", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x28E21F0", Offset = "0x28E09F0", VA = "0x1828E21F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NewInputMissingError : RNDCLZSKOMZ, IEquatable<NewInputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int GRGHDKLXIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly int MCRIDAHJYDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x28E29D0", Offset = "0x28E11D0", VA = "0x1828E29D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x28E2A00", Offset = "0x28E1200", VA = "0x1828E2A00")]
		public NewInputMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, int newInputCount, int legacyInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x28E2800", Offset = "0x28E1000", VA = "0x1828E2800", Slot = "5")]
		public bool Equals(NewInputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x28E26D0", Offset = "0x28E0ED0", VA = "0x1828E26D0", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x28E28F0", Offset = "0x28E10F0", VA = "0x1828E28F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class NewNodeMissingError : RNDCLZSKOMZ, IEquatable<NewNodeMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly Id32<EIHRYTCDBRP> SIFCALKUZNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x28E2FE0", Offset = "0x28E17E0", VA = "0x1828E2FE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x28E3010", Offset = "0x28E1810", VA = "0x1828E3010")]
		public NewNodeMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, [In] Id128<CATHGSEFVUK> legacyNodeId, [In] Id32<EIHRYTCDBRP> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x28E2E50", Offset = "0x28E1650", VA = "0x1828E2E50", Slot = "5")]
		public bool Equals(NewNodeMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x28E2D40", Offset = "0x28E1540", VA = "0x1828E2D40", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x28E2F20", Offset = "0x28E1720", VA = "0x1828E2F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class NewOutputIncorrectIdError : RNDCLZSKOMZ, IEquatable<NewOutputIncorrectIdError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly Id32<NNBWOXGQYLV> GEOYDWDQBTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly Id32<NNBWOXGQYLV> TIIYAWGLVVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int UIGPGHJTUQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x28E3640", Offset = "0x28E1E40", VA = "0x1828E3640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x28E3670", Offset = "0x28E1E70", VA = "0x1828E3670")]
		public NewOutputIncorrectIdError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, Id32<NNBWOXGQYLV> expectedOutputId, Id32<NNBWOXGQYLV> outputIdInEntities, int outputIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x28E3420", Offset = "0x28E1C20", VA = "0x1828E3420", Slot = "5")]
		public bool Equals(NewOutputIncorrectIdError? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x28E3290", Offset = "0x28E1A90", VA = "0x1828E3290", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x28E3550", Offset = "0x28E1D50", VA = "0x1828E3550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class NewOutputMissingError : RNDCLZSKOMZ, IEquatable<NewOutputMissingError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly int VGNNXKWHKGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly int HUNJIHJNWLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x28E3D30", Offset = "0x28E2530", VA = "0x1828E3D30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x28E3D60", Offset = "0x28E2560", VA = "0x1828E3D60")]
		public NewOutputMissingError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, int newOutputCount, int legacyOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x28E3A30", Offset = "0x28E2230", VA = "0x1828E3A30", Slot = "5")]
		public bool Equals(NewOutputMissingError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x28E3B20", Offset = "0x28E2320", VA = "0x1828E3B20", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x28E3C50", Offset = "0x28E2450", VA = "0x1828E3C50", Slot = "2")]
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
		public readonly Id32<NNBWOXGQYLV> SrcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly Id32<WZTXETPFGMO> DstId;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public NewStaticEdge(Id32<NNBWOXGQYLV> srcId, Id32<WZTXETPFGMO> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x28E40A0", Offset = "0x28E28A0", VA = "0x1828E40A0")]
		public void BYKHRBFUYXH([Out] Id32<NNBWOXGQYLV> srcId, [Out] Id32<WZTXETPFGMO> dstId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x28E41C0", Offset = "0x28E29C0", VA = "0x1828E41C0")]
		public static bool SSVDESVOTBX(NewStaticEdge a, NewStaticEdge b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x28E40B0", Offset = "0x28E28B0", VA = "0x1828E40B0", Slot = "4")]
		public bool Equals(NewStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x28E40C0", Offset = "0x28E28C0", VA = "0x1828E40C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x28E4150", Offset = "0x28E2950", VA = "0x1828E4150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class NodeDefMismatchError : RNDCLZSKOMZ, IEquatable<NodeDefMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly Id128<YJGJBYABSIW> XVCRJFAUGSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly Id32<EIHRYTCDBRP> SIFCALKUZNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x28E45F0", Offset = "0x28E2DF0", VA = "0x1828E45F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x28E4620", Offset = "0x28E2E20", VA = "0x1828E4620")]
		public NodeDefMismatchError(Id32<VAEORNAZREW> graphId, [In] Id128<VAEORNAZREW> legacyGraphId, [In] Id32<CATHGSEFVUK> nodeId, [In] Id128<CATHGSEFVUK> legacyNodeId, [In] Id128<YJGJBYABSIW> legacyNodeDefId, [In] Id32<EIHRYTCDBRP> nodeDefId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x28E43C0", Offset = "0x28E2BC0", VA = "0x1828E43C0", Slot = "5")]
		public bool Equals(NodeDefMismatchError other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x28E4240", Offset = "0x28E2A40", VA = "0x1828E4240", Slot = "0")]
		public override bool Equals(object? rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x28E44E0", Offset = "0x28E2CE0", VA = "0x1828E44E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class NodeDescInputsMismatchError : RNDCLZSKOMZ, IEquatable<NodeDescInputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly int NLJGFEDUKLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public readonly int AKHIHEGDPCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public readonly int AJGRZALUYQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x28E4CB0", Offset = "0x28E34B0", VA = "0x1828E4CB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x28E4CE0", Offset = "0x28E34E0", VA = "0x1828E4CE0")]
		public NodeDescInputsMismatchError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, int nodeGroupIndex, int nodeDescInputCount, int nodeGroupInputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4990", Offset = "0x28E3190", VA = "0x1828E4990", Slot = "5")]
		public bool Equals(NodeDescInputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4A80", Offset = "0x28E3280", VA = "0x1828E4A80", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4BB0", Offset = "0x28E33B0", VA = "0x1828E4BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public sealed class NodeDescOutputsMismatchError : RNDCLZSKOMZ, IEquatable<NodeDescOutputsMismatchError>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly Id32<VAEORNAZREW> TPRAXEVDNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly Id128<VAEORNAZREW> DDOKUOFBUAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly Id32<CATHGSEFVUK> KMXGEKPSBZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly Id128<CATHGSEFVUK> OPHVPCKNUUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly int NLJGFEDUKLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly int BAVSIESIVEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int HVUTRDWEOTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly string ZSASTRRGRPI;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public string YIGSCYZANQM
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x28E53A0", Offset = "0x28E3BA0", VA = "0x1828E53A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x28E53D0", Offset = "0x28E3BD0", VA = "0x1828E53D0")]
		public NodeDescOutputsMismatchError(Id32<VAEORNAZREW> graphId, Id128<VAEORNAZREW> legacyGraphId, Id32<CATHGSEFVUK> nodeId, Id128<CATHGSEFVUK> legacyNodeId, int nodeGroupIndex, int nodeDescOutputCount, int nodeGroupOutputCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x28E5080", Offset = "0x28E3880", VA = "0x1828E5080", Slot = "5")]
		public bool Equals(NodeDescOutputsMismatchError rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x28E5170", Offset = "0x28E3970", VA = "0x1828E5170", Slot = "0")]
		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x28E52A0", Offset = "0x28E3AA0", VA = "0x1828E52A0", Slot = "2")]
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
		public readonly Id128<CATHGSEFVUK> ObjectBoardId;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1285DA0", Offset = "0x12845A0", VA = "0x181285DA0")]
		public ObjectBoardProps([In] Id128<CATHGSEFVUK> objectBoardId)
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
		public readonly YBETPIMTIQD Bool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly YBETPIMTIQD Exec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly YBETPIMTIQD Float;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly YBETPIMTIQD Int;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly YBETPIMTIQD String;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly YBETPIMTIQD Vector3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public readonly YBETPIMTIQD Quaternion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly YBETPIMTIQD Color;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28E5990", Offset = "0x28E4190", VA = "0x1828E5990")]
		public PrimitivePortGroupModifiers(YBETPIMTIQD @bool, YBETPIMTIQD exec, YBETPIMTIQD @float, YBETPIMTIQD @int, YBETPIMTIQD @string, YBETPIMTIQD vector3, YBETPIMTIQD quaternion, YBETPIMTIQD color)
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
		public readonly Id128<CATHGSEFVUK> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public readonly Id32<ODOZBJITLFD> SrcPortIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly Id128<CATHGSEFVUK> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly Id32<LGADMMDLSJA> DstPortIndex;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x28E5F40", Offset = "0x28E4740", VA = "0x1828E5F40")]
		public StableStaticEdge([In] Id128<CATHGSEFVUK> srcNodeId, Id32<ODOZBJITLFD> srcPortIndex, [In] Id128<CATHGSEFVUK> dstNodeId, Id32<LGADMMDLSJA> dstPortIndex)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x28E5C60", Offset = "0x28E4460", VA = "0x1828E5C60")]
		public static bool SSVDESVOTBX([In] StableStaticEdge left, [In] StableStaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x28E5AF0", Offset = "0x28E42F0", VA = "0x1828E5AF0", Slot = "4")]
		public bool Equals(StableStaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x28E5A40", Offset = "0x28E4240", VA = "0x1828E5A40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x28E5BB0", Offset = "0x28E43B0", VA = "0x1828E5BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x28E5D20", Offset = "0x28E4520", VA = "0x1828E5D20", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC12960", Offset = "0xC11160", VA = "0x180C12960")]
		public StaticCircuitsConfig(int maxPlayers, int invisibleChipLimitBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x28E5F60", Offset = "0x28E4760", VA = "0x1828E5F60")]
		public StaticCircuitsConfigData VOPQGDPBGDJ()
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
		public readonly Id128<CATHGSEFVUK> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public readonly Id32<JIWIEDNGUWY> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public readonly Id32<RYQAJTIFIUP> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public readonly Id128<CATHGSEFVUK> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public readonly Id32<JIWIEDNGUWY> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public readonly Id32<CLOCUIODAVK> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x28E6550", Offset = "0x28E4D50", VA = "0x1828E6550")]
		public StaticEdge([In] Id128<CATHGSEFVUK> srcNodeId, Id32<JIWIEDNGUWY> srcPortGroupId, Id32<RYQAJTIFIUP> srcPortId, [In] Id128<CATHGSEFVUK> dstNodeId, Id32<JIWIEDNGUWY> dstPortGroupId, Id32<CLOCUIODAVK> dstPortId)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x28E6190", Offset = "0x28E4990", VA = "0x1828E6190")]
		public static bool SSVDESVOTBX([In] StaticEdge left, [In] StaticEdge right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x28E6080", Offset = "0x28E4880", VA = "0x1828E6080", Slot = "4")]
		public bool Equals(StaticEdge other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x28E5FD0", Offset = "0x28E47D0", VA = "0x1828E5FD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x28E60A0", Offset = "0x28E48A0", VA = "0x1828E60A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x28E6280", Offset = "0x28E4A80", VA = "0x1828E6280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public static class EDDHGIFGJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x28DE3D0", Offset = "0x28DCBD0", VA = "0x1828DE3D0")]
		public static StaticEdge OTJRLYAVGYO(this NGMVHVFERHW a)
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
		[Cpp2IlInjected.Address(RVA = "0xB22B30", Offset = "0xB21330", VA = "0x180B22B30")]
		public StudioFunctionDefinition(string prefabName, int studioFunctionIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x28E6580", Offset = "0x28E4D80", VA = "0x1828E6580", Slot = "4")]
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
		public readonly XBNVZQRVUKS.LTMCDKJGFXW.StudioFunctionParameterType ParameterType;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xB22B30", Offset = "0xB21330", VA = "0x180B22B30")]
		public StudioFunctionPortDeclaration(string name, XBNVZQRVUKS.LTMCDKJGFXW.StudioFunctionParameterType parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x28E66F0", Offset = "0x28E4EF0", VA = "0x1828E66F0")]
		internal static StudioFunctionPortDeclaration OTJRLYAVGYO(XBNVZQRVUKS a)
		{
			return default(StudioFunctionPortDeclaration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x28E69E0", Offset = "0x28E51E0", VA = "0x1828E69E0")]
		internal XBNVZQRVUKS VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x28E6680", Offset = "0x28E4E80", VA = "0x1828E6680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x28E65D0", Offset = "0x28E4DD0", VA = "0x1828E65D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x28E6580", Offset = "0x28E4D80", VA = "0x1828E6580")]
		public bool CJJTJTFGJNQ(StudioFunctionPortDeclaration a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x28E6740", Offset = "0x28E4F40", VA = "0x1828E6740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public readonly struct StudioFunctionRegistration : IEquatable<StudioFunctionRegistration>
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly IReadOnlyDictionary<Id128<MSOPKGVLNVM>, StudioFunctionDefinition> NoDefinitions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly StudioFunctionSignature Signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly string PrefabNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public readonly IReadOnlyDictionary<Id128<MSOPKGVLNVM>, StudioFunctionDefinition> Definitions;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x28E6EB0", Offset = "0x28E56B0", VA = "0x1828E6EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x28E8120", Offset = "0x28E6920", VA = "0x1828E8120")]
		public StudioFunctionRegistration(StudioFunctionSignature signature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x28E7EC0", Offset = "0x28E66C0", VA = "0x1828E7EC0")]
		public StudioFunctionRegistration(StudioFunctionSignature signature, IReadOnlyDictionary<Id128<MSOPKGVLNVM>, StudioFunctionDefinition> definitions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x28E6F30", Offset = "0x28E5730", VA = "0x1828E6F30")]
		public static StudioFunctionRegistration Merge(StudioFunctionRegistration oldRegistration, StudioFunctionRegistration newRegistration)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x28E7870", Offset = "0x28E6070", VA = "0x1828E7870")]
		public static StudioFunctionRegistration OTJRLYAVGYO(WRJQJJCOJLO a)
		{
			return default(StudioFunctionRegistration);
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x28E7CB0", Offset = "0x28E64B0", VA = "0x1828E7CB0")]
		public WRJQJJCOJLO VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x28E6A50", Offset = "0x28E5250", VA = "0x1828E6A50", Slot = "4")]
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
		public bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x28E8300", Offset = "0x28E6B00", VA = "0x1828E8300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1C99A20", Offset = "0x1C98220", VA = "0x181C99A20")]
		public StudioFunctionSignature(string name, IReadOnlyList<StudioFunctionPortDeclaration> inputs, IReadOnlyList<StudioFunctionPortDeclaration> outputs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8320", Offset = "0x28E6B20", VA = "0x1828E8320")]
		public static StudioFunctionSignature OTJRLYAVGYO(LLZUJIOFGFL a)
		{
			return default(StudioFunctionSignature);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x28E8B70", Offset = "0x28E7370", VA = "0x1828E8B70")]
		public LLZUJIOFGFL VOPQGDPBGDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x28E8280", Offset = "0x28E6A80", VA = "0x1828E8280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x28E85D0", Offset = "0x28E6DD0", VA = "0x1828E85D0")]
		private static int QOISCOJQBOY(IReadOnlyList<StudioFunctionPortDeclaration> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x28E81D0", Offset = "0x28E69D0", VA = "0x1828E81D0", Slot = "4")]
		public bool Equals(StudioFunctionSignature other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x28E87B0", Offset = "0x28E6FB0", VA = "0x1828E87B0", Slot = "3")]
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
	public static class YNUUSCJAGJX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x12A5180", Offset = "0x12A3980", VA = "0x1812A5180")]
		public static bool QCUREQEOGFV(this TemplateSerializationReason a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x12A5180", Offset = "0x12A3980", VA = "0x1812A5180")]
		public static bool ISVMCUOIRRI(this TemplateSerializationReason a)
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
		[Cpp2IlInjected.Address(RVA = "0x17DC8F0", Offset = "0x17DB0F0", VA = "0x1817DC8F0")]
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
