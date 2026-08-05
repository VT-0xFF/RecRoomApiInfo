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
		[Cpp2IlInjected.Address(RVA = "0x8812820", Offset = "0x8811420", VA = "0x188812820", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IFJCKDMOPEI : JHHKNMPBHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex BKFAGJKCIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MCAHKOEDIHJ MBMEDMNPOGB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8805E70", Offset = "0x8804A70", VA = "0x188805E70")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	[UsedImplicitly]
	internal static void MACELCFKDEA(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8805940", Offset = "0x8804540", VA = "0x188805940")]
	[UsedImplicitly]
	internal static void DIOJHIPJHAK(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IFJCKDMOPEI([GFNPNOLPMKK(null)] MCAHKOEDIHJ MBMEDMNPOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8805600", Offset = "0x8804200", VA = "0x188805600", Slot = "4")]
	public string BLPDEIDOFHH(GOFJDLJJOJL OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88059A0", Offset = "0x88045A0", VA = "0x1888059A0", Slot = "5")]
	public GOFJDLJJOJL EBAGJKMAFHO(string OLMHJMNEENP)
	{
		return default(GOFJDLJJOJL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public LFHPPJPAHAE EBAGJKMAFHO()
		{
			return default(LFHPPJPAHAE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedAvatarItemId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8811C90", Offset = "0x8810890", VA = "0x188811C90", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8811D50", Offset = "0x8810950", VA = "0x188811D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public LIEKGDGCODL EBAGJKMAFHO()
		{
			return default(LIEKGDGCODL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedBodyShapeId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8811DC0", Offset = "0x88109C0", VA = "0x188811DC0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8811E60", Offset = "0x8810A60", VA = "0x188811E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public MIAOGILCLPA EBAGJKMAFHO()
		{
			return default(MIAOGILCLPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedColorId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedColorId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8811ED0", Offset = "0x8810AD0", VA = "0x188811ED0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8811F70", Offset = "0x8810B70", VA = "0x188811F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, BFLKHIBEHMF, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDDC970", Offset = "0xDDB570", VA = "0x180DDC970")]
		public PLMOHPIJHDA EBAGJKMAFHO()
		{
			return default(PLMOHPIJHDA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x869F030", Offset = "0x869DC30", VA = "0x18869F030", Slot = "4")]
		public bool Equals(SerializedCombinationId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8811FE0", Offset = "0x8810BE0", VA = "0x188811FE0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedCombinationId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88120A0", Offset = "0x8810CA0", VA = "0x1888120A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8812090", Offset = "0x8810C90", VA = "0x188812090", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, BFLKHIBEHMF
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
			[Cpp2IlInjected.Address(RVA = "0x8812240", Offset = "0x8810E40", VA = "0x188812240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1368360", Offset = "0x1366F60", VA = "0x181368360")]
		public SerializedCustomAvatarItemId(Guid LHECJJHBNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public static SerializedCustomAvatarItemId BKIKIDHAGPO(Guid LHECJJHBNHF)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8812110", Offset = "0x8810D10", VA = "0x188812110", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30")]
		public static bool JOHLOKGLNML(SerializedCustomAvatarItemId NAHMIIJKKEL, SerializedCustomAvatarItemId IJNKBHOINCA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88121B0", Offset = "0x8810DB0", VA = "0x1888121B0")]
		public static bool FOFOJFKGMNN(SerializedCustomAvatarItemId NAHMIIJKKEL, SerializedCustomAvatarItemId IJNKBHOINCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88121D0", Offset = "0x8810DD0", VA = "0x1888121D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x8812340", Offset = "0x8810F40", VA = "0x188812340")]
		public static SerializedEquipmentSkinId FHLBDJFEEIA()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public OAMJPCIHGNE EBAGJKMAFHO()
		{
			return default(OAMJPCIHGNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88122A0", Offset = "0x8810EA0", VA = "0x1888122A0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8812370", Offset = "0x8810F70", VA = "0x188812370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public DOLBAFHNJDK EBAGJKMAFHO()
		{
			return default(DOLBAFHNJDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88123E0", Offset = "0x8810FE0", VA = "0x1888123E0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8812480", Offset = "0x8811080", VA = "0x188812480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public ANPCAKLHJAE EBAGJKMAFHO()
		{
			return default(ANPCAKLHJAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedFaceShapeId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88124F0", Offset = "0x88110F0", VA = "0x1888124F0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8812590", Offset = "0x8811190", VA = "0x188812590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620")]
		public KIGICGBMFCD EBAGJKMAFHO()
		{
			return default(KIGICGBMFCD);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30", Slot = "4")]
		public bool Equals(SerializedHairPatternId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8812600", Offset = "0x8811200", VA = "0x188812600", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8811D30", Offset = "0x8810930", VA = "0x188811D30")]
		public static bool JOHLOKGLNML(SerializedHairPatternId NAHMIIJKKEL, SerializedHairPatternId IJNKBHOINCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88126A0", Offset = "0x88112A0", VA = "0x1888126A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, BFLKHIBEHMF
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
		[Cpp2IlInjected.Address(RVA = "0x115C620", Offset = "0x115B220", VA = "0x18115C620", Slot = "6")]
		public Guid CNDLLLBCKEA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x869F030", Offset = "0x869DC30", VA = "0x18869F030", Slot = "4")]
		public bool Equals(SerializedMaterialId GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8812710", Offset = "0x8811310", VA = "0x188812710", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C45C70", Offset = "0x7C44870", VA = "0x187C45C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C45AE0", Offset = "0x7C446E0", VA = "0x187C45AE0", Slot = "5")]
		public int CompareTo(SerializedMaterialId GMNGNCHKEBK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88127B0", Offset = "0x88113B0", VA = "0x1888127B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGKELLCLDIF : MCAHKOEDIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JGKELLCLDIF LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8805FE0", Offset = "0x8804BE0", VA = "0x188805FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IINBGDLEBFP<LFHPPJPAHAE> ALDFFJCLICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8806100", Offset = "0x8804D00", VA = "0x188806100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IINBGDLEBFP<OAMJPCIHGNE> KCLNIBABKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88060A0", Offset = "0x8804CA0", VA = "0x1888060A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IINBGDLEBFP<KIGICGBMFCD> PGHKBHCFBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8806040", Offset = "0x8804C40", VA = "0x188806040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IINBGDLEBFP<PLMOHPIJHDA> CGIJDOKONCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8805F80", Offset = "0x8804B80", VA = "0x188805F80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IINBGDLEBFP<MIAOGILCLPA> INBAKAPMEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8806160", Offset = "0x8804D60", VA = "0x188806160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IINBGDLEBFP<ANPCAKLHJAE> OHNKKCGADHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8806220", Offset = "0x8804E20", VA = "0x188806220", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IINBGDLEBFP<LIEKGDGCODL> JEKLHNCMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8806280", Offset = "0x8804E80", VA = "0x188806280", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IINBGDLEBFP<DOLBAFHNJDK> EPMFBGHGKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88061C0", Offset = "0x8804DC0", VA = "0x1888061C0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GMJLPCNFCLD
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8805480", Offset = "0x8804080", VA = "0x188805480")]
	public static Guid ILOEELCHPOL(string PLDFJIOPMNL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8805530", Offset = "0x8804130", VA = "0x188805530")]
	public static bool MKNPHAPNAID(string PLDFJIOPMNL, [Out] Guid LHECJJHBNHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CFCEKICCCJE : MPFJMJADGCK<LFHPPJPAHAE>, CEBFJKJADFE<LFHPPJPAHAE>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x87FFE10", Offset = "0x87FEA10", VA = "0x1887FFE10", Slot = "4")]
	public IEnumerable<(LFHPPJPAHAE, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x87FFDF0", Offset = "0x87FE9F0", VA = "0x1887FFDF0", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public LFHPPJPAHAE HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(LFHPPJPAHAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public CFCEKICCCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GHPBDCLCAHL : MPFJMJADGCK<LIEKGDGCODL>, CEBFJKJADFE<LIEKGDGCODL>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x88050E0", Offset = "0x8803CE0", VA = "0x1888050E0", Slot = "4")]
	public IEnumerable<(LIEKGDGCODL, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public LIEKGDGCODL HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(LIEKGDGCODL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GHPBDCLCAHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class POKDKJEOHBI : MPFJMJADGCK<MIAOGILCLPA>, CEBFJKJADFE<MIAOGILCLPA>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x880FBD0", Offset = "0x880E7D0", VA = "0x18880FBD0", Slot = "4")]
	public IEnumerable<(MIAOGILCLPA, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public MIAOGILCLPA HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(MIAOGILCLPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public POKDKJEOHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AKBPDOBENOK : MPFJMJADGCK<PLMOHPIJHDA>, CEBFJKJADFE<PLMOHPIJHDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CEBFJKJADFE<CDCLKPOEAAO> OCIHPBEKAMN;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public AKBPDOBENOK(CEBFJKJADFE<CDCLKPOEAAO> OCIHPBEKAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x869F1A0", Offset = "0x869DDA0", VA = "0x18869F1A0", Slot = "4")]
	public IEnumerable<(PLMOHPIJHDA, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x87FF5A0", Offset = "0x87FE1A0", VA = "0x1887FF5A0", Slot = "6")]
	public PLMOHPIJHDA HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(PLMOHPIJHDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x87FF560", Offset = "0x87FE160", VA = "0x1887FF560", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OMEFNNKEOHG : MPFJMJADGCK<OAMJPCIHGNE>, CEBFJKJADFE<OAMJPCIHGNE>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8807FC0", Offset = "0x8806BC0", VA = "0x188807FC0", Slot = "4")]
	public IEnumerable<(OAMJPCIHGNE, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public OAMJPCIHGNE HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(OAMJPCIHGNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public OMEFNNKEOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NPBLOKKCOJP : MPFJMJADGCK<DOLBAFHNJDK>, CEBFJKJADFE<DOLBAFHNJDK>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8806700", Offset = "0x8805300", VA = "0x188806700", Slot = "4")]
	public IEnumerable<(DOLBAFHNJDK, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public DOLBAFHNJDK HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(DOLBAFHNJDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NPBLOKKCOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LGHNGKGBEBI : MPFJMJADGCK<ANPCAKLHJAE>, CEBFJKJADFE<ANPCAKLHJAE>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x88062E0", Offset = "0x8804EE0", VA = "0x1888062E0", Slot = "4")]
	public IEnumerable<(ANPCAKLHJAE, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public ANPCAKLHJAE HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(ANPCAKLHJAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LGHNGKGBEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GFOHKCJHOFK : MPFJMJADGCK<KIGICGBMFCD>, CEBFJKJADFE<KIGICGBMFCD>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8804A60", Offset = "0x8803660", VA = "0x188804A60", Slot = "4")]
	public IEnumerable<(KIGICGBMFCD, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public KIGICGBMFCD HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(KIGICGBMFCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GFOHKCJHOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MPFJMJADGCK<TModern> : CEBFJKJADFE<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> OEJFGGEBKNP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DMCOELDGOJG(string HAPEPJLLHOD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BFACLHMNOMD : MPFJMJADGCK<CDCLKPOEAAO>, CEBFJKJADFE<CDCLKPOEAAO>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x87542C0", Offset = "0x8752EC0", VA = "0x1887542C0", Slot = "4")]
	public IEnumerable<(CDCLKPOEAAO, string)> OEJFGGEBKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "5")]
	public string DMCOELDGOJG(string HAPEPJLLHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x87FF7E0", Offset = "0x87FE3E0", VA = "0x1887FF7E0", Slot = "6")]
	public CDCLKPOEAAO HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return default(CDCLKPOEAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BFACLHMNOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MENEOIILJKH<TModern> : IINBGDLEBFP<TModern>, CEBFJKJADFE<TModern> where TModern : IEquatable<TModern>, BFLKHIBEHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> JNKJLANIJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> NKHBEADFBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MPFJMJADGCK<TModern> HMJLKJCBDGN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x54B2680", Offset = "0x54B1280", VA = "0x1854B2680")]
	public MENEOIILJKH(MPFJMJADGCK<TModern> HMJLKJCBDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x54AFD60", Offset = "0x54AE960", VA = "0x1854AFD60", Slot = "5")]
	public TModern HFBJLOKDJJF(string HAPEPJLLHOD)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x54AF2D0", Offset = "0x54ADED0", VA = "0x1854AF2D0", Slot = "4")]
	public string EJIAKFINFGF(TModern HNEFHOIOIPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BKCJOADALOK : MCAHKOEDIHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MENEOIILJKH<LFHPPJPAHAE> KDBGKMDBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MENEOIILJKH<OAMJPCIHGNE> OIJILOPEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MENEOIILJKH<KIGICGBMFCD> KMGPNIBBAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MENEOIILJKH<CDCLKPOEAAO> OCIHPBEKAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MENEOIILJKH<PLMOHPIJHDA> LDMHBILFJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MENEOIILJKH<MIAOGILCLPA> OJHPPBHJIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private MENEOIILJKH<ANPCAKLHJAE> ELHFGJMNPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private MENEOIILJKH<LIEKGDGCODL> BPAOKPADJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private MENEOIILJKH<DOLBAFHNJDK> DINOLDLNBGH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IINBGDLEBFP<LFHPPJPAHAE> ALDFFJCLICN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IINBGDLEBFP<OAMJPCIHGNE> KCLNIBABKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IINBGDLEBFP<KIGICGBMFCD> PGHKBHCFBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IINBGDLEBFP<PLMOHPIJHDA> CGIJDOKONCB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IINBGDLEBFP<MIAOGILCLPA> INBAKAPMEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IINBGDLEBFP<ANPCAKLHJAE> OHNKKCGADHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IINBGDLEBFP<LIEKGDGCODL> JEKLHNCMCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IINBGDLEBFP<DOLBAFHNJDK> EPMFBGHGKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x87FF8A0", Offset = "0x87FE4A0", VA = "0x1887FF8A0")]
	[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
	[UsedImplicitly]
	internal static void FPIMJJMHECA(PFGPAPHADOM AKKHFHFGLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x87FF910", Offset = "0x87FE510", VA = "0x1887FF910")]
	[RecRoom.NoEngine.Common.Preserve]
	public BKCJOADALOK()
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
