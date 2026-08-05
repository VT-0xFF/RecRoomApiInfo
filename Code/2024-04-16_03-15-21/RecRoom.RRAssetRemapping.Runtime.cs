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
public class GLAIDHFIINL : JAADDLKDCOC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MKPAKKPMAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly JLCOAONOJCD AFCDCLMBBAN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6921E80", Offset = "0x6921080", VA = "0x186921E80")]
	[BDCLMMIIFOD(CIJFMPALMOO.GameOnly)]
	[UsedImplicitly]
	private static void OIJIAIDGBGE(JGBEMAKPOMJ PKLEDCMJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6921E20", Offset = "0x6921020", VA = "0x186921E20")]
	[UsedImplicitly]
	[BDCLMMIIFOD(CIJFMPALMOO.EditorOnly)]
	private static void MBMEENBGDPI(JGBEMAKPOMJ PKLEDCMJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	[Preserve]
	public GLAIDHFIINL([MINIJLJAKNC(null)] JLCOAONOJCD AFCDCLMBBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69212A0", Offset = "0x69204A0", VA = "0x1869212A0", Slot = "4")]
	public string JCBMCDNAHJB(GHLPFCLOJMP BHCBEHDFPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6921760", Offset = "0x6920960", VA = "0x186921760", Slot = "5")]
	public GHLPFCLOJMP MAOCPLNNJJM(string BHCBEHDFPNA)
	{
		return default(GHLPFCLOJMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKNNDJJMONJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6919640", Offset = "0x6918840", VA = "0x186919640")]
	public static JLCOAONOJCD MNANMJAOLHC()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public SerializedAvatarItemId(LCMAKACPPLG POAELFIOKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public LCMAKACPPLG MAOCPLNNJJM()
		{
			return default(LCMAKACPPLG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6925890", Offset = "0x6924A90", VA = "0x186925890", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6925950", Offset = "0x6924B50", VA = "0x186925950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public MIEIJBMPPGI MAOCPLNNJJM()
		{
			return default(MIEIJBMPPGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69259C0", Offset = "0x6924BC0", VA = "0x1869259C0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6925A60", Offset = "0x6924C60", VA = "0x186925A60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public MHLCCJMBBJE MAOCPLNNJJM()
		{
			return default(MHLCCJMBBJE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedColorId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedColorId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6925AD0", Offset = "0x6924CD0", VA = "0x186925AD0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6925B70", Offset = "0x6924D70", VA = "0x186925B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, JGBEHCONICA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6925D90", Offset = "0x6924F90", VA = "0x186925D90")]
		public FNCPBFIAFOK MAOCPLNNJJM()
		{
			return default(FNCPBFIAFOK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6925E70", Offset = "0x6925070", VA = "0x186925E70")]
		public SerializedCombinationId(FNCPBFIAFOK EKOPAIHNOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6925BE0", Offset = "0x6924DE0", VA = "0x186925BE0")]
		private void AGHFKOACAIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67B2EB0", Offset = "0x67B20B0", VA = "0x1867B2EB0", Slot = "4")]
		public bool Equals(SerializedCombinationId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6925CE0", Offset = "0x6924EE0", VA = "0x186925CE0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedCombinationId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6925E00", Offset = "0x6925000", VA = "0x186925E00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6925DF0", Offset = "0x6924FF0", VA = "0x186925DF0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x6925F40", Offset = "0x6925140", VA = "0x186925F40")]
		public static SerializedEquipmentSkinId KLBPPLCJECK()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public AEOALLDMPKB MAOCPLNNJJM()
		{
			return default(AEOALLDMPKB);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6925EA0", Offset = "0x69250A0", VA = "0x186925EA0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6925F70", Offset = "0x6925170", VA = "0x186925F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public NFAAHILECNI MAOCPLNNJJM()
		{
			return default(NFAAHILECNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6925FE0", Offset = "0x69251E0", VA = "0x186925FE0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6926080", Offset = "0x6925280", VA = "0x186926080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public DGCLIPNNKEP MAOCPLNNJJM()
		{
			return default(DGCLIPNNKEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69260F0", Offset = "0x69252F0", VA = "0x1869260F0", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6926190", Offset = "0x6925390", VA = "0x186926190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public SerializedHairPatternId(KFBDCNHKDOH POAELFIOKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public KFBDCNHKDOH MAOCPLNNJJM()
		{
			return default(KFBDCNHKDOH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930", Slot = "4")]
		public bool Equals(SerializedHairPatternId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6926200", Offset = "0x6925400", VA = "0x186926200", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6925930", Offset = "0x6924B30", VA = "0x186925930")]
		public static bool FPIEKNKMEBM(SerializedHairPatternId EAIBKNOIIGG, SerializedHairPatternId PKGAILNKPEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69262A0", Offset = "0x69254A0", VA = "0x1869262A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, JGBEHCONICA
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
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public SerializedMaterialId(FGKAKHJMBEH POAELFIOKHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
		public Guid DEMEEFPNFFI()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public FGKAKHJMBEH MAOCPLNNJJM()
		{
			return default(FGKAKHJMBEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67B2EB0", Offset = "0x67B20B0", VA = "0x1867B2EB0", Slot = "4")]
		public bool Equals(SerializedMaterialId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6926310", Offset = "0x6925510", VA = "0x186926310", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9125F0", Offset = "0x9117F0", VA = "0x1809125F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x67B2EB0", Offset = "0x67B20B0", VA = "0x1867B2EB0")]
		public static bool FPIEKNKMEBM(SerializedMaterialId EAIBKNOIIGG, SerializedMaterialId PKGAILNKPEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9123D0", Offset = "0x9115D0", VA = "0x1809123D0", Slot = "5")]
		public int CompareTo(SerializedMaterialId MEJMHKPOODP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69263B0", Offset = "0x69255B0", VA = "0x1869263B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BFHMMEEGCOA : JLCOAONOJCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BFHMMEEGCOA EELHBDDPCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6919520", Offset = "0x6918720", VA = "0x186919520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LDFOPLAHODB<LCMAKACPPLG> AFHFONKHOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69195E0", Offset = "0x69187E0", VA = "0x1869195E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LDFOPLAHODB<AEOALLDMPKB> GOGDOKFCNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6919340", Offset = "0x6918540", VA = "0x186919340", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LDFOPLAHODB<KFBDCNHKDOH> IKHMCLLKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69194C0", Offset = "0x69186C0", VA = "0x1869194C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LDFOPLAHODB<FNCPBFIAFOK> LEOAHIPAADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69192E0", Offset = "0x69184E0", VA = "0x1869192E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LDFOPLAHODB<MHLCCJMBBJE> LNPPMGNJJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69193A0", Offset = "0x69185A0", VA = "0x1869193A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LDFOPLAHODB<DGCLIPNNKEP> GKAGIKPPHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6919400", Offset = "0x6918600", VA = "0x186919400", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LDFOPLAHODB<MIEIJBMPPGI> OIAMNDPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6919580", Offset = "0x6918780", VA = "0x186919580", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LDFOPLAHODB<NFAAHILECNI> NFGEOOAHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6919460", Offset = "0x6918660", VA = "0x186919460", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class OMICMKDEEJC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69257E0", Offset = "0x69249E0", VA = "0x1869257E0")]
	public static Guid OGNJFLFMFBH(string HHNKLGJGDNK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6925710", Offset = "0x6924910", VA = "0x186925710")]
	public static bool HFDDBHOPKHH(string HHNKLGJGDNK, [Out] Guid JJMGPACFMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AICDILKLOPA : PGGPNLDEFFO<LCMAKACPPLG>, EAAOEPICDOC<LCMAKACPPLG>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6912DD0", Offset = "0x6911FD0", VA = "0x186912DD0", Slot = "4")]
	public IEnumerable<(LCMAKACPPLG, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6912CF0", Offset = "0x6911EF0", VA = "0x186912CF0", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public LCMAKACPPLG DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(LCMAKACPPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AICDILKLOPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HLHECPHKJPN : PGGPNLDEFFO<MIEIJBMPPGI>, EAAOEPICDOC<MIEIJBMPPGI>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6924040", Offset = "0x6923240", VA = "0x186924040", Slot = "4")]
	public IEnumerable<(MIEIJBMPPGI, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public MIEIJBMPPGI DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(MIEIJBMPPGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HLHECPHKJPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HFLOADOPDEJ : PGGPNLDEFFO<MHLCCJMBBJE>, EAAOEPICDOC<MHLCCJMBBJE>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6921F80", Offset = "0x6921180", VA = "0x186921F80", Slot = "4")]
	public IEnumerable<(MHLCCJMBBJE, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public MHLCCJMBBJE DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(MHLCCJMBBJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HFLOADOPDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JLGFCMCBNOM : PGGPNLDEFFO<FNCPBFIAFOK>, EAAOEPICDOC<FNCPBFIAFOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EAAOEPICDOC<FGKAKHJMBEH> ODLIDLMDNGC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C19B0", Offset = "0x7C0BB0", VA = "0x1807C19B0")]
	public JLGFCMCBNOM(EAAOEPICDOC<FGKAKHJMBEH> ODLIDLMDNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67B47C0", Offset = "0x67B39C0", VA = "0x1867B47C0", Slot = "4")]
	public IEnumerable<(FNCPBFIAFOK, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6924420", Offset = "0x6923620", VA = "0x186924420", Slot = "6")]
	public FNCPBFIAFOK DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(FNCPBFIAFOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69243E0", Offset = "0x69235E0", VA = "0x1869243E0", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ENOKHABNOBC : PGGPNLDEFFO<AEOALLDMPKB>, EAAOEPICDOC<AEOALLDMPKB>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6919690", Offset = "0x6918890", VA = "0x186919690", Slot = "4")]
	public IEnumerable<(AEOALLDMPKB, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public AEOALLDMPKB DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(AEOALLDMPKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ENOKHABNOBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BEIMBNGDCHC : PGGPNLDEFFO<NFAAHILECNI>, EAAOEPICDOC<NFAAHILECNI>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6917A20", Offset = "0x6916C20", VA = "0x186917A20", Slot = "4")]
	public IEnumerable<(NFAAHILECNI, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public NFAAHILECNI DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(NFAAHILECNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public BEIMBNGDCHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KDILCDJPKNE : PGGPNLDEFFO<DGCLIPNNKEP>, EAAOEPICDOC<DGCLIPNNKEP>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6924720", Offset = "0x6923920", VA = "0x186924720", Slot = "4")]
	public IEnumerable<(DGCLIPNNKEP, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public DGCLIPNNKEP DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(DGCLIPNNKEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KDILCDJPKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ODLNIHMLKJH : PGGPNLDEFFO<KFBDCNHKDOH>, EAAOEPICDOC<KFBDCNHKDOH>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6924B40", Offset = "0x6923D40", VA = "0x186924B40", Slot = "4")]
	public IEnumerable<(KFBDCNHKDOH, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public KFBDCNHKDOH DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(KFBDCNHKDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public ODLNIHMLKJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PGGPNLDEFFO<TModern> : EAAOEPICDOC<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> PNNABNICIJJ();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CIPCDGHDAOJ(string BFBGHLNGHBL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MLOPFKOOFDP : PGGPNLDEFFO<FGKAKHJMBEH>, EAAOEPICDOC<FGKAKHJMBEH>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6868930", Offset = "0x6867B30", VA = "0x186868930", Slot = "4")]
	public IEnumerable<(FGKAKHJMBEH, string)> PNNABNICIJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x914230", Offset = "0x913430", VA = "0x180914230", Slot = "5")]
	public string CIPCDGHDAOJ(string BFBGHLNGHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6912D10", Offset = "0x6911F10", VA = "0x186912D10", Slot = "6")]
	public FGKAKHJMBEH DALLEIKECLH(string BFBGHLNGHBL)
	{
		return default(FGKAKHJMBEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public MLOPFKOOFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EEMBMJGCACD<TModern> : LDFOPLAHODB<TModern>, EAAOEPICDOC<TModern> where TModern : IEquatable<TModern>, JGBEHCONICA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> IKHPGODIJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> PMBDCPICDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly PGGPNLDEFFO<TModern> FCCGABAGMHE;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34099F0", Offset = "0x3408BF0", VA = "0x1834099F0")]
	public EEMBMJGCACD(PGGPNLDEFFO<TModern> FCCGABAGMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x34066B0", Offset = "0x34058B0", VA = "0x1834066B0", Slot = "5")]
	public TModern DALLEIKECLH(string BFBGHLNGHBL)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x34086A0", Offset = "0x34078A0", VA = "0x1834086A0", Slot = "4")]
	public string KOMKFILPGCJ(TModern GAGHJECNBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OIBEBPAAFKN : JLCOAONOJCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EEMBMJGCACD<LCMAKACPPLG> EFFKBGBFLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EEMBMJGCACD<AEOALLDMPKB> KHENKLAJIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EEMBMJGCACD<KFBDCNHKDOH> GENHBLADKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EEMBMJGCACD<FGKAKHJMBEH> ODLIDLMDNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EEMBMJGCACD<FNCPBFIAFOK> DLMMNPGDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EEMBMJGCACD<MHLCCJMBBJE> AACKDKPAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EEMBMJGCACD<DGCLIPNNKEP> DLHCGKDLEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EEMBMJGCACD<MIEIJBMPPGI> EEHPPAPMALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EEMBMJGCACD<NFAAHILECNI> PGGOBEMKGEA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LDFOPLAHODB<LCMAKACPPLG> AFHFONKHOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LDFOPLAHODB<AEOALLDMPKB> GOGDOKFCNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LDFOPLAHODB<KFBDCNHKDOH> IKHMCLLKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LDFOPLAHODB<FNCPBFIAFOK> LEOAHIPAADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LDFOPLAHODB<MHLCCJMBBJE> LNPPMGNJJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LDFOPLAHODB<DGCLIPNNKEP> GKAGIKPPHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LDFOPLAHODB<MIEIJBMPPGI> OIAMNDPKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LDFOPLAHODB<NFAAHILECNI> NFGEOOAHGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF60", Offset = "0x7BB160", VA = "0x1807BBF60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69251C0", Offset = "0x69243C0", VA = "0x1869251C0")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	[UsedImplicitly]
	private static void DBEDDFAOJOD(JGBEMAKPOMJ PKLEDCMJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6925230", Offset = "0x6924430", VA = "0x186925230")]
	[Preserve]
	public OIBEBPAAFKN()
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
