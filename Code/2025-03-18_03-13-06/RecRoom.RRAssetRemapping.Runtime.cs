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
		[Cpp2IlInjected.Address(RVA = "0x7F91910", Offset = "0x7F90B10", VA = "0x187F91910", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JMPCFKIILCE : FINHHFNAKCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex FEJJKIOGBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OPMMEONFMCI CNLKGLJAPNF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F903C0", Offset = "0x7F8F5C0", VA = "0x187F903C0")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	[UsedImplicitly]
	internal static void JHIKJAALCJE(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F90020", Offset = "0x7F8F220", VA = "0x187F90020")]
	[UsedImplicitly]
	internal static void BHFBCNCHFAP(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	[RecRoom.NoEngine.Common.Preserve]
	public JMPCFKIILCE([KMMHIEIDBEA(null)] OPMMEONFMCI CNLKGLJAPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F90080", Offset = "0x7F8F280", VA = "0x187F90080", Slot = "4")]
	public string JEAAONFOJJH(BGAANIHBCHM GEDAGNGPIPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F8FB50", Offset = "0x7F8ED50", VA = "0x187F8FB50", Slot = "5")]
	public BGAANIHBCHM ANADGBKPLNB(string GEDAGNGPIPL)
	{
		return default(BGAANIHBCHM);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public DBNNFNBKLPB ANADGBKPLNB()
		{
			return default(DBNNFNBKLPB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F90DD0", Offset = "0x7F8FFD0", VA = "0x187F90DD0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E90", Offset = "0x7F90090", VA = "0x187F90E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public OICBNHEMJNF ANADGBKPLNB()
		{
			return default(OICBNHEMJNF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F90F00", Offset = "0x7F90100", VA = "0x187F90F00", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F90FA0", Offset = "0x7F901A0", VA = "0x187F90FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public GMOJNJFKNAH ANADGBKPLNB()
		{
			return default(GMOJNJFKNAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedColorId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedColorId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F91010", Offset = "0x7F90210", VA = "0x187F91010", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F910B0", Offset = "0x7F902B0", VA = "0x187F910B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, AEJFKFOGKPI, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB45CB0", Offset = "0xB44EB0", VA = "0x180B45CB0")]
		public KFKBHGMMOEG ANADGBKPLNB()
		{
			return default(KFKBHGMMOEG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DD40", Offset = "0x7E1CF40", VA = "0x187E1DD40", Slot = "4")]
		public bool Equals(SerializedCombinationId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F91120", Offset = "0x7F90320", VA = "0x187F91120", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedCombinationId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F911E0", Offset = "0x7F903E0", VA = "0x187F911E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F911D0", Offset = "0x7F903D0", VA = "0x187F911D0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, AEJFKFOGKPI
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x10A0120", Offset = "0x109F320", VA = "0x1810A0120")]
		public SerializedCustomAvatarItemId(Guid FGPNICIMMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public static SerializedCustomAvatarItemId KBCKEBIPALB(Guid FGPNICIMMFP)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F91250", Offset = "0x7F90450", VA = "0x187F91250", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70")]
		public static bool GJNOMHNHJKL(SerializedCustomAvatarItemId MGBGOAGHGOJ, SerializedCustomAvatarItemId FCFMBBJABHD)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F912F0", Offset = "0x7F904F0", VA = "0x187F912F0")]
		public static bool GHFFJAPPGNB(SerializedCustomAvatarItemId MGBGOAGHGOJ, SerializedCustomAvatarItemId FCFMBBJABHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F91310", Offset = "0x7F90510", VA = "0x187F91310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x7F91380", Offset = "0x7F90580", VA = "0x187F91380")]
		public static SerializedEquipmentSkinId DJLALFIABBP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public OAHMAPNALPM ANADGBKPLNB()
		{
			return default(OAHMAPNALPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F913B0", Offset = "0x7F905B0", VA = "0x187F913B0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F91450", Offset = "0x7F90650", VA = "0x187F91450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public FKCADKOIAIJ ANADGBKPLNB()
		{
			return default(FKCADKOIAIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F914C0", Offset = "0x7F906C0", VA = "0x187F914C0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F91560", Offset = "0x7F90760", VA = "0x187F91560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public COALEIABEBD ANADGBKPLNB()
		{
			return default(COALEIABEBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F915D0", Offset = "0x7F907D0", VA = "0x187F915D0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F91670", Offset = "0x7F90870", VA = "0x187F91670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110")]
		public EHPJCGLIJLP ANADGBKPLNB()
		{
			return default(EHPJCGLIJLP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70", Slot = "4")]
		public bool Equals(SerializedHairPatternId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F916E0", Offset = "0x7F908E0", VA = "0x187F916E0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F90E70", Offset = "0x7F90070", VA = "0x187F90E70")]
		public static bool GJNOMHNHJKL(SerializedHairPatternId MGBGOAGHGOJ, SerializedHairPatternId FCFMBBJABHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7F91780", Offset = "0x7F90980", VA = "0x187F91780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, AEJFKFOGKPI
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
		[Cpp2IlInjected.Address(RVA = "0x10A0110", Offset = "0x109F310", VA = "0x1810A0110", Slot = "6")]
		public Guid JDEHCEJHEGD()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E1DD40", Offset = "0x7E1CF40", VA = "0x187E1DD40", Slot = "4")]
		public bool Equals(SerializedMaterialId LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F917F0", Offset = "0x7F909F0", VA = "0x187F917F0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7487300", Offset = "0x7486500", VA = "0x187487300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7487170", Offset = "0x7486370", VA = "0x187487170", Slot = "5")]
		public int CompareTo(SerializedMaterialId LDKNLBHIGFL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F918A0", Offset = "0x7F90AA0", VA = "0x187F918A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PKAKFICIIJG : OPMMEONFMCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PKAKFICIIJG JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F90D10", Offset = "0x7F8FF10", VA = "0x187F90D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public AHJHCCMBMGO<DBNNFNBKLPB> FOLEAGDJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F90A70", Offset = "0x7F8FC70", VA = "0x187F90A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AHJHCCMBMGO<OAHMAPNALPM> AEIEPGPKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F90B90", Offset = "0x7F8FD90", VA = "0x187F90B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AHJHCCMBMGO<EHPJCGLIJLP> DBPCHLMAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F90D70", Offset = "0x7F8FF70", VA = "0x187F90D70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AHJHCCMBMGO<KFKBHGMMOEG> HMPMBLIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F90CB0", Offset = "0x7F8FEB0", VA = "0x187F90CB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AHJHCCMBMGO<GMOJNJFKNAH> MHIMIOHIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F90B30", Offset = "0x7F8FD30", VA = "0x187F90B30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AHJHCCMBMGO<COALEIABEBD> PHGPHBBKOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F90AD0", Offset = "0x7F8FCD0", VA = "0x187F90AD0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AHJHCCMBMGO<OICBNHEMJNF> NCKGKDEBCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F90BF0", Offset = "0x7F8FDF0", VA = "0x187F90BF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AHJHCCMBMGO<FKCADKOIAIJ> NMGOHIIPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F90C50", Offset = "0x7F8FE50", VA = "0x187F90C50", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NNNEPBJCDGA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F909C0", Offset = "0x7F8FBC0", VA = "0x187F909C0")]
	public static Guid MKPEMHCNLGF(string MMJIEOFEBMD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F908F0", Offset = "0x7F8FAF0", VA = "0x187F908F0")]
	public static bool HKGFLIJCGNM(string MMJIEOFEBMD, [Out] Guid FGPNICIMMFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DHLBAECFDLH : HFADGNAOEGH<DBNNFNBKLPB>, DIJBIKLMCFK<DBNNFNBKLPB>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F80040", Offset = "0x7F7F240", VA = "0x187F80040", Slot = "4")]
	public IEnumerable<(DBNNFNBKLPB, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F80020", Offset = "0x7F7F220", VA = "0x187F80020", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public DBNNFNBKLPB GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(DBNNFNBKLPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DHLBAECFDLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EFGIHPHJJAN : HFADGNAOEGH<OICBNHEMJNF>, DIJBIKLMCFK<OICBNHEMJNF>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F851E0", Offset = "0x7F843E0", VA = "0x187F851E0", Slot = "4")]
	public IEnumerable<(OICBNHEMJNF, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public OICBNHEMJNF GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(OICBNHEMJNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EFGIHPHJJAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JMEKKGOPHHM : HFADGNAOEGH<GMOJNJFKNAH>, DIJBIKLMCFK<GMOJNJFKNAH>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DA90", Offset = "0x7F8CC90", VA = "0x187F8DA90", Slot = "4")]
	public IEnumerable<(GMOJNJFKNAH, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public GMOJNJFKNAH GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(GMOJNJFKNAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public JMEKKGOPHHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FLOALBOMFIL : HFADGNAOEGH<KFKBHGMMOEG>, DIJBIKLMCFK<KFKBHGMMOEG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly DIJBIKLMCFK<IAFBNDMAPDH> IPAGMCGEOND;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public FLOALBOMFIL(DIJBIKLMCFK<IAFBNDMAPDH> IPAGMCGEOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E1E2E0", Offset = "0x7E1D4E0", VA = "0x187E1E2E0", Slot = "4")]
	public IEnumerable<(KFKBHGMMOEG, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8D810", Offset = "0x7F8CA10", VA = "0x187F8D810", Slot = "6")]
	public KFKBHGMMOEG GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(KFKBHGMMOEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8DA50", Offset = "0x7F8CC50", VA = "0x187F8DA50", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EONDENFMONJ : HFADGNAOEGH<OAHMAPNALPM>, DIJBIKLMCFK<OAHMAPNALPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F85C00", Offset = "0x7F84E00", VA = "0x187F85C00", Slot = "4")]
	public IEnumerable<(OAHMAPNALPM, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public OAHMAPNALPM GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(OAHMAPNALPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EONDENFMONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CDGBKMJJIFB : HFADGNAOEGH<FKCADKOIAIJ>, DIJBIKLMCFK<FKCADKOIAIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E760", Offset = "0x7F7D960", VA = "0x187F7E760", Slot = "4")]
	public IEnumerable<(FKCADKOIAIJ, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public FKCADKOIAIJ GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(FKCADKOIAIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public CDGBKMJJIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MDDBJHCHICN : HFADGNAOEGH<COALEIABEBD>, DIJBIKLMCFK<COALEIABEBD>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F904D0", Offset = "0x7F8F6D0", VA = "0x187F904D0", Slot = "4")]
	public IEnumerable<(COALEIABEBD, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public COALEIABEBD GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(COALEIABEBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public MDDBJHCHICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EIFBHOCNFMK : HFADGNAOEGH<EHPJCGLIJLP>, DIJBIKLMCFK<EHPJCGLIJLP>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F85580", Offset = "0x7F84780", VA = "0x187F85580", Slot = "4")]
	public IEnumerable<(EHPJCGLIJLP, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public EHPJCGLIJLP GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(EHPJCGLIJLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EIFBHOCNFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HFADGNAOEGH<TModern> : DIJBIKLMCFK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> KJOFPBJBMIM();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JIOBPCCJAIF(string DKEIFIJICHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GDCIFGMCDDN : HFADGNAOEGH<IAFBNDMAPDH>, DIJBIKLMCFK<IAFBNDMAPDH>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7ED3400", Offset = "0x7ED2600", VA = "0x187ED3400", Slot = "4")]
	public IEnumerable<(IAFBNDMAPDH, string)> KJOFPBJBMIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "5")]
	public string JIOBPCCJAIF(string DKEIFIJICHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F7E6A0", Offset = "0x7F7D8A0", VA = "0x187F7E6A0", Slot = "6")]
	public IAFBNDMAPDH GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return default(IAFBNDMAPDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GDCIFGMCDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FFHFBCAFNJK<TModern> : AHJHCCMBMGO<TModern>, DIJBIKLMCFK<TModern> where TModern : IEquatable<TModern>, AEJFKFOGKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> DFDDFMAGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> AMMKDKBPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HFADGNAOEGH<TModern> PBFLHMCIKIB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x44BD130", Offset = "0x44BC330", VA = "0x1844BD130")]
	public FFHFBCAFNJK(HFADGNAOEGH<TModern> PBFLHMCIKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44BA7B0", Offset = "0x44B99B0", VA = "0x1844BA7B0", Slot = "5")]
	public TModern GEGCDLMGOLM(string DKEIFIJICHJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x44BC050", Offset = "0x44BB250", VA = "0x1844BC050", Slot = "4")]
	public string IKENOJMGOIG(TModern KEABNMABJJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DKMFFJCNNDH : OPMMEONFMCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private FFHFBCAFNJK<DBNNFNBKLPB> BIAFACCJLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FFHFBCAFNJK<OAHMAPNALPM> DDCFNEOGGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private FFHFBCAFNJK<EHPJCGLIJLP> KLCKCINBJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private FFHFBCAFNJK<IAFBNDMAPDH> IPAGMCGEOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private FFHFBCAFNJK<KFKBHGMMOEG> DLBDALBJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private FFHFBCAFNJK<GMOJNJFKNAH> DNNHMAPJPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private FFHFBCAFNJK<COALEIABEBD> EIOFBCFMJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private FFHFBCAFNJK<OICBNHEMJNF> DHGJHEBGLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private FFHFBCAFNJK<FKCADKOIAIJ> HFMDGNOPEHI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AHJHCCMBMGO<DBNNFNBKLPB> FOLEAGDJEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AHJHCCMBMGO<OAHMAPNALPM> AEIEPGPKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AHJHCCMBMGO<EHPJCGLIJLP> DBPCHLMAGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AHJHCCMBMGO<KFKBHGMMOEG> HMPMBLIJCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AHJHCCMBMGO<GMOJNJFKNAH> MHIMIOHIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AHJHCCMBMGO<COALEIABEBD> PHGPHBBKOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AHJHCCMBMGO<OICBNHEMJNF> NCKGKDEBCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AHJHCCMBMGO<FKCADKOIAIJ> NMGOHIIPDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F84C90", Offset = "0x7F83E90", VA = "0x187F84C90")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	[UsedImplicitly]
	internal static void BBACBJKIIBA(ANOENEDKKHA PIKGEGNPHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F84D00", Offset = "0x7F83F00", VA = "0x187F84D00")]
	[RecRoom.NoEngine.Common.Preserve]
	public DKMFFJCNNDH()
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
