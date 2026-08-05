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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7438270", Offset = "0x7436C70", VA = "0x187438270", Slot = "8")]
		public override void CPJKPCOPIOF(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KIKLJOCMOHJ : MKONEPBHDKA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NBNGIELPDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OELIFBKKNIM HFEKNGPPDID;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74371E0", Offset = "0x7435BE0", VA = "0x1874371E0")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	[UsedImplicitly]
	internal static void NBLEEGPPBCG(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7437250", Offset = "0x7435C50", VA = "0x187437250")]
	[UsedImplicitly]
	internal static void POGPKBKFHCC(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KIKLJOCMOHJ([LKKACOOMNBP(null)] OELIFBKKNIM HFEKNGPPDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74369D0", Offset = "0x74353D0", VA = "0x1874369D0", Slot = "4")]
	public string BBLOJHGNHMB(ACPAMABFJKA AHBBCFFJCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7436D10", Offset = "0x7435710", VA = "0x187436D10", Slot = "5")]
	public ACPAMABFJKA MPIHBHFBPAP(string AHBBCFFJCCJ)
	{
		return default(ACPAMABFJKA);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public SerializedAvatarItemId(OILMEJJBBPK DNICIAANFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public OILMEJJBBPK MPIHBHFBPAP()
		{
			return default(OILMEJJBBPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7437750", Offset = "0x7436150", VA = "0x187437750", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7437810", Offset = "0x7436210", VA = "0x187437810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public PIAPLLICGDA MPIHBHFBPAP()
		{
			return default(PIAPLLICGDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7437880", Offset = "0x7436280", VA = "0x187437880", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7437920", Offset = "0x7436320", VA = "0x187437920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public KOJLPHFPMHB MPIHBHFBPAP()
		{
			return default(KOJLPHFPMHB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedColorId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedColorId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7437990", Offset = "0x7436390", VA = "0x187437990", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7437A30", Offset = "0x7436430", VA = "0x187437A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, DJFLCPIMHBF, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0")]
		public AOFHBLCBKAK MPIHBHFBPAP()
		{
			return default(AOFHBLCBKAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7437BD0", Offset = "0x74365D0", VA = "0x187437BD0")]
		public SerializedCombinationId(AOFHBLCBKAK PDAGLHPFIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72C3B90", Offset = "0x72C2590", VA = "0x1872C3B90", Slot = "4")]
		public bool Equals(SerializedCombinationId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7437AA0", Offset = "0x74364A0", VA = "0x187437AA0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedCombinationId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7437B60", Offset = "0x7436560", VA = "0x187437B60", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7437B50", Offset = "0x7436550", VA = "0x187437B50", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public SerializedCustomAvatarItemId(Guid OKMPNEEAGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7437BE0", Offset = "0x74365E0", VA = "0x187437BE0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0")]
		public static bool JGJOKBKMGBC(SerializedCustomAvatarItemId OMCEEKENOBB, SerializedCustomAvatarItemId MOBHGIAPGGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7437C80", Offset = "0x7436680", VA = "0x187437C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0x7437D90", Offset = "0x7436790", VA = "0x187437D90")]
		public static SerializedEquipmentSkinId MHKMHAMFNJD()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public CGNBOJIKACE MPIHBHFBPAP()
		{
			return default(CGNBOJIKACE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7437CF0", Offset = "0x74366F0", VA = "0x187437CF0", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7437DC0", Offset = "0x74367C0", VA = "0x187437DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public ANINBIHMFJP MPIHBHFBPAP()
		{
			return default(ANINBIHMFJP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7437E30", Offset = "0x7436830", VA = "0x187437E30", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7437ED0", Offset = "0x74368D0", VA = "0x187437ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public JMPGPJHNGAA MPIHBHFBPAP()
		{
			return default(JMPGPJHNGAA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7437F40", Offset = "0x7436940", VA = "0x187437F40", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7437FE0", Offset = "0x74369E0", VA = "0x187437FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		public DCOCEBIDGOP MPIHBHFBPAP()
		{
			return default(DCOCEBIDGOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0", Slot = "4")]
		public bool Equals(SerializedHairPatternId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedHairPatternId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7438050", Offset = "0x7436A50", VA = "0x187438050", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74377F0", Offset = "0x74361F0", VA = "0x1874377F0")]
		public static bool JGJOKBKMGBC(SerializedHairPatternId OMCEEKENOBB, SerializedHairPatternId MOBHGIAPGGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74380F0", Offset = "0x7436AF0", VA = "0x1874380F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, DJFLCPIMHBF
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
		[Cpp2IlInjected.Address(RVA = "0xC382F0", Offset = "0xC36CF0", VA = "0x180C382F0")]
		public SerializedMaterialId(AHDECKGIPAM DNICIAANFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0", Slot = "6")]
		public Guid MCPJDCOOMJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72C3B90", Offset = "0x72C2590", VA = "0x1872C3B90", Slot = "4")]
		public bool Equals(SerializedMaterialId CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7438160", Offset = "0x7436B60", VA = "0x187438160", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCC8E10", Offset = "0xCC7810", VA = "0x180CC8E10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCC8C80", Offset = "0xCC7680", VA = "0x180CC8C80", Slot = "5")]
		public int CompareTo(SerializedMaterialId CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7438200", Offset = "0x7436C00", VA = "0x187438200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EOGDDJOHGPL : OELIFBKKNIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EOGDDJOHGPL GHBFIIGNNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x742C7E0", Offset = "0x742B1E0", VA = "0x18742C7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LJDDNBJAGCH<OILMEJJBBPK> MJMGFCECOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x742C780", Offset = "0x742B180", VA = "0x18742C780", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LJDDNBJAGCH<CGNBOJIKACE> MIMFCGNNMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x742C660", Offset = "0x742B060", VA = "0x18742C660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LJDDNBJAGCH<DCOCEBIDGOP> JLKHFEDAANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x742C840", Offset = "0x742B240", VA = "0x18742C840", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LJDDNBJAGCH<AOFHBLCBKAK> DFIPJECFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x742C900", Offset = "0x742B300", VA = "0x18742C900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LJDDNBJAGCH<KOJLPHFPMHB> LBGOGBCDABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x742C6C0", Offset = "0x742B0C0", VA = "0x18742C6C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LJDDNBJAGCH<JMPGPJHNGAA> DLJCCJHEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x742C600", Offset = "0x742B000", VA = "0x18742C600", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LJDDNBJAGCH<PIAPLLICGDA> HFCPNGPFCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x742C720", Offset = "0x742B120", VA = "0x18742C720", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LJDDNBJAGCH<ANINBIHMFJP> GFNMMLEBDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x742C8A0", Offset = "0x742B2A0", VA = "0x18742C8A0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MGCDBOLKIAG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7437350", Offset = "0x7435D50", VA = "0x187437350")]
	public static Guid EENBMLKFFOM(string IEIBAEODNAE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7437400", Offset = "0x7435E00", VA = "0x187437400")]
	public static bool KMODIOEOEHP(string IEIBAEODNAE, [Out] Guid OKMPNEEAGBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DLCOAFFFCFN : EPFEMGBANCD<OILMEJJBBPK>, FBIFJMHJDPK<OILMEJJBBPK>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7427990", Offset = "0x7426390", VA = "0x187427990", Slot = "4")]
	public IEnumerable<(OILMEJJBBPK, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x742C5E0", Offset = "0x742AFE0", VA = "0x18742C5E0", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public OILMEJJBBPK KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(OILMEJJBBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DLCOAFFFCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FANFBGBEEKK : EPFEMGBANCD<PIAPLLICGDA>, FBIFJMHJDPK<PIAPLLICGDA>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x742C960", Offset = "0x742B360", VA = "0x18742C960", Slot = "4")]
	public IEnumerable<(PIAPLLICGDA, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public PIAPLLICGDA KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(PIAPLLICGDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public FANFBGBEEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HJAPHKPCCBN : EPFEMGBANCD<KOJLPHFPMHB>, FBIFJMHJDPK<KOJLPHFPMHB>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7434910", Offset = "0x7433310", VA = "0x187434910", Slot = "4")]
	public IEnumerable<(KOJLPHFPMHB, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public KOJLPHFPMHB KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(KOJLPHFPMHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HJAPHKPCCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OBFBLFKCEMC : EPFEMGBANCD<AOFHBLCBKAK>, FBIFJMHJDPK<AOFHBLCBKAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FBIFJMHJDPK<AHDECKGIPAM> GINGHFDADEO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8913E0", Offset = "0x88FDE0", VA = "0x1808913E0")]
	public OBFBLFKCEMC(FBIFJMHJDPK<AHDECKGIPAM> GINGHFDADEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72C4C60", Offset = "0x72C3660", VA = "0x1872C4C60", Slot = "4")]
	public IEnumerable<(AOFHBLCBKAK, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74374D0", Offset = "0x7435ED0", VA = "0x1874374D0", Slot = "6")]
	public AOFHBLCBKAK KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(AOFHBLCBKAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7437710", Offset = "0x7436110", VA = "0x187437710", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GCJOJFCLJKO : EPFEMGBANCD<CGNBOJIKACE>, FBIFJMHJDPK<CGNBOJIKACE>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x742CD00", Offset = "0x742B700", VA = "0x18742CD00", Slot = "4")]
	public IEnumerable<(CGNBOJIKACE, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public CGNBOJIKACE KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(CGNBOJIKACE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public GCJOJFCLJKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AGBCPANLPEB : EPFEMGBANCD<ANINBIHMFJP>, FBIFJMHJDPK<ANINBIHMFJP>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7425020", Offset = "0x7423A20", VA = "0x187425020", Slot = "4")]
	public IEnumerable<(ANINBIHMFJP, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public ANINBIHMFJP KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(ANINBIHMFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public AGBCPANLPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BHPAFLCENAB : EPFEMGBANCD<JMPGPJHNGAA>, FBIFJMHJDPK<JMPGPJHNGAA>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74269A0", Offset = "0x74253A0", VA = "0x1874269A0", Slot = "4")]
	public IEnumerable<(JMPGPJHNGAA, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public JMPGPJHNGAA KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(JMPGPJHNGAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public BHPAFLCENAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CGBFGDEELNA : EPFEMGBANCD<DCOCEBIDGOP>, FBIFJMHJDPK<DCOCEBIDGOP>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7426DC0", Offset = "0x74257C0", VA = "0x187426DC0", Slot = "4")]
	public IEnumerable<(DCOCEBIDGOP, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public DCOCEBIDGOP KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(DCOCEBIDGOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public CGBFGDEELNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EPFEMGBANCD<TModern> : FBIFJMHJDPK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HKMGDCMLMLI();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NPHFIDMPIKH(string GCKACIBEBPF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DCEALBNHFHF : EPFEMGBANCD<AHDECKGIPAM>, FBIFJMHJDPK<AHDECKGIPAM>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7379D80", Offset = "0x7378780", VA = "0x187379D80", Slot = "4")]
	public IEnumerable<(AHDECKGIPAM, string)> HKMGDCMLMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xCCAC70", Offset = "0xCC9670", VA = "0x180CCAC70", Slot = "5")]
	public string NPHFIDMPIKH(string GCKACIBEBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74268E0", Offset = "0x74252E0", VA = "0x1874268E0", Slot = "6")]
	public AHDECKGIPAM KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return default(AHDECKGIPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public DCEALBNHFHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ICKNBIPCDAB<TModern> : LJDDNBJAGCH<TModern>, FBIFJMHJDPK<TModern> where TModern : IEquatable<TModern>, DJFLCPIMHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> FGBAKGBIGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> COPEIKICAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly EPFEMGBANCD<TModern> AGPAPPPGKPE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x407B9A0", Offset = "0x407A3A0", VA = "0x18407B9A0")]
	public ICKNBIPCDAB(EPFEMGBANCD<TModern> AGPAPPPGKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x407AC50", Offset = "0x4079650", VA = "0x18407AC50", Slot = "5")]
	public TModern KHDNCOAAIBJ(string GCKACIBEBPF)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4078D70", Offset = "0x4077770", VA = "0x184078D70", Slot = "4")]
	public string CLOHIJJOAGB(TModern EHPPEEABHBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CNAEJLFBOBL : OELIFBKKNIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private ICKNBIPCDAB<OILMEJJBBPK> BKFEABDJPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private ICKNBIPCDAB<CGNBOJIKACE> HIDNOMOHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ICKNBIPCDAB<DCOCEBIDGOP> GBMANNBGGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ICKNBIPCDAB<AHDECKGIPAM> GINGHFDADEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ICKNBIPCDAB<AOFHBLCBKAK> GHJPHEDMFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private ICKNBIPCDAB<KOJLPHFPMHB> IOPDFCKDCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private ICKNBIPCDAB<JMPGPJHNGAA> MBMIPGKHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ICKNBIPCDAB<PIAPLLICGDA> FLPFDDKBEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ICKNBIPCDAB<ANINBIHMFJP> FBHNOHMDJPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LJDDNBJAGCH<OILMEJJBBPK> MJMGFCECOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LJDDNBJAGCH<CGNBOJIKACE> MIMFCGNNMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LJDDNBJAGCH<DCOCEBIDGOP> JLKHFEDAANP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LJDDNBJAGCH<AOFHBLCBKAK> DFIPJECFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LJDDNBJAGCH<KOJLPHFPMHB> LBGOGBCDABB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LJDDNBJAGCH<JMPGPJHNGAA> DLJCCJHEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LJDDNBJAGCH<PIAPLLICGDA> HFCPNGPFCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x883D50", Offset = "0x882750", VA = "0x180883D50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LJDDNBJAGCH<ANINBIHMFJP> GFNMMLEBDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7427440", Offset = "0x7425E40", VA = "0x187427440")]
	[MDINNNLEANF.FIHKBCJDGBK.GBDNBGLLJBG]
	[UsedImplicitly]
	internal static void FACEOGGPDCB(FNNNJBMCDDC FOKBFKHGDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74274B0", Offset = "0x7425EB0", VA = "0x1874274B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CNAEJLFBOBL()
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
