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
		[Cpp2IlInjected.Address(RVA = "0x8F9AEE0", Offset = "0x8F994E0", VA = "0x188F9AEE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GIKLIOKCBGF : LNMALNIAPPD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex GCABFCGPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly HPEMFPFEPIB NOMJKLKJDBD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8F92BF0", Offset = "0x8F911F0", VA = "0x188F92BF0")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	[UsedImplicitly]
	internal static void FBMOEFONPBI(NMNJFHODGJA MOPOKCOIIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8F92C60", Offset = "0x8F91260", VA = "0x188F92C60")]
	[UsedImplicitly]
	internal static void GNLFLAKFNDA(NMNJFHODGJA MOPOKCOIIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GIKLIOKCBGF([EDHLHMEHMKO(null)] HPEMFPFEPIB NOMJKLKJDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8F928B0", Offset = "0x8F90EB0", VA = "0x188F928B0", Slot = "4")]
	public string ANHNANMIGBP(GIJENBMJDLP ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8F92CC0", Offset = "0x8F912C0", VA = "0x188F92CC0", Slot = "5")]
	public GIJENBMJDLP LPNJIHLFELG(string ECBHOIMIBKD)
	{
		return default(GIJENBMJDLP);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CCOONKOMFAG
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
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public EPGMAHLDJMC LPNJIHLFELG()
		{
			return default(EPGMAHLDJMC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A350", Offset = "0x8F98950", VA = "0x188F9A350", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A410", Offset = "0x8F98A10", VA = "0x188F9A410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CCOONKOMFAG
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
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public CFGBLEDCLBI LPNJIHLFELG()
		{
			return default(CFGBLEDCLBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A480", Offset = "0x8F98A80", VA = "0x188F9A480", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A520", Offset = "0x8F98B20", VA = "0x188F9A520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CCOONKOMFAG
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
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public HBALGBNKPFA LPNJIHLFELG()
		{
			return default(HBALGBNKPFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedColorId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedColorId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A590", Offset = "0x8F98B90", VA = "0x188F9A590", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A630", Offset = "0x8F98C30", VA = "0x188F9A630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CCOONKOMFAG, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
		public DHFMHNGLGMC LPNJIHLFELG()
		{
			return default(DHFMHNGLGMC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E26030", Offset = "0x8E24630", VA = "0x188E26030", Slot = "4")]
		public bool Equals(SerializedCombinationId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A6A0", Offset = "0x8F98CA0", VA = "0x188F9A6A0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedCombinationId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A760", Offset = "0x8F98D60", VA = "0x188F9A760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A750", Offset = "0x8F98D50", VA = "0x188F9A750", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A900", Offset = "0x8F98F00", VA = "0x188F9A900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x152BDF0", Offset = "0x152A3F0", VA = "0x18152BDF0")]
		public SerializedCustomAvatarItemId(Guid JJCLDINKIFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public static SerializedCustomAvatarItemId OMCDDMBKFPF(Guid JJCLDINKIFD)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A7D0", Offset = "0x8F98DD0", VA = "0x188F9A7D0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0")]
		public static bool MGLHCKHANFO(SerializedCustomAvatarItemId NEOIFOEJGFD, SerializedCustomAvatarItemId KNACFLNMNOM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A870", Offset = "0x8F98E70", VA = "0x188F9A870")]
		public static bool HKOGMNAKMAE(SerializedCustomAvatarItemId NEOIFOEJGFD, SerializedCustomAvatarItemId KNACFLNMNOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A890", Offset = "0x8F98E90", VA = "0x188F9A890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AA00", Offset = "0x8F99000", VA = "0x188F9AA00")]
		public static SerializedEquipmentSkinId OBBIHCKNGCB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public LDACNMBAKAL LPNJIHLFELG()
		{
			return default(LDACNMBAKAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A960", Offset = "0x8F98F60", VA = "0x188F9A960", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AA30", Offset = "0x8F99030", VA = "0x188F9AA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public KKNCLIFJEEB LPNJIHLFELG()
		{
			return default(KKNCLIFJEEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AAA0", Offset = "0x8F990A0", VA = "0x188F9AAA0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AB40", Offset = "0x8F99140", VA = "0x188F9AB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public NACGCPOMKKF LPNJIHLFELG()
		{
			return default(NACGCPOMKKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F9ABB0", Offset = "0x8F991B0", VA = "0x188F9ABB0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AC50", Offset = "0x8F99250", VA = "0x188F9AC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0")]
		public GDAILFHEPJD LPNJIHLFELG()
		{
			return default(GDAILFHEPJD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0", Slot = "4")]
		public bool Equals(SerializedHairPatternId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9ACC0", Offset = "0x8F992C0", VA = "0x188F9ACC0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A3F0", Offset = "0x8F989F0", VA = "0x188F9A3F0")]
		public static bool MGLHCKHANFO(SerializedHairPatternId NEOIFOEJGFD, SerializedHairPatternId KNACFLNMNOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AD60", Offset = "0x8F99360", VA = "0x188F9AD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CCOONKOMFAG
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

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x12CB4E0", Offset = "0x12C9AE0", VA = "0x1812CB4E0", Slot = "6")]
		public Guid JGIEIICPJCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E26030", Offset = "0x8E24630", VA = "0x188E26030", Slot = "4")]
		public bool Equals(SerializedMaterialId AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F9ADD0", Offset = "0x8F993D0", VA = "0x188F9ADD0", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8369070", Offset = "0x8367670", VA = "0x188369070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8368EE0", Offset = "0x83674E0", VA = "0x188368EE0", Slot = "5")]
		public int CompareTo(SerializedMaterialId AAGCKLPFJME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AE70", Offset = "0x8F99470", VA = "0x188F9AE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BFCLACKKGIE : HPEMFPFEPIB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BFCLACKKGIE EHBCEBDHHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F87DA0", Offset = "0x8F863A0", VA = "0x188F87DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FMNKFJKCOEF<EPGMAHLDJMC> KCJPFACCOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8F87CE0", Offset = "0x8F862E0", VA = "0x188F87CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FMNKFJKCOEF<LDACNMBAKAL> PKJIKBOJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8F87C80", Offset = "0x8F86280", VA = "0x188F87C80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FMNKFJKCOEF<GDAILFHEPJD> KODLABNDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F87E00", Offset = "0x8F86400", VA = "0x188F87E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FMNKFJKCOEF<DHFMHNGLGMC> KICMAEDPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F87D40", Offset = "0x8F86340", VA = "0x188F87D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FMNKFJKCOEF<HBALGBNKPFA> EIFJILBDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F87E60", Offset = "0x8F86460", VA = "0x188F87E60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FMNKFJKCOEF<NACGCPOMKKF> IGBIDCNMIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F87EC0", Offset = "0x8F864C0", VA = "0x188F87EC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FMNKFJKCOEF<CFGBLEDCLBI> EGFEMDMEIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F87C20", Offset = "0x8F86220", VA = "0x188F87C20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FMNKFJKCOEF<KKNCLIFJEEB> LGMNDLMFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F87F20", Offset = "0x8F86520", VA = "0x188F87F20", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BGGBAAGLJAG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8F87F80", Offset = "0x8F86580", VA = "0x188F87F80")]
	public static Guid INJGKGKBGNI(string NHBCGIPCGKO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8F88030", Offset = "0x8F86630", VA = "0x188F88030")]
	public static bool NIOMBNEONBC(string NHBCGIPCGKO, [Out] Guid JJCLDINKIFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OCOPOJLFFEN : OGFAKPLLFHN<EPGMAHLDJMC>, AJNLLAOOPMG<EPGMAHLDJMC>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8F951B0", Offset = "0x8F937B0", VA = "0x188F951B0", Slot = "4")]
	public IEnumerable<(EPGMAHLDJMC, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8F95190", Offset = "0x8F93790", VA = "0x188F95190", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public EPGMAHLDJMC DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(EPGMAHLDJMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public OCOPOJLFFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GBPOCIDCAJO : OGFAKPLLFHN<CFGBLEDCLBI>, AJNLLAOOPMG<CFGBLEDCLBI>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8F92510", Offset = "0x8F90B10", VA = "0x188F92510", Slot = "4")]
	public IEnumerable<(CFGBLEDCLBI, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public CFGBLEDCLBI DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(CFGBLEDCLBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public GBPOCIDCAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CBCNMDMBKOE : OGFAKPLLFHN<HBALGBNKPFA>, AJNLLAOOPMG<HBALGBNKPFA>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8F881C0", Offset = "0x8F867C0", VA = "0x188F881C0", Slot = "4")]
	public IEnumerable<(HBALGBNKPFA, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public HBALGBNKPFA DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(HBALGBNKPFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CBCNMDMBKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IOLKMJKALNP : OGFAKPLLFHN<DHFMHNGLGMC>, AJNLLAOOPMG<DHFMHNGLGMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly AJNLLAOOPMG<NCLFEOAAANB> DKAMJLHMLCN;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public IOLKMJKALNP(AJNLLAOOPMG<NCLFEOAAANB> DKAMJLHMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8E27860", Offset = "0x8E25E60", VA = "0x188E27860", Slot = "4")]
	public IEnumerable<(DHFMHNGLGMC, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8F94F10", Offset = "0x8F93510", VA = "0x188F94F10", Slot = "6")]
	public DHFMHNGLGMC DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(DHFMHNGLGMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8F95150", Offset = "0x8F93750", VA = "0x188F95150", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CMEODDKCAHP : OGFAKPLLFHN<LDACNMBAKAL>, AJNLLAOOPMG<LDACNMBAKAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8F8A280", Offset = "0x8F88880", VA = "0x188F8A280", Slot = "4")]
	public IEnumerable<(LDACNMBAKAL, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public LDACNMBAKAL DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(LDACNMBAKAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CMEODDKCAHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HLFBDGCOIGB : OGFAKPLLFHN<KKNCLIFJEEB>, AJNLLAOOPMG<KKNCLIFJEEB>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8F93230", Offset = "0x8F91830", VA = "0x188F93230", Slot = "4")]
	public IEnumerable<(KKNCLIFJEEB, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public KKNCLIFJEEB DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(KKNCLIFJEEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public HLFBDGCOIGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IJGHLBCHHGB : OGFAKPLLFHN<NACGCPOMKKF>, AJNLLAOOPMG<NACGCPOMKKF>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8F94AF0", Offset = "0x8F930F0", VA = "0x188F94AF0", Slot = "4")]
	public IEnumerable<(NACGCPOMKKF, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public NACGCPOMKKF DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(NACGCPOMKKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IJGHLBCHHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FDEIDCLBABH : OGFAKPLLFHN<GDAILFHEPJD>, AJNLLAOOPMG<GDAILFHEPJD>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8F91E90", Offset = "0x8F90490", VA = "0x188F91E90", Slot = "4")]
	public IEnumerable<(GDAILFHEPJD, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public GDAILFHEPJD DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(GDAILFHEPJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public FDEIDCLBABH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OGFAKPLLFHN<TModern> : AJNLLAOOPMG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> NIGLBLNBIGG();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IKLOKIKHHBG(string CDOKMBOBFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CHCOPLAMEHA : OGFAKPLLFHN<NCLFEOAAANB>, AJNLLAOOPMG<NCLFEOAAANB>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8EDC980", Offset = "0x8EDAF80", VA = "0x188EDC980", Slot = "4")]
	public IEnumerable<(NCLFEOAAANB, string)> NIGLBLNBIGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "5")]
	public string IKLOKIKHHBG(string CDOKMBOBFFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8F88100", Offset = "0x8F86700", VA = "0x188F88100", Slot = "6")]
	public NCLFEOAAANB DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return default(NCLFEOAAANB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public CHCOPLAMEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NOLMNFHEJHD<TModern> : FMNKFJKCOEF<TModern>, AJNLLAOOPMG<TModern> where TModern : IEquatable<TModern>, CCOONKOMFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> DOHEIEECLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> FOJNNAMFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OGFAKPLLFHN<TModern> LDPIKBNDNPC;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A9A810", Offset = "0x5A98E10", VA = "0x185A9A810")]
	public NOLMNFHEJHD(OGFAKPLLFHN<TModern> LDPIKBNDNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5A98AE0", Offset = "0x5A970E0", VA = "0x185A98AE0", Slot = "5")]
	public TModern DIOLLNNDLPB(string CDOKMBOBFFJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5A99B00", Offset = "0x5A98100", VA = "0x185A99B00", Slot = "4")]
	public string OEGCKMMLIFM(TModern AELOGILBIOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PIMOKFMKFHM : HPEMFPFEPIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NOLMNFHEJHD<EPGMAHLDJMC> EOLNEJJABIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NOLMNFHEJHD<LDACNMBAKAL> IFLFAFINENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NOLMNFHEJHD<GDAILFHEPJD> LDLCBDKCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NOLMNFHEJHD<NCLFEOAAANB> DKAMJLHMLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NOLMNFHEJHD<DHFMHNGLGMC> ONJKILACLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NOLMNFHEJHD<HBALGBNKPFA> MPFPJAOFJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NOLMNFHEJHD<NACGCPOMKKF> BBFMKFNFLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NOLMNFHEJHD<CFGBLEDCLBI> PEENFAMNELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NOLMNFHEJHD<KKNCLIFJEEB> CHFHONPCMIE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FMNKFJKCOEF<EPGMAHLDJMC> KCJPFACCOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FMNKFJKCOEF<LDACNMBAKAL> PKJIKBOJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FMNKFJKCOEF<GDAILFHEPJD> KODLABNDNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FMNKFJKCOEF<DHFMHNGLGMC> KICMAEDPJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FMNKFJKCOEF<HBALGBNKPFA> EIFJILBDCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FMNKFJKCOEF<NACGCPOMKKF> IGBIDCNMIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FMNKFJKCOEF<CFGBLEDCLBI> EGFEMDMEIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FMNKFJKCOEF<KKNCLIFJEEB> LGMNDLMFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA5710", Offset = "0xAA3D10", VA = "0x180AA5710", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8F99E00", Offset = "0x8F98400", VA = "0x188F99E00")]
	[EGNICHGEFDG.KHJDAJHJKCM.GHFDKJOPLIL]
	[UsedImplicitly]
	internal static void PEPKAEJBCFB(NMNJFHODGJA MOPOKCOIIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8F99E70", Offset = "0x8F98470", VA = "0x188F99E70")]
	[RecRoom.NoEngine.Common.Preserve]
	public PIMOKFMKFHM()
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
