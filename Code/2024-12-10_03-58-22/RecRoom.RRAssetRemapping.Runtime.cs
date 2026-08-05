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
		[Cpp2IlInjected.Address(RVA = "0x75216D0", Offset = "0x75202D0", VA = "0x1875216D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HBDKMBBGKED : LNCOEDHLIAA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HPHEKPOJEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly JMJDDJJLLLD JBELHFJFFOK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7514870", Offset = "0x7513470", VA = "0x187514870")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	[UsedImplicitly]
	internal static void NPEAJDJKCFF(EAEKKMJPCLA AFCCBOCJBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7514000", Offset = "0x7512C00", VA = "0x187514000")]
	[UsedImplicitly]
	internal static void HEKGPECABEN(EAEKKMJPCLA AFCCBOCJBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	[RecRoom.NoEngine.Common.Preserve]
	public HBDKMBBGKED([JGAMIMHCGFI(null)] JMJDDJJLLLD JBELHFJFFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7514530", Offset = "0x7513130", VA = "0x187514530", Slot = "4")]
	public string IMPFBNFMBKJ(DMMPCDIHBGH GKMKPBACAOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7514060", Offset = "0x7512C60", VA = "0x187514060", Slot = "5")]
	public DMMPCDIHBGH ICHKPGLOBMP(string GKMKPBACAOC)
	{
		return default(DMMPCDIHBGH);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public SerializedAvatarItemId(CBNBPLCDNIL MJDOIIBKEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public CBNBPLCDNIL ICHKPGLOBMP()
		{
			return default(CBNBPLCDNIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedAvatarItemId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7520BB0", Offset = "0x751F7B0", VA = "0x187520BB0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7520C70", Offset = "0x751F870", VA = "0x187520C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, FABBPMKDCKI
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

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public NEHAEFNHPDF ICHKPGLOBMP()
		{
			return default(NEHAEFNHPDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedBodyShapeId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7520CE0", Offset = "0x751F8E0", VA = "0x187520CE0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7520D80", Offset = "0x751F980", VA = "0x187520D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, FABBPMKDCKI
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

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public EGLKLHOCNGC ICHKPGLOBMP()
		{
			return default(EGLKLHOCNGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedColorId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedColorId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7520DF0", Offset = "0x751F9F0", VA = "0x187520DF0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7520E90", Offset = "0x751FA90", VA = "0x187520E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, FABBPMKDCKI, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0")]
		public IDJGAJOPJGM ICHKPGLOBMP()
		{
			return default(IDJGAJOPJGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7521030", Offset = "0x751FC30", VA = "0x187521030")]
		public SerializedCombinationId(IDJGAJOPJGM IJAFELPDKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73AD2F0", Offset = "0x73ABEF0", VA = "0x1873AD2F0", Slot = "4")]
		public bool Equals(SerializedCombinationId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7520F00", Offset = "0x751FB00", VA = "0x187520F00", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedCombinationId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7520FC0", Offset = "0x751FBC0", VA = "0x187520FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7520FB0", Offset = "0x751FBB0", VA = "0x187520FB0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, FABBPMKDCKI
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public SerializedCustomAvatarItemId(Guid OCIHAODAEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7521040", Offset = "0x751FC40", VA = "0x187521040", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50")]
		public static bool PCHFOHOKDFG(SerializedCustomAvatarItemId KFIDOCPNAED, SerializedCustomAvatarItemId AMMLBECACOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75210E0", Offset = "0x751FCE0", VA = "0x1875210E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0x75211F0", Offset = "0x751FDF0", VA = "0x1875211F0")]
		public static SerializedEquipmentSkinId OMPMBADGOJI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public AAONFFKKDKE ICHKPGLOBMP()
		{
			return default(AAONFFKKDKE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7521150", Offset = "0x751FD50", VA = "0x187521150", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7521220", Offset = "0x751FE20", VA = "0x187521220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public OCAFLGKEFMJ ICHKPGLOBMP()
		{
			return default(OCAFLGKEFMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7521290", Offset = "0x751FE90", VA = "0x187521290", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7521330", Offset = "0x751FF30", VA = "0x187521330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public HDCHENBKBCD ICHKPGLOBMP()
		{
			return default(HDCHENBKBCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedFaceShapeId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75213A0", Offset = "0x751FFA0", VA = "0x1875213A0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7521440", Offset = "0x7520040", VA = "0x187521440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public BMMFMLLGCKA ICHKPGLOBMP()
		{
			return default(BMMFMLLGCKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50", Slot = "4")]
		public bool Equals(SerializedHairPatternId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75214B0", Offset = "0x75200B0", VA = "0x1875214B0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7520C50", Offset = "0x751F850", VA = "0x187520C50")]
		public static bool PCHFOHOKDFG(SerializedHairPatternId KFIDOCPNAED, SerializedHairPatternId AMMLBECACOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7521550", Offset = "0x7520150", VA = "0x187521550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, FABBPMKDCKI
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
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public SerializedMaterialId(JGOKHBGKIBM MJDOIIBKEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0", Slot = "6")]
		public Guid HJPDJNHGBPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73AD2F0", Offset = "0x73ABEF0", VA = "0x1873AD2F0", Slot = "4")]
		public bool Equals(SerializedMaterialId FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x75215C0", Offset = "0x75201C0", VA = "0x1875215C0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AE63C0", Offset = "0x6AE4FC0", VA = "0x186AE63C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4DC0", VA = "0x186AE61C0", Slot = "5")]
		public int CompareTo(SerializedMaterialId FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7521660", Offset = "0x7520260", VA = "0x187521660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AKLFOHDNBGJ : JMJDDJJLLLD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AKLFOHDNBGJ AAGIFLNDKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x750E4E0", Offset = "0x750D0E0", VA = "0x18750E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JEKDCHAMNLK<CBNBPLCDNIL> MHMAONPKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x750E600", Offset = "0x750D200", VA = "0x18750E600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JEKDCHAMNLK<AAONFFKKDKE> FPLFOJDAHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x750E660", Offset = "0x750D260", VA = "0x18750E660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JEKDCHAMNLK<BMMFMLLGCKA> CCGLOCPMKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x750E720", Offset = "0x750D320", VA = "0x18750E720", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JEKDCHAMNLK<IDJGAJOPJGM> GIGNJBNCANK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x750E5A0", Offset = "0x750D1A0", VA = "0x18750E5A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JEKDCHAMNLK<EGLKLHOCNGC> LFMGGAGCGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x750E540", Offset = "0x750D140", VA = "0x18750E540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JEKDCHAMNLK<HDCHENBKBCD> AOHBBOELNDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x750E780", Offset = "0x750D380", VA = "0x18750E780", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JEKDCHAMNLK<NEHAEFNHPDF> NEOAKNNGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x750E6C0", Offset = "0x750D2C0", VA = "0x18750E6C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JEKDCHAMNLK<OCAFLGKEFMJ> PLFDPCJKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x750E480", Offset = "0x750D080", VA = "0x18750E480", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DIGHAACIIPH
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x750E8B0", Offset = "0x750D4B0", VA = "0x18750E8B0")]
	public static Guid OPOAFGDFHCC(string PBJDJGLLEON)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x750E7E0", Offset = "0x750D3E0", VA = "0x18750E7E0")]
	public static bool MMFJDLNOIIJ(string PBJDJGLLEON, [Out] Guid OCIHAODAEFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EPNAGPNFNJG : KNPEIINFLOO<CBNBPLCDNIL>, CAEFHGPOHED<CBNBPLCDNIL>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x750EF70", Offset = "0x750DB70", VA = "0x18750EF70", Slot = "4")]
	public IEnumerable<(CBNBPLCDNIL, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7513BC0", Offset = "0x75127C0", VA = "0x187513BC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public CBNBPLCDNIL IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(CBNBPLCDNIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public EPNAGPNFNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HPMLKDHBOGN : KNPEIINFLOO<NEHAEFNHPDF>, CAEFHGPOHED<NEHAEFNHPDF>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7514980", Offset = "0x7513580", VA = "0x187514980", Slot = "4")]
	public IEnumerable<(NEHAEFNHPDF, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public NEHAEFNHPDF IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(NEHAEFNHPDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HPMLKDHBOGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NNGHIKHMMPP : KNPEIINFLOO<EGLKLHOCNGC>, CAEFHGPOHED<EGLKLHOCNGC>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x751CFB0", Offset = "0x751BBB0", VA = "0x18751CFB0", Slot = "4")]
	public IEnumerable<(EGLKLHOCNGC, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public EGLKLHOCNGC IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(EGLKLHOCNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public NNGHIKHMMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OOAJMPFFCHO : KNPEIINFLOO<IDJGAJOPJGM>, CAEFHGPOHED<IDJGAJOPJGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CAEFHGPOHED<JGOKHBGKIBM> IMCPIBGMIPM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public OOAJMPFFCHO(CAEFHGPOHED<JGOKHBGKIBM> IMCPIBGMIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73AE0C0", Offset = "0x73ACCC0", VA = "0x1873AE0C0", Slot = "4")]
	public IEnumerable<(IDJGAJOPJGM, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x751F070", Offset = "0x751DC70", VA = "0x18751F070", Slot = "6")]
	public IDJGAJOPJGM IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(IDJGAJOPJGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x751F2B0", Offset = "0x751DEB0", VA = "0x18751F2B0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JGNBNKPDOPM : KNPEIINFLOO<AAONFFKKDKE>, CAEFHGPOHED<AAONFFKKDKE>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7514D20", Offset = "0x7513920", VA = "0x187514D20", Slot = "4")]
	public IEnumerable<(AAONFFKKDKE, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public AAONFFKKDKE IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(AAONFFKKDKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public JGNBNKPDOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PHJLCEKACNL : KNPEIINFLOO<OCAFLGKEFMJ>, CAEFHGPOHED<OCAFLGKEFMJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x751F2F0", Offset = "0x751DEF0", VA = "0x18751F2F0", Slot = "4")]
	public IEnumerable<(OCAFLGKEFMJ, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public OCAFLGKEFMJ IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(OCAFLGKEFMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public PHJLCEKACNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FPIMFLDKMGB : KNPEIINFLOO<HDCHENBKBCD>, CAEFHGPOHED<HDCHENBKBCD>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7513BE0", Offset = "0x75127E0", VA = "0x187513BE0", Slot = "4")]
	public IEnumerable<(HDCHENBKBCD, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public HDCHENBKBCD IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(HDCHENBKBCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public FPIMFLDKMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MJOHKBMKOOI : KNPEIINFLOO<BMMFMLLGCKA>, CAEFHGPOHED<BMMFMLLGCKA>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x751C930", Offset = "0x751B530", VA = "0x18751C930", Slot = "4")]
	public IEnumerable<(BMMFMLLGCKA, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public BMMFMLLGCKA IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(BMMFMLLGCKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public MJOHKBMKOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KNPEIINFLOO<TModern> : CAEFHGPOHED<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LLCODCCMKGA();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MACOGBGGNDF(string FBANPKAIANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KDPLAKLDIPD : KNPEIINFLOO<JGOKHBGKIBM>, CAEFHGPOHED<JGOKHBGKIBM>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74631E0", Offset = "0x7461DE0", VA = "0x1874631E0", Slot = "4")]
	public IEnumerable<(JGOKHBGKIBM, string)> LLCODCCMKGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xC3EBC0", Offset = "0xC3D7C0", VA = "0x180C3EBC0", Slot = "5")]
	public string MACOGBGGNDF(string FBANPKAIANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x750EEB0", Offset = "0x750DAB0", VA = "0x18750EEB0", Slot = "6")]
	public JGOKHBGKIBM IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return default(JGOKHBGKIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public KDPLAKLDIPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HMEINNFPLJC<TModern> : JEKDCHAMNLK<TModern>, CAEFHGPOHED<TModern> where TModern : IEquatable<TModern>, FABBPMKDCKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> CEOELMAKLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> KCOAICCBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KNPEIINFLOO<TModern> CBMNAIDFCOH;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3F59020", Offset = "0x3F57C20", VA = "0x183F59020")]
	public HMEINNFPLJC(KNPEIINFLOO<TModern> CBMNAIDFCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F56E10", Offset = "0x3F55A10", VA = "0x183F56E10", Slot = "5")]
	public TModern IDHBOEHFCLD(string FBANPKAIANJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F55850", Offset = "0x3F54450", VA = "0x183F55850", Slot = "4")]
	public string BEPIEEHOBLI(TModern DDIPKGKAAHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EGDAOHNMOIO : JMJDDJJLLLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private HMEINNFPLJC<CBNBPLCDNIL> DMDGIAEPBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HMEINNFPLJC<AAONFFKKDKE> LHLBKOOABPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HMEINNFPLJC<BMMFMLLGCKA> DMENDBJKODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private HMEINNFPLJC<JGOKHBGKIBM> IMCPIBGMIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private HMEINNFPLJC<IDJGAJOPJGM> JBAPDGFBBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HMEINNFPLJC<EGLKLHOCNGC> GKMGNJFIBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HMEINNFPLJC<HDCHENBKBCD> LKPJAPBMOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private HMEINNFPLJC<NEHAEFNHPDF> CMNOBCFPAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HMEINNFPLJC<OCAFLGKEFMJ> CJOKBDJAFGP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JEKDCHAMNLK<CBNBPLCDNIL> MHMAONPKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JEKDCHAMNLK<AAONFFKKDKE> FPLFOJDAHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JEKDCHAMNLK<BMMFMLLGCKA> CCGLOCPMKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JEKDCHAMNLK<IDJGAJOPJGM> GIGNJBNCANK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JEKDCHAMNLK<EGLKLHOCNGC> LFMGGAGCGBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JEKDCHAMNLK<HDCHENBKBCD> AOHBBOELNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JEKDCHAMNLK<NEHAEFNHPDF> NEOAKNNGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JEKDCHAMNLK<OCAFLGKEFMJ> PLFDPCJKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x750E960", Offset = "0x750D560", VA = "0x18750E960")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	[UsedImplicitly]
	internal static void PLEEJGNKMDM(EAEKKMJPCLA AFCCBOCJBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x750E9D0", Offset = "0x750D5D0", VA = "0x18750E9D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EGDAOHNMOIO()
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
