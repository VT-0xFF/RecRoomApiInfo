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
public class ADMDNGDDJKD : LBMGCBCDEKO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex HINJFHJMNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CJIPKNKAEMB CLMCNIEBOCI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71479B0", Offset = "0x71463B0", VA = "0x1871479B0")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	[UsedImplicitly]
	private static void ECBJKBNABGH(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7147A20", Offset = "0x7146420", VA = "0x187147A20")]
	[UsedImplicitly]
	[GDGALFJPCGE(JMIPDAHBNNG.EditorOnly)]
	private static void HOEAFLBKGNB(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	[Preserve]
	public ADMDNGDDJKD([OMAPKKAGFIL(null)] CJIPKNKAEMB CLMCNIEBOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7147A80", Offset = "0x7146480", VA = "0x187147A80", Slot = "4")]
	public string OPCGAJMHMBL(IMGBFBEHHOP PMPNIONIFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71472D0", Offset = "0x7145CD0", VA = "0x1871472D0", Slot = "5")]
	public IMGBFBEHHOP DGBBAPGEGII(string PMPNIONIFNI)
	{
		return default(IMGBFBEHHOP);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
		public SerializedAvatarItemId(GKBBJJAJIMK DKFNFHGODON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public GKBBJJAJIMK DGBBAPGEGII()
		{
			return default(GKBBJJAJIMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7159E50", Offset = "0x7158850", VA = "0x187159E50", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7159F10", Offset = "0x7158910", VA = "0x187159F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public DBPBPDCICIF DGBBAPGEGII()
		{
			return default(DBPBPDCICIF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7159F80", Offset = "0x7158980", VA = "0x187159F80", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x715A020", Offset = "0x7158A20", VA = "0x18715A020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public DCDLGKFIGAG DGBBAPGEGII()
		{
			return default(DCDLGKFIGAG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedColorId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedColorId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x715A090", Offset = "0x7158A90", VA = "0x18715A090", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x715A130", Offset = "0x7158B30", VA = "0x18715A130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, BJPMGPHHKII, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x715A1A0", Offset = "0x7158BA0", VA = "0x18715A1A0")]
		public NPONJLDPMAN DGBBAPGEGII()
		{
			return default(NPONJLDPMAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x715A430", Offset = "0x7158E30", VA = "0x18715A430")]
		public SerializedCombinationId(NPONJLDPMAN LKKKMCBAECE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x715A2B0", Offset = "0x7158CB0", VA = "0x18715A2B0")]
		private void GGDKFEAJKGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8990", Offset = "0x6FE7390", VA = "0x186FE8990", Slot = "4")]
		public bool Equals(SerializedCombinationId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x715A200", Offset = "0x7158C00", VA = "0x18715A200", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedCombinationId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x715A3C0", Offset = "0x7158DC0", VA = "0x18715A3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x715A3B0", Offset = "0x7158DB0", VA = "0x18715A3B0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x715A500", Offset = "0x7158F00", VA = "0x18715A500")]
		public static SerializedEquipmentSkinId NELCMBJMBMI()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public CEJFBAGMAJN DGBBAPGEGII()
		{
			return default(CEJFBAGMAJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x715A460", Offset = "0x7158E60", VA = "0x18715A460", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x715A530", Offset = "0x7158F30", VA = "0x18715A530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public CIJBFEOBFPG DGBBAPGEGII()
		{
			return default(CIJBFEOBFPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x715A5A0", Offset = "0x7158FA0", VA = "0x18715A5A0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x715A640", Offset = "0x7159040", VA = "0x18715A640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public ALAHOFBJMPD DGBBAPGEGII()
		{
			return default(ALAHOFBJMPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x715A6B0", Offset = "0x71590B0", VA = "0x18715A6B0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x715A750", Offset = "0x7159150", VA = "0x18715A750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public AEIBCMBNBKO DGBBAPGEGII()
		{
			return default(AEIBCMBNBKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0", Slot = "4")]
		public bool Equals(SerializedHairPatternId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x715A7C0", Offset = "0x71591C0", VA = "0x18715A7C0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7159EF0", Offset = "0x71588F0", VA = "0x187159EF0")]
		public static bool KBKLEFBHIDJ(SerializedHairPatternId IIILBPDHGHN, SerializedHairPatternId CLEBPGFBBGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715A860", Offset = "0x7159260", VA = "0x18715A860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, BJPMGPHHKII
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
		public SerializedMaterialId(BHKKDKDFMNI DKFNFHGODON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50", Slot = "6")]
		public Guid LILEECPKJLL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
		public BHKKDKDFMNI DGBBAPGEGII()
		{
			return default(BHKKDKDFMNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8990", Offset = "0x6FE7390", VA = "0x186FE8990", Slot = "4")]
		public bool Equals(SerializedMaterialId OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x715A8D0", Offset = "0x71592D0", VA = "0x18715A8D0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA85540", Offset = "0xA83F40", VA = "0x180A85540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8990", Offset = "0x6FE7390", VA = "0x186FE8990")]
		public static bool KBKLEFBHIDJ(SerializedMaterialId IIILBPDHGHN, SerializedMaterialId CLEBPGFBBGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA852A0", Offset = "0xA83CA0", VA = "0x180A852A0", Slot = "5")]
		public int CompareTo(SerializedMaterialId OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x715A980", Offset = "0x7159380", VA = "0x18715A980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IBDCIIOENIF : CJIPKNKAEMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IBDCIIOENIF MJFJCBEEADM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7157110", Offset = "0x7155B10", VA = "0x187157110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CPGGOMBPPFO<GKBBJJAJIMK> FEIANBKAJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7157350", Offset = "0x7155D50", VA = "0x187157350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CPGGOMBPPFO<CEJFBAGMAJN> KIBMFKIJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7157170", Offset = "0x7155B70", VA = "0x187157170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CPGGOMBPPFO<AEIBCMBNBKO> INNPKHNGKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71573B0", Offset = "0x7155DB0", VA = "0x1871573B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CPGGOMBPPFO<NPONJLDPMAN> DKBACOBHIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71570B0", Offset = "0x7155AB0", VA = "0x1871570B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CPGGOMBPPFO<DCDLGKFIGAG> DCKOOCNEPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71571D0", Offset = "0x7155BD0", VA = "0x1871571D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CPGGOMBPPFO<ALAHOFBJMPD> LPJNPIIBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7157230", Offset = "0x7155C30", VA = "0x187157230", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CPGGOMBPPFO<DBPBPDCICIF> BEFGMFBLJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71572F0", Offset = "0x7155CF0", VA = "0x1871572F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CPGGOMBPPFO<CIJBFEOBFPG> ACCJDKKIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7157290", Offset = "0x7155C90", VA = "0x187157290", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FFJAKEJDPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7156AB0", Offset = "0x71554B0", VA = "0x187156AB0")]
	public static Guid EMOIJPPGAEF(string FELMDNOFLBK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71569E0", Offset = "0x71553E0", VA = "0x1871569E0")]
	public static bool DIKGOGJIPDL(string FELMDNOFLBK, [Out] Guid BMIGIGGJPJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CDBCFPNMJMO : AJICEKJOHKI<GKBBJJAJIMK>, LHKMKPLLJMO<GKBBJJAJIMK>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x71480A0", Offset = "0x7146AA0", VA = "0x1871480A0", Slot = "4")]
	public IEnumerable<(GKBBJJAJIMK, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x714CCF0", Offset = "0x714B6F0", VA = "0x18714CCF0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public GKBBJJAJIMK NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(GKBBJJAJIMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public CDBCFPNMJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LFFBMPFPMAD : AJICEKJOHKI<DBPBPDCICIF>, LHKMKPLLJMO<DBPBPDCICIF>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7159690", Offset = "0x7158090", VA = "0x187159690", Slot = "4")]
	public IEnumerable<(DBPBPDCICIF, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public DBPBPDCICIF NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(DBPBPDCICIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public LFFBMPFPMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CEBNHNKDJFL : AJICEKJOHKI<DCDLGKFIGAG>, LHKMKPLLJMO<DCDLGKFIGAG>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x714CD10", Offset = "0x714B710", VA = "0x18714CD10", Slot = "4")]
	public IEnumerable<(DCDLGKFIGAG, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public DCDLGKFIGAG NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(DCDLGKFIGAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public CEBNHNKDJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KKLAPPFJJOL : AJICEKJOHKI<NPONJLDPMAN>, LHKMKPLLJMO<NPONJLDPMAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LHKMKPLLJMO<BHKKDKDFMNI> KGCIAONPONA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	public KKLAPPFJJOL(LHKMKPLLJMO<BHKKDKDFMNI> KGCIAONPONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FE8DA0", Offset = "0x6FE77A0", VA = "0x186FE8DA0", Slot = "4")]
	public IEnumerable<(NPONJLDPMAN, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7159350", Offset = "0x7157D50", VA = "0x187159350", Slot = "6")]
	public NPONJLDPMAN NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(NPONJLDPMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7159650", Offset = "0x7158050", VA = "0x187159650", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CFNABPGMGGI : AJICEKJOHKI<CEJFBAGMAJN>, LHKMKPLLJMO<CEJFBAGMAJN>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x714EDD0", Offset = "0x714D7D0", VA = "0x18714EDD0", Slot = "4")]
	public IEnumerable<(CEJFBAGMAJN, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public CEJFBAGMAJN NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(CEJFBAGMAJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public CFNABPGMGGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KIIFDGNGNAI : AJICEKJOHKI<CIJBFEOBFPG>, LHKMKPLLJMO<CIJBFEOBFPG>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7157A90", Offset = "0x7156490", VA = "0x187157A90", Slot = "4")]
	public IEnumerable<(CIJBFEOBFPG, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public CIJBFEOBFPG NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(CIJBFEOBFPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KIIFDGNGNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MBFGGDLLJAF : AJICEKJOHKI<ALAHOFBJMPD>, LHKMKPLLJMO<ALAHOFBJMPD>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7159A30", Offset = "0x7158430", VA = "0x187159A30", Slot = "4")]
	public IEnumerable<(ALAHOFBJMPD, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public ALAHOFBJMPD NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(ALAHOFBJMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public MBFGGDLLJAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KEFAHLKCMLM : AJICEKJOHKI<AEIBCMBNBKO>, LHKMKPLLJMO<AEIBCMBNBKO>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7157410", Offset = "0x7155E10", VA = "0x187157410", Slot = "4")]
	public IEnumerable<(AEIBCMBNBKO, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public AEIBCMBNBKO NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(AEIBCMBNBKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public KEFAHLKCMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AJICEKJOHKI<TModern> : LHKMKPLLJMO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> NJDOAJDNBCD();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NOIOHENBCDJ(string KEHDGPEAKOM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LKNAGPOFFNG : AJICEKJOHKI<BHKKDKDFMNI>, LHKMKPLLJMO<BHKKDKDFMNI>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x709CF10", Offset = "0x709B910", VA = "0x18709CF10", Slot = "4")]
	public IEnumerable<(BHKKDKDFMNI, string)> NJDOAJDNBCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA871A0", Offset = "0xA85BA0", VA = "0x180A871A0", Slot = "5")]
	public string NOIOHENBCDJ(string KEHDGPEAKOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7147FE0", Offset = "0x71469E0", VA = "0x187147FE0", Slot = "6")]
	public BHKKDKDFMNI NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return default(BHKKDKDFMNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public LKNAGPOFFNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OBFFNPGAKKP<TModern> : CPGGOMBPPFO<TModern>, LHKMKPLLJMO<TModern> where TModern : IEquatable<TModern>, BJPMGPHHKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> AMOOCONKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> EPGENGEHNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly AJICEKJOHKI<TModern> LPEIEPCJNBD;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4609D70", Offset = "0x4608770", VA = "0x184609D70")]
	public OBFFNPGAKKP(AJICEKJOHKI<TModern> LPEIEPCJNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4607BD0", Offset = "0x46065D0", VA = "0x184607BD0", Slot = "5")]
	public TModern NFEMNANDEJN(string KEHDGPEAKOM)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4606BC0", Offset = "0x46055C0", VA = "0x184606BC0", Slot = "4")]
	public string AEAPHNGIIDE(TModern NGDBLKDLIGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FNNDBIFKDFO : CJIPKNKAEMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private OBFFNPGAKKP<GKBBJJAJIMK> CDCDELNBKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private OBFFNPGAKKP<CEJFBAGMAJN> DPDAFKGIPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private OBFFNPGAKKP<AEIBCMBNBKO> IPIFMKCDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OBFFNPGAKKP<BHKKDKDFMNI> KGCIAONPONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private OBFFNPGAKKP<NPONJLDPMAN> GGPGDMLBNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OBFFNPGAKKP<DCDLGKFIGAG> HKGOCBGGLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private OBFFNPGAKKP<ALAHOFBJMPD> DFCALFBFCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private OBFFNPGAKKP<DBPBPDCICIF> NBIKBCBADPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OBFFNPGAKKP<CIJBFEOBFPG> HKGNFHIDPGL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CPGGOMBPPFO<GKBBJJAJIMK> FEIANBKAJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CPGGOMBPPFO<CEJFBAGMAJN> KIBMFKIJINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CPGGOMBPPFO<AEIBCMBNBKO> INNPKHNGKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CPGGOMBPPFO<NPONJLDPMAN> DKBACOBHIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8555C0", VA = "0x180856BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CPGGOMBPPFO<DCDLGKFIGAG> DCKOOCNEPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855360", VA = "0x180856960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CPGGOMBPPFO<ALAHOFBJMPD> LPJNPIIBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8554B0", VA = "0x180856AB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CPGGOMBPPFO<DBPBPDCICIF> BEFGMFBLJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8553D0", VA = "0x1808569D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public CPGGOMBPPFO<CIJBFEOBFPG> ACCJDKKIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854D00", VA = "0x180856300", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7156B60", Offset = "0x7155560", VA = "0x187156B60")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.GameOnly)]
	[UsedImplicitly]
	private static void JNAGAGBOGMF(INCIOHANCNE LDLMDJOAIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7156BD0", Offset = "0x71555D0", VA = "0x187156BD0")]
	[Preserve]
	public FNNDBIFKDFO()
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
