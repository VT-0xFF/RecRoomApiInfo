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
	[Cpp2IlInjected.Address(RVA = "0x71A6C20", Offset = "0x71A5220", VA = "0x1871A6C20")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void KOPFFNBBLLA(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71A6040", Offset = "0x71A4640", VA = "0x1871A6040")]
	[UsedImplicitly]
	[PECFDJPHGEK(BOIKMOKIOJG.EditorOnly)]
	private static void FCGAAGGMCDI(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	[Preserve]
	public DHIHFGFKAAJ([JFHFHOOOEKP(null)] LAAMNMEBFLF BNAJHALNKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x71A6760", Offset = "0x71A4D60", VA = "0x1871A6760", Slot = "4")]
	public string KLDBPIDHOEH(MMILDBOFIKL CPEKGDIIDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71A60A0", Offset = "0x71A46A0", VA = "0x1871A60A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
		public SerializedAvatarItemId(AJKMIEONCMG BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public AJKMIEONCMG JGNOLJBBCJA()
		{
			return default(AJKMIEONCMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71B6130", Offset = "0x71B4730", VA = "0x1871B6130", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71B61F0", Offset = "0x71B47F0", VA = "0x1871B61F0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public AFILLJLDDLH JGNOLJBBCJA()
		{
			return default(AFILLJLDDLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71B6260", Offset = "0x71B4860", VA = "0x1871B6260", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71B6300", Offset = "0x71B4900", VA = "0x1871B6300", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public CICICDBLCFP JGNOLJBBCJA()
		{
			return default(CICICDBLCFP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedColorId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedColorId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6370", Offset = "0x71B4970", VA = "0x1871B6370", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71B6410", Offset = "0x71B4A10", VA = "0x1871B6410", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x71B6630", Offset = "0x71B4C30", VA = "0x1871B6630")]
		public ENHFLJGMKFD JGNOLJBBCJA()
		{
			return default(ENHFLJGMKFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71B6710", Offset = "0x71B4D10", VA = "0x1871B6710")]
		public SerializedCombinationId(ENHFLJGMKFD PEEFEELGDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71B6480", Offset = "0x71B4A80", VA = "0x1871B6480")]
		private void CJLENEKJHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70442B0", Offset = "0x70428B0", VA = "0x1870442B0", Slot = "4")]
		public bool Equals(SerializedCombinationId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71B6580", Offset = "0x71B4B80", VA = "0x1871B6580", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedCombinationId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x71B66A0", Offset = "0x71B4CA0", VA = "0x1871B66A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71B6690", Offset = "0x71B4C90", VA = "0x1871B6690", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x71B67E0", Offset = "0x71B4DE0", VA = "0x1871B67E0")]
		public static SerializedEquipmentSkinId FGEHEMPMBCP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public ODHNKDBIOEC JGNOLJBBCJA()
		{
			return default(ODHNKDBIOEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71B6740", Offset = "0x71B4D40", VA = "0x1871B6740", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71B6810", Offset = "0x71B4E10", VA = "0x1871B6810", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public DONNKKJBKEB JGNOLJBBCJA()
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71B6880", Offset = "0x71B4E80", VA = "0x1871B6880", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71B6920", Offset = "0x71B4F20", VA = "0x1871B6920", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public FJODIMOLBCE JGNOLJBBCJA()
		{
			return default(FJODIMOLBCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71B6990", Offset = "0x71B4F90", VA = "0x1871B6990", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A30", Offset = "0x71B5030", VA = "0x1871B6A30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public CFBACMJFMHA JGNOLJBBCJA()
		{
			return default(CFBACMJFMHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0", Slot = "4")]
		public bool Equals(SerializedHairPatternId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71B6AA0", Offset = "0x71B50A0", VA = "0x1871B6AA0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71B61D0", Offset = "0x71B47D0", VA = "0x1871B61D0")]
		public static bool JEKPEIKHIPM(SerializedHairPatternId KKEPMPAJLEA, SerializedHairPatternId HIEMMBKCCDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71B6B40", Offset = "0x71B5140", VA = "0x1871B6B40", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FBD500", Offset = "0x1FBBB00", VA = "0x181FBD500")]
		public SerializedMaterialId(GMFEDAGMJBK BLCJLIJFBDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0", Slot = "6")]
		public Guid HBLPKCCEHAN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9D1FE0", Offset = "0x9D05E0", VA = "0x1809D1FE0")]
		public GMFEDAGMJBK JGNOLJBBCJA()
		{
			return default(GMFEDAGMJBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70442B0", Offset = "0x70428B0", VA = "0x1870442B0", Slot = "4")]
		public bool Equals(SerializedMaterialId LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6BB0", Offset = "0x71B51B0", VA = "0x1871B6BB0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA8F8C0", Offset = "0xA8DEC0", VA = "0x180A8F8C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70442B0", Offset = "0x70428B0", VA = "0x1870442B0")]
		public static bool JEKPEIKHIPM(SerializedMaterialId KKEPMPAJLEA, SerializedMaterialId HIEMMBKCCDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA8F6A0", Offset = "0xA8DCA0", VA = "0x180A8F6A0", Slot = "5")]
		public int CompareTo(SerializedMaterialId LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71B6C50", Offset = "0x71B5250", VA = "0x1871B6C50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x71A91F0", Offset = "0x71A77F0", VA = "0x1871A91F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FMGJFHCBAGJ<AJKMIEONCMG> BLKNCAOAGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71A90D0", Offset = "0x71A76D0", VA = "0x1871A90D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FMGJFHCBAGJ<ODHNKDBIOEC> NPNDJIFJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71A9250", Offset = "0x71A7850", VA = "0x1871A9250", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FMGJFHCBAGJ<CFBACMJFMHA> NPJGHALFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71A9190", Offset = "0x71A7790", VA = "0x1871A9190", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FMGJFHCBAGJ<ENHFLJGMKFD> JHKNBKLNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71A9130", Offset = "0x71A7730", VA = "0x1871A9130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FMGJFHCBAGJ<CICICDBLCFP> MLFIKKHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71A9010", Offset = "0x71A7610", VA = "0x1871A9010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FMGJFHCBAGJ<FJODIMOLBCE> PIDEBJBFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71A92B0", Offset = "0x71A78B0", VA = "0x1871A92B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FMGJFHCBAGJ<AFILLJLDDLH> FDFNNGLOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71A8FB0", Offset = "0x71A75B0", VA = "0x1871A8FB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FMGJFHCBAGJ<DONNKKJBKEB> BLMKIKGJKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71A9070", Offset = "0x71A7670", VA = "0x1871A9070", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x71ADF80", Offset = "0x71AC580", VA = "0x1871ADF80")]
	public static Guid ECHAMBLBOMB(string LCANFHLDCOB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71AE030", Offset = "0x71AC630", VA = "0x1871AE030")]
	public static bool JDKJPPMGBEH(string LCANFHLDCOB, [Out] Guid NNFEKLKANBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LMGOHDIKGCG : JBCAOPNOHCF<AJKMIEONCMG>, CFFCIBFLELN<AJKMIEONCMG>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71A9310", Offset = "0x71A7910", VA = "0x1871A9310", Slot = "4")]
	public IEnumerable<(AJKMIEONCMG, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x71ADF60", Offset = "0x71AC560", VA = "0x1871ADF60", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public AJKMIEONCMG BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(AJKMIEONCMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public LMGOHDIKGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CCBCOBOKIMH : JBCAOPNOHCF<AFILLJLDDLH>, CFFCIBFLELN<AFILLJLDDLH>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71A3BE0", Offset = "0x71A21E0", VA = "0x1871A3BE0", Slot = "4")]
	public IEnumerable<(AFILLJLDDLH, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public AFILLJLDDLH BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(AFILLJLDDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public CCBCOBOKIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CIKGINHDOEL : JBCAOPNOHCF<CICICDBLCFP>, CFFCIBFLELN<CICICDBLCFP>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x71A3F80", Offset = "0x71A2580", VA = "0x1871A3F80", Slot = "4")]
	public IEnumerable<(CICICDBLCFP, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public CICICDBLCFP BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(CICICDBLCFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	public EIDAKMKHCGK(CFFCIBFLELN<GMFEDAGMJBK> KCBLEPIKPDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70450A0", Offset = "0x70436A0", VA = "0x1870450A0", Slot = "4")]
	public IEnumerable<(ENHFLJGMKFD, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x71A73B0", Offset = "0x71A59B0", VA = "0x1871A73B0", Slot = "6")]
	public ENHFLJGMKFD BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(ENHFLJGMKFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71A76B0", Offset = "0x71A5CB0", VA = "0x1871A76B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NMNNBGAPNOP : JBCAOPNOHCF<ODHNKDBIOEC>, CFFCIBFLELN<ODHNKDBIOEC>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71AE100", Offset = "0x71AC700", VA = "0x1871AE100", Slot = "4")]
	public IEnumerable<(ODHNKDBIOEC, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public ODHNKDBIOEC BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(ODHNKDBIOEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public NMNNBGAPNOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class INGDGNELAJK : JBCAOPNOHCF<DONNKKJBKEB>, CFFCIBFLELN<DONNKKJBKEB>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71A76F0", Offset = "0x71A5CF0", VA = "0x1871A76F0", Slot = "4")]
	public IEnumerable<(DONNKKJBKEB, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public DONNKKJBKEB BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(DONNKKJBKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public INGDGNELAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PHGHGGDEDCG : JBCAOPNOHCF<FJODIMOLBCE>, CFFCIBFLELN<FJODIMOLBCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x71B5D10", Offset = "0x71B4310", VA = "0x1871B5D10", Slot = "4")]
	public IEnumerable<(FJODIMOLBCE, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public FJODIMOLBCE BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(FJODIMOLBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public PHGHGGDEDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EAFGGLDIGMF : JBCAOPNOHCF<CFBACMJFMHA>, CFFCIBFLELN<CFBACMJFMHA>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71A6D30", Offset = "0x71A5330", VA = "0x1871A6D30", Slot = "4")]
	public IEnumerable<(CFBACMJFMHA, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public CFBACMJFMHA BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(CFBACMJFMHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x70F9210", Offset = "0x70F7810", VA = "0x1870F9210", Slot = "4")]
	public IEnumerable<(GMFEDAGMJBK, string)> GHOPBEIPKGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA915B0", Offset = "0xA8FBB0", VA = "0x180A915B0", Slot = "5")]
	public string LNAHFLPLKNI(string IKHNEOGBOCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71A3B20", Offset = "0x71A2120", VA = "0x1871A3B20", Slot = "6")]
	public GMFEDAGMJBK BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return default(GMFEDAGMJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[Cpp2IlInjected.Address(RVA = "0x44ED530", Offset = "0x44EBB30", VA = "0x1844ED530")]
	public MOLJBIFHGKA(JBCAOPNOHCF<TModern> GGOHJIJDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x44EA380", Offset = "0x44E8980", VA = "0x1844EA380", Slot = "5")]
	public TModern BNEGMKHHGGG(string IKHNEOGBOCK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x44EBEC0", Offset = "0x44EA4C0", VA = "0x1844EBEC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FMGJFHCBAGJ<ODHNKDBIOEC> NPNDJIFJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FMGJFHCBAGJ<CFBACMJFMHA> NPJGHALFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FMGJFHCBAGJ<ENHFLJGMKFD> JHKNBKLNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FMGJFHCBAGJ<CICICDBLCFP> MLFIKKHFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FMGJFHCBAGJ<FJODIMOLBCE> PIDEBJBFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FMGJFHCBAGJ<AFILLJLDDLH> FDFNNGLOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FMGJFHCBAGJ<DONNKKJBKEB> BLMKIKGJKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71A35D0", Offset = "0x71A1BD0", VA = "0x1871A35D0")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.GameOnly)]
	[UsedImplicitly]
	private static void POFEHEPFKAG(DIIANKCHAHD MEBNPCGEJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71A3640", Offset = "0x71A1C40", VA = "0x1871A3640")]
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
