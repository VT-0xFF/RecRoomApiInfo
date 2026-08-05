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
public class DHIHFGFKAAJ : LLAJMKIJMMD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex AKIBOABIEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly LAAMNMEBFLF BNAJHALNKBG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71DBC50", Offset = "0x71DAC50", VA = "0x1871DBC50")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void KOPFFNBBLLA(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71DB050", Offset = "0x71DA050", VA = "0x1871DB050")]
	[UsedImplicitly]
	[PECFDJPHGEK(BOIKMOKIOJG.EditorOnly)]
	private static void FCGAAGGMCDI(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	[Preserve]
	public DHIHFGFKAAJ([JFHFHOOOEKP(null)] LAAMNMEBFLF BNAJHALNKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71DB790", Offset = "0x71DA790", VA = "0x1871DB790", Slot = "4")]
	public string KLDBPIDHOEH(MMILDBOFIKL CPEKGDIIDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71DB0B0", Offset = "0x71DA0B0", VA = "0x1871DB0B0", Slot = "5")]
	public MMILDBOFIKL JGNOLJBBCJA(string CPEKGDIIDKL)
	{
		return default(MMILDBOFIKL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
		public SerializedAvatarItemId(AJKMIEONCMG BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public AJKMIEONCMG JGNOLJBBCJA()
		{
			return default(AJKMIEONCMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71EB160", Offset = "0x71EA160", VA = "0x1871EB160", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71EB220", Offset = "0x71EA220", VA = "0x1871EB220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public AFILLJLDDLH JGNOLJBBCJA()
		{
			return default(AFILLJLDDLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71EB290", Offset = "0x71EA290", VA = "0x1871EB290", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71EB330", Offset = "0x71EA330", VA = "0x1871EB330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public CICICDBLCFP JGNOLJBBCJA()
		{
			return default(CICICDBLCFP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedColorId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedColorId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71EB3A0", Offset = "0x71EA3A0", VA = "0x1871EB3A0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71EB440", Offset = "0x71EA440", VA = "0x1871EB440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, FOOBKOEHCJF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x71EB660", Offset = "0x71EA660", VA = "0x1871EB660")]
		public ENHFLJGMKFD JGNOLJBBCJA()
		{
			return default(ENHFLJGMKFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71EB740", Offset = "0x71EA740", VA = "0x1871EB740")]
		public SerializedCombinationId(ENHFLJGMKFD PEEFEELGDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71EB4B0", Offset = "0x71EA4B0", VA = "0x1871EB4B0")]
		private void CJLENEKJHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70792C0", Offset = "0x70782C0", VA = "0x1870792C0", Slot = "4")]
		public bool Equals(SerializedCombinationId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71EB5B0", Offset = "0x71EA5B0", VA = "0x1871EB5B0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedCombinationId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71EB6D0", Offset = "0x71EA6D0", VA = "0x1871EB6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71EB6C0", Offset = "0x71EA6C0", VA = "0x1871EB6C0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x71EB810", Offset = "0x71EA810", VA = "0x1871EB810")]
		public static SerializedEquipmentSkinId FGEHEMPMBCP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public ODHNKDBIOEC JGNOLJBBCJA()
		{
			return default(ODHNKDBIOEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71EB770", Offset = "0x71EA770", VA = "0x1871EB770", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71EB840", Offset = "0x71EA840", VA = "0x1871EB840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public DONNKKJBKEB JGNOLJBBCJA()
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71EB8B0", Offset = "0x71EA8B0", VA = "0x1871EB8B0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71EB950", Offset = "0x71EA950", VA = "0x1871EB950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public FJODIMOLBCE JGNOLJBBCJA()
		{
			return default(FJODIMOLBCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71EB9C0", Offset = "0x71EA9C0", VA = "0x1871EB9C0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71EBA60", Offset = "0x71EAA60", VA = "0x1871EBA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public CFBACMJFMHA JGNOLJBBCJA()
		{
			return default(CFBACMJFMHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200", Slot = "4")]
		public bool Equals(SerializedHairPatternId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71EBAD0", Offset = "0x71EAAD0", VA = "0x1871EBAD0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71EB200", Offset = "0x71EA200", VA = "0x1871EB200")]
		public static bool JEKPEIKHIPM(SerializedHairPatternId KKEPMPAJLEA, SerializedHairPatternId HIEMMBKCCDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71EBB70", Offset = "0x71EAB70", VA = "0x1871EBB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, FOOBKOEHCJF
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
		[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
		public SerializedMaterialId(GMFEDAGMJBK BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public GMFEDAGMJBK JGNOLJBBCJA()
		{
			return default(GMFEDAGMJBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70792C0", Offset = "0x70782C0", VA = "0x1870792C0", Slot = "4")]
		public bool Equals(SerializedMaterialId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71EBBE0", Offset = "0x71EABE0", VA = "0x1871EBBE0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA94540", Offset = "0xA93540", VA = "0x180A94540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70792C0", Offset = "0x70782C0", VA = "0x1870792C0")]
		public static bool JEKPEIKHIPM(SerializedMaterialId KKEPMPAJLEA, SerializedMaterialId HIEMMBKCCDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA94320", Offset = "0xA93320", VA = "0x180A94320", Slot = "5")]
		public int CompareTo(SerializedMaterialId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71EBC80", Offset = "0x71EAC80", VA = "0x1871EBC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KGOCLGGCFKK : LAAMNMEBFLF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KGOCLGGCFKK IBMHAACFGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71DE220", Offset = "0x71DD220", VA = "0x1871DE220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FMGJFHCBAGJ<AJKMIEONCMG> BLKNCAOAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71DE100", Offset = "0x71DD100", VA = "0x1871DE100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FMGJFHCBAGJ<ODHNKDBIOEC> NPNDJIFJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71DE280", Offset = "0x71DD280", VA = "0x1871DE280", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FMGJFHCBAGJ<CFBACMJFMHA> NPJGHALFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71DE1C0", Offset = "0x71DD1C0", VA = "0x1871DE1C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FMGJFHCBAGJ<ENHFLJGMKFD> JHKNBKLNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71DE160", Offset = "0x71DD160", VA = "0x1871DE160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FMGJFHCBAGJ<CICICDBLCFP> MLFIKKHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71DE040", Offset = "0x71DD040", VA = "0x1871DE040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FMGJFHCBAGJ<FJODIMOLBCE> PIDEBJBFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71DE2E0", Offset = "0x71DD2E0", VA = "0x1871DE2E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FMGJFHCBAGJ<AFILLJLDDLH> FDFNNGLOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71DDFE0", Offset = "0x71DCFE0", VA = "0x1871DDFE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FMGJFHCBAGJ<DONNKKJBKEB> BLMKIKGJKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71DE0A0", Offset = "0x71DD0A0", VA = "0x1871DE0A0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MANMCPJGPMG
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71E2FB0", Offset = "0x71E1FB0", VA = "0x1871E2FB0")]
	public static Guid ECHAMBLBOMB(string LCANFHLDCOB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71E3060", Offset = "0x71E2060", VA = "0x1871E3060")]
	public static bool JDKJPPMGBEH(string LCANFHLDCOB, [Out] Guid NNFEKLKANBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LMGOHDIKGCG : JBCAOPNOHCF<AJKMIEONCMG>, CFFCIBFLELN<AJKMIEONCMG>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71DE340", Offset = "0x71DD340", VA = "0x1871DE340", Slot = "4")]
	public IEnumerable<(AJKMIEONCMG, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71E2F90", Offset = "0x71E1F90", VA = "0x1871E2F90", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public AJKMIEONCMG BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(AJKMIEONCMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public LMGOHDIKGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CCBCOBOKIMH : JBCAOPNOHCF<AFILLJLDDLH>, CFFCIBFLELN<AFILLJLDDLH>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71D8BF0", Offset = "0x71D7BF0", VA = "0x1871D8BF0", Slot = "4")]
	public IEnumerable<(AFILLJLDDLH, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public AFILLJLDDLH BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(AFILLJLDDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public CCBCOBOKIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CIKGINHDOEL : JBCAOPNOHCF<CICICDBLCFP>, CFFCIBFLELN<CICICDBLCFP>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71D8F90", Offset = "0x71D7F90", VA = "0x1871D8F90", Slot = "4")]
	public IEnumerable<(CICICDBLCFP, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public CICICDBLCFP BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(CICICDBLCFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public CIKGINHDOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EIDAKMKHCGK : JBCAOPNOHCF<ENHFLJGMKFD>, CFFCIBFLELN<ENHFLJGMKFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CFFCIBFLELN<GMFEDAGMJBK> KCBLEPIKPDA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	public EIDAKMKHCGK(CFFCIBFLELN<GMFEDAGMJBK> KCBLEPIKPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x707A0B0", Offset = "0x70790B0", VA = "0x18707A0B0", Slot = "4")]
	public IEnumerable<(ENHFLJGMKFD, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71DC3E0", Offset = "0x71DB3E0", VA = "0x1871DC3E0", Slot = "6")]
	public ENHFLJGMKFD BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(ENHFLJGMKFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71DC6E0", Offset = "0x71DB6E0", VA = "0x1871DC6E0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NMNNBGAPNOP : JBCAOPNOHCF<ODHNKDBIOEC>, CFFCIBFLELN<ODHNKDBIOEC>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71E3130", Offset = "0x71E2130", VA = "0x1871E3130", Slot = "4")]
	public IEnumerable<(ODHNKDBIOEC, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public ODHNKDBIOEC BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(ODHNKDBIOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public NMNNBGAPNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class INGDGNELAJK : JBCAOPNOHCF<DONNKKJBKEB>, CFFCIBFLELN<DONNKKJBKEB>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71DC720", Offset = "0x71DB720", VA = "0x1871DC720", Slot = "4")]
	public IEnumerable<(DONNKKJBKEB, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public DONNKKJBKEB BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(DONNKKJBKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public INGDGNELAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PHGHGGDEDCG : JBCAOPNOHCF<FJODIMOLBCE>, CFFCIBFLELN<FJODIMOLBCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x71EAD40", Offset = "0x71E9D40", VA = "0x1871EAD40", Slot = "4")]
	public IEnumerable<(FJODIMOLBCE, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public FJODIMOLBCE BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(FJODIMOLBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public PHGHGGDEDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EAFGGLDIGMF : JBCAOPNOHCF<CFBACMJFMHA>, CFFCIBFLELN<CFBACMJFMHA>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71DBD60", Offset = "0x71DAD60", VA = "0x1871DBD60", Slot = "4")]
	public IEnumerable<(CFBACMJFMHA, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public CFBACMJFMHA BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(CFBACMJFMHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public EAFGGLDIGMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JBCAOPNOHCF<TModern> : CFFCIBFLELN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> GHOPBEIPKGO();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LNAHFLPLKNI(string IKHNEOGBOCK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EGLHINLMMFM : JBCAOPNOHCF<GMFEDAGMJBK>, CFFCIBFLELN<GMFEDAGMJBK>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x712E220", Offset = "0x712D220", VA = "0x18712E220", Slot = "4")]
	public IEnumerable<(GMFEDAGMJBK, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA96230", Offset = "0xA95230", VA = "0x180A96230", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71D8B30", Offset = "0x71D7B30", VA = "0x1871D8B30", Slot = "6")]
	public GMFEDAGMJBK BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(GMFEDAGMJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public EGLHINLMMFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MOLJBIFHGKA<TModern> : FMGJFHCBAGJ<TModern>, CFFCIBFLELN<TModern> where TModern : IEquatable<TModern>, FOOBKOEHCJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> FHLGPPFGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> FPLCJNOBIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly JBCAOPNOHCF<TModern> GGOHJIJDOCK;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x450DD20", Offset = "0x450CD20", VA = "0x18450DD20")]
	public MOLJBIFHGKA(JBCAOPNOHCF<TModern> GGOHJIJDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x450AB70", Offset = "0x4509B70", VA = "0x18450AB70", Slot = "5")]
	public TModern BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x450C6B0", Offset = "0x450B6B0", VA = "0x18450C6B0", Slot = "4")]
	public string GFEMGFNDKPE(TModern GNGGNFGHBBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ACIMCMEEBKG : LAAMNMEBFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MOLJBIFHGKA<AJKMIEONCMG> IEMAGBFNJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MOLJBIFHGKA<ODHNKDBIOEC> GFIJMGPCHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MOLJBIFHGKA<CFBACMJFMHA> AHMCNKPIHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MOLJBIFHGKA<GMFEDAGMJBK> KCBLEPIKPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MOLJBIFHGKA<ENHFLJGMKFD> JAENGELOBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MOLJBIFHGKA<CICICDBLCFP> MILCOALNIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MOLJBIFHGKA<FJODIMOLBCE> CJJOGEJCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MOLJBIFHGKA<AFILLJLDDLH> GCKLCBJOJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MOLJBIFHGKA<DONNKKJBKEB> KKJGFOCGAOE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FMGJFHCBAGJ<AJKMIEONCMG> BLKNCAOAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FMGJFHCBAGJ<ODHNKDBIOEC> NPNDJIFJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FMGJFHCBAGJ<CFBACMJFMHA> NPJGHALFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FMGJFHCBAGJ<ENHFLJGMKFD> JHKNBKLNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FMGJFHCBAGJ<CICICDBLCFP> MLFIKKHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FMGJFHCBAGJ<FJODIMOLBCE> PIDEBJBFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x870C70", Offset = "0x86FC70", VA = "0x180870C70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FMGJFHCBAGJ<AFILLJLDDLH> FDFNNGLOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86B9A0", Offset = "0x86A9A0", VA = "0x18086B9A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FMGJFHCBAGJ<DONNKKJBKEB> BLMKIKGJKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x866DF0", Offset = "0x865DF0", VA = "0x180866DF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71D85E0", Offset = "0x71D75E0", VA = "0x1871D85E0")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void POFEHEPFKAG(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71D8650", Offset = "0x71D7650", VA = "0x1871D8650")]
	[Preserve]
	public ACIMCMEEBKG()
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
