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
		[Cpp2IlInjected.Address(RVA = "0x7E1DDB0", Offset = "0x7E1C9B0", VA = "0x187E1DDB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LPLOGFBEPMM : GLPFGOPFJEP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex PBOEIDHOKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MIIIOEHHIKG EEKACHJGOIK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A680", Offset = "0x7E19280", VA = "0x187E1A680")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	[UsedImplicitly]
	internal static void HMDEJEGKIBO(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A2E0", Offset = "0x7E18EE0", VA = "0x187E1A2E0")]
	[UsedImplicitly]
	internal static void BAJMADILIJH(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	[RecRoom.NoEngine.Common.Preserve]
	public LPLOGFBEPMM([GJMNBPKNJPO(null)] MIIIOEHHIKG EEKACHJGOIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A340", Offset = "0x7E18F40", VA = "0x187E1A340", Slot = "4")]
	public string DHDDBDHCOJI(MKBGJCIDLNA CPPOMEHPJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E1A6F0", Offset = "0x7E192F0", VA = "0x187E1A6F0", Slot = "5")]
	public MKBGJCIDLNA KOHMJABOPGF(string CPPOMEHPJCH)
	{
		return default(MKBGJCIDLNA);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public JEOEJGIGBNL KOHMJABOPGF()
		{
			return default(JEOEJGIGBNL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedAvatarItemId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D270", Offset = "0x7E1BE70", VA = "0x187E1D270", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D330", Offset = "0x7E1BF30", VA = "0x187E1D330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public KEIHNLGFFOB KOHMJABOPGF()
		{
			return default(KEIHNLGFFOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedBodyShapeId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D3A0", Offset = "0x7E1BFA0", VA = "0x187E1D3A0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D440", Offset = "0x7E1C040", VA = "0x187E1D440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public HNAMJNCOOKK KOHMJABOPGF()
		{
			return default(HNAMJNCOOKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedColorId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedColorId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D4B0", Offset = "0x7E1C0B0", VA = "0x187E1D4B0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D550", Offset = "0x7E1C150", VA = "0x187E1D550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, AECEOFBPHCP, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAD8DC0", Offset = "0xAD79C0", VA = "0x180AD8DC0")]
		public NDEJIOADGKC KOHMJABOPGF()
		{
			return default(NDEJIOADGKC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9B70", Offset = "0x7CA8770", VA = "0x187CA9B70", Slot = "4")]
		public bool Equals(SerializedCombinationId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D5C0", Offset = "0x7E1C1C0", VA = "0x187E1D5C0", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedCombinationId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D680", Offset = "0x7E1C280", VA = "0x187E1D680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D670", Offset = "0x7E1C270", VA = "0x187E1D670", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103ACA0", Offset = "0x10398A0", VA = "0x18103ACA0")]
		public SerializedCustomAvatarItemId(Guid IEIMOIIMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public static SerializedCustomAvatarItemId JCFJLBKIPNG(Guid IEIMOIIMGDN)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D710", Offset = "0x7E1C310", VA = "0x187E1D710", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310")]
		public static bool LBLECGDECIN(SerializedCustomAvatarItemId NFOAKNOEKCL, SerializedCustomAvatarItemId AFFPJGJMKFP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D6F0", Offset = "0x7E1C2F0", VA = "0x187E1D6F0")]
		public static bool AIDLCBIJBIF(SerializedCustomAvatarItemId NFOAKNOEKCL, SerializedCustomAvatarItemId AFFPJGJMKFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D7B0", Offset = "0x7E1C3B0", VA = "0x187E1D7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x7E1D8C0", Offset = "0x7E1C4C0", VA = "0x187E1D8C0")]
		public static SerializedEquipmentSkinId KBHGMJDGOFD()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public IJEIDNENKJI KOHMJABOPGF()
		{
			return default(IJEIDNENKJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D820", Offset = "0x7E1C420", VA = "0x187E1D820", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D8F0", Offset = "0x7E1C4F0", VA = "0x187E1D8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public NLHBBDJJAEA KOHMJABOPGF()
		{
			return default(NLHBBDJJAEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D960", Offset = "0x7E1C560", VA = "0x187E1D960", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DA00", Offset = "0x7E1C600", VA = "0x187E1DA00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public JAPKPLOPGJP KOHMJABOPGF()
		{
			return default(JAPKPLOPGJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedFaceShapeId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DA70", Offset = "0x7E1C670", VA = "0x187E1DA70", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DB10", Offset = "0x7E1C710", VA = "0x187E1DB10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90")]
		public NIBJMMJJHKO KOHMJABOPGF()
		{
			return default(NIBJMMJJHKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310", Slot = "4")]
		public bool Equals(SerializedHairPatternId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DB80", Offset = "0x7E1C780", VA = "0x187E1DB80", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D310", Offset = "0x7E1BF10", VA = "0x187E1D310")]
		public static bool LBLECGDECIN(SerializedHairPatternId NFOAKNOEKCL, SerializedHairPatternId AFFPJGJMKFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DC20", Offset = "0x7E1C820", VA = "0x187E1DC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, AECEOFBPHCP
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
		[Cpp2IlInjected.Address(RVA = "0x103AC90", Offset = "0x1039890", VA = "0x18103AC90", Slot = "6")]
		public Guid HGOPAOPKPFM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9B70", Offset = "0x7CA8770", VA = "0x187CA9B70", Slot = "4")]
		public bool Equals(SerializedMaterialId PELBNOCGOOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DC90", Offset = "0x7E1C890", VA = "0x187E1DC90", Slot = "0")]
		public override bool Equals(object CFMCKCBBBKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7343750", Offset = "0x7342350", VA = "0x187343750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x73435C0", Offset = "0x73421C0", VA = "0x1873435C0", Slot = "5")]
		public int CompareTo(SerializedMaterialId PELBNOCGOOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DD40", Offset = "0x7E1C940", VA = "0x187E1DD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AEKNALMFCCH : MIIIOEHHIKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AEKNALMFCCH FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B0C0", Offset = "0x7E09CC0", VA = "0x187E0B0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NLJIGDMMGCM<JEOEJGIGBNL> ICDLFEFABOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B000", Offset = "0x7E09C00", VA = "0x187E0B000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NLJIGDMMGCM<IJEIDNENKJI> ENAMAHEIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AF40", Offset = "0x7E09B40", VA = "0x187E0AF40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NLJIGDMMGCM<NIBJMMJJHKO> CJMJHOBAALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E0ADC0", Offset = "0x7E099C0", VA = "0x187E0ADC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NLJIGDMMGCM<NDEJIOADGKC> KIJABCGINEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AE20", Offset = "0x7E09A20", VA = "0x187E0AE20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NLJIGDMMGCM<HNAMJNCOOKK> GDJHMOIHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B060", Offset = "0x7E09C60", VA = "0x187E0B060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NLJIGDMMGCM<JAPKPLOPGJP> OPCLHKBLJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AEE0", Offset = "0x7E09AE0", VA = "0x187E0AEE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NLJIGDMMGCM<KEIHNLGFFOB> BPAMCNEBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AFA0", Offset = "0x7E09BA0", VA = "0x187E0AFA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NLJIGDMMGCM<NLHBBDJJAEA> GNGPCHCPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E0AE80", Offset = "0x7E09A80", VA = "0x187E0AE80", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NAABABKMPPP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B280", Offset = "0x7E19E80", VA = "0x187E1B280")]
	public static Guid LGPIHLDHAJO(string DPMCFOPNFMH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B1B0", Offset = "0x7E19DB0", VA = "0x187E1B1B0")]
	public static bool GCPGAKHDCIM(string DPMCFOPNFMH, [Out] Guid IEIMOIIMGDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GGIFKKEBHNP : MGPPLJIHBFK<JEOEJGIGBNL>, OLGNPANABAC<JEOEJGIGBNL>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E13190", Offset = "0x7E11D90", VA = "0x187E13190", Slot = "4")]
	public IEnumerable<(JEOEJGIGBNL, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E17DE0", Offset = "0x7E169E0", VA = "0x187E17DE0", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public JEOEJGIGBNL HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(JEOEJGIGBNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public GGIFKKEBHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GFDDNFBGCPP : MGPPLJIHBFK<KEIHNLGFFOB>, OLGNPANABAC<KEIHNLGFFOB>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E12DF0", Offset = "0x7E119F0", VA = "0x187E12DF0", Slot = "4")]
	public IEnumerable<(KEIHNLGFFOB, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public KEIHNLGFFOB HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(KEIHNLGFFOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public GFDDNFBGCPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LNBGBOJHJLH : MGPPLJIHBFK<HNAMJNCOOKK>, OLGNPANABAC<HNAMJNCOOKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E18220", Offset = "0x7E16E20", VA = "0x187E18220", Slot = "4")]
	public IEnumerable<(HNAMJNCOOKK, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public HNAMJNCOOKK HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(HNAMJNCOOKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public LNBGBOJHJLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ADJCJCPMOFE : MGPPLJIHBFK<NDEJIOADGKC>, OLGNPANABAC<NDEJIOADGKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly OLGNPANABAC<BFGMHNFOMMB> LAAECAJOIPI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public ADJCJCPMOFE(OLGNPANABAC<BFGMHNFOMMB> LAAECAJOIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA780", Offset = "0x7CA9380", VA = "0x187CAA780", Slot = "4")]
	public IEnumerable<(NDEJIOADGKC, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0AB40", Offset = "0x7E09740", VA = "0x187E0AB40", Slot = "6")]
	public NDEJIOADGKC HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(NDEJIOADGKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0AD80", Offset = "0x7E09980", VA = "0x187E0AD80", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ANLDEKKNMDJ : MGPPLJIHBFK<IJEIDNENKJI>, OLGNPANABAC<IJEIDNENKJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7E0B120", Offset = "0x7E09D20", VA = "0x187E0B120", Slot = "4")]
	public IEnumerable<(IJEIDNENKJI, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public IJEIDNENKJI HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(IJEIDNENKJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public ANLDEKKNMDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PJHHDFGLOBH : MGPPLJIHBFK<NLHBBDJJAEA>, OLGNPANABAC<NLHBBDJJAEA>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B9B0", Offset = "0x7E1A5B0", VA = "0x187E1B9B0", Slot = "4")]
	public IEnumerable<(NLHBBDJJAEA, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public NLHBBDJJAEA HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(NLHBBDJJAEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public PJHHDFGLOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JMLBDFBFJHH : MGPPLJIHBFK<JAPKPLOPGJP>, OLGNPANABAC<JAPKPLOPGJP>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E17E00", Offset = "0x7E16A00", VA = "0x187E17E00", Slot = "4")]
	public IEnumerable<(JAPKPLOPGJP, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public JAPKPLOPGJP HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(JAPKPLOPGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JMLBDFBFJHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NBLLFDNCNCO : MGPPLJIHBFK<NIBJMMJJHKO>, OLGNPANABAC<NIBJMMJJHKO>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E1B330", Offset = "0x7E19F30", VA = "0x187E1B330", Slot = "4")]
	public IEnumerable<(NIBJMMJJHKO, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public NIBJMMJJHKO HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(NIBJMMJJHKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public NBLLFDNCNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MGPPLJIHBFK<TModern> : OLGNPANABAC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DEKLPDLNEIJ();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string INLKPAADLDC(string MLFLBCHOGFB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CGFCMEHCKFB : MGPPLJIHBFK<BFGMHNFOMMB>, OLGNPANABAC<BFGMHNFOMMB>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D5F8A0", Offset = "0x7D5E4A0", VA = "0x187D5F8A0", Slot = "4")]
	public IEnumerable<(BFGMHNFOMMB, string)> DEKLPDLNEIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "5")]
	public string INLKPAADLDC(string MLFLBCHOGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D30", Offset = "0x7E11930", VA = "0x187E12D30", Slot = "6")]
	public BFGMHNFOMMB HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return default(BFGMHNFOMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public CGFCMEHCKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DALIHJONBEK<TModern> : NLJIGDMMGCM<TModern>, OLGNPANABAC<TModern> where TModern : IEquatable<TModern>, AECEOFBPHCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> GCPEOLCNNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> CLCNAFAJPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MGPPLJIHBFK<TModern> KOHMLKMDGNJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62EB730", Offset = "0x62EA330", VA = "0x1862EB730")]
	public DALIHJONBEK(MGPPLJIHBFK<TModern> KOHMLKMDGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62E8F40", Offset = "0x62E7B40", VA = "0x1862E8F40", Slot = "5")]
	public TModern HNKFBHJABPI(string MLFLBCHOGFB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62E9ED0", Offset = "0x62E8AD0", VA = "0x1862E9ED0", Slot = "4")]
	public string KKEAAAOCLCK(TModern HDGMEPCOFMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MNBJGENPFCI : MIIIOEHHIKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private DALIHJONBEK<JEOEJGIGBNL> LLANABLPFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DALIHJONBEK<IJEIDNENKJI> ELIOLJGCECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DALIHJONBEK<NIBJMMJJHKO> IKEKHPDCMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private DALIHJONBEK<BFGMHNFOMMB> LAAECAJOIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private DALIHJONBEK<NDEJIOADGKC> HCEJIJHDKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DALIHJONBEK<HNAMJNCOOKK> CBFAILENCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DALIHJONBEK<JAPKPLOPGJP> AIOMMFPIKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private DALIHJONBEK<KEIHNLGFFOB> GGFNJKIOEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DALIHJONBEK<NLHBBDJJAEA> IFFPLKJHCBP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NLJIGDMMGCM<JEOEJGIGBNL> ICDLFEFABOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NLJIGDMMGCM<IJEIDNENKJI> ENAMAHEIAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NLJIGDMMGCM<NIBJMMJJHKO> CJMJHOBAALO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NLJIGDMMGCM<NDEJIOADGKC> KIJABCGINEP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NLJIGDMMGCM<HNAMJNCOOKK> GDJHMOIHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NLJIGDMMGCM<JAPKPLOPGJP> OPCLHKBLJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NLJIGDMMGCM<KEIHNLGFFOB> BPAMCNEBFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NLJIGDMMGCM<NLHBBDJJAEA> GNGPCHCPPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x95F000", Offset = "0x95DC00", VA = "0x18095F000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E1AC60", Offset = "0x7E19860", VA = "0x187E1AC60")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	[UsedImplicitly]
	internal static void AEFNPIEJNPP(KPLLBHIBBNH DMGOKFDJBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E1ACD0", Offset = "0x7E198D0", VA = "0x187E1ACD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public MNBJGENPFCI()
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
