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
		[Cpp2IlInjected.Address(RVA = "0x81B2300", Offset = "0x81B1700", VA = "0x1881B2300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LGKFBEHPHAK : EDGPMMDNAON
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex ADNPMFPCPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OGNICHHMCBH KJKOHDDODHM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81B02D0", Offset = "0x81AF6D0", VA = "0x1881B02D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	[UsedImplicitly]
	internal static void KKOCPHMJODH(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81B0270", Offset = "0x81AF670", VA = "0x1881B0270")]
	[UsedImplicitly]
	internal static void GKFBLOAMCMJ(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LGKFBEHPHAK([GKAMHFFOHNI(null)] OGNICHHMCBH KJKOHDDODHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81B0340", Offset = "0x81AF740", VA = "0x1881B0340", Slot = "4")]
	public string LMGGAKIACNI(GPINPBJCOOH BEAPIEHNNIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81B0680", Offset = "0x81AFA80", VA = "0x1881B0680", Slot = "5")]
	public GPINPBJCOOH OJJOMCGFFJC(string BEAPIEHNNIB)
	{
		return default(GPINPBJCOOH);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, IECGHJIBGMC
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
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public JCFFMFFLEFL OJJOMCGFFJC()
		{
			return default(JCFFMFFLEFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedAvatarItemId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81B17C0", Offset = "0x81B0BC0", VA = "0x1881B17C0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81B1880", Offset = "0x81B0C80", VA = "0x1881B1880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, IECGHJIBGMC
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
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public GAIMANJLBKC OJJOMCGFFJC()
		{
			return default(GAIMANJLBKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedBodyShapeId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81B18F0", Offset = "0x81B0CF0", VA = "0x1881B18F0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81B1990", Offset = "0x81B0D90", VA = "0x1881B1990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, IECGHJIBGMC
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
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public EBBGFNLFKFI OJJOMCGFFJC()
		{
			return default(EBBGFNLFKFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedColorId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedColorId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81B1A00", Offset = "0x81B0E00", VA = "0x1881B1A00", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81B1AA0", Offset = "0x81B0EA0", VA = "0x1881B1AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, IECGHJIBGMC, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB9A2C0", Offset = "0xB996C0", VA = "0x180B9A2C0")]
		public HOBMLDPDGIJ OJJOMCGFFJC()
		{
			return default(HOBMLDPDGIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x803E020", Offset = "0x803D420", VA = "0x18803E020", Slot = "4")]
		public bool Equals(SerializedCombinationId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81B1B10", Offset = "0x81B0F10", VA = "0x1881B1B10", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedCombinationId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81B1BD0", Offset = "0x81B0FD0", VA = "0x1881B1BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81B1BC0", Offset = "0x81B0FC0", VA = "0x1881B1BC0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x110A3E0", Offset = "0x11097E0", VA = "0x18110A3E0")]
		public SerializedCustomAvatarItemId(Guid IIBHEJCKGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public static SerializedCustomAvatarItemId BIOJABIOOKH(Guid IIBHEJCKGGH)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81B1C40", Offset = "0x81B1040", VA = "0x1881B1C40", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860")]
		public static bool IGEKHAEJGKN(SerializedCustomAvatarItemId AJLPPHLPDOI, SerializedCustomAvatarItemId PODDNHBLFOD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81B1CE0", Offset = "0x81B10E0", VA = "0x1881B1CE0")]
		public static bool PIPJPONNKNK(SerializedCustomAvatarItemId AJLPPHLPDOI, SerializedCustomAvatarItemId PODDNHBLFOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81B1D00", Offset = "0x81B1100", VA = "0x1881B1D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81B1E10", Offset = "0x81B1210", VA = "0x1881B1E10")]
		public static SerializedEquipmentSkinId FHJHNMMLFMI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public FMJEOPIKNGA OJJOMCGFFJC()
		{
			return default(FMJEOPIKNGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81B1D70", Offset = "0x81B1170", VA = "0x1881B1D70", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81B1E40", Offset = "0x81B1240", VA = "0x1881B1E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public DFJCNMKOGLJ OJJOMCGFFJC()
		{
			return default(DFJCNMKOGLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81B1EB0", Offset = "0x81B12B0", VA = "0x1881B1EB0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81B1F50", Offset = "0x81B1350", VA = "0x1881B1F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public BOKCMAEDAAE OJJOMCGFFJC()
		{
			return default(BOKCMAEDAAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedFaceShapeId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81B1FC0", Offset = "0x81B13C0", VA = "0x1881B1FC0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81B2060", Offset = "0x81B1460", VA = "0x1881B2060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0")]
		public JMEFNJKDANM OJJOMCGFFJC()
		{
			return default(JMEFNJKDANM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860", Slot = "4")]
		public bool Equals(SerializedHairPatternId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedHairPatternId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81B20D0", Offset = "0x81B14D0", VA = "0x1881B20D0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81B1860", Offset = "0x81B0C60", VA = "0x1881B1860")]
		public static bool IGEKHAEJGKN(SerializedHairPatternId AJLPPHLPDOI, SerializedHairPatternId PODDNHBLFOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81B2170", Offset = "0x81B1570", VA = "0x1881B2170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, IECGHJIBGMC
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

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x110A3D0", Offset = "0x11097D0", VA = "0x18110A3D0", Slot = "6")]
		public Guid JAGOECLBNEN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x803E020", Offset = "0x803D420", VA = "0x18803E020", Slot = "4")]
		public bool Equals(SerializedMaterialId JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81B21E0", Offset = "0x81B15E0", VA = "0x1881B21E0", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x769E620", Offset = "0x769DA20", VA = "0x18769E620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x769E420", Offset = "0x769D820", VA = "0x18769E420", Slot = "5")]
		public int CompareTo(SerializedMaterialId JAPIEEBOJEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81B2290", Offset = "0x81B1690", VA = "0x1881B2290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LGHMNLCDKKD : OGNICHHMCBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LGHMNLCDKKD DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81B01B0", Offset = "0x81AF5B0", VA = "0x1881B01B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KGFOGAIBEKG<JCFFMFFLEFL> KJKCMHFJJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81AFF10", Offset = "0x81AF310", VA = "0x1881AFF10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KGFOGAIBEKG<FMJEOPIKNGA> DNKKLHJHBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81B0150", Offset = "0x81AF550", VA = "0x1881B0150", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KGFOGAIBEKG<JMEFNJKDANM> KECPCFEJOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81B0030", Offset = "0x81AF430", VA = "0x1881B0030", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KGFOGAIBEKG<HOBMLDPDGIJ> BAKDCPLMBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81AFFD0", Offset = "0x81AF3D0", VA = "0x1881AFFD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KGFOGAIBEKG<EBBGFNLFKFI> NPKBBENFNKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81AFF70", Offset = "0x81AF370", VA = "0x1881AFF70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KGFOGAIBEKG<BOKCMAEDAAE> GCPENFADKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81B0090", Offset = "0x81AF490", VA = "0x1881B0090", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KGFOGAIBEKG<GAIMANJLBKC> AIIKICJIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81B00F0", Offset = "0x81AF4F0", VA = "0x1881B00F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KGFOGAIBEKG<DFJCNMKOGLJ> GNFPPHPIFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81B0210", Offset = "0x81AF610", VA = "0x1881B0210", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CCJBHIHCLDJ
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x819F160", Offset = "0x819E560", VA = "0x18819F160")]
	public static Guid NFLPCKPEBON(string JOEBEPEDNNI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x819F090", Offset = "0x819E490", VA = "0x18819F090")]
	public static bool CBABJAIFBNF(string JOEBEPEDNNI, [Out] Guid IIBHEJCKGGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HCHANGFKIEF : EINPJPLLKMI<JCFFMFFLEFL>, IFOGMLJFEBN<JCFFMFFLEFL>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x81A7500", Offset = "0x81A6900", VA = "0x1881A7500", Slot = "4")]
	public IEnumerable<(JCFFMFFLEFL, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x81AC150", Offset = "0x81AB550", VA = "0x1881AC150", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public JCFFMFFLEFL JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(JCFFMFFLEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public HCHANGFKIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DKAPGPLGBIM : EINPJPLLKMI<GAIMANJLBKC>, IFOGMLJFEBN<GAIMANJLBKC>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x81A6EE0", Offset = "0x81A62E0", VA = "0x1881A6EE0", Slot = "4")]
	public IEnumerable<(GAIMANJLBKC, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public GAIMANJLBKC JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(GAIMANJLBKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public DKAPGPLGBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JHPGHFLMCJN : EINPJPLLKMI<EBBGFNLFKFI>, IFOGMLJFEBN<EBBGFNLFKFI>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81AC590", Offset = "0x81AB990", VA = "0x1881AC590", Slot = "4")]
	public IEnumerable<(EBBGFNLFKFI, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public EBBGFNLFKFI JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(EBBGFNLFKFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JHPGHFLMCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GMBKNACFDIF : EINPJPLLKMI<HOBMLDPDGIJ>, IFOGMLJFEBN<HOBMLDPDGIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IFOGMLJFEBN<JIGFKODJCDD> PPFOEFEBMEI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public GMBKNACFDIF(IFOGMLJFEBN<JIGFKODJCDD> PPFOEFEBMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x803ECD0", Offset = "0x803E0D0", VA = "0x18803ECD0", Slot = "4")]
	public IEnumerable<(HOBMLDPDGIJ, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x81A72C0", Offset = "0x81A66C0", VA = "0x1881A72C0", Slot = "6")]
	public HOBMLDPDGIJ JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(HOBMLDPDGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x81A7280", Offset = "0x81A6680", VA = "0x1881A7280", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CLGHIICCCLL : EINPJPLLKMI<FMJEOPIKNGA>, IFOGMLJFEBN<FMJEOPIKNGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x819F210", Offset = "0x819E610", VA = "0x18819F210", Slot = "4")]
	public IEnumerable<(FMJEOPIKNGA, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public FMJEOPIKNGA JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(FMJEOPIKNGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public CLGHIICCCLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LFIOFGGOFMD : EINPJPLLKMI<DFJCNMKOGLJ>, IFOGMLJFEBN<DFJCNMKOGLJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x81AE650", Offset = "0x81ADA50", VA = "0x1881AE650", Slot = "4")]
	public IEnumerable<(DFJCNMKOGLJ, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public DFJCNMKOGLJ JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(DFJCNMKOGLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LFIOFGGOFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JEPOACEDAPM : EINPJPLLKMI<BOKCMAEDAAE>, IFOGMLJFEBN<BOKCMAEDAAE>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x81AC170", Offset = "0x81AB570", VA = "0x1881AC170", Slot = "4")]
	public IEnumerable<(BOKCMAEDAAE, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public BOKCMAEDAAE JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(BOKCMAEDAAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public JEPOACEDAPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MPEGBFBBDLD : EINPJPLLKMI<JMEFNJKDANM>, IFOGMLJFEBN<JMEFNJKDANM>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x81B0BF0", Offset = "0x81AFFF0", VA = "0x1881B0BF0", Slot = "4")]
	public IEnumerable<(JMEFNJKDANM, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public JMEFNJKDANM JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(JMEFNJKDANM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MPEGBFBBDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EINPJPLLKMI<TModern> : IFOGMLJFEBN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HLHLEEDHNAJ();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IJDOMKFAIAN(string IBOAKANLICJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EAOFNFLFOHF : EINPJPLLKMI<JIGFKODJCDD>, IFOGMLJFEBN<JIGFKODJCDD>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x80F3DF0", Offset = "0x80F31F0", VA = "0x1880F3DF0", Slot = "4")]
	public IEnumerable<(JIGFKODJCDD, string)> HLHLEEDHNAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD54400", Offset = "0xD53800", VA = "0x180D54400", Slot = "5")]
	public string IJDOMKFAIAN(string IBOAKANLICJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x81A6E20", Offset = "0x81A6220", VA = "0x1881A6E20", Slot = "6")]
	public JIGFKODJCDD JOIJGECIGKC(string IBOAKANLICJ)
	{
		return default(JIGFKODJCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public EAOFNFLFOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NKPGJGMMDLD<TModern> : KGFOGAIBEKG<TModern>, IFOGMLJFEBN<TModern> where TModern : IEquatable<TModern>, IECGHJIBGMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> FNOMLKIBIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> LKNEADBICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EINPJPLLKMI<TModern> KPHGBHLHJMG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x502E570", Offset = "0x502D970", VA = "0x18502E570")]
	public NKPGJGMMDLD(EINPJPLLKMI<TModern> KPHGBHLHJMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x502DFA0", Offset = "0x502D3A0", VA = "0x18502DFA0", Slot = "5")]
	public TModern JOIJGECIGKC(string IBOAKANLICJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x502C6A0", Offset = "0x502BAA0", VA = "0x18502C6A0", Slot = "4")]
	public string GKFBKCNOPCP(TModern CHELGEBKCJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OJCNCJFNNNB : OGNICHHMCBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NKPGJGMMDLD<JCFFMFFLEFL> ODDDEDCIJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NKPGJGMMDLD<FMJEOPIKNGA> NFNCBFINCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NKPGJGMMDLD<JMEFNJKDANM> LCOPBNMBONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NKPGJGMMDLD<JIGFKODJCDD> PPFOEFEBMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NKPGJGMMDLD<HOBMLDPDGIJ> BJKECPBOLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NKPGJGMMDLD<EBBGFNLFKFI> LFIJJKMEEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NKPGJGMMDLD<BOKCMAEDAAE> BHLKFABGDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NKPGJGMMDLD<GAIMANJLBKC> DPPKCDFFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NKPGJGMMDLD<DFJCNMKOGLJ> KINIDMMKOBG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KGFOGAIBEKG<JCFFMFFLEFL> KJKCMHFJJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KGFOGAIBEKG<FMJEOPIKNGA> DNKKLHJHBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KGFOGAIBEKG<JMEFNJKDANM> KECPCFEJOID
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KGFOGAIBEKG<HOBMLDPDGIJ> BAKDCPLMBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public KGFOGAIBEKG<EBBGFNLFKFI> NPKBBENFNKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KGFOGAIBEKG<BOKCMAEDAAE> GCPENFADKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public KGFOGAIBEKG<GAIMANJLBKC> AIIKICJIBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public KGFOGAIBEKG<DFJCNMKOGLJ> GNFPPHPIFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x81B1270", Offset = "0x81B0670", VA = "0x1881B1270")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	[UsedImplicitly]
	internal static void MIDKFNLDDFI(NPIEGGOELNH FLKEBBNIBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x81B12E0", Offset = "0x81B06E0", VA = "0x1881B12E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OJCNCJFNNNB()
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
