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
		[Cpp2IlInjected.Address(RVA = "0x78F73E0", Offset = "0x78F67E0", VA = "0x1878F73E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GDPDCMDPLNC : JOPKLKKBJAP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex DDPHPDKMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PLDNGFNJBOA MHNAFPFJGIM;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78EDBD0", Offset = "0x78ECFD0", VA = "0x1878EDBD0")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	[UsedImplicitly]
	internal static void OHHPJPBCCIE(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78EDB70", Offset = "0x78ECF70", VA = "0x1878EDB70")]
	[UsedImplicitly]
	internal static void MOGLGOKLACM(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GDPDCMDPLNC([CNGCCDLPGOD(null)] PLDNGFNJBOA MHNAFPFJGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78ED370", Offset = "0x78EC770", VA = "0x1878ED370", Slot = "4")]
	public string GKPJGNLGAKF(HHDIOAFENPE AOOGNGKJLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78ED6B0", Offset = "0x78ECAB0", VA = "0x1878ED6B0", Slot = "5")]
	public HHDIOAFENPE KBLFJIABLOP(string AOOGNGKJLKL)
	{
		return default(HHDIOAFENPE);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public SerializedAvatarItemId(FKEBAHOJOEH LPMIIFILJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public FKEBAHOJOEH KBLFJIABLOP()
		{
			return default(FKEBAHOJOEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedAvatarItemId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78F68C0", Offset = "0x78F5CC0", VA = "0x1878F68C0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78F6980", Offset = "0x78F5D80", VA = "0x1878F6980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public LGEDBJMHMNA KBLFJIABLOP()
		{
			return default(LGEDBJMHMNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedBodyShapeId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78F69F0", Offset = "0x78F5DF0", VA = "0x1878F69F0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78F6A90", Offset = "0x78F5E90", VA = "0x1878F6A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public GHOPLCAKCFO KBLFJIABLOP()
		{
			return default(GHOPLCAKCFO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedColorId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedColorId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78F6B00", Offset = "0x78F5F00", VA = "0x1878F6B00", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78F6BA0", Offset = "0x78F5FA0", VA = "0x1878F6BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MDKKLDNPMCM, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB5FC10", Offset = "0xB5F010", VA = "0x180B5FC10")]
		public DOPNIDFJPBN KBLFJIABLOP()
		{
			return default(DOPNIDFJPBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78F6D40", Offset = "0x78F6140", VA = "0x1878F6D40")]
		public SerializedCombinationId(DOPNIDFJPBN ABDBLINMLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7782CD0", Offset = "0x77820D0", VA = "0x187782CD0", Slot = "4")]
		public bool Equals(SerializedCombinationId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x78F6C10", Offset = "0x78F6010", VA = "0x1878F6C10", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedCombinationId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78F6CD0", Offset = "0x78F60D0", VA = "0x1878F6CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78F6CC0", Offset = "0x78F60C0", VA = "0x1878F6CC0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public SerializedCustomAvatarItemId(Guid FNECNONNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78F6D50", Offset = "0x78F6150", VA = "0x1878F6D50", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960")]
		public static bool FANHDJJNLED(SerializedCustomAvatarItemId KLFFMNNBENE, SerializedCustomAvatarItemId EHNIKEHCICN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x78F6DF0", Offset = "0x78F61F0", VA = "0x1878F6DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0x78F6E60", Offset = "0x78F6260", VA = "0x1878F6E60")]
		public static SerializedEquipmentSkinId BDCCDMBHBEE()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public KPAAJPHOOAN KBLFJIABLOP()
		{
			return default(KPAAJPHOOAN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78F6E90", Offset = "0x78F6290", VA = "0x1878F6E90", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78F6F30", Offset = "0x78F6330", VA = "0x1878F6F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public DPJDJGPLJGE KBLFJIABLOP()
		{
			return default(DPJDJGPLJGE);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x78F6FA0", Offset = "0x78F63A0", VA = "0x1878F6FA0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x78F7040", Offset = "0x78F6440", VA = "0x1878F7040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public DKCADIBAFHB KBLFJIABLOP()
		{
			return default(DKCADIBAFHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedFaceShapeId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x78F70B0", Offset = "0x78F64B0", VA = "0x1878F70B0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78F7150", Offset = "0x78F6550", VA = "0x1878F7150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160")]
		public MLPEKEOBFJJ KBLFJIABLOP()
		{
			return default(MLPEKEOBFJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960", Slot = "4")]
		public bool Equals(SerializedHairPatternId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedHairPatternId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x78F71C0", Offset = "0x78F65C0", VA = "0x1878F71C0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x78F6960", Offset = "0x78F5D60", VA = "0x1878F6960")]
		public static bool FANHDJJNLED(SerializedHairPatternId KLFFMNNBENE, SerializedHairPatternId EHNIKEHCICN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x78F7260", Offset = "0x78F6660", VA = "0x1878F7260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MDKKLDNPMCM
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
		[Cpp2IlInjected.Address(RVA = "0xDD9170", Offset = "0xDD8570", VA = "0x180DD9170")]
		public SerializedMaterialId(KFCPMCHPDCP LPMIIFILJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDD9160", Offset = "0xDD8560", VA = "0x180DD9160", Slot = "6")]
		public Guid ELEOGAJCADM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7782CD0", Offset = "0x77820D0", VA = "0x187782CD0", Slot = "4")]
		public bool Equals(SerializedMaterialId BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x78F72D0", Offset = "0x78F66D0", VA = "0x1878F72D0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E97900", Offset = "0x6E96D00", VA = "0x186E97900", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E97700", Offset = "0x6E96B00", VA = "0x186E97700", Slot = "5")]
		public int CompareTo(SerializedMaterialId BMKPAKCEMFK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x78F7370", Offset = "0x78F6770", VA = "0x1878F7370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class EGLINIGCKKN : PLDNGFNJBOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EGLINIGCKKN ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x78ED310", Offset = "0x78EC710", VA = "0x1878ED310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PIBHMOCPPJE<FKEBAHOJOEH> GKBKMBPFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x78ED010", Offset = "0x78EC410", VA = "0x1878ED010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PIBHMOCPPJE<KPAAJPHOOAN> MBPKNMCHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x78ED0D0", Offset = "0x78EC4D0", VA = "0x1878ED0D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PIBHMOCPPJE<MLPEKEOBFJJ> OCMICIHIAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x78ED130", Offset = "0x78EC530", VA = "0x1878ED130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PIBHMOCPPJE<DOPNIDFJPBN> KEKCLKHFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x78ED1F0", Offset = "0x78EC5F0", VA = "0x1878ED1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PIBHMOCPPJE<GHOPLCAKCFO> IMKFEEFNLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x78ED2B0", Offset = "0x78EC6B0", VA = "0x1878ED2B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PIBHMOCPPJE<DKCADIBAFHB> PKJLMNJAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x78ED190", Offset = "0x78EC590", VA = "0x1878ED190", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PIBHMOCPPJE<LGEDBJMHMNA> PMDEIGBHNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78ED070", Offset = "0x78EC470", VA = "0x1878ED070", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PIBHMOCPPJE<DPJDJGPLJGE> IPHHKHDIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78ED250", Offset = "0x78EC650", VA = "0x1878ED250", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NDMNPFFEHFF
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x78F5F70", Offset = "0x78F5370", VA = "0x1878F5F70")]
	public static Guid GPMPEKMFIML(string MEDCMINBEHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78F6020", Offset = "0x78F5420", VA = "0x1878F6020")]
	public static bool HALMJMGOIGD(string MEDCMINBEHG, [Out] Guid FNECNONNEND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DOGDDMJJBAB : MPEINBDDINL<FKEBAHOJOEH>, ODJJGNNCBPD<FKEBAHOJOEH>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x78E83A0", Offset = "0x78E77A0", VA = "0x1878E83A0", Slot = "4")]
	public IEnumerable<(FKEBAHOJOEH, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x78ECFF0", Offset = "0x78EC3F0", VA = "0x1878ECFF0", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public FKEBAHOJOEH EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(FKEBAHOJOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DOGDDMJJBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ACCHIBJGKNO : MPEINBDDINL<LGEDBJMHMNA>, ODJJGNNCBPD<LGEDBJMHMNA>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x78E4260", Offset = "0x78E3660", VA = "0x1878E4260", Slot = "4")]
	public IEnumerable<(LGEDBJMHMNA, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public LGEDBJMHMNA EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(LGEDBJMHMNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ACCHIBJGKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DMDHNJOEENG : MPEINBDDINL<GHOPLCAKCFO>, ODJJGNNCBPD<GHOPLCAKCFO>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x78E62E0", Offset = "0x78E56E0", VA = "0x1878E62E0", Slot = "4")]
	public IEnumerable<(GHOPLCAKCFO, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public GHOPLCAKCFO EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(GHOPLCAKCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DMDHNJOEENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OHLGCOHKHDF : MPEINBDDINL<DOPNIDFJPBN>, ODJJGNNCBPD<DOPNIDFJPBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ODJJGNNCBPD<KFCPMCHPDCP> OBDGCEAOMDH;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	public OHLGCOHKHDF(ODJJGNNCBPD<KFCPMCHPDCP> OBDGCEAOMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7783DE0", Offset = "0x77831E0", VA = "0x187783DE0", Slot = "4")]
	public IEnumerable<(DOPNIDFJPBN, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x78F60F0", Offset = "0x78F54F0", VA = "0x1878F60F0", Slot = "6")]
	public DOPNIDFJPBN EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(DOPNIDFJPBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x78F6330", Offset = "0x78F5730", VA = "0x1878F6330", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NDGFJIAFGCN : MPEINBDDINL<KPAAJPHOOAN>, ODJJGNNCBPD<KPAAJPHOOAN>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x78EE360", Offset = "0x78ED760", VA = "0x1878EE360", Slot = "4")]
	public IEnumerable<(KPAAJPHOOAN, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public KPAAJPHOOAN EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(KPAAJPHOOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public NDGFJIAFGCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BGKNJCFOGMN : MPEINBDDINL<DPJDJGPLJGE>, ODJJGNNCBPD<DPJDJGPLJGE>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x78E4600", Offset = "0x78E3A00", VA = "0x1878E4600", Slot = "4")]
	public IEnumerable<(DPJDJGPLJGE, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public DPJDJGPLJGE EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(DPJDJGPLJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BGKNJCFOGMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DENMEBKOFGJ : MPEINBDDINL<DKCADIBAFHB>, ODJJGNNCBPD<DKCADIBAFHB>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x78E5EC0", Offset = "0x78E52C0", VA = "0x1878E5EC0", Slot = "4")]
	public IEnumerable<(DKCADIBAFHB, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public DKCADIBAFHB EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(DKCADIBAFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DENMEBKOFGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KOAPFPBIHEI : MPEINBDDINL<MLPEKEOBFJJ>, ODJJGNNCBPD<MLPEKEOBFJJ>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x78EDCE0", Offset = "0x78ED0E0", VA = "0x1878EDCE0", Slot = "4")]
	public IEnumerable<(MLPEKEOBFJJ, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public MLPEKEOBFJJ EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(MLPEKEOBFJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KOAPFPBIHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MPEINBDDINL<TModern> : ODJJGNNCBPD<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HHPNLJHGEHL();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HJNCOOPPMNL(string GILKBBJEFIL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JPNOMJJFPOJ : MPEINBDDINL<KFCPMCHPDCP>, ODJJGNNCBPD<KFCPMCHPDCP>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7838F00", Offset = "0x7838300", VA = "0x187838F00", Slot = "4")]
	public IEnumerable<(KFCPMCHPDCP, string)> HHPNLJHGEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "5")]
	public string HJNCOOPPMNL(string GILKBBJEFIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x78E41A0", Offset = "0x78E35A0", VA = "0x1878E41A0", Slot = "6")]
	public KFCPMCHPDCP EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return default(KFCPMCHPDCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public JPNOMJJFPOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AIGNNLDAHIO<TModern> : PIBHMOCPPJE<TModern>, ODJJGNNCBPD<TModern> where TModern : IEquatable<TModern>, MDKKLDNPMCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> LPOIMOCGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DHMPCJGMMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MPEINBDDINL<TModern> CGCGOIKPAAP;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x41DE440", Offset = "0x41DD840", VA = "0x1841DE440")]
	public AIGNNLDAHIO(MPEINBDDINL<TModern> CGCGOIKPAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x41DA800", Offset = "0x41D9C00", VA = "0x1841DA800", Slot = "5")]
	public TModern EHHBIPLJHBD(string GILKBBJEFIL)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41DBB20", Offset = "0x41DAF20", VA = "0x1841DBB20", Slot = "4")]
	public string IMAKADIJCOP(TModern KPJCDGFNKHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ONOEGHJKDHF : PLDNGFNJBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private AIGNNLDAHIO<FKEBAHOJOEH> EOEDGFMGJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private AIGNNLDAHIO<KPAAJPHOOAN> KLEKPPCBDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AIGNNLDAHIO<MLPEKEOBFJJ> MKJENDNBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private AIGNNLDAHIO<KFCPMCHPDCP> OBDGCEAOMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private AIGNNLDAHIO<DOPNIDFJPBN> FIPAFLMKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private AIGNNLDAHIO<GHOPLCAKCFO> BILAPLCEIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private AIGNNLDAHIO<DKCADIBAFHB> BEEDGDJHPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private AIGNNLDAHIO<LGEDBJMHMNA> NFPAMPJMMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private AIGNNLDAHIO<DPJDJGPLJGE> DPCFAOHPDGB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PIBHMOCPPJE<FKEBAHOJOEH> GKBKMBPFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PIBHMOCPPJE<KPAAJPHOOAN> MBPKNMCHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PIBHMOCPPJE<MLPEKEOBFJJ> OCMICIHIAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PIBHMOCPPJE<DOPNIDFJPBN> KEKCLKHFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public PIBHMOCPPJE<GHOPLCAKCFO> IMKFEEFNLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PIBHMOCPPJE<DKCADIBAFHB> PKJLMNJAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public PIBHMOCPPJE<LGEDBJMHMNA> PMDEIGBHNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public PIBHMOCPPJE<DPJDJGPLJGE> IPHHKHDIMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x78F6370", Offset = "0x78F5770", VA = "0x1878F6370")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	[UsedImplicitly]
	internal static void FAMCDKJJNOL(CGJHFFGEHKC AEBJKCFPLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x78F63E0", Offset = "0x78F57E0", VA = "0x1878F63E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ONOEGHJKDHF()
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
