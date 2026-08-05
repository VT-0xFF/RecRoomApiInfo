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
public class NCPCFBIOCPG : CMJBMEAAACL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NDBKIGCBFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FMFOKPBOBIM BADGPGHFEHA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x695BF50", Offset = "0x695AF50", VA = "0x18695BF50")]
	[KEBGMDILACL(JMIJNHPDBML.GameOnly)]
	[UsedImplicitly]
	private static void LMNEJCNFFGB(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x695BEF0", Offset = "0x695AEF0", VA = "0x18695BEF0")]
	[UsedImplicitly]
	[KEBGMDILACL(JMIJNHPDBML.EditorOnly)]
	private static void GBAHAIKNPPN(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	[Preserve]
	public NCPCFBIOCPG([CJCLEPGLAOP(null)] FMFOKPBOBIM BADGPGHFEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x695C680", Offset = "0x695B680", VA = "0x18695C680", Slot = "4")]
	public string PAKOMNGHIKD(PNOBAHGGIKH IIBDJBFNFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x695BFC0", Offset = "0x695AFC0", VA = "0x18695BFC0", Slot = "5")]
	public PNOBAHGGIKH MPIEPNPHGIA(string IIBDJBFNFJM)
	{
		return default(PNOBAHGGIKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CHJKJIGCLHB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x694AA60", Offset = "0x6949A60", VA = "0x18694AA60")]
	public static FMFOKPBOBIM BMADOKPPBKN()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public SerializedAvatarItemId(BMCDNIEHLLL IJKMNFNHLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public BMCDNIEHLLL MPIEPNPHGIA()
		{
			return default(BMCDNIEHLLL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x695D610", Offset = "0x695C610", VA = "0x18695D610", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x695D6D0", Offset = "0x695C6D0", VA = "0x18695D6D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public POMGCDGENIC MPIEPNPHGIA()
		{
			return default(POMGCDGENIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x695D740", Offset = "0x695C740", VA = "0x18695D740", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x695D7E0", Offset = "0x695C7E0", VA = "0x18695D7E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public KOAKCMMIHOG MPIEPNPHGIA()
		{
			return default(KOAKCMMIHOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedColorId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedColorId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x695D850", Offset = "0x695C850", VA = "0x18695D850", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x695D8F0", Offset = "0x695C8F0", VA = "0x18695D8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, JCPNAKGPHKI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x695DB10", Offset = "0x695CB10", VA = "0x18695DB10")]
		public DFCKPJMGFPE MPIEPNPHGIA()
		{
			return default(DFCKPJMGFPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x695DBF0", Offset = "0x695CBF0", VA = "0x18695DBF0")]
		public SerializedCombinationId(DFCKPJMGFPE PAJMKFNJLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x695D960", Offset = "0x695C960", VA = "0x18695D960")]
		private void CLEHLEHJMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67EAFB0", Offset = "0x67E9FB0", VA = "0x1867EAFB0", Slot = "4")]
		public bool Equals(SerializedCombinationId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x695DA60", Offset = "0x695CA60", VA = "0x18695DA60", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedCombinationId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x695DB80", Offset = "0x695CB80", VA = "0x18695DB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x695DB70", Offset = "0x695CB70", VA = "0x18695DB70", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x695DC20", Offset = "0x695CC20", VA = "0x18695DC20")]
		public static SerializedEquipmentSkinId DFJDEFDLBGC()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public DOGDMMADMNK MPIEPNPHGIA()
		{
			return default(DOGDMMADMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x695DC50", Offset = "0x695CC50", VA = "0x18695DC50", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x695DCF0", Offset = "0x695CCF0", VA = "0x18695DCF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public NOGNCKDKHOJ MPIEPNPHGIA()
		{
			return default(NOGNCKDKHOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x695DD60", Offset = "0x695CD60", VA = "0x18695DD60", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x695DE00", Offset = "0x695CE00", VA = "0x18695DE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public NCOHCPHIJPB MPIEPNPHGIA()
		{
			return default(NCOHCPHIJPB);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x695DE70", Offset = "0x695CE70", VA = "0x18695DE70", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x695DF10", Offset = "0x695CF10", VA = "0x18695DF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public SerializedHairPatternId(EJBBCGEHEDF IJKMNFNHLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public EJBBCGEHEDF MPIEPNPHGIA()
		{
			return default(EJBBCGEHEDF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedHairPatternId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x695DF80", Offset = "0x695CF80", VA = "0x18695DF80", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x695D6B0", Offset = "0x695C6B0", VA = "0x18695D6B0")]
		public static bool INAKJEGDKIC(SerializedHairPatternId FKOPFOECIGH, SerializedHairPatternId DGKDEKELGHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x695E020", Offset = "0x695D020", VA = "0x18695E020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, JCPNAKGPHKI
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
		[Cpp2IlInjected.Address(RVA = "0x1DD7F00", Offset = "0x1DD6F00", VA = "0x181DD7F00")]
		public SerializedMaterialId(EONDHDFGBIA IJKMNFNHLGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00", Slot = "6")]
		public Guid KHCJKBBDNPJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x889F00", Offset = "0x888F00", VA = "0x180889F00")]
		public EONDHDFGBIA MPIEPNPHGIA()
		{
			return default(EONDHDFGBIA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67EAFB0", Offset = "0x67E9FB0", VA = "0x1867EAFB0", Slot = "4")]
		public bool Equals(SerializedMaterialId PJNBIAFGNNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x695E090", Offset = "0x695D090", VA = "0x18695E090", Slot = "0")]
		public override bool Equals(object FGOCJODIEMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x91B370", Offset = "0x91A370", VA = "0x18091B370", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67EAFB0", Offset = "0x67E9FB0", VA = "0x1867EAFB0")]
		public static bool INAKJEGDKIC(SerializedMaterialId FKOPFOECIGH, SerializedMaterialId DGKDEKELGHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x91B150", Offset = "0x91A150", VA = "0x18091B150", Slot = "5")]
		public int CompareTo(SerializedMaterialId PJNBIAFGNNN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x695E130", Offset = "0x695D130", VA = "0x18695E130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class POEPAFELOME : FMFOKPBOBIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static POEPAFELOME GDAKEGIGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x695D5B0", Offset = "0x695C5B0", VA = "0x18695D5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FBAJEBNGMGA<BMCDNIEHLLL> CAIBBPFLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x695D550", Offset = "0x695C550", VA = "0x18695D550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FBAJEBNGMGA<DOGDMMADMNK> NPNHMCGNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x695D310", Offset = "0x695C310", VA = "0x18695D310", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FBAJEBNGMGA<EJBBCGEHEDF> AEHPAFJOHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x695D430", Offset = "0x695C430", VA = "0x18695D430", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FBAJEBNGMGA<DFCKPJMGFPE> NKOKOBNELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x695D3D0", Offset = "0x695C3D0", VA = "0x18695D3D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FBAJEBNGMGA<KOAKCMMIHOG> ALOBMJBEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x695D4F0", Offset = "0x695C4F0", VA = "0x18695D4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FBAJEBNGMGA<NCOHCPHIJPB> CAKGGOLJMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x695D2B0", Offset = "0x695C2B0", VA = "0x18695D2B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FBAJEBNGMGA<POMGCDGENIC> NKLEHCKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x695D490", Offset = "0x695C490", VA = "0x18695D490", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FBAJEBNGMGA<NOGNCKDKHOJ> LDJKHKKPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x695D370", Offset = "0x695C370", VA = "0x18695D370", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ONJMDPHEJDB
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x695D130", Offset = "0x695C130", VA = "0x18695D130")]
	public static Guid FAPDFHCMPHJ(string HPAFFPGIHEB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x695D1E0", Offset = "0x695C1E0", VA = "0x18695D1E0")]
	public static bool FCIACCAINGG(string HPAFFPGIHEB, [Out] Guid IECJFMHCKJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HMPAGFOOKMJ : BAOBELIKGHP<BMCDNIEHLLL>, NBDCKCEFHBO<BMCDNIEHLLL>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6955340", Offset = "0x6954340", VA = "0x186955340", Slot = "4")]
	public IEnumerable<(BMCDNIEHLLL, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6959F90", Offset = "0x6958F90", VA = "0x186959F90", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public BMCDNIEHLLL HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(BMCDNIEHLLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HMPAGFOOKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDLEOJPDJLJ : BAOBELIKGHP<POMGCDGENIC>, NBDCKCEFHBO<POMGCDGENIC>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x694ADF0", Offset = "0x6949DF0", VA = "0x18694ADF0", Slot = "4")]
	public IEnumerable<(POMGCDGENIC, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public POMGCDGENIC HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(POMGCDGENIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public EDLEOJPDJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GCEICPELLOE : BAOBELIKGHP<KOAKCMMIHOG>, NBDCKCEFHBO<KOAKCMMIHOG>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6952E60", Offset = "0x6951E60", VA = "0x186952E60", Slot = "4")]
	public IEnumerable<(KOAKCMMIHOG, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public KOAKCMMIHOG HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(KOAKCMMIHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public GCEICPELLOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DKFDGPEJBBH : BAOBELIKGHP<DFCKPJMGFPE>, NBDCKCEFHBO<DFCKPJMGFPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly NBDCKCEFHBO<EONDHDFGBIA> NMNEFKBLHEP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
	public DKFDGPEJBBH(NBDCKCEFHBO<EONDHDFGBIA> NMNEFKBLHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67EC530", Offset = "0x67EB530", VA = "0x1867EC530", Slot = "4")]
	public IEnumerable<(DFCKPJMGFPE, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x694AAB0", Offset = "0x6949AB0", VA = "0x18694AAB0", Slot = "6")]
	public DFCKPJMGFPE HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(DFCKPJMGFPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x694ADB0", Offset = "0x6949DB0", VA = "0x18694ADB0", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FALIMIOFEID : BAOBELIKGHP<DOGDMMADMNK>, NBDCKCEFHBO<DOGDMMADMNK>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x694B250", Offset = "0x694A250", VA = "0x18694B250", Slot = "4")]
	public IEnumerable<(DOGDMMADMNK, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public DOGDMMADMNK HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(DOGDMMADMNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public FALIMIOFEID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MJOMHNPBCCF : BAOBELIKGHP<NOGNCKDKHOJ>, NBDCKCEFHBO<NOGNCKDKHOJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6959FB0", Offset = "0x6958FB0", VA = "0x186959FB0", Slot = "4")]
	public IEnumerable<(NOGNCKDKHOJ, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public NOGNCKDKHOJ HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(NOGNCKDKHOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public MJOMHNPBCCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HMLKHJEKKJP : BAOBELIKGHP<NCOHCPHIJPB>, NBDCKCEFHBO<NCOHCPHIJPB>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6954F20", Offset = "0x6953F20", VA = "0x186954F20", Slot = "4")]
	public IEnumerable<(NCOHCPHIJPB, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public NCOHCPHIJPB HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(NCOHCPHIJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public HMLKHJEKKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NBCEGCBCNBA : BAOBELIKGHP<EJBBCGEHEDF>, NBDCKCEFHBO<EJBBCGEHEDF>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x695B870", Offset = "0x695A870", VA = "0x18695B870", Slot = "4")]
	public IEnumerable<(EJBBCGEHEDF, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public EJBBCGEHEDF HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(EJBBCGEHEDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NBCEGCBCNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BAOBELIKGHP<TModern> : NBDCKCEFHBO<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> EDLADKGBKDN();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PMGKKECLKMI(string OIGONPCEMOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LMGBKIJGCPH : BAOBELIKGHP<EONDHDFGBIA>, NBDCKCEFHBO<EONDHDFGBIA>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x68A06A0", Offset = "0x689F6A0", VA = "0x1868A06A0", Slot = "4")]
	public IEnumerable<(EONDHDFGBIA, string)> EDLADKGBKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x91D200", Offset = "0x91C200", VA = "0x18091D200", Slot = "5")]
	public string PMGKKECLKMI(string OIGONPCEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x694B190", Offset = "0x694A190", VA = "0x18694B190", Slot = "6")]
	public EONDHDFGBIA HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return default(EONDHDFGBIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LMGBKIJGCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JPEOFIIJADD<TModern> : FBAJEBNGMGA<TModern>, NBDCKCEFHBO<TModern> where TModern : IEquatable<TModern>, JCPNAKGPHKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> MMLMGIMCBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> HIOFPFILKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly BAOBELIKGHP<TModern> EAOIIPMNDHB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B5F800", Offset = "0x3B5E800", VA = "0x183B5F800")]
	public JPEOFIIJADD(BAOBELIKGHP<TModern> EAOIIPMNDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D140", Offset = "0x3B5C140", VA = "0x183B5D140", Slot = "5")]
	public TModern HKAGMGPHPFE(string OIGONPCEMOJ)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E3C0", Offset = "0x3B5D3C0", VA = "0x183B5E3C0", Slot = "4")]
	public string NIPHGMGMLHO(TModern GCHOHDHNIAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OFILIINDCFM : FMFOKPBOBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JPEOFIIJADD<BMCDNIEHLLL> DLPGCOJMEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JPEOFIIJADD<DOGDMMADMNK> ODEHPPNNPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JPEOFIIJADD<EJBBCGEHEDF> PCECLMCBBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JPEOFIIJADD<EONDHDFGBIA> NMNEFKBLHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JPEOFIIJADD<DFCKPJMGFPE> OBCFBHDOCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JPEOFIIJADD<KOAKCMMIHOG> APKIKIKCDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JPEOFIIJADD<NCOHCPHIJPB> DKDIFIEELHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JPEOFIIJADD<POMGCDGENIC> JPPIIJMNHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JPEOFIIJADD<NOGNCKDKHOJ> AIGCKJKNMOF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FBAJEBNGMGA<BMCDNIEHLLL> CAIBBPFLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FBAJEBNGMGA<DOGDMMADMNK> NPNHMCGNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FBAJEBNGMGA<EJBBCGEHEDF> AEHPAFJOHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FBAJEBNGMGA<DFCKPJMGFPE> NKOKOBNELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FBAJEBNGMGA<KOAKCMMIHOG> ALOBMJBEIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FBAJEBNGMGA<NCOHCPHIJPB> CAKGGOLJMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FBAJEBNGMGA<POMGCDGENIC> NKLEHCKBFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FBAJEBNGMGA<NOGNCKDKHOJ> LDJKHKKPEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x695CBE0", Offset = "0x695BBE0", VA = "0x18695CBE0")]
	[KEBGMDILACL(LNECJMDANHH.Root, JMIJNHPDBML.GameOnly)]
	[UsedImplicitly]
	private static void GEBKLPBPLPI(ONGJLMJLNJA COPEDPCEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x695CC50", Offset = "0x695BC50", VA = "0x18695CC50")]
	[Preserve]
	public OFILIINDCFM()
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
