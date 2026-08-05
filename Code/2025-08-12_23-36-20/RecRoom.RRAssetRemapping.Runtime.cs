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
		[Cpp2IlInjected.Address(RVA = "0x8E04CD0", Offset = "0x8E03AD0", VA = "0x188E04CD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HECBEBMJFBA : EFOAHIEBMAB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex EBKIEKGKIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NHIJPMINOCB LJIELAOKOPG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8E00E30", Offset = "0x8DFFC30", VA = "0x188E00E30")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void DKLHNMBDELP(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8E00EA0", Offset = "0x8DFFCA0", VA = "0x188E00EA0")]
	[UsedImplicitly]
	internal static void KELGELEOCEL(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	[RecRoom.NoEngine.Common.Preserve]
	public HECBEBMJFBA([POMNKOCGGBN(null)] NHIJPMINOCB LJIELAOKOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8E00F00", Offset = "0x8DFFD00", VA = "0x188E00F00", Slot = "4")]
	public string OFACCHGGJAP(EPADPFJDNDI DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8E01240", Offset = "0x8E00040", VA = "0x188E01240", Slot = "5")]
	public EPADPFJDNDI PPEAGMPJINO(string DANFKLEPBNF)
	{
		return default(EPADPFJDNDI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public MDLPHIOGMIH PPEAGMPJINO()
		{
			return default(MDLPHIOGMIH);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E04140", Offset = "0x8E02F40", VA = "0x188E04140", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E04200", Offset = "0x8E03000", VA = "0x188E04200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public LCJKMECGKBD PPEAGMPJINO()
		{
			return default(LCJKMECGKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E04270", Offset = "0x8E03070", VA = "0x188E04270", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E04310", Offset = "0x8E03110", VA = "0x188E04310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public OEOJAONNJFH PPEAGMPJINO()
		{
			return default(OEOJAONNJFH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedColorId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedColorId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E04380", Offset = "0x8E03180", VA = "0x188E04380", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E04420", Offset = "0x8E03220", VA = "0x188E04420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CCCADGGIHHO, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		public NGBEPHHOLNP PPEAGMPJINO()
		{
			return default(NGBEPHHOLNP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C912E0", Offset = "0x8C900E0", VA = "0x188C912E0", Slot = "4")]
		public bool Equals(SerializedCombinationId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E04490", Offset = "0x8E03290", VA = "0x188E04490", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedCombinationId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E04550", Offset = "0x8E03350", VA = "0x188E04550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E04540", Offset = "0x8E03340", VA = "0x188E04540", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CCCADGGIHHO
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
			[Cpp2IlInjected.Address(RVA = "0x8E046F0", Offset = "0x8E034F0", VA = "0x188E046F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x14E5B80", Offset = "0x14E4980", VA = "0x1814E5B80")]
		public SerializedCustomAvatarItemId(Guid NMEMPCKPCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public static SerializedCustomAvatarItemId KEDODPCCNOL(Guid NMEMPCKPCOG)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E045C0", Offset = "0x8E033C0", VA = "0x188E045C0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0")]
		public static bool IKIADGFKNFC(SerializedCustomAvatarItemId NNEMEIEKIAF, SerializedCustomAvatarItemId JOGLOLMOJGN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E04660", Offset = "0x8E03460", VA = "0x188E04660")]
		public static bool GFAFFKCBFKA(SerializedCustomAvatarItemId NNEMEIEKIAF, SerializedCustomAvatarItemId JOGLOLMOJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E04680", Offset = "0x8E03480", VA = "0x188E04680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x8E047F0", Offset = "0x8E035F0", VA = "0x188E047F0")]
		public static SerializedEquipmentSkinId ILCCDGIBEKM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public JGBEJPGGFBH PPEAGMPJINO()
		{
			return default(JGBEJPGGFBH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E04750", Offset = "0x8E03550", VA = "0x188E04750", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E04820", Offset = "0x8E03620", VA = "0x188E04820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public NJKDBAMDGPL PPEAGMPJINO()
		{
			return default(NJKDBAMDGPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E04890", Offset = "0x8E03690", VA = "0x188E04890", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E04930", Offset = "0x8E03730", VA = "0x188E04930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public INBBLDDKEIN PPEAGMPJINO()
		{
			return default(INBBLDDKEIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8E049A0", Offset = "0x8E037A0", VA = "0x188E049A0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8E04A40", Offset = "0x8E03840", VA = "0x188E04A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0")]
		public HDHJBPNLPKA PPEAGMPJINO()
		{
			return default(HDHJBPNLPKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0", Slot = "4")]
		public bool Equals(SerializedHairPatternId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedHairPatternId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8E04AB0", Offset = "0x8E038B0", VA = "0x188E04AB0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E041E0", Offset = "0x8E02FE0", VA = "0x188E041E0")]
		public static bool IKIADGFKNFC(SerializedHairPatternId NNEMEIEKIAF, SerializedHairPatternId JOGLOLMOJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E04B50", Offset = "0x8E03950", VA = "0x188E04B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CCCADGGIHHO
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
		[Cpp2IlInjected.Address(RVA = "0x128D9C0", Offset = "0x128C7C0", VA = "0x18128D9C0", Slot = "6")]
		public Guid NKCNCCPGDNO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8C912E0", Offset = "0x8C900E0", VA = "0x188C912E0", Slot = "4")]
		public bool Equals(SerializedMaterialId FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8E04BC0", Offset = "0x8E039C0", VA = "0x188E04BC0", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81FAA20", Offset = "0x81F9820", VA = "0x1881FAA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81FA890", Offset = "0x81F9690", VA = "0x1881FA890", Slot = "5")]
		public int CompareTo(SerializedMaterialId FGAEAFBDBPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8E04C60", Offset = "0x8E03A60", VA = "0x188E04C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MHPJMBEOBEC : NHIJPMINOCB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MHPJMBEOBEC MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8E04080", Offset = "0x8E02E80", VA = "0x188E04080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BMGIGODMMEP<MDLPHIOGMIH> BKHILPKNAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8E03E40", Offset = "0x8E02C40", VA = "0x188E03E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BMGIGODMMEP<JGBEJPGGFBH> APIOCIGKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8E03DE0", Offset = "0x8E02BE0", VA = "0x188E03DE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BMGIGODMMEP<HDHJBPNLPKA> CBDJJPKEAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8E03F00", Offset = "0x8E02D00", VA = "0x188E03F00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BMGIGODMMEP<NGBEPHHOLNP> ABFPMGGDMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8E03EA0", Offset = "0x8E02CA0", VA = "0x188E03EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMGIGODMMEP<OEOJAONNJFH> FNMCMIHIDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8E03FC0", Offset = "0x8E02DC0", VA = "0x188E03FC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMGIGODMMEP<INBBLDDKEIN> MGOJOCENAII
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8E04020", Offset = "0x8E02E20", VA = "0x188E04020", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BMGIGODMMEP<LCJKMECGKBD> AJJHIGINOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8E03F60", Offset = "0x8E02D60", VA = "0x188E03F60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BMGIGODMMEP<NJKDBAMDGPL> IKILKMPDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E040E0", Offset = "0x8E02EE0", VA = "0x188E040E0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KFCFHCMHKHI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8E023A0", Offset = "0x8E011A0", VA = "0x188E023A0")]
	public static Guid FIJDBLGACLJ(string DDPOCHOCMCH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8E02450", Offset = "0x8E01250", VA = "0x188E02450")]
	public static bool KJEAMEKFBPK(string DDPOCHOCMCH, [Out] Guid NMEMPCKPCOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ACCJALOADDG : ADOHBCOBGLG<MDLPHIOGMIH>, PJPPMPOCGHE<MDLPHIOGMIH>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1AD0", Offset = "0x8DF08D0", VA = "0x188DF1AD0", Slot = "4")]
	public IEnumerable<(MDLPHIOGMIH, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8DF6720", Offset = "0x8DF5520", VA = "0x188DF6720", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public MDLPHIOGMIH HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(MDLPHIOGMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ACCJALOADDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AKKANPFPBIC : ADOHBCOBGLG<LCJKMECGKBD>, PJPPMPOCGHE<LCJKMECGKBD>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8DF6740", Offset = "0x8DF5540", VA = "0x188DF6740", Slot = "4")]
	public IEnumerable<(LCJKMECGKBD, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public LCJKMECGKBD HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(LCJKMECGKBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public AKKANPFPBIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EGGFMFFPPBD : ADOHBCOBGLG<OEOJAONNJFH>, PJPPMPOCGHE<OEOJAONNJFH>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8DFED70", Offset = "0x8DFDB70", VA = "0x188DFED70", Slot = "4")]
	public IEnumerable<(OEOJAONNJFH, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public OEOJAONNJFH HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(OEOJAONNJFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EGGFMFFPPBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KEAPJLJICJF : ADOHBCOBGLG<NGBEPHHOLNP>, PJPPMPOCGHE<NGBEPHHOLNP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly PJPPMPOCGHE<KEGLPJPCCOP> NHBPGAMMFCK;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public KEAPJLJICJF(PJPPMPOCGHE<KEGLPJPCCOP> NHBPGAMMFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8C91650", Offset = "0x8C90450", VA = "0x188C91650", Slot = "4")]
	public IEnumerable<(NGBEPHHOLNP, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8E02120", Offset = "0x8E00F20", VA = "0x188E02120", Slot = "6")]
	public NGBEPHHOLNP HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(NGBEPHHOLNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8E02360", Offset = "0x8E01160", VA = "0x188E02360", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DFNMKBKNGIP : ADOHBCOBGLG<JGBEJPGGFBH>, PJPPMPOCGHE<JGBEJPGGFBH>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8DF7160", Offset = "0x8DF5F60", VA = "0x188DF7160", Slot = "4")]
	public IEnumerable<(JGBEJPGGFBH, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public JGBEJPGGFBH HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(JGBEJPGGFBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public DFNMKBKNGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KHMOFILIAGF : ADOHBCOBGLG<NJKDBAMDGPL>, PJPPMPOCGHE<NJKDBAMDGPL>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8E02520", Offset = "0x8E01320", VA = "0x188E02520", Slot = "4")]
	public IEnumerable<(NJKDBAMDGPL, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public NJKDBAMDGPL HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(NJKDBAMDGPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public KHMOFILIAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ILPGFGAJOAH : ADOHBCOBGLG<INBBLDDKEIN>, PJPPMPOCGHE<INBBLDDKEIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8E01D00", Offset = "0x8E00B00", VA = "0x188E01D00", Slot = "4")]
	public IEnumerable<(INBBLDDKEIN, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public INBBLDDKEIN HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(INBBLDDKEIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public ILPGFGAJOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BHFODOALJDO : ADOHBCOBGLG<HDHJBPNLPKA>, PJPPMPOCGHE<HDHJBPNLPKA>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8DF6AE0", Offset = "0x8DF58E0", VA = "0x188DF6AE0", Slot = "4")]
	public IEnumerable<(HDHJBPNLPKA, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public HDHJBPNLPKA HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(HDHJBPNLPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public BHFODOALJDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ADOHBCOBGLG<TModern> : PJPPMPOCGHE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> KCFPAPLPADF();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PFHCEGKDIJH(string JCIBDHEKJIB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OJMKAKLENPA : ADOHBCOBGLG<KEGLPJPCCOP>, PJPPMPOCGHE<KEGLPJPCCOP>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8D46770", Offset = "0x8D45570", VA = "0x188D46770", Slot = "4")]
	public IEnumerable<(KEGLPJPCCOP, string)> KCFPAPLPADF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "5")]
	public string PFHCEGKDIJH(string JCIBDHEKJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1A10", Offset = "0x8DF0810", VA = "0x188DF1A10", Slot = "6")]
	public KEGLPJPCCOP HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return default(KEGLPJPCCOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public OJMKAKLENPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LOMAEGOHNJF<TModern> : BMGIGODMMEP<TModern>, PJPPMPOCGHE<TModern> where TModern : IEquatable<TModern>, CCCADGGIHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> CNBNHAHNODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> CBNJJDKBOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ADOHBCOBGLG<TModern> IMKABGOHHAE;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x56A0960", Offset = "0x569F760", VA = "0x1856A0960")]
	public LOMAEGOHNJF(ADOHBCOBGLG<TModern> IMKABGOHHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x569F2D0", Offset = "0x569E0D0", VA = "0x18569F2D0", Slot = "5")]
	public TModern HLBPINBEMGO(string JCIBDHEKJIB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x56A00C0", Offset = "0x569EEC0", VA = "0x1856A00C0", Slot = "4")]
	public string IMCGLGDDJJI(TModern LOICGIBAMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HKLCDMMNFFL : NHIJPMINOCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private LOMAEGOHNJF<MDLPHIOGMIH> MFEOMNNOBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LOMAEGOHNJF<JGBEJPGGFBH> LMJHNHBLCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LOMAEGOHNJF<HDHJBPNLPKA> IMCPIHMANEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LOMAEGOHNJF<KEGLPJPCCOP> NHBPGAMMFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LOMAEGOHNJF<NGBEPHHOLNP> CBBKKBKLJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LOMAEGOHNJF<OEOJAONNJFH> EPLHCPHBGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private LOMAEGOHNJF<INBBLDDKEIN> CJOJONHCGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LOMAEGOHNJF<LCJKMECGKBD> GMDOOFAJEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LOMAEGOHNJF<NJKDBAMDGPL> HCHMMFLFABA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BMGIGODMMEP<MDLPHIOGMIH> BKHILPKNAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BMGIGODMMEP<JGBEJPGGFBH> APIOCIGKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BMGIGODMMEP<HDHJBPNLPKA> CBDJJPKEAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BMGIGODMMEP<NGBEPHHOLNP> ABFPMGGDMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BMGIGODMMEP<OEOJAONNJFH> FNMCMIHIDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BMGIGODMMEP<INBBLDDKEIN> MGOJOCENAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BMGIGODMMEP<LCJKMECGKBD> AJJHIGINOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BMGIGODMMEP<NJKDBAMDGPL> IKILKMPDNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8E017B0", Offset = "0x8E005B0", VA = "0x188E017B0")]
	[NKOKDPHOKEP.APMGAGDLDLC.MJKDHMGHAOE]
	[UsedImplicitly]
	internal static void NCFBCDNFMCP(HJFNEHLLJBB NPHHLLEFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8E01820", Offset = "0x8E00620", VA = "0x188E01820")]
	[RecRoom.NoEngine.Common.Preserve]
	public HKLCDMMNFFL()
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
