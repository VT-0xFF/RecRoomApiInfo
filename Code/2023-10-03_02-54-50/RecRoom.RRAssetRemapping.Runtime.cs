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
public class OCEENKNGALF : KOBNJPMPAOE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NODDBEFMIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LCHJMKMHKAP MKMIBNHBOJH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x628D3F0", Offset = "0x628BBF0", VA = "0x18628D3F0")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.GameOnly)]
	private static void AJCEEBENPCL(MPCHBJGCNBP EHMBKIJNGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x628D4F0", Offset = "0x628BCF0", VA = "0x18628D4F0")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.EditorOnly)]
	private static void DAKGIEMNPKH(MPCHBJGCNBP EHMBKIJNGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	[Preserve]
	public OCEENKNGALF([AKMGDNDIMPI(null)] LCHJMKMHKAP MKMIBNHBOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x628DC10", Offset = "0x628C410", VA = "0x18628DC10", Slot = "4")]
	public string NDMEHJLGNHG(LEBODCONKGF EJAHENBAJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x628D550", Offset = "0x628BD50", VA = "0x18628D550", Slot = "5")]
	public LEBODCONKGF GHFHHMFPNJI(string EJAHENBAJFL)
	{
		return default(LEBODCONKGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBDGOLCHINK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x628C490", Offset = "0x628AC90", VA = "0x18628C490")]
	public static LCHJMKMHKAP FJIJJNKGGCL()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public SerializedAvatarItemId(APNGBMOGDCM LJHGKCLAIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public APNGBMOGDCM GHFHHMFPNJI()
		{
			return default(APNGBMOGDCM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedAvatarItemId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x628F290", Offset = "0x628DA90", VA = "0x18628F290", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x628F360", Offset = "0x628DB60", VA = "0x18628F360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public BBLDIDBCHNK GHFHHMFPNJI()
		{
			return default(BBLDIDBCHNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedBodyShapeId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x628F3D0", Offset = "0x628DBD0", VA = "0x18628F3D0", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x628F470", Offset = "0x628DC70", VA = "0x18628F470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public GNGIIAMDNDI GHFHHMFPNJI()
		{
			return default(GNGIIAMDNDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedColorId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedColorId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x628F4E0", Offset = "0x628DCE0", VA = "0x18628F4E0", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x628F580", Offset = "0x628DD80", VA = "0x18628F580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MOHMBCOCGML, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x628F6A0", Offset = "0x628DEA0", VA = "0x18628F6A0")]
		public DCAOPGHJNHE GHFHHMFPNJI()
		{
			return default(DCAOPGHJNHE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x628F880", Offset = "0x628E080", VA = "0x18628F880")]
		public SerializedCombinationId(DCAOPGHJNHE GDFMOLMMGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x628F700", Offset = "0x628DF00", VA = "0x18628F700")]
		private void KJKCFCGKGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BC0", Offset = "0x5D563C0", VA = "0x185D57BC0", Slot = "4")]
		public bool Equals(SerializedCombinationId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x628F5F0", Offset = "0x628DDF0", VA = "0x18628F5F0", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedCombinationId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x628F810", Offset = "0x628E010", VA = "0x18628F810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x628F800", Offset = "0x628E000", VA = "0x18628F800", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0x628F950", Offset = "0x628E150", VA = "0x18628F950")]
		public static SerializedEquipmentSkinId JNHPDMPGKBP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public COJNIMBKFBI GHFHHMFPNJI()
		{
			return default(COJNIMBKFBI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x628F8B0", Offset = "0x628E0B0", VA = "0x18628F8B0", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x628F980", Offset = "0x628E180", VA = "0x18628F980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public HOCHKCDFGDD GHFHHMFPNJI()
		{
			return default(HOCHKCDFGDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x628F9F0", Offset = "0x628E1F0", VA = "0x18628F9F0", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x628FA90", Offset = "0x628E290", VA = "0x18628FA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public EMJPDEPCHIB GHFHHMFPNJI()
		{
			return default(EMJPDEPCHIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedFaceShapeId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x628FB00", Offset = "0x628E300", VA = "0x18628FB00", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x628FBA0", Offset = "0x628E3A0", VA = "0x18628FBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public SerializedHairPatternId(BJPEFKELMBF LJHGKCLAIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public BJPEFKELMBF GHFHHMFPNJI()
		{
			return default(BJPEFKELMBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330", Slot = "4")]
		public bool Equals(SerializedHairPatternId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x628FC10", Offset = "0x628E410", VA = "0x18628FC10", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x628F330", Offset = "0x628DB30", VA = "0x18628F330")]
		public static bool PEFPHNLEPOM(SerializedHairPatternId MANEBEMOKEE, SerializedHairPatternId HOCFNIKGEJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x628FCB0", Offset = "0x628E4B0", VA = "0x18628FCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MOHMBCOCGML
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
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public SerializedMaterialId(GIOOKNLAJHM LJHGKCLAIHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080", Slot = "6")]
		public Guid FOBIODEMAEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public GIOOKNLAJHM GHFHHMFPNJI()
		{
			return default(GIOOKNLAJHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BC0", Offset = "0x5D563C0", VA = "0x185D57BC0", Slot = "4")]
		public bool Equals(SerializedMaterialId GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x628FD20", Offset = "0x628E520", VA = "0x18628FD20", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x628F350", Offset = "0x628DB50", VA = "0x18628F350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BC0", Offset = "0x5D563C0", VA = "0x185D57BC0")]
		public static bool PEFPHNLEPOM(SerializedMaterialId MANEBEMOKEE, SerializedMaterialId HOCFNIKGEJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializedMaterialId GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x628FDC0", Offset = "0x628E5C0", VA = "0x18628FDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LPDPBHJICGL : LCHJMKMHKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LPDPBHJICGL LNAOMADBHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x628CB40", Offset = "0x628B340", VA = "0x18628CB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JMAJGLHILJC<APNGBMOGDCM> IGGIMHHOLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x628CBA0", Offset = "0x628B3A0", VA = "0x18628CBA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JMAJGLHILJC<COJNIMBKFBI> LKHFMKCAOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x628CD20", Offset = "0x628B520", VA = "0x18628CD20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JMAJGLHILJC<BJPEFKELMBF> CDNFDIPBEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x628CE40", Offset = "0x628B640", VA = "0x18628CE40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMAJGLHILJC<DCAOPGHJNHE> AHIBOGKLKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x628CCC0", Offset = "0x628B4C0", VA = "0x18628CCC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JMAJGLHILJC<GNGIIAMDNDI> HKHJGMIKENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x628CC60", Offset = "0x628B460", VA = "0x18628CC60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JMAJGLHILJC<EMJPDEPCHIB> CEPIFOKCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x628CDE0", Offset = "0x628B5E0", VA = "0x18628CDE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMAJGLHILJC<BBLDIDBCHNK> PLIBPMCINBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x628CC00", Offset = "0x628B400", VA = "0x18628CC00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JMAJGLHILJC<HOCHKCDFGDD> GDBJFIOFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x628CD80", Offset = "0x628B580", VA = "0x18628CD80", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x628C340", Offset = "0x628AB40", VA = "0x18628C340")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class IGBMNHIEMKF
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x628C720", Offset = "0x628AF20", VA = "0x18628C720")]
	public static string EILAMMJHGFM(this Guid ACBJLDAEBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x628C730", Offset = "0x628AF30", VA = "0x18628C730")]
	public static Guid LHDKMOBKKGO(string EAFGNDGBBOB)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DMOPKCDIKHH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> OKMPNPDGCEM(IEnumerable<(string modernStr, string legacyStr)> DEANNFOMJMB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class MKJMBJLFFLL
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OABDGFOGBJH : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x954C10", Offset = "0x953410", VA = "0x180954C10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x628D310", Offset = "0x628BB10", VA = "0x18628D310", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1B3B7B0", Offset = "0x1B39FB0", VA = "0x181B3B7B0")]
		[DebuggerHidden]
		public OABDGFOGBJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x628D360", Offset = "0x628BB60", VA = "0x18628D360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x628CFB0", Offset = "0x628B7B0", VA = "0x18628CFB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x628CF60", Offset = "0x628B760", VA = "0x18628CF60")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x628D2C0", Offset = "0x628BAC0", VA = "0x18628D2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x628D210", Offset = "0x628BA10", VA = "0x18628D210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x628D210", Offset = "0x628BA10", VA = "0x18628D210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2471200", Offset = "0x246FA00", VA = "0x182471200")]
	internal static IEnumerable<(TModern, string)> LNFMGNBPGJL<TModern>(string BMABOJMBCJA, DMOPKCDIKHH<TModern> JBOHEDKKCKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x628CEE0", Offset = "0x628B6E0", VA = "0x18628CEE0")]
	[IteratorStateMachine(typeof(OABDGFOGBJH))]
	private static IEnumerable<(string, string)> FBMKDJHMEJD(AssetIdMappingJsonData MGCKPMKJPDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GHEPDAICEGC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x628C5F0", Offset = "0x628ADF0", VA = "0x18628C5F0")]
	public static Guid PAKLOENDKCE(string LJJLCDNMFLM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x628C520", Offset = "0x628AD20", VA = "0x18628C520")]
	public static bool DCLCKDLHAON(string LJJLCDNMFLM, [Out] Guid ACBJLDAEBBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class LOANKNHONIA<TModern> : EOBMIEBAPDI<TModern>, DMOPKCDIKHH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DDFFGPGFLEE : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public LOANKNHONIA<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD3C770", Offset = "0xD3AF70", VA = "0x180D3C770", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B7240", Offset = "0x32B5A40", VA = "0x1832B7240", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD36990", Offset = "0xD35190", VA = "0x180D36990")]
		[DebuggerHidden]
		public DDFFGPGFLEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3013E30", Offset = "0x3012630", VA = "0x183013E30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4CB2F00", Offset = "0x4CB1700", VA = "0x184CB2F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4CB27E0", Offset = "0x4CB0FE0", VA = "0x184CB27E0")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4CB36A0", Offset = "0x4CB1EA0", VA = "0x184CB36A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4CB34E0", Offset = "0x4CB1CE0", VA = "0x184CB34E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3436BB0", Offset = "0x34353B0", VA = "0x183436BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern JMLMKFDPLIP(Guid ACBJLDAEBBN);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x39C3B60", Offset = "0x39C2360", VA = "0x1839C3B60", Slot = "4")]
	public TModern LIFDEJMLAPE(string LDGDOKGHMLK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x39C3C00", Offset = "0x39C2400", VA = "0x1839C3C00", Slot = "5")]
	[IteratorStateMachine(typeof(LOANKNHONIA<>.DDFFGPGFLEE))]
	public IEnumerable<(TModern, string)> OKMPNPDGCEM(IEnumerable<(string modernStr, string legacyStr)> PHBAMIGHLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected LOANKNHONIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BJIAEJPJKGO : LOANKNHONIA<APNGBMOGDCM>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override APNGBMOGDCM JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(APNGBMOGDCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x628C3F0", Offset = "0x628ABF0", VA = "0x18628C3F0")]
	internal static string KEFEDMADJEK(string LDGDOKGHMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x628C410", Offset = "0x628AC10", VA = "0x18628C410")]
	public BJIAEJPJKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OKLHFJEEJLD : LOANKNHONIA<BBLDIDBCHNK>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override BBLDIDBCHNK JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(BBLDIDBCHNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x628EA80", Offset = "0x628D280", VA = "0x18628EA80")]
	public OKLHFJEEJLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HICPMHFGBIO : LOANKNHONIA<GNGIIAMDNDI>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override GNGIIAMDNDI JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(GNGIIAMDNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x628C6A0", Offset = "0x628AEA0", VA = "0x18628C6A0")]
	public HICPMHFGBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JPDPCGIBFNM : EOBMIEBAPDI<DCAOPGHJNHE>, DMOPKCDIKHH<DCAOPGHJNHE>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OHLEOFODPHL : IEnumerable<(DCAOPGHJNHE, string)>, IEnumerable, IEnumerator<(DCAOPGHJNHE, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (DCAOPGHJNHE, string) <>2__current;

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
		public JPDPCGIBFNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (DCAOPGHJNHE, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x30A5D90", Offset = "0x30A4590", VA = "0x1830A5D90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DCAOPGHJNHE, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x628E9A0", Offset = "0x628D1A0", VA = "0x18628E9A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x628EA50", Offset = "0x628D250", VA = "0x18628EA50")]
		[DebuggerHidden]
		public OHLEOFODPHL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x628EA10", Offset = "0x628D210", VA = "0x18628EA10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x628E230", Offset = "0x628CA30", VA = "0x18628E230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x628E170", Offset = "0x628C970", VA = "0x18628E170")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x628E950", Offset = "0x628D150", VA = "0x18628E950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x628E890", Offset = "0x628D090", VA = "0x18628E890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DCAOPGHJNHE, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x628E890", Offset = "0x628D090", VA = "0x18628E890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly EOBMIEBAPDI<GIOOKNLAJHM> OOBMAHFEMML;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public JPDPCGIBFNM(EOBMIEBAPDI<GIOOKNLAJHM> OOBMAHFEMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x628C7A0", Offset = "0x628AFA0", VA = "0x18628C7A0", Slot = "4")]
	public DCAOPGHJNHE LIFDEJMLAPE(string LDGDOKGHMLK)
	{
		return default(DCAOPGHJNHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x628CAA0", Offset = "0x628B2A0", VA = "0x18628CAA0", Slot = "5")]
	[IteratorStateMachine(typeof(OHLEOFODPHL))]
	public IEnumerable<(DCAOPGHJNHE, string)> OKMPNPDGCEM(IEnumerable<(string modernStr, string legacyStr)> DEANNFOMJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x628C760", Offset = "0x628AF60", VA = "0x18628C760")]
	internal static string KEFEDMADJEK(string LDGDOKGHMLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CIOKOANADFO : LOANKNHONIA<COJNIMBKFBI>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override COJNIMBKFBI JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(COJNIMBKFBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x628C450", Offset = "0x628AC50", VA = "0x18628C450")]
	public CIOKOANADFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FJFFFHEBNHH : LOANKNHONIA<HOCHKCDFGDD>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override HOCHKCDFGDD JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(HOCHKCDFGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x628C4E0", Offset = "0x628ACE0", VA = "0x18628C4E0")]
	public FJFFFHEBNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HJKDHOLCNII : LOANKNHONIA<EMJPDEPCHIB>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override EMJPDEPCHIB JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(EMJPDEPCHIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x628C6E0", Offset = "0x628AEE0", VA = "0x18628C6E0")]
	public HJKDHOLCNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MAMDDIOFBOE : LOANKNHONIA<BJPEFKELMBF>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override BJPEFKELMBF JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(BJPEFKELMBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x628CEA0", Offset = "0x628B6A0", VA = "0x18628CEA0")]
	public MAMDDIOFBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ONGGANJNOPH : LOANKNHONIA<GIOOKNLAJHM>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "6")]
	protected override GIOOKNLAJHM JMLMKFDPLIP(Guid ACBJLDAEBBN)
	{
		return default(GIOOKNLAJHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x628EAC0", Offset = "0x628D2C0", VA = "0x18628EAC0")]
	public ONGGANJNOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PHAMFDGHHKF<TModern> : JMAJGLHILJC<TModern>, EOBMIEBAPDI<TModern> where TModern : IEquatable<TModern>, MOHMBCOCGML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> CEIGBEDOEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> ALGGDFKEBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> CGMHAFLOMHK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E7F580", Offset = "0x3E7DD80", VA = "0x183E7F580")]
	public PHAMFDGHHKF(TextAsset JDOCBNHIGON, DMOPKCDIKHH<TModern> JBOHEDKKCKN, [CanBeNull] Func<string, string> CGMHAFLOMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E7F380", Offset = "0x3E7DB80", VA = "0x183E7F380", Slot = "5")]
	public TModern LIFDEJMLAPE(string LDGDOKGHMLK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E7EE60", Offset = "0x3E7D660", VA = "0x183E7EE60", Slot = "4")]
	public string CBKHDNIGJKM(TModern PBKKJMDHDPK)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, LCHJMKMHKAP
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
		private PHAMFDGHHKF<APNGBMOGDCM> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PHAMFDGHHKF<COJNIMBKFBI> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PHAMFDGHHKF<BJPEFKELMBF> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PHAMFDGHHKF<GIOOKNLAJHM> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private PHAMFDGHHKF<DCAOPGHJNHE> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PHAMFDGHHKF<GNGIIAMDNDI> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PHAMFDGHHKF<EMJPDEPCHIB> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PHAMFDGHHKF<BBLDIDBCHNK> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PHAMFDGHHKF<HOCHKCDFGDD> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JMAJGLHILJC<APNGBMOGDCM> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x763DB0", Offset = "0x7625B0", VA = "0x180763DB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JMAJGLHILJC<COJNIMBKFBI> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JMAJGLHILJC<BJPEFKELMBF> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7612B0", VA = "0x180762AB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JMAJGLHILJC<GIOOKNLAJHM> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x76F3A0", Offset = "0x76DBA0", VA = "0x18076F3A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JMAJGLHILJC<DCAOPGHJNHE> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x76F3E0", Offset = "0x76DBE0", VA = "0x18076F3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JMAJGLHILJC<GNGIIAMDNDI> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x76F310", Offset = "0x76DB10", VA = "0x18076F310", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JMAJGLHILJC<EMJPDEPCHIB> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x810850", Offset = "0x80F050", VA = "0x180810850", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JMAJGLHILJC<BBLDIDBCHNK> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x76F350", Offset = "0x76DB50", VA = "0x18076F350", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JMAJGLHILJC<HOCHKCDFGDD> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x89E0A0", Offset = "0x89C8A0", VA = "0x18089E0A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x628EB00", Offset = "0x628D300", VA = "0x18628EB00")]
		[OPPPCFMOGOO(CODKNAAEMCD.Root, OIAOEFLOJIJ.GameOnly)]
		private static void AGIAADHOABA(MPCHBJGCNBP EHMBKIJNGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x628EB80", Offset = "0x628D380", VA = "0x18628EB80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x825B10", Offset = "0x824310", VA = "0x180825B10")]
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
