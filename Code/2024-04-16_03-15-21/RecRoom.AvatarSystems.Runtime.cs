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
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6030220", Offset = "0x602F420", VA = "0x186030220")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[PAAFOJGLPBB]
internal class NBGDHOJKMBP : KLPDOPKPHKI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct MHOOFFDEKCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public NBGDHOJKMBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JHFENCGDOHE avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IJHOBEJCDGC DLFOMAGDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NDABKPBEJLD JLBIEFEOAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NDKCHNAFIBD IDJPINAMFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MLDLNFLHFKF OHHJNPMFIEC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x602E580", Offset = "0x602D780", VA = "0x18602E580")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	[UsedImplicitly]
	private static void AIPJNGEJALE(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x602FDE0", Offset = "0x602EFE0", VA = "0x18602FDE0")]
	[Preserve]
	internal NBGDHOJKMBP([MINIJLJAKNC(null)] IJHOBEJCDGC DLFOMAGDDOL, [MINIJLJAKNC(null)] NDABKPBEJLD JLBIEFEOAHD, [MINIJLJAKNC(null)] NDKCHNAFIBD IDJPINAMFAM, [MINIJLJAKNC(null)] MLDLNFLHFKF OHHJNPMFIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x602E5F0", Offset = "0x602D7F0", VA = "0x18602E5F0", Slot = "5")]
	public COCGFAABOCL ANJKMCLPOBA(bool JAAFIEKCIBD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x602EE30", Offset = "0x602E030", VA = "0x18602EE30", Slot = "4")]
	public COCGFAABOCL EMMKGGEFHKO(bool JAAFIEKCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x602ED20", Offset = "0x602DF20", VA = "0x18602ED20", Slot = "6")]
	public DIAHKBOPENA EDFAPBOABIH(COCGFAABOCL MJGHOBDIDHD, int JAHEMDLBNNH, string? MPENHPFDCDK, string? OOJIPCFEOEI, OIILNFAJHOF DPHCJMIHJPA, List<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x602FD50", Offset = "0x602EF50", VA = "0x18602FD50", Slot = "7")]
	public bool OLMLMLNJEDB(BHONFEMDFPM MPFJIKIGBLJ, [Out] COCGFAABOCL? KGHNHOEHCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x602F770", Offset = "0x602E970", VA = "0x18602F770", Slot = "8")]
	public bool HIOJCMCLNCN(DIAHKBOPENA BBKENDFLMFJ, [Out] COCGFAABOCL? KGHNHOEHCKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x602FCC0", Offset = "0x602EEC0", VA = "0x18602FCC0", Slot = "9")]
	public bool OBJJBMGLLPA(DIAHKBOPENA BBKENDFLMFJ, [Out] IKJNEDKDEAI? MPFJIKIGBLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29C22D0", Offset = "0x29C14D0", VA = "0x1829C22D0")]
	private bool BEOJPFNHOHB<TInput, TOutput>(TInput BHCBEHDFPNA, HAMNMOHMKBF<TInput, TOutput> JNICIOEABEN, [Out] TOutput? IFJGEIAONPI) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x602FB20", Offset = "0x602ED20", VA = "0x18602FB20")]
	[CompilerGenerated]
	private AOAHMBCCJEO KCAOEPEDCDE(FaceFeatureType IBKCBKMLPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x602F850", Offset = "0x602EA50", VA = "0x18602F850")]
	[CompilerGenerated]
	private AOAHMBCCJEO JOAJHAEPNMM(FaceFeatureType IBKCBKMLPGC, MHOOFFDEKCM P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PAAFOJGLPBB]
internal class DGAPCPGMFOC : IJHOBEJCDGC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void NNMGLCEHMDN<in TData>(TData KGHNHOEHCKK, IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NDKCHNAFIBD IDJPINAMFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EHOGINAOANG BNDOEFHACCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NNMGLCEHMDN<COCGFAABOCL>?[] DLFOMAGDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NNMGLCEHMDN<IKJNEDKDEAI>?[] NFABJMGGKHO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6029710", Offset = "0x6028910", VA = "0x186029710")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	[UsedImplicitly]
	private static void AIPJNGEJALE(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x602A640", Offset = "0x6029840", VA = "0x18602A640")]
	[Preserve]
	internal DGAPCPGMFOC([MINIJLJAKNC(null)] NDKCHNAFIBD IDJPINAMFAM, [MINIJLJAKNC(null)] EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60299B0", Offset = "0x6028BB0", VA = "0x1860299B0", Slot = "4")]
	public bool IKPHAGJDGJE(COCGFAABOCL KGHNHOEHCKK, IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6029AB0", Offset = "0x6028CB0", VA = "0x186029AB0", Slot = "5")]
	public bool IKPHAGJDGJE(IKJNEDKDEAI MPFJIKIGBLJ, IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6029C10", Offset = "0x6028E10", VA = "0x186029C10")]
	private void MPJOKIKBLKB(COCGFAABOCL KGHNHOEHCKK, IReadOnlyList<GGJGHOJGBDF>? KCEAHMBEPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6029780", Offset = "0x6028980", VA = "0x186029780")]
	private void CPNBMNNFALE(COCGFAABOCL KGHNHOEHCKK, IReadOnlyList<GGJGHOJGBDF>? KCEAHMBEPHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IJHOBEJCDGC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKPHAGJDGJE(COCGFAABOCL KGHNHOEHCKK, IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IKPHAGJDGJE(IKJNEDKDEAI MPFJIKIGBLJ, IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, PLJPJOIEJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Vector3? BJDLPKLCAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool LIDNINGHMIE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6013CB0", Offset = "0x6012EB0", VA = "0x186013CB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60142A0", Offset = "0x60134A0", VA = "0x1860142A0", Slot = "4")]
		public void UpdateController(float PJADGMHMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6D40", Offset = "0xCE5F40", VA = "0x180CE6D40", Slot = "6")]
		public void SetEnabled(bool EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6013D50", Offset = "0x6012F50", VA = "0x186013D50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60146C0", Offset = "0x60138C0", VA = "0x1860146C0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, PLJPJOIEJMK
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const float CMOMIFLAFIF = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Vector3 KGCOEJBAPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 LHBACKNAPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool LIDNINGHMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float GPJJMCEIKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float BKMLELADHIN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6014A40", Offset = "0x6013C40", VA = "0x186014A40", Slot = "4")]
		public void UpdateController(float PJADGMHMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA2A260", Offset = "0xA29460", VA = "0x180A2A260", Slot = "6")]
		public void SetEnabled(bool EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6014760", Offset = "0x6013960", VA = "0x186014760")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6015420", Offset = "0x6014620", VA = "0x186015420")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6015D30", Offset = "0x6014F30", VA = "0x186015D30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6015CF0", Offset = "0x6014EF0", VA = "0x186015CF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6015450", Offset = "0x6014650", VA = "0x186015450")]
		private void AAGLGIMOIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1176230", Offset = "0x1175430", VA = "0x181176230", Slot = "4")]
		public void SetEnabled(bool KIOKGDOKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6015D60", Offset = "0x6014F60", VA = "0x186015D60")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarForearmRollController : MonoBehaviour, PLJPJOIEJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool LIDNINGHMIE;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6015DA0", Offset = "0x6014FA0", VA = "0x186015DA0", Slot = "4")]
		public void UpdateController(float PJADGMHMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C60D0", Offset = "0x7C52D0", VA = "0x1807C60D0", Slot = "6")]
		public void SetEnabled(bool EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6016510", Offset = "0x6015710", VA = "0x186016510")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, BCBKMFCPNND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[PCEENEOFAOO(DGCAKKBAIEP.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private EFMFEGLEECB NJHCIMFIDFK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EFMFEGLEECB FMNOFIDGJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6017300", Offset = "0x6016500", VA = "0x186017300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform OIPIBFGMDPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6017340", Offset = "0x6016540", VA = "0x186017340", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60165D0", Offset = "0x60157D0", VA = "0x1860165D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60171C0", Offset = "0x60163C0", VA = "0x1860171C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6017170", Offset = "0x6016370", VA = "0x186017170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6017100", Offset = "0x6016300", VA = "0x186017100")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6016A40", Offset = "0x6015C40", VA = "0x186016A40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6017100", Offset = "0x6016300", VA = "0x186017100", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6016650", Offset = "0x6015850", VA = "0x186016650", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6017210", Offset = "0x6016410", VA = "0x186017210", Slot = "8")]
		public void UpdatePostIKAnimControllers(float PJADGMHMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6016540", Offset = "0x6015740", VA = "0x186016540")]
		private void AMADANKHOGL(GameObject GLMGCMELGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6016AC0", Offset = "0x6015CC0", VA = "0x186016AC0")]
		private EFMFEGLEECB OLHJMAHHAKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct WeightData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6030420", Offset = "0x602F620", VA = "0x186030420")]
			public float GPMPKACLGAA(float EPPJDDIOKNO, float ANNIHJNBLEK)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		[Space]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E5")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		[Header("VR runtime weights")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6017360", Offset = "0x6016560", VA = "0x186017360")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EKKMBCHBMDP : NJIDIBONBOI
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static int AKILFLHPNFI;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int KCFBCMHDCPL;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int INKGDKAGLFN;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int BEONOOCDEFK;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int PHNHIEFMNJC;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static int HGGLGIKIGJB;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int ELOCGPFMBBF;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int DPEPNPOIJFK;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int JPEGDOKNPMD;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int[] BLJGIPJEKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private EENINMFPKND MNAJHEBEOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int PMAJEDDLIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private float NEJOGOHCLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool IMMJMAPODME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Animator IKEKOLJNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AvatarFullBodyConfiguration LHJBHKNBPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int OIGBOIENJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private int JPOGOPKCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private int PJOELAOCKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool BAKINLKNLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IDMAOGIEMDD KFGIHBCJDDN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DKKCJDCNCOL ILHCHPKKHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD20B80", Offset = "0xD1FD80", VA = "0x180D20B80", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(DKKCJDCNCOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD1F850", Offset = "0xD1EA50", VA = "0x180D1F850", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DKKCJDCNCOL CKGJKJPABCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87F720", Offset = "0x87E920", VA = "0x18087F720", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(DKKCJDCNCOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB25F50", Offset = "0xB25150", VA = "0x180B25F50", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public float LHJJOPCPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7CF460", Offset = "0x7CE660", VA = "0x1807CF460", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x13F2BD0", Offset = "0x13F1DD0", VA = "0x1813F2BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CBNEEFDHBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x602CC10", Offset = "0x602BE10", VA = "0x18602CC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PKGNNJJHLIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x602C8E0", Offset = "0x602BAE0", VA = "0x18602C8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KCAPIBDIOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x602C560", Offset = "0x602B760", VA = "0x18602C560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x602C8F0", Offset = "0x602BAF0", VA = "0x18602C8F0", Slot = "18")]
	public void MEJEOBIHPJE(EENINMFPKND PEAHAELKEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x602CC00", Offset = "0x602BE00", VA = "0x18602CC00", Slot = "19")]
	public void NAOGDFAJOGF(GGLIJDJHOLD KOODNDJJFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x602C570", Offset = "0x602B770", VA = "0x18602C570", Slot = "11")]
	public void IFMBPHCDIAB(bool CCMFFLCDHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x602C600", Offset = "0x602B800", VA = "0x18602C600", Slot = "10")]
	public void JMCGHIHKHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x602CAB0", Offset = "0x602BCB0", VA = "0x18602CAB0")]
	private int MPAAPINHKFJ(DKKCJDCNCOL NFNKFMHGAOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x602C430", Offset = "0x602B630", VA = "0x18602C430")]
	private void ELEAGEICELI(int NDCJPBDNIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x602C420", Offset = "0x602B620", VA = "0x18602C420", Slot = "12")]
	public bool EDGCNHMLDLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x602CC20", Offset = "0x602BE20", VA = "0x18602CC20", Slot = "13")]
	public bool PPHIDHLLOCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x602C3E0", Offset = "0x602B5E0", VA = "0x18602C3E0")]
	private DKKCJDCNCOL AFCBHKAKDIH()
	{
		return default(DKKCJDCNCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xC810A0", Offset = "0xC802A0", VA = "0x180C810A0", Slot = "14")]
	public void CFMBCPCNGJB(bool CCMFFLCDHGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x602C8B0", Offset = "0x602BAB0", VA = "0x18602C8B0", Slot = "9")]
	public void KICDPMKDFOI(int NDCJPBDNIEJ, float NKEILBODOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x602C8C0", Offset = "0x602BAC0", VA = "0x18602C8C0", Slot = "7")]
	public void LLOAFNAPFBI(IDMAOGIEMDD GAEMKAANAID, bool IKGCBKDCEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x602C8A0", Offset = "0x602BAA0", VA = "0x18602C8A0", Slot = "8")]
	public void JNBKGJGGCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x602CF10", Offset = "0x602C110", VA = "0x18602CF10")]
	public EKKMBCHBMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class COCJJPDDLIA : EFMFEGLEECB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class EOIKLLBKALA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private float PKJKDBDJMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Vector3 PAGBFHLJEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private bool AIFFLIGJEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private float OGOIOPHNMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool ELKIJEBKKHP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool CMMLOCKDHBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x602D390", Offset = "0x602C590", VA = "0x18602D390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x602D750", Offset = "0x602C950", VA = "0x18602D750")]
		public void NELCKFOLEAF(IKSolverVR.Arm FKNGHEDHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x602D170", Offset = "0x602C370", VA = "0x18602D170")]
		public void HFBOPBPPPMO(IKSolverVR.Arm FKNGHEDHECI, Transform OELCKJMHMPD, bool BGNDJPBPFIN, AvatarFullBodyConfiguration JDOEDLEPGFL, float PDMMEHHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x602D7C0", Offset = "0x602C9C0", VA = "0x18602D7C0")]
		public void PLIOLOAIJLH(IKSolverVR.Arm FKNGHEDHECI, bool LDCBPLEHPLM, bool ELKIJEBKKHP, AvatarFullBodyConfiguration JDOEDLEPGFL, float PDMMEHHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x602D3B0", Offset = "0x602C5B0", VA = "0x18602D3B0")]
		private void HODLBEPMOOP(Transform OELCKJMHMPD, IKSolverVR.Arm FKNGHEDHECI, float OPEPPLLMILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x602D530", Offset = "0x602C730", VA = "0x18602D530")]
		private void JDGBGOKJNMA(bool BGNDJPBPFIN, AvatarFullBodyConfiguration JDOEDLEPGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x602CF20", Offset = "0x602C120", VA = "0x18602CF20")]
		private void BGFBNKPEPLJ(AvatarFullBodyConfiguration JDOEDLEPGFL, float PDMMEHHMHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x602D780", Offset = "0x602C980", VA = "0x18602D780")]
		private void OFDFHIANIHO(IKSolverVR.Arm FKNGHEDHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x602CFB0", Offset = "0x602C1B0", VA = "0x18602CFB0")]
		public void BMBLMADFLKP(IKSolverVR.Arm FKNGHEDHECI, Transform ACBDOBFGPGL, Transform HDFNLMEAFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x602D4A0", Offset = "0x602C6A0", VA = "0x18602D4A0")]
		private static float IHMFCJEEBLA(bool KIOKGDOKJKG, float EBJNEJIIOMI, float LMFENEGHBGP, float HPDIPJAMBAA, float PDMMEHHMHAK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x602D5A0", Offset = "0x602C7A0", VA = "0x18602D5A0")]
		private static void MALCCOLLACG(Transform GMNHNCNNDFI, Transform GIFFOJFPOJN, Transform CEBEBLJOGPJ, float IMPAIOGPAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public EOIKLLBKALA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum IOFOBJEELFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum MGOPIEGFJBM
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int CJIPLKHMFPN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int FEEFKEJDNKE;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int OPJOOCJFKAN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int DBPDGJEEPHB;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int AKKPOIACIFN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int EDFEBICOBCI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int JDLHGJKPOKB;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int EIEIHKAOOHG;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int OKHLHIEDEEI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HCNKBFAGBOJ;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int GJOLHAOAKDM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int AGOBBOOEGAB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int DPPPIEFMLAG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int LGIKGFGDJIE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int JNJBECLJHPB;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int CMJJFPMIIOB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int FPPBPNMIGOP;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int HJICBNJHLOH;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int IMFLEADDGFF;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int IJGDCJBFEML;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int JEBLJLLKPMD;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int ANOJKLLKFGB;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int AJKFJHAHMJL;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int GPDGLKCCGPB;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int PNKOBDHPENB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int LHCGCPKCMKN;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int ELIKCNFLLCK;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int OMOEEAAAFPN;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int ECAIOJIHACM;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int KHPHKJMCNOL;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 KHDEINKOGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool PFLIDPMDBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool DPGMKAJGGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool GHLMGIFLELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool BMFIPEFJLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private bool EMICAEPOBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Vector3 INJHIEHDDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MFGGFOFOHEO? MNAJHEBEOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private CHBALIPKHIK? EKFFMBHNMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private LIKLEHBMECP NIDFBIHDKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private HMJLCCPCBDP BOILBNKJGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private EKKMBCHBMDP PALDGLKMPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private EKKMBCHBMDP OOGJMICNCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool MKLADICNHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool OAFIGKOEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly CDJBFLIDAKJ OEAFFDNNAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly LAAKFPPBFLH EBHCEOFLKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private int PJBCHDIDGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private float GPDBHJIDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GameObject JCJKAFBJCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform AOPJKHNAOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform ABBLICMPDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float GALHFBGFDEA;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker MIKPJGGGGML;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker LPGDIBGCPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker MKEGCKLFHDA;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker KMCEPKJAGKM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker BNGBHONEHPG;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker AEEDFHOMAGF;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<COCJJPDDLIA> ENFOLOOPKJK;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int HKEINONHMGD;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EOGEJALFBHN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int EOKMGPLGJJM;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int LNPDPNJEDMB;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int JFCBOMBEDFC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int JKEPHLLANOB;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float KJILCFPJEKI;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int CLFFENPIANE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float GEMANGJFANJ;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float MJGLGJCIAKP;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float IHKLKCDAJHO;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float FHBBOAPGJMK;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static HCECFCHPDLG GBCJPKCBBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float PIJFEIPKHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool BEHEGCPMJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float BDEEOEJFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private EOIKLLBKALA FDMFDKCNPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private EOIKLLBKALA CCMFHNCKEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private IOFOBJEELFO NGMGDCFCKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private float FFCFENNCBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HLDHHKJBJPN JEEFBNLAALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private float ADPNBJHONDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float OHKFMGNNNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private Vector3 FOAJEEDEGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly JIOEDMMEFFP AKONIGAHNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PAKDADMCJKC NKENCGADACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private float FIFOPLLJJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private IOFOBJEELFO BAELMCNPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private Vector3 CPHMCMJMNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float EHDMBLHDAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private float JAFICPLCGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FONDAGAOKCG OJGGNLDMJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private JIOEDMMEFFP EJKDOBFAIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly JIOEDMMEFFP AAPHDDOAKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly FONDAGAOKCG FOGCFMOLDCA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DPAIEAIPOBP IPKJJLIEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DPAIEAIPOBP GLKEOGMFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AvatarConfiguration OFPBEIMJBDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6022BA0", Offset = "0x6021DA0", VA = "0x186022BA0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AvatarFullBodyConfiguration NOIMFIGOKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6025630", Offset = "0x6024830", VA = "0x186025630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Transform JNGIADPJNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6020E00", Offset = "0x6020000", VA = "0x186020E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Transform EKCGFIAPGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x601CBC0", Offset = "0x601BDC0", VA = "0x18601CBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private SkinnedMeshRenderer FFKHKPKEDGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x601D6D0", Offset = "0x601C8D0", VA = "0x18601D6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Renderer[] OADJFPJKKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60263A0", Offset = "0x60255A0", VA = "0x1860263A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private GameObject[] HOFAFJIFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x601FDD0", Offset = "0x601EFD0", VA = "0x18601FDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Animator PKGACEPHJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x601C0B0", Offset = "0x601B2B0", VA = "0x18601C0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private VRIK ALGAACDJCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x601A460", Offset = "0x6019660", VA = "0x18601A460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private PLJPJOIEJMK GFMCKOCMANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6028990", Offset = "0x6027B90", VA = "0x186028990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private PLJPJOIEJMK KHFDEMGDCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60279C0", Offset = "0x6026BC0", VA = "0x1860279C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private PLJPJOIEJMK EHLEHDJKAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x601F060", Offset = "0x601E260", VA = "0x18601F060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private PLJPJOIEJMK ILAAAJKKCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x601EB20", Offset = "0x601DD20", VA = "0x18601EB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private PLJPJOIEJMK CNIPGEPILKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60253D0", Offset = "0x60245D0", VA = "0x1860253D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private PLJPJOIEJMK GAHNAGEFFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6018DC0", Offset = "0x6017FC0", VA = "0x186018DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private PLJPJOIEJMK JFFFEKEDGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x601A530", Offset = "0x6019730", VA = "0x18601A530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private PLJPJOIEJMK JCPBFIGMLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6024DB0", Offset = "0x6023FB0", VA = "0x186024DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CHBALIPKHIK LCCJMCFHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6025500", Offset = "0x6024700", VA = "0x186025500", Slot = "29")]
		get
		{
			return default(CHBALIPKHIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NPFDDHCGFMC PFACNMAHAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8170", Offset = "0x8B7370", VA = "0x1808B8170", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICINPJGBCED AHHELLCKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA379A0", Offset = "0xA36BA0", VA = "0x180A379A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NJIDIBONBOI KLECPPGLCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDA0BC0", Offset = "0xD9FDC0", VA = "0x180DA0BC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public NJIDIBONBOI PEKIONMMAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC10", Offset = "0xA3CE10", VA = "0x180A3DC10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GameObject CHIOFKOKCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60282D0", Offset = "0x60274D0", VA = "0x1860282D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Transform IFLNMGHIKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1CE30", Offset = "0xA1C030", VA = "0x180A1CE30", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Transform FEKGAHFEOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A7E70", Offset = "0x9A7070", VA = "0x1809A7E70", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform LHKOIDDGAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6028A60", Offset = "0x6027C60", VA = "0x186028A60", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BPCLKOKDLNO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60254A0", Offset = "0x60246A0", VA = "0x1860254A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool DOFAJKEMOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x601D7A0", Offset = "0x601C9A0", VA = "0x18601D7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x601A950", Offset = "0x6019B50", VA = "0x18601A950")]
	private void COBMKHFAFNH([In] OBKLBKMLDBK ABKJGDDDGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60230F0", Offset = "0x60222F0", VA = "0x1860230F0")]
	private void KPKNAPCOFAN(OBKLBKMLDBK ABKJGDDDGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6022A10", Offset = "0x6021C10", VA = "0x186022A10")]
	private void JMCGHIHKHLD(BNMHJPKGMFH IILPIPLNBEF, NJIDIBONBOI PDFMCGBEPBN, IKSolverVR.Arm FKNGHEDHECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x601C940", Offset = "0x601BB40", VA = "0x18601C940")]
	private void DPCBACFONEG([In] OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6029310", Offset = "0x6028510", VA = "0x186029310")]
	public COCJJPDDLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x601EBF0", Offset = "0x601DDF0", VA = "0x18601EBF0", Slot = "11")]
	public void GIJAMKLAIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60250F0", Offset = "0x60242F0", VA = "0x1860250F0", Slot = "12")]
	public void MMFGDDDBCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60274B0", Offset = "0x60266B0", VA = "0x1860274B0", Slot = "13")]
	public void OENNIIDGNAL(bool HOKGLCHOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x601D380", Offset = "0x601C580", VA = "0x18601D380", Slot = "21")]
	public Transform EGDEINKMFFB(string OLOFMGICJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6021680", Offset = "0x6020880", VA = "0x186021680", Slot = "22")]
	public Vector3? IPNDCFGMLJH(string OLOFMGICJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60264F0", Offset = "0x60256F0", VA = "0x1860264F0", Slot = "6")]
	public void ODLPHKIECGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6021610", Offset = "0x6020810", VA = "0x186021610", Slot = "7")]
	public void INIHEAIPEML(float BBFEENEAMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6018FC0", Offset = "0x60181C0", VA = "0x186018FC0")]
	private void AODFNKHHIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6023340", Offset = "0x6022540", VA = "0x186023340", Slot = "4")]
	public void LBHCILFHOMP(MFGGFOFOHEO PJFKIEBHMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6027580", Offset = "0x6026780", VA = "0x186027580", Slot = "5")]
	public void OFBJPHIGJHH(CHBALIPKHIK KOODNDJJFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6025EC0", Offset = "0x60250C0", VA = "0x186025EC0", Slot = "10")]
	public void NGGANGKMECE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6019210", Offset = "0x6018410", VA = "0x186019210", Slot = "20")]
	public void BMJLPNCNALO([Out] Vector3 MDHNNFCBLGK, [Out] Quaternion JGKHMBOABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6025070", Offset = "0x6024270", VA = "0x186025070", Slot = "23")]
	public void MEOILFDLPFL(float IKIDPDHLLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x601D4D0", Offset = "0x601C6D0", VA = "0x18601D4D0", Slot = "24")]
	public HandLogicOffsets EKMAPMGNMME()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6019010", Offset = "0x6018210", VA = "0x186019010", Slot = "25")]
	public PlatformSpecificPlayerHandOffsets BJCANBFMMHD()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x601F130", Offset = "0x601E330", VA = "0x18601F130")]
	private void GOLOFJJNDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6025FB0", Offset = "0x60251B0", VA = "0x186025FB0")]
	private void NHAMFBIIEOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x601C180", Offset = "0x601B380", VA = "0x18601C180")]
	private void DKPIHANJCHE(POKMEHNCJBC OKGALJIINPP, bool DJPOIHCPABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x601A2D0", Offset = "0x60194D0", VA = "0x18601A2D0")]
	private void CBIEHPOBMJL(POKMEHNCJBC OKGALJIINPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x601F1F0", Offset = "0x601E3F0", VA = "0x18601F1F0")]
	public Vector3 HCKKOLGOGLO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x601D660", Offset = "0x601C860", VA = "0x18601D660")]
	private void ELMMBLCNGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60231A0", Offset = "0x60223A0", VA = "0x1860231A0")]
	private float LANNCNIOHBE([In] OBKLBKMLDBK GAEMKAANAID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x601D580", Offset = "0x601C780", VA = "0x18601D580")]
	private int ELJCHIFLONE([In] GFKLOKHJCAC EAFBHKAIBPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x601FEA0", Offset = "0x601F0A0", VA = "0x18601FEA0")]
	private void HOPCGHJKEDG(OBKLBKMLDBK ABKJGDDDGLF, bool LIAICCNFJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x601C740", Offset = "0x601B940", VA = "0x18601C740")]
	private static void DLMOCPKKDBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x601F240", Offset = "0x601E440", VA = "0x18601F240")]
	private static void HEINMDMPHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60195B0", Offset = "0x60187B0", VA = "0x1860195B0")]
	private float BOFMLLDBBBJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6018F90", Offset = "0x6018190", VA = "0x186018F90")]
	private static int ANHHOHJDIDN(COCJJPDDLIA EAIBKNOIIGG, COCJJPDDLIA PKGAILNKPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x60203D0", Offset = "0x601F5D0", VA = "0x1860203D0")]
	private void IAIFPAIJBGP(OBKLBKMLDBK GAEMKAANAID, AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60190D0", Offset = "0x60182D0", VA = "0x1860190D0")]
	private void BMBLMADFLKP([In] OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x601D820", Offset = "0x601CA20", VA = "0x18601D820")]
	private void FLMJJLJAJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6024E80", Offset = "0x6024080", VA = "0x186024E80")]
	private void LMDOILAKCDJ([In] OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xD561C0", Offset = "0xD553C0", VA = "0x180D561C0")]
	private void HHCLDPHFNKK(RigidbodyEx ABDBIOADINA, Transform CHPEDBJFONI, Transform KEPLLEJFIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6026470", Offset = "0x6025670", VA = "0x186026470")]
	private float NLKPHBLKIOI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6028370", Offset = "0x6027570", VA = "0x186028370")]
	private void PFGDEEDHGOM([In] OBKLBKMLDBK GAEMKAANAID, [In] MGOPIEGFJBM JOJAMKDOBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x601A600", Offset = "0x6019800", VA = "0x18601A600")]
	private void CLJICPMNMFP(OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60230D0", Offset = "0x60222D0", VA = "0x1860230D0")]
	private void KNLLEFLDCKJ(IOFOBJEELFO HGEJDMIEFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6025CB0", Offset = "0x6024EB0", VA = "0x186025CB0")]
	private void NDBIPHHPMBG(float JDOIICMFPFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6020ED0", Offset = "0x60200D0", VA = "0x186020ED0")]
	private void IKAKBEMLHAN([In] OBKLBKMLDBK GAEMKAANAID, MGOPIEGFJBM JOJAMKDOBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6022000", Offset = "0x6021200", VA = "0x186022000")]
	private Vector3 JEFOBMDBFPP([In] OBKLBKMLDBK GAEMKAANAID)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x601E740", Offset = "0x601D940", VA = "0x18601E740")]
	private float GDGLOAPMCDE(float PDPBCICLHDL, [In] OBKLBKMLDBK GAEMKAANAID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x601D9D0", Offset = "0x601CBD0", VA = "0x18601D9D0")]
	private void FMLDKJCMEAG(IOFOBJEELFO HGEJDMIEFDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x601E050", Offset = "0x601D250", VA = "0x18601E050")]
	private void GAEKLACGGOF(float PDPBCICLHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x601E1A0", Offset = "0x601D3A0", VA = "0x18601E1A0")]
	private void GBENBCBDOGL([In] OBKLBKMLDBK GAEMKAANAID, MGOPIEGFJBM JOJAMKDOBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x60249A0", Offset = "0x6023BA0", VA = "0x1860249A0")]
	private float LIFMLDHJHNM([In] OBKLBKMLDBK ABKJGDDDGLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6019DB0", Offset = "0x6018FB0", VA = "0x186019DB0")]
	private void CADLBACNPJH(OBKLBKMLDBK GAEMKAANAID, MGOPIEGFJBM JOJAMKDOBFA, Vector3 MCOODNGMFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6028120", Offset = "0x6027320", VA = "0x186028120")]
	private static void PAEIDMDDOBP(Transform DIFJEPLFOKN, Quaternion ECLCOOPOABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x601D050", Offset = "0x601C250", VA = "0x18601D050")]
	private void EBPOONANBBH([In] OBKLBKMLDBK DHNHOMPNNGI, [In] GFKLOKHJCAC EAFBHKAIBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6019700", Offset = "0x6018900", VA = "0x186019700")]
	private void BPGOLOIPDCI([In] OBKLBKMLDBK DHNHOMPNNGI, [In] GFKLOKHJCAC EAFBHKAIBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x601D9F0", Offset = "0x601CBF0", VA = "0x18601D9F0")]
	private void FOIKNDOAOGM([In] OBKLBKMLDBK GAEMKAANAID, [In] AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x601BE10", Offset = "0x601B010", VA = "0x18601BE10")]
	public void DBCFMKBEFCE([In] OBKLBKMLDBK GAEMKAANAID, [In] AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x60256C0", Offset = "0x60248C0", VA = "0x1860256C0", Slot = "30")]
	protected virtual void NCDPADHMHPM([In] OBKLBKMLDBK GAEMKAANAID, [In] AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60226E0", Offset = "0x60218E0", VA = "0x1860226E0")]
	private void JKFGJABBMOM([In] OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6022C70", Offset = "0x6021E70", VA = "0x186022C70")]
	private void KMJCAHHMHPA(float DIHMCOHBPBB, [In] OBKLBKMLDBK ABKJGDDDGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6027A90", Offset = "0x6026C90", VA = "0x186027A90")]
	private float OPDIAEKLKIH([In] OBKLBKMLDBK ABKJGDDDGLF, [In] AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6024600", Offset = "0x6023800", VA = "0x186024600")]
	private void LGCFDJOFGBE([In] OBKLBKMLDBK ABKJGDDDGLF, [In] AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x601CC90", Offset = "0x601BE90", VA = "0x18601CC90")]
	private void EBLPMKOFHHJ([In] OBKLBKMLDBK ABKJGDDDGLF, float LAINGOBLLCI, float EJMDAKDGJPF, Vector3 KLIHMFNHKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6021810", Offset = "0x6020A10", VA = "0x186021810")]
	private void JCBBCMKKKDC(OBKLBKMLDBK ABKJGDDDGLF, AvatarFullBodyConfiguration JDOEDLEPGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6018E90", Offset = "0x6018090", VA = "0x186018E90")]
	[CompilerGenerated]
	internal static bool AMHFECOFHFC(IKSolverVR.Arm FKNGHEDHECI, HAOJAFFJNEJ EMNDOIMLHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x601C300", Offset = "0x601B500", VA = "0x18601C300")]
	[CompilerGenerated]
	internal static float DKPNGNLJEKA(Vector3 CGDCMLFKGLI, Vector3 GIOBIPACNDG, Vector3 IMNDBCFBAEN, OBKLBKMLDBK ABKJGDDDGLF, AvatarFullBodyConfiguration JDOEDLEPGFL, float BMIAFODFMCE)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum BCNPPAGNHDD
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private BCNPPAGNHDD handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6017BE0", Offset = "0x6016DE0", VA = "0x186017BE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6017BA0", Offset = "0x6016DA0", VA = "0x186017BA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60175A0", Offset = "0x60167A0", VA = "0x1860175A0")]
		private void AAGLGIMOIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1176230", Offset = "0x1175430", VA = "0x181176230", Slot = "4")]
		public void SetEnabled(bool KIOKGDOKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6017C10", Offset = "0x6016E10", VA = "0x186017C10")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, PLJPJOIEJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[PCEENEOFAOO(DGCAKKBAIEP.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private Vector3 KGCOEJBAPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Vector3 ENGGMIBEEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Vector3 GFKNMPOLGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Matrix4x4 KFNDBINJGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private bool LIDNINGHMIE;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60180A0", Offset = "0x60172A0", VA = "0x1860180A0", Slot = "4")]
		public void UpdateController(float PJADGMHMMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5F44440", Offset = "0x5F43640", VA = "0x185F44440", Slot = "6")]
		public void SetEnabled(bool EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6017C40", Offset = "0x6016E40", VA = "0x186017C40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6018760", Offset = "0x6017960", VA = "0x186018760")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class MHDHGGCAODA : LEJMMEPMPBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Dictionary<string, EFMFEGLEECB> DEIMIDCBHJO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool KJBAGDGNIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF450", Offset = "0x7CE650", VA = "0x1807CF450", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x602E110", Offset = "0x602D310", VA = "0x18602E110")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.None)]
	private static void OKMKFODPCLE(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x602DDD0", Offset = "0x602CFD0", VA = "0x18602DDD0", Slot = "4")]
	public EFMFEGLEECB ICOPBENHKCN(string IEJEBCICBCB, AvatarSystemConfiguration DLHOBAFFKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x602DF90", Offset = "0x602D190", VA = "0x18602DF90", Slot = "5")]
	public void MABIBLPIJLE(string IEJEBCICBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x602E180", Offset = "0x602D380", VA = "0x18602E180")]
	public MHDHGGCAODA()
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
		public class NLEEMDJMOJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private Dictionary<string, Transform> LEFOELOHFNA;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public bool OBLLEJJIIHM
			{
				[Cpp2IlInjected.Token(Token = "0x60000D9")]
				[Cpp2IlInjected.Address(RVA = "0x602FFD0", Offset = "0x602F1D0", VA = "0x18602FFD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6030010", Offset = "0x602F210", VA = "0x186030010")]
			public void FJNDKFBHDOM(VRIK HPOBKKJNGEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
			public void FFCBKAELMOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6030140", Offset = "0x602F340", VA = "0x186030140")]
			public void GKFNPGBHNDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6030190", Offset = "0x602F390", VA = "0x186030190")]
			public NLEEMDJMOJC()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		[CPBKDNLKGAP(DGCAKKBAIEP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		[PCEENEOFAOO(DGCAKKBAIEP.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private readonly NLEEMDJMOJC LMBKFPLAPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private BCBKMFCPNND DNHDECCAFJN;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60187C0", Offset = "0x60179C0", VA = "0x1860187C0")]
		private void MEJEOBIHPJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6018770", Offset = "0x6017970", VA = "0x186018770")]
		private bool FAPPPLKLIMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6018A80", Offset = "0x6017C80", VA = "0x186018A80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6018AF0", Offset = "0x6017CF0", VA = "0x186018AF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6018A90", Offset = "0x6017C90", VA = "0x186018A90")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6018CE0", Offset = "0x6017EE0", VA = "0x186018CE0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x602E210", Offset = "0x602D410", VA = "0x18602E210", Slot = "4")]
		public override void OnStateEnter(Animator PDPBILFPNDD, AnimatorStateInfo ELFCKHGOMFJ, int BDLHNONMHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x602E330", Offset = "0x602D530", VA = "0x18602E330")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class DMEKIKGGCKF<TInput, TOutput> : HAMNMOHMKBF<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	protected readonly EHOGINAOANG BNDOEFHACCE;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x50A5810", Offset = "0x50A4A10", VA = "0x1850A5810")]
	protected DMEKIKGGCKF(EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput MAOCPLNNJJM(TInput BHCBEHDFPNA, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x50A5770", Offset = "0x50A4970", VA = "0x1850A5770", Slot = "5")]
	public bool BEOJPFNHOHB(TInput BHCBEHDFPNA, [Out] TOutput? IFJGEIAONPI, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PAAFOJGLPBB]
public static class MFAIIFOOOPC
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly Regex MKPAKKPMAHA;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x602DB30", Offset = "0x602CD30", VA = "0x18602DB30")]
	public static ILIHPJMAOHB IIGDGHPPGMO(LCMAKACPPLG IPFJBLEHLIE, FNCPBFIAFOK OOGJIFCGALO, Guid? DLPMPAFJPIB, Color? FHHIHNEEFIE, BHLLHPOHOIE MGGHENKBGLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x602DA80", Offset = "0x602CC80", VA = "0x18602DA80")]
	public static GHLPFCLOJMP GHDHHHGFLAI(ILIHPJMAOHB MJGHOBDIDHD)
	{
		return default(GHLPFCLOJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2934910", Offset = "0x2933B10", VA = "0x182934910")]
	internal static TModern? BIBFIOPNEBD<TModern>(string? BHCBEHDFPNA, LDFOPLAHODB<TModern> FEBDDOPMOPL, EHOGINAOANG BNDOEFHACCE, IJNHANMBLGP ONMHFFFLGAB, TModern JBJFNACCCPP) where TModern : struct, JGBEHCONICA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2936E00", Offset = "0x2936000", VA = "0x182936E00")]
	internal static IKDJOEBPOLJ LOHPCEOKCEJ<TModern>(string? BHCBEHDFPNA, LDFOPLAHODB<TModern> FEBDDOPMOPL, EHOGINAOANG BNDOEFHACCE, IJNHANMBLGP ONMHFFFLGAB, TModern JBJFNACCCPP) where TModern : struct, JGBEHCONICA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x602D940", Offset = "0x602CB40", VA = "0x18602D940")]
	internal static List<GGJGHOJGBDF> DAEEBJBKOJL(IEnumerable<MKPDIAKFBJI>? LMJOOPEDIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2935F50", Offset = "0x2935150", VA = "0x182935F50")]
	internal static string DAEFAAPNBGI<TModern>(TModern BHCBEHDFPNA, LDFOPLAHODB<TModern> FEBDDOPMOPL, EHOGINAOANG BNDOEFHACCE) where TModern : JGBEHCONICA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NAECJILAHEE : NDABKPBEJLD
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HAMNMOHMKBF<BHONFEMDFPM, COCGFAABOCL> CIJKJNDKIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HAMNMOHMKBF<DIAHKBOPENA, IKJNEDKDEAI> JDBJOPLIPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public HAMNMOHMKBF<DIAHKBOPENA, IKJNEDKDEAI> AIKEPPKLJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HKLOHEBLMFM COEBKOBLJME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KJLLMOBAPBI IHIAFDIOLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x602E340", Offset = "0x602D540", VA = "0x18602E340")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.GameOnly)]
	[UsedImplicitly]
	private static void AIPJNGEJALE(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x602E3B0", Offset = "0x602D5B0", VA = "0x18602E3B0")]
	[Preserve]
	internal NAECJILAHEE([MINIJLJAKNC("UnitySerialization")] OIJBOFAJPJA LJHNCINMNHJ, [MINIJLJAKNC(null)] JLCOAONOJCD AFCDCLMBBAN, [MINIJLJAKNC(null)] EHOGINAOANG BNDOEFHACCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum IPPCIHIJMIF
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HMCFAALNLID : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x602D910", Offset = "0x602CB10", VA = "0x18602D910")]
	public HMCFAALNLID(string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x602D8A0", Offset = "0x602CAA0", VA = "0x18602D8A0")]
	public HMCFAALNLID(string FFDOAJJEAOK, Exception JLLLHGKGCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x602D870", Offset = "0x602CA70", VA = "0x18602D870")]
	public HMCFAALNLID(IPPCIHIJMIF HBBBJJEHKLF, string FFDOAJJEAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x602D8D0", Offset = "0x602CAD0", VA = "0x18602D8D0")]
	public HMCFAALNLID(IPPCIHIJMIF HBBBJJEHKLF, string FFDOAJJEAOK, Exception JLLLHGKGCGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class DIOJNGDDLLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly OIJBOFAJPJA LJHNCINMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	protected readonly JLCOAONOJCD AFCDCLMBBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected readonly EHOGINAOANG BNDOEFHACCE;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x602C260", Offset = "0x602B460", VA = "0x18602C260")]
	protected DIOJNGDDLLL(OIJBOFAJPJA LJHNCINMNHJ, JLCOAONOJCD AFCDCLMBBAN, EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x602A8E0", Offset = "0x6029AE0", VA = "0x18602A8E0")]
	protected string GACOPCEGNKL(COCGFAABOCL KGHNHOEHCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x602C070", Offset = "0x602B270", VA = "0x18602C070")]
	protected string NFIIOKHBECA(COCGFAABOCL KGHNHOEHCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x602BBC0", Offset = "0x602ADC0", VA = "0x18602BBC0")]
	private AvatarOutfitSelectionData IIGDGHPPGMO(ILIHPJMAOHB BJFPIDAGHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x602BF30", Offset = "0x602B130", VA = "0x18602BF30")]
	private static AvatarCustomizationSettingsData.AnchorParams IPIFJPHHKMI(HNCJLAOIFIN? EMFLOEPJAAB)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HAMNMOHMKBF<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput MAOCPLNNJJM(TInput BHCBEHDFPNA, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BEOJPFNHOHB(TInput BHCBEHDFPNA, [Out] TOutput? IFJGEIAONPI, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NDABKPBEJLD
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	HAMNMOHMKBF<BHONFEMDFPM, COCGFAABOCL> CIJKJNDKIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	HAMNMOHMKBF<DIAHKBOPENA, IKJNEDKDEAI> AIKEPPKLJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	HKLOHEBLMFM COEBKOBLJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum IJNHANMBLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KJLLMOBAPBI
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAJFGBJIIPP JCBMCDNAHJB(COCGFAABOCL MJGHOBDIDHD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HKLOHEBLMFM
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DIAHKBOPENA JCBMCDNAHJB(COCGFAABOCL MJGHOBDIDHD, int JAHEMDLBNNH, string? MPENHPFDCDK, string? OOJIPCFEOEI, OIILNFAJHOF DPHCJMIHJPA, List<GGJGHOJGBDF>? CCEGFNPMINL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PAAFOJGLPBB]
internal class DEJMNEMFPBE : DMEKIKGGCKF<BHONFEMDFPM, COCGFAABOCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly JLCOAONOJCD AFCDCLMBBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly GAGIIGCJKAD CNMMEOOHIFO;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6033350", Offset = "0x6032550", VA = "0x186033350")]
	public DEJMNEMFPBE(OIJBOFAJPJA LJHNCINMNHJ, JLCOAONOJCD AFCDCLMBBAN, EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60330B0", Offset = "0x60322B0", VA = "0x1860330B0", Slot = "6")]
	public override COCGFAABOCL MAOCPLNNJJM(BHONFEMDFPM BHCBEHDFPNA, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class BILLPCOCEEM : OIJBOFAJPJA
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class IDNACJKCGPN : JsonConverter<IKDJOEBPOLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6037230", Offset = "0x6036430", VA = "0x186037230", Slot = "9")]
		public override void WriteJson(JsonWriter IBOFEJJMDAD, IKDJOEBPOLJ? EKDDCPALANJ, JsonSerializer IMHJIKPNBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6037110", Offset = "0x6036310", VA = "0x186037110", Slot = "10")]
		public override IKDJOEBPOLJ ReadJson(JsonReader GILMBCDEMDA, Type PHMAPHAJPJG, IKDJOEBPOLJ? MNEHFMLLEPA, bool COHMNHEAGGJ, JsonSerializer IMHJIKPNBIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60372D0", Offset = "0x60364D0", VA = "0x1860372D0")]
		public IDNACJKCGPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class GGNEIGAIALL : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool MNHICFFDGBH
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6035E90", Offset = "0x6035090", VA = "0x186035E90", Slot = "5")]
		public override object ReadJson(JsonReader GILMBCDEMDA, Type PHMAPHAJPJG, object? MNEHFMLLEPA, JsonSerializer IMHJIKPNBIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6035AD0", Offset = "0x6034CD0", VA = "0x186035AD0", Slot = "6")]
		public override bool CanConvert(Type PHMAPHAJPJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6035EF0", Offset = "0x60350F0", VA = "0x186035EF0", Slot = "4")]
		public override void WriteJson(JsonWriter IBOFEJJMDAD, object? EKDDCPALANJ, JsonSerializer IMHJIKPNBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6035CB0", Offset = "0x6034EB0", VA = "0x186035CB0")]
		private static bool MIPGNFEHMBD(object EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public GGNEIGAIALL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly JsonSerializerSettings CBAFCCEIBAC;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x60312D0", Offset = "0x60304D0", VA = "0x1860312D0")]
	internal BILLPCOCEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x264E8D0", Offset = "0x264DAD0", VA = "0x18264E8D0", Slot = "4")]
	public string PPDHHMCBCIP<T>(T GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x264E850", Offset = "0x264DA50", VA = "0x18264E850", Slot = "5")]
	public T GBJMJPIKELL<T>(string EKDDCPALANJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class KKKKNNANDDD : OIJBOFAJPJA
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2902570", Offset = "0x2901770", VA = "0x182902570", Slot = "4")]
	public string PPDHHMCBCIP<T>(T GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2902510", Offset = "0x2901710", VA = "0x182902510", Slot = "5")]
	public T GBJMJPIKELL<T>(string EKDDCPALANJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public KKKKNNANDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[PAAFOJGLPBB]
internal class GAGIIGCJKAD : DMEKIKGGCKF<DIAHKBOPENA, IKJNEDKDEAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly OIJBOFAJPJA LJHNCINMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JLCOAONOJCD AFCDCLMBBAN;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6035990", Offset = "0x6034B90", VA = "0x186035990")]
	public GAGIIGCJKAD(OIJBOFAJPJA LJHNCINMNHJ, JLCOAONOJCD AFCDCLMBBAN, EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6035370", Offset = "0x6034570", VA = "0x186035370", Slot = "6")]
	public override IKJNEDKDEAI MAOCPLNNJJM(DIAHKBOPENA BHCBEHDFPNA, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6035840", Offset = "0x6034A40", VA = "0x186035840")]
	internal void PNJFMGCPLJI(string LAJCAJNCBCP, COCGFAABOCL KGHNHOEHCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6035790", Offset = "0x6034990", VA = "0x186035790")]
	public IEnumerable<ILIHPJMAOHB> OHPFKDGIKHI(string DMNFCMIFIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6033520", Offset = "0x6032720", VA = "0x186033520")]
	private IEnumerable<ILIHPJMAOHB> BGMONMDJKMD(string DMNFCMIFIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60341B0", Offset = "0x60333B0", VA = "0x1860341B0")]
	internal IEnumerable<ILIHPJMAOHB> DCJFMIFJEAI(string DMNFCMIFIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6034600", Offset = "0x6033800", VA = "0x186034600")]
	private ILIHPJMAOHB HNKFBLNEHFB(AvatarOutfitSelectionData NLMCAPNOPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6033930", Offset = "0x6032B30", VA = "0x186033930")]
	private void CECFEIEJEHA(AvatarCustomizationSettingsData ONCCMJKDPOH, COCGFAABOCL KGHNHOEHCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60349D0", Offset = "0x6033BD0", VA = "0x1860349D0")]
	private ILIHPJMAOHB HNKFBLNEHFB(string IHMNCDBHODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6034D30", Offset = "0x6033F30", VA = "0x186034D30")]
	internal static (BHLLHPOHOIE, string, string) IANAKBPAFHL(string IHMNCDBHODL, EHOGINAOANG BNDOEFHACCE)
	{
		return default((BHLLHPOHOIE, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6035010", Offset = "0x6034210", VA = "0x186035010")]
	private AOAHMBCCJEO? JGFADFKHJID(string? JJMGPACFMMB, Vector2 ABOEIGANCON, float LJGLFNCFCMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6035210", Offset = "0x6034410", VA = "0x186035210")]
	private static HNCJLAOIFIN LLEDKHOADCM(AvatarCustomizationSettingsData.AnchorParams MFPENAHKDEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PAAFOJGLPBB]
internal class HCBLMBNHDEF : DIOJNGDDLLL, KJLLMOBAPBI
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6036740", Offset = "0x6035940", VA = "0x186036740")]
	public HCBLMBNHDEF(OIJBOFAJPJA LJHNCINMNHJ, JLCOAONOJCD AFCDCLMBBAN, EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6035FD0", Offset = "0x60351D0", VA = "0x186035FD0", Slot = "4")]
	public PAJFGBJIIPP JCBMCDNAHJB(COCGFAABOCL MJGHOBDIDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6036640", Offset = "0x6035840", VA = "0x186036640")]
	private string PLBHFMJIIOP(COCGFAABOCL KGHNHOEHCKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6036380", Offset = "0x6035580", VA = "0x186036380")]
	private string OENNEKFAKEP(ILIHPJMAOHB BJFPIDAGHFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PAAFOJGLPBB]
internal class HDLLNFELPEP : DMEKIKGGCKF<DIAHKBOPENA, IKJNEDKDEAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly OIJBOFAJPJA LJHNCINMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly HAMNMOHMKBF<DIAHKBOPENA, IKJNEDKDEAI> IEPEGKBHIMD;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6036B80", Offset = "0x6035D80", VA = "0x186036B80")]
	public HDLLNFELPEP(HAMNMOHMKBF<DIAHKBOPENA, IKJNEDKDEAI> IEPEGKBHIMD, EHOGINAOANG BNDOEFHACCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6036750", Offset = "0x6035950", VA = "0x186036750", Slot = "6")]
	public override IKJNEDKDEAI MAOCPLNNJJM(DIAHKBOPENA BHCBEHDFPNA, [Out] IReadOnlyList<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PAAFOJGLPBB]
internal class HFGKEDHLPAF : HKLOHEBLMFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly OIJBOFAJPJA LJHNCINMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KJLLMOBAPBI ACEHIPJADJJ;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6037020", Offset = "0x6036220", VA = "0x186037020")]
	public HFGKEDHLPAF(KJLLMOBAPBI ACEHIPJADJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6036C80", Offset = "0x6035E80", VA = "0x186036C80", Slot = "4")]
	public DIAHKBOPENA JCBMCDNAHJB(COCGFAABOCL MJGHOBDIDHD, int JAHEMDLBNNH, string? MPENHPFDCDK, string? OOJIPCFEOEI, OIILNFAJHOF DPHCJMIHJPA, List<GGJGHOJGBDF>? CCEGFNPMINL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class CGMGLOFDPFM : MLDLNFLHFKF
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly Vector2 MLPIPEDGDBH;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static readonly Vector2 LFPNAGEOIEK;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static readonly Vector2 FMGPKHEOADP;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static readonly Vector2 BKNMOOGBNCA;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static readonly Vector2 HNPJIAFNDCJ;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly Vector2 LKEOFLGDJCK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static readonly Vector2 JLGCIIDAIDG;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static readonly Vector2 NIIHGJJDOFB;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static readonly Vector2 HBJHBAIIHAE;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly Vector2 ONCJDFGNMOA;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private static readonly Vector2 CKFMHLLLAEN;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private static readonly Vector2 ADBBAKOENBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private Dictionary<JHFENCGDOHE, AvatarConfiguration> BFDEBCNLKCI;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6032B90", Offset = "0x6031D90", VA = "0x186032B90")]
	[BDCLMMIIFOD(AILNDCKFLHJ.Root, CIJFMPALMOO.None)]
	private static void OKLAJENNLIO(JGBEMAKPOMJ BIBKBFDHJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6033000", Offset = "0x6032200", VA = "0x186033000")]
	[Preserve]
	internal CGMGLOFDPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6031A70", Offset = "0x6030C70", VA = "0x186031A70", Slot = "4")]
	public Vector2 GDPPBCFOEAH(FaceFeatureType IBKCBKMLPGC, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6032350", Offset = "0x6031550", VA = "0x186032350", Slot = "5")]
	public float LHIBIEDKFBO(FaceFeatureType IBKCBKMLPGC, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6031860", Offset = "0x6030A60", VA = "0x186031860", Slot = "6")]
	public void EAJEPKIDLDF(JHFENCGDOHE DPKJBPAKEGH, AvatarConfiguration DLHOBAFFKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x60320E0", Offset = "0x60312E0", VA = "0x1860320E0", Slot = "7")]
	public float GNAGOKCMOCD(FaceFeatureType NNBAMFNODIO, float JCBFEOMEHBH, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6032B60", Offset = "0x6031D60", VA = "0x186032B60", Slot = "8")]
	public float OGLBDCIJPBI(FaceFeatureType NNBAMFNODIO, float LJGLFNCFCMC, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6032630", Offset = "0x6031830", VA = "0x186032630", Slot = "10")]
	public Vector2 MDFBNBIHHKO(FaceFeatureType NNBAMFNODIO, Vector2 JEAFKJOCOEE, Vector2 GAMAFPKKFAP, Vector2 MCIFMCBEGOD, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6031500", Offset = "0x6030700", VA = "0x186031500", Slot = "9")]
	public Vector2 CIOCDCHNCAE(FaceFeatureType NNBAMFNODIO, Vector2 NPEMMJBHJLH, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6032A40", Offset = "0x6031C40", VA = "0x186032A40")]
	private Vector2 NKACLIKNOED(FaceFeatureType NNBAMFNODIO, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60324E0", Offset = "0x60316E0", VA = "0x1860324E0")]
	private Vector2 LPDAMGIFOJO(FaceFeatureType NNBAMFNODIO, Vector2 JEAFKJOCOEE, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6031D50", Offset = "0x6030F50", VA = "0x186031D50", Slot = "11")]
	public Vector2 GLLAIJHPNMB(FaceFeatureType NNBAMFNODIO, Vector2 NPEMMJBHJLH, Vector2 GAMAFPKKFAP, Vector2 MCIFMCBEGOD, JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x60318D0", Offset = "0x6030AD0", VA = "0x1860318D0")]
	private float EEAJJCKOHMG(float HBDGBCALKKA, float JDDCNPMIKLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6032980", Offset = "0x6031B80", VA = "0x186032980")]
	private Vector2 NCCOPGDEFNO(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6032110", Offset = "0x6031310", VA = "0x186032110")]
	private Vector2 HFNLMNABAHH(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60317E0", Offset = "0x60309E0", VA = "0x1860317E0")]
	private Vector2 EAANMNBGCDJ(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6032AE0", Offset = "0x6031CE0", VA = "0x186032AE0")]
	private Vector2 OFANJBNIABL(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6032A00", Offset = "0x6031C00", VA = "0x186032A00")]
	private float NHIAACBKMPG(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6031960", Offset = "0x6030B60", VA = "0x186031960")]
	private float FKHNECAHJLG(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6032190", Offset = "0x6031390", VA = "0x186032190")]
	private float IOOFENBBOGM(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60324A0", Offset = "0x60316A0", VA = "0x1860324A0")]
	private float LMALPDNFHHM(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6031430", Offset = "0x6030630", VA = "0x186031430")]
	private Vector2 ACLFMOMAJJN(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6032280", Offset = "0x6031480", VA = "0x186032280")]
	private Vector2 LCJGMIOAOKN(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60327E0", Offset = "0x60319E0", VA = "0x1860327E0")]
	private Vector2 MGDKHGCNDLA(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60319A0", Offset = "0x6030BA0", VA = "0x1860319A0")]
	private Vector2 GBOFKKNGDAN(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6032D50", Offset = "0x6031F50", VA = "0x186032D50")]
	private Vector2 PNIBFIELCLF(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6032C80", Offset = "0x6031E80", VA = "0x186032C80")]
	private Vector2 PKHJHIDGOBD(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6031BD0", Offset = "0x6030DD0", VA = "0x186031BD0")]
	private Vector2 GFOAHIBODJH(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60323D0", Offset = "0x60315D0", VA = "0x1860323D0")]
	private Vector2 LJKIDDMEIEI(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60328B0", Offset = "0x6031AB0", VA = "0x1860328B0")]
	private Vector2 MHEECOHLIHG(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6031730", Offset = "0x6030930", VA = "0x186031730")]
	private Vector2 DNFJCLFHADA(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6031CA0", Offset = "0x6030EA0", VA = "0x186031CA0")]
	private Vector2 GLEGMGJHKDK(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60321D0", Offset = "0x60313D0", VA = "0x1860321D0")]
	private Vector2 KIGNMBGCABP(JHFENCGDOHE DPKJBPAKEGH)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6030550", Offset = "0x602F750", VA = "0x186030550")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class BDMGFOCKIPO
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6031050", Offset = "0x6030250", VA = "0x186031050")]
	public static GHLPFCLOJMP MAOCPLNNJJM(this JMJPFKFEEIK MJGHOBDIDHD)
	{
		return default(GHLPFCLOJMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6030EA0", Offset = "0x60300A0", VA = "0x186030EA0")]
	public static JMJPFKFEEIK JCBMCDNAHJB(this GHLPFCLOJMP JGNDMMDEINM)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x462DA70", Offset = "0x462CC70", VA = "0x18462DA70")]
			public AnchorParams(Vector2 JEAFKJOCOEE, Vector3 KAGGBHFKDJA, Vector3 CPNPDOBIEDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x60304A0", Offset = "0x602F6A0", VA = "0x1860304A0")]
			internal HNCJLAOIFIN JCBMCDNAHJB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private JAFMFBJMKOF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x6030D30", Offset = "0x602FF30", VA = "0x186030D30")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3F46940", Offset = "0x3F45B40", VA = "0x183F46940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xEC9920", Offset = "0xEC8B20", VA = "0x180EC9920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x971F70", Offset = "0x971170", VA = "0x180971F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x86C3D0", Offset = "0x86B5D0", VA = "0x18086C3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x7B4100", Offset = "0x7B3300", VA = "0x1807B4100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6030DD0", Offset = "0x602FFD0", VA = "0x186030DD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x7BF630", Offset = "0x7BE830", VA = "0x1807BF630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xC66390", Offset = "0xC65590", VA = "0x180C66390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xEF1440", Offset = "0xEF0640", VA = "0x180EF1440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x7B7550", Offset = "0x7B6750", VA = "0x1807B7550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x6030E30", Offset = "0x6030030", VA = "0x186030E30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1AB2E20", Offset = "0x1AB2020", VA = "0x181AB2E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xD0FA20", Offset = "0xD0EC20", VA = "0x180D0FA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD10A50", Offset = "0xD0FC50", VA = "0x180D10A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BB150", VA = "0x1807BBF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF30", Offset = "0x7BB130", VA = "0x1807BBF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x6030E10", Offset = "0x6030010", VA = "0x186030E10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x1AD6670", Offset = "0x1AD5870", VA = "0x181AD6670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7EAE00", Offset = "0x7EA000", VA = "0x1807EAE00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7EAE60", Offset = "0x7EA060", VA = "0x1807EAE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4B0", Offset = "0x7BC6B0", VA = "0x1807BD4B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x7BD440", Offset = "0x7BC640", VA = "0x1807BD440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4C0", Offset = "0x7BC6C0", VA = "0x1807BD4C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7BD520", Offset = "0x7BC720", VA = "0x1807BD520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7BD410", Offset = "0x7BC610", VA = "0x1807BD410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7BD4D0", Offset = "0x7BC6D0", VA = "0x1807BD4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x98CEA0", Offset = "0x98C0A0", VA = "0x18098CEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x98CF80", Offset = "0x98C180", VA = "0x18098CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x7BD430", Offset = "0x7BC630", VA = "0x1807BD430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x7BD5A0", Offset = "0x7BC7A0", VA = "0x1807BD5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x87F4A0", Offset = "0x87E6A0", VA = "0x18087F4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x87F5C0", Offset = "0x87E7C0", VA = "0x18087F5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB080", Offset = "0x7BA280", VA = "0x1807BB080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x7BB010", Offset = "0x7BA210", VA = "0x1807BB010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA18430", Offset = "0xA17630", VA = "0x180A18430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA20BE0", Offset = "0xA1FDE0", VA = "0x180A20BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CACA0", Offset = "0x8C9EA0", VA = "0x1808CACA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xB9F560", Offset = "0xB9E760", VA = "0x180B9F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public JAFMFBJMKOF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x1B7C280", Offset = "0x1B7B480", VA = "0x181B7C280")]
			get
			{
				return default(JAFMFBJMKOF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1B7B2E0", Offset = "0x1B7A4E0", VA = "0x181B7B2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x9175F0", Offset = "0x9167F0", VA = "0x1809175F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x918330", Offset = "0x917530", VA = "0x180918330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6030DF0", Offset = "0x602FFF0", VA = "0x186030DF0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6030E50", Offset = "0x6030050", VA = "0x186030E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x60309D0", Offset = "0x602FBD0", VA = "0x1860309D0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public BHLLHPOHOIE BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private NMHOCJJDBGM? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6030E70", Offset = "0x6030070", VA = "0x186030E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
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
