using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EFCGAEMDEAN : MHEPMAMOHPL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex PCCLIFJKGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CLLDHNDLCKB FNFHMBHJIFP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6569FC0", Offset = "0x65693C0", VA = "0x186569FC0")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	private static void FBKBONBGGCH(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x656A580", Offset = "0x6569980", VA = "0x18656A580")]
	[NEHHKLCIMGL(OJLOCLENGNC.EditorOnly)]
	private static void NJKPBHKANEO(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	[Preserve]
	public EFCGAEMDEAN([CNGDHLLDFHE(null)] CLLDHNDLCKB FNFHMBHJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x656A0C0", Offset = "0x65694C0", VA = "0x18656A0C0", Slot = "4")]
	public string LENOCDGJGPN(DEPKPIDHOHK KODNHMICLEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6569900", Offset = "0x6568D00", VA = "0x186569900", Slot = "5")]
	public DEPKPIDHOHK AFFCBAMFOKP(string KODNHMICLEA)
	{
		return default(DEPKPIDHOHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMDLMGMJEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x656A900", Offset = "0x6569D00", VA = "0x18656A900")]
	public static CLLDHNDLCKB OEKIEHJCNAA()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, HLNONMJKGEK
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

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public SerializedAvatarItemId(DLCIPFPLACJ PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public DLCIPFPLACJ AFFCBAMFOKP()
		{
			return default(DLCIPFPLACJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedAvatarItemId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x656BAD0", Offset = "0x656AED0", VA = "0x18656BAD0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x656BBA0", Offset = "0x656AFA0", VA = "0x18656BBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, HLNONMJKGEK
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
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public ILAFEIKLBFM AFFCBAMFOKP()
		{
			return default(ILAFEIKLBFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedBodyShapeId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x656BC10", Offset = "0x656B010", VA = "0x18656BC10", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x656BCB0", Offset = "0x656B0B0", VA = "0x18656BCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, HLNONMJKGEK
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
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public AEHFHAKAFIE AFFCBAMFOKP()
		{
			return default(AEHFHAKAFIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedColorId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedColorId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x656BD20", Offset = "0x656B120", VA = "0x18656BD20", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x656BDC0", Offset = "0x656B1C0", VA = "0x18656BDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, HLNONMJKGEK, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private SerializedMaterialId materialId1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private SerializedMaterialId materialId2;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x656BE30", Offset = "0x656B230", VA = "0x18656BE30")]
		public FPOFKGIDGFO AFFCBAMFOKP()
		{
			return default(FPOFKGIDGFO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x656C0C0", Offset = "0x656B4C0", VA = "0x18656C0C0")]
		public SerializedCombinationId(FPOFKGIDGFO KLBHMHKPCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x656BF40", Offset = "0x656B340", VA = "0x18656BF40")]
		private void MGOIAJPBJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65680E0", Offset = "0x65674E0", VA = "0x1865680E0", Slot = "4")]
		public bool Equals(SerializedCombinationId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x656BE90", Offset = "0x656B290", VA = "0x18656BE90", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedCombinationId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x656C050", Offset = "0x656B450", VA = "0x18656C050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x656C040", Offset = "0x656B440", VA = "0x18656C040", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, HLNONMJKGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x656C190", Offset = "0x656B590", VA = "0x18656C190")]
		public static SerializedEquipmentSkinId INBLGAAKGBJ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public KDNOFOFAIJL AFFCBAMFOKP()
		{
			return default(KDNOFOFAIJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x656C0F0", Offset = "0x656B4F0", VA = "0x18656C0F0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x656C1C0", Offset = "0x656B5C0", VA = "0x18656C1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, HLNONMJKGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public IGJMEGNFAKG AFFCBAMFOKP()
		{
			return default(IGJMEGNFAKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x656C230", Offset = "0x656B630", VA = "0x18656C230", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x656C2D0", Offset = "0x656B6D0", VA = "0x18656C2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, HLNONMJKGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public BGNICMAMCHH AFFCBAMFOKP()
		{
			return default(BGNICMAMCHH);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedFaceShapeId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x656C340", Offset = "0x656B740", VA = "0x18656C340", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x656C3E0", Offset = "0x656B7E0", VA = "0x18656C3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, HLNONMJKGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public SerializedHairPatternId(LLENMLIJPDM PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public LLENMLIJPDM AFFCBAMFOKP()
		{
			return default(LLENMLIJPDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70", Slot = "4")]
		public bool Equals(SerializedHairPatternId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x656C450", Offset = "0x656B850", VA = "0x18656C450", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x656BB70", Offset = "0x656AF70", VA = "0x18656BB70")]
		public static bool FFFIMEBHMPG(SerializedHairPatternId JIKBDKDLPCA, SerializedHairPatternId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x656C4F0", Offset = "0x656B8F0", VA = "0x18656C4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, HLNONMJKGEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1D57CF0", Offset = "0x1D570F0", VA = "0x181D57CF0")]
		public SerializedMaterialId(IMCFECPEKCC PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0")]
		public IMCFECPEKCC AFFCBAMFOKP()
		{
			return default(IMCFECPEKCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65680E0", Offset = "0x65674E0", VA = "0x1865680E0", Slot = "4")]
		public bool Equals(SerializedMaterialId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x656C560", Offset = "0x656B960", VA = "0x18656C560", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x656BB90", Offset = "0x656AF90", VA = "0x18656BB90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65680E0", Offset = "0x65674E0", VA = "0x1865680E0")]
		public static bool FFFIMEBHMPG(SerializedMaterialId JIKBDKDLPCA, SerializedMaterialId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x656BAB0", Offset = "0x656AEB0", VA = "0x18656BAB0", Slot = "5")]
		public int CompareTo(SerializedMaterialId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x656C600", Offset = "0x656BA00", VA = "0x18656C600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AHHJEHNJDPC : CLLDHNDLCKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AHHJEHNJDPC MEGHANKAOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6568BA0", Offset = "0x6567FA0", VA = "0x186568BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LCNLILMMGHO<DLCIPFPLACJ> HCMNNPOEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6568C00", Offset = "0x6568000", VA = "0x186568C00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LCNLILMMGHO<KDNOFOFAIJL> JDLIKKLICGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6568D80", Offset = "0x6568180", VA = "0x186568D80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LCNLILMMGHO<LLENMLIJPDM> ONFMGPOBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6568EA0", Offset = "0x65682A0", VA = "0x186568EA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LCNLILMMGHO<FPOFKGIDGFO> MCANIPAOLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6568D20", Offset = "0x6568120", VA = "0x186568D20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LCNLILMMGHO<AEHFHAKAFIE> EDPPBKBIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6568CC0", Offset = "0x65680C0", VA = "0x186568CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LCNLILMMGHO<BGNICMAMCHH> OPOELKENAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6568E40", Offset = "0x6568240", VA = "0x186568E40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LCNLILMMGHO<ILAFEIKLBFM> BLKPAKHEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6568C60", Offset = "0x6568060", VA = "0x186568C60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LCNLILMMGHO<IGJMEGNFAKG> AEEMKFMLPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6568DE0", Offset = "0x65681E0", VA = "0x186568DE0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal class AssetIdMappingJsonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public SortedDictionary<string, string> modernToLegacy;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6568F00", Offset = "0x6568300", VA = "0x186568F00")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class OLAIHCFCDHN
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x656B310", Offset = "0x656A710", VA = "0x18656B310")]
	public static string EFKODAMBDFG(this Guid INAIFGAIEKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x656B2E0", Offset = "0x656A6E0", VA = "0x18656B2E0")]
	public static Guid ECOMGHJCOEG(string OCEJJGAENFJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDNIGCECAJI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> FOPKIMNPAKG(IEnumerable<(string modernStr, string legacyStr)> DCFIJKMIDJK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class IFDHBGGCALF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OICDKNGHNAP : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private (string, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private AssetIdMappingJsonData jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AssetIdMappingJsonData <>3__jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private SortedDictionary<string, string>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.String,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA1E8E0", Offset = "0xA1DCE0", VA = "0x180A1E8E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x656B200", Offset = "0x656A600", VA = "0x18656B200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C4CF50", Offset = "0x1C4C350", VA = "0x181C4CF50")]
		[DebuggerHidden]
		public OICDKNGHNAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x656B250", Offset = "0x656A650", VA = "0x18656B250", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x656AEA0", Offset = "0x656A2A0", VA = "0x18656AEA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x656AE50", Offset = "0x656A250", VA = "0x18656AE50")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x656B1B0", Offset = "0x656A5B0", VA = "0x18656B1B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x656B100", Offset = "0x656A500", VA = "0x18656B100", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x656B100", Offset = "0x656A500", VA = "0x18656B100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2673C30", Offset = "0x2673030", VA = "0x182673C30")]
	internal static IEnumerable<(TModern, string)> MBGBGOCHAHN<TModern>(string JLOHKMFMEKE, NDNIGCECAJI<TModern> HDBHLEKEMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x656A880", Offset = "0x6569C80", VA = "0x18656A880")]
	[IteratorStateMachine(typeof(OICDKNGHNAP))]
	private static IEnumerable<(string, string)> MAENCPOOCFC(AssetIdMappingJsonData GBFAGACANCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EIOEPFJKAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x656A750", Offset = "0x6569B50", VA = "0x18656A750")]
	public static Guid NEHDIOLHEKP(string ECCJGJFNCFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x656A680", Offset = "0x6569A80", VA = "0x18656A680")]
	public static bool IABNCLHNNMF(string ECCJGJFNCFK, [Out] Guid INAIFGAIEKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MLKHILKMOLB<TModern> : HOAIMKGAGMM<TModern>, NDNIGCECAJI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BLJAMDJINED : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (TModern, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public MLKHILKMOLB<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE46B90", Offset = "0xE45F90", VA = "0x180E46B90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TModern, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x34AC2A0", Offset = "0x34AB6A0", VA = "0x1834AC2A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE3C620", Offset = "0xE3BA20", VA = "0x180E3C620")]
		[DebuggerHidden]
		public BLJAMDJINED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x34A1050", Offset = "0x34A0450", VA = "0x1834A1050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x461A480", Offset = "0x4619880", VA = "0x18461A480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4619180", Offset = "0x4618580", VA = "0x184619180")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x461B0D0", Offset = "0x461A4D0", VA = "0x18461B0D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x461AD50", Offset = "0x461A150", VA = "0x18461AD50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3B54380", Offset = "0x3B53780", VA = "0x183B54380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern KPILPNCBIPH(Guid INAIFGAIEKH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D933E0", Offset = "0x3D927E0", VA = "0x183D933E0", Slot = "4")]
	public TModern BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D93480", Offset = "0x3D92880", VA = "0x183D93480", Slot = "5")]
	[IteratorStateMachine(typeof(MLKHILKMOLB<>.BLJAMDJINED))]
	public IEnumerable<(TModern, string)> FOPKIMNPAKG(IEnumerable<(string modernStr, string legacyStr)> MHMFBCOPGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected MLKHILKMOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LCFFOIIHGPD : MLKHILKMOLB<DLCIPFPLACJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override DLCIPFPLACJ KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(DLCIPFPLACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x656AD30", Offset = "0x656A130", VA = "0x18656AD30")]
	internal static string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x656AD50", Offset = "0x656A150", VA = "0x18656AD50")]
	public LCFFOIIHGPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EJKFGIAGAKL : MLKHILKMOLB<ILAFEIKLBFM>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override ILAFEIKLBFM KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(ILAFEIKLBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x656A800", Offset = "0x6569C00", VA = "0x18656A800")]
	public EJKFGIAGAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FENONOJEKEA : MLKHILKMOLB<AEHFHAKAFIE>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override AEHFHAKAFIE KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(AEHFHAKAFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x656A840", Offset = "0x6569C40", VA = "0x18656A840")]
	public FENONOJEKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LAHFDLOBFOG : HOAIMKGAGMM<FPOFKGIDGFO>, NDNIGCECAJI<FPOFKGIDGFO>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class BFJHCAMCGIJ : IEnumerable<(FPOFKGIDGFO, string)>, IEnumerable, IEnumerator<(FPOFKGIDGFO, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (FPOFKGIDGFO, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LAHFDLOBFOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (FPOFKGIDGFO, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x329CC80", Offset = "0x329C080", VA = "0x18329CC80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((FPOFKGIDGFO, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x65697E0", Offset = "0x6568BE0", VA = "0x1865697E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6569890", Offset = "0x6568C90", VA = "0x186569890")]
		[DebuggerHidden]
		public BFJHCAMCGIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6569850", Offset = "0x6568C50", VA = "0x186569850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6569070", Offset = "0x6568470", VA = "0x186569070", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6568FB0", Offset = "0x65683B0", VA = "0x186568FB0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6569790", Offset = "0x6568B90", VA = "0x186569790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x65696D0", Offset = "0x6568AD0", VA = "0x1865696D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(FPOFKGIDGFO, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x65696D0", Offset = "0x6568AD0", VA = "0x1865696D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HOAIMKGAGMM<IMCFECPEKCC> DNEOABKOHFB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public LAHFDLOBFOG(HOAIMKGAGMM<IMCFECPEKCC> DNEOABKOHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x656A950", Offset = "0x6569D50", VA = "0x18656A950", Slot = "4")]
	public FPOFKGIDGFO BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(FPOFKGIDGFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x656AC50", Offset = "0x656A050", VA = "0x18656AC50", Slot = "5")]
	[IteratorStateMachine(typeof(BFJHCAMCGIJ))]
	public IEnumerable<(FPOFKGIDGFO, string)> FOPKIMNPAKG(IEnumerable<(string modernStr, string legacyStr)> DCFIJKMIDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x656ACF0", Offset = "0x656A0F0", VA = "0x18656ACF0")]
	internal static string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LIPENGKEIGO : MLKHILKMOLB<KDNOFOFAIJL>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override KDNOFOFAIJL KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(KDNOFOFAIJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x656AD90", Offset = "0x656A190", VA = "0x18656AD90")]
	public LIPENGKEIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OBAOBLLAIHI : MLKHILKMOLB<IGJMEGNFAKG>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override IGJMEGNFAKG KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(IGJMEGNFAKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x656AE10", Offset = "0x656A210", VA = "0x18656AE10")]
	public OBAOBLLAIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AFFJLOAMDLM : MLKHILKMOLB<BGNICMAMCHH>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override BGNICMAMCHH KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(BGNICMAMCHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6568B60", Offset = "0x6567F60", VA = "0x186568B60")]
	public AFFJLOAMDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MPAFNOEIGCJ : MLKHILKMOLB<LLENMLIJPDM>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override LLENMLIJPDM KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(LLENMLIJPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x656ADD0", Offset = "0x656A1D0", VA = "0x18656ADD0")]
	public MPAFNOEIGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CCEJMABOLPO : MLKHILKMOLB<IMCFECPEKCC>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE524D0", Offset = "0xE518D0", VA = "0x180E524D0", Slot = "6")]
	protected override IMCFECPEKCC KPILPNCBIPH(Guid INAIFGAIEKH)
	{
		return default(IMCFECPEKCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x65698C0", Offset = "0x6568CC0", VA = "0x1865698C0")]
	public CCEJMABOLPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BENCOMOJDNJ<TModern> : LCNLILMMGHO<TModern>, HOAIMKGAGMM<TModern> where TModern : IEquatable<TModern>, HLNONMJKGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> IKKKPNALLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> CPLGHMMKDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> FKCFIDKJMIF;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x45E9620", Offset = "0x45E8A20", VA = "0x1845E9620")]
	public BENCOMOJDNJ(TextAsset CJALLGHHNNF, NDNIGCECAJI<TModern> HDBHLEKEMGF, [CanBeNull] Func<string, string> FKCFIDKJMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x45E7C00", Offset = "0x45E7000", VA = "0x1845E7C00", Slot = "5")]
	public TModern BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x45E8C00", Offset = "0x45E8000", VA = "0x1845E8C00", Slot = "4")]
	public string PPCIEDKPNMK(TModern GKANFJKMKFA)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, CLLDHNDLCKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TextAsset avatarItemIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private TextAsset combinationIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TextAsset equipmentSkinIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private TextAsset hairPatternIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TextAsset materialIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private TextAsset colorIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TextAsset faceShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private TextAsset bodyShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextAsset faceFeatureIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private BENCOMOJDNJ<DLCIPFPLACJ> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private BENCOMOJDNJ<KDNOFOFAIJL> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private BENCOMOJDNJ<LLENMLIJPDM> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private BENCOMOJDNJ<IMCFECPEKCC> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private BENCOMOJDNJ<FPOFKGIDGFO> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BENCOMOJDNJ<AEHFHAKAFIE> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BENCOMOJDNJ<BGNICMAMCHH> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private BENCOMOJDNJ<ILAFEIKLBFM> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private BENCOMOJDNJ<IGJMEGNFAKG> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LCNLILMMGHO<DLCIPFPLACJ> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LCNLILMMGHO<KDNOFOFAIJL> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x79F310", Offset = "0x79E710", VA = "0x18079F310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LCNLILMMGHO<LLENMLIJPDM> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x79F130", Offset = "0x79E530", VA = "0x18079F130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public LCNLILMMGHO<IMCFECPEKCC> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7A9590", Offset = "0x7A8990", VA = "0x1807A9590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public LCNLILMMGHO<FPOFKGIDGFO> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LCNLILMMGHO<AEHFHAKAFIE> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7A9460", Offset = "0x7A8860", VA = "0x1807A9460", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LCNLILMMGHO<BGNICMAMCHH> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DB2B0", Offset = "0x8DA6B0", VA = "0x1808DB2B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LCNLILMMGHO<ILAFEIKLBFM> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A8840", VA = "0x1807A9440", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LCNLILMMGHO<IGJMEGNFAKG> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x85D990", Offset = "0x85CD90", VA = "0x18085D990", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x656B320", Offset = "0x656A720", VA = "0x18656B320")]
		[NEHHKLCIMGL(DIKIGLGFNNP.Root, OJLOCLENGNC.GameOnly)]
		private static void LFKEMOGPHEB(BHJKECHLECD EAJOHJPGIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x656B3A0", Offset = "0x656A7A0", VA = "0x18656B3A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x857600", Offset = "0x856A00", VA = "0x180857600")]
		public RuntimeIdAssetMappers()
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
