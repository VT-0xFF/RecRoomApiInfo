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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B7FC0", Offset = "0x79B73C0", VA = "0x1879B7FC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B8040", Offset = "0x79B7440", VA = "0x1879B8040", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IJOMDGJLMLC]
internal class CBNMEEAKKGA : NJOKEANDMND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DNLEOFHGBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public CBNMEEAKKGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public LOHMIPEBFLA avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KPJLAPIBJLM DJIFMKKLCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KNDFIHDMAKA JGLGGMGPBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IOFFCGADLEI JJEGGNDKAIG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x799A540", Offset = "0x7999940", VA = "0x18799A540")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	[UsedImplicitly]
	internal static void HDGDIFJKKGM(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x799BED0", Offset = "0x799B2D0", VA = "0x18799BED0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CBNMEEAKKGA([MGCCDFKFGBG(null)] KPJLAPIBJLM DJIFMKKLCJD, [MGCCDFKFGBG(null)] KNDFIHDMAKA JGLGGMGPBBL, [MGCCDFKFGBG(null)] IOFFCGADLEI JJEGGNDKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x799A790", Offset = "0x7999B90", VA = "0x18799A790", Slot = "5")]
	public BJFLFCHJINB KFMIFBNMIFK(LOHMIPEBFLA EEBDILJINIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x799B070", Offset = "0x799A470", VA = "0x18799B070", Slot = "4")]
	public BJFLFCHJINB KKINHAMBDPB(LOHMIPEBFLA EEBDILJINIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x799BDC0", Offset = "0x799B1C0", VA = "0x18799BDC0", Slot = "6")]
	public LCBFOIKMINJ PJDAAECLOKC(BJFLFCHJINB AOFGGGKINCN, int PJOBJMPCFKF, string? KCCMEIDBNGP, string? EDFBPAOOBLD, ALNGOLLGNAJ EMAIMHFDOKO, List<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x799BB80", Offset = "0x799AF80", VA = "0x18799BB80", Slot = "7")]
	public bool PCBCHCNKPMH(CAJLLMCBOMK PCNGKEJOHAJ, [Out] BJFLFCHJINB? NMNEBNPOIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x799A460", Offset = "0x7999860", VA = "0x18799A460", Slot = "8")]
	public bool FKNPLOPOKLC(LCBFOIKMINJ GIDHMFPFCGE, [Out] BJFLFCHJINB? NMNEBNPOIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x799A3D0", Offset = "0x79997D0", VA = "0x18799A3D0", Slot = "9")]
	public bool BKJODPAFBKP(LCBFOIKMINJ GIDHMFPFCGE, [Out] HDOFECNGONC? PCNGKEJOHAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34BB5C0", Offset = "0x34BA9C0", VA = "0x1834BB5C0")]
	private bool KFKINMPCGCP<TInput, TOutput>(TInput EOMFNMMGCEC, NJIHIJAJGGC<TInput, TOutput> LGOLGCGJCOB, [Out] TOutput? APLCGCDLEGH) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x799BC10", Offset = "0x799B010", VA = "0x18799BC10")]
	[CompilerGenerated]
	private JEPNDKFIAON PDFOGBDCAJP(FaceFeatureType IBMEGOHDDJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x799A5B0", Offset = "0x79999B0", VA = "0x18799A5B0")]
	[CompilerGenerated]
	private JEPNDKFIAON IPODCOJCGNL(FaceFeatureType IBMEGOHDDJB, DNLEOFHGBDD P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[IJOMDGJLMLC]
internal class MIBJPAIKINE : KPJLAPIBJLM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NDIHJIKGDIA<in TData>(TData NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LILBNGIFEKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public HCLLDJJOBIO rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GHAPOEOFOLK currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public GHAPOEOFOLK latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public LILBNGIFEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79B5D90", Offset = "0x79B5190", VA = "0x1879B5D90")]
		internal bool LKHBFPNFPNO(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x79B5D10", Offset = "0x79B5110", VA = "0x1879B5D10")]
		internal bool ENJCKAHDPJC(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IOFFCGADLEI JJEGGNDKAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IEDDOEABFGN GKILNJBFBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NDIHJIKGDIA<BJFLFCHJINB>?[] DJIFMKKLCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NDIHJIKGDIA<HDOFECNGONC>?[] MHBBDFNKJPE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79B7280", Offset = "0x79B6680", VA = "0x1879B7280")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	[UsedImplicitly]
	internal static void HDGDIFJKKGM(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79B7940", Offset = "0x79B6D40", VA = "0x1879B7940")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MIBJPAIKINE([MGCCDFKFGBG(null)] IOFFCGADLEI JJEGGNDKAIG, [MGCCDFKFGBG(null)] IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79B73D0", Offset = "0x79B67D0", VA = "0x1879B73D0", Slot = "4")]
	public bool KOMCAGOAAOM(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79B74D0", Offset = "0x79B68D0", VA = "0x1879B74D0", Slot = "5")]
	public bool KOMCAGOAAOM(HDOFECNGONC PCNGKEJOHAJ, IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79B6690", Offset = "0x79B5A90", VA = "0x1879B6690")]
	private void GKCBPGKCEGH(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79B7640", Offset = "0x79B6A40", VA = "0x1879B7640")]
	private void NBLPJFOODEC(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79B6380", Offset = "0x79B5780", VA = "0x1879B6380")]
	private void EPNGKAPMGMI(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79B5DF0", Offset = "0x79B51F0", VA = "0x1879B5DF0")]
	private void BNCMFNEDEJD(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79B7870", Offset = "0x79B6C70", VA = "0x1879B7870")]
	private void PDEOGNPIAEA(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79B62D0", Offset = "0x79B56D0", VA = "0x1879B62D0")]
	private void EPDEIJBDCPD(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x79B7320", Offset = "0x79B6720", VA = "0x1879B7320")]
	private void KLLGALIIKBJ(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x79B7630", Offset = "0x79B6A30", VA = "0x1879B7630")]
	private void LBEEEPONOIM(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79B72F0", Offset = "0x79B66F0", VA = "0x1879B72F0")]
	private void HPOIHHCBHMM(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? PLCJAHDMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x79B63B0", Offset = "0x79B57B0", VA = "0x1879B63B0")]
	private void FKAMDPPGANM(BJFLFCHJINB NMNEBNPOIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79B5FF0", Offset = "0x79B53F0", VA = "0x1879B5FF0")]
	private BJFLFCHJINB ELKCHMIAOGN(BJFLFCHJINB NMNEBNPOIJA, List<RangeMigration> GEBNLLOOCAI, GHAPOEOFOLK PEKDKHGKIIL, GHAPOEOFOLK NPEMLOEJPMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79B5DB0", Offset = "0x79B51B0", VA = "0x1879B5DB0")]
	private float AKKKOEBPHID(float BHACJDBLDPJ, Vector2 DEBILEFMOEL, Vector2 BAHFIPEJODP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x79B5E20", Offset = "0x79B5220", VA = "0x1879B5E20")]
	private (RangeMigration?, RangeMigration?) CJBJMFGNGIK(List<RangeMigration> PLDHHOFPAIJ, HCLLDJJOBIO ODBHMCHDBCE, GHAPOEOFOLK PEKDKHGKIIL, GHAPOEOFOLK NPEMLOEJPMG)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KPJLAPIBJLM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOMCAGOAAOM(BJFLFCHJINB NMNEBNPOIJA, IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOMCAGOAAOM(HDOFECNGONC PCNGKEJOHAJ, IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);
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
		public ONJNNKNKEPP AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7997F60", Offset = "0x7997360", VA = "0x187997F60")]
		public void AHMFLKLFMBE(AnimationPoseSetting DMMBOHMLHLF, float EMGMDIBGOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7998090", Offset = "0x7997490", VA = "0x187998090")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
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
		[Cpp2IlInjected.Address(RVA = "0x79980F0", Offset = "0x79974F0", VA = "0x1879980F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x79980B0", Offset = "0x79974B0", VA = "0x1879980B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7998120", Offset = "0x7997520", VA = "0x187998120")]
		private void PKBNOHMKEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7926BF0", Offset = "0x7925FF0", VA = "0x187926BF0", Slot = "4")]
		public void SetEnabled(bool PBPBGDAIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79989D0", Offset = "0x7997DD0", VA = "0x1879989D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7998A10", Offset = "0x7997E10", VA = "0x187998A10")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F9")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4EC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7998A90", Offset = "0x7997E90", VA = "0x187998A90")]
		public AnimationPoseSetting KCFNDEJEJJP(ONJNNKNKEPP CKJCFCCGALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7998A50", Offset = "0x7997E50", VA = "0x187998A50")]
		public void HGEPFBBIJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7998AC0", Offset = "0x7997EC0", VA = "0x187998AC0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum LFCKCGOKOCN
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private LFCKCGOKOCN handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7998F70", Offset = "0x7998370", VA = "0x187998F70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7998F30", Offset = "0x7998330", VA = "0x187998F30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7998FA0", Offset = "0x79983A0", VA = "0x187998FA0")]
		private void PKBNOHMKEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7926BF0", Offset = "0x7925FF0", VA = "0x187926BF0", Slot = "4")]
		public void SetEnabled(bool PBPBGDAIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79995C0", Offset = "0x79989C0", VA = "0x1879995C0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, NJIADMPGABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[Header("Configuration")]
		private LOHMIPEBFLA avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HAKPMKJKBJL(ANEAJGIOFML.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[FormerlySerializedAs("HeadTweakBone")]
		[SerializeField]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JIEEMEHOAEF LFONJGBEBJI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JIEEMEHOAEF DDOOHKCNJEK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA65D50", Offset = "0xA65150", VA = "0x180A65D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform MPGLMLAPHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x799A3B0", Offset = "0x79997B0", VA = "0x18799A3B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79995F0", Offset = "0x79989F0", VA = "0x1879995F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x799A270", Offset = "0x7999670", VA = "0x18799A270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x799A220", Offset = "0x7999620", VA = "0x18799A220")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x799A1B0", Offset = "0x79995B0", VA = "0x18799A1B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x79995F0", Offset = "0x79989F0", VA = "0x1879995F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7999980", Offset = "0x7998D80", VA = "0x187999980", Slot = "6")]
		public JIEEMEHOAEF CreateAvatarSystem(string PFLLBLDNHAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x799A1B0", Offset = "0x79995B0", VA = "0x18799A1B0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x79996B0", Offset = "0x7998AB0", VA = "0x1879996B0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x799A2C0", Offset = "0x79996C0", VA = "0x18799A2C0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float KMHBKELIILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class FEGHDIJNHDB : JIEEMEHOAEF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PIEBMAAAMJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Vector3 IOALFEKOHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Quaternion EFCNJEOHGAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 NIFMLJCJIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Transform GBJIKMAODFG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 FPICNELHHPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1E5AEE0", Offset = "0x1E5A2E0", VA = "0x181E5AEE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1E5AF00", Offset = "0x1E5A300", VA = "0x181E5AF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion CPHHEHIKAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x12BB180", Offset = "0x12BA580", VA = "0x1812BB180")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x12BB3D0", Offset = "0x12BA7D0", VA = "0x1812BB3D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float KIKMJBCHBLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x104E6B0", Offset = "0x104DAB0", VA = "0x18104E6B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x168FD90", Offset = "0x168F190", VA = "0x18168FD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool FKJBNJJIPOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9CE3A0", Offset = "0x9CD7A0", VA = "0x1809CE3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x9CE370", Offset = "0x9CD770", VA = "0x1809CE370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool MADIFOHFLAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9CE3B0", Offset = "0x9CD7B0", VA = "0x1809CE3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9CE340", Offset = "0x9CD740", VA = "0x1809CE340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool DEIOKJFBLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9CE470", Offset = "0x9CD870", VA = "0x1809CE470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9CE3C0", Offset = "0x9CD7C0", VA = "0x1809CE3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float ILGPPJNBACD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xC47150", Offset = "0xC46550", VA = "0x180C47150")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC468D0", Offset = "0xC45CD0", VA = "0x180C468D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x79C38E0", Offset = "0x79C2CE0", VA = "0x1879C38E0")]
		public void NONNLADNJMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x79C2B40", Offset = "0x79C1F40", VA = "0x1879C2B40")]
		public void AJEDJJLAHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x79C2D80", Offset = "0x79C2180", VA = "0x1879C2D80")]
		public float CHIPMNALGDG(Vector3 IGOEOOAJHNF, Quaternion PPFMJBHNBMA, [In] AvatarFootSettings POLGNHDPMFD, float HIJJIPKCJEP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79C31E0", Offset = "0x79C25E0", VA = "0x1879C31E0")]
		public void JJIAEJHKBCO(Vector3 DCEBBEFMAEO, Quaternion BNMKCODMEFJ, Transform BGFMEACPNON, float GOJODJLGHGN, bool KNBCPCBECFI, bool KCBKBPCGKHE, float GFNHCOMGAHO, float LOFFJDLPNPM, Transform DGFFJNKGDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x79C2B50", Offset = "0x79C1F50", VA = "0x1879C2B50")]
		public void CBNKFNKLMNP(Transform DIAPMDLEMHB, Transform DGFFJNKGDJD, bool PJJADLNOAEG, bool JGPFDBIHGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x79C30E0", Offset = "0x79C24E0", VA = "0x1879C30E0")]
		private void HGBINKOODNN(Transform DGFFJNKGDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x79C2F90", Offset = "0x79C2390", VA = "0x1879C2F90")]
		public void EEEAFPHKPAE(Transform DGFFJNKGDJD, AvatarFullBodyConfiguration ICLMPPLIKCJ, Vector3 HDNBFNPIHEO, float HDLFKKMEICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x79C38C0", Offset = "0x79C2CC0", VA = "0x1879C38C0")]
		public void NJMIHOCGDFF(float LOFFJDLPNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x79C38F0", Offset = "0x79C2CF0", VA = "0x1879C38F0")]
		public PIEBMAAAMJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class PBDBGOAMJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float GKLKDNHLPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private bool NADJBJNOBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AnimationPoseSetting BGFKCGOILNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float DPMCPGDPFDP;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x79C1460", Offset = "0x79C0860", VA = "0x1879C1460")]
		public void AELABGAMPGD(IKSolverVR.Arm HKKHFBMJAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x79C2940", Offset = "0x79C1D40", VA = "0x1879C2940")]
		public void PHKKMBGIJEB(IKSolverVR.Arm HKKHFBMJAJP, float BBOBLKLPNLL, bool NADJBJNOBLL, AvatarFullBodyConfiguration ICLMPPLIKCJ, float DPACGNFKBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x79C1870", Offset = "0x79C0C70", VA = "0x1879C1870")]
		private void GJLADGLDLNG(IKSolverVR.Arm HKKHFBMJAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x79C1490", Offset = "0x79C0890", VA = "0x1879C1490")]
		public void GBHIFMFILIH(IKSolverVR.Arm HKKHFBMJAJP, Transform GAPADCNEEOJ, Transform BGFMEACPNON, Quaternion ONGCAIKGNEK, Vector3 JNJNMNMBBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x79C18B0", Offset = "0x79C0CB0", VA = "0x1879C18B0")]
		private (Vector3, Quaternion) IJDJNMEAJBD(LAKJPCFBEPA IFPNFJGOPKE, Quaternion EDLADIFFEOJ, Vector3 CGGJDDKGPBM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x79C27E0", Offset = "0x79C1BE0", VA = "0x1879C27E0")]
		public void NLLEJOBJCFG(LAKJPCFBEPA IFPNFJGOPKE, IKSolverVR.Arm HKKHFBMJAJP, Quaternion EDLADIFFEOJ, Vector3 CGGJDDKGPBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x79C1D40", Offset = "0x79C1140", VA = "0x1879C1D40")]
		public void LBBJNAHFKBF(LAKJPCFBEPA IFPNFJGOPKE, IKSolverVR.Arm HKKHFBMJAJP, Quaternion EDLADIFFEOJ, Vector3 CGGJDDKGPBM, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ, [In] IPMFCCDENKC FGCBFMGNEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x79C2980", Offset = "0x79C1D80", VA = "0x1879C2980")]
		public void POLCOOGFCFL(ONJNNKNKEPP LEACJIBPEFA, AvatarFullBodyConfiguration ICLMPPLIKCJ, IPMFCCDENKC FGCBFMGNEPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x79C2340", Offset = "0x79C1740", VA = "0x1879C2340")]
		public void MGIEBAEDBLC(IKSolverVR.Arm HKKHFBMJAJP, Transform GAPADCNEEOJ, Vector3 CHJLFBPPNEE, float JCPBLLCENFA, Quaternion EGFLONDEOBJ, Vector3 GBCJKHLDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x79C2AC0", Offset = "0x79C1EC0", VA = "0x1879C2AC0")]
		public PBDBGOAMJAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum LCDLJBIOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct PKGHFDDBFDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct MIFFFLAKFHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int HKMGEBMIDDC;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int AONDOIJANBL;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int HENDJJCMEAI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int BHBELEJDPDC;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int BKGHKJKMHKE;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int CFINBMDDGHA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int IODADEMPKDM;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int MLJCDEOBHDL;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int IHOAEABLBEK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int JHBMFGCIBIL;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int NEBMPKKDIIE;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int HFLDMEFDFDE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int LFFODLPAJDM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int LDPGKEFNBIL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int LMIJIEDFNGK;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int PPHGAJIBHCB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int BDLILCAADID;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GKECIJGOAAH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int EMNGMCCFLEC;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int HPCFBGECNAA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int ILNBLPKEJPC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int CDBJBLOKPCE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int NMAHCNGECDO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HMGPKDADMGP;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int KOLJCHMBIJJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OKAABNPNEBL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int AKGJKPFHHLG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int ENBODFDIMJI;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int HOAAIGAEGNN;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int HGHDHELMKDH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int AMDBAMNANLO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 KNCLBPFLNCN;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int IMAJFLDCKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool JIDIHBJBNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool PKKHDIMHOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool DNCHHGPHLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool GNFMANEIBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LAIKJBGCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool DHODBBBADJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Vector3 FEPMKOGOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private string DPGNKKIKEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private BPGNKGEOLBH? AFJPKKBELFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DJJBPFKKPCC? LDOOJPCGIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MOPMMHIMELM ELNDGIGCCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LFDJDONCOGP HIHJEFNEKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LAKJPCFBEPA JJJKKIKLIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private LAKJPCFBEPA KAACODCEGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool MIGDJFADPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool IEIEKNCEJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly HNJOGJJMAAH DLHFGMBJDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly NBIPKNEDJNJ GKIPMLBGNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int PDMJHDFAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private float CNCIMAONPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GameObject EMOKABFAGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform BOCCGHHAKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Transform BJBCFFMEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Transform IKAJGCOCHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform INMMJJOAMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private float FPIADOBIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float GMBOHNDJAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Vector3 MCPNKCMEOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Quaternion LHEHGBMCJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform CEJFOKIDGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform IOOLPIMHHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform HOFCDBIDKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private ADKLGBJCABI ODBBCHGFNDD;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker CBHKLHPBGEM;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker FELNMJCOKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ProfilerMarker CHDIFMMIBFJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker ABFILLPEJHC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly ProfilerMarker DPFPOFDMIOG;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly ProfilerMarker OMJGHPAIMOC;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly List<FEGHDIJNHDB> MECNICNMDDH;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int CJKLKENDIFC;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> AANEDPDIKJN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int BGIKDBKGPHG;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int BENLBHNBLPJ;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int MODLAAGBMGE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static int OLJOHLFACLO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float KOJLCECHKED;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int JGFNAADDENF;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float CLCHABGENCH;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static float PHNJEJNCPKN;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static float ILFOPLLGELM;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static float OLHAPIHNPHJ;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static CKAJDJFNDNI PICDFCGIDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private float LOMINLLNPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool OBDHPNKMDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float LJHBJCGBFBB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly int PBAOPCGNKDM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly int JELILMDLEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private PIEBMAAAMJP HCIIHBCANBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private PIEBMAAAMJP PNIPIEMPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float OMAGBGGNLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Vector3 JBIMELPEBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Vector3 OHCODDAFPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool BJFIAAHEJHL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Quaternion FPLFFLBNKKB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion HDJFOLAFFOJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Vector3 GJNBNGKAPMG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 IBNHBOJMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private float LOBPOFBCMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float PKNLHHOINGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private PBDBGOAMJAM KMBJLFIBAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private PBDBGOAMJAM IHBBCHDBFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HHDDFJBFALK EJEKEANHECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private BAAMLGJMHDH MOIHMHLHGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly HDLNBMICHDE MNJAFEGNMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private float ANGINGDMHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float CACFACHOMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly BAAMLGJMHDH DPGAOKEKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 FJIEFCGBMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private Vector3 DMPAEOEJHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float COINNKHKDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float DFBBNOGMBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly BAAMLGJMHDH DIHDDMPHBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly HHDDFJBFALK PGPEECNPKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly BAAMLGJMHDH GLGEHBHNIIL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KFBDEOPEKLE OIBOICGDINE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KFBDEOPEKLE DHJJABCGOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration ABMDHBOOHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79B2710", Offset = "0x79B1B10", VA = "0x1879B2710", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LOHMIPEBFLA PDBNGGNFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79AF8C0", Offset = "0x79AECC0", VA = "0x1879AF8C0", Slot = "23")]
		get
		{
			return default(LOHMIPEBFLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration JCCAEBBFENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x799E820", Offset = "0x799DC20", VA = "0x18799E820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform GABHMKHMHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x799EB10", Offset = "0x799DF10", VA = "0x18799EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform LOLBOPLCILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79A9C20", Offset = "0x79A9020", VA = "0x1879A9C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer EHAJHFEACLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x79AB910", Offset = "0x79AAD10", VA = "0x1879AB910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] NJDDPOFFDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x79AA2E0", Offset = "0x79A96E0", VA = "0x1879AA2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] MHGDCLCEHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x799F880", Offset = "0x799EC80", VA = "0x18799F880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator EOMMEMCNBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79B0B60", Offset = "0x79AFF60", VA = "0x1879B0B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK IPGKJFMNELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x799D460", Offset = "0x799C860", VA = "0x18799D460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private CDMFGMGOJIF KBBJGJNPFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x79B0C60", Offset = "0x79B0060", VA = "0x1879B0C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private CDMFGMGOJIF BCOIEMCLLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x79A45D0", Offset = "0x79A39D0", VA = "0x1879A45D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private CDMFGMGOJIF LMANKAIOKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x799D360", Offset = "0x799C760", VA = "0x18799D360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private CDMFGMGOJIF NNJBNFPEBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79AEE40", Offset = "0x79AE240", VA = "0x1879AEE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private CDMFGMGOJIF GLOODCGLOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x79ACEA0", Offset = "0x79AC2A0", VA = "0x1879ACEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private CDMFGMGOJIF DIPNNGMLFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79A2A30", Offset = "0x79A1E30", VA = "0x1879A2A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private CDMFGMGOJIF KALLEMJIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x799E720", Offset = "0x799DB20", VA = "0x18799E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private CDMFGMGOJIF KJFGLGPFBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79AE1B0", Offset = "0x79AD5B0", VA = "0x1879AE1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DJJBPFKKPCC LPADOOHGAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79B4B50", Offset = "0x79B3F50", VA = "0x1879B4B50", Slot = "15")]
		get
		{
			return default(DJJBPFKKPCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CKKICPFEDGL MEGJHNHKOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA8ABE0", Offset = "0xA89FE0", VA = "0x180A8ABE0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GNHNBKMHFPD CHEAINDHKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA8B270", Offset = "0xA8A670", VA = "0x180A8B270", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OHNJHAOHDGP JGINNIICJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA8B520", Offset = "0xA8A920", VA = "0x180A8B520", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OHNJHAOHDGP IHCEIPDDAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA8AF80", Offset = "0xA8A380", VA = "0x180A8AF80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BCNFMIOEPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform DHEDKMENCJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79B2810", Offset = "0x79B1C10", VA = "0x1879B2810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform GHJCBFGHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x799F130", Offset = "0x799E530", VA = "0x18799F130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform CLLNAOANMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79B4C80", Offset = "0x79B4080", VA = "0x1879B4C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform BBOHPIFABIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x79AF600", Offset = "0x79AEA00", VA = "0x1879AF600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform DOGKKHOJBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x79B1C80", Offset = "0x79B1080", VA = "0x1879B1C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool BBJLCNCIKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x79ADCD0", Offset = "0x79AD0D0", VA = "0x1879ADCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool DHFPJEAKENO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x79ADCD0", Offset = "0x79AD0D0", VA = "0x1879ADCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool NHBNBHMAMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79B0D60", Offset = "0x79B0160", VA = "0x1879B0D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform LNCKPOENEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x79AF500", Offset = "0x79AE900", VA = "0x1879AF500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject GMFIIANHHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x79A9D20", Offset = "0x79A9120", VA = "0x1879A9D20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets KKCNNPGDGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79A29B0", Offset = "0x79A1DB0", VA = "0x1879A29B0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform GDBCMKFAMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA6E900", Offset = "0xA6DD00", VA = "0x180A6E900", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform OGEIFNANHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA8B560", Offset = "0xA8A960", VA = "0x180A8B560", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform EMJNEDAKNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A1D0", Offset = "0xA895D0", VA = "0x180A8A1D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform ONILAOLPBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x12B7050", Offset = "0x12B6450", VA = "0x1812B7050", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 PMPPIDGMBAF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x79B1670", Offset = "0x79B0A70", VA = "0x1879B1670", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float GBMAJODDKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x79A04C0", Offset = "0x799F8C0", VA = "0x1879A04C0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform OLLKNHILJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x79A2B30", Offset = "0x79A1F30", VA = "0x1879A2B30", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform NPGFIEIFAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x222FD00", Offset = "0x222F100", VA = "0x18222FD00", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform CGGKEBOMBLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x222FCF0", Offset = "0x222F0F0", VA = "0x18222FCF0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform CFDOFJPCJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1B9F530", Offset = "0x1B9E930", VA = "0x181B9F530", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FCMAOCHCJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x79AB580", Offset = "0x79AA980", VA = "0x1879AB580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool FBLNFMAHLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x799C2F0", Offset = "0x799B6F0", VA = "0x18799C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool HCHIEABMBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x79AF480", Offset = "0x79AE880", VA = "0x1879AF480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79A0760", Offset = "0x799FB60", VA = "0x1879A0760")]
	private void ELDEDPDEECE([In] IPMFCCDENKC AHJOOMILLAM, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ, bool MMEKBEGMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x799C230", Offset = "0x799B630", VA = "0x18799C230")]
	private float AHEMHLGPPOF([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79B2D70", Offset = "0x79B2170", VA = "0x1879B2D70")]
	private float ONEIIFIHMDM([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79B1210", Offset = "0x79B0610", VA = "0x1879B1210")]
	private void NHLIINLJNME(IPMFCCDENKC AHJOOMILLAM, AvatarFullBodyConfiguration ICLMPPLIKCJ, bool MMEKBEGMKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x799D5D0", Offset = "0x799C9D0", VA = "0x18799D5D0")]
	private void DABKEJMFEGD([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79B2DF0", Offset = "0x79B21F0", VA = "0x1879B2DF0")]
	private void OOLBBDJHKGA([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79B5870", Offset = "0x79B4C70", VA = "0x1879B5870")]
	public FEGHDIJNHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x799EC10", Offset = "0x799E010", VA = "0x18799EC10", Slot = "12")]
	public void DMKKJGIKKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x79ABA10", Offset = "0x79AAE10", VA = "0x1879ABA10", Slot = "13")]
	public void IPMACJIEEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79ADA10", Offset = "0x79ACE10", VA = "0x1879ADA10", Slot = "14")]
	public void KJMLBJBADBE(bool GJHIMMJLNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x79A6EF0", Offset = "0x79A62F0", VA = "0x1879A6EF0", Slot = "25")]
	public Transform HBFABFCJDGL(string MBKADIIBEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x79ADB30", Offset = "0x79ACF30", VA = "0x1879ADB30", Slot = "26")]
	public Vector3? KMFFMJKMMPE(string MBKADIIBEKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79A7040", Offset = "0x79A6440", VA = "0x1879A7040", Slot = "7")]
	public void HEHENBHOBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x799E620", Offset = "0x799DA20", VA = "0x18799E620")]
	private void DGHENNEBFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79B2A20", Offset = "0x79B1E20", VA = "0x1879B2A20")]
	private Vector3 OEGHAFDLOHN([In] IPMFCCDENKC FGCBFMGNEPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x79B01D0", Offset = "0x79AF5D0", VA = "0x1879B01D0", Slot = "6")]
	public void MKKJGLGCBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x799D560", Offset = "0x799C960", VA = "0x18799D560", Slot = "8")]
	public void CHOICHIDCNL(float DEKNENKJJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79AF640", Offset = "0x79AEA40", VA = "0x1879AF640")]
	private void MANBLCHIAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79A4C80", Offset = "0x79A4080", VA = "0x1879A4C80", Slot = "4")]
	public void GPBLEJEKPFD(string PFLLBLDNHAD, BPGNKGEOLBH KLABNLIBBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79B4610", Offset = "0x79B3A10", VA = "0x1879B4610", Slot = "5")]
	public void PFLEAPFCGEN(DJJBPFKKPCC AHDMONMOBJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79A4B20", Offset = "0x79A3F20", VA = "0x1879A4B20", Slot = "11")]
	public void GOPDIHOJEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x799DC90", Offset = "0x799D090", VA = "0x18799DC90", Slot = "24")]
	public void DANICPOJFLE([Out] Vector3 LHCNGPBNPNA, [Out] Quaternion EGFLONDEOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x799C2C0", Offset = "0x799B6C0", VA = "0x18799C2C0")]
	private void AJNNHGLGIFI([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x799CFC0", Offset = "0x799C3C0", VA = "0x18799CFC0", Slot = "27")]
	public void BMIFKNIFAPG(float AGHJICHKCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x79AD550", Offset = "0x79AC950", VA = "0x1879AD550", Slot = "28")]
	public void KHAOBCJPFLD(float MHHDNBNPCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79A4580", Offset = "0x79A3980", VA = "0x1879A4580", Slot = "44")]
	public void GDFBOHMEFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD20", Offset = "0x79AD120", VA = "0x1879ADD20", Slot = "29")]
	public void KNAJLBFAJOB(bool POMJHHADHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79ADAE0", Offset = "0x79ACEE0", VA = "0x1879ADAE0", Slot = "30")]
	public HandLogicOffsets KKBBLCGCMPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x79B1150", Offset = "0x79B0550", VA = "0x1879B1150", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets NGNGONBEIJP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x799CB30", Offset = "0x799BF30", VA = "0x18799CB30")]
	private void ANFOKELBBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x79A4400", Offset = "0x79A3800", VA = "0x1879A4400")]
	private void GDACGMCJBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x79B30A0", Offset = "0x79B24A0", VA = "0x1879B30A0")]
	private void PCNGMPOHGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x79A3510", Offset = "0x79A2910", VA = "0x1879A3510")]
	private void FMAEEDDMLMI(GOICLPNEOHK DKKFKDBKPBP, bool LPODAIKDKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x79ACA20", Offset = "0x79ABE20", VA = "0x1879ACA20")]
	private void JJEGDMFEAFH(GOICLPNEOHK DKKFKDBKPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x79AA800", Offset = "0x79A9C00", VA = "0x1879AA800")]
	public Vector3 IEICPLHJBNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x79ACBB0", Offset = "0x79ABFB0", VA = "0x1879ACBB0")]
	private void JMJDPIDNCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x799F860", Offset = "0x799EC60", VA = "0x18799F860")]
	private void EBCKLLKPOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x79A2130", Offset = "0x79A1530", VA = "0x1879A2130")]
	private void ELKLHJLJLGN(IPMFCCDENKC AHJOOMILLAM, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x79B2EF0", Offset = "0x79B22F0", VA = "0x1879B2EF0")]
	private float PBIKJOOJPBJ([In] IPMFCCDENKC FGCBFMGNEPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x79B0E60", Offset = "0x79B0260", VA = "0x1879B0E60")]
	private int MNJBEFKNLJE([In] JENCNNKMBCI KMHJLJDBJDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x79AEF40", Offset = "0x79AE340", VA = "0x1879AEF40")]
	private void LLIOIDDFKNA(IPMFCCDENKC AHJOOMILLAM, bool DEBAKLCBFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x79AF690", Offset = "0x79AEA90", VA = "0x1879AF690")]
	private static void MCFKFOHFJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x79AA850", Offset = "0x79A9C50", VA = "0x1879AA850")]
	private static void IJKKCDJGJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x799D790", Offset = "0x799CB90", VA = "0x18799D790")]
	private float DADIPPHEMEP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x79A34E0", Offset = "0x79A28E0", VA = "0x1879A34E0")]
	private static int FHEPKOHMHKN(FEGHDIJNHDB BGDONNBGCJK, FEGHDIJNHDB DKEKGDBAIOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x79AD8A0", Offset = "0x79ACCA0", VA = "0x1879AD8A0", Slot = "40")]
	public IPMFCCDENKC KHFFMFAIDJN()
	{
		return default(IPMFCCDENKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x79AC1A0", Offset = "0x79AB5A0", VA = "0x1879AC1A0")]
	public void JDBLLGNGHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x79B0F40", Offset = "0x79B0340", VA = "0x1879B0F40")]
	private (bool, bool) NDOKLLGHICK()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x799E930", Offset = "0x799DD30", VA = "0x18799E930")]
	private (float, float) DINPKIENCNG([In] IPMFCCDENKC FGCBFMGNEPC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x79A81D0", Offset = "0x79A75D0", VA = "0x1879A81D0")]
	private void HPOMFKIONFI([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x799D970", Offset = "0x799CD70", VA = "0x18799D970")]
	private void DAKAAFPMCJI([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x79AA3E0", Offset = "0x79A97E0", VA = "0x1879AA3E0")]
	private void IDPKHCNIEFH([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ, AvatarFootSettings POLGNHDPMFD, bool BKBJHHBGNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x799E8B0", Offset = "0x799DCB0", VA = "0x18799E8B0")]
	private float DILBENBEGND()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x79AE2B0", Offset = "0x79AD6B0", VA = "0x1879AE2B0")]
	private void LHBDCAPCNBB(IPMFCCDENKC FGCBFMGNEPC, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x79A0470", Offset = "0x799F870", VA = "0x1879A0470")]
	private float EIENPBOLIAC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x79A2CE0", Offset = "0x79A20E0", VA = "0x1879A2CE0")]
	private void FGOKNHHGPJG([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x79A4110", Offset = "0x79A3510", VA = "0x1879A4110")]
	private void GBHIFMFILIH([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x79ACFA0", Offset = "0x79AC3A0", VA = "0x1879ACFA0")]
	private void KCAJMDMDAEK([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x799CD10", Offset = "0x799C110", VA = "0x18799CD10")]
	private void BFBBOBKOFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x79A46D0", Offset = "0x79A3AD0", VA = "0x1879A46D0")]
	private void GLBBNIEEKAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x79AFCC0", Offset = "0x79AF0C0", VA = "0x1879AFCC0")]
	private void MIFBINLNFLE([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x79AB680", Offset = "0x79AAA80", VA = "0x1879AB680")]
	private void INENEAIAIOG(LAKJPCFBEPA EEHDKGPICLG, IKSolverVR.Arm HKKHFBMJAJP, Transform BCJNILLIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x799CFD0", Offset = "0x799C3D0", VA = "0x18799CFD0")]
	private void BNDDEIICKIO(IPMFCCDENKC FGCBFMGNEPC, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x79B2BA0", Offset = "0x79B1FA0", VA = "0x1879B2BA0")]
	private void OMIKDBPIGBK(PGLBIBBFLBI AAPIHNKBPKJ, OHNJHAOHDGP EEHDKGPICLG, IKSolverVR.Arm HKKHFBMJAJP, float BBOBLKLPNLL, float PALNGILABJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x799E020", Offset = "0x799D420", VA = "0x18799E020")]
	private void DCOLEKIDCJF([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x799F980", Offset = "0x799ED80", VA = "0x18799F980")]
	protected void EFOJACJLMDG([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x79A01A0", Offset = "0x799F5A0", VA = "0x1879A01A0")]
	private void EHABDGLIPHP([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x79A0510", Offset = "0x799F910", VA = "0x1879A0510")]
	protected void ELBMKCJPMKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x79A38D0", Offset = "0x79A2CD0", VA = "0x1879A38D0")]
	private void GAOJHHAGCLH([In] IPMFCCDENKC FGCBFMGNEPC, [In] LCDLJBIOFLA GGODIKNKJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x799CB60", Offset = "0x799BF60", VA = "0x18799CB60")]
	private void BACMGDCNAFG(IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x799C050", Offset = "0x799B450", VA = "0x18799C050")]
	private void AEAEANPFOBB([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x79A9DC0", Offset = "0x79A91C0", VA = "0x1879A9DC0")]
	private Vector3 IDCCJEHOHGH([In] IPMFCCDENKC FGCBFMGNEPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x79A3800", Offset = "0x79A2C00", VA = "0x1879A3800")]
	private void GAOJANPGLDB([In] IPMFCCDENKC FGCBFMGNEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x799FD50", Offset = "0x799F150", VA = "0x18799FD50")]
	private float EGGGGPBPFKH(float LOFFJDLPNPM, [In] IPMFCCDENKC FGCBFMGNEPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x79A2B90", Offset = "0x79A1F90", VA = "0x1879A2B90")]
	private void FFHNIOPFFPD(float LOFFJDLPNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x799F170", Offset = "0x799E570", VA = "0x18799F170")]
	private void EAPDBAMHMAC([In] IPMFCCDENKC FGCBFMGNEPC, LCDLJBIOFLA GGODIKNKJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x799C370", Offset = "0x799B770", VA = "0x18799C370")]
	private float AMICHLIELAO([In] IPMFCCDENKC AHJOOMILLAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x79AC220", Offset = "0x79AB620", VA = "0x1879AC220")]
	private void JEDIJAGBGLC(IPMFCCDENKC FGCBFMGNEPC, LCDLJBIOFLA GGODIKNKJND, Vector3 NFIPHNPCEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x79AD3A0", Offset = "0x79AC7A0", VA = "0x1879AD3A0")]
	private static void KCMKKGNDPLP(Transform NIBJBBEPHBE, Quaternion PNEDBEMJDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x79AF9C0", Offset = "0x79AEDC0", VA = "0x1879AF9C0")]
	private void MFEHHEGCGLN([In] IPMFCCDENKC IJLCCNHPLAB, [In] JENCNNKMBCI KMHJLJDBJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x79B3D60", Offset = "0x79B3160", VA = "0x1879B3D60")]
	private void PFCCMPHGMFP([In] IPMFCCDENKC IJLCCNHPLAB, [In] JENCNNKMBCI KMHJLJDBJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x79A4930", Offset = "0x79A3D30", VA = "0x1879A4930")]
	private void GMJCNJHLJGJ(float EFGIFCLPAJL, [In] IPMFCCDENKC AHJOOMILLAM, float HJBHPJINPCF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x79B3590", Offset = "0x79B2990", VA = "0x1879B3590")]
	private float PEKMCMJCINK([In] IPMFCCDENKC AHJOOMILLAM, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x79B1990", Offset = "0x79B0D90", VA = "0x1879B1990")]
	private void NLGAKDECBOB([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x79B1CC0", Offset = "0x79B10C0", VA = "0x1879B1CC0")]
	private void NMKLDPFAOAO([In] IPMFCCDENKC AHJOOMILLAM, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x79ABDD0", Offset = "0x79AB1D0", VA = "0x1879ABDD0")]
	private void JCBIJLJGGHK([In] IPMFCCDENKC AHJOOMILLAM, float CANMHHDEKKJ, float KLKEFGFJNIB, Vector3 FFKFDNOFCKI, float HJBHPJINPCF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x79A77D0", Offset = "0x79A6BD0", VA = "0x1879A77D0")]
	private void HIPKMJFFNEL(IPMFCCDENKC AHJOOMILLAM, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x79B1700", Offset = "0x79B0B00", VA = "0x1879B1700")]
	private void NILHBIFNNBF(IPMFCCDENKC FGCBFMGNEPC, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x79A31A0", Offset = "0x79A25A0", VA = "0x1879A31A0")]
	private void FHCNFHPBAAB(IPMFCCDENKC AHJOOMILLAM, AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79B2860", Offset = "0x79B1C60", VA = "0x1879B2860")]
	public void ODPDBACAPGH([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x79AFE60", Offset = "0x79AF260", VA = "0x1879AFE60")]
	public void MIKJHBDKNAM([In] IPMFCCDENKC FGCBFMGNEPC, [In] AvatarFullBodyConfiguration ICLMPPLIKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x799C090", Offset = "0x799B490", VA = "0x18799C090")]
	[CompilerGenerated]
	internal static void AFOPIKKFNIK(Transform BHCEDEKBMHE, IKSolverVR.Arm HKKHFBMJAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x79B34E0", Offset = "0x79B28E0", VA = "0x1879B34E0")]
	[CompilerGenerated]
	internal static void PDDJMCDLOFC(Vector3 NAELKIJFKCO, Vector3 HCBBPDLEKAJ, PKGHFDDBFDK P_2, MIFFFLAKFHH P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x79B4AB0", Offset = "0x79B3EB0", VA = "0x1879B4AB0")]
	[CompilerGenerated]
	internal static void PFMCDJMNEMH(PIEBMAAAMJP HLJIHKJDCAE, PIEBMAAAMJP NHLPCJFKDIP, Vector3 HKFJBGMNNNA, float MHFONFLBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79B4CB0", Offset = "0x79B40B0", VA = "0x1879B4CB0")]
	[CompilerGenerated]
	internal static bool PNAKJGFODPL(IKSolverVR.Arm HKKHFBMJAJP, HKDFDNLBIHE AIINFJBAELC, float KHIIKKJNEJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD70", Offset = "0x79AD170", VA = "0x1879ADD70")]
	[CompilerGenerated]
	internal static float KNPKNPAJEBD(Vector3 IHOENNDIHKN, Vector3 AAOCLFCJLOM, Vector3 AJPCDPEILEP, IPMFCCDENKC AHJOOMILLAM, AvatarFullBodyConfiguration ICLMPPLIKCJ, float IALPEJIGIPD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class NLLNNEEDDJM : AKEMIJCAMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Dictionary<string, JIEEMEHOAEF> MELONGFKFKI;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x79C1110", Offset = "0x79C0510", VA = "0x1879C1110")]
	[ACPGCKDGGJH.EHOIKNIBKMA]
	internal static void EOOENJGLFKJ(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x79C0DB0", Offset = "0x79C01B0", VA = "0x1879C0DB0", Slot = "4")]
	public JIEEMEHOAEF AOLCFJEIHFI(string OJLBFIDHBAI, AvatarSystemConfiguration BOICKNJEBMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x79C11F0", Offset = "0x79C05F0", VA = "0x1879C11F0", Slot = "5")]
	public void PIGBLBMADOH(string OJLBFIDHBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79C0FD0", Offset = "0x79C03D0", VA = "0x1879C0FD0", Slot = "6")]
	public string EKCOJLCKHPN(string MLJFCGJNDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x79C1180", Offset = "0x79C0580", VA = "0x1879C1180")]
	private string FDEOPIJHEFA(string MLJFCGJNDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x79C13D0", Offset = "0x79C07D0", VA = "0x1879C13D0")]
	public NLLNNEEDDJM()
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
		public class EFCFMEJOPDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private Dictionary<string, Transform> KPPMNKACPML;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool GHONCNALJFE
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x79BBFE0", Offset = "0x79BB3E0", VA = "0x1879BBFE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x79BBEB0", Offset = "0x79BB2B0", VA = "0x1879BBEB0")]
			public void AOEMINKJKFF(VRIK LLBMEKINOII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
			public void GIKHIDJHDCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x79BC020", Offset = "0x79BB420", VA = "0x1879BC020")]
			public void ICMDEPLACPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x79BC070", Offset = "0x79BB470", VA = "0x1879BC070")]
			public EFCFMEJOPDO()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[HJIOCNMHEJP(ANEAJGIOFML.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[HAKPMKJKBJL(ANEAJGIOFML.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly EFCFMEJOPDO HLOHFACFOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private NJIADMPGABJ OLPLIOPEFKH;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x79B9C60", Offset = "0x79B9060", VA = "0x1879B9C60")]
		private void ENMMELFAOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x79B9C10", Offset = "0x79B9010", VA = "0x1879B9C10")]
		private bool AMPBPNGHKEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x79B9F40", Offset = "0x79B9340", VA = "0x1879B9F40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x79B9FB0", Offset = "0x79B93B0", VA = "0x1879B9FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x79B9F50", Offset = "0x79B9350", VA = "0x1879B9F50")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79BA220", Offset = "0x79B9620", VA = "0x1879BA220")]
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
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x79BEDC0", Offset = "0x79BE1C0", VA = "0x1879BEDC0")]
			public void HGEPFBBIJLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x79BEEA0", Offset = "0x79BE2A0", VA = "0x1879BEEA0")]
			public (float, float) NGDOAOKPKLO(Animator ABCGOCBPJOG, AnimatorStateInfo PIBNJHJGNAM)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x79BF3E0", Offset = "0x79BE7E0", VA = "0x1879BF3E0")]
		public void HGEPFBBIJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x79BF1D0", Offset = "0x79BE5D0", VA = "0x1879BF1D0")]
		public (float, float) BCOMCGBFKAM(Animator ABCGOCBPJOG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x79BEFE0", Offset = "0x79BE3E0", VA = "0x1879BEFE0")]
		private (float, float) AAPOEDPAAPN(Animator ABCGOCBPJOG, AnimatorStateInfo PIBNJHJGNAM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x79BF5D0", Offset = "0x79BE9D0", VA = "0x1879BF5D0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x79C0990", Offset = "0x79BFD90", VA = "0x1879C0990", Slot = "4")]
		public override void OnStateEnter(Animator ABCGOCBPJOG, AnimatorStateInfo PIBNJHJGNAM, int BAAFKKKEKDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x79C0B00", Offset = "0x79BFF00", VA = "0x1879C0B00")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal abstract class FEBLBDONKIA<TInput, TOutput> : NJIHIJAJGGC<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected readonly IEDDOEABFGN GKILNJBFBEM;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47D5630", Offset = "0x47D4A30", VA = "0x1847D5630")]
	protected FEBLBDONKIA(IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput ILOIKAMJPOD(TInput EOMFNMMGCEC, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x47D5590", Offset = "0x47D4990", VA = "0x1847D5590", Slot = "5")]
	public bool KFKINMPCGCP(TInput EOMFNMMGCEC, [Out] TOutput? APLCGCDLEGH, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[IJOMDGJLMLC]
public static class IBMGIJOLGHI
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly Regex GHIPDDFPJBA;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x79BF890", Offset = "0x79BEC90", VA = "0x1879BF890")]
	public static GHPECODJJJM GAOKKJKIHDH(BKGBLAEFKKI KGGJIBECFPC, BCAJBMEKGPP LPGNPFCHFFD, Guid? LHMBLLKGLHN, Color? HINJJOAEGGC, MJGMDPCOPJP DFKGNLKKCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x79BF5E0", Offset = "0x79BE9E0", VA = "0x1879BF5E0")]
	public static BBFALMJKFCO DABEGCKEGHA(GHPECODJJJM AOFGGGKINCN)
	{
		return default(BBFALMJKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x37226A0", Offset = "0x3721AA0", VA = "0x1837226A0")]
	internal static TModern? JCMDILKEEGB<TModern>(string? EOMFNMMGCEC, NHOAKMKCFGJ<TModern> OBHKFOKBLHH, IEDDOEABFGN GKILNJBFBEM, JCDDBLKOJDF AHKLOPDFKOL, TModern AFHJDGBGHBE) where TModern : struct, KGIFCIOKMHM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3721EC0", Offset = "0x37212C0", VA = "0x183721EC0")]
	internal static PHONKGGOGKM AIBCEHLNFGG<TModern>(string? EOMFNMMGCEC, NHOAKMKCFGJ<TModern> OBHKFOKBLHH, IEDDOEABFGN GKILNJBFBEM, JCDDBLKOJDF AHKLOPDFKOL, TModern AFHJDGBGHBE) where TModern : struct, KGIFCIOKMHM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x79BF740", Offset = "0x79BEB40", VA = "0x1879BF740")]
	internal static List<PDJKCBDEPAF> DMMHPLIOKPA(IEnumerable<FHCCNMELIEH>? GFHJMMAHJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3723CF0", Offset = "0x37230F0", VA = "0x183723CF0")]
	internal static string NGOOBFLOIAD<TModern>(TModern EOMFNMMGCEC, NHOAKMKCFGJ<TModern> OBHKFOKBLHH, IEDDOEABFGN GKILNJBFBEM) where TModern : KGIFCIOKMHM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class KGIOLMLAFJE : KNDFIHDMAKA
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NJIHIJAJGGC<CAJLLMCBOMK, BJFLFCHJINB> ONJOMNLAHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NJIHIJAJGGC<LCBFOIKMINJ, HDOFECNGONC> FGFDPCLDHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NJIHIJAJGGC<LCBFOIKMINJ, HDOFECNGONC> HEGOJLEKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public EGJHAHECEBJ HANFGAOOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GLLEKKNKLFP CGJCHFNBCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x79C0060", Offset = "0x79BF460", VA = "0x1879C0060")]
	[ACPGCKDGGJH.EHOIKNIBKMA.DOIDFDFNIIB]
	[UsedImplicitly]
	internal static void HDGDIFJKKGM(NPCGGDCACLM INELJPKBMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x79C00D0", Offset = "0x79BF4D0", VA = "0x1879C00D0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KGIOLMLAFJE([MGCCDFKFGBG("UnitySerialization")] KENMAHBKKHP FNDOFDGFFCC, [MGCCDFKFGBG(null)] MBKECGGBKFN PBEPNNPJPBL, [MGCCDFKFGBG(null)] IEDDOEABFGN GKILNJBFBEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum LMPEIDGLIOI
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CDMPOOFGGFI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x79BA300", Offset = "0x79B9700", VA = "0x1879BA300")]
	public CDMPOOFGGFI(string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x79BA330", Offset = "0x79B9730", VA = "0x1879BA330")]
	public CDMPOOFGGFI(string FGEBHLNNMNH, Exception BNECGNPLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x79BA360", Offset = "0x79B9760", VA = "0x1879BA360")]
	public CDMPOOFGGFI(LMPEIDGLIOI PEHFPIIENIB, string FGEBHLNNMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x79BA390", Offset = "0x79B9790", VA = "0x1879BA390")]
	public CDMPOOFGGFI(LMPEIDGLIOI PEHFPIIENIB, string FGEBHLNNMNH, Exception BNECGNPLEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal abstract class DELHEFPPCGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly KENMAHBKKHP FNDOFDGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	protected readonly MBKECGGBKFN PBEPNNPJPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	protected readonly IEDDOEABFGN GKILNJBFBEM;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x79BBD30", Offset = "0x79BB130", VA = "0x1879BBD30")]
	protected DELHEFPPCGN(KENMAHBKKHP FNDOFDGFFCC, MBKECGGBKFN PBEPNNPJPBL, IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x79BA8F0", Offset = "0x79B9CF0", VA = "0x1879BA8F0")]
	protected string GJBJJBBINJL(BJFLFCHJINB NMNEBNPOIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x79BA3D0", Offset = "0x79B97D0", VA = "0x1879BA3D0")]
	protected string EEGFABPHKNE(BJFLFCHJINB NMNEBNPOIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79BA5C0", Offset = "0x79B99C0", VA = "0x1879BA5C0")]
	private AvatarOutfitSelectionData GAOKKJKIHDH(GHPECODJJJM EBEKPKOFICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x79BBBF0", Offset = "0x79BAFF0", VA = "0x1879BBBF0")]
	private static AvatarCustomizationSettingsData.AnchorParams MCODADIHJEM(AOFLICKOANP? FNMHKMFPHLM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NJIHIJAJGGC<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput ILOIKAMJPOD(TInput EOMFNMMGCEC, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFKINMPCGCP(TInput EOMFNMMGCEC, [Out] TOutput? APLCGCDLEGH, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KNDFIHDMAKA
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NJIHIJAJGGC<CAJLLMCBOMK, BJFLFCHJINB> ONJOMNLAHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	NJIHIJAJGGC<LCBFOIKMINJ, HDOFECNGONC> HEGOJLEKAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	EGJHAHECEBJ HANFGAOOCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum JCDDBLKOJDF
{
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GLLEKKNKLFP
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DFEKFILLFKI PEGKBLBFNLH(BJFLFCHJINB AOFGGGKINCN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EGJHAHECEBJ
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCBFOIKMINJ PEGKBLBFNLH(BJFLFCHJINB AOFGGGKINCN, int PJOBJMPCFKF, string? KCCMEIDBNGP, string? EDFBPAOOBLD, ALNGOLLGNAJ EMAIMHFDOKO, List<PDJKCBDEPAF>? MIKADHKHCBG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[IJOMDGJLMLC]
internal class AOPDIAEBGCE : FEBLBDONKIA<CAJLLMCBOMK, BJFLFCHJINB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly MBKECGGBKFN PBEPNNPJPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly FCBANGOHEME KMNLAOJPIBC;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x79B9000", Offset = "0x79B8400", VA = "0x1879B9000")]
	public AOPDIAEBGCE(KENMAHBKKHP FNDOFDGFFCC, MBKECGGBKFN PBEPNNPJPBL, IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79B8D50", Offset = "0x79B8150", VA = "0x1879B8D50", Slot = "6")]
	public override BJFLFCHJINB ILOIKAMJPOD(CAJLLMCBOMK EOMFNMMGCEC, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[RecRoom.NoEngine.Common.Preserve]
internal class MCGIMMPHIPL : KENMAHBKKHP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class MHAEAMLLPIG : JsonConverter<PHONKGGOGKM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x79C08B0", Offset = "0x79BFCB0", VA = "0x1879C08B0", Slot = "9")]
		public override void WriteJson(JsonWriter CELBHBDDEKA, PHONKGGOGKM? OOEMJLHLIHJ, JsonSerializer EKNFDDNNCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x79C0790", Offset = "0x79BFB90", VA = "0x1879C0790", Slot = "10")]
		public override PHONKGGOGKM ReadJson(JsonReader PABEDPKBAJJ, Type ACOKEOAFGJO, PHONKGGOGKM? JKJJEIMNCHD, bool LGCMPDKJDBP, JsonSerializer EKNFDDNNCCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x79C0950", Offset = "0x79BFD50", VA = "0x1879C0950")]
		public MHAEAMLLPIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KCKCEILIILE : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool LDFEILLDEBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x79BFF20", Offset = "0x79BF320", VA = "0x1879BFF20", Slot = "5")]
		public override object ReadJson(JsonReader PABEDPKBAJJ, Type ACOKEOAFGJO, object? JKJJEIMNCHD, JsonSerializer EKNFDDNNCCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x79BFB40", Offset = "0x79BEF40", VA = "0x1879BFB40", Slot = "6")]
		public override bool CanConvert(Type ACOKEOAFGJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x79BFF80", Offset = "0x79BF380", VA = "0x1879BFF80", Slot = "4")]
		public override void WriteJson(JsonWriter CELBHBDDEKA, object? OOEMJLHLIHJ, JsonSerializer EKNFDDNNCCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x79BFD20", Offset = "0x79BF120", VA = "0x1879BFD20")]
		private static bool MLJHNPGKMBJ(object OOEMJLHLIHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public KCKCEILIILE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly JsonSerializerSettings MMJOHIFPIPH;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x79C0630", Offset = "0x79BFA30", VA = "0x1879C0630")]
	internal MCGIMMPHIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37B5D30", Offset = "0x37B5130", VA = "0x1837B5D30", Slot = "4")]
	public string PCDMIGOHENG<T>(T KLANNNFBLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37B5CA0", Offset = "0x37B50A0", VA = "0x1837B5CA0", Slot = "5")]
	public T ADEFOKDBGHJ<T>(string OOEMJLHLIHJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[RecRoom.NoEngine.Common.Preserve]
internal class OIMKOPEMPAB : KENMAHBKKHP
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38B2300", Offset = "0x38B1700", VA = "0x1838B2300", Slot = "4")]
	public string PCDMIGOHENG<T>(T KLANNNFBLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38B2280", Offset = "0x38B1680", VA = "0x1838B2280", Slot = "5")]
	public T ADEFOKDBGHJ<T>(string OOEMJLHLIHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public OIMKOPEMPAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[IJOMDGJLMLC]
internal class FCBANGOHEME : FEBLBDONKIA<LCBFOIKMINJ, HDOFECNGONC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly KENMAHBKKHP FNDOFDGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly MBKECGGBKFN PBEPNNPJPBL;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x79BE590", Offset = "0x79BD990", VA = "0x1879BE590")]
	public FCBANGOHEME(KENMAHBKKHP FNDOFDGFFCC, MBKECGGBKFN PBEPNNPJPBL, IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x79BD7C0", Offset = "0x79BCBC0", VA = "0x1879BD7C0", Slot = "6")]
	public override HDOFECNGONC ILOIKAMJPOD(LCBFOIKMINJ EOMFNMMGCEC, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x79BDDF0", Offset = "0x79BD1F0", VA = "0x1879BDDF0")]
	internal void NIKMMJMMFNM(string JDPHCHHMPEM, BJFLFCHJINB NMNEBNPOIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x79BE0B0", Offset = "0x79BD4B0", VA = "0x1879BE0B0")]
	public IEnumerable<GHPECODJJJM> OMDBEOMDLLG(string BFBDPGAEANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79BE160", Offset = "0x79BD560", VA = "0x1879BE160")]
	private IEnumerable<GHPECODJJJM> OPGBGEOLKOO(string BFBDPGAEANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x79BD350", Offset = "0x79BC750", VA = "0x1879BD350")]
	internal IEnumerable<GHPECODJJJM> GOEOHGCBBBI(string BFBDPGAEANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x79BC420", Offset = "0x79BB820", VA = "0x1879BC420")]
	private GHPECODJJJM APJHMGFGPML(AvatarOutfitSelectionData MJMCIJNAHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x79BCAB0", Offset = "0x79BBEB0", VA = "0x1879BCAB0")]
	private void DKHIFGPHPIP(AvatarCustomizationSettingsData ALOEGCEHKAE, BJFLFCHJINB NMNEBNPOIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x79BC100", Offset = "0x79BB500", VA = "0x1879BC100")]
	private GHPECODJJJM APJHMGFGPML(string ABIHMIBAMFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x79BC7B0", Offset = "0x79BBBB0", VA = "0x1879BC7B0")]
	internal static (MJGMDPCOPJP, string, string) BHJMMMGOIKN(string ABIHMIBAMFD, IEDDOEABFGN GKILNJBFBEM)
	{
		return default((MJGMDPCOPJP, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x79BDBF0", Offset = "0x79BCFF0", VA = "0x1879BDBF0")]
	private JEPNDKFIAON? LKGKEPLMPAF(string? FIAGFFPOAHP, Vector2 LNDLINIPIHN, float IDAOOBNOFGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x79BDF50", Offset = "0x79BD350", VA = "0x1879BDF50")]
	private static AOFLICKOANP NKLEAOHHHGM(AvatarCustomizationSettingsData.AnchorParams BACHKPBLJFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[IJOMDGJLMLC]
internal class FFFIEIPKLOL : DELHEFPPCGN, GLLEKKNKLFP
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x79BBD30", Offset = "0x79BB130", VA = "0x1879BBD30")]
	public FFFIEIPKLOL(KENMAHBKKHP FNDOFDGFFCC, MBKECGGBKFN PBEPNNPJPBL, IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x79BEA10", Offset = "0x79BDE10", VA = "0x1879BEA10", Slot = "4")]
	public DFEKFILLFKI PEGKBLBFNLH(BJFLFCHJINB AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x79BE6D0", Offset = "0x79BDAD0", VA = "0x1879BE6D0")]
	private string AHFBMEFEJLA(BJFLFCHJINB NMNEBNPOIJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x79BE7D0", Offset = "0x79BDBD0", VA = "0x1879BE7D0")]
	private string ELHFOCEDDPM(GHPECODJJJM EBEKPKOFICL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IJOMDGJLMLC]
internal class ADLDFOEONAF : FEBLBDONKIA<LCBFOIKMINJ, HDOFECNGONC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly KENMAHBKKHP FNDOFDGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly NJIHIJAJGGC<LCBFOIKMINJ, HDOFECNGONC> DNMGNGEPAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x79B87B0", Offset = "0x79B7BB0", VA = "0x1879B87B0")]
	public ADLDFOEONAF(NJIHIJAJGGC<LCBFOIKMINJ, HDOFECNGONC> DNMGNGEPAHJ, IEDDOEABFGN GKILNJBFBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x79B8380", Offset = "0x79B7780", VA = "0x1879B8380", Slot = "6")]
	public override HDOFECNGONC ILOIKAMJPOD(LCBFOIKMINJ EOMFNMMGCEC, [Out] IReadOnlyList<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IJOMDGJLMLC]
internal class ANFMCCBHPFJ : EGJHAHECEBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly KENMAHBKKHP FNDOFDGFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly GLLEKKNKLFP LKLIFGFDPFD;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x79B8C60", Offset = "0x79B8060", VA = "0x1879B8C60")]
	public ANFMCCBHPFJ(GLLEKKNKLFP LKLIFGFDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x79B88B0", Offset = "0x79B7CB0", VA = "0x1879B88B0", Slot = "4")]
	public LCBFOIKMINJ PEGKBLBFNLH(BJFLFCHJINB AOFGGGKINCN, int PJOBJMPCFKF, string? KCCMEIDBNGP, string? EDFBPAOOBLD, ALNGOLLGNAJ EMAIMHFDOKO, List<PDJKCBDEPAF>? MIKADHKHCBG)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x79B9280", Offset = "0x79B8680", VA = "0x1879B9280")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NDILHLCMPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x79C0B80", Offset = "0x79BFF80", VA = "0x1879C0B80")]
	public static BBFALMJKFCO ILOIKAMJPOD(this DBJFFFOILEK AOFGGGKINCN)
	{
		return default(BBFALMJKFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x79C0C90", Offset = "0x79C0090", VA = "0x1879C0C90")]
	public static DBJFFFOILEK PEGKBLBFNLH(this BBFALMJKFCO BPFCFAJBNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x79C0B20", Offset = "0x79BFF20", VA = "0x1879C0B20")]
	public static bool IEHAEPMEMPC(this BBFALMJKFCO BPFCFAJBNGP)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5AD16A0", Offset = "0x5AD0AA0", VA = "0x185AD16A0")]
			public AnchorParams(Vector2 LJELBPGLBJP, Vector3 FBFBJHOBCFC, Vector3 IKMMHNMDBKA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x79B91D0", Offset = "0x79B85D0", VA = "0x1879B91D0")]
			internal AOFLICKOANP PEGKBLBFNLH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private AELCGAALLCD useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x79B9AB0", Offset = "0x79B8EB0", VA = "0x1879B9AB0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x496EFC0", Offset = "0x496E3C0", VA = "0x18496EFC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC628F0", Offset = "0xC61CF0", VA = "0x180C628F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xECB0F0", Offset = "0xECA4F0", VA = "0x180ECB0F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1244090", Offset = "0x1243490", VA = "0x181244090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x79B9B60", Offset = "0x79B8F60", VA = "0x1879B9B60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9D9490", Offset = "0x9D8890", VA = "0x1809D9490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xBD1C50", Offset = "0xBD1050", VA = "0x180BD1C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xBD1C10", Offset = "0xBD1010", VA = "0x180BD1C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x9C9440", Offset = "0x9C8840", VA = "0x1809C9440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x79B9BA0", Offset = "0x79B8FA0", VA = "0x1879B9BA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xDF2870", Offset = "0xDF1C70", VA = "0x180DF2870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x104E670", Offset = "0x104DA70", VA = "0x18104E670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x16C8680", Offset = "0x16C7A80", VA = "0x1816C8680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9CD860", Offset = "0x9CCC60", VA = "0x1809CD860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x9CD820", Offset = "0x9CCC20", VA = "0x1809CD820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x21EB960", Offset = "0x21EAD60", VA = "0x1821EB960")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xE1B920", Offset = "0xE1AD20", VA = "0x180E1B920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA00E20", Offset = "0xA00220", VA = "0x180A00E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA00E80", Offset = "0xA00280", VA = "0x180A00E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B60", Offset = "0x9D4F60", VA = "0x1809D5B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C00", Offset = "0x9D5000", VA = "0x1809D5C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AB0", Offset = "0x9D4EB0", VA = "0x1809D5AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AC0", Offset = "0x9D4EC0", VA = "0x1809D5AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C70", Offset = "0x9D5070", VA = "0x1809D5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C20", Offset = "0x9D5020", VA = "0x1809D5C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xBB23C0", Offset = "0xBB17C0", VA = "0x180BB23C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x12684B0", Offset = "0x12678B0", VA = "0x1812684B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x9D5C80", Offset = "0x9D5080", VA = "0x1809D5C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9D5B70", Offset = "0x9D4F70", VA = "0x1809D5B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC9B070", Offset = "0xC9A470", VA = "0x180C9B070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xE0CC00", Offset = "0xE0C000", VA = "0x180E0CC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E60", Offset = "0x9D3260", VA = "0x1809D3E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9D3EC0", Offset = "0x9D32C0", VA = "0x1809D3EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xBE6830", Offset = "0xBE5C30", VA = "0x180BE6830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xE18B10", Offset = "0xE17F10", VA = "0x180E18B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xC453A0", Offset = "0xC447A0", VA = "0x180C453A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xC42F40", Offset = "0xC42340", VA = "0x180C42F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public AELCGAALLCD UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xECF8D0", Offset = "0xECECD0", VA = "0x180ECF8D0")]
			get
			{
				return default(AELCGAALLCD);
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xED0700", Offset = "0xECFB00", VA = "0x180ED0700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xED1800", Offset = "0xED0C00", VA = "0x180ED1800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xBA3AC0", Offset = "0xBA2EC0", VA = "0x180BA3AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x79B9B80", Offset = "0x79B8F80", VA = "0x1879B9B80")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x79B9BC0", Offset = "0x79B8FC0", VA = "0x1879B9BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x79B9710", Offset = "0x79B8B10", VA = "0x1879B9710")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public MJGMDPCOPJP BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private OHPFOIBFOHH? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x79B9BE0", Offset = "0x79B8FE0", VA = "0x1879B9BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
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
