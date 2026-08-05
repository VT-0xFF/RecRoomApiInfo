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
		[Cpp2IlInjected.Address(RVA = "0x76C5330", Offset = "0x76C3D30", VA = "0x1876C5330", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LMEMLBIBOAJ : HNJBJMEDIHE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HOELKCBIIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly HELFAHKGAEL PLPPFFGIMJO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76C2270", Offset = "0x76C0C70", VA = "0x1876C2270")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	[UsedImplicitly]
	internal static void DJJNDGGBFEG(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x76C27B0", Offset = "0x76C11B0", VA = "0x1876C27B0")]
	[UsedImplicitly]
	internal static void HFNOOIBCGOK(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LMEMLBIBOAJ([CCLEDEMDDDH(null)] HELFAHKGAEL PLPPFFGIMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76C2810", Offset = "0x76C1210", VA = "0x1876C2810", Slot = "4")]
	public string HLGBFIEHJDG(KPJKPOMJGHE CPOLINJHFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76C22E0", Offset = "0x76C0CE0", VA = "0x1876C22E0", Slot = "5")]
	public KPJKPOMJGHE DLDAMIHNNNK(string CPOLINJHFNA)
	{
		return default(KPJKPOMJGHE);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public SerializedAvatarItemId(FDADCHGPADP CMEADPACGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public FDADCHGPADP DLDAMIHNNNK()
		{
			return default(FDADCHGPADP);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4810", Offset = "0x76C3210", VA = "0x1876C4810", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76C48D0", Offset = "0x76C32D0", VA = "0x1876C48D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public IKEMKMCCCBO DLDAMIHNNNK()
		{
			return default(IKEMKMCCCBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76C4940", Offset = "0x76C3340", VA = "0x1876C4940", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x76C49E0", Offset = "0x76C33E0", VA = "0x1876C49E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public JLNNJCEGLJL DLDAMIHNNNK()
		{
			return default(JLNNJCEGLJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedColorId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedColorId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4A50", Offset = "0x76C3450", VA = "0x1876C4A50", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4AF0", Offset = "0x76C34F0", VA = "0x1876C4AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CHMODCOCIAL, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840")]
		public LEPAIFLHDDH DLDAMIHNNNK()
		{
			return default(LEPAIFLHDDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76C4C90", Offset = "0x76C3690", VA = "0x1876C4C90")]
		public SerializedCombinationId(LEPAIFLHDDH GOJEAAACHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75511F0", Offset = "0x754FBF0", VA = "0x1875511F0", Slot = "4")]
		public bool Equals(SerializedCombinationId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B60", Offset = "0x76C3560", VA = "0x1876C4B60", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedCombinationId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x76C4C20", Offset = "0x76C3620", VA = "0x1876C4C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x76C4C10", Offset = "0x76C3610", VA = "0x1876C4C10", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public SerializedCustomAvatarItemId(Guid MMGMNLELLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4CA0", Offset = "0x76C36A0", VA = "0x1876C4CA0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0")]
		public static bool EKIKFCPHGPG(SerializedCustomAvatarItemId FCKNABCAAPB, SerializedCustomAvatarItemId JGIIKLPFBFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76C4D40", Offset = "0x76C3740", VA = "0x1876C4D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0x76C4E50", Offset = "0x76C3850", VA = "0x1876C4E50")]
		public static SerializedEquipmentSkinId FJNGEKIMLLK()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public LOIONMFEKKG DLDAMIHNNNK()
		{
			return default(LOIONMFEKKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76C4DB0", Offset = "0x76C37B0", VA = "0x1876C4DB0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x76C4E80", Offset = "0x76C3880", VA = "0x1876C4E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public FNFEKAHOFPA DLDAMIHNNNK()
		{
			return default(FNFEKAHOFPA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76C4EF0", Offset = "0x76C38F0", VA = "0x1876C4EF0", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x76C4F90", Offset = "0x76C3990", VA = "0x1876C4F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public CCCHHPPCONE DLDAMIHNNNK()
		{
			return default(CCCHHPPCONE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x76C5000", Offset = "0x76C3A00", VA = "0x1876C5000", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x76C50A0", Offset = "0x76C3AA0", VA = "0x1876C50A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0")]
		public AFIMDNDGDAB DLDAMIHNNNK()
		{
			return default(AFIMDNDGDAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedHairPatternId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76C5110", Offset = "0x76C3B10", VA = "0x1876C5110", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x76C48B0", Offset = "0x76C32B0", VA = "0x1876C48B0")]
		public static bool EKIKFCPHGPG(SerializedHairPatternId FCKNABCAAPB, SerializedHairPatternId JGIIKLPFBFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76C51B0", Offset = "0x76C3BB0", VA = "0x1876C51B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CHMODCOCIAL
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
		[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD23E60", VA = "0x180D25460")]
		public SerializedMaterialId(OGEBMIEBBJO CMEADPACGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xD253B0", Offset = "0xD23DB0", VA = "0x180D253B0", Slot = "6")]
		public Guid FICIGFHCHPG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75511F0", Offset = "0x754FBF0", VA = "0x1875511F0", Slot = "4")]
		public bool Equals(SerializedMaterialId GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x76C5220", Offset = "0x76C3C20", VA = "0x1876C5220", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C93520", Offset = "0x6C91F20", VA = "0x186C93520", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C93390", Offset = "0x6C91D90", VA = "0x186C93390", Slot = "5")]
		public int CompareTo(SerializedMaterialId GDOGPMPJPOO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x76C52C0", Offset = "0x76C3CC0", VA = "0x1876C52C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PBOODOHHJDE : HELFAHKGAEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PBOODOHHJDE JOLICDCBKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x76C4510", Offset = "0x76C2F10", VA = "0x1876C4510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public OHCBNEMNKEA<FDADCHGPADP> BKHAJKBABBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76C44B0", Offset = "0x76C2EB0", VA = "0x1876C44B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OHCBNEMNKEA<LOIONMFEKKG> NJFIGNFLNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x76C4750", Offset = "0x76C3150", VA = "0x1876C4750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OHCBNEMNKEA<AFIMDNDGDAB> DPLAMHBFAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x76C4570", Offset = "0x76C2F70", VA = "0x1876C4570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OHCBNEMNKEA<LEPAIFLHDDH> HHFFGIMBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x76C45D0", Offset = "0x76C2FD0", VA = "0x1876C45D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OHCBNEMNKEA<JLNNJCEGLJL> EFCLLHHOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x76C4690", Offset = "0x76C3090", VA = "0x1876C4690", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OHCBNEMNKEA<CCCHHPPCONE> NDCNPOMGDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4630", Offset = "0x76C3030", VA = "0x1876C4630", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OHCBNEMNKEA<IKEMKMCCCBO> JEPLJGLMANG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x76C47B0", Offset = "0x76C31B0", VA = "0x1876C47B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OHCBNEMNKEA<FNFEKAHOFPA> MLCMJHLLDJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76C46F0", Offset = "0x76C30F0", VA = "0x1876C46F0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDBJNNJFCPJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76BD1B0", Offset = "0x76BBBB0", VA = "0x1876BD1B0")]
	public static Guid FOCBCIBPABD(string MAHHCBPLAAD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76BD0E0", Offset = "0x76BBAE0", VA = "0x1876BD0E0")]
	public static bool EJNAONJIDNM(string MAHHCBPLAAD, [Out] Guid MMGMNLELLKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KKNEAMKPJHL : GOFCDNNIBBC<FDADCHGPADP>, JKPEHELCBKF<FDADCHGPADP>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x76BD600", Offset = "0x76BC000", VA = "0x1876BD600", Slot = "4")]
	public IEnumerable<(FDADCHGPADP, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76C2250", Offset = "0x76C0C50", VA = "0x1876C2250", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public FDADCHGPADP JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(FDADCHGPADP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KKNEAMKPJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class JHNDIBFNDIB : GOFCDNNIBBC<IKEMKMCCCBO>, JKPEHELCBKF<IKEMKMCCCBO>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x76BD260", Offset = "0x76BBC60", VA = "0x1876BD260", Slot = "4")]
	public IEnumerable<(IKEMKMCCCBO, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public IKEMKMCCCBO JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(IKEMKMCCCBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JHNDIBFNDIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EPDLIGLGJBK : GOFCDNNIBBC<JLNNJCEGLJL>, JKPEHELCBKF<JLNNJCEGLJL>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x76B2AA0", Offset = "0x76B14A0", VA = "0x1876B2AA0", Slot = "4")]
	public IEnumerable<(JLNNJCEGLJL, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public JLNNJCEGLJL JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(JLNNJCEGLJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public EPDLIGLGJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EMDOCPCNBDF : GOFCDNNIBBC<LEPAIFLHDDH>, JKPEHELCBKF<LEPAIFLHDDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JKPEHELCBKF<OGEBMIEBBJO> NFEHANMBBPO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
	public EMDOCPCNBDF(JKPEHELCBKF<OGEBMIEBBJO> NFEHANMBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7551D20", Offset = "0x7550720", VA = "0x187551D20", Slot = "4")]
	public IEnumerable<(LEPAIFLHDDH, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x76B2820", Offset = "0x76B1220", VA = "0x1876B2820", Slot = "6")]
	public LEPAIFLHDDH JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(LEPAIFLHDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x76B2A60", Offset = "0x76B1460", VA = "0x1876B2A60", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FOABMNMLHEM : GOFCDNNIBBC<LOIONMFEKKG>, JKPEHELCBKF<LOIONMFEKKG>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76B4B60", Offset = "0x76B3560", VA = "0x1876B4B60", Slot = "4")]
	public IEnumerable<(LOIONMFEKKG, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public LOIONMFEKKG JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(LOIONMFEKKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public FOABMNMLHEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OKMCKCDJGGC : GOFCDNNIBBC<FNFEKAHOFPA>, JKPEHELCBKF<FNFEKAHOFPA>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x76C2BF0", Offset = "0x76C15F0", VA = "0x1876C2BF0", Slot = "4")]
	public IEnumerable<(FNFEKAHOFPA, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public FNFEKAHOFPA JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(FNFEKAHOFPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public OKMCKCDJGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GGONCGKGOEO : GOFCDNNIBBC<CCCHHPPCONE>, JKPEHELCBKF<CCCHHPPCONE>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76BC770", Offset = "0x76BB170", VA = "0x1876BC770", Slot = "4")]
	public IEnumerable<(CCCHHPPCONE, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public CCCHHPPCONE JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(CCCHHPPCONE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public GGONCGKGOEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DADHJGNAFOA : GOFCDNNIBBC<AFIMDNDGDAB>, JKPEHELCBKF<AFIMDNDGDAB>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x76B20E0", Offset = "0x76B0AE0", VA = "0x1876B20E0", Slot = "4")]
	public IEnumerable<(AFIMDNDGDAB, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public AFIMDNDGDAB JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(AFIMDNDGDAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public DADHJGNAFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GOFCDNNIBBC<TModern> : JKPEHELCBKF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DDMEJGGGAAP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KLEPNMOPKCE(string CAPCIPBNAGM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KKOIDEGEGOO : GOFCDNNIBBC<OGEBMIEBBJO>, JKPEHELCBKF<OGEBMIEBBJO>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7606E40", Offset = "0x7605840", VA = "0x187606E40", Slot = "4")]
	public IEnumerable<(OGEBMIEBBJO, string)> DDMEJGGGAAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9DAC80", Offset = "0x9D9680", VA = "0x1809DAC80", Slot = "5")]
	public string KLEPNMOPKCE(string CAPCIPBNAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76B2760", Offset = "0x76B1160", VA = "0x1876B2760", Slot = "6")]
	public OGEBMIEBBJO JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return default(OGEBMIEBBJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KKOIDEGEGOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FKMLCKDJHNN<TModern> : OHCBNEMNKEA<TModern>, JKPEHELCBKF<TModern> where TModern : IEquatable<TModern>, CHMODCOCIAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> OGOAKKLOACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IGJIHBKFKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly GOFCDNNIBBC<TModern> IKOCEJODHDP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3FBBD50", Offset = "0x3FBA750", VA = "0x183FBBD50")]
	public FKMLCKDJHNN(GOFCDNNIBBC<TModern> IKOCEJODHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FBAF90", Offset = "0x3FB9990", VA = "0x183FBAF90", Slot = "5")]
	public TModern JLHNOJGGFGH(string CAPCIPBNAGM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3FB9910", Offset = "0x3FB8310", VA = "0x183FB9910", Slot = "4")]
	public string HMLOPFJFCLF(TModern DJMDHGJCICJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GLOKHBBJIGD : HELFAHKGAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private FKMLCKDJHNN<FDADCHGPADP> GAANDEDHCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FKMLCKDJHNN<LOIONMFEKKG> CMOGHLIDEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FKMLCKDJHNN<AFIMDNDGDAB> FEOMDGMPJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private FKMLCKDJHNN<OGEBMIEBBJO> NFEHANMBBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FKMLCKDJHNN<LEPAIFLHDDH> HLHNMLIAHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FKMLCKDJHNN<JLNNJCEGLJL> NLKICFGOGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private FKMLCKDJHNN<CCCHHPPCONE> PMFKKGPCFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private FKMLCKDJHNN<IKEMKMCCCBO> PGCBMIMBJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FKMLCKDJHNN<FNFEKAHOFPA> IIIDJEIFJOA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OHCBNEMNKEA<FDADCHGPADP> BKHAJKBABBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OHCBNEMNKEA<LOIONMFEKKG> NJFIGNFLNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OHCBNEMNKEA<AFIMDNDGDAB> DPLAMHBFAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OHCBNEMNKEA<LEPAIFLHDDH> HHFFGIMBKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public OHCBNEMNKEA<JLNNJCEGLJL> EFCLLHHOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public OHCBNEMNKEA<CCCHHPPCONE> NDCNPOMGDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8AD960", Offset = "0x8AC360", VA = "0x1808AD960", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public OHCBNEMNKEA<IKEMKMCCCBO> JEPLJGLMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OHCBNEMNKEA<FNFEKAHOFPA> MLCMJHLLDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1D0", Offset = "0x8A9BD0", VA = "0x1808AB1D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76BCB90", Offset = "0x76BB590", VA = "0x1876BCB90")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	[UsedImplicitly]
	internal static void LAKIIFNFKHP(KNPHAFHLPCE LKJFOBDMKGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76BCC00", Offset = "0x76BB600", VA = "0x1876BCC00")]
	[RecRoom.NoEngine.Common.Preserve]
	public GLOKHBBJIGD()
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
