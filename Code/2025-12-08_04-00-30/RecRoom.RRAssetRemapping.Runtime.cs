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
		[Cpp2IlInjected.Address(RVA = "0x8C57690", Offset = "0x8C55E90", VA = "0x188C57690", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class JGZOEQRTUWM : GRPSLARLKPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex JWLYDHWKSPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly CGOCDAZPQZU MVFKKVGSZSV;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A220", Offset = "0x8C48A20", VA = "0x188C4A220")]
		[UKOBXVXKPZF.Root.GameOnly]
		[UsedImplicitly]
		internal static void UKOBXVXKPZF(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C49E80", Offset = "0x8C48680", VA = "0x188C49E80")]
		[UsedImplicitly]
		internal static void EWTOVCCFPWW(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		[RecRoom.NoEngine.Common.Preserve]
		public JGZOEQRTUWM([Inject(null)] CGOCDAZPQZU runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C49EE0", Offset = "0x8C486E0", VA = "0x188C49EE0", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C499C0", Offset = "0x8C481C0", VA = "0x188C499C0", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E1C0", Offset = "0x8C4C9C0", VA = "0x188C4E1C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E280", Offset = "0x8C4CA80", VA = "0x188C4E280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E2F0", Offset = "0x8C4CAF0", VA = "0x188C4E2F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E390", Offset = "0x8C4CB90", VA = "0x188C4E390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E400", Offset = "0x8C4CC00", VA = "0x188C4E400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E4A0", Offset = "0x8C4CCA0", VA = "0x188C4E4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, AIBVHMBYPOW, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC27030", Offset = "0xC25830", VA = "0x180C27030")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3190", Offset = "0x8AE1990", VA = "0x188AE3190", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E510", Offset = "0x8C4CD10", VA = "0x188C4E510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E5D0", Offset = "0x8C4CDD0", VA = "0x188C4E5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E5C0", Offset = "0x8C4CDC0", VA = "0x188C4E5C0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, AIBVHMBYPOW
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
		public bool UIDTTMZIHUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E640", Offset = "0x8C4CE40", VA = "0x188C4E640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1258590", Offset = "0x1256D90", VA = "0x181258590")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public static SerializedCustomAvatarItemId YXHNJXCJHHA(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E6A0", Offset = "0x8C4CEA0", VA = "0x188C4E6A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260")]
		public static bool FYOQTCVQVIR(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E740", Offset = "0x8C4CF40", VA = "0x188C4E740")]
		public static bool IDTAQAUODHM(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E760", Offset = "0x8C4CF60", VA = "0x188C4E760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0x8C4E870", Offset = "0x8C4D070", VA = "0x188C4E870")]
		public static SerializedEquipmentSkinId KJSVXBTPBNQ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E7D0", Offset = "0x8C4CFD0", VA = "0x188C4E7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E8A0", Offset = "0x8C4D0A0", VA = "0x188C4E8A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E910", Offset = "0x8C4D110", VA = "0x188C4E910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E9B0", Offset = "0x8C4D1B0", VA = "0x188C4E9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EA20", Offset = "0x8C4D220", VA = "0x188C4EA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EAC0", Offset = "0x8C4D2C0", VA = "0x188C4EAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EB30", Offset = "0x8C4D330", VA = "0x188C4EB30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E260", Offset = "0x8C4CA60", VA = "0x188C4E260")]
		public static bool FYOQTCVQVIR(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EBD0", Offset = "0x8C4D3D0", VA = "0x188C4EBD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, AIBVHMBYPOW
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
		[Cpp2IlInjected.Address(RVA = "0xFED340", Offset = "0xFEBB40", VA = "0x180FED340", Slot = "6")]
		public Guid GXCWLCXCLBE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3190", Offset = "0x8AE1990", VA = "0x188AE3190", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8C4EC40", Offset = "0x8C4D440", VA = "0x188C4EC40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x80B42B0", Offset = "0x80B2AB0", VA = "0x1880B42B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80B4120", Offset = "0x80B2920", VA = "0x1880B4120", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ECF0", Offset = "0x8C4D4F0", VA = "0x188C4ECF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CTBXZJHRUSU : CGOCDAZPQZU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CTBXZJHRUSU GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8C44710", Offset = "0x8C42F10", VA = "0x188C44710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public SHWJWSMZDJN<AvatarItemId> IAOCOLLZKMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8C447B0", Offset = "0x8C42FB0", VA = "0x188C447B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SHWJWSMZDJN<EquipmentSkinId> EXZMENSAYVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8C44800", Offset = "0x8C43000", VA = "0x188C44800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public SHWJWSMZDJN<HairPatternId> BXFBGENWXRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8C44670", Offset = "0x8C42E70", VA = "0x188C44670", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public SHWJWSMZDJN<CombinationId> VUSFVTKJVBX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8C44760", Offset = "0x8C42F60", VA = "0x188C44760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SHWJWSMZDJN<ColorId> KXESHYTOMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8C44850", Offset = "0x8C43050", VA = "0x188C44850", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SHWJWSMZDJN<FaceShapeId> SOGDYOYVXYY
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8C44620", Offset = "0x8C42E20", VA = "0x188C44620", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public SHWJWSMZDJN<BodyShapeId> ONPYMLNMFWL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8C445D0", Offset = "0x8C42DD0", VA = "0x188C445D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public SHWJWSMZDJN<FaceFeatureId> QZJDJVZJQZR
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8C446C0", Offset = "0x8C42EC0", VA = "0x188C446C0", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class LNIBPBLYIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A6C0", Offset = "0x8C48EC0", VA = "0x188C4A6C0")]
		public static Guid MCZWDJYWQKA(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A770", Offset = "0x8C48F70", VA = "0x188C4A770")]
		public static bool QLRBZPFDNBO(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GUMQQEYFLLR : KMDRRZRUGSR<AvatarItemId>, HLQMKBRKJIX<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8C448C0", Offset = "0x8C430C0", VA = "0x188C448C0", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C448A0", Offset = "0x8C430A0", VA = "0x188C448A0", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public AvatarItemId PRMCYAGGFVV(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public GUMQQEYFLLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class LFGFBWLWTLE : KMDRRZRUGSR<BodyShapeId>, HLQMKBRKJIX<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A320", Offset = "0x8C48B20", VA = "0x188C4A320", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public BodyShapeId PRMCYAGGFVV(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LFGFBWLWTLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class MNFURCEVASU : KMDRRZRUGSR<ColorId>, HLQMKBRKJIX<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C4A840", Offset = "0x8C49040", VA = "0x188C4A840", Slot = "4")]
		public IEnumerable<(ColorId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public ColorId PRMCYAGGFVV(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public MNFURCEVASU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class XPVCMNYZHQM : KMDRRZRUGSR<CombinationId>, HLQMKBRKJIX<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HLQMKBRKJIX<MaterialId> DDMPNVQSQEN;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public XPVCMNYZHQM(HLQMKBRKJIX<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4160", Offset = "0x8AE2960", VA = "0x188AE4160", Slot = "4")]
		public IEnumerable<(CombinationId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F840", Offset = "0x8C4E040", VA = "0x188C4F840", Slot = "6")]
		public CombinationId PRMCYAGGFVV(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F800", Offset = "0x8C4E000", VA = "0x188C4F800", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZFJNPUKXAGW : KMDRRZRUGSR<EquipmentSkinId>, HLQMKBRKJIX<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8C4FA80", Offset = "0x8C4E280", VA = "0x188C4FA80", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public EquipmentSkinId PRMCYAGGFVV(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ZFJNPUKXAGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SVNIDVBXFXE : KMDRRZRUGSR<FaceFeatureId>, HLQMKBRKJIX<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8C4C900", Offset = "0x8C4B100", VA = "0x188C4C900", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public FaceFeatureId PRMCYAGGFVV(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SVNIDVBXFXE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class WUHLEHWNAQF : KMDRRZRUGSR<FaceShapeId>, HLQMKBRKJIX<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8C4F3E0", Offset = "0x8C4DBE0", VA = "0x188C4F3E0", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public FaceShapeId PRMCYAGGFVV(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WUHLEHWNAQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class THLFYBGHQVP : KMDRRZRUGSR<HairPatternId>, HLQMKBRKJIX<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4ED60", Offset = "0x8C4D560", VA = "0x188C4ED60", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public HairPatternId PRMCYAGGFVV(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public THLFYBGHQVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KMDRRZRUGSR<a> : HLQMKBRKJIX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> GQFXXQQBPKC();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string EWOXJIWTJOI(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class BCQMQDFUKAQ : KMDRRZRUGSR<MaterialId>, HLQMKBRKJIX<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B99280", Offset = "0x8B97A80", VA = "0x188B99280", Slot = "4")]
		public IEnumerable<(MaterialId, string)> GQFXXQQBPKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "5")]
		public string EWOXJIWTJOI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8C44520", Offset = "0x8C42D20", VA = "0x188C44520", Slot = "6")]
		public MaterialId PRMCYAGGFVV(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public BCQMQDFUKAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class JNFQSAQZQEK<a> : SHWJWSMZDJN<a>, HLQMKBRKJIX<a> where a : IEquatable<a>, AIBVHMBYPOW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> DJVOHUGJASH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> AZDNFUOYTSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KMDRRZRUGSR<a> KVSVECLFARU;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x50F6150", Offset = "0x50F4950", VA = "0x1850F6150")]
		public JNFQSAQZQEK(KMDRRZRUGSR<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x50F56B0", Offset = "0x50F3EB0", VA = "0x1850F56B0", Slot = "5")]
		public a PRMCYAGGFVV(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x50F41D0", Offset = "0x50F29D0", VA = "0x1850F41D0", Slot = "4")]
		public string PMJTDHVTADJ(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class HTZHFNRCCIK : CGOCDAZPQZU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JNFQSAQZQEK<AvatarItemId> FWZEAENZHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private JNFQSAQZQEK<EquipmentSkinId> QKQAUUBRWIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private JNFQSAQZQEK<HairPatternId> ESHPWHAWXUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private JNFQSAQZQEK<MaterialId> DDMPNVQSQEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private JNFQSAQZQEK<CombinationId> IWHUYWOMJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JNFQSAQZQEK<ColorId> WUQVFPYXMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JNFQSAQZQEK<FaceShapeId> DHKXNTHESEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private JNFQSAQZQEK<BodyShapeId> TPPIKVIYJRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private JNFQSAQZQEK<FaceFeatureId> AGHXIXQFGAT;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SHWJWSMZDJN<AvatarItemId> IAOCOLLZKMS
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public SHWJWSMZDJN<EquipmentSkinId> EXZMENSAYVV
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public SHWJWSMZDJN<HairPatternId> BXFBGENWXRS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SHWJWSMZDJN<CombinationId> VUSFVTKJVBX
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public SHWJWSMZDJN<ColorId> KXESHYTOMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public SHWJWSMZDJN<FaceShapeId> SOGDYOYVXYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public SHWJWSMZDJN<BodyShapeId> ONPYMLNMFWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SHWJWSMZDJN<FaceFeatureId> QZJDJVZJQZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8C49510", Offset = "0x8C47D10", VA = "0x188C49510")]
		[UKOBXVXKPZF.Root.GameOnly]
		[UsedImplicitly]
		internal static void NLNDLFOXCAL(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8C49580", Offset = "0x8C47D80", VA = "0x188C49580")]
		[RecRoom.NoEngine.Common.Preserve]
		public HTZHFNRCCIK()
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
