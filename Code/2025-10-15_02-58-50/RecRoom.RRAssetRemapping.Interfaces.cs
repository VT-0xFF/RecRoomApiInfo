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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D36DE0", Offset = "0x8D35BE0", VA = "0x188D36DE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HSZUHTJTGSV
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
		public bool EFSGUXODZUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8D35720", Offset = "0x8D34520", VA = "0x188D35720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FRAEXFOFMMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D357B0", Offset = "0x8D345B0", VA = "0x188D357B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D35B10", Offset = "0x8D34910", VA = "0x188D35B10")]
		public AvatarItemDesc(AvatarItemDesc baseItemDesc, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65BDD70", Offset = "0x65BCB70", VA = "0x1865BDD70")]
		public AvatarItemDesc(AvatarItemId avatarItemId, CombinationId combinationId, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D355D0", Offset = "0x8D343D0", VA = "0x188D355D0", Slot = "4")]
		public bool Equals(AvatarItemDesc other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D35520", Offset = "0x8D34320", VA = "0x188D35520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D35690", Offset = "0x8D34490", VA = "0x188D35690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D357E0", Offset = "0x8D345E0", VA = "0x188D357E0")]
		public static bool TRHVNHMHPTX(AvatarItemDesc a, AvatarItemDesc b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D35810", Offset = "0x8D34610", VA = "0x188D35810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public AvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(AvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(AvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D35B30", Offset = "0x8D34930", VA = "0x188D35B30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D35BD0", Offset = "0x8D349D0", VA = "0x188D35BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public BodyShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(BodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(BodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C70", Offset = "0x8D34A70", VA = "0x188D35C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D35D10", Offset = "0x8D34B10", VA = "0x188D35D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public ColorId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(ColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(ColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D35D80", Offset = "0x8D34B80", VA = "0x188D35D80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D35E20", Offset = "0x8D34C20", VA = "0x188D35E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public CombinationId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D35F30", Offset = "0x8D34D30", VA = "0x188D35F30", Slot = "4")]
		public bool Equals(CombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D35E90", Offset = "0x8D34C90", VA = "0x188D35E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D35F30", Offset = "0x8D34D30", VA = "0x188D35F30")]
		public static bool TRHVNHMHPTX(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D35FD0", Offset = "0x8D34DD0", VA = "0x188D35FD0")]
		public static bool VVLYKZHTTRM(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(CombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D35F60", Offset = "0x8D34D60", VA = "0x188D35F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public CombinationId(MaterialId materialId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public EquipmentSkinId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(EquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(EquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D36000", Offset = "0x8D34E00", VA = "0x188D36000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D360A0", Offset = "0x8D34EA0", VA = "0x188D360A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public FaceFeatureId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(FaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(FaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D36110", Offset = "0x8D34F10", VA = "0x188D36110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D361B0", Offset = "0x8D34FB0", VA = "0x188D361B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public FaceShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(FaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(FaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D36220", Offset = "0x8D35020", VA = "0x188D36220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D362C0", Offset = "0x8D350C0", VA = "0x188D362C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public HairPatternId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(HairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(HairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8D36330", Offset = "0x8D35130", VA = "0x188D36330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0")]
		public static bool TRHVNHMHPTX(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D35C40", Offset = "0x8D34A40", VA = "0x188D35C40")]
		public static bool VVLYKZHTTRM(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D363D0", Offset = "0x8D351D0", VA = "0x188D363D0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ARWUUGAYCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D36980", Offset = "0x8D35780", VA = "0x188D36980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int ZFIQPNEYKOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x58D7530", Offset = "0x58D6330", VA = "0x1858D7530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D36A20", Offset = "0x8D35820", VA = "0x188D36A20")]
		public MaterialCombinationId(string? originalString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D369A0", Offset = "0x8D357A0", VA = "0x188D369A0")]
		public MaterialCombinationId(string?[] parts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D366E0", Offset = "0x8D354E0", VA = "0x188D366E0")]
		private static string?[]? PSBLPYJVYLY(string?[]? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D365A0", Offset = "0x8D353A0", VA = "0x188D365A0")]
		public string FIMYFFYTTAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D364D0", Offset = "0x8D352D0", VA = "0x188D364D0", Slot = "4")]
		public bool Equals(MaterialCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D36440", Offset = "0x8D35240", VA = "0x188D36440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D36600", Offset = "0x8D35400", VA = "0x188D36600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D368F0", Offset = "0x8D356F0", VA = "0x188D368F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public MaterialId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x51F10B0", Offset = "0x51EFEB0", VA = "0x1851F10B0", Slot = "4")]
		public bool Equals(MaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x51F0A10", Offset = "0x51EF810", VA = "0x1851F0A10", Slot = "5")]
		public int CompareTo(MaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D36B60", Offset = "0x8D35960", VA = "0x188D36B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EFA50", VA = "0x1851F0C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D36C00", Offset = "0x8D35A00", VA = "0x188D36C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface LMGFQYJWXTN<a> : HNSGOQNSBSP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string USHFLIDQGPN(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface UDQHUHYEIZA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Guid SEQIZJLYXAS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface HNSGOQNSBSP<out a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a MXIMGTNABID(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NFVQCOGXZQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		LMGFQYJWXTN<AvatarItemId> SULONBCGPZY
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		LMGFQYJWXTN<EquipmentSkinId> UPQPRCSWLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		LMGFQYJWXTN<HairPatternId> CZAQQPSNWNK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		LMGFQYJWXTN<CombinationId> XFPRFUIXTHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		LMGFQYJWXTN<ColorId> RHSTVLRKDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		LMGFQYJWXTN<FaceShapeId> JPEBXZMGXBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		LMGFQYJWXTN<BodyShapeId> XCYKTVEPLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		LMGFQYJWXTN<FaceFeatureId> YVSSYHYYIKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class NSXTNSRTBYJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly char[] VLFNFXWPVLC;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D36CA0", Offset = "0x8D35AA0", VA = "0x188D36CA0")]
		public static string[] ONOJWVYDLMX(string? originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D36C70", Offset = "0x8D35A70", VA = "0x188D36C70")]
		public static string? LQEACJREKAJ(string? a)
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
