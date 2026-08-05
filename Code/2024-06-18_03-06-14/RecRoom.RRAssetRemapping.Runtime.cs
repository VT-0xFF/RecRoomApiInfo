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
public class GPHECMCOHBG : FMACAGIFFFD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NADOFPCAEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BPFFNPJOOHC LFAAEHJEHCF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71359D0", Offset = "0x71343D0", VA = "0x1871359D0")]
	[MHFEIEAPENL(CMFCLNIIIKO.GameOnly)]
	[UsedImplicitly]
	private static void CGLKAELBCAP(GPECMKAJNMD MJAMFOPMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7135970", Offset = "0x7134370", VA = "0x187135970")]
	[UsedImplicitly]
	[MHFEIEAPENL(CMFCLNIIIKO.EditorOnly)]
	private static void CAAKNFMCCFA(GPECMKAJNMD MJAMFOPMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	[Preserve]
	public GPHECMCOHBG([OHLKLPAILPF(null)] BPFFNPJOOHC LFAAEHJEHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7136100", Offset = "0x7134B00", VA = "0x187136100", Slot = "4")]
	public string KJCBMOAEMAH(ONCNPAAFPAJ CGAJJAALELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7135A40", Offset = "0x7134440", VA = "0x187135A40", Slot = "5")]
	public ONCNPAAFPAJ FIOJCIMJMME(string CGAJJAALELM)
	{
		return default(ONCNPAAFPAJ);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
		public SerializedAvatarItemId(GBHMJLHNKHN OBDGAAHPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public GBHMJLHNKHN FIOJCIMJMME()
		{
			return default(GBHMJLHNKHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedAvatarItemId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7145AA0", Offset = "0x71444A0", VA = "0x187145AA0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7145B60", Offset = "0x7144560", VA = "0x187145B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public HLNCNEOFKGK FIOJCIMJMME()
		{
			return default(HLNCNEOFKGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedBodyShapeId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7145BD0", Offset = "0x71445D0", VA = "0x187145BD0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7145C70", Offset = "0x7144670", VA = "0x187145C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public KJEDFHBBPGK FIOJCIMJMME()
		{
			return default(KJEDFHBBPGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedColorId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedColorId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7145CE0", Offset = "0x71446E0", VA = "0x187145CE0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7145D80", Offset = "0x7144780", VA = "0x187145D80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MIPPIMJAJNA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7145EA0", Offset = "0x71448A0", VA = "0x187145EA0")]
		public OMEPBNMDOOI FIOJCIMJMME()
		{
			return default(OMEPBNMDOOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7146080", Offset = "0x7144A80", VA = "0x187146080")]
		public SerializedCombinationId(OMEPBNMDOOI FJBCICKFCNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7145F00", Offset = "0x7144900", VA = "0x187145F00")]
		private void JOOCPHKKILB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3DA0", Offset = "0x6FD27A0", VA = "0x186FD3DA0", Slot = "4")]
		public bool Equals(SerializedCombinationId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7145DF0", Offset = "0x71447F0", VA = "0x187145DF0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedCombinationId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7146010", Offset = "0x7144A10", VA = "0x187146010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7146000", Offset = "0x7144A00", VA = "0x187146000", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x7146150", Offset = "0x7144B50", VA = "0x187146150")]
		public static SerializedEquipmentSkinId NEFPFLBBDFE()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public PALMOAGHFKD FIOJCIMJMME()
		{
			return default(PALMOAGHFKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71460B0", Offset = "0x7144AB0", VA = "0x1871460B0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7146180", Offset = "0x7144B80", VA = "0x187146180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public ENFHCMKIOHI FIOJCIMJMME()
		{
			return default(ENFHCMKIOHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71461F0", Offset = "0x7144BF0", VA = "0x1871461F0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7146290", Offset = "0x7144C90", VA = "0x187146290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public EDPKFFIMOMC FIOJCIMJMME()
		{
			return default(EDPKFFIMOMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedFaceShapeId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7146300", Offset = "0x7144D00", VA = "0x187146300", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71463A0", Offset = "0x7144DA0", VA = "0x1871463A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public GLMCIKGKCFG FIOJCIMJMME()
		{
			return default(GLMCIKGKCFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40", Slot = "4")]
		public bool Equals(SerializedHairPatternId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7146410", Offset = "0x7144E10", VA = "0x187146410", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7145B40", Offset = "0x7144540", VA = "0x187145B40")]
		public static bool IKJGJDJDJIH(SerializedHairPatternId FKJLOGAHGLJ, SerializedHairPatternId MJMNBMLJKJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71464B0", Offset = "0x7144EB0", VA = "0x1871464B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MIPPIMJAJNA
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
		[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
		public SerializedMaterialId(ICFGFCOCCJK OBDGAAHPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0", Slot = "6")]
		public Guid EOKHFMBEOJK()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9BDDC0", Offset = "0x9BC7C0", VA = "0x1809BDDC0")]
		public ICFGFCOCCJK FIOJCIMJMME()
		{
			return default(ICFGFCOCCJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3DA0", Offset = "0x6FD27A0", VA = "0x186FD3DA0", Slot = "4")]
		public bool Equals(SerializedMaterialId HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7146520", Offset = "0x7144F20", VA = "0x187146520", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B9D0", Offset = "0xA7A3D0", VA = "0x180A7B9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3DA0", Offset = "0x6FD27A0", VA = "0x186FD3DA0")]
		public static bool IKJGJDJDJIH(SerializedMaterialId FKJLOGAHGLJ, SerializedMaterialId MJMNBMLJKJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA7B7B0", Offset = "0xA7A1B0", VA = "0x180A7B7B0", Slot = "5")]
		public int CompareTo(SerializedMaterialId HENLEJBGFIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71465D0", Offset = "0x7144FD0", VA = "0x1871465D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CKNJCCIPMIF : BPFFNPJOOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CKNJCCIPMIF OHJMENPNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71334F0", Offset = "0x7131EF0", VA = "0x1871334F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JJLKMNEMLLL<GBHMJLHNKHN> PINDLEBOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7133790", Offset = "0x7132190", VA = "0x187133790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JJLKMNEMLLL<PALMOAGHFKD> EBHBMKGLAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7133610", Offset = "0x7132010", VA = "0x187133610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JJLKMNEMLLL<GLMCIKGKCFG> CELBLIHMCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71336D0", Offset = "0x71320D0", VA = "0x1871336D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JJLKMNEMLLL<OMEPBNMDOOI> MCHGDLMODKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71335B0", Offset = "0x7131FB0", VA = "0x1871335B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JJLKMNEMLLL<KJEDFHBBPGK> HKDCLIEFGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7133490", Offset = "0x7131E90", VA = "0x187133490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JJLKMNEMLLL<EDPKFFIMOMC> LNAPCFMDJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7133670", Offset = "0x7132070", VA = "0x187133670", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JJLKMNEMLLL<HLNCNEOFKGK> FCGBONPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7133730", Offset = "0x7132130", VA = "0x187133730", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JJLKMNEMLLL<ENFHCMKIOHI> HLACIIBJNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7133550", Offset = "0x7131F50", VA = "0x187133550", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FPOCBDOPJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71358C0", Offset = "0x71342C0", VA = "0x1871358C0")]
	public static Guid FPDFNMAHFFA(string CJDECMJJIFI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71357F0", Offset = "0x71341F0", VA = "0x1871357F0")]
	public static bool AOFHFHGKMNO(string CJDECMJJIFI, [Out] Guid JCMDDLFAGEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LEFMGMADIOD : AEMIMMLMAJM<GBHMJLHNKHN>, OMMBGELPKNC<GBHMJLHNKHN>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x713E610", Offset = "0x713D010", VA = "0x18713E610", Slot = "4")]
	public IEnumerable<(GBHMJLHNKHN, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7143260", Offset = "0x7141C60", VA = "0x187143260", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public GBHMJLHNKHN LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(GBHMJLHNKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public LEFMGMADIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KMOEKIOHKIN : AEMIMMLMAJM<HLNCNEOFKGK>, OMMBGELPKNC<HLNCNEOFKGK>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x713E270", Offset = "0x713CC70", VA = "0x18713E270", Slot = "4")]
	public IEnumerable<(HLNCNEOFKGK, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public HLNCNEOFKGK LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(HLNCNEOFKGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public KMOEKIOHKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MGAMACKOFBM : AEMIMMLMAJM<KJEDFHBBPGK>, OMMBGELPKNC<KJEDFHBBPGK>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7143280", Offset = "0x7141C80", VA = "0x187143280", Slot = "4")]
	public IEnumerable<(KJEDFHBBPGK, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public KJEDFHBBPGK LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(KJEDFHBBPGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public MGAMACKOFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NPBLHPCNNIJ : AEMIMMLMAJM<OMEPBNMDOOI>, OMMBGELPKNC<OMEPBNMDOOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly OMMBGELPKNC<ICFGFCOCCJK> NOAEKLONCIG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	public NPBLHPCNNIJ(OMMBGELPKNC<ICFGFCOCCJK> NOAEKLONCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FD4A10", Offset = "0x6FD3410", VA = "0x186FD4A10", Slot = "4")]
	public IEnumerable<(OMEPBNMDOOI, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7145760", Offset = "0x7144160", VA = "0x187145760", Slot = "6")]
	public OMEPBNMDOOI LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(OMEPBNMDOOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7145A60", Offset = "0x7144460", VA = "0x187145A60", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JABLMPGHNNC : AEMIMMLMAJM<PALMOAGHFKD>, OMMBGELPKNC<PALMOAGHFKD>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7136660", Offset = "0x7135060", VA = "0x187136660", Slot = "4")]
	public IEnumerable<(PALMOAGHFKD, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public PALMOAGHFKD LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(PALMOAGHFKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public JABLMPGHNNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FEFFMDIELHO : AEMIMMLMAJM<ENFHCMKIOHI>, OMMBGELPKNC<ENFHCMKIOHI>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7133F30", Offset = "0x7132930", VA = "0x187133F30", Slot = "4")]
	public IEnumerable<(ENFHCMKIOHI, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public ENFHCMKIOHI LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(ENFHCMKIOHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public FEFFMDIELHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NOJIDPGKNOL : AEMIMMLMAJM<EDPKFFIMOMC>, OMMBGELPKNC<EDPKFFIMOMC>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7145340", Offset = "0x7143D40", VA = "0x187145340", Slot = "4")]
	public IEnumerable<(EDPKFFIMOMC, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public EDPKFFIMOMC LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(EDPKFFIMOMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public NOJIDPGKNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EOAOHICHBIB : AEMIMMLMAJM<GLMCIKGKCFG>, OMMBGELPKNC<GLMCIKGKCFG>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71338B0", Offset = "0x71322B0", VA = "0x1871338B0", Slot = "4")]
	public IEnumerable<(GLMCIKGKCFG, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public GLMCIKGKCFG LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(GLMCIKGKCFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public EOAOHICHBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AEMIMMLMAJM<TModern> : OMMBGELPKNC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LMKNIDFNEMJ();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PKKDIPKFAHE(string OHHNEMKBIOH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GKHHBBGHCPK : AEMIMMLMAJM<ICFGFCOCCJK>, OMMBGELPKNC<ICFGFCOCCJK>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7088B80", Offset = "0x7087580", VA = "0x187088B80", Slot = "4")]
	public IEnumerable<(ICFGFCOCCJK, string)> LMKNIDFNEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA7D740", Offset = "0xA7C140", VA = "0x180A7D740", Slot = "5")]
	public string PKKDIPKFAHE(string OHHNEMKBIOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71337F0", Offset = "0x71321F0", VA = "0x1871337F0", Slot = "6")]
	public ICFGFCOCCJK LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return default(ICFGFCOCCJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public GKHHBBGHCPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EIJBJCIHGBM<TModern> : JJLKMNEMLLL<TModern>, OMMBGELPKNC<TModern> where TModern : IEquatable<TModern>, MIPPIMJAJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> CEEIJJDCJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> NHLFCFBHCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AEMIMMLMAJM<TModern> AANOOECKMFN;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3862760", Offset = "0x3861160", VA = "0x183862760")]
	public EIJBJCIHGBM(AEMIMMLMAJM<TModern> AANOOECKMFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3861F80", Offset = "0x3860980", VA = "0x183861F80", Slot = "5")]
	public TModern LKIKGOEDKPB(string OHHNEMKBIOH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38609E0", Offset = "0x385F3E0", VA = "0x1838609E0", Slot = "4")]
	public string DJNGOEHBJAJ(TModern OMKFALKENAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ANGCIGOHFCJ : BPFFNPJOOHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EIJBJCIHGBM<GBHMJLHNKHN> MLHNMFJJIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EIJBJCIHGBM<PALMOAGHFKD> OBOCIDFDMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EIJBJCIHGBM<GLMCIKGKCFG> PDHDHFJENLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EIJBJCIHGBM<ICFGFCOCCJK> NOAEKLONCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EIJBJCIHGBM<OMEPBNMDOOI> IDHFBLPCLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EIJBJCIHGBM<KJEDFHBBPGK> CIFAOHCCFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EIJBJCIHGBM<EDPKFFIMOMC> FFEDCLNPEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EIJBJCIHGBM<HLNCNEOFKGK> IDDEPBPONOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EIJBJCIHGBM<ENFHCMKIOHI> PIGKELDNJLG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JJLKMNEMLLL<GBHMJLHNKHN> PINDLEBOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JJLKMNEMLLL<PALMOAGHFKD> EBHBMKGLAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JJLKMNEMLLL<GLMCIKGKCFG> CELBLIHMCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JJLKMNEMLLL<OMEPBNMDOOI> MCHGDLMODKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JJLKMNEMLLL<KJEDFHBBPGK> HKDCLIEFGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JJLKMNEMLLL<EDPKFFIMOMC> LNAPCFMDJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JJLKMNEMLLL<HLNCNEOFKGK> FCGBONPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JJLKMNEMLLL<ENFHCMKIOHI> HLACIIBJNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84FCE0", Offset = "0x84E6E0", VA = "0x18084FCE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7132F40", Offset = "0x7131940", VA = "0x187132F40")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.GameOnly)]
	[UsedImplicitly]
	private static void HKLKPMFNMFN(GPECMKAJNMD MJAMFOPMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7132FB0", Offset = "0x71319B0", VA = "0x187132FB0")]
	[Preserve]
	public ANGCIGOHFCJ()
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
