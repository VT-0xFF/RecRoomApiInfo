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
public class KAMIHLAOAJB : OCOMIAFPJFK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MFHIIPAIFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly ADOBOFDDOHJ CHMJBJBKINP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6788B60", Offset = "0x6787960", VA = "0x186788B60")]
	[NAAAALLPNIA(PBKIGNPNCFO.GameOnly)]
	[UsedImplicitly]
	private static void LHBJIPOANBJ(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6787F80", Offset = "0x6786D80", VA = "0x186787F80")]
	[UsedImplicitly]
	[NAAAALLPNIA(PBKIGNPNCFO.EditorOnly)]
	private static void CCPDALGGLBL(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	[Preserve]
	public KAMIHLAOAJB([LICAMFFCLCL(null)] ADOBOFDDOHJ CHMJBJBKINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67886A0", Offset = "0x67874A0", VA = "0x1867886A0", Slot = "4")]
	public string FILLENIGNNA(GCJCFMDAODD ECKJJAACLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6787FE0", Offset = "0x6786DE0", VA = "0x186787FE0", Slot = "5")]
	public GCJCFMDAODD CINNELLPCMC(string ECKJJAACLOE)
	{
		return default(GCJCFMDAODD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ACJFELBCAEB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6776940", Offset = "0x6775740", VA = "0x186776940")]
	public static ADOBOFDDOHJ GAIGJJNKMOE()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public SerializedAvatarItemId(LBHGABEKMEC DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public LBHGABEKMEC CINNELLPCMC()
		{
			return default(LBHGABEKMEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedAvatarItemId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6789090", Offset = "0x6787E90", VA = "0x186789090", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6789150", Offset = "0x6787F50", VA = "0x186789150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public EOJCBICDBHE CINNELLPCMC()
		{
			return default(EOJCBICDBHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedBodyShapeId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67891C0", Offset = "0x6787FC0", VA = "0x1867891C0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6789260", Offset = "0x6788060", VA = "0x186789260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public BENNFIBOECP CINNELLPCMC()
		{
			return default(BENNFIBOECP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedColorId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedColorId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67892D0", Offset = "0x67880D0", VA = "0x1867892D0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6789370", Offset = "0x6788170", VA = "0x186789370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, LDDGGJBEKGP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x67893E0", Offset = "0x67881E0", VA = "0x1867893E0")]
		public DFPMJDLGDHO CINNELLPCMC()
		{
			return default(DFPMJDLGDHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6789670", Offset = "0x6788470", VA = "0x186789670")]
		public SerializedCombinationId(DFPMJDLGDHO DCMPKOAIIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67894F0", Offset = "0x67882F0", VA = "0x1867894F0")]
		private void NJDAKOFDOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66162D0", Offset = "0x66150D0", VA = "0x1866162D0", Slot = "4")]
		public bool Equals(SerializedCombinationId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6789440", Offset = "0x6788240", VA = "0x186789440", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedCombinationId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6789600", Offset = "0x6788400", VA = "0x186789600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67895F0", Offset = "0x67883F0", VA = "0x1867895F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x6789740", Offset = "0x6788540", VA = "0x186789740")]
		public static SerializedEquipmentSkinId PFIOOBFBAAO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public NKLHELMOINE CINNELLPCMC()
		{
			return default(NKLHELMOINE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67896A0", Offset = "0x67884A0", VA = "0x1867896A0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6789770", Offset = "0x6788570", VA = "0x186789770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public JGMMLLLGHOB CINNELLPCMC()
		{
			return default(JGMMLLLGHOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67897E0", Offset = "0x67885E0", VA = "0x1867897E0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6789880", Offset = "0x6788680", VA = "0x186789880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public NEEKCOKFGOD CINNELLPCMC()
		{
			return default(NEEKCOKFGOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedFaceShapeId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67898F0", Offset = "0x67886F0", VA = "0x1867898F0", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6789990", Offset = "0x6788790", VA = "0x186789990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public SerializedHairPatternId(FFGDPHHADEF DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public FFGDPHHADEF CINNELLPCMC()
		{
			return default(FFGDPHHADEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130", Slot = "4")]
		public bool Equals(SerializedHairPatternId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6789A00", Offset = "0x6788800", VA = "0x186789A00", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6789130", Offset = "0x6787F30", VA = "0x186789130")]
		public static bool JACCNGOPODK(SerializedHairPatternId DPMPIPDPNFG, SerializedHairPatternId DJCBILALFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6789AA0", Offset = "0x67888A0", VA = "0x186789AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, LDDGGJBEKGP
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
		[Cpp2IlInjected.Address(RVA = "0x1D8AD10", Offset = "0x1D89B10", VA = "0x181D8AD10")]
		public SerializedMaterialId(NFNDKHDEMKE DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800", Slot = "6")]
		public Guid IPCGJKBGOKI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x816800", Offset = "0x815600", VA = "0x180816800")]
		public NFNDKHDEMKE CINNELLPCMC()
		{
			return default(NFNDKHDEMKE);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x66162D0", Offset = "0x66150D0", VA = "0x1866162D0", Slot = "4")]
		public bool Equals(SerializedMaterialId FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6789B10", Offset = "0x6788910", VA = "0x186789B10", Slot = "0")]
		public override bool Equals(object NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A7FF0", Offset = "0x8A6DF0", VA = "0x1808A7FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x66162D0", Offset = "0x66150D0", VA = "0x1866162D0")]
		public static bool JACCNGOPODK(SerializedMaterialId DPMPIPDPNFG, SerializedMaterialId DJCBILALFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A7DD0", Offset = "0x8A6BD0", VA = "0x1808A7DD0", Slot = "5")]
		public int CompareTo(SerializedMaterialId FPEEGIOMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6789BB0", Offset = "0x67889B0", VA = "0x186789BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JPNFMOJLMPI : ADOBOFDDOHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JPNFMOJLMPI AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6787EC0", Offset = "0x6786CC0", VA = "0x186787EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MAJGOBKEGDC<LBHGABEKMEC> MANDNJODMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6787F20", Offset = "0x6786D20", VA = "0x186787F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MAJGOBKEGDC<NKLHELMOINE> LMOHHCNDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6787C80", Offset = "0x6786A80", VA = "0x186787C80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MAJGOBKEGDC<FFGDPHHADEF> MDDEMAILADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6787E00", Offset = "0x6786C00", VA = "0x186787E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MAJGOBKEGDC<DFPMJDLGDHO> PFACLDJMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6787D40", Offset = "0x6786B40", VA = "0x186787D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MAJGOBKEGDC<BENNFIBOECP> KBJECIKJIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6787C20", Offset = "0x6786A20", VA = "0x186787C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MAJGOBKEGDC<NEEKCOKFGOD> HAGKLOCAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6787CE0", Offset = "0x6786AE0", VA = "0x186787CE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MAJGOBKEGDC<EOJCBICDBHE> KDNELOAFOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6787DA0", Offset = "0x6786BA0", VA = "0x186787DA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MAJGOBKEGDC<JGMMLLLGHOB> OEEPMAPANNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6787E60", Offset = "0x6786C60", VA = "0x186787E60", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JHFLGMFCPHP
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6785AB0", Offset = "0x67848B0", VA = "0x186785AB0")]
	public static Guid PMEHLMIMCOE(string IGJKGDNEMAJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x67859E0", Offset = "0x67847E0", VA = "0x1867859E0")]
	public static bool PILDNMPDDBG(string IGJKGDNEMAJ, [Out] Guid FANIDECOFDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AKCONPLLDMP : FMOKGONHKBO<LBHGABEKMEC>, AGGINCCPFOJ<LBHGABEKMEC>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6776F00", Offset = "0x6775D00", VA = "0x186776F00", Slot = "4")]
	public IEnumerable<(LBHGABEKMEC, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6776EE0", Offset = "0x6775CE0", VA = "0x186776EE0", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public LBHGABEKMEC EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(LBHGABEKMEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public AKCONPLLDMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ACBEGHDIAPJ : FMOKGONHKBO<EOJCBICDBHE>, AGGINCCPFOJ<EOJCBICDBHE>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67765A0", Offset = "0x67753A0", VA = "0x1867765A0", Slot = "4")]
	public IEnumerable<(EOJCBICDBHE, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public EOJCBICDBHE EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(EOJCBICDBHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ACBEGHDIAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JKGCEKEHNMD : FMOKGONHKBO<BENNFIBOECP>, AGGINCCPFOJ<BENNFIBOECP>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6785B60", Offset = "0x6784960", VA = "0x186785B60", Slot = "4")]
	public IEnumerable<(BENNFIBOECP, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public BENNFIBOECP EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(BENNFIBOECP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JKGCEKEHNMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FAKJCCBGNEL : FMOKGONHKBO<DFPMJDLGDHO>, AGGINCCPFOJ<DFPMJDLGDHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AGGINCCPFOJ<NFNDKHDEMKE> MAIGLADJHJE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public FAKJCCBGNEL(AGGINCCPFOJ<NFNDKHDEMKE> MAIGLADJHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6617FB0", Offset = "0x6616DB0", VA = "0x186617FB0", Slot = "4")]
	public IEnumerable<(DFPMJDLGDHO, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x677DA90", Offset = "0x677C890", VA = "0x18677DA90", Slot = "6")]
	public DFPMJDLGDHO EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(DFPMJDLGDHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x677DD90", Offset = "0x677CB90", VA = "0x18677DD90", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HLKOKFAFIEB : FMOKGONHKBO<NKLHELMOINE>, AGGINCCPFOJ<NKLHELMOINE>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x677DDD0", Offset = "0x677CBD0", VA = "0x18677DDD0", Slot = "4")]
	public IEnumerable<(NKLHELMOINE, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public NKLHELMOINE EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(NKLHELMOINE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HLKOKFAFIEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EKDLKOENOFG : FMOKGONHKBO<JGMMLLLGHOB>, AGGINCCPFOJ<JGMMLLLGHOB>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x677C1D0", Offset = "0x677AFD0", VA = "0x18677C1D0", Slot = "4")]
	public IEnumerable<(JGMMLLLGHOB, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public JGMMLLLGHOB EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(JGMMLLLGHOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EKDLKOENOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NMAPHNKGAOL : FMOKGONHKBO<NEEKCOKFGOD>, AGGINCCPFOJ<NEEKCOKFGOD>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6788C70", Offset = "0x6787A70", VA = "0x186788C70", Slot = "4")]
	public IEnumerable<(NEEKCOKFGOD, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public NEEKCOKFGOD EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(NEEKCOKFGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NMAPHNKGAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EDANEJALKAP : FMOKGONHKBO<FFGDPHHADEF>, AGGINCCPFOJ<FFGDPHHADEF>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x677BB50", Offset = "0x677A950", VA = "0x18677BB50", Slot = "4")]
	public IEnumerable<(FFGDPHHADEF, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public FFGDPHHADEF EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(FFGDPHHADEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EDANEJALKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FMOKGONHKBO<TModern> : AGGINCCPFOJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> IHFHNIANGJJ();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GKBHMNBHKDG(string CACIEBJGGBG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EGMIDLBGCAD : FMOKGONHKBO<NFNDKHDEMKE>, AGGINCCPFOJ<NFNDKHDEMKE>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x66CC120", Offset = "0x66CAF20", VA = "0x1866CC120", Slot = "4")]
	public IEnumerable<(NFNDKHDEMKE, string)> IHFHNIANGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9C20", Offset = "0x8A8A20", VA = "0x1808A9C20", Slot = "5")]
	public string GKBHMNBHKDG(string CACIEBJGGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67764E0", Offset = "0x67752E0", VA = "0x1867764E0", Slot = "6")]
	public NFNDKHDEMKE EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return default(NFNDKHDEMKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EGMIDLBGCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OGFGJPNOPJI<TModern> : MAJGOBKEGDC<TModern>, AGGINCCPFOJ<TModern> where TModern : IEquatable<TModern>, LDDGGJBEKGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> PKJCMJINNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> KOLOIAOHAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FMOKGONHKBO<TModern> PJFNOHBOJOB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3F68680", Offset = "0x3F67480", VA = "0x183F68680")]
	public OGFGJPNOPJI(FMOKGONHKBO<TModern> PJFNOHBOJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3F658D0", Offset = "0x3F646D0", VA = "0x183F658D0", Slot = "5")]
	public TModern EDKJAABKNGJ(string CACIEBJGGBG)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3F66910", Offset = "0x3F65710", VA = "0x183F66910", Slot = "4")]
	public string MGIKHBODJPF(TModern CPCHDCMABJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AFKKMLHKKOP : ADOBOFDDOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private OGFGJPNOPJI<LBHGABEKMEC> GPMFLDODEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private OGFGJPNOPJI<NKLHELMOINE> JGOKDLJLMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OGFGJPNOPJI<FFGDPHHADEF> CMCOPJABOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OGFGJPNOPJI<NFNDKHDEMKE> MAIGLADJHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OGFGJPNOPJI<DFPMJDLGDHO> DDLNAJKGAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OGFGJPNOPJI<BENNFIBOECP> DCCKOBLHEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OGFGJPNOPJI<NEEKCOKFGOD> HOENAFHPAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OGFGJPNOPJI<EOJCBICDBHE> HNNPCIJIKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OGFGJPNOPJI<JGMMLLLGHOB> BIHKFFFJBJC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MAJGOBKEGDC<LBHGABEKMEC> MANDNJODMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MAJGOBKEGDC<NKLHELMOINE> LMOHHCNDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MAJGOBKEGDC<FFGDPHHADEF> MDDEMAILADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MAJGOBKEGDC<DFPMJDLGDHO> PFACLDJMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MAJGOBKEGDC<BENNFIBOECP> KBJECIKJIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MAJGOBKEGDC<NEEKCOKFGOD> HAGKLOCAGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MAJGOBKEGDC<EOJCBICDBHE> KDNELOAFOAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MAJGOBKEGDC<JGMMLLLGHOB> OEEPMAPANNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6776990", Offset = "0x6775790", VA = "0x186776990")]
	[NAAAALLPNIA(KMIEHGCCHON.Root, PBKIGNPNCFO.GameOnly)]
	[UsedImplicitly]
	private static void OCPPHKOHOLM(IBPIJCMLLGH GGHBEJLCMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6776A00", Offset = "0x6775800", VA = "0x186776A00")]
	[Preserve]
	public AFKKMLHKKOP()
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
