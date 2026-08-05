using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Avatars;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RootMotion.FinalIK;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FFD0", Offset = "0x7B0F1D0", VA = "0x187B0FFD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B10050", Offset = "0x7B0F250", VA = "0x187B10050", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAABKHKLJM]
internal class MMBLDOECLMM : DFGKLGECNKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct FMHHHNFEPDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public MMBLDOECLMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HIEAKOJGBND avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NCBNAFLLHNG BAHHOBEIMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NPLNNBMEHNO JKMKIOIFLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LMCMPHNNPJK LBILAOFHOKH;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B0FCD0", Offset = "0x7B0EED0", VA = "0x187B0FCD0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	[UsedImplicitly]
	internal static void KLAEAHLHGJE(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B0FE50", Offset = "0x7B0F050", VA = "0x187B0FE50")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MMBLDOECLMM([NGLIAOPBMFM(null)] NCBNAFLLHNG BAHHOBEIMDJ, [NGLIAOPBMFM(null)] NPLNNBMEHNO JKMKIOIFLGO, [NGLIAOPBMFM(null)] LMCMPHNNPJK LBILAOFHOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B0F1B0", Offset = "0x7B0E3B0", VA = "0x187B0F1B0", Slot = "5")]
	public MLFDDOBOAFD GIAKLNPPFKH(HIEAKOJGBND LNEJDOLFDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0E350", Offset = "0x7B0D550", VA = "0x187B0E350", Slot = "4")]
	public MLFDDOBOAFD BEBKAACPKDI(HIEAKOJGBND LNEJDOLFDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0FD40", Offset = "0x7B0EF40", VA = "0x187B0FD40", Slot = "6")]
	public JLPCKEGOIAJ PKPDMOIJCPN(MLFDDOBOAFD CAIGHLKIDBF, int JDNOBKHDIMM, string? GBOCGPJOEEK, string? BKGLFCFLEBM, MDCHAHHDJEP EICMAJILGBG, List<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EF40", Offset = "0x7B0E140", VA = "0x187B0EF40", Slot = "7")]
	public bool DPFCJIPHANP(JGPCMMJIACE BIBCPGAMEJJ, [Out] MLFDDOBOAFD? NMNBELDFILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EE60", Offset = "0x7B0E060", VA = "0x187B0EE60", Slot = "8")]
	public bool DABCBFDKNCE(JLPCKEGOIAJ HPBENFAMHFI, [Out] MLFDDOBOAFD? NMNBELDFILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0FA90", Offset = "0x7B0EC90", VA = "0x187B0FA90", Slot = "9")]
	public bool HHLPNPJAGEK(JLPCKEGOIAJ HPBENFAMHFI, [Out] FEAFBJCHPOI? BIBCPGAMEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3B02270", Offset = "0x3B01470", VA = "0x183B02270")]
	private bool HMKLAIFNJJH<TInput, TOutput>(TInput GLMNBNPBGCG, GKFGGKJEHMF<TInput, TOutput> FBMIEOEOCAL, [Out] TOutput? ACALKMLJJOL) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B0FB20", Offset = "0x7B0ED20", VA = "0x187B0FB20")]
	[CompilerGenerated]
	private GAOHINJEOHD HNGKNDKKGLL(FaceFeatureType OLOLHIJOODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EFD0", Offset = "0x7B0E1D0", VA = "0x187B0EFD0")]
	[CompilerGenerated]
	private GAOHINJEOHD EFIBMAPPNHD(FaceFeatureType OLOLHIJOODJ, FMHHHNFEPDO P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CBAABKHKLJM]
internal class MIDJLHJBFPE : NCBNAFLLHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void KFKEIPEAOMG<in TData>(TData NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KAOOAPIGHJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public MLJHBMLBLFH rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public HGEJKEILCOP currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HGEJKEILCOP latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public KAOOAPIGHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C130", Offset = "0x7B0B330", VA = "0x187B0C130")]
		internal bool LKFFIGHGJJO(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C0B0", Offset = "0x7B0B2B0", VA = "0x187B0C0B0")]
		internal bool LIOIONDDPPH(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LMCMPHNNPJK LBILAOFHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LKKACGOMJHM AEMENHIGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KFKEIPEAOMG<MLFDDOBOAFD>?[] BAHHOBEIMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KFKEIPEAOMG<FEAFBJCHPOI>?[] PINFDKKLJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B0D900", Offset = "0x7B0CB00", VA = "0x187B0D900")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	[UsedImplicitly]
	internal static void KLAEAHLHGJE(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B0DCD0", Offset = "0x7B0CED0", VA = "0x187B0DCD0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MIDJLHJBFPE([NGLIAOPBMFM(null)] LMCMPHNNPJK LBILAOFHOKH, [NGLIAOPBMFM(null)] LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7B0DA70", Offset = "0x7B0CC70", VA = "0x187B0DA70", Slot = "4")]
	public bool PGGCCCPFFNB(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B0DB70", Offset = "0x7B0CD70", VA = "0x187B0DB70", Slot = "5")]
	public bool PGGCCCPFFNB(FEAFBJCHPOI BIBCPGAMEJJ, IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C990", Offset = "0x7B0BB90", VA = "0x187B0C990")]
	private void IFOIIPFAKNP(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C350", Offset = "0x7B0B550", VA = "0x187B0C350")]
	private void CAOJINEDKFA(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B0D970", Offset = "0x7B0CB70", VA = "0x187B0D970")]
	private void NIIKFGMCDFE(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C320", Offset = "0x7B0B520", VA = "0x187B0C320")]
	private void BFODJHKEMGI(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0D9A0", Offset = "0x7B0CBA0", VA = "0x187B0D9A0")]
	private void OAKLNDGBBNO(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0D570", Offset = "0x7B0C770", VA = "0x187B0D570")]
	private void ILKOJBHEBFI(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C580", Offset = "0x7B0B780", VA = "0x187B0C580")]
	private void COBKNLJMGBP(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C980", Offset = "0x7B0BB80", VA = "0x187B0C980")]
	private void HEHAIBMKLBA(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C950", Offset = "0x7B0BB50", VA = "0x187B0C950")]
	private void HCECNLBCCLO(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? LDINAKFKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0D620", Offset = "0x7B0C820", VA = "0x187B0D620")]
	private void JOHKFGKONNH(MLFDDOBOAFD NMNBELDFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C630", Offset = "0x7B0B830", VA = "0x187B0C630")]
	private MLFDDOBOAFD DDGNALNCLKD(MLFDDOBOAFD NMNBELDFILE, List<RangeMigration> BHPCLCJGOKA, HGEJKEILCOP CEKJLCEEAPK, HGEJKEILCOP ONLNPHGCJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C910", Offset = "0x7B0BB10", VA = "0x187B0C910")]
	private float EFALFFHCNHF(float MEKODADBGCD, Vector2 BDCNKBHBIII, Vector2 OJADALEKEPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B0C150", Offset = "0x7B0B350", VA = "0x187B0C150")]
	private (RangeMigration?, RangeMigration?) ADADLICCLLP(List<RangeMigration> ACDOLDJLAGE, MLJHBMLBLFH KOHFIKDJMJO, HGEJKEILCOP CEKJLCEEAPK, HGEJKEILCOP ONLNPHGCJCJ)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NCBNAFLLHNG
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGGCCCPFFNB(MLFDDOBOAFD NMNBELDFILE, IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PGGCCCPFFNB(FEAFBJCHPOI BIBCPGAMEJJ, IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Type of pose")]
		public BMABCNIHHFM AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF390", Offset = "0x7AEE590", VA = "0x187AEF390")]
		public void AMNACIBLDLN(AnimationPoseSetting CMOCFNBHPLJ, float BHMHPKBGCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF4C0", Offset = "0x7AEE6C0", VA = "0x187AEF4C0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFDB0", Offset = "0x7AEEFB0", VA = "0x187AEFDB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFD70", Offset = "0x7AEEF70", VA = "0x187AEFD70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF4E0", Offset = "0x7AEE6E0", VA = "0x187AEF4E0")]
		private void GLKJOFGKAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7A7EA60", Offset = "0x7A7DC60", VA = "0x187A7EA60", Slot = "4")]
		public void SetEnabled(bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFDE0", Offset = "0x7AEEFE0", VA = "0x187AEFDE0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFE20", Offset = "0x7AEF020", VA = "0x187AEFE20")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Lower than 1 makes the head bob less.")]
		public float BeanHeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Numbers under 1 = uses a slower locomotion animation. Above = faster.")]
		public float BeanLocomotionAnimationSelectionScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Numbers under 1 = plays the locomotion animations at a slower speed. Above = faster.")]
		public float BeanLocomotionAnimationSpeedScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Forward offset applied to bean animations.")]
		public float BeanHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Straighten the back by moving the pelvis instead of leaning towards the head.")]
		public float BeanStraightBackFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float ClassicBeanHandSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40D")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4DC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x504")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x508")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x518")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFE60", Offset = "0x7AEF060", VA = "0x187AEFE60")]
		public AnimationPoseSetting BAAFINACGKN(BMABCNIHHFM KBFHIEMPIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFE90", Offset = "0x7AEF090", VA = "0x187AEFE90")]
		public void IJDFNMPLFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFED0", Offset = "0x7AEF0D0", VA = "0x187AEFED0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum KFFMJLMGDFP
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private KFFMJLMGDFP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AF09C0", Offset = "0x7AEFBC0", VA = "0x187AF09C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0980", Offset = "0x7AEFB80", VA = "0x187AF0980")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0380", Offset = "0x7AEF580", VA = "0x187AF0380")]
		private void GLKJOFGKAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A7EA60", Offset = "0x7A7DC60", VA = "0x187A7EA60", Slot = "4")]
		public void SetEnabled(bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AF09F0", Offset = "0x7AEFBF0", VA = "0x187AF09F0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, JFONPHGKKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private HIEAKOJGBND avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[Header("Configuration")]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private OADMELLNGMM COFPDIHLHAP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OADMELLNGMM OGMHPAHMFLC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAFDA30", Offset = "0xAFCC30", VA = "0x180AFDA30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform LPFNJEDHPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7AF1890", Offset = "0x7AF0A90", VA = "0x187AF1890", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0A20", Offset = "0x7AEFC20", VA = "0x187AF0A20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1750", Offset = "0x7AF0950", VA = "0x187AF1750")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1700", Offset = "0x7AF0900", VA = "0x187AF1700")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1690", Offset = "0x7AF0890", VA = "0x187AF1690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0A20", Offset = "0x7AEFC20", VA = "0x187AF0A20", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0E60", Offset = "0x7AF0060", VA = "0x187AF0E60", Slot = "6")]
		public OADMELLNGMM CreateAvatarSystem(string FPDODEFKKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1690", Offset = "0x7AF0890", VA = "0x187AF1690", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AF0AE0", Offset = "0x7AEFCE0", VA = "0x187AF0AE0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AF17A0", Offset = "0x7AF09A0", VA = "0x187AF17A0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float IDFEGEHLHMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JJHHICDEBAO : OADMELLNGMM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class BAIMNPFOLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 KNPEILICJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion GANPCPGNENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 KHNJGBEPFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform BDHBNIOEMLF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 AFGPCBGKPBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1FF4600", Offset = "0x1FF3800", VA = "0x181FF4600")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1FF4620", Offset = "0x1FF3820", VA = "0x181FF4620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion FDMPHDMEABE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x10C6C60", Offset = "0x10C5E60", VA = "0x1810C6C60")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x10C5F60", Offset = "0x10C5160", VA = "0x1810C5F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float ICIKNLPKOFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1105690", Offset = "0x1104890", VA = "0x181105690")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x181DE00", Offset = "0x181D000", VA = "0x18181DE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool KKBBKFOENJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA0FC10", Offset = "0xA0EE10", VA = "0x180A0FC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool MAEONJFDOFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA0FC00", Offset = "0xA0EE00", VA = "0x180A0FC00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA0FCD0", Offset = "0xA0EED0", VA = "0x180A0FCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IBGOHJNOBKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA0FCF0", Offset = "0xA0EEF0", VA = "0x180A0FCF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD00", Offset = "0xA0EF00", VA = "0x180A0FD00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float EDGPAPMHALM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xCECA70", Offset = "0xCEBC70", VA = "0x180CECA70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCEC140", Offset = "0xCEB340", VA = "0x180CEC140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B12930", Offset = "0x7B11B30", VA = "0x187B12930")]
		public void CMNCAJMLJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B12AB0", Offset = "0x7B11CB0", VA = "0x187B12AB0")]
		public void MKMJDPMEAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B12AC0", Offset = "0x7B11CC0", VA = "0x187B12AC0")]
		public float ONBPJKOHAEJ(Vector3 MFAIFKFAMLD, Quaternion FAKDMEOENOF, [In] AvatarFootSettings IPFADJKKKLL, float EPDPNCNLBIN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B12260", Offset = "0x7B11460", VA = "0x187B12260")]
		public void CLCGMAGPLLD(Vector3 KGNLEFNADCA, Quaternion DNDKMHNKKIF, Transform HKGDMEPCAPH, float ILOOPBJGDCI, bool GHEMDHJPFDO, bool NDIGHIDLIHD, float ENFJFPEJHNF, float GBBMKLKHELE, Transform OLEJNEHCCLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B12030", Offset = "0x7B11230", VA = "0x187B12030")]
		public void CKICMLMBFBP(Transform OEJEEPDJANP, Transform OLEJNEHCCLF, bool MCOMLKIOFEH, bool LDDGIDDCGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B12CD0", Offset = "0x7B11ED0", VA = "0x187B12CD0")]
		private void PILIPKCDJAM(Transform OLEJNEHCCLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B12960", Offset = "0x7B11B60", VA = "0x187B12960")]
		public bool MBFPCLIALNJ(Transform OLEJNEHCCLF, AvatarFullBodyConfiguration HICOIPDJCOI, Vector3 NIIGDAIBKGE, float DHFGIEGINAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B12940", Offset = "0x7B11B40", VA = "0x187B12940")]
		public void EDELKLADCFJ(float GBBMKLKHELE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B12DD0", Offset = "0x7B11FD0", VA = "0x187B12DD0")]
		public BAIMNPFOLCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class BMLACFIPAKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float LPCNIHNFDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool LLEJLJAICAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting FIEGGBMKJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float DIOOCOKKFEO;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B140A0", Offset = "0x7B132A0", VA = "0x187B140A0")]
		public void INHENBJCCKA(IKSolverVR.Arm IHAELGKGIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B13A70", Offset = "0x7B12C70", VA = "0x187B13A70")]
		public void EGOOONNANAJ(IKSolverVR.Arm IHAELGKGIDJ, float OPLHMLMIBHF, bool LLEJLJAICAJ, AvatarFullBodyConfiguration HICOIPDJCOI, float AKHINELDCBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B13A30", Offset = "0x7B12C30", VA = "0x187B13A30")]
		private void ECOOJMPPCEJ(IKSolverVR.Arm IHAELGKGIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B13650", Offset = "0x7B12850", VA = "0x187B13650")]
		public void DKCLIOHEFII(IKSolverVR.Arm IHAELGKGIDJ, Transform JEHKKNHNJHP, Transform HKGDMEPCAPH, Quaternion AJMHDBPAMCL, Vector3 GDGNHPGDOFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B13C10", Offset = "0x7B12E10", VA = "0x187B13C10")]
		private (Vector3, Quaternion) GMMAGADJPOA(NACKAPHCKGC AAMKCODCKEN, Quaternion PEHHLHKGOLN, Vector3 GLFMBKJHANI)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B13AB0", Offset = "0x7B12CB0", VA = "0x187B13AB0")]
		public void GCALLKIFEPI(NACKAPHCKGC AAMKCODCKEN, IKSolverVR.Arm IHAELGKGIDJ, Quaternion PEHHLHKGOLN, Vector3 GLFMBKJHANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B14570", Offset = "0x7B13770", VA = "0x187B14570")]
		public void KGOKLIMPACD(NACKAPHCKGC AAMKCODCKEN, IKSolverVR.Arm IHAELGKGIDJ, Quaternion PEHHLHKGOLN, Vector3 GLFMBKJHANI, [In] AvatarFullBodyConfiguration HICOIPDJCOI, [In] IGAOAKIEAIF CKCKEFFHJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B14B70", Offset = "0x7B13D70", VA = "0x187B14B70")]
		public void LHGOJKOGDEE(BMABCNIHHFM MBNKLKJKAAA, AvatarFullBodyConfiguration HICOIPDJCOI, IGAOAKIEAIF CKCKEFFHJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B140D0", Offset = "0x7B132D0", VA = "0x187B140D0")]
		public void JCENJIMHAPE(IKSolverVR.Arm IHAELGKGIDJ, Transform JEHKKNHNJHP, Vector3 OPFFFOPIAAG, float NNCJDNKPGAD, Quaternion IEENEKHJKNM, Vector3 KFMGGEFMFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B14CB0", Offset = "0x7B13EB0", VA = "0x187B14CB0")]
		public BMLACFIPAKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum FAPLCMHLHIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NGDPEPDEPAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct FNDEGEMIEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int GDCIMKHJGIH;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int IAMHPCBGCBB;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int OEECLDAGFCK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int EIFMNPLCNHP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FONBFPONMMP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int ELLGJJOPAJO;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int CCDDFJDIPPI;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int GBEJAHFFNKL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int PBMNMCKEGKI;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int IDJFOCONFMP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int BOLDHJFGGFI;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int HKBBAPKCHOK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int LLJNJJKIPCN;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int ALMAGGACNHC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int CFIKBOFJCKK;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JEKJPLKAMHD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MGOPLFGGJNB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int JGDIEFHILOG;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int HIEKFABBHPP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int IHCDJPGGLJN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PBGLBOMIDIK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int MENJKFHKMED;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int DDJOKDDOHKB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int CMAKMPLKMKH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int BCEMKCPBPOH;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int BMDHBKMJCAD;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int BDGFOKDMFMK;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int MEPJGADFLDH;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int OOKAEJABFFP;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int CDHOKFMFODH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int OINIHLFMBOL;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int DNIIAMIMBGN;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 HAAKHLADOOE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int DBGLPCCHEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool KLFDHDOBMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool JPLNGNDJNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool CFFFMEDAGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool IBJKHKIFNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool LNDMPPPOBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CDKGBCEJJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 CKKCKHCFICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string EHNEJCLLHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EJODGLEFJFB? ENPNGFLEGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LBIFDIJPOMD? PLHALGNNMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private HHHEDDCEHLP EHEIJGAJEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private MEHBOADMAFE MJEDBCOHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NACKAPHCKGC NOOECKKAIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NACKAPHCKGC MCHKFGJOIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool CLDIGFOBKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool IAIKLGPCJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly MJKKANKPBLE IOEAHHGGKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly HGBNDHJJNFN DOOEFBOEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int FJDEBIPAJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float KFOGADGFJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject KPAGCFKLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform GILFGAGNHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform GPNHBDHKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform GOCEOMKDBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform AFENKHDBGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float DOFHOFCNJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float DHCOMBLHCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 NMBJGDIPJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion FPFELIHHLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform EIGGGJHJPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform BDFOEFFOAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform FOKDHOOPLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PBBLBPHODLA LOMJFEEGDNF;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker AGJNFFPJGEP;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker GCJOCLPLCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker EDOJFOJJEPM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker JKJMGMDKMNK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker KIOEBOGKALD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker JHDIKOOPHLC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<JJHHICDEBAO> OLJGDOLJLAN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int EKONGPBLHPO;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> ONAEAKEDDGB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int KGOJJLPBPEL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int HKHNEFEGAHF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int AHAPKBLFADH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int POBEAMCJKOJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float OGCGBDHBLNA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int EGGEDODBLJN;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float CIEGBINPGCM;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float BAKFDLKIFGH;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float JKGFKILOICH;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float BOMPLJBAIAE;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static IJCEFLHKACL BGBMIOCACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float KHEPJJLEPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool NPKEAJBIGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float COMMLJENJKI;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int BKKJOLFEBAC;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int HEGKFGNFJPK;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int AMJHNGCDNOM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int GFPBOPJJAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private BAIMNPFOLCB KIFJFDPPKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private BAIMNPFOLCB AIGHEILJNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float IGCPPCLIOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 HPJDCGFFJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 DIKNKBDKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool ACAODGPLNKO;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion LGHINKPFJLP;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion CKEJEIODLNG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 MPAACPHGKOC;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 PHFPIHPIEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float PKJBKKDPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float DNIFEPIPMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private BMLACFIPAKF KMANKINICFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private BMLACFIPAKF ADOEINJJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private GJHKOHHDDKI PCMEKINILNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private POKKNKEHCHE DCAKKDBMOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly OCGACBLEFDF DBBCAINOOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float NPOBKANKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float LFAEMFIIPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly POKKNKEHCHE PDNLKHBLANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 BHMGLEOGCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 EPEBFCKEJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float LLGFLBLMIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float LGGPMFDPHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly POKKNKEHCHE FHMEDDAFMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly GJHKOHHDDKI OFEHNCENCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly POKKNKEHCHE GNKAIHKPJPL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EPHHEFDKGKL ELNMCBGCNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EPHHEFDKGKL GKDAMGBHAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration IAOLBMPLGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6680", Offset = "0x7AF5880", VA = "0x187AF6680", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HIEAKOJGBND ELDNOACLEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B026B0", Offset = "0x7B018B0", VA = "0x187B026B0", Slot = "24")]
		get
		{
			return default(HIEAKOJGBND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration HEOMHONBLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AF75C0", Offset = "0x7AF67C0", VA = "0x187AF75C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform MCENJFDODGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B072D0", Offset = "0x7B064D0", VA = "0x187B072D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform HNNNLIBLMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2D00", Offset = "0x7AF1F00", VA = "0x187AF2D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer KGGHMBAKGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B06A20", Offset = "0x7B05C20", VA = "0x187B06A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] CKBJDHDBALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AF86F0", Offset = "0x7AF78F0", VA = "0x187AF86F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] LMGEJEDPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4DB0", Offset = "0x7AF3FB0", VA = "0x187AF4DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator KEMJIMFDILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B01FB0", Offset = "0x7B011B0", VA = "0x187B01FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JJHDOMCNBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2E00", Offset = "0x7AF2000", VA = "0x187AF2E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IHEOBAFNGIE FPOOBIKCIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF25E0", Offset = "0x7AF17E0", VA = "0x187AF25E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IHEOBAFNGIE FNHLIEGFKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFADE0", Offset = "0x7AF9FE0", VA = "0x187AFADE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private IHEOBAFNGIE LMFLHDHFEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7B07B10", Offset = "0x7B06D10", VA = "0x187B07B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private IHEOBAFNGIE JMNFMPKBGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6D20", Offset = "0x7AF5F20", VA = "0x187AF6D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IHEOBAFNGIE FFNAIBKLKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDA70", Offset = "0x7AFCC70", VA = "0x187AFDA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private IHEOBAFNGIE OOFKHIFMHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5F90", Offset = "0x7AF5190", VA = "0x187AF5F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private IHEOBAFNGIE FMGGEBKPFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AFFB30", Offset = "0x7AFED30", VA = "0x187AFFB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private IHEOBAFNGIE MLMMBCKHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B02840", Offset = "0x7B01A40", VA = "0x187B02840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LBIFDIJPOMD HBIMMKPCHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A00", Offset = "0x7B06C00", VA = "0x187B07A00", Slot = "16")]
		get
		{
			return default(LBIFDIJPOMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KONLHIGFPIP DANBHDDELJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAADF10", Offset = "0xAAD110", VA = "0x180AADF10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FHHGLMCDKMP OCLDIJKBLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB212E0", Offset = "0xB204E0", VA = "0x180B212E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JGDIKKCCKEJ DJJEFJOLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1C0", Offset = "0xAAD3C0", VA = "0x180AAE1C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JGDIKKCCKEJ ILHIHBIPNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB20FE0", Offset = "0xB201E0", VA = "0x180B20FE0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string KEFHBBEHCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform GHEPMOJHOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2540", Offset = "0x7AF1740", VA = "0x187AF2540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform EINOKFMAFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6780", Offset = "0x7AF5980", VA = "0x187AF6780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform PJIFOGILFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDA40", Offset = "0x7AFCC40", VA = "0x187AFDA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform FBHOMEMNOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF26E0", Offset = "0x7AF18E0", VA = "0x187AF26E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HJENCMGJHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8270", Offset = "0x7AF7470", VA = "0x187AF8270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool MHODMLDNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1900", Offset = "0x7AF0B00", VA = "0x187AF1900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool EPEAGDMIBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1900", Offset = "0x7AF0B00", VA = "0x187AF1900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool BHIDNGMDJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7B08E10", Offset = "0x7B08010", VA = "0x187B08E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform IJIIGEGILLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1DD0", Offset = "0x7AF0FD0", VA = "0x187AF1DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject LBBGHAOMHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7290", Offset = "0x7AF6490", VA = "0x187AF7290", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets APKHLKOBFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B02940", Offset = "0x7B01B40", VA = "0x187B02940", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform KNFHLMFMDEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB212F0", Offset = "0xB204F0", VA = "0x180B212F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform AELMBNMHDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB20850", Offset = "0xB1FA50", VA = "0x180B20850", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform BKGEIEDLMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB12100", Offset = "0xB11300", VA = "0x180B12100", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform NICCGCIOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAAD330", VA = "0x180AAE130", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 GHEMILPPCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B02EA0", Offset = "0x7B020A0", VA = "0x187B02EA0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float OIIGEJLBPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5300", Offset = "0x7AF4500", VA = "0x187AF5300", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform EAMLDIKAMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7AF37B0", Offset = "0x7AF29B0", VA = "0x187AF37B0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform FAICBJAJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x142DDB0", Offset = "0x142CFB0", VA = "0x18142DDB0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform LNNDNEHGHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAAD340", VA = "0x180AAE140", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform LILCJOMLHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2372F50", Offset = "0x2372150", VA = "0x182372F50", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool HOGFIJDKHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7AF1AA0", Offset = "0x7AF0CA0", VA = "0x187AF1AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KFOHPPMEALH<OADMELLNGMM.KLMOIAHLCLN> EHOBKGFDDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B02E90", Offset = "0x7B02090", VA = "0x187B02E90", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool FBHNKKPBOCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF74C0", Offset = "0x7AF66C0", VA = "0x187AF74C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool FBNJIACIDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7AF2230", Offset = "0x7AF1430", VA = "0x187AF2230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AF40C0", Offset = "0x7AF32C0", VA = "0x187AF40C0")]
	private float DFHAGOJHPEA(JJNLPDLGAEG LPKBDJGLONC, float OBIDDCNPCJO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB890", Offset = "0x7AFAA90", VA = "0x187AFB890")]
	private void JFOFNHDCJFC([In] IGAOAKIEAIF DDJOIMIAKBP, [In] AvatarFullBodyConfiguration HICOIPDJCOI, bool AHPDIJFOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B027B0", Offset = "0x7B019B0", VA = "0x187B027B0")]
	private float LPADOGPMAGF([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1A20", Offset = "0x7AF0C20", VA = "0x187AF1A20")]
	private float ANNKOFLOKOP([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B01600", Offset = "0x7B00800", VA = "0x187B01600")]
	private void LDHBALPFBGL(IGAOAKIEAIF DDJOIMIAKBP, AvatarFullBodyConfiguration HICOIPDJCOI, bool AHPDIJFOFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2720", Offset = "0x7AF1920", VA = "0x187AF2720")]
	private void BLIAPECCLJM([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B071D0", Offset = "0x7B063D0", VA = "0x187B071D0")]
	private void OGICFJFLAAN([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0BBB0", Offset = "0x7B0ADB0", VA = "0x187B0BBB0")]
	public JJHHICDEBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7AFDC30", Offset = "0x7AFCE30", VA = "0x187AFDC30", Slot = "13")]
	public void JKKBDGLLPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3400", Offset = "0x7AF2600", VA = "0x187AF3400", Slot = "14")]
	public void CODFJKLGLHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B02F30", Offset = "0x7B02130", VA = "0x187B02F30", Slot = "15")]
	public void MJDIBICLIHO(bool IDHPAMLCOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7AFD8F0", Offset = "0x7AFCAF0", VA = "0x187AFD8F0", Slot = "26")]
	public Transform JHIILCICNKP(string DGOMKLEAAMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7330", Offset = "0x7AF6530", VA = "0x187AF7330", Slot = "27")]
	public Vector3? FNLJBLAGPHH(string DGOMKLEAAMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8450", Offset = "0x7AF7650", VA = "0x187AF8450", Slot = "7")]
	public void HPHGFIOHCOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B06B20", Offset = "0x7B05D20", VA = "0x187B06B20")]
	private void OCBJLGKOJOM(AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1B90", Offset = "0x7AF0D90", VA = "0x187AF1B90", Slot = "8")]
	public void BBFMJEAPHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6580", Offset = "0x7AF5780", VA = "0x187AF6580")]
	private void FFEEIOMNJNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B05E00", Offset = "0x7B05000", VA = "0x187B05E00")]
	private Vector3 NNPEODEGFMD([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AFA8D0", Offset = "0x7AF9AD0", VA = "0x187AFA8D0", Slot = "6")]
	public void IEEMDFDCKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7AF56B0", Offset = "0x7AF48B0", VA = "0x187AF56B0")]
	private void EOOFBIOPOJG(bool AHPDIJFOFFI, FAPLCMHLHIF MEJIIFKKEMH, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B01380", Offset = "0x7B00580", VA = "0x187B01380", Slot = "9")]
	public void LANOPEFGEAJ(float GGPPJJPONDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3190", Offset = "0x7AF2390", VA = "0x187AF3190")]
	private void CMBDEMIDDJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B08F00", Offset = "0x7B08100", VA = "0x187B08F00", Slot = "4")]
	public void PMJMLIJOHOK(string FPDODEFKKOP, EJODGLEFJFB FICCABLJLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7AF68A0", Offset = "0x7AF5AA0", VA = "0x187AF68A0", Slot = "5")]
	public void FKMFLGDGNPO(LBIFDIJPOMD PIBMLFMGFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B073D0", Offset = "0x7B065D0", VA = "0x187B073D0", Slot = "12")]
	public void OGLPLJMNDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B07C10", Offset = "0x7B06E10", VA = "0x187B07C10", Slot = "25")]
	public void PBMGCIDOADN([Out] Vector3 DIJFEHHCFLM, [Out] Quaternion IEENEKHJKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6550", Offset = "0x7AF5750", VA = "0x187AF6550")]
	private void FFDBCPHLDJE([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x121B8F0", Offset = "0x121AAF0", VA = "0x18121B8F0", Slot = "28")]
	public void BEEOMLFDNOI(float CLCKCPNHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7B029C0", Offset = "0x7B01BC0", VA = "0x187B029C0", Slot = "29")]
	public void MCNDCKFNOGC(float IDKCJNCCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AF18B0", Offset = "0x7AF0AB0", VA = "0x187AF18B0", Slot = "46")]
	public void ABMJMEINPAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7AF87F0", Offset = "0x7AF79F0", VA = "0x187AF87F0", Slot = "30")]
	public void IACCPHLLHPG(bool OGKNIENILEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2590", Offset = "0x7AF1790", VA = "0x187AF2590", Slot = "31")]
	public HandLogicOffsets BHAEJDNGMMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7AFDB70", Offset = "0x7AFCD70", VA = "0x187AFDB70", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets JKINJGDKNBA()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B00940", Offset = "0x7AFFB40", VA = "0x187B00940")]
	private void KOCCMAHHIKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5530", Offset = "0x7AF4730", VA = "0x187AF5530")]
	private void ENEBGAHLKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7E30", Offset = "0x7AF7030", VA = "0x187AF7E30")]
	private void HLDDEGEJMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B055D0", Offset = "0x7B047D0", VA = "0x187B055D0")]
	private void NIHPCPCNKDK(NIJLAPDBAHE BAOCDEMDHGG, bool PEMCPPNLJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B02D10", Offset = "0x7B01F10", VA = "0x187B02D10")]
	private void MFCCJCGKAKA(NIJLAPDBAHE BAOCDEMDHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF31E0", Offset = "0x7AF23E0", VA = "0x187AF31E0")]
	public Vector3 CMECMFAFGGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7B04230", Offset = "0x7B03430", VA = "0x187B04230")]
	private void MMCHJACCOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7B05A00", Offset = "0x7B04C00", VA = "0x187B05A00")]
	private void NKFDJJEAHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7AFE3B0", Offset = "0x7AFD5B0", VA = "0x187AFE3B0")]
	private void JPLKFGHMLNJ(IGAOAKIEAIF DDJOIMIAKBP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2B10", Offset = "0x7AF1D10", VA = "0x187AF2B10")]
	private float BPKFGBFALBN([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7AF67C0", Offset = "0x7AF59C0", VA = "0x187AF67C0")]
	private int FJJHOGJGFOC([In] FMHENPIPMMH CDHIDAPHIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7B08130", Offset = "0x7B07330", VA = "0x187B08130")]
	private void PFEEHEBFBFE(IGAOAKIEAIF DDJOIMIAKBP, bool DKIPGAPEMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7B013F0", Offset = "0x7B005F0", VA = "0x187B013F0")]
	private static void LDEPAAPCMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7AFEE30", Offset = "0x7AFE030", VA = "0x187AFEE30")]
	private static void KCEDJDHCELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B05C30", Offset = "0x7B04E30", VA = "0x187B05C30")]
	private float NMACJHLOKEI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7940", Offset = "0x7AF6B40", VA = "0x187AF7940")]
	private static int HGNAKGFCKBO(JJHHICDEBAO KEAFHNNEEAN, JJHHICDEBAO FNKKBNJEBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7B058B0", Offset = "0x7B04AB0", VA = "0x187B058B0", Slot = "41")]
	public IGAOAKIEAIF NJABHNJNBCM()
	{
		return default(IGAOAKIEAIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4970", Offset = "0x7AF3B70", VA = "0x187AF4970")]
	private bool DNOMIADPMKN(int APBCLGNDGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7540", Offset = "0x7AF6740", VA = "0x187AF7540")]
	public void GIFCAKLDGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B05400", Offset = "0x7B04600", VA = "0x187B05400")]
	private (bool, bool) NIFOKGFEOAD()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7AF5350", Offset = "0x7AF4550", VA = "0x187AF5350")]
	private (float, float) ELLLNEHPJCG([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8840", Offset = "0x7AF7A40", VA = "0x187AF8840")]
	private void IDDIGHHKJAD([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAAC0", Offset = "0x7AF9CC0", VA = "0x187AFAAC0")]
	private void IIFMFNBKGEG([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7B03E10", Offset = "0x7B03010", VA = "0x187B03E10")]
	private void MLDJEMADDBK([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI, AvatarFootSettings IPFADJKKKLL, bool MDIPLALPBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7AFE330", Offset = "0x7AFD530", VA = "0x187AFE330")]
	private float JOHJFCDJBAN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B03290", Offset = "0x7B02490", VA = "0x187B03290")]
	private void MJKMOGMAHNP(IGAOAKIEAIF CKCKEFFHJAP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4A10", Offset = "0x7AF3C10", VA = "0x187AF4A10")]
	private float DOENDIGPMFL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB3D0", Offset = "0x7AFA5D0", VA = "0x187AFB3D0")]
	private void JEGHMBEAEMJ([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7AF42A0", Offset = "0x7AF34A0", VA = "0x187AF42A0")]
	private void DKCLIOHEFII([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4580", Offset = "0x7AF3780", VA = "0x187AF4580")]
	private void DMAKBDKDBDD([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF22B0", Offset = "0x7AF14B0", VA = "0x187AF22B0")]
	private void BEOCENFPJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6E20", Offset = "0x7AF6020", VA = "0x187AF6E20")]
	private void FMHFJJEEBJG(float BINDOKNGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B07FA0", Offset = "0x7B071A0", VA = "0x187B07FA0")]
	private void PDLFIODJJHN([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2F00", Offset = "0x7AF2100", VA = "0x187AF2F00")]
	private void CKCJKBCGMAE(NACKAPHCKGC MGAEGJMNIDC, IKSolverVR.Arm IHAELGKGIDJ, Transform JKLHEOJCKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7970", Offset = "0x7AF6B70", VA = "0x187AF7970")]
	private void HHOMLLCGBMF(IGAOAKIEAIF CKCKEFFHJAP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3230", Offset = "0x7AF2430", VA = "0x187AF3230")]
	private void CMNKIHGNLLN(MCONPIEHLEK BPKELHMNMLC, JGDIKKCCKEJ MGAEGJMNIDC, IKSolverVR.Arm IHAELGKGIDJ, float OPLHMLMIBHF, float EHGPGCIGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7B05A20", Offset = "0x7B04C20", VA = "0x187B05A20")]
	private void NKHPGDBGLMN([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7B020B0", Offset = "0x7B012B0", VA = "0x187B020B0")]
	private void LMFBONGDOJD([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7B07530", Offset = "0x7B06730", VA = "0x187B07530")]
	protected void OJPFHBAIHIB([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4A60", Offset = "0x7AF3C60", VA = "0x187AF4A60")]
	private void EDPDJEOBCGK([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7AFD6A0", Offset = "0x7AFC8A0", VA = "0x187AFD6A0")]
	protected void JGEDGDJBEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7B01790", Offset = "0x7B00990", VA = "0x187B01790")]
	private void LEADEGKLHDE([In] IGAOAKIEAIF CKCKEFFHJAP, [In] FAPLCMHLHIF MEJIIFKKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7AFAEE0", Offset = "0x7AFA0E0", VA = "0x187AFAEE0")]
	private void INNOIAHMFPJ(IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7AF2CC0", Offset = "0x7AF1EC0", VA = "0x187AF2CC0")]
	private void CEFFAMHHPFE([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7AFFC30", Offset = "0x7AFEE30", VA = "0x187AFFC30")]
	private Vector3 KFKJLFDKJDP([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1950", Offset = "0x7AF0B50", VA = "0x187AF1950")]
	private void AJPJFDGEMMG([In] IGAOAKIEAIF CKCKEFFHJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF4EB0", Offset = "0x7AF40B0", VA = "0x187AF4EB0")]
	private float EJGPIANKNOJ(float GBBMKLKHELE, [In] IGAOAKIEAIF CKCKEFFHJAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB280", Offset = "0x7AFA480", VA = "0x187AFB280")]
	private void IPHNFJOLHAA(float GBBMKLKHELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B04520", Offset = "0x7B03720", VA = "0x187B04520")]
	private void NAHHEEKJCFE([In] IGAOAKIEAIF CKCKEFFHJAP, FAPLCMHLHIF MEJIIFKKEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7B00140", Offset = "0x7AFF340", VA = "0x187B00140")]
	private float KKILOMIAKOC([In] IGAOAKIEAIF DDJOIMIAKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7B04C10", Offset = "0x7B03E10", VA = "0x187B04C10")]
	private void NDAMJNGGMFD(IGAOAKIEAIF CKCKEFFHJAP, FAPLCMHLHIF MEJIIFKKEMH, Vector3 IOOPCEMKAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7AFE180", Offset = "0x7AFD380", VA = "0x187AFE180")]
	private static void JOAOJDPOPJG(Transform JGOMLHGOKKB, Quaternion NDOBKEDDJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7AFD370", Offset = "0x7AFC570", VA = "0x187AFD370")]
	private void JGABHOPHACD([In] IGAOAKIEAIF HDDLIPCPJJK, [In] FMHENPIPMMH CDHIDAPHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7AF3810", Offset = "0x7AF2A10", VA = "0x187AF3810")]
	private void DEJEHLIOMBE([In] IGAOAKIEAIF HDDLIPCPJJK, [In] FMHENPIPMMH CDHIDAPHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7AFB090", Offset = "0x7AFA290", VA = "0x187AFB090")]
	private void IPCBNNPEJPH(float KMEOHFGHLDO, [In] IGAOAKIEAIF DDJOIMIAKBP, float LLAKJJKCNGH = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B08650", Offset = "0x7B07850", VA = "0x187B08650")]
	private float PGBNKPCGLFH([In] IGAOAKIEAIF DDJOIMIAKBP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7AF7650", Offset = "0x7AF6850", VA = "0x187AF7650")]
	private void HFMJPLCMGKG([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7B00970", Offset = "0x7AFFB70", VA = "0x187B00970")]
	private void LAFLIGAAFLG([In] IGAOAKIEAIF DDJOIMIAKBP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7AFEA60", Offset = "0x7AFDC60", VA = "0x187AFEA60")]
	private void KBICDNADDHB([In] IGAOAKIEAIF DDJOIMIAKBP, float KKPPOEMBEJO, float FJKBKJLONNN, Vector3 AIOEKKJDPNM, float LLAKJJKCNGH = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B06030", Offset = "0x7B05230", VA = "0x187B06030")]
	private void NPKLAFMEMJE(IGAOAKIEAIF DDJOIMIAKBP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B03000", Offset = "0x7B02200", VA = "0x187B03000")]
	private void MJKJHPKAHCN(IGAOAKIEAIF CKCKEFFHJAP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6090", Offset = "0x7AF5290", VA = "0x187AF6090")]
	private void FDMHOEOMBED(IGAOAKIEAIF DDJOIMIAKBP, AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7AF40E0", Offset = "0x7AF32E0", VA = "0x187AF40E0")]
	public void DGEMNDNGKNO([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7AF1ED0", Offset = "0x7AF10D0", VA = "0x187AF1ED0")]
	public void BCMNJFCOHBM([In] IGAOAKIEAIF CKCKEFFHJAP, [In] AvatarFullBodyConfiguration HICOIPDJCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7AF82B0", Offset = "0x7AF74B0", VA = "0x187AF82B0")]
	[CompilerGenerated]
	internal static void HPFNFNCJNMF(Transform LMDCFNDMKMH, IKSolverVR.Arm IHAELGKGIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B05F80", Offset = "0x7B05180", VA = "0x187B05F80")]
	[CompilerGenerated]
	internal static void NOJCIBJCAOC(Vector3 CCOOBODHLJA, Vector3 BDJNJLNAGDJ, NGDPEPDEPAL P_2, FNDEGEMIEPI P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7AF71F0", Offset = "0x7AF63F0", VA = "0x187AF71F0")]
	[CompilerGenerated]
	internal static void FMLNAPGBJKD(BAIMNPFOLCB IMJJKIKMINL, BAIMNPFOLCB OFFINCJFDOP, Vector3 GCJKOBHLFJB, float HKIJLMNBOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7B078F0", Offset = "0x7B06AF0", VA = "0x187B078F0")]
	[CompilerGenerated]
	internal static bool OOINIODPMBJ(IKSolverVR.Arm IHAELGKGIDJ, KCGDJEFAEGI CBOICIEDOGK, float DOIFOMHANCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7AFA490", Offset = "0x7AF9690", VA = "0x187AFA490")]
	[CompilerGenerated]
	internal static float IEDHOPPGGON(Vector3 KOPEKABDAIL, Vector3 FPCCOLGODEJ, Vector3 BNLEBFOHLNF, IGAOAKIEAIF DDJOIMIAKBP, AvatarFullBodyConfiguration HICOIPDJCOI, float GJBFKFHLHKP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NIBLPBMANGI : GALJKJPMJMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, OADMELLNGMM> DBAAAALLLBA;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7B18D30", Offset = "0x7B17F30", VA = "0x187B18D30")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void KKNFKOKLLGA(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7B18EE0", Offset = "0x7B180E0", VA = "0x187B18EE0", Slot = "4")]
	public OADMELLNGMM OKDPKMLIOIM(string LEDFDIGHKMF, AvatarSystemConfiguration ADAHHOONJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7B18AE0", Offset = "0x7B17CE0", VA = "0x187B18AE0", Slot = "5")]
	public void AJNBICCDHPI(string LEDFDIGHKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7B18DA0", Offset = "0x7B17FA0", VA = "0x187B18DA0", Slot = "6")]
	public string LHNIMFBLMNI(string BNKJIMCPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7B18CC0", Offset = "0x7B17EC0", VA = "0x187B18CC0")]
	private string FHIBJDAHGDA(string BNKJIMCPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7B19100", Offset = "0x7B18300", VA = "0x187B19100")]
	public NIBLPBMANGI()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class EENIBBDDJNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> CBJAIPKHMHM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool AEOGNGCAJFN
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7B15270", Offset = "0x7B14470", VA = "0x187B15270")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7B15300", Offset = "0x7B14500", VA = "0x187B15300")]
			public void MKBPAFPFNAB(VRIK KMIEJJADAOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
			public void JGAGOCFCFKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7B152B0", Offset = "0x7B144B0", VA = "0x187B152B0")]
			public void DNFMCNPCKDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7B15430", Offset = "0x7B14630", VA = "0x187B15430")]
			public EENIBBDDJNM()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[GOJJDCGGJEB(CFJMFGLCHFI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[GBCGIPBAICF(CFJMFGLCHFI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly EENIBBDDJNM JOJFJEAFJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private JFONPHGKKCN GMKCPMJLLKB;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7B11990", Offset = "0x7B10B90", VA = "0x187B11990")]
		private void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7B11940", Offset = "0x7B10B40", VA = "0x187B11940")]
		private bool ACFJOPNLOOP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7B11C70", Offset = "0x7B10E70", VA = "0x187B11C70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7B11CE0", Offset = "0x7B10EE0", VA = "0x187B11CE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7B11C80", Offset = "0x7B10E80", VA = "0x187B11C80")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B11F50", Offset = "0x7B11150", VA = "0x187B11F50")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct HandsOpenCloseAmount
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7B16850", Offset = "0x7B15A50", VA = "0x187B16850")]
			public (float, float) NMFKOPKGDHD(float HMNHMMBKBKE)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000164")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000165")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7B16080", Offset = "0x7B15280", VA = "0x187B16080")]
			public void IJDFNMPLFGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7B15F40", Offset = "0x7B15140", VA = "0x187B15F40")]
			public (float, float) CHNDDJNNOEF(Animator GDMACAEEIPG, AnimatorStateInfo BPGNDNOODDK)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int IDLE_STATE_ID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B16160", Offset = "0x7B15360", VA = "0x187B16160")]
		public void IJDFNMPLFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B16350", Offset = "0x7B15550", VA = "0x187B16350")]
		public (float, float) KOKPCPBLMCL(Animator GDMACAEEIPG, JJNLPDLGAEG LPKBDJGLONC, float DINFILDBFLC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B16590", Offset = "0x7B15790", VA = "0x187B16590")]
		private (float, float) NLNENGOPNLE(Animator GDMACAEEIPG, AnimatorStateInfo BPGNDNOODDK, JJNLPDLGAEG LPKBDJGLONC, float DINFILDBFLC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7B16840", Offset = "0x7B15A40", VA = "0x187B16840")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B18960", Offset = "0x7B17B60", VA = "0x187B18960", Slot = "4")]
		public override void OnStateEnter(Animator GDMACAEEIPG, AnimatorStateInfo BPGNDNOODDK, int AIKKAOBLJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B18AC0", Offset = "0x7B17CC0", VA = "0x187B18AC0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class JJGCKDKBCDL<TInput, TOutput> : GKFGGKJEHMF<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly LKKACGOMJHM AEMENHIGDPD;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x50578D0", Offset = "0x5056AD0", VA = "0x1850578D0")]
	protected JJGCKDKBCDL(LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput BHIBMPPAILM(TInput GLMNBNPBGCG, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5057830", Offset = "0x5056A30", VA = "0x185057830", Slot = "5")]
	public bool HMKLAIFNJJH(TInput GLMNBNPBGCG, [Out] TOutput? ACALKMLJJOL, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CBAABKHKLJM]
public static class EKHBGFFMHGO
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex LOGDBHLOCOM;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7B15760", Offset = "0x7B14960", VA = "0x187B15760")]
	public static NGOLNHHLKLE PHAPDPPCLPG(OEOKECIEANE HDAHIJKIDKG, BEJJMAFOJDH EOOLALMGKBE, Guid? BFKMEDKGNMB, Color? BONHEDPPKOH, IMAHPAJHFNK IJFIDCOKOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7B15600", Offset = "0x7B14800", VA = "0x187B15600")]
	public static GHAADPGGCEA CNNCPAAFCIO(NGOLNHHLKLE CAIGHLKIDBF)
	{
		return default(GHAADPGGCEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3896610", Offset = "0x3895810", VA = "0x183896610")]
	internal static TModern? DCKOLCGLBOA<TModern>(string? GLMNBNPBGCG, BPMBCBHNICN<TModern> ABMGNFLKPNO, LKKACGOMJHM AEMENHIGDPD, PMPNNNDOLGF HGDLMKNEMAP, TModern MEAIDBKOFKH) where TModern : struct, DAGBLJJIGGP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3897C60", Offset = "0x3896E60", VA = "0x183897C60")]
	internal static CAPBBOECDPO GKAMLLDDPAN<TModern>(string? GLMNBNPBGCG, BPMBCBHNICN<TModern> ABMGNFLKPNO, LKKACGOMJHM AEMENHIGDPD, PMPNNNDOLGF HGDLMKNEMAP, TModern MEAIDBKOFKH) where TModern : struct, DAGBLJJIGGP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7B154C0", Offset = "0x7B146C0", VA = "0x187B154C0")]
	internal static List<PGKCIHNBJDG> CEHPFPBCDHA(IEnumerable<EOHNBDPKCBE>? GMNNMIPJOIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x38983D0", Offset = "0x38975D0", VA = "0x1838983D0")]
	internal static string MFHBFGNLMCD<TModern>(TModern GLMNBNPBGCG, BPMBCBHNICN<TModern> ABMGNFLKPNO, LKKACGOMJHM AEMENHIGDPD) where TModern : DAGBLJJIGGP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class AGCAOEEPJCK : NPLNNBMEHNO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GKFGGKJEHMF<JGPCMMJIACE, MLFDDOBOAFD> BBICHBPHKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GKFGGKJEHMF<JLPCKEGOIAJ, FEAFBJCHPOI> DMKCEMCDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GKFGGKJEHMF<JLPCKEGOIAJ, FEAFBJCHPOI> EKNMLNKNAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PDBDNDMDKIN NOANGKJAPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GHPOIJDOMHA FKLGNLJEAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7B104F0", Offset = "0x7B0F6F0", VA = "0x187B104F0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	[UsedImplicitly]
	internal static void KLAEAHLHGJE(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7B10560", Offset = "0x7B0F760", VA = "0x187B10560")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AGCAOEEPJCK([NGLIAOPBMFM("UnitySerialization")] EEGLJJGAEEM CKIKCEIELGN, [NGLIAOPBMFM(null)] AOEMIOEJPMI BBINOBLDFML, [NGLIAOPBMFM(null)] LKKACGOMJHM AEMENHIGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum PAMHPAKNKKM
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DKCNHFNDKDA : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7B14D70", Offset = "0x7B13F70", VA = "0x187B14D70")]
	public DKCNHFNDKDA(string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7B14DD0", Offset = "0x7B13FD0", VA = "0x187B14DD0")]
	public DKCNHFNDKDA(string NPEJLHCJPAI, Exception LANNDIJMBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7B14DA0", Offset = "0x7B13FA0", VA = "0x187B14DA0")]
	public DKCNHFNDKDA(PAMHPAKNKKM IEGHFABKDKJ, string NPEJLHCJPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7B14D30", Offset = "0x7B13F30", VA = "0x187B14D30")]
	public DKCNHFNDKDA(PAMHPAKNKKM IEGHFABKDKJ, string NPEJLHCJPAI, Exception LANNDIJMBDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class IIINNAPCHGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly EEGLJJGAEEM CKIKCEIELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly AOEMIOEJPMI BBINOBLDFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly LKKACGOMJHM AEMENHIGDPD;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B134D0", Offset = "0x7B126D0", VA = "0x187B134D0")]
	protected IIINNAPCHGK(EEGLJJGAEEM CKIKCEIELGN, AOEMIOEJPMI BBINOBLDFML, LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B16910", Offset = "0x7B15B10", VA = "0x187B16910")]
	protected string FODJJGPKNEC(MLFDDOBOAFD NMNBELDFILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B17BE0", Offset = "0x7B16DE0", VA = "0x187B17BE0")]
	protected string HCEFKOJKMOJ(MLFDDOBOAFD NMNBELDFILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7B17F10", Offset = "0x7B17110", VA = "0x187B17F10")]
	private AvatarOutfitSelectionData PHAPDPPCLPG(NGOLNHHLKLE BGPAAGKJDNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7B17DD0", Offset = "0x7B16FD0", VA = "0x187B17DD0")]
	private static AvatarCustomizationSettingsData.AnchorParams LFGNGJINIHP(BCHLBCJFNPL? KFGJHKKPMNP)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface GKFGGKJEHMF<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput BHIBMPPAILM(TInput GLMNBNPBGCG, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HMKLAIFNJJH(TInput GLMNBNPBGCG, [Out] TOutput? ACALKMLJJOL, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NPLNNBMEHNO
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	GKFGGKJEHMF<JGPCMMJIACE, MLFDDOBOAFD> BBICHBPHKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GKFGGKJEHMF<JLPCKEGOIAJ, FEAFBJCHPOI> EKNMLNKNAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	PDBDNDMDKIN NOANGKJAPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum PMPNNNDOLGF
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GHPOIJDOMHA
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MOGBPGICBFB ELKKKBEIKKA(MLFDDOBOAFD CAIGHLKIDBF);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PDBDNDMDKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JLPCKEGOIAJ ELKKKBEIKKA(MLFDDOBOAFD CAIGHLKIDBF, int JDNOBKHDIMM, string? GBOCGPJOEEK, string? BKGLFCFLEBM, MDCHAHHDJEP EICMAJILGBG, List<PGKCIHNBJDG>? KCLJCNKKKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[CBAABKHKLJM]
internal class DOHENLEIOFG : JJGCKDKBCDL<JGPCMMJIACE, MLFDDOBOAFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly AOEMIOEJPMI BBINOBLDFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly PHEMOGKKDFF AIHEKBNNEKP;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7B150A0", Offset = "0x7B142A0", VA = "0x187B150A0")]
	public DOHENLEIOFG(EEGLJJGAEEM CKIKCEIELGN, AOEMIOEJPMI BBINOBLDFML, LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B14E00", Offset = "0x7B14000", VA = "0x187B14E00", Slot = "6")]
	public override MLFDDOBOAFD BHIBMPPAILM(JGPCMMJIACE GLMNBNPBGCG, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class ADKGJPJLIKI : EEGLJJGAEEM
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class JMNMAPOFPNA : JsonConverter<CAPBBOECDPO>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B18360", Offset = "0x7B17560", VA = "0x187B18360", Slot = "9")]
		public override void WriteJson(JsonWriter HLPFOKGJOHH, CAPBBOECDPO? KJIOHKMJAPE, JsonSerializer EPPBECKMJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B18240", Offset = "0x7B17440", VA = "0x187B18240", Slot = "10")]
		public override CAPBBOECDPO ReadJson(JsonReader GBOEOLHFKIL, Type BIAABFFGEBE, CAPBBOECDPO? PHPPMNEGCNI, bool EBHEGKINMBG, JsonSerializer EPPBECKMJNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B18400", Offset = "0x7B17600", VA = "0x187B18400")]
		public JMNMAPOFPNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class LLNJPLHGHJB : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool IMKONJGLLEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B18820", Offset = "0x7B17A20", VA = "0x187B18820", Slot = "5")]
		public override object ReadJson(JsonReader GBOEOLHFKIL, Type BIAABFFGEBE, object? PHPPMNEGCNI, JsonSerializer EPPBECKMJNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B18440", Offset = "0x7B17640", VA = "0x187B18440", Slot = "6")]
		public override bool CanConvert(Type BIAABFFGEBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B18880", Offset = "0x7B17A80", VA = "0x187B18880", Slot = "4")]
		public override void WriteJson(JsonWriter HLPFOKGJOHH, object? KJIOHKMJAPE, JsonSerializer EPPBECKMJNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7B18620", Offset = "0x7B17820", VA = "0x187B18620")]
		private static bool DCGHNLJCEEN(object KJIOHKMJAPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public LLNJPLHGHJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings JMMIIAOFEBJ;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B10390", Offset = "0x7B0F590", VA = "0x187B10390")]
	internal ADKGJPJLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2F987E0", Offset = "0x2F979E0", VA = "0x182F987E0", Slot = "4")]
	public string PMJJECGGNIF<T>(T KFMNDOMPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2F98760", Offset = "0x2F97960", VA = "0x182F98760", Slot = "5")]
	public T DIJFLIAJHKP<T>(string KJIOHKMJAPE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class LPNOFGABCLI : EEGLJJGAEEM
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFC10", Offset = "0x3ACEE10", VA = "0x183ACFC10", Slot = "4")]
	public string PMJJECGGNIF<T>(T KFMNDOMPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFBB0", Offset = "0x3ACEDB0", VA = "0x183ACFBB0", Slot = "5")]
	public T DIJFLIAJHKP<T>(string KJIOHKMJAPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LPNOFGABCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CBAABKHKLJM]
internal class PHEMOGKKDFF : JJGCKDKBCDL<JLPCKEGOIAJ, FEAFBJCHPOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly EEGLJJGAEEM CKIKCEIELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly AOEMIOEJPMI BBINOBLDFML;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B840", Offset = "0x7B1AA40", VA = "0x187B1B840")]
	public PHEMOGKKDFF(EEGLJJGAEEM CKIKCEIELGN, AOEMIOEJPMI BBINOBLDFML, LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7B19930", Offset = "0x7B18B30", VA = "0x187B19930", Slot = "6")]
	public override FEAFBJCHPOI BHIBMPPAILM(JLPCKEGOIAJ GLMNBNPBGCG, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A370", Offset = "0x7B19570", VA = "0x187B1A370")]
	internal void KHEEMKCMMIE(string EGEHHMMBOBI, MLFDDOBOAFD NMNBELDFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7B19880", Offset = "0x7B18A80", VA = "0x187B19880")]
	public IEnumerable<NGOLNHHLKLE> AFAALHLAFMC(string IANBGHHGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7B19D50", Offset = "0x7B18F50", VA = "0x187B19D50")]
	private IEnumerable<NGOLNHHLKLE> ECPKKBKBNPI(string IANBGHHGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A4D0", Offset = "0x7B196D0", VA = "0x187B1A4D0")]
	internal IEnumerable<NGOLNHHLKLE> KNNNKAGHLHI(string IANBGHHGKEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B4C0", Offset = "0x7B1A6C0", VA = "0x187B1B4C0")]
	private NGOLNHHLKLE POADOJFGBJB(AvatarOutfitSelectionData GPADBENLEJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A920", Offset = "0x7B19B20", VA = "0x187B1A920")]
	private void MPCEDMNDIFF(AvatarCustomizationSettingsData APHAOPDOELB, MLFDDOBOAFD NMNBELDFILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B1A0", Offset = "0x7B1A3A0", VA = "0x187B1B1A0")]
	private NGOLNHHLKLE POADOJFGBJB(string IPJHGOMDKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7B19580", Offset = "0x7B18780", VA = "0x187B19580")]
	internal static (IMAHPAJHFNK, string, string) AEHONJMFEKE(string IPJHGOMDKCM, LKKACGOMJHM AEMENHIGDPD)
	{
		return default((IMAHPAJHFNK, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A170", Offset = "0x7B19370", VA = "0x187B1A170")]
	private GAOHINJEOHD? HDBHLDGLJBK(string? DJOIAEMCFDK, Vector2 BLJIKHPALFC, float ILMGNKKCLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7B19420", Offset = "0x7B18620", VA = "0x187B19420")]
	private static BCHLBCJFNPL ABFDKOOPNGK(AvatarCustomizationSettingsData.AnchorParams EDMINDCIDKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CBAABKHKLJM]
internal class BGMPKDOFGFM : IIINNAPCHGK, GHPOIJDOMHA
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7B134D0", Offset = "0x7B126D0", VA = "0x187B134D0")]
	public BGMPKDOFGFM(EEGLJJGAEEM CKIKCEIELGN, AOEMIOEJPMI BBINOBLDFML, LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7B12DE0", Offset = "0x7B11FE0", VA = "0x187B12DE0", Slot = "4")]
	public MOGBPGICBFB ELKKKBEIKKA(MLFDDOBOAFD CAIGHLKIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7B133D0", Offset = "0x7B125D0", VA = "0x187B133D0")]
	private string MHPLAIELGID(MLFDDOBOAFD NMNBELDFILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7B13190", Offset = "0x7B12390", VA = "0x187B13190")]
	private string FKCFHCCNINB(NGOLNHHLKLE BGPAAGKJDNA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CBAABKHKLJM]
internal class ENKEDDJJCFP : JJGCKDKBCDL<JLPCKEGOIAJ, FEAFBJCHPOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly EEGLJJGAEEM CKIKCEIELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GKFGGKJEHMF<JLPCKEGOIAJ, FEAFBJCHPOI> JIHMNBKHGCK;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7B15E40", Offset = "0x7B15040", VA = "0x187B15E40")]
	public ENKEDDJJCFP(GKFGGKJEHMF<JLPCKEGOIAJ, FEAFBJCHPOI> JIHMNBKHGCK, LKKACGOMJHM AEMENHIGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7B15A10", Offset = "0x7B14C10", VA = "0x187B15A10", Slot = "6")]
	public override FEAFBJCHPOI BHIBMPPAILM(JLPCKEGOIAJ GLMNBNPBGCG, [Out] IReadOnlyList<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CBAABKHKLJM]
internal class APILNBPOPGE : PDBDNDMDKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly EEGLJJGAEEM CKIKCEIELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly GHPOIJDOMHA PPNJKIOKICN;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7B10E60", Offset = "0x7B10060", VA = "0x187B10E60")]
	public APILNBPOPGE(GHPOIJDOMHA PPNJKIOKICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7B10AC0", Offset = "0x7B0FCC0", VA = "0x187B10AC0", Slot = "4")]
	public JLPCKEGOIAJ ELKKKBEIKKA(MLFDDOBOAFD CAIGHLKIDBF, int JDNOBKHDIMM, string? GBOCGPJOEEK, string? BKGLFCFLEBM, MDCHAHHDJEP EICMAJILGBG, List<PGKCIHNBJDG>? KCLJCNKKKGJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B11000", Offset = "0x7B10200", VA = "0x187B11000")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OCAANKKAFGP
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7B19190", Offset = "0x7B18390", VA = "0x187B19190")]
	public static GHAADPGGCEA BHIBMPPAILM(this AIAKEDMMLIG CAIGHLKIDBF)
	{
		return default(GHAADPGGCEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7B192A0", Offset = "0x7B184A0", VA = "0x187B192A0")]
	public static AIAKEDMMLIG ELKKKBEIKKA(this GHAADPGGCEA INNHHLMODJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B193C0", Offset = "0x7B185C0", VA = "0x187B193C0")]
	public static bool KPGCHNPNDEJ(this GHAADPGGCEA INNHHLMODJH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x5CDBAB0", Offset = "0x5CDACB0", VA = "0x185CDBAB0")]
			public AnchorParams(Vector2 MNMPKCJNOEM, Vector3 IPHPPCCFNIA, Vector3 JCCDMMGBJOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B10F50", Offset = "0x7B10150", VA = "0x187B10F50")]
			internal BCHLBCJFNPL ELKKKBEIKKA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private DDKMPEMLOPH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7B117F0", Offset = "0x7B109F0", VA = "0x187B117F0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x422F0F0", Offset = "0x422E2F0", VA = "0x18422F0F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xD12D40", Offset = "0xD11F40", VA = "0x180D12D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xEE8830", Offset = "0xEE7A30", VA = "0x180EE8830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x13D2FC0", Offset = "0x13D21C0", VA = "0x1813D2FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7B11890", Offset = "0x7B10A90", VA = "0x187B11890")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA00F80", Offset = "0xA00180", VA = "0x180A00F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC56110", Offset = "0xC55310", VA = "0x180C56110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xC56490", Offset = "0xC55690", VA = "0x180C56490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3D0", Offset = "0xA0C5D0", VA = "0x180A0D3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7B118D0", Offset = "0x7B10AD0", VA = "0x187B118D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xE9FAB0", Offset = "0xE9ECB0", VA = "0x180E9FAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x1105650", Offset = "0x1104850", VA = "0x181105650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1871790", Offset = "0x1870990", VA = "0x181871790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA00390", Offset = "0x9FF590", VA = "0x180A00390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA003A0", Offset = "0x9FF5A0", VA = "0x180A003A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x239FA20", Offset = "0x239EC20", VA = "0x18239FA20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xED09E0", Offset = "0xECFBE0", VA = "0x180ED09E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA38230", Offset = "0xA37430", VA = "0x180A38230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA38290", Offset = "0xA37490", VA = "0x180A38290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA0E420", Offset = "0xA0D620", VA = "0x180A0E420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA0E4E0", Offset = "0xA0D6E0", VA = "0x180A0E4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA0E4A0", Offset = "0xA0D6A0", VA = "0x180A0E4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA0E3C0", Offset = "0xA0D5C0", VA = "0x180A0E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA0E520", Offset = "0xA0D720", VA = "0x180A0E520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA0E400", Offset = "0xA0D600", VA = "0x180A0E400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xC50C10", Offset = "0xC4FE10", VA = "0x180C50C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x13DDAA0", Offset = "0x13DCCA0", VA = "0x1813DDAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA0E550", Offset = "0xA0D750", VA = "0x180A0E550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA0E470", Offset = "0xA0D670", VA = "0x180A0E470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xD54F00", Offset = "0xD54100", VA = "0x180D54F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xEBEEA0", Offset = "0xEBE0A0", VA = "0x180EBEEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA07240", Offset = "0xA06440", VA = "0x180A07240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA071B0", Offset = "0xA063B0", VA = "0x180A071B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xDC9B70", Offset = "0xDC8D70", VA = "0x180DC9B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xECEDD0", Offset = "0xECDFD0", VA = "0x180ECEDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCD33F0", Offset = "0xCD25F0", VA = "0x180CD33F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xCCF9E0", Offset = "0xCCEBE0", VA = "0x180CCF9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public DDKMPEMLOPH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF52070", Offset = "0xF51270", VA = "0x180F52070")]
			get
			{
				return default(DDKMPEMLOPH);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF53590", Offset = "0xF52790", VA = "0x180F53590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xF538C0", Offset = "0xF52AC0", VA = "0x180F538C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC36160", Offset = "0xC35360", VA = "0x180C36160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7B118B0", Offset = "0x7B10AB0", VA = "0x187B118B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B118F0", Offset = "0x7B10AF0", VA = "0x187B118F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B11490", Offset = "0x7B10690", VA = "0x187B11490")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public IMAHPAJHFNK BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private LCMLGAJHMHG? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B11910", Offset = "0x7B10B10", VA = "0x187B11910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public AvatarUgcOutfitData()
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
