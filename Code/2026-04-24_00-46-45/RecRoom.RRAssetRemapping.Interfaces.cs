using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetIds;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA28DB80", Offset = "0xA28C580", VA = "0x18A28DB80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AQCBHTVLMCW
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(AvatarItemDesc input);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AvatarItemDesc Deserialize(string input);
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct AvatarItemDesc : IEquatable<AvatarItemDesc>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly AvatarItemId AvatarItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CombinationId MaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly Guid CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DTGGJBMXLRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA28C560", Offset = "0xA28AF60", VA = "0x18A28C560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool RPBYMZCCBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA28C900", Offset = "0xA28B300", VA = "0x18A28C900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA28C930", Offset = "0xA28B330", VA = "0x18A28C930")]
		public AvatarItemDesc(AvatarItemDesc baseItemDesc, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8298570", Offset = "0x8296F70", VA = "0x188298570")]
		public AvatarItemDesc(AvatarItemId avatarItemId, CombinationId combinationId, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA28C3E0", Offset = "0xA28ADE0", VA = "0x18A28C3E0", Slot = "4")]
		public bool Equals(AvatarItemDesc other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA28C330", Offset = "0xA28AD30", VA = "0x18A28C330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA28C4A0", Offset = "0xA28AEA0", VA = "0x18A28C4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA28C530", Offset = "0xA28AF30", VA = "0x18A28C530")]
		public static bool SHHUBVCQRYC(AvatarItemDesc a, AvatarItemDesc b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA28C5F0", Offset = "0xA28AFF0", VA = "0x18A28C5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public AvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(AvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(AvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA28C980", Offset = "0xA28B380", VA = "0x18A28C980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA28CA30", Offset = "0xA28B430", VA = "0x18A28CA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public BodyShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(BodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(BodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA28CAA0", Offset = "0xA28B4A0", VA = "0x18A28CAA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA28CB50", Offset = "0xA28B550", VA = "0x18A28CB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public ColorId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(ColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(ColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA28CBC0", Offset = "0xA28B5C0", VA = "0x18A28CBC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA28CC70", Offset = "0xA28B670", VA = "0x18A28CC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public CombinationId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA28CDC0", Offset = "0xA28B7C0", VA = "0x18A28CDC0", Slot = "4")]
		public bool Equals(CombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA28CD10", Offset = "0xA28B710", VA = "0x18A28CD10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA28CDC0", Offset = "0xA28B7C0", VA = "0x18A28CDC0")]
		public static bool SHHUBVCQRYC(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA28CCE0", Offset = "0xA28B6E0", VA = "0x18A28CCE0")]
		public static bool ENWYWLXFHXP(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(CombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA28CDF0", Offset = "0xA28B7F0", VA = "0x18A28CDF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public CombinationId(MaterialId materialId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA28CE60", Offset = "0xA28B860", VA = "0x18A28CE60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public EquipmentSkinId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(EquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(EquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA28CEC0", Offset = "0xA28B8C0", VA = "0x18A28CEC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA28CF70", Offset = "0xA28B970", VA = "0x18A28CF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public FaceFeatureId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(FaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(FaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA28CFE0", Offset = "0xA28B9E0", VA = "0x18A28CFE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA28D090", Offset = "0xA28BA90", VA = "0x18A28D090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public FaceShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(FaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(FaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA28D100", Offset = "0xA28BB00", VA = "0x18A28D100", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA28D1B0", Offset = "0xA28BBB0", VA = "0x18A28D1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public HairPatternId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(HairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(HairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA28D220", Offset = "0xA28BC20", VA = "0x18A28D220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0")]
		public static bool SHHUBVCQRYC(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA28C950", Offset = "0xA28B350", VA = "0x18A28C950")]
		public static bool ENWYWLXFHXP(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA28D2D0", Offset = "0xA28BCD0", VA = "0x18A28D2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct MaterialCombinationId : IEquatable<MaterialCombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly string?[]? sanitizedParts;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA28D340", Offset = "0xA28BD40", VA = "0x18A28D340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private int BEYFJUFQUNA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x74513E0", Offset = "0x744FDE0", VA = "0x1874513E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA28D920", Offset = "0xA28C320", VA = "0x18A28D920")]
		public MaterialCombinationId(string? originalString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D8A0", Offset = "0xA28C2A0", VA = "0x18A28D8A0")]
		public MaterialCombinationId(string?[] parts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D5A0", Offset = "0xA28BFA0", VA = "0x18A28D5A0")]
		private static string?[]? NWWDRZOLTFL(string?[]? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA28D7B0", Offset = "0xA28C1B0", VA = "0x18A28D7B0")]
		public string SFIWWWAHYLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA28D3F0", Offset = "0xA28BDF0", VA = "0x18A28D3F0", Slot = "4")]
		public bool Equals(MaterialCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA28D360", Offset = "0xA28BD60", VA = "0x18A28D360", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA28D4C0", Offset = "0xA28BEC0", VA = "0x18A28D4C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA28D810", Offset = "0xA28C210", VA = "0x18A28D810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public MaterialId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x660AFC0", Offset = "0x66099C0", VA = "0x18660AFC0", Slot = "4")]
		public bool Equals(MaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(MaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA28DA60", Offset = "0xA28C460", VA = "0x18A28DA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x660A550", Offset = "0x6608F50", VA = "0x18660A550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA28DB10", Offset = "0xA28C510", VA = "0x18A28DB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface RVMVPQNDFZE<a> : ACCUDNQYGCY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string JWHHXIDWDYE(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface RJEIXZTKTCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Guid CAJIFQLNWQL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ACCUDNQYGCY<out a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a AQDLHQRZWIU(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface UMTIQQCLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		RVMVPQNDFZE<AvatarItemId> HWXKYVFIWQH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		RVMVPQNDFZE<EquipmentSkinId> VLGSARDSTBC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		RVMVPQNDFZE<HairPatternId> QSYYJWGBSCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		RVMVPQNDFZE<CombinationId> SKGGRQFBLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RVMVPQNDFZE<ColorId> IJTFLUFMXBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		RVMVPQNDFZE<FaceShapeId> USVSNYZOMIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		RVMVPQNDFZE<BodyShapeId> HVLXDFSOWBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		RVMVPQNDFZE<FaceFeatureId> JRUDLVQABWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class QSULULWLCJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly char[] PTJGRESLSGZ;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA28DC00", Offset = "0xA28C600", VA = "0x18A28DC00")]
		public static string[] JQUMPUJBKLG(string? originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA28DCA0", Offset = "0xA28C6A0", VA = "0x18A28DCA0")]
		public static string? MGUJHTRIGLE(string? a)
		{
			return null;
		}
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
