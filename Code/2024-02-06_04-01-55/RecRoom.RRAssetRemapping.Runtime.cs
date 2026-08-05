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
public class FEJELCMEHCD : CMKIOPIPLAD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex CAAAJHADCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CLOCPKMNDGM IDOGLOMEIAG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66FEA60", Offset = "0x66FDE60", VA = "0x1866FEA60")]
	[HMKFFNEGBBO(FMOKCMPGPEB.GameOnly)]
	private static void OGNLIODLBPE(FJIKPBKCIMI ICOACGGPAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66FEA00", Offset = "0x66FDE00", VA = "0x1866FEA00")]
	[HMKFFNEGBBO(FMOKCMPGPEB.EditorOnly)]
	private static void NHFBOOIOEMB(FJIKPBKCIMI ICOACGGPAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	[Preserve]
	public FEJELCMEHCD([POFPGPCOKGP(null)] CLOCPKMNDGM IDOGLOMEIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66FDE80", Offset = "0x66FD280", VA = "0x1866FDE80", Slot = "4")]
	public string ILCGODJBNBA(BIICCJCEIJJ EPJNNNGOOAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66FE340", Offset = "0x66FD740", VA = "0x1866FE340", Slot = "5")]
	public BIICCJCEIJJ JCEFODEMOAF(string EPJNNNGOOAO)
	{
		return default(BIICCJCEIJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HANGBPHFFEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66FEC40", Offset = "0x66FE040", VA = "0x1866FEC40")]
	public static CLOCPKMNDGM PHMNKHBKNDG()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public SerializedAvatarItemId(NEDLJHKGNGL FNOGEAGAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public NEDLJHKGNGL JCEFODEMOAF()
		{
			return default(NEDLJHKGNGL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedAvatarItemId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6700AA0", Offset = "0x66FFEA0", VA = "0x186700AA0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6700B70", Offset = "0x66FFF70", VA = "0x186700B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public IBELFNPGJPB JCEFODEMOAF()
		{
			return default(IBELFNPGJPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedBodyShapeId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6700BE0", Offset = "0x66FFFE0", VA = "0x186700BE0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6700C80", Offset = "0x6700080", VA = "0x186700C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public GJBKAAIMHKF JCEFODEMOAF()
		{
			return default(GJBKAAIMHKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedColorId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedColorId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6700CF0", Offset = "0x67000F0", VA = "0x186700CF0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6700D90", Offset = "0x6700190", VA = "0x186700D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, BBHCOKLJNPJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6700FB0", Offset = "0x67003B0", VA = "0x186700FB0")]
		public CENAINPGEND JCEFODEMOAF()
		{
			return default(CENAINPGEND);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6701090", Offset = "0x6700490", VA = "0x186701090")]
		public SerializedCombinationId(CENAINPGEND APEGGJHHHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6700EB0", Offset = "0x67002B0", VA = "0x186700EB0")]
		private void HGKAHDJJPHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x614F380", Offset = "0x614E780", VA = "0x18614F380", Slot = "4")]
		public bool Equals(SerializedCombinationId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6700E00", Offset = "0x6700200", VA = "0x186700E00", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedCombinationId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6701020", Offset = "0x6700420", VA = "0x186701020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6701010", Offset = "0x6700410", VA = "0x186701010", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x67010C0", Offset = "0x67004C0", VA = "0x1867010C0")]
		public static SerializedEquipmentSkinId CBMHNFDDCFD()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public JEKOHKIPLMM JCEFODEMOAF()
		{
			return default(JEKOHKIPLMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67010F0", Offset = "0x67004F0", VA = "0x1867010F0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6701190", Offset = "0x6700590", VA = "0x186701190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public COJDBPEBDOA JCEFODEMOAF()
		{
			return default(COJDBPEBDOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6701200", Offset = "0x6700600", VA = "0x186701200", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67012A0", Offset = "0x67006A0", VA = "0x1867012A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public NKHGCNKBHIG JCEFODEMOAF()
		{
			return default(NKHGCNKBHIG);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedFaceShapeId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6701310", Offset = "0x6700710", VA = "0x186701310", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67013B0", Offset = "0x67007B0", VA = "0x1867013B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public SerializedHairPatternId(KLPHLAEFEOC FNOGEAGAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public KLPHLAEFEOC JCEFODEMOAF()
		{
			return default(KLPHLAEFEOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40", Slot = "4")]
		public bool Equals(SerializedHairPatternId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedHairPatternId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6701420", Offset = "0x6700820", VA = "0x186701420", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6700B40", Offset = "0x66FFF40", VA = "0x186700B40")]
		public static bool HOHCACPHFGD(SerializedHairPatternId BGDKODNOBOD, SerializedHairPatternId APAKCINIMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67014C0", Offset = "0x67008C0", VA = "0x1867014C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, BBHCOKLJNPJ
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
		[Cpp2IlInjected.Address(RVA = "0x1D42690", Offset = "0x1D41A90", VA = "0x181D42690")]
		public SerializedMaterialId(OEAEIPNHKDB FNOGEAGAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
		public Guid FBPFMNCBNOD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public OEAEIPNHKDB JCEFODEMOAF()
		{
			return default(OEAEIPNHKDB);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x614F380", Offset = "0x614E780", VA = "0x18614F380", Slot = "4")]
		public bool Equals(SerializedMaterialId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6701530", Offset = "0x6700930", VA = "0x186701530", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6700B60", Offset = "0x66FFF60", VA = "0x186700B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x614F380", Offset = "0x614E780", VA = "0x18614F380")]
		public static bool HOHCACPHFGD(SerializedMaterialId BGDKODNOBOD, SerializedMaterialId APAKCINIMJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializedMaterialId KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67015D0", Offset = "0x67009D0", VA = "0x1867015D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JPMDJJEMAMJ : CLOCPKMNDGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JPMDJJEMAMJ GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x66FF280", Offset = "0x66FE680", VA = "0x1866FF280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public OJOEPEDKNCC<NEDLJHKGNGL> GABDOAOCJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x66FF2E0", Offset = "0x66FE6E0", VA = "0x1866FF2E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OJOEPEDKNCC<JEKOHKIPLMM> DLEANBJEOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x66FF460", Offset = "0x66FE860", VA = "0x1866FF460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OJOEPEDKNCC<KLPHLAEFEOC> ENJJHBCKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x66FF580", Offset = "0x66FE980", VA = "0x1866FF580", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OJOEPEDKNCC<CENAINPGEND> EAMNPALOLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66FF400", Offset = "0x66FE800", VA = "0x1866FF400", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OJOEPEDKNCC<GJBKAAIMHKF> NMBBKFOGKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x66FF3A0", Offset = "0x66FE7A0", VA = "0x1866FF3A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OJOEPEDKNCC<NKHGCNKBHIG> LALKKKBJHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66FF520", Offset = "0x66FE920", VA = "0x1866FF520", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OJOEPEDKNCC<IBELFNPGJPB> ECBABGLACFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66FF340", Offset = "0x66FE740", VA = "0x1866FF340", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OJOEPEDKNCC<COJDBPEBDOA> ALNMMKENLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x66FF4C0", Offset = "0x66FE8C0", VA = "0x1866FF4C0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x66FDB50", Offset = "0x66FCF50", VA = "0x1866FDB50")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class ECFADDIONOF
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x66FDE30", Offset = "0x66FD230", VA = "0x1866FDE30")]
	public static string PIANDMFDBMC(this Guid LHLNCEHJAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66FDE00", Offset = "0x66FD200", VA = "0x1866FDE00")]
	public static Guid DELGDDBKHJJ(string NNHMDMFPJII)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GMNLHHLKIDH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> KNLBAJDPDDM(IEnumerable<(string modernStr, string legacyStr)> CBCGPPDFHEI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class HJPKPKKBOCN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JFBPKENAEMK : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA1FB90", Offset = "0xA1EF90", VA = "0x180A1FB90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x66FF100", Offset = "0x66FE500", VA = "0x1866FF100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C3B890", Offset = "0x1C3AC90", VA = "0x181C3B890")]
		[DebuggerHidden]
		public JFBPKENAEMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66FF150", Offset = "0x66FE550", VA = "0x1866FF150", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x66FEDA0", Offset = "0x66FE1A0", VA = "0x1866FEDA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x66FED50", Offset = "0x66FE150", VA = "0x1866FED50")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x66FF0B0", Offset = "0x66FE4B0", VA = "0x1866FF0B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66FF000", Offset = "0x66FE400", VA = "0x1866FF000", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66FF000", Offset = "0x66FE400", VA = "0x1866FF000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x268A640", Offset = "0x2689A40", VA = "0x18268A640")]
	internal static IEnumerable<(TModern, string)> FALEBMBGEKM<TModern>(string IEBIMDMBHDD, GMNLHHLKIDH<TModern> BCMLGHMLDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66FEC90", Offset = "0x66FE090", VA = "0x1866FEC90")]
	[IteratorStateMachine(typeof(JFBPKENAEMK))]
	private static IEnumerable<(string, string)> DJMIBLJINMC(AssetIdMappingJsonData INNGFNFNJHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BHPFAEKCFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x66FDC40", Offset = "0x66FD040", VA = "0x1866FDC40")]
	public static Guid JKBFIKBOKAE(string NMLIKIPFOAK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x66FDCF0", Offset = "0x66FD0F0", VA = "0x1866FDCF0")]
	public static bool MLBMBDDIMPE(string NMLIKIPFOAK, [Out] Guid LHLNCEHJAOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PAOGBNIPMKE<TModern> : IOONJIAMAMM<TModern>, GMNLHHLKIDH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GFKOCCMFGDO : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public PAOGBNIPMKE<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE47360", Offset = "0xE46760", VA = "0x180E47360", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x353FB70", Offset = "0x353EF70", VA = "0x18353FB70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE3E9C0", Offset = "0xE3DDC0", VA = "0x180E3E9C0")]
		[DebuggerHidden]
		public GFKOCCMFGDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3533770", VA = "0x183534370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3706D70", Offset = "0x3706170", VA = "0x183706D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x37053A0", Offset = "0x37047A0", VA = "0x1837053A0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3707390", Offset = "0x3706790", VA = "0x183707390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3707060", Offset = "0x3706460", VA = "0x183707060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x36C5720", Offset = "0x36C4B20", VA = "0x1836C5720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern PNCGHNHNCMD(Guid LHLNCEHJAOH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x407E510", Offset = "0x407D910", VA = "0x18407E510", Slot = "4")]
	public TModern LDMGOKAFNNK(string AKKFBEGKCIB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x407E3B0", Offset = "0x407D7B0", VA = "0x18407E3B0", Slot = "5")]
	[IteratorStateMachine(typeof(PAOGBNIPMKE<>.GFKOCCMFGDO))]
	public IEnumerable<(TModern, string)> KNLBAJDPDDM(IEnumerable<(string modernStr, string legacyStr)> EDEHKEKNHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected PAOGBNIPMKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JHMGPPLDMJG : PAOGBNIPMKE<NEDLJHKGNGL>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override NEDLJHKGNGL PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(NEDLJHKGNGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66FF220", Offset = "0x66FE620", VA = "0x1866FF220")]
	internal static string CJGKDJBNONE(string AKKFBEGKCIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x66FF240", Offset = "0x66FE640", VA = "0x1866FF240")]
	public JHMGPPLDMJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BLOENDJOFGB : PAOGBNIPMKE<IBELFNPGJPB>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override IBELFNPGJPB PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(IBELFNPGJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x66FDDC0", Offset = "0x66FD1C0", VA = "0x1866FDDC0")]
	public BLOENDJOFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JGJAFMADKFG : PAOGBNIPMKE<GJBKAAIMHKF>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override GJBKAAIMHKF PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(GJBKAAIMHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x66FF1E0", Offset = "0x66FE5E0", VA = "0x1866FF1E0")]
	public JGJAFMADKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OEEOEKIEKAG : IOONJIAMAMM<CENAINPGEND>, GMNLHHLKIDH<CENAINPGEND>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PFNLBKCEGMO : IEnumerable<(CENAINPGEND, string)>, IEnumerable, IEnumerator<(CENAINPGEND, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (CENAINPGEND, string) <>2__current;

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
		public OEEOEKIEKAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (CENAINPGEND, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x334DD70", Offset = "0x334D170", VA = "0x18334DD70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((CENAINPGEND, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6700230", Offset = "0x66FF630", VA = "0x186700230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x67002E0", Offset = "0x66FF6E0", VA = "0x1867002E0")]
		[DebuggerHidden]
		public PFNLBKCEGMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x67002A0", Offset = "0x66FF6A0", VA = "0x1867002A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x66FFAC0", Offset = "0x66FEEC0", VA = "0x1866FFAC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66FFA00", Offset = "0x66FEE00", VA = "0x1866FFA00")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x67001E0", Offset = "0x66FF5E0", VA = "0x1867001E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6700120", Offset = "0x66FF520", VA = "0x186700120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(CENAINPGEND, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6700120", Offset = "0x66FF520", VA = "0x186700120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IOONJIAMAMM<OEAEIPNHKDB> FJNBJHILJFH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public OEEOEKIEKAG(IOONJIAMAMM<OEAEIPNHKDB> FJNBJHILJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x66FF700", Offset = "0x66FEB00", VA = "0x1866FF700", Slot = "4")]
	public CENAINPGEND LDMGOKAFNNK(string AKKFBEGKCIB)
	{
		return default(CENAINPGEND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x66FF660", Offset = "0x66FEA60", VA = "0x1866FF660", Slot = "5")]
	[IteratorStateMachine(typeof(PFNLBKCEGMO))]
	public IEnumerable<(CENAINPGEND, string)> KNLBAJDPDDM(IEnumerable<(string modernStr, string legacyStr)> CBCGPPDFHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x66FF620", Offset = "0x66FEA20", VA = "0x1866FF620")]
	internal static string CJGKDJBNONE(string AKKFBEGKCIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MGBIEAFJPEP : PAOGBNIPMKE<JEKOHKIPLMM>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override JEKOHKIPLMM PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(JEKOHKIPLMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x66FF5E0", Offset = "0x66FE9E0", VA = "0x1866FF5E0")]
	public MGBIEAFJPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IIFNHGNOFIC : PAOGBNIPMKE<COJDBPEBDOA>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override COJDBPEBDOA PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(COJDBPEBDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x66FED10", Offset = "0x66FE110", VA = "0x1866FED10")]
	public IIFNHGNOFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FHOKGKELIOO : PAOGBNIPMKE<NKHGCNKBHIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override NKHGCNKBHIG PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(NKHGCNKBHIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66FEC00", Offset = "0x66FE000", VA = "0x1866FEC00")]
	public FHOKGKELIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BDMNNOLBNOE : PAOGBNIPMKE<KLPHLAEFEOC>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override KLPHLAEFEOC PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(KLPHLAEFEOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x66FDC00", Offset = "0x66FD000", VA = "0x1866FDC00")]
	public BDMNNOLBNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EKGIMNNGEIJ : PAOGBNIPMKE<OEAEIPNHKDB>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "6")]
	protected override OEAEIPNHKDB PNCGHNHNCMD(Guid LHLNCEHJAOH)
	{
		return default(OEAEIPNHKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x66FDE40", Offset = "0x66FD240", VA = "0x1866FDE40")]
	public EKGIMNNGEIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PIBJIPABIGL<TModern> : OJOEPEDKNCC<TModern>, IOONJIAMAMM<TModern> where TModern : IEquatable<TModern>, BBHCOKLJNPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> GBDBDKDGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> EBIFPCCCMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> MAKKPKJNDOK;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x409C120", Offset = "0x409B520", VA = "0x18409C120")]
	public PIBJIPABIGL(TextAsset IAOGDEFELCJ, GMNLHHLKIDH<TModern> BCMLGHMLDLA, [CanBeNull] Func<string, string> MAKKPKJNDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x40991F0", Offset = "0x40985F0", VA = "0x1840991F0", Slot = "5")]
	public TModern LDMGOKAFNNK(string AKKFBEGKCIB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4098260", Offset = "0x4097660", VA = "0x184098260", Slot = "4")]
	public string GGNAIIPBHPC(TModern EPLIKKPPNKC)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, CLOCPKMNDGM
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
		private PIBJIPABIGL<NEDLJHKGNGL> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PIBJIPABIGL<JEKOHKIPLMM> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PIBJIPABIGL<KLPHLAEFEOC> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PIBJIPABIGL<OEAEIPNHKDB> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private PIBJIPABIGL<CENAINPGEND> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PIBJIPABIGL<GJBKAAIMHKF> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PIBJIPABIGL<NKHGCNKBHIG> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private PIBJIPABIGL<IBELFNPGJPB> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private PIBJIPABIGL<COJDBPEBDOA> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OJOEPEDKNCC<NEDLJHKGNGL> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7A6820", Offset = "0x7A5C20", VA = "0x1807A6820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public OJOEPEDKNCC<JEKOHKIPLMM> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7A67A0", Offset = "0x7A5BA0", VA = "0x1807A67A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OJOEPEDKNCC<KLPHLAEFEOC> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7A67F0", Offset = "0x7A5BF0", VA = "0x1807A67F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public OJOEPEDKNCC<OEAEIPNHKDB> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x79E6D0", Offset = "0x79DAD0", VA = "0x18079E6D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public OJOEPEDKNCC<CENAINPGEND> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x79E700", Offset = "0x79DB00", VA = "0x18079E700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public OJOEPEDKNCC<GJBKAAIMHKF> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x79E760", Offset = "0x79DB60", VA = "0x18079E760", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OJOEPEDKNCC<NKHGCNKBHIG> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DCCD0", Offset = "0x8DC0D0", VA = "0x1808DCCD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public OJOEPEDKNCC<IBELFNPGJPB> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x79E710", Offset = "0x79DB10", VA = "0x18079E710", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OJOEPEDKNCC<COJDBPEBDOA> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x859C10", Offset = "0x859010", VA = "0x180859C10", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6700A20", Offset = "0x66FFE20", VA = "0x186700A20")]
		[HMKFFNEGBBO(PNDDNINAHEG.Root, FMOKCMPGPEB.GameOnly)]
		private static void PPHHLHHCDCB(FJIKPBKCIMI ICOACGGPAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6700310", Offset = "0x66FF710", VA = "0x186700310")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x858890", Offset = "0x857C90", VA = "0x180858890")]
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
