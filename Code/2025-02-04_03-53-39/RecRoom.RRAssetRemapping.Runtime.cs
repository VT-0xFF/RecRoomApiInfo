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
		[Cpp2IlInjected.Address(RVA = "0x7BABE10", Offset = "0x7BAAC10", VA = "0x187BABE10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MKINJPCNPDL : BPBNENKCCDK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex EKOOHAICDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PGNMPPJCBIM OFJNAFEEFDI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5ED0", Offset = "0x7BA4CD0", VA = "0x187BA5ED0")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	[UsedImplicitly]
	internal static void PIKBCINMJOC(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5660", Offset = "0x7BA4460", VA = "0x187BA5660")]
	[UsedImplicitly]
	internal static void DKIPAIFJAMD(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	[RecRoom.NoEngine.Common.Preserve]
	public MKINJPCNPDL([MHFJPMCEEAM(null)] PGNMPPJCBIM OFJNAFEEFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5B90", Offset = "0x7BA4990", VA = "0x187BA5B90", Slot = "4")]
	public string NPIKEPIONAB(INIBBLLDHHA HEILFBEALON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7BA56C0", Offset = "0x7BA44C0", VA = "0x187BA56C0", Slot = "5")]
	public INIBBLLDHHA FEIAPADJKML(string HEILFBEALON)
	{
		return default(INIBBLLDHHA);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public ENMEILKFHJI FEIAPADJKML()
		{
			return default(ENMEILKFHJI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB2D0", Offset = "0x7BAA0D0", VA = "0x187BAB2D0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB390", Offset = "0x7BAA190", VA = "0x187BAB390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public OCPOKLJHOAK FEIAPADJKML()
		{
			return default(OCPOKLJHOAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB400", Offset = "0x7BAA200", VA = "0x187BAB400", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB4A0", Offset = "0x7BAA2A0", VA = "0x187BAB4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public GLPNFIMFOMN FEIAPADJKML()
		{
			return default(GLPNFIMFOMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedColorId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedColorId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB510", Offset = "0x7BAA310", VA = "0x187BAB510", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB5B0", Offset = "0x7BAA3B0", VA = "0x187BAB5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, OOGFPHLFINK, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x180B21E50")]
		public FFOIEOOLOLI FEIAPADJKML()
		{
			return default(FFOIEOOLOLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A37670", Offset = "0x7A36470", VA = "0x187A37670", Slot = "4")]
		public bool Equals(SerializedCombinationId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB620", Offset = "0x7BAA420", VA = "0x187BAB620", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedCombinationId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB6E0", Offset = "0x7BAA4E0", VA = "0x187BAB6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB6D0", Offset = "0x7BAA4D0", VA = "0x187BAB6D0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
		public SerializedCustomAvatarItemId(Guid OGOMDMBFOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public static SerializedCustomAvatarItemId FEADALANPMH(Guid OGOMDMBFOMG)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB750", Offset = "0x7BAA550", VA = "0x187BAB750", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370")]
		public static bool BHDCHHANDIG(SerializedCustomAvatarItemId PMKFIDCMLAN, SerializedCustomAvatarItemId BFOIKIBAAFG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB7F0", Offset = "0x7BAA5F0", VA = "0x187BAB7F0")]
		public static bool HGMDHININLF(SerializedCustomAvatarItemId PMKFIDCMLAN, SerializedCustomAvatarItemId BFOIKIBAAFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB810", Offset = "0x7BAA610", VA = "0x187BAB810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB920", Offset = "0x7BAA720", VA = "0x187BAB920")]
		public static SerializedEquipmentSkinId PPKHAPDAFBG()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public POFHINLGMDJ FEIAPADJKML()
		{
			return default(POFHINLGMDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB880", Offset = "0x7BAA680", VA = "0x187BAB880", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB950", Offset = "0x7BAA750", VA = "0x187BAB950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public PNHNCIGEODL FEIAPADJKML()
		{
			return default(PNHNCIGEODL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB9C0", Offset = "0x7BAA7C0", VA = "0x187BAB9C0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BABA60", Offset = "0x7BAA860", VA = "0x187BABA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public LJLEIIMBNNB FEIAPADJKML()
		{
			return default(LJLEIIMBNNB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BABAD0", Offset = "0x7BAA8D0", VA = "0x187BABAD0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BABB70", Offset = "0x7BAA970", VA = "0x187BABB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public KEOJAAEHPII FEIAPADJKML()
		{
			return default(KEOJAAEHPII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370", Slot = "4")]
		public bool Equals(SerializedHairPatternId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BABBE0", Offset = "0x7BAA9E0", VA = "0x187BABBE0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB370", Offset = "0x7BAA170", VA = "0x187BAB370")]
		public static bool BHDCHHANDIG(SerializedHairPatternId PMKFIDCMLAN, SerializedHairPatternId BFOIKIBAAFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7BABC80", Offset = "0x7BAAA80", VA = "0x187BABC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, OOGFPHLFINK
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
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220", Slot = "6")]
		public Guid CLNKPNKCHAH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A37670", Offset = "0x7A36470", VA = "0x187A37670", Slot = "4")]
		public bool Equals(SerializedMaterialId LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BABCF0", Offset = "0x7BAAAF0", VA = "0x187BABCF0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7116D00", Offset = "0x7115B00", VA = "0x187116D00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7116B00", Offset = "0x7115900", VA = "0x187116B00", Slot = "5")]
		public int CompareTo(SerializedMaterialId LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BABDA0", Offset = "0x7BAABA0", VA = "0x187BABDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IEFKFOLGMML : PGNMPPJCBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IEFKFOLGMML GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1820", Offset = "0x7BA0620", VA = "0x187BA1820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public EKGHAOGKIJN<ENMEILKFHJI> LFOILEGIPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BA15E0", Offset = "0x7BA03E0", VA = "0x187BA15E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EKGHAOGKIJN<POFHINLGMDJ> GGKLPEIEABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1700", Offset = "0x7BA0500", VA = "0x187BA1700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EKGHAOGKIJN<KEOJAAEHPII> LGEBJCAINCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BA17C0", Offset = "0x7BA05C0", VA = "0x187BA17C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EKGHAOGKIJN<FFOIEOOLOLI> DNNJPPHBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1640", Offset = "0x7BA0440", VA = "0x187BA1640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EKGHAOGKIJN<GLPNFIMFOMN> HLDELGOPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA18E0", Offset = "0x7BA06E0", VA = "0x187BA18E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EKGHAOGKIJN<LJLEIIMBNNB> FJJEMGCCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1760", Offset = "0x7BA0560", VA = "0x187BA1760", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EKGHAOGKIJN<OCPOKLJHOAK> KJMDGIAOPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA1880", Offset = "0x7BA0680", VA = "0x187BA1880", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EKGHAOGKIJN<PNHNCIGEODL> OLFGOGEJLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA16A0", Offset = "0x7BA04A0", VA = "0x187BA16A0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DIFFBNJJEOG
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0870", Offset = "0x7B9F670", VA = "0x187BA0870")]
	public static Guid BCMOIKMCMJG(string LMBGNPJJCGA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0920", Offset = "0x7B9F720", VA = "0x187BA0920")]
	public static bool ECKNONAHJBB(string LMBGNPJJCGA, [Out] Guid OGOMDMBFOMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OCPCENIDJBN : AJHBMNENDCC<ENMEILKFHJI>, PAPJDAHNOLF<ENMEILKFHJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6680", Offset = "0x7BA5480", VA = "0x187BA6680", Slot = "4")]
	public IEnumerable<(ENMEILKFHJI, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6660", Offset = "0x7BA5460", VA = "0x187BA6660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public ENMEILKFHJI LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(ENMEILKFHJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OCPCENIDJBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MBIOJHPIPOL : AJHBMNENDCC<OCPOKLJHOAK>, PAPJDAHNOLF<OCPOKLJHOAK>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BA52C0", Offset = "0x7BA40C0", VA = "0x187BA52C0", Slot = "4")]
	public IEnumerable<(OCPOKLJHOAK, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public OCPOKLJHOAK LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(OCPOKLJHOAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public MBIOJHPIPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LPLBHBJEEHD : AJHBMNENDCC<GLPNFIMFOMN>, PAPJDAHNOLF<GLPNFIMFOMN>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3200", Offset = "0x7BA2000", VA = "0x187BA3200", Slot = "4")]
	public IEnumerable<(GLPNFIMFOMN, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public GLPNFIMFOMN LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(GLPNFIMFOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public LPLBHBJEEHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EKFLCCLOIPD : AJHBMNENDCC<FFOIEOOLOLI>, PAPJDAHNOLF<FFOIEOOLOLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PAPJDAHNOLF<NIBNJDFHAFI> LDGKADFLDCB;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public EKFLCCLOIPD(PAPJDAHNOLF<NIBNJDFHAFI> LDGKADFLDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A387E0", Offset = "0x7A375E0", VA = "0x187A387E0", Slot = "4")]
	public IEnumerable<(FFOIEOOLOLI, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0A30", Offset = "0x7B9F830", VA = "0x187BA0A30", Slot = "6")]
	public FFOIEOOLOLI LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(FFOIEOOLOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BA09F0", Offset = "0x7B9F7F0", VA = "0x187BA09F0", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CBNMBAHKAKC : AJHBMNENDCC<POFHINLGMDJ>, PAPJDAHNOLF<POFHINLGMDJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B98C60", Offset = "0x7B97A60", VA = "0x187B98C60", Slot = "4")]
	public IEnumerable<(POFHINLGMDJ, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public POFHINLGMDJ LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(POFHINLGMDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public CBNMBAHKAKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JDLLOBCMANF : AJHBMNENDCC<PNHNCIGEODL>, PAPJDAHNOLF<PNHNCIGEODL>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1940", Offset = "0x7BA0740", VA = "0x187BA1940", Slot = "4")]
	public IEnumerable<(PNHNCIGEODL, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public PNHNCIGEODL LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(PNHNCIGEODL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JDLLOBCMANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GNCOENHGBME : AJHBMNENDCC<LJLEIIMBNNB>, PAPJDAHNOLF<LJLEIIMBNNB>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BA0C70", Offset = "0x7B9FA70", VA = "0x187BA0C70", Slot = "4")]
	public IEnumerable<(LJLEIIMBNNB, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public LJLEIIMBNNB LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(LJLEIIMBNNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GNCOENHGBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OBGHEEGCKIA : AJHBMNENDCC<KEOJAAEHPII>, PAPJDAHNOLF<KEOJAAEHPII>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA5FE0", Offset = "0x7BA4DE0", VA = "0x187BA5FE0", Slot = "4")]
	public IEnumerable<(KEOJAAEHPII, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public KEOJAAEHPII LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(KEOJAAEHPII);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OBGHEEGCKIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AJHBMNENDCC<TModern> : PAPJDAHNOLF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HOMKAOJKPOH();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HAOBEPKNIHE(string JLHBBALLKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BDGFIEJFKAJ : AJHBMNENDCC<NIBNJDFHAFI>, PAPJDAHNOLF<NIBNJDFHAFI>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7AED900", Offset = "0x7AEC700", VA = "0x187AED900", Slot = "4")]
	public IEnumerable<(NIBNJDFHAFI, string)> HOMKAOJKPOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "5")]
	public string HAOBEPKNIHE(string JLHBBALLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7B98BA0", Offset = "0x7B979A0", VA = "0x187B98BA0", Slot = "6")]
	public NIBNJDFHAFI LABIFEENPEC(string JLHBBALLKEK)
	{
		return default(NIBNJDFHAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public BDGFIEJFKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PDFLHODMNPA<TModern> : EKGHAOGKIJN<TModern>, PAPJDAHNOLF<TModern> where TModern : IEquatable<TModern>, OOGFPHLFINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> MMOHOKHDHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> EONEJCFKBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly AJHBMNENDCC<TModern> MDAFKHAKPEN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F0AAB0", Offset = "0x4F098B0", VA = "0x184F0AAB0")]
	public PDFLHODMNPA(AJHBMNENDCC<TModern> MDAFKHAKPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F08030", Offset = "0x4F06E30", VA = "0x184F08030", Slot = "5")]
	public TModern LABIFEENPEC(string JLHBBALLKEK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F09620", Offset = "0x4F08420", VA = "0x184F09620", Slot = "4")]
	public string OKOAKBEJPNC(TModern OABJAHADAFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IEDBINMMCMB : PGNMPPJCBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private PDFLHODMNPA<ENMEILKFHJI> HHAGNGIIDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PDFLHODMNPA<POFHINLGMDJ> BPMPKHBGONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PDFLHODMNPA<KEOJAAEHPII> LJEDDDLGADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private PDFLHODMNPA<NIBNJDFHAFI> LDGKADFLDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PDFLHODMNPA<FFOIEOOLOLI> BDCDNACOAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PDFLHODMNPA<GLPNFIMFOMN> FEEOLDIFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private PDFLHODMNPA<LJLEIIMBNNB> POADIPLDELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private PDFLHODMNPA<OCPOKLJHOAK> OMHLAMDNDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private PDFLHODMNPA<PNHNCIGEODL> MBBEJNOEPCA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EKGHAOGKIJN<ENMEILKFHJI> LFOILEGIPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EKGHAOGKIJN<POFHINLGMDJ> GGKLPEIEABO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EKGHAOGKIJN<KEOJAAEHPII> LGEBJCAINCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EKGHAOGKIJN<FFOIEOOLOLI> DNNJPPHBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EKGHAOGKIJN<GLPNFIMFOMN> HLDELGOPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EKGHAOGKIJN<LJLEIIMBNNB> FJJEMGCCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EKGHAOGKIJN<OCPOKLJHOAK> KJMDGIAOPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EKGHAOGKIJN<PNHNCIGEODL> OLFGOGEJLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1090", Offset = "0x7B9FE90", VA = "0x187BA1090")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	[UsedImplicitly]
	internal static void OGLOOKLDEDN(IEPIHLKICIO JMPMFBCPFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BA1100", Offset = "0x7B9FF00", VA = "0x187BA1100")]
	[RecRoom.NoEngine.Common.Preserve]
	public IEDBINMMCMB()
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
