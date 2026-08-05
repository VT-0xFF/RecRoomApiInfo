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
public class AMOMKHPGILN : LHNDICIABLH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex FCHEFAPLGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly JKBNIMMMFLF MBIHEIGBHFI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71F89E0", Offset = "0x71F79E0", VA = "0x1871F89E0")]
	[ONAOIKEPAJE(IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void BJONJIDIGGM(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71F8D90", Offset = "0x71F7D90", VA = "0x1871F8D90")]
	[UsedImplicitly]
	[ONAOIKEPAJE(IKAJKCKEGIH.EditorOnly)]
	private static void NJEKGHDANDG(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	[Preserve]
	public AMOMKHPGILN([JONIFKKOOAA(null)] JKBNIMMMFLF MBIHEIGBHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71F8A50", Offset = "0x71F7A50", VA = "0x1871F8A50", Slot = "4")]
	public string JMNIMAIKKED(MEDGMGIADBO MIFEONEPPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71F8DF0", Offset = "0x71F7DF0", VA = "0x1871F8DF0", Slot = "5")]
	public MEDGMGIADBO PPFECFLIGJE(string MIFEONEPPKP)
	{
		return default(MEDGMGIADBO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NOOOIIHJIEB
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
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public SerializedAvatarItemId(DBLDAMEGANG KHLDDJPHOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public DBLDAMEGANG PPFECFLIGJE()
		{
			return default(DBLDAMEGANG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedAvatarItemId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7205D60", Offset = "0x7204D60", VA = "0x187205D60", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7205E20", Offset = "0x7204E20", VA = "0x187205E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NOOOIIHJIEB
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
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public HDPDBHKAGDO PPFECFLIGJE()
		{
			return default(HDPDBHKAGDO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedBodyShapeId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7205E90", Offset = "0x7204E90", VA = "0x187205E90", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7205F30", Offset = "0x7204F30", VA = "0x187205F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NOOOIIHJIEB
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
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public ALFCGNBGPAB PPFECFLIGJE()
		{
			return default(ALFCGNBGPAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedColorId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedColorId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7205FA0", Offset = "0x7204FA0", VA = "0x187205FA0", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7206040", Offset = "0x7205040", VA = "0x187206040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NOOOIIHJIEB, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
		public HAADOMONODM PPFECFLIGJE()
		{
			return default(HAADOMONODM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72061E0", Offset = "0x72051E0", VA = "0x1872061E0")]
		public SerializedCombinationId(HAADOMONODM ICBODFKDBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7093B90", Offset = "0x7092B90", VA = "0x187093B90", Slot = "4")]
		public bool Equals(SerializedCombinationId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72060B0", Offset = "0x72050B0", VA = "0x1872060B0", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedCombinationId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7206170", Offset = "0x7205170", VA = "0x187206170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7206160", Offset = "0x7205160", VA = "0x187206160", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NOOOIIHJIEB
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
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public SerializedCustomAvatarItemId(Guid CNIMPJMOLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72061F0", Offset = "0x72051F0", VA = "0x1872061F0", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00")]
		public static bool MKBCGNPIJEJ(SerializedCustomAvatarItemId OHFIHFHICKK, SerializedCustomAvatarItemId CENGDJBMKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7206290", Offset = "0x7205290", VA = "0x187206290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NOOOIIHJIEB
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

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72063A0", Offset = "0x72053A0", VA = "0x1872063A0")]
		public static SerializedEquipmentSkinId MMFHNACMAPP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public BLEINJLNGIP PPFECFLIGJE()
		{
			return default(BLEINJLNGIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7206300", Offset = "0x7205300", VA = "0x187206300", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72063D0", Offset = "0x72053D0", VA = "0x1872063D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NOOOIIHJIEB
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public DFGLBGMNOFH PPFECFLIGJE()
		{
			return default(DFGLBGMNOFH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7206440", Offset = "0x7205440", VA = "0x187206440", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72064E0", Offset = "0x72054E0", VA = "0x1872064E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NOOOIIHJIEB
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

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public NHJGDHBOFPL PPFECFLIGJE()
		{
			return default(NHJGDHBOFPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedFaceShapeId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7206550", Offset = "0x7205550", VA = "0x187206550", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72065F0", Offset = "0x72055F0", VA = "0x1872065F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NOOOIIHJIEB
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

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0")]
		public OEAPDDDHGEN PPFECFLIGJE()
		{
			return default(OEAPDDDHGEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00", Slot = "4")]
		public bool Equals(SerializedHairPatternId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedHairPatternId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7206660", Offset = "0x7205660", VA = "0x187206660", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7205E00", Offset = "0x7204E00", VA = "0x187205E00")]
		public static bool MKBCGNPIJEJ(SerializedHairPatternId OHFIHFHICKK, SerializedHairPatternId CENGDJBMKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7206700", Offset = "0x7205700", VA = "0x187206700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NOOOIIHJIEB
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

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xABE210", Offset = "0xABD210", VA = "0x180ABE210")]
		public SerializedMaterialId(PHJCKKDBEEC KHLDDJPHOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xABE1C0", Offset = "0xABD1C0", VA = "0x180ABE1C0", Slot = "6")]
		public Guid IBBDNMEHGPF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7093B90", Offset = "0x7092B90", VA = "0x187093B90", Slot = "4")]
		public bool Equals(SerializedMaterialId ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7206770", Offset = "0x7205770", VA = "0x187206770", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB61130", Offset = "0xB60130", VA = "0x180B61130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB60F20", Offset = "0xB5FF20", VA = "0x180B60F20", Slot = "5")]
		public int CompareTo(SerializedMaterialId ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7206820", Offset = "0x7205820", VA = "0x187206820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CLFJCABLHAA : JKBNIMMMFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CLFJCABLHAA PNNELGGLBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71FB540", Offset = "0x71FA540", VA = "0x1871FB540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AGBAKLPNDKD<DBLDAMEGANG> ANBIKLABJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71FB480", Offset = "0x71FA480", VA = "0x1871FB480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AGBAKLPNDKD<BLEINJLNGIP> INIDJFIKMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71FB5A0", Offset = "0x71FA5A0", VA = "0x1871FB5A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AGBAKLPNDKD<OEAPDDDHGEN> OBBJHMIFMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71FB660", Offset = "0x71FA660", VA = "0x1871FB660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AGBAKLPNDKD<HAADOMONODM> JODLDIPMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x71FB6C0", Offset = "0x71FA6C0", VA = "0x1871FB6C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGBAKLPNDKD<ALFCGNBGPAB> EDFLMIMGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71FB600", Offset = "0x71FA600", VA = "0x1871FB600", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AGBAKLPNDKD<NHJGDHBOFPL> GBLKNGIPCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71FB420", Offset = "0x71FA420", VA = "0x1871FB420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AGBAKLPNDKD<HDPDBHKAGDO> GNHFBJJEDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x71FB720", Offset = "0x71FA720", VA = "0x1871FB720", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AGBAKLPNDKD<DFGLBGMNOFH> PPEIOINNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x71FB4E0", Offset = "0x71FA4E0", VA = "0x1871FB4E0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LMDDLJCLEAO
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7205410", Offset = "0x7204410", VA = "0x187205410")]
	public static Guid CHLLNBNDIBJ(string DAGLPGFHNJP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72054C0", Offset = "0x72044C0", VA = "0x1872054C0")]
	public static bool HOKDKAFJDEH(string DAGLPGFHNJP, [Out] Guid CNIMPJMOLDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ACGGHMEIIJE : DEPADJOPPEM<DBLDAMEGANG>, HJHLPPBKBJE<DBLDAMEGANG>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x71F3710", Offset = "0x71F2710", VA = "0x1871F3710", Slot = "4")]
	public IEnumerable<(DBLDAMEGANG, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71F36F0", Offset = "0x71F26F0", VA = "0x1871F36F0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public DBLDAMEGANG BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(DBLDAMEGANG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ACGGHMEIIJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FGPDKFJNIPH : DEPADJOPPEM<HDPDBHKAGDO>, HJHLPPBKBJE<HDPDBHKAGDO>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71FB780", Offset = "0x71FA780", VA = "0x1871FB780", Slot = "4")]
	public IEnumerable<(HDPDBHKAGDO, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public HDPDBHKAGDO BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(HDPDBHKAGDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public FGPDKFJNIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CJJFFKAOEGP : DEPADJOPPEM<ALFCGNBGPAB>, HJHLPPBKBJE<ALFCGNBGPAB>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x71F9360", Offset = "0x71F8360", VA = "0x1871F9360", Slot = "4")]
	public IEnumerable<(ALFCGNBGPAB, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public ALFCGNBGPAB BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(ALFCGNBGPAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public CJJFFKAOEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NDIPMEKNHJL : DEPADJOPPEM<HAADOMONODM>, HJHLPPBKBJE<HAADOMONODM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HJHLPPBKBJE<PHJCKKDBEEC> CBFCCKDBAMB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
	public NDIPMEKNHJL(HJHLPPBKBJE<PHJCKKDBEEC> CBFCCKDBAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7095100", Offset = "0x7094100", VA = "0x187095100", Slot = "4")]
	public IEnumerable<(HAADOMONODM, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7205AE0", Offset = "0x7204AE0", VA = "0x187205AE0", Slot = "6")]
	public HAADOMONODM BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(HAADOMONODM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7205D20", Offset = "0x7204D20", VA = "0x187205D20", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KDAOGKNLGGG : DEPADJOPPEM<BLEINJLNGIP>, HJHLPPBKBJE<BLEINJLNGIP>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71FBB20", Offset = "0x71FAB20", VA = "0x1871FBB20", Slot = "4")]
	public IEnumerable<(BLEINJLNGIP, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public BLEINJLNGIP BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(BLEINJLNGIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public KDAOGKNLGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KPBLENKKEBE : DEPADJOPPEM<DFGLBGMNOFH>, HJHLPPBKBJE<DFGLBGMNOFH>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7203730", Offset = "0x7202730", VA = "0x187203730", Slot = "4")]
	public IEnumerable<(DFGLBGMNOFH, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public DFGLBGMNOFH BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(DFGLBGMNOFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public KPBLENKKEBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LHBGDMBJLFE : DEPADJOPPEM<NHJGDHBOFPL>, HJHLPPBKBJE<NHJGDHBOFPL>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7204FF0", Offset = "0x7203FF0", VA = "0x187204FF0", Slot = "4")]
	public IEnumerable<(NHJGDHBOFPL, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public NHJGDHBOFPL BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(NHJGDHBOFPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public LHBGDMBJLFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ALENDKBHBNO : DEPADJOPPEM<OEAPDDDHGEN>, HJHLPPBKBJE<OEAPDDDHGEN>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x71F8360", Offset = "0x71F7360", VA = "0x1871F8360", Slot = "4")]
	public IEnumerable<(OEAPDDDHGEN, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public OEAPDDDHGEN BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(OEAPDDDHGEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ALENDKBHBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DEPADJOPPEM<TModern> : HJHLPPBKBJE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JGOJMIBPLKB();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EGAGDPNFFCB(string OPBOMDNGKCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IBMNLIIDIJG : DEPADJOPPEM<PHJCKKDBEEC>, HJHLPPBKBJE<PHJCKKDBEEC>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7149270", Offset = "0x7148270", VA = "0x187149270", Slot = "4")]
	public IEnumerable<(PHJCKKDBEEC, string)> JGOJMIBPLKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xB62FE0", Offset = "0xB61FE0", VA = "0x180B62FE0", Slot = "5")]
	public string EGAGDPNFFCB(string OPBOMDNGKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71F3630", Offset = "0x71F2630", VA = "0x1871F3630", Slot = "6")]
	public PHJCKKDBEEC BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return default(PHJCKKDBEEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public IBMNLIIDIJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MNHDAGODOGL<TModern> : AGBAKLPNDKD<TModern>, HJHLPPBKBJE<TModern> where TModern : IEquatable<TModern>, NOOOIIHJIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> ANAKBNPJFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> LNMIDAJCFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DEPADJOPPEM<TModern> MOPBBFBODFG;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4508AA0", Offset = "0x4507AA0", VA = "0x184508AA0")]
	public MNHDAGODOGL(DEPADJOPPEM<TModern> MOPBBFBODFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4506AA0", Offset = "0x4505AA0", VA = "0x184506AA0", Slot = "5")]
	public TModern BPDPPFNOFOE(string OPBOMDNGKCJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4505380", Offset = "0x4504380", VA = "0x184505380", Slot = "4")]
	public string BNANGAODHLJ(TModern CKMGBABAHCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LPAIOFJPJPK : JKBNIMMMFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MNHDAGODOGL<DBLDAMEGANG> IGNBJCLFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MNHDAGODOGL<BLEINJLNGIP> FOPBDMCMIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MNHDAGODOGL<OEAPDDDHGEN> ECGAFMJNPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MNHDAGODOGL<PHJCKKDBEEC> CBFCCKDBAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MNHDAGODOGL<HAADOMONODM> NGOCPCFGKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MNHDAGODOGL<ALFCGNBGPAB> CEEDEJCHOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MNHDAGODOGL<NHJGDHBOFPL> NHHHKKDFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MNHDAGODOGL<HDPDBHKAGDO> FDEBBFMCGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MNHDAGODOGL<DFGLBGMNOFH> EBBFIHNIECE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AGBAKLPNDKD<DBLDAMEGANG> ANBIKLABJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AGBAKLPNDKD<BLEINJLNGIP> INIDJFIKMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AGBAKLPNDKD<OEAPDDDHGEN> OBBJHMIFMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AGBAKLPNDKD<HAADOMONODM> JODLDIPMCBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AGBAKLPNDKD<ALFCGNBGPAB> EDFLMIMGEGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AGBAKLPNDKD<NHJGDHBOFPL> GBLKNGIPCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AGBAKLPNDKD<HDPDBHKAGDO> GNHFBJJEDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AGBAKLPNDKD<DFGLBGMNOFH> PPEIOINNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7205590", Offset = "0x7204590", VA = "0x187205590")]
	[ONAOIKEPAJE(NOFONODCPKJ.Root, IKAJKCKEGIH.GameOnly)]
	[UsedImplicitly]
	private static void IIPNNHOGOLM(NDJGECDCBMH GJMGLGAJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7205600", Offset = "0x7204600", VA = "0x187205600")]
	[Preserve]
	public LPAIOFJPJPK()
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
