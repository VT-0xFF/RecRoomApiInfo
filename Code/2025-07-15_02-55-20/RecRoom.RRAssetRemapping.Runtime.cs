using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D160", Offset = "0x8B7BD60", VA = "0x188B7D160", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AFAIEBFLNJA : JMHIIDMNIMF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NPEHHOKBCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NJGPDEOPNKH GLIBLGGAABI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B69E90", Offset = "0x8B68A90", VA = "0x188B69E90")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	[UsedImplicitly]
	internal static void AMOEJCEGAKO(LGPCNHIHIDJ FDOOPNLIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8B69F00", Offset = "0x8B68B00", VA = "0x188B69F00")]
	[UsedImplicitly]
	internal static void CBFDGOIEIPN(LGPCNHIHIDJ FDOOPNLIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AFAIEBFLNJA([HAKCNCGPHPD(null)] NJGPDEOPNKH GLIBLGGAABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A430", Offset = "0x8B69030", VA = "0x188B6A430", Slot = "4")]
	public string PBHGMJKEMBG(KJEPDDGGDOL HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B69F60", Offset = "0x8B68B60", VA = "0x188B69F60", Slot = "5")]
	public KJEPDDGGDOL GLDNKJDIMCO(string HOKNBAKODNG)
	{
		return default(KJEPDDGGDOL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public IBGOJPCJDBO GLDNKJDIMCO()
		{
			return default(IBGOJPCJDBO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedAvatarItemId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C5C0", Offset = "0x8B7B1C0", VA = "0x188B7C5C0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C680", Offset = "0x8B7B280", VA = "0x188B7C680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public ODODAOJKFLP GLDNKJDIMCO()
		{
			return default(ODODAOJKFLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedBodyShapeId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C6F0", Offset = "0x8B7B2F0", VA = "0x188B7C6F0", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C790", Offset = "0x8B7B390", VA = "0x188B7C790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public HKOGKMHLCPM GLDNKJDIMCO()
		{
			return default(HKOGKMHLCPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedColorId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedColorId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C800", Offset = "0x8B7B400", VA = "0x188B7C800", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C8A0", Offset = "0x8B7B4A0", VA = "0x188B7C8A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CIMNPCOKFON, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE507D0", Offset = "0xE4F3D0", VA = "0x180E507D0")]
		public GFJCEPIDMBH GLDNKJDIMCO()
		{
			return default(GFJCEPIDMBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A08350", Offset = "0x8A06F50", VA = "0x188A08350", Slot = "4")]
		public bool Equals(SerializedCombinationId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C910", Offset = "0x8B7B510", VA = "0x188B7C910", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedCombinationId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C9D0", Offset = "0x8B7B5D0", VA = "0x188B7C9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C9C0", Offset = "0x8B7B5C0", VA = "0x188B7C9C0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CIMNPCOKFON
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
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B7CB70", Offset = "0x8B7B770", VA = "0x188B7CB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x14354C0", Offset = "0x14340C0", VA = "0x1814354C0")]
		public SerializedCustomAvatarItemId(Guid FHNOHJCOOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public static SerializedCustomAvatarItemId HGGBDMLGOPC(Guid FHNOHJCOOKK)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CA40", Offset = "0x8B7B640", VA = "0x188B7CA40", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660")]
		public static bool CDGFDPOPEPC(SerializedCustomAvatarItemId ODBANBBPCIA, SerializedCustomAvatarItemId FMNHBACBGIN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CAE0", Offset = "0x8B7B6E0", VA = "0x188B7CAE0")]
		public static bool IECKAGJENEB(SerializedCustomAvatarItemId ODBANBBPCIA, SerializedCustomAvatarItemId FMNHBACBGIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CB00", Offset = "0x8B7B700", VA = "0x188B7CB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x8B7CBD0", Offset = "0x8B7B7D0", VA = "0x188B7CBD0")]
		public static SerializedEquipmentSkinId BNDJLLNPMGL()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public LBIEPCDDEBD GLDNKJDIMCO()
		{
			return default(LBIEPCDDEBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CC00", Offset = "0x8B7B800", VA = "0x188B7CC00", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CCA0", Offset = "0x8B7B8A0", VA = "0x188B7CCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public PFINHFPAAHI GLDNKJDIMCO()
		{
			return default(PFINHFPAAHI);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CD10", Offset = "0x8B7B910", VA = "0x188B7CD10", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CDB0", Offset = "0x8B7B9B0", VA = "0x188B7CDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public OLCDFLLEBBM GLDNKJDIMCO()
		{
			return default(OLCDFLLEBBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedFaceShapeId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CE20", Offset = "0x8B7BA20", VA = "0x188B7CE20", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CEC0", Offset = "0x8B7BAC0", VA = "0x188B7CEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610")]
		public KLCDEDJLAJO GLDNKJDIMCO()
		{
			return default(KLCDEDJLAJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660", Slot = "4")]
		public bool Equals(SerializedHairPatternId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedHairPatternId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CF30", Offset = "0x8B7BB30", VA = "0x188B7CF30", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C660", Offset = "0x8B7B260", VA = "0x188B7C660")]
		public static bool CDGFDPOPEPC(SerializedHairPatternId ODBANBBPCIA, SerializedHairPatternId FMNHBACBGIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7CFD0", Offset = "0x8B7BBD0", VA = "0x188B7CFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CIMNPCOKFON
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
		[Cpp2IlInjected.Address(RVA = "0x11E4610", Offset = "0x11E3210", VA = "0x1811E4610", Slot = "6")]
		public Guid OECFNIJJKJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A08350", Offset = "0x8A06F50", VA = "0x188A08350", Slot = "4")]
		public bool Equals(SerializedMaterialId IIOGPDPGOLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D040", Offset = "0x8B7BC40", VA = "0x188B7D040", Slot = "0")]
		public override bool Equals(object KOJLNGLNBMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EAC0", Offset = "0x7F6D6C0", VA = "0x187F6EAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E930", Offset = "0x7F6D530", VA = "0x187F6E930", Slot = "5")]
		public int CompareTo(SerializedMaterialId IIOGPDPGOLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D0F0", Offset = "0x8B7BCF0", VA = "0x188B7D0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HPGIOMBBMFD : NJGPDEOPNKH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HPGIOMBBMFD MFAGMJBMEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C7D0", Offset = "0x8B6B3D0", VA = "0x188B6C7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KAOCIBDKDIB<IBGOJPCJDBO> FAKKDNLCMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C8F0", Offset = "0x8B6B4F0", VA = "0x188B6C8F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KAOCIBDKDIB<LBIEPCDDEBD> MAEBHIEACHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C770", Offset = "0x8B6B370", VA = "0x188B6C770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KAOCIBDKDIB<KLCDEDJLAJO> CNLIHEMAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C950", Offset = "0x8B6B550", VA = "0x188B6C950", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KAOCIBDKDIB<GFJCEPIDMBH> EJIAJJMAHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C890", Offset = "0x8B6B490", VA = "0x188B6C890", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KAOCIBDKDIB<HKOGKMHLCPM> KAGNLCMFNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C830", Offset = "0x8B6B430", VA = "0x188B6C830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KAOCIBDKDIB<OLCDFLLEBBM> HEEGHCGLLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C710", Offset = "0x8B6B310", VA = "0x188B6C710", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KAOCIBDKDIB<ODODAOJKFLP> DCAMJBJGMEC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C6B0", Offset = "0x8B6B2B0", VA = "0x188B6C6B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KAOCIBDKDIB<PFINHFPAAHI> BLLIFACCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C9B0", Offset = "0x8B6B5B0", VA = "0x188B6C9B0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FINPHIJFIMH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AD40", Offset = "0x8B69940", VA = "0x188B6AD40")]
	public static Guid JIEIGGOOEHI(string ENKPJHKACGJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AC70", Offset = "0x8B69870", VA = "0x188B6AC70")]
	public static bool JFOODNGEHEM(string ENKPJHKACGJ, [Out] Guid FHNOHJCOOKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IFOKBAJFGBA : LLKDDNKGDHF<IBGOJPCJDBO>, BCJAMDAFOOB<IBGOJPCJDBO>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CA30", Offset = "0x8B6B630", VA = "0x188B6CA30", Slot = "4")]
	public IEnumerable<(IBGOJPCJDBO, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CA10", Offset = "0x8B6B610", VA = "0x188B6CA10", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public IBGOJPCJDBO NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(IBGOJPCJDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public IFOKBAJFGBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ANKLMBGCNPL : LLKDDNKGDHF<ODODAOJKFLP>, BCJAMDAFOOB<ODODAOJKFLP>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A810", Offset = "0x8B69410", VA = "0x188B6A810", Slot = "4")]
	public IEnumerable<(ODODAOJKFLP, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public ODODAOJKFLP NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(ODODAOJKFLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public ANKLMBGCNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MFBJMDJHHEO : LLKDDNKGDHF<HKOGKMHLCPM>, BCJAMDAFOOB<HKOGKMHLCPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B79910", Offset = "0x8B78510", VA = "0x188B79910", Slot = "4")]
	public IEnumerable<(HKOGKMHLCPM, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public HKOGKMHLCPM NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(HKOGKMHLCPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MFBJMDJHHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NIJPAGMOHEK : LLKDDNKGDHF<GFJCEPIDMBH>, BCJAMDAFOOB<GFJCEPIDMBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly BCJAMDAFOOB<AEMNJGHKJNB> HCMKLFFBMNI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public NIJPAGMOHEK(BCJAMDAFOOB<AEMNJGHKJNB> HCMKLFFBMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8A09AD0", Offset = "0x8A086D0", VA = "0x188A09AD0", Slot = "4")]
	public IEnumerable<(GFJCEPIDMBH, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BA10", Offset = "0x8B7A610", VA = "0x188B7BA10", Slot = "6")]
	public GFJCEPIDMBH NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(GFJCEPIDMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8B7B9D0", Offset = "0x8B7A5D0", VA = "0x188B7B9D0", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KEKLLPDECHN : LLKDDNKGDHF<LBIEPCDDEBD>, BCJAMDAFOOB<LBIEPCDDEBD>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B71680", Offset = "0x8B70280", VA = "0x188B71680", Slot = "4")]
	public IEnumerable<(LBIEPCDDEBD, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public LBIEPCDDEBD NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(LBIEPCDDEBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KEKLLPDECHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FOCKFHKCDPM : LLKDDNKGDHF<PFINHFPAAHI>, BCJAMDAFOOB<PFINHFPAAHI>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ADF0", Offset = "0x8B699F0", VA = "0x188B6ADF0", Slot = "4")]
	public IEnumerable<(PFINHFPAAHI, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public PFINHFPAAHI NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(PFINHFPAAHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public FOCKFHKCDPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PMFHMDOEMDP : LLKDDNKGDHF<OLCDFLLEBBM>, BCJAMDAFOOB<OLCDFLLEBBM>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C1A0", Offset = "0x8B7ADA0", VA = "0x188B7C1A0", Slot = "4")]
	public IEnumerable<(OLCDFLLEBBM, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public OLCDFLLEBBM NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(OLCDFLLEBBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PMFHMDOEMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KMKLFCAAEJM : LLKDDNKGDHF<KLCDEDJLAJO>, BCJAMDAFOOB<KLCDEDJLAJO>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8B79290", Offset = "0x8B77E90", VA = "0x188B79290", Slot = "4")]
	public IEnumerable<(KLCDEDJLAJO, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public KLCDEDJLAJO NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(KLCDEDJLAJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KMKLFCAAEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LLKDDNKGDHF<TModern> : BCJAMDAFOOB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JHHLIMCECCF();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ENJJGMJKCGE(string BPFHFOCIAPN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KOOGKAOKBAE : LLKDDNKGDHF<AEMNJGHKJNB>, BCJAMDAFOOB<AEMNJGHKJNB>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8ABEBF0", Offset = "0x8ABD7F0", VA = "0x188ABEBF0", Slot = "4")]
	public IEnumerable<(AEMNJGHKJNB, string)> JHHLIMCECCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "5")]
	public string ENJJGMJKCGE(string BPFHFOCIAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8B6ABB0", Offset = "0x8B697B0", VA = "0x188B6ABB0", Slot = "6")]
	public AEMNJGHKJNB NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return default(AEMNJGHKJNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public KOOGKAOKBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EFPKGDCAELB<TModern> : KAOCIBDKDIB<TModern>, BCJAMDAFOOB<TModern> where TModern : IEquatable<TModern>, CIMNPCOKFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> HNKIGDJMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IFCFODEPCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly LLKDDNKGDHF<TModern> ECDDANKCOLE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48D2EB0", Offset = "0x48D1AB0", VA = "0x1848D2EB0")]
	public EFPKGDCAELB(LLKDDNKGDHF<TModern> ECDDANKCOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48D0C20", Offset = "0x48CF820", VA = "0x1848D0C20", Slot = "5")]
	public TModern NLPCDIELCCG(string BPFHFOCIAPN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48D1A60", Offset = "0x48D0660", VA = "0x1848D1A60", Slot = "4")]
	public string OBFCIFLJIIH(TModern JDPHOFHOCFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PHCKDHEFNPD : NJGPDEOPNKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EFPKGDCAELB<IBGOJPCJDBO> HLLFDIKPADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EFPKGDCAELB<LBIEPCDDEBD> JPNPGFHCFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EFPKGDCAELB<KLCDEDJLAJO> DNLPELJOPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EFPKGDCAELB<AEMNJGHKJNB> HCMKLFFBMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EFPKGDCAELB<GFJCEPIDMBH> ECDCKDFHDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EFPKGDCAELB<HKOGKMHLCPM> KBKAMKJBADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EFPKGDCAELB<OLCDFLLEBBM> GJGEGDLLAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EFPKGDCAELB<ODODAOJKFLP> FPKCHABKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EFPKGDCAELB<PFINHFPAAHI> BOHMCNMOFEM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KAOCIBDKDIB<IBGOJPCJDBO> FAKKDNLCMED
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KAOCIBDKDIB<LBIEPCDDEBD> MAEBHIEACHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KAOCIBDKDIB<KLCDEDJLAJO> CNLIHEMAECL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public KAOCIBDKDIB<GFJCEPIDMBH> EJIAJJMAHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KAOCIBDKDIB<HKOGKMHLCPM> KAGNLCMFNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public KAOCIBDKDIB<OLCDFLLEBBM> HEEGHCGLLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public KAOCIBDKDIB<ODODAOJKFLP> DCAMJBJGMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA5B690", Offset = "0xA5A290", VA = "0x180A5B690", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KAOCIBDKDIB<PFINHFPAAHI> BLLIFACCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA5B670", Offset = "0xA5A270", VA = "0x180A5B670", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BC50", Offset = "0x8B7A850", VA = "0x188B7BC50")]
	[HHMPGEJNNFC.JKDCLEHGFFF.OKMFHHNNKLI]
	[UsedImplicitly]
	internal static void CFEHOJBIEEO(LGPCNHIHIDJ FDOOPNLIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8B7BCC0", Offset = "0x8B7A8C0", VA = "0x188B7BCC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PHCKDHEFNPD()
	{
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
