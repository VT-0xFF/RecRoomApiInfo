using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
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
	[Cpp2IlInjected.Address(RVA = "0x6747060", Offset = "0x6745A60", VA = "0x186747060")]
	[NEHHKLCIMGL(OJLOCLENGNC.GameOnly)]
	[UsedImplicitly]
	private static void FBKBONBGGCH(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6747590", Offset = "0x6745F90", VA = "0x186747590")]
	[UsedImplicitly]
	[NEHHKLCIMGL(OJLOCLENGNC.EditorOnly)]
	private static void NJKPBHKANEO(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	[Preserve]
	public EFCGAEMDEAN([CNGDHLLDFHE(null)] CLLDHNDLCKB FNFHMBHJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67470D0", Offset = "0x6745AD0", VA = "0x1867470D0", Slot = "4")]
	public string LENOCDGJGPN(DEPKPIDHOHK KODNHMICLEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67469A0", Offset = "0x67453A0", VA = "0x1867469A0", Slot = "5")]
	public DEPKPIDHOHK AFFCBAMFOKP(string KODNHMICLEA)
	{
		return default(DEPKPIDHOHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMDLMGMJEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x674CEA0", Offset = "0x674B8A0", VA = "0x18674CEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public SerializedAvatarItemId(DLCIPFPLACJ PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public DLCIPFPLACJ AFFCBAMFOKP()
		{
			return default(DLCIPFPLACJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedAvatarItemId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67589D0", Offset = "0x67573D0", VA = "0x1867589D0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6758A90", Offset = "0x6757490", VA = "0x186758A90", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public ILAFEIKLBFM AFFCBAMFOKP()
		{
			return default(ILAFEIKLBFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedBodyShapeId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6758B00", Offset = "0x6757500", VA = "0x186758B00", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6758BA0", Offset = "0x67575A0", VA = "0x186758BA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public AEHFHAKAFIE AFFCBAMFOKP()
		{
			return default(AEHFHAKAFIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedColorId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedColorId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6758C10", Offset = "0x6757610", VA = "0x186758C10", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6758CB0", Offset = "0x67576B0", VA = "0x186758CB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6758D20", Offset = "0x6757720", VA = "0x186758D20")]
		public FPOFKGIDGFO AFFCBAMFOKP()
		{
			return default(FPOFKGIDGFO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6758FB0", Offset = "0x67579B0", VA = "0x186758FB0")]
		public SerializedCombinationId(FPOFKGIDGFO KLBHMHKPCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6758E30", Offset = "0x6757830", VA = "0x186758E30")]
		private void MGOIAJPBJGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EE0", Offset = "0x65E58E0", VA = "0x1865E6EE0", Slot = "4")]
		public bool Equals(SerializedCombinationId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6758D80", Offset = "0x6757780", VA = "0x186758D80", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedCombinationId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6758F40", Offset = "0x6757940", VA = "0x186758F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6758F30", Offset = "0x6757930", VA = "0x186758F30", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6759080", Offset = "0x6757A80", VA = "0x186759080")]
		public static SerializedEquipmentSkinId INBLGAAKGBJ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public KDNOFOFAIJL AFFCBAMFOKP()
		{
			return default(KDNOFOFAIJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6758FE0", Offset = "0x67579E0", VA = "0x186758FE0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67590B0", Offset = "0x6757AB0", VA = "0x1867590B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public IGJMEGNFAKG AFFCBAMFOKP()
		{
			return default(IGJMEGNFAKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6759120", Offset = "0x6757B20", VA = "0x186759120", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67591C0", Offset = "0x6757BC0", VA = "0x1867591C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public BGNICMAMCHH AFFCBAMFOKP()
		{
			return default(BGNICMAMCHH);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedFaceShapeId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6759230", Offset = "0x6757C30", VA = "0x186759230", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67592D0", Offset = "0x6757CD0", VA = "0x1867592D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public SerializedHairPatternId(LLENMLIJPDM PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public LLENMLIJPDM AFFCBAMFOKP()
		{
			return default(LLENMLIJPDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70", Slot = "4")]
		public bool Equals(SerializedHairPatternId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6759340", Offset = "0x6757D40", VA = "0x186759340", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6758A70", Offset = "0x6757470", VA = "0x186758A70")]
		public static bool FFFIMEBHMPG(SerializedHairPatternId JIKBDKDLPCA, SerializedHairPatternId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67593E0", Offset = "0x6757DE0", VA = "0x1867593E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D728F0", Offset = "0x1D712F0", VA = "0x181D728F0")]
		public SerializedMaterialId(IMCFECPEKCC PDDHPPHOJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
		public Guid LFHKFANHHHH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580")]
		public IMCFECPEKCC AFFCBAMFOKP()
		{
			return default(IMCFECPEKCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EE0", Offset = "0x65E58E0", VA = "0x1865E6EE0", Slot = "4")]
		public bool Equals(SerializedMaterialId AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6759450", Offset = "0x6757E50", VA = "0x186759450", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89F5F0", Offset = "0x89DFF0", VA = "0x18089F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x65E6EE0", Offset = "0x65E58E0", VA = "0x1865E6EE0")]
		public static bool FFFIMEBHMPG(SerializedMaterialId JIKBDKDLPCA, SerializedMaterialId DOFNKPFHEKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D0", Offset = "0x89DDD0", VA = "0x18089F3D0", Slot = "5")]
		public int CompareTo(SerializedMaterialId AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67594F0", Offset = "0x6757EF0", VA = "0x1867594F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x6746420", Offset = "0x6744E20", VA = "0x186746420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LCNLILMMGHO<DLCIPFPLACJ> HCMNNPOEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6746300", Offset = "0x6744D00", VA = "0x186746300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LCNLILMMGHO<KDNOFOFAIJL> JDLIKKLICGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6746600", Offset = "0x6745000", VA = "0x186746600", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LCNLILMMGHO<LLENMLIJPDM> ONFMGPOBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6746540", Offset = "0x6744F40", VA = "0x186746540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LCNLILMMGHO<FPOFKGIDGFO> MCANIPAOLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67465A0", Offset = "0x6744FA0", VA = "0x1867465A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LCNLILMMGHO<AEHFHAKAFIE> EDPPBKBIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x67463C0", Offset = "0x6744DC0", VA = "0x1867463C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LCNLILMMGHO<BGNICMAMCHH> OPOELKENAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x67464E0", Offset = "0x6744EE0", VA = "0x1867464E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LCNLILMMGHO<ILAFEIKLBFM> BLKPAKHEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6746480", Offset = "0x6744E80", VA = "0x186746480", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LCNLILMMGHO<IGJMEGNFAKG> AEEMKFMLPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6746360", Offset = "0x6744D60", VA = "0x186746360", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EIOEPFJKAOD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6747760", Offset = "0x6746160", VA = "0x186747760")]
	public static Guid NEHDIOLHEKP(string ECCJGJFNCFK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6747690", Offset = "0x6746090", VA = "0x186747690")]
	public static bool IABNCLHNNMF(string ECCJGJFNCFK, [Out] Guid INAIFGAIEKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HNCIMCCMBFF : FONMIFGPIHI<DLCIPFPLACJ>, HOAIMKGAGMM<DLCIPFPLACJ>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6747EB0", Offset = "0x67468B0", VA = "0x186747EB0", Slot = "4")]
	public IEnumerable<(DLCIPFPLACJ, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6747E90", Offset = "0x6746890", VA = "0x186747E90", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public DLCIPFPLACJ BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(DLCIPFPLACJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public HNCIMCCMBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JLLEPCAIDJD : FONMIFGPIHI<ILAFEIKLBFM>, HOAIMKGAGMM<ILAFEIKLBFM>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x674CB00", Offset = "0x674B500", VA = "0x18674CB00", Slot = "4")]
	public IEnumerable<(ILAFEIKLBFM, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public ILAFEIKLBFM BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(ILAFEIKLBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public JLLEPCAIDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PADJEPEANIB : FONMIFGPIHI<AEHFHAKAFIE>, HOAIMKGAGMM<AEHFHAKAFIE>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6754B00", Offset = "0x6753500", VA = "0x186754B00", Slot = "4")]
	public IEnumerable<(AEHFHAKAFIE, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public AEHFHAKAFIE BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(AEHFHAKAFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public PADJEPEANIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CNKOKAGDOLG : FONMIFGPIHI<FPOFKGIDGFO>, HOAIMKGAGMM<FPOFKGIDGFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HOAIMKGAGMM<IMCFECPEKCC> DNEOABKOHFB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public CNKOKAGDOLG(HOAIMKGAGMM<IMCFECPEKCC> DNEOABKOHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x65E78F0", Offset = "0x65E62F0", VA = "0x1865E78F0", Slot = "4")]
	public IEnumerable<(FPOFKGIDGFO, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6746660", Offset = "0x6745060", VA = "0x186746660", Slot = "6")]
	public FPOFKGIDGFO BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(FPOFKGIDGFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6746960", Offset = "0x6745360", VA = "0x186746960", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MEJKFOLHEDO : FONMIFGPIHI<KDNOFOFAIJL>, HOAIMKGAGMM<KDNOFOFAIJL>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x674CEF0", Offset = "0x674B8F0", VA = "0x18674CEF0", Slot = "4")]
	public IEnumerable<(KDNOFOFAIJL, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public KDNOFOFAIJL BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(KDNOFOFAIJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public MEJKFOLHEDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PKLANAAPANO : FONMIFGPIHI<IGJMEGNFAKG>, HOAIMKGAGMM<IGJMEGNFAKG>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6756BC0", Offset = "0x67555C0", VA = "0x186756BC0", Slot = "4")]
	public IEnumerable<(IGJMEGNFAKG, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public IGJMEGNFAKG BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(IGJMEGNFAKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public PKLANAAPANO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ADFKEGHJLGB : FONMIFGPIHI<BGNICMAMCHH>, HOAIMKGAGMM<BGNICMAMCHH>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6745EE0", Offset = "0x67448E0", VA = "0x186745EE0", Slot = "4")]
	public IEnumerable<(BGNICMAMCHH, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public BGNICMAMCHH BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(BGNICMAMCHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public ADFKEGHJLGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EMLPGIIOHLF : FONMIFGPIHI<LLENMLIJPDM>, HOAIMKGAGMM<LLENMLIJPDM>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6747810", Offset = "0x6746210", VA = "0x186747810", Slot = "4")]
	public IEnumerable<(LLENMLIJPDM, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public LLENMLIJPDM BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(LLENMLIJPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public EMLPGIIOHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FONMIFGPIHI<TModern> : HOAIMKGAGMM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> PNDHEJEJBCM();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KHAEHKLCIKD(string GMJDFKDGHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EPDEAJHKBHB : FONMIFGPIHI<IMCFECPEKCC>, HOAIMKGAGMM<IMCFECPEKCC>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x669BA60", Offset = "0x669A460", VA = "0x18669BA60", Slot = "4")]
	public IEnumerable<(IMCFECPEKCC, string)> PNDHEJEJBCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x89FD40", VA = "0x1808A1340", Slot = "5")]
	public string KHAEHKLCIKD(string GMJDFKDGHIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6745E20", Offset = "0x6744820", VA = "0x186745E20", Slot = "6")]
	public IMCFECPEKCC BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return default(IMCFECPEKCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public EPDEAJHKBHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BENCOMOJDNJ<TModern> : LCNLILMMGHO<TModern>, HOAIMKGAGMM<TModern> where TModern : IEquatable<TModern>, HLNONMJKGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> IKKKPNALLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> CPLGHMMKDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FONMIFGPIHI<TModern> DEPAMBPIJKF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4623EA0", Offset = "0x46228A0", VA = "0x184623EA0")]
	public BENCOMOJDNJ(FONMIFGPIHI<TModern> DEPAMBPIJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x46214A0", Offset = "0x461FEA0", VA = "0x1846214A0", Slot = "5")]
	public TModern BHKEPPCFJEG(string GMJDFKDGHIN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4622300", Offset = "0x4620D00", VA = "0x184622300", Slot = "4")]
	public string PPCIEDKPNMK(TModern GKANFJKMKFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PNCPPPGNEIF : CLLDHNDLCKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BENCOMOJDNJ<DLCIPFPLACJ> CPKBFMPMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private BENCOMOJDNJ<KDNOFOFAIJL> EHLGIIGDCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BENCOMOJDNJ<LLENMLIJPDM> FCELONKAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BENCOMOJDNJ<IMCFECPEKCC> DNEOABKOHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BENCOMOJDNJ<FPOFKGIDGFO> ENNNHGOPBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BENCOMOJDNJ<AEHFHAKAFIE> NJKEAODFLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BENCOMOJDNJ<BGNICMAMCHH> BGJDKCOJFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BENCOMOJDNJ<ILAFEIKLBFM> DPIIDEDBEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BENCOMOJDNJ<IGJMEGNFAKG> JKNCFFOKKOA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LCNLILMMGHO<DLCIPFPLACJ> HCMNNPOEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LCNLILMMGHO<KDNOFOFAIJL> JDLIKKLICGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LCNLILMMGHO<LLENMLIJPDM> ONFMGPOBHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LCNLILMMGHO<FPOFKGIDGFO> MCANIPAOLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LCNLILMMGHO<AEHFHAKAFIE> EDPPBKBIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9320", Offset = "0x7A7D20", VA = "0x1807A9320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LCNLILMMGHO<BGNICMAMCHH> OPOELKENAML
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LCNLILMMGHO<ILAFEIKLBFM> BLKPAKHEJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9220", Offset = "0x7A7C20", VA = "0x1807A9220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LCNLILMMGHO<IGJMEGNFAKG> AEEMKFMLPED
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7A91A0", Offset = "0x7A7BA0", VA = "0x1807A91A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6758480", Offset = "0x6756E80", VA = "0x186758480")]
	[NEHHKLCIMGL(DIKIGLGFNNP.Root, OJLOCLENGNC.GameOnly)]
	[UsedImplicitly]
	private static void LFKEMOGPHEB(BHJKECHLECD EAJOHJPGIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67584F0", Offset = "0x6756EF0", VA = "0x1867584F0")]
	[Preserve]
	public PNCPPPGNEIF()
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
