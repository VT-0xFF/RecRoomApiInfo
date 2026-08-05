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
public class JLEAJGNADPM : EFEDEMEGOBL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex FAKJDALONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FFPMEIHPAKG MBFAEFOPMGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6281440", Offset = "0x6280240", VA = "0x186281440")]
	[DJDJPHIPNFL(IEJLPKKICHC.GameOnly)]
	private static void LKBEDIJGOEL(NNIGDKDCOBN AMGLAFJJOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6280F20", Offset = "0x627FD20", VA = "0x186280F20")]
	[DJDJPHIPNFL(IEJLPKKICHC.EditorOnly)]
	private static void IHNMICALDJM(NNIGDKDCOBN AMGLAFJJOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	[Preserve]
	public JLEAJGNADPM([FGPOJKOJBFM(null)] FFPMEIHPAKG MBFAEFOPMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6280F80", Offset = "0x627FD80", VA = "0x186280F80", Slot = "4")]
	public string LJOKGFFEJKK(EJALALGJNMI KHNEEJJPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6281540", Offset = "0x6280340", VA = "0x186281540", Slot = "5")]
	public EJALALGJNMI NLOFGFEMKNI(string KHNEEJJPNNH)
	{
		return default(EJALALGJNMI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CCJJOOBHDDK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6280520", Offset = "0x627F320", VA = "0x186280520")]
	public static FFPMEIHPAKG DOGLANNAGGI()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public SerializedAvatarItemId(HIDHCENBIKG KKIIDNMAMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public HIDHCENBIKG NLOFGFEMKNI()
		{
			return default(HIDHCENBIKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedAvatarItemId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62833C0", Offset = "0x62821C0", VA = "0x1862833C0", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6282290", VA = "0x186283490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public DLCBBFAKOIG NLOFGFEMKNI()
		{
			return default(DLCBBFAKOIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedBodyShapeId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6283500", Offset = "0x6282300", VA = "0x186283500", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62835A0", Offset = "0x62823A0", VA = "0x1862835A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public GPBAPFLPPLK NLOFGFEMKNI()
		{
			return default(GPBAPFLPPLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedColorId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedColorId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6283610", Offset = "0x6282410", VA = "0x186283610", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62836B0", Offset = "0x62824B0", VA = "0x1862836B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, MBPBKCBPNCF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x62838D0", Offset = "0x62826D0", VA = "0x1862838D0")]
		public MIIMNMCJACG NLOFGFEMKNI()
		{
			return default(MIIMNMCJACG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62839B0", Offset = "0x62827B0", VA = "0x1862839B0")]
		public SerializedCombinationId(MIIMNMCJACG LGHPFEJDHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62837D0", Offset = "0x62825D0", VA = "0x1862837D0")]
		private void NEOEHNDALAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D39900", Offset = "0x5D38700", VA = "0x185D39900", Slot = "4")]
		public bool Equals(SerializedCombinationId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6283720", Offset = "0x6282520", VA = "0x186283720", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedCombinationId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6283940", Offset = "0x6282740", VA = "0x186283940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6283930", Offset = "0x6282730", VA = "0x186283930", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0x6283A80", Offset = "0x6282880", VA = "0x186283A80")]
		public static SerializedEquipmentSkinId JMBOLCJAEIE()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public BOLEMINDPIJ NLOFGFEMKNI()
		{
			return default(BOLEMINDPIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62839E0", Offset = "0x62827E0", VA = "0x1862839E0", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6283AB0", Offset = "0x62828B0", VA = "0x186283AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public IGJNIAODAPD NLOFGFEMKNI()
		{
			return default(IGJNIAODAPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6283B20", Offset = "0x6282920", VA = "0x186283B20", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6283BC0", Offset = "0x62829C0", VA = "0x186283BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public MFMNMCECOHP NLOFGFEMKNI()
		{
			return default(MFMNMCECOHP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedFaceShapeId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6283C30", Offset = "0x6282A30", VA = "0x186283C30", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6283CD0", Offset = "0x6282AD0", VA = "0x186283CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public SerializedHairPatternId(INHNMLHBLPF KKIIDNMAMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public INHNMLHBLPF NLOFGFEMKNI()
		{
			return default(INHNMLHBLPF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460", Slot = "4")]
		public bool Equals(SerializedHairPatternId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6283D40", Offset = "0x6282B40", VA = "0x186283D40", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6283460", Offset = "0x6282260", VA = "0x186283460")]
		public static bool PNFEPLLEJJK(SerializedHairPatternId NLBDNIEIKMB, SerializedHairPatternId NFFCMKPCJPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6283DE0", Offset = "0x6282BE0", VA = "0x186283DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, MBPBKCBPNCF
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
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public SerializedMaterialId(IDMGPCABMLI KKIIDNMAMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0", Slot = "6")]
		public Guid FFALGHOMING()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public IDMGPCABMLI NLOFGFEMKNI()
		{
			return default(IDMGPCABMLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D39900", Offset = "0x5D38700", VA = "0x185D39900", Slot = "4")]
		public bool Equals(SerializedMaterialId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6283E50", Offset = "0x6282C50", VA = "0x186283E50", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6283480", Offset = "0x6282280", VA = "0x186283480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D39900", Offset = "0x5D38700", VA = "0x185D39900")]
		public static bool PNFEPLLEJJK(SerializedMaterialId NLBDNIEIKMB, SerializedMaterialId NFFCMKPCJPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializedMaterialId LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6283EF0", Offset = "0x6282CF0", VA = "0x186283EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CLBPCLPLNHH : FFPMEIHPAKG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CLBPCLPLNHH IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6280A40", Offset = "0x627F840", VA = "0x186280A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JMEDKDICIGA<HIDHCENBIKG> OEJNLPLDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6280AA0", Offset = "0x627F8A0", VA = "0x186280AA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JMEDKDICIGA<BOLEMINDPIJ> BLOPDHPDIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6280C20", Offset = "0x627FA20", VA = "0x186280C20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JMEDKDICIGA<INHNMLHBLPF> NAKBOIMFGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6280D40", Offset = "0x627FB40", VA = "0x186280D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMEDKDICIGA<MIIMNMCJACG> DBOPANCGEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6280BC0", Offset = "0x627F9C0", VA = "0x186280BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JMEDKDICIGA<GPBAPFLPPLK> CODPEADCNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6280B60", Offset = "0x627F960", VA = "0x186280B60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JMEDKDICIGA<MFMNMCECOHP> PKOPECKMMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6280CE0", Offset = "0x627FAE0", VA = "0x186280CE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMEDKDICIGA<DLCBBFAKOIG> PHOBFGPEOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6280B00", Offset = "0x627F900", VA = "0x186280B00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JMEDKDICIGA<IGJNIAODAPD> ADJJAMBDANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6280C80", Offset = "0x627FA80", VA = "0x186280C80", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6280470", Offset = "0x627F270", VA = "0x186280470")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class JEJBDDPMBNK
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6280EA0", Offset = "0x627FCA0", VA = "0x186280EA0")]
	public static string DEPDMOIJKIF(this Guid EIODILKIKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6280EB0", Offset = "0x627FCB0", VA = "0x186280EB0")]
	public static Guid FNOGLPJAIFH(string NBBEBKKHBOK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BBDMIGGOKDF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DJJBNIOKNJA(IEnumerable<(string modernStr, string legacyStr)> MGEOIFFDBLF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class EMDKFBLIFKB
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CGAMPIDFIHN : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6280960", Offset = "0x627F760", VA = "0x186280960", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1B673D0", Offset = "0x1B661D0", VA = "0x181B673D0")]
		[DebuggerHidden]
		public CGAMPIDFIHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62809B0", Offset = "0x627F7B0", VA = "0x1862809B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6280600", Offset = "0x627F400", VA = "0x186280600", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62805B0", Offset = "0x627F3B0", VA = "0x1862805B0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6280910", Offset = "0x627F710", VA = "0x186280910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6280860", Offset = "0x627F660", VA = "0x186280860", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6280860", Offset = "0x627F660", VA = "0x186280860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x224CAF0", Offset = "0x224B8F0", VA = "0x18224CAF0")]
	internal static IEnumerable<(TModern, string)> BAFAPCMDNFI<TModern>(string MPCPAIBAGMB, BBDMIGGOKDF<TModern> ILIHICPMIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6280DA0", Offset = "0x627FBA0", VA = "0x186280DA0")]
	[IteratorStateMachine(typeof(CGAMPIDFIHN))]
	private static IEnumerable<(string, string)> BAPLGENJNBK(AssetIdMappingJsonData BPLBBNFBPPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OEDLOKKBHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6282160", Offset = "0x6280F60", VA = "0x186282160")]
	public static Guid GMLIDBAAHFG(string LDPJPDPMNDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6282210", Offset = "0x6281010", VA = "0x186282210")]
	public static bool GPDCIFMKDGE(string LDPJPDPMNDM, [Out] Guid EIODILKIKCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PJHDEKBJKHD<TModern> : FPAPHKPENMP<TModern>, BBDMIGGOKDF<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class ENOHLMJOEKM : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public PJHDEKBJKHD<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD77A50", Offset = "0xD76850", VA = "0x180D77A50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x30539C0", Offset = "0x30527C0", VA = "0x1830539C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD6EA10", Offset = "0xD6D810", VA = "0x180D6EA10")]
		[DebuggerHidden]
		public ENOHLMJOEKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3053A50", Offset = "0x3052850", VA = "0x183053A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3051DD0", Offset = "0x3050BD0", VA = "0x183051DD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x30519F0", Offset = "0x30507F0", VA = "0x1830519F0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3053830", Offset = "0x3052630", VA = "0x183053830", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3053520", Offset = "0x3052320", VA = "0x183053520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x30536C0", Offset = "0x30524C0", VA = "0x1830536C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern EDFGPDLMHPI(Guid EIODILKIKCN);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8720", Offset = "0x3DC7520", VA = "0x183DC8720", Slot = "4")]
	public TModern DNMBENHGPDL(string AFHAOADGHLN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC85C0", Offset = "0x3DC73C0", VA = "0x183DC85C0", Slot = "5")]
	[IteratorStateMachine(typeof(PJHDEKBJKHD<>.ENOHLMJOEKM))]
	public IEnumerable<(TModern, string)> DJJBNIOKNJA(IEnumerable<(string modernStr, string legacyStr)> NBDEAIPNEKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected PJHDEKBJKHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KADIPELNADH : PJHDEKBJKHD<HIDHCENBIKG>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override HIDHCENBIKG EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(HIDHCENBIKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6282080", Offset = "0x6280E80", VA = "0x186282080")]
	internal static string IKNBIBOCGHO(string AFHAOADGHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62820A0", Offset = "0x6280EA0", VA = "0x1862820A0")]
	public KADIPELNADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IMEBGBOPCJJ : PJHDEKBJKHD<DLCBBFAKOIG>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override DLCBBFAKOIG EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(DLCBBFAKOIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6280E60", Offset = "0x627FC60", VA = "0x186280E60")]
	public IMEBGBOPCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NBEJFFEFPKJ : PJHDEKBJKHD<GPBAPFLPPLK>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override GPBAPFLPPLK EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(GPBAPFLPPLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6282120", Offset = "0x6280F20", VA = "0x186282120")]
	public NBEJFFEFPKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JNKDGKIPPJA : FPAPHKPENMP<MIIMNMCJACG>, BBDMIGGOKDF<MIIMNMCJACG>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class OMCFJDKJNGN : IEnumerable<(MIIMNMCJACG, string)>, IEnumerable, IEnumerator<(MIIMNMCJACG, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (MIIMNMCJACG, string) <>2__current;

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
		public JNKDGKIPPJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (MIIMNMCJACG, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x30B85B0", Offset = "0x30B73B0", VA = "0x1830B85B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((MIIMNMCJACG, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6282B10", Offset = "0x6281910", VA = "0x186282B10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6282BC0", Offset = "0x62819C0", VA = "0x186282BC0")]
		[DebuggerHidden]
		public OMCFJDKJNGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6282B80", Offset = "0x6281980", VA = "0x186282B80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62823A0", Offset = "0x62811A0", VA = "0x1862823A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62822E0", Offset = "0x62810E0", VA = "0x1862822E0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6282AC0", Offset = "0x62818C0", VA = "0x186282AC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6282A00", Offset = "0x6281800", VA = "0x186282A00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(MIIMNMCJACG, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6282A00", Offset = "0x6281800", VA = "0x186282A00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FPAPHKPENMP<IDMGPCABMLI> CHMIGIIKGCG;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public JNKDGKIPPJA(FPAPHKPENMP<IDMGPCABMLI> CHMIGIIKGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6281D40", Offset = "0x6280B40", VA = "0x186281D40", Slot = "4")]
	public MIIMNMCJACG DNMBENHGPDL(string AFHAOADGHLN)
	{
		return default(MIIMNMCJACG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6281CA0", Offset = "0x6280AA0", VA = "0x186281CA0", Slot = "5")]
	[IteratorStateMachine(typeof(OMCFJDKJNGN))]
	public IEnumerable<(MIIMNMCJACG, string)> DJJBNIOKNJA(IEnumerable<(string modernStr, string legacyStr)> MGEOIFFDBLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6282040", Offset = "0x6280E40", VA = "0x186282040")]
	internal static string IKNBIBOCGHO(string AFHAOADGHLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JJLNDHHJBIA : PJHDEKBJKHD<BOLEMINDPIJ>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override BOLEMINDPIJ EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(BOLEMINDPIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6280EE0", Offset = "0x627FCE0", VA = "0x186280EE0")]
	public JJLNDHHJBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MNGGCAMHPHO : PJHDEKBJKHD<IGJNIAODAPD>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override IGJNIAODAPD EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(IGJNIAODAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62820E0", Offset = "0x6280EE0", VA = "0x1862820E0")]
	public MNGGCAMHPHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CDADCCINIMF : PJHDEKBJKHD<MFMNMCECOHP>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override MFMNMCECOHP EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(MFMNMCECOHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6280570", Offset = "0x627F370", VA = "0x186280570")]
	public CDADCCINIMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OMEEAGHKCMN : PJHDEKBJKHD<INHNMLHBLPF>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override INHNMLHBLPF EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(INHNMLHBLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6282BF0", Offset = "0x62819F0", VA = "0x186282BF0")]
	public OMEEAGHKCMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IFEPMEIPBIP : PJHDEKBJKHD<IDMGPCABMLI>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "6")]
	protected override IDMGPCABMLI EDFGPDLMHPI(Guid EIODILKIKCN)
	{
		return default(IDMGPCABMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6280E20", Offset = "0x627FC20", VA = "0x186280E20")]
	public IFEPMEIPBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FBCCGKHAAIK<TModern> : JMEDKDICIGA<TModern>, FPAPHKPENMP<TModern> where TModern : IEquatable<TModern>, MBPBKCBPNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> CFCJOGHEOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> PLJPMIMDDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> FOJHMOKLOJI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3385530", Offset = "0x3384330", VA = "0x183385530")]
	public FBCCGKHAAIK(TextAsset BEHNCKFFLMP, BBDMIGGOKDF<TModern> ILIHICPMIHE, [CanBeNull] Func<string, string> FOJHMOKLOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x33836A0", Offset = "0x33824A0", VA = "0x1833836A0", Slot = "5")]
	public TModern DNMBENHGPDL(string AFHAOADGHLN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3384BD0", Offset = "0x33839D0", VA = "0x183384BD0", Slot = "4")]
	public string EEIAJEPCKGL(TModern MIJAIFBCCJO)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, FFPMEIHPAKG
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
		private FBCCGKHAAIK<HIDHCENBIKG> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private FBCCGKHAAIK<BOLEMINDPIJ> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private FBCCGKHAAIK<INHNMLHBLPF> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FBCCGKHAAIK<IDMGPCABMLI> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private FBCCGKHAAIK<MIIMNMCJACG> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FBCCGKHAAIK<GPBAPFLPPLK> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FBCCGKHAAIK<MFMNMCECOHP> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private FBCCGKHAAIK<DLCBBFAKOIG> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private FBCCGKHAAIK<IGJNIAODAPD> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JMEDKDICIGA<HIDHCENBIKG> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JMEDKDICIGA<BOLEMINDPIJ> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JMEDKDICIGA<INHNMLHBLPF> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JMEDKDICIGA<IDMGPCABMLI> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766770", VA = "0x180767970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JMEDKDICIGA<MIIMNMCJACG> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7678E0", Offset = "0x7666E0", VA = "0x1807678E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JMEDKDICIGA<GPBAPFLPPLK> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7679F0", Offset = "0x7667F0", VA = "0x1807679F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JMEDKDICIGA<MFMNMCECOHP> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x827700", Offset = "0x826500", VA = "0x180827700", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JMEDKDICIGA<DLCBBFAKOIG> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x767990", Offset = "0x766790", VA = "0x180767990", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JMEDKDICIGA<IGJNIAODAPD> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x89EB10", Offset = "0x89D910", VA = "0x18089EB10", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6282C30", Offset = "0x6281A30", VA = "0x186282C30")]
		[DJDJPHIPNFL(KHJICKDGEOE.Root, IEJLPKKICHC.GameOnly)]
		private static void HLLKMDBMGOC(NNIGDKDCOBN AMGLAFJJOEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6282CB0", Offset = "0x6281AB0", VA = "0x186282CB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x18084A0A0")]
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
