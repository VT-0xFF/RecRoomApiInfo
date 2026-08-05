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
		[Cpp2IlInjected.Address(RVA = "0x7B445B0", Offset = "0x7B437B0", VA = "0x187B445B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BCMDJJNHADH : ONBDNIOJJIC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex BOLOOAAGNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CNMCLAGJJKN EMCCLPHOODL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B365D0", Offset = "0x7B357D0", VA = "0x187B365D0")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	[UsedImplicitly]
	internal static void BHMHEMCKFJH(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B36E50", Offset = "0x7B36050", VA = "0x187B36E50")]
	[UsedImplicitly]
	internal static void PMPEPIDEEGA(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	[RecRoom.NoEngine.Common.Preserve]
	public BCMDJJNHADH([FMJHJHHALCB(null)] CNMCLAGJJKN EMCCLPHOODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B36B10", Offset = "0x7B35D10", VA = "0x187B36B10", Slot = "4")]
	public string LKDLAIOBOFF(PFMDOPPHAKG DFKGLBJBJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B36640", Offset = "0x7B35840", VA = "0x187B36640", Slot = "5")]
	public PFMDOPPHAKG LAEIJKNHIPI(string DFKGLBJBJGD)
	{
		return default(PFMDOPPHAKG);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, GHLPHAHIDFB
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
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public KFNFGKAFGLE LAEIJKNHIPI()
		{
			return default(KFNFGKAFGLE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedAvatarItemId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B43A80", Offset = "0x7B42C80", VA = "0x187B43A80", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B40", Offset = "0x7B42D40", VA = "0x187B43B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, GHLPHAHIDFB
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
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public FKHLDIGBEOP LAEIJKNHIPI()
		{
			return default(FKHLDIGBEOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedBodyShapeId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B43BB0", Offset = "0x7B42DB0", VA = "0x187B43BB0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B43C50", Offset = "0x7B42E50", VA = "0x187B43C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, GHLPHAHIDFB
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
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public OLKPCCCMIKF LAEIJKNHIPI()
		{
			return default(OLKPCCCMIKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedColorId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedColorId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43CC0", Offset = "0x7B42EC0", VA = "0x187B43CC0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B43D60", Offset = "0x7B42F60", VA = "0x187B43D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, GHLPHAHIDFB, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB00AB0", Offset = "0xAFFCB0", VA = "0x180B00AB0")]
		public FLOHLNJAHJB LAEIJKNHIPI()
		{
			return default(FLOHLNJAHJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x79D0350", Offset = "0x79CF550", VA = "0x1879D0350", Slot = "4")]
		public bool Equals(SerializedCombinationId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B43DD0", Offset = "0x7B42FD0", VA = "0x187B43DD0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedCombinationId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B43E90", Offset = "0x7B43090", VA = "0x187B43E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B43E80", Offset = "0x7B43080", VA = "0x187B43E80", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, GHLPHAHIDFB
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
		[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
		public SerializedCustomAvatarItemId(Guid IBPGMNEANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F00", Offset = "0x7B43100", VA = "0x187B43F00", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20")]
		public static bool CCHBIHOFELC(SerializedCustomAvatarItemId LFOFDHEGDLC, SerializedCustomAvatarItemId KMPLOMOLJCO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B43FA0", Offset = "0x7B431A0", VA = "0x187B43FA0")]
		public static bool IMFBACMHPLD(SerializedCustomAvatarItemId LFOFDHEGDLC, SerializedCustomAvatarItemId KMPLOMOLJCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B43FC0", Offset = "0x7B431C0", VA = "0x187B43FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, GHLPHAHIDFB
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

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B440D0", Offset = "0x7B432D0", VA = "0x187B440D0")]
		public static SerializedEquipmentSkinId FNHKHDKMIBC()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public DEBJIGNILIH LAEIJKNHIPI()
		{
			return default(DEBJIGNILIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B44030", Offset = "0x7B43230", VA = "0x187B44030", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B44100", Offset = "0x7B43300", VA = "0x187B44100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, GHLPHAHIDFB
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

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public IFNONIKJIIN LAEIJKNHIPI()
		{
			return default(IFNONIKJIIN);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B44170", Offset = "0x7B43370", VA = "0x187B44170", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B44210", Offset = "0x7B43410", VA = "0x187B44210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, GHLPHAHIDFB
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

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public HEBNHOMKAPM LAEIJKNHIPI()
		{
			return default(HEBNHOMKAPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedFaceShapeId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B44280", Offset = "0x7B43480", VA = "0x187B44280", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B44320", Offset = "0x7B43520", VA = "0x187B44320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, GHLPHAHIDFB
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

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public BAGALCLENMK LAEIJKNHIPI()
		{
			return default(BAGALCLENMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20", Slot = "4")]
		public bool Equals(SerializedHairPatternId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B44390", Offset = "0x7B43590", VA = "0x187B44390", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B43B20", Offset = "0x7B42D20", VA = "0x187B43B20")]
		public static bool CCHBIHOFELC(SerializedHairPatternId LFOFDHEGDLC, SerializedHairPatternId KMPLOMOLJCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B44430", Offset = "0x7B43630", VA = "0x187B44430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, GHLPHAHIDFB
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

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0", Slot = "6")]
		public Guid MBMDCHCHBOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79D0350", Offset = "0x79CF550", VA = "0x1879D0350", Slot = "4")]
		public bool Equals(SerializedMaterialId JAINJPLCLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B444A0", Offset = "0x7B436A0", VA = "0x187B444A0", Slot = "0")]
		public override bool Equals(object LCACGJDNDHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70B96E0", Offset = "0x70B88E0", VA = "0x1870B96E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0", Slot = "5")]
		public int CompareTo(SerializedMaterialId JAINJPLCLDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B44540", Offset = "0x7B43740", VA = "0x187B44540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NJOMMNPDCPN : CNMCLAGJJKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NJOMMNPDCPN CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B433C0", Offset = "0x7B425C0", VA = "0x187B433C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LNKDLEOEFBN<KFNFGKAFGLE> KHCMGGNEADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B43540", Offset = "0x7B42740", VA = "0x187B43540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LNKDLEOEFBN<DEBJIGNILIH> JNNGLGGAGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B43360", Offset = "0x7B42560", VA = "0x187B43360", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LNKDLEOEFBN<BAGALCLENMK> FNPLBNLFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B43600", Offset = "0x7B42800", VA = "0x187B43600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LNKDLEOEFBN<FLOHLNJAHJB> JDLMOFFIGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B434E0", Offset = "0x7B426E0", VA = "0x187B434E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LNKDLEOEFBN<OLKPCCCMIKF> ENAPNLJHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B43480", Offset = "0x7B42680", VA = "0x187B43480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LNKDLEOEFBN<HEBNHOMKAPM> PGEBJAKOLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7B43420", Offset = "0x7B42620", VA = "0x187B43420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNKDLEOEFBN<FKHLDIGBEOP> AHAMBCIIFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7B435A0", Offset = "0x7B427A0", VA = "0x187B435A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LNKDLEOEFBN<IFNONIKJIIN> LPCLLALFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B43300", Offset = "0x7B42500", VA = "0x187B43300", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HEMHOFEJMFM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AB50", Offset = "0x7B39D50", VA = "0x187B3AB50")]
	public static Guid CEDGKANEIJD(string FBBEOFENAAO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AC00", Offset = "0x7B39E00", VA = "0x187B3AC00")]
	public static bool JBJNIIPPAPN(string FBBEOFENAAO, [Out] Guid IBPGMNEANFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ANLHDPJGEIN : FAKDEMALLJG<KFNFGKAFGLE>, JGGBNBCOJGO<KFNFGKAFGLE>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B31980", Offset = "0x7B30B80", VA = "0x187B31980", Slot = "4")]
	public IEnumerable<(KFNFGKAFGLE, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B31960", Offset = "0x7B30B60", VA = "0x187B31960", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public KFNFGKAFGLE AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(KFNFGKAFGLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ANLHDPJGEIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KPBIFIOIFEF : FAKDEMALLJG<FKHLDIGBEOP>, JGGBNBCOJGO<FKHLDIGBEOP>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B350", Offset = "0x7B3A550", VA = "0x187B3B350", Slot = "4")]
	public IEnumerable<(FKHLDIGBEOP, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public FKHLDIGBEOP AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(FKHLDIGBEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KPBIFIOIFEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BLGHNAHFAGA : FAKDEMALLJG<OLKPCCCMIKF>, JGGBNBCOJGO<OLKPCCCMIKF>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B36F50", Offset = "0x7B36150", VA = "0x187B36F50", Slot = "4")]
	public IEnumerable<(OLKPCCCMIKF, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public OLKPCCCMIKF AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(OLKPCCCMIKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public BLGHNAHFAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CCNKDAOPOKB : FAKDEMALLJG<FLOHLNJAHJB>, JGGBNBCOJGO<FLOHLNJAHJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JGGBNBCOJGO<EMCONOFBEMC> EDNBIKCEKNA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public CCNKDAOPOKB(JGGBNBCOJGO<EMCONOFBEMC> EDNBIKCEKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79D0F90", Offset = "0x79D0190", VA = "0x1879D0F90", Slot = "4")]
	public IEnumerable<(FLOHLNJAHJB, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B39010", Offset = "0x7B38210", VA = "0x187B39010", Slot = "6")]
	public FLOHLNJAHJB AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(FLOHLNJAHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B39250", Offset = "0x7B38450", VA = "0x187B39250", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MCDNMOEILGC : FAKDEMALLJG<DEBJIGNILIH>, JGGBNBCOJGO<DEBJIGNILIH>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B3B6F0", Offset = "0x7B3A8F0", VA = "0x187B3B6F0", Slot = "4")]
	public IEnumerable<(DEBJIGNILIH, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public DEBJIGNILIH AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(DEBJIGNILIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public MCDNMOEILGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GFIAPCOCOGL : FAKDEMALLJG<IFNONIKJIIN>, JGGBNBCOJGO<IFNONIKJIIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B39290", Offset = "0x7B38490", VA = "0x187B39290", Slot = "4")]
	public IEnumerable<(IFNONIKJIIN, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public IFNONIKJIIN AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(IFNONIKJIIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public GFIAPCOCOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NKMHIEIOHOK : FAKDEMALLJG<HEBNHOMKAPM>, JGGBNBCOJGO<HEBNHOMKAPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B43660", Offset = "0x7B42860", VA = "0x187B43660", Slot = "4")]
	public IEnumerable<(HEBNHOMKAPM, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public HEBNHOMKAPM AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(HEBNHOMKAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public NKMHIEIOHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KEOJBEGAMBK : FAKDEMALLJG<BAGALCLENMK>, JGGBNBCOJGO<BAGALCLENMK>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3ACD0", Offset = "0x7B39ED0", VA = "0x187B3ACD0", Slot = "4")]
	public IEnumerable<(BAGALCLENMK, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public BAGALCLENMK AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(BAGALCLENMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KEOJBEGAMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FAKDEMALLJG<TModern> : JGGBNBCOJGO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LIBBEBLGLFK();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HPLDPGHFEGH(string NJJJMPFFCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HBMPACMPLEM : FAKDEMALLJG<EMCONOFBEMC>, JGGBNBCOJGO<EMCONOFBEMC>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7A860B0", Offset = "0x7A852B0", VA = "0x187A860B0", Slot = "4")]
	public IEnumerable<(EMCONOFBEMC, string)> LIBBEBLGLFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9CFE0", VA = "0x180C9DDE0", Slot = "5")]
	public string HPLDPGHFEGH(string NJJJMPFFCLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B318A0", Offset = "0x7B30AA0", VA = "0x187B318A0", Slot = "6")]
	public EMCONOFBEMC AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return default(EMCONOFBEMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public HBMPACMPLEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KGCENKEJEHC<TModern> : LNKDLEOEFBN<TModern>, JGGBNBCOJGO<TModern> where TModern : IEquatable<TModern>, GHLPHAHIDFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> NIOLMKNDNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DOFFNEABKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FAKDEMALLJG<TModern> FNDIHNCOMKM;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4932870", Offset = "0x4931A70", VA = "0x184932870")]
	public KGCENKEJEHC(FAKDEMALLJG<TModern> FNDIHNCOMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x492F350", Offset = "0x492E550", VA = "0x18492F350", Slot = "5")]
	public TModern AOHFPECIEAL(string NJJJMPFFCLA)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x492FED0", Offset = "0x492F0D0", VA = "0x18492FED0", Slot = "4")]
	public string GDCIFHIKKIF(TModern OHGJCNJJKAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AAGJFBKGIMO : CNMCLAGJJKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KGCENKEJEHC<KFNFGKAFGLE> OJGDEHBGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KGCENKEJEHC<DEBJIGNILIH> OCBOPJPEAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KGCENKEJEHC<BAGALCLENMK> JPKFAJHCKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KGCENKEJEHC<EMCONOFBEMC> EDNBIKCEKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KGCENKEJEHC<FLOHLNJAHJB> JDICMCFLKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KGCENKEJEHC<OLKPCCCMIKF> NHBFOIJGFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KGCENKEJEHC<HEBNHOMKAPM> ONOFHHHMBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KGCENKEJEHC<FKHLDIGBEOP> MIEELBAKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KGCENKEJEHC<IFNONIKJIIN> EKLBFEGBMEG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LNKDLEOEFBN<KFNFGKAFGLE> KHCMGGNEADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LNKDLEOEFBN<DEBJIGNILIH> JNNGLGGAGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LNKDLEOEFBN<BAGALCLENMK> FNPLBNLFOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LNKDLEOEFBN<FLOHLNJAHJB> JDLMOFFIGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LNKDLEOEFBN<OLKPCCCMIKF> ENAPNLJHNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LNKDLEOEFBN<HEBNHOMKAPM> PGEBJAKOLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LNKDLEOEFBN<FKHLDIGBEOP> AHAMBCIIFAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LNKDLEOEFBN<IFNONIKJIIN> LPCLLALFNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7B31350", Offset = "0x7B30550", VA = "0x187B31350")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	[UsedImplicitly]
	internal static void NINIBBDHOGI(JBPONICDCIO FJGJKHFLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B313C0", Offset = "0x7B305C0", VA = "0x187B313C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public AAGJFBKGIMO()
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
