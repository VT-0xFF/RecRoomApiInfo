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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DE0670", Offset = "0x8DDF470", VA = "0x188DE0670")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface HLVTPNALQCU
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
		public bool SVJEHYCITPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF060", Offset = "0x8DDDE60", VA = "0x188DDF060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool RPOLGBUJHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8DDEEC0", Offset = "0x8DDDCC0", VA = "0x188DDEEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF4B0", Offset = "0x8DDE2B0", VA = "0x188DDF4B0")]
		public AvatarItemDesc(AvatarItemDesc baseItemDesc, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66C7E70", Offset = "0x66C6C70", VA = "0x1866C7E70")]
		public AvatarItemDesc(AvatarItemId avatarItemId, CombinationId combinationId, [Optional] Guid customAvatarItemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEFA0", Offset = "0x8DDDDA0", VA = "0x188DDEFA0", Slot = "4")]
		public bool Equals(AvatarItemDesc other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDEEF0", Offset = "0x8DDDCF0", VA = "0x188DDEEF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF0F0", Offset = "0x8DDDEF0", VA = "0x188DDF0F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF180", Offset = "0x8DDDF80", VA = "0x188DDF180")]
		public static bool QIDDWXQJPGU(AvatarItemDesc a, AvatarItemDesc b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF1B0", Offset = "0x8DDDFB0", VA = "0x188DDF1B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct AvatarItemId : IEquatable<AvatarItemId>, IComparable<AvatarItemId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly AvatarItemId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public AvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(AvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(AvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF4D0", Offset = "0x8DDE2D0", VA = "0x188DDF4D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(AvatarItemId a, AvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF5A0", Offset = "0x8DDE3A0", VA = "0x188DDF5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BodyShapeId : IEquatable<BodyShapeId>, IComparable<BodyShapeId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly BodyShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public BodyShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(BodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(BodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF610", Offset = "0x8DDE410", VA = "0x188DDF610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(BodyShapeId a, BodyShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF6B0", Offset = "0x8DDE4B0", VA = "0x188DDF6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct ColorId : IEquatable<ColorId>, IComparable<ColorId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly ColorId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public ColorId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(ColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(ColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF720", Offset = "0x8DDE520", VA = "0x188DDF720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(ColorId a, ColorId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF7C0", Offset = "0x8DDE5C0", VA = "0x188DDF7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CombinationId : IEquatable<CombinationId>, IComparable<CombinationId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly CombinationId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public CombinationId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF8D0", Offset = "0x8DDE6D0", VA = "0x188DDF8D0", Slot = "4")]
		public bool Equals(CombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF830", Offset = "0x8DDE630", VA = "0x188DDF830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF8D0", Offset = "0x8DDE6D0", VA = "0x188DDF8D0")]
		public static bool QIDDWXQJPGU(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF900", Offset = "0x8DDE700", VA = "0x188DDF900")]
		public static bool OLTCZZLLQGX(CombinationId a, CombinationId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(CombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF930", Offset = "0x8DDE730", VA = "0x188DDF930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public CombinationId(MaterialId materialId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EquipmentSkinId : IEquatable<EquipmentSkinId>, IComparable<EquipmentSkinId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly EquipmentSkinId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SBSQVTEZLGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8DDF9A0", Offset = "0x8DDE7A0", VA = "0x188DDF9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public EquipmentSkinId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(EquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(EquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFA00", Offset = "0x8DDE800", VA = "0x188DDFA00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(EquipmentSkinId a, EquipmentSkinId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFAA0", Offset = "0x8DDE8A0", VA = "0x188DDFAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct FaceFeatureId : IEquatable<FaceFeatureId>, IComparable<FaceFeatureId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public static readonly FaceFeatureId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public FaceFeatureId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(FaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(FaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFB10", Offset = "0x8DDE910", VA = "0x188DDFB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(FaceFeatureId a, FaceFeatureId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFBB0", Offset = "0x8DDE9B0", VA = "0x188DDFBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public readonly struct FaceShapeId : IEquatable<FaceShapeId>, IComparable<FaceShapeId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static readonly FaceShapeId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public FaceShapeId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(FaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(FaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFC20", Offset = "0x8DDEA20", VA = "0x188DDFC20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(FaceShapeId a, FaceShapeId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFCC0", Offset = "0x8DDEAC0", VA = "0x188DDFCC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HairPatternId : IEquatable<HairPatternId>, IComparable<HairPatternId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly HairPatternId Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public HairPatternId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(HairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(HairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFD30", Offset = "0x8DDEB30", VA = "0x188DDFD30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930")]
		public static bool QIDDWXQJPGU(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF570", Offset = "0x8DDE370", VA = "0x188DDF570")]
		public static bool OLTCZZLLQGX(HairPatternId a, HairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFDD0", Offset = "0x8DDEBD0", VA = "0x188DDFDD0", Slot = "3")]
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
		public bool SBSQVTEZLGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8DDFE40", Offset = "0x8DDEC40", VA = "0x188DDFE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private int XLAWKSATFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x58A17E0", Offset = "0x58A05E0", VA = "0x1858A17E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0420", Offset = "0x8DDF220", VA = "0x188DE0420")]
		public MaterialCombinationId(string? originalString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE03A0", Offset = "0x8DDF1A0", VA = "0x188DE03A0")]
		public MaterialCombinationId(string?[] parts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE00A0", Offset = "0x8DDEEA0", VA = "0x188DE00A0")]
		private static string?[]? JBCRNWSSIFF(string?[]? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0340", Offset = "0x8DDF140", VA = "0x188DE0340")]
		public string XVMXKMYNAKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFEF0", Offset = "0x8DDECF0", VA = "0x188DDFEF0", Slot = "4")]
		public bool Equals(MaterialCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFE60", Offset = "0x8DDEC60", VA = "0x188DDFE60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFFC0", Offset = "0x8DDEDC0", VA = "0x188DDFFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8DE02B0", Offset = "0x8DDF0B0", VA = "0x188DE02B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MaterialId : IEquatable<MaterialId>, IComparable<MaterialId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Guid guid;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public MaterialId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5119930", Offset = "0x5118730", VA = "0x185119930", Slot = "4")]
		public bool Equals(MaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5118AF0", Offset = "0x51178F0", VA = "0x185118AF0", Slot = "5")]
		public int CompareTo(MaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0560", Offset = "0x8DDF360", VA = "0x188DE0560", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5118DD0", Offset = "0x5117BD0", VA = "0x185118DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0600", Offset = "0x8DDF400", VA = "0x188DE0600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface XPNTWMODFOM<a> : WTZVETWARLM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string MHTQDVEHNSS(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NVQGEFUYTGF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Guid VDGSZNPDKKR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface WTZVETWARLM<out a>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a HUQCZCRGBZI(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OBYGOLPQHAR
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		XPNTWMODFOM<AvatarItemId> PJXFHGSNMYN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		XPNTWMODFOM<EquipmentSkinId> AGZMDHBXIZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		XPNTWMODFOM<HairPatternId> OQADZPZDAXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		XPNTWMODFOM<CombinationId> VNLSNPEWORC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		XPNTWMODFOM<ColorId> QIAWUDZIRBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		XPNTWMODFOM<FaceShapeId> DDXYIPJYBEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		XPNTWMODFOM<BodyShapeId> DUICDCKPZIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		XPNTWMODFOM<FaceFeatureId> RWBJBFFLWQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UWJWYIZWQUA
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly char[] CQKULMEWCKT;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8DE06F0", Offset = "0x8DDF4F0", VA = "0x188DE06F0")]
		public static string[] BZUVQAQCCSO(string? originalString)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0790", Offset = "0x8DDF590", VA = "0x188DE0790")]
		public static string? NESNVKJHAWQ(string? a)
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
