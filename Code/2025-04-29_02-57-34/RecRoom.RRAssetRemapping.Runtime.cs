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
		[Cpp2IlInjected.Address(RVA = "0x84BF230", Offset = "0x84BE630", VA = "0x1884BF230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HKJEGALAAND : NCEJBDJKGCK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex GHIPDDFPJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MBKECGGBKFN PBEPNNPJPBL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84BBA30", Offset = "0x84BAE30", VA = "0x1884BBA30")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	[UsedImplicitly]
	internal static void BIBAMGIFFDO(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84BBF70", Offset = "0x84BB370", VA = "0x1884BBF70")]
	[UsedImplicitly]
	internal static void IMIHBNJCFAB(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	[RecRoom.NoEngine.Common.Preserve]
	public HKJEGALAAND([MGCCDFKFGBG(null)] MBKECGGBKFN PBEPNNPJPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84BBFD0", Offset = "0x84BB3D0", VA = "0x1884BBFD0", Slot = "4")]
	public string PEGKBLBFNLH(BBFALMJKFCO EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84BBAA0", Offset = "0x84BAEA0", VA = "0x1884BBAA0", Slot = "5")]
	public BBFALMJKFCO ILOIKAMJPOD(string EOMFNMMGCEC)
	{
		return default(BBFALMJKFCO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public BKGBLAEFKKI ILOIKAMJPOD()
		{
			return default(BKGBLAEFKKI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedAvatarItemId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84BE6F0", Offset = "0x84BDAF0", VA = "0x1884BE6F0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84BE7B0", Offset = "0x84BDBB0", VA = "0x1884BE7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public KODNMIGJFEI ILOIKAMJPOD()
		{
			return default(KODNMIGJFEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedBodyShapeId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84BE820", Offset = "0x84BDC20", VA = "0x1884BE820", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84BE8C0", Offset = "0x84BDCC0", VA = "0x1884BE8C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public CJINAFCJHOI ILOIKAMJPOD()
		{
			return default(CJINAFCJHOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedColorId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedColorId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84BE930", Offset = "0x84BDD30", VA = "0x1884BE930", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84BE9D0", Offset = "0x84BDDD0", VA = "0x1884BE9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, KGIFCIOKMHM, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
		public BCAJBMEKGPP ILOIKAMJPOD()
		{
			return default(BCAJBMEKGPP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x834A810", Offset = "0x8349C10", VA = "0x18834A810", Slot = "4")]
		public bool Equals(SerializedCombinationId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84BEA40", Offset = "0x84BDE40", VA = "0x1884BEA40", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedCombinationId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84BEB00", Offset = "0x84BDF00", VA = "0x1884BEB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84BEAF0", Offset = "0x84BDEF0", VA = "0x1884BEAF0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x11971F0", Offset = "0x11965F0", VA = "0x1811971F0")]
		public SerializedCustomAvatarItemId(Guid FIAGFFPOAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public static SerializedCustomAvatarItemId BKGANGNPOAF(Guid FIAGFFPOAHP)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84BEB70", Offset = "0x84BDF70", VA = "0x1884BEB70", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790")]
		public static bool HGJBAFCOLON(SerializedCustomAvatarItemId BGDONNBGCJK, SerializedCustomAvatarItemId DKEKGDBAIOE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84BEC10", Offset = "0x84BE010", VA = "0x1884BEC10")]
		public static bool PBNEENGPCHJ(SerializedCustomAvatarItemId BGDONNBGCJK, SerializedCustomAvatarItemId DKEKGDBAIOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84BEC30", Offset = "0x84BE030", VA = "0x1884BEC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x84BED40", Offset = "0x84BE140", VA = "0x1884BED40")]
		public static SerializedEquipmentSkinId FHDIMBEEJJC()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public OOHHMEDGGOO ILOIKAMJPOD()
		{
			return default(OOHHMEDGGOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84BECA0", Offset = "0x84BE0A0", VA = "0x1884BECA0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84BED70", Offset = "0x84BE170", VA = "0x1884BED70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public CEIANKIDECD ILOIKAMJPOD()
		{
			return default(CEIANKIDECD);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84BEDE0", Offset = "0x84BE1E0", VA = "0x1884BEDE0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84BEE80", Offset = "0x84BE280", VA = "0x1884BEE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public HKFNMLCCPDK ILOIKAMJPOD()
		{
			return default(HKFNMLCCPDK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedFaceShapeId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84BEEF0", Offset = "0x84BE2F0", VA = "0x1884BEEF0", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84BEF90", Offset = "0x84BE390", VA = "0x1884BEF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200")]
		public MBDBBLGDPFC ILOIKAMJPOD()
		{
			return default(MBDBBLGDPFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790", Slot = "4")]
		public bool Equals(SerializedHairPatternId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84BF000", Offset = "0x84BE400", VA = "0x1884BF000", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84BE790", Offset = "0x84BDB90", VA = "0x1884BE790")]
		public static bool HGJBAFCOLON(SerializedHairPatternId BGDONNBGCJK, SerializedHairPatternId DKEKGDBAIOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84BF0A0", Offset = "0x84BE4A0", VA = "0x1884BF0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, KGIFCIOKMHM
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
		[Cpp2IlInjected.Address(RVA = "0x1197200", Offset = "0x1196600", VA = "0x181197200", Slot = "6")]
		public Guid ODNFDMKDAHN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x834A810", Offset = "0x8349C10", VA = "0x18834A810", Slot = "4")]
		public bool Equals(SerializedMaterialId DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84BF110", Offset = "0x84BE510", VA = "0x1884BF110", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x797D870", Offset = "0x797CC70", VA = "0x18797D870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x797D6E0", Offset = "0x797CAE0", VA = "0x18797D6E0", Slot = "5")]
		public int CompareTo(SerializedMaterialId DMMBOHMLHLF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84BF1C0", Offset = "0x84BE5C0", VA = "0x1884BF1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AFEELHGADIP : MBKECGGBKFN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AFEELHGADIP IADGMEFIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84AC200", Offset = "0x84AB600", VA = "0x1884AC200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NHOAKMKCFGJ<BKGBLAEFKKI> ABJMAPDMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84AC1A0", Offset = "0x84AB5A0", VA = "0x1884AC1A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NHOAKMKCFGJ<OOHHMEDGGOO> MHGPBOKLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84AC020", Offset = "0x84AB420", VA = "0x1884AC020", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NHOAKMKCFGJ<MBDBBLGDPFC> JJMFPBBOJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84ABFC0", Offset = "0x84AB3C0", VA = "0x1884ABFC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NHOAKMKCFGJ<BCAJBMEKGPP> EIFHDOLGINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84AC260", Offset = "0x84AB660", VA = "0x1884AC260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NHOAKMKCFGJ<CJINAFCJHOI> HCHHJCPCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84AC0E0", Offset = "0x84AB4E0", VA = "0x1884AC0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NHOAKMKCFGJ<HKFNMLCCPDK> HJLCPENMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84AC2C0", Offset = "0x84AB6C0", VA = "0x1884AC2C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NHOAKMKCFGJ<KODNMIGJFEI> KIHDGLPPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84AC140", Offset = "0x84AB540", VA = "0x1884AC140", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NHOAKMKCFGJ<CEIANKIDECD> CKNALPNDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84AC080", Offset = "0x84AB480", VA = "0x1884AC080", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LLNIKIJPIIJ
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x84BCB00", Offset = "0x84BBF00", VA = "0x1884BCB00")]
	public static Guid LPIEMNOPNBB(string LCGHJNJGLNJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA30", Offset = "0x84BBE30", VA = "0x1884BCA30")]
	public static bool GGNEPGHLLMG(string LCGHJNJGLNJ, [Out] Guid FIAGFFPOAHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EFLJKBLJNBC : INBCNPPPBOO<BKGBLAEFKKI>, ECOIMGDGOPJ<BKGBLAEFKKI>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84AC7A0", Offset = "0x84ABBA0", VA = "0x1884AC7A0", Slot = "4")]
	public IEnumerable<(BKGBLAEFKKI, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84AC780", Offset = "0x84ABB80", VA = "0x1884AC780", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public BKGBLAEFKKI MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(BKGBLAEFKKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public EFLJKBLJNBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CPHPJIHBJFH : INBCNPPPBOO<KODNMIGJFEI>, ECOIMGDGOPJ<KODNMIGJFEI>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x84AC320", Offset = "0x84AB720", VA = "0x1884AC320", Slot = "4")]
	public IEnumerable<(KODNMIGJFEI, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public KODNMIGJFEI MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(KODNMIGJFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public CPHPJIHBJFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FEPBCBFBNGP : INBCNPPPBOO<CJINAFCJHOI>, ECOIMGDGOPJ<CJINAFCJHOI>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84B13F0", Offset = "0x84B07F0", VA = "0x1884B13F0", Slot = "4")]
	public IEnumerable<(CJINAFCJHOI, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public CJINAFCJHOI MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(CJINAFCJHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FEPBCBFBNGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OPKJBBHHIEJ : INBCNPPPBOO<BCAJBMEKGPP>, ECOIMGDGOPJ<BCAJBMEKGPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly ECOIMGDGOPJ<NMLDFDLEOIG> BIMDLOMABMP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public OPKJBBHHIEJ(ECOIMGDGOPJ<NMLDFDLEOIG> BIMDLOMABMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x834BC00", Offset = "0x834B000", VA = "0x18834BC00", Slot = "4")]
	public IEnumerable<(BCAJBMEKGPP, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84BE4B0", Offset = "0x84BD8B0", VA = "0x1884BE4B0", Slot = "6")]
	public BCAJBMEKGPP MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(BCAJBMEKGPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84BE470", Offset = "0x84BD870", VA = "0x1884BE470", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HHLANGKICAP : INBCNPPPBOO<OOHHMEDGGOO>, ECOIMGDGOPJ<OOHHMEDGGOO>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84B3E20", Offset = "0x84B3220", VA = "0x1884B3E20", Slot = "4")]
	public IEnumerable<(OOHHMEDGGOO, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public OOHHMEDGGOO MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(OOHHMEDGGOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HHLANGKICAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NIMCBKCOOMD : INBCNPPPBOO<CEIANKIDECD>, ECOIMGDGOPJ<CEIANKIDECD>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84BCBB0", Offset = "0x84BBFB0", VA = "0x1884BCBB0", Slot = "4")]
	public IEnumerable<(CEIANKIDECD, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public CEIANKIDECD MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(CEIANKIDECD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NIMCBKCOOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HADGPDJLEOF : INBCNPPPBOO<HKFNMLCCPDK>, ECOIMGDGOPJ<HKFNMLCCPDK>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x84B3A00", Offset = "0x84B2E00", VA = "0x1884B3A00", Slot = "4")]
	public IEnumerable<(HKFNMLCCPDK, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public HKFNMLCCPDK MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(HKFNMLCCPDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HADGPDJLEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LIMBFCALDBJ : INBCNPPPBOO<MBDBBLGDPFC>, ECOIMGDGOPJ<MBDBBLGDPFC>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84BC3B0", Offset = "0x84BB7B0", VA = "0x1884BC3B0", Slot = "4")]
	public IEnumerable<(MBDBBLGDPFC, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public MBDBBLGDPFC MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(MBDBBLGDPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public LIMBFCALDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface INBCNPPPBOO<TModern> : ECOIMGDGOPJ<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> INCIMLPCCMA();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FKPIKOABDJC(string LHNHPLACIOA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KONMJCGMMBM : INBCNPPPBOO<NMLDFDLEOIG>, ECOIMGDGOPJ<NMLDFDLEOIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8400D20", Offset = "0x8400120", VA = "0x188400D20", Slot = "4")]
	public IEnumerable<(NMLDFDLEOIG, string)> INCIMLPCCMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "5")]
	public string FKPIKOABDJC(string LHNHPLACIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84AC6C0", Offset = "0x84ABAC0", VA = "0x1884AC6C0", Slot = "6")]
	public NMLDFDLEOIG MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return default(NMLDFDLEOIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KONMJCGMMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KNEPEIDKEJA<TModern> : NHOAKMKCFGJ<TModern>, ECOIMGDGOPJ<TModern> where TModern : IEquatable<TModern>, KGIFCIOKMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> KLPDCNAFGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IFLOFPEAOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly INBCNPPPBOO<TModern> HLAIICLCFDA;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E12970", Offset = "0x4E11D70", VA = "0x184E12970")]
	public KNEPEIDKEJA(INBCNPPPBOO<TModern> HLAIICLCFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E0FCA0", Offset = "0x4E0F0A0", VA = "0x184E0FCA0", Slot = "5")]
	public TModern MMFCPNBEKCO(string LHNHPLACIOA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E11360", Offset = "0x4E10760", VA = "0x184E11360", Slot = "4")]
	public string PNGEFPCJCHO(TModern BMKKPEAILEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GHCHHKOBMPK : MBKECGGBKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KNEPEIDKEJA<BKGBLAEFKKI> OJPADGAPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KNEPEIDKEJA<OOHHMEDGGOO> PLHMDNGHLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KNEPEIDKEJA<MBDBBLGDPFC> JBOFDPECJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KNEPEIDKEJA<NMLDFDLEOIG> BIMDLOMABMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KNEPEIDKEJA<BCAJBMEKGPP> NEDGPJLHBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KNEPEIDKEJA<CJINAFCJHOI> MLGCBNMFECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KNEPEIDKEJA<HKFNMLCCPDK> FOAHBPGGNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KNEPEIDKEJA<KODNMIGJFEI> LMDCGCDGCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KNEPEIDKEJA<CEIANKIDECD> EKGDAGOEBNE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NHOAKMKCFGJ<BKGBLAEFKKI> ABJMAPDMIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NHOAKMKCFGJ<OOHHMEDGGOO> MHGPBOKLFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NHOAKMKCFGJ<MBDBBLGDPFC> JJMFPBBOJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NHOAKMKCFGJ<BCAJBMEKGPP> EIFHDOLGINL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NHOAKMKCFGJ<CJINAFCJHOI> HCHHJCPCNDI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NHOAKMKCFGJ<HKFNMLCCPDK> HJLCPENMNLI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NHOAKMKCFGJ<KODNMIGJFEI> KIHDGLPPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NHOAKMKCFGJ<CEIANKIDECD> CKNALPNDGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84B34B0", Offset = "0x84B28B0", VA = "0x1884B34B0")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	[UsedImplicitly]
	internal static void JFPDPLCMAPE(NPCGGDCACLM MIOIJELPIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x84B3520", Offset = "0x84B2920", VA = "0x1884B3520")]
	[RecRoom.NoEngine.Common.Preserve]
	public GHCHHKOBMPK()
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
