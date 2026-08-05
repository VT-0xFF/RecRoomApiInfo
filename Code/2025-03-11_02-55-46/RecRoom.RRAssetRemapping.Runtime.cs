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
		[Cpp2IlInjected.Address(RVA = "0x7F7BA20", Offset = "0x7F7AE20", VA = "0x187F7BA20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LDPDLHHAIGK : LIPJIIDPCCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex PEGBECONIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly AALNDNADIPN FNOMGDENIIC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A2B0", Offset = "0x7F796B0", VA = "0x187F7A2B0")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	[UsedImplicitly]
	internal static void PPNAAKNMPKA(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F79A50", Offset = "0x7F78E50", VA = "0x187F79A50")]
	[UsedImplicitly]
	internal static void CNLOFMIMIFK(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	[RecRoom.NoEngine.Common.Preserve]
	public LDPDLHHAIGK([PNFCCJKFMBH(null)] AALNDNADIPN FNOMGDENIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F79AB0", Offset = "0x7F78EB0", VA = "0x187F79AB0", Slot = "4")]
	public string EFGCEHNIDJN(HEFHKNJHOBF NIPDIMDKGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F79DF0", Offset = "0x7F791F0", VA = "0x187F79DF0", Slot = "5")]
	public HEFHKNJHOBF NHMCOOCBIHH(string NIPDIMDKGGA)
	{
		return default(HEFHKNJHOBF);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public HOEDMLCMIIH NHMCOOCBIHH()
		{
			return default(HOEDMLCMIIH);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AEF0", Offset = "0x7F7A2F0", VA = "0x187F7AEF0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AFB0", Offset = "0x7F7A3B0", VA = "0x187F7AFB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public MBDMAMDEGNN NHMCOOCBIHH()
		{
			return default(MBDMAMDEGNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B020", Offset = "0x7F7A420", VA = "0x187F7B020", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B0C0", Offset = "0x7F7A4C0", VA = "0x187F7B0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public LBLHIKBBLBJ NHMCOOCBIHH()
		{
			return default(LBLHIKBBLBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedColorId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedColorId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B130", Offset = "0x7F7A530", VA = "0x187F7B130", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B1D0", Offset = "0x7F7A5D0", VA = "0x187F7B1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, COENILANACJ, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0")]
		public APAOJHILPJK NHMCOOCBIHH()
		{
			return default(APAOJHILPJK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E06BF0", Offset = "0x7E05FF0", VA = "0x187E06BF0", Slot = "4")]
		public bool Equals(SerializedCombinationId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B240", Offset = "0x7F7A640", VA = "0x187F7B240", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedCombinationId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B300", Offset = "0x7F7A700", VA = "0x187F7B300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B2F0", Offset = "0x7F7A6F0", VA = "0x187F7B2F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EEE0", Offset = "0x109E2E0", VA = "0x18109EEE0")]
		public SerializedCustomAvatarItemId(Guid BCIHOIBCNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public static SerializedCustomAvatarItemId BBLICCBFFEL(Guid BCIHOIBCNMJ)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B370", Offset = "0x7F7A770", VA = "0x187F7B370", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90")]
		public static bool JECEAGOPPKI(SerializedCustomAvatarItemId BBGKOKBOEGA, SerializedCustomAvatarItemId NBNHMPFPBPM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B410", Offset = "0x7F7A810", VA = "0x187F7B410")]
		public static bool NEBBLIKBPGD(SerializedCustomAvatarItemId BBGKOKBOEGA, SerializedCustomAvatarItemId NBNHMPFPBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B430", Offset = "0x7F7A830", VA = "0x187F7B430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x7F7B540", Offset = "0x7F7A940", VA = "0x187F7B540")]
		public static SerializedEquipmentSkinId PNFPCDCKMIG()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public HMEIINLNNMC NHMCOOCBIHH()
		{
			return default(HMEIINLNNMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B4A0", Offset = "0x7F7A8A0", VA = "0x187F7B4A0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B570", Offset = "0x7F7A970", VA = "0x187F7B570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public AFEABOIFMLA NHMCOOCBIHH()
		{
			return default(AFEABOIFMLA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B5E0", Offset = "0x7F7A9E0", VA = "0x187F7B5E0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B680", Offset = "0x7F7AA80", VA = "0x187F7B680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public BFMALJPIEON NHMCOOCBIHH()
		{
			return default(BFMALJPIEON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B6F0", Offset = "0x7F7AAF0", VA = "0x187F7B6F0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B790", Offset = "0x7F7AB90", VA = "0x187F7B790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0")]
		public LACLLNIICDF NHMCOOCBIHH()
		{
			return default(LACLLNIICDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90", Slot = "4")]
		public bool Equals(SerializedHairPatternId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B800", Offset = "0x7F7AC00", VA = "0x187F7B800", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7AF90", Offset = "0x7F7A390", VA = "0x187F7AF90")]
		public static bool JECEAGOPPKI(SerializedHairPatternId BBGKOKBOEGA, SerializedHairPatternId NBNHMPFPBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B8A0", Offset = "0x7F7ACA0", VA = "0x187F7B8A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, COENILANACJ
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
		[Cpp2IlInjected.Address(RVA = "0x109EED0", Offset = "0x109E2D0", VA = "0x18109EED0", Slot = "6")]
		public Guid CPHKICCJAMP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E06BF0", Offset = "0x7E05FF0", VA = "0x187E06BF0", Slot = "4")]
		public bool Equals(SerializedMaterialId MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B910", Offset = "0x7F7AD10", VA = "0x187F7B910", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74776C0", Offset = "0x7476AC0", VA = "0x1874776C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7477530", Offset = "0x7476930", VA = "0x187477530", Slot = "5")]
		public int CompareTo(SerializedMaterialId MNALNBMKJLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F7B9B0", Offset = "0x7F7ADB0", VA = "0x187F7B9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OKJBHKKHGKJ : AALNDNADIPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OKJBHKKHGKJ AJPLFLPAHGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A660", Offset = "0x7F79A60", VA = "0x187F7A660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DGEJEGPCHIG<HOEDMLCMIIH> BDALHFGIJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A5A0", Offset = "0x7F799A0", VA = "0x187F7A5A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DGEJEGPCHIG<HMEIINLNNMC> MGEBNMHGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A3C0", Offset = "0x7F797C0", VA = "0x187F7A3C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DGEJEGPCHIG<LACLLNIICDF> IDFEBCMCLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A600", Offset = "0x7F79A00", VA = "0x187F7A600", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DGEJEGPCHIG<APAOJHILPJK> OOMKJFHDDJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A4E0", Offset = "0x7F798E0", VA = "0x187F7A4E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DGEJEGPCHIG<LBLHIKBBLBJ> JDIBGBKBALO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A420", Offset = "0x7F79820", VA = "0x187F7A420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DGEJEGPCHIG<BFMALJPIEON> DGHDHIHMOON
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A6C0", Offset = "0x7F79AC0", VA = "0x187F7A6C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DGEJEGPCHIG<MBDMAMDEGNN> KDAHCOFCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A540", Offset = "0x7F79940", VA = "0x187F7A540", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DGEJEGPCHIG<AFEABOIFMLA> ELMLLFPLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A480", Offset = "0x7F79880", VA = "0x187F7A480", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AGMBMABMAOA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F687D0", Offset = "0x7F67BD0", VA = "0x187F687D0")]
	public static Guid HLEJOFMNPIK(string CPLNNDGBPDP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F68880", Offset = "0x7F67C80", VA = "0x187F68880")]
	public static bool HOOJKBAFDGH(string CPLNNDGBPDP, [Out] Guid BCIHOIBCNMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDPHPOAKKGB : OMKEBOCPFLE<HOEDMLCMIIH>, EGKLNLKIHID<HOEDMLCMIIH>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B590", Offset = "0x7F6A990", VA = "0x187F6B590", Slot = "4")]
	public IEnumerable<(HOEDMLCMIIH, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B570", Offset = "0x7F6A970", VA = "0x187F6B570", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public HOEDMLCMIIH FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(HOEDMLCMIIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public EDPHPOAKKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HCIICCGCHJN : OMKEBOCPFLE<MBDMAMDEGNN>, EGKLNLKIHID<MBDMAMDEGNN>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F701E0", Offset = "0x7F6F5E0", VA = "0x187F701E0", Slot = "4")]
	public IEnumerable<(MBDMAMDEGNN, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public MBDMAMDEGNN FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(MBDMAMDEGNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HCIICCGCHJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AOLPBEJNHOK : OMKEBOCPFLE<LBLHIKBBLBJ>, EGKLNLKIHID<LBLHIKBBLBJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F68A10", Offset = "0x7F67E10", VA = "0x187F68A10", Slot = "4")]
	public IEnumerable<(LBLHIKBBLBJ, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public LBLHIKBBLBJ FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(LBLHIKBBLBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AOLPBEJNHOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PFCMJLMDDJO : OMKEBOCPFLE<APAOJHILPJK>, EGKLNLKIHID<APAOJHILPJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly EGKLNLKIHID<MHNIFPENILI> LMMHHAENDEE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
	public PFCMJLMDDJO(EGKLNLKIHID<MHNIFPENILI> LMMHHAENDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E08410", Offset = "0x7E07810", VA = "0x187E08410", Slot = "4")]
	public IEnumerable<(APAOJHILPJK, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7ACB0", Offset = "0x7F7A0B0", VA = "0x187F7ACB0", Slot = "6")]
	public APAOJHILPJK FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(APAOJHILPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AC70", Offset = "0x7F7A070", VA = "0x187F7AC70", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ILACMPMNCGA : OMKEBOCPFLE<HMEIINLNNMC>, EGKLNLKIHID<HMEIINLNNMC>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F70580", Offset = "0x7F6F980", VA = "0x187F70580", Slot = "4")]
	public IEnumerable<(HMEIINLNNMC, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public HMEIINLNNMC FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(HMEIINLNNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public ILACMPMNCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IMMOEMECBNN : OMKEBOCPFLE<AFEABOIFMLA>, EGKLNLKIHID<AFEABOIFMLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F78190", Offset = "0x7F77590", VA = "0x187F78190", Slot = "4")]
	public IEnumerable<(AFEABOIFMLA, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public AFEABOIFMLA FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(AFEABOIFMLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public IMMOEMECBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DAONJEJNOCD : OMKEBOCPFLE<BFMALJPIEON>, EGKLNLKIHID<BFMALJPIEON>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F6B150", Offset = "0x7F6A550", VA = "0x187F6B150", Slot = "4")]
	public IEnumerable<(BFMALJPIEON, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public BFMALJPIEON FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(BFMALJPIEON);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public DAONJEJNOCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BLEDGMGKOPM : OMKEBOCPFLE<LACLLNIICDF>, EGKLNLKIHID<LACLLNIICDF>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6AAD0", Offset = "0x7F69ED0", VA = "0x187F6AAD0", Slot = "4")]
	public IEnumerable<(LACLLNIICDF, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public LACLLNIICDF FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(LACLLNIICDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BLEDGMGKOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OMKEBOCPFLE<TModern> : EGKLNLKIHID<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> GHDCDOMBNJF();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CCPDDHOMAFA(string KLAENBKEMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OPGPLFFCAFO : OMKEBOCPFLE<MHNIFPENILI>, EGKLNLKIHID<MHNIFPENILI>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7EBD530", Offset = "0x7EBC930", VA = "0x187EBD530", Slot = "4")]
	public IEnumerable<(MHNIFPENILI, string)> GHDCDOMBNJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD03D20", Offset = "0xD03120", VA = "0x180D03D20", Slot = "5")]
	public string CCPDDHOMAFA(string KLAENBKEMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F68950", Offset = "0x7F67D50", VA = "0x187F68950", Slot = "6")]
	public MHNIFPENILI FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return default(MHNIFPENILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public OPGPLFFCAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ALLOBBBDHAF<TModern> : DGEJEGPCHIG<TModern>, EGKLNLKIHID<TModern> where TModern : IEquatable<TModern>, COENILANACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> NADLMPMIOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> GPBGIGFKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OMKEBOCPFLE<TModern> JDOCJKAPPGN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x473B680", Offset = "0x473AA80", VA = "0x18473B680")]
	public ALLOBBBDHAF(OMKEBOCPFLE<TModern> JDOCJKAPPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4739870", Offset = "0x4738C70", VA = "0x184739870", Slot = "5")]
	public TModern FLCFKDGAOCK(string KLAENBKEMCB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x473A200", Offset = "0x4739600", VA = "0x18473A200", Slot = "4")]
	public string LMHAMOHIOIL(TModern EMPEOMJHBOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PBIGHLBCMDD : AALNDNADIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private ALLOBBBDHAF<HOEDMLCMIIH> LCDFIGHKLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private ALLOBBBDHAF<HMEIINLNNMC> LKMCKHALNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ALLOBBBDHAF<LACLLNIICDF> BODFIKIKBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private ALLOBBBDHAF<MHNIFPENILI> LMMHHAENDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private ALLOBBBDHAF<APAOJHILPJK> PKIFPBBCIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private ALLOBBBDHAF<LBLHIKBBLBJ> LMNFFGDLMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private ALLOBBBDHAF<BFMALJPIEON> DBPBPPOCEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ALLOBBBDHAF<MBDMAMDEGNN> JGAGKPBLPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ALLOBBBDHAF<AFEABOIFMLA> EGFHKPOGJLP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DGEJEGPCHIG<HOEDMLCMIIH> BDALHFGIJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DGEJEGPCHIG<HMEIINLNNMC> MGEBNMHGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DGEJEGPCHIG<LACLLNIICDF> IDFEBCMCLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DGEJEGPCHIG<APAOJHILPJK> OOMKJFHDDJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DGEJEGPCHIG<LBLHIKBBLBJ> JDIBGBKBALO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DGEJEGPCHIG<BFMALJPIEON> DGHDHIHMOON
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DGEJEGPCHIG<MBDMAMDEGNN> KDAHCOFCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DGEJEGPCHIG<AFEABOIFMLA> ELMLLFPLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A720", Offset = "0x7F79B20", VA = "0x187F7A720")]
	[AEDFFNEEAKJ.AMNMLEGDOCC.LHJJLFEKIGK]
	[UsedImplicitly]
	internal static void HCFGACKFDEN(LEPFMCICNAK BFCIDAHLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A790", Offset = "0x7F79B90", VA = "0x187F7A790")]
	[RecRoom.NoEngine.Common.Preserve]
	public PBIGHLBCMDD()
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
