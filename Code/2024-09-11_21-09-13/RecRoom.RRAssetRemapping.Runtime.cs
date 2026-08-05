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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74064D0", Offset = "0x7404AD0", VA = "0x1874064D0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class INGGFNDFFCH : BEECDDPFNOF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex KLPJKKGLDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IKLEIDMNHGJ BAPPMIGDNCN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73FB460", Offset = "0x73F9A60", VA = "0x1873FB460")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void LJBMCKAFLEE(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x73FB400", Offset = "0x73F9A00", VA = "0x1873FB400")]
	[UsedImplicitly]
	internal static void FNCMOKFDBOB(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public INGGFNDFFCH([OLJNBPOCBCJ(null)] IKLEIDMNHGJ BAPPMIGDNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x73FABF0", Offset = "0x73F91F0", VA = "0x1873FABF0", Slot = "4")]
	public string AMCHBAGBIFH(EBOIDAOENMM DIGEGMNKCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73FAF30", Offset = "0x73F9530", VA = "0x1873FAF30", Slot = "5")]
	public EBOIDAOENMM CENBFOHJAFB(string DIGEGMNKCOG)
	{
		return default(EBOIDAOENMM);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public SerializedAvatarItemId(EHINIDBNANO MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public EHINIDBNANO CENBFOHJAFB()
		{
			return default(EHINIDBNANO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedAvatarItemId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74059B0", Offset = "0x7403FB0", VA = "0x1874059B0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7405A70", Offset = "0x7404070", VA = "0x187405A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public NCHIFEMIBHL CENBFOHJAFB()
		{
			return default(NCHIFEMIBHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedBodyShapeId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7405AE0", Offset = "0x74040E0", VA = "0x187405AE0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7405B80", Offset = "0x7404180", VA = "0x187405B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public IBPLBEBNLMD CENBFOHJAFB()
		{
			return default(IBPLBEBNLMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedColorId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedColorId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7405BF0", Offset = "0x74041F0", VA = "0x187405BF0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7405C90", Offset = "0x7404290", VA = "0x187405C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, FFEKDPGODPD, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96B660", Offset = "0x969C60", VA = "0x18096B660")]
		public PELNEICAOKM CENBFOHJAFB()
		{
			return default(PELNEICAOKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7405E30", Offset = "0x7404430", VA = "0x187405E30")]
		public SerializedCombinationId(PELNEICAOKM JFPBOCJOGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7294980", Offset = "0x7292F80", VA = "0x187294980", Slot = "4")]
		public bool Equals(SerializedCombinationId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7405D00", Offset = "0x7404300", VA = "0x187405D00", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedCombinationId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7405DC0", Offset = "0x74043C0", VA = "0x187405DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7405DB0", Offset = "0x74043B0", VA = "0x187405DB0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public SerializedCustomAvatarItemId(Guid GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7405E40", Offset = "0x7404440", VA = "0x187405E40", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50")]
		public static bool MNAFCOICNLK(SerializedCustomAvatarItemId NFCDCHABNCB, SerializedCustomAvatarItemId BCBMNIEKAKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7405EE0", Offset = "0x74044E0", VA = "0x187405EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0x7405FF0", Offset = "0x74045F0", VA = "0x187405FF0")]
		public static SerializedEquipmentSkinId GKHIPBPIAPM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public HIKPLHMBBLA CENBFOHJAFB()
		{
			return default(HIKPLHMBBLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7405F50", Offset = "0x7404550", VA = "0x187405F50", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7406020", Offset = "0x7404620", VA = "0x187406020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public DFIACMOLAPM CENBFOHJAFB()
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7406090", Offset = "0x7404690", VA = "0x187406090", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7406130", Offset = "0x7404730", VA = "0x187406130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public OAGOEKHDGKK CENBFOHJAFB()
		{
			return default(OAGOEKHDGKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedFaceShapeId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74061A0", Offset = "0x74047A0", VA = "0x1874061A0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7406240", Offset = "0x7404840", VA = "0x187406240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50")]
		public PJKGNECFBON CENBFOHJAFB()
		{
			return default(PJKGNECFBON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50", Slot = "4")]
		public bool Equals(SerializedHairPatternId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedHairPatternId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74062B0", Offset = "0x74048B0", VA = "0x1874062B0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7405A50", Offset = "0x7404050", VA = "0x187405A50")]
		public static bool MNAFCOICNLK(SerializedHairPatternId NFCDCHABNCB, SerializedHairPatternId BCBMNIEKAKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7406350", Offset = "0x7404950", VA = "0x187406350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, FFEKDPGODPD
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
		[Cpp2IlInjected.Address(RVA = "0xB7DA60", Offset = "0xB7C060", VA = "0x180B7DA60")]
		public SerializedMaterialId(OBAADAMJMCC MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA50", Offset = "0xB7C050", VA = "0x180B7DA50", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7294980", Offset = "0x7292F80", VA = "0x187294980", Slot = "4")]
		public bool Equals(SerializedMaterialId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74063C0", Offset = "0x74049C0", VA = "0x1874063C0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC250D0", Offset = "0xC236D0", VA = "0x180C250D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC24F40", Offset = "0xC23540", VA = "0x180C24F40", Slot = "5")]
		public int CompareTo(SerializedMaterialId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7406460", Offset = "0x7404A60", VA = "0x187406460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MLCDNHDGJOO : IKLEIDMNHGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MLCDNHDGJOO DFEEMNKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73FC0C0", Offset = "0x73FA6C0", VA = "0x1873FC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NBNELONLMLH<EHINIDBNANO> KHOBNAPJECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73FC300", Offset = "0x73FA900", VA = "0x1873FC300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NBNELONLMLH<HIKPLHMBBLA> GGIJEGCALME
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73FC240", Offset = "0x73FA840", VA = "0x1873FC240", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NBNELONLMLH<PJKGNECFBON> HFOCFHACDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x73FC060", Offset = "0x73FA660", VA = "0x1873FC060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NBNELONLMLH<PELNEICAOKM> PCODLKCIMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x73FC120", Offset = "0x73FA720", VA = "0x1873FC120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NBNELONLMLH<IBPLBEBNLMD> BIGFPKNDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x73FC180", Offset = "0x73FA780", VA = "0x1873FC180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NBNELONLMLH<OAGOEKHDGKK> NKKINHBECDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73FC000", Offset = "0x73FA600", VA = "0x1873FC000", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NBNELONLMLH<NCHIFEMIBHL> DBJOMKCGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73FC1E0", Offset = "0x73FA7E0", VA = "0x1873FC1E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NBNELONLMLH<DFIACMOLAPM> MPMIPMMIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73FC2A0", Offset = "0x73FA8A0", VA = "0x1873FC2A0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NAKMBPGIIFO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73FC360", Offset = "0x73FA960", VA = "0x1873FC360")]
	public static Guid CMDJIMAGCEB(string GBDCKEINLDD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73FC410", Offset = "0x73FAA10", VA = "0x1873FC410")]
	public static bool INNJCGCEMGA(string GBDCKEINLDD, [Out] Guid GDCMEHKEAMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DDBFGAGFLON : HFHKPGNNIKC<EHINIDBNANO>, NIEIFGIJBPP<EHINIDBNANO>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x73F3C40", Offset = "0x73F2240", VA = "0x1873F3C40", Slot = "4")]
	public IEnumerable<(EHINIDBNANO, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x73F8890", Offset = "0x73F6E90", VA = "0x1873F8890", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public EHINIDBNANO NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(EHINIDBNANO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public DDBFGAGFLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BOPNECFBKBO : HFHKPGNNIKC<NCHIFEMIBHL>, NIEIFGIJBPP<NCHIFEMIBHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x73F38A0", Offset = "0x73F1EA0", VA = "0x1873F38A0", Slot = "4")]
	public IEnumerable<(NCHIFEMIBHL, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public NCHIFEMIBHL NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(NCHIFEMIBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public BOPNECFBKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GGIBLLPBDGG : HFHKPGNNIKC<IBPLBEBNLMD>, NIEIFGIJBPP<IBPLBEBNLMD>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73F8B30", Offset = "0x73F7130", VA = "0x1873F8B30", Slot = "4")]
	public IEnumerable<(IBPLBEBNLMD, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public IBPLBEBNLMD NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(IBPLBEBNLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public GGIBLLPBDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FFHIFKBJJDE : HFHKPGNNIKC<PELNEICAOKM>, NIEIFGIJBPP<PELNEICAOKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly NIEIFGIJBPP<OBAADAMJMCC> IHBNJCHMJOI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8842A0", Offset = "0x8828A0", VA = "0x1808842A0")]
	public FFHIFKBJJDE(NIEIFGIJBPP<OBAADAMJMCC> IHBNJCHMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7294D60", Offset = "0x7293360", VA = "0x187294D60", Slot = "4")]
	public IEnumerable<(PELNEICAOKM, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73F88B0", Offset = "0x73F6EB0", VA = "0x1873F88B0", Slot = "6")]
	public PELNEICAOKM NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(PELNEICAOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x73F8AF0", Offset = "0x73F70F0", VA = "0x1873F8AF0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OJEJCNNNJCM : HFHKPGNNIKC<HIKPLHMBBLA>, NIEIFGIJBPP<HIKPLHMBBLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73FC4E0", Offset = "0x73FAAE0", VA = "0x1873FC4E0", Slot = "4")]
	public IEnumerable<(HIKPLHMBBLA, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public HIKPLHMBBLA NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(HIKPLHMBBLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public OJEJCNNNJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PIPFKGLNMDH : HFHKPGNNIKC<DFIACMOLAPM>, NIEIFGIJBPP<DFIACMOLAPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74040F0", Offset = "0x74026F0", VA = "0x1874040F0", Slot = "4")]
	public IEnumerable<(DFIACMOLAPM, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public DFIACMOLAPM NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(DFIACMOLAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public PIPFKGLNMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MGLHDOLFNJA : HFHKPGNNIKC<OAGOEKHDGKK>, NIEIFGIJBPP<OAGOEKHDGKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73FBBE0", Offset = "0x73FA1E0", VA = "0x1873FBBE0", Slot = "4")]
	public IEnumerable<(OAGOEKHDGKK, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public OAGOEKHDGKK NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(OAGOEKHDGKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public MGLHDOLFNJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JDKDFHCDHIL : HFHKPGNNIKC<PJKGNECFBON>, NIEIFGIJBPP<PJKGNECFBON>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x73FB560", Offset = "0x73F9B60", VA = "0x1873FB560", Slot = "4")]
	public IEnumerable<(PJKGNECFBON, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public PJKGNECFBON NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(PJKGNECFBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JDKDFHCDHIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HFHKPGNNIKC<TModern> : NIEIFGIJBPP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JLGMIHKCGAP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NNPCICFPCKJ(string LPMOOBPJNHL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AIGCCKNDHOI : HFHKPGNNIKC<OBAADAMJMCC>, NIEIFGIJBPP<OBAADAMJMCC>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7348ED0", Offset = "0x73474D0", VA = "0x187348ED0", Slot = "4")]
	public IEnumerable<(OBAADAMJMCC, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC26E50", Offset = "0xC25450", VA = "0x180C26E50", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x73F37E0", Offset = "0x73F1DE0", VA = "0x1873F37E0", Slot = "6")]
	public OBAADAMJMCC NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(OBAADAMJMCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public AIGCCKNDHOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BCMPMPGOLCI<TModern> : NBNELONLMLH<TModern>, NIEIFGIJBPP<TModern> where TModern : IEquatable<TModern>, FFEKDPGODPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> KDOLOGNHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IEGHNMDPHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HFHKPGNNIKC<TModern> HLDGNDBMKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5032470", Offset = "0x5030A70", VA = "0x185032470")]
	public BCMPMPGOLCI(HFHKPGNNIKC<TModern> HLDGNDBMKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5030A20", Offset = "0x502F020", VA = "0x185030A20", Slot = "5")]
	public TModern NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x502FAD0", Offset = "0x502E0D0", VA = "0x18502FAD0", Slot = "4")]
	public string EIBNLPNKOCH(TModern JNKCIMIMFPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AECLMLALOLF : IKLEIDMNHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private BCMPMPGOLCI<EHINIDBNANO> CCMOBIGMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BCMPMPGOLCI<HIKPLHMBBLA> KBMAKAELKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BCMPMPGOLCI<PJKGNECFBON> NBLFGLCMFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BCMPMPGOLCI<OBAADAMJMCC> IHBNJCHMJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BCMPMPGOLCI<PELNEICAOKM> GEIOKBHEIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BCMPMPGOLCI<IBPLBEBNLMD> LECMDHFICLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BCMPMPGOLCI<OAGOEKHDGKK> APBFJINCJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BCMPMPGOLCI<NCHIFEMIBHL> IOBJGIEDILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BCMPMPGOLCI<DFIACMOLAPM> OKANMLKCDCF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NBNELONLMLH<EHINIDBNANO> KHOBNAPJECF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NBNELONLMLH<HIKPLHMBBLA> GGIJEGCALME
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NBNELONLMLH<PJKGNECFBON> HFOCFHACDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NBNELONLMLH<PELNEICAOKM> PCODLKCIMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NBNELONLMLH<IBPLBEBNLMD> BIGFPKNDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NBNELONLMLH<OAGOEKHDGKK> NKKINHBECDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NBNELONLMLH<NCHIFEMIBHL> DBJOMKCGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NBNELONLMLH<DFIACMOLAPM> MPMIPMMIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8868B0", Offset = "0x884EB0", VA = "0x1808868B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73F3290", Offset = "0x73F1890", VA = "0x1873F3290")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void NKGNNKIFAJN(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73F3300", Offset = "0x73F1900", VA = "0x1873F3300")]
	[RecRoom.NoEngine.Common.Preserve]
	public AECLMLALOLF()
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
