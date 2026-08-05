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
		[Cpp2IlInjected.Address(RVA = "0x8A08C90", Offset = "0x8A07290", VA = "0x188A08C90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IJDFJBHPCAJ : LMFLGOBIABL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex DHJLOKMFAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LGKJIPCELAF PONOHPHOPGC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8A027C0", Offset = "0x8A00DC0", VA = "0x188A027C0")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	[UsedImplicitly]
	internal static void GLAOIPJFGAH(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8A02830", Offset = "0x8A00E30", VA = "0x188A02830")]
	[UsedImplicitly]
	internal static void LEAHFBLPCGH(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	[RecRoom.NoEngine.Common.Preserve]
	public IJDFJBHPCAJ([GGNLMCAPMLP(null)] LGKJIPCELAF PONOHPHOPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8A02890", Offset = "0x8A00E90", VA = "0x188A02890", Slot = "4")]
	public string LGGJGPOGIBH(KAMKFCKINLN FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8A022F0", Offset = "0x8A008F0", VA = "0x188A022F0", Slot = "5")]
	public KAMKFCKINLN FJJOMODMCLM(string FCHACHIDAGA)
	{
		return default(KAMKFCKINLN);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public OLAHBCMDBEM FJJOMODMCLM()
		{
			return default(OLAHBCMDBEM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A08100", Offset = "0x8A06700", VA = "0x188A08100", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A081C0", Offset = "0x8A067C0", VA = "0x188A081C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public KALEKLMDJOG FJJOMODMCLM()
		{
			return default(KALEKLMDJOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A08230", Offset = "0x8A06830", VA = "0x188A08230", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8A082D0", Offset = "0x8A068D0", VA = "0x188A082D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public KFDECOOHAKA FJJOMODMCLM()
		{
			return default(KFDECOOHAKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedColorId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedColorId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A08340", Offset = "0x8A06940", VA = "0x188A08340", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A083E0", Offset = "0x8A069E0", VA = "0x188A083E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, FOAALLIHHLC, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		public ALBLDJNNKOA FJJOMODMCLM()
		{
			return default(ALBLDJNNKOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8893CA0", Offset = "0x88922A0", VA = "0x188893CA0", Slot = "4")]
		public bool Equals(SerializedCombinationId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A08450", Offset = "0x8A06A50", VA = "0x188A08450", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedCombinationId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A08510", Offset = "0x8A06B10", VA = "0x188A08510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A08500", Offset = "0x8A06B00", VA = "0x188A08500", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, FOAALLIHHLC
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
			[Cpp2IlInjected.Address(RVA = "0x8A086B0", Offset = "0x8A06CB0", VA = "0x188A086B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x13C1610", Offset = "0x13BFC10", VA = "0x1813C1610")]
		public SerializedCustomAvatarItemId(Guid PPIICOOCLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public static SerializedCustomAvatarItemId GNAFEDAOKMM(Guid PPIICOOCLEP)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A08580", Offset = "0x8A06B80", VA = "0x188A08580", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0")]
		public static bool JKIBMILPCGE(SerializedCustomAvatarItemId DBDIOGELIIH, SerializedCustomAvatarItemId LHANOGJMGBN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A08620", Offset = "0x8A06C20", VA = "0x188A08620")]
		public static bool FLMCEAOBGCC(SerializedCustomAvatarItemId DBDIOGELIIH, SerializedCustomAvatarItemId LHANOGJMGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A08640", Offset = "0x8A06C40", VA = "0x188A08640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x8A087B0", Offset = "0x8A06DB0", VA = "0x188A087B0")]
		public static SerializedEquipmentSkinId JLAGAAPCFEB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public KKEJCONAAEL FJJOMODMCLM()
		{
			return default(KKEJCONAAEL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8A08710", Offset = "0x8A06D10", VA = "0x188A08710", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A087E0", Offset = "0x8A06DE0", VA = "0x188A087E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public HBMNJKGCEPD FJJOMODMCLM()
		{
			return default(HBMNJKGCEPD);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A08850", Offset = "0x8A06E50", VA = "0x188A08850", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A088F0", Offset = "0x8A06EF0", VA = "0x188A088F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public BNGLIJOIOAL FJJOMODMCLM()
		{
			return default(BNGLIJOIOAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8A08960", Offset = "0x8A06F60", VA = "0x188A08960", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A08A00", Offset = "0x8A07000", VA = "0x188A08A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340")]
		public JJDBFDPKIAI FJJOMODMCLM()
		{
			return default(JJDBFDPKIAI);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0", Slot = "4")]
		public bool Equals(SerializedHairPatternId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedHairPatternId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8A08A70", Offset = "0x8A07070", VA = "0x188A08A70", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A081A0", Offset = "0x8A067A0", VA = "0x188A081A0")]
		public static bool JKIBMILPCGE(SerializedHairPatternId DBDIOGELIIH, SerializedHairPatternId LHANOGJMGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A08B10", Offset = "0x8A07110", VA = "0x188A08B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, FOAALLIHHLC
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
		[Cpp2IlInjected.Address(RVA = "0x118B340", Offset = "0x1189940", VA = "0x18118B340", Slot = "6")]
		public Guid BOIIJAKDNPH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8893CA0", Offset = "0x88922A0", VA = "0x188893CA0", Slot = "4")]
		public bool Equals(SerializedMaterialId HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8A08B80", Offset = "0x8A07180", VA = "0x188A08B80", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E24DC0", Offset = "0x7E233C0", VA = "0x187E24DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E24C30", Offset = "0x7E23230", VA = "0x187E24C30", Slot = "5")]
		public int CompareTo(SerializedMaterialId HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A08C20", Offset = "0x8A07220", VA = "0x188A08C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HCNOCDGFNIM : LGKJIPCELAF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HCNOCDGFNIM FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89F85C0", Offset = "0x89F6BC0", VA = "0x1889F85C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LNCPLAGEFJB<OLAHBCMDBEM> PLGGIFKGMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89F8500", Offset = "0x89F6B00", VA = "0x1889F8500", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LNCPLAGEFJB<KKEJCONAAEL> MDAABHGCNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x89F82C0", Offset = "0x89F68C0", VA = "0x1889F82C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LNCPLAGEFJB<JJDBFDPKIAI> LFDFGIEFOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x89F84A0", Offset = "0x89F6AA0", VA = "0x1889F84A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LNCPLAGEFJB<ALBLDJNNKOA> IJHILMEKODI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89F8440", Offset = "0x89F6A40", VA = "0x1889F8440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LNCPLAGEFJB<KFDECOOHAKA> DDNJAJMDILO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x89F8320", Offset = "0x89F6920", VA = "0x1889F8320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNCPLAGEFJB<BNGLIJOIOAL> HFBGFNBNGPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89F83E0", Offset = "0x89F69E0", VA = "0x1889F83E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LNCPLAGEFJB<KALEKLMDJOG> FKCKNAFEKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8380", Offset = "0x89F6980", VA = "0x1889F8380", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LNCPLAGEFJB<HBMNJKGCEPD> LBODMGANCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89F8560", Offset = "0x89F6B60", VA = "0x1889F8560", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NIPJAEPIADG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8A02C70", Offset = "0x8A01270", VA = "0x188A02C70")]
	public static Guid FCEAHACFBME(string CJNFOCKKEHB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8A02D20", Offset = "0x8A01320", VA = "0x188A02D20")]
	public static bool GFPCLNJKMMM(string CJNFOCKKEHB, [Out] Guid PPIICOOCLEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PBIKFOLOCIH : BLAFEEAMMAC<OLAHBCMDBEM>, PBBIFILNFDK<OLAHBCMDBEM>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8A03070", Offset = "0x8A01670", VA = "0x188A03070", Slot = "4")]
	public IEnumerable<(OLAHBCMDBEM, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8A07CC0", Offset = "0x8A062C0", VA = "0x188A07CC0", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public OLAHBCMDBEM CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(OLAHBCMDBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PBIKFOLOCIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GGBODIFIPKN : BLAFEEAMMAC<KALEKLMDJOG>, PBBIFILNFDK<KALEKLMDJOG>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x89F7F20", Offset = "0x89F6520", VA = "0x1889F7F20", Slot = "4")]
	public IEnumerable<(KALEKLMDJOG, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public KALEKLMDJOG CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(KALEKLMDJOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GGBODIFIPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HHBBCGDFALM : BLAFEEAMMAC<KFDECOOHAKA>, PBBIFILNFDK<KFDECOOHAKA>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x89F8620", Offset = "0x89F6C20", VA = "0x1889F8620", Slot = "4")]
	public IEnumerable<(KFDECOOHAKA, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public KFDECOOHAKA CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(KFDECOOHAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HHBBCGDFALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ODOKLHOJJKJ : BLAFEEAMMAC<ALBLDJNNKOA>, PBBIFILNFDK<ALBLDJNNKOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PBBIFILNFDK<OCELNMNLIHE> JPGDMPONKEM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public ODOKLHOJJKJ(PBBIFILNFDK<OCELNMNLIHE> JPGDMPONKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8895610", Offset = "0x8893C10", VA = "0x188895610", Slot = "4")]
	public IEnumerable<(ALBLDJNNKOA, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8A02DF0", Offset = "0x8A013F0", VA = "0x188A02DF0", Slot = "6")]
	public ALBLDJNNKOA CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(ALBLDJNNKOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8A03030", Offset = "0x8A01630", VA = "0x188A03030", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HHENPLIIHGF : BLAFEEAMMAC<KKEJCONAAEL>, PBBIFILNFDK<KKEJCONAAEL>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x89FA6E0", Offset = "0x89F8CE0", VA = "0x1889FA6E0", Slot = "4")]
	public IEnumerable<(KKEJCONAAEL, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public KKEJCONAAEL CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(KKEJCONAAEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HHENPLIIHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CILAGAOBKNJ : BLAFEEAMMAC<HBMNJKGCEPD>, PBBIFILNFDK<HBMNJKGCEPD>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x89F5FE0", Offset = "0x89F45E0", VA = "0x1889F5FE0", Slot = "4")]
	public IEnumerable<(HBMNJKGCEPD, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public HBMNJKGCEPD CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(HBMNJKGCEPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CILAGAOBKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class POFMNAOLAPF : BLAFEEAMMAC<BNGLIJOIOAL>, PBBIFILNFDK<BNGLIJOIOAL>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A07CE0", Offset = "0x8A062E0", VA = "0x188A07CE0", Slot = "4")]
	public IEnumerable<(BNGLIJOIOAL, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public BNGLIJOIOAL CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(BNGLIJOIOAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public POFMNAOLAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FBJHNCDNCCK : BLAFEEAMMAC<JJDBFDPKIAI>, PBBIFILNFDK<JJDBFDPKIAI>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x89F78A0", Offset = "0x89F5EA0", VA = "0x1889F78A0", Slot = "4")]
	public IEnumerable<(JJDBFDPKIAI, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public JJDBFDPKIAI CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(JJDBFDPKIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FBJHNCDNCCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BLAFEEAMMAC<TModern> : PBBIFILNFDK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DPHFFGALNLH();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string OIENFNJGJHJ(string LLBJLPONEAN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CPCGFAMGJDP : BLAFEEAMMAC<OCELNMNLIHE>, PBBIFILNFDK<OCELNMNLIHE>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x894A730", Offset = "0x8948D30", VA = "0x18894A730", Slot = "4")]
	public IEnumerable<(OCELNMNLIHE, string)> DPHFFGALNLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "5")]
	public string OIENFNJGJHJ(string LLBJLPONEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x89F5F20", Offset = "0x89F4520", VA = "0x1889F5F20", Slot = "6")]
	public OCELNMNLIHE CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return default(OCELNMNLIHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CPCGFAMGJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KCOOPNJGOPK<TModern> : LNCPLAGEFJB<TModern>, PBBIFILNFDK<TModern> where TModern : IEquatable<TModern>, FOAALLIHHLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> MOGENFBHLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> KLNLLNJFJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BLAFEEAMMAC<TModern> MLCIPFJCAAI;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x52932C0", Offset = "0x52918C0", VA = "0x1852932C0")]
	public KCOOPNJGOPK(BLAFEEAMMAC<TModern> MLCIPFJCAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5291930", Offset = "0x528FF30", VA = "0x185291930", Slot = "5")]
	public TModern CKHPDLDPCMG(string LLBJLPONEAN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52927E0", Offset = "0x5290DE0", VA = "0x1852927E0", Slot = "4")]
	public string MBDCFDHDICE(TModern EGBKGHLKEEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ABOFLBIPDJH : LGKJIPCELAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private KCOOPNJGOPK<OLAHBCMDBEM> DAKAKFMFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KCOOPNJGOPK<KKEJCONAAEL> MOPLKAHGMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KCOOPNJGOPK<JJDBFDPKIAI> NFDNGOKDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private KCOOPNJGOPK<OCELNMNLIHE> JPGDMPONKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KCOOPNJGOPK<ALBLDJNNKOA> FHOPBJOLMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KCOOPNJGOPK<KFDECOOHAKA> BFLLELPJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private KCOOPNJGOPK<BNGLIJOIOAL> LIAKHKMKKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KCOOPNJGOPK<KALEKLMDJOG> NIHALHCBDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KCOOPNJGOPK<HBMNJKGCEPD> AKOLIFHODFB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LNCPLAGEFJB<OLAHBCMDBEM> PLGGIFKGMPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LNCPLAGEFJB<KKEJCONAAEL> MDAABHGCNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LNCPLAGEFJB<JJDBFDPKIAI> LFDFGIEFOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LNCPLAGEFJB<ALBLDJNNKOA> IJHILMEKODI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LNCPLAGEFJB<KFDECOOHAKA> DDNJAJMDILO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LNCPLAGEFJB<BNGLIJOIOAL> HFBGFNBNGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LNCPLAGEFJB<KALEKLMDJOG> FKCKNAFEKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LNCPLAGEFJB<HBMNJKGCEPD> LBODMGANCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x89F59D0", Offset = "0x89F3FD0", VA = "0x1889F59D0")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	[UsedImplicitly]
	internal static void BGFKKOPDAMP(DCNOMJHNEOK PPICPBELMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x89F5A40", Offset = "0x89F4040", VA = "0x1889F5A40")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABOFLBIPDJH()
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
