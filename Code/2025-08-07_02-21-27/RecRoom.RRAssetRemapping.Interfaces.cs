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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x92F1850", Offset = "0x92F0450", VA = "0x1892F1850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GRHCPIWZEJZ
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
		public bool FJLCQFQIRHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x92F0060", Offset = "0x92EEC60", VA = "0x1892F0060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool VHKFTXACVDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x92F0320", Offset = "0x92EEF20", VA = "0x1892F0320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x92F0660", Offset = "0x92EF260", VA = "0x1892F0660")]
		public AvatarItemDesc(AvatarItemDesc baseItemDesc, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B24840", Offset = "0x6B23440", VA = "0x186B24840")]
		public AvatarItemDesc(AvatarItemId avatarItemId, CombinationId combinationId, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x92F01D0", Offset = "0x92EEDD0", VA = "0x1892F01D0", Slot = "4")]
		public bool Equals(AvatarItemDesc other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x92F0120", Offset = "0x92EED20", VA = "0x1892F0120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x92F0290", Offset = "0x92EEE90", VA = "0x1892F0290", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92F00F0", Offset = "0x92EECF0", VA = "0x1892F00F0")]
		public static bool EOXNKNKFOQL(AvatarItemDesc a, AvatarItemDesc b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x92F0350", Offset = "0x92EEF50", VA = "0x1892F0350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public AvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(AvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(AvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x92F0680", Offset = "0x92EF280", VA = "0x1892F0680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x92F0760", Offset = "0x92EF360", VA = "0x1892F0760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public BodyShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(BodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(BodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x92F07D0", Offset = "0x92EF3D0", VA = "0x1892F07D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x92F0880", Offset = "0x92EF480", VA = "0x1892F0880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public ColorId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(ColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(ColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x92F08F0", Offset = "0x92EF4F0", VA = "0x1892F08F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x92F09A0", Offset = "0x92EF5A0", VA = "0x1892F09A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public CombinationId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x92F0A10", Offset = "0x92EF610", VA = "0x1892F0A10", Slot = "4")]
		public bool Equals(CombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x92F0A40", Offset = "0x92EF640", VA = "0x1892F0A40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x92F0A10", Offset = "0x92EF610", VA = "0x1892F0A10")]
		public static bool EOXNKNKFOQL(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x92F0AF0", Offset = "0x92EF6F0", VA = "0x1892F0AF0")]
		public static bool SZMIMWEVICM(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(CombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x92F0B20", Offset = "0x92EF720", VA = "0x1892F0B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public CombinationId(MaterialId materialId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public EquipmentSkinId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(EquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(EquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x92F0B90", Offset = "0x92EF790", VA = "0x1892F0B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x92F0C40", Offset = "0x92EF840", VA = "0x1892F0C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public FaceFeatureId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(FaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(FaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x92F0CB0", Offset = "0x92EF8B0", VA = "0x1892F0CB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x92F0D60", Offset = "0x92EF960", VA = "0x1892F0D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public FaceShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(FaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(FaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x92F0DD0", Offset = "0x92EF9D0", VA = "0x1892F0DD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x92F0E80", Offset = "0x92EFA80", VA = "0x1892F0E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public HairPatternId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(HairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(HairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x92F0EF0", Offset = "0x92EFAF0", VA = "0x1892F0EF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80")]
		public static bool EOXNKNKFOQL(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x92F0730", Offset = "0x92EF330", VA = "0x1892F0730")]
		public static bool SZMIMWEVICM(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x92F0FA0", Offset = "0x92EFBA0", VA = "0x1892F0FA0", Slot = "3")]
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
		public bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x92F14C0", Offset = "0x92F00C0", VA = "0x1892F14C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private int AHQLTUIIKLL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5ED48B0", Offset = "0x5ED34B0", VA = "0x185ED48B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x92F15F0", Offset = "0x92F01F0", VA = "0x1892F15F0")]
		public MaterialCombinationId(string? originalString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x92F1570", Offset = "0x92F0170", VA = "0x1892F1570")]
		public MaterialCombinationId(string?[] parts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x92F1070", Offset = "0x92EFC70", VA = "0x1892F1070")]
		private static string?[]? ELSYHTXRDGI(string?[]? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x92F1010", Offset = "0x92EFC10", VA = "0x1892F1010")]
		public string CCOEQEKGMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x92F1310", Offset = "0x92EFF10", VA = "0x1892F1310", Slot = "4")]
		public bool Equals(MaterialCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x92F1280", Offset = "0x92EFE80", VA = "0x1892F1280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x92F13E0", Offset = "0x92EFFE0", VA = "0x1892F13E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x92F14E0", Offset = "0x92F00E0", VA = "0x1892F14E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, YGKPYJREKUM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public MaterialId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x556CE80", Offset = "0x556BA80", VA = "0x18556CE80", Slot = "4")]
		public bool Equals(MaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x556C190", Offset = "0x556AD90", VA = "0x18556C190", Slot = "5")]
		public int CompareTo(MaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x92F1730", Offset = "0x92F0330", VA = "0x1892F1730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x556C460", Offset = "0x556B060", VA = "0x18556C460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x92F17E0", Offset = "0x92F03E0", VA = "0x1892F17E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ZOQURIDNNYB<a> : AJFUZAFNJLT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DGPIQGAMHGZ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface YGKPYJREKUM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Guid HHCSOIALONS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface AJFUZAFNJLT<out a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a YYFWOTTQBRP(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface HYEGHIFALXC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		ZOQURIDNNYB<AvatarItemId> WOFAJJFLLTO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		ZOQURIDNNYB<EquipmentSkinId> CBMNUZXBVEV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		ZOQURIDNNYB<HairPatternId> KIAUFGESKAW
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ZOQURIDNNYB<CombinationId> HGYQOYNPSPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ZOQURIDNNYB<ColorId> EREDFGFYXNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		ZOQURIDNNYB<FaceShapeId> SIKBHRSRYKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		ZOQURIDNNYB<BodyShapeId> MZPBAKHBNEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ZOQURIDNNYB<FaceFeatureId> IVBLTEKXNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class TVASZXISEKT
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly char[] KEZRDMEPSUK;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x92F18D0", Offset = "0x92F04D0", VA = "0x1892F18D0")]
		public static string[] IQFGKKWXJIB(string? originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x92F1970", Offset = "0x92F0570", VA = "0x1892F1970")]
		public static string? TVQVZVXWYPJ(string? a)
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
