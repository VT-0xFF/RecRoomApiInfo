using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;
using UJect.Injection;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED9E0", Offset = "0xA3EC9E0", VA = "0x18A3ED9E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ZKNVMBWVTLT : CJGGLIFDKFQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex ICXKMCNYESV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly RDNMBKMIPSX XWFADESGZOG;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED540", Offset = "0xA3EC540", VA = "0x18A3ED540")]
		[GQJUYEPYYUG.Root.GameOnly]
		[UsedImplicitly]
		internal static void GQJUYEPYYUG(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED8F0", Offset = "0xA3EC8F0", VA = "0x18A3ED8F0")]
		[UsedImplicitly]
		internal static void UVDOKYEZPKX(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZKNVMBWVTLT([Inject(null)] RDNMBKMIPSX runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED5B0", Offset = "0xA3EC5B0", VA = "0x18A3ED5B0", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED070", Offset = "0xA3EC070", VA = "0x18A3ED070", Slot = "5")]
		public AvatarItemDesc Deserialize(string input)
		{
			return default(AvatarItemDesc);
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2110", Offset = "0xA3E1110", VA = "0x18A3E2110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21D0", Offset = "0xA3E11D0", VA = "0x18A3E21D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2240", Offset = "0xA3E1240", VA = "0x18A3E2240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3E22E0", Offset = "0xA3E12E0", VA = "0x18A3E22E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2350", Offset = "0xA3E1350", VA = "0x18A3E2350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E23F0", Offset = "0xA3E13F0", VA = "0x18A3E23F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, LDEENKXSBFJ, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA2794C0", Offset = "0xA2784C0", VA = "0x18A2794C0", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2460", Offset = "0xA3E1460", VA = "0x18A3E2460", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2520", Offset = "0xA3E1520", VA = "0x18A3E2520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2510", Offset = "0xA3E1510", VA = "0x18A3E2510", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool TQTTSICFWVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2630", Offset = "0xA3E1630", VA = "0x18A3E2630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x15315F0", Offset = "0x15305F0", VA = "0x1815315F0")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public static SerializedCustomAvatarItemId IZUQGIXQJPB(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2590", Offset = "0xA3E1590", VA = "0x18A3E2590", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0")]
		public static bool HCRCQFCURBY(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2690", Offset = "0xA3E1690", VA = "0x18A3E2690")]
		public static bool SIHBZTKNPGZ(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3E26B0", Offset = "0xA3E16B0", VA = "0x18A3E26B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3E27C0", Offset = "0xA3E17C0", VA = "0x18A3E27C0")]
		public static SerializedEquipmentSkinId QVJUSSCXMGB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2720", Offset = "0xA3E1720", VA = "0x18A3E2720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3E27F0", Offset = "0xA3E17F0", VA = "0x18A3E27F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2860", Offset = "0xA3E1860", VA = "0x18A3E2860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2900", Offset = "0xA3E1900", VA = "0x18A3E2900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2970", Offset = "0xA3E1970", VA = "0x18A3E2970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2A10", Offset = "0xA3E1A10", VA = "0x18A3E2A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2A80", Offset = "0xA3E1A80", VA = "0x18A3E2A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E11B0", VA = "0x18A3E21B0")]
		public static bool HCRCQFCURBY(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2B20", Offset = "0xA3E1B20", VA = "0x18A3E2B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "6")]
		public Guid WFGBMMWXZSL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2794C0", Offset = "0xA2784C0", VA = "0x18A2794C0", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2B90", Offset = "0xA3E1B90", VA = "0x18A3E2B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x98166C0", Offset = "0x98156C0", VA = "0x1898166C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9816530", Offset = "0x9815530", VA = "0x189816530", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2C40", Offset = "0xA3E1C40", VA = "0x18A3E2C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class TAFMNCLSJBX : RDNMBKMIPSX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static TAFMNCLSJBX CIARLSLMHCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2EE0", Offset = "0xA3E1EE0", VA = "0x18A3E2EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public WTSJPTGCVLI<AvatarItemId> XKFSVACSQSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2D50", Offset = "0xA3E1D50", VA = "0x18A3E2D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public WTSJPTGCVLI<EquipmentSkinId> CUTHQWFACYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2F30", Offset = "0xA3E1F30", VA = "0x18A3E2F30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public WTSJPTGCVLI<HairPatternId> QRQYYFTMQMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2E40", Offset = "0xA3E1E40", VA = "0x18A3E2E40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public WTSJPTGCVLI<CombinationId> TRDERMCNDXI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2E90", Offset = "0xA3E1E90", VA = "0x18A3E2E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public WTSJPTGCVLI<ColorId> FCNLWGZSQFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2DF0", Offset = "0xA3E1DF0", VA = "0x18A3E2DF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public WTSJPTGCVLI<FaceShapeId> HNFRKYINNUT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2DA0", Offset = "0xA3E1DA0", VA = "0x18A3E2DA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public WTSJPTGCVLI<BodyShapeId> SHBIHWOUVRW
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2CB0", Offset = "0xA3E1CB0", VA = "0x18A3E2CB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public WTSJPTGCVLI<FaceFeatureId> GVDBMFOWGSU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA3E2D00", Offset = "0xA3E1D00", VA = "0x18A3E2D00", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class OZIGCUKNJRU
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E07A0", Offset = "0xA3DF7A0", VA = "0x18A3E07A0")]
		public static Guid ZITEVJIZUDX(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3E06D0", Offset = "0xA3DF6D0", VA = "0x18A3E06D0")]
		public static bool ARRNWDMWDKJ(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GSYKGTPXLLQ : WMMQYOKCDFM<AvatarItemId>, XSJHMDHQAIE<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB400", Offset = "0xA3DA400", VA = "0x18A3DB400", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB3E0", Offset = "0xA3DA3E0", VA = "0x18A3DB3E0", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public AvatarItemId VVSGKUDPERC(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public GSYKGTPXLLQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DWEMJEZOUPP : WMMQYOKCDFM<BodyShapeId>, XSJHMDHQAIE<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAB90", Offset = "0xA3D9B90", VA = "0x18A3DAB90", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public BodyShapeId VVSGKUDPERC(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public DWEMJEZOUPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class XBUOTXBCWQL : WMMQYOKCDFM<ColorId>, XSJHMDHQAIE<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3E33A0", Offset = "0xA3E23A0", VA = "0x18A3E33A0", Slot = "4")]
		public IEnumerable<(ColorId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public ColorId VVSGKUDPERC(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public XBUOTXBCWQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AQOLMTQZPST : WMMQYOKCDFM<CombinationId>, XSJHMDHQAIE<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly XSJHMDHQAIE<MaterialId> MCLDRUXFSSE;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public AQOLMTQZPST(XSJHMDHQAIE<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA27A4A0", Offset = "0xA2794A0", VA = "0x18A27A4A0", Slot = "4")]
		public IEnumerable<(CombinationId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA8A0", Offset = "0xA3D98A0", VA = "0x18A3DA8A0", Slot = "6")]
		public CombinationId VVSGKUDPERC(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA860", Offset = "0xA3D9860", VA = "0x18A3DA860", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class YYPHOBSBABH : WMMQYOKCDFM<EquipmentSkinId>, XSJHMDHQAIE<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5460", Offset = "0xA3E4460", VA = "0x18A3E5460", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public EquipmentSkinId VVSGKUDPERC(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public YYPHOBSBABH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SYVAQBJPOMZ : WMMQYOKCDFM<FaceFeatureId>, XSJHMDHQAIE<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0850", Offset = "0xA3DF850", VA = "0x18A3E0850", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public FaceFeatureId VVSGKUDPERC(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public SYVAQBJPOMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class WMJXVGRKGAS : WMMQYOKCDFM<FaceShapeId>, XSJHMDHQAIE<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2F80", Offset = "0xA3E1F80", VA = "0x18A3E2F80", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public FaceShapeId VVSGKUDPERC(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WMJXVGRKGAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class KKKOZEMRPUC : WMMQYOKCDFM<HairPatternId>, XSJHMDHQAIE<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0050", Offset = "0xA3DF050", VA = "0x18A3E0050", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public HairPatternId VVSGKUDPERC(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KKKOZEMRPUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface WMMQYOKCDFM<a> : XSJHMDHQAIE<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> TYPSBEUYPZX();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string IEVXGQMMZXF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class BSHTXBUHNRT : WMMQYOKCDFM<MaterialId>, XSJHMDHQAIE<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA32F5C0", Offset = "0xA32E5C0", VA = "0x18A32F5C0", Slot = "4")]
		public IEnumerable<(MaterialId, string)> TYPSBEUYPZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "5")]
		public string IEVXGQMMZXF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAE0", Offset = "0xA3D9AE0", VA = "0x18A3DAAE0", Slot = "6")]
		public MaterialId VVSGKUDPERC(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public BSHTXBUHNRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DAGKUFOKJYP<a> : WTSJPTGCVLI<a>, XSJHMDHQAIE<a> where a : IEquatable<a>, LDEENKXSBFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> FCBPKPLMTSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> KVDQLRJQLTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly WMMQYOKCDFM<a> DHSXWQBNUUN;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53A85D0", Offset = "0x53A75D0", VA = "0x1853A85D0")]
		public DAGKUFOKJYP(WMMQYOKCDFM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53A55C0", Offset = "0x53A45C0", VA = "0x1853A55C0", Slot = "5")]
		public a VVSGKUDPERC(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x53A5180", Offset = "0x53A4180", VA = "0x1853A5180", Slot = "4")]
		public string LFKLOWTTJGY(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class FCIUIOXAXLX : RDNMBKMIPSX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private DAGKUFOKJYP<AvatarItemId> COFICYXQVWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private DAGKUFOKJYP<EquipmentSkinId> YHRGDEXRLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private DAGKUFOKJYP<HairPatternId> SOTRUOZBLKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DAGKUFOKJYP<MaterialId> MCLDRUXFSSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DAGKUFOKJYP<CombinationId> KNIURBFAYHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private DAGKUFOKJYP<ColorId> QDJDBLRCYVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DAGKUFOKJYP<FaceShapeId> TJNMMMFAINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private DAGKUFOKJYP<BodyShapeId> DPCWGIKXTWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private DAGKUFOKJYP<FaceFeatureId> XGHQIEKNLXG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public WTSJPTGCVLI<AvatarItemId> XKFSVACSQSL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public WTSJPTGCVLI<EquipmentSkinId> CUTHQWFACYA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WTSJPTGCVLI<HairPatternId> QRQYYFTMQMD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WTSJPTGCVLI<CombinationId> TRDERMCNDXI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public WTSJPTGCVLI<ColorId> FCNLWGZSQFI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public WTSJPTGCVLI<FaceShapeId> HNFRKYINNUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public WTSJPTGCVLI<BodyShapeId> SHBIHWOUVRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public WTSJPTGCVLI<FaceFeatureId> GVDBMFOWGSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAF30", Offset = "0xA3D9F30", VA = "0x18A3DAF30")]
		[GQJUYEPYYUG.Root.GameOnly]
		[UsedImplicitly]
		internal static void WVJSVKLWAIO(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAFA0", Offset = "0xA3D9FA0", VA = "0x18A3DAFA0")]
		[RecRoom.NoEngine.Common.Preserve]
		public FCIUIOXAXLX()
		{
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
