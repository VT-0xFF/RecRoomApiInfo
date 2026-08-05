using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7449F20", Offset = "0x7448920", VA = "0x187449F20", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PJEOGBOCACF : FOOFKICGDAD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NCGALGLOHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BDGAMALNPBH HMALHDFPOKM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74492F0", Offset = "0x7447CF0", VA = "0x1874492F0")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void MEDHEEHHIJF(APIKLLPBEEI PFCFNGPPMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7448F50", Offset = "0x7447950", VA = "0x187448F50")]
	[UsedImplicitly]
	internal static void JPIKLHADLJH(APIKLLPBEEI PFCFNGPPMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	[RecRoom.NoEngine.Common.Preserve]
	public PJEOGBOCACF([CNNDHKODGDP(null)] BDGAMALNPBH HMALHDFPOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7448FB0", Offset = "0x74479B0", VA = "0x187448FB0", Slot = "4")]
	public string LKLOMDOAOHF(AHDCONECEDL DKDIADEJLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7448A80", Offset = "0x7447480", VA = "0x187448A80", Slot = "5")]
	public AHDCONECEDL ILDFGHALABA(string DKDIADEJLHP)
	{
		return default(AHDCONECEDL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public SerializedAvatarItemId(PPKIGHIHCHJ KFBALBFDDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public PPKIGHIHCHJ ILDFGHALABA()
		{
			return default(PPKIGHIHCHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedAvatarItemId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74493F0", Offset = "0x7447DF0", VA = "0x1874493F0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74494B0", Offset = "0x7447EB0", VA = "0x1874494B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NAOFDPDFIEP
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

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public IIPKPLGIMIE ILDFGHALABA()
		{
			return default(IIPKPLGIMIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedBodyShapeId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7449520", Offset = "0x7447F20", VA = "0x187449520", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74495C0", Offset = "0x7447FC0", VA = "0x1874495C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NAOFDPDFIEP
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

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public NBKDMALLDCE ILDFGHALABA()
		{
			return default(NBKDMALLDCE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedColorId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedColorId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7449630", Offset = "0x7448030", VA = "0x187449630", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74496D0", Offset = "0x74480D0", VA = "0x1874496D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NAOFDPDFIEP, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
		public NLPKIMNBAMP ILDFGHALABA()
		{
			return default(NLPKIMNBAMP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7449870", Offset = "0x7448270", VA = "0x187449870")]
		public SerializedCombinationId(NLPKIMNBAMP IEECBMNALJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72D84B0", Offset = "0x72D6EB0", VA = "0x1872D84B0", Slot = "4")]
		public bool Equals(SerializedCombinationId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7449740", Offset = "0x7448140", VA = "0x187449740", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedCombinationId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7449800", Offset = "0x7448200", VA = "0x187449800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74497F0", Offset = "0x74481F0", VA = "0x1874497F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NAOFDPDFIEP
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public SerializedCustomAvatarItemId(Guid HLIKNGLOMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7449880", Offset = "0x7448280", VA = "0x187449880", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490")]
		public static bool LBPOCMFLOBH(SerializedCustomAvatarItemId JHAFNHPHBBL, SerializedCustomAvatarItemId GONHEFIHLCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7449920", Offset = "0x7448320", VA = "0x187449920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0x7449A30", Offset = "0x7448430", VA = "0x187449A30")]
		public static SerializedEquipmentSkinId GMAABJEMBCN()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public KKJPNJJJKLB ILDFGHALABA()
		{
			return default(KKJPNJJJKLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7449990", Offset = "0x7448390", VA = "0x187449990", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7449A60", Offset = "0x7448460", VA = "0x187449A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public IIEBDBDHLOD ILDFGHALABA()
		{
			return default(IIEBDBDHLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7449AD0", Offset = "0x74484D0", VA = "0x187449AD0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7449B70", Offset = "0x7448570", VA = "0x187449B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public IFKGKDFJHGN ILDFGHALABA()
		{
			return default(IFKGKDFJHGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedFaceShapeId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7449BE0", Offset = "0x74485E0", VA = "0x187449BE0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7449C80", Offset = "0x7448680", VA = "0x187449C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public JGBKIPHAEBD ILDFGHALABA()
		{
			return default(JGBKIPHAEBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490", Slot = "4")]
		public bool Equals(SerializedHairPatternId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedHairPatternId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7449CF0", Offset = "0x74486F0", VA = "0x187449CF0", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7449490", Offset = "0x7447E90", VA = "0x187449490")]
		public static bool LBPOCMFLOBH(SerializedHairPatternId JHAFNHPHBBL, SerializedHairPatternId GONHEFIHLCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7449D90", Offset = "0x7448790", VA = "0x187449D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NAOFDPDFIEP
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
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public SerializedMaterialId(EKIJHGABHCH KFBALBFDDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0", Slot = "6")]
		public Guid HHLJJMOJHKE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72D84B0", Offset = "0x72D6EB0", VA = "0x1872D84B0", Slot = "4")]
		public bool Equals(SerializedMaterialId AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7449E00", Offset = "0x7448800", VA = "0x187449E00", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC22E20", Offset = "0xC21820", VA = "0x180C22E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC22C90", Offset = "0xC21690", VA = "0x180C22C90", Slot = "5")]
		public int CompareTo(SerializedMaterialId AIPFCMFLDKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7449EB0", Offset = "0x74488B0", VA = "0x187449EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ENEENHFDGOC : BDGAMALNPBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ENEENHFDGOC LPENGNKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7437A20", Offset = "0x7436420", VA = "0x187437A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PNKMDIEINFE<PPKIGHIHCHJ> POCKDHCIJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7437A80", Offset = "0x7436480", VA = "0x187437A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PNKMDIEINFE<KKJPNJJJKLB> OPJOCOMCOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74379C0", Offset = "0x74363C0", VA = "0x1874379C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PNKMDIEINFE<JGBKIPHAEBD> CMAONIKDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7437B40", Offset = "0x7436540", VA = "0x187437B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PNKMDIEINFE<NLPKIMNBAMP> IFCJAGJDHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7437960", Offset = "0x7436360", VA = "0x187437960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PNKMDIEINFE<NBKDMALLDCE> ANPNHIIHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7437BA0", Offset = "0x74365A0", VA = "0x187437BA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PNKMDIEINFE<IFKGKDFJHGN> MKJJLHEDPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7437AE0", Offset = "0x74364E0", VA = "0x187437AE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PNKMDIEINFE<IIPKPLGIMIE> GBIJPEPCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7437C00", Offset = "0x7436600", VA = "0x187437C00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PNKMDIEINFE<IIEBDBDHLOD> MCMNOLFPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7437900", Offset = "0x7436300", VA = "0x187437900", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GOCCOLHGBGH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7437D30", Offset = "0x7436730", VA = "0x187437D30")]
	public static Guid MEHDNABAFLG(string IJGEOMEMMGJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7437C60", Offset = "0x7436660", VA = "0x187437C60")]
	public static bool CBOBJFFEHKK(string IJGEOMEMMGJ, [Out] Guid HLIKNGLOMIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OMFFDAPDKMA : PMJPKMICNLA<PPKIGHIHCHJ>, CFMMEGFKEID<PPKIGHIHCHJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7443E30", Offset = "0x7442830", VA = "0x187443E30", Slot = "4")]
	public IEnumerable<(PPKIGHIHCHJ, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7443E10", Offset = "0x7442810", VA = "0x187443E10", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public PPKIGHIHCHJ AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(PPKIGHIHCHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OMFFDAPDKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DEOPAPGGFDF : PMJPKMICNLA<IIPKPLGIMIE>, CFMMEGFKEID<IIPKPLGIMIE>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7436D90", Offset = "0x7435790", VA = "0x187436D90", Slot = "4")]
	public IEnumerable<(IIPKPLGIMIE, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public IIPKPLGIMIE AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(IIPKPLGIMIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public DEOPAPGGFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NJEKEAFOEEM : PMJPKMICNLA<NBKDMALLDCE>, CFMMEGFKEID<NBKDMALLDCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74416D0", Offset = "0x74400D0", VA = "0x1874416D0", Slot = "4")]
	public IEnumerable<(NBKDMALLDCE, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public NBKDMALLDCE AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(NBKDMALLDCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NJEKEAFOEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DHHGPGJDIBB : PMJPKMICNLA<NLPKIMNBAMP>, CFMMEGFKEID<NLPKIMNBAMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CFMMEGFKEID<EKIJHGABHCH> JEOPDOJMFBC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public DHHGPGJDIBB(CFMMEGFKEID<EKIJHGABHCH> JEOPDOJMFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72D87A0", Offset = "0x72D71A0", VA = "0x1872D87A0", Slot = "4")]
	public IEnumerable<(NLPKIMNBAMP, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7437130", Offset = "0x7435B30", VA = "0x187437130", Slot = "6")]
	public NLPKIMNBAMP AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(NLPKIMNBAMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7437370", Offset = "0x7435D70", VA = "0x187437370", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NDNCKEKOLAB : PMJPKMICNLA<KKJPNJJJKLB>, CFMMEGFKEID<KKJPNJJJKLB>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7439AC0", Offset = "0x74384C0", VA = "0x187439AC0", Slot = "4")]
	public IEnumerable<(KKJPNJJJKLB, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public KKJPNJJJKLB AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(KKJPNJJJKLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NDNCKEKOLAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MDCOPBFKAEN : PMJPKMICNLA<IIEBDBDHLOD>, CFMMEGFKEID<IIEBDBDHLOD>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7437DE0", Offset = "0x74367E0", VA = "0x187437DE0", Slot = "4")]
	public IEnumerable<(IIEBDBDHLOD, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public IIEBDBDHLOD AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(IIEBDBDHLOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public MDCOPBFKAEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NDNBOKMPMDB : PMJPKMICNLA<IFKGKDFJHGN>, CFMMEGFKEID<IFKGKDFJHGN>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74396A0", Offset = "0x74380A0", VA = "0x1874396A0", Slot = "4")]
	public IEnumerable<(IFKGKDFJHGN, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public IFKGKDFJHGN AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(IFKGKDFJHGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NDNBOKMPMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OBECDICBBBK : PMJPKMICNLA<JGBKIPHAEBD>, CFMMEGFKEID<JGBKIPHAEBD>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7443790", Offset = "0x7442190", VA = "0x187443790", Slot = "4")]
	public IEnumerable<(JGBKIPHAEBD, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public JGBKIPHAEBD AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(JGBKIPHAEBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OBECDICBBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PMJPKMICNLA<TModern> : CFMMEGFKEID<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> MJLAPGDIFJM();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EHMILMINAPE(string GAOGBEJOECO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LMDFDOCKNMF : PMJPKMICNLA<EKIJHGABHCH>, CFMMEGFKEID<EKIJHGABHCH>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x738C910", Offset = "0x738B310", VA = "0x18738C910", Slot = "4")]
	public IEnumerable<(EKIJHGABHCH, string)> MJLAPGDIFJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC24C20", Offset = "0xC23620", VA = "0x180C24C20", Slot = "5")]
	public string EHMILMINAPE(string GAOGBEJOECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7436CD0", Offset = "0x74356D0", VA = "0x187436CD0", Slot = "6")]
	public EKIJHGABHCH AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return default(EKIJHGABHCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LMDFDOCKNMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OHKKMPAILIC<TModern> : PNKMDIEINFE<TModern>, CFMMEGFKEID<TModern> where TModern : IEquatable<TModern>, NAOFDPDFIEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> JDDLBMNPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IPGBCBGFIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly PMJPKMICNLA<TModern> JMDBLHAOEKH;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x483E470", Offset = "0x483CE70", VA = "0x18483E470")]
	public OHKKMPAILIC(PMJPKMICNLA<TModern> JMDBLHAOEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x483BFF0", Offset = "0x483A9F0", VA = "0x18483BFF0", Slot = "5")]
	public TModern AMDJNPBFKEE(string GAOGBEJOECO)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x483D030", Offset = "0x483BA30", VA = "0x18483D030", Slot = "4")]
	public string JFFNENGAKKK(TModern FLKIKBDLHFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ECAHMKAFIIH : BDGAMALNPBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private OHKKMPAILIC<PPKIGHIHCHJ> LFBIFOMKFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OHKKMPAILIC<KKJPNJJJKLB> IEKFAGFHONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OHKKMPAILIC<JGBKIPHAEBD> HKLJAOFNCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OHKKMPAILIC<EKIJHGABHCH> JEOPDOJMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OHKKMPAILIC<NLPKIMNBAMP> ECKFPJJBPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OHKKMPAILIC<NBKDMALLDCE> NLDIFNKPJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OHKKMPAILIC<IFKGKDFJHGN> BNOHHFIEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OHKKMPAILIC<IIPKPLGIMIE> AIEMCMMDMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OHKKMPAILIC<IIEBDBDHLOD> DOBJHPPDEPM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PNKMDIEINFE<PPKIGHIHCHJ> POCKDHCIJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PNKMDIEINFE<KKJPNJJJKLB> OPJOCOMCOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PNKMDIEINFE<JGBKIPHAEBD> CMAONIKDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PNKMDIEINFE<NLPKIMNBAMP> IFCJAGJDHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PNKMDIEINFE<NBKDMALLDCE> ANPNHIIHFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PNKMDIEINFE<IFKGKDFJHGN> MKJJLHEDPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PNKMDIEINFE<IIPKPLGIMIE> GBIJPEPCBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PNKMDIEINFE<IIEBDBDHLOD> MCMNOLFPOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x74373B0", Offset = "0x7435DB0", VA = "0x1874373B0")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void IIODECBGFBD(APIKLLPBEEI PFCFNGPPMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7437420", Offset = "0x7435E20", VA = "0x187437420")]
	[RecRoom.NoEngine.Common.Preserve]
	public ECAHMKAFIIH()
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
