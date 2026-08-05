using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76A2A00", Offset = "0x76A1E00", VA = "0x1876A2A00", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GMEEONKBJOA : MNGLJMNKILG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NCGCKHLDKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BGKIAOHIJGJ DLFPAKKIEDP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x769CD30", Offset = "0x769C130", VA = "0x18769CD30")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	[UsedImplicitly]
	internal static void MBGCLLCDEMF(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x769C990", Offset = "0x769BD90", VA = "0x18769C990")]
	[UsedImplicitly]
	internal static void ICBEIEELFLN(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GMEEONKBJOA([ACGOIOBGIEE(null)] BGKIAOHIJGJ DLFPAKKIEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x769C9F0", Offset = "0x769BDF0", VA = "0x18769C9F0", Slot = "4")]
	public string KEEAKGCJIOB(KGFBNKJDMOF GJMNBMBONPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x769C4C0", Offset = "0x769B8C0", VA = "0x18769C4C0", Slot = "5")]
	public KGFBNKJDMOF GEBAPMNFHGF(string GJMNBMBONPJ)
	{
		return default(KGFBNKJDMOF);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public SerializedAvatarItemId(LIPMOPEKLJE IHELCOHOCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public LIPMOPEKLJE GEBAPMNFHGF()
		{
			return default(LIPMOPEKLJE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76A1ED0", Offset = "0x76A12D0", VA = "0x1876A1ED0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F90", Offset = "0x76A1390", VA = "0x1876A1F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public CMJGNKBOLIJ GEBAPMNFHGF()
		{
			return default(CMJGNKBOLIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76A2000", Offset = "0x76A1400", VA = "0x1876A2000", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76A20A0", Offset = "0x76A14A0", VA = "0x1876A20A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public DBKGLJPGPGA GEBAPMNFHGF()
		{
			return default(DBKGLJPGPGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedColorId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedColorId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76A2110", Offset = "0x76A1510", VA = "0x1876A2110", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76A21B0", Offset = "0x76A15B0", VA = "0x1876A21B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MFFOALEFBNJ, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380")]
		public MLLCBKIBLJC GEBAPMNFHGF()
		{
			return default(MLLCBKIBLJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76A2350", Offset = "0x76A1750", VA = "0x1876A2350")]
		public SerializedCombinationId(MLLCBKIBLJC PGEAOLIDHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x752F170", Offset = "0x752E570", VA = "0x18752F170", Slot = "4")]
		public bool Equals(SerializedCombinationId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76A2220", Offset = "0x76A1620", VA = "0x1876A2220", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedCombinationId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76A22E0", Offset = "0x76A16E0", VA = "0x1876A22E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76A22D0", Offset = "0x76A16D0", VA = "0x1876A22D0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public SerializedCustomAvatarItemId(Guid FDANKBMKMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76A2360", Offset = "0x76A1760", VA = "0x1876A2360", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70")]
		public static bool GBDINLJCMBD(SerializedCustomAvatarItemId EHOEECMJEAD, SerializedCustomAvatarItemId CPKKNGGFDGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76A2400", Offset = "0x76A1800", VA = "0x1876A2400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0x76A2470", Offset = "0x76A1870", VA = "0x1876A2470")]
		public static SerializedEquipmentSkinId BCPIOKGGCIB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public IAOIAGHLOEC GEBAPMNFHGF()
		{
			return default(IAOIAGHLOEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76A24A0", Offset = "0x76A18A0", VA = "0x1876A24A0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76A2540", Offset = "0x76A1940", VA = "0x1876A2540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public LGPPHCHPBNO GEBAPMNFHGF()
		{
			return default(LGPPHCHPBNO);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76A25B0", Offset = "0x76A19B0", VA = "0x1876A25B0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76A2650", Offset = "0x76A1A50", VA = "0x1876A2650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public EFGAFCFIFCC GEBAPMNFHGF()
		{
			return default(EFGAFCFIFCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76A26C0", Offset = "0x76A1AC0", VA = "0x1876A26C0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x76A2760", Offset = "0x76A1B60", VA = "0x1876A2760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0")]
		public PIAKFDEEEHG GEBAPMNFHGF()
		{
			return default(PIAKFDEEEHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70", Slot = "4")]
		public bool Equals(SerializedHairPatternId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76A27D0", Offset = "0x76A1BD0", VA = "0x1876A27D0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x76A1F70", Offset = "0x76A1370", VA = "0x1876A1F70")]
		public static bool GBDINLJCMBD(SerializedHairPatternId EHOEECMJEAD, SerializedHairPatternId CPKKNGGFDGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76A2870", Offset = "0x76A1C70", VA = "0x1876A2870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MFFOALEFBNJ
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
		[Cpp2IlInjected.Address(RVA = "0xCEAE00", Offset = "0xCEA200", VA = "0x180CEAE00")]
		public SerializedMaterialId(LHIKMCDGAOP IHELCOHOCAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCEADF0", Offset = "0xCEA1F0", VA = "0x180CEADF0", Slot = "6")]
		public Guid BMGPLCBODMK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x752F170", Offset = "0x752E570", VA = "0x18752F170", Slot = "4")]
		public bool Equals(SerializedMaterialId OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76A28E0", Offset = "0x76A1CE0", VA = "0x1876A28E0", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD87BA0", Offset = "0xD86FA0", VA = "0x180D87BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD87A10", Offset = "0xD86E10", VA = "0x180D87A10", Slot = "5")]
		public int CompareTo(SerializedMaterialId OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x76A2990", Offset = "0x76A1D90", VA = "0x1876A2990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GJDEHGEONKH : BGKIAOHIJGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GJDEHGEONKH FKMJLLKHOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x769C0C0", Offset = "0x769B4C0", VA = "0x18769C0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DBFDHKFKOJC<LIPMOPEKLJE> DIFNNGJIABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x769BF40", Offset = "0x769B340", VA = "0x18769BF40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DBFDHKFKOJC<IAOIAGHLOEC> DECDKBFOACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x769BEE0", Offset = "0x769B2E0", VA = "0x18769BEE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DBFDHKFKOJC<PIAKFDEEEHG> NHIEKJNPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x769C180", Offset = "0x769B580", VA = "0x18769C180", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DBFDHKFKOJC<MLLCBKIBLJC> CGINFFLDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x769C1E0", Offset = "0x769B5E0", VA = "0x18769C1E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DBFDHKFKOJC<DBKGLJPGPGA> JICCCPCCANO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x769C120", Offset = "0x769B520", VA = "0x18769C120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DBFDHKFKOJC<EFGAFCFIFCC> ILOLHOCEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x769BFA0", Offset = "0x769B3A0", VA = "0x18769BFA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DBFDHKFKOJC<CMJGNKBOLIJ> JHDKPBLJAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x769C000", Offset = "0x769B400", VA = "0x18769C000", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DBFDHKFKOJC<LGPPHCHPBNO> CLKCONBMBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x769C060", Offset = "0x769B460", VA = "0x18769C060", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CJBCLNEHNNG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7694150", Offset = "0x7693550", VA = "0x187694150")]
	public static Guid IGNLFLDHIGH(string HGBNNHFBFKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7694200", Offset = "0x7693600", VA = "0x187694200")]
	public static bool PJEHJMLHFBC(string HGBNNHFBFKA, [Out] Guid FDANKBMKMCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LFOHCHLIKLP : NAGJFOPJNFF<LIPMOPEKLJE>, GHDJEDJDAEG<LIPMOPEKLJE>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x769D280", Offset = "0x769C680", VA = "0x18769D280", Slot = "4")]
	public IEnumerable<(LIPMOPEKLJE, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x769D260", Offset = "0x769C660", VA = "0x18769D260", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public LIPMOPEKLJE JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(LIPMOPEKLJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LFOHCHLIKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CFOBLHDNHJH : NAGJFOPJNFF<CMJGNKBOLIJ>, GHDJEDJDAEG<CMJGNKBOLIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7693DB0", Offset = "0x76931B0", VA = "0x187693DB0", Slot = "4")]
	public IEnumerable<(CMJGNKBOLIJ, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public CMJGNKBOLIJ JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(CMJGNKBOLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CFOBLHDNHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CBGBPLJCGNA : NAGJFOPJNFF<DBKGLJPGPGA>, GHDJEDJDAEG<DBKGLJPGPGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7691CF0", Offset = "0x76910F0", VA = "0x187691CF0", Slot = "4")]
	public IEnumerable<(DBKGLJPGPGA, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public DBKGLJPGPGA JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(DBKGLJPGPGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CBGBPLJCGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GKKGJMJMFMD : NAGJFOPJNFF<MLLCBKIBLJC>, GHDJEDJDAEG<MLLCBKIBLJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly GHDJEDJDAEG<LHIKMCDGAOP> POEFAJJJOAD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public GKKGJMJMFMD(GHDJEDJDAEG<LHIKMCDGAOP> POEFAJJJOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x752F3E0", Offset = "0x752E7E0", VA = "0x18752F3E0", Slot = "4")]
	public IEnumerable<(MLLCBKIBLJC, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x769C240", Offset = "0x769B640", VA = "0x18769C240", Slot = "6")]
	public MLLCBKIBLJC JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(MLLCBKIBLJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x769C480", Offset = "0x769B880", VA = "0x18769C480", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DEMDIPJAHNP : NAGJFOPJNFF<IAOIAGHLOEC>, GHDJEDJDAEG<IAOIAGHLOEC>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76942D0", Offset = "0x76936D0", VA = "0x1876942D0", Slot = "4")]
	public IEnumerable<(IAOIAGHLOEC, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public IAOIAGHLOEC JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(IAOIAGHLOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public DEMDIPJAHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BPMFPJLEOOD : NAGJFOPJNFF<LGPPHCHPBNO>, GHDJEDJDAEG<LGPPHCHPBNO>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7690430", Offset = "0x768F830", VA = "0x187690430", Slot = "4")]
	public IEnumerable<(LGPPHCHPBNO, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public LGPPHCHPBNO JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(LGPPHCHPBNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public BPMFPJLEOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LDKMLPKCDPD : NAGJFOPJNFF<EFGAFCFIFCC>, GHDJEDJDAEG<EFGAFCFIFCC>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x769CE40", Offset = "0x769C240", VA = "0x18769CE40", Slot = "4")]
	public IEnumerable<(EFGAFCFIFCC, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public EFGAFCFIFCC JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(EFGAFCFIFCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LDKMLPKCDPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BOJJNKJBOPL : NAGJFOPJNFF<PIAKFDEEEHG>, GHDJEDJDAEG<PIAKFDEEEHG>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x768FDB0", Offset = "0x768F1B0", VA = "0x18768FDB0", Slot = "4")]
	public IEnumerable<(PIAKFDEEEHG, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public PIAKFDEEEHG JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(PIAKFDEEEHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public BOJJNKJBOPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NAGJFOPJNFF<TModern> : GHDJEDJDAEG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> MLPIPACENBB();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KJCPGLHGAKP(string JAAAKAOHBNF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BGACMFEPJJE : NAGJFOPJNFF<LHIKMCDGAOP>, GHDJEDJDAEG<LHIKMCDGAOP>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75E4500", Offset = "0x75E3900", VA = "0x1875E4500", Slot = "4")]
	public IEnumerable<(LHIKMCDGAOP, string)> MLPIPACENBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9BB210", Offset = "0x9BA610", VA = "0x1809BB210", Slot = "5")]
	public string KJCPGLHGAKP(string JAAAKAOHBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x768FCF0", Offset = "0x768F0F0", VA = "0x18768FCF0", Slot = "6")]
	public LHIKMCDGAOP JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return default(LHIKMCDGAOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public BGACMFEPJJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JEAPACPJPNC<TModern> : DBFDHKFKOJC<TModern>, GHDJEDJDAEG<TModern> where TModern : IEquatable<TModern>, MFFOALEFBNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> HKNICNDIFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> BANDCJIBOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NAGJFOPJNFF<TModern> KFKKABGIEIM;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x441FE90", Offset = "0x441F290", VA = "0x18441FE90")]
	public JEAPACPJPNC(NAGJFOPJNFF<TModern> KFKKABGIEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x441DD80", Offset = "0x441D180", VA = "0x18441DD80", Slot = "5")]
	public TModern JPMMNGNIBOF(string JAAAKAOHBNF)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x441C830", Offset = "0x441BC30", VA = "0x18441C830", Slot = "4")]
	public string EMFOEIBKEOH(TModern PIECPFKJHAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BFPLFIPGMBP : BGKIAOHIJGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JEAPACPJPNC<LIPMOPEKLJE> GHCDHMEKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JEAPACPJPNC<IAOIAGHLOEC> COALGLNOOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JEAPACPJPNC<PIAKFDEEEHG> IBEHMAGGLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JEAPACPJPNC<LHIKMCDGAOP> POEFAJJJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JEAPACPJPNC<MLLCBKIBLJC> FHBFHGBBADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JEAPACPJPNC<DBKGLJPGPGA> MKINCJNAAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JEAPACPJPNC<EFGAFCFIFCC> GAKEFEPCHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JEAPACPJPNC<CMJGNKBOLIJ> PCDGJOMKBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JEAPACPJPNC<LGPPHCHPBNO> FDPPPGBGLPK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DBFDHKFKOJC<LIPMOPEKLJE> DIFNNGJIABG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DBFDHKFKOJC<IAOIAGHLOEC> DECDKBFOACI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DBFDHKFKOJC<PIAKFDEEEHG> NHIEKJNPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DBFDHKFKOJC<MLLCBKIBLJC> CGINFFLDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DBFDHKFKOJC<DBKGLJPGPGA> JICCCPCCANO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DBFDHKFKOJC<EFGAFCFIFCC> ILOLHOCEIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DBFDHKFKOJC<CMJGNKBOLIJ> JHDKPBLJAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DBFDHKFKOJC<LGPPHCHPBNO> CLKCONBMBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x768F7A0", Offset = "0x768EBA0", VA = "0x18768F7A0")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	[UsedImplicitly]
	internal static void PGACNHLPKNC(ACFNHMKNHLL IFIBOOJGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x768F810", Offset = "0x768EC10", VA = "0x18768F810")]
	[RecRoom.NoEngine.Common.Preserve]
	public BFPLFIPGMBP()
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
