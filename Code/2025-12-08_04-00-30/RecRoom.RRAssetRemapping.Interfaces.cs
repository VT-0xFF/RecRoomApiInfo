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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE3F80", Offset = "0x8AE2780", VA = "0x188AE3F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GRPSLARLKPP
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
		public bool UQLYGHABPCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8AE2730", Offset = "0x8AE0F30", VA = "0x188AE2730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BDAFTEPPAIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8AE29F0", Offset = "0x8AE11F0", VA = "0x188AE29F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2D30", Offset = "0x8AE1530", VA = "0x188AE2D30")]
		public AvatarItemDesc(AvatarItemDesc baseItemDesc, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64732E0", Offset = "0x6471AE0", VA = "0x1864732E0")]
		public AvatarItemDesc(AvatarItemId avatarItemId, CombinationId combinationId, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2870", Offset = "0x8AE1070", VA = "0x188AE2870", Slot = "4")]
		public bool Equals(AvatarItemDesc other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE27C0", Offset = "0x8AE0FC0", VA = "0x188AE27C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2960", Offset = "0x8AE1160", VA = "0x188AE2960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2930", Offset = "0x8AE1130", VA = "0x188AE2930")]
		public static bool FYOQTCVQVIR(AvatarItemDesc a, AvatarItemDesc b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2A20", Offset = "0x8AE1220", VA = "0x188AE2A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public AvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(AvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(AvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2D50", Offset = "0x8AE1550", VA = "0x188AE2D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E30", Offset = "0x8AE1630", VA = "0x188AE2E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public BodyShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(BodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(BodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2EA0", Offset = "0x8AE16A0", VA = "0x188AE2EA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2F50", Offset = "0x8AE1750", VA = "0x188AE2F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public ColorId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(ColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(ColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2FC0", Offset = "0x8AE17C0", VA = "0x188AE2FC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3070", Offset = "0x8AE1870", VA = "0x188AE3070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public CombinationId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3190", Offset = "0x8AE1990", VA = "0x188AE3190", Slot = "4")]
		public bool Equals(CombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE30E0", Offset = "0x8AE18E0", VA = "0x188AE30E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3190", Offset = "0x8AE1990", VA = "0x188AE3190")]
		public static bool FYOQTCVQVIR(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AE31C0", Offset = "0x8AE19C0", VA = "0x188AE31C0")]
		public static bool IDTAQAUODHM(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(CombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8AE31F0", Offset = "0x8AE19F0", VA = "0x188AE31F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public CombinationId(MaterialId materialId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UIDTTMZIHUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8AE3260", Offset = "0x8AE1A60", VA = "0x188AE3260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public EquipmentSkinId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(EquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(EquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE32C0", Offset = "0x8AE1AC0", VA = "0x188AE32C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3370", Offset = "0x8AE1B70", VA = "0x188AE3370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public FaceFeatureId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(FaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(FaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AE33E0", Offset = "0x8AE1BE0", VA = "0x188AE33E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3490", Offset = "0x8AE1C90", VA = "0x188AE3490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public FaceShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(FaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(FaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3500", Offset = "0x8AE1D00", VA = "0x188AE3500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8AE35B0", Offset = "0x8AE1DB0", VA = "0x188AE35B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public HairPatternId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(HairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(HairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3620", Offset = "0x8AE1E20", VA = "0x188AE3620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310")]
		public static bool FYOQTCVQVIR(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E00", Offset = "0x8AE1600", VA = "0x188AE2E00")]
		public static bool IDTAQAUODHM(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8AE36D0", Offset = "0x8AE1ED0", VA = "0x188AE36D0", Slot = "3")]
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
		public bool UIDTTMZIHUA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE3740", Offset = "0x8AE1F40", VA = "0x188AE3740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private int XLCSTHVMVEX
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x57555F0", Offset = "0x5753DF0", VA = "0x1857555F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3D20", Offset = "0x8AE2520", VA = "0x188AE3D20")]
		public MaterialCombinationId(string? originalString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3CA0", Offset = "0x8AE24A0", VA = "0x188AE3CA0")]
		public MaterialCombinationId(string?[] parts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3A90", Offset = "0x8AE2290", VA = "0x188AE3A90")]
		private static string?[]? YXGYKUMVIJA(string?[]? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE39A0", Offset = "0x8AE21A0", VA = "0x188AE39A0")]
		public string NBOASSIISJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AE37F0", Offset = "0x8AE1FF0", VA = "0x188AE37F0", Slot = "4")]
		public bool Equals(MaterialCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3760", Offset = "0x8AE1F60", VA = "0x188AE3760", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8AE38C0", Offset = "0x8AE20C0", VA = "0x188AE38C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3A00", Offset = "0x8AE2200", VA = "0x188AE3A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public MaterialId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5009310", Offset = "0x5007B10", VA = "0x185009310", Slot = "4")]
		public bool Equals(MaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5008B00", Offset = "0x5007300", VA = "0x185008B00", Slot = "5")]
		public int CompareTo(MaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3E60", Offset = "0x8AE2660", VA = "0x188AE3E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5008E60", Offset = "0x5007660", VA = "0x185008E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3F10", Offset = "0x8AE2710", VA = "0x188AE3F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface SHWJWSMZDJN<a> : HLQMKBRKJIX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string PMJTDHVTADJ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface AIBVHMBYPOW
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Guid GXCWLCXCLBE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface HLQMKBRKJIX<out a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a PRMCYAGGFVV(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface CGOCDAZPQZU
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		SHWJWSMZDJN<AvatarItemId> IAOCOLLZKMS
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		SHWJWSMZDJN<EquipmentSkinId> EXZMENSAYVV
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		SHWJWSMZDJN<HairPatternId> BXFBGENWXRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		SHWJWSMZDJN<CombinationId> VUSFVTKJVBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		SHWJWSMZDJN<ColorId> KXESHYTOMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		SHWJWSMZDJN<FaceShapeId> SOGDYOYVXYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		SHWJWSMZDJN<BodyShapeId> ONPYMLNMFWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		SHWJWSMZDJN<FaceFeatureId> QZJDJVZJQZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class SEKWRFKCNMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly char[] JFHACLJGWYA;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4000", Offset = "0x8AE2800", VA = "0x188AE4000")]
		public static string[] AESNGLJZQEX(string? originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AE40A0", Offset = "0x8AE28A0", VA = "0x188AE40A0")]
		public static string? DUNIIKPRFFP(string? a)
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
