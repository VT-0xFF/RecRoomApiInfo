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
		[Cpp2IlInjected.Address(RVA = "0x785F6C0", Offset = "0x785DEC0", VA = "0x18785F6C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MMGKALBANJB : FDDHAHKIEBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NLKKJJNBGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly ONADJBIIBGG LDJPLKPGKDN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x785E380", Offset = "0x785CB80", VA = "0x18785E380")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	[UsedImplicitly]
	internal static void NJDIOBPBJFD(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x785DB10", Offset = "0x785C310", VA = "0x18785DB10")]
	[UsedImplicitly]
	internal static void IDNKNAFHBDF(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMGKALBANJB([NDCFMLCHJCI(null)] ONADJBIIBGG LDJPLKPGKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x785DB70", Offset = "0x785C370", VA = "0x18785DB70", Slot = "4")]
	public string KBGBIJFEDIC(IHDHEKBLLBJ AOJEAJGBMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x785DEB0", Offset = "0x785C6B0", VA = "0x18785DEB0", Slot = "5")]
	public IHDHEKBLLBJ KDFBDMHOPOO(string AOJEAJGBMCP)
	{
		return default(IHDHEKBLLBJ);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NLLKPNMALIA
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
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public MCDELACKOKB KDFBDMHOPOO()
		{
			return default(MCDELACKOKB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x785EB90", Offset = "0x785D390", VA = "0x18785EB90", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x785EC50", Offset = "0x785D450", VA = "0x18785EC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NLLKPNMALIA
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
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public FFDNFNMJGGE KDFBDMHOPOO()
		{
			return default(FFDNFNMJGGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x785ECC0", Offset = "0x785D4C0", VA = "0x18785ECC0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x785ED60", Offset = "0x785D560", VA = "0x18785ED60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NLLKPNMALIA
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
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public DEBOPKMJAMH KDFBDMHOPOO()
		{
			return default(DEBOPKMJAMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedColorId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedColorId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x785EDD0", Offset = "0x785D5D0", VA = "0x18785EDD0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x785EE70", Offset = "0x785D670", VA = "0x18785EE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NLLKPNMALIA, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30")]
		public HMKFGHFJBCL KDFBDMHOPOO()
		{
			return default(HMKFGHFJBCL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76EADF0", Offset = "0x76E95F0", VA = "0x1876EADF0", Slot = "4")]
		public bool Equals(SerializedCombinationId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x785EEE0", Offset = "0x785D6E0", VA = "0x18785EEE0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedCombinationId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x785EFA0", Offset = "0x785D7A0", VA = "0x18785EFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x785EF90", Offset = "0x785D790", VA = "0x18785EF90", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NLLKPNMALIA
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
		[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
		public SerializedCustomAvatarItemId(Guid PLMJELCKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x785F030", Offset = "0x785D830", VA = "0x18785F030", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30")]
		public static bool PCBECHOJFKF(SerializedCustomAvatarItemId CBNNCMPLCDK, SerializedCustomAvatarItemId OKJLFDLNFEM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x785F010", Offset = "0x785D810", VA = "0x18785F010")]
		public static bool DJBIFFEEEPL(SerializedCustomAvatarItemId CBNNCMPLCDK, SerializedCustomAvatarItemId OKJLFDLNFEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x785F0D0", Offset = "0x785D8D0", VA = "0x18785F0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NLLKPNMALIA
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

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x785F140", Offset = "0x785D940", VA = "0x18785F140")]
		public static SerializedEquipmentSkinId EOKKIGEOCFN()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public FLPCDAIJLMJ KDFBDMHOPOO()
		{
			return default(FLPCDAIJLMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x785F170", Offset = "0x785D970", VA = "0x18785F170", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x785F210", Offset = "0x785DA10", VA = "0x18785F210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NLLKPNMALIA
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

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public ILOBAEFMBMP KDFBDMHOPOO()
		{
			return default(ILOBAEFMBMP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x785F280", Offset = "0x785DA80", VA = "0x18785F280", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x785F320", Offset = "0x785DB20", VA = "0x18785F320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NLLKPNMALIA
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

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public CBCPFENGCGJ KDFBDMHOPOO()
		{
			return default(CBCPFENGCGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x785F390", Offset = "0x785DB90", VA = "0x18785F390", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x785F430", Offset = "0x785DC30", VA = "0x18785F430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NLLKPNMALIA
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

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public EPONLFNHFNM KDFBDMHOPOO()
		{
			return default(EPONLFNHFNM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30", Slot = "4")]
		public bool Equals(SerializedHairPatternId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x785F4A0", Offset = "0x785DCA0", VA = "0x18785F4A0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x785EC30", Offset = "0x785D430", VA = "0x18785EC30")]
		public static bool PCBECHOJFKF(SerializedHairPatternId CBNNCMPLCDK, SerializedHairPatternId OKJLFDLNFEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x785F540", Offset = "0x785DD40", VA = "0x18785F540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NLLKPNMALIA
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

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430", Slot = "6")]
		public Guid HHEEMJGJJOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76EADF0", Offset = "0x76E95F0", VA = "0x1876EADF0", Slot = "4")]
		public bool Equals(SerializedMaterialId LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x785F5B0", Offset = "0x785DDB0", VA = "0x18785F5B0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6DE92E0", Offset = "0x6DE7AE0", VA = "0x186DE92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9150", Offset = "0x6DE7950", VA = "0x186DE9150", Slot = "5")]
		public int CompareTo(SerializedMaterialId LIHCAHPMPHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x785F650", Offset = "0x785DE50", VA = "0x18785F650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OLIFHLGNGEJ : ONADJBIIBGG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OLIFHLGNGEJ ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x785E8F0", Offset = "0x785D0F0", VA = "0x18785E8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IOIPIFNBCPB<MCDELACKOKB> GIPJIMECOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x785E890", Offset = "0x785D090", VA = "0x18785E890", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IOIPIFNBCPB<FLPCDAIJLMJ> FAPNFFFMBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x785E950", Offset = "0x785D150", VA = "0x18785E950", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IOIPIFNBCPB<EPONLFNHFNM> DOGEFPBJILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x785EAD0", Offset = "0x785D2D0", VA = "0x18785EAD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IOIPIFNBCPB<HMKFGHFJBCL> LGKBAJJJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x785E830", Offset = "0x785D030", VA = "0x18785E830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IOIPIFNBCPB<DEBOPKMJAMH> NMCIDKEIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x785E9B0", Offset = "0x785D1B0", VA = "0x18785E9B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IOIPIFNBCPB<CBCPFENGCGJ> FDIBNELBECO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x785EA10", Offset = "0x785D210", VA = "0x18785EA10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IOIPIFNBCPB<FFDNFNMJGGE> OEGKHGBLHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x785EA70", Offset = "0x785D270", VA = "0x18785EA70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IOIPIFNBCPB<ILOBAEFMBMP> LEGJKABBPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x785EB30", Offset = "0x785D330", VA = "0x18785EB30", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EPGENKGOKNA
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7856DC0", Offset = "0x78555C0", VA = "0x187856DC0")]
	public static Guid BMGIIDKEPKB(string EHCKNNHMLLC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7856E70", Offset = "0x7855670", VA = "0x187856E70")]
	public static bool PFJDIGIPKMO(string EHCKNNHMLLC, [Out] Guid PLMJELCKKDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GIDGJJEIHEB : KBLLOIHBAJN<MCDELACKOKB>, JCGDANJMMEE<MCDELACKOKB>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7856F60", Offset = "0x7855760", VA = "0x187856F60", Slot = "4")]
	public IEnumerable<(MCDELACKOKB, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7856F40", Offset = "0x7855740", VA = "0x187856F40", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public MCDELACKOKB EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(MCDELACKOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public GIDGJJEIHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NGPKGPIAGEK : KBLLOIHBAJN<FFDNFNMJGGE>, JCGDANJMMEE<FFDNFNMJGGE>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x785E490", Offset = "0x785CC90", VA = "0x18785E490", Slot = "4")]
	public IEnumerable<(FFDNFNMJGGE, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public FFDNFNMJGGE EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(FFDNFNMJGGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public NGPKGPIAGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CHLKKEOEOGF : KBLLOIHBAJN<DEBOPKMJAMH>, JCGDANJMMEE<DEBOPKMJAMH>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x784D0F0", Offset = "0x784B8F0", VA = "0x18784D0F0", Slot = "4")]
	public IEnumerable<(DEBOPKMJAMH, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public DEBOPKMJAMH EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(DEBOPKMJAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CHLKKEOEOGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MGLIFNDCLIH : KBLLOIHBAJN<HMKFGHFJBCL>, JCGDANJMMEE<HMKFGHFJBCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JCGDANJMMEE<BIDOOOJOKHK> NEPHKOENOLA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public MGLIFNDCLIH(JCGDANJMMEE<BIDOOOJOKHK> NEPHKOENOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x76EC0A0", Offset = "0x76EA8A0", VA = "0x1876EC0A0", Slot = "4")]
	public IEnumerable<(HMKFGHFJBCL, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x785D8D0", Offset = "0x785C0D0", VA = "0x18785D8D0", Slot = "6")]
	public HMKFGHFJBCL EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(HMKFGHFJBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x785D890", Offset = "0x785C090", VA = "0x18785D890", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DEDOPJDEGAK : KBLLOIHBAJN<FLPCDAIJLMJ>, JCGDANJMMEE<FLPCDAIJLMJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x784F1B0", Offset = "0x784D9B0", VA = "0x18784F1B0", Slot = "4")]
	public IEnumerable<(FLPCDAIJLMJ, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public FLPCDAIJLMJ EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(FLPCDAIJLMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public DEDOPJDEGAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JJCKKNNDCFJ : KBLLOIHBAJN<ILOBAEFMBMP>, JCGDANJMMEE<ILOBAEFMBMP>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x785BBB0", Offset = "0x785A3B0", VA = "0x18785BBB0", Slot = "4")]
	public IEnumerable<(ILOBAEFMBMP, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public ILOBAEFMBMP EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(ILOBAEFMBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public JJCKKNNDCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LKANFDMGGKK : KBLLOIHBAJN<CBCPFENGCGJ>, JCGDANJMMEE<CBCPFENGCGJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x785D470", Offset = "0x785BC70", VA = "0x18785D470", Slot = "4")]
	public IEnumerable<(CBCPFENGCGJ, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public CBCPFENGCGJ EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(CBCPFENGCGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public LKANFDMGGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ADLKDCHHAMG : KBLLOIHBAJN<EPONLFNHFNM>, JCGDANJMMEE<EPONLFNHFNM>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x784C520", Offset = "0x784AD20", VA = "0x18784C520", Slot = "4")]
	public IEnumerable<(EPONLFNHFNM, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public EPONLFNHFNM EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(EPONLFNHFNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public ADLKDCHHAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBLLOIHBAJN<TModern> : JCGDANJMMEE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> ODLOKHCGDPH();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AEFEAOKJLKJ(string CDCHKCNGEMF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MLHOMFFPIMH : KBLLOIHBAJN<BIDOOOJOKHK>, JCGDANJMMEE<BIDOOOJOKHK>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x77A11C0", Offset = "0x779F9C0", VA = "0x1877A11C0", Slot = "4")]
	public IEnumerable<(BIDOOOJOKHK, string)> ODLOKHCGDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA3B090", Offset = "0xA39890", VA = "0x180A3B090", Slot = "5")]
	public string AEFEAOKJLKJ(string CDCHKCNGEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x784C460", Offset = "0x784AC60", VA = "0x18784C460", Slot = "6")]
	public BIDOOOJOKHK EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return default(BIDOOOJOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public MLHOMFFPIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IPLIDNCIBDM<TModern> : IOIPIFNBCPB<TModern>, JCGDANJMMEE<TModern> where TModern : IEquatable<TModern>, NLLKPNMALIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> ICDDDLJOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> EMEJMMBACHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KBLLOIHBAJN<TModern> OCCLCNGAHNN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x43466A0", Offset = "0x4344EA0", VA = "0x1843466A0")]
	public IPLIDNCIBDM(KBLLOIHBAJN<TModern> OCCLCNGAHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4344D60", Offset = "0x4343560", VA = "0x184344D60", Slot = "5")]
	public TModern EJPNLMAGLIE(string CDCHKCNGEMF)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4345C20", Offset = "0x4344420", VA = "0x184345C20", Slot = "4")]
	public string NANLLNJLBEB(TModern COAJHMPKOBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BJDIFGNBHIJ : ONADJBIIBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IPLIDNCIBDM<MCDELACKOKB> EKPHGCNBOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IPLIDNCIBDM<FLPCDAIJLMJ> OJOJBGNELOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IPLIDNCIBDM<EPONLFNHFNM> EIGGDELJDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IPLIDNCIBDM<BIDOOOJOKHK> NEPHKOENOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private IPLIDNCIBDM<HMKFGHFJBCL> BEBAMEBEDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IPLIDNCIBDM<DEBOPKMJAMH> IOOLMIINHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IPLIDNCIBDM<CBCPFENGCGJ> FONNMPHKDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IPLIDNCIBDM<FFDNFNMJGGE> JFJNEPJPPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IPLIDNCIBDM<ILOBAEFMBMP> FJMHPHJAKCO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IOIPIFNBCPB<MCDELACKOKB> GIPJIMECOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IOIPIFNBCPB<FLPCDAIJLMJ> FAPNFFFMBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IOIPIFNBCPB<EPONLFNHFNM> DOGEFPBJILA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IOIPIFNBCPB<HMKFGHFJBCL> LGKBAJJJOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IOIPIFNBCPB<DEBOPKMJAMH> NMCIDKEIPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IOIPIFNBCPB<CBCPFENGCGJ> FDIBNELBECO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IOIPIFNBCPB<FFDNFNMJGGE> OEGKHGBLHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IOIPIFNBCPB<ILOBAEFMBMP> LEGJKABBPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x784CBA0", Offset = "0x784B3A0", VA = "0x18784CBA0")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	[UsedImplicitly]
	internal static void EGBEIEOHABF(CMONJLKOOCI CGNEPIEHDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x784CC10", Offset = "0x784B410", VA = "0x18784CC10")]
	[RecRoom.NoEngine.Common.Preserve]
	public BJDIFGNBHIJ()
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
