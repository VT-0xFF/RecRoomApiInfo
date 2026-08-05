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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7619DA0", Offset = "0x76191A0", VA = "0x187619DA0", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JJCFHMODFKH : HCFCMHHHCHA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex EHJNGIMAEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LDBPMFKPPIO FKPCJKGGMDE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7617760", Offset = "0x7616B60", VA = "0x187617760")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	[UsedImplicitly]
	internal static void GIDGJLHOKMO(MCLDCOGKKML FKHGLAMHEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7617FE0", Offset = "0x76173E0", VA = "0x187617FE0")]
	[UsedImplicitly]
	internal static void OMJGPHFOLFG(MCLDCOGKKML FKHGLAMHEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JJCFHMODFKH([NDMEANGLJKD(null)] LDBPMFKPPIO FKPCJKGGMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76177D0", Offset = "0x7616BD0", VA = "0x1876177D0", Slot = "4")]
	public string IJIPNHCCMND(MMGKCPFJLPI CMILLOOAKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7617B10", Offset = "0x7616F10", VA = "0x187617B10", Slot = "5")]
	public MMGKCPFJLPI LIJBJHOEHGL(string CMILLOOAKEN)
	{
		return default(MMGKCPFJLPI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public SerializedAvatarItemId(DGMNJDBAMFC HDCHKIOFILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public DGMNJDBAMFC LIJBJHOEHGL()
		{
			return default(DGMNJDBAMFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7619280", Offset = "0x7618680", VA = "0x187619280", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7619340", Offset = "0x7618740", VA = "0x187619340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public HAFPIFMFCGN LIJBJHOEHGL()
		{
			return default(HAFPIFMFCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76193B0", Offset = "0x76187B0", VA = "0x1876193B0", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7619450", Offset = "0x7618850", VA = "0x187619450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public PJINIDKILAA LIJBJHOEHGL()
		{
			return default(PJINIDKILAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedColorId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedColorId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76194C0", Offset = "0x76188C0", VA = "0x1876194C0", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7619560", Offset = "0x7618960", VA = "0x187619560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MBFEJGKNDJG, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
		public HLKLPNJACJF LIJBJHOEHGL()
		{
			return default(HLKLPNJACJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7619700", Offset = "0x7618B00", VA = "0x187619700")]
		public SerializedCombinationId(HLKLPNJACJF PDGHBMKIDAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74A5360", Offset = "0x74A4760", VA = "0x1874A5360", Slot = "4")]
		public bool Equals(SerializedCombinationId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76195D0", Offset = "0x76189D0", VA = "0x1876195D0", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedCombinationId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7619690", Offset = "0x7618A90", VA = "0x187619690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7619680", Offset = "0x7618A80", VA = "0x187619680", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public SerializedCustomAvatarItemId(Guid MDOJFEIEAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7619710", Offset = "0x7618B10", VA = "0x187619710", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320")]
		public static bool LIIBJCIOAJF(SerializedCustomAvatarItemId CGCHNDGEIJH, SerializedCustomAvatarItemId LEGMFFDGEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76197B0", Offset = "0x7618BB0", VA = "0x1876197B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0x76198C0", Offset = "0x7618CC0", VA = "0x1876198C0")]
		public static SerializedEquipmentSkinId OCKFMPCMIAN()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public LCPEJHNINJI LIJBJHOEHGL()
		{
			return default(LCPEJHNINJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7619820", Offset = "0x7618C20", VA = "0x187619820", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76198F0", Offset = "0x7618CF0", VA = "0x1876198F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public JHKPFMPLNBA LIJBJHOEHGL()
		{
			return default(JHKPFMPLNBA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7619960", Offset = "0x7618D60", VA = "0x187619960", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7619A00", Offset = "0x7618E00", VA = "0x187619A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public EBPOPODBICM LIJBJHOEHGL()
		{
			return default(EBPOPODBICM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7619A70", Offset = "0x7618E70", VA = "0x187619A70", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7619B10", Offset = "0x7618F10", VA = "0x187619B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0")]
		public GLMFFLOLMCM LIJBJHOEHGL()
		{
			return default(GLMFFLOLMCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320", Slot = "4")]
		public bool Equals(SerializedHairPatternId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7619B80", Offset = "0x7618F80", VA = "0x187619B80", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7619320", Offset = "0x7618720", VA = "0x187619320")]
		public static bool LIIBJCIOAJF(SerializedHairPatternId CGCHNDGEIJH, SerializedHairPatternId LEGMFFDGEGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7619C20", Offset = "0x7619020", VA = "0x187619C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MBFEJGKNDJG
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
		[Cpp2IlInjected.Address(RVA = "0xD068A0", Offset = "0xD05CA0", VA = "0x180D068A0")]
		public SerializedMaterialId(FILLGFDGBDC HDCHKIOFILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
		public Guid IJFDEGDMNBA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74A5360", Offset = "0x74A4760", VA = "0x1874A5360", Slot = "4")]
		public bool Equals(SerializedMaterialId OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7619C90", Offset = "0x7619090", VA = "0x187619C90", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xDC0B90", Offset = "0xDBFF90", VA = "0x180DC0B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xDC0A00", Offset = "0xDBFE00", VA = "0x180DC0A00", Slot = "5")]
		public int CompareTo(SerializedMaterialId OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7619D30", Offset = "0x7619130", VA = "0x187619D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NNILNCKMCEC : LDBPMFKPPIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NNILNCKMCEC GHDNHBBFDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x76191C0", Offset = "0x76185C0", VA = "0x1876191C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public POOCNPDLGKI<DGMNJDBAMFC> PLOMPPDNBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7619160", Offset = "0x7618560", VA = "0x187619160", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public POOCNPDLGKI<LCPEJHNINJI> HBFGILLMPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7619040", Offset = "0x7618440", VA = "0x187619040", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public POOCNPDLGKI<GLMFFLOLMCM> IODKLOBAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7619100", Offset = "0x7618500", VA = "0x187619100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public POOCNPDLGKI<HLKLPNJACJF> OIJEKKLIKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x76190A0", Offset = "0x76184A0", VA = "0x1876190A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public POOCNPDLGKI<PJINIDKILAA> MBMAHIKOONN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7618F20", Offset = "0x7618320", VA = "0x187618F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public POOCNPDLGKI<EBPOPODBICM> ACIFJLIDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7619220", Offset = "0x7618620", VA = "0x187619220", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public POOCNPDLGKI<HAFPIFMFCGN> AJNMJFECDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7618F80", Offset = "0x7618380", VA = "0x187618F80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public POOCNPDLGKI<JHKPFMPLNBA> PLJFKKIOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7618FE0", Offset = "0x76183E0", VA = "0x187618FE0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CMJGNHLPLGG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x760BB00", Offset = "0x760AF00", VA = "0x18760BB00")]
	public static Guid FOHONPHIGJL(string MDBFLBKPPLJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x760BBB0", Offset = "0x760AFB0", VA = "0x18760BBB0")]
	public static bool IOHFBJHNGBF(string MDBFLBKPPLJ, [Out] Guid MDOJFEIEAFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BAHGKMDAMHM : BCHFBOLELBN<DGMNJDBAMFC>, KOMBNKFLGBG<DGMNJDBAMFC>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7606B70", Offset = "0x7605F70", VA = "0x187606B70", Slot = "4")]
	public IEnumerable<(DGMNJDBAMFC, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7606B50", Offset = "0x7605F50", VA = "0x187606B50", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public DGMNJDBAMFC MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(DGMNJDBAMFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public BAHGKMDAMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NCJOPBDDJKN : BCHFBOLELBN<HAFPIFMFCGN>, KOMBNKFLGBG<HAFPIFMFCGN>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7618760", Offset = "0x7617B60", VA = "0x187618760", Slot = "4")]
	public IEnumerable<(HAFPIFMFCGN, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public HAFPIFMFCGN MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(HAFPIFMFCGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public NCJOPBDDJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JDELLECPCNF : BCHFBOLELBN<PJINIDKILAA>, KOMBNKFLGBG<PJINIDKILAA>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76156A0", Offset = "0x7614AA0", VA = "0x1876156A0", Slot = "4")]
	public IEnumerable<(PJINIDKILAA, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public PJINIDKILAA MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(PJINIDKILAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public JDELLECPCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CDHNBLFMOOP : BCHFBOLELBN<HLKLPNJACJF>, KOMBNKFLGBG<HLKLPNJACJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KOMBNKFLGBG<FILLGFDGBDC> NBCJLMDIDNA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public CDHNBLFMOOP(KOMBNKFLGBG<FILLGFDGBDC> NBCJLMDIDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74A6790", Offset = "0x74A5B90", VA = "0x1874A6790", Slot = "4")]
	public IEnumerable<(HLKLPNJACJF, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x760B8C0", Offset = "0x760ACC0", VA = "0x18760B8C0", Slot = "6")]
	public HLKLPNJACJF MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(HLKLPNJACJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x760B880", Offset = "0x760AC80", VA = "0x18760B880", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ICNEDJHBLJI : BCHFBOLELBN<LCPEJHNINJI>, KOMBNKFLGBG<LCPEJHNINJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x760DA90", Offset = "0x760CE90", VA = "0x18760DA90", Slot = "4")]
	public IEnumerable<(LCPEJHNINJI, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public LCPEJHNINJI MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(LCPEJHNINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public ICNEDJHBLJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DOEEKDIENMP : BCHFBOLELBN<JHKPFMPLNBA>, KOMBNKFLGBG<JHKPFMPLNBA>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x760BC80", Offset = "0x760B080", VA = "0x18760BC80", Slot = "4")]
	public IEnumerable<(JHKPFMPLNBA, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public JHKPFMPLNBA MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(JHKPFMPLNBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DOEEKDIENMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NNCIMBMJAOP : BCHFBOLELBN<EBPOPODBICM>, KOMBNKFLGBG<EBPOPODBICM>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7618B00", Offset = "0x7617F00", VA = "0x187618B00", Slot = "4")]
	public IEnumerable<(EBPOPODBICM, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public EBPOPODBICM MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(EBPOPODBICM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public NNCIMBMJAOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KGLODCMGPPH : BCHFBOLELBN<GLMFFLOLMCM>, KOMBNKFLGBG<GLMFFLOLMCM>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76180E0", Offset = "0x76174E0", VA = "0x1876180E0", Slot = "4")]
	public IEnumerable<(GLMFFLOLMCM, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public GLMFFLOLMCM MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(GLMFFLOLMCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public KGLODCMGPPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BCHFBOLELBN<TModern> : KOMBNKFLGBG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> KMMIJFEMOEH();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AICMJBHCCNF(string ACBKNNEMOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DAODBEDIJBD : BCHFBOLELBN<FILLGFDGBDC>, KOMBNKFLGBG<FILLGFDGBDC>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x755B8B0", Offset = "0x755ACB0", VA = "0x18755B8B0", Slot = "4")]
	public IEnumerable<(FILLGFDGBDC, string)> KMMIJFEMOEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9CB650", Offset = "0x9CAA50", VA = "0x1809CB650", Slot = "5")]
	public string AICMJBHCCNF(string ACBKNNEMOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x760B7C0", Offset = "0x760ABC0", VA = "0x18760B7C0", Slot = "6")]
	public FILLGFDGBDC MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return default(FILLGFDGBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DAODBEDIJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NLCHLAACKHP<TModern> : POOCNPDLGKI<TModern>, KOMBNKFLGBG<TModern> where TModern : IEquatable<TModern>, MBFEJGKNDJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> DECLLOMJBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> MIDKDEFMIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BCHFBOLELBN<TModern> GMCPNAFBBML;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x495C210", Offset = "0x495B610", VA = "0x18495C210")]
	public NLCHLAACKHP(BCHFBOLELBN<TModern> GMCPNAFBBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4958F60", Offset = "0x4958360", VA = "0x184958F60", Slot = "5")]
	public TModern MCKPHFIGIFA(string ACBKNNEMOKM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4959380", Offset = "0x4958780", VA = "0x184959380", Slot = "4")]
	public string NBJANDKBPOK(TModern KAAFJDCEAOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HOIKLEFFEMN : LDBPMFKPPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NLCHLAACKHP<DGMNJDBAMFC> MBFKHHIAAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NLCHLAACKHP<LCPEJHNINJI> HIEAICPGANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NLCHLAACKHP<GLMFFLOLMCM> MJPLCIFGKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NLCHLAACKHP<FILLGFDGBDC> NBCJLMDIDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NLCHLAACKHP<HLKLPNJACJF> DLOJICLNALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NLCHLAACKHP<PJINIDKILAA> OKHHANEOBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NLCHLAACKHP<EBPOPODBICM> EINIJEFBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NLCHLAACKHP<HAFPIFMFCGN> OICBBJEMMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NLCHLAACKHP<JHKPFMPLNBA> MIAJHGDOPNH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public POOCNPDLGKI<DGMNJDBAMFC> PLOMPPDNBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public POOCNPDLGKI<LCPEJHNINJI> HBFGILLMPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public POOCNPDLGKI<GLMFFLOLMCM> IODKLOBAJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public POOCNPDLGKI<HLKLPNJACJF> OIJEKKLIKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public POOCNPDLGKI<PJINIDKILAA> MBMAHIKOONN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public POOCNPDLGKI<EBPOPODBICM> ACIFJLIDOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public POOCNPDLGKI<HAFPIFMFCGN> AJNMJFECDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public POOCNPDLGKI<JHKPFMPLNBA> PLJFKKIOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x760D540", Offset = "0x760C940", VA = "0x18760D540")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	[UsedImplicitly]
	internal static void IMCINAOJNGK(MCLDCOGKKML FKHGLAMHEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x760D5B0", Offset = "0x760C9B0", VA = "0x18760D5B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HOIKLEFFEMN()
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
