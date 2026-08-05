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
public class CABHDMCHKDK : CEAAANGKCJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex DJJJHHFHNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly DFCDEDIBLNN LBDMPCGIJJA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7213610", Offset = "0x7211C10", VA = "0x187213610")]
	[CCEDJDOPMOE(CFIDNIINJOK.GameOnly)]
	[UsedImplicitly]
	private static void EPFABJKOPAP(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72130F0", Offset = "0x72116F0", VA = "0x1872130F0")]
	[UsedImplicitly]
	[CCEDJDOPMOE(CFIDNIINJOK.EditorOnly)]
	private static void DGGHAPEKCFA(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	[Preserve]
	public CABHDMCHKDK([JLPFJOFFNLM(null)] DFCDEDIBLNN LBDMPCGIJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7212DB0", Offset = "0x72113B0", VA = "0x187212DB0", Slot = "4")]
	public string ALGEABNCNAB(DFMKIAJNCLI NGALCNCLJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7213150", Offset = "0x7211750", VA = "0x187213150", Slot = "5")]
	public DFMKIAJNCLI DIPBOAAMMJI(string NGALCNCLJMG)
	{
		return default(DFMKIAJNCLI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public SerializedAvatarItemId(CDMPNOCHBKH KAGKMEDPMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public CDMPNOCHBKH DIPBOAAMMJI()
		{
			return default(CDMPNOCHBKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7224EE0", Offset = "0x72234E0", VA = "0x187224EE0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7224FA0", Offset = "0x72235A0", VA = "0x187224FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public OGGKFBHPMHE DIPBOAAMMJI()
		{
			return default(OGGKFBHPMHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7225010", Offset = "0x7223610", VA = "0x187225010", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72250B0", Offset = "0x72236B0", VA = "0x1872250B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public GCJCGHEDGPM DIPBOAAMMJI()
		{
			return default(GCJCGHEDGPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedColorId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedColorId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7225120", Offset = "0x7223720", VA = "0x187225120", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72251C0", Offset = "0x72237C0", VA = "0x1872251C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, DPDJOGKPPAG, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1620", Offset = "0x9AFC20", VA = "0x1809B1620")]
		public NHDGGCIBEGO DIPBOAAMMJI()
		{
			return default(NHDGGCIBEGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7225360", Offset = "0x7223960", VA = "0x187225360")]
		public SerializedCombinationId(NHDGGCIBEGO PLAKDCIKCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B1DE0", VA = "0x1870B37E0", Slot = "4")]
		public bool Equals(SerializedCombinationId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7225230", Offset = "0x7223830", VA = "0x187225230", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedCombinationId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72252F0", Offset = "0x72238F0", VA = "0x1872252F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72252E0", Offset = "0x72238E0", VA = "0x1872252E0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public SerializedCustomAvatarItemId(Guid DHEKBCJKGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7225370", Offset = "0x7223970", VA = "0x187225370", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80")]
		public static bool MLHBCNDBLOI(SerializedCustomAvatarItemId GKFLJIIICHM, SerializedCustomAvatarItemId GCLENKIGLBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7225410", Offset = "0x7223A10", VA = "0x187225410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0x7225520", Offset = "0x7223B20", VA = "0x187225520")]
		public static SerializedEquipmentSkinId JINKHLGPKDO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public BJCALNENODB DIPBOAAMMJI()
		{
			return default(BJCALNENODB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7225480", Offset = "0x7223A80", VA = "0x187225480", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7225550", Offset = "0x7223B50", VA = "0x187225550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public CIFJPJIKLJC DIPBOAAMMJI()
		{
			return default(CIFJPJIKLJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72255C0", Offset = "0x7223BC0", VA = "0x1872255C0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7225660", Offset = "0x7223C60", VA = "0x187225660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public GHJNEJAMJEH DIPBOAAMMJI()
		{
			return default(GHJNEJAMJEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72256D0", Offset = "0x7223CD0", VA = "0x1872256D0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7225770", Offset = "0x7223D70", VA = "0x187225770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80")]
		public FPELILCNBPE DIPBOAAMMJI()
		{
			return default(FPELILCNBPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80", Slot = "4")]
		public bool Equals(SerializedHairPatternId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x72257E0", Offset = "0x7223DE0", VA = "0x1872257E0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7224F80", Offset = "0x7223580", VA = "0x187224F80")]
		public static bool MLHBCNDBLOI(SerializedHairPatternId GKFLJIIICHM, SerializedHairPatternId GCLENKIGLBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7225880", Offset = "0x7223E80", VA = "0x187225880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, DPDJOGKPPAG
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
		[Cpp2IlInjected.Address(RVA = "0xAC7B30", Offset = "0xAC6130", VA = "0x180AC7B30")]
		public SerializedMaterialId(NIAOHDCALJL KAGKMEDPMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A80", Offset = "0xAC6080", VA = "0x180AC7A80", Slot = "6")]
		public Guid JHOEONAIKKL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70B37E0", Offset = "0x70B1DE0", VA = "0x1870B37E0", Slot = "4")]
		public bool Equals(SerializedMaterialId OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72258F0", Offset = "0x7223EF0", VA = "0x1872258F0", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB66020", Offset = "0xB64620", VA = "0x180B66020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xB65E90", Offset = "0xB64490", VA = "0x180B65E90", Slot = "5")]
		public int CompareTo(SerializedMaterialId OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7225990", Offset = "0x7223F90", VA = "0x187225990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BMMMJCOFBDB : DFCDEDIBLNN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BMMMJCOFBDB HHHOBHGDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7212C90", Offset = "0x7211290", VA = "0x187212C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JHBIJAIELGJ<CDMPNOCHBKH> OKIPKFBHKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7212D50", Offset = "0x7211350", VA = "0x187212D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JHBIJAIELGJ<BJCALNENODB> FDJEGCNKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7212BD0", Offset = "0x72111D0", VA = "0x187212BD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JHBIJAIELGJ<FPELILCNBPE> JBKPGGCBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7212A50", Offset = "0x7211050", VA = "0x187212A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JHBIJAIELGJ<NHDGGCIBEGO> NCFLMAFOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7212CF0", Offset = "0x72112F0", VA = "0x187212CF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JHBIJAIELGJ<GCJCGHEDGPM> GHAEHKGHJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7212AB0", Offset = "0x72110B0", VA = "0x187212AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JHBIJAIELGJ<GHJNEJAMJEH> CNKDCJGOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7212C30", Offset = "0x7211230", VA = "0x187212C30", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JHBIJAIELGJ<OGGKFBHPMHE> GDEMOAOPLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7212B10", Offset = "0x7211110", VA = "0x187212B10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JHBIJAIELGJ<CIFJPJIKLJC> DMPPHJGJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7212B70", Offset = "0x7211170", VA = "0x187212B70", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IBEGPLJMJKB
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x721B800", Offset = "0x7219E00", VA = "0x18721B800")]
	public static Guid IPIALHMNAFP(string KOCPCKPHLDL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x721B8B0", Offset = "0x7219EB0", VA = "0x18721B8B0")]
	public static bool PKCOKDCKCNG(string KOCPCKPHLDL, [Out] Guid DHEKBCJKGBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MOCPGNIKJDI : DPBLGDGDEFF<CDMPNOCHBKH>, KNEPGJJBCKC<CDMPNOCHBKH>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x721FBF0", Offset = "0x721E1F0", VA = "0x18721FBF0", Slot = "4")]
	public IEnumerable<(CDMPNOCHBKH, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7224840", Offset = "0x7222E40", VA = "0x187224840", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public CDMPNOCHBKH GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(CDMPNOCHBKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MOCPGNIKJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJNNBCOCPAH : DPBLGDGDEFF<OGGKFBHPMHE>, KNEPGJJBCKC<OGGKFBHPMHE>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x721F300", Offset = "0x721D900", VA = "0x18721F300", Slot = "4")]
	public IEnumerable<(OGGKFBHPMHE, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public OGGKFBHPMHE GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(OGGKFBHPMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KJNNBCOCPAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IBOJEBLHJJN : DPBLGDGDEFF<GCJCGHEDGPM>, KNEPGJJBCKC<GCJCGHEDGPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x721B980", Offset = "0x7219F80", VA = "0x18721B980", Slot = "4")]
	public IEnumerable<(GCJCGHEDGPM, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public GCJCGHEDGPM GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(GCJCGHEDGPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public IBOJEBLHJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BKNLHOOJCJI : DPBLGDGDEFF<NHDGGCIBEGO>, KNEPGJJBCKC<NHDGGCIBEGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KNEPGJJBCKC<NIAOHDCALJL> DDMAABOEBEG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	public BKNLHOOJCJI(KNEPGJJBCKC<NIAOHDCALJL> DDMAABOEBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x70B42A0", Offset = "0x70B28A0", VA = "0x1870B42A0", Slot = "4")]
	public IEnumerable<(NHDGGCIBEGO, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x72127D0", Offset = "0x7210DD0", VA = "0x1872127D0", Slot = "6")]
	public NHDGGCIBEGO GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(NHDGGCIBEGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7212A10", Offset = "0x7211010", VA = "0x187212A10", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DDDGHLBHAME : DPBLGDGDEFF<BJCALNENODB>, KNEPGJJBCKC<BJCALNENODB>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72137D0", Offset = "0x7211DD0", VA = "0x1872137D0", Slot = "4")]
	public IEnumerable<(BJCALNENODB, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public BJCALNENODB GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(BJCALNENODB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DDDGHLBHAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IDDOIODFPJJ : DPBLGDGDEFF<CIFJPJIKLJC>, KNEPGJJBCKC<CIFJPJIKLJC>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x721DA40", Offset = "0x721C040", VA = "0x18721DA40", Slot = "4")]
	public IEnumerable<(CIFJPJIKLJC, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public CIFJPJIKLJC GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(CIFJPJIKLJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public IDDOIODFPJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DHKCDLLPGFD : DPBLGDGDEFF<GHJNEJAMJEH>, KNEPGJJBCKC<GHJNEJAMJEH>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x721B3E0", Offset = "0x72199E0", VA = "0x18721B3E0", Slot = "4")]
	public IEnumerable<(GHJNEJAMJEH, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public GHJNEJAMJEH GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(GHJNEJAMJEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DHKCDLLPGFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NBGLDAJNNBG : DPBLGDGDEFF<FPELILCNBPE>, KNEPGJJBCKC<FPELILCNBPE>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7224860", Offset = "0x7222E60", VA = "0x187224860", Slot = "4")]
	public IEnumerable<(FPELILCNBPE, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public FPELILCNBPE GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(FPELILCNBPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NBGLDAJNNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DPBLGDGDEFF<TModern> : KNEPGJJBCKC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> GPKDIPFOHDE();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KIHEBLOLHMO(string KCDEJHMGGGC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EIICABLKJCA : DPBLGDGDEFF<NIAOHDCALJL>, KNEPGJJBCKC<NIAOHDCALJL>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7168410", Offset = "0x7166A10", VA = "0x187168410", Slot = "4")]
	public IEnumerable<(NIAOHDCALJL, string)> GPKDIPFOHDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xB67D50", Offset = "0xB66350", VA = "0x180B67D50", Slot = "5")]
	public string KIHEBLOLHMO(string KCDEJHMGGGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7213710", Offset = "0x7211D10", VA = "0x187213710", Slot = "6")]
	public NIAOHDCALJL GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return default(NIAOHDCALJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public EIICABLKJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MBCPOGIPELE<TModern> : JHBIJAIELGJ<TModern>, KNEPGJJBCKC<TModern> where TModern : IEquatable<TModern>, DPDJOGKPPAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> DDDMDNGGHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> HCNGPNGFMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DPBLGDGDEFF<TModern> AEEGPGFOKGF;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x44C8540", Offset = "0x44C6B40", VA = "0x1844C8540")]
	public MBCPOGIPELE(DPBLGDGDEFF<TModern> AEEGPGFOKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44C5CF0", Offset = "0x44C42F0", VA = "0x1844C5CF0", Slot = "5")]
	public TModern GOGMIPMHNCN(string KCDEJHMGGGC)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44C65F0", Offset = "0x44C4BF0", VA = "0x1844C65F0", Slot = "4")]
	public string LNPBOIDFKGE(TModern OBCLHGMPGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MELCKEDOGCN : DFCDEDIBLNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MBCPOGIPELE<CDMPNOCHBKH> OGIOJGCOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MBCPOGIPELE<BJCALNENODB> KFJAAHEBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MBCPOGIPELE<FPELILCNBPE> GJPCNBHHLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MBCPOGIPELE<NIAOHDCALJL> DDMAABOEBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MBCPOGIPELE<NHDGGCIBEGO> JFKJIGNGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MBCPOGIPELE<GCJCGHEDGPM> HKHFENGLKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MBCPOGIPELE<GHJNEJAMJEH> PCGHOJNGKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MBCPOGIPELE<OGGKFBHPMHE> ADGNEFAGDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MBCPOGIPELE<CIFJPJIKLJC> EGJJCJIEGIG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JHBIJAIELGJ<CDMPNOCHBKH> OKIPKFBHKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JHBIJAIELGJ<BJCALNENODB> FDJEGCNKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JHBIJAIELGJ<FPELILCNBPE> JBKPGGCBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JHBIJAIELGJ<NHDGGCIBEGO> NCFLMAFOIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JHBIJAIELGJ<GCJCGHEDGPM> GHAEHKGHJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JHBIJAIELGJ<GHJNEJAMJEH> CNKDCJGOOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JHBIJAIELGJ<OGGKFBHPMHE> GDEMOAOPLOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x861D50", Offset = "0x860350", VA = "0x180861D50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JHBIJAIELGJ<CIFJPJIKLJC> DMPPHJGJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x721F6A0", Offset = "0x721DCA0", VA = "0x18721F6A0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.GameOnly)]
	[UsedImplicitly]
	private static void MLANPAMCCDJ(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x721F710", Offset = "0x721DD10", VA = "0x18721F710")]
	[Preserve]
	public MELCKEDOGCN()
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
