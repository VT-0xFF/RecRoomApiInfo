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
public class BJOCMLHFHAK : PAMLCLNPKJL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MMDGBBGILNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NJHFEHHDIKB NHHHEBLKDKP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x723F9D0", Offset = "0x723E5D0", VA = "0x18723F9D0")]
	[DHOHFCLMOGD(IDHBAGABJJA.GameOnly)]
	[UsedImplicitly]
	private static void NOFLNPHPAAG(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x723FA40", Offset = "0x723E640", VA = "0x18723FA40")]
	[UsedImplicitly]
	[DHOHFCLMOGD(IDHBAGABJJA.EditorOnly)]
	private static void OHJHFIMAEBG(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	[Preserve]
	public BJOCMLHFHAK([POJODGKFIMO(null)] NJHFEHHDIKB NHHHEBLKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x723EE30", Offset = "0x723DA30", VA = "0x18723EE30", Slot = "4")]
	public string CJJBNJOFCID(CMEPKGFHLPL NGMMAKENIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x723F2F0", Offset = "0x723DEF0", VA = "0x18723F2F0", Slot = "5")]
	public CMEPKGFHLPL GCPIDJEBGBI(string NGMMAKENIFG)
	{
		return default(CMEPKGFHLPL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
		public SerializedAvatarItemId(FFKCOFENOPK CABAGOHBNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public FFKCOFENOPK GCPIDJEBGBI()
		{
			return default(FFKCOFENOPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedAvatarItemId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72513D0", Offset = "0x724FFD0", VA = "0x1872513D0", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7251490", Offset = "0x7250090", VA = "0x187251490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public HGHOKGOAIFO GCPIDJEBGBI()
		{
			return default(HGHOKGOAIFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedBodyShapeId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7251500", Offset = "0x7250100", VA = "0x187251500", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72515A0", Offset = "0x72501A0", VA = "0x1872515A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public HHBFBBPCPOI GCPIDJEBGBI()
		{
			return default(HHBFBBPCPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedColorId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedColorId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7251610", Offset = "0x7250210", VA = "0x187251610", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72516B0", Offset = "0x72502B0", VA = "0x1872516B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, LNGABDMOONC, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72517D0", Offset = "0x72503D0", VA = "0x1872517D0")]
		public PJILGJPEDNH GCPIDJEBGBI()
		{
			return default(PJILGJPEDNH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72519B0", Offset = "0x72505B0", VA = "0x1872519B0")]
		public SerializedCombinationId(PJILGJPEDNH KMGHHLICIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7251830", Offset = "0x7250430", VA = "0x187251830")]
		private void LECNFKAKKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70E0040", Offset = "0x70DEC40", VA = "0x1870E0040", Slot = "4")]
		public bool Equals(SerializedCombinationId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7251720", Offset = "0x7250320", VA = "0x187251720", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedCombinationId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7251940", Offset = "0x7250540", VA = "0x187251940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7251930", Offset = "0x7250530", VA = "0x187251930", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7251A80", Offset = "0x7250680", VA = "0x187251A80")]
		public static SerializedEquipmentSkinId KHELGMICHFE()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public LOPIGABIBGJ GCPIDJEBGBI()
		{
			return default(LOPIGABIBGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72519E0", Offset = "0x72505E0", VA = "0x1872519E0", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7251AB0", Offset = "0x72506B0", VA = "0x187251AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public APOLGJPCPMJ GCPIDJEBGBI()
		{
			return default(APOLGJPCPMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7251B20", Offset = "0x7250720", VA = "0x187251B20", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7251BC0", Offset = "0x72507C0", VA = "0x187251BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public DEIDGKDGHJK GCPIDJEBGBI()
		{
			return default(DEIDGKDGHJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedFaceShapeId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7251C30", Offset = "0x7250830", VA = "0x187251C30", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7251CD0", Offset = "0x72508D0", VA = "0x187251CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public NMOAOFAHBEC GCPIDJEBGBI()
		{
			return default(NMOAOFAHBEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470", Slot = "4")]
		public bool Equals(SerializedHairPatternId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedHairPatternId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7251D40", Offset = "0x7250940", VA = "0x187251D40", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7251470", Offset = "0x7250070", VA = "0x187251470")]
		public static bool IGDKJEPDLHP(SerializedHairPatternId HDIFBMODGOB, SerializedHairPatternId ADFEKOHGOPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7251DE0", Offset = "0x72509E0", VA = "0x187251DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, LNGABDMOONC
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

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0E50", Offset = "0x1FCFA50", VA = "0x181FD0E50")]
		public SerializedMaterialId(CMGIONJOHJG CABAGOHBNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0", Slot = "6")]
		public Guid HDAFPMNDCAF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BF0", Offset = "0x9D87F0", VA = "0x1809D9BF0")]
		public CMGIONJOHJG GCPIDJEBGBI()
		{
			return default(CMGIONJOHJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70E0040", Offset = "0x70DEC40", VA = "0x1870E0040", Slot = "4")]
		public bool Equals(SerializedMaterialId HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7251E50", Offset = "0x7250A50", VA = "0x187251E50", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA98930", Offset = "0xA97530", VA = "0x180A98930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70E0040", Offset = "0x70DEC40", VA = "0x1870E0040")]
		public static bool IGDKJEPDLHP(SerializedMaterialId HDIFBMODGOB, SerializedMaterialId ADFEKOHGOPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA98710", Offset = "0xA97310", VA = "0x180A98710", Slot = "5")]
		public int CompareTo(SerializedMaterialId HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7251F00", Offset = "0x7250B00", VA = "0x187251F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class GBKKLKODFMG : NJHFEHHDIKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GBKKLKODFMG NKKNEDDGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7242810", Offset = "0x7241410", VA = "0x187242810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AHDNMBAPFHG<FFKCOFENOPK> NAOGNHKFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7242750", Offset = "0x7241350", VA = "0x187242750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AHDNMBAPFHG<LOPIGABIBGJ> JGEAIECNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7242570", Offset = "0x7241170", VA = "0x187242570", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AHDNMBAPFHG<NMOAOFAHBEC> ODLBJPIBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7242690", Offset = "0x7241290", VA = "0x187242690", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AHDNMBAPFHG<PJILGJPEDNH> NMFIKMGICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72426F0", Offset = "0x72412F0", VA = "0x1872426F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AHDNMBAPFHG<HHBFBBPCPOI> DGPENOCPEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x72427B0", Offset = "0x72413B0", VA = "0x1872427B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AHDNMBAPFHG<DEIDGKDGHJK> JKGHDMGGNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x72425D0", Offset = "0x72411D0", VA = "0x1872425D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AHDNMBAPFHG<HGHOKGOAIFO> KHPALKCBBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7242870", Offset = "0x7241470", VA = "0x187242870", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AHDNMBAPFHG<APOLGJPCPMJ> JHBINEMBNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7242630", Offset = "0x7241230", VA = "0x187242630", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AHBIJGHIJAG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x723ED80", Offset = "0x723D980", VA = "0x18723ED80")]
	public static Guid NPBCAMPKOBJ(string IKKJBOGPALO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x723ECB0", Offset = "0x723D8B0", VA = "0x18723ECB0")]
	public static bool DPDBMCBGMMJ(string IKKJBOGPALO, [Out] Guid GBCIBJHFOHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PEDMHKHMOFJ : BBBBAJAJAGJ<FFKCOFENOPK>, NNJIJCPBKCK<FFKCOFENOPK>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x724C0E0", Offset = "0x724ACE0", VA = "0x18724C0E0", Slot = "4")]
	public IEnumerable<(FFKCOFENOPK, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7250D30", Offset = "0x724F930", VA = "0x187250D30", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public FFKCOFENOPK MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(FFKCOFENOPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public PEDMHKHMOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AAFBAMAKCFH : BBBBAJAJAGJ<HGHOKGOAIFO>, NNJIJCPBKCK<HGHOKGOAIFO>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x723E850", Offset = "0x723D450", VA = "0x18723E850", Slot = "4")]
	public IEnumerable<(HGHOKGOAIFO, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public HGHOKGOAIFO MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(HGHOKGOAIFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public AAFBAMAKCFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FNDICMABODA : BBBBAJAJAGJ<HHBFBBPCPOI>, NNJIJCPBKCK<HHBFBBPCPOI>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x72404B0", Offset = "0x723F0B0", VA = "0x1872404B0", Slot = "4")]
	public IEnumerable<(HHBFBBPCPOI, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public HHBFBBPCPOI MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(HHBFBBPCPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public FNDICMABODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NGDEKIGEDNA : BBBBAJAJAGJ<PJILGJPEDNH>, NNJIJCPBKCK<PJILGJPEDNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NNJIJCPBKCK<CMGIONJOHJG> HACPEGCKEFH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	public NGDEKIGEDNA(NNJIJCPBKCK<CMGIONJOHJG> HACPEGCKEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70E0320", Offset = "0x70DEF20", VA = "0x1870E0320", Slot = "4")]
	public IEnumerable<(PJILGJPEDNH, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7244190", Offset = "0x7242D90", VA = "0x187244190", Slot = "6")]
	public PJILGJPEDNH MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(PJILGJPEDNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7244490", Offset = "0x7243090", VA = "0x187244490", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ODLGACIHBFD : BBBBAJAJAGJ<LOPIGABIBGJ>, NNJIJCPBKCK<LOPIGABIBGJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72444D0", Offset = "0x72430D0", VA = "0x1872444D0", Slot = "4")]
	public IEnumerable<(LOPIGABIBGJ, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public LOPIGABIBGJ MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(LOPIGABIBGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ODLGACIHBFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ICCHJBDIFJD : BBBBAJAJAGJ<APOLGJPCPMJ>, NNJIJCPBKCK<APOLGJPCPMJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72428D0", Offset = "0x72414D0", VA = "0x1872428D0", Slot = "4")]
	public IEnumerable<(APOLGJPCPMJ, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public APOLGJPCPMJ MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(APOLGJPCPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ICCHJBDIFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DKCPPDJONDG : BBBBAJAJAGJ<DEIDGKDGHJK>, NNJIJCPBKCK<DEIDGKDGHJK>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7240090", Offset = "0x723EC90", VA = "0x187240090", Slot = "4")]
	public IEnumerable<(DEIDGKDGHJK, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public DEIDGKDGHJK MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(DEIDGKDGHJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public DKCPPDJONDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PHOFNHPPACC : BBBBAJAJAGJ<NMOAOFAHBEC>, NNJIJCPBKCK<NMOAOFAHBEC>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7250D50", Offset = "0x724F950", VA = "0x187250D50", Slot = "4")]
	public IEnumerable<(NMOAOFAHBEC, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public NMOAOFAHBEC MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(NMOAOFAHBEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public PHOFNHPPACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BBBBAJAJAGJ<TModern> : NNJIJCPBKCK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> GMOMFOPCGMF();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OABLFHBCJEP(string PEFHJPGEJPH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HFPBNNIDHBK : BBBBAJAJAGJ<CMGIONJOHJG>, NNJIJCPBKCK<CMGIONJOHJG>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7194490", Offset = "0x7193090", VA = "0x187194490", Slot = "4")]
	public IEnumerable<(CMGIONJOHJG, string)> GMOMFOPCGMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA9A6D0", Offset = "0xA992D0", VA = "0x180A9A6D0", Slot = "5")]
	public string OABLFHBCJEP(string PEFHJPGEJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x723EBF0", Offset = "0x723D7F0", VA = "0x18723EBF0", Slot = "6")]
	public CMGIONJOHJG MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return default(CMGIONJOHJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public HFPBNNIDHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LCIDICGNKDN<TModern> : AHDNMBAPFHG<TModern>, NNJIJCPBKCK<TModern> where TModern : IEquatable<TModern>, LNGABDMOONC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> CCEKHALNMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> OEHOCOMCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BBBBAJAJAGJ<TModern> ALGMKKMCLBO;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x424DC80", Offset = "0x424C880", VA = "0x18424DC80")]
	public LCIDICGNKDN(BBBBAJAJAGJ<TModern> ALGMKKMCLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x424BEA0", Offset = "0x424AAA0", VA = "0x18424BEA0", Slot = "5")]
	public TModern MKLFNBMPJJC(string PEFHJPGEJPH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x424B590", Offset = "0x424A190", VA = "0x18424B590", Slot = "4")]
	public string LFJNAOAFDOK(TModern MNIJBBKCCNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CFLDMEKLION : NJHFEHHDIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private LCIDICGNKDN<FFKCOFENOPK> EELPGDHDPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private LCIDICGNKDN<LOPIGABIBGJ> DCENFLGJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LCIDICGNKDN<NMOAOFAHBEC> EIGJPICNDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LCIDICGNKDN<CMGIONJOHJG> HACPEGCKEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LCIDICGNKDN<PJILGJPEDNH> BLIKDLKICLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LCIDICGNKDN<HHBFBBPCPOI> IGFACPNEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LCIDICGNKDN<DEIDGKDGHJK> NFKPMOHMJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private LCIDICGNKDN<HGHOKGOAIFO> ELOIIDJNOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LCIDICGNKDN<APOLGJPCPMJ> INJKDEALMPD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AHDNMBAPFHG<FFKCOFENOPK> NAOGNHKFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AHDNMBAPFHG<LOPIGABIBGJ> JGEAIECNCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AHDNMBAPFHG<NMOAOFAHBEC> ODLBJPIBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AHDNMBAPFHG<PJILGJPEDNH> NMFIKMGICDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AHDNMBAPFHG<HHBFBBPCPOI> DGPENOCPEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AHDNMBAPFHG<DEIDGKDGHJK> JKGHDMGGNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AHDNMBAPFHG<HGHOKGOAIFO> KHPALKCBBAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AHDNMBAPFHG<APOLGJPCPMJ> JHBINEMBNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x723FB40", Offset = "0x723E740", VA = "0x18723FB40")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.GameOnly)]
	[UsedImplicitly]
	private static void PNCOJBGCPOD(IMEOEBHKJNP DAOJEFNFNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x723FBB0", Offset = "0x723E7B0", VA = "0x18723FBB0")]
	[Preserve]
	public CFLDMEKLION()
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
