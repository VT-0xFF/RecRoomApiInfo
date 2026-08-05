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
public class GENDMICEHPM : IBOHLOCDDOI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex OHFHDPPOCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly KIGLANGNNBE NCGBMIIKGLF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x645AE60", Offset = "0x6459A60", VA = "0x18645AE60")]
	[GFMBCOBENIN(CDPNEOMLNDL.GameOnly)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x645AF60", Offset = "0x6459B60", VA = "0x18645AF60")]
	[GFMBCOBENIN(CDPNEOMLNDL.EditorOnly)]
	private static void KEINOOADJBC(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	[Preserve]
	public GENDMICEHPM([DLBAGNNJKKK(null)] KIGLANGNNBE NCGBMIIKGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x645AFC0", Offset = "0x6459BC0", VA = "0x18645AFC0", Slot = "4")]
	public string OIIEHDKDHEB(LNOEEDOPAMJ MAIMNHFMIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x645A7A0", Offset = "0x64593A0", VA = "0x18645A7A0", Slot = "5")]
	public LNOEEDOPAMJ JFKFFNFOIMD(string MAIMNHFMIBD)
	{
		return default(LNOEEDOPAMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BCKFMNIAPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6459DC0", Offset = "0x64589C0", VA = "0x186459DC0")]
	public static KIGLANGNNBE EBFBNNJEPMG()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
		public SerializedAvatarItemId(PNEIPKAFINP HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public PNEIPKAFINP JFKFFNFOIMD()
		{
			return default(PNEIPKAFINP);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x645C710", Offset = "0x645B310", VA = "0x18645C710", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x645C7E0", Offset = "0x645B3E0", VA = "0x18645C7E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public JLAOOLAEMEJ JFKFFNFOIMD()
		{
			return default(JLAOOLAEMEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x645C850", Offset = "0x645B450", VA = "0x18645C850", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x645C8F0", Offset = "0x645B4F0", VA = "0x18645C8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public ECCOKMBHIBA JFKFFNFOIMD()
		{
			return default(ECCOKMBHIBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedColorId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedColorId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x645C960", Offset = "0x645B560", VA = "0x18645C960", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x645CA00", Offset = "0x645B600", VA = "0x18645CA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, PNPPOCLONMF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x645CC20", Offset = "0x645B820", VA = "0x18645CC20")]
		public BBFEOJBPFGI JFKFFNFOIMD()
		{
			return default(BBFEOJBPFGI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x645CD00", Offset = "0x645B900", VA = "0x18645CD00")]
		public SerializedCombinationId(BBFEOJBPFGI NLGBENKGENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x645CA70", Offset = "0x645B670", VA = "0x18645CA70")]
		private void CGELMBCDAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1150", Offset = "0x5ECFD50", VA = "0x185ED1150", Slot = "4")]
		public bool Equals(SerializedCombinationId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x645CB70", Offset = "0x645B770", VA = "0x18645CB70", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedCombinationId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x645CC90", Offset = "0x645B890", VA = "0x18645CC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x645CC80", Offset = "0x645B880", VA = "0x18645CC80", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x645CDD0", Offset = "0x645B9D0", VA = "0x18645CDD0")]
		public static SerializedEquipmentSkinId NLCBIOFPKMJ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public HOLGPLBNGNG JFKFFNFOIMD()
		{
			return default(HOLGPLBNGNG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x645CD30", Offset = "0x645B930", VA = "0x18645CD30", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x645CE00", Offset = "0x645BA00", VA = "0x18645CE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public OAEAOJLAGNN JFKFFNFOIMD()
		{
			return default(OAEAOJLAGNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x645CE70", Offset = "0x645BA70", VA = "0x18645CE70", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x645CF10", Offset = "0x645BB10", VA = "0x18645CF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public PFAAKBKFIOL JFKFFNFOIMD()
		{
			return default(PFAAKBKFIOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x645CF80", Offset = "0x645BB80", VA = "0x18645CF80", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x645D020", Offset = "0x645BC20", VA = "0x18645D020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
		public SerializedHairPatternId(FNLFLIELHBO HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public FNLFLIELHBO JFKFFNFOIMD()
		{
			return default(FNLFLIELHBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x645D090", Offset = "0x645BC90", VA = "0x18645D090", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x645C7B0", Offset = "0x645B3B0", VA = "0x18645C7B0")]
		public static bool JONBIHPGCCI(SerializedHairPatternId CNJMMNBENNL, SerializedHairPatternId PLPCDFMLHIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x645D130", Offset = "0x645BD30", VA = "0x18645D130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, PNPPOCLONMF
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC94A0", VA = "0x181CCA8A0")]
		public SerializedMaterialId(BAECFEEMCDB HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920", Slot = "6")]
		public Guid NDEPEHOLMNI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public BAECFEEMCDB JFKFFNFOIMD()
		{
			return default(BAECFEEMCDB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1150", Offset = "0x5ECFD50", VA = "0x185ED1150", Slot = "4")]
		public bool Equals(SerializedMaterialId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x645D1A0", Offset = "0x645BDA0", VA = "0x18645D1A0", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x645C7D0", Offset = "0x645B3D0", VA = "0x18645C7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1150", Offset = "0x5ECFD50", VA = "0x185ED1150")]
		public static bool JONBIHPGCCI(SerializedMaterialId CNJMMNBENNL, SerializedMaterialId PLPCDFMLHIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializedMaterialId LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x645D240", Offset = "0x645BE40", VA = "0x18645D240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JFMABEBEEKM : KIGLANGNNBE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JFMABEBEEKM IDAIJJLMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x645B940", Offset = "0x645A540", VA = "0x18645B940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JBLNIBCFFOH<PNEIPKAFINP> HDNBAPPJJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x645B9A0", Offset = "0x645A5A0", VA = "0x18645B9A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JBLNIBCFFOH<HOLGPLBNGNG> GKGBNKFGEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x645BB20", Offset = "0x645A720", VA = "0x18645BB20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JBLNIBCFFOH<FNLFLIELHBO> BNDPDCKHKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x645BC40", Offset = "0x645A840", VA = "0x18645BC40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JBLNIBCFFOH<BBFEOJBPFGI> MEBIBLLIJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x645BAC0", Offset = "0x645A6C0", VA = "0x18645BAC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JBLNIBCFFOH<ECCOKMBHIBA> MGFALLKBAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x645BA60", Offset = "0x645A660", VA = "0x18645BA60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JBLNIBCFFOH<PFAAKBKFIOL> OKKDKBBFHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x645BBE0", Offset = "0x645A7E0", VA = "0x18645BBE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JBLNIBCFFOH<JLAOOLAEMEJ> EEOLFHHHECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x645BA00", Offset = "0x645A600", VA = "0x18645BA00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JBLNIBCFFOH<OAEAOJLAGNN> NOEIOMKCABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x645BB80", Offset = "0x645A780", VA = "0x18645BB80", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6459CD0", Offset = "0x64588D0", VA = "0x186459CD0")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class CAGJDAPBPNO
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6459E40", Offset = "0x6458A40", VA = "0x186459E40")]
	public static string GGHPACKEFIM(this Guid OGCEPACDHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6459E10", Offset = "0x6458A10", VA = "0x186459E10")]
	public static Guid EJCEEDCGPOP(string OIBLIPNGIOC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PGCAJDOMHOI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LOMIFGLDIIB(IEnumerable<(string modernStr, string legacyStr)> KCDEDCEDLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class ONMAGFBLAEI
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class ABDMDLKPDMD : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6459B70", Offset = "0x6458770", VA = "0x186459B70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1BCD000", Offset = "0x1BCBC00", VA = "0x181BCD000")]
		[DebuggerHidden]
		public ABDMDLKPDMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6459BC0", Offset = "0x64587C0", VA = "0x186459BC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6459810", Offset = "0x6458410", VA = "0x186459810", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64597C0", Offset = "0x64583C0", VA = "0x1864597C0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6459B20", Offset = "0x6458720", VA = "0x186459B20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6459A70", Offset = "0x6458670", VA = "0x186459A70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6459A70", Offset = "0x6458670", VA = "0x186459A70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2652840", Offset = "0x2651440", VA = "0x182652840")]
	internal static IEnumerable<(TModern, string)> LIBJDCJDILJ<TModern>(string GNNOENJHJPH, PGCAJDOMHOI<TModern> KGPCCKLDCBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x645BF00", Offset = "0x645AB00", VA = "0x18645BF00")]
	[IteratorStateMachine(typeof(ABDMDLKPDMD))]
	private static IEnumerable<(string, string)> PPFPOECHCLK(AssetIdMappingJsonData LPAFFPKOEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KGNEGCEDNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x645BCA0", Offset = "0x645A8A0", VA = "0x18645BCA0")]
	public static Guid DDDDIFHPDCM(string KICEKCLGKNJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x645BD50", Offset = "0x645A950", VA = "0x18645BD50")]
	public static bool HHLLNADJGCJ(string KICEKCLGKNJ, [Out] Guid OGCEPACDHOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BNKIHICGJMG<TModern> : FDPPONKIIIL<TModern>, PGCAJDOMHOI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class KEECDKOOAFE : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public BNKIHICGJMG<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDFA010", Offset = "0xDF8C10", VA = "0x180DFA010", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34645C0", Offset = "0x34631C0", VA = "0x1834645C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDF39D0", Offset = "0xDF25D0", VA = "0x180DF39D0")]
		[DebuggerHidden]
		public KEECDKOOAFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3309BA0", Offset = "0x33087A0", VA = "0x183309BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3977660", Offset = "0x3976260", VA = "0x183977660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3976CD0", Offset = "0x39758D0", VA = "0x183976CD0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3978B80", Offset = "0x3977780", VA = "0x183978B80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x39788D0", Offset = "0x39774D0", VA = "0x1839788D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3554AF0", Offset = "0x35536F0", VA = "0x183554AF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern GKHOCPCOOMO(Guid OGCEPACDHOE);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4678FD0", Offset = "0x4677BD0", VA = "0x184678FD0", Slot = "4")]
	public TModern JLCCKCCOLML(string CGIFEAKDCAE)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4679070", Offset = "0x4677C70", VA = "0x184679070", Slot = "5")]
	[IteratorStateMachine(typeof(BNKIHICGJMG<>.KEECDKOOAFE))]
	public IEnumerable<(TModern, string)> LOMIFGLDIIB(IEnumerable<(string modernStr, string legacyStr)> FFGNLJNCPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected BNKIHICGJMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MDEBCGBMFNC : BNKIHICGJMG<PNEIPKAFINP>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override PNEIPKAFINP GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(PNEIPKAFINP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x645BE60", Offset = "0x645AA60", VA = "0x18645BE60")]
	internal static string NJKCIKAIOOA(string CGIFEAKDCAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x645BE80", Offset = "0x645AA80", VA = "0x18645BE80")]
	public MDEBCGBMFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IPIEHHMFNAO : BNKIHICGJMG<JLAOOLAEMEJ>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override JLAOOLAEMEJ GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(JLAOOLAEMEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x645B900", Offset = "0x645A500", VA = "0x18645B900")]
	public IPIEHHMFNAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BAJFHKDNHJA : BNKIHICGJMG<ECCOKMBHIBA>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override ECCOKMBHIBA GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(ECCOKMBHIBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6459D80", Offset = "0x6458980", VA = "0x186459D80")]
	public BAJFHKDNHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HPLFKPLODHF : FDPPONKIIIL<BBFEOJBPFGI>, PGCAJDOMHOI<BBFEOJBPFGI>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GBJHBOAFJNN : IEnumerable<(BBFEOJBPFGI, string)>, IEnumerable, IEnumerator<(BBFEOJBPFGI, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (BBFEOJBPFGI, string) <>2__current;

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
		public HPLFKPLODHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (BBFEOJBPFGI, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x31F6C60", Offset = "0x31F5860", VA = "0x1831F6C60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((BBFEOJBPFGI, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x645A6C0", Offset = "0x64592C0", VA = "0x18645A6C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x645A770", Offset = "0x6459370", VA = "0x18645A770")]
		[DebuggerHidden]
		public GBJHBOAFJNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x645A730", Offset = "0x6459330", VA = "0x18645A730", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6459F50", Offset = "0x6458B50", VA = "0x186459F50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6459E90", Offset = "0x6458A90", VA = "0x186459E90")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x645A670", Offset = "0x6459270", VA = "0x18645A670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x645A5B0", Offset = "0x64591B0", VA = "0x18645A5B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(BBFEOJBPFGI, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x645A5B0", Offset = "0x64591B0", VA = "0x18645A5B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FDPPONKIIIL<BAECFEEMCDB> JONPGCDKBFK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public HPLFKPLODHF(FDPPONKIIIL<BAECFEEMCDB> JONPGCDKBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x645B520", Offset = "0x645A120", VA = "0x18645B520", Slot = "4")]
	public BBFEOJBPFGI JLCCKCCOLML(string CGIFEAKDCAE)
	{
		return default(BBFEOJBPFGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x645B820", Offset = "0x645A420", VA = "0x18645B820", Slot = "5")]
	[IteratorStateMachine(typeof(GBJHBOAFJNN))]
	public IEnumerable<(BBFEOJBPFGI, string)> LOMIFGLDIIB(IEnumerable<(string modernStr, string legacyStr)> KCDEDCEDLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x645B8C0", Offset = "0x645A4C0", VA = "0x18645B8C0")]
	internal static string NJKCIKAIOOA(string CGIFEAKDCAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FDLHDMCIKLM : BNKIHICGJMG<HOLGPLBNGNG>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override HOLGPLBNGNG GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(HOLGPLBNGNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6459E50", Offset = "0x6458A50", VA = "0x186459E50")]
	public FDLHDMCIKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KMNHKKLAOCI : BNKIHICGJMG<OAEAOJLAGNN>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override OAEAOJLAGNN GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(OAEAOJLAGNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x645BE20", Offset = "0x645AA20", VA = "0x18645BE20")]
	public KMNHKKLAOCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class APHDLAPJACL : BNKIHICGJMG<PFAAKBKFIOL>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override PFAAKBKFIOL GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(PFAAKBKFIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6459C90", Offset = "0x6458890", VA = "0x186459C90")]
	public APHDLAPJACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MGLJJACMJDN : BNKIHICGJMG<FNLFLIELHBO>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override FNLFLIELHBO GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(FNLFLIELHBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x645BEC0", Offset = "0x645AAC0", VA = "0x18645BEC0")]
	public MGLJJACMJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AINAACFPJHN : BNKIHICGJMG<BAECFEEMCDB>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "6")]
	protected override BAECFEEMCDB GKHOCPCOOMO(Guid OGCEPACDHOE)
	{
		return default(BAECFEEMCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6459C50", Offset = "0x6458850", VA = "0x186459C50")]
	public AINAACFPJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EGMPNBCMBOJ<TModern> : JBLNIBCFFOH<TModern>, FDPPONKIIIL<TModern> where TModern : IEquatable<TModern>, PNPPOCLONMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> CLPGFFMJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> EOLLPBGMCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> KKMPAGIJJLA;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x316B630", Offset = "0x316A230", VA = "0x18316B630")]
	public EGMPNBCMBOJ(TextAsset HGFAIELIAFE, PGCAJDOMHOI<TModern> KGPCCKLDCBE, [CanBeNull] Func<string, string> KKMPAGIJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3167A80", Offset = "0x3166680", VA = "0x183167A80", Slot = "5")]
	public TModern JLCCKCCOLML(string CGIFEAKDCAE)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3169A20", Offset = "0x3168620", VA = "0x183169A20", Slot = "4")]
	public string MOHCPDAHFDF(TModern JFBPDJEINAA)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, KIGLANGNNBE
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
		private EGMPNBCMBOJ<PNEIPKAFINP> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EGMPNBCMBOJ<HOLGPLBNGNG> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EGMPNBCMBOJ<FNLFLIELHBO> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EGMPNBCMBOJ<BAECFEEMCDB> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private EGMPNBCMBOJ<BBFEOJBPFGI> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EGMPNBCMBOJ<ECCOKMBHIBA> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EGMPNBCMBOJ<PFAAKBKFIOL> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private EGMPNBCMBOJ<JLAOOLAEMEJ> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EGMPNBCMBOJ<OAEAOJLAGNN> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JBLNIBCFFOH<PNEIPKAFINP> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JBLNIBCFFOH<HOLGPLBNGNG> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JBLNIBCFFOH<FNLFLIELHBO> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JBLNIBCFFOH<BAECFEEMCDB> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x778760", Offset = "0x777360", VA = "0x180778760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JBLNIBCFFOH<BBFEOJBPFGI> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x778710", Offset = "0x777310", VA = "0x180778710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JBLNIBCFFOH<ECCOKMBHIBA> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x778780", Offset = "0x777380", VA = "0x180778780", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JBLNIBCFFOH<PFAAKBKFIOL> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8AE890", Offset = "0x8AD490", VA = "0x1808AE890", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JBLNIBCFFOH<JLAOOLAEMEJ> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x778690", Offset = "0x777290", VA = "0x180778690", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JBLNIBCFFOH<OAEAOJLAGNN> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x837820", Offset = "0x836420", VA = "0x180837820", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x645BF80", Offset = "0x645AB80", VA = "0x18645BF80")]
		[GFMBCOBENIN(MGPIABHDDAF.Root, CDPNEOMLNDL.GameOnly)]
		private static void BCNNFLKPKKL(OKOCNPPIKGG JGGJFGBKEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x645C000", Offset = "0x645AC00", VA = "0x18645C000")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5690", VA = "0x1807F6A90")]
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
