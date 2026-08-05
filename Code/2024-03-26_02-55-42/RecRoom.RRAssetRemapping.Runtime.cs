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
public class BGBKPJOEIAA : OHEKOHNBOCK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex FDHPKNBAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BMHJMKBBLON CFPGLNKMLJL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x697B250", Offset = "0x697A650", VA = "0x18697B250")]
	[AMCIKKJLCIB(HENHDGEOMOC.GameOnly)]
	[UsedImplicitly]
	private static void IEDLFPKPNAO(BNDLKDEPBDF PLABOMGPCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x697A670", Offset = "0x6979A70", VA = "0x18697A670")]
	[UsedImplicitly]
	[AMCIKKJLCIB(HENHDGEOMOC.EditorOnly)]
	private static void BLBPKGMALHB(BNDLKDEPBDF PLABOMGPCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	[Preserve]
	public BGBKPJOEIAA([AKGMOFMFNCG(null)] BMHJMKBBLON CFPGLNKMLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x697AD90", Offset = "0x697A190", VA = "0x18697AD90", Slot = "4")]
	public string HBIMCCJEPGN(ILHJOKKCIHN CIBLPGDHGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x697A6D0", Offset = "0x6979AD0", VA = "0x18697A6D0", Slot = "5")]
	public ILHJOKKCIHN CMCHCKHHIFC(string CIBLPGDHGMJ)
	{
		return default(ILHJOKKCIHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FHCLHDGEFEA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x697D2F0", Offset = "0x697C6F0", VA = "0x18697D2F0")]
	public static BMHJMKBBLON DDJMLHEHDPK()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public SerializedAvatarItemId(GJKJFBJPLEB BFMGPLIBCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public GJKJFBJPLEB CMCHCKHHIFC()
		{
			return default(GJKJFBJPLEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x698D160", Offset = "0x698C560", VA = "0x18698D160", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x698D220", Offset = "0x698C620", VA = "0x18698D220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, HHNLMKPIDKB
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
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public MJOIAGLKBND CMCHCKHHIFC()
		{
			return default(MJOIAGLKBND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x698D290", Offset = "0x698C690", VA = "0x18698D290", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x698D330", Offset = "0x698C730", VA = "0x18698D330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, HHNLMKPIDKB
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
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public MKDHPMFJKGN CMCHCKHHIFC()
		{
			return default(MKDHPMFJKGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedColorId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedColorId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x698D3A0", Offset = "0x698C7A0", VA = "0x18698D3A0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x698D440", Offset = "0x698C840", VA = "0x18698D440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, HHNLMKPIDKB, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x698D4B0", Offset = "0x698C8B0", VA = "0x18698D4B0")]
		public AJKOACJGOMI CMCHCKHHIFC()
		{
			return default(AJKOACJGOMI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x698D740", Offset = "0x698CB40", VA = "0x18698D740")]
		public SerializedCombinationId(AJKOACJGOMI DIKEGEMEMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x698D510", Offset = "0x698C910", VA = "0x18698D510")]
		private void DCDBCMLOGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x681A280", Offset = "0x6819680", VA = "0x18681A280", Slot = "4")]
		public bool Equals(SerializedCombinationId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x698D610", Offset = "0x698CA10", VA = "0x18698D610", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedCombinationId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x698D6D0", Offset = "0x698CAD0", VA = "0x18698D6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x698D6C0", Offset = "0x698CAC0", VA = "0x18698D6C0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x698D810", Offset = "0x698CC10", VA = "0x18698D810")]
		public static SerializedEquipmentSkinId MDMEEDCJGJJ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public GCIIDMPLGFE CMCHCKHHIFC()
		{
			return default(GCIIDMPLGFE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x698D770", Offset = "0x698CB70", VA = "0x18698D770", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x698D840", Offset = "0x698CC40", VA = "0x18698D840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public DAGNKAFLHCE CMCHCKHHIFC()
		{
			return default(DAGNKAFLHCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x698D8B0", Offset = "0x698CCB0", VA = "0x18698D8B0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x698D950", Offset = "0x698CD50", VA = "0x18698D950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public AKGJGCFKOBH CMCHCKHHIFC()
		{
			return default(AKGJGCFKOBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x698D9C0", Offset = "0x698CDC0", VA = "0x18698D9C0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x698DA60", Offset = "0x698CE60", VA = "0x18698DA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public SerializedHairPatternId(LNLAIKCBHJI BFMGPLIBCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public LNLAIKCBHJI CMCHCKHHIFC()
		{
			return default(LNLAIKCBHJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200", Slot = "4")]
		public bool Equals(SerializedHairPatternId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x698DAD0", Offset = "0x698CED0", VA = "0x18698DAD0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x698D200", Offset = "0x698C600", VA = "0x18698D200")]
		public static bool IDILALBKFJC(SerializedHairPatternId OOGPCKEGMIK, SerializedHairPatternId NPEJHBIFPCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x698DB70", Offset = "0x698CF70", VA = "0x18698DB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, HHNLMKPIDKB
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

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DE1F20", Offset = "0x1DE1320", VA = "0x181DE1F20")]
		public SerializedMaterialId(FGIAOJAELOM BFMGPLIBCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840", Slot = "6")]
		public Guid GJHJEOPONJD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88B840", Offset = "0x88AC40", VA = "0x18088B840")]
		public FGIAOJAELOM CMCHCKHHIFC()
		{
			return default(FGIAOJAELOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x681A280", Offset = "0x6819680", VA = "0x18681A280", Slot = "4")]
		public bool Equals(SerializedMaterialId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x698DBE0", Offset = "0x698CFE0", VA = "0x18698DBE0", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x91D720", Offset = "0x91CB20", VA = "0x18091D720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x681A280", Offset = "0x6819680", VA = "0x18681A280")]
		public static bool IDILALBKFJC(SerializedMaterialId OOGPCKEGMIK, SerializedMaterialId NPEJHBIFPCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x91D480", Offset = "0x91C880", VA = "0x18091D480", Slot = "5")]
		public int CompareTo(SerializedMaterialId MGDPHHCBMMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x698DC80", Offset = "0x698D080", VA = "0x18698DC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JPGNHBCPLNE : BMHJMKBBLON
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JPGNHBCPLNE GDCHCCJBKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x698A300", Offset = "0x6989700", VA = "0x18698A300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MCEFOBJJKBD<GJKJFBJPLEB> NFBOLIHOFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x698A2A0", Offset = "0x69896A0", VA = "0x18698A2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MCEFOBJJKBD<GCIIDMPLGFE> JMEPJGCEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x698A480", Offset = "0x6989880", VA = "0x18698A480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MCEFOBJJKBD<LNLAIKCBHJI> CBNMFALPLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x698A3C0", Offset = "0x69897C0", VA = "0x18698A3C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MCEFOBJJKBD<AJKOACJGOMI> OPAPBLIHEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x698A420", Offset = "0x6989820", VA = "0x18698A420", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MCEFOBJJKBD<MKDHPMFJKGN> LDLFFJKFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x698A540", Offset = "0x6989940", VA = "0x18698A540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MCEFOBJJKBD<AKGJGCFKOBH> DJNAEJLLBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x698A4E0", Offset = "0x69898E0", VA = "0x18698A4E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MCEFOBJJKBD<MJOIAGLKBND> APCNIKKBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x698A360", Offset = "0x6989760", VA = "0x18698A360", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MCEFOBJJKBD<DAGNKAFLHCE> GFLEACBHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x698A240", Offset = "0x6989640", VA = "0x18698A240", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DBGCBFAHLON
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x697D240", Offset = "0x697C640", VA = "0x18697D240")]
	public static Guid KLHJEJPFHMD(string IIAPPBFDDDH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x697D170", Offset = "0x697C570", VA = "0x18697D170")]
	public static bool FFMADCKHMOL(string IIAPPBFDDDH, [Out] Guid GFLAAGJEJNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HHMIBJCELGP : ENJGBCHGFOA<GJKJFBJPLEB>, CEEAPIPBMAO<GJKJFBJPLEB>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6984F70", Offset = "0x6984370", VA = "0x186984F70", Slot = "4")]
	public IEnumerable<(GJKJFBJPLEB, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6984F50", Offset = "0x6984350", VA = "0x186984F50", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public GJKJFBJPLEB HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(GJKJFBJPLEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HHMIBJCELGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PFMPFJPJGHM : ENJGBCHGFOA<MJOIAGLKBND>, CEEAPIPBMAO<MJOIAGLKBND>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x698CDC0", Offset = "0x698C1C0", VA = "0x18698CDC0", Slot = "4")]
	public IEnumerable<(MJOIAGLKBND, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public MJOIAGLKBND HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(MJOIAGLKBND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PFMPFJPJGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MECDABIMLJG : ENJGBCHGFOA<MKDHPMFJKGN>, CEEAPIPBMAO<MKDHPMFJKGN>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x698A5A0", Offset = "0x69899A0", VA = "0x18698A5A0", Slot = "4")]
	public IEnumerable<(MKDHPMFJKGN, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public MKDHPMFJKGN HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(MKDHPMFJKGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public MECDABIMLJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OKOMLNGDJOE : ENJGBCHGFOA<AJKOACJGOMI>, CEEAPIPBMAO<AJKOACJGOMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CEEAPIPBMAO<FGIAOJAELOM> AGJEPGDIAAG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public OKOMLNGDJOE(CEEAPIPBMAO<FGIAOJAELOM> AGJEPGDIAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x681C080", Offset = "0x681B480", VA = "0x18681C080", Slot = "4")]
	public IEnumerable<(AJKOACJGOMI, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x698CA80", Offset = "0x698BE80", VA = "0x18698CA80", Slot = "6")]
	public AJKOACJGOMI HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(AJKOACJGOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x698CD80", Offset = "0x698C180", VA = "0x18698CD80", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HAJCLJOANKE : ENJGBCHGFOA<GCIIDMPLGFE>, CEEAPIPBMAO<GCIIDMPLGFE>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x697D340", Offset = "0x697C740", VA = "0x18697D340", Slot = "4")]
	public IEnumerable<(GCIIDMPLGFE, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public GCIIDMPLGFE HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(GCIIDMPLGFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HAJCLJOANKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class COOGFCBEAIL : ENJGBCHGFOA<DAGNKAFLHCE>, CEEAPIPBMAO<DAGNKAFLHCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x697B8B0", Offset = "0x697ACB0", VA = "0x18697B8B0", Slot = "4")]
	public IEnumerable<(DAGNKAFLHCE, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public DAGNKAFLHCE HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(DAGNKAFLHCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public COOGFCBEAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OIPCODFGNKB : ENJGBCHGFOA<AKGJGCFKOBH>, CEEAPIPBMAO<AKGJGCFKOBH>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x698C660", Offset = "0x698BA60", VA = "0x18698C660", Slot = "4")]
	public IEnumerable<(AKGJGCFKOBH, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public AKGJGCFKOBH HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(AKGJGCFKOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public OIPCODFGNKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class IJELPOEIJMO : ENJGBCHGFOA<LNLAIKCBHJI>, CEEAPIPBMAO<LNLAIKCBHJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6989BC0", Offset = "0x6988FC0", VA = "0x186989BC0", Slot = "4")]
	public IEnumerable<(LNLAIKCBHJI, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public LNLAIKCBHJI HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(LNLAIKCBHJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public IJELPOEIJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ENJGBCHGFOA<TModern> : CEEAPIPBMAO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> NAAIIMKFKJA();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string IOIFCEJMDBJ(string JJABBHAJCHE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AFNKEPIIOLF : ENJGBCHGFOA<FGIAOJAELOM>, CEEAPIPBMAO<FGIAOJAELOM>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68D01F0", Offset = "0x68CF5F0", VA = "0x1868D01F0", Slot = "4")]
	public IEnumerable<(FGIAOJAELOM, string)> NAAIIMKFKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "5")]
	public string IOIFCEJMDBJ(string JJABBHAJCHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x697A5B0", Offset = "0x69799B0", VA = "0x18697A5B0", Slot = "6")]
	public FGIAOJAELOM HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return default(FGIAOJAELOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public AFNKEPIIOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BIPBFKIHCIK<TModern> : MCEFOBJJKBD<TModern>, CEEAPIPBMAO<TModern> where TModern : IEquatable<TModern>, HHNLMKPIDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> KABHLGFEKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> BDNHCDAFGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ENJGBCHGFOA<TModern> JGDEOCGABFF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4811BC0", Offset = "0x4810FC0", VA = "0x184811BC0")]
	public BIPBFKIHCIK(ENJGBCHGFOA<TModern> JGDEOCGABFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4810190", Offset = "0x480F590", VA = "0x184810190", Slot = "5")]
	public TModern HGNDCIAEAAB(string JJABBHAJCHE)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x480F750", Offset = "0x480EB50", VA = "0x18480F750", Slot = "4")]
	public string DAAEONMFCGN(TModern CNAGJHELFNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CBJOJCEPFEH : BMHJMKBBLON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BIPBFKIHCIK<GJKJFBJPLEB> PPOPLPMFDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private BIPBFKIHCIK<GCIIDMPLGFE> CKNEIJLKJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BIPBFKIHCIK<LNLAIKCBHJI> ACKABCPHJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BIPBFKIHCIK<FGIAOJAELOM> AGJEPGDIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BIPBFKIHCIK<AJKOACJGOMI> BFKCGFCFMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BIPBFKIHCIK<MKDHPMFJKGN> MAAOAGGOAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BIPBFKIHCIK<AKGJGCFKOBH> BEHAOMOEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BIPBFKIHCIK<MJOIAGLKBND> CJOMPADGNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BIPBFKIHCIK<DAGNKAFLHCE> PPGMJGLJDCD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MCEFOBJJKBD<GJKJFBJPLEB> NFBOLIHOFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MCEFOBJJKBD<GCIIDMPLGFE> JMEPJGCEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MCEFOBJJKBD<LNLAIKCBHJI> CBNMFALPLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MCEFOBJJKBD<AJKOACJGOMI> OPAPBLIHEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MCEFOBJJKBD<MKDHPMFJKGN> LDLFFJKFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MCEFOBJJKBD<AKGJGCFKOBH> DJNAEJLLBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MCEFOBJJKBD<MJOIAGLKBND> APCNIKKBGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MCEFOBJJKBD<DAGNKAFLHCE> GFLEACBHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x697B360", Offset = "0x697A760", VA = "0x18697B360")]
	[AMCIKKJLCIB(FDMHFCDINAO.Root, HENHDGEOMOC.GameOnly)]
	[UsedImplicitly]
	private static void DNPDJCFPNKL(BNDLKDEPBDF PLABOMGPCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x697B3D0", Offset = "0x697A7D0", VA = "0x18697B3D0")]
	[Preserve]
	public CBJOJCEPFEH()
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
