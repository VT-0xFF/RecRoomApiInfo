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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7520270", Offset = "0x751F470", VA = "0x187520270", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GHADGBPEJHJ : MPHNFBMHBNO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex OOCGJNDFENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BEJANLLLKLB LGLHNJPHIGK;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7517210", Offset = "0x7516410", VA = "0x187517210")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	[UsedImplicitly]
	internal static void BMGOJHCGLFB(KHAIBIPGEJP BDIDKDEEDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7517280", Offset = "0x7516480", VA = "0x187517280")]
	[UsedImplicitly]
	internal static void FPJGDFBJIGJ(KHAIBIPGEJP BDIDKDEEDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	[RecRoom.NoEngine.Common.Preserve]
	public GHADGBPEJHJ([GEFLINBOFNF(null)] BEJANLLLKLB LGLHNJPHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75177A0", Offset = "0x75169A0", VA = "0x1875177A0", Slot = "4")]
	public string LMOHAAKIFFE(LGIGHIHBKAO GJDJIDOLBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75172E0", Offset = "0x75164E0", VA = "0x1875172E0", Slot = "5")]
	public LGIGHIHBKAO GBKBNNNFJGC(string GJDJIDOLBAE)
	{
		return default(LGIGHIHBKAO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public SerializedAvatarItemId(ODIOBCFCCOG MHMAFIBKDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public ODIOBCFCCOG GBKBNNNFJGC()
		{
			return default(ODIOBCFCCOG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x751F750", Offset = "0x751E950", VA = "0x18751F750", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x751F810", Offset = "0x751EA10", VA = "0x18751F810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public NBLMKFLHGGA GBKBNNNFJGC()
		{
			return default(NBLMKFLHGGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x751F880", Offset = "0x751EA80", VA = "0x18751F880", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x751F920", Offset = "0x751EB20", VA = "0x18751F920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public GEBFPKLICLC GBKBNNNFJGC()
		{
			return default(GEBFPKLICLC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedColorId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedColorId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x751F990", Offset = "0x751EB90", VA = "0x18751F990", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x751FA30", Offset = "0x751EC30", VA = "0x18751FA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, LPODAIJOFKC, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0")]
		public FPAFDHKJIGP GBKBNNNFJGC()
		{
			return default(FPAFDHKJIGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x751FBD0", Offset = "0x751EDD0", VA = "0x18751FBD0")]
		public SerializedCombinationId(FPAFDHKJIGP MHCCGDDCFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73AB7D0", Offset = "0x73AA9D0", VA = "0x1873AB7D0", Slot = "4")]
		public bool Equals(SerializedCombinationId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x751FAA0", Offset = "0x751ECA0", VA = "0x18751FAA0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedCombinationId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x751FB60", Offset = "0x751ED60", VA = "0x18751FB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x751FB50", Offset = "0x751ED50", VA = "0x18751FB50", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public SerializedCustomAvatarItemId(Guid KGBBBBHDKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x751FBE0", Offset = "0x751EDE0", VA = "0x18751FBE0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0")]
		public static bool IELJJBKMIFI(SerializedCustomAvatarItemId PCICJLNHPMM, SerializedCustomAvatarItemId OIJJJJFPNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x751FC80", Offset = "0x751EE80", VA = "0x18751FC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0x751FD90", Offset = "0x751EF90", VA = "0x18751FD90")]
		public static SerializedEquipmentSkinId LHIIFAKGGKK()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public FAGOMDOIJDM GBKBNNNFJGC()
		{
			return default(FAGOMDOIJDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x751FCF0", Offset = "0x751EEF0", VA = "0x18751FCF0", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x751FDC0", Offset = "0x751EFC0", VA = "0x18751FDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public DIAKMFLOOAA GBKBNNNFJGC()
		{
			return default(DIAKMFLOOAA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x751FE30", Offset = "0x751F030", VA = "0x18751FE30", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x751FED0", Offset = "0x751F0D0", VA = "0x18751FED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public LHALHLNOGDB GBKBNNNFJGC()
		{
			return default(LHALHLNOGDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x751FF40", Offset = "0x751F140", VA = "0x18751FF40", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x751FFE0", Offset = "0x751F1E0", VA = "0x18751FFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public ADHGKFCEMKH GBKBNNNFJGC()
		{
			return default(ADHGKFCEMKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0", Slot = "4")]
		public bool Equals(SerializedHairPatternId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedHairPatternId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7520050", Offset = "0x751F250", VA = "0x187520050", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x751F7F0", Offset = "0x751E9F0", VA = "0x18751F7F0")]
		public static bool IELJJBKMIFI(SerializedHairPatternId PCICJLNHPMM, SerializedHairPatternId OIJJJJFPNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75200F0", Offset = "0x751F2F0", VA = "0x1875200F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, LPODAIJOFKC
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
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public SerializedMaterialId(CKOHHNJGGJB MHMAFIBKDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
		public Guid HFODIEEOGLP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73AB7D0", Offset = "0x73AA9D0", VA = "0x1873AB7D0", Slot = "4")]
		public bool Equals(SerializedMaterialId KDHPJMADEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7520160", Offset = "0x751F360", VA = "0x187520160", Slot = "0")]
		public override bool Equals(object JMJAOKJJFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD35C90", Offset = "0xD34E90", VA = "0x180D35C90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD35B00", Offset = "0xD34D00", VA = "0x180D35B00", Slot = "5")]
		public int CompareTo(SerializedMaterialId KDHPJMADEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7520200", Offset = "0x751F400", VA = "0x187520200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DMPFFMOMAEK : BEJANLLLKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DMPFFMOMAEK FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x750EAD0", Offset = "0x750DCD0", VA = "0x18750EAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MHOPPHPACNL<ODIOBCFCCOG> EEGJNCOIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x750EA10", Offset = "0x750DC10", VA = "0x18750EA10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MHOPPHPACNL<FAGOMDOIJDM> DJDIEBKNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x750EBF0", Offset = "0x750DDF0", VA = "0x18750EBF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MHOPPHPACNL<ADHGKFCEMKH> ELIAHKEHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x750ECB0", Offset = "0x750DEB0", VA = "0x18750ECB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MHOPPHPACNL<FPAFDHKJIGP> HOMHEPKEPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x750EA70", Offset = "0x750DC70", VA = "0x18750EA70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MHOPPHPACNL<GEBFPKLICLC> HDKJGICDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x750EB30", Offset = "0x750DD30", VA = "0x18750EB30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MHOPPHPACNL<LHALHLNOGDB> LLAIPJLPJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x750EC50", Offset = "0x750DE50", VA = "0x18750EC50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MHOPPHPACNL<NBLMKFLHGGA> FHPPCHJJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x750EB90", Offset = "0x750DD90", VA = "0x18750EB90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MHOPPHPACNL<DIAKMFLOOAA> CKEAKMADPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x750E9B0", Offset = "0x750DBB0", VA = "0x18750E9B0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HOKFBDCDFFN
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7517C50", Offset = "0x7516E50", VA = "0x187517C50")]
	public static Guid PJPIFBNKMHD(string HHKGKEJPBMD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7517B80", Offset = "0x7516D80", VA = "0x187517B80")]
	public static bool EFALEEDOOFN(string HHKGKEJPBMD, [Out] Guid KGBBBBHDKAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IHPIGAIICOE : KBKBJGCEJGB<ODIOBCFCCOG>, CDJAFDNENCP<ODIOBCFCCOG>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7517D20", Offset = "0x7516F20", VA = "0x187517D20", Slot = "4")]
	public IEnumerable<(ODIOBCFCCOG, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7517D00", Offset = "0x7516F00", VA = "0x187517D00", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public ODIOBCFCCOG GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(ODIOBCFCCOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public IHPIGAIICOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GFECPDFIFAK : KBKBJGCEJGB<NBLMKFLHGGA>, CDJAFDNENCP<NBLMKFLHGGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7516E70", Offset = "0x7516070", VA = "0x187516E70", Slot = "4")]
	public IEnumerable<(NBLMKFLHGGA, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public NBLMKFLHGGA GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(NBLMKFLHGGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GFECPDFIFAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MPHMKPCBNKE : KBKBJGCEJGB<GEBFPKLICLC>, CDJAFDNENCP<GEBFPKLICLC>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x751C970", Offset = "0x751BB70", VA = "0x18751C970", Slot = "4")]
	public IEnumerable<(GEBFPKLICLC, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public GEBFPKLICLC GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(GEBFPKLICLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public MPHMKPCBNKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OPHOGIGBCHK : KBKBJGCEJGB<FPAFDHKJIGP>, CDJAFDNENCP<FPAFDHKJIGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CDJAFDNENCP<CKOHHNJGGJB> HCHAAIIJGEO;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	public OPHOGIGBCHK(CDJAFDNENCP<CKOHHNJGGJB> HCHAAIIJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73ACC70", Offset = "0x73ABE70", VA = "0x1873ACC70", Slot = "4")]
	public IEnumerable<(FPAFDHKJIGP, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x751F0F0", Offset = "0x751E2F0", VA = "0x18751F0F0", Slot = "6")]
	public FPAFDHKJIGP GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(FPAFDHKJIGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x751F0B0", Offset = "0x751E2B0", VA = "0x18751F0B0", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EKCNAAJIOID : KBKBJGCEJGB<FAGOMDOIJDM>, CDJAFDNENCP<FAGOMDOIJDM>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x750F260", Offset = "0x750E460", VA = "0x18750F260", Slot = "4")]
	public IEnumerable<(FAGOMDOIJDM, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public FAGOMDOIJDM GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(FAGOMDOIJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public EKCNAAJIOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CAKCGJLOMAH : KBKBJGCEJGB<DIAKMFLOOAA>, CDJAFDNENCP<DIAKMFLOOAA>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x750D0F0", Offset = "0x750C2F0", VA = "0x18750D0F0", Slot = "4")]
	public IEnumerable<(DIAKMFLOOAA, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public DIAKMFLOOAA GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(DIAKMFLOOAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public CAKCGJLOMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PNIKCBFLDHN : KBKBJGCEJGB<LHALHLNOGDB>, CDJAFDNENCP<LHALHLNOGDB>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x751F330", Offset = "0x751E530", VA = "0x18751F330", Slot = "4")]
	public IEnumerable<(LHALHLNOGDB, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public LHALHLNOGDB GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(LHALHLNOGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public PNIKCBFLDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OJBHHNNEIFL : KBKBJGCEJGB<ADHGKFCEMKH>, CDJAFDNENCP<ADHGKFCEMKH>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x751EA30", Offset = "0x751DC30", VA = "0x18751EA30", Slot = "4")]
	public IEnumerable<(ADHGKFCEMKH, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public ADHGKFCEMKH GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(ADHGKFCEMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public OJBHHNNEIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KBKBJGCEJGB<TModern> : CDJAFDNENCP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> OFFKLNOAJAG();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CLMMGPCPJOO(string DABAHNBGCGM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AHHIIHCMINH : KBKBJGCEJGB<CKOHHNJGGJB>, CDJAFDNENCP<CKOHHNJGGJB>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7461D90", Offset = "0x7460F90", VA = "0x187461D90", Slot = "4")]
	public IEnumerable<(CKOHHNJGGJB, string)> OFFKLNOAJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x96A020", Offset = "0x969220", VA = "0x18096A020", Slot = "5")]
	public string CLMMGPCPJOO(string DABAHNBGCGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x750D030", Offset = "0x750C230", VA = "0x18750D030", Slot = "6")]
	public CKOHHNJGGJB GECKOMFJIDF(string DABAHNBGCGM)
	{
		return default(CKOHHNJGGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AHHIIHCMINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NLKGJNKJKFA<TModern> : MHOPPHPACNL<TModern>, CDJAFDNENCP<TModern> where TModern : IEquatable<TModern>, LPODAIJOFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> JLAJPMGHLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> BKNHCLBFJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly KBKBJGCEJGB<TModern> IAADGOLHPJB;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4860970", Offset = "0x485FB70", VA = "0x184860970")]
	public NLKGJNKJKFA(KBKBJGCEJGB<TModern> IAADGOLHPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x485EB30", Offset = "0x485DD30", VA = "0x18485EB30", Slot = "5")]
	public TModern GECKOMFJIDF(string DABAHNBGCGM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x485F3C0", Offset = "0x485E5C0", VA = "0x18485F3C0", Slot = "4")]
	public string IIPGMLBJBLK(TModern HCJJBJIOMBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EDAMJJIPJIM : BEJANLLLKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NLKGJNKJKFA<ODIOBCFCCOG> BGEIMPEJMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NLKGJNKJKFA<FAGOMDOIJDM> IFFKOLLALBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NLKGJNKJKFA<ADHGKFCEMKH> FMHLFJLLBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NLKGJNKJKFA<CKOHHNJGGJB> HCHAAIIJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NLKGJNKJKFA<FPAFDHKJIGP> PIOODKNMALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NLKGJNKJKFA<GEBFPKLICLC> DCAJNKIBPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NLKGJNKJKFA<LHALHLNOGDB> CDKJIAMNAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NLKGJNKJKFA<NBLMKFLHGGA> PKNHOBMDLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NLKGJNKJKFA<DIAKMFLOOAA> LCMNNLFBODE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MHOPPHPACNL<ODIOBCFCCOG> EEGJNCOIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MHOPPHPACNL<FAGOMDOIJDM> DJDIEBKNGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MHOPPHPACNL<ADHGKFCEMKH> ELIAHKEHIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MHOPPHPACNL<FPAFDHKJIGP> HOMHEPKEPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MHOPPHPACNL<GEBFPKLICLC> HDKJGICDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MHOPPHPACNL<LHALHLNOGDB> LLAIPJLPJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MHOPPHPACNL<NBLMKFLHGGA> FHPPCHJJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MHOPPHPACNL<DIAKMFLOOAA> CKEAKMADPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x750ED10", Offset = "0x750DF10", VA = "0x18750ED10")]
	[NPIOOMADHDK.JLDADBHPDAA.GOAAFNNCHDN]
	[UsedImplicitly]
	internal static void HGOIHNBOMNM(KHAIBIPGEJP BDIDKDEEDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x750ED80", Offset = "0x750DF80", VA = "0x18750ED80")]
	[RecRoom.NoEngine.Common.Preserve]
	public EDAMJJIPJIM()
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
