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
		[Cpp2IlInjected.Address(RVA = "0x868CA70", Offset = "0x868BC70", VA = "0x18868CA70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CPNFFLLGCGM : IPAKPNEOHDP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex GNPAENEEPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FCFDCMAIFMA KKFHBKHKLCD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8688A80", Offset = "0x8687C80", VA = "0x188688A80")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	[UsedImplicitly]
	internal static void NPCFNJKLMBL(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8688550", Offset = "0x8687750", VA = "0x188688550")]
	[UsedImplicitly]
	internal static void FMMLIDKABOA(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CPNFFLLGCGM([ALHAHLCGLLK(null)] FCFDCMAIFMA KKFHBKHKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8688210", Offset = "0x8687410", VA = "0x188688210", Slot = "4")]
	public string CEBCPPBDNIB(PMLAJJBBALO EEEOGOJIPGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x86885B0", Offset = "0x86877B0", VA = "0x1886885B0", Slot = "5")]
	public PMLAJJBBALO JKAINKAKBPB(string EEEOGOJIPGB)
	{
		return default(PMLAJJBBALO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public KAKAKJKDPIO JKAINKAKBPB()
		{
			return default(KAKAKJKDPIO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x868BF40", Offset = "0x868B140", VA = "0x18868BF40", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x868C000", Offset = "0x868B200", VA = "0x18868C000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public PAPGPDMJLIC JKAINKAKBPB()
		{
			return default(PAPGPDMJLIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x868C070", Offset = "0x868B270", VA = "0x18868C070", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x868C110", Offset = "0x868B310", VA = "0x18868C110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public IKJJOJNJAPI JKAINKAKBPB()
		{
			return default(IKJJOJNJAPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedColorId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedColorId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x868C180", Offset = "0x868B380", VA = "0x18868C180", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x868C220", Offset = "0x868B420", VA = "0x18868C220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, FDEINOGEHIH, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		public MKHDGODFEOG JKAINKAKBPB()
		{
			return default(MKHDGODFEOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8518C10", Offset = "0x8517E10", VA = "0x188518C10", Slot = "4")]
		public bool Equals(SerializedCombinationId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x868C290", Offset = "0x868B490", VA = "0x18868C290", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedCombinationId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x868C350", Offset = "0x868B550", VA = "0x18868C350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x868C340", Offset = "0x868B540", VA = "0x18868C340", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CC0", Offset = "0x1226EC0", VA = "0x181227CC0")]
		public SerializedCustomAvatarItemId(Guid DIHOLCNHIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public static SerializedCustomAvatarItemId NDGNKFKKOGC(Guid DIHOLCNHIND)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868C3E0", Offset = "0x868B5E0", VA = "0x18868C3E0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0")]
		public static bool NDBPPCEOMJH(SerializedCustomAvatarItemId MHEJPNNFCGC, SerializedCustomAvatarItemId BGMAPCGDHFK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x868C3C0", Offset = "0x868B5C0", VA = "0x18868C3C0")]
		public static bool EFJOOJHLAGB(SerializedCustomAvatarItemId MHEJPNNFCGC, SerializedCustomAvatarItemId BGMAPCGDHFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x868C480", Offset = "0x868B680", VA = "0x18868C480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x868C590", Offset = "0x868B790", VA = "0x18868C590")]
		public static SerializedEquipmentSkinId KAGELFDMGNK()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public FDOICMMGLJH JKAINKAKBPB()
		{
			return default(FDOICMMGLJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x868C4F0", Offset = "0x868B6F0", VA = "0x18868C4F0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x868C5C0", Offset = "0x868B7C0", VA = "0x18868C5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public FOJCDPOPCPL JKAINKAKBPB()
		{
			return default(FOJCDPOPCPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x868C630", Offset = "0x868B830", VA = "0x18868C630", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x868C6D0", Offset = "0x868B8D0", VA = "0x18868C6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public BBPDKPJNAIP JKAINKAKBPB()
		{
			return default(BBPDKPJNAIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x868C740", Offset = "0x868B940", VA = "0x18868C740", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x868C7E0", Offset = "0x868B9E0", VA = "0x18868C7E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0")]
		public GIGIBBKKLGE JKAINKAKBPB()
		{
			return default(GIGIBBKKLGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0", Slot = "4")]
		public bool Equals(SerializedHairPatternId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x868C850", Offset = "0x868BA50", VA = "0x18868C850", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x868BFE0", Offset = "0x868B1E0", VA = "0x18868BFE0")]
		public static bool NDBPPCEOMJH(SerializedHairPatternId MHEJPNNFCGC, SerializedHairPatternId BGMAPCGDHFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x868C8F0", Offset = "0x868BAF0", VA = "0x18868C8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, FDEINOGEHIH
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
		[Cpp2IlInjected.Address(RVA = "0x1227CB0", Offset = "0x1226EB0", VA = "0x181227CB0", Slot = "6")]
		public Guid KLJAHCEDMMF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8518C10", Offset = "0x8517E10", VA = "0x188518C10", Slot = "4")]
		public bool Equals(SerializedMaterialId FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x868C960", Offset = "0x868BB60", VA = "0x18868C960", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B19640", Offset = "0x7B18840", VA = "0x187B19640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B194B0", Offset = "0x7B186B0", VA = "0x187B194B0", Slot = "5")]
		public int CompareTo(SerializedMaterialId FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x868CA00", Offset = "0x868BC00", VA = "0x18868CA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KFNJFDIIOAD : FCFDCMAIFMA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KFNJFDIIOAD NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8688D10", Offset = "0x8687F10", VA = "0x188688D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NILCLPCBFCI<KAKAKJKDPIO> PLAEDDNMMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8688C50", Offset = "0x8687E50", VA = "0x188688C50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NILCLPCBFCI<FDOICMMGLJH> HLCOOOKHEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8688CB0", Offset = "0x8687EB0", VA = "0x188688CB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NILCLPCBFCI<GIGIBBKKLGE> PLGMPGNMLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8688D70", Offset = "0x8687F70", VA = "0x188688D70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NILCLPCBFCI<MKHDGODFEOG> JLEGMNAHIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8688E30", Offset = "0x8688030", VA = "0x188688E30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NILCLPCBFCI<IKJJOJNJAPI> JIIMJLMHKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8688E90", Offset = "0x8688090", VA = "0x188688E90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NILCLPCBFCI<BBPDKPJNAIP> EOOHAHAHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8688B90", Offset = "0x8687D90", VA = "0x188688B90", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NILCLPCBFCI<PAPGPDMJLIC> DLGAHHHBCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8688BF0", Offset = "0x8687DF0", VA = "0x188688BF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NILCLPCBFCI<FOJCDPOPCPL> FEAIJEPMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8688DD0", Offset = "0x8687FD0", VA = "0x188688DD0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KMPDEJKOIHK
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8688FC0", Offset = "0x86881C0", VA = "0x188688FC0")]
	public static Guid FCKMHEJDOLN(string KDALBLHEOPF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8688EF0", Offset = "0x86880F0", VA = "0x188688EF0")]
	public static bool BHHLGDILCFL(string KDALBLHEOPF, [Out] Guid DIHOLCNHIND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AKEGFAHPMAL : OFKOGOELLOG<KAKAKJKDPIO>, AHMEIAFMAAE<KAKAKJKDPIO>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x867B9B0", Offset = "0x867ABB0", VA = "0x18867B9B0", Slot = "4")]
	public IEnumerable<(KAKAKJKDPIO, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x867B990", Offset = "0x867AB90", VA = "0x18867B990", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public KAKAKJKDPIO BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(KAKAKJKDPIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AKEGFAHPMAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PLIPPNFKPKA : OFKOGOELLOG<PAPGPDMJLIC>, AHMEIAFMAAE<PAPGPDMJLIC>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x868BBA0", Offset = "0x868ADA0", VA = "0x18868BBA0", Slot = "4")]
	public IEnumerable<(PAPGPDMJLIC, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public PAPGPDMJLIC BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(PAPGPDMJLIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PLIPPNFKPKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AAPKJKNNGPM : OFKOGOELLOG<IKJJOJNJAPI>, AHMEIAFMAAE<IKJJOJNJAPI>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86798D0", Offset = "0x8678AD0", VA = "0x1886798D0", Slot = "4")]
	public IEnumerable<(IKJJOJNJAPI, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public IKJJOJNJAPI BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(IKJJOJNJAPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AAPKJKNNGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MGNEBOOPPBB : OFKOGOELLOG<MKHDGODFEOG>, AHMEIAFMAAE<MKHDGODFEOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly AHMEIAFMAAE<DHHAOBCCFCA> OANNILFJIDI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public MGNEBOOPPBB(AHMEIAFMAAE<DHHAOBCCFCA> OANNILFJIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8519450", Offset = "0x8518650", VA = "0x188519450", Slot = "4")]
	public IEnumerable<(MKHDGODFEOG, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8689A20", Offset = "0x8688C20", VA = "0x188689A20", Slot = "6")]
	public MKHDGODFEOG BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(MKHDGODFEOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86899E0", Offset = "0x8688BE0", VA = "0x1886899E0", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CKPAKGPNBLP : OFKOGOELLOG<FDOICMMGLJH>, AHMEIAFMAAE<FDOICMMGLJH>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8680600", Offset = "0x867F800", VA = "0x188680600", Slot = "4")]
	public IEnumerable<(FDOICMMGLJH, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public FDOICMMGLJH BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(FDOICMMGLJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CKPAKGPNBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NAECALHBALC : OFKOGOELLOG<FOJCDPOPCPL>, AHMEIAFMAAE<FOJCDPOPCPL>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8689C60", Offset = "0x8688E60", VA = "0x188689C60", Slot = "4")]
	public IEnumerable<(FOJCDPOPCPL, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public FOJCDPOPCPL BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(FOJCDPOPCPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NAECALHBALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MENCIMLFFMH : OFKOGOELLOG<BBPDKPJNAIP>, AHMEIAFMAAE<BBPDKPJNAIP>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86895C0", Offset = "0x86887C0", VA = "0x1886895C0", Slot = "4")]
	public IEnumerable<(BBPDKPJNAIP, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public BBPDKPJNAIP BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(BBPDKPJNAIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MENCIMLFFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OGOBDHGJPMM : OFKOGOELLOG<GIGIBBKKLGE>, AHMEIAFMAAE<GIGIBBKKLGE>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x868B520", Offset = "0x868A720", VA = "0x18868B520", Slot = "4")]
	public IEnumerable<(GIGIBBKKLGE, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public GIGIBBKKLGE BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(GIGIBBKKLGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OGOBDHGJPMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OFKOGOELLOG<TModern> : AHMEIAFMAAE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DEONLAKFGMO();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AEBCPFAPNGL(string HGAGGMCNOOK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CEHCNPGLCND : OFKOGOELLOG<DHHAOBCCFCA>, AHMEIAFMAAE<DHHAOBCCFCA>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85CE570", Offset = "0x85CD770", VA = "0x1885CE570", Slot = "4")]
	public IEnumerable<(DHHAOBCCFCA, string)> DEONLAKFGMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xAA6950", Offset = "0xAA5B50", VA = "0x180AA6950", Slot = "5")]
	public string AEBCPFAPNGL(string HGAGGMCNOOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8679810", Offset = "0x8678A10", VA = "0x188679810", Slot = "6")]
	public DHHAOBCCFCA BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return default(DHHAOBCCFCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CEHCNPGLCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JOCJJFGCIMJ<TModern> : NILCLPCBFCI<TModern>, AHMEIAFMAAE<TModern> where TModern : IEquatable<TModern>, FDEINOGEHIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> OGMEABNNEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> EIHHBJMFDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OFKOGOELLOG<TModern> DENNJDFFDMD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4F082E0", Offset = "0x4F074E0", VA = "0x184F082E0")]
	public JOCJJFGCIMJ(OFKOGOELLOG<TModern> DENNJDFFDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4F05EC0", Offset = "0x4F050C0", VA = "0x184F05EC0", Slot = "5")]
	public TModern BNDNJGKOAHB(string HGAGGMCNOOK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F06D80", Offset = "0x4F05F80", VA = "0x184F06D80", Slot = "4")]
	public string DAFOLHGFINO(TModern INKDJLNMJDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LCOEFDJHCDL : FCFDCMAIFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JOCJJFGCIMJ<KAKAKJKDPIO> AEIBMOFCLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JOCJJFGCIMJ<FDOICMMGLJH> NHCACODHEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JOCJJFGCIMJ<GIGIBBKKLGE> GKLBHJMOMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JOCJJFGCIMJ<DHHAOBCCFCA> OANNILFJIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JOCJJFGCIMJ<MKHDGODFEOG> HINNMHLPAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JOCJJFGCIMJ<IKJJOJNJAPI> FCGOHAPILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JOCJJFGCIMJ<BBPDKPJNAIP> CMOIJMOIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JOCJJFGCIMJ<PAPGPDMJLIC> GINKHBIDDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JOCJJFGCIMJ<FOJCDPOPCPL> GAKNAGIKNAE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NILCLPCBFCI<KAKAKJKDPIO> PLAEDDNMMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NILCLPCBFCI<FDOICMMGLJH> HLCOOOKHEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NILCLPCBFCI<GIGIBBKKLGE> PLGMPGNMLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NILCLPCBFCI<MKHDGODFEOG> JLEGMNAHIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NILCLPCBFCI<IKJJOJNJAPI> JIIMJLMHKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NILCLPCBFCI<BBPDKPJNAIP> EOOHAHAHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NILCLPCBFCI<PAPGPDMJLIC> DLGAHHHBCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NILCLPCBFCI<FOJCDPOPCPL> FEAIJEPMAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8689070", Offset = "0x8688270", VA = "0x188689070")]
	[DBIDCJGLKKO.BICJMLCNMCI.FCGHBDOAPKJ]
	[UsedImplicitly]
	internal static void IMCKJCIKHAK(HILJAABEPDC PHIACDDDGBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x86890E0", Offset = "0x86882E0", VA = "0x1886890E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LCOEFDJHCDL()
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
