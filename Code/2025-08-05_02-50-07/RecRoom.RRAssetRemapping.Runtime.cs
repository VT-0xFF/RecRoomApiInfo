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
		[Cpp2IlInjected.Address(RVA = "0x8D3DBB0", Offset = "0x8D3CFB0", VA = "0x188D3DBB0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OONBHLGNOBP : IDLEGOLOPCF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex LELNHLOMPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PNAAMOOFGFL MHOGLOHJNKN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CF00", Offset = "0x8D3C300", VA = "0x188D3CF00")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	[UsedImplicitly]
	internal static void EMILKHFAJPJ(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C9D0", Offset = "0x8D3BDD0", VA = "0x188D3C9D0")]
	[UsedImplicitly]
	internal static void DFJHABBEOCH(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	[RecRoom.NoEngine.Common.Preserve]
	public OONBHLGNOBP([PKIHAALFADL(null)] PNAAMOOFGFL MHOGLOHJNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C690", Offset = "0x8D3BA90", VA = "0x188D3C690", Slot = "4")]
	public string COFPFOKABJF(PBBHALCOHCB MICKAKKPGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CA30", Offset = "0x8D3BE30", VA = "0x188D3CA30", Slot = "5")]
	public PBBHALCOHCB DGFNGGGAAON(string MICKAKKPGLH)
	{
		return default(PBBHALCOHCB);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public PPDJPCBBHNI DGFNGGGAAON()
		{
			return default(PPDJPCBBHNI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D010", Offset = "0x8D3C410", VA = "0x188D3D010", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0D0", Offset = "0x8D3C4D0", VA = "0x188D3D0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public ELOAIAIFLPJ DGFNGGGAAON()
		{
			return default(ELOAIAIFLPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D140", Offset = "0x8D3C540", VA = "0x188D3D140", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D1E0", Offset = "0x8D3C5E0", VA = "0x188D3D1E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public FGBKOBFMFHG DGFNGGGAAON()
		{
			return default(FGBKOBFMFHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedColorId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedColorId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D250", Offset = "0x8D3C650", VA = "0x188D3D250", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D2F0", Offset = "0x8D3C6F0", VA = "0x188D3D2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, PIKPFPHMMFH, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		public KHANOMCGPKB DGFNGGGAAON()
		{
			return default(KHANOMCGPKB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9AA0", Offset = "0x8BC8EA0", VA = "0x188BC9AA0", Slot = "4")]
		public bool Equals(SerializedCombinationId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D360", Offset = "0x8D3C760", VA = "0x188D3D360", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedCombinationId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D420", Offset = "0x8D3C820", VA = "0x188D3D420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D410", Offset = "0x8D3C810", VA = "0x188D3D410", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, PIKPFPHMMFH
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
			[Cpp2IlInjected.Address(RVA = "0x8D3D5C0", Offset = "0x8D3C9C0", VA = "0x188D3D5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x146A160", Offset = "0x1469560", VA = "0x18146A160")]
		public SerializedCustomAvatarItemId(Guid OOOANFDGEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public static SerializedCustomAvatarItemId GFJFFLLKLCI(Guid OOOANFDGEED)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D4B0", Offset = "0x8D3C8B0", VA = "0x188D3D4B0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0")]
		public static bool ILMCFLMCOJH(SerializedCustomAvatarItemId JLJHECODIOL, SerializedCustomAvatarItemId DABLONGJEGN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D490", Offset = "0x8D3C890", VA = "0x188D3D490")]
		public static bool AMDBHCBNEEF(SerializedCustomAvatarItemId JLJHECODIOL, SerializedCustomAvatarItemId DABLONGJEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D550", Offset = "0x8D3C950", VA = "0x188D3D550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x8D3D620", Offset = "0x8D3CA20", VA = "0x188D3D620")]
		public static SerializedEquipmentSkinId DOHINAJAOHG()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public CKPKAPIIDCF DGFNGGGAAON()
		{
			return default(CKPKAPIIDCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D650", Offset = "0x8D3CA50", VA = "0x188D3D650", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D6F0", Offset = "0x8D3CAF0", VA = "0x188D3D6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public KDMFEBNOJJL DGFNGGGAAON()
		{
			return default(KDMFEBNOJJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D760", Offset = "0x8D3CB60", VA = "0x188D3D760", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D800", Offset = "0x8D3CC00", VA = "0x188D3D800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public CNJONJMPBMP DGFNGGGAAON()
		{
			return default(CNJONJMPBMP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D870", Offset = "0x8D3CC70", VA = "0x188D3D870", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D910", Offset = "0x8D3CD10", VA = "0x188D3D910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30")]
		public JBEEOLANKLN DGFNGGGAAON()
		{
			return default(JBEEOLANKLN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D980", Offset = "0x8D3CD80", VA = "0x188D3D980", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D0B0", Offset = "0x8D3C4B0", VA = "0x188D3D0B0")]
		public static bool ILMCFLMCOJH(SerializedHairPatternId JLJHECODIOL, SerializedHairPatternId DABLONGJEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DA20", Offset = "0x8D3CE20", VA = "0x188D3DA20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, PIKPFPHMMFH
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
		[Cpp2IlInjected.Address(RVA = "0x1243A30", Offset = "0x1242E30", VA = "0x181243A30", Slot = "6")]
		public Guid MADBNACIMLN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8BC9AA0", Offset = "0x8BC8EA0", VA = "0x188BC9AA0", Slot = "4")]
		public bool Equals(SerializedMaterialId LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DA90", Offset = "0x8D3CE90", VA = "0x188D3DA90", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x8119EC0", VA = "0x18811AAC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x811A8C0", Offset = "0x8119CC0", VA = "0x18811A8C0", Slot = "5")]
		public int CompareTo(SerializedMaterialId LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DB40", Offset = "0x8D3CF40", VA = "0x188D3DB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AOGCHEKCKAL : PNAAMOOFGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AOGCHEKCKAL NKAKNKMIPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B080", Offset = "0x8D2A480", VA = "0x188D2B080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FHLIDKIAKPK<PPDJPCBBHNI> JBMCDPGLGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B1A0", Offset = "0x8D2A5A0", VA = "0x188D2B1A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FHLIDKIAKPK<CKPKAPIIDCF> GCHKIODJDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B140", Offset = "0x8D2A540", VA = "0x188D2B140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FHLIDKIAKPK<JBEEOLANKLN> BPCPEMGALHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B260", Offset = "0x8D2A660", VA = "0x188D2B260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FHLIDKIAKPK<KHANOMCGPKB> MIOIEGMKILP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B200", Offset = "0x8D2A600", VA = "0x188D2B200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FHLIDKIAKPK<FGBKOBFMFHG> AJLNAENPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B320", Offset = "0x8D2A720", VA = "0x188D2B320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FHLIDKIAKPK<CNJONJMPBMP> GGACDDIKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B2C0", Offset = "0x8D2A6C0", VA = "0x188D2B2C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FHLIDKIAKPK<ELOAIAIFLPJ> JOHPHKOMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B020", Offset = "0x8D2A420", VA = "0x188D2B020", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FHLIDKIAKPK<KDMFEBNOJJL> KMEOHIJMCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B0E0", Offset = "0x8D2A4E0", VA = "0x188D2B0E0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ELFKHNCMKEG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B720", Offset = "0x8D2AB20", VA = "0x188D2B720")]
	public static Guid AJODAKANMBB(string GIBDLKMJHBM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B7D0", Offset = "0x8D2ABD0", VA = "0x188D2B7D0")]
	public static bool EDGIFMKEIBG(string GIBDLKMJHBM, [Out] Guid OOOANFDGEED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HIADLDJAEEE : KCLOKAKIKBP<PPDJPCBBHNI>, FEFGPEEHFDA<PPDJPCBBHNI>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DBE0", Offset = "0x8D2CFE0", VA = "0x188D2DBE0", Slot = "4")]
	public IEnumerable<(PPDJPCBBHNI, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D32830", Offset = "0x8D31C30", VA = "0x188D32830", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public PPDJPCBBHNI FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(PPDJPCBBHNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HIADLDJAEEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BIFLGDHMNLH : KCLOKAKIKBP<ELOAIAIFLPJ>, FEFGPEEHFDA<ELOAIAIFLPJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B380", Offset = "0x8D2A780", VA = "0x188D2B380", Slot = "4")]
	public IEnumerable<(ELOAIAIFLPJ, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public ELOAIAIFLPJ FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(ELOAIAIFLPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public BIFLGDHMNLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GOFHGBOJIKP : KCLOKAKIKBP<FGBKOBFMFHG>, FEFGPEEHFDA<FGBKOBFMFHG>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BB20", Offset = "0x8D2AF20", VA = "0x188D2BB20", Slot = "4")]
	public IEnumerable<(FGBKOBFMFHG, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public FGBKOBFMFHG FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(FGBKOBFMFHG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GOFHGBOJIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EMCPBBGJNEF : KCLOKAKIKBP<KHANOMCGPKB>, FEFGPEEHFDA<KHANOMCGPKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FEFGPEEHFDA<DIBBJJPBDGI> JMNCPMBMDHH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public EMCPBBGJNEF(FEFGPEEHFDA<DIBBJJPBDGI> JMNCPMBMDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA520", Offset = "0x8BC9920", VA = "0x188BCA520", Slot = "4")]
	public IEnumerable<(KHANOMCGPKB, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B8A0", Offset = "0x8D2ACA0", VA = "0x188D2B8A0", Slot = "6")]
	public KHANOMCGPKB FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(KHANOMCGPKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BAE0", Offset = "0x8D2AEE0", VA = "0x188D2BAE0", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JFPPGOGFMHN : KCLOKAKIKBP<CKPKAPIIDCF>, FEFGPEEHFDA<CKPKAPIIDCF>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8D32C70", Offset = "0x8D32070", VA = "0x188D32C70", Slot = "4")]
	public IEnumerable<(CKPKAPIIDCF, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public CKPKAPIIDCF FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(CKPKAPIIDCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JFPPGOGFMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OFGJMNHDFJN : KCLOKAKIKBP<KDMFEBNOJJL>, FEFGPEEHFDA<KDMFEBNOJJL>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8D3ADD0", Offset = "0x8D3A1D0", VA = "0x188D3ADD0", Slot = "4")]
	public IEnumerable<(KDMFEBNOJJL, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public KDMFEBNOJJL FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(KDMFEBNOJJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OFGJMNHDFJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ILHCLEKCPJC : KCLOKAKIKBP<CNJONJMPBMP>, FEFGPEEHFDA<CNJONJMPBMP>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8D32850", Offset = "0x8D31C50", VA = "0x188D32850", Slot = "4")]
	public IEnumerable<(CNJONJMPBMP, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public CNJONJMPBMP FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(CNJONJMPBMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public ILHCLEKCPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AJHAIEKIDEB : KCLOKAKIKBP<JBEEOLANKLN>, FEFGPEEHFDA<JBEEOLANKLN>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A9A0", Offset = "0x8D29DA0", VA = "0x188D2A9A0", Slot = "4")]
	public IEnumerable<(JBEEOLANKLN, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public JBEEOLANKLN FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(JBEEOLANKLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AJHAIEKIDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KCLOKAKIKBP<TModern> : FEFGPEEHFDA<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JIMDIANOKMK();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NJFIKOAEBLI(string AKKPBENJCDC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AGAGDDJIDAH : KCLOKAKIKBP<DIBBJJPBDGI>, FEFGPEEHFDA<DIBBJJPBDGI>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8C7F640", Offset = "0x8C7EA40", VA = "0x188C7F640", Slot = "4")]
	public IEnumerable<(DIBBJJPBDGI, string)> JIMDIANOKMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAD5C60", Offset = "0xAD5060", VA = "0x180AD5C60", Slot = "5")]
	public string NJFIKOAEBLI(string AKKPBENJCDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8E0", Offset = "0x8D29CE0", VA = "0x188D2A8E0", Slot = "6")]
	public DIBBJJPBDGI FABNFCIJIDM(string AKKPBENJCDC)
	{
		return default(DIBBJJPBDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AGAGDDJIDAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KFOPGOADINK<TModern> : FHLIDKIAKPK<TModern>, FEFGPEEHFDA<TModern> where TModern : IEquatable<TModern>, PIKPFPHMMFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> CIBJOKDCBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DLNAJHHNJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KCLOKAKIKBP<TModern> GKNPBCLHOGP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x544BD00", Offset = "0x544B100", VA = "0x18544BD00")]
	public KFOPGOADINK(KCLOKAKIKBP<TModern> GKNPBCLHOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5448890", Offset = "0x5447C90", VA = "0x185448890", Slot = "5")]
	public TModern FABNFCIJIDM(string AKKPBENJCDC)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5449CB0", Offset = "0x54490B0", VA = "0x185449CB0", Slot = "4")]
	public string LECOIFNLDEE(TModern EEPBOHFEADD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LCOACCAMMEP : PNAAMOOFGFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KFOPGOADINK<PPDJPCBBHNI> MHCIFPFEPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KFOPGOADINK<CKPKAPIIDCF> LFPIJLCIPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KFOPGOADINK<JBEEOLANKLN> GKEBHKLOKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KFOPGOADINK<DIBBJJPBDGI> JMNCPMBMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KFOPGOADINK<KHANOMCGPKB> EDCGFOPAFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KFOPGOADINK<FGBKOBFMFHG> PGPJMGDOKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KFOPGOADINK<CNJONJMPBMP> GDMLNIFHLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KFOPGOADINK<ELOAIAIFLPJ> JANHJEFHFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KFOPGOADINK<KDMFEBNOJJL> NLKPDEEHCHM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FHLIDKIAKPK<PPDJPCBBHNI> JBMCDPGLGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FHLIDKIAKPK<CKPKAPIIDCF> GCHKIODJDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FHLIDKIAKPK<JBEEOLANKLN> BPCPEMGALHC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FHLIDKIAKPK<KHANOMCGPKB> MIOIEGMKILP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FHLIDKIAKPK<FGBKOBFMFHG> AJLNAENPLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FHLIDKIAKPK<CNJONJMPBMP> GGACDDIKLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FHLIDKIAKPK<ELOAIAIFLPJ> JOHPHKOMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FHLIDKIAKPK<KDMFEBNOJJL> KMEOHIJMCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A880", Offset = "0x8D39C80", VA = "0x188D3A880")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	[UsedImplicitly]
	internal static void CJOCKMMIJAN(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A8F0", Offset = "0x8D39CF0", VA = "0x188D3A8F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LCOACCAMMEP()
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
