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
public class PGMMEELCJBH : CPDAIDAEFBL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex KKIKCPDLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NMFFAPBEOHA PLPDKEDFKHM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6459D70", Offset = "0x6458570", VA = "0x186459D70")]
	[IOOPNJKFHOG(FICJCHGEBPC.GameOnly)]
	private static void IEHGJHACKNO(PHIPPCBHDOE OFJPADAKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6459D10", Offset = "0x6458510", VA = "0x186459D10")]
	[IOOPNJKFHOG(FICJCHGEBPC.EditorOnly)]
	private static void EOAJPJJEHOE(PHIPPCBHDOE OFJPADAKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	[Preserve]
	public PGMMEELCJBH([NBBCAEDCKMG(null)] NMFFAPBEOHA PLPDKEDFKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6459E70", Offset = "0x6458670", VA = "0x186459E70", Slot = "4")]
	public string JMOOMJHDBEG(APEKKKOONDF LLJFBBILFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6459650", Offset = "0x6457E50", VA = "0x186459650", Slot = "5")]
	public APEKKKOONDF AEDPLFCAHJC(string LLJFBBILFIJ)
	{
		return default(APEKKKOONDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FCKCFDNKPNF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6457EA0", Offset = "0x64566A0", VA = "0x186457EA0")]
	public static NMFFAPBEOHA PJLCGCJADHG()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public SerializedAvatarItemId(GPGBPBMJAEC MBMFHFDDILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public GPGBPBMJAEC AEDPLFCAHJC()
		{
			return default(GPGBPBMJAEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedAvatarItemId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x645AB60", Offset = "0x6459360", VA = "0x18645AB60", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x645AC30", Offset = "0x6459430", VA = "0x18645AC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public FHCEDGBBBEB AEDPLFCAHJC()
		{
			return default(FHCEDGBBBEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedBodyShapeId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x645ACA0", Offset = "0x64594A0", VA = "0x18645ACA0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x645AD40", Offset = "0x6459540", VA = "0x18645AD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public ANBBBJKNFMM AEDPLFCAHJC()
		{
			return default(ANBBBJKNFMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedColorId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedColorId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x645ADB0", Offset = "0x64595B0", VA = "0x18645ADB0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x645AE50", Offset = "0x6459650", VA = "0x18645AE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, BJBFBJPAEGE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x645AEC0", Offset = "0x64596C0", VA = "0x18645AEC0")]
		public EJKPOEEPIFD AEDPLFCAHJC()
		{
			return default(EJKPOEEPIFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x645B150", Offset = "0x6459950", VA = "0x18645B150")]
		public SerializedCombinationId(EJKPOEEPIFD GKCPNOIBIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x645AFD0", Offset = "0x64597D0", VA = "0x18645AFD0")]
		private void JEMEEHEGGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECDE30", VA = "0x185ECF630", Slot = "4")]
		public bool Equals(SerializedCombinationId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x645AF20", Offset = "0x6459720", VA = "0x18645AF20", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedCombinationId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x645B0E0", Offset = "0x64598E0", VA = "0x18645B0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x645B0D0", Offset = "0x64598D0", VA = "0x18645B0D0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x645B220", Offset = "0x6459A20", VA = "0x18645B220")]
		public static SerializedEquipmentSkinId KJLCCDEGILI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public MPKHIBIDIGE AEDPLFCAHJC()
		{
			return default(MPKHIBIDIGE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x645B180", Offset = "0x6459980", VA = "0x18645B180", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x645B250", Offset = "0x6459A50", VA = "0x18645B250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public CEPJMPEDIKN AEDPLFCAHJC()
		{
			return default(CEPJMPEDIKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x645B2C0", Offset = "0x6459AC0", VA = "0x18645B2C0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x645B360", Offset = "0x6459B60", VA = "0x18645B360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public PFBEHLAOOKJ AEDPLFCAHJC()
		{
			return default(PFBEHLAOOKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedFaceShapeId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x645B3D0", Offset = "0x6459BD0", VA = "0x18645B3D0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x645B470", Offset = "0x6459C70", VA = "0x18645B470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public SerializedHairPatternId(OEOFFPNLGIM MBMFHFDDILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public OEOFFPNLGIM AEDPLFCAHJC()
		{
			return default(OEOFFPNLGIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00", Slot = "4")]
		public bool Equals(SerializedHairPatternId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedHairPatternId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x645B4E0", Offset = "0x6459CE0", VA = "0x18645B4E0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x645AC00", Offset = "0x6459400", VA = "0x18645AC00")]
		public static bool FMFPLPMCDAE(SerializedHairPatternId PCIGCGBJFLC, SerializedHairPatternId FLACNDCEKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x645B580", Offset = "0x6459D80", VA = "0x18645B580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, BJBFBJPAEGE
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
		[Cpp2IlInjected.Address(RVA = "0x1CCB780", Offset = "0x1CC9F80", VA = "0x181CCB780")]
		public SerializedMaterialId(ECBDFHAMFJH MBMFHFDDILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910", Slot = "6")]
		public Guid LOBKGEDECOM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public ECBDFHAMFJH AEDPLFCAHJC()
		{
			return default(ECBDFHAMFJH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECDE30", VA = "0x185ECF630", Slot = "4")]
		public bool Equals(SerializedMaterialId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x645B5F0", Offset = "0x6459DF0", VA = "0x18645B5F0", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x645AC20", Offset = "0x6459420", VA = "0x18645AC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECDE30", VA = "0x185ECF630")]
		public static bool FMFPLPMCDAE(SerializedMaterialId PCIGCGBJFLC, SerializedMaterialId FLACNDCEKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializedMaterialId FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x645B690", Offset = "0x6459E90", VA = "0x18645B690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GGNPLFCHKLF : NMFFAPBEOHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GGNPLFCHKLF ODCBNHJKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6458800", Offset = "0x6457000", VA = "0x186458800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public EKNKLLIPBDM<GPGBPBMJAEC> JBPDGIMBHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6458860", Offset = "0x6457060", VA = "0x186458860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EKNKLLIPBDM<MPKHIBIDIGE> BCEGLGIMEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64589E0", Offset = "0x64571E0", VA = "0x1864589E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EKNKLLIPBDM<OEOFFPNLGIM> KINHEMLPBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6458B00", Offset = "0x6457300", VA = "0x186458B00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EKNKLLIPBDM<EJKPOEEPIFD> ILFCIMMEEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6458980", Offset = "0x6457180", VA = "0x186458980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EKNKLLIPBDM<ANBBBJKNFMM> BGHPHDOLAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6458920", Offset = "0x6457120", VA = "0x186458920", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EKNKLLIPBDM<PFBEHLAOOKJ> CLODADGGMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6458AA0", Offset = "0x64572A0", VA = "0x186458AA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EKNKLLIPBDM<FHCEDGBBBEB> MDCLKAEPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64588C0", Offset = "0x64570C0", VA = "0x1864588C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EKNKLLIPBDM<CEPJMPEDIKN> BDPBCJNNLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6458A40", Offset = "0x6457240", VA = "0x186458A40", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6457C50", Offset = "0x6456450", VA = "0x186457C50")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class IJMGGFNGMCC
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6459220", Offset = "0x6457A20", VA = "0x186459220")]
	public static string CJNKEHNCCPC(this Guid CLGOKAHLILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64591F0", Offset = "0x64579F0", VA = "0x1864591F0")]
	public static Guid CGCGCHEHFFD(string KFMBEOMDONA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AAHMONLENIP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LOABONIMHBF(IEnumerable<(string modernStr, string legacyStr)> FFBFLAKMGPK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class CKFLNKGMFFF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GPLIIMOLHHA : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6459090", Offset = "0x6457890", VA = "0x186459090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1BCDA90", Offset = "0x1BCC290", VA = "0x181BCDA90")]
		[DebuggerHidden]
		public GPLIIMOLHHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64590E0", Offset = "0x64578E0", VA = "0x1864590E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6458D30", Offset = "0x6457530", VA = "0x186458D30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6458CE0", Offset = "0x64574E0", VA = "0x186458CE0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6459040", Offset = "0x6457840", VA = "0x186459040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6458F90", Offset = "0x6457790", VA = "0x186458F90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6458F90", Offset = "0x6457790", VA = "0x186458F90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x232F080", Offset = "0x232D880", VA = "0x18232F080")]
	internal static IEnumerable<(TModern, string)> OHNEPJEMAEP<TModern>(string DLFLDJOBHEN, AAHMONLENIP<TModern> HHKBLLDEDBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6457DE0", Offset = "0x64565E0", VA = "0x186457DE0")]
	[IteratorStateMachine(typeof(GPLIIMOLHHA))]
	private static IEnumerable<(string, string)> COJFEKAAHEP(AssetIdMappingJsonData CMMKHOHHBCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GIAOPJPGHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6458B60", Offset = "0x6457360", VA = "0x186458B60")]
	public static Guid LOECNJICPFK(string EKGGDFDPIFL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6458C10", Offset = "0x6457410", VA = "0x186458C10")]
	public static bool NIABNJMAOIF(string EKGGDFDPIFL, [Out] Guid CLGOKAHLILM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JGINBCBGNPB<TModern> : IAILMIGDJLD<TModern>, AAHMONLENIP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NMDAINKCNNP : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public JGINBCBGNPB<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDFAB30", Offset = "0xDF9330", VA = "0x180DFAB30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34B7430", Offset = "0x34B5C30", VA = "0x1834B7430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDEBE50", Offset = "0xDEA650", VA = "0x180DEBE50")]
		[DebuggerHidden]
		public NMDAINKCNNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3124B20", Offset = "0x3123320", VA = "0x183124B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3D3D1A0", Offset = "0x3D3B9A0", VA = "0x183D3D1A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C230", Offset = "0x3D3AA30", VA = "0x183D3C230")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E040", Offset = "0x3D3C840", VA = "0x183D3E040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DE30", Offset = "0x3D3C630", VA = "0x183D3DE30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3501CB0", Offset = "0x35004B0", VA = "0x183501CB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern PBLEBPNOOHC(Guid CLGOKAHLILM);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x388FCC0", Offset = "0x388E4C0", VA = "0x18388FCC0", Slot = "4")]
	public TModern PECFGPJGKNM(string HGALEAKJCPA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x388FB60", Offset = "0x388E360", VA = "0x18388FB60", Slot = "5")]
	[IteratorStateMachine(typeof(JGINBCBGNPB<>.NMDAINKCNNP))]
	public IEnumerable<(TModern, string)> LOABONIMHBF(IEnumerable<(string modernStr, string legacyStr)> DHPGBMMOKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected JGINBCBGNPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CDLAAHOCGFJ : JGINBCBGNPB<GPGBPBMJAEC>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override GPGBPBMJAEC PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(GPGBPBMJAEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6457D00", Offset = "0x6456500", VA = "0x186457D00")]
	internal static string BKADCFNDOHJ(string HGALEAKJCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6457D20", Offset = "0x6456520", VA = "0x186457D20")]
	public CDLAAHOCGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DCHNCLNCFNO : JGINBCBGNPB<FHCEDGBBBEB>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override FHCEDGBBBEB PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(FHCEDGBBBEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6457E60", Offset = "0x6456660", VA = "0x186457E60")]
	public DCHNCLNCFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CGEAEBHPPDL : JGINBCBGNPB<ANBBBJKNFMM>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override ANBBBJKNFMM PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(ANBBBJKNFMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6457D60", Offset = "0x6456560", VA = "0x186457D60")]
	public CGEAEBHPPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PFDLNJAONAC : IAILMIGDJLD<EJKPOEEPIFD>, AAHMONLENIP<EJKPOEEPIFD>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GBKIEBOFKMM : IEnumerable<(EJKPOEEPIFD, string)>, IEnumerable, IEnumerator<(EJKPOEEPIFD, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (EJKPOEEPIFD, string) <>2__current;

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
		public PFDLNJAONAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (EJKPOEEPIFD, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x31907F0", Offset = "0x318EFF0", VA = "0x1831907F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((EJKPOEEPIFD, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6458720", Offset = "0x6456F20", VA = "0x186458720", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64587D0", Offset = "0x6456FD0", VA = "0x1864587D0")]
		[DebuggerHidden]
		public GBKIEBOFKMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6458790", Offset = "0x6456F90", VA = "0x186458790", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6457FB0", Offset = "0x64567B0", VA = "0x186457FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6457EF0", Offset = "0x64566F0", VA = "0x186457EF0")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64586D0", Offset = "0x6456ED0", VA = "0x1864586D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6458610", Offset = "0x6456E10", VA = "0x186458610", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(EJKPOEEPIFD, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6458610", Offset = "0x6456E10", VA = "0x186458610", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IAILMIGDJLD<ECBDFHAMFJH> DMGNMDNNAFK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public PFDLNJAONAC(IAILMIGDJLD<ECBDFHAMFJH> DMGNMDNNAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6459350", Offset = "0x6457B50", VA = "0x186459350", Slot = "4")]
	public EJKPOEEPIFD PECFGPJGKNM(string HGALEAKJCPA)
	{
		return default(EJKPOEEPIFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x64592B0", Offset = "0x6457AB0", VA = "0x1864592B0", Slot = "5")]
	[IteratorStateMachine(typeof(GBKIEBOFKMM))]
	public IEnumerable<(EJKPOEEPIFD, string)> LOABONIMHBF(IEnumerable<(string modernStr, string legacyStr)> FFBFLAKMGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6459270", Offset = "0x6457A70", VA = "0x186459270")]
	internal static string BKADCFNDOHJ(string HGALEAKJCPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IJBKAMOAPCO : JGINBCBGNPB<MPKHIBIDIGE>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override MPKHIBIDIGE PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(MPKHIBIDIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x64591B0", Offset = "0x64579B0", VA = "0x1864591B0")]
	public IJBKAMOAPCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AHPIHPDKGKO : JGINBCBGNPB<CEPJMPEDIKN>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override CEPJMPEDIKN PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(CEPJMPEDIKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6457C10", Offset = "0x6456410", VA = "0x186457C10")]
	public AHPIHPDKGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CKBCOHNHOOO : JGINBCBGNPB<PFBEHLAOOKJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override PFBEHLAOOKJ PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(PFBEHLAOOKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6457DA0", Offset = "0x64565A0", VA = "0x186457DA0")]
	public CKBCOHNHOOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HMPDLLENCHJ : JGINBCBGNPB<OEOFFPNLGIM>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override OEOFFPNLGIM PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(OEOFFPNLGIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6459170", Offset = "0x6457970", VA = "0x186459170")]
	public HMPDLLENCHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NENNDEJGJBB : JGINBCBGNPB<ECBDFHAMFJH>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "6")]
	protected override ECBDFHAMFJH PBLEBPNOOHC(Guid CLGOKAHLILM)
	{
		return default(ECBDFHAMFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6459230", Offset = "0x6457A30", VA = "0x186459230")]
	public NENNDEJGJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DDJKADAEAJC<TModern> : EKNKLLIPBDM<TModern>, IAILMIGDJLD<TModern> where TModern : IEquatable<TModern>, BJBFBJPAEGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> NCJEPPMCDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> BLLCABMGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> IDGAGPDFDDH;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4DCA9C0", Offset = "0x4DC91C0", VA = "0x184DCA9C0")]
	public DDJKADAEAJC(TextAsset CMDIJDPJBHF, AAHMONLENIP<TModern> HHKBLLDEDBM, [CanBeNull] Func<string, string> IDGAGPDFDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4DC8B60", Offset = "0x4DC7360", VA = "0x184DC8B60", Slot = "5")]
	public TModern PECFGPJGKNM(string HGALEAKJCPA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4DC7C40", Offset = "0x4DC6440", VA = "0x184DC7C40", Slot = "4")]
	public string CDEBJONCHBJ(TModern HGHOGJICPMH)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, NMFFAPBEOHA
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
		private DDJKADAEAJC<GPGBPBMJAEC> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private DDJKADAEAJC<MPKHIBIDIGE> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private DDJKADAEAJC<OEOFFPNLGIM> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private DDJKADAEAJC<ECBDFHAMFJH> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private DDJKADAEAJC<EJKPOEEPIFD> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DDJKADAEAJC<ANBBBJKNFMM> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private DDJKADAEAJC<PFBEHLAOOKJ> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private DDJKADAEAJC<FHCEDGBBBEB> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private DDJKADAEAJC<CEPJMPEDIKN> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EKNKLLIPBDM<GPGBPBMJAEC> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x772CC0", Offset = "0x7714C0", VA = "0x180772CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EKNKLLIPBDM<MPKHIBIDIGE> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x779ED0", Offset = "0x7786D0", VA = "0x180779ED0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EKNKLLIPBDM<OEOFFPNLGIM> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x779F00", Offset = "0x778700", VA = "0x180779F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public EKNKLLIPBDM<ECBDFHAMFJH> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x777190", Offset = "0x775990", VA = "0x180777190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public EKNKLLIPBDM<EJKPOEEPIFD> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x777290", Offset = "0x775A90", VA = "0x180777290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public EKNKLLIPBDM<ANBBBJKNFMM> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x777280", Offset = "0x775A80", VA = "0x180777280", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EKNKLLIPBDM<PFBEHLAOOKJ> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF760", Offset = "0x8ADF60", VA = "0x1808AF760", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EKNKLLIPBDM<FHCEDGBBBEB> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x777260", Offset = "0x775A60", VA = "0x180777260", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EKNKLLIPBDM<CEPJMPEDIKN> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x839580", Offset = "0x837D80", VA = "0x180839580", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x645A3D0", Offset = "0x6458BD0", VA = "0x18645A3D0")]
		[IOOPNJKFHOG(JJAMOFEKMEH.Root, FICJCHGEBPC.GameOnly)]
		private static void LAKLFGALIHP(PHIPPCBHDOE OFJPADAKEMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x645A450", Offset = "0x6458C50", VA = "0x18645A450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A90", Offset = "0x7F6290", VA = "0x1807F7A90")]
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
