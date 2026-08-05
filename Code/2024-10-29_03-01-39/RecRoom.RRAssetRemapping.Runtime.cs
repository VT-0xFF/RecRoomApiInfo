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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7763B00", Offset = "0x7762B00", VA = "0x187763B00", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DFAFPCHKNIP : IFDPIODEBNC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NNLLHIEKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly KDABCBFBNHH JMNMKCFBPFJ;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7753130", Offset = "0x7752130", VA = "0x187753130")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	[UsedImplicitly]
	internal static void MKFFGPHAFOG(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x77530D0", Offset = "0x77520D0", VA = "0x1877530D0")]
	[UsedImplicitly]
	internal static void GEBNJLIGGOL(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	[RecRoom.NoEngine.Common.Preserve]
	public DFAFPCHKNIP([GAHPILLNNBL(null)] KDABCBFBNHH JMNMKCFBPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7752D90", Offset = "0x7751D90", VA = "0x187752D90", Slot = "4")]
	public string EKFEJLFJOKC(MMDGIABAHDI EDAMLOGMMEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77531A0", Offset = "0x77521A0", VA = "0x1877531A0", Slot = "5")]
	public MMDGIABAHDI OGCNNFLPKKP(string EDAMLOGMMEK)
	{
		return default(MMDGIABAHDI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public SerializedAvatarItemId(IOFOCLGJBKE JHCIODFGPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public IOFOCLGJBKE OGCNNFLPKKP()
		{
			return default(IOFOCLGJBKE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedAvatarItemId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7762FE0", Offset = "0x7761FE0", VA = "0x187762FE0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77630A0", Offset = "0x77620A0", VA = "0x1877630A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public LAAGBDBIFCE OGCNNFLPKKP()
		{
			return default(LAAGBDBIFCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedBodyShapeId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7763110", Offset = "0x7762110", VA = "0x187763110", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77631B0", Offset = "0x77621B0", VA = "0x1877631B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public LHADLCKBALK OGCNNFLPKKP()
		{
			return default(LHADLCKBALK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedColorId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedColorId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7763220", Offset = "0x7762220", VA = "0x187763220", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x77632C0", Offset = "0x77622C0", VA = "0x1877632C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, PACINHNAFHD, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0")]
		public BEFENALLNEP OGCNNFLPKKP()
		{
			return default(BEFENALLNEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7763460", Offset = "0x7762460", VA = "0x187763460")]
		public SerializedCombinationId(BEFENALLNEP AKENLIPJGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75EEB50", Offset = "0x75EDB50", VA = "0x1875EEB50", Slot = "4")]
		public bool Equals(SerializedCombinationId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7763330", Offset = "0x7762330", VA = "0x187763330", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedCombinationId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77633F0", Offset = "0x77623F0", VA = "0x1877633F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77633E0", Offset = "0x77623E0", VA = "0x1877633E0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public SerializedCustomAvatarItemId(Guid EEKOILIMLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7763470", Offset = "0x7762470", VA = "0x187763470", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080")]
		public static bool LJMKDDBNEAO(SerializedCustomAvatarItemId GGEOEEJGPGH, SerializedCustomAvatarItemId OLIPOMNIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7763510", Offset = "0x7762510", VA = "0x187763510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0x7763620", Offset = "0x7762620", VA = "0x187763620")]
		public static SerializedEquipmentSkinId OGOMEAPAAEH()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public LOEDIDEPMAK OGCNNFLPKKP()
		{
			return default(LOEDIDEPMAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7763580", Offset = "0x7762580", VA = "0x187763580", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7763650", Offset = "0x7762650", VA = "0x187763650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public CEHCJOLGKJG OGCNNFLPKKP()
		{
			return default(CEHCJOLGKJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x77636C0", Offset = "0x77626C0", VA = "0x1877636C0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7763760", Offset = "0x7762760", VA = "0x187763760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public NEANNCABPBL OGCNNFLPKKP()
		{
			return default(NEANNCABPBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedFaceShapeId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77637D0", Offset = "0x77627D0", VA = "0x1877637D0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7763870", Offset = "0x7762870", VA = "0x187763870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700")]
		public GGBIONBNLAB OGCNNFLPKKP()
		{
			return default(GGBIONBNLAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080", Slot = "4")]
		public bool Equals(SerializedHairPatternId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedHairPatternId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77638E0", Offset = "0x77628E0", VA = "0x1877638E0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7763080", Offset = "0x7762080", VA = "0x187763080")]
		public static bool LJMKDDBNEAO(SerializedHairPatternId GGEOEEJGPGH, SerializedHairPatternId OLIPOMNIFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7763980", Offset = "0x7762980", VA = "0x187763980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, PACINHNAFHD
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
		[Cpp2IlInjected.Address(RVA = "0xDC76F0", Offset = "0xDC66F0", VA = "0x180DC76F0")]
		public SerializedMaterialId(ICCKNJPMFGP JHCIODFGPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xDC7700", Offset = "0xDC6700", VA = "0x180DC7700", Slot = "6")]
		public Guid IACKPLLKMIL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x75EEB50", Offset = "0x75EDB50", VA = "0x1875EEB50", Slot = "4")]
		public bool Equals(SerializedMaterialId DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77639F0", Offset = "0x77629F0", VA = "0x1877639F0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xE65A10", Offset = "0xE64A10", VA = "0x180E65A10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xE65800", Offset = "0xE64800", VA = "0x180E65800", Slot = "5")]
		public int CompareTo(SerializedMaterialId DFABCHNPEEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7763A90", Offset = "0x7762A90", VA = "0x187763A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ADCKGEKOHCH : KDABCBFBNHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ADCKGEKOHCH LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x77508B0", Offset = "0x774F8B0", VA = "0x1877508B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JMKEPDKLDNL<IOFOCLGJBKE> MBHLMDHIFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7750B50", Offset = "0x774FB50", VA = "0x187750B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JMKEPDKLDNL<LOEDIDEPMAK> BPHDMFJJHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7750910", Offset = "0x774F910", VA = "0x187750910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JMKEPDKLDNL<GGBIONBNLAB> NEHHGLADJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7750BB0", Offset = "0x774FBB0", VA = "0x187750BB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMKEPDKLDNL<BEFENALLNEP> GNOBODCAICA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7750AF0", Offset = "0x774FAF0", VA = "0x187750AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JMKEPDKLDNL<LHADLCKBALK> EDBFHMJGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7750A30", Offset = "0x774FA30", VA = "0x187750A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JMKEPDKLDNL<NEANNCABPBL> DIENBDDNNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7750970", Offset = "0x774F970", VA = "0x187750970", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMKEPDKLDNL<LAAGBDBIFCE> OIPFABHKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7750A90", Offset = "0x774FA90", VA = "0x187750A90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JMKEPDKLDNL<CEHCJOLGKJG> MEDLCDAJCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77509D0", Offset = "0x774F9D0", VA = "0x1877509D0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MMBACLLMCPP
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x775DDD0", Offset = "0x775CDD0", VA = "0x18775DDD0")]
	public static Guid GJAGPNLDJAM(string JPCNDGMKCBO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x775DE80", Offset = "0x775CE80", VA = "0x18775DE80")]
	public static bool HKJIBNBBLLG(string JPCNDGMKCBO, [Out] Guid EEKOILIMLBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PDIHCNELBBL : FLKAHBFNKDO<IOFOCLGJBKE>, EBHOHPLBABB<IOFOCLGJBKE>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x775E390", Offset = "0x775D390", VA = "0x18775E390", Slot = "4")]
	public IEnumerable<(IOFOCLGJBKE, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x775E370", Offset = "0x775D370", VA = "0x18775E370", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public IOFOCLGJBKE APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(IOFOCLGJBKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public PDIHCNELBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FGCIIMOPBBF : FLKAHBFNKDO<LAAGBDBIFCE>, EBHOHPLBABB<LAAGBDBIFCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7753710", Offset = "0x7752710", VA = "0x187753710", Slot = "4")]
	public IEnumerable<(LAAGBDBIFCE, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public LAAGBDBIFCE APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(LAAGBDBIFCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public FGCIIMOPBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CACDEAEMEFG : FLKAHBFNKDO<LHADLCKBALK>, EBHOHPLBABB<LHADLCKBALK>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7750CD0", Offset = "0x774FCD0", VA = "0x187750CD0", Slot = "4")]
	public IEnumerable<(LHADLCKBALK, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public LHADLCKBALK APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(LHADLCKBALK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public CACDEAEMEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JEKOFCIIBLM : FLKAHBFNKDO<BEFENALLNEP>, EBHOHPLBABB<BEFENALLNEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly EBHOHPLBABB<ICCKNJPMFGP> BFNIGNPMOJM;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	public JEKOFCIIBLM(EBHOHPLBABB<ICCKNJPMFGP> BFNIGNPMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x75F04F0", Offset = "0x75EF4F0", VA = "0x1875F04F0", Slot = "4")]
	public IEnumerable<(BEFENALLNEP, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7755370", Offset = "0x7754370", VA = "0x187755370", Slot = "6")]
	public BEFENALLNEP APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(BEFENALLNEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x77555B0", Offset = "0x77545B0", VA = "0x1877555B0", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LCKLPFLPDHI : FLKAHBFNKDO<LOEDIDEPMAK>, EBHOHPLBABB<LOEDIDEPMAK>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77551C0", VA = "0x1877561C0", Slot = "4")]
	public IEnumerable<(LOEDIDEPMAK, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public LOEDIDEPMAK APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(LOEDIDEPMAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LCKLPFLPDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HKFJKEJGJKG : FLKAHBFNKDO<CEHCJOLGKJG>, EBHOHPLBABB<CEHCJOLGKJG>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7753AB0", Offset = "0x7752AB0", VA = "0x187753AB0", Slot = "4")]
	public IEnumerable<(CEHCJOLGKJG, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public CEHCJOLGKJG APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(CEHCJOLGKJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public HKFJKEJGJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NLDNHMNIHND : FLKAHBFNKDO<NEANNCABPBL>, EBHOHPLBABB<NEANNCABPBL>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x775DF50", Offset = "0x775CF50", VA = "0x18775DF50", Slot = "4")]
	public IEnumerable<(NEANNCABPBL, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public NEANNCABPBL APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(NEANNCABPBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public NLDNHMNIHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JLFDLAKIMCM : FLKAHBFNKDO<GGBIONBNLAB>, EBHOHPLBABB<GGBIONBNLAB>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7755B40", Offset = "0x7754B40", VA = "0x187755B40", Slot = "4")]
	public IEnumerable<(GGBIONBNLAB, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public GGBIONBNLAB APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(GGBIONBNLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public JLFDLAKIMCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FLKAHBFNKDO<TModern> : EBHOHPLBABB<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LNHBOJFBEJD();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CIOFAJMKNFB(string NBMPOJFDLGC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GKNDHCPDEHG : FLKAHBFNKDO<ICCKNJPMFGP>, EBHOHPLBABB<ICCKNJPMFGP>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76A5610", Offset = "0x76A4610", VA = "0x1876A5610", Slot = "4")]
	public IEnumerable<(ICCKNJPMFGP, string)> LNHBOJFBEJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA8DD50", Offset = "0xA8CD50", VA = "0x180A8DD50", Slot = "5")]
	public string CIOFAJMKNFB(string NBMPOJFDLGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7750C10", Offset = "0x774FC10", VA = "0x187750C10", Slot = "6")]
	public ICCKNJPMFGP APENNHHLPFO(string NBMPOJFDLGC)
	{
		return default(ICCKNJPMFGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public GKNDHCPDEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MLOMNJKLHOF<TModern> : JMKEPDKLDNL<TModern>, EBHOHPLBABB<TModern> where TModern : IEquatable<TModern>, PACINHNAFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> ADEGLJBIIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> MGOANGEOIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FLKAHBFNKDO<TModern> KPNGEAPEBJL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4961160", Offset = "0x4960160", VA = "0x184961160")]
	public MLOMNJKLHOF(FLKAHBFNKDO<TModern> KPNGEAPEBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x495E8B0", Offset = "0x495D8B0", VA = "0x18495E8B0", Slot = "5")]
	public TModern APENNHHLPFO(string NBMPOJFDLGC)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x495F570", Offset = "0x495E570", VA = "0x18495F570", Slot = "4")]
	public string JJIJNDGFGHD(TModern LCKCHHICAKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JHNAMKBIAOH : KDABCBFBNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MLOMNJKLHOF<IOFOCLGJBKE> DAPCNNEGMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MLOMNJKLHOF<LOEDIDEPMAK> FJCLGCNALAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MLOMNJKLHOF<GGBIONBNLAB> NHDLPNGLLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MLOMNJKLHOF<ICCKNJPMFGP> BFNIGNPMOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MLOMNJKLHOF<BEFENALLNEP> FGFDBKEKKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MLOMNJKLHOF<LHADLCKBALK> BHJIFLHCGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MLOMNJKLHOF<NEANNCABPBL> MJOFMOIEIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MLOMNJKLHOF<LAAGBDBIFCE> MMGLDICDGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MLOMNJKLHOF<CEHCJOLGKJG> GLAKEOPFODC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JMKEPDKLDNL<IOFOCLGJBKE> MBHLMDHIFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JMKEPDKLDNL<LOEDIDEPMAK> BPHDMFJJHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JMKEPDKLDNL<GGBIONBNLAB> NEHHGLADJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JMKEPDKLDNL<BEFENALLNEP> GNOBODCAICA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JMKEPDKLDNL<LHADLCKBALK> EDBFHMJGOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JMKEPDKLDNL<NEANNCABPBL> DIENBDDNNNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JMKEPDKLDNL<LAAGBDBIFCE> OIPFABHKMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JMKEPDKLDNL<CEHCJOLGKJG> MEDLCDAJCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x77555F0", Offset = "0x77545F0", VA = "0x1877555F0")]
	[AEDCCIMPEFD.GIGKNHONDJE.KBDJNGCKNKK]
	[UsedImplicitly]
	internal static void MHIJNHBLKEJ(MAONAIOKEHK OLAHEEDNGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7755660", Offset = "0x7754660", VA = "0x187755660")]
	[RecRoom.NoEngine.Common.Preserve]
	public JHNAMKBIAOH()
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
