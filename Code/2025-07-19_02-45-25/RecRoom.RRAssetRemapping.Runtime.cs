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
		[Cpp2IlInjected.Address(RVA = "0x8BF5CF0", Offset = "0x8BF4CF0", VA = "0x188BF5CF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LIPPLOHGPDB : CLNKPHMDENM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HEOGBAHHKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CAOGJAKDFBC BJHBFIMLHOB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2540", Offset = "0x8BF1540", VA = "0x188BF2540")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	[UsedImplicitly]
	internal static void PHNOHKBOJEP(CBHAAKGBAOP NACGIDKDDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2010", Offset = "0x8BF1010", VA = "0x188BF2010")]
	[UsedImplicitly]
	internal static void HCMFPHNKBCP(CBHAAKGBAOP NACGIDKDDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LIPPLOHGPDB([KELEGLJPNHI(null)] CAOGJAKDFBC BJHBFIMLHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1CD0", Offset = "0x8BF0CD0", VA = "0x188BF1CD0", Slot = "4")]
	public string FBGBLPHHDGN(NPHONPGHNPF JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2070", Offset = "0x8BF1070", VA = "0x188BF2070", Slot = "5")]
	public NPHONPGHNPF LABNBGADOBH(string JMJJABEKOFI)
	{
		return default(NPHONPGHNPF);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public ENEJMMGDILI LABNBGADOBH()
		{
			return default(ENEJMMGDILI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5150", Offset = "0x8BF4150", VA = "0x188BF5150", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5210", Offset = "0x8BF4210", VA = "0x188BF5210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public KIGEPKPKPOM LABNBGADOBH()
		{
			return default(KIGEPKPKPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5280", Offset = "0x8BF4280", VA = "0x188BF5280", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5320", Offset = "0x8BF4320", VA = "0x188BF5320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public IJBOOMIFELF LABNBGADOBH()
		{
			return default(IJBOOMIFELF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedColorId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedColorId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5390", Offset = "0x8BF4390", VA = "0x188BF5390", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5430", Offset = "0x8BF4430", VA = "0x188BF5430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, HLNHJFLKOLN, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		public GLNFCDOGKEH LABNBGADOBH()
		{
			return default(GLNFCDOGKEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A81180", Offset = "0x8A80180", VA = "0x188A81180", Slot = "4")]
		public bool Equals(SerializedCombinationId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BF54A0", Offset = "0x8BF44A0", VA = "0x188BF54A0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedCombinationId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5560", Offset = "0x8BF4560", VA = "0x188BF5560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5550", Offset = "0x8BF4550", VA = "0x188BF5550", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, HLNHJFLKOLN
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
			[Cpp2IlInjected.Address(RVA = "0x8BF5700", Offset = "0x8BF4700", VA = "0x188BF5700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x14395A0", Offset = "0x14385A0", VA = "0x1814395A0")]
		public SerializedCustomAvatarItemId(Guid JFLBGDIIGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public static SerializedCustomAvatarItemId AIODOPNKONO(Guid JFLBGDIIGHK)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF55F0", Offset = "0x8BF45F0", VA = "0x188BF55F0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0")]
		public static bool PHGIAKEDBEK(SerializedCustomAvatarItemId AKPAAKDLPCB, SerializedCustomAvatarItemId AIKJCCNDBKF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF55D0", Offset = "0x8BF45D0", VA = "0x188BF55D0")]
		public static bool BDCEBPMLGHE(SerializedCustomAvatarItemId AKPAAKDLPCB, SerializedCustomAvatarItemId AIKJCCNDBKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5690", Offset = "0x8BF4690", VA = "0x188BF5690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5800", Offset = "0x8BF4800", VA = "0x188BF5800")]
		public static SerializedEquipmentSkinId PBCLAPMFMHI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public PDGOAELHCJG LABNBGADOBH()
		{
			return default(PDGOAELHCJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5760", Offset = "0x8BF4760", VA = "0x188BF5760", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5830", Offset = "0x8BF4830", VA = "0x188BF5830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public AHAMFIMFGBH LABNBGADOBH()
		{
			return default(AHAMFIMFGBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF58A0", Offset = "0x8BF48A0", VA = "0x188BF58A0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5940", Offset = "0x8BF4940", VA = "0x188BF5940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public LKCHCONINKK LABNBGADOBH()
		{
			return default(LKCHCONINKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BF59B0", Offset = "0x8BF49B0", VA = "0x188BF59B0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5A50", Offset = "0x8BF4A50", VA = "0x188BF5A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630")]
		public MKCPMMMEAMC LABNBGADOBH()
		{
			return default(MKCPMMMEAMC);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0", Slot = "4")]
		public bool Equals(SerializedHairPatternId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedHairPatternId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5AC0", Offset = "0x8BF4AC0", VA = "0x188BF5AC0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF51F0", Offset = "0x8BF41F0", VA = "0x188BF51F0")]
		public static bool PHGIAKEDBEK(SerializedHairPatternId AKPAAKDLPCB, SerializedHairPatternId AIKJCCNDBKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5B60", Offset = "0x8BF4B60", VA = "0x188BF5B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, HLNHJFLKOLN
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
		[Cpp2IlInjected.Address(RVA = "0x11FD630", Offset = "0x11FC630", VA = "0x1811FD630", Slot = "6")]
		public Guid DPMLIPCCHBC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8A81180", Offset = "0x8A80180", VA = "0x188A81180", Slot = "4")]
		public bool Equals(SerializedMaterialId EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5BD0", Offset = "0x8BF4BD0", VA = "0x188BF5BD0", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1E20", Offset = "0x7FE0E20", VA = "0x187FE1E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7FE1C90", Offset = "0x7FE0C90", VA = "0x187FE1C90", Slot = "5")]
		public int CompareTo(SerializedMaterialId EDJHHGMLKFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C80", Offset = "0x8BF4C80", VA = "0x188BF5C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JCCIPHMDHCP : CAOGJAKDFBC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JCCIPHMDHCP KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1A90", Offset = "0x8BF0A90", VA = "0x188BF1A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JOLMNCGABLL<ENEJMMGDILI> NCBMPIKKGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1B50", Offset = "0x8BF0B50", VA = "0x188BF1B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JOLMNCGABLL<PDGOAELHCJG> ECDFDJHLANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1A30", Offset = "0x8BF0A30", VA = "0x188BF1A30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JOLMNCGABLL<MKCPMMMEAMC> PALGDOHFGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1C70", Offset = "0x8BF0C70", VA = "0x188BF1C70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JOLMNCGABLL<GLNFCDOGKEH> CDHJHEDCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1970", Offset = "0x8BF0970", VA = "0x188BF1970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JOLMNCGABLL<IJBOOMIFELF> HJOOCEEKJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1C10", Offset = "0x8BF0C10", VA = "0x188BF1C10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JOLMNCGABLL<LKCHCONINKK> GLCNNLMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1AF0", Offset = "0x8BF0AF0", VA = "0x188BF1AF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JOLMNCGABLL<KIGEPKPKPOM> LMOBECBGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF19D0", Offset = "0x8BF09D0", VA = "0x188BF19D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JOLMNCGABLL<AHAMFIMFGBH> DKKKFBNKDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF1BB0", Offset = "0x8BF0BB0", VA = "0x188BF1BB0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GIHIGJOHGCA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8BEBFB0", Offset = "0x8BEAFB0", VA = "0x188BEBFB0")]
	public static Guid DGNGIHMBNJJ(string NKEEKMDOHMM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC060", Offset = "0x8BEB060", VA = "0x188BEC060")]
	public static bool KCNJALHADCN(string NKEEKMDOHMM, [Out] Guid JFLBGDIIGHK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IMAIILPFFEC : IPDKEDOGCGM<ENEJMMGDILI>, CNHDLIMPJGG<ENEJMMGDILI>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8BECD00", Offset = "0x8BEBD00", VA = "0x188BECD00", Slot = "4")]
	public IEnumerable<(ENEJMMGDILI, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BF1950", Offset = "0x8BF0950", VA = "0x188BF1950", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public ENEJMMGDILI HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(ENEJMMGDILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IMAIILPFFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MNEOOIBOBFI : IPDKEDOGCGM<KIGEPKPKPOM>, CNHDLIMPJGG<KIGEPKPKPOM>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2A70", Offset = "0x8BF1A70", VA = "0x188BF2A70", Slot = "4")]
	public IEnumerable<(KIGEPKPKPOM, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public KIGEPKPKPOM HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(KIGEPKPKPOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MNEOOIBOBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OADAIGECEJP : IPDKEDOGCGM<IJBOOMIFELF>, CNHDLIMPJGG<IJBOOMIFELF>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3090", Offset = "0x8BF2090", VA = "0x188BF3090", Slot = "4")]
	public IEnumerable<(IJBOOMIFELF, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public IJBOOMIFELF HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(IJBOOMIFELF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OADAIGECEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NOLNLBMFFKC : IPDKEDOGCGM<GLNFCDOGKEH>, CNHDLIMPJGG<GLNFCDOGKEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CNHDLIMPJGG<ANDDDIIPGEC> LLAJNJCLKKM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public NOLNLBMFFKC(CNHDLIMPJGG<ANDDDIIPGEC> LLAJNJCLKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8A82660", Offset = "0x8A81660", VA = "0x188A82660", Slot = "4")]
	public IEnumerable<(GLNFCDOGKEH, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2E10", Offset = "0x8BF1E10", VA = "0x188BF2E10", Slot = "6")]
	public GLNFCDOGKEH HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(GLNFCDOGKEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8BF3050", Offset = "0x8BF2050", VA = "0x188BF3050", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FHOBMAADEJN : IPDKEDOGCGM<PDGOAELHCJG>, CNHDLIMPJGG<PDGOAELHCJG>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8BE43A0", Offset = "0x8BE33A0", VA = "0x188BE43A0", Slot = "4")]
	public IEnumerable<(PDGOAELHCJG, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public PDGOAELHCJG HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(PDGOAELHCJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FHOBMAADEJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EHJIPBGOLHD : IPDKEDOGCGM<AHAMFIMFGBH>, CNHDLIMPJGG<AHAMFIMFGBH>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2AE0", Offset = "0x8BE1AE0", VA = "0x188BE2AE0", Slot = "4")]
	public IEnumerable<(AHAMFIMFGBH, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public AHAMFIMFGBH HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(AHAMFIMFGBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EHJIPBGOLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MDGNKCJHNBJ : IPDKEDOGCGM<LKCHCONINKK>, CNHDLIMPJGG<LKCHCONINKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8BF2650", Offset = "0x8BF1650", VA = "0x188BF2650", Slot = "4")]
	public IEnumerable<(LKCHCONINKK, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public LKCHCONINKK HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(LKCHCONINKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MDGNKCJHNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IFIIIMODPMD : IPDKEDOGCGM<MKCPMMMEAMC>, CNHDLIMPJGG<MKCPMMMEAMC>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC680", Offset = "0x8BEB680", VA = "0x188BEC680", Slot = "4")]
	public IEnumerable<(MKCPMMMEAMC, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public MKCPMMMEAMC HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(MKCPMMMEAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IFIIIMODPMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPDKEDOGCGM<TModern> : CNHDLIMPJGG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LEDBBAOOONP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string MDAMJBLEFHG(string PODNMEGMEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OKICMAALPPE : IPDKEDOGCGM<ANDDDIIPGEC>, CNHDLIMPJGG<ANDDDIIPGEC>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8B37780", Offset = "0x8B36780", VA = "0x188B37780", Slot = "4")]
	public IEnumerable<(ANDDDIIPGEC, string)> LEDBBAOOONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "5")]
	public string MDAMJBLEFHG(string PODNMEGMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8BE2A20", Offset = "0x8BE1A20", VA = "0x188BE2A20", Slot = "6")]
	public ANDDDIIPGEC HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return default(ANDDDIIPGEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OKICMAALPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OFEEFKEGHHC<TModern> : JOLMNCGABLL<TModern>, CNHDLIMPJGG<TModern> where TModern : IEquatable<TModern>, HLNHJFLKOLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> KHCEKBOBHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> JGEKBFHLHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IPDKEDOGCGM<TModern> IIHIMPBEAEL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x58A5F60", Offset = "0x58A4F60", VA = "0x1858A5F60")]
	public OFEEFKEGHHC(IPDKEDOGCGM<TModern> IIHIMPBEAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x58A3590", Offset = "0x58A2590", VA = "0x1858A3590", Slot = "5")]
	public TModern HIKCOPPDAPE(string PODNMEGMEOA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x58A4650", Offset = "0x58A3650", VA = "0x1858A4650", Slot = "4")]
	public string OHBFJJIPGKH(TModern CEFNPFDNLCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HMDJHEBKCFM : CAOGJAKDFBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private OFEEFKEGHHC<ENEJMMGDILI> EMHEPEIKOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OFEEFKEGHHC<PDGOAELHCJG> LEJNFKMJKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OFEEFKEGHHC<MKCPMMMEAMC> ECEMBFDHGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OFEEFKEGHHC<ANDDDIIPGEC> LLAJNJCLKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OFEEFKEGHHC<GLNFCDOGKEH> OHHGKAILFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OFEEFKEGHHC<IJBOOMIFELF> PGBMJMLCIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OFEEFKEGHHC<LKCHCONINKK> LDCMOAEIENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OFEEFKEGHHC<KIGEPKPKPOM> POKAMOMMGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private OFEEFKEGHHC<AHAMFIMFGBH> DJGLGDKNIGB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JOLMNCGABLL<ENEJMMGDILI> NCBMPIKKGJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JOLMNCGABLL<PDGOAELHCJG> ECDFDJHLANH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JOLMNCGABLL<MKCPMMMEAMC> PALGDOHFGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JOLMNCGABLL<GLNFCDOGKEH> CDHJHEDCHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JOLMNCGABLL<IJBOOMIFELF> HJOOCEEKJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JOLMNCGABLL<LKCHCONINKK> GLCNNLMMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JOLMNCGABLL<KIGEPKPKPOM> LMOBECBGMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JOLMNCGABLL<AHAMFIMFGBH> DKKKFBNKDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC130", Offset = "0x8BEB130", VA = "0x188BEC130")]
	[GOMLKAICHII.NIENCEEHOCF.GHHMJPKJCIP]
	[UsedImplicitly]
	internal static void CFEDANGKIBL(CBHAAKGBAOP NACGIDKDDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8BEC1A0", Offset = "0x8BEB1A0", VA = "0x188BEC1A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HMDJHEBKCFM()
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
