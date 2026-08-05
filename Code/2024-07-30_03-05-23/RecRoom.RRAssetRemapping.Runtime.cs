using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AGHNLENMCPK : JJOGMOCPBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MOGBBIIMPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IIHHJNFJGAC PHFMADOPDOC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x727A150", Offset = "0x7278750", VA = "0x18727A150")]
	[ILMJIPMJHLC(IAFNNCJJPGN.GameOnly)]
	[UsedImplicitly]
	private static void GMLBGNJNKIA(GLOPJKBGAFG FDLKLBHIAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x727A0F0", Offset = "0x72786F0", VA = "0x18727A0F0")]
	[UsedImplicitly]
	[ILMJIPMJHLC(IAFNNCJJPGN.EditorOnly)]
	private static void ANECLNJJFED(GLOPJKBGAFG FDLKLBHIAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	[Preserve]
	public AGHNLENMCPK([JAMCDGPOOBO(null)] IIHHJNFJGAC PHFMADOPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x727A8A0", Offset = "0x7278EA0", VA = "0x18727A8A0", Slot = "4")]
	public string PEGIGFCKLEH(IIGFKAAIIHK BNBKMKBLLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x727A1C0", Offset = "0x72787C0", VA = "0x18727A1C0", Slot = "5")]
	public IIGFKAAIIHK OJPHNAHFOOE(string BNBKMKBLLLG)
	{
		return default(IIGFKAAIIHK);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, PKCEIIEOBOB
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

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
		public SerializedAvatarItemId(DIBKDMJIGJP DAIJJLLIENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public DIBKDMJIGJP OJPHNAHFOOE()
		{
			return default(DIBKDMJIGJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedAvatarItemId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x728CBB0", Offset = "0x728B1B0", VA = "0x18728CBB0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x728CC70", Offset = "0x728B270", VA = "0x18728CC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, PKCEIIEOBOB
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

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public FHOKKHPPPEG OJPHNAHFOOE()
		{
			return default(FHOKKHPPPEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedBodyShapeId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x728CCE0", Offset = "0x728B2E0", VA = "0x18728CCE0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x728CD80", Offset = "0x728B380", VA = "0x18728CD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, PKCEIIEOBOB
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

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public BGKFEPHCNAG OJPHNAHFOOE()
		{
			return default(BGKFEPHCNAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedColorId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedColorId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x728CDF0", Offset = "0x728B3F0", VA = "0x18728CDF0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x728CE90", Offset = "0x728B490", VA = "0x18728CE90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, PKCEIIEOBOB, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private SerializedMaterialId materialId1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private SerializedMaterialId materialId2;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x728D0B0", Offset = "0x728B6B0", VA = "0x18728D0B0")]
		public NAJCLKBNHFG OJPHNAHFOOE()
		{
			return default(NAJCLKBNHFG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x728D190", Offset = "0x728B790", VA = "0x18728D190")]
		public SerializedCombinationId(NAJCLKBNHFG JPJACOBFIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x728CF00", Offset = "0x728B500", VA = "0x18728CF00")]
		private void EDMDMCMLLDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x711B5E0", Offset = "0x7119BE0", VA = "0x18711B5E0", Slot = "4")]
		public bool Equals(SerializedCombinationId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x728D000", Offset = "0x728B600", VA = "0x18728D000", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedCombinationId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x728D120", Offset = "0x728B720", VA = "0x18728D120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x728D110", Offset = "0x728B710", VA = "0x18728D110", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, PKCEIIEOBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x728D260", Offset = "0x728B860", VA = "0x18728D260")]
		public static SerializedEquipmentSkinId PJALKEGGJDH()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public JFOHGLPGOKN OJPHNAHFOOE()
		{
			return default(JFOHGLPGOKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x728D1C0", Offset = "0x728B7C0", VA = "0x18728D1C0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x728D290", Offset = "0x728B890", VA = "0x18728D290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, PKCEIIEOBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public OMIIACJOJFJ OJPHNAHFOOE()
		{
			return default(OMIIACJOJFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x728D300", Offset = "0x728B900", VA = "0x18728D300", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x728D3A0", Offset = "0x728B9A0", VA = "0x18728D3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, PKCEIIEOBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public BPOGHOJNPIN OJPHNAHFOOE()
		{
			return default(BPOGHOJNPIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedFaceShapeId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x728D410", Offset = "0x728BA10", VA = "0x18728D410", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x728D4B0", Offset = "0x728BAB0", VA = "0x18728D4B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, PKCEIIEOBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public DKKCBBGFBGH OJPHNAHFOOE()
		{
			return default(DKKCBBGFBGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50", Slot = "4")]
		public bool Equals(SerializedHairPatternId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedHairPatternId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x728D520", Offset = "0x728BB20", VA = "0x18728D520", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x728CC50", Offset = "0x728B250", VA = "0x18728CC50")]
		public static bool FFOLOHFBIHN(SerializedHairPatternId CLMMPLJCADB, SerializedHairPatternId NIGNLACGOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x728D5C0", Offset = "0x728BBC0", VA = "0x18728D5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, PKCEIIEOBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
		public SerializedMaterialId(PLPLILKLPID DAIJJLLIENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0", Slot = "6")]
		public Guid AAIOOOLAJIF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public PLPLILKLPID OJPHNAHFOOE()
		{
			return default(PLPLILKLPID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x711B5E0", Offset = "0x7119BE0", VA = "0x18711B5E0", Slot = "4")]
		public bool Equals(SerializedMaterialId BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x728D630", Offset = "0x728BC30", VA = "0x18728D630", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xABF9A0", Offset = "0xABDFA0", VA = "0x180ABF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x711B5E0", Offset = "0x7119BE0", VA = "0x18711B5E0")]
		public static bool FFOLOHFBIHN(SerializedMaterialId CLMMPLJCADB, SerializedMaterialId NIGNLACGOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xABF700", Offset = "0xABDD00", VA = "0x180ABF700", Slot = "5")]
		public int CompareTo(SerializedMaterialId BHFGHGMPKOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x728D6E0", Offset = "0x728BCE0", VA = "0x18728D6E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DNKGDACKCLO : IIHHJNFJGAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DNKGDACKCLO CFNNMJAMDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x727B4A0", Offset = "0x7279AA0", VA = "0x18727B4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NHEFIAGPNID<DIBKDMJIGJP> EINHCDLCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x727B620", Offset = "0x7279C20", VA = "0x18727B620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NHEFIAGPNID<JFOHGLPGOKN> MDNALMIOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x727B320", Offset = "0x7279920", VA = "0x18727B320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NHEFIAGPNID<DKKCBBGFBGH> LMKCBCEMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x727B3E0", Offset = "0x72799E0", VA = "0x18727B3E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NHEFIAGPNID<NAJCLKBNHFG> NIOMOCJELIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x727B440", Offset = "0x7279A40", VA = "0x18727B440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NHEFIAGPNID<BGKFEPHCNAG> MJIDCEKFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x727B5C0", Offset = "0x7279BC0", VA = "0x18727B5C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NHEFIAGPNID<BPOGHOJNPIN> KAHOMKACLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x727B500", Offset = "0x7279B00", VA = "0x18727B500", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NHEFIAGPNID<FHOKKHPPPEG> LMKHEOFKMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x727B380", Offset = "0x7279980", VA = "0x18727B380", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NHEFIAGPNID<OMIIACJOJFJ> NIKJNEPFLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x727B560", Offset = "0x7279B60", VA = "0x18727B560", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BDFPLEGMGFL
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x727AED0", Offset = "0x72794D0", VA = "0x18727AED0")]
	public static Guid KCLFEGAOCEF(string LDEGDFBKKLJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x727AE00", Offset = "0x7279400", VA = "0x18727AE00")]
	public static bool JFLOHKKHFCM(string LDEGDFBKKLJ, [Out] Guid IJNLNGBKEAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PCONIEFNLNA : IEAIBFOIBPK<DIBKDMJIGJP>, EHLLKDDMBGF<DIBKDMJIGJP>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7286340", Offset = "0x7284940", VA = "0x187286340", Slot = "4")]
	public IEnumerable<(DIBKDMJIGJP, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x728AF90", Offset = "0x7289590", VA = "0x18728AF90", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public DIBKDMJIGJP NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(DIBKDMJIGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PCONIEFNLNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DLLMNFDCKDC : IEAIBFOIBPK<FHOKKHPPPEG>, EHLLKDDMBGF<FHOKKHPPPEG>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x727AF80", Offset = "0x7279580", VA = "0x18727AF80", Slot = "4")]
	public IEnumerable<(FHOKKHPPPEG, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public FHOKKHPPPEG NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(FHOKKHPPPEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DLLMNFDCKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GCDOJJAILCB : IEAIBFOIBPK<BGKFEPHCNAG>, EHLLKDDMBGF<BGKFEPHCNAG>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7283910", Offset = "0x7281F10", VA = "0x187283910", Slot = "4")]
	public IEnumerable<(BGKFEPHCNAG, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public BGKFEPHCNAG NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(BGKFEPHCNAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public GCDOJJAILCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PIIEPALHFAL : IEAIBFOIBPK<NAJCLKBNHFG>, EHLLKDDMBGF<NAJCLKBNHFG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EHLLKDDMBGF<PLPLILKLPID> LJOMFFPNCPO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	public PIIEPALHFAL(EHLLKDDMBGF<PLPLILKLPID> LJOMFFPNCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x711BB00", Offset = "0x711A100", VA = "0x18711BB00", Slot = "4")]
	public IEnumerable<(NAJCLKBNHFG, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x728C870", Offset = "0x728AE70", VA = "0x18728C870", Slot = "6")]
	public NAJCLKBNHFG NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(NAJCLKBNHFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x728CB70", Offset = "0x728B170", VA = "0x18728CB70", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FPLPLGLPLLD : IEAIBFOIBPK<JFOHGLPGOKN>, EHLLKDDMBGF<JFOHGLPGOKN>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x727BD00", Offset = "0x727A300", VA = "0x18727BD00", Slot = "4")]
	public IEnumerable<(JFOHGLPGOKN, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public JFOHGLPGOKN NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(JFOHGLPGOKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public FPLPLGLPLLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PIGEIBKGPJB : IEAIBFOIBPK<OMIIACJOJFJ>, EHLLKDDMBGF<OMIIACJOJFJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x728AFB0", Offset = "0x72895B0", VA = "0x18728AFB0", Slot = "4")]
	public IEnumerable<(OMIIACJOJFJ, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public OMIIACJOJFJ NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(OMIIACJOJFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PIGEIBKGPJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MPEFCLEGJOB : IEAIBFOIBPK<BPOGHOJNPIN>, EHLLKDDMBGF<BPOGHOJNPIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72859D0", Offset = "0x7283FD0", VA = "0x1872859D0", Slot = "4")]
	public IEnumerable<(BPOGHOJNPIN, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public BPOGHOJNPIN NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(BPOGHOJNPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MPEFCLEGJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EGKEDCFDLGM : IEAIBFOIBPK<DKKCBBGFBGH>, EHLLKDDMBGF<DKKCBBGFBGH>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x727B680", Offset = "0x7279C80", VA = "0x18727B680", Slot = "4")]
	public IEnumerable<(DKKCBBGFBGH, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public DKKCBBGFBGH NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(DKKCBBGFBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public EGKEDCFDLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IEAIBFOIBPK<TModern> : EHLLKDDMBGF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HGFBGFKLPED();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ONACNIMJEON(string EANOCADKNNG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ACKDDEDDILK : IEAIBFOIBPK<PLPLILKLPID>, EHLLKDDMBGF<PLPLILKLPID>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x71CFC70", Offset = "0x71CE270", VA = "0x1871CFC70", Slot = "4")]
	public IEnumerable<(PLPLILKLPID, string)> HGFBGFKLPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xAC1550", Offset = "0xABFB50", VA = "0x180AC1550", Slot = "5")]
	public string ONACNIMJEON(string EANOCADKNNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x727A030", Offset = "0x7278630", VA = "0x18727A030", Slot = "6")]
	public PLPLILKLPID NMKBGAJJELG(string EANOCADKNNG)
	{
		return default(PLPLILKLPID);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public ACKDDEDDILK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PDLEJEILAHE<TModern> : NHEFIAGPNID<TModern>, EHLLKDDMBGF<TModern> where TModern : IEquatable<TModern>, PKCEIIEOBOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> KHLEMLALOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> NKGMLNECIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly IEAIBFOIBPK<TModern> JJNOHKBHABG;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x47A89D0", Offset = "0x47A6FD0", VA = "0x1847A89D0")]
	public PDLEJEILAHE(IEAIBFOIBPK<TModern> JJNOHKBHABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x47A6930", Offset = "0x47A4F30", VA = "0x1847A6930", Slot = "5")]
	public TModern NMKBGAJJELG(string EANOCADKNNG)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x47A6030", Offset = "0x47A4630", VA = "0x1847A6030", Slot = "4")]
	public string MGPIDOEPBKN(TModern AADENCHKHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NIDECCBPMNO : IIHHJNFJGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private PDLEJEILAHE<DIBKDMJIGJP> MBANPBNPGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private PDLEJEILAHE<JFOHGLPGOKN> ADIHHEHJABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PDLEJEILAHE<DKKCBBGFBGH> DNDKCLHNLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PDLEJEILAHE<PLPLILKLPID> LJOMFFPNCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private PDLEJEILAHE<NAJCLKBNHFG> DDKGBABABMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PDLEJEILAHE<BGKFEPHCNAG> IBNDPLEGJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private PDLEJEILAHE<BPOGHOJNPIN> DOBIKGLEGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private PDLEJEILAHE<FHOKKHPPPEG> BBBJDPDFLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private PDLEJEILAHE<OMIIACJOJFJ> KBACMJNLBBE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NHEFIAGPNID<DIBKDMJIGJP> EINHCDLCEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NHEFIAGPNID<JFOHGLPGOKN> MDNALMIOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NHEFIAGPNID<DKKCBBGFBGH> LMKCBCEMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NHEFIAGPNID<NAJCLKBNHFG> NIOMOCJELIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NHEFIAGPNID<BGKFEPHCNAG> MJIDCEKFCBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NHEFIAGPNID<BPOGHOJNPIN> KAHOMKACLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NHEFIAGPNID<FHOKKHPPPEG> LMKHEOFKMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NHEFIAGPNID<OMIIACJOJFJ> NIKJNEPFLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86ADF0", Offset = "0x8693F0", VA = "0x18086ADF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7285DF0", Offset = "0x72843F0", VA = "0x187285DF0")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.GameOnly)]
	[UsedImplicitly]
	private static void ENMGGHMAIPC(GLOPJKBGAFG FDLKLBHIAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7285E60", Offset = "0x7284460", VA = "0x187285E60")]
	[Preserve]
	public NIDECCBPMNO()
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
