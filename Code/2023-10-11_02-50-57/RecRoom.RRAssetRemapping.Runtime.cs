using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PMEMNCLCMHN : DCELPGDDPNG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex IDMFOJKMPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly EDLHFAEHJIC PJDBHFKPHMC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62CA760", Offset = "0x62C9560", VA = "0x1862CA760")]
	[GAPOPKHLLNB(OGJCEJIMIKL.GameOnly)]
	private static void NHJLANHPGEE(OILPPPCALMB IDMCGGBGLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62CA700", Offset = "0x62C9500", VA = "0x1862CA700")]
	[GAPOPKHLLNB(OGJCEJIMIKL.EditorOnly)]
	private static void GNKFFOLDAKI(OILPPPCALMB IDMCGGBGLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	[Preserve]
	public PMEMNCLCMHN([NMBHAKGIBHG(null)] EDLHFAEHJIC PJDBHFKPHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62CA240", Offset = "0x62C9040", VA = "0x1862CA240", Slot = "4")]
	public string GKMCGBDALGF(DLMLPLPLKBA ENGEPLNNBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62C9B80", Offset = "0x62C8980", VA = "0x1862C9B80", Slot = "5")]
	public DLMLPLPLKBA EFHLMHLMFOG(string ENGEPLNNBDC)
	{
		return default(DLMLPLPLKBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LOBKIMFAJAN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62C8F80", Offset = "0x62C7D80", VA = "0x1862C8F80")]
	public static EDLHFAEHJIC GLACNDJJAMA()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public SerializedAvatarItemId(JFJOENEOEEK NBHCOBHPFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public JFJOENEOEEK EFHLMHLMFOG()
		{
			return default(JFJOENEOEEK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB090", Offset = "0x62C9E90", VA = "0x1862CB090", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62CB160", Offset = "0x62C9F60", VA = "0x1862CB160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public NGEIMOEOPCO EFHLMHLMFOG()
		{
			return default(NGEIMOEOPCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62CB1D0", Offset = "0x62C9FD0", VA = "0x1862CB1D0", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62CB270", Offset = "0x62CA070", VA = "0x1862CB270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public KFFJOEKIJAH EFHLMHLMFOG()
		{
			return default(KFFJOEKIJAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedColorId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedColorId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62CB2E0", Offset = "0x62CA0E0", VA = "0x1862CB2E0", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB380", Offset = "0x62CA180", VA = "0x1862CB380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, EHJFCIKJNAH, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x62CB3F0", Offset = "0x62CA1F0", VA = "0x1862CB3F0")]
		public GDNGPBHAAIH EFHLMHLMFOG()
		{
			return default(GDNGPBHAAIH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62CB680", Offset = "0x62CA480", VA = "0x1862CB680")]
		public SerializedCombinationId(GDNGPBHAAIH LIIMEILJJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62CB450", Offset = "0x62CA250", VA = "0x1862CB450")]
		private void ENPIHDFMIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D90070", Offset = "0x5D8EE70", VA = "0x185D90070", Slot = "4")]
		public bool Equals(SerializedCombinationId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62CB550", Offset = "0x62CA350", VA = "0x1862CB550", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedCombinationId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x62CB610", Offset = "0x62CA410", VA = "0x1862CB610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62CB600", Offset = "0x62CA400", VA = "0x1862CB600", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0x62CB750", Offset = "0x62CA550", VA = "0x1862CB750")]
		public static SerializedEquipmentSkinId IOEECNOIOIB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public HMCLDAHIPDM EFHLMHLMFOG()
		{
			return default(HMCLDAHIPDM);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB6B0", Offset = "0x62CA4B0", VA = "0x1862CB6B0", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62CB780", Offset = "0x62CA580", VA = "0x1862CB780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public NJILKKKHBCK EFHLMHLMFOG()
		{
			return default(NJILKKKHBCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62CB7F0", Offset = "0x62CA5F0", VA = "0x1862CB7F0", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62CB890", Offset = "0x62CA690", VA = "0x1862CB890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public BOMNBMOHBFK EFHLMHLMFOG()
		{
			return default(BOMNBMOHBFK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62CB900", Offset = "0x62CA700", VA = "0x1862CB900", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62CB9A0", Offset = "0x62CA7A0", VA = "0x1862CB9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public SerializedHairPatternId(NCIGLFEJKIH NBHCOBHPFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public NCIGLFEJKIH EFHLMHLMFOG()
		{
			return default(NCIGLFEJKIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130", Slot = "4")]
		public bool Equals(SerializedHairPatternId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62CBA10", Offset = "0x62CA810", VA = "0x1862CBA10", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62CB130", Offset = "0x62C9F30", VA = "0x1862CB130")]
		public static bool NOLBLOCHCOA(SerializedHairPatternId HADGDMKFEOD, SerializedHairPatternId CJIAEKJDMKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62CBAB0", Offset = "0x62CA8B0", VA = "0x1862CBAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, EHJFCIKJNAH
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
		[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
		public SerializedMaterialId(KMLLLEBGBIK NBHCOBHPFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860", Slot = "6")]
		public Guid BDAOGOBABLJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		public KMLLLEBGBIK EFHLMHLMFOG()
		{
			return default(KMLLLEBGBIK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D90070", Offset = "0x5D8EE70", VA = "0x185D90070", Slot = "4")]
		public bool Equals(SerializedMaterialId MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x62CBB20", Offset = "0x62CA920", VA = "0x1862CBB20", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB150", Offset = "0x62C9F50", VA = "0x1862CB150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D90070", Offset = "0x5D8EE70", VA = "0x185D90070")]
		public static bool NOLBLOCHCOA(SerializedMaterialId HADGDMKFEOD, SerializedMaterialId CJIAEKJDMKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FFD0", Offset = "0x5D8EDD0", VA = "0x185D8FFD0", Slot = "5")]
		public int CompareTo(SerializedMaterialId MFMJJEFODHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62CBBC0", Offset = "0x62CA9C0", VA = "0x1862CBBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LFKMKFEDNPK : EDLHFAEHJIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LFKMKFEDNPK GOPCOAILBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62C8C20", Offset = "0x62C7A20", VA = "0x1862C8C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PHCCFGKEDML<JFJOENEOEEK> LPHMCGHMECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62C8C80", Offset = "0x62C7A80", VA = "0x1862C8C80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public PHCCFGKEDML<HMCLDAHIPDM> FPKEMOBDDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62C8E00", Offset = "0x62C7C00", VA = "0x1862C8E00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PHCCFGKEDML<NCIGLFEJKIH> PLCIFODIHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62C8F20", Offset = "0x62C7D20", VA = "0x1862C8F20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PHCCFGKEDML<GDNGPBHAAIH> FLKNLNIPDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62C8DA0", Offset = "0x62C7BA0", VA = "0x1862C8DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PHCCFGKEDML<KFFJOEKIJAH> IIAMNHKOHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62C8D40", Offset = "0x62C7B40", VA = "0x1862C8D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PHCCFGKEDML<BOMNBMOHBFK> GCGOFIJOKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62C8EC0", Offset = "0x62C7CC0", VA = "0x1862C8EC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PHCCFGKEDML<NGEIMOEOPCO> OJJBJGBDNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62C8CE0", Offset = "0x62C7AE0", VA = "0x1862C8CE0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PHCCFGKEDML<NJILKKKHBCK> PIHKEELJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62C8E60", Offset = "0x62C7C60", VA = "0x1862C8E60", Slot = "11")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal class AssetIdMappingJsonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public SortedDictionary<string, string> modernToLegacy;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62C8180", Offset = "0x62C6F80", VA = "0x1862C8180")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class AKFDDIKOGPO
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62C8170", Offset = "0x62C6F70", VA = "0x1862C8170")]
	public static string IPDNKNPGNOE(this Guid FGCEIIELPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62C8140", Offset = "0x62C6F40", VA = "0x1862C8140")]
	public static Guid CIADOFOAAKB(string AKOOOJOMBJL)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HIKOMNHDLEB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> IAFPPOMAGFK(IEnumerable<(string modernStr, string legacyStr)> IHNJGJIIMFO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class GAFFPAFJAOD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FFHNEHAEJIJ : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private (string, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private AssetIdMappingJsonData jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AssetIdMappingJsonData <>3__jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private SortedDictionary<string, string>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.String,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x62C85E0", Offset = "0x62C73E0", VA = "0x1862C85E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1B32A80", Offset = "0x1B31880", VA = "0x181B32A80")]
		[DebuggerHidden]
		public FFHNEHAEJIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62C8630", Offset = "0x62C7430", VA = "0x1862C8630", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62C8280", Offset = "0x62C7080", VA = "0x1862C8280", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62C8230", Offset = "0x62C7030", VA = "0x1862C8230")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62C8590", Offset = "0x62C7390", VA = "0x1862C8590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62C84E0", Offset = "0x62C72E0", VA = "0x1862C84E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62C84E0", Offset = "0x62C72E0", VA = "0x1862C84E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x234E450", Offset = "0x234D250", VA = "0x18234E450")]
	internal static IEnumerable<(TModern, string)> FHIAKNHJLHO<TModern>(string ELECJFLHPAP, HIKOMNHDLEB<TModern> OLAJEPNELOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62C8AE0", Offset = "0x62C78E0", VA = "0x1862C8AE0")]
	[IteratorStateMachine(typeof(FFHNEHAEJIJ))]
	private static IEnumerable<(string, string)> NPPGIPEIKNC(AssetIdMappingJsonData FLGKHLAIIAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OMIBCILAMMK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62C99A0", Offset = "0x62C87A0", VA = "0x1862C99A0")]
	public static Guid IANCMHKGFMG(string KNLAPAANBFB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62C9A50", Offset = "0x62C8850", VA = "0x1862C9A50")]
	public static bool LINCNEOCPHA(string KNLAPAANBFB, [Out] Guid FGCEIIELPBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CLHHDPNOGOM<TModern> : LPHAPLFHHGC<TModern>, HIKOMNHDLEB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HJGLHNHOEKA : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (TModern, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CLHHDPNOGOM<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD5F440", Offset = "0xD5E240", VA = "0x180D5F440", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TModern, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3269140", Offset = "0x3267F40", VA = "0x183269140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD58640", Offset = "0xD57440", VA = "0x180D58640")]
		[DebuggerHidden]
		public HJGLHNHOEKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x325F240", Offset = "0x325E040", VA = "0x18325F240", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3597D50", Offset = "0x3596B50", VA = "0x183597D50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3596960", Offset = "0x3595760", VA = "0x183596960")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3598810", Offset = "0x3597610", VA = "0x183598810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3598620", Offset = "0x3597420", VA = "0x183598620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x346DB80", Offset = "0x346C980", VA = "0x18346DB80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern JBBDJODELAI(Guid FGCEIIELPBP);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x490FAE0", Offset = "0x490E8E0", VA = "0x18490FAE0", Slot = "4")]
	public TModern EPPJDMJHKPB(string AMPODBDAPEM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x490FB80", Offset = "0x490E980", VA = "0x18490FB80", Slot = "5")]
	[IteratorStateMachine(typeof(CLHHDPNOGOM<>.HJGLHNHOEKA))]
	public IEnumerable<(TModern, string)> IAFPPOMAGFK(IEnumerable<(string modernStr, string legacyStr)> PLODCGAJHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected CLHHDPNOGOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PHHNBMPFIKG : CLHHDPNOGOM<JFJOENEOEEK>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override JFJOENEOEEK JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(JFJOENEOEEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x62C9B20", Offset = "0x62C8920", VA = "0x1862C9B20")]
	internal static string IACGIGAFDGD(string AMPODBDAPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62C9B40", Offset = "0x62C8940", VA = "0x1862C9B40")]
	public PHHNBMPFIKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FLFBBHAPHFL : CLHHDPNOGOM<NGEIMOEOPCO>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override NGEIMOEOPCO JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(NGEIMOEOPCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x62C86C0", Offset = "0x62C74C0", VA = "0x1862C86C0")]
	public FLFBBHAPHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MBNHFMKHGCC : CLHHDPNOGOM<KFFJOEKIJAH>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override KFFJOEKIJAH JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(KFFJOEKIJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x62C9010", Offset = "0x62C7E10", VA = "0x1862C9010")]
	public MBNHFMKHGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FOHLDDAIMID : LPHAPLFHHGC<GDNGPBHAAIH>, HIKOMNHDLEB<GDNGPBHAAIH>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MPPCPFDCCIE : IEnumerable<(GDNGPBHAAIH, string)>, IEnumerable, IEnumerator<(GDNGPBHAAIH, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (GDNGPBHAAIH, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FOHLDDAIMID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (GDNGPBHAAIH, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x30EFE50", Offset = "0x30EEC50", VA = "0x1830EFE50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((GDNGPBHAAIH, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x62C9880", Offset = "0x62C8680", VA = "0x1862C9880", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62C9930", Offset = "0x62C8730", VA = "0x1862C9930")]
		[DebuggerHidden]
		public MPPCPFDCCIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62C98F0", Offset = "0x62C86F0", VA = "0x1862C98F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62C9110", Offset = "0x62C7F10", VA = "0x1862C9110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62C9050", Offset = "0x62C7E50", VA = "0x1862C9050")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62C9830", Offset = "0x62C8630", VA = "0x1862C9830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62C9770", Offset = "0x62C8570", VA = "0x1862C9770", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(GDNGPBHAAIH, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62C9770", Offset = "0x62C8570", VA = "0x1862C9770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LPHAPLFHHGC<KMLLLEBGBIK> PAMPINPFHCK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public FOHLDDAIMID(LPHAPLFHHGC<KMLLLEBGBIK> PAMPINPFHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x62C8700", Offset = "0x62C7500", VA = "0x1862C8700", Slot = "4")]
	public GDNGPBHAAIH EPPJDMJHKPB(string AMPODBDAPEM)
	{
		return default(GDNGPBHAAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62C8A40", Offset = "0x62C7840", VA = "0x1862C8A40", Slot = "5")]
	[IteratorStateMachine(typeof(MPPCPFDCCIE))]
	public IEnumerable<(GDNGPBHAAIH, string)> IAFPPOMAGFK(IEnumerable<(string modernStr, string legacyStr)> IHNJGJIIMFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62C8A00", Offset = "0x62C7800", VA = "0x1862C8A00")]
	internal static string IACGIGAFDGD(string AMPODBDAPEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LBEOENGNDCF : CLHHDPNOGOM<HMCLDAHIPDM>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override HMCLDAHIPDM JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(HMCLDAHIPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62C8BE0", Offset = "0x62C79E0", VA = "0x1862C8BE0")]
	public LBEOENGNDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MADCAGMNPEP : CLHHDPNOGOM<NJILKKKHBCK>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override NJILKKKHBCK JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(NJILKKKHBCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62C8FD0", Offset = "0x62C7DD0", VA = "0x1862C8FD0")]
	public MADCAGMNPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GNKNINGNMKG : CLHHDPNOGOM<BOMNBMOHBFK>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override BOMNBMOHBFK JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(BOMNBMOHBFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62C8B60", Offset = "0x62C7960", VA = "0x1862C8B60")]
	public GNKNINGNMKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KHHCDNBEAIB : CLHHDPNOGOM<NCIGLFEJKIH>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override NCIGLFEJKIH JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(NCIGLFEJKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62C8BA0", Offset = "0x62C79A0", VA = "0x1862C8BA0")]
	public KHHCDNBEAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OBKLBKMKDEE : CLHHDPNOGOM<KMLLLEBGBIK>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "6")]
	protected override KMLLLEBGBIK JBBDJODELAI(Guid FGCEIIELPBP)
	{
		return default(KMLLLEBGBIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x62C9960", Offset = "0x62C8760", VA = "0x1862C9960")]
	public OBKLBKMKDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EFFMJDPBEEK<TModern> : PHCCFGKEDML<TModern>, LPHAPLFHHGC<TModern> where TModern : IEquatable<TModern>, EHJFCIKJNAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> OCJIAMDLLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> HCAMLBGMKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> PJFGPJKGIAA;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3035010", Offset = "0x3033E10", VA = "0x183035010")]
	public EFFMJDPBEEK(TextAsset ILKEDMNEPPG, HIKOMNHDLEB<TModern> OLAJEPNELOF, [CanBeNull] Func<string, string> PJFGPJKGIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x30317F0", Offset = "0x30305F0", VA = "0x1830317F0", Slot = "5")]
	public TModern EPPJDMJHKPB(string AMPODBDAPEM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3032440", Offset = "0x3031240", VA = "0x183032440", Slot = "4")]
	public string NFDLIIGLKML(TModern CIBLACMMHBO)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, EDLHFAEHJIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TextAsset avatarItemIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private TextAsset combinationIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TextAsset equipmentSkinIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private TextAsset hairPatternIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TextAsset materialIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private TextAsset colorIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TextAsset faceShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private TextAsset bodyShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextAsset faceFeatureIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EFFMJDPBEEK<JFJOENEOEEK> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EFFMJDPBEEK<HMCLDAHIPDM> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private EFFMJDPBEEK<NCIGLFEJKIH> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private EFFMJDPBEEK<KMLLLEBGBIK> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private EFFMJDPBEEK<GDNGPBHAAIH> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EFFMJDPBEEK<KFFJOEKIJAH> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EFFMJDPBEEK<BOMNBMOHBFK> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private EFFMJDPBEEK<NGEIMOEOPCO> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private EFFMJDPBEEK<NJILKKKHBCK> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PHCCFGKEDML<JFJOENEOEEK> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PHCCFGKEDML<HMCLDAHIPDM> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public PHCCFGKEDML<NCIGLFEJKIH> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public PHCCFGKEDML<KMLLLEBGBIK> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x76FD20", Offset = "0x76EB20", VA = "0x18076FD20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public PHCCFGKEDML<GDNGPBHAAIH> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x76FD10", Offset = "0x76EB10", VA = "0x18076FD10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PHCCFGKEDML<KFFJOEKIJAH> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x76FCA0", Offset = "0x76EAA0", VA = "0x18076FCA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PHCCFGKEDML<BOMNBMOHBFK> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8125E0", Offset = "0x8113E0", VA = "0x1808125E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public PHCCFGKEDML<NGEIMOEOPCO> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x76FC50", Offset = "0x76EA50", VA = "0x18076FC50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public PHCCFGKEDML<NJILKKKHBCK> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x89C9D0", Offset = "0x89B7D0", VA = "0x18089C9D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62CA900", Offset = "0x62C9700", VA = "0x1862CA900")]
		[GAPOPKHLLNB(KLEBEPKJPOL.Root, OGJCEJIMIKL.GameOnly)]
		private static void GOLHEJOKLGP(OILPPPCALMB IDMCGGBGLJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62CA980", Offset = "0x62C9780", VA = "0x1862CA980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C4F0", VA = "0x18084D6F0")]
		public RuntimeIdAssetMappers()
		{
		}
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
