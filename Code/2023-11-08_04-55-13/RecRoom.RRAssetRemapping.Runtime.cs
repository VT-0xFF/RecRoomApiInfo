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
public class BPJGDBAMLJF : JECKJANCCKP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex BFPMPFMLHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly JIHNOEAIIKO OJJCLBEKPKD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x642EB80", Offset = "0x642D980", VA = "0x18642EB80")]
	[IBKPEPPEMNJ(MIBJABCBNEH.GameOnly)]
	private static void GLHDCMGJMLB(KIDCBAFLGEK NOFONEKOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x642EB20", Offset = "0x642D920", VA = "0x18642EB20")]
	[IBKPEPPEMNJ(MIBJABCBNEH.EditorOnly)]
	private static void ECKMOOKAPMA(KIDCBAFLGEK NOFONEKOMDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	[Preserve]
	public BPJGDBAMLJF([HOHGLGKGFHE(null)] JIHNOEAIIKO OJJCLBEKPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x642F340", Offset = "0x642E140", VA = "0x18642F340", Slot = "4")]
	public string OJBJHHLKILJ(CDEIEAKMFDI JHAPDKALKLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x642EC80", Offset = "0x642DA80", VA = "0x18642EC80", Slot = "5")]
	public CDEIEAKMFDI LKNPCKIALBL(string JHAPDKALKLI)
	{
		return default(CDEIEAKMFDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NCDNEIKHFAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6430790", Offset = "0x642F590", VA = "0x186430790")]
	public static JIHNOEAIIKO DKFPBEBOEJI()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public SerializedAvatarItemId(BHKPEIJJGHP JPODHBJFPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public BHKPEIJJGHP LKNPCKIALBL()
		{
			return default(BHKPEIJJGHP);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6431920", Offset = "0x6430720", VA = "0x186431920", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64319F0", Offset = "0x64307F0", VA = "0x1864319F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public OBACIPLEFHE LKNPCKIALBL()
		{
			return default(OBACIPLEFHE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6431A60", Offset = "0x6430860", VA = "0x186431A60", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6431B00", Offset = "0x6430900", VA = "0x186431B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public HFBKIOKHMLG LKNPCKIALBL()
		{
			return default(HFBKIOKHMLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedColorId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedColorId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6431B70", Offset = "0x6430970", VA = "0x186431B70", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6431C10", Offset = "0x6430A10", VA = "0x186431C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, EJOEFEOFBCD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6431E30", Offset = "0x6430C30", VA = "0x186431E30")]
		public LOMEGCIFLKN LKNPCKIALBL()
		{
			return default(LOMEGCIFLKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6431F10", Offset = "0x6430D10", VA = "0x186431F10")]
		public SerializedCombinationId(LOMEGCIFLKN LBDHFOKDJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6431D30", Offset = "0x6430B30", VA = "0x186431D30")]
		private void JEBCMJHIINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550", Slot = "4")]
		public bool Equals(SerializedCombinationId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6431C80", Offset = "0x6430A80", VA = "0x186431C80", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedCombinationId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6431EA0", Offset = "0x6430CA0", VA = "0x186431EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6431E90", Offset = "0x6430C90", VA = "0x186431E90", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x6431F40", Offset = "0x6430D40", VA = "0x186431F40")]
		public static SerializedEquipmentSkinId CMCMPJPKOII()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public NMECNMIAGHI LKNPCKIALBL()
		{
			return default(NMECNMIAGHI);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6431F70", Offset = "0x6430D70", VA = "0x186431F70", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6432010", Offset = "0x6430E10", VA = "0x186432010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public AEFJCPOEANN LKNPCKIALBL()
		{
			return default(AEFJCPOEANN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6432080", Offset = "0x6430E80", VA = "0x186432080", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6432120", Offset = "0x6430F20", VA = "0x186432120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public BPEOECGLCNP LKNPCKIALBL()
		{
			return default(BPEOECGLCNP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6432190", Offset = "0x6430F90", VA = "0x186432190", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6432230", Offset = "0x6431030", VA = "0x186432230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public SerializedHairPatternId(ANBEKNMHALN JPODHBJFPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public ANBEKNMHALN LKNPCKIALBL()
		{
			return default(ANBEKNMHALN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0", Slot = "4")]
		public bool Equals(SerializedHairPatternId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x64322A0", Offset = "0x64310A0", VA = "0x1864322A0", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64319C0", Offset = "0x64307C0", VA = "0x1864319C0")]
		public static bool HIHGGPGGFPN(SerializedHairPatternId CJNLLBDPPAC, SerializedHairPatternId CCDAOMDJCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6432340", Offset = "0x6431140", VA = "0x186432340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, EJOEFEOFBCD
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
		[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
		public SerializedMaterialId(GENMKAOMKKA JPODHBJFPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0", Slot = "6")]
		public Guid CKHMHKEBBPA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public GENMKAOMKKA LKNPCKIALBL()
		{
			return default(GENMKAOMKKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550", Slot = "4")]
		public bool Equals(SerializedMaterialId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x64323B0", Offset = "0x64311B0", VA = "0x1864323B0", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64319E0", Offset = "0x64307E0", VA = "0x1864319E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550")]
		public static bool HIHGGPGGFPN(SerializedMaterialId CJNLLBDPPAC, SerializedMaterialId CCDAOMDJCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializedMaterialId LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6432450", Offset = "0x6431250", VA = "0x186432450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GGGFJJMDPAD : JIHNOEAIIKO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GGGFJJMDPAD ANGIAPALHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64303F0", Offset = "0x642F1F0", VA = "0x1864303F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public EJEGLLLDIGN<BHKPEIJJGHP> OJJCIKNCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6430450", Offset = "0x642F250", VA = "0x186430450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EJEGLLLDIGN<NMECNMIAGHI> CAAGFMPALHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64305D0", Offset = "0x642F3D0", VA = "0x1864305D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EJEGLLLDIGN<ANBEKNMHALN> HGOGEPNMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64306F0", Offset = "0x642F4F0", VA = "0x1864306F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EJEGLLLDIGN<LOMEGCIFLKN> IDNFKIMFOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6430570", Offset = "0x642F370", VA = "0x186430570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EJEGLLLDIGN<HFBKIOKHMLG> PAOFLPMMBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6430510", Offset = "0x642F310", VA = "0x186430510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EJEGLLLDIGN<BPEOECGLCNP> BILPFMFBPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6430690", Offset = "0x642F490", VA = "0x186430690", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EJEGLLLDIGN<OBACIPLEFHE> GJJHJDOHPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64304B0", Offset = "0x642F2B0", VA = "0x1864304B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EJEGLLLDIGN<AEFJCPOEANN> PKPICNBMADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6430630", Offset = "0x642F430", VA = "0x186430630", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x642EA30", Offset = "0x642D830", VA = "0x18642EA30")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class GGBCPNHDFNP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64303B0", Offset = "0x642F1B0", VA = "0x1864303B0")]
	public static string LLGCBJGNEFD(this Guid CHLMGBPAGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64303C0", Offset = "0x642F1C0", VA = "0x1864303C0")]
	public static Guid LMHDGHINGID(string LHHJFEKPGCF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EKIGBAPHGFF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> EGFACIBCNDO(IEnumerable<(string modernStr, string legacyStr)> LCDBEPBOBNM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class OKAJDLCIONP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NCPOFHKKBHI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9C95C0", Offset = "0x9C83C0", VA = "0x1809C95C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6430B90", Offset = "0x642F990", VA = "0x186430B90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA460", Offset = "0x1BB9260", VA = "0x181BBA460")]
		[DebuggerHidden]
		public NCPOFHKKBHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6430BE0", Offset = "0x642F9E0", VA = "0x186430BE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6430830", Offset = "0x642F630", VA = "0x186430830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64307E0", Offset = "0x642F5E0", VA = "0x1864307E0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6430B40", Offset = "0x642F940", VA = "0x186430B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6430A90", Offset = "0x642F890", VA = "0x186430A90", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6430A90", Offset = "0x642F890", VA = "0x186430A90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2633730", Offset = "0x2632530", VA = "0x182633730")]
	internal static IEnumerable<(TModern, string)> KIKHHJIJDCP<TModern>(string FFGFENKNAGE, EKIGBAPHGFF<TModern> DHEALIMFJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6430CF0", Offset = "0x642FAF0", VA = "0x186430CF0")]
	[IteratorStateMachine(typeof(NCPOFHKKBHI))]
	private static IEnumerable<(string, string)> JECHBKOIKCH(AssetIdMappingJsonData HEEBNFOJBHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EDABHECODJO
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x642F9F0", Offset = "0x642E7F0", VA = "0x18642F9F0")]
	public static Guid OLOANJDNDAJ(string DBEBCGICEMA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x642F920", Offset = "0x642E720", VA = "0x18642F920")]
	public static bool BILFALBLJJI(string DBEBCGICEMA, [Out] Guid CHLMGBPAGHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NOAKIMIMFBH<TModern> : NDDCHCHNGLG<TModern>, EKIGBAPHGFF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HEOKHJFMJNH : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public NOAKIMIMFBH<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDC2600", Offset = "0xDC1400", VA = "0x180DC2600", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34BC970", Offset = "0x34BB770", VA = "0x1834BC970", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDB2350", Offset = "0xDB1150", VA = "0x180DB2350")]
		[DebuggerHidden]
		public HEOKHJFMJNH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x30FEF00", Offset = "0x30FDD00", VA = "0x1830FEF00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3637CB0", Offset = "0x3636AB0", VA = "0x183637CB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3636A00", Offset = "0x3635800", VA = "0x183636A00")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x36387C0", Offset = "0x36375C0", VA = "0x1836387C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3638580", Offset = "0x3637380", VA = "0x183638580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x350ACE0", Offset = "0x3509AE0", VA = "0x18350ACE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern EJKFANNEMME(Guid CHLMGBPAGHG);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EAB0", Offset = "0x3D2D8B0", VA = "0x183D2EAB0", Slot = "4")]
	public TModern KLFABLMEIJH(string PCKLOACIILI)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EA00", Offset = "0x3D2D800", VA = "0x183D2EA00", Slot = "5")]
	[IteratorStateMachine(typeof(NOAKIMIMFBH<>.HEOKHJFMJNH))]
	public IEnumerable<(TModern, string)> EGFACIBCNDO(IEnumerable<(string modernStr, string legacyStr)> CJPKPEIPJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected NOAKIMIMFBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class APFKMJIJENG : NOAKIMIMFBH<BHKPEIJJGHP>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override BHKPEIJJGHP EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(BHKPEIJJGHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x642E9D0", Offset = "0x642D7D0", VA = "0x18642E9D0")]
	internal static string LIDPFKKGJPP(string PCKLOACIILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x642E9F0", Offset = "0x642D7F0", VA = "0x18642E9F0")]
	public APFKMJIJENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NHHAJJGBJFN : NOAKIMIMFBH<OBACIPLEFHE>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override OBACIPLEFHE EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(OBACIPLEFHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6430C70", Offset = "0x642FA70", VA = "0x186430C70")]
	public NHHAJJGBJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OCCHLGHEGIN : NOAKIMIMFBH<HFBKIOKHMLG>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override HFBKIOKHMLG EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(HFBKIOKHMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6430CB0", Offset = "0x642FAB0", VA = "0x186430CB0")]
	public OCCHLGHEGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PNGKBMPMGPI : NDDCHCHNGLG<LOMEGCIFLKN>, EKIGBAPHGFF<LOMEGCIFLKN>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FLMGFJHMOLI : IEnumerable<(LOMEGCIFLKN, string)>, IEnumerable, IEnumerator<(LOMEGCIFLKN, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (LOMEGCIFLKN, string) <>2__current;

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
		public PNGKBMPMGPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (LOMEGCIFLKN, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3165450", Offset = "0x3164250", VA = "0x183165450", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((LOMEGCIFLKN, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x64302D0", Offset = "0x642F0D0", VA = "0x1864302D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6430380", Offset = "0x642F180", VA = "0x186430380")]
		[DebuggerHidden]
		public FLMGFJHMOLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6430340", Offset = "0x642F140", VA = "0x186430340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x642FB60", Offset = "0x642E960", VA = "0x18642FB60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x642FAA0", Offset = "0x642E8A0", VA = "0x18642FAA0")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6430280", Offset = "0x642F080", VA = "0x186430280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64301C0", Offset = "0x642EFC0", VA = "0x1864301C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(LOMEGCIFLKN, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64301C0", Offset = "0x642EFC0", VA = "0x1864301C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly NDDCHCHNGLG<GENMKAOMKKA> DPDBMMFHKLN;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76FDF0", VA = "0x180770FF0")]
	public PNGKBMPMGPI(NDDCHCHNGLG<GENMKAOMKKA> DPDBMMFHKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6430E50", Offset = "0x642FC50", VA = "0x186430E50", Slot = "4")]
	public LOMEGCIFLKN KLFABLMEIJH(string PCKLOACIILI)
	{
		return default(LOMEGCIFLKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6430DB0", Offset = "0x642FBB0", VA = "0x186430DB0", Slot = "5")]
	[IteratorStateMachine(typeof(FLMGFJHMOLI))]
	public IEnumerable<(LOMEGCIFLKN, string)> EGFACIBCNDO(IEnumerable<(string modernStr, string legacyStr)> LCDBEPBOBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6431150", Offset = "0x642FF50", VA = "0x186431150")]
	internal static string LIDPFKKGJPP(string PCKLOACIILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BFKEKHCIJGC : NOAKIMIMFBH<NMECNMIAGHI>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override NMECNMIAGHI EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(NMECNMIAGHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x642EAE0", Offset = "0x642D8E0", VA = "0x18642EAE0")]
	public BFKEKHCIJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EAFDGAPANEL : NOAKIMIMFBH<AEFJCPOEANN>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override AEFJCPOEANN EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(AEFJCPOEANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x642F8E0", Offset = "0x642E6E0", VA = "0x18642F8E0")]
	public EAFDGAPANEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OKHCKGABGBM : NOAKIMIMFBH<BPEOECGLCNP>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override BPEOECGLCNP EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(BPEOECGLCNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6430D70", Offset = "0x642FB70", VA = "0x186430D70")]
	public OKHCKGABGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IJNONPCAHEH : NOAKIMIMFBH<ANBEKNMHALN>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override ANBEKNMHALN EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(ANBEKNMHALN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6430750", Offset = "0x642F550", VA = "0x186430750")]
	public IJNONPCAHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CNCNANBDACI : NOAKIMIMFBH<GENMKAOMKKA>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "6")]
	protected override GENMKAOMKKA EJKFANNEMME(Guid CHLMGBPAGHG)
	{
		return default(GENMKAOMKKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x642F8A0", Offset = "0x642E6A0", VA = "0x18642F8A0")]
	public CNCNANBDACI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LFHPEAJIIDB<TModern> : EJEGLLLDIGN<TModern>, NDDCHCHNGLG<TModern> where TModern : IEquatable<TModern>, EJOEFEOFBCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> PIJNKCJJNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> EGPEBKJGDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> FLKFMNHJNFI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2A20", Offset = "0x3AB1820", VA = "0x183AB2A20")]
	public LFHPEAJIIDB(TextAsset DPGFDCJKPOP, EKIGBAPHGFF<TModern> DHEALIMFJJP, [CanBeNull] Func<string, string> FLKFMNHJNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCA0", Offset = "0x3AAEAA0", VA = "0x183AAFCA0", Slot = "5")]
	public TModern KLFABLMEIJH(string PCKLOACIILI)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEA90", Offset = "0x3AAD890", VA = "0x183AAEA90", Slot = "4")]
	public string EMDMJNOCIML(TModern NHBLJGDMGIA)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, JIHNOEAIIKO
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
		private LFHPEAJIIDB<BHKPEIJJGHP> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LFHPEAJIIDB<NMECNMIAGHI> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private LFHPEAJIIDB<ANBEKNMHALN> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private LFHPEAJIIDB<GENMKAOMKKA> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private LFHPEAJIIDB<LOMEGCIFLKN> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private LFHPEAJIIDB<HFBKIOKHMLG> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private LFHPEAJIIDB<BPEOECGLCNP> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private LFHPEAJIIDB<OBACIPLEFHE> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private LFHPEAJIIDB<AEFJCPOEANN> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EJEGLLLDIGN<BHKPEIJJGHP> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x76FF20", Offset = "0x76ED20", VA = "0x18076FF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EJEGLLLDIGN<NMECNMIAGHI> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x773C10", Offset = "0x772A10", VA = "0x180773C10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EJEGLLLDIGN<ANBEKNMHALN> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x773BF0", Offset = "0x7729F0", VA = "0x180773BF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public EJEGLLLDIGN<GENMKAOMKKA> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x774640", Offset = "0x773440", VA = "0x180774640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public EJEGLLLDIGN<LOMEGCIFLKN> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x774630", Offset = "0x773430", VA = "0x180774630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public EJEGLLLDIGN<HFBKIOKHMLG> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x774570", Offset = "0x773370", VA = "0x180774570", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EJEGLLLDIGN<BPEOECGLCNP> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x879790", Offset = "0x878590", VA = "0x180879790", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EJEGLLLDIGN<OBACIPLEFHE> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773300", VA = "0x180774500", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EJEGLLLDIGN<AEFJCPOEANN> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7F7440", Offset = "0x7F6240", VA = "0x1807F7440", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6431190", Offset = "0x642FF90", VA = "0x186431190")]
		[IBKPEPPEMNJ(INBBGMADPCI.Root, MIBJABCBNEH.GameOnly)]
		private static void BJNGLCECMKE(KIDCBAFLGEK NOFONEKOMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6431210", Offset = "0x6430010", VA = "0x186431210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x800FF0", Offset = "0x7FFDF0", VA = "0x180800FF0")]
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
