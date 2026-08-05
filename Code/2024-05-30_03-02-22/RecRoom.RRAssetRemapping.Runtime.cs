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
public class KHBMAIEBMEK : LLKOBCKBADP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex CNMMILEENGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PPPAOOBJLJE CDDBJDIFGNJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A870", Offset = "0x6C09A70", VA = "0x186C0A870")]
	[JIMPHGEJKMA(CLDBMEKPFFP.GameOnly)]
	[UsedImplicitly]
	private static void KKAGNGKELMI(EHGDBDLIOFB JKHBLMGBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A150", Offset = "0x6C09350", VA = "0x186C0A150")]
	[UsedImplicitly]
	[JIMPHGEJKMA(CLDBMEKPFFP.EditorOnly)]
	private static void GPHMBHJLBDB(EHGDBDLIOFB JKHBLMGBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	[Preserve]
	public KHBMAIEBMEK([KFHLAIGNCCH(null)] PPPAOOBJLJE CDDBJDIFGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C09C90", Offset = "0x6C08E90", VA = "0x186C09C90", Slot = "4")]
	public string GKNEHCEDNDE(LMGLPMBGHHO NBFGFAAMIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A1B0", Offset = "0x6C093B0", VA = "0x186C0A1B0", Slot = "5")]
	public LMGLPMBGHHO IHPADLGFHBL(string NBFGFAAMIMJ)
	{
		return default(LMGLPMBGHHO);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
		public SerializedAvatarItemId(PPFHPDKJCCM IFAFPBGLEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public PPFHPDKJCCM IHPADLGFHBL()
		{
			return default(PPFHPDKJCCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedAvatarItemId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CD80", Offset = "0x6C0BF80", VA = "0x186C0CD80", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE40", Offset = "0x6C0C040", VA = "0x186C0CE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public JMPHDKBEGLF IHPADLGFHBL()
		{
			return default(JMPHDKBEGLF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedBodyShapeId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CEB0", Offset = "0x6C0C0B0", VA = "0x186C0CEB0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CF50", Offset = "0x6C0C150", VA = "0x186C0CF50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public KDLAJGECGFL IHPADLGFHBL()
		{
			return default(KDLAJGECGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedColorId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedColorId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CFC0", Offset = "0x6C0C1C0", VA = "0x186C0CFC0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D060", Offset = "0x6C0C260", VA = "0x186C0D060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, HJNDGGGNPJK, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6C0D280", Offset = "0x6C0C480", VA = "0x186C0D280")]
		public IBBLFMEEAFP IHPADLGFHBL()
		{
			return default(IBBLFMEEAFP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D360", Offset = "0x6C0C560", VA = "0x186C0D360")]
		public SerializedCombinationId(IBBLFMEEAFP ONLLACAPGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D0D0", Offset = "0x6C0C2D0", VA = "0x186C0D0D0")]
		private void ANGACMJOFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A6C0", Offset = "0x6A998C0", VA = "0x186A9A6C0", Slot = "4")]
		public bool Equals(SerializedCombinationId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D1D0", Offset = "0x6C0C3D0", VA = "0x186C0D1D0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedCombinationId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D2F0", Offset = "0x6C0C4F0", VA = "0x186C0D2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D2E0", Offset = "0x6C0C4E0", VA = "0x186C0D2E0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x6C0D430", Offset = "0x6C0C630", VA = "0x186C0D430")]
		public static SerializedEquipmentSkinId HMJCCLKCJGC()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public FCBNLOPDJIL IHPADLGFHBL()
		{
			return default(FCBNLOPDJIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D390", Offset = "0x6C0C590", VA = "0x186C0D390", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D460", Offset = "0x6C0C660", VA = "0x186C0D460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public PLPCONDGDMD IHPADLGFHBL()
		{
			return default(PLPCONDGDMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D4D0", Offset = "0x6C0C6D0", VA = "0x186C0D4D0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D570", Offset = "0x6C0C770", VA = "0x186C0D570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public KOJBJIADMMM IHPADLGFHBL()
		{
			return default(KOJBJIADMMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedFaceShapeId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D5E0", Offset = "0x6C0C7E0", VA = "0x186C0D5E0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D680", Offset = "0x6C0C880", VA = "0x186C0D680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public PKFGAFHOMKH IHPADLGFHBL()
		{
			return default(PKFGAFHOMKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20", Slot = "4")]
		public bool Equals(SerializedHairPatternId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedHairPatternId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D6F0", Offset = "0x6C0C8F0", VA = "0x186C0D6F0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0C020", VA = "0x186C0CE20")]
		public static bool LOAKJDDAMKI(SerializedHairPatternId ABPADDODFDF, SerializedHairPatternId DLCDCNECDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D790", Offset = "0x6C0C990", VA = "0x186C0D790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, HJNDGGGNPJK
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
		[Cpp2IlInjected.Address(RVA = "0x1EBEA70", Offset = "0x1EBDC70", VA = "0x181EBEA70")]
		public SerializedMaterialId(NFPPFNGGELC IFAFPBGLEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0", Slot = "6")]
		public Guid AOHJHMGCENG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x920CC0", Offset = "0x91FEC0", VA = "0x180920CC0")]
		public NFPPFNGGELC IHPADLGFHBL()
		{
			return default(NFPPFNGGELC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A6C0", Offset = "0x6A998C0", VA = "0x186A9A6C0", Slot = "4")]
		public bool Equals(SerializedMaterialId JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D800", Offset = "0x6C0CA00", VA = "0x186C0D800", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9D0CB0", Offset = "0x9CFEB0", VA = "0x1809D0CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A6C0", Offset = "0x6A998C0", VA = "0x186A9A6C0")]
		public static bool LOAKJDDAMKI(SerializedMaterialId ABPADDODFDF, SerializedMaterialId DLCDCNECDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9D0A90", Offset = "0x9CFC90", VA = "0x1809D0A90", Slot = "5")]
		public int CompareTo(SerializedMaterialId JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D8B0", Offset = "0x6C0CAB0", VA = "0x186C0D8B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DJMOKJKEHFH : PPPAOOBJLJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DJMOKJKEHFH LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C01010", Offset = "0x6C00210", VA = "0x186C01010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JKIKNNMOLHI<PPFHPDKJCCM> PHCONKJJFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C01250", Offset = "0x6C00450", VA = "0x186C01250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JKIKNNMOLHI<FCBNLOPDJIL> DPINEMICGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C010D0", Offset = "0x6C002D0", VA = "0x186C010D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JKIKNNMOLHI<PKFGAFHOMKH> BOCJHAFNMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C01070", Offset = "0x6C00270", VA = "0x186C01070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JKIKNNMOLHI<IBBLFMEEAFP> KCHALDGLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C012B0", Offset = "0x6C004B0", VA = "0x186C012B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JKIKNNMOLHI<KDLAJGECGFL> LDOJJECONNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C01190", Offset = "0x6C00390", VA = "0x186C01190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKIKNNMOLHI<KOJBJIADMMM> NNPBENAGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C011F0", Offset = "0x6C003F0", VA = "0x186C011F0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JKIKNNMOLHI<JMPHDKBEGLF> LCCENDEHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C01310", Offset = "0x6C00510", VA = "0x186C01310", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JKIKNNMOLHI<PLPCONDGDMD> ADBADNBCAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C01130", Offset = "0x6C00330", VA = "0x186C01130", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ADOHMLIOFDC
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA220", Offset = "0x6BF9420", VA = "0x186BFA220")]
	public static Guid MAKBLFOEAMO(string OCMOGBEBEDP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA2D0", Offset = "0x6BF94D0", VA = "0x186BFA2D0")]
	public static bool OHCAKBFAPGL(string OCMOGBEBEDP, [Out] Guid LDJEJDDHHLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CMNMMPBLCIN : MGBJCEHMBKI<PPFHPDKJCCM>, HBDHPFBKEKE<PPFHPDKJCCM>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC3C0", Offset = "0x6BFB5C0", VA = "0x186BFC3C0", Slot = "4")]
	public IEnumerable<(PPFHPDKJCCM, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC3A0", Offset = "0x6BFB5A0", VA = "0x186BFC3A0", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public PPFHPDKJCCM HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(PPFHPDKJCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CMNMMPBLCIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FFGCFAHJCLP : MGBJCEHMBKI<JMPHDKBEGLF>, HBDHPFBKEKE<JMPHDKBEGLF>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C018C0", Offset = "0x6C00AC0", VA = "0x186C018C0", Slot = "4")]
	public IEnumerable<(JMPHDKBEGLF, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public JMPHDKBEGLF HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(JMPHDKBEGLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FFGCFAHJCLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LJCFNJMNCDH : MGBJCEHMBKI<KDLAJGECGFL>, HBDHPFBKEKE<KDLAJGECGFL>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A980", Offset = "0x6C09B80", VA = "0x186C0A980", Slot = "4")]
	public IEnumerable<(KDLAJGECGFL, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public KDLAJGECGFL HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(KDLAJGECGFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public LJCFNJMNCDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class MIGJLPCDLKJ : MGBJCEHMBKI<IBBLFMEEAFP>, HBDHPFBKEKE<IBBLFMEEAFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HBDHPFBKEKE<NFPPFNGGELC> JGEBLJFLPIB;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	public MIGJLPCDLKJ(HBDHPFBKEKE<NFPPFNGGELC> JGEBLJFLPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BCF0", Offset = "0x6A9AEF0", VA = "0x186A9BCF0", Slot = "4")]
	public IEnumerable<(IBBLFMEEAFP, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CA80", Offset = "0x6C0BC80", VA = "0x186C0CA80", Slot = "6")]
	public IBBLFMEEAFP HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(IBBLFMEEAFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CA40", Offset = "0x6C0BC40", VA = "0x186C0CA40", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HMMAPKKCNHO : MGBJCEHMBKI<FCBNLOPDJIL>, HBDHPFBKEKE<FCBNLOPDJIL>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C02080", Offset = "0x6C01280", VA = "0x186C02080", Slot = "4")]
	public IEnumerable<(FCBNLOPDJIL, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public FCBNLOPDJIL HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(FCBNLOPDJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HMMAPKKCNHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AIKMMEPODEJ : MGBJCEHMBKI<PLPCONDGDMD>, HBDHPFBKEKE<PLPCONDGDMD>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA460", Offset = "0x6BF9660", VA = "0x186BFA460", Slot = "4")]
	public IEnumerable<(PLPCONDGDMD, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public PLPCONDGDMD HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(PLPCONDGDMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AIKMMEPODEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HCLHIOMFCFP : MGBJCEHMBKI<KOJBJIADMMM>, HBDHPFBKEKE<KOJBJIADMMM>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C01C60", Offset = "0x6C00E60", VA = "0x186C01C60", Slot = "4")]
	public IEnumerable<(KOJBJIADMMM, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public KOJBJIADMMM HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(KOJBJIADMMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HCLHIOMFCFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AJLMCPJPDIK : MGBJCEHMBKI<PKFGAFHOMKH>, HBDHPFBKEKE<PKFGAFHOMKH>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBD20", Offset = "0x6BFAF20", VA = "0x186BFBD20", Slot = "4")]
	public IEnumerable<(PKFGAFHOMKH, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public PKFGAFHOMKH HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(PKFGAFHOMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public AJLMCPJPDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MGBJCEHMBKI<TModern> : HBDHPFBKEKE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> NPBHPMKAFOK();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HFIGIKDAELM(string JBFKAFCIKIK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KOABOEFKNPJ : MGBJCEHMBKI<NFPPFNGGELC>, HBDHPFBKEKE<NFPPFNGGELC>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B4FE60", Offset = "0x6B4F060", VA = "0x186B4FE60", Slot = "4")]
	public IEnumerable<(NFPPFNGGELC, string)> NPBHPMKAFOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9D2770", Offset = "0x9D1970", VA = "0x1809D2770", Slot = "5")]
	public string HFIGIKDAELM(string JBFKAFCIKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA3A0", Offset = "0x6BF95A0", VA = "0x186BFA3A0", Slot = "6")]
	public NFPPFNGGELC HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return default(NFPPFNGGELC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KOABOEFKNPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NKLGDKOAOIL<TModern> : JKIKNNMOLHI<TModern>, HBDHPFBKEKE<TModern> where TModern : IEquatable<TModern>, HJNDGGGNPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> HGBGJMGAAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> LKKOJKJHLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MGBJCEHMBKI<TModern> MLDGCJBJILG;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x41B7580", Offset = "0x41B6780", VA = "0x1841B7580")]
	public NKLGDKOAOIL(MGBJCEHMBKI<TModern> MLDGCJBJILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x41B7380", Offset = "0x41B6580", VA = "0x1841B7380", Slot = "5")]
	public TModern HNAADKJFBDL(string JBFKAFCIKIK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x41B5670", Offset = "0x41B4870", VA = "0x1841B5670", Slot = "4")]
	public string FLNBPCOFLAD(TModern MGDFHFNFCAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DMLOKJHOLBC : PPPAOOBJLJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NKLGDKOAOIL<PPFHPDKJCCM> CHFGNCCKKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NKLGDKOAOIL<FCBNLOPDJIL> KBMEMKECAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NKLGDKOAOIL<PKFGAFHOMKH> ODKJPOKMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NKLGDKOAOIL<NFPPFNGGELC> JGEBLJFLPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NKLGDKOAOIL<IBBLFMEEAFP> OHBGCGAFDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NKLGDKOAOIL<KDLAJGECGFL> JPOKCKHCPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NKLGDKOAOIL<KOJBJIADMMM> MCBACFGCKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NKLGDKOAOIL<JMPHDKBEGLF> EIACMMIDOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NKLGDKOAOIL<PLPCONDGDMD> NADJEAFHHKN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JKIKNNMOLHI<PPFHPDKJCCM> PHCONKJJFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JKIKNNMOLHI<FCBNLOPDJIL> DPINEMICGBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JKIKNNMOLHI<PKFGAFHOMKH> BOCJHAFNMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JKIKNNMOLHI<IBBLFMEEAFP> KCHALDGLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JKIKNNMOLHI<KDLAJGECGFL> LDOJJECONNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JKIKNNMOLHI<KOJBJIADMMM> NNPBENAGBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JKIKNNMOLHI<JMPHDKBEGLF> LCCENDEHMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JKIKNNMOLHI<PLPCONDGDMD> ADBADNBCAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB180", VA = "0x1807CBF80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C01370", Offset = "0x6C00570", VA = "0x186C01370")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Root, CLDBMEKPFFP.GameOnly)]
	[UsedImplicitly]
	private static void IKGBAOHJGCA(EHGDBDLIOFB JKHBLMGBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C013E0", Offset = "0x6C005E0", VA = "0x186C013E0")]
	[Preserve]
	public DMLOKJHOLBC()
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
