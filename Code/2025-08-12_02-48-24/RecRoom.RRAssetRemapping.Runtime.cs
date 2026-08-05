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
		[Cpp2IlInjected.Address(RVA = "0x8EF6E80", Offset = "0x8EF5480", VA = "0x188EF6E80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KBILNPFNLIA : OAGGKJEICID
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex EBLKDEFGFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly ICDMELAABPI KPCLGEPKDJE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6980", Offset = "0x8EE4F80", VA = "0x188EE6980")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	[UsedImplicitly]
	internal static void EBJPFNJLIPM(CFPMHDJNIAH MIEGGENMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6EC0", Offset = "0x8EE54C0", VA = "0x188EE6EC0")]
	[UsedImplicitly]
	internal static void MFNAJAGLBHP(CFPMHDJNIAH MIEGGENMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	[RecRoom.NoEngine.Common.Preserve]
	public KBILNPFNLIA([OEKMEJFDAAI(null)] ICDMELAABPI KPCLGEPKDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6640", Offset = "0x8EE4C40", VA = "0x188EE6640", Slot = "4")]
	public string CAELEDFILEL(BDDFNOANCGH EKNLPIEMHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8EE69F0", Offset = "0x8EE4FF0", VA = "0x188EE69F0", Slot = "5")]
	public BDDFNOANCGH KJBCLIOBDIC(string EKNLPIEMHNC)
	{
		return default(BDDFNOANCGH);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public KFPCHIHLHJM KJBCLIOBDIC()
		{
			return default(KFPCHIHLHJM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedAvatarItemId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF62E0", Offset = "0x8EF48E0", VA = "0x188EF62E0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF63A0", Offset = "0x8EF49A0", VA = "0x188EF63A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public EKHGCOBGJHL KJBCLIOBDIC()
		{
			return default(EKHGCOBGJHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedBodyShapeId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6410", Offset = "0x8EF4A10", VA = "0x188EF6410", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8EF64B0", Offset = "0x8EF4AB0", VA = "0x188EF64B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public IDKLMMFDGOH KJBCLIOBDIC()
		{
			return default(IDKLMMFDGOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedColorId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedColorId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6520", Offset = "0x8EF4B20", VA = "0x188EF6520", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF65C0", Offset = "0x8EF4BC0", VA = "0x188EF65C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NFJHEOPKPGK, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
		public PHJLLKHDGCC KJBCLIOBDIC()
		{
			return default(PHJLLKHDGCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D83670", Offset = "0x8D81C70", VA = "0x188D83670", Slot = "4")]
		public bool Equals(SerializedCombinationId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6630", Offset = "0x8EF4C30", VA = "0x188EF6630", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedCombinationId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8EF66F0", Offset = "0x8EF4CF0", VA = "0x188EF66F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8EF66E0", Offset = "0x8EF4CE0", VA = "0x188EF66E0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NFJHEOPKPGK
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
			[Cpp2IlInjected.Address(RVA = "0x8EF6890", Offset = "0x8EF4E90", VA = "0x188EF6890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x14EFE20", Offset = "0x14EE420", VA = "0x1814EFE20")]
		public SerializedCustomAvatarItemId(Guid CLPJLOJHBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public static SerializedCustomAvatarItemId BKELCBHCLDB(Guid CLPJLOJHBDJ)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6760", Offset = "0x8EF4D60", VA = "0x188EF6760", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380")]
		public static bool LMIMJGGKHMP(SerializedCustomAvatarItemId LEOAACGBJCD, SerializedCustomAvatarItemId GDBFOEGEGHN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6800", Offset = "0x8EF4E00", VA = "0x188EF6800")]
		public static bool PACMOMIAEBP(SerializedCustomAvatarItemId LEOAACGBJCD, SerializedCustomAvatarItemId GDBFOEGEGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6820", Offset = "0x8EF4E20", VA = "0x188EF6820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x8EF68F0", Offset = "0x8EF4EF0", VA = "0x188EF68F0")]
		public static SerializedEquipmentSkinId AHJDNAMFHLO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public AKEMAGKCEEL KJBCLIOBDIC()
		{
			return default(AKEMAGKCEEL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6920", Offset = "0x8EF4F20", VA = "0x188EF6920", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8EF69C0", Offset = "0x8EF4FC0", VA = "0x188EF69C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public GJDKJPBGNBN KJBCLIOBDIC()
		{
			return default(GJDKJPBGNBN);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6A30", Offset = "0x8EF5030", VA = "0x188EF6A30", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6AD0", Offset = "0x8EF50D0", VA = "0x188EF6AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public DELOGIONJPM KJBCLIOBDIC()
		{
			return default(DELOGIONJPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedFaceShapeId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6B40", Offset = "0x8EF5140", VA = "0x188EF6B40", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6BE0", Offset = "0x8EF51E0", VA = "0x188EF6BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740")]
		public LIKKIADOIJO KJBCLIOBDIC()
		{
			return default(LIKKIADOIJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380", Slot = "4")]
		public bool Equals(SerializedHairPatternId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6C50", Offset = "0x8EF5250", VA = "0x188EF6C50", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6380", Offset = "0x8EF4980", VA = "0x188EF6380")]
		public static bool LMIMJGGKHMP(SerializedHairPatternId LEOAACGBJCD, SerializedHairPatternId GDBFOEGEGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6CF0", Offset = "0x8EF52F0", VA = "0x188EF6CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NFJHEOPKPGK
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
		[Cpp2IlInjected.Address(RVA = "0x1286740", Offset = "0x1284D40", VA = "0x181286740", Slot = "6")]
		public Guid CKNNKMILCOF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D83670", Offset = "0x8D81C70", VA = "0x188D83670", Slot = "4")]
		public bool Equals(SerializedMaterialId IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6D60", Offset = "0x8EF5360", VA = "0x188EF6D60", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82CFD50", Offset = "0x82CE350", VA = "0x1882CFD50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82CFBC0", Offset = "0x82CE1C0", VA = "0x1882CFBC0", Slot = "5")]
		public int CompareTo(SerializedMaterialId IBCMCOKAJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8EF6E10", Offset = "0x8EF5410", VA = "0x188EF6E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAHFAMGNMPP : ICDMELAABPI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NAHFAMGNMPP DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8EF40A0", Offset = "0x8EF26A0", VA = "0x188EF40A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HILFMOALGJN<KFPCHIHLHJM> AHLDBBNBLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3F20", Offset = "0x8EF2520", VA = "0x188EF3F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HILFMOALGJN<AKEMAGKCEEL> GFPDILAHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3F80", Offset = "0x8EF2580", VA = "0x188EF3F80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HILFMOALGJN<LIKKIADOIJO> IDBPKEDCNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4100", Offset = "0x8EF2700", VA = "0x188EF4100", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HILFMOALGJN<PHJLLKHDGCC> IDFLIPKGJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4160", Offset = "0x8EF2760", VA = "0x188EF4160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HILFMOALGJN<IDKLMMFDGOH> MFJOEGMDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF41C0", Offset = "0x8EF27C0", VA = "0x188EF41C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HILFMOALGJN<DELOGIONJPM> PHJBNEBJJII
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3FE0", Offset = "0x8EF25E0", VA = "0x188EF3FE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HILFMOALGJN<EKHGCOBGJHL> PGHHOCPNCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF4040", Offset = "0x8EF2640", VA = "0x188EF4040", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HILFMOALGJN<GJDKJPBGNBN> LBFINEJCMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF3EC0", Offset = "0x8EF24C0", VA = "0x188EF3EC0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HBFECHBDOAG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6040", Offset = "0x8EE4640", VA = "0x188EE6040")]
	public static Guid BJDNCNKBOOC(string MNDFFMCPPIB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8EE5F70", Offset = "0x8EE4570", VA = "0x188EE5F70")]
	public static bool BAFDHKGALIJ(string MNDFFMCPPIB, [Out] Guid CLPJLOJHBDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LPDIMACKNLO : NNEKOBBGHMI<KFPCHIHLHJM>, IIFJDIFEHDN<KFPCHIHLHJM>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7660", Offset = "0x8EE5C60", VA = "0x188EE7660", Slot = "4")]
	public IEnumerable<(KFPCHIHLHJM, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7640", Offset = "0x8EE5C40", VA = "0x188EE7640", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public KFPCHIHLHJM CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(KFPCHIHLHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public LPDIMACKNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BCEEMPLHHFJ : NNEKOBBGHMI<EKHGCOBGJHL>, IIFJDIFEHDN<EKHGCOBGJHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3C70", Offset = "0x8EE2270", VA = "0x188EE3C70", Slot = "4")]
	public IEnumerable<(EKHGCOBGJHL, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public EKHGCOBGJHL CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(EKHGCOBGJHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BCEEMPLHHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NFIEKNPDBAE : NNEKOBBGHMI<IDKLMMFDGOH>, IIFJDIFEHDN<IDKLMMFDGOH>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8EF4220", Offset = "0x8EF2820", VA = "0x188EF4220", Slot = "4")]
	public IEnumerable<(IDKLMMFDGOH, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public IDKLMMFDGOH CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(IDKLMMFDGOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public NFIEKNPDBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DEDEBNBEGGI : NNEKOBBGHMI<PHJLLKHDGCC>, IIFJDIFEHDN<PHJLLKHDGCC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IIFJDIFEHDN<PDLCHNHKPHL> NOIGLNFNMCP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public DEDEBNBEGGI(IIFJDIFEHDN<PDLCHNHKPHL> NOIGLNFNMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8D837F0", Offset = "0x8D81DF0", VA = "0x188D837F0", Slot = "4")]
	public IEnumerable<(PHJLLKHDGCC, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4430", Offset = "0x8EE2A30", VA = "0x188EE4430", Slot = "6")]
	public PHJLLKHDGCC CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(PHJLLKHDGCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4670", Offset = "0x8EE2C70", VA = "0x188EE4670", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MBDBPKLLCFC : NNEKOBBGHMI<AKEMAGKCEEL>, IIFJDIFEHDN<AKEMAGKCEEL>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8EEC2B0", Offset = "0x8EEA8B0", VA = "0x188EEC2B0", Slot = "4")]
	public IEnumerable<(AKEMAGKCEEL, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public AKEMAGKCEEL CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(AKEMAGKCEEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MBDBPKLLCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FJKJJBDEBDG : NNEKOBBGHMI<GJDKJPBGNBN>, IIFJDIFEHDN<GJDKJPBGNBN>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8EE46B0", Offset = "0x8EE2CB0", VA = "0x188EE46B0", Slot = "4")]
	public IEnumerable<(GJDKJPBGNBN, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public GJDKJPBGNBN CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(GJDKJPBGNBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public FJKJJBDEBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BMGMOCEPICA : NNEKOBBGHMI<DELOGIONJPM>, IIFJDIFEHDN<DELOGIONJPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8EE4010", Offset = "0x8EE2610", VA = "0x188EE4010", Slot = "4")]
	public IEnumerable<(DELOGIONJPM, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public DELOGIONJPM CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(DELOGIONJPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public BMGMOCEPICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KFINMOCDKKG : NNEKOBBGHMI<LIKKIADOIJO>, IIFJDIFEHDN<LIKKIADOIJO>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6FC0", Offset = "0x8EE55C0", VA = "0x188EE6FC0", Slot = "4")]
	public IEnumerable<(LIKKIADOIJO, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public LIKKIADOIJO CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(LIKKIADOIJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KFINMOCDKKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NNEKOBBGHMI<TModern> : IIFJDIFEHDN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> PPBBPIPGDIP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JOMKJGFIKGI(string HFDHCIGLHDO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class APJBOMJMPEF : NNEKOBBGHMI<PDLCHNHKPHL>, IIFJDIFEHDN<PDLCHNHKPHL>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8E38910", Offset = "0x8E36F10", VA = "0x188E38910", Slot = "4")]
	public IEnumerable<(PDLCHNHKPHL, string)> PPBBPIPGDIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAFB050", Offset = "0xAF9650", VA = "0x180AFB050", Slot = "5")]
	public string JOMKJGFIKGI(string HFDHCIGLHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8EE3BB0", Offset = "0x8EE21B0", VA = "0x188EE3BB0", Slot = "6")]
	public PDLCHNHKPHL CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return default(PDLCHNHKPHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public APJBOMJMPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MHDIJIHECOI<TModern> : HILFMOALGJN<TModern>, IIFJDIFEHDN<TModern> where TModern : IEquatable<TModern>, NFJHEOPKPGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> GAFHJHKJGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> HGIAOPPMINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly NNEKOBBGHMI<TModern> GMGPJMIOMDL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x595A9B0", Offset = "0x5958FB0", VA = "0x18595A9B0")]
	public MHDIJIHECOI(NNEKOBBGHMI<TModern> GMGPJMIOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x59596A0", Offset = "0x5957CA0", VA = "0x1859596A0", Slot = "5")]
	public TModern CLAMKEGLGMN(string HFDHCIGLHDO)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x595A230", Offset = "0x5958830", VA = "0x18595A230", Slot = "4")]
	public string JNEMDGBNFDO(TModern DCLEAEPOCKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IKJPAKGDCHE : ICDMELAABPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MHDIJIHECOI<KFPCHIHLHJM> BLNENCDBOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MHDIJIHECOI<AKEMAGKCEEL> JJDMLCPMHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MHDIJIHECOI<LIKKIADOIJO> BFPHIOMJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MHDIJIHECOI<PDLCHNHKPHL> NOIGLNFNMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MHDIJIHECOI<PHJLLKHDGCC> PCBNCFBEIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MHDIJIHECOI<IDKLMMFDGOH> PMKAHHEBKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MHDIJIHECOI<DELOGIONJPM> HPPGJEAHMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MHDIJIHECOI<EKHGCOBGJHL> KFEBEPDHCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MHDIJIHECOI<GJDKJPBGNBN> BDKJCHPDHII;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HILFMOALGJN<KFPCHIHLHJM> AHLDBBNBLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HILFMOALGJN<AKEMAGKCEEL> GFPDILAHEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HILFMOALGJN<LIKKIADOIJO> IDBPKEDCNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public HILFMOALGJN<PHJLLKHDGCC> IDFLIPKGJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public HILFMOALGJN<IDKLMMFDGOH> MFJOEGMDJOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HILFMOALGJN<DELOGIONJPM> PHJBNEBJJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HILFMOALGJN<EKHGCOBGJHL> PGHHOCPNCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public HILFMOALGJN<GJDKJPBGNBN> LBFINEJCMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8EE60F0", Offset = "0x8EE46F0", VA = "0x188EE60F0")]
	[LAFCEDCMNGK.DCDCJCFDIHP.KFAGBDMOPBG]
	[UsedImplicitly]
	internal static void KHJKENNIAIC(CFPMHDJNIAH MIEGGENMBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8EE6160", Offset = "0x8EE4760", VA = "0x188EE6160")]
	[RecRoom.NoEngine.Common.Preserve]
	public IKJPAKGDCHE()
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
