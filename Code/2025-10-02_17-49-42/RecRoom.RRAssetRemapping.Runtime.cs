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
		[Cpp2IlInjected.Address(RVA = "0x8F94980", Offset = "0x8F93380", VA = "0x188F94980", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JKICMMPNJFB : OGMBPJENFED
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex CDDEOCGBAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly DLFALJHALEC FKKDBGIKNON;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8F8F310", Offset = "0x8F8DD10", VA = "0x188F8F310")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	[UsedImplicitly]
	internal static void HFPMPAAENFC(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8F8EF70", Offset = "0x8F8D970", VA = "0x188F8EF70")]
	[UsedImplicitly]
	internal static void ADKDLLAJCMA(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKICMMPNJFB([BMCONCJPCIA(null)] DLFALJHALEC FKKDBGIKNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8F8EFD0", Offset = "0x8F8D9D0", VA = "0x188F8EFD0", Slot = "4")]
	public string GCGCKFHBJPB(NCHELFAJJGK GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8F8F380", Offset = "0x8F8DD80", VA = "0x188F8F380", Slot = "5")]
	public NCHELFAJJGK LEOAOCFGODA(string GHANLDMHBLD)
	{
		return default(NCHELFAJJGK);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public KCNLPKHKIFL LEOAOCFGODA()
		{
			return default(KCNLPKHKIFL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedAvatarItemId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F93DF0", Offset = "0x8F927F0", VA = "0x188F93DF0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F93EB0", Offset = "0x8F928B0", VA = "0x188F93EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public KIAKNBOHMJA LEOAOCFGODA()
		{
			return default(KIAKNBOHMJA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedBodyShapeId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F93F20", Offset = "0x8F92920", VA = "0x188F93F20", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F93FC0", Offset = "0x8F929C0", VA = "0x188F93FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public PDKIOGIIPNG LEOAOCFGODA()
		{
			return default(PDKIOGIIPNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedColorId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedColorId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F94030", Offset = "0x8F92A30", VA = "0x188F94030", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F940D0", Offset = "0x8F92AD0", VA = "0x188F940D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CNAKNBPLFLB, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
		public CKPKFPAKPLM LEOAOCFGODA()
		{
			return default(CKPKFPAKPLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FA60", Offset = "0x8E1E460", VA = "0x188E1FA60", Slot = "4")]
		public bool Equals(SerializedCombinationId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F94140", Offset = "0x8F92B40", VA = "0x188F94140", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedCombinationId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F94200", Offset = "0x8F92C00", VA = "0x188F94200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F941F0", Offset = "0x8F92BF0", VA = "0x188F941F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CNAKNBPLFLB
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
			[Cpp2IlInjected.Address(RVA = "0x8F943A0", Offset = "0x8F92DA0", VA = "0x188F943A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1531090", Offset = "0x152FA90", VA = "0x181531090")]
		public SerializedCustomAvatarItemId(Guid OCONCDFGCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public static SerializedCustomAvatarItemId MMHBOHDGJHD(Guid OCONCDFGCOB)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F94290", Offset = "0x8F92C90", VA = "0x188F94290", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90")]
		public static bool NOPNAEDOCOI(SerializedCustomAvatarItemId IIIICGAEODJ, SerializedCustomAvatarItemId ELBIKJBAIEA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F94270", Offset = "0x8F92C70", VA = "0x188F94270")]
		public static bool DFNINOIAFHB(SerializedCustomAvatarItemId IIIICGAEODJ, SerializedCustomAvatarItemId ELBIKJBAIEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F94330", Offset = "0x8F92D30", VA = "0x188F94330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x8F94400", Offset = "0x8F92E00", VA = "0x188F94400")]
		public static SerializedEquipmentSkinId BABNPFBFIIM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public PBMBPKKKHDL LEOAOCFGODA()
		{
			return default(PBMBPKKKHDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F94430", Offset = "0x8F92E30", VA = "0x188F94430", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F944D0", Offset = "0x8F92ED0", VA = "0x188F944D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public IBNJPOEEICJ LEOAOCFGODA()
		{
			return default(IBNJPOEEICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F94540", Offset = "0x8F92F40", VA = "0x188F94540", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F945E0", Offset = "0x8F92FE0", VA = "0x188F945E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public HEKFPEMBJAL LEOAOCFGODA()
		{
			return default(HEKFPEMBJAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedFaceShapeId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F94650", Offset = "0x8F93050", VA = "0x188F94650", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8F946F0", Offset = "0x8F930F0", VA = "0x188F946F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120")]
		public PHIEDCFFKBA LEOAOCFGODA()
		{
			return default(PHIEDCFFKBA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90", Slot = "4")]
		public bool Equals(SerializedHairPatternId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedHairPatternId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F94760", Offset = "0x8F93160", VA = "0x188F94760", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E90", Offset = "0x8F92890", VA = "0x188F93E90")]
		public static bool NOPNAEDOCOI(SerializedHairPatternId IIIICGAEODJ, SerializedHairPatternId ELBIKJBAIEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8F94800", Offset = "0x8F93200", VA = "0x188F94800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CNAKNBPLFLB
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
		[Cpp2IlInjected.Address(RVA = "0x12D6120", Offset = "0x12D4B20", VA = "0x1812D6120", Slot = "6")]
		public Guid BAGEJBANCLB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E1FA60", Offset = "0x8E1E460", VA = "0x188E1FA60", Slot = "4")]
		public bool Equals(SerializedMaterialId GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F94870", Offset = "0x8F93270", VA = "0x188F94870", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x835F020", Offset = "0x835DA20", VA = "0x18835F020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x835EE90", Offset = "0x835D890", VA = "0x18835EE90", Slot = "5")]
		public int CompareTo(SerializedMaterialId GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F94910", Offset = "0x8F93310", VA = "0x188F94910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MMCFPACIGEJ : DLFALJHALEC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MMCFPACIGEJ FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F93D90", Offset = "0x8F92790", VA = "0x188F93D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FNNGFKJFEMK<KCNLPKHKIFL> DNFDLOEEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F93AF0", Offset = "0x8F924F0", VA = "0x188F93AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FNNGFKJFEMK<PBMBPKKKHDL> BBJEILNLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F93CD0", Offset = "0x8F926D0", VA = "0x188F93CD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FNNGFKJFEMK<PHIEDCFFKBA> MJNFDLCABLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F93B50", Offset = "0x8F92550", VA = "0x188F93B50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FNNGFKJFEMK<CKPKFPAKPLM> FEKMEOMCFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F93C70", Offset = "0x8F92670", VA = "0x188F93C70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FNNGFKJFEMK<PDKIOGIIPNG> JIAHBONGMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F93A90", Offset = "0x8F92490", VA = "0x188F93A90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FNNGFKJFEMK<HEKFPEMBJAL> FMMOCDBCOID
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F93C10", Offset = "0x8F92610", VA = "0x188F93C10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FNNGFKJFEMK<KIAKNBOHMJA> HNKFIOLMLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F93BB0", Offset = "0x8F925B0", VA = "0x188F93BB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FNNGFKJFEMK<IBNJPOEEICJ> EAABMNKOKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F93D30", Offset = "0x8F92730", VA = "0x188F93D30", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KLEJCLECEOM
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8F8FDE0", Offset = "0x8F8E7E0", VA = "0x188F8FDE0")]
	public static Guid MPGLLAGPCMA(string MMJJJBEDOCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8F8FD10", Offset = "0x8F8E710", VA = "0x188F8FD10")]
	public static bool EMJGACABFEC(string MMJJJBEDOCH, [Out] Guid OCONCDFGCOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ICMJDAICCBP : BHJPIPMDHIO<KCNLPKHKIFL>, BINMOCKBKFH<KCNLPKHKIFL>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8F89A10", Offset = "0x8F88410", VA = "0x188F89A10", Slot = "4")]
	public IEnumerable<(KCNLPKHKIFL, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8F8E660", Offset = "0x8F8D060", VA = "0x188F8E660", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public KCNLPKHKIFL ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(KCNLPKHKIFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ICMJDAICCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JBEIIFCCGLE : BHJPIPMDHIO<KIAKNBOHMJA>, BINMOCKBKFH<KIAKNBOHMJA>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8F8EBD0", Offset = "0x8F8D5D0", VA = "0x188F8EBD0", Slot = "4")]
	public IEnumerable<(KIAKNBOHMJA, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public KIAKNBOHMJA ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(KIAKNBOHMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JBEIIFCCGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LKIBNOKLOEG : BHJPIPMDHIO<PDKIOGIIPNG>, BINMOCKBKFH<PDKIOGIIPNG>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8F919D0", Offset = "0x8F903D0", VA = "0x188F919D0", Slot = "4")]
	public IEnumerable<(PDKIOGIIPNG, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public PDKIOGIIPNG ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(PDKIOGIIPNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LKIBNOKLOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KOEPDLCBDBI : BHJPIPMDHIO<CKPKFPAKPLM>, BINMOCKBKFH<CKPKFPAKPLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly BINMOCKBKFH<IPHCCDLOJNC> ADCEAIBPCLK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public KOEPDLCBDBI(BINMOCKBKFH<IPHCCDLOJNC> ADCEAIBPCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8E21300", Offset = "0x8E1FD00", VA = "0x188E21300", Slot = "4")]
	public IEnumerable<(CKPKFPAKPLM, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8F8FED0", Offset = "0x8F8E8D0", VA = "0x188F8FED0", Slot = "6")]
	public CKPKFPAKPLM ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(CKPKFPAKPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8F8FE90", Offset = "0x8F8E890", VA = "0x188F8FE90", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IBAONANEMIM : BHJPIPMDHIO<PBMBPKKKHDL>, BINMOCKBKFH<PBMBPKKKHDL>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8F81E00", Offset = "0x8F80800", VA = "0x188F81E00", Slot = "4")]
	public IEnumerable<(PBMBPKKKHDL, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public PBMBPKKKHDL ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(PBMBPKKKHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public IBAONANEMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LFMIONBIEAC : BHJPIPMDHIO<IBNJPOEEICJ>, BINMOCKBKFH<IBNJPOEEICJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8F90110", Offset = "0x8F8EB10", VA = "0x188F90110", Slot = "4")]
	public IEnumerable<(IBNJPOEEICJ, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public IBNJPOEEICJ ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(IBNJPOEEICJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LFMIONBIEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JNPLPLJCFKB : BHJPIPMDHIO<HEKFPEMBJAL>, BINMOCKBKFH<HEKFPEMBJAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8F8F8F0", Offset = "0x8F8E2F0", VA = "0x188F8F8F0", Slot = "4")]
	public IEnumerable<(HEKFPEMBJAL, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public HEKFPEMBJAL ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(HEKFPEMBJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JNPLPLJCFKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EHNEFPPNICH : BHJPIPMDHIO<PHIEDCFFKBA>, BINMOCKBKFH<PHIEDCFFKBA>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8F816C0", Offset = "0x8F800C0", VA = "0x188F816C0", Slot = "4")]
	public IEnumerable<(PHIEDCFFKBA, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public PHIEDCFFKBA ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(PHIEDCFFKBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EHNEFPPNICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BHJPIPMDHIO<TModern> : BINMOCKBKFH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> BGHOIEJGNEG();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HJKEBABKIMC(string CGEELNBKPAP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LAPOKMMJALA : BHJPIPMDHIO<IPHCCDLOJNC>, BINMOCKBKFH<IPHCCDLOJNC>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6420", Offset = "0x8ED4E20", VA = "0x188ED6420", Slot = "4")]
	public IEnumerable<(IPHCCDLOJNC, string)> BGHOIEJGNEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "5")]
	public string HJKEBABKIMC(string CGEELNBKPAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8F81D40", Offset = "0x8F80740", VA = "0x188F81D40", Slot = "6")]
	public IPHCCDLOJNC ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return default(IPHCCDLOJNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public LAPOKMMJALA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ECFGGIBDHLO<TModern> : FNNGFKJFEMK<TModern>, BINMOCKBKFH<TModern> where TModern : IEquatable<TModern>, CNAKNBPLFLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> LDOLHCPOPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> FABCAHBAFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BHJPIPMDHIO<TModern> JEIFEFMANCN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA050", Offset = "0x4AF8A50", VA = "0x184AFA050")]
	public ECFGGIBDHLO(BHJPIPMDHIO<TModern> JEIFEFMANCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4AF79E0", Offset = "0x4AF63E0", VA = "0x184AF79E0", Slot = "5")]
	public TModern ONCPAPLLLAB(string CGEELNBKPAP)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4AF69A0", Offset = "0x4AF53A0", VA = "0x184AF69A0", Slot = "4")]
	public string OGNINEAIHHN(TModern EIDBJPKJMKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IKAKEGKCNOK : DLFALJHALEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private ECFGGIBDHLO<KCNLPKHKIFL> LADDIDNHOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private ECFGGIBDHLO<PBMBPKKKHDL> GNNKFONEOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ECFGGIBDHLO<PHIEDCFFKBA> JMDNMCACLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ECFGGIBDHLO<IPHCCDLOJNC> ADCEAIBPCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ECFGGIBDHLO<CKPKFPAKPLM> GGKAHDGHHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private ECFGGIBDHLO<PDKIOGIIPNG> INCJEKHKJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private ECFGGIBDHLO<HEKFPEMBJAL> FENIAMFOHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ECFGGIBDHLO<KIAKNBOHMJA> HOOHMEJOCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ECFGGIBDHLO<IBNJPOEEICJ> MJMFGHEPHBM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FNNGFKJFEMK<KCNLPKHKIFL> DNFDLOEEDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FNNGFKJFEMK<PBMBPKKKHDL> BBJEILNLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FNNGFKJFEMK<PHIEDCFFKBA> MJNFDLCABLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FNNGFKJFEMK<CKPKFPAKPLM> FEKMEOMCFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FNNGFKJFEMK<PDKIOGIIPNG> JIAHBONGMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FNNGFKJFEMK<HEKFPEMBJAL> FMMOCDBCOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FNNGFKJFEMK<KIAKNBOHMJA> HNKFIOLMLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FNNGFKJFEMK<IBNJPOEEICJ> EAABMNKOKFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8F8E680", Offset = "0x8F8D080", VA = "0x188F8E680")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	[UsedImplicitly]
	internal static void NJIHGMBMMOP(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8F8E6F0", Offset = "0x8F8D0F0", VA = "0x188F8E6F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IKAKEGKCNOK()
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
