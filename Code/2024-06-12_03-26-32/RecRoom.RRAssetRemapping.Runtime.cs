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
public class IELNMKABBMK : FKICEGABKJK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HAFBBCCCIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IFBHIOFCNNP CAEAAMIBODB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7138960", Offset = "0x7137560", VA = "0x187138960")]
	[FJJFAIMPJIC(JBEKPLNNIEC.GameOnly)]
	[UsedImplicitly]
	private static void GBNHEMCAJHC(LLIMAHMFNLB IADIMANELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71389D0", Offset = "0x71375D0", VA = "0x1871389D0")]
	[UsedImplicitly]
	[FJJFAIMPJIC(JBEKPLNNIEC.EditorOnly)]
	private static void JAICAKMHBHK(LLIMAHMFNLB IADIMANELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	[Preserve]
	public IELNMKABBMK([GOICEJLKLIB(null)] IFBHIOFCNNP CAEAAMIBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7138A30", Offset = "0x7137630", VA = "0x187138A30", Slot = "4")]
	public string PLFEAILJDFE(BBAGBHNBMOO HJNPKADFMMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71382A0", Offset = "0x7136EA0", VA = "0x1871382A0", Slot = "5")]
	public BBAGBHNBMOO EGCBEAACMHC(string HJNPKADFMMO)
	{
		return default(BBAGBHNBMOO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
		public SerializedAvatarItemId(LKFMAAICKAG EPKGPGILADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public LKFMAAICKAG EGCBEAACMHC()
		{
			return default(LKFMAAICKAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7149F10", Offset = "0x7148B10", VA = "0x187149F10", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7149FD0", Offset = "0x7148BD0", VA = "0x187149FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public CPONPOCPOHL EGCBEAACMHC()
		{
			return default(CPONPOCPOHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x714A040", Offset = "0x7148C40", VA = "0x18714A040", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x714A0E0", Offset = "0x7148CE0", VA = "0x18714A0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public GBBJJGFDJCC EGCBEAACMHC()
		{
			return default(GBBJJGFDJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedColorId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedColorId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x714A150", Offset = "0x7148D50", VA = "0x18714A150", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x714A1F0", Offset = "0x7148DF0", VA = "0x18714A1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, JJAKLHDPBME, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x714A260", Offset = "0x7148E60", VA = "0x18714A260")]
		public KAECHKCDNJH EGCBEAACMHC()
		{
			return default(KAECHKCDNJH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x714A4F0", Offset = "0x71490F0", VA = "0x18714A4F0")]
		public SerializedCombinationId(KAECHKCDNJH AHIAGANHOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x714A370", Offset = "0x7148F70", VA = "0x18714A370")]
		private void KHAFCDAIHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8830", Offset = "0x6FD7430", VA = "0x186FD8830", Slot = "4")]
		public bool Equals(SerializedCombinationId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x714A2C0", Offset = "0x7148EC0", VA = "0x18714A2C0", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedCombinationId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x714A480", Offset = "0x7149080", VA = "0x18714A480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x714A470", Offset = "0x7149070", VA = "0x18714A470", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x714A5C0", Offset = "0x71491C0", VA = "0x18714A5C0")]
		public static SerializedEquipmentSkinId OCMNFJJDKKF()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public FEDPOAIINPJ EGCBEAACMHC()
		{
			return default(FEDPOAIINPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x714A520", Offset = "0x7149120", VA = "0x18714A520", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x714A5F0", Offset = "0x71491F0", VA = "0x18714A5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public EPAIPDBBJOB EGCBEAACMHC()
		{
			return default(EPAIPDBBJOB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x714A660", Offset = "0x7149260", VA = "0x18714A660", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x714A700", Offset = "0x7149300", VA = "0x18714A700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public FKGKDBCHMBL EGCBEAACMHC()
		{
			return default(FKGKDBCHMBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x714A770", Offset = "0x7149370", VA = "0x18714A770", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x714A810", Offset = "0x7149410", VA = "0x18714A810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public DCNMLPGLGPB EGCBEAACMHC()
		{
			return default(DCNMLPGLGPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0", Slot = "4")]
		public bool Equals(SerializedHairPatternId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x714A880", Offset = "0x7149480", VA = "0x18714A880", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7149FB0", Offset = "0x7148BB0", VA = "0x187149FB0")]
		public static bool NBAHCGFACIA(SerializedHairPatternId HOGIDEMINCM, SerializedHairPatternId FKJHDCOBNND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x714A920", Offset = "0x7149520", VA = "0x18714A920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, JJAKLHDPBME
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
		[Cpp2IlInjected.Address(RVA = "0x1F94260", Offset = "0x1F92E60", VA = "0x181F94260")]
		public SerializedMaterialId(LOCIFEEIHIM EPKGPGILADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
		public Guid BCPGKOOEMFB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150")]
		public LOCIFEEIHIM EGCBEAACMHC()
		{
			return default(LOCIFEEIHIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8830", Offset = "0x6FD7430", VA = "0x186FD8830", Slot = "4")]
		public bool Equals(SerializedMaterialId OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x714A990", Offset = "0x7149590", VA = "0x18714A990", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E960", Offset = "0xA6D560", VA = "0x180A6E960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8830", Offset = "0x6FD7430", VA = "0x186FD8830")]
		public static bool NBAHCGFACIA(SerializedMaterialId HOGIDEMINCM, SerializedMaterialId FKJHDCOBNND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E740", Offset = "0xA6D340", VA = "0x180A6E740", Slot = "5")]
		public int CompareTo(SerializedMaterialId OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x714AA40", Offset = "0x7149640", VA = "0x18714AA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NHLLFHDOICG : IFBHIOFCNNP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NHLLFHDOICG GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7147470", Offset = "0x7146070", VA = "0x187147470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JKMOIHHGHAC<LKFMAAICKAG> HKOOCGIENFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7147770", Offset = "0x7146370", VA = "0x187147770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JKMOIHHGHAC<FEDPOAIINPJ> LEKNJBMFBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71476B0", Offset = "0x71462B0", VA = "0x1871476B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JKMOIHHGHAC<DCNMLPGLGPB> JMMAIGLICLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7147530", Offset = "0x7146130", VA = "0x187147530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JKMOIHHGHAC<KAECHKCDNJH> EPFBOIJPLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7147710", Offset = "0x7146310", VA = "0x187147710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JKMOIHHGHAC<GBBJJGFDJCC> FHEKNELHEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71474D0", Offset = "0x71460D0", VA = "0x1871474D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKMOIHHGHAC<FKGKDBCHMBL> IMCNPFBOMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71475F0", Offset = "0x71461F0", VA = "0x1871475F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JKMOIHHGHAC<CPONPOCPOHL> GJPBBNHNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7147590", Offset = "0x7146190", VA = "0x187147590", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JKMOIHHGHAC<EPAIPDBBJOB> DCCIFIPNEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7147650", Offset = "0x7146250", VA = "0x187147650", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GDLHFOLNKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x71379C0", Offset = "0x71365C0", VA = "0x1871379C0")]
	public static Guid FEKJAEFMPFC(string BJMEIACFJKG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7137A70", Offset = "0x7136670", VA = "0x187137A70")]
	public static bool MFPNHEIAFJH(string BJMEIACFJKG, [Out] Guid CICFLOBNFHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KKBFIOLONON : MPBJIHOEAPB<LKFMAAICKAG>, EMGIHHDBHEG<LKFMAAICKAG>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x713A870", Offset = "0x7139470", VA = "0x18713A870", Slot = "4")]
	public IEnumerable<(LKFMAAICKAG, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x713A850", Offset = "0x7139450", VA = "0x18713A850", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public LKFMAAICKAG DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(LKFMAAICKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public KKBFIOLONON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LLNKFICKCJJ : MPBJIHOEAPB<CPONPOCPOHL>, EMGIHHDBHEG<CPONPOCPOHL>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x71470D0", Offset = "0x7145CD0", VA = "0x1871470D0", Slot = "4")]
	public IEnumerable<(CPONPOCPOHL, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public CPONPOCPOHL DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(CPONPOCPOHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LLNKFICKCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class POGKKHBKJGJ : MPBJIHOEAPB<GBBJJGFDJCC>, EMGIHHDBHEG<GBBJJGFDJCC>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7147E50", Offset = "0x7146A50", VA = "0x187147E50", Slot = "4")]
	public IEnumerable<(GBBJJGFDJCC, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public GBBJJGFDJCC DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(GBBJJGFDJCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public POGKKHBKJGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GNPLIOGKAEM : MPBJIHOEAPB<KAECHKCDNJH>, EMGIHHDBHEG<KAECHKCDNJH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EMGIHHDBHEG<LOCIFEEIHIM> EDPIMPPKAED;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	public GNPLIOGKAEM(EMGIHHDBHEG<LOCIFEEIHIM> EDPIMPPKAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FD8E80", Offset = "0x6FD7A80", VA = "0x186FD8E80", Slot = "4")]
	public IEnumerable<(KAECHKCDNJH, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7137F60", Offset = "0x7136B60", VA = "0x187137F60", Slot = "6")]
	public KAECHKCDNJH DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(KAECHKCDNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7138260", Offset = "0x7136E60", VA = "0x187138260", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LEFNADLLDME : MPBJIHOEAPB<FEDPOAIINPJ>, EMGIHHDBHEG<FEDPOAIINPJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x713F4C0", Offset = "0x713E0C0", VA = "0x18713F4C0", Slot = "4")]
	public IEnumerable<(FEDPOAIINPJ, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public FEDPOAIINPJ DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(FEDPOAIINPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public LEFNADLLDME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JIOPOLAJDBF : MPBJIHOEAPB<EPAIPDBBJOB>, EMGIHHDBHEG<EPAIPDBBJOB>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7138F90", Offset = "0x7137B90", VA = "0x187138F90", Slot = "4")]
	public IEnumerable<(EPAIPDBBJOB, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public EPAIPDBBJOB DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(EPAIPDBBJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public JIOPOLAJDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GKJOAODMFGB : MPBJIHOEAPB<FKGKDBCHMBL>, EMGIHHDBHEG<FKGKDBCHMBL>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7137B40", Offset = "0x7136740", VA = "0x187137B40", Slot = "4")]
	public IEnumerable<(FKGKDBCHMBL, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public FKGKDBCHMBL DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(FKGKDBCHMBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GKJOAODMFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PODOEJHAEMN : MPBJIHOEAPB<DCNMLPGLGPB>, EMGIHHDBHEG<DCNMLPGLGPB>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71477D0", Offset = "0x71463D0", VA = "0x1871477D0", Slot = "4")]
	public IEnumerable<(DCNMLPGLGPB, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public DCNMLPGLGPB DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(DCNMLPGLGPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PODOEJHAEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MPBJIHOEAPB<TModern> : EMGIHHDBHEG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> NDHOFNEMCLJ();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DIBCBDBMPJB(string FJMDMAHFMII);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EOIJFCOMGGK : MPBJIHOEAPB<LOCIFEEIHIM>, EMGIHHDBHEG<LOCIFEEIHIM>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x708CFF0", Offset = "0x708BBF0", VA = "0x18708CFF0", Slot = "4")]
	public IEnumerable<(LOCIFEEIHIM, string)> NDHOFNEMCLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA6F990", Offset = "0xA6E590", VA = "0x180A6F990", Slot = "5")]
	public string DIBCBDBMPJB(string FJMDMAHFMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7137900", Offset = "0x7136500", VA = "0x187137900", Slot = "6")]
	public LOCIFEEIHIM DHEFHPELALB(string FJMDMAHFMII)
	{
		return default(LOCIFEEIHIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EOIJFCOMGGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MMNJAJADFFK<TModern> : JKMOIHHGHAC<TModern>, EMGIHHDBHEG<TModern> where TModern : IEquatable<TModern>, JJAKLHDPBME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> CEBGNLKCMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> DALBGHOMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MPBJIHOEAPB<TModern> BOHIIOGLDDD;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x441BCD0", Offset = "0x441A8D0", VA = "0x18441BCD0")]
	public MMNJAJADFFK(MPBJIHOEAPB<TModern> BOHIIOGLDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x44199F0", Offset = "0x44185F0", VA = "0x1844199F0", Slot = "5")]
	public TModern DHEFHPELALB(string FJMDMAHFMII)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x441B450", Offset = "0x441A050", VA = "0x18441B450", Slot = "4")]
	public string ICFFCLKHPMD(TModern NKFCFGHAMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DGKOHHNPIHO : IFBHIOFCNNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MMNJAJADFFK<LKFMAAICKAG> BIBHAGLKHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MMNJAJADFFK<FEDPOAIINPJ> PNMMMDIBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MMNJAJADFFK<DCNMLPGLGPB> HDNHPAMKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MMNJAJADFFK<LOCIFEEIHIM> EDPIMPPKAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MMNJAJADFFK<KAECHKCDNJH> JJNNCFFNMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MMNJAJADFFK<GBBJJGFDJCC> EDKPMFDKOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MMNJAJADFFK<FKGKDBCHMBL> DFMBANMCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MMNJAJADFFK<CPONPOCPOHL> GLAPPLKIODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MMNJAJADFFK<EPAIPDBBJOB> GGEFCICIBJG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JKMOIHHGHAC<LKFMAAICKAG> HKOOCGIENFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JKMOIHHGHAC<FEDPOAIINPJ> LEKNJBMFBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JKMOIHHGHAC<DCNMLPGLGPB> JMMAIGLICLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JKMOIHHGHAC<KAECHKCDNJH> EPFBOIJPLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JKMOIHHGHAC<GBBJJGFDJCC> FHEKNELHEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JKMOIHHGHAC<FKGKDBCHMBL> IMCNPFBOMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JKMOIHHGHAC<CPONPOCPOHL> GJPBBNHNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JKMOIHHGHAC<EPAIPDBBJOB> DCCIFIPNEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71373B0", Offset = "0x7135FB0", VA = "0x1871373B0")]
	[FJJFAIMPJIC(AMDAGODFNAF.Root, JBEKPLNNIEC.GameOnly)]
	[UsedImplicitly]
	private static void CNGOBDBKALM(LLIMAHMFNLB IADIMANELHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7137420", Offset = "0x7136020", VA = "0x187137420")]
	[Preserve]
	public DGKOHHNPIHO()
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
