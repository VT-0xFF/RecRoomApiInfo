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
public class EFFHHJEKCLA : KFFAMNKBMMP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex IAHPOHPJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FNOCCEJOOKG CBMGAKIHLLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6459FD0", Offset = "0x64593D0", VA = "0x186459FD0")]
	[JMGGEKJCAGA(PLCOHLLKCIG.GameOnly)]
	private static void KLOPPCLPFPI(DIBCBJLEDOH OCLBHAALDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x645A0D0", Offset = "0x64594D0", VA = "0x18645A0D0")]
	[JMGGEKJCAGA(PLCOHLLKCIG.EditorOnly)]
	private static void MKOBFDDAFKJ(DIBCBJLEDOH OCLBHAALDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	[Preserve]
	public EFFHHJEKCLA([MJHHGJKKIMK(null)] FNOCCEJOOKG CBMGAKIHLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6459450", Offset = "0x6458850", VA = "0x186459450", Slot = "4")]
	public string ALIOEPOJFBC(AFKPLGJHCHM CGOLCEEBMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6459910", Offset = "0x6458D10", VA = "0x186459910", Slot = "5")]
	public AFKPLGJHCHM JKMDPBEAKHM(string CGOLCEEBMBE)
	{
		return default(AFKPLGJHCHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OFPLKPOBGOF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x645B650", Offset = "0x645AA50", VA = "0x18645B650")]
	public static FNOCCEJOOKG BEKGEIGLIMC()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public SerializedAvatarItemId(GBIOGAOCJBJ EPDCALNHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public GBIOGAOCJBJ JKMDPBEAKHM()
		{
			return default(GBIOGAOCJBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x645BF10", Offset = "0x645B310", VA = "0x18645BF10", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x645BFE0", Offset = "0x645B3E0", VA = "0x18645BFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public GEPFDDJIGPC JKMDPBEAKHM()
		{
			return default(GEPFDDJIGPC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x645C050", Offset = "0x645B450", VA = "0x18645C050", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x645C0F0", Offset = "0x645B4F0", VA = "0x18645C0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public JKAEIHBBPEI JKMDPBEAKHM()
		{
			return default(JKAEIHBBPEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedColorId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedColorId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x645C160", Offset = "0x645B560", VA = "0x18645C160", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x645C200", Offset = "0x645B600", VA = "0x18645C200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, KLGEPHJGHEG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x645C420", Offset = "0x645B820", VA = "0x18645C420")]
		public HLIMNJNLOEL JKMDPBEAKHM()
		{
			return default(HLIMNJNLOEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x645C500", Offset = "0x645B900", VA = "0x18645C500")]
		public SerializedCombinationId(HLIMNJNLOEL BPDFAAHEPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x645C270", Offset = "0x645B670", VA = "0x18645C270")]
		private void EPPGEJDLOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20", Slot = "4")]
		public bool Equals(SerializedCombinationId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x645C370", Offset = "0x645B770", VA = "0x18645C370", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedCombinationId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x645C490", Offset = "0x645B890", VA = "0x18645C490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x645C480", Offset = "0x645B880", VA = "0x18645C480", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x645C5D0", Offset = "0x645B9D0", VA = "0x18645C5D0")]
		public static SerializedEquipmentSkinId GKKDPEIENEG()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public JEKHGGKMKJE JKMDPBEAKHM()
		{
			return default(JEKHGGKMKJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x645C530", Offset = "0x645B930", VA = "0x18645C530", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x645C600", Offset = "0x645BA00", VA = "0x18645C600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public EHPJADFBGFH JKMDPBEAKHM()
		{
			return default(EHPJADFBGFH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x645C670", Offset = "0x645BA70", VA = "0x18645C670", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x645C710", Offset = "0x645BB10", VA = "0x18645C710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public NBEFKMDGOAE JKMDPBEAKHM()
		{
			return default(NBEFKMDGOAE);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x645C780", Offset = "0x645BB80", VA = "0x18645C780", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x645C820", Offset = "0x645BC20", VA = "0x18645C820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public SerializedHairPatternId(NPDMNAIKMOE EPDCALNHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public NPDMNAIKMOE JKMDPBEAKHM()
		{
			return default(NPDMNAIKMOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0", Slot = "4")]
		public bool Equals(SerializedHairPatternId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x645C890", Offset = "0x645BC90", VA = "0x18645C890", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x645BFB0", Offset = "0x645B3B0", VA = "0x18645BFB0")]
		public static bool FCHDBNDMOOD(SerializedHairPatternId OJKFAPKLEMA, SerializedHairPatternId BBHLJNIGCPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x645C930", Offset = "0x645BD30", VA = "0x18645C930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, KLGEPHJGHEG
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
		[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
		public SerializedMaterialId(OOPDJHHIALL EPDCALNHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920", Slot = "6")]
		public Guid BINBFKFLBCA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public OOPDJHHIALL JKMDPBEAKHM()
		{
			return default(OOPDJHHIALL);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20", Slot = "4")]
		public bool Equals(SerializedMaterialId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x645C9A0", Offset = "0x645BDA0", VA = "0x18645C9A0", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x645BFD0", Offset = "0x645B3D0", VA = "0x18645BFD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20")]
		public static bool FCHDBNDMOOD(SerializedMaterialId OJKFAPKLEMA, SerializedMaterialId BBHLJNIGCPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializedMaterialId LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x645CA40", Offset = "0x645BE40", VA = "0x18645CA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DDOMBLEKNBP : FNOCCEJOOKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DDOMBLEKNBP NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64590B0", Offset = "0x64584B0", VA = "0x1864590B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AIEBEMKDAKL<GBIOGAOCJBJ> EPIPBLIGHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6459110", Offset = "0x6458510", VA = "0x186459110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AIEBEMKDAKL<JEKHGGKMKJE> JAMCCJLAMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6459290", Offset = "0x6458690", VA = "0x186459290", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AIEBEMKDAKL<NPDMNAIKMOE> FNHLKMLPIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64593B0", Offset = "0x64587B0", VA = "0x1864593B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AIEBEMKDAKL<HLIMNJNLOEL> KHPFNMDDPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6459230", Offset = "0x6458630", VA = "0x186459230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AIEBEMKDAKL<JKAEIHBBPEI> NLEDFKPKIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x64591D0", Offset = "0x64585D0", VA = "0x1864591D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AIEBEMKDAKL<NBEFKMDGOAE> IOICFPOOPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6459350", Offset = "0x6458750", VA = "0x186459350", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AIEBEMKDAKL<GEPFDDJIGPC> CLEENDALNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6459170", Offset = "0x6458570", VA = "0x186459170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AIEBEMKDAKL<EHPJADFBGFH> KDAGBDEMKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64592F0", Offset = "0x64586F0", VA = "0x1864592F0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6459000", Offset = "0x6458400", VA = "0x186459000")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class AJNCJHACBBD
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6458FF0", Offset = "0x64583F0", VA = "0x186458FF0")]
	public static string HIOOJJFFMKG(this Guid GJKCBNEBGAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6458FC0", Offset = "0x64583C0", VA = "0x186458FC0")]
	public static Guid BMGCABDGNEC(string GKDCLAHEDEI)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ELCBMGPBABJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HMCOKFOFFKL(IEnumerable<(string modernStr, string legacyStr)> CGOAKFJALLD);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class OIPIMAJGCOA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class JOGNKPCCJLK : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x645B530", Offset = "0x645A930", VA = "0x18645B530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1BCCA90", Offset = "0x1BCBE90", VA = "0x181BCCA90")]
		[DebuggerHidden]
		public JOGNKPCCJLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x645B580", Offset = "0x645A980", VA = "0x18645B580", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x645B180", Offset = "0x645A580", VA = "0x18645B180", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x645B3E0", Offset = "0x645A7E0", VA = "0x18645B3E0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x645B4E0", Offset = "0x645A8E0", VA = "0x18645B4E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x645B430", Offset = "0x645A830", VA = "0x18645B430", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x645B430", Offset = "0x645A830", VA = "0x18645B430", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x265F5E0", Offset = "0x265E9E0", VA = "0x18265F5E0")]
	internal static IEnumerable<(TModern, string)> FHJDGHDGGLM<TModern>(string GNJPPPIAIEG, ELCBMGPBABJ<TModern> BACOBHACGPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x645B6A0", Offset = "0x645AAA0", VA = "0x18645B6A0")]
	[IteratorStateMachine(typeof(JOGNKPCCJLK))]
	private static IEnumerable<(string, string)> ODHMPMDPFLE(AssetIdMappingJsonData GCBEIFOFGFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class INPHJPHANFD
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x645A780", Offset = "0x6459B80", VA = "0x18645A780")]
	public static Guid DBJEENLPGBL(string MNNOIAJEFIL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x645A6B0", Offset = "0x6459AB0", VA = "0x18645A6B0")]
	public static bool CPOBEIKDIDJ(string MNNOIAJEFIL, [Out] Guid GJKCBNEBGAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class IIFHGFDAIIJ<TModern> : JJPJCJIDKGC<TModern>, ELCBMGPBABJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LCFFDJPJHPA : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public IIFHGFDAIIJ<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDF9B30", Offset = "0xDF8F30", VA = "0x180DF9B30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34AA190", Offset = "0x34A9590", VA = "0x1834AA190", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDEA330", Offset = "0xDE9730", VA = "0x180DEA330")]
		[DebuggerHidden]
		public LCFFDJPJHPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x33C5DB0", Offset = "0x33C51B0", VA = "0x1833C5DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3A6EF50", Offset = "0x3A6E350", VA = "0x183A6EF50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F960", Offset = "0x3A6ED60", VA = "0x183A6F960")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FCE0", Offset = "0x3A6F0E0", VA = "0x183A6FCE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FAF0", Offset = "0x3A6EEF0", VA = "0x183A6FAF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x34F37A0", Offset = "0x34F2BA0", VA = "0x1834F37A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern GNJGMHKGGPJ(Guid GJKCBNEBGAL);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x375B9B0", Offset = "0x375ADB0", VA = "0x18375B9B0", Slot = "4")]
	public TModern ENBFEHJBPLG(string FMPLPHMNAJA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x375BA50", Offset = "0x375AE50", VA = "0x18375BA50", Slot = "5")]
	[IteratorStateMachine(typeof(IIFHGFDAIIJ<>.LCFFDJPJHPA))]
	public IEnumerable<(TModern, string)> HMCOKFOFFKL(IEnumerable<(string modernStr, string legacyStr)> BKFAIKGFKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected IIFHGFDAIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLIDNBAMDFP : IIFHGFDAIIJ<GBIOGAOCJBJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override GBIOGAOCJBJ GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(GBIOGAOCJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x645B720", Offset = "0x645AB20", VA = "0x18645B720")]
	internal static string GJBJPFCJBMC(string FMPLPHMNAJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x645B740", Offset = "0x645AB40", VA = "0x18645B740")]
	public PLIDNBAMDFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JIDFKNGGBGM : IIFHGFDAIIJ<GEPFDDJIGPC>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override GEPFDDJIGPC GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(GEPFDDJIGPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x645A830", Offset = "0x6459C30", VA = "0x18645A830")]
	public JIDFKNGGBGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KMOEJJGDHAP : IIFHGFDAIIJ<JKAEIHBBPEI>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override JKAEIHBBPEI GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(JKAEIHBBPEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x645B610", Offset = "0x645AA10", VA = "0x18645B610")]
	public KMOEJJGDHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HAIIHOCHJAD : JJPJCJIDKGC<HLIMNJNLOEL>, ELCBMGPBABJ<HLIMNJNLOEL>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JKNGNHCDABN : IEnumerable<(HLIMNJNLOEL, string)>, IEnumerable, IEnumerator<(HLIMNJNLOEL, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (HLIMNJNLOEL, string) <>2__current;

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
		public HAIIHOCHJAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (HLIMNJNLOEL, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3176DE0", Offset = "0x31761E0", VA = "0x183176DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((HLIMNJNLOEL, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x645B0A0", Offset = "0x645A4A0", VA = "0x18645B0A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x645B150", Offset = "0x645A550", VA = "0x18645B150")]
		[DebuggerHidden]
		public JKNGNHCDABN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x645B110", Offset = "0x645A510", VA = "0x18645B110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x645A870", Offset = "0x6459C70", VA = "0x18645A870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x645AED0", Offset = "0x645A2D0", VA = "0x18645AED0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x645B050", Offset = "0x645A450", VA = "0x18645B050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x645AF90", Offset = "0x645A390", VA = "0x18645AF90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(HLIMNJNLOEL, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x645AF90", Offset = "0x645A390", VA = "0x18645AF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JJPJCJIDKGC<OOPDJHHIALL> KNJMBGAGBHC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public HAIIHOCHJAD(JJPJCJIDKGC<OOPDJHHIALL> KNJMBGAGBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x645A250", Offset = "0x6459650", VA = "0x18645A250", Slot = "4")]
	public HLIMNJNLOEL ENBFEHJBPLG(string FMPLPHMNAJA)
	{
		return default(HLIMNJNLOEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x645A590", Offset = "0x6459990", VA = "0x18645A590", Slot = "5")]
	[IteratorStateMachine(typeof(JKNGNHCDABN))]
	public IEnumerable<(HLIMNJNLOEL, string)> HMCOKFOFFKL(IEnumerable<(string modernStr, string legacyStr)> CGOAKFJALLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x645A550", Offset = "0x6459950", VA = "0x18645A550")]
	internal static string GJBJPFCJBMC(string FMPLPHMNAJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EAPFILPCJGB : IIFHGFDAIIJ<JEKHGGKMKJE>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override JEKHGGKMKJE GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(JEKHGGKMKJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6459410", Offset = "0x6458810", VA = "0x186459410")]
	public EAPFILPCJGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HFBFMDPHOCD : IIFHGFDAIIJ<EHPJADFBGFH>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override EHPJADFBGFH GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(EHPJADFBGFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x645A630", Offset = "0x6459A30", VA = "0x18645A630")]
	public HFBFMDPHOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FOLGKHGBMIE : IIFHGFDAIIJ<NBEFKMDGOAE>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override NBEFKMDGOAE GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(NBEFKMDGOAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x645A210", Offset = "0x6459610", VA = "0x18645A210")]
	public FOLGKHGBMIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EGELOPAEEMO : IIFHGFDAIIJ<NPDMNAIKMOE>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override NPDMNAIKMOE GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(NPDMNAIKMOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x645A1D0", Offset = "0x64595D0", VA = "0x18645A1D0")]
	public EGELOPAEEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IDEIEBKCJEB : IIFHGFDAIIJ<OOPDJHHIALL>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "6")]
	protected override OOPDJHHIALL GNJGMHKGGPJ(Guid GJKCBNEBGAL)
	{
		return default(OOPDJHHIALL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x645A670", Offset = "0x6459A70", VA = "0x18645A670")]
	public IDEIEBKCJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EOOMHHNPCAM<TModern> : AIEBEMKDAKL<TModern>, JJPJCJIDKGC<TModern> where TModern : IEquatable<TModern>, KLGEPHJGHEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> MCDMACPNKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> FBLLDGJKCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> GEPMHEMHIIF;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3111F30", Offset = "0x3111330", VA = "0x183111F30")]
	public EOOMHHNPCAM(TextAsset OFLOOOJJGLM, ELCBMGPBABJ<TModern> BACOBHACGPI, [CanBeNull] Func<string, string> GEPMHEMHIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x310D770", Offset = "0x310CB70", VA = "0x18310D770", Slot = "5")]
	public TModern ENBFEHJBPLG(string FMPLPHMNAJA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x310EBC0", Offset = "0x310DFC0", VA = "0x18310EBC0", Slot = "4")]
	public string HNOKPEPFPLH(TModern KNBIBBLFHCP)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, FNOCCEJOOKG
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
		private EOOMHHNPCAM<GBIOGAOCJBJ> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EOOMHHNPCAM<JEKHGGKMKJE> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EOOMHHNPCAM<NPDMNAIKMOE> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EOOMHHNPCAM<OOPDJHHIALL> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private EOOMHHNPCAM<HLIMNJNLOEL> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EOOMHHNPCAM<JKAEIHBBPEI> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EOOMHHNPCAM<NBEFKMDGOAE> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private EOOMHHNPCAM<GEPFDDJIGPC> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EOOMHHNPCAM<EHPJADFBGFH> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AIEBEMKDAKL<GBIOGAOCJBJ> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x779420", Offset = "0x778820", VA = "0x180779420", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AIEBEMKDAKL<JEKHGGKMKJE> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7782D0", Offset = "0x7776D0", VA = "0x1807782D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AIEBEMKDAKL<NPDMNAIKMOE> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7782C0", Offset = "0x7776C0", VA = "0x1807782C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AIEBEMKDAKL<OOPDJHHIALL> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x770C90", Offset = "0x770090", VA = "0x180770C90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public AIEBEMKDAKL<HLIMNJNLOEL> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x770CE0", Offset = "0x7700E0", VA = "0x180770CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public AIEBEMKDAKL<JKAEIHBBPEI> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x770B60", Offset = "0x76FF60", VA = "0x180770B60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public AIEBEMKDAKL<NBEFKMDGOAE> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8AE730", Offset = "0x8ADB30", VA = "0x1808AE730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AIEBEMKDAKL<GEPFDDJIGPC> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x770C10", Offset = "0x770010", VA = "0x180770C10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AIEBEMKDAKL<EHPJADFBGFH> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x837040", Offset = "0x836440", VA = "0x180837040", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x645BE90", Offset = "0x645B290", VA = "0x18645BE90")]
		[JMGGEKJCAGA(IHKKALDEJFL.Root, PLCOHLLKCIG.GameOnly)]
		private static void PFOPFDLGLMI(DIBCBJLEDOH OCLBHAALDKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x645B780", Offset = "0x645AB80", VA = "0x18645B780")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5E90", VA = "0x1807F6A90")]
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
