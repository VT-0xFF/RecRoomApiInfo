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
		[Cpp2IlInjected.Address(RVA = "0x8D841E0", Offset = "0x8D82BE0", VA = "0x188D841E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BPLNKGBDGCJ : AGIHLMKDAGP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex AJMOLMPHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GIAOBDOCLCJ HKJLNLEACIE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8D719A0", Offset = "0x8D703A0", VA = "0x188D719A0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	[UsedImplicitly]
	internal static void CPNCCEEHJEL(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8D71EE0", Offset = "0x8D708E0", VA = "0x188D71EE0")]
	[UsedImplicitly]
	internal static void PFENGIFBGHD(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	[RecRoom.NoEngine.Common.Preserve]
	public BPLNKGBDGCJ([LNLOHEINMEO(null)] GIAOBDOCLCJ HKJLNLEACIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8D71660", Offset = "0x8D70060", VA = "0x188D71660", Slot = "4")]
	public string AGNKEKDJGCC(ANBOJIKIHHJ GMLILPJAKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D71A10", Offset = "0x8D70410", VA = "0x188D71A10", Slot = "5")]
	public ANBOJIKIHHJ JBBKNKCPLNK(string GMLILPJAKBM)
	{
		return default(ANBOJIKIHHJ);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public BKDCIKGEGPK JBBKNKCPLNK()
		{
			return default(BKDCIKGEGPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D83650", Offset = "0x8D82050", VA = "0x188D83650", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D83710", Offset = "0x8D82110", VA = "0x188D83710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public DPLOPFFMDPM JBBKNKCPLNK()
		{
			return default(DPLOPFFMDPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D83780", Offset = "0x8D82180", VA = "0x188D83780", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D83820", Offset = "0x8D82220", VA = "0x188D83820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public KOELLOADCHB JBBKNKCPLNK()
		{
			return default(KOELLOADCHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedColorId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedColorId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D83890", Offset = "0x8D82290", VA = "0x188D83890", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D83930", Offset = "0x8D82330", VA = "0x188D83930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, GHCCIAMMCFG, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
		public NOKNCAGJAEE JBBKNKCPLNK()
		{
			return default(NOKNCAGJAEE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C109A0", Offset = "0x8C0F3A0", VA = "0x188C109A0", Slot = "4")]
		public bool Equals(SerializedCombinationId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D839A0", Offset = "0x8D823A0", VA = "0x188D839A0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedCombinationId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D83A60", Offset = "0x8D82460", VA = "0x188D83A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D83A50", Offset = "0x8D82450", VA = "0x188D83A50", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, GHCCIAMMCFG
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
			[Cpp2IlInjected.Address(RVA = "0x8D83C00", Offset = "0x8D82600", VA = "0x188D83C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1486E20", Offset = "0x1485820", VA = "0x181486E20")]
		public SerializedCustomAvatarItemId(Guid DNLDANFOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public static SerializedCustomAvatarItemId FBAGBGBDGGN(Guid DNLDANFOOJK)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D83AF0", Offset = "0x8D824F0", VA = "0x188D83AF0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0")]
		public static bool JJNADAGGMDE(SerializedCustomAvatarItemId OKDCNKNEMHO, SerializedCustomAvatarItemId AAJFLFEAFBA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D83AD0", Offset = "0x8D824D0", VA = "0x188D83AD0")]
		public static bool CNNLEBNJPBE(SerializedCustomAvatarItemId OKDCNKNEMHO, SerializedCustomAvatarItemId AAJFLFEAFBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D83B90", Offset = "0x8D82590", VA = "0x188D83B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x8D83D00", Offset = "0x8D82700", VA = "0x188D83D00")]
		public static SerializedEquipmentSkinId PJEIDHCDONI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public COIIDLGAIBC JBBKNKCPLNK()
		{
			return default(COIIDLGAIBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D83C60", Offset = "0x8D82660", VA = "0x188D83C60", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D83D30", Offset = "0x8D82730", VA = "0x188D83D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public ALMOMBBBFFN JBBKNKCPLNK()
		{
			return default(ALMOMBBBFFN);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D83DA0", Offset = "0x8D827A0", VA = "0x188D83DA0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D83E40", Offset = "0x8D82840", VA = "0x188D83E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public LHEHHAEIJGB JBBKNKCPLNK()
		{
			return default(LHEHHAEIJGB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D83EB0", Offset = "0x8D828B0", VA = "0x188D83EB0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D83F50", Offset = "0x8D82950", VA = "0x188D83F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0")]
		public MGBLGNGEFKP JBBKNKCPLNK()
		{
			return default(MGBLGNGEFKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0", Slot = "4")]
		public bool Equals(SerializedHairPatternId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D83FC0", Offset = "0x8D829C0", VA = "0x188D83FC0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D836F0", Offset = "0x8D820F0", VA = "0x188D836F0")]
		public static bool JJNADAGGMDE(SerializedHairPatternId OKDCNKNEMHO, SerializedHairPatternId AAJFLFEAFBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D84060", Offset = "0x8D82A60", VA = "0x188D84060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, GHCCIAMMCFG
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
		[Cpp2IlInjected.Address(RVA = "0x125C2A0", Offset = "0x125ACA0", VA = "0x18125C2A0", Slot = "6")]
		public Guid CHPKHLLGHNH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8C109A0", Offset = "0x8C0F3A0", VA = "0x188C109A0", Slot = "4")]
		public bool Equals(SerializedMaterialId EFNHKCDKOGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D840D0", Offset = "0x8D82AD0", VA = "0x188D840D0", Slot = "0")]
		public override bool Equals(object CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8173930", Offset = "0x8172330", VA = "0x188173930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81737A0", Offset = "0x81721A0", VA = "0x1881737A0", Slot = "5")]
		public int CompareTo(SerializedMaterialId EFNHKCDKOGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D84170", Offset = "0x8D82B70", VA = "0x188D84170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MDMPMJNFOID : GIAOBDOCLCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MDMPMJNFOID NDAIDGNOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D83350", Offset = "0x8D81D50", VA = "0x188D83350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EHFIBAOOOCP<BKDCIKGEGPK> GCNOPDBBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D83230", Offset = "0x8D81C30", VA = "0x188D83230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EHFIBAOOOCP<COIIDLGAIBC> ICGICLFOPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D833B0", Offset = "0x8D81DB0", VA = "0x188D833B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EHFIBAOOOCP<MGBLGNGEFKP> OHINHMMBMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D83290", Offset = "0x8D81C90", VA = "0x188D83290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EHFIBAOOOCP<NOKNCAGJAEE> IONDHJFABNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D83170", Offset = "0x8D81B70", VA = "0x188D83170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EHFIBAOOOCP<KOELLOADCHB> CONIMAMAJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D832F0", Offset = "0x8D81CF0", VA = "0x188D832F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EHFIBAOOOCP<LHEHHAEIJGB> GEHNEKGLGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D831D0", Offset = "0x8D81BD0", VA = "0x188D831D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EHFIBAOOOCP<DPLOPFFMDPM> IKCDPDEBFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D83410", Offset = "0x8D81E10", VA = "0x188D83410", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EHFIBAOOOCP<ALMOMBBBFFN> LJPBBMDHEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D83470", Offset = "0x8D81E70", VA = "0x188D83470", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NPKLACGLEHA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D834D0", Offset = "0x8D81ED0", VA = "0x188D834D0")]
	public static Guid BJMNPIEFHPN(string HKGGHJHGONF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D83580", Offset = "0x8D81F80", VA = "0x188D83580")]
	public static bool OJACLNGLEHK(string HKGGHJHGONF, [Out] Guid DNLDANFOOJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HPEGNDGOLDO : KCGBCFDBCLG<BKDCIKGEGPK>, DGAIFNDDGFO<BKDCIKGEGPK>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8D7E520", Offset = "0x8D7CF20", VA = "0x188D7E520", Slot = "4")]
	public IEnumerable<(BKDCIKGEGPK, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D7E500", Offset = "0x8D7CF00", VA = "0x188D7E500", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public BKDCIKGEGPK FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(BKDCIKGEGPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HPEGNDGOLDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EJGGAOMFHPE : KCGBCFDBCLG<DPLOPFFMDPM>, DGAIFNDDGFO<DPLOPFFMDPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D73B20", Offset = "0x8D72520", VA = "0x188D73B20", Slot = "4")]
	public IEnumerable<(DPLOPFFMDPM, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public DPLOPFFMDPM FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(DPLOPFFMDPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public EJGGAOMFHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GBAEHLFGHDI : KCGBCFDBCLG<KOELLOADCHB>, DGAIFNDDGFO<KOELLOADCHB>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8D74410", Offset = "0x8D72E10", VA = "0x188D74410", Slot = "4")]
	public IEnumerable<(KOELLOADCHB, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public KOELLOADCHB FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(KOELLOADCHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GBAEHLFGHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DNNGPIJLFDN : KCGBCFDBCLG<NOKNCAGJAEE>, DGAIFNDDGFO<NOKNCAGJAEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DGAIFNDDGFO<APEGJNHJPLN> MJBHFPLDCOO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public DNNGPIJLFDN(DGAIFNDDGFO<APEGJNHJPLN> MJBHFPLDCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8C10B60", Offset = "0x8C0F560", VA = "0x188C10B60", Slot = "4")]
	public IEnumerable<(NOKNCAGJAEE, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D738A0", Offset = "0x8D722A0", VA = "0x188D738A0", Slot = "6")]
	public NOKNCAGJAEE FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(NOKNCAGJAEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8D73AE0", Offset = "0x8D724E0", VA = "0x188D73AE0", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HGACNBBNNPA : KCGBCFDBCLG<COIIDLGAIBC>, DGAIFNDDGFO<COIIDLGAIBC>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D768F0", Offset = "0x8D752F0", VA = "0x188D768F0", Slot = "4")]
	public IEnumerable<(COIIDLGAIBC, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public COIIDLGAIBC FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(COIIDLGAIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HGACNBBNNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CHEPOEKGICK : KCGBCFDBCLG<ALMOMBBBFFN>, DGAIFNDDGFO<ALMOMBBBFFN>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8D71FE0", Offset = "0x8D709E0", VA = "0x188D71FE0", Slot = "4")]
	public IEnumerable<(ALMOMBBBFFN, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public ALMOMBBBFFN FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(ALMOMBBBFFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CHEPOEKGICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GCKMFMLKCAF : KCGBCFDBCLG<LHEHHAEIJGB>, DGAIFNDDGFO<LHEHHAEIJGB>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8D764D0", Offset = "0x8D74ED0", VA = "0x188D764D0", Slot = "4")]
	public IEnumerable<(LHEHHAEIJGB, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public LHEHHAEIJGB FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(LHEHHAEIJGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public GCKMFMLKCAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BEAEGDOHGAB : KCGBCFDBCLG<MGBLGNGEFKP>, DGAIFNDDGFO<MGBLGNGEFKP>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8D70FE0", Offset = "0x8D6F9E0", VA = "0x188D70FE0", Slot = "4")]
	public IEnumerable<(MGBLGNGEFKP, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public MGBLGNGEFKP FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(MGBLGNGEFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public BEAEGDOHGAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KCGBCFDBCLG<TModern> : DGAIFNDDGFO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> PALPHFHGPOC();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FMFGBGDIJIC(string BHBCINJBLFP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IPKADBNMDON : KCGBCFDBCLG<APEGJNHJPLN>, DGAIFNDDGFO<APEGJNHJPLN>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8CC5C80", Offset = "0x8CC4680", VA = "0x188CC5C80", Slot = "4")]
	public IEnumerable<(APEGJNHJPLN, string)> PALPHFHGPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE20", Offset = "0xAED820", VA = "0x180AEEE20", Slot = "5")]
	public string FMFGBGDIJIC(string BHBCINJBLFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8D70F20", Offset = "0x8D6F920", VA = "0x188D70F20", Slot = "6")]
	public APEGJNHJPLN FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return default(APEGJNHJPLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IPKADBNMDON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GPCBIDCHHKA<TModern> : EHFIBAOOOCP<TModern>, DGAIFNDDGFO<TModern> where TModern : IEquatable<TModern>, GHCCIAMMCFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> KCCLBJAKGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DMALOCIJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KCGBCFDBCLG<TModern> ADODDBGIHAA;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4FBF590", Offset = "0x4FBDF90", VA = "0x184FBF590")]
	public GPCBIDCHHKA(KCGBCFDBCLG<TModern> ADODDBGIHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4FBCF80", Offset = "0x4FBB980", VA = "0x184FBCF80", Slot = "5")]
	public TModern FDPOFCGJKKO(string BHBCINJBLFP)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4FBE590", Offset = "0x4FBCF90", VA = "0x184FBE590", Slot = "4")]
	public string HJIMCCPJPHB(TModern PPGBPGHDKGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FDHNJIFOCII : GIAOBDOCLCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private GPCBIDCHHKA<BKDCIKGEGPK> GMCEGIPCFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GPCBIDCHHKA<COIIDLGAIBC> ADLMGMNNIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GPCBIDCHHKA<MGBLGNGEFKP> EEPLHMHMDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private GPCBIDCHHKA<APEGJNHJPLN> MJBHFPLDCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GPCBIDCHHKA<NOKNCAGJAEE> MJIGIGKPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private GPCBIDCHHKA<KOELLOADCHB> DBPEOHBHPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private GPCBIDCHHKA<LHEHHAEIJGB> BNAOJOGBJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GPCBIDCHHKA<DPLOPFFMDPM> GLEPKLALPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GPCBIDCHHKA<ALMOMBBBFFN> OCGFHNLFEOI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EHFIBAOOOCP<BKDCIKGEGPK> GCNOPDBBPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EHFIBAOOOCP<COIIDLGAIBC> ICGICLFOPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EHFIBAOOOCP<MGBLGNGEFKP> OHINHMMBMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EHFIBAOOOCP<NOKNCAGJAEE> IONDHJFABNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EHFIBAOOOCP<KOELLOADCHB> CONIMAMAJMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EHFIBAOOOCP<LHEHHAEIJGB> GEHNEKGLGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EHFIBAOOOCP<DPLOPFFMDPM> IKCDPDEBFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EHFIBAOOOCP<ALMOMBBBFFN> LJPBBMDHEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82C10", VA = "0x180A84210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8D73EC0", Offset = "0x8D728C0", VA = "0x188D73EC0")]
	[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
	[UsedImplicitly]
	internal static void JDFNEBKBOEL(CFAMNNNCHJA GEPFIGLFPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8D73F30", Offset = "0x8D72930", VA = "0x188D73F30")]
	[RecRoom.NoEngine.Common.Preserve]
	public FDHNJIFOCII()
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
