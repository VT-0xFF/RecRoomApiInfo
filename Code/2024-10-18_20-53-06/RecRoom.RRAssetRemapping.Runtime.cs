using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7692840", Offset = "0x7691C40", VA = "0x187692840", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LKKMCEAMHMA : BDMKBGHDDBN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MCJMBHAFNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly HBJEJEFHOOL MAOBDLMLMDP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7691290", Offset = "0x7690690", VA = "0x187691290")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	[UsedImplicitly]
	internal static void MHNICLDHNFP(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7690EF0", Offset = "0x76902F0", VA = "0x187690EF0")]
	[UsedImplicitly]
	internal static void GAKHBGLDNOF(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LKKMCEAMHMA([CCLHMIDBCEM(null)] HBJEJEFHOOL MAOBDLMLMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7690F50", Offset = "0x7690350", VA = "0x187690F50", Slot = "4")]
	public string IFDLICGNEEM(OGJHNDNNOJI EBJHHBADCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7690A30", Offset = "0x768FE30", VA = "0x187690A30", Slot = "5")]
	public OGJHNDNNOJI AJCCBGLJAMD(string EBJHHBADCKF)
	{
		return default(OGJHNDNNOJI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public SerializedAvatarItemId(KMLPKJNOABE NKPCGMJMEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public KMLPKJNOABE AJCCBGLJAMD()
		{
			return default(KMLPKJNOABE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7691D10", Offset = "0x7691110", VA = "0x187691D10", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7691DD0", Offset = "0x76911D0", VA = "0x187691DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public FOOMCMODIOE AJCCBGLJAMD()
		{
			return default(FOOMCMODIOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7691E40", Offset = "0x7691240", VA = "0x187691E40", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7691EE0", Offset = "0x76912E0", VA = "0x187691EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public DJNGKLBNCHI AJCCBGLJAMD()
		{
			return default(DJNGKLBNCHI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedColorId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedColorId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7691F50", Offset = "0x7691350", VA = "0x187691F50", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7691FF0", Offset = "0x76913F0", VA = "0x187691FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, JEBNHHNAHFI, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260")]
		public MHELINGPEEM AJCCBGLJAMD()
		{
			return default(MHELINGPEEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7692190", Offset = "0x7691590", VA = "0x187692190")]
		public SerializedCombinationId(MHELINGPEEM KFNDCDGPPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x751E700", Offset = "0x751DB00", VA = "0x18751E700", Slot = "4")]
		public bool Equals(SerializedCombinationId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7692060", Offset = "0x7691460", VA = "0x187692060", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedCombinationId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7692120", Offset = "0x7691520", VA = "0x187692120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7692110", Offset = "0x7691510", VA = "0x187692110", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public SerializedCustomAvatarItemId(Guid GPJCGLBMIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76921A0", Offset = "0x76915A0", VA = "0x1876921A0", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0")]
		public static bool LBFMGPFDJNL(SerializedCustomAvatarItemId OPJKGPJPNJJ, SerializedCustomAvatarItemId EANFIEEELEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7692240", Offset = "0x7691640", VA = "0x187692240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0x7692350", Offset = "0x7691750", VA = "0x187692350")]
		public static SerializedEquipmentSkinId HNLDLFOHJDP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public CKOBIDCKFAM AJCCBGLJAMD()
		{
			return default(CKOBIDCKFAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76922B0", Offset = "0x76916B0", VA = "0x1876922B0", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7692380", Offset = "0x7691780", VA = "0x187692380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public OBBAPCJJCDJ AJCCBGLJAMD()
		{
			return default(OBBAPCJJCDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x76923F0", Offset = "0x76917F0", VA = "0x1876923F0", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7692490", Offset = "0x7691890", VA = "0x187692490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public APNMOAFPJAL AJCCBGLJAMD()
		{
			return default(APNMOAFPJAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7692500", Offset = "0x7691900", VA = "0x187692500", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x76925A0", Offset = "0x76919A0", VA = "0x1876925A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90")]
		public PJEMGANEAJB AJCCBGLJAMD()
		{
			return default(PJEMGANEAJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0", Slot = "4")]
		public bool Equals(SerializedHairPatternId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedHairPatternId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7692610", Offset = "0x7691A10", VA = "0x187692610", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7691DB0", Offset = "0x76911B0", VA = "0x187691DB0")]
		public static bool LBFMGPFDJNL(SerializedHairPatternId OPJKGPJPNJJ, SerializedHairPatternId EANFIEEELEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76926B0", Offset = "0x7691AB0", VA = "0x1876926B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, JEBNHHNAHFI
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
		[Cpp2IlInjected.Address(RVA = "0xCB1A90", Offset = "0xCB0E90", VA = "0x180CB1A90")]
		public SerializedMaterialId(JFGBHIFLIEJ NKPCGMJMEIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0F90", VA = "0x180CB1B90", Slot = "6")]
		public Guid IHBNMPBNHCB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x751E700", Offset = "0x751DB00", VA = "0x18751E700", Slot = "4")]
		public bool Equals(SerializedMaterialId KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7692720", Offset = "0x7691B20", VA = "0x187692720", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD4F5E0", Offset = "0xD4E9E0", VA = "0x180D4F5E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD4F450", Offset = "0xD4E850", VA = "0x180D4F450", Slot = "5")]
		public int CompareTo(SerializedMaterialId KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x76927D0", Offset = "0x7691BD0", VA = "0x1876927D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KHCLFIAKBJB : HBJEJEFHOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KHCLFIAKBJB GJPJBBHLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x76907F0", Offset = "0x768FBF0", VA = "0x1876907F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IMGPDDOFEAJ<KMLPKJNOABE> DGIJHCKLJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x76909D0", Offset = "0x768FDD0", VA = "0x1876909D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IMGPDDOFEAJ<CKOBIDCKFAM> ECICGHDPDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7690970", Offset = "0x768FD70", VA = "0x187690970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IMGPDDOFEAJ<PJEMGANEAJB> DFBOPFEKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7690850", Offset = "0x768FC50", VA = "0x187690850", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IMGPDDOFEAJ<MHELINGPEEM> GPAJPGCDAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7690730", Offset = "0x768FB30", VA = "0x187690730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IMGPDDOFEAJ<DJNGKLBNCHI> IPNDHKDPADL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x76906D0", Offset = "0x768FAD0", VA = "0x1876906D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IMGPDDOFEAJ<APNMOAFPJAL> PIIONEIOKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7690790", Offset = "0x768FB90", VA = "0x187690790", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IMGPDDOFEAJ<FOOMCMODIOE> PABOBBPDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7690910", Offset = "0x768FD10", VA = "0x187690910", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IMGPDDOFEAJ<OBBAPCJJCDJ> EGOMAHDCHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76908B0", Offset = "0x768FCB0", VA = "0x1876908B0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDJDJOADPCJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7690550", Offset = "0x768F950", VA = "0x187690550")]
	public static Guid KCGDFPFNFOE(string ENKJPIPMDKN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7690600", Offset = "0x768FA00", VA = "0x187690600")]
	public static bool PMNJCPBBHGB(string ENKJPIPMDKN, [Out] Guid GPJCGLBMIBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ENAIGIKEDMN : KFDJKBGMOKE<KMLPKJNOABE>, OLMINHHLPOB<KMLPKJNOABE>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x76833F0", Offset = "0x76827F0", VA = "0x1876833F0", Slot = "4")]
	public IEnumerable<(KMLPKJNOABE, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76833D0", Offset = "0x76827D0", VA = "0x1876833D0", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public KMLPKJNOABE MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(KMLPKJNOABE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public ENAIGIKEDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BCFDLDLHHIG : KFDJKBGMOKE<FOOMCMODIOE>, OLMINHHLPOB<FOOMCMODIOE>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7683030", Offset = "0x7682430", VA = "0x187683030", Slot = "4")]
	public IEnumerable<(FOOMCMODIOE, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public FOOMCMODIOE MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(FOOMCMODIOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public BCFDLDLHHIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BBMKJPJOKEO : KFDJKBGMOKE<DJNGKLBNCHI>, OLMINHHLPOB<DJNGKLBNCHI>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7680F70", Offset = "0x7680370", VA = "0x187680F70", Slot = "4")]
	public IEnumerable<(DJNGKLBNCHI, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public DJNGKLBNCHI MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(DJNGKLBNCHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public BBMKJPJOKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GLINEDCKLEM : KFDJKBGMOKE<MHELINGPEEM>, OLMINHHLPOB<MHELINGPEEM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly OLMINHHLPOB<JFGBHIFLIEJ> NENFJFJPKAP;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
	public GLINEDCKLEM(OLMINHHLPOB<JFGBHIFLIEJ> NENFJFJPKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x751F230", Offset = "0x751E630", VA = "0x18751F230", Slot = "4")]
	public IEnumerable<(MHELINGPEEM, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7688080", Offset = "0x7687480", VA = "0x187688080", Slot = "6")]
	public MHELINGPEEM MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(MHELINGPEEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7688040", Offset = "0x7687440", VA = "0x187688040", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HHJCLMKJFNO : KFDJKBGMOKE<CKOBIDCKFAM>, OLMINHHLPOB<CKOBIDCKFAM>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x76882C0", Offset = "0x76876C0", VA = "0x1876882C0", Slot = "4")]
	public IEnumerable<(CKOBIDCKFAM, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public CKOBIDCKFAM MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(CKOBIDCKFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HHJCLMKJFNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AINBLCMHBJE : KFDJKBGMOKE<OBBAPCJJCDJ>, OLMINHHLPOB<OBBAPCJJCDJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x767F5F0", Offset = "0x767E9F0", VA = "0x18767F5F0", Slot = "4")]
	public IEnumerable<(OBBAPCJJCDJ, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public OBBAPCJJCDJ MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(OBBAPCJJCDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public AINBLCMHBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PILLICFNNPH : KFDJKBGMOKE<APNMOAFPJAL>, OLMINHHLPOB<APNMOAFPJAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x76918F0", Offset = "0x7690CF0", VA = "0x1876918F0", Slot = "4")]
	public IEnumerable<(APNMOAFPJAL, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public APNMOAFPJAL MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(APNMOAFPJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public PILLICFNNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HMLLCNMBCBB : KFDJKBGMOKE<PJEMGANEAJB>, OLMINHHLPOB<PJEMGANEAJB>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x768FED0", Offset = "0x768F2D0", VA = "0x18768FED0", Slot = "4")]
	public IEnumerable<(PJEMGANEAJB, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public PJEMGANEAJB MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(PJEMGANEAJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HMLLCNMBCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KFDJKBGMOKE<TModern> : OLMINHHLPOB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LNCLBAFFKEI();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GAIPFHNKFJO(string HFDIDKGGCGI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IFHGMPEKLCB : KFDJKBGMOKE<JFGBHIFLIEJ>, OLMINHHLPOB<JFGBHIFLIEJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x75D4350", Offset = "0x75D3750", VA = "0x1875D4350", Slot = "4")]
	public IEnumerable<(JFGBHIFLIEJ, string)> LNCLBAFFKEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x97E750", Offset = "0x97DB50", VA = "0x18097E750", Slot = "5")]
	public string GAIPFHNKFJO(string HFDIDKGGCGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7680EB0", Offset = "0x76802B0", VA = "0x187680EB0", Slot = "6")]
	public JFGBHIFLIEJ MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return default(JFGBHIFLIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public IFHGMPEKLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KLPBPKABJJM<TModern> : IMGPDDOFEAJ<TModern>, OLMINHHLPOB<TModern> where TModern : IEquatable<TModern>, JEBNHHNAHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> NPGCLIGOIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> NIBMPEGGPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KFDJKBGMOKE<TModern> GKMGKDIDCJI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x450D250", Offset = "0x450C650", VA = "0x18450D250")]
	public KLPBPKABJJM(KFDJKBGMOKE<TModern> GKMGKDIDCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x450BF90", Offset = "0x450B390", VA = "0x18450BF90", Slot = "5")]
	public TModern MMKOIJHHGFI(string HFDIDKGGCGI)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x450B140", Offset = "0x450A540", VA = "0x18450B140", Slot = "4")]
	public string GCOLKKAPAHK(TModern DNFMOAABNHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OCJOAFAFOFA : HBJEJEFHOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KLPBPKABJJM<KMLPKJNOABE> IPKDBLDMKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KLPBPKABJJM<CKOBIDCKFAM> CENFGIICCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KLPBPKABJJM<PJEMGANEAJB> CKPMDGKDIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KLPBPKABJJM<JFGBHIFLIEJ> NENFJFJPKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KLPBPKABJJM<MHELINGPEEM> JECOBAJCKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KLPBPKABJJM<DJNGKLBNCHI> COOBJJMNBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KLPBPKABJJM<APNMOAFPJAL> GDFJOBBAEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KLPBPKABJJM<FOOMCMODIOE> IFOPFKMBCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KLPBPKABJJM<OBBAPCJJCDJ> EMPIPFEPNFH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IMGPDDOFEAJ<KMLPKJNOABE> DGIJHCKLJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IMGPDDOFEAJ<CKOBIDCKFAM> ECICGHDPDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IMGPDDOFEAJ<PJEMGANEAJB> DFBOPFEKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IMGPDDOFEAJ<MHELINGPEEM> GPAJPGCDAHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IMGPDDOFEAJ<DJNGKLBNCHI> IPNDHKDPADL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IMGPDDOFEAJ<APNMOAFPJAL> PIIONEIOKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IMGPDDOFEAJ<FOOMCMODIOE> PABOBBPDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IMGPDDOFEAJ<OBBAPCJJCDJ> EGOMAHDCHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76913A0", Offset = "0x76907A0", VA = "0x1876913A0")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	[UsedImplicitly]
	internal static void CMJIFNFGFLF(LBNNADLFMIK PCMEKEJCMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7691410", Offset = "0x7690810", VA = "0x187691410")]
	[RecRoom.NoEngine.Common.Preserve]
	public OCJOAFAFOFA()
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
