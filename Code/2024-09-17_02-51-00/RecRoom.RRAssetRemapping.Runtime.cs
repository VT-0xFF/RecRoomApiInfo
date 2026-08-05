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
		[Cpp2IlInjected.Address(RVA = "0x74F19D0", Offset = "0x74F03D0", VA = "0x1874F19D0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
	[Cpp2IlInjected.Address(RVA = "0x74E6960", Offset = "0x74E5360", VA = "0x1874E6960")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void LJBMCKAFLEE(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74E6900", Offset = "0x74E5300", VA = "0x1874E6900")]
	[UsedImplicitly]
	internal static void FNCMOKFDBOB(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public INGGFNDFFCH([OLJNBPOCBCJ(null)] IKLEIDMNHGJ BAPPMIGDNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74E60F0", Offset = "0x74E4AF0", VA = "0x1874E60F0", Slot = "4")]
	public string AMCHBAGBIFH(EBOIDAOENMM DIGEGMNKCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74E6430", Offset = "0x74E4E30", VA = "0x1874E6430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
		public SerializedAvatarItemId(EHINIDBNANO MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public EHINIDBNANO CENBFOHJAFB()
		{
			return default(EHINIDBNANO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedAvatarItemId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74F0EB0", Offset = "0x74EF8B0", VA = "0x1874F0EB0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F70", Offset = "0x74EF970", VA = "0x1874F0F70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public NCHIFEMIBHL CENBFOHJAFB()
		{
			return default(NCHIFEMIBHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedBodyShapeId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74F0FE0", Offset = "0x74EF9E0", VA = "0x1874F0FE0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74F1080", Offset = "0x74EFA80", VA = "0x1874F1080", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public IBPLBEBNLMD CENBFOHJAFB()
		{
			return default(IBPLBEBNLMD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedColorId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedColorId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74F10F0", Offset = "0x74EFAF0", VA = "0x1874F10F0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74F1190", Offset = "0x74EFB90", VA = "0x1874F1190", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20")]
		public PELNEICAOKM CENBFOHJAFB()
		{
			return default(PELNEICAOKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74F1330", Offset = "0x74EFD30", VA = "0x1874F1330")]
		public SerializedCombinationId(PELNEICAOKM JFPBOCJOGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x737FE80", Offset = "0x737E880", VA = "0x18737FE80", Slot = "4")]
		public bool Equals(SerializedCombinationId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74F1200", Offset = "0x74EFC00", VA = "0x1874F1200", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedCombinationId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74F12C0", Offset = "0x74EFCC0", VA = "0x1874F12C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74F12B0", Offset = "0x74EFCB0", VA = "0x1874F12B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
		public SerializedCustomAvatarItemId(Guid GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74F1340", Offset = "0x74EFD40", VA = "0x1874F1340", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50")]
		public static bool MNAFCOICNLK(SerializedCustomAvatarItemId NFCDCHABNCB, SerializedCustomAvatarItemId BCBMNIEKAKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74F13E0", Offset = "0x74EFDE0", VA = "0x1874F13E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x74F14F0", Offset = "0x74EFEF0", VA = "0x1874F14F0")]
		public static SerializedEquipmentSkinId GKHIPBPIAPM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public HIKPLHMBBLA CENBFOHJAFB()
		{
			return default(HIKPLHMBBLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74F1450", Offset = "0x74EFE50", VA = "0x1874F1450", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74F1520", Offset = "0x74EFF20", VA = "0x1874F1520", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public DFIACMOLAPM CENBFOHJAFB()
		{
			return default(DFIACMOLAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74F1590", Offset = "0x74EFF90", VA = "0x1874F1590", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74F1630", Offset = "0x74F0030", VA = "0x1874F1630", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public OAGOEKHDGKK CENBFOHJAFB()
		{
			return default(OAGOEKHDGKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedFaceShapeId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74F16A0", Offset = "0x74F00A0", VA = "0x1874F16A0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74F1740", Offset = "0x74F0140", VA = "0x1874F1740", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		public PJKGNECFBON CENBFOHJAFB()
		{
			return default(PJKGNECFBON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50", Slot = "4")]
		public bool Equals(SerializedHairPatternId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74F17B0", Offset = "0x74F01B0", VA = "0x1874F17B0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74F0F50", Offset = "0x74EF950", VA = "0x1874F0F50")]
		public static bool MNAFCOICNLK(SerializedHairPatternId NFCDCHABNCB, SerializedHairPatternId BCBMNIEKAKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74F1850", Offset = "0x74F0250", VA = "0x1874F1850", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC4C970", Offset = "0xC4B370", VA = "0x180C4C970")]
		public SerializedMaterialId(OBAADAMJMCC MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960", Slot = "6")]
		public Guid CPCFJABKHLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x737FE80", Offset = "0x737E880", VA = "0x18737FE80", Slot = "4")]
		public bool Equals(SerializedMaterialId PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74F18C0", Offset = "0x74F02C0", VA = "0x1874F18C0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCDD660", Offset = "0xCDC060", VA = "0x180CDD660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCDD4D0", Offset = "0xCDBED0", VA = "0x180CDD4D0", Slot = "5")]
		public int CompareTo(SerializedMaterialId PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x74F1960", Offset = "0x74F0360", VA = "0x1874F1960", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x74E75C0", Offset = "0x74E5FC0", VA = "0x1874E75C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NBNELONLMLH<EHINIDBNANO> KHOBNAPJECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x74E7800", Offset = "0x74E6200", VA = "0x1874E7800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NBNELONLMLH<HIKPLHMBBLA> GGIJEGCALME
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x74E7740", Offset = "0x74E6140", VA = "0x1874E7740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NBNELONLMLH<PJKGNECFBON> HFOCFHACDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74E7560", Offset = "0x74E5F60", VA = "0x1874E7560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NBNELONLMLH<PELNEICAOKM> PCODLKCIMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x74E7620", Offset = "0x74E6020", VA = "0x1874E7620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NBNELONLMLH<IBPLBEBNLMD> BIGFPKNDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74E7680", Offset = "0x74E6080", VA = "0x1874E7680", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NBNELONLMLH<OAGOEKHDGKK> NKKINHBECDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x74E7500", Offset = "0x74E5F00", VA = "0x1874E7500", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NBNELONLMLH<NCHIFEMIBHL> DBJOMKCGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74E76E0", Offset = "0x74E60E0", VA = "0x1874E76E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NBNELONLMLH<DFIACMOLAPM> MPMIPMMIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74E77A0", Offset = "0x74E61A0", VA = "0x1874E77A0", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x74E7860", Offset = "0x74E6260", VA = "0x1874E7860")]
	public static Guid CMDJIMAGCEB(string GBDCKEINLDD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74E7910", Offset = "0x74E6310", VA = "0x1874E7910")]
	public static bool INNJCGCEMGA(string GBDCKEINLDD, [Out] Guid GDCMEHKEAMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DDBFGAGFLON : HFHKPGNNIKC<EHINIDBNANO>, NIEIFGIJBPP<EHINIDBNANO>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74DF140", Offset = "0x74DDB40", VA = "0x1874DF140", Slot = "4")]
	public IEnumerable<(EHINIDBNANO, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74E3D90", Offset = "0x74E2790", VA = "0x1874E3D90", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public EHINIDBNANO NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(EHINIDBNANO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public DDBFGAGFLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BOPNECFBKBO : HFHKPGNNIKC<NCHIFEMIBHL>, NIEIFGIJBPP<NCHIFEMIBHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74DEDA0", Offset = "0x74DD7A0", VA = "0x1874DEDA0", Slot = "4")]
	public IEnumerable<(NCHIFEMIBHL, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public NCHIFEMIBHL NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(NCHIFEMIBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public BOPNECFBKBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GGIBLLPBDGG : HFHKPGNNIKC<IBPLBEBNLMD>, NIEIFGIJBPP<IBPLBEBNLMD>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74E4030", Offset = "0x74E2A30", VA = "0x1874E4030", Slot = "4")]
	public IEnumerable<(IBPLBEBNLMD, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public IBPLBEBNLMD NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(IBPLBEBNLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public FFHIFKBJJDE(NIEIFGIJBPP<OBAADAMJMCC> IHBNJCHMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7380260", Offset = "0x737EC60", VA = "0x187380260", Slot = "4")]
	public IEnumerable<(PELNEICAOKM, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74E3DB0", Offset = "0x74E27B0", VA = "0x1874E3DB0", Slot = "6")]
	public PELNEICAOKM NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(PELNEICAOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74E3FF0", Offset = "0x74E29F0", VA = "0x1874E3FF0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OJEJCNNNJCM : HFHKPGNNIKC<HIKPLHMBBLA>, NIEIFGIJBPP<HIKPLHMBBLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74E79E0", Offset = "0x74E63E0", VA = "0x1874E79E0", Slot = "4")]
	public IEnumerable<(HIKPLHMBBLA, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public HIKPLHMBBLA NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(HIKPLHMBBLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public OJEJCNNNJCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PIPFKGLNMDH : HFHKPGNNIKC<DFIACMOLAPM>, NIEIFGIJBPP<DFIACMOLAPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74EF5F0", Offset = "0x74EDFF0", VA = "0x1874EF5F0", Slot = "4")]
	public IEnumerable<(DFIACMOLAPM, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public DFIACMOLAPM NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(DFIACMOLAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public PIPFKGLNMDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MGLHDOLFNJA : HFHKPGNNIKC<OAGOEKHDGKK>, NIEIFGIJBPP<OAGOEKHDGKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74E70E0", Offset = "0x74E5AE0", VA = "0x1874E70E0", Slot = "4")]
	public IEnumerable<(OAGOEKHDGKK, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public OAGOEKHDGKK NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(OAGOEKHDGKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public MGLHDOLFNJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JDKDFHCDHIL : HFHKPGNNIKC<PJKGNECFBON>, NIEIFGIJBPP<PJKGNECFBON>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74E6A60", Offset = "0x74E5460", VA = "0x1874E6A60", Slot = "4")]
	public IEnumerable<(PJKGNECFBON, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public PJKGNECFBON NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(PJKGNECFBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x74343D0", Offset = "0x7432DD0", VA = "0x1874343D0", Slot = "4")]
	public IEnumerable<(OBAADAMJMCC, string)> JLGMIHKCGAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xCDF3E0", Offset = "0xCDDDE0", VA = "0x180CDF3E0", Slot = "5")]
	public string NNPCICFPCKJ(string LPMOOBPJNHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74DECE0", Offset = "0x74DD6E0", VA = "0x1874DECE0", Slot = "6")]
	public OBAADAMJMCC NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return default(OBAADAMJMCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5115460", Offset = "0x5113E60", VA = "0x185115460")]
	public BCMPMPGOLCI(HFHKPGNNIKC<TModern> HLDGNDBMKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5113A10", Offset = "0x5112410", VA = "0x185113A10", Slot = "5")]
	public TModern NJNDFGJBCAG(string LPMOOBPJNHL)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5112AC0", Offset = "0x51114C0", VA = "0x185112AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NBNELONLMLH<HIKPLHMBBLA> GGIJEGCALME
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NBNELONLMLH<PJKGNECFBON> HFOCFHACDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NBNELONLMLH<PELNEICAOKM> PCODLKCIMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NBNELONLMLH<IBPLBEBNLMD> BIGFPKNDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NBNELONLMLH<OAGOEKHDGKK> NKKINHBECDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NBNELONLMLH<NCHIFEMIBHL> DBJOMKCGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NBNELONLMLH<DFIACMOLAPM> MPMIPMMIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x74DE790", Offset = "0x74DD190", VA = "0x1874DE790")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void NKGNNKIFAJN(JEFLJDHAGDI FMBOKBBFBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74DE800", Offset = "0x74DD200", VA = "0x1874DE800")]
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
