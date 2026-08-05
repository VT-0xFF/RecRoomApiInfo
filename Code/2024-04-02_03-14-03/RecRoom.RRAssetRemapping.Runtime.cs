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
public class NPIPOLLFAIM : ECAKOJEBJHN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NHPOHLKCIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OAJACJJJIDI PNDNCHJNGEO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68F1F10", Offset = "0x68F0B10", VA = "0x1868F1F10")]
	[JDFNDIEGGDI(COFBNFOEGIB.GameOnly)]
	[UsedImplicitly]
	private static void ADHPCFGLOFB(OJEGDOKHPNO KFDFGHNENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68F1F80", Offset = "0x68F0B80", VA = "0x1868F1F80")]
	[UsedImplicitly]
	[JDFNDIEGGDI(COFBNFOEGIB.EditorOnly)]
	private static void AOIMGNLHAOG(OJEGDOKHPNO KFDFGHNENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	[Preserve]
	public NPIPOLLFAIM([NNEMKPMNJAE(null)] OAJACJJJIDI PNDNCHJNGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68F26A0", Offset = "0x68F12A0", VA = "0x1868F26A0", Slot = "4")]
	public string GAPNIKJAJOO(BNHOPJAHCPN KMJAEAGEOPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68F1FE0", Offset = "0x68F0BE0", VA = "0x1868F1FE0", Slot = "5")]
	public BNHOPJAHCPN DPCADENMEMJ(string KMJAEAGEOPB)
	{
		return default(BNHOPJAHCPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KAGNPBGBFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68F19A0", Offset = "0x68F05A0", VA = "0x1868F19A0")]
	public static OAJACJJJIDI IFONCAFKIAM()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public SerializedAvatarItemId(EGAIINJFLJA JPCJHDLLDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public EGAIINJFLJA DPCADENMEMJ()
		{
			return default(EGAIINJFLJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedAvatarItemId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68FC8D0", Offset = "0x68FB4D0", VA = "0x1868FC8D0", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68FC990", Offset = "0x68FB590", VA = "0x1868FC990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public OHPFBIJPHHC DPCADENMEMJ()
		{
			return default(OHPFBIJPHHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedBodyShapeId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68FCA00", Offset = "0x68FB600", VA = "0x1868FCA00", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68FCAA0", Offset = "0x68FB6A0", VA = "0x1868FCAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public GFLJBEKNMMH DPCADENMEMJ()
		{
			return default(GFLJBEKNMMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedColorId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedColorId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68FCB10", Offset = "0x68FB710", VA = "0x1868FCB10", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68FCBB0", Offset = "0x68FB7B0", VA = "0x1868FCBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NJHELBBHEDC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x68FCC20", Offset = "0x68FB820", VA = "0x1868FCC20")]
		public FHGFDPIGBOM DPCADENMEMJ()
		{
			return default(FHGFDPIGBOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68FCEB0", Offset = "0x68FBAB0", VA = "0x1868FCEB0")]
		public SerializedCombinationId(FHGFDPIGBOM GHBNECJOBDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68FCD30", Offset = "0x68FB930", VA = "0x1868FCD30")]
		private void LFNGHMCHAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x678A330", Offset = "0x6788F30", VA = "0x18678A330", Slot = "4")]
		public bool Equals(SerializedCombinationId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x68FCC80", Offset = "0x68FB880", VA = "0x1868FCC80", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedCombinationId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68FCE40", Offset = "0x68FBA40", VA = "0x1868FCE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68FCE30", Offset = "0x68FBA30", VA = "0x1868FCE30", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x68FCF80", Offset = "0x68FBB80", VA = "0x1868FCF80")]
		public static SerializedEquipmentSkinId PBJAAPNLOIM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public NIHGKONIHFA DPCADENMEMJ()
		{
			return default(NIHGKONIHFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68FCEE0", Offset = "0x68FBAE0", VA = "0x1868FCEE0", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68FCFB0", Offset = "0x68FBBB0", VA = "0x1868FCFB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public MLCCCBINKOI DPCADENMEMJ()
		{
			return default(MLCCCBINKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68FD020", Offset = "0x68FBC20", VA = "0x1868FD020", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68FD0C0", Offset = "0x68FBCC0", VA = "0x1868FD0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public JDNGMCAHIDI DPCADENMEMJ()
		{
			return default(JDNGMCAHIDI);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedFaceShapeId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68FD130", Offset = "0x68FBD30", VA = "0x1868FD130", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68FD1D0", Offset = "0x68FBDD0", VA = "0x1868FD1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public SerializedHairPatternId(MNCKBBFKGJI JPCJHDLLDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public MNCKBBFKGJI DPCADENMEMJ()
		{
			return default(MNCKBBFKGJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970", Slot = "4")]
		public bool Equals(SerializedHairPatternId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedHairPatternId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68FD240", Offset = "0x68FBE40", VA = "0x1868FD240", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68FC970", Offset = "0x68FB570", VA = "0x1868FC970")]
		public static bool FKDJFADGJBA(SerializedHairPatternId GDDMOGHGPAF, SerializedHairPatternId GHPICIIHMOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68FD2E0", Offset = "0x68FBEE0", VA = "0x1868FD2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NJHELBBHEDC
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
		[Cpp2IlInjected.Address(RVA = "0x1DF8020", Offset = "0x1DF6C20", VA = "0x181DF8020")]
		public SerializedMaterialId(OGPPMGCGAKH JPCJHDLLDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00", Slot = "6")]
		public Guid CLFIPINJLNF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87FA00", Offset = "0x87E600", VA = "0x18087FA00")]
		public OGPPMGCGAKH DPCADENMEMJ()
		{
			return default(OGPPMGCGAKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x678A330", Offset = "0x6788F30", VA = "0x18678A330", Slot = "4")]
		public bool Equals(SerializedMaterialId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68FD350", Offset = "0x68FBF50", VA = "0x1868FD350", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x916120", Offset = "0x914D20", VA = "0x180916120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x678A330", Offset = "0x6788F30", VA = "0x18678A330")]
		public static bool FKDJFADGJBA(SerializedMaterialId GDDMOGHGPAF, SerializedMaterialId GHPICIIHMOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x915F00", Offset = "0x914B00", VA = "0x180915F00", Slot = "5")]
		public int CompareTo(SerializedMaterialId NAFFCAIMPLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68FD3F0", Offset = "0x68FBFF0", VA = "0x1868FD3F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CDMKAMDLACK : OAJACJJJIDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CDMKAMDLACK EJGFFMEDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68E9F60", Offset = "0x68E8B60", VA = "0x1868E9F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HHKBIFBBMNF<EGAIINJFLJA> GFGHHKDMHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x68EA020", Offset = "0x68E8C20", VA = "0x1868EA020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HHKBIFBBMNF<NIHGKONIHFA> BGJDGAIMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68E9FC0", Offset = "0x68E8BC0", VA = "0x1868E9FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HHKBIFBBMNF<MNCKBBFKGJI> DGBPMAPPMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68E9E40", Offset = "0x68E8A40", VA = "0x1868E9E40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HHKBIFBBMNF<FHGFDPIGBOM> BAFHIAEIMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68E9D20", Offset = "0x68E8920", VA = "0x1868E9D20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HHKBIFBBMNF<GFLJBEKNMMH> MPGIEHHHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68E9EA0", Offset = "0x68E8AA0", VA = "0x1868E9EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HHKBIFBBMNF<JDNGMCAHIDI> AADAFEGEAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x68E9D80", Offset = "0x68E8980", VA = "0x1868E9D80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HHKBIFBBMNF<OHPFBIJPHHC> DAJFALLHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68E9F00", Offset = "0x68E8B00", VA = "0x1868E9F00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HHKBIFBBMNF<MLCCCBINKOI> MEBENGBJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68E9DE0", Offset = "0x68E89E0", VA = "0x1868E9DE0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LEOKMBOPCEK
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68F1D90", Offset = "0x68F0990", VA = "0x1868F1D90")]
	public static Guid LMJBHLBCAIG(string NFNPFDFMOHC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68F1E40", Offset = "0x68F0A40", VA = "0x1868F1E40")]
	public static bool MKKALJBFICN(string NFNPFDFMOHC, [Out] Guid AGEGEBLOPIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JEGLMKMONLE : NPGBPDCPNFG<EGAIINJFLJA>, JOKGCEJKNIH<EGAIINJFLJA>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68EC9F0", Offset = "0x68EB5F0", VA = "0x1868EC9F0", Slot = "4")]
	public IEnumerable<(EGAIINJFLJA, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68F1640", Offset = "0x68F0240", VA = "0x1868F1640", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public EGAIINJFLJA KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(EGAIINJFLJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JEGLMKMONLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LDHMAKHLBOM : NPGBPDCPNFG<OHPFBIJPHHC>, JOKGCEJKNIH<OHPFBIJPHHC>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x68F19F0", Offset = "0x68F05F0", VA = "0x1868F19F0", Slot = "4")]
	public IEnumerable<(OHPFBIJPHHC, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public OHPFBIJPHHC KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(OHPFBIJPHHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public LDHMAKHLBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OKKBADGDPDB : NPGBPDCPNFG<GFLJBEKNMMH>, JOKGCEJKNIH<GFLJBEKNMMH>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68FA810", Offset = "0x68F9410", VA = "0x1868FA810", Slot = "4")]
	public IEnumerable<(GFLJBEKNMMH, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public GFLJBEKNMMH KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(GFLJBEKNMMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OKKBADGDPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JLHOPCKOFHJ : NPGBPDCPNFG<FHGFDPIGBOM>, JOKGCEJKNIH<FHGFDPIGBOM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JOKGCEJKNIH<OGPPMGCGAKH> AIMENAFDIBF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public JLHOPCKOFHJ(JOKGCEJKNIH<OGPPMGCGAKH> AIMENAFDIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x678B7F0", Offset = "0x678A3F0", VA = "0x18678B7F0", Slot = "4")]
	public IEnumerable<(FHGFDPIGBOM, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68F1660", Offset = "0x68F0260", VA = "0x1868F1660", Slot = "6")]
	public FHGFDPIGBOM KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(FHGFDPIGBOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68F1960", Offset = "0x68F0560", VA = "0x1868F1960", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OCFPNNIJBNP : NPGBPDCPNFG<NIHGKONIHFA>, JOKGCEJKNIH<NIHGKONIHFA>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x68F2C00", Offset = "0x68F1800", VA = "0x1868F2C00", Slot = "4")]
	public IEnumerable<(NIHGKONIHFA, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public NIHGKONIHFA KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(NIHGKONIHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public OCFPNNIJBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class INILDAEHIOB : NPGBPDCPNFG<MLCCCBINKOI>, JOKGCEJKNIH<MLCCCBINKOI>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68EB130", Offset = "0x68E9D30", VA = "0x1868EB130", Slot = "4")]
	public IEnumerable<(MLCCCBINKOI, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public MLCCCBINKOI KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(MLCCCBINKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public INILDAEHIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IAMHAJEBBEE : NPGBPDCPNFG<JDNGMCAHIDI>, JOKGCEJKNIH<JDNGMCAHIDI>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68EAD10", Offset = "0x68E9910", VA = "0x1868EAD10", Slot = "4")]
	public IEnumerable<(JDNGMCAHIDI, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public JDNGMCAHIDI KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(JDNGMCAHIDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IAMHAJEBBEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CFPDIKBKJOC : NPGBPDCPNFG<MNCKBBFKGJI>, JOKGCEJKNIH<MNCKBBFKGJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68EA080", Offset = "0x68E8C80", VA = "0x1868EA080", Slot = "4")]
	public IEnumerable<(MNCKBBFKGJI, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public MNCKBBFKGJI KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(MNCKBBFKGJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public CFPDIKBKJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NPGBPDCPNFG<TModern> : JOKGCEJKNIH<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JHHJNEGMDPK();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string LDGILIKJFAI(string MBKLJGOBJAP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GNIBLAKFLMC : NPGBPDCPNFG<OGPPMGCGAKH>, JOKGCEJKNIH<OGPPMGCGAKH>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x683F960", Offset = "0x683E560", VA = "0x18683F960", Slot = "4")]
	public IEnumerable<(OGPPMGCGAKH, string)> JHHJNEGMDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x917140", Offset = "0x915D40", VA = "0x180917140", Slot = "5")]
	public string LDGILIKJFAI(string MBKLJGOBJAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x68EA700", Offset = "0x68E9300", VA = "0x1868EA700", Slot = "6")]
	public OGPPMGCGAKH KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return default(OGPPMGCGAKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GNIBLAKFLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EKILANJBPDA<TModern> : HHKBIFBBMNF<TModern>, JOKGCEJKNIH<TModern> where TModern : IEquatable<TModern>, NJHELBBHEDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> CIOMDEKPEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> FBBNJOIILAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly NPGBPDCPNFG<TModern> JGAEKCINFBE;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3343670", Offset = "0x3342270", VA = "0x183343670")]
	public EKILANJBPDA(NPGBPDCPNFG<TModern> JGAEKCINFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x33421F0", Offset = "0x3340DF0", VA = "0x1833421F0", Slot = "5")]
	public TModern KKNJOPGMNCG(string MBKLJGOBJAP)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33403D0", Offset = "0x333EFD0", VA = "0x1833403D0", Slot = "4")]
	public string JMBMJPOIHIL(TModern LADFEGGFAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ENNBFIOJNCK : OAJACJJJIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EKILANJBPDA<EGAIINJFLJA> FDFBOFCIEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EKILANJBPDA<NIHGKONIHFA> NFOEPIPOPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EKILANJBPDA<MNCKBBFKGJI> CCGPGPLIPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EKILANJBPDA<OGPPMGCGAKH> AIMENAFDIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EKILANJBPDA<FHGFDPIGBOM> CIJPBOLKGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EKILANJBPDA<GFLJBEKNMMH> EJHABHEMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EKILANJBPDA<JDNGMCAHIDI> GHIJPMOCNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EKILANJBPDA<OHPFBIJPHHC> CNGOKLMCIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EKILANJBPDA<MLCCCBINKOI> EDNBMFCKCDK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HHKBIFBBMNF<EGAIINJFLJA> GFGHHKDMHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HHKBIFBBMNF<NIHGKONIHFA> BGJDGAIMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HHKBIFBBMNF<MNCKBBFKGJI> DGBPMAPPMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HHKBIFBBMNF<FHGFDPIGBOM> BAFHIAEIMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public HHKBIFBBMNF<GFLJBEKNMMH> MPGIEHHHCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public HHKBIFBBMNF<JDNGMCAHIDI> AADAFEGEAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HHKBIFBBMNF<OHPFBIJPHHC> DAJFALLHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public HHKBIFBBMNF<MLCCCBINKOI> MEBENGBJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x68EA7C0", Offset = "0x68E93C0", VA = "0x1868EA7C0")]
	[JDFNDIEGGDI(EEILJHHLCPL.Root, COFBNFOEGIB.GameOnly)]
	[UsedImplicitly]
	private static void PACIOMMBOLO(OJEGDOKHPNO KFDFGHNENJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x68EA830", Offset = "0x68E9430", VA = "0x1868EA830")]
	[Preserve]
	public ENNBFIOJNCK()
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
