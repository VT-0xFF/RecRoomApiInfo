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
		[Cpp2IlInjected.Address(RVA = "0x84E0AD0", Offset = "0x84DF2D0", VA = "0x1884E0AD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HGDKPIEJNJM : GJKCLLPHCAN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HACPFMNEKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly HABBFPCILCO CCNONNFOJHJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84DBFC0", Offset = "0x84DA7C0", VA = "0x1884DBFC0")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	[UsedImplicitly]
	internal static void FGFPGKKONLH(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84DC370", Offset = "0x84DAB70", VA = "0x1884DC370")]
	[UsedImplicitly]
	internal static void MGKMKBGGPPD(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGDKPIEJNJM([LDAFGEHKDJK(null)] HABBFPCILCO CCNONNFOJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84DC030", Offset = "0x84DA830", VA = "0x1884DC030", Slot = "4")]
	public string LIJGMGKAKKG(AJELBAFCNLN JEOEDPICHHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84DC3D0", Offset = "0x84DABD0", VA = "0x1884DC3D0", Slot = "5")]
	public AJELBAFCNLN MPBEICGIKAG(string JEOEDPICHHI)
	{
		return default(AJELBAFCNLN);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public MFBAIOHMEOF MPBEICGIKAG()
		{
			return default(MFBAIOHMEOF);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedAvatarItemId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84DFFA0", Offset = "0x84DE7A0", VA = "0x1884DFFA0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84E0060", Offset = "0x84DE860", VA = "0x1884E0060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public GIIEABJDIBB MPBEICGIKAG()
		{
			return default(GIIEABJDIBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedBodyShapeId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84E00D0", Offset = "0x84DE8D0", VA = "0x1884E00D0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84E0170", Offset = "0x84DE970", VA = "0x1884E0170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public HHIJJAHMBEN MPBEICGIKAG()
		{
			return default(HHIJJAHMBEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedColorId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedColorId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84E01E0", Offset = "0x84DE9E0", VA = "0x1884E01E0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84E0280", Offset = "0x84DEA80", VA = "0x1884E0280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, EHKBGADHGBA, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		public EGIKODNAABF MPBEICGIKAG()
		{
			return default(EGIKODNAABF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x836C3B0", Offset = "0x836ABB0", VA = "0x18836C3B0", Slot = "4")]
		public bool Equals(SerializedCombinationId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84E02F0", Offset = "0x84DEAF0", VA = "0x1884E02F0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedCombinationId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84E03B0", Offset = "0x84DEBB0", VA = "0x1884E03B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84E03A0", Offset = "0x84DEBA0", VA = "0x1884E03A0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6660", Offset = "0x11E4E60", VA = "0x1811E6660")]
		public SerializedCustomAvatarItemId(Guid BGPPHEMBCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public static SerializedCustomAvatarItemId FBIIPLPAEEH(Guid BGPPHEMBCAA)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84E0420", Offset = "0x84DEC20", VA = "0x1884E0420", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040")]
		public static bool NIDGPKKMDPO(SerializedCustomAvatarItemId HKAFAMHBCLL, SerializedCustomAvatarItemId JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84E04C0", Offset = "0x84DECC0", VA = "0x1884E04C0")]
		public static bool ONONOJDPAAN(SerializedCustomAvatarItemId HKAFAMHBCLL, SerializedCustomAvatarItemId JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84E04E0", Offset = "0x84DECE0", VA = "0x1884E04E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x84E05F0", Offset = "0x84DEDF0", VA = "0x1884E05F0")]
		public static SerializedEquipmentSkinId HFMHMPGFEAI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public PLPAABLOIJF MPBEICGIKAG()
		{
			return default(PLPAABLOIJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84E0550", Offset = "0x84DED50", VA = "0x1884E0550", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84E0620", Offset = "0x84DEE20", VA = "0x1884E0620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public MFGHHKBHMBD MPBEICGIKAG()
		{
			return default(MFGHHKBHMBD);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84E0690", Offset = "0x84DEE90", VA = "0x1884E0690", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84E0730", Offset = "0x84DEF30", VA = "0x1884E0730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public EGPFHAHNEED MPBEICGIKAG()
		{
			return default(EGPFHAHNEED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedFaceShapeId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E07A0", Offset = "0x84DEFA0", VA = "0x1884E07A0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84E0840", Offset = "0x84DF040", VA = "0x1884E0840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670")]
		public DAMJGPCPPIE MPBEICGIKAG()
		{
			return default(DAMJGPCPPIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040", Slot = "4")]
		public bool Equals(SerializedHairPatternId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84E08B0", Offset = "0x84DF0B0", VA = "0x1884E08B0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84E0040", Offset = "0x84DE840", VA = "0x1884E0040")]
		public static bool NIDGPKKMDPO(SerializedHairPatternId HKAFAMHBCLL, SerializedHairPatternId JAKFFJGMBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84E0950", Offset = "0x84DF150", VA = "0x1884E0950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, EHKBGADHGBA
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
		[Cpp2IlInjected.Address(RVA = "0x11E6670", Offset = "0x11E4E70", VA = "0x1811E6670", Slot = "6")]
		public Guid CIAECGMGKIC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x836C3B0", Offset = "0x836ABB0", VA = "0x18836C3B0", Slot = "4")]
		public bool Equals(SerializedMaterialId PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84E09C0", Offset = "0x84DF1C0", VA = "0x1884E09C0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x79AA550", Offset = "0x79A8D50", VA = "0x1879AA550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79AA3C0", Offset = "0x79A8BC0", VA = "0x1879AA3C0", Slot = "5")]
		public int CompareTo(SerializedMaterialId PGPJMFPAKOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84E0A60", Offset = "0x84DF260", VA = "0x1884E0A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NMAMJEMNLPF : HABBFPCILCO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NMAMJEMNLPF DJLOIKDDKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84DDE80", Offset = "0x84DC680", VA = "0x1884DDE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DJAOJFIAGJB<MFBAIOHMEOF> AKMCGMBOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84DDB80", Offset = "0x84DC380", VA = "0x1884DDB80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DJAOJFIAGJB<PLPAABLOIJF> PHLBFMBBMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84DDC40", Offset = "0x84DC440", VA = "0x1884DDC40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DJAOJFIAGJB<DAMJGPCPPIE> LOEGPIFGHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84DDE20", Offset = "0x84DC620", VA = "0x1884DDE20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DJAOJFIAGJB<EGIKODNAABF> LHIKPNNPHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84DDBE0", Offset = "0x84DC3E0", VA = "0x1884DDBE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DJAOJFIAGJB<HHIJJAHMBEN> LILMNDBJBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84DDCA0", Offset = "0x84DC4A0", VA = "0x1884DDCA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DJAOJFIAGJB<EGPFHAHNEED> HNCBCCCIMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84DDDC0", Offset = "0x84DC5C0", VA = "0x1884DDDC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DJAOJFIAGJB<GIIEABJDIBB> FIGIMCMOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84DDD60", Offset = "0x84DC560", VA = "0x1884DDD60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DJAOJFIAGJB<MFGHHKBHMBD> OKGEGGNJDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84DDD00", Offset = "0x84DC500", VA = "0x1884DDD00", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MGFEKJDMLMC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84DDA00", Offset = "0x84DC200", VA = "0x1884DDA00")]
	public static Guid DBDKOLEIIOE(string NAOFPCILMKE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84DDAB0", Offset = "0x84DC2B0", VA = "0x1884DDAB0")]
	public static bool PPDGGEGIMEI(string NAOFPCILMKE, [Out] Guid BGPPHEMBCAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AMAIKBFOOBE : ELPOOPKGOFB<MFBAIOHMEOF>, PIPOPGBHJAI<MFBAIOHMEOF>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84CF1F0", Offset = "0x84CD9F0", VA = "0x1884CF1F0", Slot = "4")]
	public IEnumerable<(MFBAIOHMEOF, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84D3E40", Offset = "0x84D2640", VA = "0x1884D3E40", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public MFBAIOHMEOF AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(MFBAIOHMEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AMAIKBFOOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IMBBNBHMOBJ : ELPOOPKGOFB<GIIEABJDIBB>, PIPOPGBHJAI<GIIEABJDIBB>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84DCD60", Offset = "0x84DB560", VA = "0x1884DCD60", Slot = "4")]
	public IEnumerable<(GIIEABJDIBB, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public GIIEABJDIBB AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(GIIEABJDIBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IMBBNBHMOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OEDGECDLJNO : ELPOOPKGOFB<HHIJJAHMBEN>, PIPOPGBHJAI<HHIJJAHMBEN>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84DDEE0", Offset = "0x84DC6E0", VA = "0x1884DDEE0", Slot = "4")]
	public IEnumerable<(HHIJJAHMBEN, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public HHIJJAHMBEN AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(HHIJJAHMBEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public OEDGECDLJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IOCALJCAKOC : ELPOOPKGOFB<EGIKODNAABF>, PIPOPGBHJAI<EGIKODNAABF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PIPOPGBHJAI<CKDOFMNFPNB> BFOALFOAAJP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public IOCALJCAKOC(PIPOPGBHJAI<CKDOFMNFPNB> BFOALFOAAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x836D4B0", Offset = "0x836BCB0", VA = "0x18836D4B0", Slot = "4")]
	public IEnumerable<(EGIKODNAABF, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84DD100", Offset = "0x84DB900", VA = "0x1884DD100", Slot = "6")]
	public EGIKODNAABF AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(EGIKODNAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84DD340", Offset = "0x84DBB40", VA = "0x1884DD340", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DNJGGLBNKIB : ELPOOPKGOFB<PLPAABLOIJF>, PIPOPGBHJAI<PLPAABLOIJF>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84D3E60", Offset = "0x84D2660", VA = "0x1884D3E60", Slot = "4")]
	public IEnumerable<(PLPAABLOIJF, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public PLPAABLOIJF AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(PLPAABLOIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DNJGGLBNKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ADCEFOIAPEH : ELPOOPKGOFB<MFGHHKBHMBD>, PIPOPGBHJAI<MFGHHKBHMBD>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84CD930", Offset = "0x84CC130", VA = "0x1884CD930", Slot = "4")]
	public IEnumerable<(MFGHHKBHMBD, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public MFGHHKBHMBD AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(MFGHHKBHMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public ADCEFOIAPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IHFEPGJKEGL : ELPOOPKGOFB<EGPFHAHNEED>, PIPOPGBHJAI<EGPFHAHNEED>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84DC940", Offset = "0x84DB140", VA = "0x1884DC940", Slot = "4")]
	public IEnumerable<(EGPFHAHNEED, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public EGPFHAHNEED AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(EGPFHAHNEED);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IHFEPGJKEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JEKEKMHPBEN : ELPOOPKGOFB<DAMJGPCPPIE>, PIPOPGBHJAI<DAMJGPCPPIE>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84DD380", Offset = "0x84DBB80", VA = "0x1884DD380", Slot = "4")]
	public IEnumerable<(DAMJGPCPPIE, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public DAMJGPCPPIE AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(DAMJGPCPPIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JEKEKMHPBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ELPOOPKGOFB<TModern> : PIPOPGBHJAI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> BNEJAMDHPAP();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JFIFLDKGLDC(string AJACLEELPPF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LDLAAPIDEDI : ELPOOPKGOFB<CKDOFMNFPNB>, PIPOPGBHJAI<CKDOFMNFPNB>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84225D0", Offset = "0x8420DD0", VA = "0x1884225D0", Slot = "4")]
	public IEnumerable<(CKDOFMNFPNB, string)> BNEJAMDHPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA63AC0", Offset = "0xA622C0", VA = "0x180A63AC0", Slot = "5")]
	public string JFIFLDKGLDC(string AJACLEELPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84CD870", Offset = "0x84CC070", VA = "0x1884CD870", Slot = "6")]
	public CKDOFMNFPNB AHPHKHMMKHH(string AJACLEELPPF)
	{
		return default(CKDOFMNFPNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public LDLAAPIDEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CHIDNMGDHFO<TModern> : DJAOJFIAGJB<TModern>, PIPOPGBHJAI<TModern> where TModern : IEquatable<TModern>, EHKBGADHGBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> KHKJJKCICNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IJAKDKJJJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ELPOOPKGOFB<TModern> GOOMHLJMLBB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63EFC00", Offset = "0x63EE400", VA = "0x1863EFC00")]
	public CHIDNMGDHFO(ELPOOPKGOFB<TModern> GOOMHLJMLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x63EDD80", Offset = "0x63EC580", VA = "0x1863EDD80", Slot = "5")]
	public TModern AHPHKHMMKHH(string AJACLEELPPF)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63EECF0", Offset = "0x63ED4F0", VA = "0x1863EECF0", Slot = "4")]
	public string OEHPOIANCLJ(TModern EFLICIFEDOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EJPHDJGFMNB : HABBFPCILCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private CHIDNMGDHFO<MFBAIOHMEOF> OCAMFOMJOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private CHIDNMGDHFO<PLPAABLOIJF> CAMJIGHMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CHIDNMGDHFO<DAMJGPCPPIE> OHAPGIMMGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private CHIDNMGDHFO<CKDOFMNFPNB> BFOALFOAAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private CHIDNMGDHFO<EGIKODNAABF> DGLKBDGKGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private CHIDNMGDHFO<HHIJJAHMBEN> HAFJLJFNIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private CHIDNMGDHFO<EGPFHAHNEED> AGEEFFGFLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private CHIDNMGDHFO<GIIEABJDIBB> LIIOMIGIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private CHIDNMGDHFO<MFGHHKBHMBD> FMGIBPPJHKB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DJAOJFIAGJB<MFBAIOHMEOF> AKMCGMBOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DJAOJFIAGJB<PLPAABLOIJF> PHLBFMBBMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DJAOJFIAGJB<DAMJGPCPPIE> LOEGPIFGHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DJAOJFIAGJB<EGIKODNAABF> LHIKPNNPHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DJAOJFIAGJB<HHIJJAHMBEN> LILMNDBJBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DJAOJFIAGJB<EGPFHAHNEED> HNCBCCCIMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DJAOJFIAGJB<GIIEABJDIBB> FIGIMCMOGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DJAOJFIAGJB<MFGHHKBHMBD> OKGEGGNJDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84DBA70", Offset = "0x84DA270", VA = "0x1884DBA70")]
	[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
	[UsedImplicitly]
	internal static void OHIEJCAALDD(HHDGAAFLDEF LFLOONKADLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x84DBAE0", Offset = "0x84DA2E0", VA = "0x1884DBAE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EJPHDJGFMNB()
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
